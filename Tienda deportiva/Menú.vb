Public Class Menú
    Sub CambioPanel(ByVal Panel As Form)
        PanelCentral.Controls.Clear()
        Panel.TopLevel = False
        PanelCentral.Controls.Add(Panel)
        Panel.Show()

    End Sub

    Private Sub Btnuevaventa_Click(sender As Object, e As EventArgs) Handles btnuevaventa.Click
        CambioPanel(VentasPanel)
    End Sub

    Private Sub Btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        CambioPanel(Productos)
    End Sub

    Private Sub ButtonFacturas_Click(sender As Object, e As EventArgs) Handles ButtonFacturas.Click
        CambioPanel(Facturas)
    End Sub

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        CambioPanel(Usuarios)
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        yest.Show()
        Me.Close()
    End Sub

    Private Sub ButtonTrabajadores_Click(sender As Object, e As EventArgs) Handles ButtonTrabajadores.Click
        CambioPanel(Trabajadores)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CambioPanel(FrClientes)
    End Sub

End Class