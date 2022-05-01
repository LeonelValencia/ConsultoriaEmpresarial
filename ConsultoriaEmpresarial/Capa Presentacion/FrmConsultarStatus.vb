Imports System.ComponentModel

Public Class FrmConsultarStatus
    Private Sub FrmConsultarStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtIdCliente.Text = Main2SesionIniciada.txtIdClienteMain.Text
            Dim idCl = txtIdCliente.Text
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.ConsultarStatus(idCl)
            dgvSolCliente.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvSolCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolCliente.CellClick
        Try
            Dim le As New LEmpleados
            txtEstado.Text = dgvSolCliente.CurrentRow.Cells(3).Value.ToString
            TxtPresupuesto.Text = dgvSolCliente.CurrentRow.Cells(4).Value.ToString
            TxtPagado.Text = dgvSolCliente.CurrentRow.Cells(5).Value.ToString
            TxtIdAsesor.Text = dgvSolCliente.CurrentRow.Cells(6).Value.ToString
            If TxtIdAsesor.Text = "" Then
                TxtNameAsesor.Text = "No te han asignado un asesor"
            Else
                Dim dt1 As DataTable = le.ConsultarNamesById(TxtIdAsesor.Text)
                Dim dr As DataRow = dt1.Rows.Item(0)
                TxtNameAsesor.Text = dr.Item("nombre")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmConsultarStatus_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub
End Class