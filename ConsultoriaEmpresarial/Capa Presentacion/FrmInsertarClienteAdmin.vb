Imports System.ComponentModel

Public Class FrmInsertarClienteAdmin
    Public Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Public Sub ConsultarClientes()
        Try
            Dim lc As New LClientes()
            Dim dt As DataTable = lc.ConsultarClientes()
            dgvConsultarClientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmInsertarClienteAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarClientes()
    End Sub

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Try
            Dim lc As New LClientes()
            lc.insertarCliente(txtNombreCliente.Text, txtTelCliente.Text, txtDirEmpC.Text, txtNombreEmpCliente.Text, txtEmailCliente.Text,
                               txtUsuarioCliente.Text, txtContraseñaCliente.Text)
            ConsultarClientes()
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmInsertarClienteAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
        Me.Hide()
    End Sub
End Class