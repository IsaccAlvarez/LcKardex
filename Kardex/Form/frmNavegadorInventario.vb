Imports System.ComponentModel
Public Class frmNavegadorInventario
    Dim resultados As LogicaNavegador
    Private Sub btFiltro_Click(sender As Object, e As EventArgs) Handles btFiltro.Click
        VerFiltro()
    End Sub
    Sub VerFiltro()
        If btFiltro.Tag.Equals("Select") Then
            btFiltro.Tag = ""
        Else
            btFiltro.Tag = "Select"
        End If
        scPanel.Panel1Collapsed = btFiltro.Tag.Equals("Select")
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Datos()
    End Sub
    Sub Datos()
        Enabled = False
        lbProgreso.Text = "Consultando Base de Datos..."
        bsInventarioKardex.DataSource = DtsKardex
        bsInventario.DataSource = DtsKardex
        bsBodega.DataSource = DtsKardex
        bsFamilia.DataSource = DtsKardex
        bsTipoDocumento.DataSource = DtsKardex
        bwDatos.RunWorkerAsync()
    End Sub

    Private Sub bwDatos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwDatos.DoWork
        IniciarHilo()
    End Sub

    Private estado As String = ""
    Sub IniciarHilo()
        If chFechaExistencia.Checked Then
            resultados.spRecalculoHistorico(bwDatos, dtpFechaExistencia.Value)
        Else
            estado = "Cargando Datos Actualizados"
            bwDatos.ReportProgress(1)
            resultados = Navegador.Resultados(bwDatos)
        End If

    End Sub
    Sub FinHilo()
        bsInventario.DataSource = resultados
        bsInventarioKardex.DataSource = resultados
        bsTipoDocumento.DataSource = resultados
        bsBodega.DataSource = resultados
        bsFamilia.DataSource = resultados
        Enabled = True
        lbProgreso.Text = ""
        spNavegarKardex()
    End Sub

    Private Sub bwDatos_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwDatos.ProgressChanged
        lbProgreso.Text = estado & " " & e.ProgressPercentage & " % "

    End Sub

    Private Sub bwDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDatos.RunWorkerCompleted
        FinHilo()
    End Sub

    Private Sub bsInventario_CurrentChanged(sender As Object, e As EventArgs) Handles bsInventario.CurrentChanged
        spNavegarKardex()
    End Sub
    Private Sub spNavegarKardex()
        If bsInventario.Count > 0 Then
            bsInventarioKardex.Filter = "IdInventario = " & bsInventario.Current("Codigo")
            If chBodega.Checked Then
                bsInventarioKardex.Filter &= " AND IdBodega = " & cbBodega.SelectedValue

            End If
            If chTipoDocumento.Checked Then
                bsInventarioKardex.Filter &= " AND Tipo = '" & cbTipoDocumento.Text & "'"

            End If
            If chFiltrarFechasDoc.Checked Then
                bsInventarioKardex.Filter &= " AND Fecha >= '" & Format(dtpFDesde.Value, "dd/MM/yyyy HH:mm") & "' AND Fecha <= '" & Format(dtpFHasta.Value, "dd/MM/yyyy HH:mm") & "'"
            End If
        End If

    End Sub
    Private Function fnFiltroReporte() As String
        Dim filtro As String = ""
        If bsInventario.Count > 0 Then
            filtro = "IdInventario = " & bsInventario.Current("Codigo")
            If chBodega.Checked Then
                filtro &= " AND IdBodega = " & cbBodega.SelectedValue

            End If
            If chTipoDocumento.Checked Then
                filtro &= " AND Tipo = '" & cbTipoDocumento.Text & "'"

            End If
            If chFiltrarFechasDoc.Checked Then
                filtro &= " AND Fecha >= CDATE('" & Format(dtpFDesde.Value, "dd/MM/yyyy HH:mm") & "') AND Fecha <= CDATE('" & Format(dtpFHasta.Value, "dd/MM/yyyy HH:mm") & "')"
            End If
        End If
        Return filtro
    End Function
    Private Function fnFiltroReporteVisual() As String
        Dim filtro As String = ""
        If bsInventario.Count > 0 Then

            If chBodega.Checked Then
                filtro &= " | Bodega = " & cbBodega.SelectedValue

            End If
            If chTipoDocumento.Checked Then
                filtro &= " | Tipo = '" & cbTipoDocumento.Text & "'"

            End If
            If chFiltrarFechasDoc.Checked Then
                filtro &= " | Fecha >= '" & Format(dtpFDesde.Value, "dd/MM/yyyy HH:mm") & " AND Fecha <= " & Format(dtpFHasta.Value, "dd/MM/yyyy HH:mm") & ""
            End If
        End If
        Return filtro
    End Function

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaExistencia.ValueChanged

    End Sub

    Private Sub chFechaExistencia_CheckedChanged(sender As Object, e As EventArgs) Handles chFechaExistencia.CheckedChanged
        dtpFechaExistencia.Visible = chFechaExistencia.Checked

    End Sub

    Private Sub chFamilia_CheckedChanged(sender As Object, e As EventArgs) Handles chFamilia.CheckedChanged
        cbFamilia.Visible = chFamilia.Checked
    End Sub

    Private Sub chTipoDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles chTipoDocumento.CheckedChanged
        cbTipoDocumento.Visible = chTipoDocumento.Checked
    End Sub

    Private Sub chBodega_CheckedChanged(sender As Object, e As EventArgs) Handles chBodega.CheckedChanged
        cbBodega.Visible = chBodega.Checked

    End Sub

    Private Sub frmNavegadorInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        scPanel.Panel1Collapsed = True
        rbCualquier.Checked = True
        dtpFDesde.Value = Now
        dtpFHasta.Value = Now
        dtpFechaExistencia.Value = Now
        Datos()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub
    Private Sub Buscar()
        Dim FiltroTexto As String = ""

        If Not txtBuscar.Text.Equals("") Then
            FiltroTexto &= filtroDescripcion(FiltroTexto)
            FiltroTexto &= filtroBarras(FiltroTexto)
            FiltroTexto &= filtroCodigo(FiltroTexto)
            If Not FiltroTexto.Equals("") Then
                FiltroTexto = "(" & FiltroTexto & ")"
            End If
        End If
        Dim filtro As String = FiltroTexto & filtroBodega(FiltroTexto)
        filtro &= filtroFamilia(filtro)
        bsInventario.Filter = filtro

    End Sub
    Private Function filtroFamilia(filtro As String)
        If Not chFamilia.Checked Then
            Return ""
        End If
        If filtro.Equals("") Then

            Return " Familia = " & cbFamilia.SelectedValue & ""

        Else

            Return " AND Familia  = " & cbFamilia.SelectedValue & ""
        End If
    End Function
    Private Function filtroBodega(filtro As String)
        If Not chBodega.Checked Then
            Return ""
        End If
        If filtro.Equals("") Then

            Return " Bodega LIKE '%[" & cbBodega.SelectedValue & "]%'"

        Else

            Return " AND Bodega LIKE '%[" & cbBodega.SelectedValue & "]%'"
        End If
    End Function
    Private Function filtroDescripcion(ByRef filtro As String)
        If Not chDescripcion.Checked Then
            Return ""
        End If
        If filtro.Equals("") Then
            If rbCualquier.Checked Then
                Return " Descripcion LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return "Descripcion LIKE '" & txtBuscar.Text & "%'"
            End If
        Else
            If rbCualquier.Checked Then
                Return " OR Descripcion LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return " OR Descripcion LIKE '" & txtBuscar.Text & "%'"
            End If
        End If

    End Function
    Private Function filtroBarras(ByRef filtro As String)
        If Not chBarras.Checked Then
            Return ""
        End If
        If filtro.Equals("") Then
            If rbCualquier.Checked Then
                Return " Barras LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return " Barras LIKE '" & txtBuscar.Text & "%'"
            End If
        Else
            If rbCualquier.Checked Then
                Return " OR Barras LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return " OR Barras LIKE '" & txtBuscar.Text & "%'"
            End If
        End If

    End Function
    Private Function filtroCodigo(ByRef filtro As String)
        If Not chCodigo.Checked Then
            Return ""
        End If
        If filtro.Equals("") Then
            If rbCualquier.Checked Then
                Return " Codigo LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return " Codigo LIKE '" & txtBuscar.Text & "%'"
            End If
        Else
            If rbCualquier.Checked Then
                Return " OR Codigo LIKE '%" & txtBuscar.Text & "%'"
            Else
                Return " OR Codigo LIKE '" & txtBuscar.Text & "%'"
            End If
        End If

    End Function
    Private Sub btAplicar_Click(sender As Object, e As EventArgs) Handles btAplicar.Click
        spAplicarFiltro()
    End Sub
    Private Sub spAplicarFiltro()
        If chFechaExistencia.Checked Then
            Datos()
        End If
        Buscar()
        spNavegarKardex()
    End Sub
#Region "Hilo sobre Costos"
    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        spActualizarCostos()
    End Sub
    Sub spActualizarCostos()
        If MsgBox("Esta acción no se puede revertir. ¿Esta seguro actualizar el costo promedio del inventario?") = MsgBoxResult.Yes Then
            Enabled = False
            lbProgreso.Text = "Consultando Base de Datos..."
            bwActualizar.RunWorkerAsync()
        End If

    End Sub
    Private Sub bwActualizar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwActualizar.DoWork
        Kardex.actualizarCostos(bwActualizar, estado)
    End Sub
    Private Sub bwActualizar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwActualizar.ProgressChanged
        lbProgreso.Text = estado & " " & e.ProgressPercentage & "%"
    End Sub
    Private Sub bwActualizar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwActualizar.RunWorkerCompleted
        Enabled = True
        lbProgreso.Text = ""
    End Sub

    Private Sub chFiltrarFechasDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chFiltrarFechasDoc.CheckedChanged
        dtpFDesde.Visible = chFiltrarFechasDoc.Checked
        dtpFHasta.Visible = chFiltrarFechasDoc.Checked

    End Sub




#End Region
    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Navegador.AbrirReporte(resultados, "Codigo = '" & bsInventario.Current("Codigo") & "' AND " & fnFiltroReporte(), fnFiltroReporteVisual)
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()

    End Sub
End Class