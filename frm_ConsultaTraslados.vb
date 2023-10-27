Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_ConsultaTraslados

    Dim ConsultaNormal As Boolean

    Private Sub frm_ConsultaTraslados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Hora")
        lsv_Datos.Columns.Add("Cliente")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Tipo")
        lsv_Datos.Columns.Add("Remisiones")
        lsv_Datos.Columns.Add("Envases")
        lsv_Datos.Columns.Add("Importe")
        lsv_Datos.Columns.Add("Miles")
        lsv_Datos.Columns.Add("Envases Ex")
        lsv_Datos.Columns.Add("Kilometros")
        lsv_Datos.Columns.Add("Status")
        lsv_Datos.Columns(11).Width = 120

        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Cia. Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")
        lsv_Remisiones.Columns.Add("Status")
        lsv_Remisiones.Columns.Add("Usr Valida")
        lsv_Remisiones.Columns.Add("FechaV")
        lsv_Remisiones.Columns.Add("DotacionProceso")
        lsv_Remisiones.Columns.Add("DotacionMorralla")
        lsv_Remisiones.Columns.Add("PagoMorralla")
        lsv_Remisiones.Columns.Add("PagoNomina")
        lsv_Remisiones.Columns.Add("NominaProcesada")
        lsv_Remisiones.Columns.Add("HoraR")
        lsv_Remisiones.Columns.Add("Origen")
        lsv_Remisiones.Columns.Add("Destino")
        lsv_Remisiones.Columns.Add("Sobres")

        lsv_RemisionesD.Columns.Add("Moneda")
        lsv_RemisionesD.Columns.Add("Efectivo")
        lsv_RemisionesD.Columns.Add("Documentos")
        lsv_RemisionesD.Columns.Add("Tipo Cambio")

        'Cargar el Combo con los Status
        cmb_Status.AgregarItem("A", "REGISTRADO")
        cmb_Status.AgregarItem("V", "VALIDADO")
        cmb_Status.AgregarItem("C", "CANCELADO")
        cmb_Status.AgregarItem("F", "FACTURADO")

        cmb_Clientes.AgregaParametro("@Status", "T", 0)
        cmb_Clientes.Actualizar()

        'Cargar el Combo con los Tipos de Movimiento
        cmb_TipoMov.AgregarItem("E", "ENTREGA")
        cmb_TipoMov.AgregarItem("R", "RECOLECCION")

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click

        ConsultaNormal = True

        Call LlenarLista()
        lbl_Cantidad.Text = "Se encontraron " & lsv_Datos.Items.Count & " Servicios."
    End Sub

    Private Sub btn_MostrarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarC.Click
        SegundosDesconexion = 0

        ConsultaNormal = False
        Call LlenarLista()
        Dim Cantidad As Integer = 0
        For Each Elemento As ListViewItem In lsv_Datos.Items
            Cantidad += CInt(Elemento.SubItems(1).Text)
        Next

        lbl_Cantidad.Text = "Se encontraron " & Cantidad & " Servicios."
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0

        Dim Status As Char = "T"
        Dim Id_Cliente As Integer = 0
        Dim TipoMov As Char = "T"
        Dim CompVisita As Char = ""

        Call LimpiarListas()

        If cmb_TipoMov.Enabled And cmb_TipoMov.SelectedValue = "0" Then
            MsgBox("Seleccione un Tipo de Movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoMov.Focus()
            Exit Sub
        End If

        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        If Not rdb_ExcluyeCV.Checked And Not rdb_IncluyeCV.Checked And Not rdb_SoloCV.Checked Then
            MsgBox("Seleccione alguna opción del Comprobante de Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Status.Enabled Then
            Status = cmb_Status.SelectedValue
        End If

        If cmb_Clientes.Enabled Then
            Id_Cliente = cmb_Clientes.SelectedValue
        End If

        If rdb_ExcluyeCV.Checked Then
            CompVisita = "N"
        ElseIf rdb_IncluyeCV.Checked Then
            CompVisita = "T" 'S
        ElseIf rdb_SoloCV.Checked Then
            CompVisita = "S" 'T
        End If

        If cmb_TipoMov.Enabled Then TipoMov = cmb_TipoMov.SelectedValue

        If ConsultaNormal Then
            lsv_Datos.Row1 = 7
            lsv_Datos.Row2 = 7
            lsv_Datos.Row3 = 5
            lsv_Datos.Row4 = 25
            lsv_Datos.Row5 = 8
            lsv_Datos.Row6 = 6
            lsv_Datos.Row7 = 6
            lsv_Datos.Row8 = 8
            lsv_Datos.Row9 = 6
            lsv_Datos.Row10 = 7
        Else
            lsv_Datos.Row1 = 15
            lsv_Datos.Row2 = 15
        End If

        If Not fn_Movimientos_Reporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, Id_Cliente, ConsultaNormal, lsv_Datos, TipoMov, CompVisita) Then
            btn_Exportar.Enabled = False
            MsgBox("Ocurrió un error al intentar consultar los Traslados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If ConsultaNormal Then
            lsv_Datos.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(9).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(10).TextAlign = HorizontalAlignment.Right
            lsv_Datos.Columns(12).Width = 0
            lsv_Datos.Columns(11).Width = 120
            ColorearCV()
        Else
            lsv_Datos.Columns(1).TextAlign = HorizontalAlignment.Right
        End If

        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Sub ColorearCV()
        For Each item As ListViewItem In lsv_Datos.Items
            If item.SubItems(12).Text > 0 Then item.ForeColor = Color.Red
        Next
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        Call LimpiarListas()
        If chk_Status.Checked Then
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = False
        Else
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = True
        End If
    End Sub

    Sub LimpiarListas()
        lbl_Cantidad.Text = "Se encontraron 0"
        lsv_Datos.Items.Clear()
        lsv_Remisiones.Items.Clear()
        lsv_RemisionesD.Items.Clear()
        btn_Exportar.Enabled = False
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        lsv_Remisiones.Items.Clear()
        lsv_RemisionesD.Items.Clear()
        If lsv_Datos.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Not ConsultaNormal Then Exit Sub
        If Not fn_MovimientosDLlenarLista(lsv_Datos.SelectedItems(0).Tag, lsv_Remisiones) Then
            MsgBox("Ocurrió un error al intentar consultar las Remisiones del Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_Remisiones.Columns(2).TextAlign = HorizontalAlignment.Right
        If lsv_Remisiones.Items.Count > 0 Then
            lsv_Remisiones.Items(0).Selected = True
        End If
    End Sub

    Private Sub lsv_Remisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged
        lsv_RemisionesD.Items.Clear()
        If lsv_Remisiones.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If Not fn_RemisionesDLlenarLista(lsv_Remisiones.SelectedItems(0).Tag, lsv_RemisionesD) Then
            MsgBox("Ocurrió un error al intentar consultar los Importes de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_RemisionesD.Columns(1).TextAlign = HorizontalAlignment.Right
        lsv_RemisionesD.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_RemisionesD.Columns(3).TextAlign = HorizontalAlignment.Right
    End Sub

   

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, "CONSULTA DE TRASLADOS " & dtp_Desde.Value.ToShortDateString & " - " & dtp_Hasta.Value.ToShortDateString, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover, lsv_Remisiones.MouseHover, lsv_RemisionesD.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_TipoMov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TipoMov.CheckedChanged
        Call LimpiarListas()
        If chk_TipoMov.Checked Then
            cmb_TipoMov.SelectedValue = "0"
            cmb_TipoMov.Enabled = False
        Else
            cmb_TipoMov.SelectedValue = "0"
            cmb_TipoMov.Enabled = True
        End If
    End Sub

    Private Sub cmb_TipoMov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoMov.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub rdb_ExcluyeCV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ExcluyeCV.CheckedChanged
        Call LimpiarListas()
    End Sub

    Private Sub rdb_IncluyeCV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_IncluyeCV.CheckedChanged
        Call LimpiarListas()
    End Sub

    Private Sub rdb_SoloCV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_SoloCV.CheckedChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_TipoMov.Focus()
        End If
    End Sub

    Private Sub cmb_TipoMov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_TipoMov.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                cmb_Clientes.Focus()
            End If
        End If
    End Sub

End Class