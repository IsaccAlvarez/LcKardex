Imports System.ComponentModel

Public Class Navegador
    Public Shared Sub Abrir(Optional ByRef pan As Panel = Nothing)
        If pan Is Nothing Then
            Dim frm As New frmNavegadorInventario
            frm.ShowDialog()
        Else
            Dim frm As New frmNavegadorInventario
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            pan.Controls.Clear()
            pan.Controls.Add(frm)
            frm.Show()
        End If
    End Sub
    Private Shared logica As New LogicaNavegador
    Public Shared Function Resultados(ByRef bw As BackgroundWorker) As LogicaNavegador
        logica.Cargar(bw)
        Return logica
    End Function
    Public Shared Sub AbrirReporte(ByVal logica As LogicaNavegador, filtro As String, filtroVisual As String)
        Dim fr As New frmReporte
        Dim rp As New ReporteIndividualKardex
        rp.SetDataSource(logica)
        rp.SetParameterValue("filtro", filtroVisual)
        filtro = filtro.Replace("IdInventario", "{vs_NavegadorInventarioKardex.IdInventario}")
        filtro = filtro.Replace("Codigo", "{vs_NavegadorInventario.Codigo}")
        filtro = filtro.Replace("Fecha", "{vs_NavegadorInventarioKardex.Fecha}")
        filtro = filtro.Replace("IdBodega", "{vs_NavegadorInventarioKardex.IdBodega}")
        filtro = filtro.Replace("Tipo", "{vs_NavegadorInventarioKardex.Tipo}")
        rp.RecordSelectionFormula = filtro

        fr.crv.ReportSource = rp
        fr.ShowDialog()

    End Sub

End Class
