Imports System.ComponentModel

Public Class FrmActualizarAsesores
    Private Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub ConsultarAsesores()
        Try
            Dim le As New LEmpleados
            Dim dt As DataTable = le.ConsultarEmpleados("asesor")
            dgvConsultores.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim le As New LEmpleados
            le.ActualizarEmpleado("asesor", txtId.Text, txtUsuario.Text, txtContra.Text, txtNombre.Text, txtTel.Text, datetFechaI.Text)
            ConsultarAsesores()
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmActualizarAsesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarAsesores()
    End Sub
    Private Sub dgvConsultores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultores.CellClick
        txtId.Text = dgvConsultores.CurrentRow.Cells.Item(0).Value.ToString
        txtNombre.Text = dgvConsultores.CurrentRow.Cells.Item(4).Value.ToString
        txtTel.Text = dgvConsultores.CurrentRow.Cells.Item(5).Value.ToString
        txtUsuario.Text = dgvConsultores.CurrentRow.Cells.Item(2).Value.ToString
        txtContra.Text = dgvConsultores.CurrentRow.Cells.Item(3).Value.ToString
        datetFechaI.Text = dgvConsultores.CurrentRow.Cells.Item(6).Value.ToString
    End Sub

    Private Sub FrmActualizarAsesores_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class