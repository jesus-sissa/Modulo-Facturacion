''' <summary>
''' Es un textbox que alimenta un campo VARCHAR(20)
''' </summary>
Public Class cp_tbx_varchar_20_LN
    Inherits cp_Texbox

    'Este textbox esta limitado a 4 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 20
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.Width = 110
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
