﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarAsesores
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.datetFechaI = New System.Windows.Forms.DateTimePicker()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvConsultores = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(342, 196)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(121, 42)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'datetFechaI
        '
        Me.datetFechaI.Location = New System.Drawing.Point(260, 157)
        Me.datetFechaI.Name = "datetFechaI"
        Me.datetFechaI.Size = New System.Drawing.Size(243, 22)
        Me.datetFechaI.TabIndex = 26
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(509, 107)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(135, 22)
        Me.txtContra.TabIndex = 25
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(207, 107)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(171, 22)
        Me.txtUsuario.TabIndex = 24
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(488, 63)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(122, 22)
        Me.txtTel.TabIndex = 23
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(207, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 22)
        Me.txtNombre.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fecha de inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(403, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 36)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Actualizar asesor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre:"
        '
        'dgvConsultores
        '
        Me.dgvConsultores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConsultores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvConsultores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultores.Location = New System.Drawing.Point(32, 292)
        Me.dgvConsultores.Name = "dgvConsultores"
        Me.dgvConsultores.ReadOnly = True
        Me.dgvConsultores.RowHeadersWidth = 51
        Me.dgvConsultores.RowTemplate.Height = 24
        Me.dgvConsultores.Size = New System.Drawing.Size(737, 150)
        Me.dgvConsultores.TabIndex = 15
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(560, 155)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(84, 22)
        Me.txtId.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(527, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Id:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(701, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nota: Para se llenen los campos automaticamnete debes dar clic en la fila o cenld" &
    "a del asesor que quieres modificar"
        '
        'FrmActualizarAsesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.datetFechaI)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvConsultores)
        Me.Name = "FrmActualizarAsesores"
        Me.Text = "FrmActualizarAsesores"
        CType(Me.dgvConsultores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents datetFechaI As DateTimePicker
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvConsultores As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
