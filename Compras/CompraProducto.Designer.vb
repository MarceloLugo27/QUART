<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraProducto))
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbProd = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.chkAgrupar = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 153)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(1049, 374)
        Me.dgvProductos.StandardTab = True
        Me.dgvProductos.TabIndex = 21
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(77, 533)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(222, 38)
        Me.btnExportarExcel.TabIndex = 22
        Me.btnExportarExcel.Text = "Exportar Listado de compras"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(548, 452)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(154, 23)
        Me.btnRecargar.TabIndex = 52
        Me.btnRecargar.Text = "Obtener Listado"
        Me.btnRecargar.UseVisualStyleBackColor = True
        Me.btnRecargar.Visible = False
        '
        'tbProducto
        '
        Me.tbProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProducto.Location = New System.Drawing.Point(260, 455)
        Me.tbProducto.MaxLength = 30
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(205, 20)
        Me.tbProducto.TabIndex = 53
        Me.tbProducto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Nombre del producto:"
        Me.Label1.Visible = False
        '
        'tbProveedor
        '
        Me.tbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProveedor.Location = New System.Drawing.Point(179, 6)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(150, 20)
        Me.tbProveedor.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Seleccione al Proveedor"
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(24, 33)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(305, 21)
        Me.cbProveedor.TabIndex = 12
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(24, 93)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(305, 21)
        Me.cbProducto.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Seleccione al Producto"
        '
        'tbProd
        '
        Me.tbProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProd.Location = New System.Drawing.Point(179, 66)
        Me.tbProd.Name = "tbProd"
        Me.tbProd.Size = New System.Drawing.Size(150, 20)
        Me.tbProd.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.cbFiltro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(350, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 70)
        Me.GroupBox1.TabIndex = 59
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
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(598, 93)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(154, 23)
        Me.btnListado.TabIndex = 20
        Me.btnListado.Text = "Obtener Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'chkAgrupar
        '
        Me.chkAgrupar.AutoSize = True
        Me.chkAgrupar.Location = New System.Drawing.Point(375, 97)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(174, 17)
        Me.chkAgrupar.TabIndex = 19
        Me.chkAgrupar.Text = "Agrupar por Precio y Proveedor"
        Me.chkAgrupar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Seleccione la Empresa Compradora"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Items.AddRange(New Object() {"TODAS", "QUART INDUSTRIA", "AARON URDIALES"})
        Me.cbEmpresa.Location = New System.Drawing.Point(202, 126)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(127, 21)
        Me.cbEmpresa.TabIndex = 15
        '
        'CompraProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 583)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.chkAgrupar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbProd)
        Me.Controls.Add(Me.tbProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbProducto)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "CompraProducto"
        Me.Text = "CompraProducto"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents btnRecargar As Button
    Friend WithEvents tbProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbProd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents chkAgrupar As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
End Class
