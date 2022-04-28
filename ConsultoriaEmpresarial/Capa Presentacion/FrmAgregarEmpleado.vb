Imports System.ComponentModel

Public Class FrmAgregarEmpleado
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim le As New LEmpleados
            le.InsertarEmpleado(CbTipo.Text, txtUsuario.Text, txtContra.Text, txtNombre.Text, txtTel.Text, datetFechaI.Text)
            MostrarEmpleados()
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmAgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEmpleados()
    End Sub

    Private Sub FrmAgregarEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class