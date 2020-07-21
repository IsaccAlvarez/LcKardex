<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportesInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.sc = New System.Windows.Forms.SplitContainer()
        Me.pnFiltro = New System.Windows.Forms.Panel()
        Me.lbUbicacion = New System.Windows.Forms.Label()
        Me.cbUbicacion = New System.Windows.Forms.ComboBox()
        Me.lbProveedor = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.dtpFechaExistencia = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbFamilia = New System.Windows.Forms.Label()
        Me.cbFamilia = New System.Windows.Forms.ComboBox()
        Me.bsFamilia = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsKardex = New LcPymesKardex.dtsKardex()
        Me.btVer = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cbComparacion = New System.Windows.Forms.ComboBox()
        Me.lbExistencia = New System.Windows.Forms.Label()
        Me.lbBodega = New System.Windows.Forms.Label()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.bsBodega = New System.Windows.Forms.BindingSource(Me.components)
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.cbReportes = New System.Windows.Forms.ComboBox()
        Me.bwProcesar = New System.ComponentModel.BackgroundWorker()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.btFiltro = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btMax = New System.Windows.Forms.Button()
        Me.btMinimizar = New System.Windows.Forms.Button()
        Me.bwCargarReporte = New System.ComponentModel.BackgroundWorker()
        CType(Me.sc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc.Panel1.SuspendLayout()
        Me.sc.Panel2.SuspendLayout()
        Me.sc.SuspendLayout()
        Me.pnFiltro.SuspendLayout()
        CType(Me.bsFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sc
        '
        Me.sc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sc.Location = New System.Drawing.Point(4, 57)
        Me.sc.Name = "sc"
        '
        'sc.Panel1
        '
        Me.sc.Panel1.Controls.Add(Me.pnFiltro)
        '
        'sc.Panel2
        '
        Me.sc.Panel2.Controls.Add(Me.crv)
        Me.sc.Size = New System.Drawing.Size(886, 395)
        Me.sc.SplitterDistance = 226
        Me.sc.TabIndex = 0
        '
        'pnFiltro
        '
        Me.pnFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnFiltro.Controls.Add(Me.lbUbicacion)
        Me.pnFiltro.Controls.Add(Me.cbUbicacion)
        Me.pnFiltro.Controls.Add(Me.lbProveedor)
        Me.pnFiltro.Controls.Add(Me.cbProveedor)
        Me.pnFiltro.Controls.Add(Me.txtDescripcion)
        Me.pnFiltro.Controls.Add(Me.lbDescripcion)
        Me.pnFiltro.Controls.Add(Me.lbFamilia)
        Me.pnFiltro.Controls.Add(Me.cbFamilia)
        Me.pnFiltro.Controls.Add(Me.btVer)
        Me.pnFiltro.Controls.Add(Me.txtCantidad)
        Me.pnFiltro.Controls.Add(Me.cbComparacion)
        Me.pnFiltro.Controls.Add(Me.lbExistencia)
        Me.pnFiltro.Controls.Add(Me.lbBodega)
        Me.pnFiltro.Controls.Add(Me.cbBodega)
        Me.pnFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnFiltro.Name = "pnFiltro"
        Me.pnFiltro.Size = New System.Drawing.Size(226, 395)
        Me.pnFiltro.TabIndex = 0
        '
        'lbUbicacion
        '
        Me.lbUbicacion.AutoSize = True
        Me.lbUbicacion.ForeColor = System.Drawing.Color.White
        Me.lbUbicacion.Location = New System.Drawing.Point(4, 259)
        Me.lbUbicacion.Name = "lbUbicacion"
        Me.lbUbicacion.Size = New System.Drawing.Size(56, 13)
        Me.lbUbicacion.TabIndex = 23
        Me.lbUbicacion.Text = "Ubicación:"
        '
        'cbUbicacion
        '
        Me.cbUbicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUbicacion.DisplayMember = "Id"
        Me.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUbicacion.FormattingEnabled = True
        Me.cbUbicacion.Location = New System.Drawing.Point(4, 275)
        Me.cbUbicacion.Name = "cbUbicacion"
        Me.cbUbicacion.Size = New System.Drawing.Size(220, 21)
        Me.cbUbicacion.TabIndex = 22
        Me.cbUbicacion.ValueMember = "Id"
        '
        'lbProveedor
        '
        Me.lbProveedor.AutoSize = True
        Me.lbProveedor.ForeColor = System.Drawing.Color.White
        Me.lbProveedor.Location = New System.Drawing.Point(4, 210)
        Me.lbProveedor.Name = "lbProveedor"
        Me.lbProveedor.Size = New System.Drawing.Size(61, 13)
        Me.lbProveedor.TabIndex = 21
        Me.lbProveedor.Text = "Proveedor:"
        '
        'cbProveedor
        '
        Me.cbProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProveedor.DisplayMember = "Id"
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(4, 226)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(220, 21)
        Me.cbProveedor.TabIndex = 20
        Me.cbProveedor.ValueMember = "Id"
        '
        'dtpFechaExistencia
        '
        Me.dtpFechaExistencia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaExistencia.CustomFormat = "dd/MM/yyyy hh:mm:tt"
        Me.dtpFechaExistencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaExistencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaExistencia.Location = New System.Drawing.Point(151, 13)
        Me.dtpFechaExistencia.Name = "dtpFechaExistencia"
        Me.dtpFechaExistencia.Size = New System.Drawing.Size(150, 21)
        Me.dtpFechaExistencia.TabIndex = 18
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(4, 171)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(219, 21)
        Me.txtDescripcion.TabIndex = 17
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.ForeColor = System.Drawing.Color.White
        Me.lbDescripcion.Location = New System.Drawing.Point(4, 154)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(65, 13)
        Me.lbDescripcion.TabIndex = 16
        Me.lbDescripcion.Text = "Descripción:"
        '
        'lbFamilia
        '
        Me.lbFamilia.AutoSize = True
        Me.lbFamilia.ForeColor = System.Drawing.Color.White
        Me.lbFamilia.Location = New System.Drawing.Point(4, 102)
        Me.lbFamilia.Name = "lbFamilia"
        Me.lbFamilia.Size = New System.Drawing.Size(43, 13)
        Me.lbFamilia.TabIndex = 15
        Me.lbFamilia.Text = "Familia:"
        '
        'cbFamilia
        '
        Me.cbFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFamilia.DataSource = Me.bsFamilia
        Me.cbFamilia.DisplayMember = "Familia"
        Me.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFamilia.FormattingEnabled = True
        Me.cbFamilia.Location = New System.Drawing.Point(4, 119)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(220, 21)
        Me.cbFamilia.TabIndex = 14
        Me.cbFamilia.ValueMember = "Id"
        '
        'bsFamilia
        '
        Me.bsFamilia.DataMember = "Familia"
        Me.bsFamilia.DataSource = Me.DtsKardex
        '
        'DtsKardex
        '
        Me.DtsKardex.DataSetName = "dtsKardex"
        Me.DtsKardex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btVer
        '
        Me.btVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btVer.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.search
        Me.btVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btVer.FlatAppearance.BorderSize = 0
        Me.btVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVer.Location = New System.Drawing.Point(92, 299)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(25, 25)
        Me.btVer.TabIndex = 13
        Me.btVer.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Location = New System.Drawing.Point(154, 65)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(71, 21)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbComparacion
        '
        Me.cbComparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComparacion.FormattingEnabled = True
        Me.cbComparacion.Items.AddRange(New Object() {"<>", ">=", "<=", "=", ">", "<", "Any"})
        Me.cbComparacion.Location = New System.Drawing.Point(69, 65)
        Me.cbComparacion.Name = "cbComparacion"
        Me.cbComparacion.Size = New System.Drawing.Size(79, 21)
        Me.cbComparacion.TabIndex = 4
        '
        'lbExistencia
        '
        Me.lbExistencia.AutoSize = True
        Me.lbExistencia.ForeColor = System.Drawing.Color.White
        Me.lbExistencia.Location = New System.Drawing.Point(4, 65)
        Me.lbExistencia.Name = "lbExistencia"
        Me.lbExistencia.Size = New System.Drawing.Size(59, 13)
        Me.lbExistencia.TabIndex = 3
        Me.lbExistencia.Text = "Existencia:"
        '
        'lbBodega
        '
        Me.lbBodega.AutoSize = True
        Me.lbBodega.ForeColor = System.Drawing.Color.White
        Me.lbBodega.Location = New System.Drawing.Point(4, 8)
        Me.lbBodega.Name = "lbBodega"
        Me.lbBodega.Size = New System.Drawing.Size(47, 13)
        Me.lbBodega.TabIndex = 2
        Me.lbBodega.Text = "Bodega:"
        '
        'cbBodega
        '
        Me.cbBodega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodega.DataSource = Me.bsBodega
        Me.cbBodega.DisplayMember = "Bodega"
        Me.cbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodega.FormattingEnabled = True
        Me.cbBodega.Location = New System.Drawing.Point(4, 26)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(220, 21)
        Me.cbBodega.TabIndex = 1
        Me.cbBodega.ValueMember = "IdBodega"
        '
        'bsBodega
        '
        Me.bsBodega.DataMember = "Bodega"
        Me.bsBodega.DataSource = Me.DtsKardex
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(656, 395)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'pb
        '
        Me.pb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb.ForeColor = System.Drawing.Color.RoyalBlue
        Me.pb.Location = New System.Drawing.Point(0, -1)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(903, 10)
        Me.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb.TabIndex = 11
        Me.pb.Visible = False
        '
        'cbReportes
        '
        Me.cbReportes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbReportes.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReportes.FormattingEnabled = True
        Me.cbReportes.Items.AddRange(New Object() {"INVENTARIO POR EXISTENCIA", "INVENTARIO POR DESCRIPCIÓN", "INVENTARIO POR FAMILIA RESUMIDO", "INVENTARIO POR FAMILIA", "INVENTARIO POR EXISTENCIA MAX", "INVENTARIO POR EXISTENCIA MIN"})
        Me.cbReportes.Location = New System.Drawing.Point(307, 12)
        Me.cbReportes.Name = "cbReportes"
        Me.cbReportes.Size = New System.Drawing.Size(291, 24)
        Me.cbReportes.TabIndex = 0
        '
        'bwProcesar
        '
        Me.bwProcesar.WorkerReportsProgress = True
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCerrar.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.close
        Me.btCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Location = New System.Drawing.Point(850, 13)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btCerrar.TabIndex = 6
        Me.btCerrar.UseVisualStyleBackColor = True
        '
        'btFiltro
        '
        Me.btFiltro.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.filter
        Me.btFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btFiltro.FlatAppearance.BorderSize = 0
        Me.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFiltro.Location = New System.Drawing.Point(4, 17)
        Me.btFiltro.Name = "btFiltro"
        Me.btFiltro.Size = New System.Drawing.Size(25, 25)
        Me.btFiltro.TabIndex = 7
        Me.btFiltro.Tag = "Select"
        Me.btFiltro.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btBuscar.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.search
        Me.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Location = New System.Drawing.Point(604, 12)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(25, 25)
        Me.btBuscar.TabIndex = 12
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btMax
        '
        Me.btMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMax.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.expand
        Me.btMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMax.FlatAppearance.BorderSize = 0
        Me.btMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMax.Location = New System.Drawing.Point(758, 13)
        Me.btMax.Name = "btMax"
        Me.btMax.Size = New System.Drawing.Size(40, 40)
        Me.btMax.TabIndex = 17
        Me.btMax.Tag = "OFF"
        Me.btMax.UseVisualStyleBackColor = True
        '
        'btMinimizar
        '
        Me.btMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMinimizar.BackgroundImage = Global.LcPymesKardex.My.Resources.Resources.minimize
        Me.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMinimizar.FlatAppearance.BorderSize = 0
        Me.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMinimizar.Location = New System.Drawing.Point(804, 13)
        Me.btMinimizar.Name = "btMinimizar"
        Me.btMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btMinimizar.TabIndex = 16
        Me.btMinimizar.UseVisualStyleBackColor = True
        '
        'bwCargarReporte
        '
        Me.bwCargarReporte.WorkerReportsProgress = True
        '
        'frmReportesInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(902, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.btMax)
        Me.Controls.Add(Me.btMinimizar)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.btFiltro)
        Me.Controls.Add(Me.dtpFechaExistencia)
        Me.Controls.Add(Me.sc)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.cbReportes)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportesInventario"
        Me.sc.Panel1.ResumeLayout(False)
        Me.sc.Panel2.ResumeLayout(False)
        CType(Me.sc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc.ResumeLayout(False)
        Me.pnFiltro.ResumeLayout(False)
        Me.pnFiltro.PerformLayout()
        CType(Me.bsFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sc As SplitContainer
    Friend WithEvents pnFiltro As Panel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cbComparacion As ComboBox
    Friend WithEvents lbExistencia As Label
    Friend WithEvents lbBodega As Label
    Friend WithEvents cbBodega As ComboBox
    Friend WithEvents cbReportes As ComboBox
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents bwProcesar As System.ComponentModel.BackgroundWorker
    Friend WithEvents pb As ProgressBar
    Friend WithEvents bsBodega As BindingSource
    Friend WithEvents DtsKardex As dtsKardex
    Friend WithEvents btCerrar As Button
    Friend WithEvents btFiltro As Button
    Friend WithEvents btVer As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents lbFamilia As Label
    Friend WithEvents cbFamilia As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents dtpFechaExistencia As DateTimePicker
    Friend WithEvents bsFamilia As BindingSource
    Friend WithEvents lbProveedor As Label
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents lbUbicacion As Label
    Friend WithEvents cbUbicacion As ComboBox
    Friend WithEvents btMax As Button
    Friend WithEvents btMinimizar As Button
    Friend WithEvents bwCargarReporte As System.ComponentModel.BackgroundWorker
End Class
