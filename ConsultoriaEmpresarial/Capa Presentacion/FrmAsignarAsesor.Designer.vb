<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarAsesor
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
        Me.dgvAsesorCliente = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdAsesor = New System.Windows.Forms.TextBox()
        Me.cbAsesores = New System.Windows.Forms.ComboBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        CType(Me.dgvAsesorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsesorCliente
        '
        Me.dgvAsesorCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAsesorCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAsesorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsesorCliente.Location = New System.Drawing.Point(31, 269)
        Me.dgvAsesorCliente.Name = "dgvAsesorCliente"
        Me.dgvAsesorCliente.ReadOnly = True
        Me.dgvAsesorCliente.RowHeadersWidth = 51
        Me.dgvAsesorCliente.RowTemplate.Height = 24
        Me.dgvAsesorCliente.Size = New System.Drawing.Size(737, 150)
        Me.dgvAsesorCliente.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 36)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Asignar asesor a cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Id cliente:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(143, 79)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(84, 22)
        Me.txtIdCliente.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Id asesor:"
        '
        'txtIdAsesor
        '
        Me.txtIdAsesor.Location = New System.Drawing.Point(143, 125)
        Me.txtIdAsesor.Name = "txtIdAsesor"
        Me.txtIdAsesor.Size = New System.Drawing.Size(84, 22)
        Me.txtIdAsesor.TabIndex = 39
        '
        'cbAsesores
        '
        Me.cbAsesores.FormattingEnabled = True
        Me.cbAsesores.Location = New System.Drawing.Point(260, 122)
        Me.cbAsesores.Name = "cbAsesores"
        Me.cbAsesores.Size = New System.Drawing.Size(225, 24)
        Me.cbAsesores.TabIndex = 41
        '
        'btnAsignar
        '
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.Location = New System.Drawing.Point(304, 195)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(129, 42)
        Me.btnAsignar.TabIndex = 42
        Me.btnAsignar.Text = "Guardar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(260, 79)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(225, 22)
        Me.txtNombreCliente.TabIndex = 43
        '
        'FrmAsignarAsesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.cbAsesores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdAsesor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvAsesorCliente)
        Me.Name = "FrmAsignarAsesor"
        Me.Text = "FrmAsignarAsesor"
        CType(Me.dgvAsesorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsesorCliente As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdAsesor As TextBox
    Friend WithEvents cbAsesores As ComboBox
    Friend WithEvents btnAsignar As Button
    Friend WithEvents txtNombreCliente As TextBox
End Class
