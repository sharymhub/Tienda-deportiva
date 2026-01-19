Public Class yest
    Dim rol As String = Nothing
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Database2000DataSet.Usuarios)

        Me.UsuariosTableAdapter.Fill(Me.Database2000DataSet.Usuarios)
        UsuarioTextBox.Text = ""
        ContraseñaTextBox.Text = ""
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        'Dim usuarioValido As Boolean = Me.UsuariosTableAdapter.BuscarUC(Me.Database2000DataSet.Usuarios, UsuarioTextBox.Text, ContraseñaTextBox.Text)

        Dim u = From usuarios In Me.Database2000DataSet.Usuarios
                Where usuarios.Usuario = UsuarioTextBox.Text And usuarios.Contraseña = ContraseñaTextBox.Text

        If u.Any() Then
            rol = u(0).Rol

            If rol = "Admin" Then
                Menú.Show()
            ElseIf rol = "Empleado" Then
                Menu_empleados.Show()
            Else
                MsgBox("Usuario no tiene ROL asignado", vbCritical, "Acceso denegado")
            End If
            System.Console.WriteLine("si")

        Else
            System.Console.WriteLine("no")
        End If

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_5(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub
End Class