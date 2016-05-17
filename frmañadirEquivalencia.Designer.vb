<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAñadirEquivalencia
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
        Me.tbProducto1 = New System.Windows.Forms.TextBox()
        Me.cbUM1 = New System.Windows.Forms.ComboBox()
        Me.cbProducto1 = New System.Windows.Forms.ComboBox()
        Me.cbProducto2 = New System.Windows.Forms.ComboBox()
        Me.cbUM2 = New System.Windows.Forms.ComboBox()
        Me.tbProducto2 = New System.Windows.Forms.TextBox()
        Me.tbCantidadEquivalente2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSentido = New System.Windows.Forms.ComboBox()
        Me.btnCrearEquivalencia = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCantidadEquivalente1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbProducto1
        '
        Me.tbProducto1.Location = New System.Drawing.Point(110, 99)
        Me.tbProducto1.MaxLength = 14
        Me.tbProducto1.Name = "tbProducto1"
        Me.tbProducto1.Size = New System.Drawing.Size(91, 20)
        Me.tbProducto1.TabIndex = 2
        '
        'cbUM1
        '
        Me.cbUM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM1.FormattingEnabled = True
        Me.cbUM1.Location = New System.Drawing.Point(545, 99)
        Me.cbUM1.Name = "cbUM1"
        Me.cbUM1.Size = New System.Drawing.Size(79, 21)
        Me.cbUM1.TabIndex = 4
        '
        'cbProducto1
        '
        Me.cbProducto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto1.FormattingEnabled = True
        Me.cbProducto1.Location = New System.Drawing.Point(207, 99)
        Me.cbProducto1.Name = "cbProducto1"
        Me.cbProducto1.Size = New System.Drawing.Size(332, 21)
        Me.cbProducto1.TabIndex = 3
        '
        'cbProducto2
        '
        Me.cbProducto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto2.FormattingEnabled = True
        Me.cbProducto2.Location = New System.Drawing.Point(224, 218)
        Me.cbProducto2.Name = "cbProducto2"
        Me.cbProducto2.Size = New System.Drawing.Size(315, 21)
        Me.cbProducto2.TabIndex = 7
        '
        'cbUM2
        '
        Me.cbUM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM2.FormattingEnabled = True
        Me.cbUM2.Location = New System.Drawing.Point(545, 218)
        Me.cbUM2.Name = "cbUM2"
        Me.cbUM2.Size = New System.Drawing.Size(79, 21)
        Me.cbUM2.TabIndex = 8
        '
        'tbProducto2
        '
        Me.tbProducto2.Location = New System.Drawing.Point(110, 218)
        Me.tbProducto2.MaxLength = 14
        Me.tbProducto2.Name = "tbProducto2"
        Me.tbProducto2.Size = New System.Drawing.Size(108, 20)
        Me.tbProducto2.TabIndex = 6
        '
        'tbCantidadEquivalente2
        '
        Me.tbCantidadEquivalente2.Location = New System.Drawing.Point(45, 218)
        Me.tbCantidadEquivalente2.Name = "tbCantidadEquivalente2"
        Me.tbCantidadEquivalente2.Size = New System.Drawing.Size(59, 20)
        Me.tbCantidadEquivalente2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Sentido de la equivalencia:"
        Me.Label3.Visible = False
        '
        'cbSentido
        '
        Me.cbSentido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSentido.FormattingEnabled = True
        Me.cbSentido.Items.AddRange(New Object() {"Multiplicativa", "Dividida"})
        Me.cbSentido.Location = New System.Drawing.Point(115, 296)
        Me.cbSentido.Name = "cbSentido"
        Me.cbSentido.Size = New System.Drawing.Size(155, 21)
        Me.cbSentido.TabIndex = 22
        Me.cbSentido.Visible = False
        '
        'btnCrearEquivalencia
        '
        Me.btnCrearEquivalencia.Location = New System.Drawing.Point(560, 321)
        Me.btnCrearEquivalencia.Name = "btnCrearEquivalencia"
        Me.btnCrearEquivalencia.Size = New System.Drawing.Size(128, 69)
        Me.btnCrearEquivalencia.TabIndex = 9
        Me.btnCrearEquivalencia.Text = "Crear equivalencia"
        Me.btnCrearEquivalencia.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Y este producto equivale a:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Seleccione el producto como es comprado normalmente:"
        '
        'tbCantidadEquivalente1
        '
        Me.tbCantidadEquivalente1.Location = New System.Drawing.Point(45, 100)
        Me.tbCantidadEquivalente1.Name = "tbCantidadEquivalente1"
        Me.tbCantidadEquivalente1.Size = New System.Drawing.Size(59, 20)
        Me.tbCantidadEquivalente1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cantidad:"
        '
        'frmAñadirEquivalencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 454)
        Me.Controls.Add(Me.tbCantidadEquivalente1)
        Me.Controls.Add(Me.btnCrearEquivalencia)
        Me.Controls.Add(Me.cbSentido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCantidadEquivalente2)
        Me.Controls.Add(Me.tbProducto2)
        Me.Controls.Add(Me.cbUM2)
        Me.Controls.Add(Me.tbProducto1)
        Me.Controls.Add(Me.cbProducto2)
        Me.Controls.Add(Me.cbUM1)
        Me.Controls.Add(Me.cbProducto1)
        Me.Name = "frmAñadirEquivalencia"
        Me.Text = "Añadir Equivalencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbProducto1 As TextBox
    Friend WithEvents cbUM1 As ComboBox
    Friend WithEvents cbProducto1 As ComboBox
    Friend WithEvents cbProducto2 As ComboBox
    Friend WithEvents cbUM2 As ComboBox
    Friend WithEvents tbProducto2 As TextBox
    Friend WithEvents tbCantidadEquivalente2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSentido As ComboBox
    Friend WithEvents btnCrearEquivalencia As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCantidadEquivalente1 As TextBox
    Friend WithEvents Label1 As Label
End Class
