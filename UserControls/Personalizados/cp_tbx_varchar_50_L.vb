''' <summary>
''' Es un textbox que alimenta un campo VARCHAR(50)
''' </summary>
Public Class cp_tbx_varchar_50_L
    Inherits cp_Texbox

    'Este textbox esta limitado a 50 caracteres con el tipo de datos varchar en clave
    Public Sub New()
        Me.MaxLength = 50
        Me.TipoDatos = FuncionesGlobales.Validar_Cadena.Letras
        Me.Width = 350
        Me.Height = 20
        Me.Filtrado = True
    End Sub
End Class
