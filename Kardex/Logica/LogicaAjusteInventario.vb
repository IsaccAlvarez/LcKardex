Imports System.Linq
Imports CrystalDecisions.CrystalReports.Engine

Public Class LogicaAjusteInventario : Inherits DatosAjusteInventario
    Public Sub New(datos As LogicaKardex)

        procesar(datos)
    End Sub
    Private Sub procesar(datos As LogicaKardex)
        For Each linea As dtsKardex.vs_InventarioRow In datos.vs_Inventario
            If linea.DifExistencia <> 0 Then
                IncluirLineaAjuste(linea)
            End If
        Next
    End Sub
    Public Function TotalEntradas() As Double
        Return Entradas
    End Function
    Public Function TotalSalidas() As Double
        Return Salidas
    End Function
    Private Entradas As Double = 0
    Private Salidas As Double = 0

    Private Sub IncluirLineaAjuste(linea As dtsKardex.vs_InventarioRow)
        Dim nueva As dtsKardex.vs_AjusteRow
        nueva = Me.vs_Ajuste.Newvs_AjusteRow
        nueva.Cantidad = Math.Abs(linea.DifExistencia)
        nueva.Codigo = linea.Codigo
        nueva.Costo = linea.CostoPromedioCorregido
        nueva.Descripcion = linea.Descripcion
        nueva.Entrada = linea.DifExistencia < 0
        nueva.Salida = linea.DifExistencia > 0
        nueva.TotalEntrada = IIf(nueva.Entrada, nueva.Costo * nueva.Cantidad, 0)
        Entradas += nueva.TotalEntrada
        nueva.TotalSalida = IIf(nueva.Salida, nueva.Costo * nueva.Cantidad, 0)
        Salidas += nueva.TotalSalida
        vs_Ajuste.Addvs_AjusteRow(nueva)

    End Sub

End Class
