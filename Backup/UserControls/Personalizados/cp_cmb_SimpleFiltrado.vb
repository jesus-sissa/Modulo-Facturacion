Imports System.Data.SqlClient
Imports Modulo_Facturacion.Cn_Datos
Imports Modulo_Facturacion.FuncionesGlobales

Public Class cp_cmb_SimpleFiltrado
    Inherits cp_Combobox

#Region "Eventos"
    Public Event SeleccionManual(ByVal Id As Integer)

    Public Event SeleccionCombo(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _Sucursal As Boolean = False

    Private _Empresa As Boolean = False

    Private _Pista As Boolean = True

    Private WithEvents _Filtro As TextBox

    Private WithEvents _Combo As ComboBox

    Private _Clave As String

    Private _ClaveCombo As String

    Private _Actualizar As Boolean = True

    Private _Tipo As Integer = 0

    Private Cmd As SqlCommand

    Private _NombreParametro As String

    Private _ValorParametro As Object

    Private _Tipodedatos As System.Data.SqlDbType

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Indica si se envia o no el parametro  @Pista
    ''' </summary>
    Public Property Pista() As Boolean
        Get
            Return _Pista
        End Get
        Set(ByVal value As Boolean)
            _Pista = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se va a enviar la variable global Empresa al StoredProcedure
    ''' </summary>
    Public Property Empresa() As Boolean
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Boolean)
            _Empresa = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se va a enviar o no la variable global sucursal al stored procedure
    ''' </summary>
    Public Property Sucursal() As Boolean
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As Boolean)
            _Sucursal = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

    Public Property StoredProcedure() As String
        Get
            Return _StoredProcedure
        End Get
        Set(ByVal value As String)
            _StoredProcedure = value
        End Set
    End Property

    Public Property Filtro() As TextBox
        Get
            Return _Filtro
        End Get
        Set(ByVal value As TextBox)
            _Filtro = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

    Public Property NombreParametro() As String
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As String)
            _NombreParametro = value
        End Set
    End Property

    Public Property ValorParametro() As Object
        Get
            Return _ValorParametro
        End Get
        Set(ByVal value As Object)
            _ValorParametro = value
        End Set
    End Property

    Public Property Tipodedatos() As System.Data.SqlDbType
        Get
            Return _Tipodedatos
        End Get
        Set(ByVal value As System.Data.SqlDbType)
            _Tipodedatos = value
        End Set
    End Property

    ''' <summary>
    ''' Enlaza un segundo combo al control para Seleccionar por un campo diferente
    ''' </summary>
    ''' <value>Puede ser un ComboBox, cp_ComboBox o Cualquier clase heredada de estas</value>
    ''' <returns>ComboBox</returns>
    ''' <remarks>Por Favor no Interfiera con el funcionamiento del control</remarks>
    Public Property ComboExtra() As ComboBox
        Get
            Return _Combo
        End Get
        Set(ByVal value As ComboBox)
            _Combo = value
        End Set
    End Property

    ''' <summary>
    ''' El el campo de la consulta en donde se buscara el Display Member del combobox
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks>Por Favor no Interfiera con el funcionamiento del control</remarks>
    Public Property CampoComboExtra() As String
        Get
            Return _ClaveCombo
        End Get
        Set(ByVal value As String)
            _ClaveCombo = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Actualiza el contenido del combo utilizando el stored procedure
    ''' </summary>
    ''' <remarks>'si requiere la sucursal hay que marcar sucursal como true</remarks>
    Public Sub Actualizar()
        If StoredProcedure = "" Then MsgBox("Debe asignar la propiedad Stored Procedure al elemento. " & Me.Name, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        Tbl = CreaTabla()
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
        
        If _Combo IsNot Nothing AndAlso _ClaveCombo <> "" Then
            If Tbl.Rows.Count > 0 AndAlso Tbl(0).Item(DisplayMember) = "Seleccione..." Then
                Tbl.Columns(_ClaveCombo).ReadOnly = False
                Tbl(0).Item(_ClaveCombo) = "Seleccione..."
            End If

            _Combo.DisplayMember = _ClaveCombo
            _Combo.ValueMember = Me.ValueMember
            _Combo.DataSource = Tbl
        End If
    End Sub

    Public Sub Actualizar(ByVal Source As DataTable)
        Tbl = Source.Copy
        If Tbl.Rows.Count > 0 Then
            If Tbl(0).Item(DisplayMember) = "Seleccione..." Then Tbl.Rows(0).Delete()
            fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
            _Combo.DisplayMember = _ClaveCombo
            _Combo.ValueMember = Me.ValueMember

            If _Combo IsNot Nothing AndAlso _ClaveCombo <> "" Then
                If Tbl.Rows.Count > 0 AndAlso Tbl(0).Item(DisplayMember) = "Seleccione..." Then Tbl(0).Item(_ClaveCombo) = "Seleccione..."
                _Combo.DisplayMember = _ClaveCombo
                _Combo.ValueMember = Me.ValueMember
                _Combo.DataSource = Tbl
            End If
        End If
    End Sub

    Public Sub AgregarParametro(ByVal Nombre As String, ByVal tipo As System.Data.SqlDbType, ByVal valor As Object)
        If Cmd.Parameters(Nombre) Is Nothing Then
            Crea_Parametro(Cmd, Nombre, tipo, valor)
        Else
            Cmd.Parameters(Nombre).Value = valor
        End If
    End Sub
#End Region

#Region "Funciones"

    Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Cmd = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        If _Pista Then Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        If _Sucursal Then Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        If _Empresa Then Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)
        If _Tipo > 0 Then Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, _Tipo)
        If Not NombreParametro = "" Then Crea_Parametro(Cmd, _NombreParametro, _Tipodedatos, _ValorParametro)

        Return EjecutaConsulta(Cmd)
    End Function

#End Region

#Region "Eventos Manejados"

    ''' <summary>
    ''' busca el valor del textbox en la columna clave
    ''' </summary>
    Private Sub _Filtro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Filtro.TextChanged
        Dim f As cp_Textbox = TryCast(_Filtro, cp_Textbox)
        If f IsNot Nothing Then f.TipoDatos = Validar_Cadena.LetrasNumerosYCar

        If Not _Filtro.Text = "" Then
            If Not Tbl Is Nothing Then
                For Each element As DataRow In Tbl.Rows
                    If element(Clave) = _Filtro.Text Then
                        Me.SelectedIndex = Tbl.Rows.IndexOf(element)
                        If _Combo IsNot Nothing AndAlso _Combo.Items.Count > 0 Then _Combo.SelectedIndex = Tbl.Rows.IndexOf(element)
                        Exit Sub
                    End If
                Next
                If Not Tbl.Rows(Me.SelectedIndex).Item(Clave) = _Filtro.Text Then
                    Me.SelectedIndex = 0
                    If _Combo IsNot Nothing Then _Combo.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub cp_cmb_SimpleFiltrado_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If _Filtro IsNot Nothing Then _Filtro.Enabled = Me.Enabled
        If _Combo IsNot Nothing Then _Combo.Enabled = Me.Enabled
    End Sub

    ''' <summary>
    ''' escribe en el filtro el numero de clave que se ha seleccionado
    ''' </summary>
    Private Sub cp_cmb_SimpleFiltrado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
        If _Filtro IsNot Nothing AndAlso Not _Filtro.Focused Then
            If Me.SelectedIndex >= 0 Then
                _Filtro.Text = Tbl.Rows(Me.SelectedIndex)(Clave)
                If _Combo IsNot Nothing AndAlso _Combo.Items.Count > 0 Then _Combo.SelectedIndex = Me.SelectedIndex
                RaiseEvent SeleccionManual(Me.SelectedValue)
            End If

        End If
    End Sub

    Private Sub _Combo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Combo.SelectedValueChanged
        If _Combo.SelectedValue <> Me.SelectedValue Then Me.SelectedIndex = _Combo.SelectedIndex
    End Sub

#End Region
End Class
