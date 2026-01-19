Imports Tienda_deportiva.Database2000DataSetTableAdapters

Public Class Trabajadores
    Private Sub Trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Trabajadores1' Puede moverla o quitarla según sea necesario.
        Me.Trabajadores1TableAdapter.Fill(Me.Database2000DataSet.Trabajadores1)
        GBempleados.Visible = False
        Trabajadores1BindingSource.RemoveFilter()
        txbusquedaT.SelectionStart = False
    End Sub

    Private Sub Productoslb_Click(sender As Object, e As EventArgs)
        Productos.Show()
        Me.Hide()
    End Sub
    Private Sub ProdutctosPB_Click(sender As Object, e As EventArgs)
        Productos.Show()
        Me.Hide()
    End Sub
    Private Sub Actualizar()
        ' Actualizar los datos en el DataGridView
        Me.Trabajadores1TableAdapter.Fill(Me.Database2000DataSet.Trabajadores1)
    End Sub
    Private Sub Btnañadirt_Click(sender As Object, e As EventArgs) Handles btnañadirt.Click
        GBempleados.Visible = True
        ' Agregar un nuevo campo para un nuevo producto a la fuente de datos
        Trabajadores1BindingSource.AddNew()
    End Sub
    Private Sub Cancelarbtn_Click(sender As Object, e As EventArgs) Handles btncancelarT.Click
        GBempleados.Visible = False
        Trabajadores1BindingSource.RemoveCurrent()
        Me.Trabajadores1BindingSource.EndEdit()
        Trabajadores1TableAdapter.Update(Database2000DataSet.Trabajadores1)
        Actualizar()
    End Sub
    Private Function CamposCompletados() As Boolean
        ' Iterar sobre los controles en el grupo de productos
        For Each ctrl As Control In GBempleados.Controls
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
    Private Sub BtnagregarT_Click(sender As Object, e As EventArgs) Handles btnagregarT.Click
        btnagregarT.Text = "Agregar"
        If Not CamposCompletados() Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Verificar que los datos en el formulario son válidos
        If ValidateChildren() Then

            ' Finalizar la edición
            Me.Trabajadores1BindingSource.EndEdit()

            ' Guardar los cambios en la base de datos
            Trabajadores1TableAdapter.Update(Database2000DataSet.Trabajadores1)

            ' Actualizar los datos en el DataGridView
            Actualizar()

            ' Ocultar el grupo de controles después de agregar el producto
            GBempleados.Visible = False
        Else
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btneliminart_Click(sender As Object, e As EventArgs) Handles btneliminart.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar a este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Trabajadores1BindingSource.RemoveCurrent()
            Me.Trabajadores1BindingSource.EndEdit()
            Trabajadores1TableAdapter.Update(Database2000DataSet.Trabajadores1)
            Actualizar()
        End If
    End Sub

    Private Sub Btneditart_Click(sender As Object, e As EventArgs) Handles btneditart.Click
        GBempleados.Visible = True
        btnagregarT.Text = "Cambiar"

        Dim productoselect As DataRowView = CType(Trabajadores1BindingSource.Current, DataRowView)
        NombreTextBox.Text = productoselect("Nombre").ToString
        ApellidosTextBox.Text = productoselect("Apellidos").ToString
        FNDateTimePicker.Value = Convert.ToDateTime(productoselect("Fecha de nacimiento"))
        TeléfonoTextBox.Text = productoselect("Teléfono").ToString
        CiudadTextBox.Text = productoselect("Ciudad").ToString
    End Sub

    Private Sub BtnbuscarT_Click(sender As Object, e As EventArgs) Handles btnbuscarT.Click
        'Texto de búsqueda
        Dim buscar As String = txbusquedaT.Text.Trim()

        If String.IsNullOrEmpty(buscar) Then
            'No está el filtro aplicado, asi que se muestran todos los datos
            Trabajadores1BindingSource.RemoveFilter()
        Else
            'Filtrar por nombre o marca
            Dim filtro As String = String.Format("Nombre LIKE '*{0}*' or Apellidos LIKE '*{0}*' ", buscar)
            Trabajadores1BindingSource.Filter = filtro

        End If
    End Sub

    Private Sub GBempleados_Enter(sender As Object, e As EventArgs) Handles GBempleados.Enter

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class