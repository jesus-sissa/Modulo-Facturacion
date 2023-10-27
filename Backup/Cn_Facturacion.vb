Imports Modulo_Facturacion.FuncionesGlobales
Imports Modulo_Facturacion.Cn_Datos
Imports System.Data.SqlClient
Imports System.IO


Public Class Cn_Facturacion

#Region "Menu"

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos IsNot Nothing Then
                If Dt_Destinos.Rows.Count = 0 Then
                    MsgBox("No se encotnraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
                If Adjunto <> "" Then
                    Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
                End If

                'Guardar la alerta para cada destino
                For Each Destino As DataRow In Dt_Destinos.Rows
                    cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                    Crea_Parametro(cmd, "@Detalles", SqlDbType.VarChar, Microsoft.VisualBasic.Left(Detalles, 150))
                    Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                    Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                    Id_Alerta = CInt(EjecutarScalar(cmd))
                    'Guardar el Detalle para cada alerta generada
                    If AlertasD IsNot Nothing Then
                        For Each dr As DataRow In AlertasD.Rows
                            cmd.Parameters.Clear()
                            cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                            Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                            Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                            EjecutarNonQuery(cmd)
                        Next
                    End If
                    If EnviarMail Then
                        Select Case Clave_AlertaTipo
                            Case "39"
                                Encabezado = "DIFERENCIA EN AUDITORIA DE CAJEROS"

                        End Select

                        Pie = "Agente de Servicios SIAC " & Now.Year.ToString

                        If DetallesHTML = "" Then
                            Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles, Adjunto)
                            'Cn_Mail.fn_Enviar_Mail("raul.coss@sissaseguridad.com", Asunto, Detalles, Adjunto)
                            'Cn_Mail.fn_Enviar_Mail("jose.nuncio@sissaseguridad.com", Asunto, Detalles, Adjunto)
                            'Exit Function
                        Else
                            DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                            DetallesHTML = Replace(DetallesHTML, "Pie", Pie)

                            Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                            'Cn_Mail.fn_Enviar_MailHTML("raul.coss@sissaseguridad.com", Asunto, DetallesHTML, Adjunto)
                            'Cn_Mail.fn_Enviar_MailHTML("jose.nuncio@sissaseguridad.com", Asunto, DetallesHTML, Adjunto)
                            'Exit Function
                        End If
                    End If
                Next
                Return True
            Else
                'No se encontraron destinos
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Buscar Cliente"

    ''' <summary>
    ''' Llena la lista lsv_Clientes
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarLista(ByVal lsv As cp_Listview, Optional ByVal Cliente As Boolean = True) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesCombo_GetAB", CommandType.StoredProcedure, Crea_ConexionSTD)


        'Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        'If Cliente = False Then
        '    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
        'Else
        '    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        'End If

        Try
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Empleados
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaEmpleados(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_ComboGetActivos", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Cajas Bancarias
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaCajasBancarias(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            lsv.Actualizar(cmd, "Id_CajaBancaria")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Consulta de Traslados"

    Public Shared Function fn_Movimientos_Reporte(ByVal FDesde As Date, ByVal FHasta As Date, ByVal Stastus As Char, ByVal Id_Cliente As Long, ByVal ConsultaNormal As Boolean, ByVal Lista As cp_Listview, ByVal Tipo_Mov As Char, ByVal IncluirCV As Char) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            If ConsultaNormal Then
                Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Get", CommandType.StoredProcedure, Cnn)
            Else
                Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_GetCantidad", CommandType.StoredProcedure, Cnn)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Stastus)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, Tipo_Mov)
            Cn_Datos.Crea_Parametro(Cmd, "@IncluirCV", SqlDbType.VarChar, IncluirCV)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Movimiento")
            If ConsultaNormal Then
                Lista.Columns(5).TextAlign = HorizontalAlignment.Right
                Lista.Columns(6).TextAlign = HorizontalAlignment.Right
                Lista.Columns(7).TextAlign = HorizontalAlignment.Right
                Lista.Columns(8).TextAlign = HorizontalAlignment.Right
                Lista.Columns(9).TextAlign = HorizontalAlignment.Right
                Lista.Columns(10).TextAlign = HorizontalAlignment.Right
                Lista.Columns(12).Width = 0
            End If

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_MovimientosDLlenarLista(ByVal Id_Movimiento As Long, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MovimientosD_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Remision")
            Lista.Columns(2).TextAlign = HorizontalAlignment.Right
            Lista.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RemisionesDLlenarLista(ByVal Id_Remision As Long, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Moneda")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Agregar Movimientos"

    Public Shared Function fn_AgregarMovimientos_CSRead(ByVal Id_CS As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Dim dat As DataTable
        Try
            'Consulta de Datos de un Movimiento
            cmd = Cn_Datos.Crea_Comando("Cat_ClientesServicios_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CS", SqlDbType.BigInt, Id_CS)

            dat = Cn_Datos.EjecutaConsulta(cmd)
            cmd.Dispose()
            Cnn.Dispose()
            Return dat
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Remision_Consultar(ByVal Id_Remision As Long, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_GetById", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Remision")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_Create(ByVal Tipo_Mov As String, ByVal Hora As String, ByVal Id_Cliente As Integer, ByVal Id_Precio As Integer, ByVal Id_CR As Integer, ByVal Id_EE As Integer, ByVal Id_KM As Integer, ByVal Id_Ruta As Integer, ByVal Id_CS As Integer, ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal Importe As Decimal, ByVal Miles As Integer, ByVal Envases_Exceso As Integer, ByVal Kilometros As Integer) As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de quien valida
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Create", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Mov", SqlDbType.VarChar, Tipo_Mov)
            Cn_Datos.Crea_Parametro(cmd, "@Hora", SqlDbType.VarChar, Hora)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.BigInt, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)

            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.BigInt, Id_Cliente)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.BigInt, Id_Ruta)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Precio", SqlDbType.BigInt, Id_Precio)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CR", SqlDbType.Int, Id_CR)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EE", SqlDbType.Int, Id_EE)
            Cn_Datos.Crea_Parametro(cmd, "@Id_KM", SqlDbType.Int, Id_KM)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)

            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
            Cn_Datos.Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(cmd, "@Miles", SqlDbType.Money, Miles)
            Cn_Datos.Crea_Parametro(cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
            Cn_Datos.Crea_Parametro(cmd, "@Kilometros", SqlDbType.Int, Kilometros)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Dim Retorno As Long = Cn_Datos.EjecutarScalar(cmd)
            cmd.Dispose()
            Cnn.Dispose()
            Return Retorno
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Remision_Guardar2(ByVal NumeroRemision As Long, ByVal Envases As Integer, _
                                                     ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                     ByVal IdCia As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal Id_Movimiento As Long) As Long
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Long
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
                
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return 0
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return lc_identity
    End Function

#End Region

#Region "Validar Movimientos"

    Public Shared Function fn_Movimientos_ConsultaValidar(ByVal Numero_Remision As Long, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Movimientos_GetByRemision", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Movimiento")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_ConsultaPrecios(ByVal Id_Cliente As Long, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_PreciosContratados_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_Read(ByVal Id_Movimiento As Long) As DataTable
        Dim dt As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Movimientos_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)

            dt = Cn_Datos.EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return dt
        End Try
    End Function

    Public Shared Function fn_RemisionDetalle_Read(ByVal Id_Remision As Long) As DataTable
        Dim dt As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            dt = EjecutaConsulta(Cmd)
            'If dt.Rows.Count = 0 Then
            'MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
            'Return dt
            'Else

            dt.Columns(2).ReadOnly = False
            dt.Columns(3).ReadOnly = False

            Return dt
            'End If

        Catch ex As Exception
            TrataEx(ex)
            Return dt
        End Try
    End Function

    Public Shared Function fn_RemisionEnvases_Get(ByVal Lsv As cp_Listview, ByVal Id_Remision As Long) As Boolean
        Dim dt As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Envases_Get3", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            Lsv.Actualizar(Cmd, "Id_Envase")
            Return True
            'End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_MonedasTC() As DataTable

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Monedas_GetTipoCambio", CommandType.StoredProcedure, Cnn)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else

                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False

                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Movimientos_ValidarRemision(ByVal Id_Movimiento As Long, ByVal Id_Remision As Long, ByVal Status As String, ByVal dt_Importes As DataTable, ByVal Envases As Integer, ByVal EnvasesSn As Integer, ByVal Importe As Decimal, ByVal Hora_Remision As String, ByVal DotacionBillete As String, ByVal DotacionMorralla As String, ByVal PagoMorralla As String, ByVal PagoNomina As String, ByVal NominaProcesada As String, ByVal Cantidad_Sobres As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Dim Tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Try
            cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
            For Each lc_dr As DataRow In dt_Importes.Rows
                'actualizar los datos de la Remisión
                cmd.Parameters.Clear()
                Cn_Datos.Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(cmd)
            Next
            'Actualizar los datos de quien valida
            cmd.Parameters.Clear()
            cmd.CommandText = "Cat_MovimientosD_Validar"
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.BigInt, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Cn_Datos.Crea_Parametro(cmd, "@DotacionBillete", SqlDbType.VarChar, DotacionBillete)
            Cn_Datos.Crea_Parametro(cmd, "@DotacionMorralla", SqlDbType.VarChar, DotacionMorralla)
            Cn_Datos.Crea_Parametro(cmd, "@PagoMorralla", SqlDbType.VarChar, PagoMorralla)
            Cn_Datos.Crea_Parametro(cmd, "@PagoNomina", SqlDbType.VarChar, PagoNomina)
            Cn_Datos.Crea_Parametro(cmd, "@NominaProcesada", SqlDbType.VarChar, NominaProcesada)
            Cn_Datos.EjecutarNonQueryT(cmd)

            'Actualizar los Datos de la Remision: EnvasesSN e Importe
            cmd.Parameters.Clear()
            cmd.CommandText = "Cat_Remisiones_Update"
            Cn_Datos.Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSn)
            Cn_Datos.Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Remision", SqlDbType.VarChar, Hora_Remision)
            Cn_Datos.EjecutarNonQueryT(cmd)

            'Actualizar la cantidad de Sobres en Pro_Dotaciones
            cmd.Parameters.Clear()
            cmd.CommandText = "Pro_Dotaciones_UpdateSobres"
            Cn_Datos.Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Sobres", SqlDbType.Int, Cantidad_Sobres)
            Cn_Datos.EjecutarNonQueryT(cmd)

            Tr.Commit()
            cmd.Dispose()
            Cnn.Dispose()
            Tr.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            cmd.Dispose()
            Cnn.Dispose()
            Tr.Dispose()
            Return False
        End Try

    End Function

    Public Shared Function fn_Movimientos_AgregarEnvase(ByVal Id_Remision As Integer, ByVal Numero_Envase As String, ByVal Id_Tipo As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Envases_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Id_Tipo)
        Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Numero_Envase)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Movimientos_EliminarEnvase(ByVal Id_Envase As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Envases_DeleteById", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Envase", SqlDbType.Int, Id_Envase)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Movimientos_ValidarServicio(ByVal Id_Movimiento As Long, ByVal Status As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de quien valida
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Valida", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.BigInt, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            If Cn_Datos.EjecutarNonQuery(cmd) > 0 Then
                'si se hizo
                'MsgBox("Si se validó")
            End If
            cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_ConsultaDatos(ByVal Id_Movimiento As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Dim dat As DataTable
        Try
            'Consulta de Datos de un Movimiento
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_GetDatosByID", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)

            dat = Cn_Datos.EjecutaConsulta(cmd)
            cmd.Dispose()
            Cnn.Dispose()
            Return dat
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Movimientos_UpdateIDs(ByVal Id_Movimiento As Integer, ByVal Id_Cliente As Integer, ByVal Id_CS As Integer, ByVal Id_Precio As Integer, ByVal Id_CR As Integer, ByVal Id_EE As Integer, ByVal Id_KM As Integer, ByVal Id_Ruta As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de quien valida
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_UpdateIDs", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.BigInt, Id_Cliente)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Precio", SqlDbType.BigInt, Id_Precio)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CR", SqlDbType.BigInt, Id_CR)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EE", SqlDbType.BigInt, Id_EE)
            Cn_Datos.Crea_Parametro(cmd, "@Id_KM", SqlDbType.BigInt, Id_KM)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.BigInt, Id_Ruta)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CS", SqlDbType.BigInt, Id_CS)

            If Cn_Datos.EjecutarNonQuery(cmd) > 0 Then
                'si se hizo
                'MsgBox("Si se validó")
            End If
            cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_Update(ByVal Id_Movimiento As Integer, ByVal Id_Cliente As Integer, ByVal Id_CS As Integer, ByVal Id_Precio As Integer, ByVal Id_CR As Integer, ByVal Id_EE As Integer, ByVal Id_KM As Integer, ByVal Id_Ruta As Integer, ByVal Fecha As Date, ByVal Hora As String, ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal Importe As Decimal, ByVal Miles As Integer, ByVal Envases_Exceso As Integer, ByVal Kilometros As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de un Movimiento
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Update", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.BigInt, Id_Cliente)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Precio", SqlDbType.BigInt, Id_Precio)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CR", SqlDbType.BigInt, Id_CR)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EE", SqlDbType.BigInt, Id_EE)
            Cn_Datos.Crea_Parametro(cmd, "@Id_KM", SqlDbType.BigInt, Id_KM)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.BigInt, Id_Ruta)
            Cn_Datos.Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Cn_Datos.Crea_Parametro(cmd, "@Hora", SqlDbType.VarChar, Hora)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
            Cn_Datos.Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(cmd, "@Miles", SqlDbType.Money, Miles)
            Cn_Datos.Crea_Parametro(cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
            Cn_Datos.Crea_Parametro(cmd, "@Kilometros", SqlDbType.Int, Kilometros)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)

            If Cn_Datos.EjecutarNonQuery(cmd) > 0 Then
                'si se hizo
                'MsgBox("Si se validó")
            End If
            cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_MonedasGridView() As DataTable

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Monedas_GetTipoCambio", CommandType.StoredProcedure, Cnn)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else

                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False

                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidaRemision(ByVal Numero_Remision As Long) As Boolean
        'Return fn_ValidarClave(Clave, "@Id_Remision", "Cat_Remisiones_StatusValida")
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_Existe", CommandType.StoredProcedure, Cnn)
        'Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.BigInt, CiaId)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaIdRemision(ByVal Numero_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.BigInt, CiaId)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Remision_Guardar(ByVal NumeroRemision As Long, ByVal Envases As Integer, _
                                                     ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                     ByVal IdCia As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal Id_Movimiento As Long) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
                'If CInt(lc_dr(2)) = 0 And CInt(lc_dr(3)) = 0 Then

                'Else
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
                'End If
            Next
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            'Ligar el Movimiento con la Remision
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_MovimientosD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True
    End Function

    Public Shared Function fn_MovimientosD_Guardar(ByVal Id_Movimiento As Long, ByVal Id_Remision As Long) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand

        Try
            'Ligar el Movimiento con la Remision
            Cmd = Cn_Datos.Crea_Comando("CAT_MovimientosD_Create", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Dotacion_Billete", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Dotacion_Morralla", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Pago_Morralla", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Pago_Nomina", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Nomina_Procesada", SqlDbType.VarChar, "N")
            Cn_Datos.EjecutarNonQuery(Cmd)
        Catch ex As Exception
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_MovimientosD_Eliminar(ByVal Id_Movimiento As Long, ByVal Id_Remision As Long) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Eliminar la Remision de MovimientosD
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_MovimientosD_Delete")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Validar si tiene Mas Remisiones el movimiwento
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_MovimientosD_Existe")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Dim dt_Movimientos As DataTable = Cn_Datos.EjecutaConsultaT(Cmd)

            If dt_Movimientos IsNot Nothing AndAlso dt_Movimientos.Rows.Count = 0 Then
                'En caso de que traiga 0, Eliminar Movimiento
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Movimientos_Delete")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
                Cn_Datos.EjecutarNonQueryT(Cmd)

            End If
           
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_ConsultaRemisionesD(ByVal Id_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                'MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaEnvasesRemision(ByVal Id_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Envases_Get2", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                'MsgBox("No existe el registro solicitado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidarMovimientos_ObtenerImportes(ByVal Id_Remision As Long) As Decimal
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GetProcesado", CommandType.StoredProcedure, Cnn)
        Try
            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)

            Dim ImporteProcesado As Decimal = EjecutarScalar(Cmd)

            Return ImporteProcesado
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

#End Region

#Region "Pre Factura -Imp Lavado 05/04/2016"

    Public Shared Function fn_PreFactura_GetReporte2(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Movimientos_GetPrefactura2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_GetReporte(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Movimientos_GetPrefactura", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        'Crea_Parametro(cmd, "@Id_Linea", SqlDbType.Int, Id_Linea)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    'Public Shared Function fn_PreFactura_GetCV(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Cat_Movimientos_GetCV", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
    '    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    Public Shared Function fn_PreFactura_GetPadres(ByVal Id_Cliente As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Movimientos_GetPadres", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_GetHijos(ByVal Id_Cliente As Integer, ByVal ConHijos As Boolean, ByVal Status As String, ByVal Id_ClienteGrupo As Integer) As DataTable
        Dim cmd As SqlCommand
        If ConHijos = False Then
            cmd = Crea_Comando("Cat_Movimientos_GetHijosPadre", CommandType.StoredProcedure, Crea_ConexionSTD)
        Else
            cmd = Crea_Comando("Cat_Movimientos_GetHijos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
        End If

        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_ObtenerDatosSucursal() As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_GetCajasFuertes(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CajasFuertesMov_ReportePrefactura", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_GetPernoctas(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Bo_Pernoctas_ReportePrefactura", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "V")

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_ProcesoObtenerConceptos(ByVal Id_Cliente As Integer, ByVal StatusCS As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServicios_GetConceptos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, StatusCS)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFactura_ProcesoEjecutarFormula(ByVal Id_Cliente As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Formula As String) As DataTable
        Dim cmd As SqlCommand
        Dim DT As DataTable

        cmd = Crea_Comando(Formula, CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            DT = EjecutaConsulta(cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            DT = New DataTable
            DT.Columns.Add("Cantidad")
            Return DT
        End Try
    End Function

    Public Shared Function fn_PreFactura_GetMateriales(ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_GetPrefactura", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


#End Region

#Region "Valida Comprobantes de Visita"

    Public Shared Function fn_ComprobantesV_Consultar(ByVal FDesde As String, ByVal FHasta As String, ByVal Lista As cp_Listview, ByVal Id_Cliente As Integer, ByVal Id_Padre As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ComprobantesV_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.VarChar, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.VarChar, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Padre", SqlDbType.Int, Id_Padre)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_ComprobanteV")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ComprobantesV_Validar(ByVal Id_ComprobanteV As Long, ByVal Id_Cliente As Long, ByVal Id_CS As Long, ByVal Id_Punto As Long, ByVal Hora As String, ByVal HoraLl As String, ByVal HoraS As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de quien valida
            cmd = Cn_Datos.Crea_Comando("Cat_ComprobantesV_ValidarF", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_ComprobanteV", SqlDbType.Int, Id_ComprobanteV)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_ComprobanteV", SqlDbType.VarChar, Hora)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Llegada", SqlDbType.VarChar, HoraLl)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Salida", SqlDbType.VarChar, HoraS)
            Cn_Datos.Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, comentarios)
            Cn_Datos.EjecutarNonQuery(cmd)

            cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ComprobantesV_Cancelar(ByVal Id_ComprobanteV As Long, ByVal Observaciones_Cancela As String, ByVal Hora_ComprobanteV As String, ByVal Hora_Llegada As String, ByVal Hora_Salida As String, ByVal Comentarios As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            'Actualizar los datos de quien valida
            cmd = Cn_Datos.Crea_Comando("Cat_ComprobantesV_Cancela", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_ComprobanteV", SqlDbType.Int, Id_ComprobanteV)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones_Cancela)

            Cn_Datos.Crea_Parametro(cmd, "@Hora_ComprobanteV", SqlDbType.VarChar, Hora_ComprobanteV)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Llegada", SqlDbType.VarChar, Hora_Llegada)
            Cn_Datos.Crea_Parametro(cmd, "@Hora_Salida", SqlDbType.VarChar, Hora_Salida)
            Cn_Datos.Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)

            Cn_Datos.EjecutarNonQuery(cmd)

            cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Prefactura Proceso Bancos"

    Public Shared Function fn_PreFacturaProceso_Consultar(ByVal Id_CajaBancaria As Integer) As DataTable
        Dim cmd As SqlCommand
        cmd = Crea_Comando("Fac_Proceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PreFacturaProceso_EjecutaFormula(ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoF As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Formula As String) As DataTable
        Dim cmd As SqlCommand
        Dim DT As DataTable

        cmd = Crea_Comando(Formula, CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            DT = EjecutaConsulta(cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            DT = New DataTable
            DT.Columns.Add("Cantidad")
            Return DT
        End Try
    End Function

#End Region

#Region "Grupos de Facturacion"

    Public Shared Function fn_GruposFacturacion_LlenarListaGrupos(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_GruposFactura_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_GrupoF")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaClientesSG(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesPSGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaClientesDG(ByVal Id_CajaBancaria As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesPDGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_CajaBancaria)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_LlenarListaConceptos(ByVal Id_GrupoF As Integer, ByRef Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ConceptosFPGrupo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Concepto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GruposFacturacion_Crear(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposFactura_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_Actualizar(ByVal Id_GrupoF As Integer, ByVal Descripcion As String) As Boolean

        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposFactura_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_AsignarGrupo(ByVal Id_GrupoF As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposClientes_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_DesAsignarGrupo(ByVal Id_GrupoF As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposClientes_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_AsignarConcepto(ByVal Id_GrupoF As Integer, ByVal Id_Concepto As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposConceptos_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GruposFacturacion_DesAsignarConcepto(ByVal Id_GrupoF As Integer, ByVal Id_Concepto As Integer) As Boolean
        Dim Cmd As SqlCommand = Crea_Comando("Pro_GruposConceptos_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(Cmd, "@Id_Concepto", SqlDbType.Int, Id_Concepto)

        Try
            If EjecutarNonQuery(Cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Reporte de Dotaciones"

    Public Shared Function fn_ConsultaDotaciones_LlenarRemisiones(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                  ByVal Desde As Date, ByVal Hasta As Date, _
                                                                  ByVal Id_Moneda As Integer, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer) As Boolean
        'Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetFacturacion", CommandType.StoredProcedure, Crea_ConexionSTD)
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetReporte2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)

        Try
            lsv.Actualizar(cmd, "Id_Dotacion")

            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaDotaciones_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Dotacion As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_DotacionesD_GetSinTipos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)

        Try
            lsv.Actualizar(cmd, "Id_Dotacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteDotaciones_GenerarExcel(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer, ByVal Encabezado1 As String, ByVal Encabezado2 As String) As Boolean

        Dim Denominaciones As DataTable = fn_ReporteConcentraciones_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then Return False

        Dim Dotaciones As DataTable
        Dim Desglose As DataTable
        Dim Dotacion, Cliente As Integer
        Dim j As Integer = 4
        Dim Suma As String
        Dim Letra_Final As Char
        Dim Letra_FinalN As Integer
        Dim Letra_FinBilletes As Char
        Dim Letra_FinBilletesN As Integer

        'Traer las Dotaciones
        Dotaciones = fn_ReporteDotaciones_GetDotaciones2(Id_CajaBancaria, Id_Moneda, Desde, Hasta, Id_GrupoF, Tipo)
        'Traer el dsglose
        Desglose = fn_ReporteDotaciones_GetDesglose2(Id_CajaBancaria, Id_Moneda, Desde, Hasta, Id_GrupoF, Tipo)

        frm_MENU.prg_Barra.Value = 0
        frm_MENU.prg_Barra.Maximum = Dotaciones.Rows.Count + 4
        '---------------
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If
        '----------------
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            If .Worksheets(1).name = "Sheet1" Then Suma = "=Sum" Else Suma = "=Suma"

            'Creando los encabezados
            .Range("A1:F1").Merge()
            .Range("A1").Font.Bold = True
            .Range("A1").Value = Encabezado1 & "  " & Encabezado2
            .Range("A3").Value = "FECHA"
            .Range("B3").Value = "REMISION"
            .Range("C3").Value = "DESTINO"
            .Range("D3").Value = "IMPORTE TOTAL"
            .Range("E3").Value = "ENVASES"
            .Range("F3").Value = "BOLSAS"
            .Range("G3").Value = "MAZOS"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & 3).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
                If Microsoft.VisualBasic.Left(row("Presentacion"), 1) = "M" Then
                    .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & 2).Value = row("CantidadXbolsa")
                Else
                    Letra_FinBilletes = LetrA(72 + Denominaciones.Rows.IndexOf(row))
                    Letra_FinBilletesN = 72 + Denominaciones.Rows.IndexOf(row)
                End If
                Letra_Final = LetrA(72 + Denominaciones.Rows.IndexOf(row))
                Letra_FinalN = 72 + Denominaciones.Rows.IndexOf(row)
            Next

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            Dotacion = 0
            Cliente = 0
            For Each FilaD As DataRow In Dotaciones.Rows
                frm_MENU.prg_Barra.Value += 1
                If Dotacion = 0 And Cliente = 0 Then
                    Dotacion = FilaD.Item("Id_Dotacion")
                    Cliente = FilaD.Item("IDCP")
                ElseIf Dotacion <> FilaD.Item("Id_Dotacion") Or Cliente <> FilaD.Item("IDCP") Then
                    Dotacion = FilaD.Item("Id_Dotacion")
                    Cliente = FilaD.Item("IDCP")
                    j += 1
                End If
                .Range("A" & j).Value = FilaD.Item("FechaEntrega")
                .Range("B" & j).Value = FilaD.Item("Remision")
                If FilaD.Item("Documentos") = "" Then
                    .Range("C" & j).Value = FilaD.Item("Cliente")
                Else
                    .Range("C" & j).Value = FilaD.Item("Cliente") & "(DOCUMENTOS)"
                End If
                .Range("D" & j).Value = FilaD.Item("Importe")
                .Range("E" & j).Value = FilaD.Item("EnvasesTotal")
                .Range("F" & j).Value = 0
                .Range("G" & j).Value = 0
                .Range("D" & j).NumberFormat = "#,##0.00"

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In Desglose.Rows
                        If FilaE.Item("Id_Dotacion") = Dotacion And FilaE.Item("Id_ClienteP") = Cliente Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            frm_MENU.prg_Barra.Value += 1
            'MAZOS O BOLSAS

            If Letra_FinBilletesN > 0 Then
                Try

                    Dim Bolsas As Decimal = 0.0
                    Dim BolsasT As Decimal = 0.0
                    For I As Integer = 4 To j
                        BolsasT = 0
                        For k = Letra_FinBilletesN + 1 To Letra_FinalN
                            If .range(LetrA(k) & I).value IsNot Nothing Then
                                Bolsas = CDec(.range(LetrA(k) & I).value) / .range(LetrA(k) & 2).value
                                BolsasT += Bolsas
                            End If
                        Next
                        .Range("F" & I).value = BolsasT
                        .Range("G" & I).Formula = Suma & "(H" & I & ":M" & I & ")/1000"

                        .Range("F" & I).NumberFormat = "#,##0.000"
                        .Range("G" & I).NumberFormat = "#,##0.000"
                    Next
                Catch
                    'Cuando la moneda no es pesos ocurre un error al calcular los mazos

                End Try
                frm_MENU.prg_Barra.Value += 1
                'Limpiar las cantidades por bolsa
                For k = Letra_FinBilletesN + 1 To Letra_FinalN
                    .range(LetrA(k) & 2).value = ""
                Next
            End If
            If Letra_FinBilletesN = 0 Then
                'Limpiar las cantidades por bolsa
                For k = 72 To Letra_FinalN
                    .range(LetrA(k) & 2).value = ""
                Next
            End If
            'SUMATORIAS 
            j += 1
            For I As Integer = 68 To Letra_FinalN
                .Range(LetrA(I) & j).Formula = Suma & "(" & LetrA(I) & 4 & ":" & LetrA(I) & j - 1 & ")"
            Next

            .Range("A3:" & Letra_Final & 3).Font.Bold = True
            .Range("A" & j & ":" & Letra_Final & j).Font.Bold = True
            .Range("D" & j & ":" & Letra_Final & j).NumberFormat = "#,##0.00"

            .Range("A3:" & Letra_Final & j).Borders.Value = True

            'Mostrando el libro
            .Range("A:" & Letra_Final).EntireColumn.AutoFit()
            frm_MENU.prg_Barra.Value = 0
            .Visible = True
        End With
        Return True
    End Function

    Public Shared Function fn_ReporteDotaciones_GetDenominaciones(ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesMoneda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteDotaciones_GetDotaciones(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer) As DataTable
        'Reporte de Dotaciones en Excel
        'Por Fecha_Captura de la Dotacion
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteDotaciones_GetDotaciones2(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer) As DataTable
        'Reporte de Dotaciones en Excel
        'Por Fecha_Salida de Boveda
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetReporte2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteDotaciones_GetDesglose(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer) As DataTable
        'Reporte de DotacionesD en Excel
        'Por Fecha_Captura de las dotaciones
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetReporteD", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteDotaciones_GetDesglose2(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_GrupoF As Integer, ByVal Tipo As Integer) As DataTable
        'Reporte de DotacionesD en Excel
        'Por Fecha_Salida de Boveda
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetReporteD2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Reporte de Concentraciones"

    Public Shared Function fn_ConsultaConcentraciones_LlenarRemisiones(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                  ByVal S_Desde As Integer, ByVal S_Hasta As Integer, _
                                                                  ByVal Id_Moneda As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto_Procesa As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetFacturacion", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto_Procesa)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)

        Try
            lsv.Actualizar(cmd, "Id_Servicio")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaConcentraciones_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Servicio As Integer, ByVal Id_Moneda As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetFacturacion", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteConcentraciones_GenerarExcel(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Encabezado1 As String, ByVal Encabezado2 As String) As Boolean

        Dim Denominaciones As DataTable = fn_ReporteDotaciones_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then
            MsgBox("No existen Denominaciones para la Moneda seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Dim Servicios As DataTable
        Dim Desglose As DataTable
        Dim Servicio, Cliente As Integer
        Dim j As Integer = 4
        Dim Suma As String
        Dim Letra_Final As Char
        Dim Letra_FinalN As Integer
        Dim Letra_FinBilletes As Char = "G"
        Dim Letra_FinBilletesN As Integer = 71

        'Traer los Servicios
        Servicios = fn_ReporteConcentraciones_GetServicios(Id_CajaBancaria, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto)
        'Traer el dsglose
        Desglose = fn_ReporteConcentraciones_GetDesglose(Id_CajaBancaria, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto)

        If Desglose Is Nothing Then
            MsgBox("No se pudo consultar la información para exportar el reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            If .Worksheets(1).name = "Sheet1" Then Suma = "=Sum" Else Suma = "=Suma"

            'Creando los encabezados
            .Range("A1:G1").Merge()
            .Range("A2:G2").Merge()
            .Range("A1:A2").Font.Bold = True
            .Range("A1").Value = Encabezado1
            .Range("A2").Value = Encabezado2

            .Range("A3").Value = "FECHA"
            .Range("B3").Value = "REMISION"
            .Range("C3").Value = "ORIGEN"
            .Range("D3").Value = "IMPORTE TOTAL"
            .Range("E3").Value = "ENVASES"
            .Range("F3").Value = "BOLSAS"
            .Range("G3").Value = "MAZOS"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & 3).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
                If Microsoft.VisualBasic.Left(row("Presentacion"), 1) = "M" Then
                    .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & 2).Value = row("CantidadXbolsa")
                Else
                    Letra_FinBilletes = LetrA(72 + Denominaciones.Rows.IndexOf(row))
                    Letra_FinBilletesN = 72 + Denominaciones.Rows.IndexOf(row)
                End If
                Letra_Final = LetrA(72 + Denominaciones.Rows.IndexOf(row))
                Letra_FinalN = 72 + Denominaciones.Rows.IndexOf(row)
            Next

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            Servicio = 0
            Cliente = 0
            For Each FilaD As DataRow In Servicios.Rows
                If Servicio = 0 And Cliente = 0 Then
                    Servicio = FilaD.Item("Id_Servicio")
                    Cliente = FilaD.Item("Id_ClienteP")
                ElseIf Servicio <> FilaD.Item("Id_Servicio") Or Cliente <> FilaD.Item("Id_ClienteP") Then
                    Servicio = FilaD.Item("Id_Servicio")
                    Cliente = FilaD.Item("Id_ClienteP")
                    j += 1
                End If
                .Range("A" & j).Value = FilaD.Item("Fecha")
                .Range("B" & j).Value = FilaD.Item("Remision")
                .Range("C" & j).Value = FilaD.Item("Cliente")
                .Range("D" & j).Value = FilaD.Item("Importe")
                .Range("E" & j).Value = FilaD.Item("Envases") + FilaD.Item("EnvasesSN")
                .Range("F" & j).Value = 0
                .Range("G" & j).Value = 0
                .Range("D" & j).NumberFormat = "#,##0.00"

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In Desglose.Rows
                        If FilaE.Item("Id_Servicio") = Servicio And FilaE.Item("Id_ClienteP") = Cliente Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(72 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            'MAZOS Y BOLSAS
            Dim Bolsas As Decimal = 0.0
            Dim BolsasT As Decimal = 0.0
            For I As Integer = 4 To j
                BolsasT = 0
                For k = Letra_FinBilletesN + 1 To Letra_FinalN
                    If .range(LetrA(k) & I).value IsNot Nothing Then
                        Bolsas = CDec(.range(LetrA(k) & I).value) / .range(LetrA(k) & 2).value
                        BolsasT += Bolsas
                    End If
                Next
                .Range("F" & I).value = BolsasT
                If Letra_FinBilletesN = 71 Then
                    .Range("G" & I).Formula = 0
                Else
                    .Range("G" & I).Formula = Suma & "(H" & I & ":M" & I & ")/1000"
                End If

                .Range("F" & I).NumberFormat = "#,##0.000"
                .Range("G" & I).NumberFormat = "#,##0.000"
            Next
            'Limpiar las cantidades por bolsa
            For k = Letra_FinBilletesN + 1 To Letra_FinalN
                .range(LetrA(k) & 2).value = ""
            Next
            'SUMATORIAS
            j += 1
            For I As Integer = 68 To Letra_FinalN
                .Range(LetrA(I) & j).Formula = Suma & "(" & LetrA(I) & 4 & ":" & LetrA(I) & j - 1 & ")"
            Next

            .Range("A3:" & Letra_Final & 3).Font.Bold = True
            .Range("A" & j & ":" & Letra_Final & j).Font.Bold = True
            .Range("D" & j & ":" & Letra_Final & j).NumberFormat = "#,##0.00"

            .Range("A3:" & Letra_Final & j).Borders.Value = True

            'Mostrando el libro
            .Range("A:" & Letra_Final).EntireColumn.AutoFit()
            .Visible = True
        End With
        Return True
    End Function

    Public Shared Function fn_ReporteConcentraciones_GetDenominaciones(ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesMoneda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteConcentraciones_GetServicios(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetReporteConce", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteConcentraciones_GetDesglose(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetReporteConce", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_GrupoF)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Agrupar Movimientos"

    Public Shared Function fn_Movimientos_AgruparConsultar(ByVal FDesde As String, ByVal FHasta As String, ByVal Status As Char, ByVal Id_Cliente As Long, ByVal Lista As cp_Listview, ByVal IncluirSubC As String, ByVal Destino As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand

            Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_GetAgrupar", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.VarChar, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.VarChar, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@IncluirSubC", SqlDbType.VarChar, IncluirSubC)
            Cn_Datos.Crea_Parametro(Cmd, "@Destino", SqlDbType.Int, Destino)


            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Movimiento")
            Lista.Columns(Lista.Columns.Count - 1).Width = 0
            Lista.Columns(Lista.Columns.Count - 2).Width = 0

            Lista.Columns(6).TextAlign = HorizontalAlignment.Right
            Lista.Columns(7).TextAlign = HorizontalAlignment.Right
            'Lista.Columns(8).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_Movimientos_AgruparActualizar(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer)

        'Necesito crear una variable listview para ordenar antes de iniciar el ciclo
        Dim Lista As New ListView
        Dim Orden As Integer = 0
        Lista.Columns.Add("Id_Remision")
        Lista.Columns.Add("Orden")
        Do
            Orden += 1
            For Each Ele As ListViewItem In lsv.CheckedItems
                If Ele.SubItems(12).Text = Orden Then
                    Lista.Items.Add(Ele.SubItems(11).Text)
                    Lista.Items(Lista.Items.Count - 1).Tag = Ele.Tag
                    Lista.Items(Lista.Items.Count - 1).SubItems.Add(Ele.SubItems(12).Text)
                    Exit For
                End If
            Next
        Loop Until Lista.Items.Count = lsv.CheckedItems.Count
        'Fin
        'En la Variable Listview ya estan todos los elementos ordenados segun los
        'fué palomeando el usuario.

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand
        Dim Id_MovimientoNuevo As Integer
        Dim PrimerMov As Boolean = False

        Try


            'Ahora si, iniciar el ciclo
            For Each Elemento As ListViewItem In Lista.Items
                If PrimerMov = False Then

                    'Aquí se inserta el Movimiento Nuevo
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Movimientos_CreateAgrupar")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Elemento.Tag)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

                    Id_MovimientoNuevo = Cn_Datos.EjecutarScalarT(Cmd)
                    PrimerMov = True

                End If

                'Aquí se inserta la Remisión del Movimiento Anterior que se está agrupando 
                'con el ID del Movimiento Nuevo
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_MovimientosD_CreateAgrupar")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MovimientoNuevo", SqlDbType.Int, Id_MovimientoNuevo)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_MovimientoAnterior", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Aquí se actualiza el Status de la Remision Anterior que se está agrupando (G = "Agrupado")
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_MovimientosD_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "G")
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Si todas las Remisiones del Movimiento Anterior estan G, se cambia el status del Movimiento
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Movimientos_UpdateStatusG")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            Trans.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        Trans.Commit()
        Cnn.Close()

        'En esta instrucción se actualizan: cantidad_remisiones, cantidad_envases, Miles, etc
        Call Cn_Facturacion.RecalcularMovimientos(Id_MovimientoNuevo)


        Return True

    End Function

    Public Shared Function RecalcularMovimientos(ByVal Id_Movimiento As Integer) As Boolean

        Dim Remisiones As Integer = 0, Envases As Integer = 0, Importe As Decimal = 0, Miles As Decimal = 0, EnvasesE As Integer = 0, Kilometros As Integer = 0
        Dim Efectivo As Decimal = 0, Documentos As Decimal = 0
        Dim Miles_Scosto As Decimal = 0
        Dim Envases_Scosto As Integer = 0
        Dim CantidadXunidad As Integer = 1000
        Dim Redondeado As String = "S"
        Dim Cobra_Documentos As String = "S"
        Dim ImporteTotal As Decimal = 0

        'Consultar los Datos para hacer los Cálculos del Movimiento Nuevo
        Dim dt As DataTable = fn_Movimientos_ConsultaDatos(Id_Movimiento)

        If dt IsNot Nothing Then
            Remisiones = dt.Rows(0)("Cantidad_Remisiones")
            Envases = dt.Rows(0)("Cantidad_Envases")
            Kilometros = dt.Rows(0)("Cantidad_KM")
            Efectivo = dt.Rows(0)("Efectivo")
            Documentos = dt.Rows(0)("Documentos")
            Miles_Scosto = dt.Rows(0)("Miles_Scosto")
            Redondeado = dt.Rows(0)("Redondeado")
            Cobra_Documentos = dt.Rows(0)("Cobra_Documentos")
            CantidadXunidad = dt.Rows(0)("CantidadXunidad")
            Envases_Scosto = dt.Rows(0)("Envases_Scosto")
        Else
            Return False
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
        If Kilometros < 0 Then Kilometros = 0

        'Actualizar los datos calculados del Movimiento Nuevo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand
        Try
            cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_UpdateAgrupar", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.BigInt, Id_Movimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Remisiones", SqlDbType.Int, Remisiones)
            Cn_Datos.Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(cmd, "@Miles", SqlDbType.Money, Miles)
            Cn_Datos.Crea_Parametro(cmd, "@Envases_Exceso", SqlDbType.Int, EnvasesE)
            Cn_Datos.Crea_Parametro(cmd, "@Kilometros", SqlDbType.Int, Kilometros)

            Cn_Datos.EjecutarNonQuery(cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "Pernoctas"

    Public Shared Function fn_Pernoctas_LlenarPernoctas(ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As String, ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Bo_Pernoctas_GetFacturacion", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(cmd, "Id_Pernocta")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_Eliminar(ByVal lsv As cp_Listview) As Boolean

        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cn As SqlConnection = New SqlConnection(Cnx_Datos)
        Dim trans As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Bo_Pernoctas_Delete")

            For Each item As ListViewItem In lsv.CheckedItems
                cmd.Parameters.Clear()
                'item.SubItems(3).Text = ""
                Crea_Parametro(cmd, "@Id_Pernocta", SqlDbType.Int, item.Tag)
                EjecutarNonQueryT(cmd)
            Next
            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_Actualizar(ByVal Id_CS As Integer, ByVal Observaciones_Valida As String, ByVal lsv As cp_Listview) As Boolean

        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim trans As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Bo_Pernoctas_Validar")

            For Each item As ListViewItem In lsv.CheckedItems
                cmd.Parameters.Clear()
                Crea_Parametro(cmd, "@Id_Pernocta", SqlDbType.Int, item.Tag)
                Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                'Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Fecha)
                Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Observaciones_Valida", SqlDbType.VarChar, Observaciones_Valida)

                EjecutarNonQueryT(cmd)
            Next
            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Enviar Mail"

    Public Shared Function fn_EnviarMail_BuscarCorreos(ByVal Clave As String, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesContactosEnlace_GetCorreo", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Clave", SqlDbType.VarChar, Clave)
            lsv.Actualizar(cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "DESCARGA MANUAL DE USUARIO"

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Archivo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "RECALCULAR TRASLADOS"

    Public Shared Function fn_Movimientos_ConsultaRecalcular1(ByVal Lista As cp_Listview, ByVal FDesde As Date, ByVal FHasta As Date, ByVal Status As Char, ByVal Id_Cliente As Long, ByVal Tipo_Mov As Char, ByVal IncluirCV As Char) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, Tipo_Mov)
            Cn_Datos.Crea_Parametro(Cmd, "@IncluirCV", SqlDbType.VarChar, IncluirCV)
            Lista.Actualizar(Cmd, "Id_Movimiento")

            Lista.Columns(5).TextAlign = HorizontalAlignment.Right
            Lista.Columns(6).TextAlign = HorizontalAlignment.Right
            Lista.Columns(7).TextAlign = HorizontalAlignment.Right
            Lista.Columns(8).TextAlign = HorizontalAlignment.Right
            Lista.Columns(9).TextAlign = HorizontalAlignment.Right
            Lista.Columns(10).TextAlign = HorizontalAlignment.Right
            Lista.Columns(12).Width = 0

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_ConsultaRecalcular2(ByVal FDesde As Date, ByVal FHasta As Date, ByVal Stastus As Char, ByVal Id_Cliente As Long, ByVal Tipo_Mov As Char, ByVal IncluirCV As Char) As DataTable
        Dim Dt_Datos As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_GetRecalcular", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Stastus)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, Tipo_Mov)
            Dt_Datos = Cn_Datos.EjecutaConsulta(Cmd)

            Return Dt_Datos
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Movimientos_ConsultaRecalcular3(ByVal FDesde As Date, ByVal FHasta As Date, ByVal Stastus As Char, ByVal Id_Cliente As Long, ByVal Tipo_Mov As Char, ByVal IncluirCV As Char) As DataTable
        Try

            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand

            Cmd = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetRecalcular", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Stastus)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, Tipo_Mov)
            Cn_Datos.Crea_Parametro(Cmd, "@IncluirCV", SqlDbType.VarChar, IncluirCV)

            Return EjecutaConsulta(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Movimientos_ActualizaRemisiones(ByVal ImporteTotal As Decimal, ByVal Id_Remision As Int64) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            Cmd = Cn_Datos.Crea_Comando("Cat_Remisiones_UpdateImporte", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Decimal, ImporteTotal)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Movimientos_ActualizaMovimientos(ByVal ImporteTotal As Decimal, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, _
                                                               ByVal Miles As Decimal, ByVal Id_Movimiento As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand

            Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_UpdateImpEnvRem", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Decimal, ImporteTotal)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Decimal, Miles)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Llenar listado de tipos de Cambio y Modificacion"

    Public Shared Function fn_TiposdeCambio_LlenarLista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal IdMoneda As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Try

            Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoCambio_Get2", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, IdMoneda)
            Cn_Datos.Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

            lsv.Actualizar(cmd, "Id_TC")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TiposdeCambio_Modificar(ByVal IdTC As Integer, ByVal Tipo_Cambio As Decimal) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoCambio_Update", CommandType.StoredProcedure, cnn)

            Cn_Datos.Crea_Parametro(cmd, "@Id_TC", SqlDbType.Int, IdTC)
            Cn_Datos.Crea_Parametro(cmd, "@TipoCambio", SqlDbType.Money, Tipo_Cambio)

            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "Consulta Entradas"

    Public Shared Function fn_ConsultaEntradasRutasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradasRutas3", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Remision")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaEntradasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Tipop As Integer, ByVal IdCia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradas2", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, Tipop)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Remision")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

    Public Shared Sub fn_DatosEmpresa_LlenarDataSet(ByRef Ds As ds_DatosEmpresa)

        Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Ds.Tbl_DatosEmpresa.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try

    End Sub

#Region "Requerimiento Antilavado 2014 y 2015"

    Public Shared Function fn_Antilavado_GetDatos(ByVal Fecha_Desde As Date, ByVal Fecha_Hasta As Date, ByVal BTipo As Integer, ByVal BTipoP As Integer, ByVal StatusPunto As String, ByVal TipoConsulta As String) As DataTable
        Dim cmd As SqlCommand

        If TipoConsulta = "TC" Then
            'Todo lo que no entra a Bóveda
            cmd = Crea_Comando("Cat_Movimientos_GetAntilavado", CommandType.StoredProcedure, Crea_ConexionSTD)
        ElseIf TipoConsulta = "PRO" Then
            'Solo Pro_Servicios
            cmd = Crea_Comando("Cat_Movimientos_GetAntilavado1", CommandType.StoredProcedure, Crea_ConexionSTD)
        ElseIf TipoConsulta = "TV" Then
            'Haciendo Join con Bóveda
            cmd = Crea_Comando("Cat_Movimientos_GetAntilavado2", CommandType.StoredProcedure, Crea_ConexionSTD)
        ElseIf TipoConsulta = "DO" Then
            'Haciendo Join con Bóveda
            cmd = Crea_Comando("Cat_Movimientos_GetAntilavado3", CommandType.StoredProcedure, Crea_ConexionSTD)
        End If
        Crea_Parametro(cmd, "@Fecha_Desde", SqlDbType.Date, Fecha_Desde)
        Crea_Parametro(cmd, "@Fecha_Hasta", SqlDbType.Date, Fecha_Hasta)
        If TipoConsulta = "TC" Or TipoConsulta = "PRO" Then
            Crea_Parametro(cmd, "@BTipo", SqlDbType.Int, BTipo)
            Crea_Parametro(cmd, "@BTipoP", SqlDbType.Int, BTipoP)
        End If
        If TipoConsulta <> "DO" Then
            Crea_Parametro(cmd, "@StatusPunto", SqlDbType.VarChar, StatusPunto)
        End If

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Antilavado_GetDomicilios(ByVal Id_Cliente As Integer, ByVal Fecha_Baja As Date) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetDomicilios", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.Date, Fecha_Baja)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Antilavado_GetDomiciliosF(ByVal Id_Cliente As Integer, ByVal Fecha_Baja As Date) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetDomiciliosF", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Fecha_Baja", SqlDbType.Date, Fecha_Baja)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region


#Region "Consulta de Fichas de Morralla"

    Public Shared Function fn_FichasMorrallaConsulta_Consulta(ByVal lsv As cp_Listview, ByVal Fecha_OperacionI As Date, ByVal Fecha_OperacionF As Date, ByVal Id_Cierre As Integer, ByVal Id_CajaBancaria As Integer, _
                                                             ByVal Id_ClienteGrupo As Integer, ByVal Id_Cliente As Integer, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mor_Fichas_Get4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Fecha_OperacionI", SqlDbType.Date, Fecha_OperacionI)
            Crea_Parametro(cmd, "@Fecha_OperacionF", SqlDbType.Date, Fecha_OperacionF)
            Crea_Parametro(cmd, "@Id_Cierre", SqlDbType.Int, Id_Cierre)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(cmd, "Id_Ficha")

            If lsv.Columns.Count > 0 Then
                lsv.Columns(3).TextAlign = HorizontalAlignment.Right
                lsv.Columns(7).TextAlign = HorizontalAlignment.Right
                lsv.Columns(8).TextAlign = HorizontalAlignment.Right
                lsv.Columns(9).TextAlign = HorizontalAlignment.Right
                lsv.Columns(10).TextAlign = HorizontalAlignment.Right
                lsv.Columns(12).Width = 0
                lsv.Columns(13).Width = 0
            End If

            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_FichasMorrallaConsulta_ConsultaDT(ByVal lsv As cp_Listview, ByVal Fecha_OperacionI As Date, ByVal Fecha_OperacionF As Date, ByVal Id_Cierre As Integer, ByVal Id_CajaBancaria As Integer, _
                                                             ByVal Id_ClienteGrupo As Integer, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Mor_Fichas_Get4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Fecha_OperacionI", SqlDbType.Date, Fecha_OperacionI)
            Crea_Parametro(cmd, "@Fecha_OperacionF", SqlDbType.Date, Fecha_OperacionF)
            Crea_Parametro(cmd, "@Id_Cierre", SqlDbType.Int, Id_Cierre)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_ClienteGrupo", SqlDbType.Int, Id_ClienteGrupo)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_FichasMorrallaD_LlenarDenominacion(ByVal Id_Moneda As Integer, ByVal Presentacion As String) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesPresentacion_Get2", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Tbl.Columns("Cantidad").ReadOnly = False
            Tbl.Columns("Importe").ReadOnly = False
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_FichasMorrallaD_ConsultarDenominacion(ByVal Id_Ficha As Integer, ByVal Id_Moneda As Integer, ByVal Presentacion As String) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Mor_FichasD_Get", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Tbl.Columns("Cantidad").ReadOnly = False
            Tbl.Columns("Importe").ReadOnly = False
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Sub ExportarGrupos(ByVal dt_Fichas As DataTable)
        Dim Grupo As String = ""
        Dim Fila As Integer = 0
        Dim Titulo As String = ""
        Dim book As Object
        Dim Hoja As Object
        Dim NumeroHoja As Integer = 0

        Dim TotalDC As Decimal = 0
        Dim TotalReal As Decimal = 0
        Dim TotalDif As Decimal = 0

        Dim dt_Sucursal As DataTable = fn_Reportes_ObtenerDatosSucursal()
        If dt_Sucursal Is Nothing Then
            MsgBox("Ocurrió un error al intentar obtener los datos de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If


        If dt_Fichas Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar la información.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dt_Fichas.Rows.Count = 0 Then
            MsgBox("No se encontró información para exportar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not IsDBNull(dt_Sucursal.Rows(0)("logo")) Then
            Dim imagenNueva As Image = Nothing
            Dim imagenBytes As Byte() = dt_Sucursal.Rows(0)("logo")
            Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
            imagenNueva = Image.FromStream(ms_ByteToImagen, True)

            If IO.File.Exists(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg") Then
                File.Delete(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
            End If
            imagenNueva.Save(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
        End If

        Titulo = dt_Sucursal.Rows(0)("Empresa")

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            xls = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                xls = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        xls.SheetsInNewWorkbook = 1
        book = xls.Workbooks.Add()

        For Each dr_Ficha As DataRow In dt_Fichas.Rows

            If Grupo <> dr_Ficha("Grupo") Then
                Grupo = dr_Ficha("Grupo")
                If Fila > 0 Then
                    Hoja.Range("A6:I" & Fila).Borders.Value = True
                    Fila += 1
                    Hoja.Range("A1:I" & Fila).EntireColumn.AutoFit()
                    Hoja.Range("F" & Fila & ":I" & Fila).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)
                    Hoja.Range("F" & Fila).value = "Totales"
                    Hoja.Range("G" & Fila).value = TotalDC
                    Hoja.Range("H" & Fila).value = TotalReal
                    Hoja.Range("I" & Fila).value = TotalDif
                    Hoja.Range("G" & Fila & ":I" & Fila).NumberFormat = "$###,###,##0.00"
                    Hoja.Range("F" & Fila & ":" & "I" & Fila).Font.Bold = True
                    Hoja.Range("F" & Fila & ":I" & Fila).Borders.Value = True

                    With Hoja.PageSetup
                        .zoom = False
                        .FitToPagesTall = 9
                        .fitTopageswide = 1
                    End With
                End If

                NumeroHoja += 1
                If NumeroHoja = 1 Then
                    Hoja = book.Sheets(1)
                Else
                    Hoja = book.Sheets.Add() ' esto agrega una hoja nueva
                End If

                Hoja.Name = dr_Ficha("Grupo")
                Hoja.Shapes.AddPicture(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg", False, True, 0, 0, 40, 40)
                Hoja.Range("A1").Value = Titulo
                'Hoja.Range("A2").Value = "REPORTE DE FICHAS DE MORRALLA"
                Hoja.Range("F2").Value = "FECHA DE OPERACION:"
                Hoja.Range("G2").Value = dr_Ficha("Fecha_Larga")
                Hoja.Range("F3").Value = "DEPOSITO A CAJA GENERAL:"
                Hoja.Range("A4").Value = dr_Ficha("Grupo")

                Hoja.Range("F2").HorizontalAlignment = -4152
                Hoja.Range("F3").HorizontalAlignment = -4152
                Hoja.Range("D2:F2").Merge()
                Hoja.Range("D3:F3").Merge()
                Hoja.Range("G2:I2").Merge()
                Hoja.Range("A1").VerticalAlignment = -4108
                Hoja.Range("A1").HorizontalAlignment = -4108
                Hoja.Range("A1").Font.Bold = True
                Hoja.Range("A1:I1").Merge()
                Hoja.Range("A4:I4").Merge()

                Hoja.Range("A4").HorizontalAlignment = -4108
                Hoja.Range("A4").Font.Bold = True

                Hoja.Range("A6").Value = "FechaOperacion"
                Hoja.Range("B6").Value = "FechaRemision"
                Hoja.Range("C6").Value = "Remision"
                Hoja.Range("D6").Value = "Cliente"
                If dr_Ficha("Grupo").ToString.ToUpper.Contains("TORNIQUETE") Then
                    Hoja.Range("E6").Value = "Tor"
                ElseIf dr_Ficha("Grupo").ToString.ToUpper.Contains("LINEA") Then
                    Hoja.Range("E6").Value = "Linea"
                ElseIf dr_Ficha("Grupo").ToString.ToUpper.Contains("TRANSMETRO") Then
                    Hoja.Range("E6").Value = "Ruta"
                Else
                    Hoja.Range("E6").Value = "MEA"
                End If
                Hoja.Range("F6").Value = "Folio"
                Hoja.Range("G6").Value = "Ingreso Esperado"
                Hoja.Range("H6").Value = "Ingreso Real"
                Hoja.Range("I6").Value = "Diferencia"
                Hoja.Range("A6:I6").Font.Bold = True
                Hoja.Range("A6:I6").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                TotalDC = 0
                TotalReal = 0
                TotalDif = 0
                Fila = 6

            End If

            With Hoja
                Fila += 1
                .Range("A" & Fila & ":" & "H" & Fila).Font.Size = 12
                .Range("E" & Fila & ":" & "H" & Fila).Font.Color = 0 'negro
                .Range("A" & Fila).value = dr_Ficha("FechaOperacion")
                .Range("B" & Fila).value = dr_Ficha("FechaRemision")
                .Range("C" & Fila).value = dr_Ficha("Remision")
                .Range("D" & Fila).value = dr_Ficha("Cliente")
                .Range("E" & Fila).value = dr_Ficha("Maquina")
                .Range("F" & Fila).value = dr_Ficha("Folio")
                .Range("G" & Fila).value = dr_Ficha("DiceContener")
                .Range("H" & Fila).value = dr_Ficha("ImporteReal")
                .Range("I" & Fila).value = dr_Ficha("Diferencia")
                TotalDC += Decimal.Parse(dr_Ficha("DiceContener"))
                TotalReal += Decimal.Parse(dr_Ficha("ImporteReal"))
                TotalDif += Decimal.Parse(dr_Ficha("Diferencia"))

                '.Range("A" & Fila & ":" & "I" & Fila).Font.Bold = True

            End With
        Next

        If Fila > 0 Then
            Hoja.Range("A6:I" & Fila).Borders.Value = True
            Hoja.Range("F" & Fila + 1 & ":I" & Fila + 1).Borders.Value = True

            Fila += 1
            Hoja.Range("A1:I" & Fila).EntireColumn.AutoFit()
            Hoja.Range("F" & Fila & ":I" & Fila).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)
            Hoja.Range("F" & Fila).value = "Totales"
            Hoja.Range("G" & Fila).value = TotalDC
            Hoja.Range("H" & Fila).value = TotalReal
            Hoja.Range("I" & Fila).value = TotalDif
            Hoja.Range("G" & Fila & ":I" & Fila).NumberFormat = "$###,###,##0.00"
            Hoja.Range("F" & Fila & ":" & "I" & Fila).Font.Bold = True
            With Hoja.PageSetup
                .zoom = False
                .FitToPagesTall = 9
                .fitTopageswide = 1
            End With
        End If
        xls.visible = True
        xls = Nothing
    End Sub

#End Region

#Region "Consultar Encabezado Reportes"

    Public Shared Function fn_Reportes_ObtenerDatosSucursal() As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

End Class

