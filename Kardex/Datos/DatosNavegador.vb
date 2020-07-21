Public Class DatosNavegador
    Inherits dtsKardex
    Sub spDatos()
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "Select * From vs_NavegadorInventario WHERE Servicio = 0 Order By Codigo DESC"
        clsDatos.consulta(sqlCo, vs_NavegadorInventario, "SEEPOS")

        sqlCo.CommandText = "Select * From vs_NavegadorInventarioKardex Order By IdInventario, Fecha"
        clsDatos.consulta(sqlCo, vs_NavegadorInventarioKardex, "SEEPOS")
        spConfig()
    End Sub
    Sub spConfig()
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "SELECT k.IdBodega, b.Nombre_Bodega AS Bodega FROM vs_Kardex AS k INNER JOIN  Bodegas AS b ON k.IdBodega = b.ID_Bodega GROUP BY k.IdBodega, b.Nombre_Bodega ORDER BY k.IdBodega"
        clsDatos.consulta(sqlCo, Bodega, "SEEPOS")

        sqlCo.CommandText = "SELECT Tipo FROM vs_Kardex GROUP BY Tipo ORDER BY Tipo"
        clsDatos.consulta(sqlCo, TipoDocumento, "SEEPOS")

        sqlCo.CommandText = "SELECT f.Codigo AS Id, f.Descripcion As Familia FROM Inventario AS I INNER JOIN  vs_Kardex AS k ON I.Codigo = k.IdInventario INNER JOIN  SubFamilias AS SF INNER JOIN  Familia AS f ON SF.CodigoFamilia = f.Codigo ON I.SubFamilia = SF.Codigo GROUP BY f.Codigo, f.Descripcion ORDER BY f.Descripcion"
        clsDatos.consulta(sqlCo, Familia, "SEEPOS")
    End Sub
    Friend Shared Function fnSucursal()
        Dim dtSucursal As New DataTable()
        Dim dtEmpresa As New DataTable()
        Dim s As String = GetSetting("SeeSoft", "SeePos", "Sucursal", "1")
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "select Sucursal from Sucursal where CodSucursal=" + s + ""
        clsDatos.consulta(cmd, dtSucursal, "SEEPOS")
        Dim DatosEmpresa As String = ""
        If dtSucursal.Rows.Count > 0 Then
            DatosEmpresa = dtSucursal.Rows(0).Item("Sucursal")
        End If
        cmd.CommandText = "select Empresa, Cedula from configuraciones"
        clsDatos.consulta(cmd, dtEmpresa, "SEEPOS")
        If dtEmpresa.Rows.Count > 0 Then
            DatosEmpresa = DatosEmpresa & " " & dtEmpresa.Rows(0).Item("Empresa")
        End If
        Return DatosEmpresa
    End Function

    Friend Sub spDatosKardexHistorico(ByVal Fecha As DateTime)
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "Select * From [vs_NavegadorInventarioReset] Order By Codigo DESC"
        clsDatos.consulta(sqlCo, vs_NavegadorInventario, "SEEPOS")
        sqlCo.CommandText = "Select * From vs_NavegadorInventarioKardex WHERE Fecha <= @Fecha Order By IdInventario, Fecha"
        sqlCo.Parameters.AddWithValue("@Fecha", Fecha)
        clsDatos.consulta(sqlCo, vs_NavegadorInventarioKardex, "SEEPOS")
    End Sub


End Class
