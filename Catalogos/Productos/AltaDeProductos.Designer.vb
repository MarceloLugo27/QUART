<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaDeProductos
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
        Me.chkbInventariable = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.tbNombreProducto = New System.Windows.Forms.TextBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbMixto = New System.Windows.Forms.RadioButton()
        Me.rbTerminado = New System.Windows.Forms.RadioButton()
        Me.rbMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbUnidadMedida = New System.Windows.Forms.TextBox()
        Me.gbPrecios = New System.Windows.Forms.GroupBox()
        Me.Precio4 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio3 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio2 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAñadirProducto = New System.Windows.Forms.Button()
        Me.btnAñadirID = New System.Windows.Forms.Button()
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.chkAplicaIVA = New System.Windows.Forms.CheckBox()
        Me.gbTipo.SuspendLayout()
        Me.gbPrecios.SuspendLayout()
        Me.gbTodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkbInventariable
        '
        Me.chkbInventariable.AutoSize = True
        Me.chkbInventariable.Location = New System.Drawing.Point(243, 228)
        Me.chkbInventariable.Name = "chkbInventariable"
        Me.chkbInventariable.Size = New System.Drawing.Size(96, 19)
        Me.chkbInventariable.TabIndex = 12
        Me.chkbInventariable.Text = "Inventariable"
        Me.chkbInventariable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Modelo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre Producto:"
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(347, 46)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(151, 21)
        Me.tbModelo.TabIndex = 5
        '
        'tbID
        '
        Me.tbID.BackColor = System.Drawing.SystemColors.Window
        Me.tbID.Location = New System.Drawing.Point(157, 15)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(66, 21)
        Me.tbID.TabIndex = 1
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(134, 46)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(145, 21)
        Me.tbMarca.TabIndex = 4
        '
        'tbNombreProducto
        '
        Me.tbNombreProducto.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombreProducto.Location = New System.Drawing.Point(134, 16)
        Me.tbNombreProducto.Name = "tbNombreProducto"
        Me.tbNombreProducto.Size = New System.Drawing.Size(363, 21)
        Me.tbNombreProducto.TabIndex = 3
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbMixto)
        Me.gbTipo.Controls.Add(Me.rbTerminado)
        Me.gbTipo.Controls.Add(Me.rbMateriaPrima)
        Me.gbTipo.Location = New System.Drawing.Point(64, 188)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(136, 108)
        Me.gbTipo.TabIndex = 19
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo de producto"
        Me.gbTipo.UseCompatibleTextRendering = True
        Me.gbTipo.Visible = False
        '
        'rbMixto
        '
        Me.rbMixto.AutoSize = True
        Me.rbMixto.Location = New System.Drawing.Point(8, 76)
        Me.rbMixto.Name = "rbMixto"
        Me.rbMixto.Size = New System.Drawing.Size(55, 19)
        Me.rbMixto.TabIndex = 11
        Me.rbMixto.TabStop = True
        Me.rbMixto.Text = "Mixto"
        Me.rbMixto.UseVisualStyleBackColor = True
        '
        'rbTerminado
        '
        Me.rbTerminado.AutoSize = True
        Me.rbTerminado.Location = New System.Drawing.Point(8, 50)
        Me.rbTerminado.Name = "rbTerminado"
        Me.rbTerminado.Size = New System.Drawing.Size(85, 19)
        Me.rbTerminado.TabIndex = 10
        Me.rbTerminado.TabStop = True
        Me.rbTerminado.Text = "Terminado"
        Me.rbTerminado.UseVisualStyleBackColor = True
        '
        'rbMateriaPrima
        '
        Me.rbMateriaPrima.AutoSize = True
        Me.rbMateriaPrima.Location = New System.Drawing.Point(8, 23)
        Me.rbMateriaPrima.Name = "rbMateriaPrima"
        Me.rbMateriaPrima.Size = New System.Drawing.Size(103, 19)
        Me.rbMateriaPrima.TabIndex = 9
        Me.rbMateriaPrima.TabStop = True
        Me.rbMateriaPrima.Text = "Materia Prima"
        Me.rbMateriaPrima.UseVisualStyleBackColor = True
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(84, 150)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(259, 23)
        Me.cbProveedor.TabIndex = 8
        '
        'cbTipoUnidad
        '
        Me.cbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoUnidad.FormattingEnabled = True
        Me.cbTipoUnidad.Location = New System.Drawing.Point(207, 103)
        Me.cbTipoUnidad.Name = "cbTipoUnidad"
        Me.cbTipoUnidad.Size = New System.Drawing.Size(117, 23)
        Me.cbTipoUnidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Unidad de medida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Proveedor:"
        '
        'tbUnidadMedida
        '
        Me.tbUnidadMedida.BackColor = System.Drawing.SystemColors.Window
        Me.tbUnidadMedida.Enabled = False
        Me.tbUnidadMedida.Location = New System.Drawing.Point(149, 104)
        Me.tbUnidadMedida.Name = "tbUnidadMedida"
        Me.tbUnidadMedida.Size = New System.Drawing.Size(49, 21)
        Me.tbUnidadMedida.TabIndex = 6
        Me.tbUnidadMedida.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tbUnidadMedida.Visible = False
        '
        'gbPrecios
        '
        Me.gbPrecios.Controls.Add(Me.Precio4)
        Me.gbPrecios.Controls.Add(Me.Precio3)
        Me.gbPrecios.Controls.Add(Me.Precio2)
        Me.gbPrecios.Controls.Add(Me.Precio1)
        Me.gbPrecios.Controls.Add(Me.Label10)
        Me.gbPrecios.Controls.Add(Me.Label9)
        Me.gbPrecios.Controls.Add(Me.Label8)
        Me.gbPrecios.Controls.Add(Me.Label7)
        Me.gbPrecios.Location = New System.Drawing.Point(377, 91)
        Me.gbPrecios.Name = "gbPrecios"
        Me.gbPrecios.Size = New System.Drawing.Size(182, 181)
        Me.gbPrecios.TabIndex = 25
        Me.gbPrecios.TabStop = False
        Me.gbPrecios.Text = "Precios"
        '
        'Precio4
        '
        Me.Precio4.Location = New System.Drawing.Point(95, 141)
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Size = New System.Drawing.Size(69, 21)
        Me.Precio4.TabIndex = 16
        '
        'Precio3
        '
        Me.Precio3.Location = New System.Drawing.Point(95, 103)
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Size = New System.Drawing.Size(69, 21)
        Me.Precio3.TabIndex = 15
        '
        'Precio2
        '
        Me.Precio2.Location = New System.Drawing.Point(95, 65)
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Size = New System.Drawing.Size(69, 21)
        Me.Precio2.TabIndex = 14
        '
        'Precio1
        '
        Me.Precio1.BackColor = System.Drawing.SystemColors.Window
        Me.Precio1.Location = New System.Drawing.Point(95, 27)
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Size = New System.Drawing.Size(69, 21)
        Me.Precio1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tipo 4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tipo 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tipo 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tipo 1"
        '
        'btnAñadirProducto
        '
        Me.btnAñadirProducto.Location = New System.Drawing.Point(473, 294)
        Me.btnAñadirProducto.Name = "btnAñadirProducto"
        Me.btnAñadirProducto.Size = New System.Drawing.Size(75, 44)
        Me.btnAñadirProducto.TabIndex = 17
        Me.btnAñadirProducto.Text = "Añadir Producto"
        Me.btnAñadirProducto.UseVisualStyleBackColor = True
        '
        'btnAñadirID
        '
        Me.btnAñadirID.Font = New System.Drawing.Font("Webdings", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnAñadirID.Location = New System.Drawing.Point(229, 15)
        Me.btnAñadirID.Name = "btnAñadirID"
        Me.btnAñadirID.Size = New System.Drawing.Size(33, 21)
        Me.btnAñadirID.TabIndex = 2
        Me.btnAñadirID.Text = "n n"
        Me.btnAñadirID.UseVisualStyleBackColor = True
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.chkAplicaIVA)
        Me.gbTodo.Controls.Add(Me.gbPrecios)
        Me.gbTodo.Controls.Add(Me.btnAñadirProducto)
        Me.gbTodo.Controls.Add(Me.cbProveedor)
        Me.gbTodo.Controls.Add(Me.cbTipoUnidad)
        Me.gbTodo.Controls.Add(Me.Label5)
        Me.gbTodo.Controls.Add(Me.Label6)
        Me.gbTodo.Controls.Add(Me.tbUnidadMedida)
        Me.gbTodo.Controls.Add(Me.gbTipo)
        Me.gbTodo.Controls.Add(Me.chkbInventariable)
        Me.gbTodo.Controls.Add(Me.Label3)
        Me.gbTodo.Controls.Add(Me.Label2)
        Me.gbTodo.Controls.Add(Me.Label1)
        Me.gbTodo.Controls.Add(Me.tbModelo)
        Me.gbTodo.Controls.Add(Me.tbMarca)
        Me.gbTodo.Controls.Add(Me.tbNombreProducto)
        Me.gbTodo.Location = New System.Drawing.Point(12, 42)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(572, 354)
        Me.gbTodo.TabIndex = 28
        Me.gbTodo.TabStop = False
        '
        'chkAplicaIVA
        '
        Me.chkAplicaIVA.AutoSize = True
        Me.chkAplicaIVA.Location = New System.Drawing.Point(243, 254)
        Me.chkAplicaIVA.Name = "chkAplicaIVA"
        Me.chkAplicaIVA.Size = New System.Drawing.Size(79, 19)
        Me.chkAplicaIVA.TabIndex = 26
        Me.chkAplicaIVA.Text = "Aplica IVA"
        Me.chkAplicaIVA.UseVisualStyleBackColor = True
        '
        'AltaDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 408)
        Me.Controls.Add(Me.gbTodo)
        Me.Controls.Add(Me.btnAñadirID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltaDeProductos"
        Me.Text = "Alta de Productos"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.gbPrecios.ResumeLayout(False)
        Me.gbPrecios.PerformLayout()
        Me.gbTodo.ResumeLayout(False)
        Me.gbTodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkbInventariable As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbMixto As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerminado As System.Windows.Forms.RadioButton
    Friend WithEvents rbMateriaPrima As System.Windows.Forms.RadioButton
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents gbPrecios As System.Windows.Forms.GroupBox
    Friend WithEvents Precio4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAñadirProducto As Button
    Friend WithEvents btnAñadirID As Button
    Friend WithEvents gbTodo As System.Windows.Forms.GroupBox
    Friend WithEvents chkAplicaIVA As CheckBox
End Class
