Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_Pernoctas

    Private Sub frm_Pernoctas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()

            Case Keys.F4
                If btn_Eliminar.Enabled Then btn_Eliminar_Click(btn_Eliminar, Nothing)

            Case Keys.F2
                If btn_Validar.Enabled Then btn_Validar_Click(btn_Validar, Nothing)
        End Select

    End Sub

    Private Sub frm_Pernoctas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date
        dtp_Fecha.Value = Now.Date

        cmb_CS.AgregaParametro("@Id_Cliente", -1, 1)
        cmb_CS.AgregaParametro("@Clave_Linea", "BOV", 0)
        cmb_CS.AgregaParametro("@MostrarPrecio", "N", 0)
        cmb_CS.Actualizar()

        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("V", "VALIDADOS")

        lsv_Pernoctas.Columns.Add("Fecha")
        lsv_Pernoctas.Columns.Add("Clave")
        lsv_Pernoctas.Columns.Add("Cliente")
        lsv_Pernoctas.Columns.Add("Remisión")
        lsv_Pernoctas.Columns.Add("Importe")
        lsv_Pernoctas.Columns.Add("Miles")
        lsv_Pernoctas.Columns.Add("ObservacionesRegistro")
        lsv_Pernoctas.Columns.Add("Status")
        lsv_Pernoctas.Columns.Add("ObservacionesValidacion")
    End Sub

    Sub Limpiar()
        dtp_Fecha.Value = Now.Date
        cmb_CS.SelectedValue = 0
        tbx_Observaciones.Clear()
        tbx_ObservacionesValida.Clear()
        tbx_Cliente.Clear()
    End Sub

    Sub LlenarLista()
        lsv_Pernoctas.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Dim Status As Char = cmb_Status.SelectedValue
        If chk_Status.Checked Then Status = "T"
        If Not fn_Pernoctas_LlenarPernoctas(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, lsv_Pernoctas) Then
            MsgBox("Ocurrio un error al intentar consultar las Pernoctas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_Registros.Text = "Registros: " & lsv_Pernoctas.Items.Count
    End Sub

    Private Sub Controles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged, dtp_Desde.ValueChanged, cmb_Status.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Pernoctas.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Validar.Enabled = False
        btn_Eliminar.Enabled = False
        Call Limpiar()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        lsv_Pernoctas.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        btn_Validar.Enabled = False
        btn_Eliminar.Enabled = False
        Call Limpiar()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        'Validar datos
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicio no puede ser mayor al a Fecha Fin.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" AndAlso Not chk_Status.Checked Then
            MsgBox("Seleccione un Status o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Call LlenarLista()
    End Sub

    Private Sub dtp_InicioPernocta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_CS.Focus()
    End Sub

    Private Sub lsv_Pernoctas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Pernoctas.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Limpiar()
        If lsv_Pernoctas.SelectedItems.Count > 0 Then
            cmb_CS.ActualizaValorParametro("@Id_Cliente", lsv_Pernoctas.SelectedItems(0).SubItems(10).Text)
            cmb_CS.Actualizar()

            dtp_Fecha.Value = lsv_Pernoctas.SelectedItems(0).Text
            cmb_CS.SelectedValue = lsv_Pernoctas.SelectedItems(0).SubItems(9).Text
            tbx_Observaciones.Text = lsv_Pernoctas.SelectedItems(0).SubItems(6).Text
            tbx_ObservacionesValida.Text = lsv_Pernoctas.SelectedItems(0).SubItems(8).Text
            tbx_Cliente.Text = lsv_Pernoctas.SelectedItems(0).SubItems(1).Text & "  " & lsv_Pernoctas.SelectedItems(0).SubItems(2).Text
        Else
            cmb_CS.ActualizaValorParametro("@Id_Cliente", -1)
            cmb_CS.Actualizar()
        End If
    End Sub

    Private Sub lsv_Pernoctas_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Pernoctas.ItemChecked
        SegundosDesconexion = 0

        btn_Validar.Enabled = lsv_Pernoctas.CheckedItems.Count > 0
        btn_Eliminar.Enabled = lsv_Pernoctas.CheckedItems.Count > 0
        dtp_Fecha.Enabled = lsv_Pernoctas.CheckedItems.Count = 1
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        'Validar Datos
        If Not ValidarClientes() Then
            MsgBox("Sólo se pueden Validar Pernoctas de un mismo Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If cmb_CS.SelectedValue = 0 Then
            MsgBox("Seleccione el Servicio para asignarle el Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CS.Focus()
            Exit Sub
        End If
        If Not lsv_Pernoctas.SelectedItems(0).Checked Then
            MsgBox("Debe seleccionar una de las Remisiones que haya marcado para Validar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Actualizar Pernocta 
        If fn_Pernoctas_Actualizar(cmb_CS.SelectedValue, tbx_ObservacionesValida.Text, lsv_Pernoctas) Then
            Call Limpiar()
            Call LlenarLista()
            MsgBox("Se Validaron correctamente las Pernoctas marcadas.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrió un error al intentar Actualizar las Pernoctas marcadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Function ValidarClientes() As Boolean
        Dim cliente As Integer = 0

        For Each item As ListViewItem In lsv_Pernoctas.CheckedItems
            If cliente = 0 Then
                cliente = item.SubItems(10).Text
            End If
            If Not cliente = item.SubItems(10).Text Then
                Return False
                Exit For
            End If
        Next
        Return True
    End Function

    Function ValidarStatus() As Boolean
        For Each item As ListViewItem In lsv_Pernoctas.CheckedItems
            If Not item.SubItems(7).Text = "ACTIVO" Then
                If MsgBox("Hay Pernoctas seleccionadas para Eliminar que ya han sido Validadas. ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                    Return True
                    Exit For
                Else
                    Return False
                    Exit For
                End If
            End If
        Next
        Return True
    End Function

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        'Validar que el Cliente de todas las pernoctas marcadas sea el mismo
        If Not ValidarClientes() Then
            MsgBox("Sólo se pueden Eliminar Pernoctas de un mismo Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If MsgBox("Ha marcado Pernoctas para su Eliminación. ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
            'Revisar si el Status de todas las Pernoctas es ACTIVO
            If Not ValidarStatus() Then
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        If fn_Pernoctas_Eliminar(lsv_Pernoctas) Then
            Call Limpiar()
            Call LlenarLista()
        Else
            MsgBox("Ocurrió un error al intentar Eliminar la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class