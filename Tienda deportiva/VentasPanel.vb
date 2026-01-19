Imports System.Data.OleDb

Public Class VentasPanel
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub VentasPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Database2000DataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.Database2000DataSet.Facturas)
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Trabajadores1' Puede moverla o quitarla según sea necesario.
        Me.Trabajadores1TableAdapter.Fill(Me.Database2000DataSet.Trabajadores1)
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Database2000DataSet.Productos)
        Me.ClientesTableAdapter.Fill(Me.Database2000DataSet.Clientes)
        LlenarCB()
        TxtCedula.Text = String.Empty
        TextBoxNombre.Text = String.Empty
        TextBoxApellido.Text = String.Empty
        TextBoxTelefono.Text = String.Empty
    End Sub


    Private Sub GUARDAR_VENTA_Click(sender As Object, e As EventArgs) Handles btnguardaarV.Click
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim newVentaRow As DataRowView = CType(VentasBindingSource.AddNew, DataRowView)
        newVentaRow("Cliente") = TextBoxNombre.Text
        newVentaRow("Empleado a cargo") = NombreTextBox1.Text
        newVentaRow("Forma de pago") = Forma_de_pagoComboBox.SelectedItem
        newVentaRow("Fecha de venta") = lblFecha.Text


        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.VentasTableAdapter.Update(Database2000DataSet.Ventas)

        'Obtener el Id de venta generado y almacenarlo en una variable global
        Dim idVentaGenerado As Integer = CInt(newVentaRow("Código"))
        MsgBox("Venta generada exitosamente. Código de venta: " & idVentaGenerado.ToString(), MsgBoxStyle.Information)

        'Guardar el Id de venta generado en una variable para usarla en el siguiente paso
        Me.Tag = idVentaGenerado

        For Each row As DataGridViewRow In VentasDataGridView.Rows
            If Not row.IsNewRow Then
                Dim nombreProducto As String = row.Cells("Producto").Value.ToString() ' Asume que tienes una columna NombreProducto
                Dim cantidadVendida As Integer = CInt(row.Cells("Cantidad").Value) ' Asume que tienes una columna Cantidad

                ' Buscar la fila correspondiente del DataSet de productos usando el nombre del producto
                Dim productoRows() As DataRow = Database2000DataSet.Productos.Select("Nombre = '" & nombreProducto & "'")
                If productoRows.Length > 0 Then
                    Dim productoRow As DataRow = productoRows(0)
                    Dim cantidadActual As Integer = CInt(productoRow("Stock disponible"))
                    productoRow("Stock disponible") = cantidadActual - cantidadVendida
                End If
            End If
        Next

        ' Guardar los cambios en la base de datos
        Me.ProductosTableAdapter.Update(Database2000DataSet.Productos)
        Nuevaventa()
    End Sub

    Private Sub Nuevaventa()
        VentasDataGridView.Rows.Clear()

        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxTelefono.Clear()
        TextBoxCantidad.Clear()
        Lbtotal.Text = ""
        LbIVA.Text = ""
        LbTotalpagar.Text = ""
        Txtpagorecibido.Clear()
        LbCambio.Text = ""
        'Limpiar los ítems del ComboBox
        Forma_de_pagoComboBox.Items.Clear()

        ' Volver a agregar ítems predeterminados
        Forma_de_pagoComboBox.Items.Add("Efectivo")
        Forma_de_pagoComboBox.Items.Add("Tarjeta")

        ' Opcional: Seleccionar un ítem por defecto
        If Forma_de_pagoComboBox.Items.Count > 0 Then
            Forma_de_pagoComboBox.SelectedIndex = 0
        End If
        TxtCedula.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidadDisponible As Integer = GetCantidadDisponible()
        ' Verificar si hay una fila seleccionada en dataGridView1
        If ProductosDataGridView.SelectedRows.Count > 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = ProductosDataGridView.SelectedRows(0)

            ' Crear una nueva fila en dataGridView2
            Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
            newRow.CreateCells(VentasDataGridView)

            newRow.Cells(0).Value = selectedRow.Cells(1).Value

            If TextBoxCantidad.Text = "" Then
                MessageBox.Show("Por favor, seleccione la cantidad del producto que desea agregar")
                TextBoxCantidad.Focus()
            ElseIf TextBoxCantidad.Text <= 0 Then
                MessageBox.Show("seleccione una cantidad valida")
                TextBoxCantidad.Text = ""
                TextBoxCantidad.Focus()
            ElseIf TextBoxCantidad.Text > cantidadDisponible Then
                MessageBox.Show("La cantidad ingresada excede la cantidad disponible en el inventario.")
                TextBoxCantidad.Text = ""
                TextBoxCantidad.Focus()
            Else
                newRow.Cells(1).Value = TextBoxCantidad.Text
                newRow.Cells(2).Value = selectedRow.Cells(2).Value
                newRow.Cells(3).Value = Convert.ToDecimal(newRow.Cells(2).Value) * Convert.ToDecimal(newRow.Cells(1).Value)
                'newRow.Cells(3).Value = (newRow.Cells(2).Value) * (newRow.Cells(1).Value)

                ' Agregar la nueva fila a dataGridView2
                VentasDataGridView.Rows.Add(newRow)
                Sumaproductos()
                IVA()
                TextBoxCantidad.Clear()
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para agregar")
        End If
    End Sub
    Private Sub Txtbuscador_TextChanged(sender As Object, e As EventArgs) Handles Txtbuscador.TextChanged
        Dim buscar As String = Txtbuscador.Text.Trim()
        Dim filtro As String

        If String.IsNullOrEmpty(buscar) Then
            ProductosBindingSource.RemoveFilter()
        Else
            If RBnombre.Checked Then
                filtro = String.Format("Nombre LIKE '*{0}*'", buscar)
                ProductosBindingSource.Filter = filtro
            ElseIf RBcodigo.Checked Then
                Dim valorNumerico As Integer
                If Integer.TryParse(buscar, valorNumerico) Then
                    filtro = String.Format("Código = {0}", valorNumerico)
                    ProductosBindingSource.Filter = filtro
                Else
                    filtro = String.Format("CStr(Código) LIKE '{0}'", buscar)
                    ProductosBindingSource.Filter = filtro
                End If
            End If


        End If
    End Sub
    Private Sub CódigoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CódigoComboBox.SelectedIndexChanged
        MostrarEmpleado()
    End Sub
    Private Sub LlenarCB()
        ' El DataSet vinculado al BindingSource
        Dim dt As DataTable = Database2000DataSet.Tables("Trabajadores1")
        CódigoComboBox.Items.Clear()
        For Each row As DataRow In dt.Rows
            CódigoComboBox.Items.Add(row("Código"))
        Next
    End Sub
    Private Sub MostrarEmpleado()
        Dim codigoSeleccionado As Integer = CInt(CódigoComboBox.SelectedItem)

        ' Filtrar el BindingSource basado en el código seleccionado
        Trabajadores1BindingSource.Filter = String.Format("Código = {0}", codigoSeleccionado)

        ' Verificar si hay datos después de aplicar el filtro
        If Trabajadores1BindingSource.Count > 0 Then
            ' Mostrar los datos en los TextBox
            NombreTextBox1.Text = CType(Trabajadores1BindingSource.Current, DataRowView)("Nombre").ToString()
            ApellidosTextBox1.Text = CType(Trabajadores1BindingSource.Current, DataRowView)("Apellidos").ToString()
        Else
            ' Limpiar los TextBox si no hay datos
            NombreTextBox1.Text = ""
            ApellidosTextBox1.Text = ""
        End If
    End Sub
    Private Sub Sumaproductos()
        Dim sumatoria As Double = 0
        For i As Integer = 0 To VentasDataGridView.Rows().Count - 1 Step 1
            sumatoria = sumatoria + VentasDataGridView.Rows(i).Cells(3).Value
        Next
        Lbtotal.Text = "$ " & sumatoria
    End Sub
    Private Sub IVA()
        Dim productos As Double = Lbtotal.Text
        Dim IVA As Double
        IVA = productos * 19 / 100
        LbIVA.Text = IVA
        LbTotalpagar.Text = productos + IVA
    End Sub

    Private Sub Forma_de_pagoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Forma_de_pagoComboBox.SelectedValueChanged
        If Forma_de_pagoComboBox.SelectedItem.ToString() = "Efectivo" Then
            Txtpagorecibido.Enabled = True
        ElseIf Forma_de_pagoComboBox.SelectedItem.ToString() = "Tarjeta" Then
            Txtpagorecibido.Enabled = False
            LbCambio.Visible = False
            Labelcambio.Visible = False
            Label8.Visible = False
        End If
    End Sub

    Private Sub TextBoxCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse
             e.KeyChar = ChrW(Keys.Back) OrElse
             e.KeyChar = ChrW(Keys.Delete)) Then
            ' Si la tecla no es permitida, anulamos el evento
            e.Handled = True
        End If
    End Sub

    Private Function GetCantidadDisponible() As Integer
        ' Aquí debes reemplazar el código con la forma en la que obtienes la cantidad disponible del DataSet
        ' Este es solo un ejemplo; ajústalo según tu implementación
        Dim cantidadDisponible As Integer = 0
        If ProductosDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ProductosDataGridView.SelectedRows(0)
            Dim productoId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value) ' Asumiendo que la columna 0 es el ID del producto

            ' Buscar la cantidad disponible en el DataSet usando el ID del producto
            Dim row As DataRow = Database2000DataSet.Productos.FindByCódigo(productoId)
            If row IsNot Nothing Then
                cantidadDisponible = row("Stock disponible")
            End If
        End If
        Return cantidadDisponible
    End Function

    Private Sub Btnguardarcliente_Click(sender As Object, e As EventArgs) Handles Btnguardarcliente.Click
        If TxtCedula.Text <> "" AndAlso TextBoxNombre.Text <> "" AndAlso TextBoxApellido.Text <> "" AndAlso TextBoxTelefono.Text <> "" Then
            Try
                Me.ClientesBindingSource.EndEdit()
                ClientesTableAdapter.Update(Database2000DataSet.Clientes)
                Me.ClientesTableAdapter.Fill(Me.Database2000DataSet.Clientes)
                MessageBox.Show("Usuario ingresado correctamente")
            Catch ex As Exception
                MessageBox.Show("Error al añadir el cliente: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor, completa todos los campos.")
        End If
    End Sub

    Private Sub GBdatagrid_Enter(sender As Object, e As EventArgs) Handles GBdatagrid.Enter

    End Sub

    Private Sub Txtpagorecibido_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtpagorecibido.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim recibido As Double
            Dim cambio As Double
            Dim total_pagar As Double

            ' Verifica si los textos pueden ser convertidos a Double
            If Double.TryParse(Txtpagorecibido.Text, recibido) AndAlso
               Double.TryParse(LbTotalpagar.Text, total_pagar) Then
                If recibido < total_pagar Then
                    MessageBox.Show("No se puede realizar la venta, revise el dinero recibido")
                Else
                    cambio = recibido - total_pagar
                    LbCambio.Text = cambio
                End If

            End If
        End If
    End Sub

    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        Try
            If String.IsNullOrWhiteSpace(TxtCedula.Text) Then
                MessageBox.Show("Por favor, introduzca una cédula válida.")
                Return
            End If

            Dim buscarcliente = From clientes In Me.Database2000DataSet.Clientes
                                Where clientes.Cédula = TxtCedula.Text

            If buscarcliente.Any() Then
                TextBoxNombre.Text = buscarcliente(0).Nombres
                TextBoxApellido.Text = buscarcliente(0).Apellidos
                TextBoxTelefono.Text = buscarcliente(0).Teléfono
                MessageBox.Show("Cliente existente")
            Else
                MessageBox.Show("Cliente Nuevo, ingrese los datos correspondientes")
                TextBoxNombre.Clear()
                TextBoxApellido.Clear()
                TextBoxTelefono.Clear()
                TextBoxNombre.Focus()
                ClientesBindingSource.AddNew()

                ' Asignar la cédula al nuevo registro
                Dim nuevoCliente As DataRowView = CType(ClientesBindingSource.Current, DataRowView)
                nuevoCliente("Cédula") = TxtCedula.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar o agregar el cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub Txtpagorecibido_TextChanged(sender As Object, e As EventArgs) Handles Txtpagorecibido.TextChanged

    End Sub

    Private Sub Forma_de_pagoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Forma_de_pagoComboBox.SelectedIndexChanged

    End Sub
End Class