Imports System.ComponentModel

Public Class FrmInsertarAsesores
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim le As New LEmpleados
            le.InsertarEmpleado("asesor", txtUsuario.Text, txtContra.Text, txtNombre.Text, txtTel.Text, datetFechaI.Text)
            MostrarAsesores()
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub MostrarAsesores()
        Try
            Dim le As New LEmpleados
            Dim dt As DataTable = le.ConsultarEmpleados("asesor")
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
    Private Sub FrmInsertarAsesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAsesores()
    End Sub

    Private Sub FrmInsertarAsesores_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class