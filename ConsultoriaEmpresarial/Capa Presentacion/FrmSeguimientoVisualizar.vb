Imports System.ComponentModel

Public Class FrmSeguimientoVisualizar
    Private Sub FrmSeguimientoVisualizar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub
    Private Sub btnBuscarSeguimiento_Click(sender As Object, e As EventArgs) Handles btnBuscarSeguimiento.Click
        Try
            Dim ls As New LSeguimientos
            Dim dt As DataTable = ls.SelectSeguimientoIdCl(txtIdCliente.Text)
            Dim n As Integer = dt.Rows.Count - 1
            Dim filas(n) As DataRow
            Console.WriteLine("no.seguimientos: " & n)
            Dim segs As String = ""
            For i As Integer = 0 To n
                filas(i) = dt.Rows.Item(i)
                segs = segs & vbNewLine & filas(i).Item("seguimiento")
            Next
            rtxtSeguimiento.Text = segs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class