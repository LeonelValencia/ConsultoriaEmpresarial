<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarAsesor
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvConsultores = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(701, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Nota: Para se llenen los campos automaticamnete debes dar clic en la fila o cenld" &
    "a del asesor que quieres modificar"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(87, 79)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(84, 22)
        Me.txtId.TabIndex = 34
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(272, 131)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(202, 42)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar asesor"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 36)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Eliminar asesor"
        '
        'dgvConsultores
        '
        Me.dgvConsultores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsultores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvConsultores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultores.Location = New System.Drawing.Point(33, 251)
        Me.dgvConsultores.Name = "dgvConsultores"
        Me.dgvConsultores.ReadOnly = True
        Me.dgvConsultores.RowHeadersWidth = 51
        Me.dgvConsultores.RowTemplate.Height = 24
        Me.dgvConsultores.Size = New System.Drawing.Size(737, 150)
        Me.dgvConsultores.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Id:"
        '
        'FrmEliminarAsesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvConsultores)
        Me.Name = "FrmEliminarAsesor"
        Me.Text = "FrmEliminarAsesor"
        CType(Me.dgvConsultores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvConsultores As DataGridView
    Friend WithEvents Label7 As Label
End Class
