Imports System.Data.SqlClient
Imports Modulo_Facturacion.FuncionesGlobales
Imports Modulo_Facturacion.Cn_Facturacion

Public Class frm_GruposFacturacion

    Dim Tipo As Type

    Private Sub frm_GruposFacturacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_CajaBancaria.Actualizar()

        cmb_Concepto.AgregaParametro("@Tipo", 1, 1)
        cmb_Concepto.AgregaParametro("@Status", "A", 0)
        cmb_Concepto.Actualizar()

        fn_GruposFacturacion_LlenarListaClientesDG(-1, lsv_ClientesDG)
        fn_GruposFacturacion_LlenarListaConceptos(-1, lsv_Conceptos)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Primero debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If tbx_Grupo.Text.Trim = "" Then
            MsgBox("Indique la descripción para el Grupo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Grupos2.SelectedItems.Count = 0 Then
            If Not fn_GruposFacturacion_Crear(tbx_Grupo.Text.Trim, cmb_CajaBancaria.SelectedValue) Then MsgBox("No se pudo insertar el registro")

            fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos)
            fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos2)

            tbx_Grupo.Focus()
        Else
            If Not fn_GruposFacturacion_Actualizar(lsv_Grupos2.SelectedItems(0).Tag, tbx_Grupo.Text) Then MsgBox("No se pudo insertar el registro")

            fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos)
            fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos2)

            tbx_Grupo.Focus()
        End If

    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Grupos.Items.Clear()
        lsv_Grupos2.Items.Clear()
        lsv_ClientesSG.Items.Clear()
        lsv_ClientesDG.Items.Clear()
        lsv_Conceptos.Items.Clear()

        gbx_ClientesSG.Text = "Clientes sin Grupo: 0"
        gbx_ClientesDG.Text = "Clientes del Grupo: 0"

        If cmb_CajaBancaria.SelectedValue Is Nothing Then Exit Sub
        If cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub
        Call LlenarListas()
    End Sub

    Sub LlenarListas()
        fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos)
        fn_GruposFacturacion_LlenarListaGrupos(cmb_CajaBancaria.SelectedValue, lsv_Grupos2)
        fn_GruposFacturacion_LlenarListaClientesSG(cmb_CajaBancaria.SelectedValue, lsv_ClientesSG)

        gbx_ClientesSG.Text = "Clientes sin Grupo: " & lsv_ClientesSG.Items.Count.ToString

        btn_Cancelar.Enabled = cmb_CajaBancaria.SelectedValue <> "0"
        btn_Guardar.Enabled = cmb_CajaBancaria.SelectedValue <> "0"
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        tbx_Grupo.Clear()
        lsv_Grupos2.SelectedItems.Clear()

        Tab_Catalogo.SelectedTab = tab_Clientes
    End Sub

    Private Sub lsv_Grupos2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Grupos2.SelectedIndexChanged
        If lsv_Grupos2.SelectedItems.Count > 0 Then
            tbx_Grupo.Text = lsv_Grupos2.SelectedItems(0).Text
        Else
            tbx_Grupo.Clear()
        End If
    End Sub

    Private Sub lsv_Grupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Grupos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_ClientesDG.Items.Clear()
        lsv_Conceptos.Items.Clear()
        gbx_ClientesDG.Text = "Clientes del Grupo: 0"
        cmb_Concepto.SelectedValue = "0"
        Btn_AgregarConcepto.Enabled = False

        chk_Todos.Checked = False
        If lsv_Grupos.SelectedItems.Count = 0 Then Exit Sub

        fn_GruposFacturacion_LlenarListaClientesDG(lsv_Grupos.SelectedItems(0).Tag, lsv_ClientesDG)
        fn_GruposFacturacion_LlenarListaConceptos(lsv_Grupos.SelectedItems(0).Tag, lsv_Conceptos)
        cmb_Concepto.SelectedValue = "0"
        Btn_AgregarConcepto.Enabled = False
        gbx_ClientesDG.Text = "Clientes del Grupo: " & lsv_ClientesDG.Items.Count.ToString

    End Sub

    Private Sub lsv_ClientesSG_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_ClientesSG.ItemChecked
        Btn_Asignar.Enabled = lsv_ClientesSG.CheckedItems.Count > 0
    End Sub


    Private Sub lsv_ClientesDG_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_ClientesDG.ItemChecked
        btn_Desasignar.Enabled = lsv_ClientesDG.CheckedItems.Count > 0
    End Sub

    Private Sub Btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Asignar.Click
        SegundosDesconexion = 0

        If lsv_Grupos.SelectedItems.Count = 0 Then Exit Sub
        If lsv_ClientesSG.CheckedItems.Count = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        For Each element As ListViewItem In lsv_ClientesSG.CheckedItems
            fn_GruposFacturacion_AsignarGrupo(lsv_Grupos.SelectedItems(0).Tag, element.Tag)
        Next
        Btn_Asignar.Enabled = False
        chk_TodosSG.Checked = False
        fn_GruposFacturacion_LlenarListaClientesSG(cmb_CajaBancaria.SelectedValue, lsv_ClientesSG)
        gbx_ClientesSG.Text = "Clientes sin Grupo: " & lsv_ClientesSG.Items.Count.ToString
        fn_GruposFacturacion_LlenarListaClientesDG(lsv_Grupos.SelectedItems(0).Tag, lsv_ClientesDG)
        gbx_ClientesDG.Text = "Clientes del Grupo: " & lsv_ClientesDG.Items.Count.ToString

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Desasignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Desasignar.Click
        SegundosDesconexion = 0

        If lsv_Grupos.SelectedItems.Count = 0 Then Exit Sub
        If lsv_ClientesDG.CheckedItems.Count = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        For Each element As ListViewItem In lsv_ClientesDG.CheckedItems
            fn_GruposFacturacion_DesAsignarGrupo(lsv_Grupos.SelectedItems(0).Tag, element.Tag)
        Next
        btn_Desasignar.Enabled = False
        chk_Todos.Checked = False
        fn_GruposFacturacion_LlenarListaClientesSG(cmb_CajaBancaria.SelectedValue, lsv_ClientesSG)
        gbx_ClientesSG.Text = "Clientes sin Grupo: " & lsv_ClientesSG.Items.Count.ToString
        fn_GruposFacturacion_LlenarListaClientesDG(lsv_Grupos.SelectedItems(0).Tag, lsv_ClientesDG)
        gbx_ClientesDG.Text = "Clientes del Grupo: " & lsv_ClientesDG.Items.Count.ToString
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Btn_AgregarConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarConcepto.Click
        SegundosDesconexion = 0

        If lsv_Grupos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Grupo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            lsv_Grupos.Focus()
            Exit Sub
        End If
        If cmb_Concepto.SelectedValue = "0" Then
            MsgBox("Seleccione un Concepto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_Concepto.Focus()
            Exit Sub
        End If

        If Not fn_GruposFacturacion_AsignarConcepto(lsv_Grupos.SelectedItems(0).Tag, cmb_Concepto.SelectedValue) Then
            MsgBox("No se pudo asignar el concepto del grupo.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            fn_GruposFacturacion_LlenarListaConceptos(lsv_Grupos.SelectedItems(0).Tag, lsv_Conceptos)
            cmb_Concepto.SelectedValue = "0"
        End If
        cmb_Concepto.Focus()

    End Sub

    Private Sub cmb_Concepto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Concepto.SelectedValueChanged
        Btn_AgregarConcepto.Enabled = lsv_Grupos.SelectedItems.Count > 0 And Not cmb_Concepto.SelectedValue = "0"
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        If lsv_Conceptos.SelectedItems.Count > 0 And lsv_Grupos.SelectedItems.Count > 0 Then
            If Not fn_GruposFacturacion_DesAsignarConcepto(lsv_Grupos.SelectedItems(0).Tag, lsv_Conceptos.SelectedItems(0).Tag) Then
                MsgBox("No se pudo desasignar el concepto del grupo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                fn_GruposFacturacion_LlenarListaConceptos(lsv_Grupos.SelectedItems(0).Tag, lsv_Conceptos)
            End If
        End If
    End Sub

    Private Sub lsv_Conceptos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Conceptos.SelectedIndexChanged
        btn_Eliminar.Enabled = lsv_Conceptos.SelectedItems.Count > 0
    End Sub

    Private Sub chk_TodosSG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodosSG.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        If chk_TodosSG.Checked = True Then
            For Each element As ListViewItem In lsv_ClientesSG.Items
                element.Checked = True
            Next
        Else
            For Each element As ListViewItem In lsv_ClientesSG.Items
                element.Checked = False
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        If chk_Todos.Checked = True Then
            For Each element As ListViewItem In lsv_ClientesDG.Items
                element.Checked = True
            Next
        Else
            For Each element As ListViewItem In lsv_ClientesDG.Items
                element.Checked = False
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lsv_Grupos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Grupos.MouseHover, lsv_ClientesDG.MouseHover, lsv_ClientesSG.MouseHover, lsv_Conceptos.MouseHover, lsv_Grupos2.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class