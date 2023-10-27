Module Variables
    Public tieneAdminPaq As Char

    Public Cnx_Datos As String = ""
    Public ServDatos As String = ""
    Public BaseDatos As String = ""
    Public UsuarioDatos As String = ""
    Public ContraDatos As String = ""
    Public SucursalDatos As String = ""
    Public CadenaPermisosControles As String = ""

    Public UsuarioId As Long
    Public UsuarioN As String
    Public EmpresaId As Long
    Public SucursalId As Long
    Public SucursalN As String
    Public CiaId As Long
    Public ProcesoD As Long
    Public EstacioN As String
    Public EstacionIp As String
    Public EstacionMac As String
    Public ModuloId As Long
    Public MonedaId As Long
    Public ModuloClave As String
    Public ModuloVersion As String
    Public ModuloNombre As String
    Public ContraHash As String
    Public UsuarioTipo As Byte
    Public DepartamentoID As Integer
    Public CambiarConexion As Boolean
    Public Mail_ReporteFallas As String

    Public LoginId As Long
    Public MinutosDesconexion As Integer 'Parametro de Cat_Sucursales
    Public SegundosDesconexion As Integer 'Contador de segundos para el Bloqueo
    Public TipoBloqueo As Byte '0=No Bloqueado; 1=Bloqueado por el Usuario; 2=Bloqueado por inactividad
    Public Intentos_Login As Byte

    Public I As Long
    Public J As Long
    Public ResP As Integer
    Public BanderA As Boolean

End Module
