Public Class DatosNavegador
    Inherits dtsKardex
    Sub spDatos()
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "Select * From vs_NavegadorInventario Order By Codigo DESC"
        clsDatos.consulta(sqlCo, vs_NavegadorInventario, "Proveeduria")

        sqlCo.CommandText = "Select * From vs_NavegadorInventarioKardex Order By IdInventario, Fecha"
        clsDatos.consulta(sqlCo, vs_NavegadorInventarioKardex, "Proveeduria")

        sqlCo.CommandText = "SELECT k.IdBodega, b.Nombre_Bodega AS Nombre FROM vs_Kardex AS k INNER JOIN  Bodegas AS b ON k.IdBodega = b.ID_Bodega GROUP BY k.IdBodega, b.Nombre_Bodega ORDER BY k.IdBodega"
        clsDatos.consulta(sqlCo, Bodega, "Proveeduria")

        sqlCo.CommandText = "SELECT k.IdBodega, b.Nombre_Bodega AS Bodega FROM vs_Kardex AS k INNER JOIN  Bodegas AS b ON k.IdBodega = b.ID_Bodega GROUP BY k.IdBodega, b.Nombre_Bodega ORDER BY k.IdBodega"
        clsDatos.consulta(sqlCo, Bodega, "Proveeduria")

        sqlCo.CommandText = "SELECT Tipo FROM vs_Kardex GROUP BY Tipo ORDER BY Tipo"
        clsDatos.consulta(sqlCo, TipoDocumento, "Proveeduria")

        sqlCo.CommandText = "SELECT f.Codigo AS Id, f.Descripcion As Familia FROM Inventario AS I INNER JOIN  vs_Kardex AS k ON I.Codigo = k.IdInventario INNER JOIN  SubFamilias AS SF INNER JOIN  Familia AS f ON SF.CodigoFamilia = f.Codigo ON I.SubFamilia = SF.Codigo GROUP BY f.Codigo, f.Descripcion ORDER BY f.Descripcion"
        clsDatos.consulta(sqlCo, Familia, "Proveeduria")
    End Sub
    Friend Sub spDatosKardexHistorico(ByVal Fecha As DateTime)
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "Select * From [vs_NavegadorInventarioReset] Order By Codigo DESC"
        clsDatos.consulta(sqlCo, vs_NavegadorInventario, "Proveeduria")


        sqlCo.CommandText = "Select * From vs_NavegadorInventarioKardex WHERE Fecha <= @Fecha Order By IdInventario, Fecha"
        sqlCo.Parameters.AddWithValue("@Fecha", Fecha)
        clsDatos.consulta(sqlCo, vs_NavegadorInventarioKardex, "Proveeduria")
    End Sub

End Class
