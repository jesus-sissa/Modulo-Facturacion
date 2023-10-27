''' <summary>
''' Es un textbox con todas las funcionalidades de la aplicacion
''' pero sin ningun valor por defecto
''' </summary>
Public Class cp_Textbox
    Inherits TextBox

#Region "Eventos"
    ''' <summary>
    ''' Ocurre cuando se presiona la tecla enter
    ''' </summary>
    Public Event EnterPress()
#End Region

#Region "Variables Privadas"

    Private _ColorAnt As System.Drawing.Color
    Private _Control_Siguiente As Control
    Private _TipoDatos As FuncionesGlobales.Validar_Cadena
    Private _Filtrado As Boolean

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Es el control al que se va a mover el foco cuando se presione enter
    ''' </summary>
    Public Property Control_Siguiente() As Control
        Get
            Return _Control_Siguiente
        End Get
        Set(ByVal value As Control)
            _Control_Siguiente = value
        End Set
    End Property

    ''' <summary>
    ''' Es el tipo de datos que va a admitir el textbox
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TipoDatos() As FuncionesGlobales.Validar_Cadena
        Get
            Return _TipoDatos
        End Get
        Set(ByVal value As FuncionesGlobales.Validar_Cadena)
            _TipoDatos = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si el textbox va a estar filtrado por Tipo de Datos
    ''' </summary>
    Public Property Filtrado() As Boolean
        Get
            Return _Filtrado
        End Get
        Set(ByVal value As Boolean)
            _Filtrado = value
        End Set
    End Property

#End Region

#Region "Eventos Manejados"

    Private Sub cp_Texbox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.SelectionStart = 0
        Me.SelectionLength = Len(Me.Text)
    End Sub

    Private Sub cp_tbx_Texbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Not _ColorAnt = Nothing Then
            Me.ForeColor = _ColorAnt
        End If
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            RaiseEvent EnterPress()

            If Not _Control_Siguiente Is Nothing Then
                _Control_Siguiente.Focus()
                e.Handled = True
            Else
                Me.SelectionStart = 0
                Me.SelectionLength = Len(Me.Text)
                e.Handled = True
            End If

        Else
            If (Not Char.IsControl(e.KeyChar)) And Filtrado Then

                'Aqui se filtra la entrada segun el tipo de datos especificado
                If Not FuncionesGlobales.fn_Valida_Cadena(e.KeyChar, _TipoDatos) Then
                    e.KeyChar = Nothing
                    e.Handled = True
                End If

                'Aqui se fltra cuando se intenta poner doble punto a un numero decimal
                If _TipoDatos = FuncionesGlobales.Validar_Cadena.Numeros_Decimales And e.KeyChar = "." And Me.Text.Contains(".") Then
                    e.KeyChar = Nothing
                    e.Handled = True
                End If

                'Aqui se filtra cuando se intenta poner doble punto a un numero porcentual
                If _TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje And e.KeyChar = "." And Me.Text.Contains(".") Then
                    e.KeyChar = Nothing
                    e.Handled = True
                End If

                'Aqui se filtra cuando se intenta poner un numero porcentual mayor que 100
                Dim Dec As Decimal
                Try
                    If Me.SelectionLength = 0 Then
                        Dec = CDec(Me.Text & e.KeyChar.ToString)
                    Else
                        Dec = CDec(e.KeyChar.ToString)
                    End If

                Catch
                    Dec = 0
                End Try
                If Not e.KeyChar = Nothing Then
                    If _TipoDatos = FuncionesGlobales.Validar_Cadena.Porcentaje And Dec > 100 Then
                        e.KeyChar = Nothing
                        e.Handled = True
                    End If

                    'Aqui se filtra cuando se trabaja cin una ip
                    If _TipoDatos = FuncionesGlobales.Validar_Cadena.DireccionIP Then
                        Dim Valor As Array

                        If Me.SelectionLength = 0 Then
                            Valor = Split(Me.Text & e.KeyChar, ".")
                        Else
                            Valor = Split(e.KeyChar, ".")
                        End If

                        If Valor.Length > 4 Then e.KeyChar = Nothing
                        For Each element As String In Valor
                            Try
                                If Not element = "" Then
                                    element = CByte(element)
                                End If
                            Catch
                                e.KeyChar = Nothing
                            End Try
                        Next
                    End If
                End If
            End If

            'Aqui se convierte el caracter en mayusculas
            e.KeyChar = UCase(e.KeyChar)

            'Aqui se pinta en caso de error
            If e.KeyChar = Nothing Then
                _ColorAnt = Me.ForeColor
                Me.ForeColor = Color.Red
            End If

        End If
    End Sub

    Private Sub cp_Texbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Me.ForeColor = Color.Red Then
            Me.ForeColor = _ColorAnt
        End If
    End Sub

#End Region

End Class
