''' <summary>
''' Es un textbox que alimenta un campo VARCHAR(150)
''' </summary>
Public Class cp_tbx_varchar_150_LN
    Inherits cp_Texbox

    'Este textbox esta limitado a 50 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 150
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.Width = 350
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
