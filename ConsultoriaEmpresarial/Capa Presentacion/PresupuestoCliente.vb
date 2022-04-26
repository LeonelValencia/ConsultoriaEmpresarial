Imports System.ComponentModel

Public Class PresupuestoCliente
    Private Sub ListarIdSolConsul()
        Try
            Dim lsc As New LSolConsul
            Dim ds = lsc.SelectIdSolConsul(txtIdCliente.Text)
            cbIdSolConsul.DataSource = ds.Tables(0)
            cbIdSolConsul.ValueMember = "idSC"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PresupuestoCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main2SesionIniciada.Show()
    End Sub

    Private Sub PresupuestoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarIdSolConsul()
        If txtIdCliente.Text = "" Then
            txtIdCliente.Text = Main2SesionIniciada.txtIdClienteMain.Text
        End If
    End Sub

    Private Sub btnBuscarConsul_Click(sender As Object, e As EventArgs) Handles btnBuscarConsul.Click
        Try
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.SelectAllIdSol(cbIdSolConsul.Text)
            Dim dr As DataRow = dt.Rows.Item(0)
            txtNece.Text = dr.Item("necesidad")
            If dr.Item("presupuesto").ToString = "" Then
                txtTotal.Text = ""
                MsgBox("Todavia no te han asignado un presupuesto")
            Else
                txtTotal.Text = dr.Item("presupuesto")
            End If
            txtTotal.Text = dr.Item("presupuesto")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarSolConsultoria_Click(sender As Object, e As EventArgs) Handles btnEnviarSolConsultoria.Click
        Try
            Dim ls As New LSolConsul
            If txtTotal.Text = "" Then
                MsgBox("No se puede pagar porque no te han asignado un presupuesto")
            Else
                ls.Pagar(cbIdSolConsul.Text)
                txtNece.Clear()
                txtTotal.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class