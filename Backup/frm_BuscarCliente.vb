Imports Modulo_Facturacion.FuncionesGlobales
Imports Modulo_Facturacion.Cn_Facturacion

Public Class Frm_BuscarCliente
    Public Cliente As Boolean = True
    Public Clave As String
    Public Consulta As Query = Query.Clientes
    Public Id As Integer = 0

    <Flags()> _
    Enum Query As Byte
        Clientes
        Empleados
        CajaBancaria
    End Enum

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case Consulta
            Case Query.Clientes
                lsv_Clientes.Row1 = 70
                lsv_Clientes.Row2 = 20

                If Not fn_BuscarClientes_LlenarLista(lsv_Clientes, Cliente) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los clientes", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes"
            Case Query.Empleados
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaEmpleados(lsv_Clientes) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los empleados", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados"
            Case Query.CajaBancaria
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaCajasBancarias(lsv_Clientes) Then
                    MsgBox("Ha ocurrido un error al intentar cargar las cajas bancarias", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Cajas Bancarias"
        End Select

        tbx_Buscar.Focus()
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        Select Case Consulta
            Case Query.Clientes
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Empleados
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CajaBancaria
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
        End Select

        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Select Case Consulta
            Case Query.Clientes
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Empleados
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.CajaBancaria
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If
        End Select
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 And lsv_Clientes.SelectedItems.Count > 0 Then Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        Dim Fila_Inicio As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Clientes.SelectedItems(0).Index + 1
        End If
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub

    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class