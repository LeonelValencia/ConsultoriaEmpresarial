<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertarClienteAdmin
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
        Me.txtContraseñaCliente = New System.Windows.Forms.TextBox()
        Me.txtUsuarioCliente = New System.Windows.Forms.TextBox()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpCliente = New System.Windows.Forms.TextBox()
        Me.txtDirEmpC = New System.Windows.Forms.TextBox()
        Me.txtTelCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvConsultarClientes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContraseñaCliente
        '
        Me.txtContraseñaCliente.Location = New System.Drawing.Point(605, 118)
        Me.txtContraseñaCliente.Name = "txtContraseñaCliente"
        Me.txtContraseñaCliente.Size = New System.Drawing.Size(143, 22)
        Me.txtContraseñaCliente.TabIndex = 34
        '
        'txtUsuarioCliente
        '
        Me.txtUsuarioCliente.Location = New System.Drawing.Point(211, 117)
        Me.txtUsuarioCliente.Name = "txtUsuarioCliente"
        Me.txtUsuarioCliente.Size = New System.Drawing.Size(262, 22)
        Me.txtUsuarioCliente.TabIndex = 33
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(205, 153)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(255, 22)
        Me.txtEmailCliente.TabIndex = 32
        '
        'txtNombreEmpCliente
        '
        Me.txtNombreEmpCliente.Location = New System.Drawing.Point(123, 207)
        Me.txtNombreEmpCliente.Name = "txtNombreEmpCliente"
        Me.txtNombreEmpCliente.Size = New System.Drawing.Size(184, 22)
        Me.txtNombreEmpCliente.TabIndex = 31
        '
        'txtDirEmpC
        '
        Me.txtDirEmpC.Location = New System.Drawing.Point(413, 204)
        Me.txtDirEmpC.Name = "txtDirEmpC"
        Me.txtDirEmpC.Size = New System.Drawing.Size(297, 22)
        Me.txtDirEmpC.TabIndex = 30
        '
        'txtTelCliente
        '
        Me.txtTelCliente.Location = New System.Drawing.Point(541, 80)
        Me.txtTelCliente.Name = "txtTelCliente"
        Me.txtTelCliente.Size = New System.Drawing.Size(210, 22)
        Me.txtTelCliente.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(485, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nombre de usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Correo electronico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nombre "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre"
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(797, 179)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(228, 50)
        Me.btnRegistrarCliente.TabIndex = 21
        Me.btnRegistrarCliente.Text = "Enviar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(115, 80)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNombreCliente.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(338, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 54)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Registrar cliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(360, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Datos de su empresa________________________________"
        '
        'dgvConsultarClientes
        '
        Me.dgvConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultarClientes.Location = New System.Drawing.Point(12, 297)
        Me.dgvConsultarClientes.Name = "dgvConsultarClientes"
        Me.dgvConsultarClientes.RowHeadersWidth = 51
        Me.dgvConsultarClientes.RowTemplate.Height = 24
        Me.dgvConsultarClientes.Size = New System.Drawing.Size(1038, 226)
        Me.dgvConsultarClientes.TabIndex = 36
        '
        'FrmInsertarClienteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 553)
        Me.Controls.Add(Me.txtDirEmpC)
        Me.Controls.Add(Me.txtNombreEmpCliente)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.txtContraseñaCliente)
        Me.Controls.Add(Me.txtUsuarioCliente)
        Me.Controls.Add(Me.txtTelCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.dgvConsultarClientes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInsertarClienteAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInsertarClienteAdmin"
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContraseñaCliente As TextBox
    Friend WithEvents txtUsuarioCliente As TextBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtNombreEmpCliente As TextBox
    Friend WithEvents txtDirEmpC As TextBox
    Friend WithEvents txtTelCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvConsultarClientes As DataGridView
End Class
