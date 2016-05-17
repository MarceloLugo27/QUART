<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicionProductos
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
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.chkAplicaIVA = New System.Windows.Forms.CheckBox()
        Me.gbPrecios = New System.Windows.Forms.GroupBox()
        Me.Precio4 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio3 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio2 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbMixto = New System.Windows.Forms.RadioButton()
        Me.rbTerminado = New System.Windows.Forms.RadioButton()
        Me.rbMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.chkbInventariable = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.tbNombreProducto = New System.Windows.Forms.TextBox()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.gbTodo.SuspendLayout()
        Me.gbPrecios.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.chkAplicaIVA)
        Me.gbTodo.Controls.Add(Me.gbPrecios)
        Me.gbTodo.Controls.Add(Me.btnEditarProducto)
        Me.gbTodo.Controls.Add(Me.cbProveedor)
        Me.gbTodo.Controls.Add(Me.cbTipoUnidad)
        Me.gbTodo.Controls.Add(Me.Label5)
        Me.gbTodo.Controls.Add(Me.Label6)
        Me.gbTodo.Controls.Add(Me.gbTipo)
        Me.gbTodo.Controls.Add(Me.chkbInventariable)
        Me.gbTodo.Controls.Add(Me.Label3)
        Me.gbTodo.Controls.Add(Me.Label2)
        Me.gbTodo.Controls.Add(Me.Label1)
        Me.gbTodo.Controls.Add(Me.tbModelo)
        Me.gbTodo.Controls.Add(Me.tbMarca)
        Me.gbTodo.Controls.Add(Me.tbNombreProducto)
        Me.gbTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTodo.Location = New System.Drawing.Point(12, 50)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(572, 354)
        Me.gbTodo.TabIndex = 29
        Me.gbTodo.TabStop = False
        '
        'chkAplicaIVA
        '
        Me.chkAplicaIVA.AutoSize = True
        Me.chkAplicaIVA.Location = New System.Drawing.Point(183, 277)
        Me.chkAplicaIVA.Name = "chkAplicaIVA"
        Me.chkAplicaIVA.Size = New System.Drawing.Size(79, 19)
        Me.chkAplicaIVA.TabIndex = 26
        Me.chkAplicaIVA.Text = "Aplica IVA"
        Me.chkAplicaIVA.UseVisualStyleBackColor = True
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
        'btnEditarProducto
        '
        Me.btnEditarProducto.Location = New System.Drawing.Point(473, 294)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(75, 44)
        Me.btnEditarProducto.TabIndex = 17
        Me.btnEditarProducto.Text = "Editar producto"
        Me.btnEditarProducto.UseVisualStyleBackColor = True
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(86, 200)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(259, 23)
        Me.cbProveedor.TabIndex = 8
        '
        'cbTipoUnidad
        '
        Me.cbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoUnidad.FormattingEnabled = True
        Me.cbTipoUnidad.Location = New System.Drawing.Point(132, 153)
        Me.cbTipoUnidad.Name = "cbTipoUnidad"
        Me.cbTipoUnidad.Size = New System.Drawing.Size(117, 23)
        Me.cbTipoUnidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Unidad de medida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Proveedor:"
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbMixto)
        Me.gbTipo.Controls.Add(Me.rbTerminado)
        Me.gbTipo.Controls.Add(Me.rbMateriaPrima)
        Me.gbTipo.Location = New System.Drawing.Point(22, 228)
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
        'chkbInventariable
        '
        Me.chkbInventariable.AutoSize = True
        Me.chkbInventariable.Location = New System.Drawing.Point(183, 251)
        Me.chkbInventariable.Name = "chkbInventariable"
        Me.chkbInventariable.Size = New System.Drawing.Size(96, 19)
        Me.chkbInventariable.TabIndex = 12
        Me.chkbInventariable.Text = "Inventariable"
        Me.chkbInventariable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Modelo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre Producto:"
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(340, 60)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(151, 21)
        Me.tbModelo.TabIndex = 5
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(129, 60)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(145, 21)
        Me.tbMarca.TabIndex = 4
        '
        'tbNombreProducto
        '
        Me.tbNombreProducto.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombreProducto.Location = New System.Drawing.Point(127, 30)
        Me.tbNombreProducto.Name = "tbNombreProducto"
        Me.tbNombreProducto.Size = New System.Drawing.Size(363, 21)
        Me.tbNombreProducto.TabIndex = 3
        '
        'tbProducto
        '
        Me.tbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProducto.Location = New System.Drawing.Point(12, 24)
        Me.tbProducto.MaxLength = 14
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(91, 21)
        Me.tbProducto.TabIndex = 30
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(109, 24)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(332, 23)
        Me.cbProducto.TabIndex = 31
        '
        'EdicionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 409)
        Me.Controls.Add(Me.tbProducto)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.gbTodo)
        Me.Name = "EdicionProductos"
        Me.Text = "EdicionProductos"
        Me.gbTodo.ResumeLayout(False)
        Me.gbTodo.PerformLayout()
        Me.gbPrecios.ResumeLayout(False)
        Me.gbPrecios.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTodo As GroupBox
    Friend WithEvents chkAplicaIVA As CheckBox
    Friend WithEvents gbPrecios As GroupBox
    Friend WithEvents Precio4 As MaskedTextBox
    Friend WithEvents Precio3 As MaskedTextBox
    Friend WithEvents Precio2 As MaskedTextBox
    Friend WithEvents Precio1 As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEditarProducto As Button
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents cbTipoUnidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents rbMixto As RadioButton
    Friend WithEvents rbTerminado As RadioButton
    Friend WithEvents rbMateriaPrima As RadioButton
    Friend WithEvents chkbInventariable As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbModelo As TextBox
    Friend WithEvents tbMarca As TextBox
    Friend WithEvents tbNombreProducto As TextBox
    Friend WithEvents tbProducto As TextBox
    Friend WithEvents cbProducto As ComboBox
End Class
