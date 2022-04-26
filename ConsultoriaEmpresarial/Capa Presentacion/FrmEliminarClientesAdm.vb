Imports System.ComponentModel

Public Class FrmEliminarClientesAdm
    Public Sub ConsultarClientes()
        Try
            Dim lc As New LClientes()
            Dim dt As DataTable = lc.ConsultarClientes()
            dgvConsultarClientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmEliminarClientesAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarClientes()
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Try
            Dim lc As New LClientes()
            lc.EliminarCliente(txtContraseñaCliente.Text)
            ConsultarClientes()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            txtContraseñaCliente.Text = ""
        End Try
    End Sub
    Private Sub dgvConsultarClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultarClientes.CellClick
        txtContraseñaCliente.Text = dgvConsultarClientes.CurrentRow.Cells.Item(7).Value.ToString
    End Sub

    Private Sub FrmEliminarClientesAdm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
        Me.Hide()
    End Sub
End Class