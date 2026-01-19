<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrClientes
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
        Dim CédulaLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Me.Database2000DataSet = New Tienda_deportiva.Database2000DataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Tienda_deportiva.Database2000DataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnañadirt = New System.Windows.Forms.Button()
        Me.btnagregarT = New System.Windows.Forms.Button()
        Me.CédulaTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TeléfonoTextBox = New System.Windows.Forms.TextBox()
        CédulaLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CédulaLabel
        '
        CédulaLabel.AutoSize = True
        CédulaLabel.Location = New System.Drawing.Point(771, 186)
        CédulaLabel.Name = "CédulaLabel"
        CédulaLabel.Size = New System.Drawing.Size(53, 16)
        CédulaLabel.TabIndex = 48
        CédulaLabel.Text = "Cédula:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(809, 270)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(66, 16)
        NombresLabel.TabIndex = 49
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(800, 328)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(67, 16)
        ApellidosLabel.TabIndex = 50
        ApellidosLabel.Text = "Apellidos:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Location = New System.Drawing.Point(818, 367)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(64, 16)
        TeléfonoLabel.TabIndex = 51
        TeléfonoLabel.Text = "Teléfono:"
        '
        'Database2000DataSet
        '
        Me.Database2000DataSet.DataSetName = "Database2000DataSet"
        Me.Database2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.Trabajadores1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tienda_deportiva.Database2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(62, 217)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.RowHeadersWidth = 51
        Me.ClientesDataGridView.RowTemplate.Height = 24
        Me.ClientesDataGridView.Size = New System.Drawing.Size(567, 220)
        Me.ClientesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cédula"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cédula"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombres"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tienda_deportiva.My.Resources.Resources.agregar
        Me.PictureBox2.Location = New System.Drawing.Point(72, 78)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'btnañadirt
        '
        Me.btnañadirt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnañadirt.ForeColor = System.Drawing.Color.Blue
        Me.btnañadirt.Location = New System.Drawing.Point(65, 72)
        Me.btnañadirt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnañadirt.Name = "btnañadirt"
        Me.btnañadirt.Size = New System.Drawing.Size(241, 39)
        Me.btnañadirt.TabIndex = 46
        Me.btnañadirt.Text = "Añadir Cliente"
        Me.btnañadirt.UseVisualStyleBackColor = True
        '
        'btnagregarT
        '
        Me.btnagregarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnagregarT.Location = New System.Drawing.Point(805, 471)
        Me.btnagregarT.Name = "btnagregarT"
        Me.btnagregarT.Size = New System.Drawing.Size(172, 47)
        Me.btnagregarT.TabIndex = 48
        Me.btnagregarT.Text = "Agregar"
        Me.btnagregarT.UseVisualStyleBackColor = True
        '
        'CédulaTextBox
        '
        Me.CédulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cédula", True))
        Me.CédulaTextBox.Location = New System.Drawing.Point(830, 183)
        Me.CédulaTextBox.Name = "CédulaTextBox"
        Me.CédulaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CédulaTextBox.TabIndex = 49
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(881, 267)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombresTextBox.TabIndex = 50
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(873, 325)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ApellidosTextBox.TabIndex = 51
        '
        'TeléfonoTextBox
        '
        Me.TeléfonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Teléfono", True))
        Me.TeléfonoTextBox.Location = New System.Drawing.Point(888, 364)
        Me.TeléfonoTextBox.Name = "TeléfonoTextBox"
        Me.TeléfonoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TeléfonoTextBox.TabIndex = 52
        '
        'FrClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 685)
        Me.Controls.Add(TeléfonoLabel)
        Me.Controls.Add(Me.TeléfonoTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(CédulaLabel)
        Me.Controls.Add(Me.CédulaTextBox)
        Me.Controls.Add(Me.btnagregarT)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnañadirt)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Name = "FrClientes"
        Me.Text = "FrClientes"
        CType(Me.Database2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database2000DataSet As Database2000DataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Database2000DataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Database2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnañadirt As Button
    Friend WithEvents btnagregarT As Button
    Friend WithEvents CédulaTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents TeléfonoTextBox As TextBox
End Class
