Imports System.ComponentModel
Imports System.Drawing.Text

Public Class frmKardex
    Private logica As New LogicaKardex

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IniciarRevision()
    End Sub
    Private Sub IniciarRevision()
        Me.Enabled = False
        logica.spDatos()
        bsKardex.DataSource = logica
        bsKardex.DataMember = logica.vs_Kardex.TableName

        bsCorreciones.DataSource = logica
        bsCorreciones.DataMember = logica.vs_Inventario.TableName

        pbar.Visible = True
        bwRevisar.RunWorkerAsync()
    End Sub

    Private Sub bwRevisar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwRevisar.DoWork
        logica.spRevisar(bwRevisar)
    End Sub

    Private Sub bwRevisar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwRevisar.RunWorkerCompleted
        pbar.Visible = False
        Me.Enabled = True
        txtSaldoAcumulado.Text = logica.SaldoBodegaTotal()

        Detalle()
    End Sub

    Private Sub bwRevisar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwRevisar.ProgressChanged
        pbar.Value = e.ProgressPercentage

    End Sub
    Dim errores As Integer = 0
    Private Sub dgvCorreciones_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvCorreciones.DataError, dgvKardex.DataError
        errores += 1
    End Sub
    Private Sub bsCorreciones_CurrentChanged(sender As Object, e As EventArgs) Handles bsCorreciones.CurrentChanged
        Detalle()

    End Sub
    Private Sub Detalle()
        If Enabled = True Then
            If bsCorreciones.Count > 0 Then
                bsKardex.Filter = "IdInventario = " & bsCorreciones.Current("Codigo")
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbDiferencia.Text = Kardex.abrirDiferencia()
        bsCorreciones.Filter = lbDiferencia.Text
        Detalle()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IniciarCorrecion()
    End Sub
    Private Sub IniciarCorrecion()
        If MsgBox("Esta acción va a modificar el inventario y no se puede reversar. ¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Enabled = False
            pbar.Visible = True
            pbar.Value = 0
            bwCorregir.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwCorregir_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCorregir.DoWork
        logica.spCorregir(bwCorregir)
    End Sub

    Private Sub bwCorregir_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCorregir.ProgressChanged
        pbar.Value = e.ProgressPercentage
    End Sub

    Private Sub bwCorregir_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCorregir.RunWorkerCompleted
        Me.Enabled = True

        pbar.Visible = False
        If MsgBox("Datos cambiados. ¿Desea volver a consultar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            IniciarRevision()

        End If
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        bsCorreciones.Filter = txtFiltro.Text
    End Sub

    Private Sub btActualizarGanancia_Click(sender As Object, e As EventArgs) Handles btActualizarGanancia.Click
        Me.Enabled = False
        pbar.Visible = True

        bwCorregirGanancia.RunWorkerAsync()


    End Sub

    Private Sub bwCorregirGanancia_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCorregirGanancia.DoWork
        Kardex.actualizarGanancia(bwCorregirGanancia, "")
    End Sub

    Private Sub bwCorregirGanancia_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCorregirGanancia.ProgressChanged
        pbar.Value = e.ProgressPercentage

    End Sub

    Private Sub bwCorregirGanancia_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCorregirGanancia.RunWorkerCompleted
        Me.Enabled = True
        Me.pbar.Visible = False

    End Sub
End Class
