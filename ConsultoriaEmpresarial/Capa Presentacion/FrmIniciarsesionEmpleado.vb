Imports System.ComponentModel

Public Class FrmIniciarsesionEmpleado
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            Dim le As New LEmpleados()
            FrmInicioEmpleado.nameUsuarioTSMenuItem.Text = txtUsuario.Text
            le.iniciarEmpleado(txtUsuario.Text, txtContraseña.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmIniciarsesionEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Show()
    End Sub
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                Dim le As New LEmpleados()
                le.iniciarEmpleado(txtUsuario.Text, txtContraseña.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class