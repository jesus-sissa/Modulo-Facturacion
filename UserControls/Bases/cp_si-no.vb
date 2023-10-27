''' <summary>
''' Es un groupbox con dos RadioButton Si y No
''' </summary>
''' <remarks></remarks>
Public Class cp_si_no
    Inherits GroupBox

#Region "Variables privadas"
    Public WithEvents Si As New RadioButton
    Public WithEvents No As New RadioButton
    Private _SigControl As Control
#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Es el control que obtendra el foco al presionar enter
    ''' </summary>
    Public Property ControlSiguiente() As Control
        Get
            Return _SigControl
        End Get
        Set(ByVal value As Control)
            _SigControl = value
        End Set
    End Property

    ''' <summary>
    ''' Es similar al SelectedValue de un combobox 
    ''' Devuelve S en caso de seleccionar Sí
    ''' Devuelve N en caso de seleccionar No
    ''' Devuelve 0 en case de no haber seleccion
    ''' </summary>
    Public Property SelectedValue() As Char
        Get
            If Si.Checked Then
                If Si.Tag = "" Then Si.Tag = "S"
                Return Si.Tag
            ElseIf No.Checked Then
                If No.Tag = "" Then No.Tag = "N"
                Return No.Tag
            Else
                Return "0"
            End If
        End Get
        Set(ByVal value As Char)
            Select Case value
                Case "S"
                    Si.Checked = True
                Case "N"
                    No.Checked = True
                Case Si.Tag
                    Si.Checked = True
                Case No.Tag
                    No.Checked = True
                Case Else
                    Si.Checked = False
                    No.Checked = False
            End Select
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub New()
        Me.Text = ""

        CrearSi()
        CrearNo()

    End Sub

    Private Sub CrearSi()
        Si.Text = "Sí"

        Si.Top = 5
        Si.Left = 5
        Si.Tag = "S"

        Si.Width = 40
        Si.Height = 20

        Me.Controls.Add(Si)
    End Sub

    Private Sub CrearNo()
        No.Text = "No"

        No.Top = 5
        No.Left = 50
        No.Tag = "N"

        No.Width = 40
        No.Height = 20

        Me.Controls.Add(No)
    End Sub

    Private Sub Si_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Si.KeyPress
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            _SigControl.Focus()

        ElseIf UCase(e.KeyChar) = "S" Then

            Si.Checked = True

        ElseIf UCase(e.KeyChar) = "N" Then

            No.Checked = True

        End If
    End Sub

    Private Sub No_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles No.KeyPress
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            _SigControl.Focus()

        ElseIf UCase(e.KeyChar) = "S" Then

            Si.Checked = True

        ElseIf UCase(e.KeyChar) = "N" Then

            No.Checked = True

        End If
    End Sub

    Private Sub cp_si_no_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        'al obtener el enfoque aqui se define a que control se le dara el enfoque
        If Si.Checked Then
            Si.Focus()
        ElseIf No.Checked Then
            No.Focus()
        Else
            Si.Focus()
        End If

    End Sub

    Private Sub cp_si_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            _SigControl.Focus()

        End If
    End Sub

#End Region

End Class
