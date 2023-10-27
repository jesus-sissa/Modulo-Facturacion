Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_RecalcularTraslado

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Call LlenarLista()
    End Sub

    Sub LimpiarListas()
        prg_Barra.Value = 0
        SegundosDesconexion = 0
        lsv_Datos.Items.Clear()
        lsv_Remisiones.Items.Clear()
        lsv_RemisionesD.Items.Clear()
        btn_Recalcular.Enabled = False
        Lbl_RegistrosP.Text = "Registros: 0"
    End Sub

    Private Sub frm_RecalcularTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cargar el Combo con los Status
        cmb_Status.AgregarItem("A", "REGISTRADO")
        cmb_Status.AgregarItem("V", "VALIDADO")
        cmb_Status.AgregarItem("C", "CANCELADO")
        cmb_Status.AgregarItem("F", "FACTURADO")

        cmb_Clientes.Actualizar()
        'Cargar el Combo con los Tipos de Movimiento
        cmb_TipoMov.AgregarItem("E", "ENTREGA")
        cmb_TipoMov.AgregarItem("R", "RECOLECCION")
        'rdb_RecalcularNormal.Checked = False
        'rdb_RecalcularNormal.Enabled = False

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

        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Cia. Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")
        lsv_Remisiones.Columns.Add("Status")

        lsv_RemisionesD.Columns.Add("Moneda")
        lsv_RemisionesD.Columns.Add("Efectivo")
        lsv_RemisionesD.Columns.Add("Documentos")
        lsv_RemisionesD.Columns.Add("Tipo Cambio")
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

    Sub LlenarLista()
        prg_Barra.Value = 0
        SegundosDesconexion = 0
        Lbl_RegistrosP.Text = "Registros: 0"

        Dim Status As Char = "T"
        Dim Id_Cliente As Integer = 0
        Dim TipoMov As Char = "T"
        Dim CompVisita As Char = "N"

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

        If cmb_Status.Enabled Then
            Status = cmb_Status.SelectedValue
        End If

        If cmb_Clientes.Enabled Then
            Id_Cliente = cmb_Clientes.SelectedValue
        End If

        If cmb_TipoMov.Enabled Then TipoMov = cmb_TipoMov.SelectedValue

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

        If Not fn_Movimientos_ConsultaRecalcular1(lsv_Datos, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, Id_Cliente, TipoMov, CompVisita) Then
            btn_Recalcular.Enabled = False
            MsgBox("Ocurrió un error al intentar consultar los Traslados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Lbl_RegistrosP.Text = "Registros: " & lsv_Datos.Items.Count
        btn_Recalcular.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        If lsv_Datos.SelectedItems.Count = 0 Then
            Exit Sub
        End If

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

    Private Sub btn_Recalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recalcular.Click
        Dim Status As Char = "T"
        Dim Id_Cliente As Integer = 0
        Dim TipoMov As Char = "T"
        Dim CompVisita As Char = "N"

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

        If cmb_Status.Enabled Then
            Status = cmb_Status.SelectedValue
        End If

        If cmb_Clientes.Enabled Then
            Id_Cliente = cmb_Clientes.SelectedValue
        End If

        If cmb_TipoMov.Enabled Then TipoMov = cmb_TipoMov.SelectedValue
        Me.Cursor = Cursors.WaitCursor
        '---------------------------------------------------------------------
        'Traer todas las remisiones de cada Movimiento Utilizando los mismos filtros que la consulta que carga el Listview
        Dim dt_Movimientos As DataTable = fn_Movimientos_ConsultaRecalcular2(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, Id_Cliente, TipoMov, CompVisita)
        Dim dt_Remisiones As DataTable = fn_Movimientos_ConsultaRecalcular3(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, Id_Cliente, TipoMov, CompVisita)

        'FuncionesGlobales.fn_ExportarExcelDT(dt_Movimientos, 0, "", 0, 0, frm_MENU.prg_Barra)
        'FuncionesGlobales.fn_ExportarExcelDT(dt_Remisiones, 0, "", 0, 0, frm_MENU.prg_Barra)

        Dim TotalImporte As Decimal = 0
        Dim TotalRemisiones As Integer = 0
        Dim TotalEnvases As Integer = 0
        Dim Miles As Decimal = 0.0
        Dim Miles_Scosto As Decimal = 0
        Dim CantidadXunidad As Decimal = 0
        Dim CobraDoctos As String = "S"
        Dim Redondeado As String = "S"
        Dim dr_Temporal() As DataRow

        prg_Barra.Maximum = dt_Movimientos.Rows.Count + 1
        prg_Barra.Value = 0
        For Each Elemento As DataRow In dt_Movimientos.Rows
            dr_Temporal = Nothing
            dr_Temporal = dt_Remisiones.Select("Id_Movimiento=" & Elemento("Id_Movimiento"))
            TotalEnvases = 0
            TotalRemisiones = 0
            TotalImporte = 0
            Miles = 0
            If dr_Temporal.Length = 0 Then Continue For
            For i As Byte = 0 To dr_Temporal.Count - 1
                TotalRemisiones += 1
                TotalEnvases += dr_Temporal(i)("Envases")
                TotalEnvases += dr_Temporal(i)("Envases_S/N")
                TotalImporte += dr_Temporal(i)("ImporteTotalRD")
                'actualiza Remisiones Importe
                If Not fn_Movimientos_ActualizaRemisiones(CDec(dr_Temporal(i)("ImporteTotalRD")), dr_Temporal(i)("ID_Remision")) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrió un Error al Intentar Actualizar la Remisión " & dr_Temporal(i)("ID_Remision"), MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Cursor = Cursors.WaitCursor
                End If

            Next

            CobraDoctos = Elemento("CobraDoctos")
            CantidadXunidad = Elemento("CantidadUnidad")
            Redondeado = Elemento("Redondeado")
            Miles_Scosto = Elemento("MSC")

            If Redondeado = "N" Then
                Miles = TotalImporte / 1000
            Else
                If (TotalImporte Mod 1000) > 0 Then
                    If (TotalImporte Mod 1000) >= 999.5 Then
                        Miles = ((TotalImporte \ 1000))
                        'Le quité el "+1" porque cuando el resultado del mod es muy cercano a 1000
                        'se redondea automaticamente y el calculo de los miles sale mal
                        'sale 1 mil de mas
                    Else
                        Miles = (TotalImporte \ 1000) + 1
                    End If
                Else
                    Miles = TotalImporte / 1000
                End If

            End If
            If Miles_Scosto > Miles Then
                Miles = 0
            Else
                Miles = Miles - Miles_Scosto
            End If

            If Not fn_Movimientos_ActualizaMovimientos(TotalImporte, TotalRemisiones, TotalEnvases, Miles, Elemento("Id_Movimiento")) Then

            End If
            prg_Barra.Value += 1
        Next
        prg_Barra.Value = prg_Barra.Maximum
        Me.Cursor = Cursors.Default
        MsgBox("Proceso Terminado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, frm_MENU.Text)
        '------------------------------------------------------------------------
        'Call LimpiarListas()
        'Call LlenarLista() 

    End Sub

    Private Sub cmb_TipoMov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoMov.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LimpiarListas()
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

End Class