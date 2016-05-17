<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.dtFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIniciarCompraDatagrid = New System.Windows.Forms.Button()
        Me.gbProductos = New System.Windows.Forms.GroupBox()
        Me.tbProducto = New System.Windows.Forms.TextBox()
        Me.btnProductoNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.mtbPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCant = New System.Windows.Forms.MaskedTextBox()
        Me.cbUM = New System.Windows.Forms.ComboBox()
        Me.lblNumPartida = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.rbRemision = New System.Windows.Forms.RadioButton()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.tbReferenciaProveedor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGrabarCompra = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.tbRecibioMercancia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.btnAaron = New System.Windows.Forms.Button()
        Me.btnQuart = New System.Windows.Forms.Button()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.gbModificarPartida = New System.Windows.Forms.GroupBox()
        Me.btnModificarPartida = New System.Windows.Forms.Button()
        Me.mtbPrecioUnitarioM = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCantidadM = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUMedidaM = New System.Windows.Forms.Label()
        Me.lblDescProcuctoM = New System.Windows.Forms.Label()
        Me.gbProductoNuevo = New System.Windows.Forms.GroupBox()
        Me.gbDatosProducto = New System.Windows.Forms.GroupBox()
        Me.chkAplicaIVA = New System.Windows.Forms.CheckBox()
        Me.btnCancelaProductoNuevo = New System.Windows.Forms.Button()
        Me.btnAñadirProducto = New System.Windows.Forms.Button()
        Me.Precio4 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio3 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio2 = New System.Windows.Forms.MaskedTextBox()
        Me.Precio1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkbInventariable = New System.Windows.Forms.CheckBox()
        Me.cbTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.tbNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnVerificaID = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.gbProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProveedor.SuspendLayout()
        Me.gbTodo.SuspendLayout()
        Me.gbEmpresa.SuspendLayout()
        Me.gbModificarPartida.SuspendLayout()
        Me.gbProductoNuevo.SuspendLayout()
        Me.gbDatosProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor"
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(10, 52)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(346, 23)
        Me.cbProveedor.TabIndex = 101
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(157, 42)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(332, 23)
        Me.cbProducto.TabIndex = 201
        '
        'dtFechaCompra
        '
        Me.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCompra.Location = New System.Drawing.Point(666, 52)
        Me.dtFechaCompra.Name = "dtFechaCompra"
        Me.dtFechaCompra.Size = New System.Drawing.Size(113, 21)
        Me.dtFechaCompra.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de Compra"
        '
        'btnIniciarCompraDatagrid
        '
        Me.btnIniciarCompraDatagrid.Location = New System.Drawing.Point(802, 26)
        Me.btnIniciarCompraDatagrid.Name = "btnIniciarCompraDatagrid"
        Me.btnIniciarCompraDatagrid.Size = New System.Drawing.Size(71, 47)
        Me.btnIniciarCompraDatagrid.TabIndex = 106
        Me.btnIniciarCompraDatagrid.Text = "Iniciar Compra"
        Me.btnIniciarCompraDatagrid.UseVisualStyleBackColor = True
        '
        'gbProductos
        '
        Me.gbProductos.Controls.Add(Me.tbProducto)
        Me.gbProductos.Controls.Add(Me.btnProductoNuevo)
        Me.gbProductos.Controls.Add(Me.btnAgregar)
        Me.gbProductos.Controls.Add(Me.mtbPrecio)
        Me.gbProductos.Controls.Add(Me.mtbCant)
        Me.gbProductos.Controls.Add(Me.cbUM)
        Me.gbProductos.Controls.Add(Me.lblNumPartida)
        Me.gbProductos.Controls.Add(Me.Label8)
        Me.gbProductos.Controls.Add(Me.Label9)
        Me.gbProductos.Controls.Add(Me.Label10)
        Me.gbProductos.Controls.Add(Me.Label11)
        Me.gbProductos.Controls.Add(Me.cbProducto)
        Me.gbProductos.Controls.Add(Me.Label12)
        Me.gbProductos.Location = New System.Drawing.Point(6, 106)
        Me.gbProductos.Name = "gbProductos"
        Me.gbProductos.Size = New System.Drawing.Size(893, 75)
        Me.gbProductos.TabIndex = 3
        Me.gbProductos.TabStop = False
        Me.gbProductos.Text = "Seleccione productos"
        '
        'tbProducto
        '
        Me.tbProducto.Location = New System.Drawing.Point(60, 42)
        Me.tbProducto.MaxLength = 14
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(91, 21)
        Me.tbProducto.TabIndex = 200
        '
        'btnProductoNuevo
        '
        Me.btnProductoNuevo.Location = New System.Drawing.Point(813, 18)
        Me.btnProductoNuevo.Name = "btnProductoNuevo"
        Me.btnProductoNuevo.Size = New System.Drawing.Size(67, 47)
        Me.btnProductoNuevo.TabIndex = 206
        Me.btnProductoNuevo.Text = "Producto Nuevo"
        Me.btnProductoNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(740, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(67, 47)
        Me.btnAgregar.TabIndex = 205
        Me.btnAgregar.Text = "Agregar Partida"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'mtbPrecio
        '
        Me.mtbPrecio.Location = New System.Drawing.Point(657, 42)
        Me.mtbPrecio.Name = "mtbPrecio"
        Me.mtbPrecio.Size = New System.Drawing.Size(69, 21)
        Me.mtbPrecio.TabIndex = 204
        '
        'mtbCant
        '
        Me.mtbCant.Location = New System.Drawing.Point(591, 42)
        Me.mtbCant.Name = "mtbCant"
        Me.mtbCant.Size = New System.Drawing.Size(60, 21)
        Me.mtbCant.TabIndex = 203
        '
        'cbUM
        '
        Me.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Location = New System.Drawing.Point(498, 42)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(79, 23)
        Me.cbUM.TabIndex = 202
        '
        'lblNumPartida
        '
        Me.lblNumPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumPartida.Location = New System.Drawing.Point(6, 44)
        Me.lblNumPartida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumPartida.Name = "lblNumPartida"
        Me.lblNumPartida.Size = New System.Drawing.Size(48, 18)
        Me.lblNumPartida.TabIndex = 17
        Me.lblNumPartida.Text = "Partida"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(657, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "P. Unitario"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(6, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Partida"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(60, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(430, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Producto"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(591, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(496, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "U. M."
        '
        'dgvProductos
        '
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(6, 187)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(893, 277)
        Me.dgvProductos.TabIndex = 206
        Me.dgvProductos.TabStop = False
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.rbFactura)
        Me.gbProveedor.Controls.Add(Me.rbRemision)
        Me.gbProveedor.Controls.Add(Me.tbProveedor)
        Me.gbProveedor.Controls.Add(Me.tbReferenciaProveedor)
        Me.gbProveedor.Controls.Add(Me.Label13)
        Me.gbProveedor.Controls.Add(Me.btnIniciarCompraDatagrid)
        Me.gbProveedor.Controls.Add(Me.Label5)
        Me.gbProveedor.Controls.Add(Me.dtFechaCompra)
        Me.gbProveedor.Controls.Add(Me.cbProveedor)
        Me.gbProveedor.Controls.Add(Me.Label1)
        Me.gbProveedor.Location = New System.Drawing.Point(6, 13)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(893, 87)
        Me.gbProveedor.TabIndex = 2
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Seleccione Proveedor"
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Location = New System.Drawing.Point(379, 55)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(66, 19)
        Me.rbFactura.TabIndex = 103
        Me.rbFactura.TabStop = True
        Me.rbFactura.Text = "Factura"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'rbRemision
        '
        Me.rbRemision.AutoSize = True
        Me.rbRemision.Location = New System.Drawing.Point(379, 20)
        Me.rbRemision.Name = "rbRemision"
        Me.rbRemision.Size = New System.Drawing.Size(81, 19)
        Me.rbRemision.TabIndex = 102
        Me.rbRemision.TabStop = True
        Me.rbRemision.Text = "Remisión "
        Me.rbRemision.UseVisualStyleBackColor = True
        '
        'tbProveedor
        '
        Me.tbProveedor.Location = New System.Drawing.Point(96, 26)
        Me.tbProveedor.MaxLength = 7
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(146, 21)
        Me.tbProveedor.TabIndex = 100
        '
        'tbReferenciaProveedor
        '
        Me.tbReferenciaProveedor.Location = New System.Drawing.Point(457, 54)
        Me.tbReferenciaProveedor.MaxLength = 30
        Me.tbReferenciaProveedor.Name = "tbReferenciaProveedor"
        Me.tbReferenciaProveedor.Size = New System.Drawing.Size(184, 21)
        Me.tbReferenciaProveedor.TabIndex = 104
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(476, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Referencia del Proveedor"
        '
        'btnGrabarCompra
        '
        Me.btnGrabarCompra.Location = New System.Drawing.Point(740, 485)
        Me.btnGrabarCompra.Name = "btnGrabarCompra"
        Me.btnGrabarCompra.Size = New System.Drawing.Size(74, 41)
        Me.btnGrabarCompra.TabIndex = 209
        Me.btnGrabarCompra.Text = "Grabar Compra"
        Me.btnGrabarCompra.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(828, 485)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 41)
        Me.btnCancelar.TabIndex = 210
        Me.btnCancelar.Text = "Cancelar Compra"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.btnVistaPrevia)
        Me.gbTodo.Controls.Add(Me.tbRecibioMercancia)
        Me.gbTodo.Controls.Add(Me.Label3)
        Me.gbTodo.Controls.Add(Me.tbObservaciones)
        Me.gbTodo.Controls.Add(Me.Label2)
        Me.gbTodo.Controls.Add(Me.btnCancelar)
        Me.gbTodo.Controls.Add(Me.btnGrabarCompra)
        Me.gbTodo.Controls.Add(Me.gbProveedor)
        Me.gbTodo.Controls.Add(Me.dgvProductos)
        Me.gbTodo.Controls.Add(Me.gbProductos)
        Me.gbTodo.Location = New System.Drawing.Point(7, 77)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(908, 542)
        Me.gbTodo.TabIndex = 1
        Me.gbTodo.TabStop = False
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(652, 485)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(74, 41)
        Me.btnVistaPrevia.TabIndex = 208
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'tbRecibioMercancia
        '
        Me.tbRecibioMercancia.Location = New System.Drawing.Point(467, 485)
        Me.tbRecibioMercancia.MaxLength = 50
        Me.tbRecibioMercancia.Multiline = True
        Me.tbRecibioMercancia.Name = "tbRecibioMercancia"
        Me.tbRecibioMercancia.Size = New System.Drawing.Size(179, 50)
        Me.tbRecibioMercancia.TabIndex = 207
        Me.tbRecibioMercancia.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 467)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Recibió Mercancía"
        Me.Label3.Visible = False
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Location = New System.Drawing.Point(12, 485)
        Me.tbObservaciones.MaxLength = 500
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(442, 51)
        Me.tbObservaciones.TabIndex = 207
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Observaciones"
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Controls.Add(Me.btnAaron)
        Me.gbEmpresa.Controls.Add(Me.btnQuart)
        Me.gbEmpresa.Location = New System.Drawing.Point(7, 12)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(908, 60)
        Me.gbEmpresa.TabIndex = 0
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "  Seleccione la empresa que realizo la compra"
        '
        'btnAaron
        '
        Me.btnAaron.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAaron.Location = New System.Drawing.Point(512, 21)
        Me.btnAaron.Name = "btnAaron"
        Me.btnAaron.Size = New System.Drawing.Size(315, 33)
        Me.btnAaron.TabIndex = 6
        Me.btnAaron.Text = "AARON URDIALES GONZALEZ"
        Me.btnAaron.UseVisualStyleBackColor = True
        '
        'btnQuart
        '
        Me.btnQuart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuart.Location = New System.Drawing.Point(81, 21)
        Me.btnQuart.Name = "btnQuart"
        Me.btnQuart.Size = New System.Drawing.Size(315, 33)
        Me.btnQuart.TabIndex = 5
        Me.btnQuart.Text = "QUART INDUSTRIAS, S.A. DE C.V."
        Me.btnQuart.UseVisualStyleBackColor = True
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(46, 16)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(840, 40)
        Me.lblEmpresa.TabIndex = 18
        Me.lblEmpresa.Text = "Label2"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbModificarPartida
        '
        Me.gbModificarPartida.Controls.Add(Me.btnModificarPartida)
        Me.gbModificarPartida.Controls.Add(Me.mtbPrecioUnitarioM)
        Me.gbModificarPartida.Controls.Add(Me.mtbCantidadM)
        Me.gbModificarPartida.Controls.Add(Me.Label23)
        Me.gbModificarPartida.Controls.Add(Me.Label22)
        Me.gbModificarPartida.Controls.Add(Me.lblUMedidaM)
        Me.gbModificarPartida.Controls.Add(Me.lblDescProcuctoM)
        Me.gbModificarPartida.Location = New System.Drawing.Point(921, 400)
        Me.gbModificarPartida.Name = "gbModificarPartida"
        Me.gbModificarPartida.Size = New System.Drawing.Size(342, 214)
        Me.gbModificarPartida.TabIndex = 4
        Me.gbModificarPartida.TabStop = False
        Me.gbModificarPartida.Text = "Modificación de Partida"
        '
        'btnModificarPartida
        '
        Me.btnModificarPartida.Location = New System.Drawing.Point(103, 167)
        Me.btnModificarPartida.Name = "btnModificarPartida"
        Me.btnModificarPartida.Size = New System.Drawing.Size(137, 41)
        Me.btnModificarPartida.TabIndex = 402
        Me.btnModificarPartida.Text = "Modificar Partida"
        Me.btnModificarPartida.UseVisualStyleBackColor = True
        '
        'mtbPrecioUnitarioM
        '
        Me.mtbPrecioUnitarioM.Location = New System.Drawing.Point(202, 131)
        Me.mtbPrecioUnitarioM.Name = "mtbPrecioUnitarioM"
        Me.mtbPrecioUnitarioM.Size = New System.Drawing.Size(81, 21)
        Me.mtbPrecioUnitarioM.TabIndex = 401
        '
        'mtbCantidadM
        '
        Me.mtbCantidadM.Location = New System.Drawing.Point(202, 106)
        Me.mtbCantidadM.Name = "mtbCantidadM"
        Me.mtbCantidadM.Size = New System.Drawing.Size(81, 21)
        Me.mtbCantidadM.TabIndex = 400
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(59, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 15)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Precio Unitario :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(59, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Cantidad :"
        '
        'lblUMedidaM
        '
        Me.lblUMedidaM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUMedidaM.Location = New System.Drawing.Point(12, 79)
        Me.lblUMedidaM.Name = "lblUMedidaM"
        Me.lblUMedidaM.Size = New System.Drawing.Size(115, 19)
        Me.lblUMedidaM.TabIndex = 1
        '
        'lblDescProcuctoM
        '
        Me.lblDescProcuctoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescProcuctoM.Location = New System.Drawing.Point(12, 21)
        Me.lblDescProcuctoM.Name = "lblDescProcuctoM"
        Me.lblDescProcuctoM.Size = New System.Drawing.Size(321, 49)
        Me.lblDescProcuctoM.TabIndex = 0
        '
        'gbProductoNuevo
        '
        Me.gbProductoNuevo.Controls.Add(Me.gbDatosProducto)
        Me.gbProductoNuevo.Controls.Add(Me.btnVerificaID)
        Me.gbProductoNuevo.Controls.Add(Me.Label4)
        Me.gbProductoNuevo.Controls.Add(Me.tbID)
        Me.gbProductoNuevo.Location = New System.Drawing.Point(925, 17)
        Me.gbProductoNuevo.Name = "gbProductoNuevo"
        Me.gbProductoNuevo.Size = New System.Drawing.Size(337, 383)
        Me.gbProductoNuevo.TabIndex = 19
        Me.gbProductoNuevo.TabStop = False
        Me.gbProductoNuevo.Text = "Producto Nuevo"
        '
        'gbDatosProducto
        '
        Me.gbDatosProducto.Controls.Add(Me.chkAplicaIVA)
        Me.gbDatosProducto.Controls.Add(Me.btnCancelaProductoNuevo)
        Me.gbDatosProducto.Controls.Add(Me.btnAñadirProducto)
        Me.gbDatosProducto.Controls.Add(Me.Precio4)
        Me.gbDatosProducto.Controls.Add(Me.Precio3)
        Me.gbDatosProducto.Controls.Add(Me.Precio2)
        Me.gbDatosProducto.Controls.Add(Me.Precio1)
        Me.gbDatosProducto.Controls.Add(Me.Label16)
        Me.gbDatosProducto.Controls.Add(Me.Label17)
        Me.gbDatosProducto.Controls.Add(Me.Label18)
        Me.gbDatosProducto.Controls.Add(Me.Label19)
        Me.gbDatosProducto.Controls.Add(Me.chkbInventariable)
        Me.gbDatosProducto.Controls.Add(Me.cbTipoUnidad)
        Me.gbDatosProducto.Controls.Add(Me.Label15)
        Me.gbDatosProducto.Controls.Add(Me.Label14)
        Me.gbDatosProducto.Controls.Add(Me.tbModelo)
        Me.gbDatosProducto.Controls.Add(Me.Label7)
        Me.gbDatosProducto.Controls.Add(Me.tbMarca)
        Me.gbDatosProducto.Controls.Add(Me.tbNombreProducto)
        Me.gbDatosProducto.Controls.Add(Me.Label6)
        Me.gbDatosProducto.Location = New System.Drawing.Point(8, 48)
        Me.gbDatosProducto.Name = "gbDatosProducto"
        Me.gbDatosProducto.Size = New System.Drawing.Size(320, 329)
        Me.gbDatosProducto.TabIndex = 3
        Me.gbDatosProducto.TabStop = False
        '
        'chkAplicaIVA
        '
        Me.chkAplicaIVA.AutoSize = True
        Me.chkAplicaIVA.Location = New System.Drawing.Point(23, 248)
        Me.chkAplicaIVA.Name = "chkAplicaIVA"
        Me.chkAplicaIVA.Size = New System.Drawing.Size(79, 19)
        Me.chkAplicaIVA.TabIndex = 35
        Me.chkAplicaIVA.Text = "Aplica IVA"
        Me.chkAplicaIVA.UseVisualStyleBackColor = True
        '
        'btnCancelaProductoNuevo
        '
        Me.btnCancelaProductoNuevo.Location = New System.Drawing.Point(181, 283)
        Me.btnCancelaProductoNuevo.Name = "btnCancelaProductoNuevo"
        Me.btnCancelaProductoNuevo.Size = New System.Drawing.Size(106, 29)
        Me.btnCancelaProductoNuevo.TabIndex = 310
        Me.btnCancelaProductoNuevo.Text = "Cancelar"
        Me.btnCancelaProductoNuevo.UseVisualStyleBackColor = True
        '
        'btnAñadirProducto
        '
        Me.btnAñadirProducto.Location = New System.Drawing.Point(34, 283)
        Me.btnAñadirProducto.Name = "btnAñadirProducto"
        Me.btnAñadirProducto.Size = New System.Drawing.Size(106, 29)
        Me.btnAñadirProducto.TabIndex = 309
        Me.btnAñadirProducto.Text = "Añadir Producto"
        Me.btnAñadirProducto.UseVisualStyleBackColor = True
        '
        'Precio4
        '
        Me.Precio4.Location = New System.Drawing.Point(237, 232)
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Size = New System.Drawing.Size(69, 21)
        Me.Precio4.TabIndex = 308
        '
        'Precio3
        '
        Me.Precio3.Location = New System.Drawing.Point(237, 202)
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Size = New System.Drawing.Size(69, 21)
        Me.Precio3.TabIndex = 307
        '
        'Precio2
        '
        Me.Precio2.Location = New System.Drawing.Point(237, 172)
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Size = New System.Drawing.Size(69, 21)
        Me.Precio2.TabIndex = 306
        '
        'Precio1
        '
        Me.Precio1.BackColor = System.Drawing.SystemColors.Window
        Me.Precio1.Location = New System.Drawing.Point(237, 142)
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Size = New System.Drawing.Size(69, 21)
        Me.Precio1.TabIndex = 305
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(166, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Precio 4"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(166, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Precio 3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(166, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Precio 2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(166, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Precio 1"
        '
        'chkbInventariable
        '
        Me.chkbInventariable.AutoSize = True
        Me.chkbInventariable.Location = New System.Drawing.Point(24, 223)
        Me.chkbInventariable.Name = "chkbInventariable"
        Me.chkbInventariable.Size = New System.Drawing.Size(96, 19)
        Me.chkbInventariable.TabIndex = 24
        Me.chkbInventariable.Text = "Inventariable"
        Me.chkbInventariable.UseVisualStyleBackColor = True
        '
        'cbTipoUnidad
        '
        Me.cbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoUnidad.FormattingEnabled = True
        Me.cbTipoUnidad.Location = New System.Drawing.Point(11, 171)
        Me.cbTipoUnidad.Name = "cbTipoUnidad"
        Me.cbTipoUnidad.Size = New System.Drawing.Size(117, 23)
        Me.cbTipoUnidad.TabIndex = 304
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 15)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Unidad de medida:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Modelo:"
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(68, 94)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(145, 21)
        Me.tbModelo.TabIndex = 303
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Marca:"
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(68, 64)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(145, 21)
        Me.tbMarca.TabIndex = 303
        '
        'tbNombreProducto
        '
        Me.tbNombreProducto.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombreProducto.Location = New System.Drawing.Point(6, 35)
        Me.tbNombreProducto.Name = "tbNombreProducto"
        Me.tbNombreProducto.Size = New System.Drawing.Size(308, 21)
        Me.tbNombreProducto.TabIndex = 302
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nombre Producto:"
        '
        'btnVerificaID
        '
        Me.btnVerificaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificaID.Location = New System.Drawing.Point(213, 19)
        Me.btnVerificaID.Name = "btnVerificaID"
        Me.btnVerificaID.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificaID.TabIndex = 301
        Me.btnVerificaID.Text = "> >"
        Me.btnVerificaID.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Id del Producto"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(116, 22)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(79, 21)
        Me.tbID.TabIndex = 300
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 623)
        Me.Controls.Add(Me.gbProductoNuevo)
        Me.Controls.Add(Me.gbModificarPartida)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.gbTodo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Compra"
        Me.gbProductos.ResumeLayout(False)
        Me.gbProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.gbTodo.ResumeLayout(False)
        Me.gbTodo.PerformLayout()
        Me.gbEmpresa.ResumeLayout(False)
        Me.gbModificarPartida.ResumeLayout(False)
        Me.gbModificarPartida.PerformLayout()
        Me.gbProductoNuevo.ResumeLayout(False)
        Me.gbProductoNuevo.PerformLayout()
        Me.gbDatosProducto.ResumeLayout(False)
        Me.gbDatosProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnIniciarCompraDatagrid As System.Windows.Forms.Button
    Friend WithEvents gbProductos As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents mtbPrecio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCant As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbUM As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumPartida As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents btnGrabarCompra As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnProductoNuevo As System.Windows.Forms.Button
    Friend WithEvents tbReferenciaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbTodo As System.Windows.Forms.GroupBox
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents btnAaron As System.Windows.Forms.Button
    Friend WithEvents btnQuart As System.Windows.Forms.Button
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents tbProducto As System.Windows.Forms.TextBox
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents gbModificarPartida As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarPartida As System.Windows.Forms.Button
    Friend WithEvents mtbPrecioUnitarioM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCantidadM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblUMedidaM As System.Windows.Forms.Label
    Friend WithEvents lblDescProcuctoM As System.Windows.Forms.Label
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbRemision As System.Windows.Forms.RadioButton
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbRecibioMercancia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents gbProductoNuevo As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatosProducto As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerificaID As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbTipoUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents chkbInventariable As System.Windows.Forms.CheckBox
    Friend WithEvents Precio4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Precio1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnAñadirProducto As System.Windows.Forms.Button
    Friend WithEvents btnCancelaProductoNuevo As System.Windows.Forms.Button
    Friend WithEvents chkAplicaIVA As CheckBox
End Class
