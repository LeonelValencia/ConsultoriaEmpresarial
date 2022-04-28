Public Class FrmAceptarSolicitud
    Private Sub ConsultarEstados()
        Try
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.ConsultarEstados
            dgvNece.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizarEstado(estado As String)
        Try
            Dim ls As New LSolConsul
            ls.ActualizarEstado(estado, txtIdSol.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ActualizarEstado("Aceptado")
        ConsultarEstados()
    End Sub

    Private Sub BtnRechazar_Click(sender As Object, e As EventArgs) Handles BtnRechazar.Click
        ActualizarEstado("Rechazado")
        ConsultarEstados()
    End Sub

    Private Sub FrmAceptarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarEstados()
    End Sub
    Private Sub dgvNece_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNece.CellClick
        txtIdSol.Text = dgvNece.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class