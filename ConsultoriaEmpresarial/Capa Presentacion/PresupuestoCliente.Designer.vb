<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PresupuestoCliente
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnviarSolConsultoria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.cbIdSolConsul = New System.Windows.Forms.ComboBox()
        Me.txtNece = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscarConsul = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(239, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 54)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Presupuesto"
        '
        'btnEnviarSolConsultoria
        '
        Me.btnEnviarSolConsultoria.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEnviarSolConsultoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarSolConsultoria.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnviarSolConsultoria.Location = New System.Drawing.Point(231, 460)
        Me.btnEnviarSolConsultoria.Name = "btnEnviarSolConsultoria"
        Me.btnEnviarSolConsultoria.Size = New System.Drawing.Size(295, 41)
        Me.btnEnviarSolConsultoria.TabIndex = 9
        Me.btnEnviarSolConsultoria.Text = "Pagar"
        Me.btnEnviarSolConsultoria.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 402)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total a pagar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 269)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "*Servicios por entregar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(356, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "*Herramientas para mejora de procesos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 344)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "*Consultores y capacitaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(538, 402)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "$"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(569, 405)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Id Cliente: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Folio consultoria: "
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(231, 72)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdCliente.TabIndex = 21
        '
        'cbIdSolConsul
        '
        Me.cbIdSolConsul.FormattingEnabled = True
        Me.cbIdSolConsul.Location = New System.Drawing.Point(280, 103)
        Me.cbIdSolConsul.Name = "cbIdSolConsul"
        Me.cbIdSolConsul.Size = New System.Drawing.Size(121, 24)
        Me.cbIdSolConsul.TabIndex = 22
        '
        'txtNece
        '
        Me.txtNece.Location = New System.Drawing.Point(124, 167)
        Me.txtNece.Multiline = True
        Me.txtNece.Name = "txtNece"
        Me.txtNece.Size = New System.Drawing.Size(623, 91)
        Me.txtNece.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(392, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Problemas y/o necesidades de la empresa: "
        '
        'btnBuscarConsul
        '
        Me.btnBuscarConsul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarConsul.Location = New System.Drawing.Point(436, 97)
        Me.btnBuscarConsul.Name = "btnBuscarConsul"
        Me.btnBuscarConsul.Size = New System.Drawing.Size(96, 33)
        Me.btnBuscarConsul.TabIndex = 25
        Me.btnBuscarConsul.Text = "Buscar"
        Me.btnBuscarConsul.UseVisualStyleBackColor = True
        '
        'PresupuestoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.btnBuscarConsul)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNece)
        Me.Controls.Add(Me.cbIdSolConsul)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviarSolConsultoria)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PresupuestoCliente"
        Me.Text = "PresupuestoCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnviarSolConsultoria As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents cbIdSolConsul As ComboBox
    Friend WithEvents txtNece As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscarConsul As Button
End Class
