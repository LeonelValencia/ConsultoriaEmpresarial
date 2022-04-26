Imports System.ComponentModel
Public Class OrdenSalida
    Private Sub ConsultarNamesClientes()
        Try
            Dim lc As New LClientes
            Dim ds = lc.ConsultarAllNamesCl
            CbNameCliente.DataSource = ds.Tables(0)
            CbNameCliente.ValueMember = "nomC"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultarNamesEmpleados()
        Try
            Dim le As New LEmpleados
            Dim ds = le.ConsultarAllNamesEm
            CBNamePersonal.DataSource = ds.Tables(0)
            CBNamePersonal.ValueMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub OrdenSalida_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim lOrden As New LOT()
            lOrden.insertarOT(txtIdOT.Text, CbNameCliente.Text, CBNamePersonal.Text, cbPago.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Iniciar_sesion.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub txtIdOT_Enter(sender As Object, e As EventArgs) Handles txtIdOT.Enter
        If txtIdOT.Text = "Id de la OT" Then
            txtIdOT.Text = ""
            txtIdOT.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtIdOT_Leave(sender As Object, e As EventArgs) Handles txtIdOT.Leave
        If txtIdOT.Text = "" Then
            txtIdOT.Text = "Id de la OT"
            txtIdOT.ForeColor = SystemColors.ActiveCaption
        End If
    End Sub

    Private Sub OrdenSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarNamesClientes()
        ConsultarNamesEmpleados()
    End Sub
End Class