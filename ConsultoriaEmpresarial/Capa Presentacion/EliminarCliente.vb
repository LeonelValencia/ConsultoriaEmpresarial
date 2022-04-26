Imports System.ComponentModel

Public Class EliminarCliente
    Private Sub EliminarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Try
            Dim lc As New LClientes()
            lc.EliminarCliente(txtContraseña.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            txtContraseña.Text = ""
            main.Show()
            Me.Hide()
        End Try
    End Sub
End Class