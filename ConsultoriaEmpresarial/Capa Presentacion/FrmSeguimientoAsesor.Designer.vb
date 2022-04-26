<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguimientoAsesor
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
        Me.BtnEnviarSolConsultoria = New System.Windows.Forms.Button()
        Me.rtxtSeguimiento = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdAsesor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(152, 82)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(76, 20)
        Me.txtIdCliente.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID Cliente="
        '
        'BtnEnviarSolConsultoria
        '
        Me.BtnEnviarSolConsultoria.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnEnviarSolConsultoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviarSolConsultoria.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEnviarSolConsultoria.Location = New System.Drawing.Point(130, 333)
        Me.BtnEnviarSolConsultoria.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEnviarSolConsultoria.Name = "BtnEnviarSolConsultoria"
        Me.BtnEnviarSolConsultoria.Size = New System.Drawing.Size(221, 35)
        Me.BtnEnviarSolConsultoria.TabIndex = 16
        Me.BtnEnviarSolConsultoria.Text = "Enviar"
        Me.BtnEnviarSolConsultoria.UseVisualStyleBackColor = False
        '
        'rtxtSeguimiento
        '
        Me.rtxtSeguimiento.Location = New System.Drawing.Point(105, 147)
        Me.rtxtSeguimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtSeguimiento.Name = "rtxtSeguimiento"
        Me.rtxtSeguimiento.Size = New System.Drawing.Size(281, 164)
        Me.rtxtSeguimiento.TabIndex = 14
        Me.rtxtSeguimiento.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Datos relevantes a tomas en cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(81, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 42)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Guardar seguimiento"
        '
        'txtIdAsesor
        '
        Me.txtIdAsesor.Location = New System.Drawing.Point(152, 53)
        Me.txtIdAsesor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdAsesor.Name = "txtIdAsesor"
        Me.txtIdAsesor.Size = New System.Drawing.Size(76, 20)
        Me.txtIdAsesor.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ID Asesor="
        '
        'FrmSeguimientoAsesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 394)
        Me.Controls.Add(Me.txtIdAsesor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEnviarSolConsultoria)
        Me.Controls.Add(Me.rtxtSeguimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmSeguimientoAsesor"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEnviarSolConsultoria As Button
    Friend WithEvents rtxtSeguimiento As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdAsesor As TextBox
    Friend WithEvents Label3 As Label
End Class
