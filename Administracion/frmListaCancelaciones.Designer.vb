<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCancelaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCancelaciones))
        Me.cbDocumento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbFiltoFecha = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvPartidas = New System.Windows.Forms.DataGridView()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.gbFiltoFecha.SuspendLayout()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbDocumento
        '
        Me.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumento.FormattingEnabled = True
        Me.cbDocumento.Items.AddRange(New Object() {"COMPRAS", "VENTAS"})
        Me.cbDocumento.Location = New System.Drawing.Point(15, 41)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(158, 23)
        Me.cbDocumento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione la Empresa"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Items.AddRange(New Object() {"TODAS", "QUART", "AARON"})
        Me.cbEmpresa.Location = New System.Drawing.Point(193, 41)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(136, 23)
        Me.cbEmpresa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo de Documento"
        '
        'gbFiltoFecha
        '
        Me.gbFiltoFecha.Controls.Add(Me.btnConsultar)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaFinal)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaInicial)
        Me.gbFiltoFecha.Controls.Add(Me.cbFiltro)
        Me.gbFiltoFecha.Location = New System.Drawing.Point(347, 12)
        Me.gbFiltoFecha.Name = "gbFiltoFecha"
        Me.gbFiltoFecha.Size = New System.Drawing.Size(643, 67)
        Me.gbFiltoFecha.TabIndex = 5
        Me.gbFiltoFecha.TabStop = False
        Me.gbFiltoFecha.Text = "Seleccione un rango de fechas"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(552, 25)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 28)
        Me.btnConsultar.TabIndex = 20
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(386, 31)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaFinal.TabIndex = 19
        Me.dtFechaFinal.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = ""
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(220, 31)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaInicial.TabIndex = 18
        Me.dtFechaInicial.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'cbFiltro
        '
        Me.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"TODAS", "El día de hoy", "Esta semana", "Las ultimas dos semanas", "Este Mes", "El mes pasado", "El día de...", "Entre los dias..."})
        Me.cbFiltro.Location = New System.Drawing.Point(9, 29)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(152, 23)
        Me.cbFiltro.TabIndex = 17
        Me.cbFiltro.Text = "TODAS"
        '
        'dgvPartidas
        '
        Me.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidas.Location = New System.Drawing.Point(12, 280)
        Me.dgvPartidas.Name = "dgvPartidas"
        Me.dgvPartidas.Size = New System.Drawing.Size(978, 296)
        Me.dgvPartidas.TabIndex = 20
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 85)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(978, 189)
        Me.dgvDocumentos.TabIndex = 19
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(61, 587)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(245, 27)
        Me.btnExportarExcel.TabIndex = 23
        Me.btnExportarExcel.Text = "Exportar Lista de Cancelaciones"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'frmListaCancelaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 624)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.dgvPartidas)
        Me.Controls.Add(Me.dgvDocumentos)
        Me.Controls.Add(Me.gbFiltoFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaCancelaciones"
        Me.Text = "Lista de Cancelaciones Realizadas"
        Me.gbFiltoFecha.ResumeLayout(False)
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbFiltoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
End Class
