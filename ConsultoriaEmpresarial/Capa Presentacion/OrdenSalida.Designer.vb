<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdenSalida
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
        Me.cbPago = New System.Windows.Forms.ComboBox()
        Me.txtIdOT = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbNameCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNamePersonal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orden de salida"
        '
        'cbPago
        '
        Me.cbPago.FormattingEnabled = True
        Me.cbPago.Items.AddRange(New Object() {"Si", "No"})
        Me.cbPago.Location = New System.Drawing.Point(285, 185)
        Me.cbPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPago.Name = "cbPago"
        Me.cbPago.Size = New System.Drawing.Size(99, 24)
        Me.cbPago.TabIndex = 1
        '
        'txtIdOT
        '
        Me.txtIdOT.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtIdOT.Location = New System.Drawing.Point(220, 66)
        Me.txtIdOT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdOT.Name = "txtIdOT"
        Me.txtIdOT.Size = New System.Drawing.Size(267, 22)
        Me.txtIdOT.TabIndex = 2
        Me.txtIdOT.Text = "Id de la OT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 235)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "¿Pago realizado?"
        '
        'CbNameCliente
        '
        Me.CbNameCliente.FormattingEnabled = True
        Me.CbNameCliente.Location = New System.Drawing.Point(220, 98)
        Me.CbNameCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbNameCliente.Name = "CbNameCliente"
        Me.CbNameCliente.Size = New System.Drawing.Size(267, 24)
        Me.CbNameCliente.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cliente"
        '
        'CBNamePersonal
        '
        Me.CBNamePersonal.FormattingEnabled = True
        Me.CBNamePersonal.Location = New System.Drawing.Point(220, 132)
        Me.CBNamePersonal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBNamePersonal.Name = "CBNamePersonal"
        Me.CBNamePersonal.Size = New System.Drawing.Size(267, 24)
        Me.CBNamePersonal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Personal Asignado"
        '
        'OrdenSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 330)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBNamePersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbNameCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdOT)
        Me.Controls.Add(Me.cbPago)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "OrdenSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdenSalida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbPago As ComboBox
    Friend WithEvents txtIdOT As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CbNameCliente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBNamePersonal As ComboBox
    Friend WithEvents Label4 As Label
End Class
