Public Class Facturas
    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database2000DataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Database2000DataSet.Ventas)

    End Sub

    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2000DataSet)

    End Sub

    Private Sub VentasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasDataGridView.CellContentClick
        Me.VentasTableAdapter.Fill(Me.Database2000DataSet.Ventas)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim buscarDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        If DateTimePicker1.Checked Then
            VentasBindingSource.Filter = String.Format("Fecha de venta = #{0}#", buscarDate)

            ' Si no se aplica ningún filtro, se muestran todos los datos
        Else
            VentasBindingSource.RemoveFilter()

        End If
    End Sub
End Class