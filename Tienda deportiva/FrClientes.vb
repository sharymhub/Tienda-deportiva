Public Class FrClientes

    Private Sub FrClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Database2000DataSet.Clientes)

    End Sub

    Private Sub Btnañadirt_Click(sender As Object, e As EventArgs) Handles btnañadirt.Click
        ClientesBindingSource.AddNew()
    End Sub

    Private Sub BtnagregarT_Click(sender As Object, e As EventArgs) Handles btnagregarT.Click
        Me.ClientesBindingSource.EndEdit()
        ClientesTableAdapter.Update(Database2000DataSet.Clientes)
        Me.ClientesTableAdapter.Fill(Me.Database2000DataSet.Clientes)
    End Sub
End Class