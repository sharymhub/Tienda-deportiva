Public Class Usuarios
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Database2000DataSet.Usuarios)

    End Sub
    Private Sub Actualizar()
        Me.UsuariosTableAdapter.Fill(Me.Database2000DataSet.Usuarios)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GBUsuarios.Visible = True
        UsuariosBindingSource.AddNew()
    End Sub

    Private Sub ApellidosLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtncancelarT_Click(sender As Object, e As EventArgs) Handles btncancelarT.Click
        GBUsuarios.Visible = False
        UsuariosBindingSource.RemoveCurrent()
        Me.UsuariosBindingSource.EndEdit()
        UsuariosTableAdapter.Update(Database2000DataSet.Usuarios)
        Actualizar()
    End Sub
    Private Function CamposCompletados() As Boolean
        ' Iterar sobre los controles en el grupo de productos
        For Each ctrl As Control In GBUsuarios.Controls
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
            Me.UsuariosBindingSource.EndEdit()

            ' Guardar los cambios en la base de datos
            UsuariosTableAdapter.Update(Database2000DataSet.Usuarios)

            ' Actualizar los datos en el DataGridView
            Actualizar()

            ' Ocultar el grupo de controles después de agregar el producto
            GBUsuarios.Visible = False
        Else
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar a este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            UsuariosBindingSource.RemoveCurrent()
            Me.UsuariosBindingSource.EndEdit()
            UsuariosTableAdapter.Update(Database2000DataSet.Usuarios)
            Actualizar()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GBUsuarios.Visible = True
        btnagregarT.Text = "Cambiar"

        Dim productoselect As DataRowView = CType(UsuariosBindingSource.Current, DataRowView)
        NombreTextBox.Text = productoselect("Nombre").ToString
        TelefonoTextBox.Text = productoselect("Telefono").ToString
        Correo_ElectronicoTextBox.Text = productoselect("Correo Electronico").ToString
        UsuarioTextBox.Text = productoselect("Usuario").ToString
        ContraseñaTextBox1.Text = productoselect("Contraseña").ToString
        RolComboBox.SelectedItem = productoselect("Rol").ToString
    End Sub
End Class