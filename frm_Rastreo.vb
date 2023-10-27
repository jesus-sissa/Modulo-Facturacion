Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_Rastreo

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub Buscar()
        If tbx_Remision.Text <> "" Then
            cmb_Cia.ValorParametro = CLng(tbx_Remision.Text)
            cmb_Cia.Actualizar()

            If cmb_Cia.Items.Count = 2 Then
                cmb_Cia.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub frm_Rastreo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cia.ValorParametro = 0
        cmb_Cia.Actualizar()

        If Not fn_Rastreo_LlenarImportes(lsv_Importe, 0) Then
            MsgBox("Ha ocurrido un error al intentar llenar los Importes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not fn_Rastreo_LlenarEnvases(lsv_Envases, 0) Then
            MsgBox("Ha ocurrido un error al intentar llenar los Envases.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Importe.Items.Count

    End Sub

    Private Sub tbx_Remision_EnterPress() Handles tbx_Remision.EnterPress
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0

        If Not fn_Rastreo_LlenarImportes(lsv_Importe, cmb_Cia.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar llenar los importes", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Importe.Items.Count

        If Not fn_Rastreo_LlenarEnvases(lsv_Envases, cmb_Cia.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar llenar los envases", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Dim row As DataRow = fn_Rastreo_LlenarBoveda(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaEntrada.Text = row("Fecha_Entrada").ToString
            tbx_HoraEntrada.Text = row("Hora_Entrada").ToString
            tbx_FechaSalida.Text = row("Fecha_Salida").ToString
            tbx_HoraSalida.Text = row("Hora_Salida").ToString
            tbx_UsuarioEntrada.Text = row("Usuario_Entrada").ToString
            tbx_UsuarioSalida.Text = row("Usuario_Salida").ToString
            cbx_DotacionPro.Checked = (row("DotacionPro").ToString = "S")
            cbx_DotacionMorralla.Checked = (row("DotacionMorr").ToString = "S")
            cbx_DotacionATM.Checked = (row("DotacionATM").ToString = "S")
            cbx_Materiales.Checked = (row("Material").ToString = "S")
            cbx_ConcentracionATM.Checked = (row("ConcentracionATM").ToString = "S")
            cbx_CustodiaATM.Checked = (row("CustodiaATM").ToString = "S")
            cbx_DotacionNom.Checked = (row("DotacionNom").ToString = "S")
            tbx_Status.Text = row("Status").ToString
        Else
            tbx_FechaEntrada.Clear()
            tbx_HoraEntrada.Clear()
            tbx_FechaSalida.Clear()
            tbx_HoraSalida.Clear()
            tbx_UsuarioEntrada.Clear()
            tbx_UsuarioSalida.Clear()
            cbx_DotacionPro.Checked = False
            cbx_DotacionMorralla.Checked = False
            cbx_DotacionATM.Checked = False
            cbx_Materiales.Checked = False
            cbx_ConcentracionATM.Checked = False
            cbx_CustodiaATM.Checked = False
            cbx_DotacionNom.Checked = False
            tbx_Status.Clear()
        End If
        'Llenar la tabla de asignaciones de Fecha y Hora
        If Not fn_Rastreo_LlenarAsignaFyR(lsv_AsignaFecha, cmb_Cia.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar llenar los datos de asignación de Fecha y Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If


        row = fn_Rastreo_LlenarProceso(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_Sesion.Text = row("Numero_Sesion").ToString
            tbx_CajaBancaria.Text = row("Caja").ToString
            tbx_Cliente.Text = row("Cliente").ToString
            tbx_Cajero.Text = row("Cajero").ToString
            tbx_GrupoDeposito.Text = row("GrupoDepo").ToString
            tbx_FechaRecepcion.Text = row("Fecha_Recibe").ToString
            tbx_FechaAsignacion.Text = row("Fecha_Asigna").ToString
            tbx_FechaInicioVerificacion.Text = row("Fecha_InicioV").ToString
            tbx_FechaFinVerificacion.Text = row("Fecha_FinV").ToString
            tbx_FechaContabilizacion.Text = row("Fecha_Contabiliza").ToString
            tbx_Fichas.Text = row("Cantidad_Fichas").ToString
            tbx_FichasContabilizadas.Text = row("Cantidad_FichasC").ToString
            tbx_Corte.Text = row("Corte_Turno").ToString
            tbx_EstacionRecibe.Text = row("Estacion_Recibe").ToString
            tbx_EstacionAsigna.Text = row("Estacion_Asigna").ToString
            tbx_EstacionVerifica.Text = row("Estacion_Verifica").ToString
            tbx_MinutosVerificando.Text = row("MinutosVerificando").ToString
            tbx_StatusPro.Text = row("Status").ToString
        Else
            tbx_Sesion.Clear()
            tbx_CajaBancaria.Clear()
            tbx_Cliente.Clear()
            tbx_Cajero.Clear()
            tbx_GrupoDeposito.Clear()
            tbx_FechaRecepcion.Clear()
            tbx_FechaAsignacion.Clear()
            tbx_FechaInicioVerificacion.Clear()
            tbx_FechaFinVerificacion.Clear()
            tbx_FechaContabilizacion.Clear()
            tbx_Fichas.Clear()
            tbx_FichasContabilizadas.Clear()
            tbx_Corte.Clear()
            tbx_EstacionRecibe.Clear()
            tbx_EstacionAsigna.Clear()
            tbx_EstacionVerifica.Clear()
            tbx_MinutosVerificando.Clear()
            tbx_StatusPro.Clear()
        End If

        row = fn_Rastreo_LlenarProDotaciones(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaCaptura.Text = row("Fecha_Captura").ToString
            tbx_FechaValida.Text = row("Fecha_Valida").ToString
            tbx_FechaEntrega.Text = row("Fecha_Entrega").ToString
            tbx_FechaCancela.Text = row("Fecha_Cancela").ToString
            tbx_Caja.Text = row("Caja").ToString
            tbx_NombreCliente.Text = row("Cliente").ToString
            tbx_UsuarioCaptura.Text = row("Usuario_Captura").ToString
            tbx_UsuarioValida.Text = row("Usuario_Valida").ToString
            tbx_UsuarioCancela.Text = row("Usuario_Cancela").ToString
            tbx_Importe.Text = row("Importe").ToString
            tbx_Envases.Text = row("Envases").ToString
            tbx_Moneda.Text = row("Moneda").ToString
            tbx_Tipo.Text = row("Tipo").ToString
            tbx_StatusDP.Text = row("Status").ToString
            tbx_UsuarioAsignaFecha.Text = row("Usuario_AsignaFecha").ToString
            tbx_UsuarioAsignaRuta.Text = row("Usuario_AsignaRuta").ToString
            tbx_FechaAsignaFecha.Text = row("Fecha_AsignaFecha").ToString
            tbx_FechaAsignaRuta.Text = row("Fecha_AsignaRuta").ToString
            tbx_RutaEntrega.Text = row("Ruta_Entrega").ToString

        Else
            tbx_FechaCaptura.Clear()
            tbx_FechaValida.Clear()
            tbx_FechaEntrega.Clear()
            tbx_FechaCancela.Clear()
            tbx_Caja.Clear()
            tbx_NombreCliente.Clear()
            tbx_UsuarioCaptura.Clear()
            tbx_UsuarioValida.Clear()
            tbx_UsuarioCancela.Clear()
            tbx_Importe.Clear()
            tbx_Envases.Clear()
            tbx_Moneda.Clear()
            tbx_Tipo.Clear()
            tbx_StatusDP.Clear()
            tbx_UsuarioAsignaFecha.Clear()
            tbx_UsuarioAsignaRuta.Clear()
            tbx_FechaAsignaFecha.Clear()
            tbx_FechaAsignaRuta.Clear()
            tbx_RutaEntrega.Clear()
        End If

        row = fn_Rastreo_LlenarCajDotaciones(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaCapturaC.Text = row("Fecha_Captura").ToString
            tbx_FechaValidaC.Text = row("Fecha_Valida").ToString
            tbx_FechaEntregaC.Text = row("Fecha_Entrega").ToString
            tbx_FechaCancelaC.Text = row("Fecha_Cancela").ToString
            tbx_CajaC.Text = row("Caja").ToString
            tbx_NumeroCajeroC.Text = row("Numero_Cajero").ToString
            tbx_CajeroC.Text = row("Cajero").ToString
            tbx_UsuarioCapturaC.Text = row("Usuario_Captura").ToString
            tbx_UsuarioValidaC.Text = row("Usuario_Valida").ToString
            tbx_UsuarioCancelaC.Text = row("Usuario_Cancela").ToString
            tbx_ImporteC.Text = row("Importe").ToString
            tbx_EnvasesC.Text = row("Envases").ToString
            tbx_MonedaC.Text = row("Moneda").ToString
            tbx_StatusDC.Text = row("Status").ToString
        Else
            tbx_FechaCapturaC.Clear()
            tbx_FechaValidaC.Clear()
            tbx_FechaEntregaC.Clear()
            tbx_FechaCancelaC.Clear()
            tbx_CajaC.Clear()
            tbx_NumeroCajeroC.Clear()
            tbx_CajeroC.Clear()
            tbx_UsuarioCapturaC.Clear()
            tbx_UsuarioValidaC.Clear()
            tbx_UsuarioCancelaC.Clear()
            tbx_ImporteC.Clear()
            tbx_EnvasesC.Clear()
            tbx_MonedaC.Clear()
            tbx_StatusDC.Clear()
        End If

        row = fn_Rastreo_LlenarMateriales(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_DestinoM.Text = row("Destino")
            tbx_FechaRegistroM.Text = row("Fehca_Registro")
            tbx_HoraRegistroM.Text = row("Hora_Registro")
            tbx_UsuarioRegistroM.Text = row("Fehca_Valida")
            tbx_FechaValidaM.Text = row("Hora_Valida")
            tbx_HoraValidaM.Text = row("Usuario_Registro")
            tbx_UsuarioValidaM.Text = row("usuario_Valida")
            'tbx_StatusM.Text = row("Status")
        Else
            tbx_DestinoM.Clear()
            tbx_FechaRegistroM.Clear()
            tbx_HoraRegistroM.Clear()
            tbx_UsuarioRegistroM.Clear()
            tbx_FechaValidaM.Clear()
            tbx_HoraValidaM.Clear()
            tbx_UsuarioValidaM.Clear()
            tbx_StatusM.Clear()
        End If

        row = fn_Rastreo_LlenarTraslado(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_RutaT.Text = row("Ruta")
            tbx_FechaT.Text = row("Fecha")
            tbx_OrigenT.Text = row("Origen")
            tbx_DestinoT.Text = row("Destino")
            tbx_CajeroT.Text = row("Cajero")
            tbx_OperadorT.Text = row("Operador")
            tbx_HorarioRecoleccionT.Text = row("HR_Recoleccion")
            tbx_HorarioEntregaT.Text = row("HR_Entrega")
            tbx_StatusT.Text = row("Status")
        Else
            tbx_RutaT.Clear()
            tbx_FechaT.Clear()
            tbx_OrigenT.Clear()
            tbx_DestinoT.Clear()
            tbx_CajeroT.Clear()
            tbx_OperadorT.Clear()
            tbx_HorarioRecoleccionT.Clear()
            tbx_HorarioEntregaT.Clear()
            tbx_StatusT.Clear()
        End If
        row = fn_Rastreo_ObtenerAmparada(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            lbl_Leyenda.Visible = True
            If row("Id_RemisionAmparada") > 0 Then
                lbl_Leyenda.Text = "La Remisión " & tbx_Remision.Text & " Ampara a la Remisión " & row("NumRemisionAmparada")
            ElseIf row("Id_RemisionNueva") > 0 Then
                lbl_Leyenda.Text = "La Remisión " & tbx_Remision.Text & " fué Reemplazada por la Remisión " & row("NumRemisionNueva")
            Else
                lbl_Leyenda.Visible = False
            End If
        Else
            lbl_Leyenda.Visible = False
        End If
    End Sub

End Class