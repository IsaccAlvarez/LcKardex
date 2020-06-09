<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiferencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btListo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.rbExistencia = New System.Windows.Forms.RadioButton()
        Me.rbCostoPromedio = New System.Windows.Forms.RadioButton()
        Me.rbCostoPromedioBodega = New System.Windows.Forms.RadioButton()
        Me.rbExistenciaBodega = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btListo
        '
        Me.btListo.Location = New System.Drawing.Point(170, 250)
        Me.btListo.Name = "btListo"
        Me.btListo.Size = New System.Drawing.Size(135, 74)
        Me.btListo.TabIndex = 0
        Me.btListo.Text = "Listo"
        Me.btListo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Diferencia:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(114, 39)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(110, 20)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Text = "0"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbExistencia
        '
        Me.rbExistencia.AutoSize = True
        Me.rbExistencia.Location = New System.Drawing.Point(32, 72)
        Me.rbExistencia.Name = "rbExistencia"
        Me.rbExistencia.Size = New System.Drawing.Size(73, 17)
        Me.rbExistencia.TabIndex = 3
        Me.rbExistencia.TabStop = True
        Me.rbExistencia.Text = "Existencia"
        Me.rbExistencia.UseVisualStyleBackColor = True
        '
        'rbCostoPromedio
        '
        Me.rbCostoPromedio.AutoSize = True
        Me.rbCostoPromedio.Location = New System.Drawing.Point(32, 95)
        Me.rbCostoPromedio.Name = "rbCostoPromedio"
        Me.rbCostoPromedio.Size = New System.Drawing.Size(96, 17)
        Me.rbCostoPromedio.TabIndex = 4
        Me.rbCostoPromedio.TabStop = True
        Me.rbCostoPromedio.Text = "CostoPromedio"
        Me.rbCostoPromedio.UseVisualStyleBackColor = True
        '
        'rbCostoPromedioBodega
        '
        Me.rbCostoPromedioBodega.AutoSize = True
        Me.rbCostoPromedioBodega.Location = New System.Drawing.Point(32, 141)
        Me.rbCostoPromedioBodega.Name = "rbCostoPromedioBodega"
        Me.rbCostoPromedioBodega.Size = New System.Drawing.Size(133, 17)
        Me.rbCostoPromedioBodega.TabIndex = 5
        Me.rbCostoPromedioBodega.TabStop = True
        Me.rbCostoPromedioBodega.Text = "CostoPromedioBodega"
        Me.rbCostoPromedioBodega.UseVisualStyleBackColor = True
        '
        'rbExistenciaBodega
        '
        Me.rbExistenciaBodega.AutoSize = True
        Me.rbExistenciaBodega.Location = New System.Drawing.Point(32, 118)
        Me.rbExistenciaBodega.Name = "rbExistenciaBodega"
        Me.rbExistenciaBodega.Size = New System.Drawing.Size(113, 17)
        Me.rbExistenciaBodega.TabIndex = 6
        Me.rbExistenciaBodega.TabStop = True
        Me.rbExistenciaBodega.Text = "Existencia Bodega"
        Me.rbExistenciaBodega.UseVisualStyleBackColor = True
        '
        'frmDiferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 336)
        Me.Controls.Add(Me.rbExistenciaBodega)
        Me.Controls.Add(Me.rbCostoPromedioBodega)
        Me.Controls.Add(Me.rbCostoPromedio)
        Me.Controls.Add(Me.rbExistencia)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btListo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiferencia"
        Me.Text = "Diferencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaldoActualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btListo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents rbExistencia As RadioButton
    Friend WithEvents rbCostoPromedio As RadioButton
    Friend WithEvents rbCostoPromedioBodega As RadioButton
    Friend WithEvents rbExistenciaBodega As RadioButton
End Class
