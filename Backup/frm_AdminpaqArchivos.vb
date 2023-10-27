Imports System.IO

Public Class frm_AdminpaqArchivos

    Public RespaldoRealizado As Boolean = False
    Public CarpetaDestino As String = ""

    Private Sub HabilitarForm()
        btn_Cerrar.Enabled = True
        btn_Copiar.Enabled = True
        btn_Copiar.Text = "Actualizar Respaldos"
        prg_Barra.Value = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Copiar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        btn_Cerrar.Enabled = False
        btn_Copiar.Enabled = False
        If tbx_Ruta.TextLength = 0 Then
            MsgBox("Debe indicar la Ruta de los Archivos.", MsgBoxStyle.Critical, frm_MENU.Text)
            btn_Examinar.Focus()
            btn_Cerrar.Enabled = True
            btn_Copiar.Enabled = True
            Exit Sub
        End If
        Dim RutaOrigen As String = tbx_Ruta.Text
        'CarpetaDestino = My.Application.Info.DirectoryPath
        CarpetaDestino = "C:\SIACAdm"
        Dim Cantidad As Integer = 0
        Me.Cursor = Cursors.WaitCursor
        prg_Barra.Value = 0
        prg_Barra.Maximum = 19
        Try
            If Not IO.Directory.Exists(CarpetaDestino) Then
                IO.Directory.CreateDirectory(CarpetaDestino)
            End If
            'CLIENTES
            btn_Copiar.Text = "Copiando Clientes..."
            If File.Exists(RutaOrigen & "\MGW10002.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10002.dbf")
                File.Copy(RutaOrigen & "\MGW10002.dbf", CarpetaDestino & "\MGW10002.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10002.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Clientes. Imposible Continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call HabilitarForm()
                Exit Sub
            End If

            If File.Exists(RutaOrigen & "\MGW10002.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10002.cdx")
                File.Copy(RutaOrigen & "\MGW10002.cdx", CarpetaDestino & "\MGW10002.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10002.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10002.fpt")
                File.Copy(RutaOrigen & "\MGW10002.fpt", CarpetaDestino & "\MGW10002.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

            'PRODUCTOS
            btn_Copiar.Text = "Copiando Productos..."
            If File.Exists(RutaOrigen & "\MGW10005.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10005.dbf")
                File.Copy(RutaOrigen & "\MGW10005.dbf", CarpetaDestino & "\MGW10005.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10005.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Productos. Imposible Continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call HabilitarForm()
                Exit Sub
            End If
            If File.Exists(RutaOrigen & "\MGW10005.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10005.cdx")
                File.Copy(RutaOrigen & "\MGW10005.cdx", CarpetaDestino & "\MGW10005.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10005.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10005.fpt")
                File.Copy(RutaOrigen & "\MGW10005.fpt", CarpetaDestino & "\MGW10005.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

            'TIPOS DE DOCUMENTOS
            btn_Copiar.Text = "Copiando Tipos de Documentos..."
            If File.Exists(RutaOrigen & "\MGW10007.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10007.dbf")
                File.Copy(RutaOrigen & "\MGW10007.dbf", CarpetaDestino & "\MGW10007.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10007.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Tipos de Documentos. Imposible Continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If File.Exists(RutaOrigen & "\MGW10007.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10007.cdx")
                File.Copy(RutaOrigen & "\MGW10007.cdx", CarpetaDestino & "\MGW10007.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10007.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10007.fpt")
                File.Copy(RutaOrigen & "\MGW10007.fpt", CarpetaDestino & "\MGW10007.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

            'DOCUMENTOS
            btn_Copiar.Text = "Copiando Documentos..."
            If File.Exists(RutaOrigen & "\MGW10008.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10008.dbf")
                File.Copy(RutaOrigen & "\MGW10008.dbf", CarpetaDestino & "\MGW10008.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10008.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Documentos. Imposible Continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call HabilitarForm()
                Exit Sub
            End If
            If File.Exists(RutaOrigen & "\MGW10008.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10008.cdx")
                File.Copy(RutaOrigen & "\MGW10008.cdx", CarpetaDestino & "\MGW10008.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10008.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10008.fpt")
                File.Copy(RutaOrigen & "\MGW10008.fpt", CarpetaDestino & "\MGW10008.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

            'MOVIMIENTOS
            btn_Copiar.Text = "Copiando Movimientos..."
            If File.Exists(RutaOrigen & "\MGW10010.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10010.dbf")
                File.Copy(RutaOrigen & "\MGW10010.dbf", CarpetaDestino & "\MGW10010.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10010.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Movimientos. Imposible continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call HabilitarForm()
                Exit Sub
            End If
            If File.Exists(RutaOrigen & "\MGW10010.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10010.cdx")
                File.Copy(RutaOrigen & "\MGW10010.cdx", CarpetaDestino & "\MGW10010.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10010.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10010.fpt")
                File.Copy(RutaOrigen & "\MGW10010.fpt", CarpetaDestino & "\MGW10010.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

            'DIRECCIONES
            btn_Copiar.Text = "Copiando Direcciones..."
            If File.Exists(RutaOrigen & "\MGW10011.dbf") Then
                File.Delete(CarpetaDestino & "\MGW10011.dbf")
                File.Copy(RutaOrigen & "\MGW10011.dbf", CarpetaDestino & "\MGW10011.dbf", True)
                File.SetCreationTime(CarpetaDestino & "\MGW10011.dbf", DateTime.Now)
                prg_Barra.Value += 1
            Else
                MsgBox("No se encontró el Catálogo de Direcciones. Imposible continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call HabilitarForm()
                Exit Sub
            End If
            If File.Exists(RutaOrigen & "\MGW10011.cdx") Then
                File.Delete(CarpetaDestino & "\MGW10011.cdx")
                File.Copy(RutaOrigen & "\MGW10011.cdx", CarpetaDestino & "\MGW10011.cdx", True)
                prg_Barra.Value += 1
            End If
            If File.Exists(RutaOrigen & "\MGW10011.fpt") Then
                File.Delete(CarpetaDestino & "\MGW10011.fpt")
                File.Copy(RutaOrigen & "\MGW10011.fpt", CarpetaDestino & "\MGW10011.fpt", True)
                prg_Barra.Value += 1
            End If
            Cantidad += 1
            Me.Refresh()

        Catch ex As Exception
            RespaldoRealizado = False
            btn_Cerrar.Enabled = True
            Me.Cursor = Cursors.Default
            FuncionesGlobales.TrataEx(ex)
            btn_Copiar.Text = "Error al Copiar"
            Me.Refresh()
            MsgBox("Ocurrió un error al intentar realizar el respaldo. Solo se copiaron " & Cantidad.ToString & " Archivos de 5 que se requieren.", MsgBoxStyle.Information, frm_MENU.Text)
            btn_Copiar.Text = "Copiar Ahora"
            Exit Sub
        End Try
        btn_Cerrar.Enabled = True
        btn_Copiar.Enabled = True
        btn_Copiar.Text = "Copia Finalizada..."
        Me.Refresh()
        prg_Barra.Value = prg_Barra.Maximum
        Me.Cursor = Cursors.Default
        btn_Copiar.Text = "Copiar Ahora"
        If Cantidad = 6 Then
            RespaldoRealizado = True
            MsgBox("Respaldo Realizado Correctamente... " & Cantidad.ToString & " Archivos Copiados.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("El Respaldo no se ealizado Correctamente... " & Chr(13) & "Solo se copiaron " & Cantidad.ToString & " Archivos de los 6 requeruidos.", MsgBoxStyle.Information, frm_MENU.Text)
            RespaldoRealizado = False
        End If
        Me.Refresh()
        Me.Close()
    End Sub

    Private Sub btn_Examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Examinar.Click
        Dim Dialogo As New FolderBrowserDialog
        Dialogo.ShowDialog()
        tbx_Ruta.Text = Dialogo.SelectedPath
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
End Class