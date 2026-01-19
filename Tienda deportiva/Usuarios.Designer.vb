<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim RolLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Database2000DataSet = New Tienda_deportiva.Database2000DataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBUsuarios = New System.Windows.Forms.GroupBox()
        Me.RolComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelarT = New System.Windows.Forms.Button()
        Me.btnagregarT = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        CiudadLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        Fecha_de_nacimietnoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RolLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.BackColor = System.Drawing.Color.White
        CiudadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        CiudadLabel.Location = New System.Drawing.Point(43, 348)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(96, 20)
        CiudadLabel.TabIndex = 8
        CiudadLabel.Text = "Contraseña:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.BackColor = System.Drawing.Color.White
        TeléfonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TeléfonoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        TeléfonoLabel.Location = New System.Drawing.Point(43, 280)
        TeléfonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(68, 20)
        TeléfonoLabel.TabIndex = 6
        TeléfonoLabel.Text = "Usuario:"
        '
        'Fecha_de_nacimietnoLabel
        '
        Fecha_de_nacimietnoLabel.AutoSize = True
        Fecha_de_nacimietnoLabel.BackColor = System.Drawing.Color.White
        Fecha_de_nacimietnoLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Correo Electronico", True))
        Fecha_de_nacimietnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_de_nacimietnoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Fecha_de_nacimietnoLabel.Location = New System.Drawing.Point(43, 216)
        Fecha_de_nacimietnoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_de_nacimietnoLabel.Name = "Fecha_de_nacimietnoLabel"
        Fecha_de_nacimietnoLabel.Size = New System.Drawing.Size(144, 20)
        Fecha_de_nacimietnoLabel.TabIndex = 4
        Fecha_de_nacimietnoLabel.Text = "Correo Electronico:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.BackColor = System.Drawing.Color.White
        ApellidosLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        ApellidosLabel.Location = New System.Drawing.Point(43, 149)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(75, 20)
        ApellidosLabel.TabIndex = 2
        ApellidosLabel.Text = "Telefono:"
        AddHandler ApellidosLabel.Click, AddressOf Me.ApellidosLabel_Click
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
        'RolLabel
        '
        RolLabel.AutoSize = True
        RolLabel.BackColor = System.Drawing.Color.White
        RolLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        RolLabel.Location = New System.Drawing.Point(50, 418)
        RolLabel.Name = "RolLabel"
        RolLabel.Size = New System.Drawing.Size(37, 20)
        RolLabel.TabIndex = 78
        RolLabel.Text = "Rol:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 42)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Usuarios"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(661, 39)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 31)
        Me.TextBox1.TabIndex = 30
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(67, 102)
        Me.Button8.Margin = New System.Windows.Forms.Padding(7)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(176, 47)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "Añadir usuario"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(280, 102)
        Me.Button9.Margin = New System.Windows.Forms.Padding(7)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(182, 47)
        Me.Button9.TabIndex = 39
        Me.Button9.Text = "Editar usuario"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(494, 102)
        Me.Button10.Margin = New System.Windows.Forms.Padding(7)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(171, 47)
        Me.Button10.TabIndex = 41
        Me.Button10.Text = "Eliminar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Tienda_deportiva.My.Resources.Resources.eliminar_1_
        Me.PictureBox5.Location = New System.Drawing.Point(511, 111)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Tienda_deportiva.My.Resources.Resources.boligrafo
        Me.PictureBox4.Location = New System.Drawing.Point(292, 111)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tienda_deportiva.My.Resources.Resources.agregar
        Me.PictureBox2.Location = New System.Drawing.Point(71, 111)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1014, 37)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'Database2000DataSet
        '
        Me.Database2000DataSet.DataSetName = "Database2000DataSet"
        Me.Database2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Database2000DataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.F_PTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.Trabajadores1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.UsuariosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(44, 174)
        Me.UsuariosDataGridView.Margin = New System.Windows.Forms.Padding(7)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.RowHeadersWidth = 51
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(984, 536)
        Me.UsuariosDataGridView.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Correo Electronico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 89
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 117
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Rol"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Rol"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 58
        '
        'GBUsuarios
        '
        Me.GBUsuarios.BackColor = System.Drawing.Color.Gainsboro
        Me.GBUsuarios.BackgroundImage = Global.Tienda_deportiva.My.Resources.Resources.Diseño_sin_título
        Me.GBUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBUsuarios.Controls.Add(Me.TelefonoTextBox)
        Me.GBUsuarios.Controls.Add(Me.ContraseñaTextBox1)
        Me.GBUsuarios.Controls.Add(Me.UsuarioTextBox)
        Me.GBUsuarios.Controls.Add(Me.Correo_ElectronicoTextBox)
        Me.GBUsuarios.Controls.Add(Me.NombreTextBox)
        Me.GBUsuarios.Controls.Add(RolLabel)
        Me.GBUsuarios.Controls.Add(Me.RolComboBox)
        Me.GBUsuarios.Controls.Add(Me.Label1)
        Me.GBUsuarios.Controls.Add(Me.btncancelarT)
        Me.GBUsuarios.Controls.Add(Me.btnagregarT)
        Me.GBUsuarios.Controls.Add(CiudadLabel)
        Me.GBUsuarios.Controls.Add(TeléfonoLabel)
        Me.GBUsuarios.Controls.Add(Fecha_de_nacimietnoLabel)
        Me.GBUsuarios.Controls.Add(ApellidosLabel)
        Me.GBUsuarios.Controls.Add(NombreLabel)
        Me.GBUsuarios.Location = New System.Drawing.Point(679, 184)
        Me.GBUsuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBUsuarios.Name = "GBUsuarios"
        Me.GBUsuarios.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBUsuarios.Size = New System.Drawing.Size(385, 538)
        Me.GBUsuarios.TabIndex = 75
        Me.GBUsuarios.TabStop = False
        '
        'RolComboBox
        '
        Me.RolComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Rol", True))
        Me.RolComboBox.FormattingEnabled = True
        Me.RolComboBox.Items.AddRange(New Object() {"Admin", "Empleado"})
        Me.RolComboBox.Location = New System.Drawing.Point(93, 415)
        Me.RolComboBox.Name = "RolComboBox"
        Me.RolComboBox.Size = New System.Drawing.Size(121, 28)
        Me.RolComboBox.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(86, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 42)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Usuarios"
        '
        'btncancelarT
        '
        Me.btncancelarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btncancelarT.Location = New System.Drawing.Point(197, 462)
        Me.btncancelarT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncancelarT.Name = "btncancelarT"
        Me.btncancelarT.Size = New System.Drawing.Size(155, 40)
        Me.btncancelarT.TabIndex = 11
        Me.btncancelarT.Text = "Cancelar"
        Me.btncancelarT.UseVisualStyleBackColor = True
        '
        'btnagregarT
        '
        Me.btnagregarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnagregarT.Location = New System.Drawing.Point(38, 462)
        Me.btnagregarT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnagregarT.Name = "btnagregarT"
        Me.btnagregarT.Size = New System.Drawing.Size(145, 40)
        Me.btnagregarT.TabIndex = 10
        Me.btnagregarT.Text = "Agregar"
        Me.btnagregarT.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(47, 107)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(285, 26)
        Me.NombreTextBox.TabIndex = 80
        '
        'Correo_ElectronicoTextBox
        '
        Me.Correo_ElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Correo Electronico", True))
        Me.Correo_ElectronicoTextBox.Location = New System.Drawing.Point(47, 239)
        Me.Correo_ElectronicoTextBox.Name = "Correo_ElectronicoTextBox"
        Me.Correo_ElectronicoTextBox.Size = New System.Drawing.Size(285, 26)
        Me.Correo_ElectronicoTextBox.TabIndex = 82
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(47, 303)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(285, 26)
        Me.UsuarioTextBox.TabIndex = 83
        '
        'ContraseñaTextBox1
        '
        Me.ContraseñaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox1.Location = New System.Drawing.Point(47, 371)
        Me.ContraseñaTextBox1.Name = "ContraseñaTextBox1"
        Me.ContraseñaTextBox1.Size = New System.Drawing.Size(285, 26)
        Me.ContraseñaTextBox1.TabIndex = 84
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(47, 172)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(285, 26)
        Me.TelefonoTextBox.TabIndex = 85
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 736)
        Me.Controls.Add(Me.GBUsuarios)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBUsuarios.ResumeLayout(False)
        Me.GBUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Database2000DataSet As Database2000DataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As Database2000DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As Database2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents GBUsuarios As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncancelarT As Button
    Friend WithEvents btnagregarT As Button
    Friend WithEvents RolComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaTextBox1 As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents Correo_ElectronicoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
End Class
