<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptarSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarPresupuestoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarAsesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuejasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarEnGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramarOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameUsuarioTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ConsultoriaToolStripMenuItem, Me.AsesoresToolStripMenuItem, Me.OTToolStripMenuItem, Me.nameUsuarioTSMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.AceptarSolicitudToolStripMenuItem, Me.AsignarPresupuestoToolStripMenuItem1, Me.AsignarAsesorToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ActualizarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'ActualizarToolStripMenuItem1
        '
        Me.ActualizarToolStripMenuItem1.Name = "ActualizarToolStripMenuItem1"
        Me.ActualizarToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.ActualizarToolStripMenuItem1.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'AceptarSolicitudToolStripMenuItem
        '
        Me.AceptarSolicitudToolStripMenuItem.Name = "AceptarSolicitudToolStripMenuItem"
        Me.AceptarSolicitudToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.AceptarSolicitudToolStripMenuItem.Text = "Aceptar Solicitud"
        '
        'AsignarPresupuestoToolStripMenuItem1
        '
        Me.AsignarPresupuestoToolStripMenuItem1.Name = "AsignarPresupuestoToolStripMenuItem1"
        Me.AsignarPresupuestoToolStripMenuItem1.Size = New System.Drawing.Size(226, 26)
        Me.AsignarPresupuestoToolStripMenuItem1.Text = "Asignar Presupuesto"
        '
        'AsignarAsesorToolStripMenuItem
        '
        Me.AsignarAsesorToolStripMenuItem.Name = "AsignarAsesorToolStripMenuItem"
        Me.AsignarAsesorToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.AsignarAsesorToolStripMenuItem.Text = "Asignar asesor"
        '
        'ConsultoriaToolStripMenuItem
        '
        Me.ConsultoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguimientoToolStripMenuItem, Me.QuejasToolStripMenuItem})
        Me.ConsultoriaToolStripMenuItem.Name = "ConsultoriaToolStripMenuItem"
        Me.ConsultoriaToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.ConsultoriaToolStripMenuItem.Text = "Consultoria"
        '
        'SeguimientoToolStripMenuItem
        '
        Me.SeguimientoToolStripMenuItem.Name = "SeguimientoToolStripMenuItem"
        Me.SeguimientoToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.SeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'QuejasToolStripMenuItem
        '
        Me.QuejasToolStripMenuItem.Name = "QuejasToolStripMenuItem"
        Me.QuejasToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.QuejasToolStripMenuItem.Text = "Quejas"
        '
        'AsesoresToolStripMenuItem
        '
        Me.AsesoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarEnGeneralToolStripMenuItem, Me.AsesoresToolStripMenuItem1})
        Me.AsesoresToolStripMenuItem.Name = "AsesoresToolStripMenuItem"
        Me.AsesoresToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.AsesoresToolStripMenuItem.Text = "Empleados"
        '
        'GestionarEnGeneralToolStripMenuItem
        '
        Me.GestionarEnGeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEmpleadoToolStripMenuItem, Me.ActualizarEmpleadoToolStripMenuItem, Me.EliminarEmpleadoToolStripMenuItem})
        Me.GestionarEnGeneralToolStripMenuItem.Name = "GestionarEnGeneralToolStripMenuItem"
        Me.GestionarEnGeneralToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.GestionarEnGeneralToolStripMenuItem.Text = "Gestionar en general"
        '
        'AgregarEmpleadoToolStripMenuItem
        '
        Me.AgregarEmpleadoToolStripMenuItem.Name = "AgregarEmpleadoToolStripMenuItem"
        Me.AgregarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.AgregarEmpleadoToolStripMenuItem.Text = "Agregar empleado"
        '
        'ActualizarEmpleadoToolStripMenuItem
        '
        Me.ActualizarEmpleadoToolStripMenuItem.Name = "ActualizarEmpleadoToolStripMenuItem"
        Me.ActualizarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ActualizarEmpleadoToolStripMenuItem.Text = "Actualizar empleado"
        '
        'EliminarEmpleadoToolStripMenuItem
        '
        Me.EliminarEmpleadoToolStripMenuItem.Name = "EliminarEmpleadoToolStripMenuItem"
        Me.EliminarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EliminarEmpleadoToolStripMenuItem.Text = "Eliminar empleado"
        '
        'AsesoresToolStripMenuItem1
        '
        Me.AsesoresToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ActualizarToolStripMenuItem2, Me.EliminarToolStripMenuItem2})
        Me.AsesoresToolStripMenuItem1.Name = "AsesoresToolStripMenuItem1"
        Me.AsesoresToolStripMenuItem1.Size = New System.Drawing.Size(229, 26)
        Me.AsesoresToolStripMenuItem1.Text = "Asesores"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ActualizarToolStripMenuItem2
        '
        Me.ActualizarToolStripMenuItem2.Name = "ActualizarToolStripMenuItem2"
        Me.ActualizarToolStripMenuItem2.Size = New System.Drawing.Size(158, 26)
        Me.ActualizarToolStripMenuItem2.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(158, 26)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'OTToolStripMenuItem
        '
        Me.OTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenSalidaToolStripMenuItem, Me.ConsultarOTToolStripMenuItem, Me.ProgramarOTToolStripMenuItem})
        Me.OTToolStripMenuItem.Name = "OTToolStripMenuItem"
        Me.OTToolStripMenuItem.Size = New System.Drawing.Size(41, 24)
        Me.OTToolStripMenuItem.Text = "OT"
        '
        'OrdenSalidaToolStripMenuItem
        '
        Me.OrdenSalidaToolStripMenuItem.Name = "OrdenSalidaToolStripMenuItem"
        Me.OrdenSalidaToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.OrdenSalidaToolStripMenuItem.Text = "Orden Salida"
        '
        'ConsultarOTToolStripMenuItem
        '
        Me.ConsultarOTToolStripMenuItem.Name = "ConsultarOTToolStripMenuItem"
        Me.ConsultarOTToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ConsultarOTToolStripMenuItem.Text = "Consultar OT"
        '
        'ProgramarOTToolStripMenuItem
        '
        Me.ProgramarOTToolStripMenuItem.Name = "ProgramarOTToolStripMenuItem"
        Me.ProgramarOTToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ProgramarOTToolStripMenuItem.Text = "Programar OT"
        '
        'nameUsuarioTSMenuItem
        '
        Me.nameUsuarioTSMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.nameUsuarioTSMenuItem.Name = "nameUsuarioTSMenuItem"
        Me.nameUsuarioTSMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.nameUsuarioTSMenuItem.Text = "Usuario"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'FrmInicioEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmInicioEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInicioEmpleado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nameUsuarioTSMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuejasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarOTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramarOTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AceptarSolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarPresupuestoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsignarAsesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarEnGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsesoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As ToolStripMenuItem
End Class
