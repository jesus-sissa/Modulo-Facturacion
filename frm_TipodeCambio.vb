Public Class frm_TipodeCambio

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()

    End Sub

    Private Sub frm_TipodeCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_TipodeCambio.Columns.Add("Fecha", 150)
        lsv_TipodeCambio.Columns.Add("Moneda", 120)
        lsv_TipodeCambio.Columns.Add("Clave", 100)
        lsv_TipodeCambio.Columns.Add("Tipo Cambio", 100, HorizontalAlignment.Right)

        cmb_Monedas.Actualizar()

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Call LimpiaTexbox()
        Tab_TipoCambio.SelectedIndex = 0
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        cmb_Monedas.SelectedValue = 0
        cmb_Monedas.Enabled = Not chk_Todos.Checked
        btn_Modificar.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        lsv_TipodeCambio.SelectedItems.Clear()

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El periodo de fechas parece estar incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Monedas.SelectedValue = 0 And Not chk_Todos.Checked Then
            MsgBox("Seleccione alguna moneda o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Monedas.Focus()
            Exit Sub

        End If

        If Not Cn_Facturacion.fn_TiposdeCambio_LlenarLista(lsv_TipodeCambio, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Monedas.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_TipodeCambio.Items.Count
    End Sub

    Private Sub lsv_TipodeCambio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_TipodeCambio.DoubleClick
        Call ModificarTipodeCambio()
        Tab_TipoCambio.SelectedIndex = 1

        btn_Guardar.Enabled = True

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Modificar.Enabled = False
    End Sub

    Private Sub lsv_TipodeCambio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_TipodeCambio.SelectedIndexChanged
        If lsv_TipodeCambio.SelectedItems.Count > 0 Then
            btn_Modificar.Enabled = True
        Else
            btn_Modificar.Enabled = False
        End If
    End Sub

    Sub ModificarTipodeCambio()
        tbx_Moneda.Text = lsv_TipodeCambio.SelectedItems(0).SubItems(1).Text
        tbx_Moneda.Tag = lsv_TipodeCambio.SelectedItems(0).Tag
        tbx_Fecha.Text = lsv_TipodeCambio.SelectedItems(0).SubItems(0).Text
        tbx_TipoCambioAntes.Text = lsv_TipodeCambio.SelectedItems(0).SubItems(3).Text

    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        Call ModificarTipodeCambio()
        Tab_TipoCambio.SelectedIndex = 1

        btn_Guardar.Enabled = True

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Modificar.Enabled = False
    End Sub

    Private Sub Tab_TipoCambio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_TipoCambio.SelectedIndexChanged
        If Tab_TipoCambio.SelectedIndex = 1 Then
            lsv_TipodeCambio.Items.Clear()
            Lbl_Registros.Text = "Registros: 0"
            tbx_TipoCambioNuevo.Focus()
        Else
            Call LimpiaTexbox()
        End If
    End Sub

    Sub LimpiaTexbox()
        tbx_Moneda.Text = ""
        tbx_Moneda.Tag = ""
        tbx_Fecha.Text = ""
        tbx_TipoCambioAntes.Text = ""
        btn_Guardar.Enabled = False
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If tbx_TipoCambioNuevo.Text = "" Then
            MsgBox("Capture el nuevo tipo de cambio para reemplazar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_TipoCambioNuevo.Focus()
            Exit Sub

        End If

        If Not Cn_Facturacion.fn_TiposdeCambio_Modificar(tbx_Moneda.Tag, tbx_TipoCambioNuevo.Text) Then
            MsgBox("Ocurrió un error al modificar los datos en tipo de cambio.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_TipoCambioNuevo.Focus()
            Exit Sub
        Else
            MsgBox("Datos Guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LimpiaTexbox()
            Tab_TipoCambio.SelectedIndex = 0
            btn_Mostrar_Click(btn_Mostrar, New EventArgs)
        End If
        'funcion guarda cambios

    End Sub

    Private Sub cmb_Monedas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Monedas.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"

    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lsv_TipodeCambio.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
    End Sub
End Class