<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.chkEditar = New System.Windows.Forms.CheckBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.chkActivado = New System.Windows.Forms.CheckBox()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaUsuarios.Location = New System.Drawing.Point(12, 152)
        Me.dgvListaUsuarios.Name = "dgvListaUsuarios"
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(581, 398)
        Me.dgvListaUsuarios.TabIndex = 0
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(51, 16)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(204, 20)
        Me.tbLogin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login:"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(79, 42)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(176, 20)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'tbPuesto
        '
        Me.tbPuesto.Location = New System.Drawing.Point(58, 115)
        Me.tbPuesto.Name = "tbPuesto"
        Me.tbPuesto.Size = New System.Drawing.Size(232, 20)
        Me.tbPuesto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Puesto:"
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.Location = New System.Drawing.Point(114, 89)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.Size = New System.Drawing.Size(176, 20)
        Me.tbNombreUsuario.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre de usuario:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(518, 123)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(261, 42)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(28, 20)
        Me.btnSwap.TabIndex = 4
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'chkEditar
        '
        Me.chkEditar.AutoSize = True
        Me.chkEditar.Location = New System.Drawing.Point(459, 127)
        Me.chkEditar.Name = "chkEditar"
        Me.chkEditar.Size = New System.Drawing.Size(53, 17)
        Me.chkEditar.TabIndex = 5
        Me.chkEditar.Text = "Editar"
        Me.chkEditar.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Enabled = False
        Me.tbID.Location = New System.Drawing.Point(459, 19)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 6
        Me.tbID.Visible = False
        '
        'chkActivado
        '
        Me.chkActivado.AutoSize = True
        Me.chkActivado.Location = New System.Drawing.Point(296, 117)
        Me.chkActivado.Name = "chkActivado"
        Me.chkActivado.Size = New System.Drawing.Size(68, 17)
        Me.chkActivado.TabIndex = 7
        Me.chkActivado.Text = "Activado"
        Me.chkActivado.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 562)
        Me.Controls.Add(Me.chkActivado)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.chkEditar)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNombreUsuario)
        Me.Controls.Add(Me.tbPuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbLogin)
        Me.Controls.Add(Me.dgvListaUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents tbLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombreUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSwap As Button
    Friend WithEvents chkEditar As CheckBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents chkActivado As CheckBox
End Class
