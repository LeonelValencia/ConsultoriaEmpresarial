Imports System.ComponentModel

Public Class FrmEliminarEmpleados
    Public Sub MostrarEmpleados()
        Try
            Dim le As New LEmpleados
            Dim dt As DataTable = le.ConsultarAllEmpleados()
            dgvConsultores.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub dgvConsultores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultores.CellClick
        txtId.Text = dgvConsultores.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim le As New LEmpleados
            le.EliminarEmpleado(txtId.Text)
            MostrarEmpleados()
            txtId.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmEliminarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEmpleados()
    End Sub

    Private Sub FrmEliminarEmpleados_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class