Imports System.Drawing.Printing

Public Class ReporteVenta
    Private WithEvents printDoc As New PrintDocument()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mostrar el diálogo de impresión
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub
End Class