Imports System.ComponentModel

Public Class FrmActualizarClienteAdm
    Public Sub ConsultarClientes()
        Try
            Dim lc As New LClientes()
            Dim dt As DataTable = lc.ConsultarClientes()
            dgvConsultarClientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            lc.ActualizarCliente(txtId.Text, txtNombreCliente.Text, txtTelCliente.Text, txtDirEmpC.Text, txtNombreEmpCliente.Text, txtEmailCliente.Text,
                               txtUsuarioCliente.Text, txtContraseñaCliente.Text)
            ConsultarClientes()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call borrarTodo(Me)
        End Try
    End Sub

    Private Sub FrmActualizarClienteAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarClientes()
    End Sub

    Private Sub dgvConsultarClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultarClientes.CellClick
        txtId.Text = dgvConsultarClientes.CurrentRow.Cells(0).Value.ToString
        txtNombreCliente.Text = dgvConsultarClientes.CurrentRow.Cells(1).Value.ToString
        txtTelCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(2).Value.ToString
        txtDirEmpC.Text = dgvConsultarClientes.CurrentRow.Cells.Item(3).Value.ToString
        txtNombreEmpCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(4).Value.ToString
        txtEmailCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(5).Value.ToString
        txtUsuarioCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(6).Value.ToString
        txtContraseñaCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(7).Value.ToString
    End Sub
    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        Try
            Dim lc As New LClientes
            Dim dt As DataTable = lc.ConsultarCliente(txtId.Text)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtNombreCliente.Text = dr.Item("nomC")
            txtTelCliente.Text = dr.Item("telC")
            txtDirEmpC.Text = dr.Item("dirEmp")
            txtNombreEmpCliente.Text = dr.Item("nomEmp")
            txtEmailCliente.Text = dr.Item("emailC")
            txtUsuarioCliente.Text = dr.Item("userC")
            txtContraseñaCliente.Text = dr.Item("passwordC")
        Catch ex As Exception
            MsgBox("El cliente ingresado no existe")
        End Try
    End Sub

    Private Sub FrmActualizarClienteAdm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
        Me.Hide()
    End Sub
End Class