Imports System.Data.SqlClient

Public Class clsConexion
    Public Shared Function Fn_Conector() As SqlConnection
        Dim _sqlconnection As New SqlConnection
        Try
            _sqlconnection.ConnectionString = clsDatos.fn_StrConexionBase("Proveeduria")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return _sqlconnection
    End Function

    Public Shared Sub Sp_CerrarConector(ByRef p_conector As SqlConnection)
        If p_conector.State <> ConnectionState.Closed Then
            p_conector.Close()
            p_conector.Dispose()
        End If
    End Sub

    Public Shared Function fn_StrConexionBase(ByVal BD As String) As String
        Return Configuracion.Claves.Conexion(BD)
    End Function
End Class