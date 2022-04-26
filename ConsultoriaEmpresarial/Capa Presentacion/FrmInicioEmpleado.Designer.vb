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
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuejasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarAsesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarAClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameUsuarioTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ConsultoriaToolStripMenuItem, Me.AsesoresToolStripMenuItem, Me.nameUsuarioTSMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.ActualizarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(75, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'ActualizarClienteToolStripMenuItem
        '
        Me.ActualizarClienteToolStripMenuItem.Name = "ActualizarClienteToolStripMenuItem"
        Me.ActualizarClienteToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.ActualizarClienteToolStripMenuItem.Text = "Actualizar cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar cliente"
        '
        'ConsultoriaToolStripMenuItem
        '
        Me.ConsultoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarPresupuestoToolStripMenuItem, Me.SeguimientoToolStripMenuItem, Me.QuejasToolStripMenuItem})
        Me.ConsultoriaToolStripMenuItem.Name = "ConsultoriaToolStripMenuItem"
        Me.ConsultoriaToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.ConsultoriaToolStripMenuItem.Text = "Consultoria"
        '
        'AsignarPresupuestoToolStripMenuItem
        '
        Me.AsignarPresupuestoToolStripMenuItem.Name = "AsignarPresupuestoToolStripMenuItem"
        Me.AsignarPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.AsignarPresupuestoToolStripMenuItem.Text = "Asignar presupuesto"
        '
        'SeguimientoToolStripMenuItem
        '
        Me.SeguimientoToolStripMenuItem.Name = "SeguimientoToolStripMenuItem"
        Me.SeguimientoToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'QuejasToolStripMenuItem
        '
        Me.QuejasToolStripMenuItem.Name = "QuejasToolStripMenuItem"
        Me.QuejasToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.QuejasToolStripMenuItem.Text = "Quejas"
        '
        'AsesoresToolStripMenuItem
        '
        Me.AsesoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarAsesorToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.AsignarAClienteToolStripMenuItem})
        Me.AsesoresToolStripMenuItem.Name = "AsesoresToolStripMenuItem"
        Me.AsesoresToolStripMenuItem.Size = New System.Drawing.Size(81, 26)
        Me.AsesoresToolStripMenuItem.Text = "Asesores"
        '
        'AgregarAsesorToolStripMenuItem
        '
        Me.AgregarAsesorToolStripMenuItem.Name = "AgregarAsesorToolStripMenuItem"
        Me.AgregarAsesorToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AgregarAsesorToolStripMenuItem.Text = "Agregar asesor"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'AsignarAClienteToolStripMenuItem
        '
        Me.AsignarAClienteToolStripMenuItem.Name = "AsignarAClienteToolStripMenuItem"
        Me.AsignarAClienteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AsignarAClienteToolStripMenuItem.Text = "Asignar a cliente"
        '
        'nameUsuarioTSMenuItem
        '
        Me.nameUsuarioTSMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.nameUsuarioTSMenuItem.Name = "nameUsuarioTSMenuItem"
        Me.nameUsuarioTSMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.nameUsuarioTSMenuItem.Text = "Usuario"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.Text = "FrmInicioEmpleado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nameUsuarioTSMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarPresupuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarAsesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarAClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuejasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
