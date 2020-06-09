Imports System.Data.SqlClient
Public Class clsDatos
    Inherits clsConexion
    Public Shared Sub sp_llenarTabla(ByVal SQLCommand As String, ByRef Tabla As DataTable, ByVal BD As String)

        Dim StringConexion As String = fn_StrConexionBase(BD)

        'Dim conexionX As New OleDb.OleDbConnection
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = New SqlCommand

        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = Comando

            Tabla.Clear()
            da.Fill(Tabla)


        Catch ex As System.Exception
            ' Tabla.Clear()
            If Tabla.Rows.Count = 0 Then
                MsgBox(ex.ToString)
            End If
            ' Si hay error, devolvemos un valor nulo.

        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub
    Public Shared Sub consulta(ByVal comando As SqlCommand, ByRef Tabla As DataTable, ByVal BD As String)

        Dim StringConexion As String = fn_StrConexionBase(BD)

        'Dim conexionX As New OleDb.OleDbConnection
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)

        Try
            ConexionX.Open()
            comando.Connection = ConexionX
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 120
            Dim da As New SqlDataAdapter
            da.SelectCommand = comando

            Tabla.Clear()
            da.Fill(Tabla)


        Catch ex As System.Exception
            ' Tabla.Clear()
            If Tabla.Rows.Count = 0 Then
                MsgBox(ex.ToString)
            End If
            ' Si hay error, devolvemos un valor nulo.

        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub
    Public Shared Sub cambio(ByVal comando As SqlCommand, ByVal BD As String)

        Dim StringConexion As String = fn_StrConexionBase(BD)

        'Dim conexionX As New OleDb.OleDbConnection
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)

        Try
            ConexionX.Open()
            comando.Connection = ConexionX
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 120
            comando.ExecuteNonQuery()


        Catch ex As System.Exception

            MsgBox(ex.ToString)


        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub

    Public Shared Sub Sp_EjecutarSQL(ByVal consulta As String, ByVal bd As String)
        Dim _comando As SqlCommand = Nothing
        Dim _conector As SqlConnection = New SqlConnection(fn_StrConexionBase("Contabilidad"))

        Dim _sql As String = consulta

        If _conector.State <> ConnectionState.Open Then _conector.Open()
        _comando = New SqlCommand(_sql, _conector)

        Try
            _comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Sp_CerrarConector(_conector)
            _comando.Dispose()
            _comando = Nothing
        End Try
    End Sub
End Class
