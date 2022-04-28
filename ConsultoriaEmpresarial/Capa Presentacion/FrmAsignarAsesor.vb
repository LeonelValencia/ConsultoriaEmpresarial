Imports System.ComponentModel

Public Class FrmAsignarAsesor
    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try
            Dim ls As New LSolConsul
            ls.AsignarAsesorACliente(txtIdAsesor.Text, txtIdSol.Text)
            txtIdCliente.Clear()
            txtNombreCliente.Clear()
            MostrarTabla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MostrarTabla()
        Try
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.ConsultarAsignarAsesor
            dgvAsesorCliente.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListarAsesores()
        Try
            Dim lsc As New LSolConsul
            Dim ds = lsc.ListarAsesores
            cbAsesores.DataSource = ds.Tables(0)
            cbAsesores.ValueMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmAsignarAsesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTabla()
        ListarAsesores()
    End Sub

    Private Sub FrmAsignarAsesor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
    Private Sub dgvAsesorCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsesorCliente.CellClick
        Try
            txtNombreCliente.Text = dgvAsesorCliente.CurrentRow.Cells(1).Value.ToString
            txtIdSol.Text = dgvAsesorCliente.CurrentRow.Cells(0).Value.ToString
            Dim nombre As String = dgvAsesorCliente.CurrentRow.Cells(1).Value.ToString
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.SetIdClienteName(nombre)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtIdCliente.Text = dr.Item("idCl")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbAsesores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAsesores.SelectedIndexChanged
        Try
            Dim ls As New LSolConsul
            Dim nombre = cbAsesores.Text
            Dim dt As DataTable = ls.SetIdAsesorName(nombre)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtIdAsesor.Text = dr.Item("id")
        Catch ex As IndexOutOfRangeException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class