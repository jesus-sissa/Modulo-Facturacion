Imports System.IO
Imports Modulo_Facturacion.Cn_Facturacion
Imports Modulo_Facturacion.FuncionesGlobales

Public Class frm_EnviarMail

    Private Sub frm_EnviarMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Destinos.Columns.Add("Contacto", 100)
        lsv_Destinos.Columns.Add("Tipo", 100)
        lsv_Destinos.Columns.Add("Correo", 100)
    End Sub

    Private Sub btn_Archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Archivo.Click
        SegundosDesconexion = 0

        lsv_Destinos.Items.Clear()
        rtb_Archivo.Clear()
        rtb_Archivo.Tag = Nothing

        With ofd_Archivo
            .Multiselect = False
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Todos los Archivos (*.*)|*.*"
        End With

        If ofd_Archivo.ShowDialog = DialogResult.OK Then
            rtb_Archivo.Text = Path.GetFileNameWithoutExtension(ofd_Archivo.FileName)
            rtb_Archivo.Tag = ofd_Archivo.FileName
            Dim Clave() As String = Split(rtb_Archivo.Text)
            If Clave(0) IsNot Nothing AndAlso Clave(0) <> "" Then
                If Not fn_EnviarMail_BuscarCorreos(Clave(0), lsv_Destinos) Then
                    MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                MsgBox("El Nombre del Archivo es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub lsv_Destinos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Destinos.ItemChecked
        SegundosDesconexion = 0

        'Sólo deja palomear a los que tengan un correo correcto
        If e.Item.Checked Then e.Item.Checked = fn_ValidarMail(e.Item.SubItems(1).Text)
        btn_EnviarMail.Enabled = lsv_Destinos.CheckedItems.Count > 0
    End Sub

    Private Sub btn_EnviarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EnviarMail.Click
        SegundosDesconexion = 0

        For Each Elemento As ListViewItem In lsv_Destinos.CheckedItems
            Cn_Mail.fn_Enviar_Mail(Elemento.SubItems(1).Text, rtb_Archivo.Text, rtb_Texto.Text, rtb_Archivo.Tag)
        Next
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class