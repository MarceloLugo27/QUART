<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaProductos
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
        Me.tbNombreProducto = New System.Windows.Forms.TextBox()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAltaProductos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMixto = New System.Windows.Forms.RadioButton()
        Me.rbTerminado = New System.Windows.Forms.RadioButton()
        Me.rbMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkbInventariable = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNombreProducto
        '
        Me.tbNombreProducto.Location = New System.Drawing.Point(129, 58)
        Me.tbNombreProducto.Name = "tbNombreProducto"
        Me.tbNombreProducto.Size = New System.Drawing.Size(363, 21)
        Me.tbNombreProducto.TabIndex = 0
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(129, 88)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(145, 21)
        Me.tbMarca.TabIndex = 0
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(342, 88)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(151, 21)
        Me.tbModelo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Modelo:"
        '
        'btnAltaProductos
        '
        Me.btnAltaProductos.Location = New System.Drawing.Point(326, 136)
        Me.btnAltaProductos.Name = "btnAltaProductos"
        Me.btnAltaProductos.Size = New System.Drawing.Size(138, 53)
        Me.btnAltaProductos.TabIndex = 3
        Me.btnAltaProductos.Text = "Añadir producto"
        Me.btnAltaProductos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMixto)
        Me.GroupBox1.Controls.Add(Me.rbTerminado)
        Me.GroupBox1.Controls.Add(Me.rbMateriaPrima)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 108)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de producto"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'rbMixto
        '
        Me.rbMixto.AutoSize = True
        Me.rbMixto.Location = New System.Drawing.Point(8, 76)
        Me.rbMixto.Name = "rbMixto"
        Me.rbMixto.Size = New System.Drawing.Size(55, 19)
        Me.rbMixto.TabIndex = 0
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
        Me.rbTerminado.TabIndex = 0
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
        Me.rbMateriaPrima.TabIndex = 0
        Me.rbMateriaPrima.TabStop = True
        Me.rbMateriaPrima.Text = "Materia Prima"
        Me.rbMateriaPrima.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(129, 28)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(66, 21)
        Me.tbID.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mostrar Relacion Producto Proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkbInventariable
        '
        Me.chkbInventariable.AutoSize = True
        Me.chkbInventariable.Location = New System.Drawing.Point(392, 30)
        Me.chkbInventariable.Name = "chkbInventariable"
        Me.chkbInventariable.Size = New System.Drawing.Size(96, 19)
        Me.chkbInventariable.TabIndex = 9
        Me.chkbInventariable.Text = "Inventariable"
        Me.chkbInventariable.UseVisualStyleBackColor = True
        '
        'AltaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 268)
        Me.Controls.Add(Me.chkbInventariable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAltaProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbModelo)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.tbMarca)
        Me.Controls.Add(Me.tbNombreProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltaProductos"
        Me.Text = "Alta de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAltaProductos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMixto As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerminado As System.Windows.Forms.RadioButton
    Friend WithEvents rbMateriaPrima As System.Windows.Forms.RadioButton
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkbInventariable As CheckBox
End Class
