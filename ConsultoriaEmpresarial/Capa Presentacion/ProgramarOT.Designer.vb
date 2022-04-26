<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgramarOT
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateProgramada = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbAnalista = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Materiales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empleado"
        '
        'DateProgramada
        '
        Me.DateProgramada.Location = New System.Drawing.Point(4, 299)
        Me.DateProgramada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateProgramada.Name = "DateProgramada"
        Me.DateProgramada.Size = New System.Drawing.Size(265, 22)
        Me.DateProgramada.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 266)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha programada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Analista asignado"
        '
        'CbAnalista
        '
        Me.CbAnalista.FormattingEnabled = True
        Me.CbAnalista.Location = New System.Drawing.Point(333, 298)
        Me.CbAnalista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbAnalista.Name = "CbAnalista"
        Me.CbAnalista.Size = New System.Drawing.Size(160, 24)
        Me.CbAnalista.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 299)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Programar OT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMateriales
        '
        Me.txtMateriales.Location = New System.Drawing.Point(4, 80)
        Me.txtMateriales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMateriales.Multiline = True
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.Size = New System.Drawing.Size(195, 164)
        Me.txtMateriales.TabIndex = 9
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(241, 80)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(201, 164)
        Me.txtCliente.TabIndex = 10
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(485, 80)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpleado.Multiline = True
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(199, 164)
        Me.txtEmpleado.TabIndex = 11
        '
        'ProgramarOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 370)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtMateriales)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CbAnalista)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateProgramada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProgramarOT"
        Me.Text = "ProgramarOT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateProgramada As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbAnalista As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMateriales As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtEmpleado As TextBox
End Class
