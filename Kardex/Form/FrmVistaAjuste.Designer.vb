<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaAjuste
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
        Me.components = New System.ComponentModel.Container()
        Me.enlaceDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.datos = New LcPymesKardex.dtsKardex()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalidaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.txtSalidas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiferencias = New System.Windows.Forms.TextBox()
        CType(Me.enlaceDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enlaceDatos
        '
        Me.enlaceDatos.DataMember = "vs_Ajuste"
        Me.enlaceDatos.DataSource = Me.datos
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.EntradaDataGridViewCheckBoxColumn, Me.SalidaDataGridViewCheckBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.TotalEntradaDataGridViewTextBoxColumn, Me.TotalSalidaDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.enlaceDatos
        Me.dgv.Location = New System.Drawing.Point(27, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(979, 306)
        Me.dgv.TabIndex = 0
        '
        'datos
        '
        Me.datos.DataSetName = "dtsKardex"
        Me.datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btGuardar
        '
        Me.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btGuardar.Location = New System.Drawing.Point(422, 353)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(137, 51)
        Me.btGuardar.TabIndex = 1
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntradaDataGridViewCheckBoxColumn
        '
        Me.EntradaDataGridViewCheckBoxColumn.DataPropertyName = "Entrada"
        Me.EntradaDataGridViewCheckBoxColumn.HeaderText = "Entrada"
        Me.EntradaDataGridViewCheckBoxColumn.Name = "EntradaDataGridViewCheckBoxColumn"
        Me.EntradaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SalidaDataGridViewCheckBoxColumn
        '
        Me.SalidaDataGridViewCheckBoxColumn.DataPropertyName = "Salida"
        Me.SalidaDataGridViewCheckBoxColumn.HeaderText = "Salida"
        Me.SalidaDataGridViewCheckBoxColumn.Name = "SalidaDataGridViewCheckBoxColumn"
        Me.SalidaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalEntradaDataGridViewTextBoxColumn
        '
        Me.TotalEntradaDataGridViewTextBoxColumn.DataPropertyName = "TotalEntrada"
        Me.TotalEntradaDataGridViewTextBoxColumn.HeaderText = "TotalEntrada"
        Me.TotalEntradaDataGridViewTextBoxColumn.Name = "TotalEntradaDataGridViewTextBoxColumn"
        Me.TotalEntradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalSalidaDataGridViewTextBoxColumn
        '
        Me.TotalSalidaDataGridViewTextBoxColumn.DataPropertyName = "TotalSalida"
        Me.TotalSalidaDataGridViewTextBoxColumn.HeaderText = "TotalSalida"
        Me.TotalSalidaDataGridViewTextBoxColumn.Name = "TotalSalidaDataGridViewTextBoxColumn"
        Me.TotalSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Entradas:"
        '
        'txtEntradas
        '
        Me.txtEntradas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEntradas.Location = New System.Drawing.Point(96, 324)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(100, 20)
        Me.txtEntradas.TabIndex = 3
        Me.txtEntradas.Text = "0"
        Me.txtEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalidas
        '
        Me.txtSalidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSalidas.Location = New System.Drawing.Point(96, 350)
        Me.txtSalidas.Name = "txtSalidas"
        Me.txtSalidas.Size = New System.Drawing.Size(100, 20)
        Me.txtSalidas.TabIndex = 5
        Me.txtSalidas.Text = "0"
        Me.txtSalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Salidas:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Diferencia:"
        '
        'txtDiferencias
        '
        Me.txtDiferencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDiferencias.Location = New System.Drawing.Point(96, 384)
        Me.txtDiferencias.Name = "txtDiferencias"
        Me.txtDiferencias.Size = New System.Drawing.Size(100, 20)
        Me.txtDiferencias.TabIndex = 7
        Me.txtDiferencias.Text = "0"
        Me.txtDiferencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmVistaAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 431)
        Me.Controls.Add(Me.txtDiferencias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalidas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.dgv)
        Me.Name = "FrmVistaAjuste"
        Me.Text = "FrmVistaAjuste"
        CType(Me.enlaceDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enlaceDatos As BindingSource
    Friend WithEvents dgv As DataGridView
    Friend WithEvents datos As dtsKardex
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntradaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SalidaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEntradas As TextBox
    Friend WithEvents txtSalidas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiferencias As TextBox
End Class
