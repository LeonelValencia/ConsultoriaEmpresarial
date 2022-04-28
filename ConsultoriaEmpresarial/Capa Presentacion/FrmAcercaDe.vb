Imports System.ComponentModel

Public Class FrmAcercaDe
    Private Sub FrmAcercaDe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Main2SesionIniciada.txtIdClienteMain.Text = "" Then
            main.Show()
        Else
            Main2SesionIniciada.Show()
        End If
    End Sub
End Class