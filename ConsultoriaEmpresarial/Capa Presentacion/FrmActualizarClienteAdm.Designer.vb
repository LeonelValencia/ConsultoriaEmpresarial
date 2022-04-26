<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarClienteAdm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuarioCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContraseñaCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreEmpCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDirEmpC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvConsultarClientes = New System.Windows.Forms.DataGridView()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(324, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 54)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Actualizar cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(115, 76)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNombreCliente.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre"
        '
        'txtTelCliente
        '
        Me.txtTelCliente.Location = New System.Drawing.Point(608, 76)
        Me.txtTelCliente.Name = "txtTelCliente"
        Me.txtTelCliente.Size = New System.Drawing.Size(210, 22)
        Me.txtTelCliente.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Telefono"
        '
        'txtUsuarioCliente
        '
        Me.txtUsuarioCliente.Location = New System.Drawing.Point(211, 118)
        Me.txtUsuarioCliente.Name = "txtUsuarioCliente"
        Me.txtUsuarioCliente.Size = New System.Drawing.Size(262, 22)
        Me.txtUsuarioCliente.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nombre de usuario"
        '
        'txtContraseñaCliente
        '
        Me.txtContraseñaCliente.Location = New System.Drawing.Point(629, 118)
        Me.txtContraseñaCliente.Name = "txtContraseñaCliente"
        Me.txtContraseñaCliente.Size = New System.Drawing.Size(143, 22)
        Me.txtContraseñaCliente.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(509, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Contraseña"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(202, 163)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(255, 22)
        Me.txtEmailCliente.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Correo electronico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(360, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Datos de su empresa________________________________"
        '
        'txtNombreEmpCliente
        '
        Me.txtNombreEmpCliente.Location = New System.Drawing.Point(115, 237)
        Me.txtNombreEmpCliente.Name = "txtNombreEmpCliente"
        Me.txtNombreEmpCliente.Size = New System.Drawing.Size(184, 22)
        Me.txtNombreEmpCliente.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Nombre "
        '
        'txtDirEmpC
        '
        Me.txtDirEmpC.Location = New System.Drawing.Point(427, 237)
        Me.txtDirEmpC.Name = "txtDirEmpC"
        Me.txtDirEmpC.Size = New System.Drawing.Size(297, 22)
        Me.txtDirEmpC.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Direccion"
        '
        'dgvConsultarClientes
        '
        Me.dgvConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultarClientes.Location = New System.Drawing.Point(12, 305)
        Me.dgvConsultarClientes.Name = "dgvConsultarClientes"
        Me.dgvConsultarClientes.ReadOnly = True
        Me.dgvConsultarClientes.RowHeadersWidth = 51
        Me.dgvConsultarClientes.RowTemplate.Height = 24
        Me.dgvConsultarClientes.Size = New System.Drawing.Size(1058, 226)
        Me.dgvConsultarClientes.TabIndex = 45
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarCliente.Location = New System.Drawing.Point(788, 223)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(228, 42)
        Me.btnModificarCliente.TabIndex = 46
        Me.btnModificarCliente.Text = "Guardar cambios"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 25)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(66, 40)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(745, 20)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Seleccione el cliente que quiere modificar en la tabla de abajo para que se acomp" &
    "leten los campos"
        '
        'FrmActualizarClienteAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 553)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.dgvConsultarClientes)
        Me.Controls.Add(Me.txtDirEmpC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreEmpCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContraseñaCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUsuarioCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmActualizarClienteAdm"
        Me.Text = "FrmActualizarClienteAdm"
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuarioCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContraseñaCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreEmpCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDirEmpC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvConsultarClientes As DataGridView
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label11 As Label
End Class
