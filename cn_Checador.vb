Imports Modulo_Facturacion.FuncionesGlobales
Imports Modulo_Facturacion.Cn_Datos
Imports System.Data.SqlClient

Public Class cn_Checador

#Region "Checador"

    Public Shared Function fn_Checador_LlenarLista(ByVal lsv As cp_Listview, ByVal FDesde As Date, ByVal FHasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_RelojesES_getByEmpleado", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, FDesde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, FHasta)
        Try
            lsv.Actualizar(cmd, "Id_ES")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

End Class
