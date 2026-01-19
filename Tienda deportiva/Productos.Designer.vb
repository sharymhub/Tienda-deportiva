<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim Stock_disponibleLabel As System.Windows.Forms.Label
        Dim EmpresaLabel1 As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbusquedaP = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btneditarP = New System.Windows.Forms.Button()
        Me.btneliminarp = New System.Windows.Forms.Button()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2000DataSet = New Tienda_deportiva.Database2000DataSet()
        Me.GBproductos = New System.Windows.Forms.GroupBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stock_disponibleTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripciónTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.BtncancelarP = New System.Windows.Forms.Button()
        Me.btnagregarP = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnbuscarP = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProveedoresTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.ProveedoresTableAdapter()
        Me.EmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NombreLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        DescripciónLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        Stock_disponibleLabel = New System.Windows.Forms.Label()
        EmpresaLabel1 = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBproductos.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.White
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        NombreLabel.Location = New System.Drawing.Point(63, 114)
        NombreLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(84, 24)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.White
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        MarcaLabel.Location = New System.Drawing.Point(79, 164)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(67, 24)
        MarcaLabel.TabIndex = 4
        MarcaLabel.Text = "Marca:"
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.BackColor = System.Drawing.Color.White
        DescripciónLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripciónLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        DescripciónLabel.Location = New System.Drawing.Point(32, 211)
        DescripciónLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(115, 24)
        DescripciónLabel.TabIndex = 6
        DescripciónLabel.Text = "Descripción:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.BackColor = System.Drawing.Color.White
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        PrecioLabel.Location = New System.Drawing.Point(78, 294)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(69, 24)
        PrecioLabel.TabIndex = 8
        PrecioLabel.Text = "Precio:"
        '
        'Stock_disponibleLabel
        '
        Stock_disponibleLabel.AutoSize = True
        Stock_disponibleLabel.BackColor = System.Drawing.Color.White
        Stock_disponibleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stock_disponibleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Stock_disponibleLabel.Location = New System.Drawing.Point(86, 343)
        Stock_disponibleLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Stock_disponibleLabel.Name = "Stock_disponibleLabel"
        Stock_disponibleLabel.Size = New System.Drawing.Size(61, 24)
        Stock_disponibleLabel.TabIndex = 10
        Stock_disponibleLabel.Text = "Stock:"
        Stock_disponibleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EmpresaLabel1
        '
        EmpresaLabel1.AutoSize = True
        EmpresaLabel1.BackColor = System.Drawing.Color.White
        EmpresaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpresaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        EmpresaLabel1.Location = New System.Drawing.Point(56, 389)
        EmpresaLabel1.Name = "EmpresaLabel1"
        EmpresaLabel1.Size = New System.Drawing.Size(91, 24)
        EmpresaLabel1.TabIndex = 76
        EmpresaLabel1.Text = "Empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 42)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Productos"
        '
        'txbusquedaP
        '
        Me.txbusquedaP.BackColor = System.Drawing.Color.White
        Me.txbusquedaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbusquedaP.Location = New System.Drawing.Point(634, 21)
        Me.txbusquedaP.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txbusquedaP.Name = "txbusquedaP"
        Me.txbusquedaP.Size = New System.Drawing.Size(346, 24)
        Me.txbusquedaP.TabIndex = 18
        Me.txbusquedaP.Text = "Buscar por nombre o marca . . ."
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(67, 102)
        Me.Button8.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(168, 47)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Añadir producto"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btneditarP
        '
        Me.btneditarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btneditarP.Location = New System.Drawing.Point(273, 102)
        Me.btneditarP.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btneditarP.Name = "btneditarP"
        Me.btneditarP.Size = New System.Drawing.Size(173, 47)
        Me.btneditarP.TabIndex = 46
        Me.btneditarP.Text = "Editar producto"
        Me.btneditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditarP.UseVisualStyleBackColor = True
        '
        'btneliminarp
        '
        Me.btneliminarp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btneliminarp.Location = New System.Drawing.Point(471, 102)
        Me.btneliminarp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btneliminarp.Name = "btneliminarp"
        Me.btneliminarp.Size = New System.Drawing.Size(173, 47)
        Me.btneliminarp.TabIndex = 47
        Me.btneliminarp.Text = "Eliminar"
        Me.btneliminarp.UseVisualStyleBackColor = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Database2000DataSet
        '
        'Database2000DataSet
        '
        Me.Database2000DataSet.DataSetName = "Database2000DataSet"
        Me.Database2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GBproductos
        '
        Me.GBproductos.BackColor = System.Drawing.SystemColors.Control
        Me.GBproductos.BackgroundImage = Global.Tienda_deportiva.My.Resources.Resources.Diseño_sin_título
        Me.GBproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBproductos.Controls.Add(Me.EmpresaComboBox)
        Me.GBproductos.Controls.Add(EmpresaLabel1)
        Me.GBproductos.Controls.Add(Me.Label1)
        Me.GBproductos.Controls.Add(Stock_disponibleLabel)
        Me.GBproductos.Controls.Add(Me.Stock_disponibleTextBox)
        Me.GBproductos.Controls.Add(PrecioLabel)
        Me.GBproductos.Controls.Add(Me.PrecioTextBox)
        Me.GBproductos.Controls.Add(DescripciónLabel)
        Me.GBproductos.Controls.Add(Me.DescripciónTextBox)
        Me.GBproductos.Controls.Add(MarcaLabel)
        Me.GBproductos.Controls.Add(Me.MarcaTextBox)
        Me.GBproductos.Controls.Add(NombreLabel)
        Me.GBproductos.Controls.Add(Me.NombreTextBox)
        Me.GBproductos.Controls.Add(Me.BtncancelarP)
        Me.GBproductos.Controls.Add(Me.btnagregarP)
        Me.GBproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBproductos.Location = New System.Drawing.Point(636, 208)
        Me.GBproductos.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GBproductos.Name = "GBproductos"
        Me.GBproductos.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GBproductos.Size = New System.Drawing.Size(446, 527)
        Me.GBproductos.TabIndex = 74
        Me.GBproductos.TabStop = False
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.Database2000DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 42)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Nuevo producto"
        '
        'Stock_disponibleTextBox
        '
        Me.Stock_disponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Stock disponible", True))
        Me.Stock_disponibleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock_disponibleTextBox.Location = New System.Drawing.Point(149, 340)
        Me.Stock_disponibleTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Stock_disponibleTextBox.Name = "Stock_disponibleTextBox"
        Me.Stock_disponibleTextBox.Size = New System.Drawing.Size(237, 29)
        Me.Stock_disponibleTextBox.TabIndex = 11
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(149, 291)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(237, 29)
        Me.PrecioTextBox.TabIndex = 9
        '
        'DescripciónTextBox
        '
        Me.DescripciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripción", True))
        Me.DescripciónTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripciónTextBox.Location = New System.Drawing.Point(149, 209)
        Me.DescripciónTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DescripciónTextBox.Multiline = True
        Me.DescripciónTextBox.Name = "DescripciónTextBox"
        Me.DescripciónTextBox.Size = New System.Drawing.Size(237, 69)
        Me.DescripciónTextBox.TabIndex = 7
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Marca", True))
        Me.MarcaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaTextBox.Location = New System.Drawing.Point(149, 163)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(237, 29)
        Me.MarcaTextBox.TabIndex = 5
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(149, 111)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(237, 29)
        Me.NombreTextBox.TabIndex = 3
        '
        'BtncancelarP
        '
        Me.BtncancelarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtncancelarP.Location = New System.Drawing.Point(230, 445)
        Me.BtncancelarP.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtncancelarP.Name = "BtncancelarP"
        Me.BtncancelarP.Size = New System.Drawing.Size(140, 41)
        Me.BtncancelarP.TabIndex = 1
        Me.BtncancelarP.Text = "Cancelar"
        Me.BtncancelarP.UseVisualStyleBackColor = True
        '
        'btnagregarP
        '
        Me.btnagregarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnagregarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarP.ForeColor = System.Drawing.Color.White
        Me.btnagregarP.Location = New System.Drawing.Point(71, 445)
        Me.btnagregarP.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnagregarP.Name = "btnagregarP"
        Me.btnagregarP.Size = New System.Drawing.Size(140, 41)
        Me.btnagregarP.TabIndex = 0
        Me.btnagregarP.Text = "Agregar"
        Me.btnagregarP.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Tienda_deportiva.My.Resources.Resources.eliminar_1_
        Me.PictureBox5.Location = New System.Drawing.Point(486, 110)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Tienda_deportiva.My.Resources.Resources.boligrafo
        Me.PictureBox4.Location = New System.Drawing.Point(282, 110)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tienda_deportiva.My.Resources.Resources.agregar
        Me.PictureBox2.Location = New System.Drawing.Point(80, 110)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'btnbuscarP
        '
        Me.btnbuscarP.BackgroundImage = Global.Tienda_deportiva.My.Resources.Resources.iconobuscar
        Me.btnbuscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarP.Location = New System.Drawing.Point(596, 21)
        Me.btnbuscarP.Name = "btnbuscarP"
        Me.btnbuscarP.Size = New System.Drawing.Size(30, 30)
        Me.btnbuscarP.TabIndex = 75
        Me.btnbuscarP.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.F_PTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.Trabajadores1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(42, 160)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(938, 546)
        Me.ProductosDataGridView.TabIndex = 75
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'EmpresaComboBox
        '
        Me.EmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Empresa", True))
        Me.EmpresaComboBox.FormattingEnabled = True
        Me.EmpresaComboBox.Location = New System.Drawing.Point(149, 385)
        Me.EmpresaComboBox.Name = "EmpresaComboBox"
        Me.EmpresaComboBox.Size = New System.Drawing.Size(237, 28)
        Me.EmpresaComboBox.TabIndex = 77
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Empresa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Stock disponible"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock disponible"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripción"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1102, 755)
        Me.Controls.Add(Me.GBproductos)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.btnbuscarP)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btneditarP)
        Me.Controls.Add(Me.btneliminarp)
        Me.Controls.Add(Me.txbusquedaP)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBproductos.ResumeLayout(False)
        Me.GBproductos.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txbusquedaP As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents btneditarP As Button
    Friend WithEvents btneliminarp As Button
    Friend WithEvents Database2000DataSet As Database2000DataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As Database2000DataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As Database2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GBproductos As GroupBox
    Friend WithEvents BtncancelarP As Button
    Friend WithEvents btnagregarP As Button
    Friend WithEvents Stock_disponibleTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents DescripciónTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents btnbuscarP As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As Database2000DataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents EmpresaComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
