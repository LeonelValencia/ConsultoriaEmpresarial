Imports System.ComponentModel
Public Class ConsultarOT
    Private Sub LlenarTabla()
        Try
            Dim lot As New LOT
            Dim dt As DataTable = lot.ConsultarOTs
            dgvOT.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarOT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub

    Private Sub ConsultarOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarTabla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("OT programada")
    End Sub
End Class