<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trabajadores
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
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim Fecha_de_nacimietnoLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbusquedaT = New System.Windows.Forms.TextBox()
        Me.btnañadirt = New System.Windows.Forms.Button()
        Me.btneditart = New System.Windows.Forms.Button()
        Me.btneliminart = New System.Windows.Forms.Button()
        Me.Database2000DataSet = New Tienda_deportiva.Database2000DataSet()
        Me.Trabajadores1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trabajadores1TableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.Trabajadores1TableAdapter()
        Me.TableAdapterManager = New Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager()
        Me.Trabajadores1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnbuscarT = New System.Windows.Forms.Button()
        Me.GBempleados = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelarT = New System.Windows.Forms.Button()
        Me.btnagregarT = New System.Windows.Forms.Button()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.TeléfonoTextBox = New System.Windows.Forms.TextBox()
        Me.FNDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CiudadLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        Fecha_de_nacimietnoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajadores1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajadores1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBempleados.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.BackColor = System.Drawing.Color.White
        CiudadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        CiudadLabel.Location = New System.Drawing.Point(43, 404)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(63, 20)
        CiudadLabel.TabIndex = 8
        CiudadLabel.Text = "Ciudad:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.BackColor = System.Drawing.Color.White
        TeléfonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TeléfonoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        TeléfonoLabel.Location = New System.Drawing.Point(43, 326)
        TeléfonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(75, 20)
        TeléfonoLabel.TabIndex = 6
        TeléfonoLabel.Text = "Teléfono:"
        '
        'Fecha_de_nacimietnoLabel
        '
        Fecha_de_nacimietnoLabel.AutoSize = True
        Fecha_de_nacimietnoLabel.BackColor = System.Drawing.Color.White
        Fecha_de_nacimietnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_de_nacimietnoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Fecha_de_nacimietnoLabel.Location = New System.Drawing.Point(43, 246)
        Fecha_de_nacimietnoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_de_nacimietnoLabel.Name = "Fecha_de_nacimietnoLabel"
        Fecha_de_nacimietnoLabel.Size = New System.Drawing.Size(161, 20)
        Fecha_de_nacimietnoLabel.TabIndex = 4
        Fecha_de_nacimietnoLabel.Text = "Fecha de nacimiento:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.BackColor = System.Drawing.Color.White
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        ApellidosLabel.Location = New System.Drawing.Point(43, 163)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(77, 20)
        ApellidosLabel.TabIndex = 2
        ApellidosLabel.Text = "Apellidos:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.White
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        NombreLabel.Location = New System.Drawing.Point(43, 84)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 42)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Trabajadores"
        '
        'txbusquedaT
        '
        Me.txbusquedaT.BackColor = System.Drawing.Color.White
        Me.txbusquedaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbusquedaT.Location = New System.Drawing.Point(673, 42)
        Me.txbusquedaT.Margin = New System.Windows.Forms.Padding(6)
        Me.txbusquedaT.Name = "txbusquedaT"
        Me.txbusquedaT.Size = New System.Drawing.Size(346, 28)
        Me.txbusquedaT.TabIndex = 26
        '
        'btnañadirt
        '
        Me.btnañadirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnañadirt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnañadirt.Location = New System.Drawing.Point(56, 97)
        Me.btnañadirt.Margin = New System.Windows.Forms.Padding(6)
        Me.btnañadirt.Name = "btnañadirt"
        Me.btnañadirt.Size = New System.Drawing.Size(180, 47)
        Me.btnañadirt.TabIndex = 44
        Me.btnañadirt.Text = "Añadir trabajador"
        Me.btnañadirt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnañadirt.UseVisualStyleBackColor = True
        '
        'btneditart
        '
        Me.btneditart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btneditart.Location = New System.Drawing.Point(266, 97)
        Me.btneditart.Margin = New System.Windows.Forms.Padding(6)
        Me.btneditart.Name = "btneditart"
        Me.btneditart.Size = New System.Drawing.Size(175, 47)
        Me.btneditart.TabIndex = 46
        Me.btneditart.Text = "Editar trabajador"
        Me.btneditart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditart.UseVisualStyleBackColor = True
        '
        'btneliminart
        '
        Me.btneliminart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btneliminart.Location = New System.Drawing.Point(474, 97)
        Me.btneliminart.Margin = New System.Windows.Forms.Padding(6)
        Me.btneliminart.Name = "btneliminart"
        Me.btneliminart.Size = New System.Drawing.Size(120, 47)
        Me.btneliminart.TabIndex = 47
        Me.btneliminart.Text = "Eliminar"
        Me.btneliminart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminart.UseVisualStyleBackColor = True
        '
        'Database2000DataSet
        '
        Me.Database2000DataSet.DataSetName = "Database2000DataSet"
        Me.Database2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Trabajadores1BindingSource
        '
        Me.Trabajadores1BindingSource.DataMember = "Trabajadores1"
        Me.Trabajadores1BindingSource.DataSource = Me.Database2000DataSet
        '
        'Trabajadores1TableAdapter
        '
        Me.Trabajadores1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.F_PTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.Trabajadores1TableAdapter = Me.Trabajadores1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Trabajadores1DataGridView
        '
        Me.Trabajadores1DataGridView.AutoGenerateColumns = False
        Me.Trabajadores1DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Trabajadores1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Trabajadores1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Trabajadores1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Trabajadores1DataGridView.DataSource = Me.Trabajadores1BindingSource
        Me.Trabajadores1DataGridView.Location = New System.Drawing.Point(44, 164)
        Me.Trabajadores1DataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Trabajadores1DataGridView.Name = "Trabajadores1DataGridView"
        Me.Trabajadores1DataGridView.RowHeadersWidth = 51
        Me.Trabajadores1DataGridView.RowTemplate.Height = 24
        Me.Trabajadores1DataGridView.Size = New System.Drawing.Size(874, 934)
        Me.Trabajadores1DataGridView.TabIndex = 73
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha de nacimietno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha de nacimiento"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'btnbuscarT
        '
        Me.btnbuscarT.BackgroundImage = Global.Tienda_deportiva.My.Resources.Resources.iconobuscar
        Me.btnbuscarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarT.Location = New System.Drawing.Point(1023, 45)
        Me.btnbuscarT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbuscarT.Name = "btnbuscarT"
        Me.btnbuscarT.Size = New System.Drawing.Size(30, 30)
        Me.btnbuscarT.TabIndex = 76
        Me.btnbuscarT.UseVisualStyleBackColor = True
        '
        'GBempleados
        '
        Me.GBempleados.BackColor = System.Drawing.Color.Gainsboro
        Me.GBempleados.BackgroundImage = Global.Tienda_deportiva.My.Resources.Resources.Diseño_sin_título
        Me.GBempleados.Controls.Add(Me.Label1)
        Me.GBempleados.Controls.Add(Me.btncancelarT)
        Me.GBempleados.Controls.Add(Me.btnagregarT)
        Me.GBempleados.Controls.Add(CiudadLabel)
        Me.GBempleados.Controls.Add(Me.CiudadTextBox)
        Me.GBempleados.Controls.Add(TeléfonoLabel)
        Me.GBempleados.Controls.Add(Me.TeléfonoTextBox)
        Me.GBempleados.Controls.Add(Fecha_de_nacimietnoLabel)
        Me.GBempleados.Controls.Add(Me.FNDateTimePicker)
        Me.GBempleados.Controls.Add(ApellidosLabel)
        Me.GBempleados.Controls.Add(Me.ApellidosTextBox)
        Me.GBempleados.Controls.Add(NombreLabel)
        Me.GBempleados.Controls.Add(Me.NombreTextBox)
        Me.GBempleados.Location = New System.Drawing.Point(631, 164)
        Me.GBempleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBempleados.Name = "GBempleados"
        Me.GBempleados.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBempleados.Size = New System.Drawing.Size(422, 563)
        Me.GBempleados.TabIndex = 74
        Me.GBempleados.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 42)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Trabajador"
        '
        'btncancelarT
        '
        Me.btncancelarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btncancelarT.Location = New System.Drawing.Point(210, 493)
        Me.btncancelarT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncancelarT.Name = "btncancelarT"
        Me.btncancelarT.Size = New System.Drawing.Size(155, 46)
        Me.btncancelarT.TabIndex = 11
        Me.btncancelarT.Text = "Cancelar"
        Me.btncancelarT.UseVisualStyleBackColor = True
        '
        'btnagregarT
        '
        Me.btnagregarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnagregarT.Location = New System.Drawing.Point(51, 493)
        Me.btnagregarT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnagregarT.Name = "btnagregarT"
        Me.btnagregarT.Size = New System.Drawing.Size(145, 46)
        Me.btnagregarT.TabIndex = 10
        Me.btnagregarT.Text = "Agregar"
        Me.btnagregarT.UseVisualStyleBackColor = True
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Ciudad", True))
        Me.CiudadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CiudadTextBox.Location = New System.Drawing.Point(47, 429)
        Me.CiudadTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(323, 26)
        Me.CiudadTextBox.TabIndex = 9
        '
        'TeléfonoTextBox
        '
        Me.TeléfonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Teléfono", True))
        Me.TeléfonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TeléfonoTextBox.Location = New System.Drawing.Point(48, 356)
        Me.TeléfonoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TeléfonoTextBox.Name = "TeléfonoTextBox"
        Me.TeléfonoTextBox.Size = New System.Drawing.Size(323, 26)
        Me.TeléfonoTextBox.TabIndex = 7
        '
        'FNDateTimePicker
        '
        Me.FNDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Trabajadores1BindingSource, "Fecha de nacimietno", True))
        Me.FNDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FNDateTimePicker.Location = New System.Drawing.Point(48, 276)
        Me.FNDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FNDateTimePicker.Name = "FNDateTimePicker"
        Me.FNDateTimePicker.Size = New System.Drawing.Size(323, 23)
        Me.FNDateTimePicker.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ApellidosTextBox.Location = New System.Drawing.Point(48, 193)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(323, 26)
        Me.ApellidosTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Trabajadores1BindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(48, 114)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(323, 26)
        Me.NombreTextBox.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Tienda_deportiva.My.Resources.Resources.eliminar_1_
        Me.PictureBox5.Location = New System.Drawing.Point(491, 106)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Tienda_deportiva.My.Resources.Resources.boligrafo
        Me.PictureBox4.Location = New System.Drawing.Point(277, 106)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tienda_deportiva.My.Resources.Resources.agregar
        Me.PictureBox2.Location = New System.Drawing.Point(65, 106)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'Trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 736)
        Me.Controls.Add(Me.btnbuscarT)
        Me.Controls.Add(Me.GBempleados)
        Me.Controls.Add(Me.Trabajadores1DataGridView)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnañadirt)
        Me.Controls.Add(Me.btneditart)
        Me.Controls.Add(Me.btneliminart)
        Me.Controls.Add(Me.txbusquedaT)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Trabajadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trabajadores"
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajadores1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajadores1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBempleados.ResumeLayout(False)
        Me.GBempleados.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txbusquedaT As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnañadirt As Button
    Friend WithEvents btneditart As Button
    Friend WithEvents btneliminart As Button
    Friend WithEvents Database2000DataSet As Database2000DataSet
    Friend WithEvents Trabajadores1BindingSource As BindingSource
    Friend WithEvents Trabajadores1TableAdapter As Database2000DataSetTableAdapters.Trabajadores1TableAdapter
    Friend WithEvents TableAdapterManager As Database2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Trabajadores1DataGridView As DataGridView
    Friend WithEvents GBempleados As GroupBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents TeléfonoTextBox As TextBox
    Friend WithEvents FNDateTimePicker As DateTimePicker
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents btncancelarT As Button
    Friend WithEvents btnagregarT As Button
    Friend WithEvents btnbuscarT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
