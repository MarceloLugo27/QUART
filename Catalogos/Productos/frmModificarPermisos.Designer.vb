<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPermisos
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
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.dgvPermisos = New System.Windows.Forms.DataGridView()
        Me.btnObtenerListaPermisos = New System.Windows.Forms.Button()
        Me.btnGrabarPermisos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el usuario"
        '
        'cbUsuarios
        '
        Me.cbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(16, 45)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(216, 23)
        Me.cbUsuarios.TabIndex = 1
        '
        'dgvPermisos
        '
        Me.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPermisos.Location = New System.Drawing.Point(16, 83)
        Me.dgvPermisos.Name = "dgvPermisos"
        Me.dgvPermisos.Size = New System.Drawing.Size(539, 384)
        Me.dgvPermisos.TabIndex = 2
        '
        'btnObtenerListaPermisos
        '
        Me.btnObtenerListaPermisos.Location = New System.Drawing.Point(339, 45)
        Me.btnObtenerListaPermisos.Name = "btnObtenerListaPermisos"
        Me.btnObtenerListaPermisos.Size = New System.Drawing.Size(216, 23)
        Me.btnObtenerListaPermisos.TabIndex = 3
        Me.btnObtenerListaPermisos.Text = "Listar Permisos"
        Me.btnObtenerListaPermisos.UseVisualStyleBackColor = True
        '
        'btnGrabarPermisos
        '
        Me.btnGrabarPermisos.Location = New System.Drawing.Point(16, 486)
        Me.btnGrabarPermisos.Name = "btnGrabarPermisos"
        Me.btnGrabarPermisos.Size = New System.Drawing.Size(216, 23)
        Me.btnGrabarPermisos.TabIndex = 4
        Me.btnGrabarPermisos.Text = "Grabar Permisos"
        Me.btnGrabarPermisos.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(339, 486)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(216, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmModificarPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 530)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabarPermisos)
        Me.Controls.Add(Me.btnObtenerListaPermisos)
        Me.Controls.Add(Me.dgvPermisos)
        Me.Controls.Add(Me.cbUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarPermisos"
        Me.Text = "Modificar Permisos"
        CType(Me.dgvPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPermisos As System.Windows.Forms.DataGridView
    Friend WithEvents btnObtenerListaPermisos As System.Windows.Forms.Button
    Friend WithEvents btnGrabarPermisos As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
