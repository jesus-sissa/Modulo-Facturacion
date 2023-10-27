Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_ReporteDotaciones

    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        cmb_Grupo.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()

        lsv_Dotaciones.Columns.Add("Remision")
        lsv_Dotaciones.Columns.Add("Fecha")
        lsv_Dotaciones.Columns.Add("Sesion")
        lsv_Dotaciones.Columns.Add("Cliente")
        lsv_Dotaciones.Columns.Add("Moneda")
        lsv_Dotaciones.Columns.Add("Importe")
        lsv_Dotaciones.Columns.Add("Envases")
        lsv_Dotaciones.Columns.Add("EnvasesSN")
        lsv_Dotaciones.Columns.Add("Status")

        lsv_Desglose.Columns.Add("Presentacion")
        lsv_Desglose.Columns.Add("Denominacion")
        lsv_Desglose.Columns.Add("Cantidad")
        lsv_Desglose.Columns.Add("Importe")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        LimpiarListas()
        If Validar() Then
            Dim Tipo As Integer
            If rdb_Proceso.Checked Then
                Tipo = 1
            ElseIf rdb_Morralla.Checked Then
                Tipo = 2
            ElseIf rdb_Todo.Checked Then
                Tipo = 0
            End If
            If Not fn_ConsultaDotaciones_LlenarRemisiones(lsv_Dotaciones, cmb_CajaBancaria.SelectedValue, _
                                                    dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Moneda.SelectedValue, CInt(cmb_Grupo.SelectedValue), Tipo) Then

                MsgBox("Ha ocurrido un error al intentar llenar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            lsv_Dotaciones.Columns(10).Width = 0
            gbx_Dotaciones.Text = lsv_Dotaciones.Items.Count & " Dotaciones"
            If lsv_Dotaciones.Items.Count > 0 Then
                btn_Exportar.Enabled = True
            Else
                btn_Exportar.Enabled = False
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("Las fechas seleccionadas son incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Return False
        End If

        If chk_Grupo.Checked = False And cmb_Grupo.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Grupo de Facturación o Todos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Grupo.Focus()
            Return False
        End If

        If rdb_Proceso.Checked = False And rdb_Morralla.Checked = False And rdb_Todo.Checked = False Then
            MsgBox("Debe seleccionar el Tipo de Consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If


        Return True
    End Function


    Private Sub lsv_dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Desglose.Items.Clear()
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            If Not fn_ConsultaDotaciones_LlenarDetalle(lsv_Desglose, lsv_Dotaciones.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar el detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Grupo.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        cmb_Grupo.Actualizar()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LimpiarListas()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Tipo As Integer
        If rdb_Proceso.Checked Then
            Tipo = 1
        ElseIf rdb_Morralla.Checked Then
            Tipo = 2
        ElseIf rdb_Todo.Checked Then
            Tipo = 0
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   REPORTE DE DOTACIONES "
        Dim Encabezado2 As String = "DEL  " & dtp_Desde.Value.Date.ToShortDateString & "  AL  " & dtp_Hasta.Value.Date.ToShortDateString
        If lsv_Dotaciones.Items.Count > 0 Then
            fn_ReporteDotaciones_GenerarExcel(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, CInt(cmb_Grupo.SelectedValue), Tipo, Encabezado1, Encabezado2)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rdb_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Proceso.CheckedChanged
        Call LimpiarListas()
    End Sub

    Sub LimpiarListas()
        lsv_Dotaciones.Items.Clear()
        lsv_Desglose.Items.Clear()
        gbx_Dotaciones.Text = "0 Dotaciones"
        btn_Exportar.Enabled = False
    End Sub

    Private Sub chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grupo.CheckedChanged
        Call LimpiarListas()
        cmb_Grupo.SelectedIndex = 0
        cmb_Grupo.Enabled = not chk_Grupo.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Dotaciones_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.MouseHover, lsv_Desglose.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_Moneda.Focus()
    End Sub

    Private Sub cmb_Moneda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Moneda.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Grupo.Enabled Then
                cmb_Grupo.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grupo.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Morralla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Morralla.CheckedChanged
        Call LimpiarListas()
    End Sub
End Class