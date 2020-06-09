Imports System.ComponentModel

Public Class LogicaKardex
    Inherits DatosKardex
    Sub spRevisar(ByRef bw As BackgroundWorker)
        Dim i As Integer = 1
        For Each linea As vs_KardexRow In vs_Kardex
            spCalcularLinea(linea)
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
            spActualizarDatos(linea)
            bw.ReportProgress((i / vs_Kardex.Count) * 100)
            i += 1
        Next
    End Sub
    Private Sub spCalcularLinea(linea As dtsKardex.vs_KardexRow)
        If currentIdInventario <> linea.IdInventario Then
            spActualizar()
            currentIdInventario = linea.IdInventario
            currentIdBodega = linea.IdBodega
            Existencia = 0
            Saldo = 0
            CostoPromedio = 0
            ExistenciaBodega = 0
            SaldoBodega = 0
            CostoPromedioBodega = 0
        End If
        If currentIdBodega <> linea.IdBodega Then
            spActualizar()
            currentIdBodega = linea.IdBodega
            ExistenciaBodega = 0
            SaldoBodega = 0
            CostoPromedioBodega = 0
        End If
        Dim costoMovimiento As Double = 0
        If linea.Suma Then
            Existencia += linea.Cantidad
            costoMovimiento = linea.Cantidad * linea.Costo
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
            CostoPromedioBodega = SaldoBodega / ExistenciaBodega
        Else
            CostoPromedio = 0
            CostoPromedioBodega = 0
        End If
        linea.Saldo = Saldo
        linea.CostoPromedio = CostoPromedio
        linea.Existencia = Existencia
        linea.CostoPromedioBodega = CostoPromedioBodega
        linea.ExistenciaBodega = ExistenciaBodega
        linea.SaldoBodega = SaldoBodega

    End Sub
    Private Sub spActualizar()
        If currentIdInventario <> -1 And currentIdBodega <> -1 Then
            For Each linea As vs_InventarioRow In vs_Inventario
                If linea.Codigo = currentIdInventario Then
                    linea.ExistenciaCorregida = Existencia
                    linea.SaldoCorregido = Saldo
                    linea.CostoPromedioCorregido = CostoPromedio
                    linea.DifCostoPromedio = Math.Abs(linea.CostoPromedio - linea.CostoPromedioCorregido)
                    linea.DifExistencia = Math.Abs(linea.Existencia - linea.ExistenciaCorregida)
                End If
                If linea.Codigo = currentIdInventario And linea.IdBodega = currentIdBodega Then
                    linea.ExistenciaCorregida = Existencia
                    linea.SaldoCorregido = Saldo
                    linea.CostoPromedioCorregido = CostoPromedio
                    linea.DifCostoPromedio = Math.Abs(linea.CostoPromedio - linea.CostoPromedioCorregido)
                    linea.DifExistencia = Math.Abs(linea.Existencia - linea.ExistenciaCorregida)

                    linea.SaldoBodegaCorregido = SaldoBodega
                    linea.ExistenciaBodegaCorregida = ExistenciaBodega
                    linea.CostPromedioBodegaCorregida = CostoPromedioBodega
                    linea.DifCostoPromedioBodega = Math.Abs(linea.CostoPromedioBodega - linea.CostPromedioBodegaCorregida)
                    linea.DifExistenciaBodega = Math.Abs(linea.ExistenciaBodega - linea.ExistenciaBodegaCorregida)
                    Exit For
                End If
            Next
        End If

    End Sub
    Public Function SaldoBodegaTotal() As String
        Dim saldoBodega As Double = 0
        For Each linea As vs_InventarioRow In vs_Inventario
            saldoBodega += linea.SaldoBodegaCorregido
        Next
        Return Format(Math.Round(saldoBodega, 2), "#,##0.00")
    End Function
End Class
