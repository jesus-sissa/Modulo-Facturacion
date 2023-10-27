Public Class Frm_DescargarRemisionxFechas
    Dim _path As String
    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim Folder As New FolderBrowserDialog()
        If Folder.ShowDialog = DialogResult.OK Then
            _path = Folder.SelectedPath
            txb_path.Text = Folder.SelectedPath
        End If
    End Sub

    Private Sub Frm_DescargarRemisionxFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Cmb_grupo.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Moneda.Actualizar()

        cmb_CajaBancaria.Actualizar()

        'Cmb_Clientes.AgregaParametro("@Status", "A", 0)
        'Cmb_Clientes.Actualizar()

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

    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click

    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call LimpiarListas()
        Cmb_grupo.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        Cmb_grupo.Actualizar()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
    End Sub

    Private Sub LlenarClientes()
        If Cmb_Compañia.SelectedValue = 1 Then
            If Chk_Clientes.Checked = False Then
                'Cmb_Clientes.Enabled = True
            End If
            Cmb_ClientesP.Enabled = False
            Cmb_ClientesP.Visible = False
            Cmb_ClientesP.SelectedIndex = 0
            'Cmb_Clientes.Visible = True
            ' Cmb_Clientes.Actualizar()
        Else
            If Chk_Clientes.Checked = False Then
                Cmb_ClientesP.Enabled = True
            End If
            'Cmb_Clientes.Enabled = False
            ' Cmb_Clientes.SelectedIndex = 0
            Cmb_ClientesP.Visible = True
            ' Cmb_Clientes.Visible = False
            Cmb_ClientesP.ActualizaValorParametro("@Activos", "A")
            Cmb_ClientesP.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
            Cmb_ClientesP.ActualizaValorParametro("@Id_Cia", Cmb_Compañia.SelectedValue)
            Cmb_ClientesP.Actualizar()
        End If
    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Dotaciones.Items.Clear()

    End Sub

    Private Sub Cmb_Compañia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Compañia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
        '  Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
    End Sub

    Private Sub Cmb_ClientesP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_ClientesP.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Desde.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Hasta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Hasta.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Cmb_grupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_grupo.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Chk_Clientes_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        'Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
        ' Cmb_Clientes.Enabled = Not Chk_Clientes.Checked
        Cmb_ClientesP.Enabled = Not Chk_Clientes.Checked
    End Sub

    Private Sub chk_Grupo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Grupo.CheckedChanged
        SegundosDesconexion = 0
        Cmb_grupo.SelectedValue = 0
        Cmb_grupo.Enabled = Not chk_Grupo.Checked
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Proceso_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Proceso.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Morralla_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Morralla.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Todo_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Todo.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub
End Class