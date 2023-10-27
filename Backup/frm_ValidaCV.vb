Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_ValidaCV

    Private Sub frm_ValidaCV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()

            Case Keys.F2
                If btn_Validar.Enabled Then btn_Validar_Click(btn_Validar, Nothing)

            Case Keys.F4
                If btn_Cancelar.Enabled Then btn_Cancelar_Click(btn_Cancelar, Nothing)
        End Select

    End Sub

    Private Sub frm_ValidaCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        lsv_Datos.Columns.Add("Numero")
        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Hora")
        lsv_Datos.Columns.Add("Cliente")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Status")

        cmb_Precio.AgregaParametro("@Id_Cliente", 0, 1)
        cmb_Cliente.Actualizar()
        cmb_ClienteF.Actualizar()

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        If cmb_ClienteF.SelectedValue = 0 And chk_TodosCf.Checked = False Then
            MsgBox("Seleccione un Cliente o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClienteF.Focus()
            Exit Sub
        End If

        Call Limpiar()
        If Not fn_ComprobantesV_Consultar(FuncionesGlobales.fn_Fecha102(dtp_Desde.Value.Date.ToShortDateString), FuncionesGlobales.fn_Fecha102(dtp_Hasta.Value.Date.ToShortDateString), lsv_Datos, IIf(chk_SubClientes.Checked, 0, cmb_ClienteF.SelectedValue), IIf(chk_SubClientes.Checked, cmb_ClienteF.SelectedValue, 0)) Then
            MsgBox("Ocurrió un error al intentar consultar los Coprobantes de Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_Datos.Columns(10).Width = 0
        lsv_Datos.Columns(11).Width = 0
        lsv_Datos.Columns(12).Width = 0
        Lbl_Registros.Text = "Registros: " & lsv_Datos.Items.Count

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Sub Limpiar()
        SegundosDesconexion = 0

        If cmb_Cliente.Items.Count > 0 Then
            cmb_Cliente.SelectedIndex = 0
        End If
        If cmb_Precio.Items.Count > 0 Then
            cmb_Precio.SelectedIndex = 0
        End If
        tbx_Hora.Clear()
        tbx_HoraLL.Clear()
        tbx_HoraS.Clear()
        tbx_Comentarios.Clear()
        tbx_ComentariosCancela.Clear()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Limpiar()
        btn_Validar.Enabled = False
        btn_Cancelar.Enabled = False
        If lsv_Datos.SelectedItems.Count = 0 Then Exit Sub

        tbx_Hora.Text = lsv_Datos.SelectedItems(0).SubItems(2).Text
        tbx_HoraLL.Text = lsv_Datos.SelectedItems(0).SubItems(3).Text
        tbx_HoraS.Text = lsv_Datos.SelectedItems(0).SubItems(4).Text
        tbx_Comentarios.Text = lsv_Datos.SelectedItems(0).SubItems(8).Text.ToUpper
        tbx_ComentariosCancela.Text = lsv_Datos.SelectedItems(0).SubItems(9).Text.ToUpper
        cmb_Cliente.SelectedValue = lsv_Datos.SelectedItems(0).SubItems(10).Text
        cmb_Precio.SelectedValue = lsv_Datos.SelectedItems(0).SubItems(11).Text
        'Id_Punto = lsv_Datos.SelectedItems(0).SubItems(12).Text
        btn_Validar.Enabled = True
        btn_Cancelar.Enabled = True
    End Sub

    Private Sub cmb_Clientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Cliente.SelectedValue Is Nothing Then Exit Sub
        If lsv_Datos.SelectedItems.Count = 0 Then Exit Sub
        cmb_Precio.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        cmb_Precio.Actualizar()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        If lsv_Datos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Comprobante de Visita para Validar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If cmb_Cliente.SelectedIndex = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If
        If cmb_Precio.SelectedIndex = 0 Then
            MsgBox("Seleccione un Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Precio.Focus()
            Exit Sub
        End If
        If Len(tbx_Hora.Text) <> 5 Then
            MsgBox("Hora Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If
        If InStr(tbx_Hora.Text, ":") <> 3 Then
            MsgBox("Hora Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If
        If Len(tbx_HoraLL.Text) <> 5 Then
            MsgBox("Hora de Llegada Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraLL.Focus()
            Exit Sub
        End If
        If InStr(tbx_HoraLL.Text, ":") <> 3 Then
            MsgBox("Hora de Llegada Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraLL.Focus()
            Exit Sub
        End If
        If Len(tbx_HoraS.Text) <> 5 Then
            MsgBox("Hora de Salida Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraS.Focus()
            Exit Sub
        End If
        If InStr(tbx_HoraS.Text, ":") <> 3 Then
            MsgBox("Hora de Salida Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraS.Focus()
            Exit Sub
        End If
        'Actualizar el registro
        If fn_ComprobantesV_Validar(lsv_Datos.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, cmb_Precio.SelectedValue, lsv_Datos.SelectedItems(0).SubItems(12).Text, tbx_Hora.Text, tbx_HoraLL.Text, tbx_HoraS.Text, tbx_Comentarios.Text.Trim) Then
            MsgBox("Comprobante validado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
            Exit Sub
        Else
            MsgBox("Ocurrió un error al intentar Validar el Comprobante. Consulte a su Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
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
            txt_Clave.Text = frm.Clave
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        If lsv_Datos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Comprobante de Visita para Cancelar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_ComentariosCancela.Text.Trim = "" Then
            MsgBox("Los Comentarios son oblitatorios. No se cancelará el Comprobante de Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ComentariosCancela.Focus()
            Exit Sub
        End If
        'Cancelar el CV
        If fn_ComprobantesV_Cancelar(lsv_Datos.SelectedItems(0).Tag, tbx_ComentariosCancela.Text, tbx_Hora.Text, tbx_HoraLL.Text, tbx_HoraS.Text, tbx_Comentarios.Text) Then
            MsgBox("Comprobante Cancelado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
            Exit Sub
        Else
            MsgBox("Ocurrió un error al intentar Cancelar el Comprobante. Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then btn_Mostrar.Focus()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0
        lsv_Datos.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0
        lsv_Datos.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Limpiar()
    End Sub

    Private Sub cmb_Precio_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Precio.SelectedValueChanged
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_TodosCf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodosCf.CheckedChanged
        SegundosDesconexion = 0
        cmb_ClienteF.SelectedValue = 0
        cmb_ClienteF.Enabled = chk_TodosCf.Checked = False
        Tbx_Filtro2.Enabled = chk_TodosCf.Checked = False
        chk_SubClientes.Checked = False
        chk_SubClientes.Enabled = chk_TodosCf.Checked = False
        lsv_Datos.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Limpiar()
    End Sub

    Private Sub cmb_ClienteF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClienteF.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Datos.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Limpiar()
    End Sub

    Private Sub chk_SubClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SubClientes.CheckedChanged
        SegundosDesconexion = 0
        lsv_Datos.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Call Limpiar()
    End Sub
End Class