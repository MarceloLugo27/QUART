<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoProveedor
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
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.cbTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUnidadMedida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbProveedor
        '
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(100, 61)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(259, 23)
        Me.cbProveedor.TabIndex = 14
        Me.cbProveedor.Text = "cbProveedor"
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(100, 30)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(259, 23)
        Me.cbProducto.TabIndex = 15
        Me.cbProducto.Text = "cbProducto"
        '
        'btnAsociar
        '
        Me.btnAsociar.Location = New System.Drawing.Point(151, 175)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(87, 27)
        Me.btnAsociar.TabIndex = 13
        Me.btnAsociar.Text = "Asociar"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'cbTipoUnidad
        '
        Me.cbTipoUnidad.FormattingEnabled = True
        Me.cbTipoUnidad.Location = New System.Drawing.Point(224, 124)
        Me.cbTipoUnidad.Name = "cbTipoUnidad"
        Me.cbTipoUnidad.Size = New System.Drawing.Size(117, 23)
        Me.cbTipoUnidad.TabIndex = 12
        Me.cbTipoUnidad.Text = "cbTipoUnidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Unidad de medida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Proveedor:"
        '
        'tbUnidadMedida
        '
        Me.tbUnidadMedida.Enabled = False
        Me.tbUnidadMedida.Location = New System.Drawing.Point(166, 125)
        Me.tbUnidadMedida.Name = "tbUnidadMedida"
        Me.tbUnidadMedida.Size = New System.Drawing.Size(49, 21)
        Me.tbUnidadMedida.TabIndex = 8
        Me.tbUnidadMedida.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Producto:"
        '
        'ProductoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 234)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.cbTipoUnidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbUnidadMedida)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductoProveedor"
        Me.Text = "Relación Producto Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents btnAsociar As Button
    Friend WithEvents cbTipoUnidad As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUnidadMedida As TextBox
    Friend WithEvents Label1 As Label
End Class
