﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPyM
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
        Me.labelPersonas = New System.Windows.Forms.Label()
        Me.textCi = New System.Windows.Forms.TextBox()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.textTelefono = New System.Windows.Forms.TextBox()
        Me.textDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCapturarPersonas = New System.Windows.Forms.Button()
        Me.labelVerResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'labelPersonas
        '
        Me.labelPersonas.AutoSize = True
        Me.labelPersonas.Font = New System.Drawing.Font("Rockwell", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPersonas.Location = New System.Drawing.Point(383, 35)
        Me.labelPersonas.Name = "labelPersonas"
        Me.labelPersonas.Size = New System.Drawing.Size(55, 16)
        Me.labelPersonas.TabIndex = 5
        Me.labelPersonas.Text = "Personas"
        '
        'textCi
        '
        Me.textCi.Location = New System.Drawing.Point(386, 81)
        Me.textCi.Name = "textCi"
        Me.textCi.Size = New System.Drawing.Size(94, 20)
        Me.textCi.TabIndex = 2
        '
        'textNombre
        '
        Me.textNombre.Location = New System.Drawing.Point(385, 115)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(94, 20)
        Me.textNombre.TabIndex = 3
        '
        'textTelefono
        '
        Me.textTelefono.Location = New System.Drawing.Point(385, 150)
        Me.textTelefono.Name = "textTelefono"
        Me.textTelefono.Size = New System.Drawing.Size(94, 20)
        Me.textTelefono.TabIndex = 4
        '
        'textDireccion
        '
        Me.textDireccion.Location = New System.Drawing.Point(384, 189)
        Me.textDireccion.Name = "textDireccion"
        Me.textDireccion.Size = New System.Drawing.Size(94, 20)
        Me.textDireccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Direccion"
        '
        'btnCapturarPersonas
        '
        Me.btnCapturarPersonas.Location = New System.Drawing.Point(390, 263)
        Me.btnCapturarPersonas.Name = "btnCapturarPersonas"
        Me.btnCapturarPersonas.Size = New System.Drawing.Size(89, 32)
        Me.btnCapturarPersonas.TabIndex = 10
        Me.btnCapturarPersonas.Text = "Capturar datos"
        Me.btnCapturarPersonas.UseVisualStyleBackColor = True
        '
        'labelVerResultado
        '
        Me.labelVerResultado.AutoSize = True
        Me.labelVerResultado.Location = New System.Drawing.Point(336, 336)
        Me.labelVerResultado.Name = "labelVerResultado"
        Me.labelVerResultado.Size = New System.Drawing.Size(0, 13)
        Me.labelVerResultado.TabIndex = 11
        Me.labelVerResultado.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FormPyM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelVerResultado)
        Me.Controls.Add(Me.btnCapturarPersonas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textDireccion)
        Me.Controls.Add(Me.textTelefono)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.textCi)
        Me.Controls.Add(Me.labelPersonas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPyM"
        Me.Text = "Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelPersonas As Label
    Friend WithEvents textCi As TextBox
    Friend WithEvents textNombre As TextBox
    Friend WithEvents textTelefono As TextBox
    Friend WithEvents textDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCapturarPersonas As Button
    Friend WithEvents labelVerResultado As Label
End Class
