Imports System.ComponentModel

Public Class FrmAsignarPresupuesto
    Public Sub ConsultarClientes()
        Try
            Dim lsc As New LSolConsul()
            Dim dt As DataTable = lsc.ConsultarSolConsuls
            dgvNece.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmAsignarPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarClientes()
    End Sub
    Private Sub dgvNece_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNece.CellClick
        txtFolio.Text = dgvNece.CurrentRow.Cells(0).Value.ToString
        rtxNece.Text = dgvNece.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim lsc As New LSolConsul
            lsc.InsertarPresupuesto(txtPresu.Text, txtFolio.Text)
            ConsultarClientes()
            LimpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtFolio.Clear()
        rtxNece.Clear()
        txtPresu.Clear()
    End Sub
    Private Sub FrmAsignarPresupuesto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class