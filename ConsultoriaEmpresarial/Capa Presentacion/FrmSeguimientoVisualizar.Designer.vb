<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguimientoVisualizar
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
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarSeguimiento = New System.Windows.Forms.Button()
        Me.rtxtSeguimiento = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(172, 140)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdCliente.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ID Cliente="
        '
        'btnBuscarSeguimiento
        '
        Me.btnBuscarSeguimiento.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscarSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSeguimiento.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarSeguimiento.Location = New System.Drawing.Point(293, 126)
        Me.btnBuscarSeguimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarSeguimiento.Name = "btnBuscarSeguimiento"
        Me.btnBuscarSeguimiento.Size = New System.Drawing.Size(167, 47)
        Me.btnBuscarSeguimiento.TabIndex = 23
        Me.btnBuscarSeguimiento.Text = "Buscar"
        Me.btnBuscarSeguimiento.UseVisualStyleBackColor = False
        '
        'rtxtSeguimiento
        '
        Me.rtxtSeguimiento.Location = New System.Drawing.Point(61, 198)
        Me.rtxtSeguimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtSeguimiento.Name = "rtxtSeguimiento"
        Me.rtxtSeguimiento.ReadOnly = True
        Me.rtxtSeguimiento.Size = New System.Drawing.Size(509, 301)
        Me.rtxtSeguimiento.TabIndex = 22
        Me.rtxtSeguimiento.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(157, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 54)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Ver seguimiento"
        '
        'FrmSeguimientoVisualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 546)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuscarSeguimiento)
        Me.Controls.Add(Me.rtxtSeguimiento)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSeguimientoVisualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscarSeguimiento As Button
    Friend WithEvents rtxtSeguimiento As RichTextBox
    Friend WithEvents Label2 As Label
End Class
