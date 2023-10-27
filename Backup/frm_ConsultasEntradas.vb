Public Class frm_ConsultaEntradas

    Private Sub frm_ConsultaEntradas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Cmb_Cliente.AgregaParametro("@Padres", "S", 0)
        Cmb_Cliente.Actualizar()
    End Sub

    Private Sub frm_ConsultaEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False
        
        Lsv_Rutas.Columns.Add("Remision")
        Lsv_Rutas.Columns.Add("FechaEntrada")
        Lsv_Rutas.Columns.Add("HoraEntrada")
        Lsv_Rutas.Columns.Add("ClaveOrigen")
        Lsv_Rutas.Columns.Add("NombreOrigen")
        Lsv_Rutas.Columns.Add("ClaveDestino")
        Lsv_Rutas.Columns.Add("NombreDestino")
        Lsv_Rutas.Columns.Add("Importe")
        Lsv_Rutas.Columns.Add("Envases")
        Lsv_Rutas.Columns.Add("Envases SN")
        Lsv_Rutas.Columns.Add("Status")
        Lsv_Rutas.Columns.Add("EnvasesTotal")

        Lsv_Procesos.Columns.Add("Remision")
        Lsv_Procesos.Columns.Add("FechaEntrada")
        Lsv_Procesos.Columns.Add("HoraEntrada")
        Lsv_Procesos.Columns.Add("Caja")
        Lsv_Procesos.Columns.Add("ClaveOrigen")
        Lsv_Procesos.Columns.Add("NombreOrigen")
        Lsv_Procesos.Columns.Add("Importe")
        Lsv_Procesos.Columns.Add("Envases")
        Lsv_Procesos.Columns.Add("Envases SN")
        Lsv_Procesos.Columns.Add("Status")
        Lsv_Procesos.Columns.Add("EnvasesTotal")

        BanderA = True
    End Sub

    Private Sub TabPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Function ValidaFecha() As Boolean
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha de Inicio no puede ser mayor a la fecha final.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SegundosDesconexion = 0

        If ValidaFecha() = True Then
            If Cmb_Cliente.SelectedValue = 0 And Ckb_Cliente.Checked = False Then
                MsgBox("Seleccione un Cliente ", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Call LlenaListas()
                Call Botones()
            End If
        End If
    End Sub

    Private Sub LlenaListas()
        SegundosDesconexion = 0
        Lbl_RegistrosR.Text = "Registros: 0"
        Lbl_RegistrosP.Text = "Registros: 0"
        If BanderA = True Then
            Cursor = Cursors.WaitCursor

            If Cmb_Cliente.SelectedValue = 0 And Ckb_Cliente.Checked = False Then
                Lsv_Rutas.Items.Clear()
                Lsv_Procesos.Items.Clear()
            Else

                Call Cn_Facturacion.fn_ConsultaEntradasRutasLlenalista(Lsv_Rutas, IIf(Ckb_Cliente.Checked, 0, Cmb_Cliente.SelectedValue), dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Lsv_Rutas.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(8).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(9).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(10).TextAlign = HorizontalAlignment.Right
                Lsv_Procesos.Columns(10).Width = 60

                Call Cn_Facturacion.fn_ConsultaEntradasLlenalista(Lsv_Procesos, IIf(Ckb_Cliente.Checked, 0, Cmb_Cliente.SelectedValue), 1, CiaId, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Lsv_Procesos.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Procesos.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_Procesos.Columns(8).TextAlign = HorizontalAlignment.Right
                Lsv_Procesos.Columns(9).TextAlign = HorizontalAlignment.Right
                Lsv_Procesos.Columns(10).Width = 60

            End If

        End If

        Lbl_RegistrosR.Text = "Registros: " & Lsv_Rutas.Items.Count
        Lbl_RegistrosP.Text = "Registros: " & Lsv_Procesos.Items.Count

        Cursor = Cursors.Default
    End Sub

    Private Sub Ckb_Cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_Cliente.CheckedChanged
        SegundosDesconexion = 0
        Call Limpiar()
        If Ckb_Cliente.Checked = True Then
            Cmb_Cliente.Enabled = False
            Tbx_Clv_Cliente.Enabled = False
            Cmb_Cliente.SelectedValue = 0
        Else
            Cmb_Cliente.Enabled = True
            Tbx_Clv_Cliente.Enabled = True
        End If

    End Sub

    Private Sub Btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exportar.Click
        SegundosDesconexion = 0


        If TabPage.SelectedTab Is Rutas Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Rutas, 2, Me.Text, 0, 1, frm_MENU.prg_Barra)
        ElseIf TabPage.SelectedTab Is Procesos Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Procesos, 2, Me.Text, 0, 1, frm_MENU.prg_Barra)
        End If
    End Sub

    Private Sub Botones()
        SegundosDesconexion = 0
        Btn_Exportar.Enabled = False
        If TabPage.SelectedTab Is Rutas Then
            If Lsv_Rutas.Items.Count > 0 Then Btn_Exportar.Enabled = True
        ElseIf TabPage.SelectedTab Is Procesos Then
            If Lsv_Procesos.Items.Count > 0 Then Btn_Exportar.Enabled = True
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged, dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        SegundosDesconexion = 0
        Btn_Exportar.Enabled = False
        Lsv_Rutas.Items.Clear()
        Lsv_Procesos.Items.Clear()
        Lbl_RegistrosP.Text = "Registros: 0"
        Lbl_RegistrosR.Text = "Registros: 0"
    End Sub

    Private Sub Cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

End Class