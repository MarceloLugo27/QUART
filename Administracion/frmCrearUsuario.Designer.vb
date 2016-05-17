<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearUsuario
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
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.tbPuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(305, 70)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(28, 20)
        Me.btnSwap.TabIndex = 6
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre de usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Puesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña:"
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.Location = New System.Drawing.Point(158, 117)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.Size = New System.Drawing.Size(176, 20)
        Me.tbNombreUsuario.TabIndex = 3
        '
        'tbPuesto
        '
        Me.tbPuesto.Location = New System.Drawing.Point(102, 143)
        Me.tbPuesto.Name = "tbPuesto"
        Me.tbPuesto.Size = New System.Drawing.Size(232, 20)
        Me.tbPuesto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Login:"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(123, 70)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(176, 20)
        Me.tbPassword.TabIndex = 2
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(95, 44)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(204, 20)
        Me.tbLogin.TabIndex = 1
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Location = New System.Drawing.Point(253, 191)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(123, 75)
        Me.btnCrearUsuario.TabIndex = 5
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 312)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNombreUsuario)
        Me.Controls.Add(Me.tbPuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrearUsuario"
        Me.Text = "frmCrearUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSwap As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNombreUsuario As TextBox
    Friend WithEvents tbPuesto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbLogin As TextBox
    Friend WithEvents btnCrearUsuario As Button
End Class
