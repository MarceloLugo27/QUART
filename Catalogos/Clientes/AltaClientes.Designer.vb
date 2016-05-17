<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaClientes
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
        Me.btnAñadirCliente = New System.Windows.Forms.Button()
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTelefono3 = New System.Windows.Forms.TextBox()
        Me.tbTelefono2 = New System.Windows.Forms.TextBox()
        Me.tbTelefono1 = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.tbMunicipio = New System.Windows.Forms.TextBox()
        Me.tbColonia = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRFC = New System.Windows.Forms.TextBox()
        Me.tbNombreContacto = New System.Windows.Forms.TextBox()
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btnListaClientes = New System.Windows.Forms.Button()
        Me.btnAñadirID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbTodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAñadirCliente
        '
        Me.btnAñadirCliente.Location = New System.Drawing.Point(583, 197)
        Me.btnAñadirCliente.Name = "btnAñadirCliente"
        Me.btnAñadirCliente.Size = New System.Drawing.Size(94, 27)
        Me.btnAñadirCliente.TabIndex = 17
        Me.btnAñadirCliente.Text = "Añadir Cliente"
        Me.btnAñadirCliente.UseVisualStyleBackColor = True
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.Label1)
        Me.gbTodo.Controls.Add(Me.tbObservaciones)
        Me.gbTodo.Controls.Add(Me.Label8)
        Me.gbTodo.Controls.Add(Me.btnAñadirCliente)
        Me.gbTodo.Controls.Add(Me.Label3)
        Me.gbTodo.Controls.Add(Me.Label6)
        Me.gbTodo.Controls.Add(Me.Label5)
        Me.gbTodo.Controls.Add(Me.Label4)
        Me.gbTodo.Controls.Add(Me.Label13)
        Me.gbTodo.Controls.Add(Me.Label12)
        Me.gbTodo.Controls.Add(Me.Label2)
        Me.gbTodo.Controls.Add(Me.tbTelefono3)
        Me.gbTodo.Controls.Add(Me.tbTelefono2)
        Me.gbTodo.Controls.Add(Me.tbTelefono1)
        Me.gbTodo.Controls.Add(Me.tbEmail)
        Me.gbTodo.Controls.Add(Me.tbEstado)
        Me.gbTodo.Controls.Add(Me.tbMunicipio)
        Me.gbTodo.Controls.Add(Me.tbColonia)
        Me.gbTodo.Controls.Add(Me.tbDomicilio)
        Me.gbTodo.Controls.Add(Me.Label11)
        Me.gbTodo.Controls.Add(Me.Label10)
        Me.gbTodo.Controls.Add(Me.Label7)
        Me.gbTodo.Controls.Add(Me.tbRFC)
        Me.gbTodo.Controls.Add(Me.tbNombreContacto)
        Me.gbTodo.Controls.Add(Me.tbNombreCliente)
        Me.gbTodo.Location = New System.Drawing.Point(14, 60)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(692, 245)
        Me.gbTodo.TabIndex = 36
        Me.gbTodo.TabStop = False
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Location = New System.Drawing.Point(141, 180)
        Me.tbObservaciones.MaxLength = 200
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(427, 57)
        Me.tbObservaciones.TabIndex = 57
        Me.tbObservaciones.Text = "tbObservaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Comentarios:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(496, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Teléfono:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(496, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Dirección:"
        '
        'tbTelefono3
        '
        Me.tbTelefono3.Enabled = False
        Me.tbTelefono3.Location = New System.Drawing.Point(563, 141)
        Me.tbTelefono3.MaxLength = 25
        Me.tbTelefono3.Name = "tbTelefono3"
        Me.tbTelefono3.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono3.TabIndex = 35
        Me.tbTelefono3.Text = "tbTelefono3"
        Me.tbTelefono3.Visible = False
        '
        'tbTelefono2
        '
        Me.tbTelefono2.Location = New System.Drawing.Point(563, 111)
        Me.tbTelefono2.MaxLength = 25
        Me.tbTelefono2.Name = "tbTelefono2"
        Me.tbTelefono2.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono2.TabIndex = 36
        Me.tbTelefono2.Text = "tbTelefono2"
        '
        'tbTelefono1
        '
        Me.tbTelefono1.Location = New System.Drawing.Point(563, 81)
        Me.tbTelefono1.MaxLength = 25
        Me.tbTelefono1.Name = "tbTelefono1"
        Me.tbTelefono1.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono1.TabIndex = 37
        Me.tbTelefono1.Text = "tbTelefono1"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(141, 120)
        Me.tbEmail.MaxLength = 50
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(149, 21)
        Me.tbEmail.TabIndex = 38
        Me.tbEmail.Text = "tbEmail"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(358, 81)
        Me.tbEstado.MaxLength = 50
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(116, 21)
        Me.tbEstado.TabIndex = 39
        Me.tbEstado.Text = "tbEstado"
        '
        'tbMunicipio
        '
        Me.tbMunicipio.Location = New System.Drawing.Point(141, 81)
        Me.tbMunicipio.MaxLength = 100
        Me.tbMunicipio.Name = "tbMunicipio"
        Me.tbMunicipio.Size = New System.Drawing.Size(116, 21)
        Me.tbMunicipio.TabIndex = 40
        Me.tbMunicipio.Text = "tbMunicipio"
        '
        'tbColonia
        '
        Me.tbColonia.Location = New System.Drawing.Point(497, 51)
        Me.tbColonia.MaxLength = 50
        Me.tbColonia.Name = "tbColonia"
        Me.tbColonia.Size = New System.Drawing.Size(180, 21)
        Me.tbColonia.TabIndex = 41
        Me.tbColonia.Text = "tbColonia"
        '
        'tbDomicilio
        '
        Me.tbDomicilio.Location = New System.Drawing.Point(141, 51)
        Me.tbDomicilio.MaxLength = 80
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(275, 21)
        Me.tbDomicilio.TabIndex = 42
        Me.tbDomicilio.Text = "tbDireccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "RFC:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 15)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Nombre de contacto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Nombre de cliente:"
        '
        'tbRFC
        '
        Me.tbRFC.Location = New System.Drawing.Point(336, 120)
        Me.tbRFC.MaxLength = 20
        Me.tbRFC.Name = "tbRFC"
        Me.tbRFC.Size = New System.Drawing.Size(148, 21)
        Me.tbRFC.TabIndex = 44
        Me.tbRFC.Text = "tbRFC"
        '
        'tbNombreContacto
        '
        Me.tbNombreContacto.Location = New System.Drawing.Point(141, 150)
        Me.tbNombreContacto.MaxLength = 50
        Me.tbNombreContacto.Name = "tbNombreContacto"
        Me.tbNombreContacto.Size = New System.Drawing.Size(343, 21)
        Me.tbNombreContacto.TabIndex = 45
        Me.tbNombreContacto.Text = "tbNombreContacto"
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Location = New System.Drawing.Point(141, 21)
        Me.tbNombreCliente.MaxLength = 90
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(347, 21)
        Me.tbNombreCliente.TabIndex = 46
        Me.tbNombreCliente.Text = "tbNombreCliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "ID Cliente:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(408, 30)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(41, 21)
        Me.tbID.TabIndex = 43
        Me.tbID.Text = "tbID"
        '
        'btnListaClientes
        '
        Me.btnListaClientes.Location = New System.Drawing.Point(597, 27)
        Me.btnListaClientes.Name = "btnListaClientes"
        Me.btnListaClientes.Size = New System.Drawing.Size(108, 27)
        Me.btnListaClientes.TabIndex = 37
        Me.btnListaClientes.Text = "Lista de Clientes"
        Me.btnListaClientes.UseVisualStyleBackColor = True
        '
        'btnAñadirID
        '
        Me.btnAñadirID.Location = New System.Drawing.Point(469, 29)
        Me.btnAñadirID.Name = "btnAñadirID"
        Me.btnAñadirID.Size = New System.Drawing.Size(99, 24)
        Me.btnAñadirID.TabIndex = 53
        Me.btnAñadirID.Text = "Verificar ID"
        Me.btnAñadirID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Colonia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Municipio:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(288, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Estado:"
        '
        'AltaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 360)
        Me.Controls.Add(Me.btnAñadirID)
        Me.Controls.Add(Me.btnListaClientes)
        Me.Controls.Add(Me.gbTodo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltaClientes"
        Me.Text = "Alta de Clientes"
        Me.gbTodo.ResumeLayout(False)
        Me.gbTodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAñadirCliente As System.Windows.Forms.Button
    Friend WithEvents gbTodo As System.Windows.Forms.GroupBox
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbTelefono3 As System.Windows.Forms.TextBox
    Friend WithEvents tbTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents tbTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbEstado As System.Windows.Forms.TextBox
    Friend WithEvents tbMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents tbColonia As System.Windows.Forms.TextBox
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents tbDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbRFC As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreContacto As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnListaClientes As System.Windows.Forms.Button
    Friend WithEvents btnAñadirID As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
