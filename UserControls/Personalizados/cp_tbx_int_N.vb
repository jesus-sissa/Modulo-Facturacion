''' <summary>
''' Es un textbox que alimenta un campo INT
''' </summary>
Public Class cp_tbx_int_N
    Inherits cp_Texbox

    'Este textbox esta limitado a 50 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 10
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.Width = 110
        Me.Height = 20
        Me.Filtrado = False
    End Sub
End Class
