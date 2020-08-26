Public Class AjusteInventario
    Public Shared Sub Abrir(ByVal datos As LogicaKardex)
        Dim frm As New FrmVistaAjuste(datos)
        frm.Show()
    End Sub
End Class
