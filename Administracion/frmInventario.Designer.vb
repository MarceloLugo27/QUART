<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(14, 50)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(1062, 513)
        Me.dgvInventario.TabIndex = 0
        Me.dgvInventario.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(693, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(222, 27)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Obtener Inventario"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(80, 569)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(222, 38)
        Me.btnExportarExcel.TabIndex = 3
        Me.btnExportarExcel.Text = "Exportar Listado de Inventario"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Introduzca el nombre ( o parte de él ) del Producto"
        '
        'tbProducto
        '
        Me.tbProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProducto.Location = New System.Drawing.Point(328, 17)
        Me.tbProducto.MaxLength = 30
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(282, 21)
        Me.tbProducto.TabIndex = 1
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 619)
        Me.Controls.Add(Me.tbProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvInventario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInventario"
        Me.Text = "Inventario de Almacén"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbProducto As System.Windows.Forms.TextBox
End Class
