
Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_MovimientosAgrupar

    Dim IncluirSubC As Char = "N"
    Dim Orden As Integer = 0

    Private Sub frm_MovimientosAgrupar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()
            Case Keys.F6
                If btn_Agrupar.Enabled Then btn_Agrupar_Click(btn_Agrupar, Nothing)

        End Select
    End Sub


    Private Sub AgruparMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Hora")
        lsv_Datos.Columns.Add("Cliente")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Tipo")
        lsv_Datos.Columns.Add("Remisiones")
        lsv_Datos.Columns.Add("Envases")
        lsv_Datos.Columns.Add("Importe")
        lsv_Datos.Columns.Add("Origen")
        lsv_Datos.Columns.Add("Destino")
        lsv_Datos.Columns.Add("Status")


        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")

        lsv_RemisionesD.Columns.Add("Moneda")
        lsv_RemisionesD.Columns.Add("Efectivo")
        lsv_RemisionesD.Columns.Add("Documentos")
        lsv_RemisionesD.Columns.Add("Tipo Cambio")

        lsv_RemisionesD.Columns(0).Width = 87
        lsv_RemisionesD.Columns(1).Width = 87
        lsv_RemisionesD.Columns(2).Width = 87
        lsv_RemisionesD.Columns(3).Width = 87

        'Cargar el Combo con los Status
        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("V", "VALIDADO")
        cmb_Status.AgregarItem("C", "CANCELADO")
        cmb_Status.AgregarItem("F", "FACTURADO")

        cmb_Clientes.Actualizar()
        cmb_Destino.Actualizar()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        Call LimpiarListas()
        Orden = 0
        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            Me.Cursor = Cursors.Default
            MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If
        If cmb_Clientes.Enabled And cmb_Clientes.SelectedValue = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        If Not fn_Movimientos_AgruparConsultar(FuncionesGlobales.fn_Fecha102(dtp_Desde.Value.Date.ToShortDateString), FuncionesGlobales.fn_Fecha102(dtp_Hasta.Value.Date.ToShortDateString), cmb_Status.SelectedValue, cmb_Clientes.SelectedValue, lsv_Datos, IncluirSubC, cmb_Destino.SelectedValue) Then
            Me.Cursor = Cursors.Default
            btn_Agrupar.Enabled = False
            MsgBox("Ocurrió un error al intentar consultar los Traslados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_RegistrosP.Text = "Registros: " & lsv_Datos.Items.Count
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        Call LimpiarListas()
        If chk_Status.Checked Then
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = False
        Else
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub chk_SubClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SubClientes.CheckedChanged
        Call LimpiarListas()
        If chk_SubClientes.Checked Then
            'cmb_Clientes.SelectedValue = 0
            IncluirSubC = "S"
            'cmb_Clientes.Enabled = False
            'txt_Clave.Enabled = False
        Else
            'cmb_Clientes.SelectedValue = 0
            IncluirSubC = "N"
            'cmb_Clientes.Enabled = True
            'txt_Clave.Enabled = True
        End If
    End Sub

    Sub LimpiarListas()
        lsv_Datos.Items.Clear()
        Lbl_RegistrosP.Text = "Registros: 0"
        lsv_Remisiones.Items.Clear()
        lsv_RemisionesD.Items.Clear()
        btn_Agrupar.Enabled = False
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged, cmb_Destino.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cmb_Status.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        lsv_RemisionesD.Items.Clear()
        If lsv_Datos.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Not fn_RemisionesDLlenarLista(lsv_Datos.SelectedItems(0).SubItems(11).Text, lsv_RemisionesD) Then
            MsgBox("Ocurrió un error al intentar consultar los Importes de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_RemisionesD.Columns(1).TextAlign = HorizontalAlignment.Right
        lsv_RemisionesD.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_RemisionesD.Columns(3).TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub lsv_Datos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Datos.ItemChecked
        btn_Agrupar.Enabled = lsv_Datos.CheckedItems.Count > 1
        If lsv_Datos.Items(e.Item.Index).Checked Then
            Orden += 1
            lsv_Datos.Items(e.Item.Index).SubItems(12).Text = Orden
            lsv_Datos.Items(e.Item.Index).Selected = True
        Else
            If lsv_Datos.Items(e.Item.Index).SubItems.Count > 10 Then
                lsv_Datos.Items(e.Item.Index).SubItems(12).Text = 0
                lsv_Datos.Items(e.Item.Index).Selected = False
            End If
        End If
    End Sub

    Private Sub btn_Agrupar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agrupar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        If Not fn_Movimientos_AgruparActualizar(lsv_Datos, cmb_Destino.SelectedValue) Then
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrió un error al intentar Agrupar los Movimientos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Los Movimientos se han Agrupado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        
        Call LlenarLista()

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Call Buscar()
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Buscar()
        End If
    End Sub

    Sub Buscar()
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If FuncionesGlobales.fn_BuscarYmarcar_enListView(lsv_Datos, tbx_Buscar.Text, 1, 0) Then

            'Orden += 1
            'lsv_Datos.SelectedItems(0).SubItems(12).Text = Orden
            'Los puse en comentario porque esas 2 instrucciones se duplicaban en el ItemChecked
        Else
            MsgBox("No se encontró la Remisión en la Lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover, gbx_Remisiones.MouseHover, gbx_Remisiones1.MouseHover, gbx_RemisionesD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class