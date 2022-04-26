<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelCliente = New System.Windows.Forms.TextBox()
        Me.txtDirEmpC = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpCliente = New System.Windows.Forms.TextBox()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtUsuarioCliente = New System.Windows.Forms.TextBox()
        Me.txtContraseñaCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(241, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registrarse"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(358, 108)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNombreCliente.TabIndex = 4
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(277, 388)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(228, 50)
        Me.btnRegistrarCliente.TabIndex = 5
        Me.btnRegistrarCliente.Text = "Enviar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direccion de la empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre de la empresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(125, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Correo electronico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(125, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nombre de usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Contraseña"
        '
        'txtTelCliente
        '
        Me.txtTelCliente.Location = New System.Drawing.Point(358, 153)
        Me.txtTelCliente.Name = "txtTelCliente"
        Me.txtTelCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtTelCliente.TabIndex = 13
        '
        'txtDirEmpC
        '
        Me.txtDirEmpC.Location = New System.Drawing.Point(358, 194)
        Me.txtDirEmpC.Name = "txtDirEmpC"
        Me.txtDirEmpC.Size = New System.Drawing.Size(297, 22)
        Me.txtDirEmpC.TabIndex = 14
        '
        'txtNombreEmpCliente
        '
        Me.txtNombreEmpCliente.Location = New System.Drawing.Point(358, 238)
        Me.txtNombreEmpCliente.Name = "txtNombreEmpCliente"
        Me.txtNombreEmpCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNombreEmpCliente.TabIndex = 15
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(358, 277)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtEmailCliente.TabIndex = 16
        '
        'txtUsuarioCliente
        '
        Me.txtUsuarioCliente.Location = New System.Drawing.Point(358, 312)
        Me.txtUsuarioCliente.Name = "txtUsuarioCliente"
        Me.txtUsuarioCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtUsuarioCliente.TabIndex = 17
        '
        'txtContraseñaCliente
        '
        Me.txtContraseñaCliente.Location = New System.Drawing.Point(358, 349)
        Me.txtContraseñaCliente.Name = "txtContraseñaCliente"
        Me.txtContraseñaCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtContraseñaCliente.TabIndex = 18
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtContraseñaCliente)
        Me.Controls.Add(Me.txtUsuarioCliente)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.txtNombreEmpCliente)
        Me.Controls.Add(Me.txtDirEmpC)
        Me.Controls.Add(Me.txtTelCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarCliente"
        Me.Text = "RegistrarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelCliente As TextBox
    Friend WithEvents txtDirEmpC As TextBox
    Friend WithEvents txtNombreEmpCliente As TextBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtUsuarioCliente As TextBox
    Friend WithEvents txtContraseñaCliente As TextBox
End Class
