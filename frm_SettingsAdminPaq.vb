Public Class frm_SettingsAdminPaq

    Private Sub frm_SettingsAdminPaq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdb_NO.Checked = False
        rdb_SI.Checked = False

        If My.Settings.TieneAdminPaq = "S" Then
            rdb_SI.Checked = True
        ElseIf My.Settings.TieneAdminPaq = "N" Then
            rdb_NO.Checked = True
        Else
            rdb_NO.Checked = False
            rdb_SI.Checked = False
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim enlazarAdminpaq As Char

        If rdb_NO.Checked Then
            enlazarAdminpaq = "N"
        ElseIf rdb_SI.Checked Then
            enlazarAdminpaq = "S"
        End If
        My.Settings.TieneAdminPaq = enlazarAdminpaq
        My.Settings.Save()

        MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, frm_MENU.Text)

        ' leer si tiene enlace con adminpaq
        tieneAdminPaq = My.Settings.TieneAdminPaq

        Me.Close()
    End Sub
End Class