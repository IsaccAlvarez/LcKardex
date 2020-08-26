Public Class FrmVistaAjuste
    Public Sub New(_datos As LogicaKardex)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim logica = New LogicaAjusteInventario(_datos)
        enlaceDatos.DataSource = logica
        enlaceDatos.DataMember = logica.vs_Ajuste.TableName
        Dim diferencia As Double = logica.TotalEntradas() - logica.TotalSalidas()
        txtDiferencias.Text = FormatoNum(diferencia)
        txtEntradas.Text = FormatoNum(logica.TotalEntradas)
        txtSalidas.Text = FormatoNum(logica.TotalSalidas)

    End Sub
    Public Function FormatoNum(numero As Double) As String

        Return Format(numero, "#,###.00")
    End Function

    Private Sub FrmVistaAjuste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class