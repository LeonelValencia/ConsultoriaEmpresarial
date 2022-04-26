<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuejaCliente
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
        Me.txtQueja = New System.Windows.Forms.TextBox()
        Me.txtIdAsesor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtQueja
        '
        Me.txtQueja.Location = New System.Drawing.Point(287, 162)
        Me.txtQueja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQueja.Multiline = True
        Me.txtQueja.Name = "txtQueja"
        Me.txtQueja.Size = New System.Drawing.Size(419, 143)
        Me.txtQueja.TabIndex = 48
        '
        'txtIdAsesor
        '
        Me.txtIdAsesor.Location = New System.Drawing.Point(287, 123)
        Me.txtIdAsesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdAsesor.Name = "txtIdAsesor"
        Me.txtIdAsesor.Size = New System.Drawing.Size(297, 22)
        Me.txtIdAsesor.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 25)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Descripcion de la queja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "ID Asesor"
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(357, 311)
        Me.btnRegistrarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(228, 50)
        Me.btnRegistrarCliente.TabIndex = 38
        Me.btnRegistrarCliente.Text = "Enviar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(231, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 54)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Registrar Queja"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(287, 83)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(297, 22)
        Me.txtIdCliente.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ID Cliente"
        '
        'FrmQuejaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 401)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQueja)
        Me.Controls.Add(Me.txtIdAsesor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmQuejaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQueja As TextBox
    Friend WithEvents txtIdAsesor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label3 As Label
End Class
