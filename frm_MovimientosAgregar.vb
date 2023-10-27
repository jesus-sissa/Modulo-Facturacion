Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_MovimientosAgregar

    Dim dt_Importes As DataTable

    Private Sub frm_MovimientosAgregar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()

            Case Keys.F3
                If btn_Agregar.Enabled Then btn_Agregar_Click(btn_Agregar, Nothing)

            Case Keys.F4
                If btn_Eliminar.Enabled Then btn_Eliminar_Click(btn_Eliminar, Nothing)

            Case Keys.F5
                If btn_Guardar.Enabled Then btn_Guardar_Click(btn_Guardar, Nothing)
        End Select
    End Sub

    Private Sub frm_MovimientosAgregar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Fecha.Value = Now.Date

        lsv_Remisiones.Columns.Clear()
        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Cia Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("Status")
        lsv_Remisiones.Columns.Add("UsrValida")
        lsv_Remisiones.Columns.Add("FechaV")

        cmb_Precio.AgregaParametro("@Id_Cliente", 0, 1)
        cmb_Cuota.AgregaParametro("@Id_Cliente", 0, 1)
        cmb_Cliente.Actualizar()

        cmb_Cuota.Actualizar()
        cmb_EnvasesE.Actualizar()
        cmb_Kilometraje.Actualizar()
        cmb_Ruta.Actualizar()

        cmb_Tipo.AgregarItem("R", "RECOLECCION")
        cmb_Tipo.AgregarItem("E", "ENTREGA")

        dt_Importes = fn_RemisionDetalle_Read(0)
        dgv_Importes.DataSource = dt_Importes
        Call FormatoGrid()
        tbx_Total.Text = "0.00"

    End Sub

    Sub Colores_Remisiones()
        For I As Integer = 0 To lsv_Remisiones.Items.Count - 1
            If lsv_Remisiones.Items(I).SubItems(3).Text = "VALIDADO" Then
                lsv_Remisiones.Items(I).ForeColor = Color.Green
            End If
        Next
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Remisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged
        Call Mostrar_Importes()
        If lsv_Remisiones.SelectedItems.Count > 0 And dgv_Importes.Rows.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Sub Mostrar_Importes()
        If dt_Importes IsNot Nothing Then
            dt_Importes.Rows.Clear()
        End If
        If lsv_Remisiones.SelectedItems.Count > 0 Then
            dt_Importes = fn_RemisionDetalle_Read(lsv_Remisiones.SelectedItems(0).Tag)
            dgv_Importes.DataSource = dt_Importes
            Call FormatoGrid()
            Call CalculaImporteTotal()
            If dgv_Importes.Rows.Count > 0 Then
                'btn_ValidarRemision.Enabled = True
            Else
                'btn_ValidarRemision.Enabled = False
            End If
        End If
    End Sub

    Private Sub FormatoGrid()
        If dgv_Importes.Columns.Count = 0 Then Exit Sub

        With dgv_Importes.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(dgv_Importes.Font, FontStyle.Bold)
        End With

        With dgv_Importes
            '.Name = "dgv_Importes"

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            '.GridColor = Color.Black
            .RowHeadersVisible = False

            .Columns(0).Name = "Id_Moneda"
            .Columns(0).Visible = False
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(1).Name = "Moneda"
            .Columns(1).Width = 70
            .Columns(1).ReadOnly = True
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(2).Name = "Importe Efectivo"
            .Columns(2).ReadOnly = False
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Format = "N2"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).Name = "Importe Documentos"
            .Columns(3).ReadOnly = False
            .Columns(3).Width = 100
            .Columns(3).DefaultCellStyle.Format = "N2"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(4).Name = "TipoCambio"
            .Columns(4).ReadOnly = True
            .Columns(4).Width = 80
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            .MultiSelect = False
        End With
    End Sub

    Private Sub CalculaImporteTotal()
        If dt_Importes.Rows.Count > 0 Then
            Dim DR_lc As DataRow
            Dim Efectivo As Decimal = 0
            Dim Documentos As Decimal = 0
            For Each DR_lc In dt_Importes.Rows
                Efectivo += DR_lc(2).ToString * DR_lc(4).ToString
                Documentos += DR_lc(3).ToString * DR_lc(4).ToString
            Next
            tbx_Total.Text = Format(Efectivo + Documentos, "c")
        Else
            tbx_Total.Text = "0.00"
        End If
    End Sub

    Private Sub dgv_Importes_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Importes.CellValueChanged
        CalculaImporteTotal()
    End Sub

    Private Sub dgv_Importes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Importes.DataError
        MsgBox("Cantidad no válida, Capture un dato numérico.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub tbx_Numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            'Call Mostrar()
        End If
    End Sub

    Sub Limpiar()
        lsv_Remisiones.Items.Clear()
        If dt_Importes IsNot Nothing Then
            dt_Importes.Rows.Clear()
        End If
        cmb_Cliente.SelectedValue = 0
        cmb_Precio.SelectedValue = 0
        cmb_Cuota.SelectedValue = 0
        cmb_EnvasesE.SelectedValue = 0
        cmb_Kilometraje.SelectedValue = 0
        cmb_Ruta.SelectedValue = 0
        btn_Agregar.Enabled = True
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim frm As New frm_AgregaRemision
        Dim Id_Remision As Long
        frm.Id_Movimiento = 0
        frm.Origen = 2
        frm.ShowDialog()
        Id_Remision = frm.tbx_Remision.Tag
        Call Mostrar_Detalle(Id_Remision)
        If lsv_Remisiones.Items.Count > 0 Then
            btn_Agregar.Enabled = False
        Else
            btn_Agregar.Enabled = True
        End If
    End Sub

    Sub Mostrar_Detalle(ByVal Id_Remision As Long)
        lsv_Remisiones.Items.Clear()
        'llemar las remisiones del movimiento seleccionado
        If Not fn_Remision_Consultar(Id_Remision, lsv_Remisiones) Then
            MsgBox("Ocurrió un error al intentar consultar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_Remisiones.Columns(1).TextAlign = HorizontalAlignment.Right
        lsv_Remisiones.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Remisiones.Columns(3).TextAlign = HorizontalAlignment.Right
        If lsv_Remisiones.Items.Count > 0 Then
            lsv_Remisiones.Items(0).Selected = True
            Call Mostrar_Importes()
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Solo eliminar la relación en Cat_MovimientosD
        lsv_Remisiones.SelectedItems(0).Remove()
        'MsgBox("Se Eliminó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        btn_Eliminar.Enabled = False

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Remisiones As Integer = 0, Envases As Integer = 0, Importe As Decimal = 0, Miles As Decimal = 0, EnvasesE As Integer = 0, Kilometros As Integer = 0
        Dim Efectivo As Decimal = 0, Documentos As Decimal = 0
        Dim Miles_Scosto As Decimal = 0
        Dim Envases_Scosto As Integer = 0
        Dim CantidadXunidad As Integer = 1000
        Dim Redondeado As String = "S"
        Dim Cobra_Documentos As String = "S"
        Dim ImporteTotal As Decimal = 0

        If tbx_CantidadKM.Text = "" Then tbx_CantidadKM.Text = 0
        If cmb_Tipo.SelectedIndex = 0 Then
            MsgBox("Seleccione el Tipo de Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If
        If lsv_Remisiones.Items.Count = 0 Then
            MsgBox("Debe agregar por lo menos una Remisión.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)

            Exit Sub
        End If
        Dim dt As DataTable
        Dim Id_Movimiento As Long = 0
        'Update de los IDs a Cat_Movimientos
        Id_Movimiento = Cn_Facturacion.fn_Movimientos_Create(cmb_Tipo.SelectedValue, tbx_Hora.Text, cmb_Cliente.SelectedValue, cmb_Precio.SelectedValue, cmb_Cuota.SelectedValue, cmb_EnvasesE.SelectedValue, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue, cmb_Precio.Tag, 1, lsv_Remisiones.SelectedItems(0).SubItems(2).Text, lsv_Remisiones.SelectedItems(0).SubItems(3).Text, 0, 0, tbx_CantidadKM.Text)
        'se actualizaron los IDs
        If Id_Movimiento = 0 Then
            MsgBox("Ocurrió un error al intentar Actualizar el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        'Ligar la Remision con el movimiento
        If Not (Cn_Facturacion.fn_MovimientosD_Guardar(Id_Movimiento, lsv_Remisiones.SelectedItems(0).Tag)) Then
            MsgBox("Ocurrió un error al intentar ligar la Remisión con el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        'Consultar los Datos para hacer los Cálculos
        dt = Cn_Facturacion.fn_Movimientos_ConsultaDatos(Id_Movimiento)
        If dt IsNot Nothing Then
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
            Envases = dt.Rows(0)("Cantidad_Envases")
            'Kilometros = dt.Rows(0)("Cantidad_KM")
            Kilometros = tbx_CantidadKM.Text
            Efectivo = dt.Rows(0)("Efectivo")
            Documentos = dt.Rows(0)("Documentos")
            Miles_Scosto = dt.Rows(0)("Miles_Scosto")
            Redondeado = dt.Rows(0)("Redondeado")
            Cobra_Documentos = dt.Rows(0)("Cobra_Documentos")
            CantidadXunidad = dt.Rows(0)("CantidadXunidad")
            Envases_Scosto = dt.Rows(0)("Envases_Scosto")
        Else
            MsgBox("Ocurrió un error al intentar Realizar los Cálculos del Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        'Hacer todos los Calculos
        If Cobra_Documentos = "S" Then ImporteTotal = Efectivo + Documentos Else ImporteTotal = Efectivo
        Importe = Efectivo + Documentos
        If Redondeado = "S" Then
            If ImporteTotal Mod CantidadXunidad > 0 Then
                Miles = ((ImporteTotal \ CantidadXunidad) + 1) - Miles_Scosto
            Else
                Miles = (ImporteTotal / CantidadXunidad) - Miles_Scosto
            End If

        Else
            Miles = (ImporteTotal / CantidadXunidad) - Miles_Scosto
        End If
        If Miles < 0 Then Miles = 0
        If Envases_Scosto = -1 Then
            EnvasesE = 0
        Else
            EnvasesE = Envases - Envases_Scosto
        End If
        If EnvasesE < 0 Then EnvasesE = 0
        If Kilometros < 0 Then Kilometros = 0
        'actualizar todo
        If Cn_Facturacion.fn_Movimientos_Update(Id_Movimiento, cmb_Cliente.SelectedValue, cmb_Precio.Tag, cmb_Precio.SelectedValue, cmb_Cuota.SelectedValue, cmb_EnvasesE.SelectedValue, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue, dtp_Fecha.Value, tbx_Hora.Text, Remisiones, Envases, Importe, Miles, EnvasesE, Kilometros) Then

            '    If Cn_Facturacion.fn_Movimientos_ValidarServicio(lsv_Datos.SelectedItems(0).Tag, "V") Then
            '        MsgBox("Servicio validado con exito.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            '        Call Mostrar()
            '    Else
            '        MsgBox("Ocurrió un error al intentar validar el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            '    End If
            Call Limpiar()
        Else
            MsgBox("Ocurrió un error al intentar Recalcular el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        If cmb_Cliente.SelectedValue Is Nothing Then Exit Sub
        cmb_Precio.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Precio.Actualizar()
        cmb_Cuota.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Cuota.Actualizar()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Clientes
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Cliente.SelectedValue = 0
        Else
            tbx_Cliente.Text = frm.Clave
        End If
    End Sub

    Private Sub cmb_Precio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Precio.SelectedValueChanged
        '_Filtro.Text = Tbl.Rows(Me.SelectedIndex)(Clave)
        'obtener el Id_CS
        cmb_Precio.Tag = 0
        cmb_Cuota.SelectedValue = 0
        cmb_Kilometraje.SelectedValue = 0
        tbx_CantidadKM.Clear()
        If cmb_Precio.SelectedValue Is Nothing Then Exit Sub
        If cmb_Precio.SelectedIndex = 0 Then Exit Sub

        Dim dt As DataTable = TryCast(cmb_Precio.DataSource, DataTable)
        cmb_Precio.Tag = dt.Rows(cmb_Precio.SelectedIndex)("Id_CS")

        'ya teniendo el Id_CS debo ir a traer los IDs de CR y KM
        dt = fn_AgregarMovimientos_CSRead(cmb_Precio.Tag)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cmb_Cuota.SelectedValue = dt.Rows(0)("Id_CR")
                cmb_Kilometraje.SelectedValue = dt.Rows(0)("Id_KM")
                tbx_CantidadKM.Text = dt.Rows(0)("Cantidad_Kilometros")
                tbx_Descripcion.Text = dt.Rows(0)("Comentarios")
            Else
                MsgBox("Ocurrió un error al intentar consultar los Servicios Contratados por el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("Ocurrió un error al intentar consultar los Servicios Contratados por el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub gbx_Movimientos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Movimientos.MouseHover, gbx_Remisiones.MouseHover, gbx_RemisionesD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Precio.Enabled Then
                cmb_Precio.Focus()
            Else
                cmb_Ruta.Focus()
            End If
        End If
    End Sub

End Class