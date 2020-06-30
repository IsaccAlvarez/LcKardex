Imports System.ComponentModel

Public Class LogicaKardex
    Inherits DatosKardex
    Sub spRevisar(ByRef bw As BackgroundWorker)
        Dim i As Integer = 1
        For Each producto As vs_InventarioRow In vs_Inventario
            Existencia = 0
            Saldo = 0
            CostoPromedio = 0
            ExistenciaBodega = 0
            SaldoBodega = 0
            CostoPromedioBodega = 0
            Dim datos = From linea In vs_Kardex
                        Where linea.IdInventario = producto.Codigo
                        Select linea
            For Each kardex As vs_KardexRow In datos
                spCalcularLinea(kardex)
            Next
            producto.ExistenciaCorregida = Existencia
            producto.SaldoCorregido = Saldo
            producto.CostoPromedioCorregido = CostoPromedio
            producto.DifCostoPromedio = Math.Abs(producto.CostoPromedio - producto.CostoPromedioCorregido)
            producto.DifExistencia = Math.Abs(producto.Existencia - producto.ExistenciaCorregida)

            producto.SaldoBodegaCorregido = SaldoBodega
            producto.ExistenciaBodegaCorregida = ExistenciaBodega
            producto.CostPromedioBodegaCorregida = CostoPromedioBodega
            producto.DifCostoPromedioBodega = Math.Abs(producto.CostoPromedioBodega - producto.CostPromedioBodegaCorregida)
            producto.DifExistenciaBodega = Math.Abs(producto.ExistenciaBodega - producto.ExistenciaBodegaCorregida)
            bw.ReportProgress((i / vs_Kardex.Count) * 100)
            i += 1
        Next


    End Sub
    Private currentIdInventario As Integer = -1
    Private Existencia As Double = 0
    Private Saldo As Double = 0
    Private CostoPromedio As Double = 0


    Private currentIdBodega As Integer = -1
    Private ExistenciaBodega As Double = 0
    Private SaldoBodega As Double = 0
    Private CostoPromedioBodega As Double = 0
    Public Sub spCorregir(ByRef bw As BackgroundWorker)
        Dim i As Integer = 1
        For Each linea As vs_InventarioRow In vs_Inventario
            If linea.CostoPromedio <> linea.CostoPromedioCorregido Or linea.CostPromedioBodegaCorregida <> linea.CostoPromedioBodega Then
                spActualizarDatos(linea)
            End If
            bw.ReportProgress((i / vs_Inventario.Count) * 100)
            i += 1
        Next
    End Sub
    Private Sub spCalcularLinea(linea As dtsKardex.vs_KardexRow)
        Dim costoMovimiento As Double = 0
        If linea.Suma Then
            Existencia += linea.Cantidad
            If linea.Tipo.Equals("DEVOLUCION COMPRA") Then
                costoMovimiento = linea.Cantidad * CostoPromedio
            Else
                costoMovimiento = linea.Cantidad * linea.Costo
            End If
            Saldo += costoMovimiento
            ExistenciaBodega += linea.Cantidad
            SaldoBodega += costoMovimiento
        Else
            Existencia -= linea.Cantidad
            costoMovimiento = linea.Cantidad * CostoPromedio
            Saldo -= costoMovimiento
            ExistenciaBodega -= linea.Cantidad
            SaldoBodega -= costoMovimiento
        End If
        If Existencia <> 0 Then
            CostoPromedio = Saldo / Existencia
        Else
            CostoPromedio = 0
        End If
        If ExistenciaBodega <> 0 Then
            CostoPromedioBodega = SaldoBodega / ExistenciaBodega
        Else
            CostoPromedioBodega = 0
        End If
        linea.Saldo = Saldo
        linea.CostoPromedio = CostoPromedio
        linea.Existencia = Existencia
        linea.CostoPromedioBodega = CostoPromedioBodega
        linea.ExistenciaBodega = ExistenciaBodega
        linea.SaldoBodega = SaldoBodega

    End Sub

    Public Function SaldoBodegaTotal() As String
        Dim saldoBodega As Double = 0
        For Each linea As vs_InventarioRow In vs_Inventario
            saldoBodega += linea.SaldoBodegaCorregido
        Next
        Return Format(Math.Round(saldoBodega, 2), "#,##0.00")
    End Function
End Class
