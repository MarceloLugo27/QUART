<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisarCancelaciones
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
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDocumento = New System.Windows.Forms.ComboBox()
        Me.tbComentarios = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.btnVoBo = New System.Windows.Forms.Button()
        Me.dgvPartidas = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(20, 43)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(586, 224)
        Me.dgvDocumentos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Cancelaciones por Revisar"
        '
        'cbDocumento
        '
        Me.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumento.FormattingEnabled = True
        Me.cbDocumento.Items.AddRange(New Object() {"COMPRAS", "VENTAS"})
        Me.cbDocumento.Location = New System.Drawing.Point(253, 7)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(180, 23)
        Me.cbDocumento.TabIndex = 2
        '
        'tbComentarios
        '
        Me.tbComentarios.Location = New System.Drawing.Point(253, 301)
        Me.tbComentarios.MaxLength = 255
        Me.tbComentarios.Multiline = True
        Me.tbComentarios.Name = "tbComentarios"
        Me.tbComentarios.Size = New System.Drawing.Size(219, 134)
        Me.tbComentarios.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Comentarios de la revisión"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Motivo de la Cancelación"
        '
        'lblMotivo
        '
        Me.lblMotivo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMotivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMotivo.Location = New System.Drawing.Point(20, 303)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(219, 134)
        Me.lblMotivo.TabIndex = 7
        '
        'btnVoBo
        '
        Me.btnVoBo.Location = New System.Drawing.Point(492, 351)
        Me.btnVoBo.Name = "btnVoBo"
        Me.btnVoBo.Size = New System.Drawing.Size(99, 48)
        Me.btnVoBo.TabIndex = 8
        Me.btnVoBo.Text = "Vo. Bo."
        Me.btnVoBo.UseVisualStyleBackColor = True
        '
        'dgvPartidas
        '
        Me.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidas.Location = New System.Drawing.Point(625, 12)
        Me.dgvPartidas.Name = "dgvPartidas"
        Me.dgvPartidas.Size = New System.Drawing.Size(486, 445)
        Me.dgvPartidas.TabIndex = 9
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(463, 7)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(142, 23)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'frmRevisarCancelaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 469)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvPartidas)
        Me.Controls.Add(Me.btnVoBo)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbComentarios)
        Me.Controls.Add(Me.cbDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDocumentos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRevisarCancelaciones"
        Me.Text = "Revision de Cancelaciones"
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents tbComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents btnVoBo As System.Windows.Forms.Button
    Friend WithEvents dgvPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
