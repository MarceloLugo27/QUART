<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaMermas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaMermas))
        Me.gbFiltoFecha = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.dgvMermas = New System.Windows.Forms.DataGridView()
        Me.lblRazon = New System.Windows.Forms.Label()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.gbFiltoFecha.SuspendLayout()
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltoFecha
        '
        Me.gbFiltoFecha.Controls.Add(Me.btnConsultar)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaFinal)
        Me.gbFiltoFecha.Controls.Add(Me.dtFechaInicial)
        Me.gbFiltoFecha.Controls.Add(Me.cbFiltro)
        Me.gbFiltoFecha.Location = New System.Drawing.Point(242, 12)
        Me.gbFiltoFecha.Name = "gbFiltoFecha"
        Me.gbFiltoFecha.Size = New System.Drawing.Size(553, 67)
        Me.gbFiltoFecha.TabIndex = 6
        Me.gbFiltoFecha.TabStop = False
        Me.gbFiltoFecha.Text = "Seleccione un rango de fechas"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(458, 25)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 28)
        Me.btnConsultar.TabIndex = 20
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(324, 31)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(107, 21)
        Me.dtFechaFinal.TabIndex = 19
        Me.dtFechaFinal.Value = New Date(2015, 9, 1, 0, 0, 0, 0)
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = ""
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(190, 31)
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
        Me.cbFiltro.Location = New System.Drawing.Point(11, 29)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(152, 23)
        Me.cbFiltro.TabIndex = 17
        Me.cbFiltro.Text = "TODAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Estado de las Mermas"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"TODAS", "REPORTADAS", "CON CARGO", "PERDIDA"})
        Me.cbEstado.Location = New System.Drawing.Point(25, 45)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(144, 23)
        Me.cbEstado.TabIndex = 8
        '
        'dgvMermas
        '
        Me.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMermas.Location = New System.Drawing.Point(12, 95)
        Me.dgvMermas.Name = "dgvMermas"
        Me.dgvMermas.Size = New System.Drawing.Size(826, 255)
        Me.dgvMermas.TabIndex = 9
        '
        'lblRazon
        '
        Me.lblRazon.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRazon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRazon.Location = New System.Drawing.Point(12, 362)
        Me.lblRazon.Name = "lblRazon"
        Me.lblRazon.Size = New System.Drawing.Size(248, 135)
        Me.lblRazon.TabIndex = 10
        '
        'lblComentarios
        '
        Me.lblComentarios.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComentarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComentarios.Location = New System.Drawing.Point(279, 362)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(248, 135)
        Me.lblComentarios.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(618, 362)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(146, 52)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(618, 445)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(146, 52)
        Me.btnExportarExcel.TabIndex = 24
        Me.btnExportarExcel.Text = "Exportar Lista de Mermas"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'frmListaMermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 513)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblComentarios)
        Me.Controls.Add(Me.lblRazon)
        Me.Controls.Add(Me.dgvMermas)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbFiltoFecha)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmListaMermas"
        Me.Text = "Listado de Mermas de Inventario"
        Me.gbFiltoFecha.ResumeLayout(False)
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbFiltoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMermas As System.Windows.Forms.DataGridView
    Friend WithEvents lblRazon As System.Windows.Forms.Label
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
End Class
