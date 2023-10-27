Imports System.IO
Imports Modulo_Facturacion.Cn_Facturacion
Imports Modulo_Facturacion.FuncionesGlobales
Imports Modulo_Facturacion.Remision_Digital

Public Class frm_DetalleDepositos
    Dim _path As String
    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        Cmb_grupo.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Moneda.Actualizar()

        cmb_CajaBancaria.Actualizar()

        Cmb_Clientes.AgregaParametro("@Status", "A", 0)
        Cmb_Clientes.Actualizar()

        Cmb_ClientesP.AgregaParametro("@Activos", "", 0)
        Cmb_ClientesP.AgregaParametro("@Id_CajaBancaria", 0, 1)
        Cmb_ClientesP.AgregaParametro("@Id_Cia", 0, 1)
        Cmb_ClientesP.Actualizar()

        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()
        Cmb_Compañia.Actualizar()

        lsv_Dotaciones.Columns.Add("Remision")
        lsv_Dotaciones.Columns.Add("Fecha")
        lsv_Dotaciones.Columns.Add("Sesion")
        lsv_Dotaciones.Columns.Add("Cliente")
        lsv_Dotaciones.Columns.Add("Moneda")
        lsv_Dotaciones.Columns.Add("Importe")
        lsv_Dotaciones.Columns.Add("Envases")
        lsv_Dotaciones.Columns.Add("EnvasesSN")
        lsv_Dotaciones.Columns.Add("Status")



    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Dpto As String = ""
        LimpiarListas()
        Me.Refresh()
        If Validar() Then
            If rdb_Proceso.Checked Then
                Dpto = "P"
            ElseIf rdb_Morralla.Checked Then
                Dpto = "M"
            ElseIf rdb_Todo.Checked Then
                Dpto = "T"
            End If
            If Not fn_DetalleDepositos_LlenarRemisiones(lsv_Dotaciones, cmb_CajaBancaria.SelectedValue, IIf(Chk_Clientes.Checked, 0, Cmb_Clientes.SelectedValue), _
                                                        cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, CInt(Cmb_grupo.SelectedValue), Dpto, _
                                                        Cmb_ClientesP.SelectedValue, Cmb_Compañia.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)
            If lsv_Dotaciones.Items.Count > 0 Then
                btn_Exportar.Enabled = True

            Else

                btn_Exportar.Enabled = False
            End If
        End If
    End Sub

    Private Sub LlenarClientes()
        If Cmb_Compañia.SelectedValue = 1 Then
            If Chk_Clientes.Checked = False Then
                Cmb_Clientes.Enabled = True
            End If
            Cmb_ClientesP.Enabled = False
            Cmb_ClientesP.Visible = False
            Cmb_ClientesP.SelectedIndex = 0
            Cmb_Clientes.Visible = True
            Cmb_Clientes.Actualizar()
        Else
            If Chk_Clientes.Checked = False Then
                Cmb_ClientesP.Enabled = True
            End If
            Cmb_Clientes.Enabled = False
            Cmb_Clientes.SelectedIndex = 0
            Cmb_ClientesP.Visible = True
            Cmb_Clientes.Visible = False
            Cmb_ClientesP.ActualizaValorParametro("@Activos", "A")
            Cmb_ClientesP.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
            Cmb_ClientesP.ActualizaValorParametro("@Id_Cia", Cmb_Compañia.SelectedValue)
            Cmb_ClientesP.Actualizar()
        End If
    End Sub

    Private Function Validar() As Boolean
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If Cmb_Clientes.SelectedIndex = 0 And Chk_Clientes.Checked = False And Cmb_ClientesP.SelectedIndex = 0 Then
            MsgBox("Seleccione un Cliente o Marque Todos", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Clientes.Focus()
            Cmb_ClientesP.Focus()
            Return False
        End If

        If cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Return False
        End If

        If cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Return False
        End If

        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If

        If chk_Grupo.Checked = False And Cmb_grupo.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Grupo o marcar la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_grupo.Focus()
            Return False
        End If

        If rdb_Proceso.Checked = False And rdb_Morralla.Checked = False And rdb_Todo.Checked = False Then
            MsgBox("Debe seleccionar el Tipo de Consulta(Proceso, Morralla o Ambos).", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub


    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call LimpiarListas()
        Cmb_grupo.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        Cmb_grupo.Actualizar()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
        'If Cmb_grupo.Items.Count >= 2 Then chk_Grupo.Enabled = True Else chk_Grupo.Enabled = False
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        If _path <> "" Then
            If lsv_Dotaciones.Items.Count > 0 Then
                Dim NumeroRemision As Decimal = 0
                Dim NumeroDesc As Integer = 0
                lbl_remisionesDescargadas.Text = NumeroDesc.ToString()
                frm_MENU.prg_Barra.Maximum = lsv_Dotaciones.Items.Count + 1
                'frm_MENU.prg_Barra.Maximum = lsv_Dotaciones.Items.Count + 1
                For Each item As ListViewItem In lsv_Dotaciones.Items

                    NumeroRemision = CDec(item.SubItems(0).Text)

                    Try

                        Dim notificiones As DataTable = Remision_Digital.obtenerNotificacion(Remision_Digital.obtenerPunto(NumeroRemision))

                        If notificiones.Rows.Count > 0 Then
                            '  im Query = dt.AsEnumerable.Where(Function(dr) dr("column name").ToString = "something").ToList
                            Dim remisiones As DataTable = notificiones.AsEnumerable.Where(Function(r) r("Numero_Remision").ToString = NumeroRemision).CopyToDataTable()
                            For Each noti As DataRow In remisiones.Rows
                                Dim dtRemisionImporte As DataTable = Remision_Digital.obtenerRemisionWebImporte(noti("Numero_Remision"))
                                Dim dtEnvases As DataTable = Remision_Digital.obtenerEnvases(noti("Numero_Remision"))
                                Dim dtMonedas As DataTable = Remision_Digital.obtenerImporteMoneda(noti("Numero_Remision"))

                                Dim envases As String = Remision_Digital.obtenerEnvases(dtEnvases)
                                Dim cantEnvaseBillete As Integer = Remision_Digital.obtenerEnvaseMoneda(dtEnvases)
                                Dim cantEnvaseMixto As Integer = Remision_Digital.obtenerEnvaseMixto(dtEnvases)
                                Dim cantEnvaseMorr As Integer = Remision_Digital.obtenerEnvaseMorralla(dtEnvases)

                                Dim impPesos As Decimal = Remision_Digital.obtenerMonenadaNacional(dtMonedas)
                                Dim impExtranjero As Decimal = Remision_Digital.obtenerMonenadaExtranjera(dtMonedas)
                                Dim impDoctos As Decimal = Remision_Digital.obtenerDocumentos(dtMonedas)

                                If dtRemisionImporte.Rows.Count = 0 Then
                                    Dim dr As DataRow = dtRemisionImporte.NewRow()
                                    dr("Mil") = 0
                                    dr("Cien") = 0
                                    dr("MVeinte") = 0
                                    dr("MDos") = 0
                                    dr("MPVeinte") = 0
                                    dr("Quinientos") = 0
                                    dr("Cincuenta") = 0
                                    dr("MDiez") = 0
                                    dr("MUno") = 0
                                    dr("MPDiez") = 0
                                    dr("Docientos") = 0
                                    dr("Veinte") = 0
                                    dr("MCinco") = 0
                                    dr("MPCincuenta") = 0
                                    dr("MPCinco") = 0
                                    dr("Id_RemisionesWebImportes") = 0
                                    dr("Id_Remision") = 0
                                    dr("Id_RemisionReal") = 0
                                    dtRemisionImporte.Rows.Add(dr)
                                End If

                                Dim pdf As MemoryStream = Remision_Digital.crearPDF(noti("Numero_Remision").ToString(), noti("Fecha").ToString(), noti("Hora").ToString(),
                                                                           noti("Envases").ToString() + "+ " + noti("EnvasesSN").ToString() + " S/N", envases, Convert.ToString(impDoctos + impExtranjero + impPesos), fn_EnLetras((impDoctos + impExtranjero + impPesos).ToString()),
                                                                           noti("NombreClienteOrigen").ToString(), noti("ClaveClienteOrigen").ToString(), noti("DireccionOrigen").ToString(),
                                                                           noti("NombreClienteDestino").ToString(), noti("DireccionDestino").ToString(), noti("Clave_Ruta").ToString(),
                                                                           noti("CiaTraslada").ToString(), noti("Unidad").ToString(), noti("Cajero").ToString(),
                                                                           noti("UsuarioClienteFirma").ToString(), Convert.ToString(impPesos), Convert.ToString(impExtranjero), Convert.ToString(impDoctos),
                                                                           cantEnvaseBillete.ToString(), cantEnvaseMorr.ToString(), cantEnvaseMixto.ToString(),
                                                                           dtRemisionImporte.Rows(0)("Mil").ToString(), dtRemisionImporte.Rows(0)("Quinientos").ToString(), dtRemisionImporte.Rows(0)("Docientos").ToString(),
                                                                           dtRemisionImporte.Rows(0)("Cien").ToString(), dtRemisionImporte.Rows(0)("Cincuenta").ToString(), dtRemisionImporte.Rows(0)("Veinte").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MVeinte").ToString(), dtRemisionImporte.Rows(0)("MDiez").ToString(), dtRemisionImporte.Rows(0)("MCinco").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MDos").ToString(), dtRemisionImporte.Rows(0)("MUno").ToString(), dtRemisionImporte.Rows(0)("MPCincuenta").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MPVeinte").ToString(), dtRemisionImporte.Rows(0)("MPDiez").ToString(), dtRemisionImporte.Rows(0)("MPCinco").ToString(), noti("Comentarios").ToString())


                                'guardar pdf

                                If pdf IsNot Nothing Then
                                    Dim pdfile As String = _path + "\" + NumeroRemision.ToString() + ".pdf"
                                    If File.Exists(pdfile) Then
                                        File.Delete(pdfile)
                                    End If
                                    Dim fs As FileStream = File.Create(pdfile)
                                    fs.Write(pdf.ToArray(), 0, pdf.Length)
                                    fs.Close()
                                    NumeroDesc += 1
                                    frm_MENU.prg_Barra.Value += 1
                                End If
                            Next

                        End If
                    Catch ex As Exception
                        MsgBox("Falta Informacion(Firma,autorizacion,etc) en la remision, no se puede descargar Remision", MsgBoxStyle.Critical, frm_MENU.Text)
                    End Try

                    lbl_remisionesDescargadas.Text = NumeroDesc.ToString()
                Next
                MsgBox("Descargado Corractamente", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Else
            MsgBox("Debe seleccionar un lugar donde guardar las remisiones", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Dim Folder As New FolderBrowserDialog()
            If Folder.ShowDialog = DialogResult.OK Then
                _path = Folder.SelectedPath
                txb_path.Text = Folder.SelectedPath
            End If
        End If

    End Sub

    Private Sub rdb_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Proceso.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Dotaciones.Items.Clear()

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)
        btn_Exportar.Enabled = False


    End Sub

    Private Sub chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Call LimpiarListas()
        Cmb_grupo.SelectedIndex = 0
        Cmb_grupo.Enabled = Not chk_Grupo.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover, gbx_Dotaciones.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Moneda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Moneda.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Cmb_grupo.Enabled Then
                Cmb_grupo.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Btn_ExportarEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        If MsgBox("Segun el rango de fechas seleccionado, este reporte puede tardar algunos segundos o incluso minutos en generarse. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Dpto As Char = ""
        If rdb_Proceso.Checked Then
            Dpto = "P"
        ElseIf rdb_Morralla.Checked Then
            Dpto = "M"
        ElseIf rdb_Todo.Checked Then
            Dpto = "T"
        End If
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   DETALLE DE DEPOSITOS/CONCENTRACIONES(" & cmb_Moneda.Text & ")"
        Dim Encabezado2 As String = "DEL  " & Microsoft.VisualBasic.Left(cmb_Desde.Text, 10) & "  AL  " & Microsoft.VisualBasic.Left(cmb_Hasta.Text, 10)
        If lsv_Dotaciones.Items.Count > 0 Then
        End If
    End Sub



    Private Sub chk_Grupo_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grupo.CheckedChanged
        SegundosDesconexion = 0
        Cmb_grupo.SelectedValue = 0
        Cmb_grupo.Enabled = Not chk_Grupo.Checked
        Call LimpiarListas()

    End Sub

    Private Sub cmb_Hasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Cmb_grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_grupo.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Morralla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Morralla.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Todo.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
        Cmb_Clientes.Enabled = Not Chk_Clientes.Checked
        Cmb_ClientesP.Enabled = Not Chk_Clientes.Checked

    End Sub

    Private Sub Cmb_Compañia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Compañia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
        Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
    End Sub

    Private Sub Cmb_ClientesP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_ClientesP.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim Folder As New FolderBrowserDialog()
        If Folder.ShowDialog = DialogResult.OK Then
            _path = Folder.SelectedPath
            txb_path.Text = Folder.SelectedPath
        End If
    End Sub
End Class