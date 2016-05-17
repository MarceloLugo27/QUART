<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaProveedor
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTelefono3 = New System.Windows.Forms.TextBox()
        Me.tbTelefono2 = New System.Windows.Forms.TextBox()
        Me.tbTelefono1 = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.tbMunicipio = New System.Windows.Forms.TextBox()
        Me.tbColonia = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRFC = New System.Windows.Forms.TextBox()
        Me.tbNombreContacto = New System.Windows.Forms.TextBox()
        Me.tbNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(639, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Ver lista"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tbObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbTelefono3)
        Me.GroupBox1.Controls.Add(Me.tbTelefono2)
        Me.GroupBox1.Controls.Add(Me.tbTelefono1)
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Controls.Add(Me.tbEstado)
        Me.GroupBox1.Controls.Add(Me.tbMunicipio)
        Me.GroupBox1.Controls.Add(Me.tbColonia)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.tbDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbRFC)
        Me.GroupBox1.Controls.Add(Me.tbNombreContacto)
        Me.GroupBox1.Controls.Add(Me.tbNombreProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 245)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Colonia:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(289, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Estado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(71, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Municipio:"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbObservaciones.Location = New System.Drawing.Point(141, 180)
        Me.tbObservaciones.MaxLength = 200
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(427, 57)
        Me.tbObservaciones.TabIndex = 13
        Me.tbObservaciones.Text = "TBOBSERVACIONES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Comentarios:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Teléfono:"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(496, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 15)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Dirección:"
        '
        'tbTelefono3
        '
        Me.tbTelefono3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono3.Location = New System.Drawing.Point(563, 141)
        Me.tbTelefono3.MaxLength = 20
        Me.tbTelefono3.Name = "tbTelefono3"
        Me.tbTelefono3.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono3.TabIndex = 9
        Me.tbTelefono3.Text = "TBTELEFONO3"
        '
        'tbTelefono2
        '
        Me.tbTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono2.Location = New System.Drawing.Point(563, 111)
        Me.tbTelefono2.MaxLength = 20
        Me.tbTelefono2.Name = "tbTelefono2"
        Me.tbTelefono2.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono2.TabIndex = 8
        Me.tbTelefono2.Text = "TBTELEFONO2"
        '
        'tbTelefono1
        '
        Me.tbTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono1.Location = New System.Drawing.Point(563, 81)
        Me.tbTelefono1.MaxLength = 20
        Me.tbTelefono1.Name = "tbTelefono1"
        Me.tbTelefono1.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono1.TabIndex = 7
        Me.tbTelefono1.Text = "TBTELEFONO1"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(141, 120)
        Me.tbEmail.MaxLength = 50
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(116, 21)
        Me.tbEmail.TabIndex = 10
        Me.tbEmail.Text = "tbEmail"
        '
        'tbEstado
        '
        Me.tbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEstado.Location = New System.Drawing.Point(343, 81)
        Me.tbEstado.MaxLength = 50
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(116, 21)
        Me.tbEstado.TabIndex = 6
        Me.tbEstado.Text = "TBESTADO"
        '
        'tbMunicipio
        '
        Me.tbMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMunicipio.Location = New System.Drawing.Point(141, 81)
        Me.tbMunicipio.MaxLength = 100
        Me.tbMunicipio.Name = "tbMunicipio"
        Me.tbMunicipio.Size = New System.Drawing.Size(116, 21)
        Me.tbMunicipio.TabIndex = 5
        Me.tbMunicipio.Text = "TBMUNICIPIO"
        '
        'tbColonia
        '
        Me.tbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbColonia.Location = New System.Drawing.Point(499, 51)
        Me.tbColonia.MaxLength = 50
        Me.tbColonia.Name = "tbColonia"
        Me.tbColonia.Size = New System.Drawing.Size(180, 21)
        Me.tbColonia.TabIndex = 4
        Me.tbColonia.Text = "TBCOLONIA"
        '
        'tbID
        '
        Me.tbID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbID.Location = New System.Drawing.Point(527, 21)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(41, 21)
        Me.tbID.TabIndex = 2
        Me.tbID.Text = "TBID"
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(141, 51)
        Me.tbDomicilio.MaxLength = 80
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(294, 21)
        Me.tbDomicilio.TabIndex = 3
        Me.tbDomicilio.Text = "TBDIRECCION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "RFC:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 15)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Nombre de contacto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 15)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Nombre de proveedor:"
        '
        'tbRFC
        '
        Me.tbRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRFC.Location = New System.Drawing.Point(304, 120)
        Me.tbRFC.MaxLength = 15
        Me.tbRFC.Name = "tbRFC"
        Me.tbRFC.Size = New System.Drawing.Size(180, 21)
        Me.tbRFC.TabIndex = 11
        Me.tbRFC.Text = "TBRFC"
        '
        'tbNombreContacto
        '
        Me.tbNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreContacto.Location = New System.Drawing.Point(141, 150)
        Me.tbNombreContacto.MaxLength = 50
        Me.tbNombreContacto.Name = "tbNombreContacto"
        Me.tbNombreContacto.Size = New System.Drawing.Size(343, 21)
        Me.tbNombreContacto.TabIndex = 12
        Me.tbNombreContacto.Text = "TBNOMBRECONTACTO"
        '
        'tbNombreProveedor
        '
        Me.tbNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreProveedor.Location = New System.Drawing.Point(141, 21)
        Me.tbNombreProveedor.MaxLength = 90
        Me.tbNombreProveedor.Name = "tbNombreProveedor"
        Me.tbNombreProveedor.Size = New System.Drawing.Size(347, 21)
        Me.tbNombreProveedor.TabIndex = 1
        Me.tbNombreProveedor.Text = "TBNOMBREPROVEEDOR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AltaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltaProveedor"
        Me.Text = "Alta de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents tbNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
