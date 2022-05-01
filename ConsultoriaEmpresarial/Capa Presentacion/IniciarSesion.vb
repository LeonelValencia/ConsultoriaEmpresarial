Imports System.ComponentModel

Public Class Iniciar_sesion
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegistrarCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Iniciar_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.PasswordChar = "*"
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Entrar()
        Try
            Dim lc As New LClientes()
            Dim lsc As New LSolConsul()
            If lc.iniciarCliente(txtUsuario.Text, txtContraseña.Text) Then
                Main2SesionIniciada.NombreDeUsuarioToolStripMenuItem.Text = txtUsuario.Text
                Dim dt As DataTable = lc.GetIdCliente(txtUsuario.Text)
                Dim dr As DataRow = dt.Rows.Item(0)
                Main2SesionIniciada.txtIdClienteMain.Text = dr.Item("idC")
                lc.SetIdCliente(dr.Item("idC"))
                lsc.SetIdCliente(dr.Item("idC"))
                lsc.IDClienteLSolConsul = Val(dr.Item("idC"))
                Dim idc As String = Val(dr.Item("idC"))
                FrmQuejaCliente.txtIdCliente.Text = dr.Item("idC")
                PresupuestoCliente.txtIdCliente.Text = dr.Item("idC")
                txtContraseña.Clear()
                txtUsuario.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Iniciar_sesion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Show()
    End Sub
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            Entrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lkContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkContraseña.LinkClicked
        FrmRecuperarContraseña.Show()
        Me.Hide()
    End Sub
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                Entrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class