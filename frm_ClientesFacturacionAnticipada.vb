Public Class frm_ClientesFacturacionAnticipada

    Sub Buscar()
        SegundosDesconexion = 0
        chk_Todos.Checked = False
        If tbx_Buscar.Text.Trim = "" Then tbx_Buscar.Focus()
        If Cn_Facturacion.fn_LlenarListaClientesFacturacionAnticipada(Lsv_Clientes, tbx_Buscar.Text.Trim, IIf(rdb_ClaveCliente.Checked, "CC", "CQ")) Then
            lbl_Registros.Text = "Registros : " + Lsv_Clientes.Items.Count.ToString
        End If
    End Sub

    Private Sub chk_Todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Todos.CheckedChanged
        If chk_Todos.Checked = True Then
            For Each Item As ListViewItem In Lsv_Clientes.Items
                Item.Checked = True
            Next
        Else
            For Each Item As ListViewItem In Lsv_Clientes.CheckedItems
                Item.Checked = False
            Next

        End If
    End Sub
    Private Sub Lsv_Clientes_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Lsv_Clientes.ItemChecked
        For Each Item As ListViewItem In Lsv_Clientes.CheckedItems
            If Item.SubItems(3).Text = "2" Then Item.Checked = False
        Next
        If Lsv_Clientes.CheckedItems.Count > 0 Then
            lbl_UUID.Enabled = True
            tbx_UUID.Enabled = True
            btn_Guardar.Enabled = True
            tbx_UUID.Focus()
        Else
            lbl_UUID.Enabled = False
            tbx_UUID.Enabled = False
            btn_Guardar.Enabled = False
            tbx_UUID.Text = Nothing
            tbx_Buscar.Focus()
        End If
        SegundosDesconexion = 0
    End Sub
    Sub Limpiar()
        tbx_UUID.Text = Nothing
        lbl_UUID.Enabled = False
        tbx_UUID.Enabled = False
        btn_Guardar.Enabled = False
        Buscar()
    End Sub
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Se cambiara el UUID de: " + Lsv_Clientes.CheckedItems.Count.ToString + " clientes.", "SIAC", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            For Each item In Lsv_Clientes.CheckedItems
                Cn_Facturacion.fn_LlenarListaClientesFacturacionAnticipada_Update(item.Tag, tbx_UUID.Text)
            Next
            Limpiar()
        End If

    End Sub

    Private Sub btn_Buscar_Click_1(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Buscar()
    End Sub

    Private Sub rdb_ClaveCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_ClaveCliente.CheckedChanged
        tbx_Buscar.Enabled = True
        Buscar()
        tbx_Buscar.Focus()

    End Sub

    Private Sub rdb_Conpaq_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Conpaq.CheckedChanged
        tbx_Buscar.Enabled = True
        Buscar()
        tbx_Buscar.Focus()

    End Sub

    Private Sub tbx_Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If tbx_Buscar.TextLength > 0 AndAlso Asc(e.KeyChar) = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub frm_ClientesFacturacionAnticipada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_Buscar.Focus()
    End Sub
End Class