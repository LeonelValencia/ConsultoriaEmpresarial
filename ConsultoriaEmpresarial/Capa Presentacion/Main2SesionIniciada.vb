Imports System.ComponentModel

Public Class Main2SesionIniciada
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
End Class