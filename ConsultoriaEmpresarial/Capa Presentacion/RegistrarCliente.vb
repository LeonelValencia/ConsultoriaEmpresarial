Imports System.ComponentModel

Public Class RegistrarCliente
    Public Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub RegistrarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Show()
    End Sub

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Try
            Dim lc As New LClientes()
            lc.insertarCliente(txtNombreCliente.Text, txtTelCliente.Text, txtDirEmpC.Text, txtNombreEmpCliente.Text, txtEmailCliente.Text,
                               txtUsuarioCliente.Text, txtContraseñaCliente.Text)
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Iniciar_sesion.Show()
            Me.Hide()
        End Try
    End Sub
End Class