<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaMostrador
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
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.dtFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIniciarCompraDatagrid = New System.Windows.Forms.Button()
        Me.gbProductos = New System.Windows.Forms.GroupBox()
        Me.tbProducto = New System.Windows.Forms.TextBox()
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
        Me.btnPrecotizado = New System.Windows.Forms.Button()
        Me.chkIVA = New System.Windows.Forms.CheckBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.tbReferenciaProveedor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.btnGenerarSalida = New System.Windows.Forms.Button()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.btnAaron = New System.Windows.Forms.Button()
        Me.btnQuart = New System.Windows.Forms.Button()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDomicilioEntrega = New System.Windows.Forms.TextBox()
        Me.btnCancelarTodo = New System.Windows.Forms.Button()
        Me.btnGrabarOrdenSalida = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRecibioMercancia = New System.Windows.Forms.TextBox()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.tcApoyos = New System.Windows.Forms.TabControl()
        Me.tpModificarPartida = New System.Windows.Forms.TabPage()
        Me.btnModificarPartida = New System.Windows.Forms.Button()
        Me.mtbPrecioUnitarioM = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCantidadM = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUMedidaM = New System.Windows.Forms.Label()
        Me.lblDescProcuctoM = New System.Windows.Forms.Label()
        Me.tpRepetirCotizacion = New System.Windows.Forms.TabPage()
        Me.btnSeleccionarCotizacionFuente = New System.Windows.Forms.Button()
        Me.dgvPartidasAnteriores = New System.Windows.Forms.DataGridView()
        Me.dgvCotizacionesAnteriores = New System.Windows.Forms.DataGridView()
        Me.tbClienteCotizacionAnterior = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.gbProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProveedor.SuspendLayout()
        Me.gbTodo.SuspendLayout()
        Me.gbEmpresa.SuspendLayout()
        Me.tcApoyos.SuspendLayout()
        Me.tpModificarPartida.SuspendLayout()
        Me.tpRepetirCotizacion.SuspendLayout()
        CType(Me.dgvPartidasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCotizacionesAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(10, 42)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(227, 23)
        Me.cbCliente.TabIndex = 3
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(136, 42)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(353, 23)
        Me.cbProducto.TabIndex = 7
        '
        'dtFechaCompra
        '
        Me.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCompra.Location = New System.Drawing.Point(498, 41)
        Me.dtFechaCompra.Name = "dtFechaCompra"
        Me.dtFechaCompra.Size = New System.Drawing.Size(113, 21)
        Me.dtFechaCompra.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(495, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de Venta"
        '
        'btnIniciarCompraDatagrid
        '
        Me.btnIniciarCompraDatagrid.Location = New System.Drawing.Point(719, 11)
        Me.btnIniciarCompraDatagrid.Name = "btnIniciarCompraDatagrid"
        Me.btnIniciarCompraDatagrid.Size = New System.Drawing.Size(99, 27)
        Me.btnIniciarCompraDatagrid.TabIndex = 6
        Me.btnIniciarCompraDatagrid.Text = "Iniciar Venta"
        Me.btnIniciarCompraDatagrid.UseVisualStyleBackColor = True
        '
        'gbProductos
        '
        Me.gbProductos.Controls.Add(Me.tbProducto)
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
        Me.gbProductos.Location = New System.Drawing.Point(4, 89)
        Me.gbProductos.Name = "gbProductos"
        Me.gbProductos.Size = New System.Drawing.Size(827, 75)
        Me.gbProductos.TabIndex = 11
        Me.gbProductos.TabStop = False
        Me.gbProductos.Text = "Seleccione productos"
        '
        'tbProducto
        '
        Me.tbProducto.Location = New System.Drawing.Point(61, 43)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(69, 21)
        Me.tbProducto.TabIndex = 18
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(752, 17)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(67, 47)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar Partida"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'mtbPrecio
        '
        Me.mtbPrecio.Location = New System.Drawing.Point(670, 42)
        Me.mtbPrecio.Name = "mtbPrecio"
        Me.mtbPrecio.Size = New System.Drawing.Size(69, 21)
        Me.mtbPrecio.TabIndex = 10
        '
        'mtbCant
        '
        Me.mtbCant.Location = New System.Drawing.Point(604, 42)
        Me.mtbCant.Name = "mtbCant"
        Me.mtbCant.Size = New System.Drawing.Size(60, 21)
        Me.mtbCant.TabIndex = 9
        '
        'cbUM
        '
        Me.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Location = New System.Drawing.Point(498, 42)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(79, 23)
        Me.cbUM.TabIndex = 8
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
        Me.Label8.Location = New System.Drawing.Point(670, 18)
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
        Me.Label11.Location = New System.Drawing.Point(604, 18)
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
        Me.dgvProductos.Location = New System.Drawing.Point(5, 170)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(834, 260)
        Me.dgvProductos.TabIndex = 12
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.btnPrecotizado)
        Me.gbProveedor.Controls.Add(Me.chkIVA)
        Me.gbProveedor.Controls.Add(Me.tbCliente)
        Me.gbProveedor.Controls.Add(Me.tbReferenciaProveedor)
        Me.gbProveedor.Controls.Add(Me.Label13)
        Me.gbProveedor.Controls.Add(Me.btnIniciarCompraDatagrid)
        Me.gbProveedor.Controls.Add(Me.Label5)
        Me.gbProveedor.Controls.Add(Me.dtFechaCompra)
        Me.gbProveedor.Controls.Add(Me.cbCliente)
        Me.gbProveedor.Controls.Add(Me.Label1)
        Me.gbProveedor.Location = New System.Drawing.Point(5, 12)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(826, 73)
        Me.gbProveedor.TabIndex = 13
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Seleccione Cliente"
        '
        'btnPrecotizado
        '
        Me.btnPrecotizado.Location = New System.Drawing.Point(719, 39)
        Me.btnPrecotizado.Name = "btnPrecotizado"
        Me.btnPrecotizado.Size = New System.Drawing.Size(99, 27)
        Me.btnPrecotizado.TabIndex = 13
        Me.btnPrecotizado.Text = "Pre-Cotizado"
        Me.btnPrecotizado.UseVisualStyleBackColor = True
        '
        'chkIVA
        '
        Me.chkIVA.AutoSize = True
        Me.chkIVA.Location = New System.Drawing.Point(624, 29)
        Me.chkIVA.Name = "chkIVA"
        Me.chkIVA.Size = New System.Drawing.Size(89, 19)
        Me.chkIVA.TabIndex = 12
        Me.chkIVA.Text = "Agregar IVA"
        Me.chkIVA.UseVisualStyleBackColor = True
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(126, 16)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(111, 21)
        Me.tbCliente.TabIndex = 11
        '
        'tbReferenciaProveedor
        '
        Me.tbReferenciaProveedor.Location = New System.Drawing.Point(255, 42)
        Me.tbReferenciaProveedor.MaxLength = 30
        Me.tbReferenciaProveedor.Name = "tbReferenciaProveedor"
        Me.tbReferenciaProveedor.Size = New System.Drawing.Size(226, 21)
        Me.tbReferenciaProveedor.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(252, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Referencia de Venta"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(768, 435)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 41)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar Venta"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.btnGenerarSalida)
        Me.gbTodo.Controls.Add(Me.btnCancelar)
        Me.gbTodo.Controls.Add(Me.gbProveedor)
        Me.gbTodo.Controls.Add(Me.dgvProductos)
        Me.gbTodo.Controls.Add(Me.gbProductos)
        Me.gbTodo.Location = New System.Drawing.Point(10, 71)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(848, 486)
        Me.gbTodo.TabIndex = 15
        Me.gbTodo.TabStop = False
        '
        'btnGenerarSalida
        '
        Me.btnGenerarSalida.Location = New System.Drawing.Point(615, 435)
        Me.btnGenerarSalida.Name = "btnGenerarSalida"
        Me.btnGenerarSalida.Size = New System.Drawing.Size(147, 41)
        Me.btnGenerarSalida.TabIndex = 15
        Me.btnGenerarSalida.Text = "Preparar Orden de Salida"
        Me.btnGenerarSalida.UseVisualStyleBackColor = True
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(16, 16)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(840, 40)
        Me.lblEmpresa.TabIndex = 16
        Me.lblEmpresa.Text = "Label2"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Controls.Add(Me.btnAaron)
        Me.gbEmpresa.Controls.Add(Me.btnQuart)
        Me.gbEmpresa.Location = New System.Drawing.Point(10, 11)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(848, 60)
        Me.gbEmpresa.TabIndex = 17
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "  Seleccione la empresa con la que desea realizar la venta  "
        '
        'btnAaron
        '
        Me.btnAaron.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAaron.Location = New System.Drawing.Point(488, 21)
        Me.btnAaron.Name = "btnAaron"
        Me.btnAaron.Size = New System.Drawing.Size(304, 33)
        Me.btnAaron.TabIndex = 2
        Me.btnAaron.Text = "AARON URDIALES GONZALEZ"
        Me.btnAaron.UseVisualStyleBackColor = True
        '
        'btnQuart
        '
        Me.btnQuart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuart.Location = New System.Drawing.Point(57, 21)
        Me.btnQuart.Name = "btnQuart"
        Me.btnQuart.Size = New System.Drawing.Size(304, 33)
        Me.btnQuart.TabIndex = 1
        Me.btnQuart.Text = "QUART INDUSTRIA S.A. DE C.V."
        Me.btnQuart.UseVisualStyleBackColor = True
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Location = New System.Drawing.Point(282, 582)
        Me.tbObservaciones.MaxLength = 250
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.Size = New System.Drawing.Size(223, 89)
        Me.tbObservaciones.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 563)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Observaciones de Entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Domicilio de Entrega"
        '
        'tbDomicilioEntrega
        '
        Me.tbDomicilioEntrega.Location = New System.Drawing.Point(25, 582)
        Me.tbDomicilioEntrega.MaxLength = 250
        Me.tbDomicilioEntrega.Multiline = True
        Me.tbDomicilioEntrega.Name = "tbDomicilioEntrega"
        Me.tbDomicilioEntrega.Size = New System.Drawing.Size(246, 89)
        Me.tbDomicilioEntrega.TabIndex = 28
        '
        'btnCancelarTodo
        '
        Me.btnCancelarTodo.Location = New System.Drawing.Point(778, 630)
        Me.btnCancelarTodo.Name = "btnCancelarTodo"
        Me.btnCancelarTodo.Size = New System.Drawing.Size(71, 33)
        Me.btnCancelarTodo.TabIndex = 26
        Me.btnCancelarTodo.Text = "Cancelar"
        Me.btnCancelarTodo.UseVisualStyleBackColor = True
        '
        'btnGrabarOrdenSalida
        '
        Me.btnGrabarOrdenSalida.Location = New System.Drawing.Point(625, 630)
        Me.btnGrabarOrdenSalida.Name = "btnGrabarOrdenSalida"
        Me.btnGrabarOrdenSalida.Size = New System.Drawing.Size(147, 33)
        Me.btnGrabarOrdenSalida.TabIndex = 27
        Me.btnGrabarOrdenSalida.Text = "Grabar Orden de Salida"
        Me.btnGrabarOrdenSalida.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 563)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Recibió Mercancía :"
        '
        'tbRecibioMercancia
        '
        Me.tbRecibioMercancia.Location = New System.Drawing.Point(565, 589)
        Me.tbRecibioMercancia.MaxLength = 40
        Me.tbRecibioMercancia.Name = "tbRecibioMercancia"
        Me.tbRecibioMercancia.Size = New System.Drawing.Size(275, 21)
        Me.tbRecibioMercancia.TabIndex = 34
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(535, 630)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(84, 32)
        Me.btnVistaPrevia.TabIndex = 35
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'tcApoyos
        '
        Me.tcApoyos.Controls.Add(Me.tpModificarPartida)
        Me.tcApoyos.Controls.Add(Me.tpRepetirCotizacion)
        Me.tcApoyos.Location = New System.Drawing.Point(862, 12)
        Me.tcApoyos.Name = "tcApoyos"
        Me.tcApoyos.SelectedIndex = 0
        Me.tcApoyos.Size = New System.Drawing.Size(326, 545)
        Me.tcApoyos.TabIndex = 36
        '
        'tpModificarPartida
        '
        Me.tpModificarPartida.Controls.Add(Me.btnModificarPartida)
        Me.tpModificarPartida.Controls.Add(Me.mtbPrecioUnitarioM)
        Me.tpModificarPartida.Controls.Add(Me.mtbCantidadM)
        Me.tpModificarPartida.Controls.Add(Me.Label23)
        Me.tpModificarPartida.Controls.Add(Me.Label22)
        Me.tpModificarPartida.Controls.Add(Me.lblUMedidaM)
        Me.tpModificarPartida.Controls.Add(Me.lblDescProcuctoM)
        Me.tpModificarPartida.Location = New System.Drawing.Point(4, 24)
        Me.tpModificarPartida.Name = "tpModificarPartida"
        Me.tpModificarPartida.Padding = New System.Windows.Forms.Padding(3)
        Me.tpModificarPartida.Size = New System.Drawing.Size(318, 517)
        Me.tpModificarPartida.TabIndex = 0
        Me.tpModificarPartida.Text = "Modificacion de Partida"
        Me.tpModificarPartida.UseVisualStyleBackColor = True
        '
        'btnModificarPartida
        '
        Me.btnModificarPartida.Location = New System.Drawing.Point(97, 185)
        Me.btnModificarPartida.Name = "btnModificarPartida"
        Me.btnModificarPartida.Size = New System.Drawing.Size(137, 41)
        Me.btnModificarPartida.TabIndex = 21
        Me.btnModificarPartida.Text = "Modificar Partida"
        Me.btnModificarPartida.UseVisualStyleBackColor = True
        '
        'mtbPrecioUnitarioM
        '
        Me.mtbPrecioUnitarioM.Location = New System.Drawing.Point(153, 137)
        Me.mtbPrecioUnitarioM.Name = "mtbPrecioUnitarioM"
        Me.mtbPrecioUnitarioM.Size = New System.Drawing.Size(81, 21)
        Me.mtbPrecioUnitarioM.TabIndex = 20
        '
        'mtbCantidadM
        '
        Me.mtbCantidadM.Location = New System.Drawing.Point(153, 112)
        Me.mtbCantidadM.Name = "mtbCantidadM"
        Me.mtbCantidadM.Size = New System.Drawing.Size(81, 21)
        Me.mtbCantidadM.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 15)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Precio Unitario :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Cantidad :"
        '
        'lblUMedidaM
        '
        Me.lblUMedidaM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUMedidaM.Location = New System.Drawing.Point(5, 71)
        Me.lblUMedidaM.Name = "lblUMedidaM"
        Me.lblUMedidaM.Size = New System.Drawing.Size(115, 19)
        Me.lblUMedidaM.TabIndex = 16
        '
        'lblDescProcuctoM
        '
        Me.lblDescProcuctoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescProcuctoM.Location = New System.Drawing.Point(5, 13)
        Me.lblDescProcuctoM.Name = "lblDescProcuctoM"
        Me.lblDescProcuctoM.Size = New System.Drawing.Size(308, 49)
        Me.lblDescProcuctoM.TabIndex = 15
        '
        'tpRepetirCotizacion
        '
        Me.tpRepetirCotizacion.Controls.Add(Me.btnSeleccionarCotizacionFuente)
        Me.tpRepetirCotizacion.Controls.Add(Me.dgvPartidasAnteriores)
        Me.tpRepetirCotizacion.Controls.Add(Me.dgvCotizacionesAnteriores)
        Me.tpRepetirCotizacion.Controls.Add(Me.tbClienteCotizacionAnterior)
        Me.tpRepetirCotizacion.Controls.Add(Me.Label24)
        Me.tpRepetirCotizacion.Location = New System.Drawing.Point(4, 24)
        Me.tpRepetirCotizacion.Name = "tpRepetirCotizacion"
        Me.tpRepetirCotizacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRepetirCotizacion.Size = New System.Drawing.Size(318, 517)
        Me.tpRepetirCotizacion.TabIndex = 1
        Me.tpRepetirCotizacion.Text = "Seleccione la Cotización"
        Me.tpRepetirCotizacion.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCotizacionFuente
        '
        Me.btnSeleccionarCotizacionFuente.Location = New System.Drawing.Point(111, 476)
        Me.btnSeleccionarCotizacionFuente.Name = "btnSeleccionarCotizacionFuente"
        Me.btnSeleccionarCotizacionFuente.Size = New System.Drawing.Size(94, 29)
        Me.btnSeleccionarCotizacionFuente.TabIndex = 14
        Me.btnSeleccionarCotizacionFuente.Text = "Seleccionar"
        Me.btnSeleccionarCotizacionFuente.UseVisualStyleBackColor = True
        '
        'dgvPartidasAnteriores
        '
        Me.dgvPartidasAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidasAnteriores.Location = New System.Drawing.Point(3, 214)
        Me.dgvPartidasAnteriores.Name = "dgvPartidasAnteriores"
        Me.dgvPartidasAnteriores.Size = New System.Drawing.Size(312, 256)
        Me.dgvPartidasAnteriores.TabIndex = 13
        '
        'dgvCotizacionesAnteriores
        '
        Me.dgvCotizacionesAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCotizacionesAnteriores.Location = New System.Drawing.Point(6, 35)
        Me.dgvCotizacionesAnteriores.Name = "dgvCotizacionesAnteriores"
        Me.dgvCotizacionesAnteriores.Size = New System.Drawing.Size(307, 174)
        Me.dgvCotizacionesAnteriores.TabIndex = 12
        '
        'tbClienteCotizacionAnterior
        '
        Me.tbClienteCotizacionAnterior.Location = New System.Drawing.Point(58, 7)
        Me.tbClienteCotizacionAnterior.Name = "tbClienteCotizacionAnterior"
        Me.tbClienteCotizacionAnterior.ReadOnly = True
        Me.tbClienteCotizacionAnterior.Size = New System.Drawing.Size(254, 21)
        Me.tbClienteCotizacionAnterior.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 10)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 15)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Cliente"
        '
        'VentaMostrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 676)
        Me.Controls.Add(Me.tcApoyos)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.tbRecibioMercancia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbObservaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDomicilioEntrega)
        Me.Controls.Add(Me.btnCancelarTodo)
        Me.Controls.Add(Me.btnGrabarOrdenSalida)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.gbTodo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaMostrador"
        Me.Text = "Venta de Mostrador"
        Me.gbProductos.ResumeLayout(False)
        Me.gbProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.gbTodo.ResumeLayout(False)
        Me.gbEmpresa.ResumeLayout(False)
        Me.tcApoyos.ResumeLayout(False)
        Me.tpModificarPartida.ResumeLayout(False)
        Me.tpModificarPartida.PerformLayout()
        Me.tpRepetirCotizacion.ResumeLayout(False)
        Me.tpRepetirCotizacion.PerformLayout()
        CType(Me.dgvPartidasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCotizacionesAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbReferenciaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbTodo As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents btnAaron As System.Windows.Forms.Button
    Friend WithEvents btnQuart As System.Windows.Forms.Button
    Friend WithEvents btnGenerarSalida As Button
    Friend WithEvents tbObservaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDomicilioEntrega As TextBox
    Friend WithEvents btnCancelarTodo As Button
    Friend WithEvents btnGrabarOrdenSalida As Button
    Friend WithEvents tbProducto As System.Windows.Forms.TextBox
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents chkIVA As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRecibioMercancia As System.Windows.Forms.TextBox
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents tcApoyos As System.Windows.Forms.TabControl
    Friend WithEvents tpModificarPartida As System.Windows.Forms.TabPage
    Friend WithEvents tpRepetirCotizacion As System.Windows.Forms.TabPage
    Friend WithEvents btnModificarPartida As System.Windows.Forms.Button
    Friend WithEvents mtbPrecioUnitarioM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCantidadM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblUMedidaM As System.Windows.Forms.Label
    Friend WithEvents lblDescProcuctoM As System.Windows.Forms.Label
    Friend WithEvents dgvPartidasAnteriores As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCotizacionesAnteriores As System.Windows.Forms.DataGridView
    Friend WithEvents tbClienteCotizacionAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionarCotizacionFuente As System.Windows.Forms.Button
    Friend WithEvents btnPrecotizado As System.Windows.Forms.Button
End Class
