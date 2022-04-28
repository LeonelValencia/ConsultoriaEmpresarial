<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarStatus
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
        Me.dgvSolCliente = New System.Windows.Forms.DataGridView()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPagado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdAsesor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNameAsesor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvSolCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSolCliente
        '
        Me.dgvSolCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSolCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSolCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolCliente.Location = New System.Drawing.Point(12, 23)
        Me.dgvSolCliente.Name = "dgvSolCliente"
        Me.dgvSolCliente.ReadOnly = True
        Me.dgvSolCliente.RowHeadersWidth = 51
        Me.dgvSolCliente.RowTemplate.Height = 24
        Me.dgvSolCliente.Size = New System.Drawing.Size(895, 95)
        Me.dgvSolCliente.TabIndex = 31
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(144, 135)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 15)
        Me.txtIdCliente.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID Cliente="
        '
        'txtEstado
        '
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(144, 176)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(143, 15)
        Me.txtEstado.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Estado Solicitud="
        '
        'TxtPresupuesto
        '
        Me.TxtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPresupuesto.Enabled = False
        Me.TxtPresupuesto.Location = New System.Drawing.Point(144, 214)
        Me.TxtPresupuesto.Name = "TxtPresupuesto"
        Me.TxtPresupuesto.ReadOnly = True
        Me.TxtPresupuesto.Size = New System.Drawing.Size(100, 15)
        Me.TxtPresupuesto.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Presupuesto="
        '
        'TxtPagado
        '
        Me.TxtPagado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPagado.Enabled = False
        Me.TxtPagado.Location = New System.Drawing.Point(144, 252)
        Me.TxtPagado.Name = "TxtPagado"
        Me.TxtPagado.ReadOnly = True
        Me.TxtPagado.Size = New System.Drawing.Size(100, 15)
        Me.TxtPagado.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Pagado="
        '
        'TxtIdAsesor
        '
        Me.TxtIdAsesor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdAsesor.Enabled = False
        Me.TxtIdAsesor.Location = New System.Drawing.Point(144, 291)
        Me.TxtIdAsesor.Name = "TxtIdAsesor"
        Me.TxtIdAsesor.ReadOnly = True
        Me.TxtIdAsesor.Size = New System.Drawing.Size(100, 15)
        Me.TxtIdAsesor.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Id Asesor="
        '
        'TxtNameAsesor
        '
        Me.TxtNameAsesor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNameAsesor.Enabled = False
        Me.TxtNameAsesor.Location = New System.Drawing.Point(460, 291)
        Me.TxtNameAsesor.Name = "TxtNameAsesor"
        Me.TxtNameAsesor.ReadOnly = True
        Me.TxtNameAsesor.Size = New System.Drawing.Size(189, 15)
        Me.TxtNameAsesor.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Nombre del asesor="
        '
        'FrmConsultarStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 339)
        Me.Controls.Add(Me.TxtNameAsesor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtIdAsesor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPagado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPresupuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSolCliente)
        Me.Name = "FrmConsultarStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultarStatus"
        CType(Me.dgvSolCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSolCliente As DataGridView
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPresupuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPagado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdAsesor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNameAsesor As TextBox
    Friend WithEvents Label6 As Label
End Class
