Public Class Kardex
    Public Shared Sub abrir(Optional ByRef pan As Panel = Nothing)
        If pan Is Nothing Then
            Dim frm As New frmKardex
            frm.ShowDialog()
        Else
            Dim frm As New frmKardex
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            pan.Controls.Clear()
            pan.Controls.Add(frm)
            frm.Show()
        End If
    End Sub
    Public Shared Function abrirDiferencia() As String
        Dim filtro As String = ""
        Dim frm As New frmDiferencia()
        If frm.ShowDialog() = DialogResult.OK Then
            If frm.rbExistencia.Checked Then
                filtro = "DifExistencia >= " & frm.txtMonto.Text
            End If
            If frm.rbExistenciaBodega.Checked Then
                filtro = "DifExistenciaBodega >= " & frm.txtMonto.Text
            End If
            If frm.rbCostoPromedio.Checked Then
                filtro = "DifCostoPromedio >= " & frm.txtMonto.Text
            End If
            If frm.rbCostoPromedio.Checked Then
                filtro = "DifCostoPromedioBodega >= " & frm.txtMonto.Text
            End If

        End If
        Return filtro

    End Function

End Class
