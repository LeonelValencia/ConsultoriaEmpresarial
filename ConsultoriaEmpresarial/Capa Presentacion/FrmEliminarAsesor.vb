Imports System.ComponentModel

Public Class FrmEliminarAsesor
    Public Sub MostrarAsesores()
        Try
            Dim le As New LEmpleados
            Dim dt As DataTable = le.ConsultarEmpleados("asesor")
            dgvConsultores.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim le As New LEmpleados
            le.EliminarEmpleado(txtId.Text)
            MostrarAsesores()
            txtId.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmEliminarAsesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAsesores()
    End Sub

    Private Sub FrmEliminarAsesor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
    Private Sub dgvConsultores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultores.CellClick
        txtId.Text = dgvConsultores.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class