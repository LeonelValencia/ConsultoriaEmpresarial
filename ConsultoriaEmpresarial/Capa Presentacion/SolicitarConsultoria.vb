Imports System.ComponentModel

Public Class SolicitarConsultoria
    Private Sub SolicitarConsultoria_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub

    Private Sub btnEnviarSolConsultoria_Click(sender As Object, e As EventArgs) Handles btnEnviarSolConsultoria.Click
        Try
            Dim lsc As New LSolConsul()
            lsc.InsertarSolConsul(txtIdCliente.Text, rtxtProblemasCliente.Text, dateTimer1.Text)
            rtxtProblemasCliente.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SolicitarConsultoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdCliente.Text = Main2SesionIniciada.txtIdClienteMain.Text
    End Sub
End Class