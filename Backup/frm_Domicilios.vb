Imports Modulo_Facturacion.Cn_Facturacion
Imports Modulo_Facturacion.FuncionesGlobales
Imports System.IO

Public Class frm_Domicilios

    Dim dt_Domicilios As DataTable
    Dim Tipo As String = ""

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Comerciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Comerciales.Click
        Tipo = ""
        lbl_Registros.Text = "0 Registros Leídos"
        btn_Guardar.Enabled = False
        dt_Domicilios = fn_Antilavado_GetDomicilios(0, "01/01/2010")
        If dt_Domicilios Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar obtener los domicilios de los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub 'salir si ocurrio error
        End If

        If dt_Domicilios.Rows.Count = 0 Then
            MsgBox("No se encontraron datos de los Domicilios de los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Tipo = "C"
        lbl_Registros.Text = dt_Domicilios.Rows.Count.ToString & " Registros Leídos"
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Fiscales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fiscales.Click
        Tipo = ""
        lbl_Registros.Text = "0 Registros Leídos"
        btn_Guardar.Enabled = False
        dt_Domicilios = fn_Antilavado_GetDomiciliosF(0, "01/01/2000")
        If dt_Domicilios Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar obtener los domicilios de los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub 'salir si ocurrio error
        End If

        If dt_Domicilios.Rows.Count = 0 Then
            MsgBox("No se encontraron datos de los Domicilios de los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Tipo = "F"
        lbl_Registros.Text = dt_Domicilios.Rows.Count.ToString & " Registros Leídos"
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Contador As Integer = 0
        Dim ContadorError As Integer = 0
        If Tipo = "" Then
            MsgBox("Para poder guardar los Domicilios primero debe leer la información.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        pgb.Maximum = dt_Domicilios.Rows.Count + 1
        Me.Cursor = Cursors.WaitCursor
        'Recorrer cada uno de nuevo para buscar el Domicilio en la otra Consulta
        Dim Domicilio As String = ""
        Dim Resp As Integer
        Dim cmd As SqlClient.SqlCommand
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        For Each Dr_Dom As DataRow In dt_Domicilios.Rows
            Domicilio = ""
            'Armar el Domicilio
            If Tipo = "C" Then
                Domicilio &= Dr_Dom("Calle_Comercial")
                If Dr_Dom("Numero_Comercial") <> 0 Then
                    Domicilio &= " "
                    Domicilio &= Dr_Dom("Numero_Comercial")
                    If Dr_Dom("NumeroInt_Comercial") <> "" Then
                        Domicilio &= " INT "
                        Domicilio &= Dr_Dom("NumeroInt_Comercial")
                    End If
                End If
                If Dr_Dom("Colonia_Comercial").ToString.Trim <> "" Then
                    Domicilio &= ", "
                    Domicilio &= Dr_Dom("Colonia_Comercial")
                End If
                If Domicilio.Trim <> "" Then
                    Domicilio &= ", "
                End If
                Domicilio &= Dr_Dom("Ciudad")
                Domicilio &= ", "
                Domicilio &= Dr_Dom("Estado")
                Domicilio &= ", "
                Domicilio &= Dr_Dom("Pais")
                If Dr_Dom("CP_Comercial") > 0 Then
                    Domicilio &= " CP "
                    Domicilio &= Dr_Dom("CP_Comercial")
                End If
            ElseIf Tipo = "F" Then
                Domicilio &= Dr_Dom("Calle_Fiscal")
                If Dr_Dom("Numero_Fiscal") <> 0 Then
                    Domicilio &= " "
                    Domicilio &= Dr_Dom("Numero_Fiscal")
                    If Dr_Dom("NumeroInt_Fiscal") <> "" Then
                        Domicilio &= " INT "
                        Domicilio &= Dr_Dom("NumeroInt_Fiscal")
                    End If
                End If
                If Dr_Dom("Colonia_Fiscal").ToString.Trim <> "" Then
                    Domicilio &= ", "
                    Domicilio &= Dr_Dom("Colonia_Fiscal")
                End If
                If Domicilio.Trim <> "" Then
                    Domicilio &= ", "
                End If
                Domicilio &= Dr_Dom("Ciudad")
                Domicilio &= ", "
                Domicilio &= Dr_Dom("Estado")
                Domicilio &= ", "
                Domicilio &= Dr_Dom("Pais")
                If Dr_Dom("CP_Fiscal") > 0 Then
                    Domicilio &= " CP "
                    Domicilio &= Dr_Dom("CP_Fiscal")
                End If
            End If
            cmd = Cn_Datos.Crea_Comando("Cat_Clientes_UpdateDomicilio", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Dr_Dom("Id_Cliente"))
            Cn_Datos.Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, Tipo)
            Cn_Datos.Crea_Parametro(cmd, "@Domicilio", SqlDbType.VarChar, Domicilio)
            Resp = Cn_Datos.EjecutarNonQuery(cmd)
            Contador += 1
            pgb.Value += 1
            If pgb.Value = pgb.Maximum Then pgb.Maximum += 1
            If Resp < 1 Then
                Contador -= 1
                ContadorError += 1
                MsgBox("Ocurrió un error al intentar actualizar el domicilio del Cliente: " & Dr_Dom("Nombre_Comercial"), MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Next

        Me.Cursor = Cursors.Default
        MsgBox(Contador.ToString & " Domicilios actualizados correctamente. " & ContadorError.ToString & " Errores al guardar.", MsgBoxStyle.Information, frm_MENU.Text)
        btn_Guardar.Enabled = False
        lbl_Registros.Text = "0 Registros Leídos"
        pgb.Value = 0
        Tipo = ""
    End Sub



End Class