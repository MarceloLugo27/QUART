<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaSalidaAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaSalidaAlmacen))
        Me.lblContar = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dgvPartidas = New System.Windows.Forms.DataGridView()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnImprimirVenta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblContar
        '
        Me.lblContar.AutoSize = True
        Me.lblContar.Location = New System.Drawing.Point(744, 106)
        Me.lblContar.Name = "lblContar"
        Me.lblContar.Size = New System.Drawing.Size(45, 15)
        Me.lblContar.TabIndex = 36
        Me.lblContar.Text = "Label5"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(802, 56)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(152, 25)
        Me.btnConsultar.TabIndex = 33
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(667, 59)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaFinal.TabIndex = 32
        Me.dtFechaFinal.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = ""
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(535, 59)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaInicial.TabIndex = 31
        Me.dtFechaInicial.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'cbFiltro
        '
        Me.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"TODAS", "El día de hoy", "Esta semana", "Las ultimas dos semanas", "Este Mes", "El mes pasado", "El día de...", "Entre los dias..."})
        Me.cbFiltro.Location = New System.Drawing.Point(361, 58)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(152, 23)
        Me.cbFiltro.TabIndex = 30
        Me.cbFiltro.Text = "TODAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Fechas"
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(141, 70)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(174, 21)
        Me.tbCliente.TabIndex = 27
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(10, 96)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(305, 23)
        Me.cbCliente.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Seleccione el Cliente"
        '
        'cbTipoVenta
        '
        Me.cbTipoVenta.DisplayMember = "TODAS"
        Me.cbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVenta.FormattingEnabled = True
        Me.cbTipoVenta.Items.AddRange(New Object() {"TODAS", "XML", "MOSTRADOR"})
        Me.cbTipoVenta.Location = New System.Drawing.Point(179, 33)
        Me.cbTipoVenta.Name = "cbTipoVenta"
        Me.cbTipoVenta.Size = New System.Drawing.Size(136, 23)
        Me.cbTipoVenta.TabIndex = 25
        Me.cbTipoVenta.ValueMember = "TODAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Seleccione el Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Seleccione la Empresa"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Items.AddRange(New Object() {"TODAS", "QUART", "AARON"})
        Me.cbEmpresa.Location = New System.Drawing.Point(10, 33)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(136, 23)
        Me.cbEmpresa.TabIndex = 24
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(10, 150)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(1139, 163)
        Me.dgvVentas.TabIndex = 37
        '
        'dgvPartidas
        '
        Me.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidas.Location = New System.Drawing.Point(10, 319)
        Me.dgvPartidas.Name = "dgvPartidas"
        Me.dgvPartidas.Size = New System.Drawing.Size(1139, 183)
        Me.dgvPartidas.TabIndex = 38
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(206, 508)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(199, 27)
        Me.btnExportarExcel.TabIndex = 41
        Me.btnExportarExcel.Text = "Exportar Lista de Salidas"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'btnImprimirVenta
        '
        Me.btnImprimirVenta.Location = New System.Drawing.Point(852, 508)
        Me.btnImprimirVenta.Name = "btnImprimirVenta"
        Me.btnImprimirVenta.Size = New System.Drawing.Size(166, 27)
        Me.btnImprimirVenta.TabIndex = 39
        Me.btnImprimirVenta.Text = "Visualizar Orden de Salida"
        Me.btnImprimirVenta.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(671, 508)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(166, 27)
        Me.btnLimpiar.TabIndex = 40
        Me.btnLimpiar.Text = "Nueva Consulta"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ListaSalidaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 547)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.btnImprimirVenta)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.dgvPartidas)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.lblContar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicial)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCliente)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipoVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListaSalidaAlmacen"
        Me.Text = "Lista de Salidas del Almacén"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblContar As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
    Friend WithEvents btnImprimirVenta As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
