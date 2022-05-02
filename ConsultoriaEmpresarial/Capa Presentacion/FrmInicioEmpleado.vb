Imports System.ComponentModel

Public Class FrmInicioEmpleado
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInsertarClienteAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmActualizarClienteAdm.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmEliminarClientesAdm.Show()
        Me.Hide()
    End Sub

    Private Sub FrmInicioEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Close()
    End Sub

    Private Sub AsignarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAsignarPresupuesto.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarAsesorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInsertarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmActualizarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmEliminarAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub AsignarAClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        FrmInsertarClienteAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem1.Click
        FrmActualizarClienteAdm.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        FrmEliminarClientesAdm.Show()
        Me.Hide()
    End Sub

    Private Sub AsignarPresupuestoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsignarPresupuestoToolStripMenuItem1.Click
        FrmAsignarPresupuesto.Show()
        Me.Hide()
    End Sub

    Private Sub AsignarAsesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarAsesorToolStripMenuItem.Click
        FrmAsignarAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        FrmInsertarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem2.Click
        FrmActualizarAsesores.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem2.Click
        FrmEliminarAsesor.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        FrmAgregarEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarEmpleadoToolStripMenuItem.Click
        FrmActualizarEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarEmpleadoToolStripMenuItem.Click
        FrmEliminarEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub AceptarSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarSolicitudToolStripMenuItem.Click
        FrmAceptarSolicitud.Show()
        Me.Hide()
    End Sub
End Class