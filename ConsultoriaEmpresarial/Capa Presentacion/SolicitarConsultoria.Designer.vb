﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SolicitarConsultoria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtxtProblemasCliente = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnviarSolConsultoria = New System.Windows.Forms.Button()
        Me.dateTimer1 = New System.Windows.Forms.DateTimePicker()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(173, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 54)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Solicitar consultoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Problemas o necesidades de su empresa"
        '
        'rtxtProblemasCliente
        '
        Me.rtxtProblemasCliente.Location = New System.Drawing.Point(193, 151)
        Me.rtxtProblemasCliente.Name = "rtxtProblemasCliente"
        Me.rtxtProblemasCliente.Size = New System.Drawing.Size(366, 96)
        Me.rtxtProblemasCliente.TabIndex = 6
        Me.rtxtProblemasCliente.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 278)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(521, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Elige el dia y hora que puedes para la primera capacitacion"
        '
        'btnEnviarSolConsultoria
        '
        Me.btnEnviarSolConsultoria.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEnviarSolConsultoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarSolConsultoria.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnviarSolConsultoria.Location = New System.Drawing.Point(228, 395)
        Me.btnEnviarSolConsultoria.Name = "btnEnviarSolConsultoria"
        Me.btnEnviarSolConsultoria.Size = New System.Drawing.Size(295, 43)
        Me.btnEnviarSolConsultoria.TabIndex = 8
        Me.btnEnviarSolConsultoria.Text = "Enviar"
        Me.btnEnviarSolConsultoria.UseVisualStyleBackColor = False
        '
        'dateTimer1
        '
        Me.dateTimer1.Location = New System.Drawing.Point(271, 323)
        Me.dateTimer1.Name = "dateTimer1"
        Me.dateTimer1.Size = New System.Drawing.Size(200, 22)
        Me.dateTimer1.TabIndex = 9
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(256, 72)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdCliente.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID Cliente="
        '
        'SolicitarConsultoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateTimer1)
        Me.Controls.Add(Me.btnEnviarSolConsultoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtxtProblemasCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "SolicitarConsultoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SolicitarConsultoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxtProblemasCliente As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnviarSolConsultoria As Button
    Friend WithEvents dateTimer1 As DateTimePicker
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
End Class
