<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQuejasAsesor
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
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviarSolConsultoria = New System.Windows.Forms.Button()
        Me.txtQueja = New System.Windows.Forms.TextBox()
        Me.dgvQuejas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvQuejas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(207, 99)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdCliente.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ID Cliente="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(244, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 54)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Quejas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Buscar Quejas"
        '
        'btnEnviarSolConsultoria
        '
        Me.btnEnviarSolConsultoria.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEnviarSolConsultoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarSolConsultoria.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnviarSolConsultoria.Location = New System.Drawing.Point(262, 280)
        Me.btnEnviarSolConsultoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnviarSolConsultoria.Name = "btnEnviarSolConsultoria"
        Me.btnEnviarSolConsultoria.Size = New System.Drawing.Size(141, 47)
        Me.btnEnviarSolConsultoria.TabIndex = 24
        Me.btnEnviarSolConsultoria.Text = "Buscar"
        Me.btnEnviarSolConsultoria.UseVisualStyleBackColor = False
        '
        'txtQueja
        '
        Me.txtQueja.Location = New System.Drawing.Point(97, 138)
        Me.txtQueja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQueja.Multiline = True
        Me.txtQueja.Name = "txtQueja"
        Me.txtQueja.Size = New System.Drawing.Size(456, 126)
        Me.txtQueja.TabIndex = 25
        '
        'dgvQuejas
        '
        Me.dgvQuejas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvQuejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuejas.Location = New System.Drawing.Point(32, 350)
        Me.dgvQuejas.Name = "dgvQuejas"
        Me.dgvQuejas.RowHeadersWidth = 51
        Me.dgvQuejas.RowTemplate.Height = 24
        Me.dgvQuejas.Size = New System.Drawing.Size(647, 128)
        Me.dgvQuejas.TabIndex = 26
        '
        'FrmQuejasAsesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 501)
        Me.Controls.Add(Me.dgvQuejas)
        Me.Controls.Add(Me.txtQueja)
        Me.Controls.Add(Me.btnEnviarSolConsultoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmQuejasAsesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmQuejasAsesor"
        CType(Me.dgvQuejas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviarSolConsultoria As Button
    Friend WithEvents txtQueja As TextBox
    Friend WithEvents dgvQuejas As DataGridView
End Class
