Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_MovimientosValidar

    Dim dt_Importes As DataTable
    Dim Id_Precio As Integer
    Dim Id_CS As Integer

    Private Sub frm_MovimientosValidar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()

            Case Keys.F1
                tbx_Numero.SelectAll()
                tbx_Numero.Focus()
            Case Keys.F2
                If btn_ValidarRemision.Enabled Then btn_ValidarRemision_Click(btn_ValidarRemision, Nothing)

            Case Keys.F3
                If btn_Agregar.Enabled Then btn_Agregar_Click(btn_Agregar, Nothing)

            Case Keys.F4
                If btn_Eliminar.Enabled Then btn_Eliminar_Click(btn_Eliminar, Nothing)

            Case Keys.F5
                If btn_ValidarServicio.Enabled Then btn_ValidarServicio_Click(btn_ValidarServicio, Nothing)
        End Select

    End Sub

    Private Sub frm_ValidaRemision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Remisiones.Columns.Clear()
        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Cia Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("Status")
        lsv_Remisiones.Columns.Add("UsrValida")
        lsv_Remisiones.Columns.Add("FechaV")

        lsv_Datos.Columns.Clear()
        lsv_Datos.Columns.Add("Remision")
        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Hora")
        lsv_Datos.Columns.Add("Cliente")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Tipo")
        lsv_Datos.Columns.Add("Remisiones")
        lsv_Datos.Columns.Add("Envases")
        lsv_Datos.Columns.Add("Importe")
        lsv_Datos.Columns.Add("Miles")
        lsv_Datos.Columns.Add("Envases Ex")
        lsv_Datos.Columns.Add("Kilometros")
        lsv_Datos.Columns.Add("Status")

        lsv_Precios.Columns.Add("Descripcion")
        lsv_Precios.Columns.Add("Clave")
        lsv_Precios.Columns.Add("Precio")

        lsv_Envases.Columns.Add("Tipo")
        lsv_Envases.Columns.Add("Número")

        cmb_Cliente.Actualizar()
        cmb_Precio.AgregaParametro("@Id_Cliente", "0", 1)
        cmb_Precio.Actualizar()
        cmb_Cuota.AgregaParametro("@Id_Cliente", "0", 1)
        cmb_Cuota.Actualizar()
        cmb_Kilometraje.Actualizar()
        cmb_Ruta.Actualizar()
        cmb_TipoEnvase.Actualizar()

        dt_Importes = fn_RemisionDetalle_Read(0)
        dgv_Importes.DataSource = dt_Importes
        Call FormatoGrid()
        tbx_Total.Text = "0.00"
        tbx_ImporteProcesado.Text = "0.00"

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Call Mostrar()
    End Sub

    Sub Mostrar()
        lsv_Datos.Items.Clear()
        lsv_Remisiones.Items.Clear()
        lsv_Precios.Items.Clear()
        lsv_Envases.Items.Clear()
        tbx_Hora.Clear()
        tbx_Descripcion.Clear()
        tbx_Envase.Clear()
        tbx_EnvasesSN.Clear()
        tbx_HoraR.Clear()
        tbx_Sobres.Clear()
        tbx_Origen.Clear()
        tbx_Destino.Clear()
        If (tbx_Numero.Text.Trim = "") Then
            MsgBox("Indique un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If

        If (CLng(tbx_Numero.Text.Trim) = 0) Then
            MsgBox("Indique un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If
        If Not fn_Movimientos_ConsultaValidar(tbx_Numero.Text.Trim, lsv_Datos) Then
            MsgBox("Ocurrió un error al intentar consultar los Traslados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lsv_Datos.Columns(7).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(8).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(9).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(10).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(11).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(12).TextAlign = HorizontalAlignment.Right

        If lsv_Datos.Items.Count > 0 Then
            lsv_Datos.Items(0).Selected = True
        End If
        If lsv_Datos.Items.Count > 0 Then
            btn_ValidarServicio.Enabled = True
            Call Colores_Servicios()
        Else
            btn_ValidarServicio.Enabled = False
        End If

    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Remisiones.Items.Clear()
        If dt_Importes IsNot Nothing Then
            dt_Importes.Rows.Clear()
        End If

        cmb_Cliente.SelectedValue = 0
        cmb_Precio.SelectedValue = 0
        cmb_Cuota.SelectedValue = 0
        cmb_Kilometraje.SelectedValue = 0
        cmb_Ruta.SelectedValue = 0

        tbx_EnvasesSN.Clear()
        tbx_Sobres.Clear()
        tbx_HoraR.Clear()
        tbx_Hora.Clear()
        tbx_Descripcion.Clear()
        lsv_Envases.Items.Clear()

        If lsv_Datos.Items.Count > 0 And lsv_Datos.SelectedItems.Count > 0 Then
            Call Mostrar_Detalle()
        End If
        If lsv_Datos.SelectedItems.Count > 0 Then
            btn_ValidarServicio.Enabled = True
            btn_Agregar.Enabled = True
        Else
            btn_ValidarServicio.Enabled = False
            btn_Agregar.Enabled = False
        End If
    End Sub

    Sub Mostrar_Detalle()
        lsv_Remisiones.Items.Clear()
        lsv_Envases.Items.Clear()
        tbx_EnvasesSN.Clear()

        If lsv_Datos.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        'Llenar lsv_Remisiones con las remisiones del Movimiento seleccionado (tabla Cat_MovimientosD)
        If Not fn_MovimientosDLlenarLista(lsv_Datos.SelectedItems(0).Tag, lsv_Remisiones) Then
            MsgBox("Ocurrió un error al intentar consultar las Remisiones del Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lsv_Remisiones.Columns(13).Width = 200
        lsv_Remisiones.Columns(14).Width = 200
        If lsv_Remisiones.Items.Count > 0 Then
            'Seleccionar la remision que se buscó
            For Each Elemento As ListViewItem In lsv_Remisiones.Items
                If Elemento.Text = tbx_Numero.Text.Trim Then
                    lsv_Remisiones.Items(Elemento.Index).Selected = True
                End If
            Next

            Call Mostrar_Importes()
            Call Colores_Remisiones()
            Call Mostrar_Envases()
        End If
        '
        'Llenar los combos con los datos del movimiento seleccionado
        Dim dt As DataTable = fn_Movimientos_Read(lsv_Datos.SelectedItems(0).Tag)
        If dt.Rows.Count > 0 Then
            cmb_Cliente.SelectedValue = dt.Rows(0)("Id_Cliente")
            cmb_Precio.SelectedValue = dt.Rows(0)("Id_CS") 'cuando cambia este combo se busca la CR y KM
            cmb_Ruta.SelectedValue = dt.Rows(0)("Id_Ruta")
            dtp_Fecha.Text = dt.Rows(0)("Fecha")
            tbx_Hora.Text = dt.Rows(0)("Hora")

            'Marcar el Servicio en la Lista de Servicios Contratados
            For Each Elemento As ListViewItem In lsv_Precios.Items
                If CInt(Elemento.Tag) = Id_Precio And CInt(Elemento.SubItems(4).Text) = Id_CS Then
                    Elemento.Selected = True
                    Exit Sub
                End If
            Next

        Else
            Call Mostrar()
            cmb_Cliente.SelectedValue = 0
            cmb_Ruta.SelectedValue = 0
            cmb_Precio.ActualizaValorParametro("@Id_Cliente", "0")
            cmb_Precio.Actualizar()
            MsgBox("No se encontró el Movimiento.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
    End Sub

    Sub Colores_Servicios()
        For I As Integer = 0 To lsv_Datos.Items.Count - 1
            If lsv_Datos.Items(I).SubItems(1).Text = "VALIDADO" Then
                lsv_Datos.Items(I).ForeColor = Color.Green
            End If
        Next
    End Sub

    Sub Colores_Remisiones()
        For I As Integer = 0 To lsv_Remisiones.Items.Count - 1
            If lsv_Remisiones.Items(I).SubItems(4).Text = "VALIDADO" Then
                lsv_Remisiones.Items(I).ForeColor = Color.Green
            End If
        Next
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Remisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Mostrar_Importes()
        Call Mostrar_Envases()
        gbx_Tipo2.Enabled = True
        If lsv_Remisiones.SelectedItems.Count > 0 And dgv_Importes.Rows.Count > 0 Then
            btn_ValidarRemision.Enabled = True
            btn_Eliminar.Enabled = True
            rdb_DotacionBillete.Checked = lsv_Remisiones.SelectedItems(0).SubItems(7).Text = "S"
            rdb_DotacionMorralla.Checked = lsv_Remisiones.SelectedItems(0).SubItems(8).Text = "S"
            rdb_PagoMorralla.Checked = lsv_Remisiones.SelectedItems(0).SubItems(9).Text = "S"
            rdb_PagoNomina.Checked = lsv_Remisiones.SelectedItems(0).SubItems(10).Text = "S"
            rdb_NominaProcesada.Checked = lsv_Remisiones.SelectedItems(0).SubItems(11).Text = "S"
            tbx_HoraR.Text = lsv_Remisiones.SelectedItems(0).SubItems(12).Text
            tbx_Origen.Text = lsv_Remisiones.SelectedItems(0).SubItems(13).Text
            tbx_Destino.Text = lsv_Remisiones.SelectedItems(0).SubItems(14).Text
            tbx_Sobres.Text = lsv_Remisiones.SelectedItems(0).SubItems(15).Text
            tbx_Sobres.Tag = lsv_Remisiones.SelectedItems(0).SubItems(15).Text

            'Dejar el foco en la casilla del grid que tenga un importe
            Dim Fila As Integer = 0
            Dim Columna As Integer = 0
            Dim Encontrado As Boolean = False
            For Columna = 2 To dgv_Importes.Columns.Count - 2
                Encontrado = False
                For Fila = 0 To dgv_Importes.Rows.Count - 1
                    If CDec(dgv_Importes.Rows(Fila).Cells(Columna).Value) > 0 Then
                        dgv_Importes.Rows(Fila).Cells(Columna).Selected = True
                        Encontrado = True
                        Exit For
                    End If
                Next
                If Encontrado Then Exit For
            Next
        Else
            btn_ValidarRemision.Enabled = False
            btn_Eliminar.Enabled = False
            rdb_DotacionBillete.Checked = False
            rdb_DotacionMorralla.Checked = False
            rdb_PagoMorralla.Checked = False
            rdb_PagoNomina.Checked = False
            rdb_NominaProcesada.Checked = False
            tbx_HoraR.Text = "00:00"
            tbx_Origen.Clear()
            tbx_Destino.Clear()
            tbx_Sobres.Clear()
            tbx_Sobres.Tag = ""
        End If

        If rdb_DotacionBillete.Checked Or rdb_DotacionMorralla.Checked Then
            'gbx_Tipo2.Enabled = False
            'No se deshabilita porque cuando es una dotacion tambien se puede marcar como 
            'Entrega de nomina Procesada
        End If
        
    End Sub

    Sub Mostrar_Importes()
        lsv_Envases.Items.Clear()
        tbx_EnvasesSN.Clear()
        If dt_Importes IsNot Nothing Then
            dt_Importes.Rows.Clear()
        End If
        If lsv_Remisiones.SelectedItems.Count > 0 Then
            dt_Importes = fn_RemisionDetalle_Read(lsv_Remisiones.SelectedItems(0).Tag)
            dgv_Importes.DataSource = dt_Importes
            Call FormatoGrid()
            Call CalculaImporteTotal()
            Call CalculaImporteProcesado()
            If dgv_Importes.Rows.Count > 0 Then
                btn_ValidarRemision.Enabled = True
            Else
                btn_ValidarRemision.Enabled = False
            End If
        End If
    End Sub

    Sub Mostrar_Envases()
        lsv_Envases.Items.Clear()
        If lsv_Remisiones.SelectedItems.Count > 0 Then
            fn_RemisionEnvases_Get(lsv_Envases, lsv_Remisiones.SelectedItems(0).Tag)
            tbx_EnvasesSN.Text = lsv_Remisiones.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub FormatoGrid()
        If dgv_Importes.Columns.Count = 0 Then Exit Sub

        With dgv_Importes.ColumnHeadersDefaultCellStyle
            .Font = New Font(dgv_Importes.Font, FontStyle.Bold)
        End With

        With dgv_Importes

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
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

    Private Sub CalculaImporteProcesado()
        Dim ImporteProcesado As Decimal = fn_ValidarMovimientos_ObtenerImportes(lsv_Remisiones.SelectedItems(0).Tag)
        'If dr IsNot Nothing Then
        '    tbx_ImporteProcesado.Text = CDec(dr("Efectivo")) + CDec(dr("Cheques")) + CDec(dr("Otros"))
        '    tbx_ImporteProcesado.Text = Format(CDec(tbx_ImporteProcesado.Text) - CDec(dr("Dif. Efectivo")) - CDec(dr("Dif. Cheques")) - CDec(dr("Dif. Otros")), "c")
        'Else
        '    tbx_ImporteProcesado.Text = "No Procesado"
        'End If

        If ImporteProcesado = 0 Then
            tbx_ImporteProcesado.Text = "No Procesado"
        Else
            tbx_ImporteProcesado.Text = Format(ImporteProcesado, "c")
        End If

    End Sub

    Private Sub dgv_Importes_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Importes.CellValueChanged
        Call CalculaImporteTotal()
    End Sub

    Private Sub dgv_Importes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Importes.DataError
        MsgBox("Cantidad no válida, Capture un dato numérico.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub tbx_Numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Numero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Mostrar()
        End If
    End Sub

    Private Sub btn_ValidarRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarRemision.Click, lsv_Remisiones.DoubleClick
        SegundosDesconexion = 0

        If lsv_Remisiones.SelectedItems.Count = 0 Then Exit Sub

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If
        If cmb_Precio.SelectedValue = 0 Then
            MsgBox("Seleccione un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Precio.Focus()
            Exit Sub
        End If

        If rdb_DotacionBillete.Checked = True Or rdb_DotacionMorralla.Checked = True Then
            If rdb_PagoMorralla.Checked = True Or rdb_PagoNomina.Checked = True Then
                MsgBox("Cuando es una Dotación de Billete o Morralla No se puede marcar el servicio como Pago de Morralla o Pago de Nómina.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Dim Importe As Decimal = 0.0
        Dim DotacionBillete As String = "N"
        Dim DotacionMorralla As String = "N"
        Dim PagoMorralla As String = "N"
        Dim PagoNomina As String = "N"
        Dim NominaProcesada As String = "N"

        If rdb_DotacionBillete.Checked = True Then DotacionBillete = "S"
        If rdb_DotacionMorralla.Checked = True Then DotacionMorralla = "S"
        If rdb_PagoMorralla.Checked = True Then PagoMorralla = "S"
        If rdb_PagoNomina.Checked = True Then PagoNomina = "S"
        If rdb_NominaProcesada.Checked = True Then NominaProcesada = "S"

        'Actualizar los Datos del Movimiento
        Call Validar_Servicio_Sin_Validar()

        'Totalizar el GridView
        For Each Row As DataRow In dt_Importes.Rows
            Importe += (CDec(Row("Efectivo")) + CDec(Row("Documentos"))) * CDec(Row("Tipo Cambio"))
        Next
        If tbx_Sobres.Text = "" Then tbx_Sobres.Text = 0
        If Cn_Facturacion.fn_Movimientos_ValidarRemision(lsv_Datos.SelectedItems(0).Tag, lsv_Remisiones.SelectedItems(0).Tag, "V", dt_Importes, lsv_Envases.Items.Count, CInt(tbx_EnvasesSN.Text), Importe, tbx_HoraR.Text, DotacionBillete, DotacionMorralla, PagoMorralla, PagoNomina, NominaProcesada, CInt(tbx_Sobres.Text)) Then
            MsgBox("Remisión validada con éxito.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            'Call Mostrar()
            If lsv_Datos.Items.Count > 0 And lsv_Datos.SelectedItems.Count > 0 Then
                Call Mostrar_Detalle()
            End If
            If lsv_Datos.SelectedItems.Count > 0 Then
                btn_ValidarServicio.Enabled = True
                btn_Agregar.Enabled = True
            Else
                btn_ValidarServicio.Enabled = False
                btn_Agregar.Enabled = False
            End If

            'Si ya se validaron todas las remisiones, avisarle al usuario
            Dim Pendientes As Boolean = False
            For Each elemento As ListViewItem In lsv_Remisiones.Items
                If elemento.SubItems(4).Text <> "VALIDADO" Then
                    Pendientes = True
                    Exit For
                End If
            Next
            If Pendientes = False Then
                If MsgBox("Ya se han validado todas las Remisiones del Servicio. Desea que este sea Validado también?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                    Call Validar_Servicio()
                End If
            End If
        Else
            MsgBox("Ocurrió un error al intentar guardar la Remisión.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        lsv_Remisiones.Items.Clear()
        If dt_Importes IsNot Nothing Then
            dt_Importes.Rows.Clear()
        End If
        If lsv_Datos.Items.Count > 0 Then lsv_Datos.Items.Clear()
        cmb_Cliente.SelectedValue = 0
        cmb_Precio.SelectedValue = 0
        cmb_Cuota.SelectedValue = 0
        cmb_Kilometraje.SelectedValue = 0
        cmb_Ruta.SelectedValue = 0

        If lsv_Remisiones.Items.Count > 0 Then
            lsv_Remisiones.Items.Clear()
        End If

        tbx_Origen.Clear()
        tbx_Destino.Clear()
        tbx_Hora.Clear()
        dtp_Fecha.Value = Today
        'tbx_Total.Clear()
        'tbx_ImporteProcesado.Clear()
        tbx_Total.Text = "0.00"
        tbx_ImporteProcesado.Text = "0.00"
        If lsv_Envases.Items.Count > 0 Then lsv_Envases.Items.Clear()
    End Sub

    Private Sub btn_ValidarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarServicio.Click
        SegundosDesconexion = 0

        Call Validar_Servicio()
    End Sub

    Sub Validar_Servicio()
        Dim Remisiones As Integer = 0, Envases As Integer = 0, Importe As Decimal = 0, Miles As Decimal = 0, EnvasesE As Integer = 0, Kilometros As Integer = 0
        Dim Efectivo As Decimal = 0, Documentos As Decimal = 0
        Dim Miles_Scosto As Decimal = 0
        Dim Envases_Scosto As Integer = 0
        Dim CantidadXunidad As Integer = 1000
        Dim Redondeado As String = "S"
        Dim Cobra_Documentos As String = "S"
        Dim ImporteTotal As Decimal = 0
        Dim dt As DataTable
        Dim Pendientes As Boolean = False

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If
        If cmb_Precio.SelectedValue = 0 Then
            MsgBox("Seleccione un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Precio.Focus()
            Exit Sub
        End If

        'Primero recorrer para ver si todas las remisiones han sido validadas
        For Each ele As ListViewItem In lsv_Remisiones.Items
            If ele.SubItems(4).Text <> "VALIDADO" Then
                Pendientes = True
                Exit For
            End If
        Next
        If Pendientes Then
            'preguntar si desea continuar.
            If MsgBox("Aún existen Remisiones pendientes en este Servicio. Aún así desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then Exit Sub
        End If

        'Update de los IDs a Cat_Movimientos
        If Cn_Facturacion.fn_Movimientos_UpdateIDs(lsv_Datos.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, Id_CS, Id_Precio, cmb_Cuota.SelectedValue, 0, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue) Then
            'se actualizaron los IDs
        Else
            MsgBox("Ocurrió un error al intentar Actualizar el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        'Consultar los Datos para hacer los Cálculos
        dt = Cn_Facturacion.fn_Movimientos_ConsultaDatos(lsv_Datos.SelectedItems(0).Tag)
        If dt IsNot Nothing Then
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
            Envases = dt.Rows(0)("Cantidad_Envases")
            Kilometros = dt.Rows(0)("Cantidad_KM")
            Efectivo = dt.Rows(0)("Efectivo")
            Documentos = dt.Rows(0)("Documentos")
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
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
                If ImporteTotal Mod CantidadXunidad >= 999.5 Then
                    Miles = ((ImporteTotal \ CantidadXunidad)) - Miles_Scosto
                    'Le quité el "+1" porque cuando el resultado del mod es muy cercano a 1000
                    'se redondea automaticamente y el calculo de los miles sale mal
                    'sale 1 mil de mas
                Else
                    Miles = ((ImporteTotal \ CantidadXunidad) + 1) - Miles_Scosto
                End If
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
        If Cn_Facturacion.fn_Movimientos_Update(lsv_Datos.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, Id_CS, Id_Precio, cmb_Cuota.SelectedValue, 0, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue, dtp_Fecha.Value, tbx_Hora.Text, Remisiones, Envases, Importe, Miles, EnvasesE, Kilometros) Then
            If Cn_Facturacion.fn_Movimientos_ValidarServicio(lsv_Datos.SelectedItems(0).Tag, "V") Then
                MsgBox("Servicio validado con éxito.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Call Mostrar()
            Else
                MsgBox("Ocurrió un error al intentar validar el Servicio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        End If
    End Sub

    Sub Validar_Servicio_Sin_Validar()
        'Actualiza todos los datos del registro pero no le cambia el Status.
        Dim Remisiones As Integer = 0, Envases As Integer = 0, Importe As Decimal = 0, Miles As Decimal = 0, EnvasesE As Integer = 0, Kilometros As Integer = 0
        Dim Efectivo As Decimal = 0, Documentos As Decimal = 0
        Dim Miles_Scosto As Decimal = 0
        Dim Envases_Scosto As Integer = 0
        Dim CantidadXunidad As Integer = 1000
        Dim Redondeado As String = "S"
        Dim Cobra_Documentos As String = "S"
        Dim ImporteTotal As Decimal = 0
        Dim dt As DataTable
        
        'Update de los IDs a Cat_Movimientos
        If Cn_Facturacion.fn_Movimientos_UpdateIDs(lsv_Datos.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, Id_CS, Id_Precio, cmb_Cuota.SelectedValue, 0, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue) Then
            'se actualizaron los IDs
        Else
            MsgBox("Ocurrió un error al intentar Actualizar el Servicio Pero se procederá a Validar la Remisión.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        'Consultar los Datos para hacer los Cálculos
        dt = Cn_Facturacion.fn_Movimientos_ConsultaDatos(lsv_Datos.SelectedItems(0).Tag)
        If dt IsNot Nothing Then
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
            Envases = dt.Rows(0)("Cantidad_Envases")
            Kilometros = dt.Rows(0)("Cantidad_KM")
            Efectivo = dt.Rows(0)("Efectivo")
            Documentos = dt.Rows(0)("Documentos")
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
            Miles_Scosto = dt.Rows(0)("Miles_Scosto")
            Redondeado = dt.Rows(0)("Redondeado")
            Cobra_Documentos = dt.Rows(0)("Cobra_Documentos")
            CantidadXunidad = dt.Rows(0)("CantidadXunidad")
            Envases_Scosto = dt.Rows(0)("Envases_Scosto")
        Else
            MsgBox("Ocurrió un error al intentar Realizar los Cálculos del Servicio Pero se procederá a Validar la Remisión.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
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
        If Kilometros <= 0 Then Kilometros = 0
        'actualizar todo
        If Cn_Facturacion.fn_Movimientos_Update(lsv_Datos.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, Id_CS, Id_Precio, cmb_Cuota.SelectedValue, 0, cmb_Kilometraje.SelectedValue, cmb_Ruta.SelectedValue, dtp_Fecha.Value, tbx_Hora.Text, Remisiones, Envases, Importe, Miles, EnvasesE, Kilometros) Then

        End If
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_AgregaRemision
        frm.Id_Movimiento = lsv_Datos.SelectedItems(0).Tag
        frm.Origen = 1
        frm.ShowDialog()
        Call Mostrar_Detalle()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        If lsv_Remisiones.SelectedItems.Count = 0 Then
            MsgBox("No hay elementos Seleccionados, Seleccione una Remision en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Solo eliminar la relación en Cat_MovimientosD
        If MsgBox("Confirma que desea eliminar la Remisión Seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
            If Cn_Facturacion.fn_MovimientosD_Eliminar(lsv_Datos.SelectedItems(0).Tag, lsv_Remisiones.SelectedItems(0).Tag) Then
                MsgBox("Se Eliminó correctamente la remision seleccionada.", MsgBoxStyle.Information, frm_MENU.Text)
                Call Mostrar_Detalle()
            Else
                MsgBox("Ocurrió un error al eliminar la remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Clientes
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Cliente.SelectedValue = 0
        Else
            tbx_Cliente.Text = frm.Clave
        End If
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0

        'llenar la lista con los precios del cliente
        lsv_Precios.Items.Clear()
        If cmb_Cliente.SelectedValue Is Nothing Then Exit Sub
        If Val(cmb_Cliente.SelectedValue) = 0 Then Exit Sub
        fn_Movimientos_ConsultaPrecios(CInt(cmb_Cliente.SelectedValue), lsv_Precios)

        'Llenar el Combo de Precios solo con los contratados por el cliente
        cmb_Precio.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Precio.Actualizar()
        cmb_Cuota.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Cuota.Actualizar()
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_EliminarE.Enabled = lsv_Envases.SelectedItems.Count > 0
    End Sub

    Private Sub btn_AgregarE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarE.Click
        SegundosDesconexion = 0

        'Agregar Envase
        If cmb_TipoEnvase.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Envase que desea agregar.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoEnvase.Focus()
            Exit Sub
        End If
        If tbx_Envase.Text.Trim = "" Then
            MsgBox("Indique el Número de Envase que desea agregar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Envase.Focus()
            Exit Sub
        End If

        For Each Elemento As ListViewItem In lsv_Envases.Items
            If Elemento.Text.Trim = tbx_Envase.Text.Trim Then
                MsgBox("El Envase indicado ya existe en la Lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Envase.SelectAll()
                tbx_Envase.Focus()
                Exit Sub
            End If
        Next

        If Not fn_Movimientos_AgregarEnvase(lsv_Remisiones.SelectedItems(0).Tag, tbx_Envase.Text, cmb_TipoEnvase.SelectedValue) Then
            MsgBox("Ocurrió un Error al intentar guardar el Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        tbx_Envase.Clear()
        Call Mostrar_Envases()

    End Sub

    Private Sub lsv_Precios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Precios.SelectedIndexChanged
        SegundosDesconexion = 0

        tbx_Descripcion.Clear()
        If lsv_Precios.SelectedItems.Count > 0 Then
            tbx_Descripcion.Text = lsv_Precios.SelectedItems(0).SubItems(3).Text
            'Seleccionar el Precio tambien  en el Combo
            cmb_Precio.SelectedValue = lsv_Precios.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub btn_EliminarE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminarE.Click
        SegundosDesconexion = 0

        'Eliminar un Envase
        If MsgBox("Confirma que desea Eliminar el Envase seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) <> MsgBoxResult.Yes Then Exit Sub

        If Not fn_Movimientos_EliminarEnvase(lsv_Envases.SelectedItems(0).Tag) Then
            MsgBox("Ocurrió un Error al intentar Eliminar el Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        tbx_Envase.Clear()
        Call Mostrar_Envases()
        btn_EliminarE.Enabled = False
    End Sub

    Private Sub rdb_NominaProcesada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_NominaProcesada.CheckedChanged
        If rdb_NominaProcesada.Checked = True Then
            tbx_Sobres.Enabled = True
            lbl_Sobres.Enabled = True
        Else
            tbx_Sobres.Text = 0
            tbx_Sobres.Enabled = False
            lbl_Sobres.Enabled = False
        End If
    End Sub

    Private Sub btn_BuscaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscaRemision.Click
        SegundosDesconexion = 0

        Call BuscaRemision()
    End Sub


    Sub BuscaRemision()
        If tbx_BuscaRemision.Text.Trim = "" Then
            MsgBox("ndique el Número de Remisión a Buscar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_BuscaRemision.Focus()
            Exit Sub
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Remisiones, tbx_BuscaRemision.Text, 0, 0)
        tbx_BuscaRemision.SelectAll()
        tbx_BuscaRemision.Focus()
    End Sub

    Private Sub tbx_BuscaRemision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscaRemision.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaRemision()
        End If
    End Sub

    Private Sub cmb_Precio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Precio.SelectedValueChanged
        SegundosDesconexion = 0

        Id_Precio = 0
        Id_CS = 0

        cmb_Cuota.SelectedValue = 0
        cmb_Kilometraje.SelectedValue = 0
        tbx_CantidadKM.Clear()
        If cmb_Precio.SelectedValue Is Nothing Then Exit Sub
        If cmb_Precio.SelectedIndex = 0 Then Exit Sub

        Id_CS = cmb_Precio.SelectedValue
        Dim dt As DataTable = TryCast(cmb_Precio.DataSource, DataTable)
        Id_Precio = dt.Rows(cmb_Precio.SelectedIndex)("Id_Precio")

        'ya teniendo el Id_CS debo ir a traer los IDs de CR y KM
        dt = fn_AgregarMovimientos_CSRead(Id_CS)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cmb_Cuota.SelectedValue = dt.Rows(0)("Id_CR")
                cmb_Kilometraje.SelectedValue = dt.Rows(0)("Id_KM")
                tbx_CantidadKM.Text = dt.Rows(0)("Cantidad_Kilometros")
                'tbx_Descripcion.Text = dt.Rows(0)("Comentarios")
            Else
                MsgBox("Ocurrió un error al intentar consultar los Servicios Contratados por el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("Ocurrió un error al intentar consultar los Servicios Contratados por el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

End Class