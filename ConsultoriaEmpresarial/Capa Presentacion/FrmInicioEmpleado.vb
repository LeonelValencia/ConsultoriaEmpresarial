Imports System.ComponentModel

Public Class FrmInicioEmpleado
    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInsertarClienteAdmin.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmActualizarClienteAdm.Show()
        Me.Close()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmEliminarClientesAdm.Show()
        Me.Close()
    End Sub

    Private Sub FrmInicioEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub AsignarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAsignarPresupuesto.Show()
        Me.Close()
    End Sub

    Private Sub AgregarAsesorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInsertarAsesores.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmActualizarAsesores.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmEliminarAsesor.Show()
        Me.Close()
    End Sub

    Private Sub AsignarAClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAsignarAsesor.Show()
        Me.Close()
    End Sub

    Private Sub QuejasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasToolStripMenuItem.Click
        FrmQuejasAsesor.Show()
        Me.Close()
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        FrmSeguimientoAsesor.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub OrdenSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenSalidaToolStripMenuItem.Click
        OrdenSalida.Show()
        Me.Close()
    End Sub

    Private Sub ConsultarOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarOTToolStripMenuItem.Click
        ConsultarOT.Show()
        Me.Close()
    End Sub

    Private Sub ProgramarOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarOTToolStripMenuItem.Click
        ProgramarOT.Show()
        Me.Close()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        FrmInsertarClienteAdmin.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem1.Click
        FrmActualizarClienteAdm.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        FrmEliminarClientesAdm.Show()
        Me.Close()
    End Sub

    Private Sub AsignarPresupuestoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsignarPresupuestoToolStripMenuItem1.Click
        FrmAsignarPresupuesto.Show()
        Me.Close()
    End Sub

    Private Sub AsignarAsesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarAsesorToolStripMenuItem.Click
        FrmAsignarAsesor.Show()
        Me.Close()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        FrmInsertarAsesores.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem2.Click
        FrmActualizarAsesores.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem2.Click
        FrmEliminarAsesor.Show()
        Me.Close()
    End Sub

    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        FrmAgregarEmpleado.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarEmpleadoToolStripMenuItem.Click
        FrmActualizarEmpleados.Show()
        Me.Close()
    End Sub

    Private Sub EliminarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarEmpleadoToolStripMenuItem.Click
        FrmEliminarEmpleados.Show()
        Me.Close()
    End Sub
End Class