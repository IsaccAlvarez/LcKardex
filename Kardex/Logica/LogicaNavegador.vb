Imports System.ComponentModel

Public Class LogicaNavegador
    Inherits DatosNavegador
    Friend Sub Cargar(ByRef bw As BackgroundWorker)
        spDatos()
        spRevisar(bw)
    End Sub
    Private Sub spRevisar(ByRef bw As BackgroundWorker)
        Dim i As Integer = 1
        For Each linea As vs_NavegadorInventarioKardexRow In vs_NavegadorInventarioKardex
            spCalcularLinea(linea)
            bw.ReportProgress((i / vs_NavegadorInventarioKardex.Count) * 100)
            i += 1
        Next
    End Sub

    Public Sub spRecalculoHistorico(ByRef bw As BackgroundWorker, ByVal Fecha As DateTime)
        spDatosKardexHistorico(Fecha)
        update = True
        Dim i As Integer = 1
        For Each linea As vs_NavegadorInventarioKardexRow In vs_NavegadorInventarioKardex
            spCalcularLinea(linea)
            bw.ReportProgress((i / vs_NavegadorInventarioKardex.Count) * 100)
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
    Private Sub spCalcularLinea(linea As vs_NavegadorInventarioKardexRow)
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
    Private update As Boolean = False
    Private Sub spActualizar()
        If update Then
            If currentIdInventario <> -1 And currentIdBodega <> -1 Then

                Dim datos = From linea In vs_NavegadorInventario
                            Where linea.Codigo = currentIdInventario
                            Select linea
                For Each dato As vs_NavegadorInventarioRow In datos
                    dato.Existencia = Existencia
                    dato.Saldo = Saldo
                    dato.CostoPromedio = CostoPromedio
                Next

            End If

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
