<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAceptarSolicitud
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
        Me.dgvNece = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnRechazar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdSol = New System.Windows.Forms.TextBox()
        CType(Me.dgvNece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNece
        '
        Me.dgvNece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNece.Location = New System.Drawing.Point(69, 52)
        Me.dgvNece.Name = "dgvNece"
        Me.dgvNece.ReadOnly = True
        Me.dgvNece.RowHeadersWidth = 51
        Me.dgvNece.RowTemplate.Height = 24
        Me.dgvNece.Size = New System.Drawing.Size(740, 171)
        Me.dgvNece.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Solicitudes de consultoria"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(215, 301)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(126, 43)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnRechazar
        '
        Me.BtnRechazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechazar.Location = New System.Drawing.Point(525, 301)
        Me.BtnRechazar.Name = "BtnRechazar"
        Me.BtnRechazar.Size = New System.Drawing.Size(126, 43)
        Me.BtnRechazar.TabIndex = 5
        Me.BtnRechazar.Text = "Rechazar"
        Me.BtnRechazar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Folio Solicitud:"
        '
        'txtIdSol
        '
        Me.txtIdSol.Location = New System.Drawing.Point(167, 256)
        Me.txtIdSol.Name = "txtIdSol"
        Me.txtIdSol.Size = New System.Drawing.Size(100, 22)
        Me.txtIdSol.TabIndex = 7
        '
        'FrmAceptarSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 450)
        Me.Controls.Add(Me.txtIdSol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRechazar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.dgvNece)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAceptarSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAceptarSolicitud"
        CType(Me.dgvNece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNece As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnRechazar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdSol As TextBox
End Class
