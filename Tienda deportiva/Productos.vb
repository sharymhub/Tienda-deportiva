Imports System.IO
Imports Tienda_deportiva.Database2000DataSetTableAdapters

Public Class Productos


    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.Database2000DataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Database2000DataSet.Productos)
        GBproductos.Visible = False
        ProductosBindingSource.RemoveFilter()

        txbusquedaP.SelectionStart = False
    End Sub
    Private Sub Actualizar()
        ' Actualizar los datos en el DataGridView
        Me.ProductosTableAdapter.Fill(Me.Database2000DataSet.Productos)
    End Sub

    Private Sub Agregarporducto_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GBproductos.Visible = True
        ' Agregar un nuevo campo para un nuevo producto a la fuente de datos
        ProductosBindingSource.AddNew()

    End Sub

    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles BtncancelarP.Click
        GBproductos.Visible = False
        ProductosBindingSource.RemoveCurrent()
        Me.ProductosBindingSource.EndEdit()
        ProductosTableAdapter.Update(Database2000DataSet.Productos)
        Actualizar()
    End Sub

    Private Function CamposCompletados() As Boolean
        ' Iterar sobre los controles en el grupo de productos
        For Each ctrl As Control In GBproductos.Controls
            If TypeOf ctrl Is TextBox Then
                ' Verificar si el TextBox está vacío
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    Return False
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                ' Verificar si el ComboBox tiene un valor seleccionado
                If DirectCast(ctrl, ComboBox).SelectedIndex = -1 Then
                    Return False
                End If
            End If

        Next
        ' Si todos los campos están completos, retornar True
        Return True
    End Function
    Private Sub BtnagregarP_Click(sender As Object, e As EventArgs) Handles btnagregarP.Click
        btnagregarP.Text = "Agregar"
        If Not CamposCompletados() Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Verificar que los datos en el formulario son válidos
        If ValidateChildren() Then

            ' Finalizar la edición
            Me.ProductosBindingSource.EndEdit()

            ' Guardar los cambios en la base de datos
            ProductosTableAdapter.Update(Database2000DataSet.Productos)

            ' Actualizar los datos en el DataGridView
            Actualizar()

            ' Ocultar el grupo de controles después de agregar el producto
            GBproductos.Visible = False
        Else
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub Btneliminarp_Click(sender As Object, e As EventArgs) Handles btneliminarp.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ProductosBindingSource.RemoveCurrent()
            Me.ProductosBindingSource.EndEdit()
            ProductosTableAdapter.Update(Database2000DataSet.Productos)
            Actualizar()
        End If
    End Sub

    Private Sub BtneditarP_Click(sender As Object, e As EventArgs) Handles btneditarP.Click
        GBproductos.Visible = True
        btnagregarP.Text = "Cambiar"

        Dim productoselect As DataRowView = CType(ProductosBindingSource.Current, DataRowView)
        NombreTextBox.Text = productoselect("Nombre").ToString
        MarcaTextBox.Text = productoselect("Marca").ToString
        DescripciónTextBox.Text = productoselect("Descripción").ToString
        PrecioTextBox.Text = productoselect("Precio").ToString
        Stock_disponibleTextBox.Text = productoselect("Stock disponible").ToString


    End Sub

    Private Sub BtnbuscarP_Click(sender As Object, e As EventArgs) Handles btnbuscarP.Click
        'Texto de búsqueda
        Dim buscar As String = txbusquedaP.Text.Trim()

        If String.IsNullOrEmpty(buscar) Then
            'No está el filtro aplicado, asi que se muestran todos los datos
            ProductosBindingSource.RemoveFilter()
        Else
            'Filtrar por nombre o marca
            Dim filtro As String = String.Format("Nombre LIKE '*{0}*' or Marca LIKE '*{0}*'", buscar)
            ProductosBindingSource.Filter = filtro

        End If
    End Sub

    Private Sub TxbusquedaP_TextChanged(sender As Object, e As EventArgs) Handles txbusquedaP.TextChanged

    End Sub

    Private Sub EmpresaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmpresaComboBox.SelectedIndexChanged
        EmpresaComboBox.Items.Clear()

        ' Verifica si el BindingSource tiene un DataSource válido
        If ProveedoresBindingSource.DataSource IsNot Nothing Then
            ' Obtén el DataSource desde el BindingSource
            Dim dataTable As DataTable = TryCast(ProveedoresBindingSource.DataSource, DataTable)

            ' Verifica si el DataSource es un DataTable
            If dataTable IsNot Nothing Then
                ' Llena el ComboBox con los valores de la columna 'Empresa'
                For Each row As DataRow In dataTable.Rows
                    EmpresaComboBox.Items.Add(row("Empresa").ToString())
                Next
            End If
        End If


    End Sub

    Private Sub GBproductos_Enter(sender As Object, e As EventArgs) Handles GBproductos.Enter

    End Sub

End Class