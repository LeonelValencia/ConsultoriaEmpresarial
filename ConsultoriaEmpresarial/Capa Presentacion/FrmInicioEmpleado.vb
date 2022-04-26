Imports System.ComponentModel

Public Class FrmInicioEmpleado
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        FrmInsertarClienteAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarClienteToolStripMenuItem.Click
        FrmActualizarClienteAdm.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        FrmEliminarClientesAdm.Show()
        Me.Hide()
    End Sub

    Private Sub FrmInicioEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Close()
    End Sub

    Private Sub AsignarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarPresupuestoToolStripMenuItem.Click
        FrmAsignarPresupuesto.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarAsesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAsesorToolStripMenuItem.Click
        FrmInsertarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        FrmActualizarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        FrmEliminarAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub AsignarAClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarAClienteToolStripMenuItem.Click
        FrmAsignarAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub QuejasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasToolStripMenuItem.Click
        FrmQuejasAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        FrmSeguimientoAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub OrdenSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenSalidaToolStripMenuItem.Click
        OrdenSalida.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarOTToolStripMenuItem.Click
        ConsultarOT.Show()
        Me.Hide()
    End Sub

    Private Sub ProgramarOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarOTToolStripMenuItem.Click
        ProgramarOT.Show()
        Me.Hide()
    End Sub
End Class