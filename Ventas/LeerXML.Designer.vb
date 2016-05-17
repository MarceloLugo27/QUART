<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeerXML
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.lblFechaHora = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblArchivoXML = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.ofdXML = New System.Windows.Forms.OpenFileDialog()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnOrdenSalida = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGrabarOrdenSalida = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbDomicilioEntrega = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.btnVerificarProductos = New System.Windows.Forms.Button()
        Me.gbConfirmar = New System.Windows.Forms.GroupBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbConfirmar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(948, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(77, 49)
        Me.ListBox1.TabIndex = 14
        Me.ListBox1.Visible = False
        '
        'lblRFC
        '
        Me.lblRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRFC.Location = New System.Drawing.Point(380, 125)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(217, 20)
        Me.lblRFC.TabIndex = 13
        '
        'lblCliente
        '
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCliente.Location = New System.Drawing.Point(13, 125)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(345, 20)
        Me.lblCliente.TabIndex = 12
        '
        'lblFactura
        '
        Me.lblFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFactura.Location = New System.Drawing.Point(297, 88)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(217, 20)
        Me.lblFactura.TabIndex = 11
        '
        'lblFechaHora
        '
        Me.lblFechaHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaHora.Location = New System.Drawing.Point(13, 88)
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(217, 20)
        Me.lblFechaHora.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(940, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(86, 50)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'lblArchivoXML
        '
        Me.lblArchivoXML.Location = New System.Drawing.Point(160, 18)
        Me.lblArchivoXML.Name = "lblArchivoXML"
        Me.lblArchivoXML.Size = New System.Drawing.Size(321, 21)
        Me.lblArchivoXML.TabIndex = 8
        Me.lblArchivoXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(14, 5)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(126, 47)
        Me.btnSeleccionar.TabIndex = 7
        Me.btnSeleccionar.Text = "Seleccione Archivo XML"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'ofdXML
        '
        Me.ofdXML.FileName = "OpenFileDialog1"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(13, 154)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(882, 321)
        Me.dgvProductos.TabIndex = 15
        '
        'btnOrdenSalida
        '
        Me.btnOrdenSalida.Location = New System.Drawing.Point(549, 481)
        Me.btnOrdenSalida.Name = "btnOrdenSalida"
        Me.btnOrdenSalida.Size = New System.Drawing.Size(211, 32)
        Me.btnOrdenSalida.TabIndex = 16
        Me.btnOrdenSalida.Text = "Preparar Orden de Salida"
        Me.btnOrdenSalida.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(777, 519)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Afectar Inventario"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'btnGrabarOrdenSalida
        '
        Me.btnGrabarOrdenSalida.Location = New System.Drawing.Point(642, 18)
        Me.btnGrabarOrdenSalida.Name = "btnGrabarOrdenSalida"
        Me.btnGrabarOrdenSalida.Size = New System.Drawing.Size(94, 63)
        Me.btnGrabarOrdenSalida.TabIndex = 18
        Me.btnGrabarOrdenSalida.Text = "Generar Orden de Salida"
        Me.btnGrabarOrdenSalida.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(642, 93)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 40)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(618, 88)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(108, 20)
        Me.lblSubtotal.TabIndex = 19
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIVA
        '
        Me.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIVA.Location = New System.Drawing.Point(771, 88)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(108, 20)
        Me.lblIVA.TabIndex = 20
        Me.lblIVA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(655, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(156, 20)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbDomicilioEntrega
        '
        Me.tbDomicilioEntrega.Location = New System.Drawing.Point(4, 18)
        Me.tbDomicilioEntrega.MaxLength = 250
        Me.tbDomicilioEntrega.Multiline = True
        Me.tbDomicilioEntrega.Name = "tbDomicilioEntrega"
        Me.tbDomicilioEntrega.Size = New System.Drawing.Size(583, 49)
        Me.tbDomicilioEntrega.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Domicilio de Entrega"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Observaciones de Entrega"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Location = New System.Drawing.Point(4, 89)
        Me.tbObservaciones.MaxLength = 250
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(583, 49)
        Me.tbObservaciones.TabIndex = 25
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(85, 55)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(730, 22)
        Me.lblEmpresa.TabIndex = 26
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerificarProductos
        '
        Me.btnVerificarProductos.Location = New System.Drawing.Point(141, 481)
        Me.btnVerificarProductos.Name = "btnVerificarProductos"
        Me.btnVerificarProductos.Size = New System.Drawing.Size(211, 32)
        Me.btnVerificarProductos.TabIndex = 16
        Me.btnVerificarProductos.Text = "Verificar Consistencia Productos"
        Me.btnVerificarProductos.UseVisualStyleBackColor = True
        '
        'gbConfirmar
        '
        Me.gbConfirmar.Controls.Add(Me.tbObservaciones)
        Me.gbConfirmar.Controls.Add(Me.Label2)
        Me.gbConfirmar.Controls.Add(Me.Label1)
        Me.gbConfirmar.Controls.Add(Me.tbDomicilioEntrega)
        Me.gbConfirmar.Controls.Add(Me.btnCancelar)
        Me.gbConfirmar.Controls.Add(Me.btnGrabarOrdenSalida)
        Me.gbConfirmar.Location = New System.Drawing.Point(13, 519)
        Me.gbConfirmar.Name = "gbConfirmar"
        Me.gbConfirmar.Size = New System.Drawing.Size(747, 142)
        Me.gbConfirmar.TabIndex = 27
        Me.gbConfirmar.TabStop = False
        '
        'LeerXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 661)
        Me.Controls.Add(Me.gbConfirmar)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnVerificarProductos)
        Me.Controls.Add(Me.btnOrdenSalida)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblRFC)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.lblFechaHora)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblArchivoXML)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LeerXML"
        Me.Text = "Importar Archivo XML al Sistema"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbConfirmar.ResumeLayout(False)
        Me.gbConfirmar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents lblFechaHora As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblArchivoXML As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents ofdXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents btnOrdenSalida As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnGrabarOrdenSalida As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents tbDomicilioEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents btnVerificarProductos As System.Windows.Forms.Button
    Friend WithEvents gbConfirmar As System.Windows.Forms.GroupBox
End Class
