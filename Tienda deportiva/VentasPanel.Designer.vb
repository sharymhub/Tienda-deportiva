<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentasPanel
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
        Dim CédulaLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidosLabel1 As System.Windows.Forms.Label
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasPanel))
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Btnguardarcliente = New System.Windows.Forms.Button()
        Me.Forma_de_pagoComboBox = New System.Windows.Forms.ComboBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2000DataSet = New Tienda_deportiva.Database2000DataSet()
        Me.CódigoComboBox = New System.Windows.Forms.ComboBox()
        Me.Trabajadores1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApellidosTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBdatagrid = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RBnombre = New System.Windows.Forms.RadioButton()
        Me.RBcodigo = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtbuscador = New System.Windows.Forms.TextBox()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnguardaarV = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Labelcambio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Lbtotal = New System.Windows.Forms.Label()
        Me.LbIVA = New System.Windows.Forms.Label()
        Me.LbTotalpagar = New System.Windows.Forms.Label()
        Me.Txtpagorecibido = New System.Windows.Forms.TextBox()
        Me.LbCambio = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.ProductosTableAdapter()
        Me.Trabajadores1TableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.Trabajadores1TableAdapter()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.FacturasTableAdapter()
        Me.VentasTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.VentasTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CédulaLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidosLabel1 = New System.Windows.Forms.Label()
        CódigoLabel = New System.Windows.Forms.Label()
        Me.GBdatos.SuspendLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajadores1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBdatagrid.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CédulaLabel
        '
        CédulaLabel.AutoSize = True
        CédulaLabel.Location = New System.Drawing.Point(27, 63)
        CédulaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CédulaLabel.Name = "CédulaLabel"
        CédulaLabel.Size = New System.Drawing.Size(63, 20)
        CédulaLabel.TabIndex = 0
        CédulaLabel.Text = "Cédula:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(18, 103)
        NombresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(77, 20)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(18, 142)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(77, 20)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Apellidos:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Location = New System.Drawing.Point(18, 181)
        TeléfonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(75, 20)
        TeléfonoLabel.TabIndex = 6
        TeléfonoLabel.Text = "Teléfono:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(30, 305)
        NombreLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(69, 20)
        NombreLabel1.TabIndex = 10
        NombreLabel1.Text = "Nombre:"
        '
        'ApellidosLabel1
        '
        ApellidosLabel1.AutoSize = True
        ApellidosLabel1.Location = New System.Drawing.Point(30, 347)
        ApellidosLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel1.Name = "ApellidosLabel1"
        ApellidosLabel1.Size = New System.Drawing.Size(77, 20)
        ApellidosLabel1.TabIndex = 16
        ApellidosLabel1.Text = "Apellidos:"
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(30, 263)
        CódigoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(63, 20)
        CódigoLabel.TabIndex = 17
        CódigoLabel.Text = "Código:"
        '
        'GBdatos
        '
        Me.GBdatos.Controls.Add(Me.TextBoxTelefono)
        Me.GBdatos.Controls.Add(Me.TextBoxApellido)
        Me.GBdatos.Controls.Add(Me.TextBoxNombre)
        Me.GBdatos.Controls.Add(Me.TxtCedula)
        Me.GBdatos.Controls.Add(Me.Btnguardarcliente)
        Me.GBdatos.Controls.Add(Me.Forma_de_pagoComboBox)
        Me.GBdatos.Controls.Add(CódigoLabel)
        Me.GBdatos.Controls.Add(Me.CódigoComboBox)
        Me.GBdatos.Controls.Add(ApellidosLabel1)
        Me.GBdatos.Controls.Add(Me.ApellidosTextBox1)
        Me.GBdatos.Controls.Add(Me.Label4)
        Me.GBdatos.Controls.Add(NombreLabel1)
        Me.GBdatos.Controls.Add(Me.NombreTextBox1)
        Me.GBdatos.Controls.Add(Me.Label2)
        Me.GBdatos.Controls.Add(Me.Label1)
        Me.GBdatos.Controls.Add(CédulaLabel)
        Me.GBdatos.Controls.Add(NombresLabel)
        Me.GBdatos.Controls.Add(ApellidosLabel)
        Me.GBdatos.Controls.Add(TeléfonoLabel)
        Me.GBdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBdatos.Location = New System.Drawing.Point(18, 9)
        Me.GBdatos.Margin = New System.Windows.Forms.Padding(4)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Padding = New System.Windows.Forms.Padding(4)
        Me.GBdatos.Size = New System.Drawing.Size(355, 453)
        Me.GBdatos.TabIndex = 0
        Me.GBdatos.TabStop = False
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(111, 175)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(222, 26)
        Me.TextBoxTelefono.TabIndex = 41
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(111, 138)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(222, 26)
        Me.TextBoxApellido.TabIndex = 40
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(111, 98)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(222, 26)
        Me.TextBoxNombre.TabIndex = 39
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(111, 60)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(222, 26)
        Me.TxtCedula.TabIndex = 38
        '
        'Btnguardarcliente
        '
        Me.Btnguardarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnguardarcliente.Location = New System.Drawing.Point(257, 16)
        Me.Btnguardarcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnguardarcliente.Name = "Btnguardarcliente"
        Me.Btnguardarcliente.Size = New System.Drawing.Size(90, 35)
        Me.Btnguardarcliente.TabIndex = 37
        Me.Btnguardarcliente.Text = "Guardar"
        Me.Btnguardarcliente.UseVisualStyleBackColor = True
        '
        'Forma_de_pagoComboBox
        '
        Me.Forma_de_pagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Forma de pago", True))
        Me.Forma_de_pagoComboBox.FormattingEnabled = True
        Me.Forma_de_pagoComboBox.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.Forma_de_pagoComboBox.Location = New System.Drawing.Point(31, 414)
        Me.Forma_de_pagoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Forma_de_pagoComboBox.Name = "Forma_de_pagoComboBox"
        Me.Forma_de_pagoComboBox.Size = New System.Drawing.Size(301, 28)
        Me.Forma_de_pagoComboBox.TabIndex = 19
        Me.Forma_de_pagoComboBox.Text = "- Seleccione -"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.Database2000DataSet
        '
        'Database2000DataSet
        '
        Me.Database2000DataSet.DataSetName = "Database2000DataSet"
        Me.Database2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CódigoComboBox
        '
        Me.CódigoComboBox.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CódigoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Código", True))
        Me.CódigoComboBox.FormattingEnabled = True
        Me.CódigoComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CódigoComboBox.Location = New System.Drawing.Point(111, 259)
        Me.CódigoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CódigoComboBox.Name = "CódigoComboBox"
        Me.CódigoComboBox.Size = New System.Drawing.Size(180, 28)
        Me.CódigoComboBox.TabIndex = 18
        '
        'Trabajadores1BindingSource
        '
        Me.Trabajadores1BindingSource.DataMember = "Trabajadores1"
        Me.Trabajadores1BindingSource.DataSource = Me.Database2000DataSet
        '
        'ApellidosTextBox1
        '
        Me.ApellidosTextBox1.BackColor = System.Drawing.Color.White
        Me.ApellidosTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Apellidos", True))
        Me.ApellidosTextBox1.Enabled = False
        Me.ApellidosTextBox1.Location = New System.Drawing.Point(111, 343)
        Me.ApellidosTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidosTextBox1.Name = "ApellidosTextBox1"
        Me.ApellidosTextBox1.Size = New System.Drawing.Size(222, 26)
        Me.ApellidosTextBox1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 384)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Método de pago:"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.BackColor = System.Drawing.Color.White
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Nombre", True))
        Me.NombreTextBox1.Enabled = False
        Me.NombreTextBox1.Location = New System.Drawing.Point(111, 302)
        Me.NombreTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(222, 26)
        Me.NombreTextBox1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Empleado a cargo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Datos cliente:"
        '
        'GBdatagrid
        '
        Me.GBdatagrid.Controls.Add(Me.Button3)
        Me.GBdatagrid.Controls.Add(Me.Label10)
        Me.GBdatagrid.Controls.Add(Me.TextBoxCantidad)
        Me.GBdatagrid.Controls.Add(Me.ProductosDataGridView)
        Me.GBdatagrid.Controls.Add(Me.RBnombre)
        Me.GBdatagrid.Controls.Add(Me.RBcodigo)
        Me.GBdatagrid.Controls.Add(Me.Button2)
        Me.GBdatagrid.Controls.Add(Me.Button1)
        Me.GBdatagrid.Controls.Add(Me.Label3)
        Me.GBdatagrid.Controls.Add(Me.Txtbuscador)
        Me.GBdatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBdatagrid.Location = New System.Drawing.Point(394, 13)
        Me.GBdatagrid.Margin = New System.Windows.Forms.Padding(4)
        Me.GBdatagrid.Name = "GBdatagrid"
        Me.GBdatagrid.Padding = New System.Windows.Forms.Padding(4)
        Me.GBdatagrid.Size = New System.Drawing.Size(654, 449)
        Me.GBdatagrid.TabIndex = 28
        Me.GBdatagrid.TabStop = False
        Me.GBdatagrid.Text = "LISTA PRODUCTOS"
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(512, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 50)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Codigo de barras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.White
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(584, 703)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 24)
        Me.lblFecha.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(535, 135)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Cantidad:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(539, 159)
        Me.TextBoxCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxCantidad.TabIndex = 35
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(40, 132)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowHeadersWidth = 51
        Me.ProductosDataGridView.Size = New System.Drawing.Size(473, 242)
        Me.ProductosDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 84
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Stock disponible"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock disponible"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 151
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Database2000DataSet
        '
        'RBnombre
        '
        Me.RBnombre.AutoSize = True
        Me.RBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBnombre.Location = New System.Drawing.Point(231, 80)
        Me.RBnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.RBnombre.Name = "RBnombre"
        Me.RBnombre.Size = New System.Drawing.Size(109, 24)
        Me.RBnombre.TabIndex = 34
        Me.RBnombre.TabStop = True
        Me.RBnombre.Text = "Por nombre"
        Me.RBnombre.UseVisualStyleBackColor = True
        '
        'RBcodigo
        '
        Me.RBcodigo.AutoSize = True
        Me.RBcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBcodigo.Location = New System.Drawing.Point(40, 80)
        Me.RBcodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.RBcodigo.Name = "RBcodigo"
        Me.RBcodigo.Size = New System.Drawing.Size(102, 24)
        Me.RBcodigo.TabIndex = 33
        Me.RBcodigo.TabStop = True
        Me.RBcodigo.Text = "Por código"
        Me.RBcodigo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(327, 390)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 48)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(68, 390)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 48)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Buscador:"
        '
        'Txtbuscador
        '
        Me.Txtbuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txtbuscador.Location = New System.Drawing.Point(133, 43)
        Me.Txtbuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbuscador.Name = "Txtbuscador"
        Me.Txtbuscador.Size = New System.Drawing.Size(355, 26)
        Me.Txtbuscador.TabIndex = 29
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.PrecioUnidad, Me.PrecioTotal})
        Me.VentasDataGridView.Location = New System.Drawing.Point(18, 470)
        Me.VentasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.RowHeadersWidth = 51
        Me.VentasDataGridView.Size = New System.Drawing.Size(542, 251)
        Me.VentasDataGridView.TabIndex = 29
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 125
        '
        'PrecioUnidad
        '
        Me.PrecioUnidad.HeaderText = "Precio Unidad"
        Me.PrecioUnidad.MinimumWidth = 6
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.Width = 125
        '
        'PrecioTotal
        '
        Me.PrecioTotal.HeaderText = "Precio Total"
        Me.PrecioTotal.MinimumWidth = 6
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(575, 487)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total Venta :"
        '
        'btnguardaarV
        '
        Me.btnguardaarV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardaarV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardaarV.Location = New System.Drawing.Point(878, 526)
        Me.btnguardaarV.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardaarV.Name = "btnguardaarV"
        Me.btnguardaarV.Size = New System.Drawing.Size(170, 71)
        Me.btnguardaarV.TabIndex = 32
        Me.btnguardaarV.Text = "Guardar Venta"
        Me.btnguardaarV.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(878, 621)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 71)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Cancelar venta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(575, 533)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "IVA :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(575, 579)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 24)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total a pagar :"
        '
        'Labelcambio
        '
        Me.Labelcambio.AutoSize = True
        Me.Labelcambio.BackColor = System.Drawing.Color.White
        Me.Labelcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Labelcambio.Location = New System.Drawing.Point(575, 671)
        Me.Labelcambio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelcambio.Name = "Labelcambio"
        Me.Labelcambio.Size = New System.Drawing.Size(93, 24)
        Me.Labelcambio.TabIndex = 36
        Me.Labelcambio.Text = "Cambio :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(575, 625)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 24)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Pago recibido :"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Lbtotal
        '
        Me.Lbtotal.AutoSize = True
        Me.Lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbtotal.Location = New System.Drawing.Point(710, 491)
        Me.Lbtotal.Name = "Lbtotal"
        Me.Lbtotal.Size = New System.Drawing.Size(49, 20)
        Me.Lbtotal.TabIndex = 38
        Me.Lbtotal.Text = "0000"
        '
        'LbIVA
        '
        Me.LbIVA.AutoSize = True
        Me.LbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIVA.Location = New System.Drawing.Point(644, 536)
        Me.LbIVA.Name = "LbIVA"
        Me.LbIVA.Size = New System.Drawing.Size(49, 20)
        Me.LbIVA.TabIndex = 39
        Me.LbIVA.Text = "0000"
        '
        'LbTotalpagar
        '
        Me.LbTotalpagar.AutoSize = True
        Me.LbTotalpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalpagar.Location = New System.Drawing.Point(728, 583)
        Me.LbTotalpagar.Name = "LbTotalpagar"
        Me.LbTotalpagar.Size = New System.Drawing.Size(49, 20)
        Me.LbTotalpagar.TabIndex = 40
        Me.LbTotalpagar.Text = "0000"
        '
        'Txtpagorecibido
        '
        Me.Txtpagorecibido.Location = New System.Drawing.Point(730, 627)
        Me.Txtpagorecibido.Name = "Txtpagorecibido"
        Me.Txtpagorecibido.Size = New System.Drawing.Size(127, 22)
        Me.Txtpagorecibido.TabIndex = 41
        '
        'LbCambio
        '
        Me.LbCambio.AutoSize = True
        Me.LbCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCambio.Location = New System.Drawing.Point(683, 674)
        Me.LbCambio.Name = "LbCambio"
        Me.LbCambio.Size = New System.Drawing.Size(49, 20)
        Me.LbCambio.TabIndex = 42
        Me.LbCambio.Text = "0000"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Database2000DataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.F_PTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.Trabajadores1TableAdapter = Me.Trabajadores1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Trabajadores1TableAdapter
        '
        Me.Trabajadores1TableAdapter.ClearBeforeFill = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.Database2000DataSet
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(713, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(629, 536)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 20)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(668, 675)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "$"
        '
        'VentasPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 736)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.LbCambio)
        Me.Controls.Add(Me.Txtpagorecibido)
        Me.Controls.Add(Me.LbTotalpagar)
        Me.Controls.Add(Me.LbIVA)
        Me.Controls.Add(Me.Lbtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Labelcambio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnguardaarV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.GBdatagrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VentasPanel"
        Me.Text = "VentasPanel"
        Me.GBdatos.ResumeLayout(False)
        Me.GBdatos.PerformLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajadores1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBdatagrid.ResumeLayout(False)
        Me.GBdatagrid.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents Database2000DataSet As Database2000DataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Database2000DataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Database2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductosTableAdapter As Database2000DataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Trabajadores1TableAdapter As Database2000DataSetTableAdapters.Trabajadores1TableAdapter
    Friend WithEvents Trabajadores1BindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents GBdatagrid As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtbuscador As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RBnombre As RadioButton
    Friend WithEvents RBcodigo As RadioButton
    Friend WithEvents ApellidosTextBox1 As TextBox
    Friend WithEvents CódigoComboBox As ComboBox
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As Database2000DataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnguardaarV As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Labelcambio As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As Database2000DataSetTableAdapters.VentasTableAdapter
    Friend WithEvents Forma_de_pagoComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Lbtotal As Label
    Friend WithEvents LbIVA As Label
    Friend WithEvents LbTotalpagar As Label
    Friend WithEvents Txtpagorecibido As TextBox
    Friend WithEvents LbCambio As Label
    Friend WithEvents Btnguardarcliente As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lblFecha As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
End Class
