<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarDatosCliente
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
        Me.txtNomEmCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccionEmpCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContraseñaCliente
        '
        Me.txtContraseñaCliente.Location = New System.Drawing.Point(368, 359)
        Me.txtContraseñaCliente.Name = "txtContraseñaCliente"
        Me.txtContraseñaCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtContraseñaCliente.TabIndex = 34
        '
        'txtUsuarioCliente
        '
        Me.txtUsuarioCliente.Location = New System.Drawing.Point(368, 320)
        Me.txtUsuarioCliente.Name = "txtUsuarioCliente"
        Me.txtUsuarioCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtUsuarioCliente.TabIndex = 33
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(368, 283)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtEmailCliente.TabIndex = 32
        '
        'txtNomEmCliente
        '
        Me.txtNomEmCliente.Location = New System.Drawing.Point(368, 244)
        Me.txtNomEmCliente.Name = "txtNomEmCliente"
        Me.txtNomEmCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNomEmCliente.TabIndex = 31
        '
        'txtDireccionEmpCliente
        '
        Me.txtDireccionEmpCliente.Location = New System.Drawing.Point(368, 207)
        Me.txtDireccionEmpCliente.Name = "txtDireccionEmpCliente"
        Me.txtDireccionEmpCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtDireccionEmpCliente.TabIndex = 30
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(368, 170)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtTelefonoCliente.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nombre de usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Correo electronico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nombre de la empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Direccion de la empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre"
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarCliente.Location = New System.Drawing.Point(287, 396)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(228, 42)
        Me.btnModificarCliente.TabIndex = 21
        Me.btnModificarCliente.Text = "Guardar cambios"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(368, 133)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtNombreCliente.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 54)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Modificar datos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(135, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(368, 95)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(482, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Ingresa tu ID y despues da un TAB para que todo se acomplete"
        '
        'ModificarDatosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtContraseñaCliente)
        Me.Controls.Add(Me.txtUsuarioCliente)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.txtNomEmCliente)
        Me.Controls.Add(Me.txtDireccionEmpCliente)
        Me.Controls.Add(Me.txtTelefonoCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarDatosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarDatosCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContraseñaCliente As TextBox
    Friend WithEvents txtUsuarioCliente As TextBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtNomEmCliente As TextBox
    Friend WithEvents txtDireccionEmpCliente As TextBox
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label10 As Label
End Class
