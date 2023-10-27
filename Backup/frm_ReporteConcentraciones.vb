Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_ReporteConcentraciones

    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_Grupo.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()
        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

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
            If Not fn_ConsultaConcentraciones_LlenarRemisiones(lsv_Dotaciones, cmb_CajaBancaria.SelectedValue, _
                                                    cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, CInt(cmb_Grupo.SelectedValue), Dpto) Then

                MsgBox("Ha ocurrido un error al intentar llenar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            gbx_Dotaciones.Text = lsv_Dotaciones.Items.Count & " Concentraciones o Depósitos"
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

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub

    Private Sub lsv_dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Desglose.Items.Clear()
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            If Not fn_ConsultaConcentraciones_LlenarDetalle(lsv_Desglose, lsv_Dotaciones.SelectedItems(0).Tag, CInt(cmb_Moneda.SelectedValue)) Then
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

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Dpto As Char = ""
        If rdb_Proceso.Checked Then
            Dpto = "P"
        ElseIf rdb_Morralla.Checked Then
            Dpto = "M"
        ElseIf rdb_Todo.Checked Then
            Dpto = "T"
        End If
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   REPORTE DE CONCENTRACIONES (" & cmb_Moneda.Text & ")"
        Dim Encabezado2 As String = "DEL  " & Microsoft.VisualBasic.Left(cmb_Desde.Text, 10) & "  AL  " & Microsoft.VisualBasic.Left(cmb_Hasta.Text, 10)
        If lsv_Dotaciones.Items.Count > 0 Then
            fn_ReporteConcentraciones_GenerarExcel(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, CInt(cmb_Grupo.SelectedValue), Dpto, Encabezado1, Encabezado2)
        End If
    End Sub

    Private Sub rdb_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Proceso.CheckedChanged
        Call LimpiarListas()
    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Dotaciones.Items.Clear()
        lsv_Desglose.Items.Clear()
        gbx_Dotaciones.Text = "0 Dotaciones"
        btn_Exportar.Enabled = False
    End Sub

    Private Sub chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grupo.CheckedChanged
        Call LimpiarListas()
        cmb_Grupo.SelectedIndex = 0
        cmb_Grupo.Enabled = Not chk_Grupo.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover, gbx_Desglose.MouseHover, gbx_Dotaciones.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
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

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Grupo.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Morralla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Morralla.CheckedChanged
        Call LimpiarListas()
    End Sub
End Class