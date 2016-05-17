<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaProductos))
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.chkAgrupar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbProd = New System.Windows.Forms.TextBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 153)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(940, 363)
        Me.dgvProductos.TabIndex = 0
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(80, 560)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(222, 38)
        Me.btnExportarExcel.TabIndex = 51
        Me.btnExportarExcel.Text = "Exportar Listado de Ventas"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'tbProducto
        '
        Me.tbProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProducto.Location = New System.Drawing.Point(338, 535)
        Me.tbProducto.MaxLength = 30
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(282, 20)
        Me.tbProducto.TabIndex = 52
        Me.tbProducto.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(626, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Obtener Listado"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 538)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nombre del producto:"
        Me.Label1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Seleccione la Empresa Compradora"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Items.AddRange(New Object() {"TODAS", "QUART INDUSTRIA", "AARON URDIALES"})
        Me.cbEmpresa.Location = New System.Drawing.Point(190, 126)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(127, 21)
        Me.cbEmpresa.TabIndex = 67
        '
        'chkAgrupar
        '
        Me.chkAgrupar.AutoSize = True
        Me.chkAgrupar.Location = New System.Drawing.Point(363, 97)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(174, 17)
        Me.chkAgrupar.TabIndex = 68
        Me.chkAgrupar.Text = "Agrupar por Precio y Proveedor"
        Me.chkAgrupar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.cbFiltro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(338, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 70)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la fecha"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(331, 38)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(107, 20)
        Me.dtFechaFinal.TabIndex = 18
        Me.dtFechaFinal.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = ""
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(199, 38)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(107, 20)
        Me.dtFechaInicial.TabIndex = 17
        Me.dtFechaInicial.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'cbFiltro
        '
        Me.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"TODAS", "El día de hoy", "Esta semana", "Las ultimas dos semanas", "Este Mes", "El mes pasado", "El día de...", "Entre los dias..."})
        Me.cbFiltro.Location = New System.Drawing.Point(25, 37)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(152, 21)
        Me.cbFiltro.TabIndex = 16
        Me.cbFiltro.Text = "TODAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fechas"
        '
        'tbProd
        '
        Me.tbProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProd.Location = New System.Drawing.Point(167, 66)
        Me.tbProd.Name = "tbProd"
        Me.tbProd.Size = New System.Drawing.Size(150, 20)
        Me.tbProd.TabIndex = 65
        '
        'tbCliente
        '
        Me.tbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCliente.Location = New System.Drawing.Point(167, 6)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(150, 20)
        Me.tbCliente.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Seleccione al Producto"
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(12, 93)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(305, 21)
        Me.cbProducto.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Seleccione al cliente:"
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(12, 33)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(305, 21)
        Me.cbCliente.TabIndex = 64
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(586, 93)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(154, 23)
        Me.btnListado.TabIndex = 69
        Me.btnListado.Text = "Obtener Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'cbOrigen
        '
        Me.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"TODAS", "XML", "MOSTRADOR"})
        Me.cbOrigen.Location = New System.Drawing.Point(435, 126)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(127, 21)
        Me.cbOrigen.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Seleccione el origen:"
        '
        'VentaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 645)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.chkAgrupar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbProd)
        Me.Controls.Add(Me.tbCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbProducto)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "VentaProductos"
        Me.Text = "VentaProductos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents tbProducto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEmpresa As ComboBox
    Friend WithEvents chkAgrupar As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFechaFinal As DateTimePicker
    Friend WithEvents dtFechaInicial As DateTimePicker
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbProd As TextBox
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents btnListado As Button
    Friend WithEvents cbOrigen As ComboBox
    Friend WithEvents Label6 As Label
End Class
