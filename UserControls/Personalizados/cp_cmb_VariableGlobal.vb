Imports System.Data.SqlClient
Imports Modulo_Facturacion.Cn_Datos
Imports Modulo_Facturacion.FuncionesGlobales

''' <summary>
''' Es un combobox que que envia a sqlserver un unico parametro
''' </summary>
Public Class cp_cmb_VariableGlobal
    Inherits cp_Combobox

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _NombreParametro As String

    Private _ValorParametro As Object

    Private _Tipodedatos As System.Data.SqlDbType

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Es un string que representa el storedprocedure del que se extraen los datos
    ''' </summary>
    Public Property StoredProcedure() As String
        Get
            Return _StoredProcedure
        End Get
        Set(ByVal value As String)
            _StoredProcedure = value
        End Set
    End Property

    ''' <summary>
    ''' Es el nombre del parametro que se va a enviar al stored procedure
    ''' </summary>
    Public Property NombreParametro() As String
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As String)
            _NombreParametro = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor del parametro que se va a enviar a sqlserver
    ''' </summary>
    Public Property ValorParametro() As Object
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As Object)
            _NombreParametro = value
        End Set
    End Property

    ''' <summary>
    ''' Representa el tipo de datos del parametro
    ''' </summary>
    Public Property Tipodedatos() As System.Data.SqlDbType
        Get
            Return _Tipodedatos
        End Get
        Set(ByVal value As System.Data.SqlDbType)
            _Tipodedatos = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtiene una lista actualizada de la base de datos y se alimenta de ella
    ''' </summary>
    Public Sub Actualizar()
        If StoredProcedure = "" Then MsgBox("Hay que asignar la propiedad stored procedure al elemento " & Me.Name, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        Tbl = CreaTabla()
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
    End Sub

#End Region

#Region "Funciones"

    Private Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(Cmd, _NombreParametro, _Tipodedatos, _ValorParametro)

        Return EjecutaConsulta(Cmd)
    End Function

#End Region

End Class
