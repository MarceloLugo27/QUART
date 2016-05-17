<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaClientes
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
        Me.dgvListaClientes = New System.Windows.Forms.DataGridView()
        Me.tbParametroBusqueda = New System.Windows.Forms.TextBox()
        Me.cbParamBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.chkbEditar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.gbEditarCliente = New System.Windows.Forms.GroupBox()
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbEditarCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListaClientes
        '
        Me.dgvListaClientes.AllowUserToAddRows = False
        Me.dgvListaClientes.AllowUserToDeleteRows = False
        Me.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaClientes.Location = New System.Drawing.Point(9, 347)
        Me.dgvListaClientes.Name = "dgvListaClientes"
        Me.dgvListaClientes.ReadOnly = True
        Me.dgvListaClientes.Size = New System.Drawing.Size(752, 286)
        Me.dgvListaClientes.StandardTab = True
        Me.dgvListaClientes.TabIndex = 0
        '
        'tbParametroBusqueda
        '
        Me.tbParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbParametroBusqueda.Location = New System.Drawing.Point(147, 32)
        Me.tbParametroBusqueda.MaxLength = 10
        Me.tbParametroBusqueda.Name = "tbParametroBusqueda"
        Me.tbParametroBusqueda.Size = New System.Drawing.Size(178, 21)
        Me.tbParametroBusqueda.TabIndex = 1
        '
        'cbParamBusqueda
        '
        Me.cbParamBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParamBusqueda.FormattingEnabled = True
        Me.cbParamBusqueda.Items.AddRange(New Object() {"Nombre de cliente", "Nombre de contacto"})
        Me.cbParamBusqueda.Location = New System.Drawing.Point(13, 32)
        Me.cbParamBusqueda.Name = "cbParamBusqueda"
        Me.cbParamBusqueda.Size = New System.Drawing.Size(126, 23)
        Me.cbParamBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parámetros de búsqueda:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(14, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(87, 27)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Grabar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'chkbEditar
        '
        Me.chkbEditar.AutoSize = True
        Me.chkbEditar.Location = New System.Drawing.Point(108, 15)
        Me.chkbEditar.Name = "chkbEditar"
        Me.chkbEditar.Size = New System.Drawing.Size(91, 19)
        Me.chkbEditar.TabIndex = 17
        Me.chkbEditar.Text = "Editar datos"
        Me.chkbEditar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
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
        Me.GroupBox1.Controls.Add(Me.tbNombreCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 245)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(441, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Colonia:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Estado:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(70, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Municipio:"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbObservaciones.Location = New System.Drawing.Point(141, 180)
        Me.tbObservaciones.MaxLength = 200
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(427, 57)
        Me.tbObservaciones.TabIndex = 16
        Me.tbObservaciones.Text = "TBOBSERVACIONES"
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
        Me.Label2.Location = New System.Drawing.Point(70, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Dirección:"
        '
        'tbTelefono3
        '
        Me.tbTelefono3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono3.Location = New System.Drawing.Point(563, 141)
        Me.tbTelefono3.MaxLength = 25
        Me.tbTelefono3.Name = "tbTelefono3"
        Me.tbTelefono3.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono3.TabIndex = 12
        Me.tbTelefono3.Text = "TBTELEFONO3"
        '
        'tbTelefono2
        '
        Me.tbTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono2.Location = New System.Drawing.Point(563, 111)
        Me.tbTelefono2.MaxLength = 25
        Me.tbTelefono2.Name = "tbTelefono2"
        Me.tbTelefono2.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono2.TabIndex = 11
        Me.tbTelefono2.Text = "TBTELEFONO2"
        '
        'tbTelefono1
        '
        Me.tbTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelefono1.Location = New System.Drawing.Point(563, 81)
        Me.tbTelefono1.MaxLength = 25
        Me.tbTelefono1.Name = "tbTelefono1"
        Me.tbTelefono1.Size = New System.Drawing.Size(116, 21)
        Me.tbTelefono1.TabIndex = 10
        Me.tbTelefono1.Text = "TBTELEFONO1"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(141, 120)
        Me.tbEmail.MaxLength = 50
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(116, 21)
        Me.tbEmail.TabIndex = 13
        Me.tbEmail.Text = "tbEmail"
        '
        'tbEstado
        '
        Me.tbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEstado.Location = New System.Drawing.Point(368, 81)
        Me.tbEstado.MaxLength = 50
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(116, 21)
        Me.tbEstado.TabIndex = 9
        Me.tbEstado.Text = "TBESTADO"
        '
        'tbMunicipio
        '
        Me.tbMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMunicipio.Location = New System.Drawing.Point(141, 81)
        Me.tbMunicipio.MaxLength = 100
        Me.tbMunicipio.Name = "tbMunicipio"
        Me.tbMunicipio.Size = New System.Drawing.Size(167, 21)
        Me.tbMunicipio.TabIndex = 8
        Me.tbMunicipio.Text = "TBMUNICIPIO"
        '
        'tbColonia
        '
        Me.tbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbColonia.Location = New System.Drawing.Point(499, 51)
        Me.tbColonia.MaxLength = 50
        Me.tbColonia.Name = "tbColonia"
        Me.tbColonia.Size = New System.Drawing.Size(180, 21)
        Me.tbColonia.TabIndex = 7
        Me.tbColonia.Text = "TBCOLONIA"
        '
        'tbID
        '
        Me.tbID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbID.Location = New System.Drawing.Point(527, 21)
        Me.tbID.MaxLength = 6
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(41, 21)
        Me.tbID.TabIndex = 3
        Me.tbID.Text = "TBID"
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(141, 51)
        Me.tbDomicilio.MaxLength = 80
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(294, 21)
        Me.tbDomicilio.TabIndex = 4
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
        Me.tbRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRFC.Location = New System.Drawing.Point(304, 120)
        Me.tbRFC.MaxLength = 20
        Me.tbRFC.Name = "tbRFC"
        Me.tbRFC.Size = New System.Drawing.Size(180, 21)
        Me.tbRFC.TabIndex = 14
        Me.tbRFC.Text = "TBRFC"
        '
        'tbNombreContacto
        '
        Me.tbNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreContacto.Location = New System.Drawing.Point(141, 150)
        Me.tbNombreContacto.MaxLength = 50
        Me.tbNombreContacto.Name = "tbNombreContacto"
        Me.tbNombreContacto.Size = New System.Drawing.Size(343, 21)
        Me.tbNombreContacto.TabIndex = 15
        Me.tbNombreContacto.Text = "TBNOMBRECONTACTO"
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreCliente.Location = New System.Drawing.Point(141, 21)
        Me.tbNombreCliente.MaxLength = 90
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(347, 21)
        Me.tbNombreCliente.TabIndex = 2
        Me.tbNombreCliente.Text = "TBNOMBRECLIENTE"
        '
        'gbEditarCliente
        '
        Me.gbEditarCliente.Controls.Add(Me.chkbEditar)
        Me.gbEditarCliente.Controls.Add(Me.btnEditar)
        Me.gbEditarCliente.Location = New System.Drawing.Point(461, 305)
        Me.gbEditarCliente.Name = "gbEditarCliente"
        Me.gbEditarCliente.Size = New System.Drawing.Size(207, 42)
        Me.gbEditarCliente.TabIndex = 36
        Me.gbEditarCliente.TabStop = False
        '
        'ListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 647)
        Me.Controls.Add(Me.gbEditarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbParamBusqueda)
        Me.Controls.Add(Me.tbParametroBusqueda)
        Me.Controls.Add(Me.dgvListaClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListaClientes"
        Me.Text = "Lista de Clientes"
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbEditarCliente.ResumeLayout(False)
        Me.gbEditarCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents tbParametroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cbParamBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents chkbEditar As System.Windows.Forms.CheckBox
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
    Friend WithEvents tbNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gbEditarCliente As System.Windows.Forms.GroupBox
End Class
