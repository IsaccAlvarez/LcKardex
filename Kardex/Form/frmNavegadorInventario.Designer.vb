<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavegadorInventario
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lbFiltro = New System.Windows.Forms.Label()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.btFiltro = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.scDatos = New System.Windows.Forms.SplitContainer()
        Me.dvgInventario = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsInventario = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsKardex = New KardexInventario.dtsKardex()
        Me.dgvInventarioKardex = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsInventarioKardex = New System.Windows.Forms.BindingSource(Me.components)
        Me.scPanel = New System.Windows.Forms.SplitContainer()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.bsBodega = New System.Windows.Forms.BindingSource(Me.components)
        Me.chBodega = New System.Windows.Forms.CheckBox()
        Me.btAplicar = New System.Windows.Forms.Button()
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.bsTipoDocumento = New System.Windows.Forms.BindingSource(Me.components)
        Me.chTipoDocumento = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFamilia = New System.Windows.Forms.ComboBox()
        Me.bsFamilia = New System.Windows.Forms.BindingSource(Me.components)
        Me.chFamilia = New System.Windows.Forms.CheckBox()
        Me.chFechaExistencia = New System.Windows.Forms.CheckBox()
        Me.dtpFechaExistencia = New System.Windows.Forms.DateTimePicker()
        Me.rbInicio = New System.Windows.Forms.RadioButton()
        Me.rbCualquier = New System.Windows.Forms.RadioButton()
        Me.chBarras = New System.Windows.Forms.CheckBox()
        Me.chCodigo = New System.Windows.Forms.CheckBox()
        Me.chDescripcion = New System.Windows.Forms.CheckBox()
        Me.bwDatos = New System.ComponentModel.BackgroundWorker()
        Me.lbProgreso = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.bwActualizar = New System.ComponentModel.BackgroundWorker()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.chFiltrarFechasDoc = New System.Windows.Forms.CheckBox()
        Me.dtpFDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFHasta = New System.Windows.Forms.DateTimePicker()
        CType(Me.scDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDatos.Panel1.SuspendLayout()
        Me.scDatos.Panel2.SuspendLayout()
        Me.scDatos.SuspendLayout()
        CType(Me.dvgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventarioKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventarioKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scPanel.Panel1.SuspendLayout()
        Me.scPanel.Panel2.SuspendLayout()
        Me.scPanel.SuspendLayout()
        CType(Me.bsBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(256, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(419, 21)
        Me.txtBuscar.TabIndex = 0
        '
        'lbFiltro
        '
        Me.lbFiltro.AutoSize = True
        Me.lbFiltro.ForeColor = System.Drawing.Color.White
        Me.lbFiltro.Location = New System.Drawing.Point(31, 15)
        Me.lbFiltro.Name = "lbFiltro"
        Me.lbFiltro.Size = New System.Drawing.Size(0, 13)
        Me.lbFiltro.TabIndex = 3
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCerrar.BackgroundImage = Global.KardexInventario.My.Resources.Resources.close
        Me.btCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Location = New System.Drawing.Point(840, 8)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btCerrar.TabIndex = 5
        Me.btCerrar.UseVisualStyleBackColor = True
        '
        'btFiltro
        '
        Me.btFiltro.BackgroundImage = Global.KardexInventario.My.Resources.Resources.filter
        Me.btFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btFiltro.FlatAppearance.BorderSize = 0
        Me.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFiltro.Location = New System.Drawing.Point(5, 12)
        Me.btFiltro.Name = "btFiltro"
        Me.btFiltro.Size = New System.Drawing.Size(25, 25)
        Me.btFiltro.TabIndex = 2
        Me.btFiltro.Tag = "Select"
        Me.btFiltro.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btBuscar.BackgroundImage = Global.KardexInventario.My.Resources.Resources.search
        Me.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Location = New System.Drawing.Point(681, 16)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(20, 20)
        Me.btBuscar.TabIndex = 1
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'scDatos
        '
        Me.scDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDatos.Location = New System.Drawing.Point(0, 0)
        Me.scDatos.Name = "scDatos"
        Me.scDatos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scDatos.Panel1
        '
        Me.scDatos.Panel1.Controls.Add(Me.dvgInventario)
        '
        'scDatos.Panel2
        '
        Me.scDatos.Panel2.Controls.Add(Me.dgvInventarioKardex)
        Me.scDatos.Size = New System.Drawing.Size(690, 407)
        Me.scDatos.SplitterDistance = 186
        Me.scDatos.TabIndex = 6
        '
        'dvgInventario
        '
        Me.dvgInventario.AllowUserToAddRows = False
        Me.dvgInventario.AllowUserToDeleteRows = False
        Me.dvgInventario.AllowUserToResizeRows = False
        Me.dvgInventario.AutoGenerateColumns = False
        Me.dvgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgInventario.BackgroundColor = System.Drawing.Color.White
        Me.dvgInventario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dvgInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dvgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.BarrasDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.dvgInventario.DataSource = Me.bsInventario
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgInventario.DefaultCellStyle = DataGridViewCellStyle36
        Me.dvgInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgInventario.EnableHeadersVisualStyles = False
        Me.dvgInventario.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dvgInventario.Location = New System.Drawing.Point(0, 0)
        Me.dvgInventario.Name = "dvgInventario"
        Me.dvgInventario.ReadOnly = True
        Me.dvgInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgInventario.RowHeadersVisible = False
        Me.dvgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgInventario.Size = New System.Drawing.Size(690, 186)
        Me.dvgInventario.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BarrasDataGridViewTextBoxColumn
        '
        Me.BarrasDataGridViewTextBoxColumn.DataPropertyName = "Barras"
        Me.BarrasDataGridViewTextBoxColumn.HeaderText = "Barras"
        Me.BarrasDataGridViewTextBoxColumn.Name = "BarrasDataGridViewTextBoxColumn"
        Me.BarrasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "N2"
        DataGridViewCellStyle32.NullValue = Nothing
        Me.ExistenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle32
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "N2"
        DataGridViewCellStyle33.NullValue = Nothing
        Me.CostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle33
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        Me.CostoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N2"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.SaldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle34
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "N2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.PrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle35
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "P.Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsInventario
        '
        Me.bsInventario.DataMember = "vs_NavegadorInventario"
        Me.bsInventario.DataSource = Me.DtsKardex
        '
        'DtsKardex
        '
        Me.DtsKardex.DataSetName = "dtsKardex"
        Me.DtsKardex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvInventarioKardex
        '
        Me.dgvInventarioKardex.AllowUserToAddRows = False
        Me.dgvInventarioKardex.AllowUserToDeleteRows = False
        Me.dgvInventarioKardex.AllowUserToResizeRows = False
        Me.dgvInventarioKardex.AutoGenerateColumns = False
        Me.dgvInventarioKardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvInventarioKardex.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventarioKardex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventarioKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInventarioKardex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventarioKardex.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvInventarioKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventarioKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.Nombre, Me.CantidadDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn1, Me.ExistenciaDataGridViewTextBoxColumn1, Me.SaldoDataGridViewTextBoxColumn1, Me.ExistenciaBodegaDataGridViewTextBoxColumn, Me.CostoPromedioBodegaDataGridViewTextBoxColumn, Me.SaldoBodegaDataGridViewTextBoxColumn, Me.Doc})
        Me.dgvInventarioKardex.DataSource = Me.bsInventarioKardex
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventarioKardex.DefaultCellStyle = DataGridViewCellStyle45
        Me.dgvInventarioKardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventarioKardex.EnableHeadersVisualStyles = False
        Me.dgvInventarioKardex.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvInventarioKardex.Location = New System.Drawing.Point(0, 0)
        Me.dgvInventarioKardex.Name = "dgvInventarioKardex"
        Me.dgvInventarioKardex.ReadOnly = True
        Me.dgvInventarioKardex.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventarioKardex.RowHeadersVisible = False
        Me.dgvInventarioKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventarioKardex.Size = New System.Drawing.Size(690, 217)
        Me.dgvInventarioKardex.TabIndex = 1
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 50
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Doc"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        Me.DocumentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentoDataGridViewTextBoxColumn.Width = 48
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Width = 66
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 67
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle38
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 73
        '
        'CostoPromedioDataGridViewTextBoxColumn1
        '
        Me.CostoPromedioDataGridViewTextBoxColumn1.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N2"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.CostoPromedioDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle39
        Me.CostoPromedioDataGridViewTextBoxColumn1.HeaderText = "CostoPromedio"
        Me.CostoPromedioDataGridViewTextBoxColumn1.Name = "CostoPromedioDataGridViewTextBoxColumn1"
        Me.CostoPromedioDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CostoPromedioDataGridViewTextBoxColumn1.Width = 102
        '
        'ExistenciaDataGridViewTextBoxColumn1
        '
        Me.ExistenciaDataGridViewTextBoxColumn1.DataPropertyName = "Existencia"
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle40.Format = "N2"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.ExistenciaDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle40
        Me.ExistenciaDataGridViewTextBoxColumn1.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn1.Name = "ExistenciaDataGridViewTextBoxColumn1"
        Me.ExistenciaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ExistenciaDataGridViewTextBoxColumn1.Width = 78
        '
        'SaldoDataGridViewTextBoxColumn1
        '
        Me.SaldoDataGridViewTextBoxColumn1.DataPropertyName = "Saldo"
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle41.Format = "N2"
        DataGridViewCellStyle41.NullValue = Nothing
        Me.SaldoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle41
        Me.SaldoDataGridViewTextBoxColumn1.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn1.Name = "SaldoDataGridViewTextBoxColumn1"
        Me.SaldoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SaldoDataGridViewTextBoxColumn1.Width = 56
        '
        'ExistenciaBodegaDataGridViewTextBoxColumn
        '
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.DataPropertyName = "ExistenciaBodega"
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle42.Format = "N2"
        DataGridViewCellStyle42.NullValue = Nothing
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle42
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.HeaderText = "Exist.Bodega"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.Name = "ExistenciaBodegaDataGridViewTextBoxColumn"
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExistenciaBodegaDataGridViewTextBoxColumn.Width = 93
        '
        'CostoPromedioBodegaDataGridViewTextBoxColumn
        '
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedioBodega"
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle43.Format = "N2"
        DataGridViewCellStyle43.NullValue = Nothing
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle43
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.HeaderText = "CostoPromedioBodega"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.Name = "CostoPromedioBodegaDataGridViewTextBoxColumn"
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoPromedioBodegaDataGridViewTextBoxColumn.Width = 138
        '
        'SaldoBodegaDataGridViewTextBoxColumn
        '
        Me.SaldoBodegaDataGridViewTextBoxColumn.DataPropertyName = "SaldoBodega"
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle44.Format = "N2"
        DataGridViewCellStyle44.NullValue = Nothing
        Me.SaldoBodegaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle44
        Me.SaldoBodegaDataGridViewTextBoxColumn.HeaderText = "SaldoBodega"
        Me.SaldoBodegaDataGridViewTextBoxColumn.Name = "SaldoBodegaDataGridViewTextBoxColumn"
        Me.SaldoBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoBodegaDataGridViewTextBoxColumn.Width = 92
        '
        'Doc
        '
        Me.Doc.DataPropertyName = "Doc"
        Me.Doc.HeaderText = "Doc"
        Me.Doc.Name = "Doc"
        Me.Doc.ReadOnly = True
        Me.Doc.Width = 48
        '
        'bsInventarioKardex
        '
        Me.bsInventarioKardex.DataMember = "vs_NavegadorInventarioKardex"
        Me.bsInventarioKardex.DataSource = Me.DtsKardex
        '
        'scPanel
        '
        Me.scPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scPanel.Location = New System.Drawing.Point(5, 71)
        Me.scPanel.Name = "scPanel"
        '
        'scPanel.Panel1
        '
        Me.scPanel.Panel1.Controls.Add(Me.dtpFHasta)
        Me.scPanel.Panel1.Controls.Add(Me.dtpFDesde)
        Me.scPanel.Panel1.Controls.Add(Me.chFiltrarFechasDoc)
        Me.scPanel.Panel1.Controls.Add(Me.cbBodega)
        Me.scPanel.Panel1.Controls.Add(Me.chBodega)
        Me.scPanel.Panel1.Controls.Add(Me.btAplicar)
        Me.scPanel.Panel1.Controls.Add(Me.cbTipoDocumento)
        Me.scPanel.Panel1.Controls.Add(Me.chTipoDocumento)
        Me.scPanel.Panel1.Controls.Add(Me.Label1)
        Me.scPanel.Panel1.Controls.Add(Me.cbFamilia)
        Me.scPanel.Panel1.Controls.Add(Me.chFamilia)
        Me.scPanel.Panel1.Controls.Add(Me.chFechaExistencia)
        Me.scPanel.Panel1.Controls.Add(Me.dtpFechaExistencia)
        Me.scPanel.Panel1.ForeColor = System.Drawing.Color.White
        '
        'scPanel.Panel2
        '
        Me.scPanel.Panel2.Controls.Add(Me.scDatos)
        Me.scPanel.Size = New System.Drawing.Size(878, 407)
        Me.scPanel.SplitterDistance = 184
        Me.scPanel.TabIndex = 7
        '
        'cbBodega
        '
        Me.cbBodega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodega.DataSource = Me.bsBodega
        Me.cbBodega.DisplayMember = "Bodega"
        Me.cbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBodega.FormattingEnabled = True
        Me.cbBodega.Location = New System.Drawing.Point(6, 187)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(175, 21)
        Me.cbBodega.TabIndex = 11
        Me.cbBodega.ValueMember = "IdBodega"
        Me.cbBodega.Visible = False
        '
        'bsBodega
        '
        Me.bsBodega.DataMember = "Bodega"
        Me.bsBodega.DataSource = Me.DtsKardex
        '
        'chBodega
        '
        Me.chBodega.AutoSize = True
        Me.chBodega.Location = New System.Drawing.Point(6, 158)
        Me.chBodega.Name = "chBodega"
        Me.chBodega.Size = New System.Drawing.Size(66, 17)
        Me.chBodega.TabIndex = 10
        Me.chBodega.Text = "Bodega."
        Me.chBodega.UseVisualStyleBackColor = True
        '
        'btAplicar
        '
        Me.btAplicar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAplicar.Location = New System.Drawing.Point(6, 367)
        Me.btAplicar.Name = "btAplicar"
        Me.btAplicar.Size = New System.Drawing.Size(174, 37)
        Me.btAplicar.TabIndex = 9
        Me.btAplicar.Text = "Aplicar Filtros."
        Me.btAplicar.UseVisualStyleBackColor = True
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoDocumento.DataSource = Me.bsTipoDocumento
        Me.cbTipoDocumento.DisplayMember = "Tipo"
        Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Location = New System.Drawing.Point(6, 255)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(175, 21)
        Me.cbTipoDocumento.TabIndex = 8
        Me.cbTipoDocumento.ValueMember = "Tipo"
        Me.cbTipoDocumento.Visible = False
        '
        'bsTipoDocumento
        '
        Me.bsTipoDocumento.DataMember = "TipoDocumento"
        Me.bsTipoDocumento.DataSource = Me.DtsKardex
        '
        'chTipoDocumento
        '
        Me.chTipoDocumento.AutoSize = True
        Me.chTipoDocumento.Location = New System.Drawing.Point(6, 226)
        Me.chTipoDocumento.Name = "chTipoDocumento"
        Me.chTipoDocumento.Size = New System.Drawing.Size(107, 17)
        Me.chTipoDocumento.TabIndex = 7
        Me.chTipoDocumento.Text = "Tipo Documento."
        Me.chTipoDocumento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filtros."
        '
        'cbFamilia
        '
        Me.cbFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFamilia.DataSource = Me.bsFamilia
        Me.cbFamilia.DisplayMember = "Familia"
        Me.cbFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFamilia.FormattingEnabled = True
        Me.cbFamilia.Location = New System.Drawing.Point(6, 121)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(175, 21)
        Me.cbFamilia.TabIndex = 5
        Me.cbFamilia.ValueMember = "Id"
        Me.cbFamilia.Visible = False
        '
        'bsFamilia
        '
        Me.bsFamilia.DataMember = "Familia"
        Me.bsFamilia.DataSource = Me.DtsKardex
        '
        'chFamilia
        '
        Me.chFamilia.AutoSize = True
        Me.chFamilia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFamilia.ForeColor = System.Drawing.Color.White
        Me.chFamilia.Location = New System.Drawing.Point(6, 92)
        Me.chFamilia.Name = "chFamilia"
        Me.chFamilia.Size = New System.Drawing.Size(62, 17)
        Me.chFamilia.TabIndex = 4
        Me.chFamilia.Text = "Familia."
        Me.chFamilia.UseVisualStyleBackColor = True
        '
        'chFechaExistencia
        '
        Me.chFechaExistencia.AutoSize = True
        Me.chFechaExistencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFechaExistencia.ForeColor = System.Drawing.Color.White
        Me.chFechaExistencia.Location = New System.Drawing.Point(6, 30)
        Me.chFechaExistencia.Name = "chFechaExistencia"
        Me.chFechaExistencia.Size = New System.Drawing.Size(140, 17)
        Me.chFechaExistencia.TabIndex = 2
        Me.chFechaExistencia.Text = "Fecha Corte Existencia."
        Me.chFechaExistencia.UseVisualStyleBackColor = True
        '
        'dtpFechaExistencia
        '
        Me.dtpFechaExistencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaExistencia.CustomFormat = "dd/MM/yyyy hh:mm:tt"
        Me.dtpFechaExistencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaExistencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaExistencia.Location = New System.Drawing.Point(6, 59)
        Me.dtpFechaExistencia.Name = "dtpFechaExistencia"
        Me.dtpFechaExistencia.Size = New System.Drawing.Size(175, 21)
        Me.dtpFechaExistencia.TabIndex = 1
        Me.dtpFechaExistencia.Visible = False
        '
        'rbInicio
        '
        Me.rbInicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rbInicio.AutoSize = True
        Me.rbInicio.Checked = True
        Me.rbInicio.ForeColor = System.Drawing.Color.White
        Me.rbInicio.Location = New System.Drawing.Point(256, 41)
        Me.rbInicio.Name = "rbInicio"
        Me.rbInicio.Size = New System.Drawing.Size(85, 17)
        Me.rbInicio.TabIndex = 6
        Me.rbInicio.TabStop = True
        Me.rbInicio.Text = "Inicio Texto."
        Me.rbInicio.UseVisualStyleBackColor = True
        '
        'rbCualquier
        '
        Me.rbCualquier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rbCualquier.AutoSize = True
        Me.rbCualquier.ForeColor = System.Drawing.Color.White
        Me.rbCualquier.Location = New System.Drawing.Point(352, 41)
        Me.rbCualquier.Name = "rbCualquier"
        Me.rbCualquier.Size = New System.Drawing.Size(103, 17)
        Me.rbCualquier.TabIndex = 7
        Me.rbCualquier.TabStop = True
        Me.rbCualquier.Text = "Cualquier parte."
        Me.rbCualquier.UseVisualStyleBackColor = True
        '
        'chBarras
        '
        Me.chBarras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chBarras.AutoSize = True
        Me.chBarras.Checked = True
        Me.chBarras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chBarras.ForeColor = System.Drawing.Color.White
        Me.chBarras.Location = New System.Drawing.Point(465, 42)
        Me.chBarras.Name = "chBarras"
        Me.chBarras.Size = New System.Drawing.Size(61, 17)
        Me.chBarras.TabIndex = 8
        Me.chBarras.Text = "Barras."
        Me.chBarras.UseVisualStyleBackColor = True
        '
        'chCodigo
        '
        Me.chCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chCodigo.AutoSize = True
        Me.chCodigo.Checked = True
        Me.chCodigo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chCodigo.ForeColor = System.Drawing.Color.White
        Me.chCodigo.Location = New System.Drawing.Point(528, 42)
        Me.chCodigo.Name = "chCodigo"
        Me.chCodigo.Size = New System.Drawing.Size(63, 17)
        Me.chCodigo.TabIndex = 9
        Me.chCodigo.Text = "Código."
        Me.chCodigo.UseVisualStyleBackColor = True
        '
        'chDescripcion
        '
        Me.chDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chDescripcion.AutoSize = True
        Me.chDescripcion.Checked = True
        Me.chDescripcion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chDescripcion.ForeColor = System.Drawing.Color.White
        Me.chDescripcion.Location = New System.Drawing.Point(597, 42)
        Me.chDescripcion.Name = "chDescripcion"
        Me.chDescripcion.Size = New System.Drawing.Size(84, 17)
        Me.chDescripcion.TabIndex = 10
        Me.chDescripcion.Text = "Descripción."
        Me.chDescripcion.UseVisualStyleBackColor = True
        '
        'bwDatos
        '
        Me.bwDatos.WorkerReportsProgress = True
        '
        'lbProgreso
        '
        Me.lbProgreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbProgreso.AutoSize = True
        Me.lbProgreso.BackColor = System.Drawing.Color.Transparent
        Me.lbProgreso.ForeColor = System.Drawing.Color.White
        Me.lbProgreso.Location = New System.Drawing.Point(9, 483)
        Me.lbProgreso.Name = "lbProgreso"
        Me.lbProgreso.Size = New System.Drawing.Size(0, 13)
        Me.lbProgreso.TabIndex = 11
        '
        'btActualizar
        '
        Me.btActualizar.BackgroundImage = Global.KardexInventario.My.Resources.Resources.refresh_update
        Me.btActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btActualizar.FlatAppearance.BorderSize = 0
        Me.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizar.ForeColor = System.Drawing.Color.White
        Me.btActualizar.Location = New System.Drawing.Point(34, 8)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(31, 31)
        Me.btActualizar.TabIndex = 12
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'bwActualizar
        '
        Me.bwActualizar.WorkerReportsProgress = True
        '
        'btImprimir
        '
        Me.btImprimir.BackgroundImage = Global.KardexInventario.My.Resources.Resources.print
        Me.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btImprimir.FlatAppearance.BorderSize = 0
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprimir.ForeColor = System.Drawing.Color.White
        Me.btImprimir.Location = New System.Drawing.Point(71, 8)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(31, 31)
        Me.btImprimir.TabIndex = 13
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'chFiltrarFechasDoc
        '
        Me.chFiltrarFechasDoc.AutoSize = True
        Me.chFiltrarFechasDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFiltrarFechasDoc.ForeColor = System.Drawing.Color.White
        Me.chFiltrarFechasDoc.Location = New System.Drawing.Point(6, 282)
        Me.chFiltrarFechasDoc.Name = "chFiltrarFechasDoc"
        Me.chFiltrarFechasDoc.Size = New System.Drawing.Size(175, 17)
        Me.chFiltrarFechasDoc.TabIndex = 12
        Me.chFiltrarFechasDoc.Text = "Ver entre kardex entre fechas."
        Me.chFiltrarFechasDoc.UseVisualStyleBackColor = True
        '
        'dtpFDesde
        '
        Me.dtpFDesde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFDesde.CustomFormat = "dd/MM/yyyy hh:mm:tt"
        Me.dtpFDesde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDesde.Location = New System.Drawing.Point(6, 305)
        Me.dtpFDesde.Name = "dtpFDesde"
        Me.dtpFDesde.Size = New System.Drawing.Size(175, 21)
        Me.dtpFDesde.TabIndex = 13
        Me.dtpFDesde.Visible = False
        '
        'dtpFHasta
        '
        Me.dtpFHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFHasta.CustomFormat = "dd/MM/yyyy hh:mm:tt"
        Me.dtpFHasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFHasta.Location = New System.Drawing.Point(6, 332)
        Me.dtpFHasta.Name = "dtpFHasta"
        Me.dtpFHasta.Size = New System.Drawing.Size(175, 21)
        Me.dtpFHasta.TabIndex = 14
        Me.dtpFHasta.Visible = False
        '
        'frmNavegadorInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(886, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.lbProgreso)
        Me.Controls.Add(Me.rbCualquier)
        Me.Controls.Add(Me.chDescripcion)
        Me.Controls.Add(Me.rbInicio)
        Me.Controls.Add(Me.scPanel)
        Me.Controls.Add(Me.chCodigo)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.chBarras)
        Me.Controls.Add(Me.lbFiltro)
        Me.Controls.Add(Me.btFiltro)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNavegadorInventario"
        Me.ShowIcon = False
        Me.scDatos.Panel1.ResumeLayout(False)
        Me.scDatos.Panel2.ResumeLayout(False)
        CType(Me.scDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDatos.ResumeLayout(False)
        CType(Me.dvgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventarioKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventarioKardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPanel.Panel1.ResumeLayout(False)
        Me.scPanel.Panel1.PerformLayout()
        Me.scPanel.Panel2.ResumeLayout(False)
        CType(Me.scPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPanel.ResumeLayout(False)
        CType(Me.bsBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents btFiltro As Button
    Friend WithEvents lbFiltro As Label
    Friend WithEvents btCerrar As Button
    Friend WithEvents scDatos As SplitContainer
    Friend WithEvents dvgInventario As DataGridView
    Friend WithEvents scPanel As SplitContainer
    Friend WithEvents cbTipoDocumento As ComboBox
    Friend WithEvents chTipoDocumento As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFamilia As ComboBox
    Friend WithEvents chFamilia As CheckBox
    Friend WithEvents chFechaExistencia As CheckBox
    Friend WithEvents dtpFechaExistencia As DateTimePicker
    Friend WithEvents rbInicio As RadioButton
    Friend WithEvents rbCualquier As RadioButton
    Friend WithEvents chBarras As CheckBox
    Friend WithEvents chCodigo As CheckBox
    Friend WithEvents chDescripcion As CheckBox
    Friend WithEvents btAplicar As Button
    Friend WithEvents bsInventario As BindingSource
    Friend WithEvents DtsKardex As dtsKardex
    Friend WithEvents dgvInventarioKardex As DataGridView
    Friend WithEvents bsInventarioKardex As BindingSource
    Friend WithEvents bwDatos As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbProgreso As Label
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarrasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbBodega As ComboBox
    Friend WithEvents chBodega As CheckBox
    Friend WithEvents bsTipoDocumento As BindingSource
    Friend WithEvents bsBodega As BindingSource
    Friend WithEvents bsFamilia As BindingSource
    Friend WithEvents btActualizar As Button
    Friend WithEvents bwActualizar As System.ComponentModel.BackgroundWorker
    Friend WithEvents btImprimir As Button
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Doc As DataGridViewTextBoxColumn
    Friend WithEvents dtpFHasta As DateTimePicker
    Friend WithEvents dtpFDesde As DateTimePicker
    Friend WithEvents chFiltrarFechasDoc As CheckBox
End Class
