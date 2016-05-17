<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaciones
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
        Me.gbTipoDocumento = New System.Windows.Forms.GroupBox()
        Me.cbDocumento = New System.Windows.Forms.ComboBox()
        Me.gbFiltoFecha = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.dgvPartidas = New System.Windows.Forms.DataGridView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbMotivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.gbTipoDocumento.SuspendLayout()
        Me.gbFiltoFecha.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTipoDocumento
        '
        Me.gbTipoDocumento.Controls.Add(Me.cbDocumento)
        Me.gbTipoDocumento.Location = New System.Drawing.Point(12, 12)
        Me.gbTipoDocumento.Name = "gbTipoDocumento"
        Me.gbTipoDocumento.Size = New System.Drawing.Size(222, 67)
        Me.gbTipoDocumento.TabIndex = 0
        Me.gbTipoDocumento.TabStop = False
        Me.gbTipoDocumento.Text = "Tipo de Documento a Cancelar"
        '
        'cbDocumento
        '
        Me.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumento.FormattingEnabled = True
        Me.cbDocumento.Items.AddRange(New Object() {"COMPRAS", "VENTAS"})
        Me.cbDocumento.Location = New System.Drawing.Point(21, 25)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(180, 23)
        Me.cbDocumento.TabIndex = 0
        '
        'gbFiltoFecha
        '
        Me.gbFiltoFecha.Controls.Add(Me.btnConsultar)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaFinal)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaInicial)
        Me.gbFiltoFecha.Controls.Add(Me.cbFiltro)
        Me.gbFiltoFecha.Location = New System.Drawing.Point(253, 12)
        Me.gbFiltoFecha.Name = "gbFiltoFecha"
        Me.gbFiltoFecha.Size = New System.Drawing.Size(698, 67)
        Me.gbFiltoFecha.TabIndex = 1
        Me.gbFiltoFecha.TabStop = False
        Me.gbFiltoFecha.Text = "Seleccione un rango de fechas"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(555, 21)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 28)
        Me.btnConsultar.TabIndex = 20
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(388, 27)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaFinal.TabIndex = 19
        Me.dtFechaFinal.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = ""
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(234, 27)
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
        Me.cbFiltro.Location = New System.Drawing.Point(56, 25)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(152, 23)
        Me.cbFiltro.TabIndex = 17
        Me.cbFiltro.Text = "TODAS"
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(12, 85)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(939, 163)
        Me.dgvDocumentos.TabIndex = 17
        '
        'dgvPartidas
        '
        Me.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidas.Location = New System.Drawing.Point(12, 254)
        Me.dgvPartidas.Name = "dgvPartidas"
        Me.dgvPartidas.Size = New System.Drawing.Size(937, 248)
        Me.dgvPartidas.TabIndex = 18
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(731, 551)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(142, 27)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "Nueva Consulta"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(731, 594)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(142, 27)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar Documento"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbMotivo
        '
        Me.tbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMotivo.Location = New System.Drawing.Point(12, 529)
        Me.tbMotivo.MaxLength = 255
        Me.tbMotivo.Multiline = True
        Me.tbMotivo.Name = "tbMotivo"
        Me.tbMotivo.Size = New System.Drawing.Size(647, 100)
        Me.tbMotivo.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 511)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Motivo de la Cancelación. (Sea lo más especifico posible)"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(777, 520)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(51, 18)
        Me.lblCuenta.TabIndex = 24
        Me.lblCuenta.Text = "Label2"
        '
        'frmCancelaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 633)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMotivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.dgvPartidas)
        Me.Controls.Add(Me.dgvDocumentos)
        Me.Controls.Add(Me.gbFiltoFecha)
        Me.Controls.Add(Me.gbTipoDocumento)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelaciones"
        Me.Text = "Cancelación de Documentos"
        Me.gbTipoDocumento.ResumeLayout(False)
        Me.gbFiltoFecha.ResumeLayout(False)
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbTipoDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents gbFiltoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
End Class
