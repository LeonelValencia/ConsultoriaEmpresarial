Imports System.ComponentModel

Public Class FrmQuejaCliente
    Public Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Try
            Dim lqu As New LQuejas()
            lqu.InsertarQueja(txtIdCliente.Text, txtIdAsesor.Text, txtQueja.Text)
            BorrarTodo(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmQuejaCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub
End Class