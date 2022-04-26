Imports System.ComponentModel
Public Class ProgramarOT
    Private Sub ConsultarAnalistas()
        Try
            Dim le As New LEmpleados
            Dim ds As DataSet = le.ConsultarNameTipo("nombre", "analista")
            CbAnalista.DataSource = ds.Tables(0)
            CbAnalista.ValueMember = "nombre"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimpiarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub ProgramarOT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim lot As New LOT
            lot.ProgramarOT(txtMateriales.Text, txtCliente.Text, txtEmpleado.Text, DateProgramada.Text, CbAnalista.Text)
            LimpiarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramarOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarAnalistas()
    End Sub
End Class