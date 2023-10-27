''' <summary>
''' Es un textbox que debe llenarse manualmente
''' Automaticamente agrega el campo selecciona...
''' </summary>
Public Class cp_cmb_TipoBaja
    Inherits cp_Combobox

    Dim Tbl As New DataTable
    Dim _Editado As Integer = False

#Region "Metodos"

    Public Sub New()
        Me.DataSource = Tbl

        Tbl.Columns.Add("value")
        Tbl.Columns.Add("display")

        Me.ValueMember = "value"
        Me.DisplayMember = "display"

        AgregarItem("0", "Seleccione...")
        AgregarItem("1", "Clientes")
        AgregarItem("2", "Empleados")
        AgregarItem("3", "ATMs")
        AgregarItem("4", "Proveedores")

    End Sub

    ''' <summary>
    ''' Agrega un elemento al textbox
    ''' </summary>
    ''' <param name="Value">Es el campo value member del item</param>
    ''' <param name="Display">Es el campo display member del item</param>
    Public Sub AgregarItem(ByVal Value As String, ByVal Display As String)

        Dim Row As DataRow = Tbl.NewRow
        Row("value") = Value
        Row("display") = Display
        Tbl.Rows.Add(Row)

    End Sub

#End Region
End Class
