Public Class ReportesInventario
    Public Shared Sub Abrir(Optional ByRef pan As Panel = Nothing)
        If pan Is Nothing Then
            Dim frm As New frmReportesInventario
            frm.ShowDialog()
        Else
            Dim frm As New frmReportesInventario
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            pan.Controls.Clear()
            pan.Controls.Add(frm)
            frm.Show()
        End If
    End Sub
End Class
