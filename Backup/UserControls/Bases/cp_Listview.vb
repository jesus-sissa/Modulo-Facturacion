''' <summary>
''' Es un listview con funcionalidades extendidas
''' </summary>
Public Class cp_Listview
    Inherits ListView

#Region "Eventos"
    ''' <summary>
    ''' Este evento se producira al ejecutarse la funcion Actualizar
    ''' </summary>
    Event AlActualizar()
#End Region

#Region "Variables Privadas"
    Private _1 As Integer = 10
    Private _2 As Integer = 10
    Private _3 As Integer = 10
    Private _4 As Integer = 10
    Private _5 As Integer = 10
    Private _6 As Integer = 10
    Private _7 As Integer = 10
    Private _8 As Integer = 10
    Private _9 As Integer = 10
    Private _10 As Integer = 10
    Private _Lvs As New ListViewColumnSorter
#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Obtiene o establece el ordenador del listview
    ''' </summary>
    Public Property Lvs() As ListViewColumnSorter
        Get
            Return _Lvs
        End Get
        Set(ByVal value As ListViewColumnSorter)
            _Lvs = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 1
    ''' </summary>
    Public Property Row1() As Integer
        Get
            Return _1
        End Get
        Set(ByVal value As Integer)
            _1 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 2
    ''' </summary>
    Public Property Row2() As Integer
        Get
            Return _2
        End Get
        Set(ByVal value As Integer)
            _2 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 3
    ''' </summary>
    Public Property Row3() As Integer
        Get
            Return _3
        End Get
        Set(ByVal value As Integer)
            _3 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 4
    ''' </summary>
    Public Property Row4() As Integer
        Get
            Return _4
        End Get
        Set(ByVal value As Integer)
            _4 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 5
    ''' </summary>
    Public Property Row5() As Integer
        Get
            Return _5
        End Get
        Set(ByVal value As Integer)
            _5 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 6
    ''' </summary>
    Public Property Row6() As Integer
        Get
            Return _6
        End Get
        Set(ByVal value As Integer)
            _6 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 7
    ''' </summary>
    Public Property Row7() As Integer
        Get
            Return _7
        End Get
        Set(ByVal value As Integer)
            _7 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 8
    ''' </summary>
    Public Property Row8() As Integer
        Get
            Return _8
        End Get
        Set(ByVal value As Integer)
            _8 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 9
    ''' </summary>
    Public Property Row9() As Integer
        Get
            Return _9
        End Get
        Set(ByVal value As Integer)
            _9 = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje del tamaño en la columna 10
    ''' </summary>
    Public Property Row10() As Integer
        Get
            Return _10
        End Get
        Set(ByVal value As Integer)
            _10 = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Sub New()

        'Aqui se fijan las variables que personalizan el control
        Me.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Me.MultiSelect = False
        Me.HideSelection = False
        Me.AllowColumnReorder = False
        Me.ListViewItemSorter = Lvs
        Me.View = Windows.Forms.View.Details
        Me.Width = 700
        Me.Height = 414
        Me.FullRowSelect = True

    End Sub

    ''' <summary>
    ''' Obtiene valores actualizados de la base de datos
    ''' </summary>
    ''' <param name="Cmd">Es el commando del que se obtendran los valores</param>
    ''' <param name="PK">
    ''' Es el nombre de la columna que contiene el primary key
    ''' La columna no se incluye pero su valor se guarda en la propiedad tag de la fila
    ''' </param>
    Public Sub Actualizar(ByVal Cmd As SqlClient.SqlCommand, ByVal PK As String)
        'Aqui se obtiene la conexion del command
        Dim Cnn As SqlClient.SqlConnection = Cmd.Connection

        'Aqui se Abre la conexion
        Cnn.Open()

        'Aqui se quita el flitrado para poder actualizar
        Me.ListViewItemSorter = Lvs
        Me.Sorting = SortOrder.None
        Lvs.Order = SortOrder.None
        Lvs.SortColumn = Nothing

        'Aqui se actualiza la lista
        FuncionesGlobales.fn_CargaListaCMDtag(Cmd, Me, 0, PK)

        'Aqui se cierra la conexio
        Cnn.Close()

        'Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)

        'Aqui se llama al procedimiento actualizar para acciones
        'posteriores en la capa de presentacion
        RaiseEvent AlActualizar()

    End Sub

#End Region

#Region "Eventos Manejados"
    Private Sub cp_Listview_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Me.ColumnClick
        If Me.Items.Count = 0 Then Exit Sub

        Me.ListViewItemSorter = Lvs

        'Aqui se reordenan las columnas del listview
        If e.Column = Lvs.SortColumn Then
            If Lvs.Order = Windows.Forms.SortOrder.Descending Then
                Lvs.Order = Windows.Forms.SortOrder.Ascending
            Else
                Lvs.Order = Windows.Forms.SortOrder.Descending
            End If
        Else
            Lvs.SortColumn = e.Column
            Lvs.Order = Windows.Forms.SortOrder.Ascending
        End If

        Me.Sort()

    End Sub

    Private Sub cp_Listview_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)
    End Sub

    Private Sub cp_Listview_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles Me.ColumnWidthChanging
        Dim x As Byte = Me.Columns.Count
        Dim Columnas(x) As Byte

        If Me.Columns(e.ColumnIndex).Width = 0 Then
            e.Cancel = True
            e.NewWidth = Me.Columns(e.ColumnIndex).Width
        ElseIf Me.Columns(e.ColumnIndex).Width <= 20 Then
            e.Cancel = True
            e.NewWidth = 100
        End If

    End Sub
#End Region

End Class
