Imports System.Windows.Forms
Imports System.Threading
Imports System.Globalization
Imports System.Deployment
Imports System.Deployment.Application

Public Class frm_MENU

    Private Segundos As Integer = 0

    Private Sub frm_MENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If LoginId > 0 Then
        	Cn_Login.Login_CerrarSesion()
            'Insertar en Usr_Log
            If TipoBloqueo <> 0 Then
                Cn_Login.fn_Log_Create("CIERRE DE SESION(DESPUES DE BLOQUEO)")
            Else
                Cn_Login.fn_Log_Create("CIERRE DE SESION")
            End If
        End If
    End Sub

    Private Sub frm_MENU_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Call Deshabilitar_Todo()

        'Cambiar la configuración regional
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES", False)

        ' Obtengo la informacion de formato numerico
        Dim nfi As Globalization.NumberFormatInfo = Thread.CurrentThread.CurrentCulture.NumberFormat
        ' Obtengo la informacion de formato fecha
        Dim Dfi As Globalization.DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        If nfi.NumberDecimalSeparator <> "." Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.NumberGroupSeparator <> "," Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.CurrencySymbol <> "$" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortDatePattern <> "dd/MM/yyyy" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortTimePattern <> "HH:mm:ss" And Dfi.ShortTimePattern <> "hh:mm tt" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        tmr_Inicio.Enabled = True
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0

        For Each element As ToolStripItem In MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If
                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If
                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub tmr_Inicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Inicio.Tick
        TipoBloqueo = 0
        SegundosDesconexion = 0
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        '-----------
        Dim frmSet As New frm_Settings
        'verificar Si hay tipoesquema y DAtos de conexion
        If My.Settings.TipoEsquema = "0" Then
            frmSet.ShowDialog()
            If My.Settings.TipoEsquema = "0" Then
                MsgBox("No se ha especifica el tipo de esquema a utiliar.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If

        If Cn_Facturacion.fn_CuentaSettings() = 10 Then
            frmSet.ShowDialog()
            If Cn_Facturacion.fn_CuentaSettings() = 10 Then
                MsgBox("No se han capturado el nombre del servidor y la base de datos.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If
    
        '------------------
        frm_Login.ShowDialog()
        If SucursalId = 0 Then
            Me.Close()
            Exit Sub
        End If
        
        Me.Text = "SIAC. Módulo Pre-Facturación v" & ModuloVersion & "  ** Conectado A: " & SucursalDatos

        cn_Mensajes.ActualizarMensajes()
        tmr_Hora.Enabled = True

        'leer si tiene enlace con adminpaq
        tieneAdminPaq = My.Settings.TieneAdminPaq

        FacturasDeAdminPaqToolStripMenuItem.Visible = (tieneAdminPaq = "S")

    End Sub

    Private Sub tmr_Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Hora.Tick
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString

        Segundos += 1
        SegundosDesconexion += 1
        If SegundosDesconexion >= (MinutosDesconexion * 60) Then
            SegundosDesconexion = 0
            tmr_Hora.Enabled = False
            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("BLOQUEO POR INACTIVIDAD")
            TipoBloqueo = 2
            Call CerrarModales()
            Me.Hide()
            frm_Login.ShowDialog()
            tmr_Hora.Enabled = True
        End If
        If Segundos = 300 Then
            cn_Mensajes.ActualizarMensajes()
            Segundos = 0
        End If
    End Sub

    Sub CerrarModales()
        Dim Contador As Integer = Application.OpenForms.Count
        Try
            For ILocal As Integer = 0 To Contador - 1
                If Application.OpenForms(ILocal).Modal Then
                    Application.OpenForms(ILocal).Dispose()
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub tsb_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Bloquear.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BLOQUEAR SISTEMA")
        TipoBloqueo = 1
        tmr_Hora.Enabled = False
        Me.Hide()
        frm_Login.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub ConsultaDeTrasladosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeTrasladosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE TRASLADOS")
        Dim frm As New frm_ConsultaTraslados
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ValidarServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarServiciosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR MOVIMIENTOS")

        FuncionesGlobales.MostrarVentana(frm_MovimientosValidar)
    End Sub

    Private Sub tsb_LeerMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_LeerMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub tsb_NuevoMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_NuevoMensaje.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub tsb_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Salir.Click
        Me.Close()
    End Sub

    Private Sub VerMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub EnviarMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub PrefacturasClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrefacturasClientesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREFACTURAS DE TRASLADO DE VALORES")

        FuncionesGlobales.MostrarVentana(frm_PreFacturaClientes, False)
    End Sub

    Private Sub tsb_ValidarServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ValidarServicios.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR MOVIMIENTOS")

        FuncionesGlobales.MostrarVentana(frm_MovimientosValidar)
    End Sub

    Private Sub tsb_PrefacturasClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_PrefacturasClientes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREFACTURAS DE TRASLADO DE VALORES")

        FuncionesGlobales.MostrarVentana(frm_PreFacturaClientes, False)
    End Sub

    Private Sub tsb_ConsultaTraslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ConsultaTraslados.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE TRASLADOS")

        FuncionesGlobales.MostrarVentana(frm_ConsultaTraslados, True)
    End Sub

    Private Sub MovimientosManualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosManualesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: AGREGAR MOVIMIENTOS MANUALES")

        FuncionesGlobales.MostrarVentana(frm_MovimientosAgregar, True)
    End Sub

    Private Sub ValidarComprobantesDeVisitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarComprobantesDeVisitaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR COMPROBANTES DE VISITA")

        FuncionesGlobales.MostrarVentana(frm_ValidaCV, True)
    End Sub

    Private Sub PrefacturasDeProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrefacturasDeProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREFACTURAS DE PROCESO")

        FuncionesGlobales.MostrarVentana(frm_PreFacturaProceso, False)
    End Sub

    Private Sub GruposDeFacturaciónDeProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposDeFacturaciónDeProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GRUPOS DE FACTURACION DE PROCESO")

        FuncionesGlobales.MostrarVentana(frm_GruposFacturacion, True)
    End Sub

    Private Sub FacturasDeAdminPaqToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasDeAdminPaqToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        If tieneAdminPaq = "S" Then
            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAS ADMINPAQ")
            'MsgBox("Opción aún en desarrollo...", MsgBoxStyle.Exclamation, Me.Text)
            FuncionesGlobales.MostrarVentana(frm_AdminPaq, True)
        Else
            MsgBox("No se tiene enlace con el sistema AdminPaq", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub ReporteDeDotacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeDotacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DE DOTACIONES")

        FuncionesGlobales.MostrarVentana(frm_ReporteDotaciones, True)
    End Sub

    Private Sub ReporteDeConcentracionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeConcentracionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DE CONCENTRACIONES")

        FuncionesGlobales.MostrarVentana(frm_ReporteConcentraciones, True)
    End Sub

    Private Sub DepósitosPorCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepósitosPorCuentaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DEPOSITOS POR CUENTA")

        Dim frm As New frm_DepositosPorCuenta
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ReportarFallaEnEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnEquipoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN EQUIPO")

        Dim frm As New frm_ReporteFallas
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub AgruparMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgruparMovimientosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: AGRUPAR MOVIMIENTOS")

        FuncionesGlobales.MostrarVentana(frm_MovimientosAgrupar, True)
    End Sub

    Private Sub ReportarFallaEnSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnSistemaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN SISTEMA")

        Dim frm As New frm_ReporteFallasS
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ActualizacionesInstaladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionesInstaladasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA ACTUALIZACIONES INSTALADAS")
        Dim frm As New frm_ActualizacionesConsultar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultarChecadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarChecadorToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA CHECADOR")
        Dim frm As New frm_Checador
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub tsb_ValidarCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ValidarCV.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR COMPROBANTES DE VISITA")

        FuncionesGlobales.MostrarVentana(frm_ValidaCV, True)
    End Sub

    Private Sub tsb_MovimientosManuales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_MovimientosManuales.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: AGREGAR MOVIMIENTOS MANUALES")

        FuncionesGlobales.MostrarVentana(frm_MovimientosAgregar, True)
    End Sub

    Private Sub tsb_Agrupar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Agrupar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: AGRUPAR MOVIMIENTOS")

        FuncionesGlobales.MostrarVentana(frm_MovimientosAgrupar, True)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACERCA DE")

        Dim frm As New frm_About
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub SeguimientoAFallasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAFallasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SEGUIMIENTO A FALLAS")

        Dim frm As New frm_ReporteFallasConsultar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub PernoctasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PernoctasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PERNOCTAS")

        Dim frm As New frm_Pernoctas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConvertirAPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertirAPDFToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONVERTIR A PDF")

        Dim frm As New frm_ConvertirPDF
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub EnviarMailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarMailsToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MAILS")

        Dim frm As New frm_EnviarMail
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeAlertasRecibidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlertasRecibidasToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ALERTAS RECIBIDAS")

        Dim frm As New frm_AlertasConsultas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub SolicitudDeEquipoServicioYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeEquipoServicioYOtrosToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SOLICITUD DE EQUIPO, SERVICIOS Y OTROS")

        Dim frm As New frm_ReporteFallasI
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        Call InstallUpdateSyncWithInfo()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing
        Me.Cursor = Cursors.WaitCursor
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                Me.Cursor = Cursors.Default
                MsgBox("La actualización no se puede descargar en este momento. " + Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            Catch ioe As InvalidOperationException
                Me.Cursor = Cursors.Default
                MsgBox("Esta no es una Aplicacion ClickOnce. No se puede actualizar. Error: " & ioe.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Me.Cursor = Cursors.Default
                    Dim dr As DialogResult = MsgBox("Está disponible la nueva versión " & info.AvailableVersion.ToString & ". Desea Instalarla Ahora?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MsgBox("El Sistema ha detectado una actualización marcada como obligatoria. La versión mínima requerida es " & _
                        info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la Actualización y se reiniciará el Sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
                End If
                Me.Cursor = Cursors.WaitCursor
                If (doUpdate) Then
                    Try
                        AD.Update()
                        Me.Cursor = Cursors.Default
                        MsgBox("La Actualización se instaló correctamente, El Sistema se reiniciará.", MsgBoxStyle.Exclamation, Me.Text)
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo instalar la Actualziación. " & Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.Text)
                        Return
                    End Try
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se encontraron Actualizaciones Disponibles.", MsgBoxStyle.Information, Me.Text)
            End If
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Esta no es una aplicación ClickOnce Válida.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub DescargarManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarManualDeUsuarioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_DescargarArchivo
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub RecalcularTrasladosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalcularTrasladosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECALCULAR TRASLADOS")

        Dim frm As New frm_RecalcularTraslado
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CambiarConexiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR CONEXION")
        TipoBloqueo = 3

        Dim frm As New frm_Login
        CambiarConexion = True

        tmr_Hora.Enabled = False
        Me.Hide()
        frm.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: TIPO DE CAMBIO")

        Dim frm As New frm_TipodeCambio
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ReporteDeEntradasABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeEntradasABovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DE ENTRADAS A BOVEDA")

        Dim frm As New frm_ConsultaEntradas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConfigurarAdminPaqToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarAdminPaqToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONFIGURAR ADMINPAQ")

        Dim frm As New frm_SettingsAdminPaq
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub RequerimientoAntilavadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequerimientoAntilavadoToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REQUERIMIENTO ANTILAVADO")

        Dim frm As New frm_Antilavado
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ActualizarDomiciliosDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarDomiciliosDeClientesToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACTUALIZAR DOMICILIOS DE CLIENTES")

        Dim frm As New frm_Domicilios
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub FichasDeMorrallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichasDeMorrallaToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA FICHAS DE MORRALLA")

        Dim frm As New frm_FichasMorralla_Consulta
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultaDeDepósitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDepósitosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE DEPOSITOS")

        FuncionesGlobales.MostrarVentana(frm_ConsultaDepositos)
    End Sub

    Private Sub ConsultaFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaFacturasToolStripMenuItem.Click
        Dim frmfactura = New frm_ConsultaFacturas()
        FuncionesGlobales.MostrarVentana(frmfactura, True)
    End Sub

    Private Sub FacturacionAnticipadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionAnticipadaToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CLIENTES FACTURACION ANTICIPADA")

        Dim frm As New frm_ClientesFacturacionAnticipada
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub DescargarRemisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarRemisionToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: Descarga Remisiones Digitales")
        Dim frm As New frm_DescargarRemision
        frm.Show()
    End Sub

    Private Sub DescargarRemisionPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarRemisionPorFechaToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: Descarga Remisiones Digitales")
        Dim frm As New frm_DetalleDepositos
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub RastreoDeRemisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RastreoDeRemisionesToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: Rastreo de Remisiones Digitales")
        Dim frm As New frm_Rastreo
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub RemisionesPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemisionesPDFToolStripMenuItem.Click


        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: Rastreo de Remisiones Digitales PDF")

        FuncionesGlobales.MostrarVentana(frm_Remison_Digital, False)


    End Sub



End Class
