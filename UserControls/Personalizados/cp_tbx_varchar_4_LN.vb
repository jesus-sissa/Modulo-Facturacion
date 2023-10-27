''' <summary>
''' Es un textbox que alimenta un campo VARCHAR(4)
''' </summary>
Public Class cp_tbx_varchar_4_LN
    Inherits cp_Texbox

    'Este textbox esta limitado a 4 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 4
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.Width = 50
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
