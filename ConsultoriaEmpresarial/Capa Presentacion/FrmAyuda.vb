Imports System.ComponentModel

Public Class FrmAyuda
    Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmAyuda_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Main2SesionIniciada.txtIdClienteMain.Text = "" Then
            main.Show()
        Else
            Main2SesionIniciada.Show()
        End If
    End Sub
End Class