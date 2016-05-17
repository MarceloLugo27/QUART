<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(25, 26)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(116, 20)
        Me.txtNumero.TabIndex = 0
        '
        'txtLetra
        '
        Me.txtLetra.Location = New System.Drawing.Point(28, 66)
        Me.txtLetra.Multiline = True
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(382, 80)
        Me.txtLetra.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(267, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(29, 152)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(112, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 321)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtLetra As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
