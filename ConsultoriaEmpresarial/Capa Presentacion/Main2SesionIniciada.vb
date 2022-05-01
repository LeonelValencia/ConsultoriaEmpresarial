Imports System.ComponentModel

Public Class Main2SesionIniciada
    Private Sub ConsultarDatos()
        Try
            If dgvSolCliente.RowCount <= 1 Then
                LblEstado.ForeColor = Color.Red
                LblEstado.Text = "No has solicitado consultoria"
                LblPresupuesto.ForeColor = Color.Red
                LblPresupuesto.Text = "No te han asignado un presupuesto"
                LblNameAsesor.ForeColor = Color.Red
                LblNameAsesor.Text = "No te han asignado un asesor"
            Else
                Dim le As New LEmpleados
                LblEstado.ForeColor = Color.Blue
                If dgvSolCliente.CurrentRow.Cells(3).Value.ToString = "En espera" Then
                    LblEstado.ForeColor = Color.Red
                Else
                    LblEstado.ForeColor = Color.Blue
                End If
                LblEstado.Text = dgvSolCliente.CurrentRow.Cells(3).Value.ToString
                LblPagado.Text = dgvSolCliente.CurrentRow.Cells(5).Value.ToString
                LblIdAsesor.Text = dgvSolCliente.CurrentRow.Cells(6).Value.ToString
                If dgvSolCliente.CurrentRow.Cells(4).Value.ToString = "" Then
                    LblPresupuesto.ForeColor = Color.Red
                    LblPresupuesto.Text = "No te han asignado un presupuesto"
                Else
                    LblPresupuesto.ForeColor = Color.Blue
                    LblPresupuesto.Text = dgvSolCliente.CurrentRow.Cells(4).Value.ToString
                End If

                If dgvSolCliente.CurrentRow.Cells(6).Value.ToString = "" Then
                    LblIdAsesor.Text = "0"
                End If

                If LblIdAsesor.Text = "0" Then
                    LblNameAsesor.ForeColor = Color.Red
                    LblNameAsesor.Text = "No te han asignado un asesor"
                Else
                    Dim dt1 As DataTable = le.ConsultarNamesById(LblIdAsesor.Text)
                    Dim dr As DataRow = dt1.Rows.Item(0)
                    LblNameAsesor.ForeColor = Color.Blue
                    LblNameAsesor.Text = dr.Item("nombre")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LimpiarTodo()
        LblEstado.Text = ""
        LblIdAsesor.Text = ""
        LblNameAsesor.Text = ""
        LblPagado.Text = ""
        LblPresupuesto.Text = ""
        dgvSolCliente.Columns.Clear()
    End Sub
    Private Sub SolicitarConsultoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarConsultoriaToolStripMenuItem.Click
        SolicitarConsultoria.Show()
        Me.Hide()
    End Sub

    Private Sub PresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestoToolStripMenuItem.Click
        PresupuestoCliente.Show()
        Me.Hide()
    End Sub

    Private Sub ModificarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosToolStripMenuItem.Click
        ModificarDatosCliente.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarMiCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMiCuentaToolStripMenuItem.Click
        EliminarCliente.Show()
        Me.Hide()
    End Sub

    Private Sub OrdenDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OrdenSalida.Show()
        Me.Hide()
    End Sub

    Private Sub ProgramarOTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ProgramarOT.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarOTsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConsultarOT.Show()
        Me.Hide()
    End Sub
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        LimpiarTodo()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Main2SesionIniciada_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Close()
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        FrmSeguimientoVisualizar.Show()
        Me.Hide()
    End Sub

    Private Sub QuejasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasToolStripMenuItem.Click
        FrmQuejaCliente.Show()
        Me.Hide()
    End Sub

    Private Sub SobreNosotrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreNosotrosToolStripMenuItem.Click
        FrmAcercaDe.Show()
        Me.Hide()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        FrmAyuda.Show()
        Me.Hide()
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        FrmConsultarStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Main2SesionIniciada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim idCl = txtIdClienteMain.Text
            Dim ls As New LSolConsul
            Dim dt As DataTable = ls.ConsultarStatus(idCl)
            dgvSolCliente.DataSource = dt
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvSolCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolCliente.CellClick
        Try
            ConsultarDatos()
        Catch ex As Exception
            MsgBox("No has solicitado consultoria")
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Dim idCl = txtIdClienteMain.Text
            Dim ls As New LSolConsul
            Dim le As New LEmpleados
            Dim dt As DataTable = ls.ConsultarStatus(idCl)
            dgvSolCliente.DataSource = dt
            ConsultarDatos()
        Catch ex As NullReferenceException
            MsgBox("No has solicitado consultoria")
        End Try
    End Sub
End Class