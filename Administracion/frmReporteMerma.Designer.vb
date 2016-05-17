<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMerma
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
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.lblUM = New System.Windows.Forms.Label()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.gbProducto = New System.Windows.Forms.GroupBox()
        Me.gbReporte = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRazon = New System.Windows.Forms.TextBox()
        Me.mcFechaEvento = New System.Windows.Forms.MonthCalendar()
        Me.btnReportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbProducto.SuspendLayout()
        Me.gbReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbProducto
        '
        Me.tbProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProducto.Location = New System.Drawing.Point(6, 26)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(73, 21)
        Me.tbProducto.TabIndex = 0
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(102, 24)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(261, 23)
        Me.cbProducto.TabIndex = 1
        '
        'lblUM
        '
        Me.lblUM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUM.Location = New System.Drawing.Point(380, 24)
        Me.lblUM.Name = "lblUM"
        Me.lblUM.Size = New System.Drawing.Size(62, 23)
        Me.lblUM.TabIndex = 2
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(460, 24)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(66, 21)
        Me.tbCantidad.TabIndex = 3
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(573, 24)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(101, 23)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'gbProducto
        '
        Me.gbProducto.Controls.Add(Me.tbProducto)
        Me.gbProducto.Controls.Add(Me.cbProducto)
        Me.gbProducto.Controls.Add(Me.lblUM)
        Me.gbProducto.Controls.Add(Me.tbCantidad)
        Me.gbProducto.Controls.Add(Me.btnContinuar)
        Me.gbProducto.Location = New System.Drawing.Point(19, 20)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(695, 60)
        Me.gbProducto.TabIndex = 5
        Me.gbProducto.TabStop = False
        Me.gbProducto.Text = "Seleccione el Producto y Cantidad a reportar Merma"
        '
        'gbReporte
        '
        Me.gbReporte.Controls.Add(Me.Label1)
        Me.gbReporte.Controls.Add(Me.lblCuenta)
        Me.gbReporte.Controls.Add(Me.Label2)
        Me.gbReporte.Controls.Add(Me.tbRazon)
        Me.gbReporte.Controls.Add(Me.mcFechaEvento)
        Me.gbReporte.Location = New System.Drawing.Point(19, 102)
        Me.gbReporte.Name = "gbReporte"
        Me.gbReporte.Size = New System.Drawing.Size(695, 223)
        Me.gbReporte.TabIndex = 6
        Me.gbReporte.TabStop = False
        Me.gbReporte.Text = "Reporte de Merma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Describa la razón por la que reporta la merma"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(346, 22)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(17, 17)
        Me.lblCuenta.TabIndex = 3
        Me.lblCuenta.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha del evento"
        '
        'tbRazon
        '
        Me.tbRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRazon.Location = New System.Drawing.Point(26, 51)
        Me.tbRazon.MaxLength = 250
        Me.tbRazon.Multiline = True
        Me.tbRazon.Name = "tbRazon"
        Me.tbRazon.Size = New System.Drawing.Size(375, 162)
        Me.tbRazon.TabIndex = 0
        '
        'mcFechaEvento
        '
        Me.mcFechaEvento.Location = New System.Drawing.Point(443, 51)
        Me.mcFechaEvento.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.mcFechaEvento.MaxSelectionCount = 1
        Me.mcFechaEvento.MinDate = New Date(2015, 10, 1, 0, 0, 0, 0)
        Me.mcFechaEvento.Name = "mcFechaEvento"
        Me.mcFechaEvento.TabIndex = 2
        '
        'btnReportar
        '
        Me.btnReportar.Location = New System.Drawing.Point(179, 335)
        Me.btnReportar.Name = "btnReportar"
        Me.btnReportar.Size = New System.Drawing.Size(114, 46)
        Me.btnReportar.TabIndex = 7
        Me.btnReportar.Text = "Reportar Merma"
        Me.btnReportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(440, 335)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 46)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmReporteMerma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 387)
        Me.Controls.Add(Me.gbProducto)
        Me.Controls.Add(Me.gbReporte)
        Me.Controls.Add(Me.btnReportar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteMerma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Merma de Inventario"
        Me.gbProducto.ResumeLayout(False)
        Me.gbProducto.PerformLayout()
        Me.gbReporte.ResumeLayout(False)
        Me.gbReporte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbProducto As System.Windows.Forms.TextBox
    Friend WithEvents cbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblUM As System.Windows.Forms.Label
    Friend WithEvents tbCantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents gbReporte As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents mcFechaEvento As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbRazon As System.Windows.Forms.TextBox
    Friend WithEvents btnReportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
