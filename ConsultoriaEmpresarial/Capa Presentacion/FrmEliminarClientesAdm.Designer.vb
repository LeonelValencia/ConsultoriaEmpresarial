<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarClientesAdm
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
        Me.dgvConsultarClientes = New System.Windows.Forms.DataGridView()
        Me.txtContraseñaCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(362, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 54)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Actualizar cliente"
        '
        'dgvConsultarClientes
        '
        Me.dgvConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultarClientes.Location = New System.Drawing.Point(12, 203)
        Me.dgvConsultarClientes.Name = "dgvConsultarClientes"
        Me.dgvConsultarClientes.ReadOnly = True
        Me.dgvConsultarClientes.RowHeadersWidth = 51
        Me.dgvConsultarClientes.RowTemplate.Height = 24
        Me.dgvConsultarClientes.Size = New System.Drawing.Size(1058, 226)
        Me.dgvConsultarClientes.TabIndex = 46
        '
        'txtContraseñaCliente
        '
        Me.txtContraseñaCliente.Location = New System.Drawing.Point(316, 149)
        Me.txtContraseñaCliente.Name = "txtContraseñaCliente"
        Me.txtContraseñaCliente.Size = New System.Drawing.Size(143, 22)
        Me.txtContraseñaCliente.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(196, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Contraseña"
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.Red
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarCliente.Location = New System.Drawing.Point(496, 135)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(228, 43)
        Me.btnEliminarCliente.TabIndex = 49
        Me.btnEliminarCliente.Text = "Eliminar cliente"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(940, 20)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Ingrese la contraseña del cliente a eliminar o seleccione el cliente en la tabla " &
    "de abajo para que se acompleten la contraseña"
        '
        'FrmEliminarClientesAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.txtContraseñaCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvConsultarClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEliminarClientesAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEliminarClientesAdm"
        CType(Me.dgvConsultarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvConsultarClientes As DataGridView
    Friend WithEvents txtContraseñaCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents Label11 As Label
End Class
