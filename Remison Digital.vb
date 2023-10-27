Imports FuncionesGlobales
Public Class frm_Remison_Digital


    Private Sub frm_Remison_Digital_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim folder As New FolderBrowserDialog
        Dim ruta As String = String.Empty

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = folder.SelectedPath
        End If


        TxtRuta.Text = ruta
    End Sub


    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs)
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim folder As New FolderBrowserDialog
        Dim ruta As String = String.Empty

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = folder.SelectedPath
        End If


        TxtRuta.Text = ruta
    End Sub

    Private Sub Btn_Descargar_Click(sender As Object, e As EventArgs) Handles Btn_Descargar.Click


        If TxtRuta.Text = "" Then
            MsgBox("Debe seleccionar una Ubicación primero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If tbx_numeroRemision.Text = "" Then
            MsgBox("ingrese el número de Remision.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_numeroRemision.Focus()
            Exit Sub
        End If
        Dim Path = TxtRuta.Text.Trim
        'Cn_Facturacion.fn_RemisonDigitalWeb(Lsv_Rutas, tbx_Remision.Text)

        Try
            Dim dtPDF As DataTable = Cn_Facturacion.fn_ObtenerMateriales(tbx_numeroRemision.Text)

            If dtPDF.Rows.Count > 0 Then
                Dim envase = ""
                Dim envasesello = ""
                For Each row As DataRow In dtPDF.Rows
                    If envase <> row("EnvaseN").ToString Then
                        envasesello += "[" + row("EnvaseN").ToString + "]"
                        envase = row("EnvaseN").ToString

                    End If


                Next

                envase = ""
                Dim acces As Boolean = True
                For Each rows As DataRow In dtPDF.Rows
                    If envase = rows("EnvaseN").ToString Then
                        envasesello += "/" & rows("Cantidad").ToString & " " & rows("Descripcion").ToString
                    Else
                        If acces Then
                            envasesello += "/" & rows("Cantidad").ToString & " " & rows("Descripcion").ToString
                            envase = rows("EnvaseN").ToString
                            acces = False

                        End If
                    End If
                Next

                Remision_Digital.PdfMateriales(dtPDF, envasesello, Path)
                MsgBox($"La remision se genero correctamente-->{TxtRuta.Text.Trim}", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_numeroRemision.Clear()
            Else
                MsgBox("Ocurrio un error VERIFIQUE EL NUMERO DE REMISION.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_numeroRemision.Clear()
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error.", MsgBoxStyle.Critical, frm_MENU.Text)
            'tbx_Remision.Clear()
        End Try

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub
End Class