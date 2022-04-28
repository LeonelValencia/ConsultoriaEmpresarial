<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main2SesionIniciada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main2SesionIniciada))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarConsultoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuejasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreNosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdClienteMain = New System.Windows.Forms.TextBox()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.SobreNosotrosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.NotificacionesToolStripMenuItem, Me.NombreDeUsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitarConsultoriaToolStripMenuItem, Me.PresupuestoToolStripMenuItem, Me.ModificarDatosToolStripMenuItem, Me.EliminarMiCuentaToolStripMenuItem, Me.QuejasToolStripMenuItem, Me.SeguimientoToolStripMenuItem, Me.StatusToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(93, 32)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'SolicitarConsultoriaToolStripMenuItem
        '
        Me.SolicitarConsultoriaToolStripMenuItem.Name = "SolicitarConsultoriaToolStripMenuItem"
        Me.SolicitarConsultoriaToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.SolicitarConsultoriaToolStripMenuItem.Text = "Solicitar consultoria"
        '
        'PresupuestoToolStripMenuItem
        '
        Me.PresupuestoToolStripMenuItem.Name = "PresupuestoToolStripMenuItem"
        Me.PresupuestoToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.PresupuestoToolStripMenuItem.Text = "Presupuesto"
        '
        'ModificarDatosToolStripMenuItem
        '
        Me.ModificarDatosToolStripMenuItem.Name = "ModificarDatosToolStripMenuItem"
        Me.ModificarDatosToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.ModificarDatosToolStripMenuItem.Text = "Modificar datos"
        '
        'EliminarMiCuentaToolStripMenuItem
        '
        Me.EliminarMiCuentaToolStripMenuItem.Name = "EliminarMiCuentaToolStripMenuItem"
        Me.EliminarMiCuentaToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.EliminarMiCuentaToolStripMenuItem.Text = "Eliminar mi cuenta"
        '
        'QuejasToolStripMenuItem
        '
        Me.QuejasToolStripMenuItem.Name = "QuejasToolStripMenuItem"
        Me.QuejasToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.QuejasToolStripMenuItem.Text = "Quejas"
        '
        'SeguimientoToolStripMenuItem
        '
        Me.SeguimientoToolStripMenuItem.Name = "SeguimientoToolStripMenuItem"
        Me.SeguimientoToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.SeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'SobreNosotrosToolStripMenuItem
        '
        Me.SobreNosotrosToolStripMenuItem.Name = "SobreNosotrosToolStripMenuItem"
        Me.SobreNosotrosToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.SobreNosotrosToolStripMenuItem.Text = "Sobre nosotros"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(82, 32)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'NotificacionesToolStripMenuItem
        '
        Me.NotificacionesToolStripMenuItem.Image = CType(resources.GetObject("NotificacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotificacionesToolStripMenuItem.Name = "NotificacionesToolStripMenuItem"
        Me.NotificacionesToolStripMenuItem.Size = New System.Drawing.Size(34, 32)
        '
        'NombreDeUsuarioToolStripMenuItem
        '
        Me.NombreDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.NombreDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NombreDeUsuarioToolStripMenuItem.Name = "NombreDeUsuarioToolStripMenuItem"
        Me.NombreDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.NombreDeUsuarioToolStripMenuItem.Text = "Nombre de usuario"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.CerrarSesionToolStripMenuItem.Text = "cerrar sesion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(682, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Cliente="
        '
        'txtIdClienteMain
        '
        Me.txtIdClienteMain.Enabled = False
        Me.txtIdClienteMain.Location = New System.Drawing.Point(759, 72)
        Me.txtIdClienteMain.Name = "txtIdClienteMain"
        Me.txtIdClienteMain.Size = New System.Drawing.Size(100, 22)
        Me.txtIdClienteMain.TabIndex = 2
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'Main2SesionIniciada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 450)
        Me.Controls.Add(Me.txtIdClienteMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main2SesionIniciada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main2SesionIniciada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarConsultoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMiCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NombreDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreNosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdClienteMain As TextBox
    Friend WithEvents QuejasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
End Class
