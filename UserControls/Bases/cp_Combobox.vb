''' <summary>
''' Es un combobox con funcionalidad extendida
''' </summary>
''' <remarks></remarks>
Public Class cp_Combobox
    Inherits ComboBox

#Region "Variables Privadas"

    Private _Control_Siguiente As Control

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Es el control que obtendra el foco al presionar siguiente
    ''' </summary>
    Public Property Control_Siguiente() As Control
        Get
            Return _Control_Siguiente
        End Get
        Set(ByVal value As Control)
            _Control_Siguiente = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Sub New()
        Me.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Width = 228
        Me.Height = 21
    End Sub
#End Region

#Region "Eventos Manejados"

    Private Sub cp_tbx_Texbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            If Not Control_Siguiente Is Nothing Then
                _Control_Siguiente.Focus()
                e.Handled = True
            End If

        End If
    End Sub

#End Region

End Class
