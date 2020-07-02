Imports System.ComponentModel

Public Class frmReportesInventario

    Dim rp As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub bwProcesar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwProcesar.DoWork
        LogicaReportesInventario.Cargar(bwProcesar)
    End Sub
    Private Sub bwProcesar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwProcesar.ProgressChanged
        pb.Value = e.ProgressPercentage
    End Sub
    Private Sub bwProcesar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwProcesar.RunWorkerCompleted
        Enabled = True
        bsBodega.DataSource = LogicaReportesInventario.Datos()
        Me.pb.Visible = False
        Me.Filtros()
    End Sub

    Private Sub frmReportesInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.sc.Panel1Collapsed = False
        Me.Enabled = False
        Me.pb.Visible = True
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
        Ver()
    End Sub
    Sub Ver()
        If cbReportes.Text.Equals("INVENTARIO POR EXISTENCIA") Then
            rp = LogicaReportesInventario.ReporteExistencia(cbBodega.SelectedValue, cbComparacion.Text, txtCantidad.Text, cbReportes.Text & " " & cbComparacion.Text & " " & txtCantidad.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR DESCRIPCIÓN") Then
            rp = LogicaReportesInventario.ReporteDescripcion(cbBodega.SelectedValue, txtDescripcion.Text.ToUpper, cbReportes.Text & " CONTIENE " & txtDescripcion.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR FAMILIA") Then

            rp = LogicaReportesInventario.ReporteFamilia(cbBodega.SelectedValue, cbFamilia.SelectedValue, cbReportes.Text & " " & cbFamilia.Text)
        End If
        If cbReportes.Text.Equals("INVENTARIO POR PROVEEDOR") Then
            rp = LogicaReportesInventario.ReporteProveedor(cbBodega.SelectedValue, cbProveedor.SelectedValue, cbReportes.Text & " " & cbProveedor.Text)
        End If
        crv.ReportSource = rp
        crv.Show()
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

    Private Sub chFechaExistencia_CheckedChanged(sender As Object, e As EventArgs) Handles chFechaExistencia.CheckedChanged
        dtpFechaExistencia.Visible = chFechaExistencia.Checked
    End Sub
End Class