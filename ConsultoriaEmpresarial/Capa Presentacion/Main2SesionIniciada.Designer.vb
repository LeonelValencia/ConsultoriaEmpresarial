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
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreNosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtIdClienteMain = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvSolCliente = New System.Windows.Forms.DataGridView()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.LblNameAsesor = New System.Windows.Forms.Label()
        Me.LblIdAsesor = New System.Windows.Forms.Label()
        Me.LblPagado = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSolCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(271, 32)
        Me.StatusToolStripMenuItem.Text = "Status"
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
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.CerrarSesionToolStripMenuItem.Text = "cerrar sesion"
        '
        'txtIdClienteMain
        '
        Me.txtIdClienteMain.Enabled = False
        Me.txtIdClienteMain.Location = New System.Drawing.Point(140, 172)
        Me.txtIdClienteMain.Name = "txtIdClienteMain"
        Me.txtIdClienteMain.Size = New System.Drawing.Size(100, 22)
        Me.txtIdClienteMain.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Nombre del asesor="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Id Asesor="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Pagado="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Presupuesto="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Estado Solicitud="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "ID Cliente="
        '
        'dgvSolCliente
        '
        Me.dgvSolCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSolCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSolCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolCliente.Location = New System.Drawing.Point(8, 63)
        Me.dgvSolCliente.Name = "dgvSolCliente"
        Me.dgvSolCliente.ReadOnly = True
        Me.dgvSolCliente.RowHeadersWidth = 51
        Me.dgvSolCliente.RowTemplate.Height = 24
        Me.dgvSolCliente.Size = New System.Drawing.Size(862, 95)
        Me.dgvSolCliente.TabIndex = 44
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblEstado.Location = New System.Drawing.Point(137, 219)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(179, 16)
        Me.LblEstado.TabIndex = 57
        Me.LblEstado.Text = "No has solicitado consultoria"
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblPresupuesto.Location = New System.Drawing.Point(137, 257)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(202, 16)
        Me.LblPresupuesto.TabIndex = 58
        Me.LblPresupuesto.Text = "No te han asignado presupuesto"
        '
        'LblNameAsesor
        '
        Me.LblNameAsesor.AutoSize = True
        Me.LblNameAsesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblNameAsesor.Location = New System.Drawing.Point(444, 331)
        Me.LblNameAsesor.Name = "LblNameAsesor"
        Me.LblNameAsesor.Size = New System.Drawing.Size(186, 16)
        Me.LblNameAsesor.TabIndex = 60
        Me.LblNameAsesor.Text = "No te han asignado un asesor"
        '
        'LblIdAsesor
        '
        Me.LblIdAsesor.AutoSize = True
        Me.LblIdAsesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblIdAsesor.Location = New System.Drawing.Point(137, 334)
        Me.LblIdAsesor.Name = "LblIdAsesor"
        Me.LblIdAsesor.Size = New System.Drawing.Size(14, 16)
        Me.LblIdAsesor.TabIndex = 62
        Me.LblIdAsesor.Text = "0"
        '
        'LblPagado
        '
        Me.LblPagado.AutoSize = True
        Me.LblPagado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblPagado.Location = New System.Drawing.Point(137, 295)
        Me.LblPagado.Name = "LblPagado"
        Me.LblPagado.Size = New System.Drawing.Size(25, 16)
        Me.LblPagado.TabIndex = 63
        Me.LblPagado.Text = "No"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(382, 376)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(95, 31)
        Me.BtnActualizar.TabIndex = 64
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Main2SesionIniciada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 450)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LblPagado)
        Me.Controls.Add(Me.LblIdAsesor)
        Me.Controls.Add(Me.LblNameAsesor)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvSolCliente)
        Me.Controls.Add(Me.txtIdClienteMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main2SesionIniciada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main2SesionIniciada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSolCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtIdClienteMain As TextBox
    Friend WithEvents QuejasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvSolCliente As DataGridView
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblPresupuesto As Label
    Friend WithEvents LblNameAsesor As Label
    Friend WithEvents LblIdAsesor As Label
    Friend WithEvents LblPagado As Label
    Friend WithEvents BtnActualizar As Button
End Class
