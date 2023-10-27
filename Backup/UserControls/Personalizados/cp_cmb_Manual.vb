''' <summary>
''' Es un combobox que debe llenarse manualmente
''' Automaticamente agrega el elemento selecciona...
''' </summary>
Public Class cp_cmb_Manual
    Inherits cp_Combobox

    Dim Tbl As New DataTable

#Region "Metodos"

    Public Sub New()
        Me.DataSource = Tbl

        Tbl.Columns.Add("value")
        Tbl.Columns.Add("display")

        Me.ValueMember = "value"
        Me.DisplayMember = "display"

        AgregarItem("0", "Seleccione...")

    End Sub

    ''' <summary>
    ''' Agrega un elemento al Combobox
    ''' </summary>
    ''' <param name="Value">Es el valor del elemento</param>
    ''' <param name="Display">Es el texto del elemento</param>
    Public Sub AgregarItem(ByVal Value As String, ByVal Display As String)

        Dim Row As DataRow = Tbl.NewRow
        Row("value") = Value
        Row("display") = Display
        Tbl.Rows.Add(Row)

    End Sub

#End Region
End Class
