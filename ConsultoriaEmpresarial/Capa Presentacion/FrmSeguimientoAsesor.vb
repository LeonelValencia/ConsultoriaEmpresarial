Imports System.ComponentModel

Public Class FrmSeguimientoAsesor
    Public Sub BorrarTodo(ByVal f As Form)
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub BtnEnviarSolConsultoria_Click(sender As Object, e As EventArgs) Handles BtnEnviarSolConsultoria.Click
        Try
            Dim ls As New LSeguimientos
            ls.InsertarSegui(txtIdCliente.Text, txtIdAsesor.Text, rtxtSeguimiento.Text)
            BorrarTodo(Me)
            rtxtSeguimiento.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmSeguimientoAsesor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
End Class