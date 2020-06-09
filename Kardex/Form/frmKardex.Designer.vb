<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKardex
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
        Me.dgvKardex = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdInventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsKardex = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsKardex = New KardexInventario.dtsKardex()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bwRevisar = New System.ComponentModel.BackgroundWorker()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.dgvCorreciones = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaCorregidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioCorregidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCorregidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBodegaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaBodegaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoFinalBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCorreciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.sc1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbDiferencia = New System.Windows.Forms.Label()
        Me.txtSaldoAcumulado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bwCorregir = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCorreciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCorreciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc1.Panel1.SuspendLayout()
        Me.sc1.Panel2.SuspendLayout()
        Me.sc1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKardex
        '
        Me.dgvKardex.AllowUserToAddRows = False
        Me.dgvKardex.AllowUserToDeleteRows = False
        Me.dgvKardex.AllowUserToResizeRows = False
        Me.dgvKardex.AutoGenerateColumns = False
        Me.dgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.IdInventarioDataGridViewTextBoxColumn, Me.IdBodegaDataGridViewTextBoxColumn, Me.InventarioDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.IdLineaDataGridViewTextBoxColumn, Me.IdDocumentoDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.IdMonedaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.SaldoBodegaDataGridViewTextBoxColumn, Me.ExistenciaBodegaDataGridViewTextBoxColumn, Me.CostoPromedioBodegaDataGridViewTextBoxColumn, Me.SumaDataGridViewCheckBoxColumn})
        Me.dgvKardex.DataSource = Me.bsKardex
        Me.dgvKardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKardex.Location = New System.Drawing.Point(0, 0)
        Me.dgvKardex.Name = "dgvKardex"
        Me.dgvKardex.ReadOnly = True
        Me.dgvKardex.RowHeadersVisible = False
        Me.dgvKardex.Size = New System.Drawing.Size(1050, 297)
        Me.dgvKardex.TabIndex = 0
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdInventarioDataGridViewTextBoxColumn
        '
        Me.IdInventarioDataGridViewTextBoxColumn.DataPropertyName = "IdInventario"
        Me.IdInventarioDataGridViewTextBoxColumn.HeaderText = "IdInventario"
        Me.IdInventarioDataGridViewTextBoxColumn.Name = "IdInventarioDataGridViewTextBoxColumn"
        Me.IdInventarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdBodegaDataGridViewTextBoxColumn
        '
        Me.IdBodegaDataGridViewTextBoxColumn.DataPropertyName = "IdBodega"
        Me.IdBodegaDataGridViewTextBoxColumn.HeaderText = "IdBodega"
        Me.IdBodegaDataGridViewTextBoxColumn.Name = "IdBodegaDataGridViewTextBoxColumn"
        Me.IdBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventarioDataGridViewTextBoxColumn
        '
        Me.InventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario"
        Me.InventarioDataGridViewTextBoxColumn.HeaderText = "Inventario"
        Me.InventarioDataGridViewTextBoxColumn.Name = "InventarioDataGridViewTextBoxColumn"
        Me.InventarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdLineaDataGridViewTextBoxColumn
        '
        Me.IdLineaDataGridViewTextBoxColumn.DataPropertyName = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.HeaderText = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.Name = "IdLineaDataGridViewTextBoxColumn"
        Me.IdLineaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDocumentoDataGridViewTextBoxColumn
        '
        Me.IdDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IdDocumento"
        Me.IdDocumentoDataGridViewTextBoxColumn.HeaderText = "IdDocumento"
        Me.IdDocumentoDataGridViewTextBoxColumn.Name = "IdDocumentoDataGridViewTextBoxColumn"
        Me.IdDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        Me.DocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMonedaDataGridViewTextBoxColumn
        '
        Me.IdMonedaDataGridViewTextBoxColumn.DataPropertyName = "IdMoneda"
        Me.IdMonedaDataGridViewTextBoxColumn.HeaderText = "IdMoneda"
        Me.IdMonedaDataGridViewTextBoxColumn.Name = "IdMonedaDataGridViewTextBoxColumn"
        Me.IdMonedaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        Me.CostoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoBodegaDataGridViewTextBoxColumn
        '
        Me.SaldoBodegaDataGridViewTextBoxColumn.DataPropertyName = "SaldoBodega"
        Me.SaldoBodegaDataGridViewTextBoxColumn.HeaderText = "SaldoBodega"
        Me.SaldoBodegaDataGridViewTextBoxColumn.Name = "SaldoBodegaDataGridViewTextBoxColumn"
        Me.SaldoBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaBodegaDataGridViewTextBoxColumn
        '
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.DataPropertyName = "ExistenciaBodega"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.HeaderText = "ExistenciaBodega"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.Name = "ExistenciaBodegaDataGridViewTextBoxColumn"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoPromedioBodegaDataGridViewTextBoxColumn
        '
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedioBodega"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.HeaderText = "CostoPromedioBodega"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.Name = "CostoPromedioBodegaDataGridViewTextBoxColumn"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SumaDataGridViewCheckBoxColumn
        '
        Me.SumaDataGridViewCheckBoxColumn.DataPropertyName = "Suma"
        Me.SumaDataGridViewCheckBoxColumn.HeaderText = "Suma"
        Me.SumaDataGridViewCheckBoxColumn.Name = "SumaDataGridViewCheckBoxColumn"
        Me.SumaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'bsKardex
        '
        Me.bsKardex.DataMember = "vs_Kardex"
        Me.bsKardex.DataSource = Me.DtsKardex
        '
        'DtsKardex
        '
        Me.DtsKardex.DataSetName = "dtsKardex"
        Me.DtsKardex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Revisar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bwRevisar
        '
        Me.bwRevisar.WorkerReportsProgress = True
        '
        'pbar
        '
        Me.pbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.Location = New System.Drawing.Point(322, 15)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(736, 23)
        Me.pbar.TabIndex = 4
        Me.pbar.Visible = False
        '
        'dgvCorreciones
        '
        Me.dgvCorreciones.AllowUserToAddRows = False
        Me.dgvCorreciones.AllowUserToDeleteRows = False
        Me.dgvCorreciones.AllowUserToResizeRows = False
        Me.dgvCorreciones.AutoGenerateColumns = False
        Me.dgvCorreciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCorreciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn1, Me.ExistenciaCorregidaDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn1, Me.CostoPromedioCorregidoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn1, Me.SaldoCorregidoDataGridViewTextBoxColumn, Me.IdBodegaDataGridViewTextBoxColumn1, Me.ExistenciaBodegaDataGridViewTextBoxColumn1, Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn, Me.CostoPromedioBodegaDataGridViewTextBoxColumn1, Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn, Me.SaldoFinalBodegaDataGridViewTextBoxColumn, Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn})
        Me.dgvCorreciones.DataSource = Me.bsCorreciones
        Me.dgvCorreciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCorreciones.Location = New System.Drawing.Point(0, 0)
        Me.dgvCorreciones.Name = "dgvCorreciones"
        Me.dgvCorreciones.ReadOnly = True
        Me.dgvCorreciones.RowHeadersVisible = False
        Me.dgvCorreciones.Size = New System.Drawing.Size(1050, 182)
        Me.dgvCorreciones.TabIndex = 5
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn1
        '
        Me.ExistenciaDataGridViewTextBoxColumn1.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn1.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn1.Name = "ExistenciaDataGridViewTextBoxColumn1"
        Me.ExistenciaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ExistenciaCorregidaDataGridViewTextBoxColumn
        '
        Me.ExistenciaCorregidaDataGridViewTextBoxColumn.DataPropertyName = "ExistenciaCorregida"
        Me.ExistenciaCorregidaDataGridViewTextBoxColumn.HeaderText = "ExistenciaCorregida"
        Me.ExistenciaCorregidaDataGridViewTextBoxColumn.Name = "ExistenciaCorregidaDataGridViewTextBoxColumn"
        Me.ExistenciaCorregidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoPromedioDataGridViewTextBoxColumn1
        '
        Me.CostoPromedioDataGridViewTextBoxColumn1.DataPropertyName = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn1.HeaderText = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn1.Name = "CostoPromedioDataGridViewTextBoxColumn1"
        Me.CostoPromedioDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CostoPromedioCorregidoDataGridViewTextBoxColumn
        '
        Me.CostoPromedioCorregidoDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedioCorregido"
        Me.CostoPromedioCorregidoDataGridViewTextBoxColumn.HeaderText = "CostoPromedioCorregido"
        Me.CostoPromedioCorregidoDataGridViewTextBoxColumn.Name = "CostoPromedioCorregidoDataGridViewTextBoxColumn"
        Me.CostoPromedioCorregidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn1
        '
        Me.SaldoDataGridViewTextBoxColumn1.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn1.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn1.Name = "SaldoDataGridViewTextBoxColumn1"
        Me.SaldoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SaldoCorregidoDataGridViewTextBoxColumn
        '
        Me.SaldoCorregidoDataGridViewTextBoxColumn.DataPropertyName = "SaldoCorregido"
        Me.SaldoCorregidoDataGridViewTextBoxColumn.HeaderText = "SaldoCorregido"
        Me.SaldoCorregidoDataGridViewTextBoxColumn.Name = "SaldoCorregidoDataGridViewTextBoxColumn"
        Me.SaldoCorregidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdBodegaDataGridViewTextBoxColumn1
        '
        Me.IdBodegaDataGridViewTextBoxColumn1.DataPropertyName = "IdBodega"
        Me.IdBodegaDataGridViewTextBoxColumn1.HeaderText = "IdBodega"
        Me.IdBodegaDataGridViewTextBoxColumn1.Name = "IdBodegaDataGridViewTextBoxColumn1"
        Me.IdBodegaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ExistenciaBodegaDataGridViewTextBoxColumn1
        '
        Me.ExistenciaBodegaDataGridViewTextBoxColumn1.DataPropertyName = "ExistenciaBodega"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn1.HeaderText = "ExistenciaBodega"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn1.Name = "ExistenciaBodegaDataGridViewTextBoxColumn1"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ExistenciaBodegaCorregidaDataGridViewTextBoxColumn
        '
        Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn.DataPropertyName = "ExistenciaBodegaCorregida"
        Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn.HeaderText = "ExistenciaBodegaCorregida"
        Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn.Name = "ExistenciaBodegaCorregidaDataGridViewTextBoxColumn"
        Me.ExistenciaBodegaCorregidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoPromedioBodegaDataGridViewTextBoxColumn1
        '
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn1.DataPropertyName = "CostoPromedioBodega"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn1.HeaderText = "CostoPromedioBodega"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn1.Name = "CostoPromedioBodegaDataGridViewTextBoxColumn1"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CostPromedioBodegaCorregidaDataGridViewTextBoxColumn
        '
        Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn.DataPropertyName = "CostPromedioBodegaCorregida"
        Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn.HeaderText = "CostPromedioBodegaCorregida"
        Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn.Name = "CostPromedioBodegaCorregidaDataGridViewTextBoxColumn"
        Me.CostPromedioBodegaCorregidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoFinalBodegaDataGridViewTextBoxColumn
        '
        Me.SaldoFinalBodegaDataGridViewTextBoxColumn.DataPropertyName = "SaldoFinalBodega"
        Me.SaldoFinalBodegaDataGridViewTextBoxColumn.HeaderText = "SaldoFinalBodega"
        Me.SaldoFinalBodegaDataGridViewTextBoxColumn.Name = "SaldoFinalBodegaDataGridViewTextBoxColumn"
        Me.SaldoFinalBodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoBodegaCorregidoDataGridViewTextBoxColumn
        '
        Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn.DataPropertyName = "SaldoBodegaCorregido"
        Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn.HeaderText = "SaldoBodegaCorregido"
        Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn.Name = "SaldoBodegaCorregidoDataGridViewTextBoxColumn"
        Me.SaldoBodegaCorregidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsCorreciones
        '
        Me.bsCorreciones.DataMember = "vs_Inventario"
        Me.bsCorreciones.DataSource = Me.DtsKardex
        '
        'sc1
        '
        Me.sc1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sc1.Location = New System.Drawing.Point(8, 73)
        Me.sc1.Name = "sc1"
        Me.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sc1.Panel1
        '
        Me.sc1.Panel1.Controls.Add(Me.dgvCorreciones)
        '
        'sc1.Panel2
        '
        Me.sc1.Panel2.Controls.Add(Me.dgvKardex)
        Me.sc1.Size = New System.Drawing.Size(1050, 483)
        Me.sc1.SplitterDistance = 182
        Me.sc1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Filtrar Diferencias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbDiferencia
        '
        Me.lbDiferencia.AutoSize = True
        Me.lbDiferencia.Location = New System.Drawing.Point(162, 48)
        Me.lbDiferencia.Name = "lbDiferencia"
        Me.lbDiferencia.Size = New System.Drawing.Size(0, 13)
        Me.lbDiferencia.TabIndex = 8
        '
        'txtSaldoAcumulado
        '
        Me.txtSaldoAcumulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoAcumulado.Location = New System.Drawing.Point(893, 45)
        Me.txtSaldoAcumulado.Name = "txtSaldoAcumulado"
        Me.txtSaldoAcumulado.ReadOnly = True
        Me.txtSaldoAcumulado.Size = New System.Drawing.Size(165, 20)
        Me.txtSaldoAcumulado.TabIndex = 9
        Me.txtSaldoAcumulado.Text = "0"
        Me.txtSaldoAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(746, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Saldo Acumulado Corregido:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(165, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 26)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Aplicar Cambios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'bwCorregir
        '
        Me.bwCorregir.WorkerReportsProgress = True
        '
        'frmKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 557)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaldoAcumulado)
        Me.Controls.Add(Me.lbDiferencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sc1)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.Button2)
        Me.Name = "frmKardex"
        Me.Text = "Kardex"
        CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCorreciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCorreciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc1.Panel1.ResumeLayout(False)
        Me.sc1.Panel2.ResumeLayout(False)
        CType(Me.sc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvKardex As DataGridView
    Friend WithEvents bsKardex As BindingSource
    Friend WithEvents DtsKardex As dtsKardex
    Friend WithEvents Button2 As Button
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdInventarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdLineaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SumaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents bwRevisar As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents dgvCorreciones As DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaCorregidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioCorregidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCorregidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdBodegaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaBodegaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaBodegaCorregidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioBodegaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CostPromedioBodegaCorregidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoFinalBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoBodegaCorregidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsCorreciones As BindingSource
    Friend WithEvents sc1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents lbDiferencia As Label
    Friend WithEvents txtSaldoAcumulado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents bwCorregir As System.ComponentModel.BackgroundWorker
End Class
