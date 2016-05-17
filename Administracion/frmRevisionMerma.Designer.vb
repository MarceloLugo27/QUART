<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisionMerma
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMermas = New System.Windows.Forms.DataGridView()
        Me.lblRazon = New System.Windows.Forms.Label()
        Me.tbComentarios = New System.Windows.Forms.TextBox()
        Me.btnAsumirPerdida = New System.Windows.Forms.Button()
        Me.btnReportarCargo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Reportes de Merma pendientes de evaluar"
        '
        'dgvMermas
        '
        Me.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMermas.Location = New System.Drawing.Point(12, 27)
        Me.dgvMermas.Name = "dgvMermas"
        Me.dgvMermas.Size = New System.Drawing.Size(661, 228)
        Me.dgvMermas.TabIndex = 1
        '
        'lblRazon
        '
        Me.lblRazon.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRazon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRazon.Location = New System.Drawing.Point(16, 268)
        Me.lblRazon.Name = "lblRazon"
        Me.lblRazon.Size = New System.Drawing.Size(248, 135)
        Me.lblRazon.TabIndex = 2
        '
        'tbComentarios
        '
        Me.tbComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbComentarios.Location = New System.Drawing.Point(282, 268)
        Me.tbComentarios.MaxLength = 250
        Me.tbComentarios.Multiline = True
        Me.tbComentarios.Name = "tbComentarios"
        Me.tbComentarios.Size = New System.Drawing.Size(248, 135)
        Me.tbComentarios.TabIndex = 3
        '
        'btnAsumirPerdida
        '
        Me.btnAsumirPerdida.Location = New System.Drawing.Point(537, 268)
        Me.btnAsumirPerdida.Name = "btnAsumirPerdida"
        Me.btnAsumirPerdida.Size = New System.Drawing.Size(136, 35)
        Me.btnAsumirPerdida.TabIndex = 4
        Me.btnAsumirPerdida.Text = "Asumir Perdida"
        Me.btnAsumirPerdida.UseVisualStyleBackColor = True
        '
        'btnReportarCargo
        '
        Me.btnReportarCargo.Location = New System.Drawing.Point(537, 318)
        Me.btnReportarCargo.Name = "btnReportarCargo"
        Me.btnReportarCargo.Size = New System.Drawing.Size(136, 35)
        Me.btnReportarCargo.TabIndex = 4
        Me.btnReportarCargo.Text = "Reportar Cargo"
        Me.btnReportarCargo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(537, 368)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(136, 35)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmRevisionMerma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 415)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnReportarCargo)
        Me.Controls.Add(Me.btnAsumirPerdida)
        Me.Controls.Add(Me.tbComentarios)
        Me.Controls.Add(Me.lblRazon)
        Me.Controls.Add(Me.dgvMermas)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRevisionMerma"
        Me.Text = "Revision de Mermas Registradas"
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvMermas As System.Windows.Forms.DataGridView
    Friend WithEvents lblRazon As System.Windows.Forms.Label
    Friend WithEvents tbComentarios As System.Windows.Forms.TextBox
    Friend WithEvents btnAsumirPerdida As System.Windows.Forms.Button
    Friend WithEvents btnReportarCargo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
