Imports System.ComponentModel

Public Class FrmQuejasAsesor
    Private Sub CargarQuejas()
        Try
            Dim lqu As New LQuejas
            Dim dt As DataTable = lqu.SelectQuejas
            dgvQuejas.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEnviarSolConsultoria_Click(sender As Object, e As EventArgs) Handles btnEnviarSolConsultoria.Click
        Try
            Dim lqu As New LQuejas
            Dim dt As DataTable = lqu.SelectQuejaIdCl(txtIdCliente.Text)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtQueja.Text = dr.Item("queja")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmQuejasAsesor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmInicioEmpleado.Show()
    End Sub
    Private Sub FrmQuejasAsesor_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarQuejas()
    End Sub
End Class