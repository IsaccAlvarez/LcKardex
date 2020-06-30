'Esta clase comprende todo lo que es consultas a la base de datos.
Imports System.Data.SqlClient

Public Class DatosKardex
    Inherits dtsKardex
    Protected Friend Sub spDatos()
        spComprobarBD()
        Dim consulta As String = "SELECT k.Fecha, i.Descripcion AS Inventario, k.IdInventario, k.Tipo, k.IdLinea, k.IdDocumento, k.Documento, k.IdMoneda, k.IdBodega, k.Cantidad, k.Costo, k.TipoCambio,k.Suma, 0 AS CostoPromedio, 0 As Existencia, 0 As Saldo FROM vs_Kardex AS k INNER JOIN  Inventario AS i ON k.IdInventario = i.Codigo WHERE i.Servicio = 0 AND i.Inhabilitado = 0 ORDER BY k.IdInventario, k.Fecha"
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = consulta
        clsDatos.consulta(sqlCo, vs_Kardex, "Proveeduria")

        sqlCo.CommandText = "Select * From vs_Inventario"
        clsDatos.consulta(sqlCo, vs_Inventario, "Proveeduria")



    End Sub
    Friend Sub spActualizarDatos(linea As vs_InventarioRow)

        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = "UPDATE [dbo].[ArticulosXBodega]  SET [Costo_Promedio] = @Costo,[Saldo_Final] = @SaldoFinal WHERE [Codigo] = @Codigo AND [IdBodega] =@IdBodega"
        sqlCo.Parameters.AddWithValue("@Costo", linea.CostPromedioBodegaCorregida)
        sqlCo.Parameters.AddWithValue("@SaldoFinal", linea.SaldoBodegaCorregido)
        sqlCo.Parameters.AddWithValue("@Codigo", linea.Codigo)
        sqlCo.Parameters.AddWithValue("@IdBodega", linea.IdBodega)
        clsDatos.cambio(sqlCo, "Proveeduria")
        sqlCo.CommandText = "UPDATE Inventario SET CostoPromedio = @CostoPromedioGeneral Where Codigo = @Codigo"
        sqlCo.Parameters.AddWithValue("@CostoPromedioGeneral", linea.CostoPromedioCorregido)
        clsDatos.cambio(sqlCo, "Proveeduria")



    End Sub
    Private Sub spComprobarBD()

        Dim preguntarExiste As String = "SELECT * FROM sysobjects WHERE name='vs_Inventario'"
        Dim dt As New DataTable
        Dim sqlCo As New SqlClient.SqlCommand
        sqlCo.CommandText = preguntarExiste
        clsDatos.consulta(sqlCo, dt, "Proveeduria")
        If dt.Rows.Count = 0 Then
            Dim consulta As String = "CREATE VIEW [dbo].[vs_Inventario] AS SELECT TOP 100 percent i.Codigo, i.Descripcion, i.Existencia, i.CostoPromedio, i.Existencia * i.CostoPromedio AS Saldo, ibod.IdBodega, ibod.Existencia AS ExistenciaBodega, ibod.Costo_Promedio AS CostoPromedioBodega,  ibod.Saldo_Final AS SaldoFinalBodega FROM Inventario AS i LEFT OUTER JOIN  ArticulosXBodega AS ibod ON i.Codigo = ibod.Codigo WHERE (i.Servicio = 0) AND (i.Inhabilitado = 0) ORDER BY i.Codigo, ibod.IdBodega"
            sqlCo.CommandText = consulta
            clsDatos.cambio(sqlCo, "Proveeduria")
            consulta = "CREATE VIEW [dbo].[vs_Kardex] AS  SELECT Fecha, Codigo AS IdInventario, Tipo, Codigo AS IdLinea, Documento AS IdDocumento, '0' AS Documento, 1 AS IdMoneda, IdBodegaDestino AS IdBodega, Cantidad, Costo_Unit AS Costo,  0 AS TipoCambio, 1 AS Suma FROM Kardex WHERE (Tipo = 'ICI') UNION SELECT c.Fecha, ac.Codigo AS IdInventario,  'COMPRA' AS Tipo, ac.Id_ArticuloComprados AS IdLinea, c.Id_Compra AS IdDocumento, c.Factura AS Documento, c.Cod_MonedaCompra AS IdMoneda,  ac.bodega_id AS IdBodega,  ac.Cantidad, ac.Costo,  c.TipoCambio, 1 As Suma FROM articulos_comprados AS ac INNER JOIN  compras AS c ON ac.IdCompra = c.Id_Compra UNION  SELECT a.Fecha, ad.Cod_Articulo AS IdInventario, 'AJUSTE ENTRADA' AS Tipo, ad.Consecutivo AS IdLinea, a.Consecutivo AS IdDocumento, CAST(ad.Consecutivo AS VARCHAR(255)) AS Documento, ad.Cod_Moneda AS IdMoneda,  ad.IdBodega, ad.Cantidad, ad.CostoUnit AS Costo, ad.Tipo_Cambio AS TipoCambio, 1 As Suma FROM AjusteInventario_Detalle AS ad INNER JOIN  AjusteInventario AS a ON ad.Cons_Ajuste = a.Consecutivo WHERE (a.Anula = 0) AND ad.Entrada = 1  UNION  SELECT a.Fecha, ad.Cod_Articulo AS IdInventario, 'AJUSTE SALIDA' AS Tipo, ad.Consecutivo AS IdLinea, a.Consecutivo AS IdDocumento, CAST(ad.Consecutivo AS VARCHAR(255)) AS Documento, ad.Cod_Moneda AS IdMoneda,  ad.IdBodega, ad.Cantidad, ad.CostoUnit AS Costo, ad.Tipo_Cambio AS TipoCambio, 0 As Suma FROM AjusteInventario_Detalle AS ad INNER JOIN  AjusteInventario AS a ON ad.Cons_Ajuste = a.Consecutivo WHERE (a.Anula = 0) AND ad.Salida = 1  UNION  SELECT dc.Fecha, dcd.Codigo AS IdInventario, 'DEVOLUCION COMPRA' AS Tipo, dcd.Consecutivo AS IdLinea, dc.Devolucion AS IdDocumento, CAST(dc.Devolucion AS VARCHAR(255)) AS Documento, dc.Cod_Moneda AS IdMoneda,  su.IdBodegaDescarga AS IdBodega, dcd.Cantidad, dcd.Precio_Costo AS Costo, 1 AS TipoCambio, 0 As Suma FROM dbo.devoluciones_Compras AS dc INNER JOIN  dbo.articulos_Compras_devueltos AS dcd ON dc.Devolucion = dcd.Devolucion INNER JOIN  dbo.Sucursal AS su ON dc.Sucursal = su.CodSucursal WHERE (dc.Anulado = 0) UNION SELECT t.Fecha, td.Codigo AS IdInventario, 'TRASLADO ENTRADA' AS Tipo, td.Id AS IdLinea, t.Id_Traslados AS IdDocumento, CAST( t.Id_Traslados AS VARCHAR(255)) AS Documento, td.CodigoMoneda AS IdMoneda,  t.BodegaDestino AS IdBodega, td.cantidad AS Cantidad, td.PrecioBase AS Costo, td.TipoCambio, 1 As Suma FROM TrasladosDetalle AS td INNER JOIN  Traslados AS t ON td.Id_Traslados = t.Id_Traslados where t.Anulado = 0 UNION SELECT t.Fecha, td.Codigo AS IdInventario, 'TRASLADO SALIDA' AS Tipo, td.Id AS IdLinea, t.Id_Traslados AS IdDocumento, CAST( t.Id_Traslados AS VARCHAR(255)) AS Documento, td.CodigoMoneda AS IdMoneda,  t.BodegaOrigen AS IdBodega, td.cantidad AS Cantidad, td.PrecioBase AS Costo, td.TipoCambio, 0 As Suma FROM TrasladosDetalle AS td INNER JOIN  Traslados AS t ON td.Id_Traslados = t.Id_Traslados Where t.Anulado = 0   UNION  SELECT dv.Fecha, dvd.Codigo AS IdInventario, 'DEVOLUCION VENTA' AS Tipo, dvd.Consecutivo AS IdLinea, dv.Devolucion AS IdDocumento, CAST(dv.Devolucion AS VARCHAR(255)) AS Documento, dv.Cod_Moneda AS IdMoneda,  s.IdBodegaDescarga AS IdBodega, dvd.Cantidad, dvd.Precio_Costo AS Costo, v.Tipo_Cambio AS TipoCambio, 1 As Suma FROM devoluciones_ventas AS dv INNER JOIN  articulos_ventas_devueltos AS dvd ON dv.Devolucion = dvd.Devolucion INNER JOIN  Ventas AS v ON dv.Id_Factura = v.Id INNER JOIN  Sucursal AS s ON v.Sucursal = s.CodSucursal Where dv.Anulado = 0  UNION SELECT v.Fecha, vd.Codigo AS IdInventario, 'VENTA' AS Tipo, vd.id_venta_detalle AS IdLinea, v.Id AS IdDocumento, CAST(v.Num_Factura AS VARCHAR(255)) AS Documento, v.Cod_Moneda AS IdMoneda, vd.Id_bodega AS IdBodega,  vd.Cantidad, vd.Precio_Costo AS Costo, v.Tipo_Cambio AS TipoCambio, 0 As Suma FROM Ventas_Detalle AS vd INNER JOIN  Ventas AS v ON vd.Id_Factura = v.Id WHERe v.Anulado = 0 "
            sqlCo.CommandText = consulta
            clsDatos.cambio(sqlCo, "Proveeduria")

        End If

    End Sub

End Class
