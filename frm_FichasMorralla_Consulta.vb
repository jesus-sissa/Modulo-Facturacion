Imports Modulo_Verificacion_Scan.cn_Verificacion

Public Class frm_FichasMorralla_Consulta

    Private Sub frm_FichasMorralla_Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        cmb_Corte.AgregaParametro("@Fecha_Operacion", dtp_FechaOperacionI.Value, 2)
        cmb_Corte.Actualizar()

        cmb_Cliente.AgregaParametro("@Id_Sucursal", SucursalId, 1)
        cmb_Cliente.AgregaParametro("@Id_CajaBancaria", -1, 1)
        cmb_Cliente.AgregaParametro("@Status", "T", 0)

        cmb_Grupo.AgregaParametro("@Id_Cliente", -1, 1)

        cmb_CajaBancaria.Actualizar()

        lsv_Fichas.Columns.Add("Grupo") '0
        lsv_Fichas.Columns.Add("FechaOperacion") '1
        lsv_Fichas.Columns.Add("FechaRemision") '2
        lsv_Fichas.Columns.Add("Remision") '3
        lsv_Fichas.Columns.Add("Cliente") '4
        lsv_Fichas.Columns.Add("Maquina") '5
        lsv_Fichas.Columns.Add("Folio") '6
        lsv_Fichas.Columns.Add("DiceContener") '7
        lsv_Fichas.Columns.Add("ImporteRealT") '8
        lsv_Fichas.Columns.Add("ImporteReal") '9
        lsv_Fichas.Columns.Add("Diferencia") '10
        lsv_Fichas.Columns.Add("Desglose") '11
        lsv_Fichas.Columns.Add("FechaLarga", 0) '12
        lsv_Fichas.Columns.Add("IdM", 0) '13
        Call LimpiarLista()
    End Sub

    Private Sub Botones()
        If lsv_Fichas.Items.Count = 0 Then
            btn_ExportarLista.Enabled = False
            btn_ExportarGrupos.Enabled = False
        Else
            btn_ExportarLista.Enabled = True
            btn_ExportarGrupos.Enabled = True
        End If
    End Sub

    Private Sub LimpiarLista()
        SegundosDesconexion = 0
        lsv_Fichas.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub CargarCorte()
        SegundosDesconexion = 0

        If dtp_FechaOperacionI.Value.Date = dtp_FechaOperacionF.Value.Date Then
            cmb_Corte.Enabled = True
            cmb_Corte.ActualizaValorParametro("@Fecha_Operacion", dtp_FechaOperacionI.Value)
            cmb_Corte.Actualizar()
        Else
            cmb_Corte.SelectedValue = 0
            cmb_Corte.Enabled = False
        End If
        Call LimpiarLista()
    End Sub

    Private Sub LlenarConsulta()
        SegundosDesconexion = 0

        Call LimpiarLista()

        If dtp_FechaOperacionI.Value.Date > dtp_FechaOperacionF.Value.Date Then
            MsgBox("La Fecha Inicial no puede ser mayor a la Fecha Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaOperacionI.Focus()
            Exit Sub
        End If

        If dtp_FechaOperacionI.Value.Date = dtp_FechaOperacionF.Value.Date Then
            If cmb_Corte.SelectedValue = 0 Then
                MsgBox("Seleccione un Cierre Parcial.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Corte.Focus()
                Exit Sub
            End If
        End If

        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If cmb_Grupo.SelectedValue = 0 AndAlso Not chk_Grupo.Checked Then
            MsgBox("Seleccione un Grupo o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Grupo.Focus()
            Exit Sub
        End If

        If Not Cn_Facturacion.fn_FichasMorrallaConsulta_Consulta(lsv_Fichas, dtp_FechaOperacionI.Value.Date, dtp_FechaOperacionF.Value.Date, cmb_Corte.SelectedValue, cmb_CajaBancaria.SelectedValue, _
                                                  cmb_Grupo.SelectedValue, cmb_Cliente.SelectedValue, "T") Then
            MsgBox("Ocurrió un error al cargar la información", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Registros.Text = "Registros: " & lsv_Fichas.Items.Count
        Call Botones()
    End Sub

    Private Sub dtp_FechaOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaOperacionI.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_FechaOperacionF.Focus()
        End If
    End Sub

    Private Sub dtp_FechaOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaOperacionI.ValueChanged
        Call CargarCorte()
    End Sub

    Private Sub dtp_FechaOperacionF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaOperacionF.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            cmb_Corte.Focus()
        End If
    End Sub

    Private Sub dtp_FechaOperacionF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaOperacionF.ValueChanged
        Call CargarCorte()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0

        cmb_Cliente.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        cmb_Cliente.Actualizar()
        Call LimpiarLista()
    End Sub

    Private Sub chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grupo.CheckedChanged

        cmb_Grupo.SelectedValue = 0
        cmb_Grupo.Enabled = Not chk_Grupo.Checked
        Call LimpiarLista()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarConsulta()
    End Sub

    Private Sub btn_ExportarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarLista.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Fichas, 2, Me.Text, 0, 2, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_ExportarGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarGrupos.Click
        SegundosDesconexion = 0
        Dim dt_Fichas As DataTable = Nothing
        dt_Fichas = Cn_Facturacion.fn_FichasMorrallaConsulta_ConsultaDT(lsv_Fichas, dtp_FechaOperacionI.Value.Date, dtp_FechaOperacionF.Value.Date, cmb_Corte.SelectedValue, cmb_CajaBancaria.SelectedValue, _
                                                  cmb_Grupo.SelectedValue, cmb_Cliente.SelectedValue, "T")
        Call Cn_Facturacion.ExportarGrupos(dt_Fichas)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cmb_Corte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Corte.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0

        If cmb_Cliente.SelectedValue = 0 Then
            cmb_Grupo.ActualizaValorParametro("@Id_Cliente", -1)
        Else
            cmb_Grupo.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
        End If
        cmb_Grupo.Actualizar()
        Call LimpiarLista()
    End Sub

    Private Sub lsv_Fichas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

End Class