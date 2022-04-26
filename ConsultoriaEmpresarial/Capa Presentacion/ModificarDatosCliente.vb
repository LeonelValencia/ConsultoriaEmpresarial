Imports System.ComponentModel

Public Class ModificarDatosCliente

    Private Sub ModificarDatosCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub
    Private Sub borrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Try
            Dim lc As New LClientes()
            lc.ActualizarCliente(txtId.Text, txtNombreCliente.Text, txtTelefonoCliente.Text, txtDireccionEmpCliente.Text, txtNomEmCliente.Text, txtEmailCliente.Text,
                               txtUsuarioCliente.Text, txtContraseñaCliente.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call borrarTodo(Me)
        End Try
    End Sub

    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        Try
            Dim lc As New LClientes
            Dim dt As DataTable = lc.ConsultarCliente(txtId.Text)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtNombreCliente.Text = dr.Item("nomC")
            txtTelefonoCliente.Text = dr.Item("telC")
            txtDireccionEmpCliente.Text = dr.Item("dirEmp")
            txtNomEmCliente.Text = dr.Item("nomEmp")
            txtEmailCliente.Text = dr.Item("emailC")
            txtUsuarioCliente.Text = dr.Item("userC")
            txtContraseñaCliente.Text = dr.Item("passwordC")
            txtId.Enabled() = False
        Catch ex As Exception
            MsgBox("El cliente ingresado no existe")
        End Try
    End Sub
End Class