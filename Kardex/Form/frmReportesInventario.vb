Imports System.ComponentModel

Public Class frmReportesInventario
    Dim resultados As LogicaNavegador
    Dim config As LogicaReportesInventario

    Dim rp As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub bwProcesar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwProcesar.DoWork
        config = ReportesInventario.Config()
    End Sub
    Private Sub bwProcesar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwProcesar.ProgressChanged
        pb.Value = e.ProgressPercentage
    End Sub
    Private Sub bwProcesar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwProcesar.RunWorkerCompleted
        Enabled = True
        resultados = LogicaReportesInventario.Datos()
        bsBodega.DataSource = config
        bsFamilia.DataSource = config
        Me.sc.SplitterDistance = 120
        Me.sc.Panel1Collapsed = False
        Me.pb.Visible = False
        Me.Filtros()
    End Sub

    Private Sub frmReportesInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.sc.Panel1Collapsed = True
        bwProcesar.RunWorkerAsync()
    End Sub

    Private Sub cbComparacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbComparacion.SelectedIndexChanged
        If cbComparacion.Text.Equals("Any") Then
            txtCantidad.Visible = False
        Else
            txtCantidad.Visible = True
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click, btVer.Click
        pb.Visible = True
        pb.Value = 0
        bwCargarReporte.RunWorkerAsync()
    End Sub
    Private Sub btFiltro_Click(sender As Object, e As EventArgs) Handles btFiltro.Click
        VerFiltro()
    End Sub
    Sub VerFiltro()
        If btFiltro.Tag.Equals("Select") Then
            btFiltro.Tag = ""
        Else
            btFiltro.Tag = "Select"
        End If
        sc.Panel1Collapsed = btFiltro.Tag.Equals("Select")
    End Sub

    Private Sub cbReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportes.SelectedIndexChanged
        Filtros()
    End Sub
    Private Sub Filtros()
        btFiltro.Tag = "Select"
        VerFiltro()
        lbExistencia.Visible = False
        txtCantidad.Visible = False
        lbFamilia.Visible = False
        cbFamilia.Visible = False
        cbComparacion.Visible = False
        lbDescripcion.Visible = False
        txtDescripcion.Visible = False
        lbProveedor.Visible = False
        cbProveedor.Visible = False
        lbUbicacion.Visible = False
        cbUbicacion.Visible = False
        If cbReportes.Text.Equals("INVENTARIO POR EXISTENCIA") Then
            lbExistencia.Visible = True
            cbComparacion.Visible = True
            txtCantidad.Visible = True
        End If
        If cbReportes.Text.Equals("INVENTARIO POR DESCRIPCIÓN") Then
            lbDescripcion.Visible = True
            txtDescripcion.Visible = True
        End If
        If cbReportes.Text.Equals("INVENTARIO POR FAMILIA") Then
            lbFamilia.Visible = True
            cbFamilia.Visible = True
        End If
        If cbReportes.Text.Equals("INVENTARIO POR EXISTENCIA MIN") Or cbReportes.Text.Equals("INVENTARIO POR EXISTENCIA MÁX") Then
            lbExistencia.Visible = True
            cbComparacion.Visible = True
        End If
        If cbReportes.Text.Equals("INVENTARIO POR UBICACION") Then
            lbFamilia.Visible = True
            cbFamilia.Visible = True
        End If
        If cbReportes.Text.Equals("INVENTARIO POR PROVEEDOR") Then
            lbFamilia.Visible = True
            cbFamilia.Visible = True
        End If
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()
    End Sub
    Private Sub btMinimizar_Click(sender As Object, e As EventArgs) Handles btMinimizar.Click
        WindowState = FormWindowState.Minimized
        Me.Text = "Reportes"
    End Sub

    Private Sub btMax_Click(sender As Object, e As EventArgs) Handles btMax.Click

        If btMax.Tag.Equals("ON") Then
            WindowState = FormWindowState.Normal
            btMax.Tag = "OFF"
        Else
            WindowState = FormWindowState.Maximized
            btMax.Tag = "ON"
        End If
    End Sub

    Private Sub bwCargarReporte_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCargarReporte.DoWork
        CargarDatos()
    End Sub
    Sub CargarDatos()
        LogicaReportesInventario.Cargar(bwCargarReporte, dtpFechaExistencia.Value)
    End Sub

    Private Sub bwCargarReporte_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCargarReporte.RunWorkerCompleted
        If cbReportes.Text.Equals("INVENTARIO POR EXISTENCIA") Then
            rp = LogicaReportesInventario.ReporteExistencia(cbBodega.SelectedValue, cbComparacion.Text, txtCantidad.Text, cbReportes.Text & " " & cbComparacion.Text & " " & txtCantidad.Text & " BODEGA " & cbBodega.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR DESCRIPCIÓN") Then
            rp = LogicaReportesInventario.ReporteDescripcion(cbBodega.SelectedValue, txtDescripcion.Text.ToUpper, cbReportes.Text & " CONTIENE " & txtDescripcion.Text & " BODEGA " & cbBodega.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR FAMILIA") Then
            rp = LogicaReportesInventario.ReporteFamilia(cbBodega.SelectedValue, cbFamilia.SelectedValue, cbReportes.Text & " " & cbFamilia.Text & " BODEGA " & cbBodega.Text)
        End If

        If cbReportes.Text.Equals("INVENTARIO POR FAMILIA RESUMIDO") Then
            rp = LogicaReportesInventario.ReporteFamiliaResumido(cbBodega.SelectedValue, cbReportes.Text & " " & cbBodega.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR PROVEEDOR") Then
            rp = LogicaReportesInventario.ReporteProveedor(cbBodega.SelectedValue, cbProveedor.SelectedValue, cbReportes.Text & " " & cbProveedor.Text)
        End If
        crv.ReportSource = rp
        crv.Show()
        pb.Visible = False

    End Sub

    Private Sub bwCargarReporte_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCargarReporte.ProgressChanged
        pb.Value = e.ProgressPercentage

    End Sub


End Class