Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class LogicaReportesInventario
    Inherits DatosNavegador

    Private Shared logica As New LogicaNavegador
    Public Shared Sub Cargar(bw As BackgroundWorker)
        logica.Cargar(bw)
    End Sub
    Public Shared Sub Cargar(bw As BackgroundWorker, Fecha As DateTime)
        logica.spRecalculoHistorico(bw, Fecha)
    End Sub
    Public Shared Function Datos() As LogicaNavegador

        Return logica
    End Function
    Public Shared Function ReporteExistencia(IdBodega As Integer, Comparacion As String, Cantidad As String, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        If (Not Comparacion.Equals("Any")) And (Not Cantidad.Equals("")) Then
            Dim CantidadDBL As Double
            Try
                CantidadDBL = Cantidad
            Catch ex As Exception
                CantidadDBL = 0
            End Try
            filtroBD = "InStr({vs_NavegadorInventario.Bodega}, '[" & IdBodega & "]') > 0 AND {vs_NavegadorInventario.Existencia} " & Comparacion & " " & CantidadDBL
        Else
            filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0"
        End If

        rp.SetDataSource(logica)

        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteFamilia(IdBodega As Integer, IdFamilia As Integer, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 AND {vs_NavegadorInventario.Familia} = '" & IdFamilia & "'"
        rp.SetDataSource(logica)
        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteFamiliaResumido(IdBodega As Integer, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim rp As New ReporteFamiliaResumido
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 "
        rp.SetDataSource(logica)
        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteDescripcion(IdBodega As Integer, Descripcion As String, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 AND InStr({vs_NavegadorInventario.Descripcion},'" & Descripcion & "') > 0"
        rp.SetDataSource(logica)
        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteExistenciaMaxima(IdBodega As Integer, Comparacion As String, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 AND {vs_NavegadorInventario.Existencia} " & Comparacion & " ExistenciaMaxima"
        rp.SetDataSource(logica)
        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteExistenciaMinima(IdBodega As Integer, Comparacion As String, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 AND {vs_NavegadorInventario.Existencia} " & Comparacion & " ExistenciaMinima"
        rp.SetDataSource(logica)
        encabezado = fnSucursal() + " " + encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function
    Public Shared Function ReporteProveedor(IdBodega As Integer, IdProveedor As Integer, encabezado As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rp As New ReporteInventarioExistencia
        Dim filtroBD As String = ""
        filtroBD = "InStr({vs_NavegadorInventario.Bodega},'[" & IdBodega & "]') > 0 AND InStr({vs_NavegadorInventario.Proveedor},'[" & IdProveedor & "]') > 0"
        rp.SetDataSource(logica)
        encabezado = fnSucursal() & " - " & encabezado
        rp.SetParameterValue("Encabezado", encabezado)
        rp.RecordSelectionFormula = filtroBD
        Return rp
    End Function

End Class
