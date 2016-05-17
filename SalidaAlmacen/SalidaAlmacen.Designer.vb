<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaAlamcen
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
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAfectarInvetario = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLugarEntrega = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPendientes = New System.Windows.Forms.Label()
        Me.tbEntregaMercancía = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbRecibeMercancia = New System.Windows.Forms.TextBox()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione una Orden de Salida pendiente de surtir"
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenes.Location = New System.Drawing.Point(3, 30)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.Size = New System.Drawing.Size(884, 129)
        Me.dgvOrdenes.TabIndex = 1
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(3, 320)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(884, 233)
        Me.dgvProductos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Productos a surtir"
        '
        'btnAfectarInvetario
        '
        Me.btnAfectarInvetario.Location = New System.Drawing.Point(750, 559)
        Me.btnAfectarInvetario.Name = "btnAfectarInvetario"
        Me.btnAfectarInvetario.Size = New System.Drawing.Size(117, 33)
        Me.btnAfectarInvetario.TabIndex = 4
        Me.btnAfectarInvetario.Text = "Afectar Inventarios"
        Me.btnAfectarInvetario.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(602, 559)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 33)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Entregar en :"
        '
        'lblLugarEntrega
        '
        Me.lblLugarEntrega.BackColor = System.Drawing.Color.White
        Me.lblLugarEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLugarEntrega.Location = New System.Drawing.Point(15, 243)
        Me.lblLugarEntrega.Name = "lblLugarEntrega"
        Me.lblLugarEntrega.Size = New System.Drawing.Size(403, 59)
        Me.lblLugarEntrega.TabIndex = 7
        Me.lblLugarEntrega.Text = "lblLugarEntrega"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.BackColor = System.Drawing.Color.White
        Me.lblObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblObservaciones.Location = New System.Drawing.Point(464, 243)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(403, 59)
        Me.lblObservaciones.TabIndex = 9
        Me.lblObservaciones.Text = "lblObservaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Observaciones :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfonos :"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.BackColor = System.Drawing.Color.White
        Me.lblTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefonos.Location = New System.Drawing.Point(464, 179)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(403, 20)
        Me.lblTelefonos.TabIndex = 10
        Me.lblTelefonos.Text = "lblTelefonos"
        '
        'lblContacto
        '
        Me.lblContacto.BackColor = System.Drawing.Color.White
        Me.lblContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContacto.Location = New System.Drawing.Point(15, 179)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(403, 20)
        Me.lblContacto.TabIndex = 12
        Me.lblContacto.Text = "lblContacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Contacto :"
        '
        'lblPendientes
        '
        Me.lblPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendientes.Location = New System.Drawing.Point(513, 7)
        Me.lblPendientes.Name = "lblPendientes"
        Me.lblPendientes.Size = New System.Drawing.Size(374, 20)
        Me.lblPendientes.TabIndex = 13
        Me.lblPendientes.Text = "lblPendientes"
        '
        'tbEntregaMercancía
        '
        Me.tbEntregaMercancía.Location = New System.Drawing.Point(132, 207)
        Me.tbEntregaMercancía.Name = "tbEntregaMercancía"
        Me.tbEntregaMercancía.Size = New System.Drawing.Size(285, 21)
        Me.tbEntregaMercancía.TabIndex = 14
        Me.tbEntregaMercancía.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Enterga Mercancía:"
        Me.Label5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Recibe Mercancía:"
        '
        'tbRecibeMercancia
        '
        Me.tbRecibeMercancia.Location = New System.Drawing.Point(582, 207)
        Me.tbRecibeMercancia.Name = "tbRecibeMercancia"
        Me.tbRecibeMercancia.Size = New System.Drawing.Size(285, 21)
        Me.tbRecibeMercancia.TabIndex = 17
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(454, 559)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(117, 33)
        Me.btnVistaPrevia.TabIndex = 18
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'SalidaAlamcen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 598)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.tbRecibeMercancia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEntregaMercancía)
        Me.Controls.Add(Me.lblPendientes)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLugarEntrega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAfectarInvetario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.dgvOrdenes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalidaAlamcen"
        Me.Text = "Salida de Almacén"
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAfectarInvetario As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLugarEntrega As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPendientes As System.Windows.Forms.Label
    Friend WithEvents tbEntregaMercancía As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbRecibeMercancia As System.Windows.Forms.TextBox
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
End Class
