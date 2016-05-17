<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.dtFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIniciarCompraDatagrid = New System.Windows.Forms.Button()
        Me.gbProductos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnUltimaCotizacion = New System.Windows.Forms.Button()
        Me.chkAgregarIVA = New System.Windows.Forms.CheckBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.tbReferenciaProveedor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGrabarCotizacion = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbTodo = New System.Windows.Forms.GroupBox()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.btnAaron = New System.Windows.Forms.Button()
        Me.btnQuart = New System.Windows.Forms.Button()
        Me.btnCancelaProductoNoCatalogado = New System.Windows.Forms.Button()
        Me.btnGrabarClienteD = New System.Windows.Forms.Button()
        Me.tbContactoD = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbCorreoD = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbTel2D = New System.Windows.Forms.TextBox()
        Me.tbTel1D = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbEstadoD = New System.Windows.Forms.TextBox()
        Me.tbMunicipioD = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbColoniaD = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbDomicilioD = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRazonSocialD = New System.Windows.Forms.TextBox()
        Me.lblDescProcuctoM = New System.Windows.Forms.TextBox()
        Me.lblUMedidaM = New System.Windows.Forms.Label()
        Me.btnModificarPartida = New System.Windows.Forms.Button()
        Me.mtbPrecioUnitarioM = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCantidadM = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mtbPrecioNuevo = New System.Windows.Forms.MaskedTextBox()
        Me.btnGrabarProducto = New System.Windows.Forms.Button()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.tbDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbClienteCotizacionAnterior = New System.Windows.Forms.ComboBox()
        Me.tcApoyos = New System.Windows.Forms.TabControl()
        Me.tpClienteD = New System.Windows.Forms.TabPage()
        Me.tpProductoD = New System.Windows.Forms.TabPage()
        Me.tpModificarPartida = New System.Windows.Forms.TabPage()
        Me.tpRepetirCotizacion = New System.Windows.Forms.TabPage()
        Me.btnRegresar = New System.Windows.Forms.Button()
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
        Me.tpClienteD.SuspendLayout()
        Me.tpProductoD.SuspendLayout()
        Me.tpModificarPartida.SuspendLayout()
        Me.tpRepetirCotizacion.SuspendLayout()
        CType(Me.dgvPartidasAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCotizacionesAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
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
        Me.cbCliente.Location = New System.Drawing.Point(10, 52)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(284, 23)
        Me.cbCliente.TabIndex = 201
        Me.tTip.SetToolTip(Me.cbCliente, """""")
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(155, 42)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(354, 23)
        Me.cbProducto.TabIndex = 302
        '
        'dtFechaCompra
        '
        Me.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCompra.Location = New System.Drawing.Point(589, 52)
        Me.dtFechaCompra.Name = "dtFechaCompra"
        Me.dtFechaCompra.Size = New System.Drawing.Size(113, 21)
        Me.dtFechaCompra.TabIndex = 204
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de Cotización"
        '
        'btnIniciarCompraDatagrid
        '
        Me.btnIniciarCompraDatagrid.Location = New System.Drawing.Point(712, 15)
        Me.btnIniciarCompraDatagrid.Name = "btnIniciarCompraDatagrid"
        Me.btnIniciarCompraDatagrid.Size = New System.Drawing.Size(122, 27)
        Me.btnIniciarCompraDatagrid.TabIndex = 205
        Me.btnIniciarCompraDatagrid.Text = "Nueva Cotización"
        Me.btnIniciarCompraDatagrid.UseVisualStyleBackColor = True
        '
        'gbProductos
        '
        Me.gbProductos.Controls.Add(Me.Button1)
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
        Me.gbProductos.Location = New System.Drawing.Point(5, 113)
        Me.gbProductos.Name = "gbProductos"
        Me.gbProductos.Size = New System.Drawing.Size(827, 75)
        Me.gbProductos.TabIndex = 9
        Me.gbProductos.TabStop = False
        Me.gbProductos.Text = "Seleccione productos"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(60, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 300
        Me.Button1.Text = "n"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbProducto
        '
        Me.tbProducto.Location = New System.Drawing.Point(84, 42)
        Me.tbProducto.MaxLength = 140
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(65, 21)
        Me.tbProducto.TabIndex = 301
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(752, 17)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(67, 47)
        Me.btnAgregar.TabIndex = 307
        Me.btnAgregar.Text = "Agregar Partida"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'mtbPrecio
        '
        Me.mtbPrecio.Location = New System.Drawing.Point(670, 42)
        Me.mtbPrecio.Name = "mtbPrecio"
        Me.mtbPrecio.Size = New System.Drawing.Size(69, 21)
        Me.mtbPrecio.TabIndex = 305
        '
        'mtbCant
        '
        Me.mtbCant.Location = New System.Drawing.Point(604, 42)
        Me.mtbCant.Name = "mtbCant"
        Me.mtbCant.Size = New System.Drawing.Size(60, 21)
        Me.mtbCant.TabIndex = 304
        '
        'cbUM
        '
        Me.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Location = New System.Drawing.Point(517, 42)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(79, 23)
        Me.cbUM.TabIndex = 303
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
        Me.Label10.Location = New System.Drawing.Point(58, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(451, 18)
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
        Me.Label12.Location = New System.Drawing.Point(515, 18)
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
        Me.dgvProductos.Location = New System.Drawing.Point(5, 194)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(834, 276)
        Me.dgvProductos.TabIndex = 16
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.btnUltimaCotizacion)
        Me.gbProveedor.Controls.Add(Me.chkAgregarIVA)
        Me.gbProveedor.Controls.Add(Me.tbCliente)
        Me.gbProveedor.Controls.Add(Me.tbReferenciaProveedor)
        Me.gbProveedor.Controls.Add(Me.Label13)
        Me.gbProveedor.Controls.Add(Me.btnIniciarCompraDatagrid)
        Me.gbProveedor.Controls.Add(Me.Label5)
        Me.gbProveedor.Controls.Add(Me.dtFechaCompra)
        Me.gbProveedor.Controls.Add(Me.cbCliente)
        Me.gbProveedor.Controls.Add(Me.Label1)
        Me.gbProveedor.Location = New System.Drawing.Point(5, 21)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(837, 87)
        Me.gbProveedor.TabIndex = 3
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Seleccione Cliente"
        '
        'btnUltimaCotizacion
        '
        Me.btnUltimaCotizacion.Location = New System.Drawing.Point(712, 49)
        Me.btnUltimaCotizacion.Name = "btnUltimaCotizacion"
        Me.btnUltimaCotizacion.Size = New System.Drawing.Size(122, 27)
        Me.btnUltimaCotizacion.TabIndex = 206
        Me.btnUltimaCotizacion.Text = "Ultima Cotización"
        Me.btnUltimaCotizacion.UseVisualStyleBackColor = True
        '
        'chkAgregarIVA
        '
        Me.chkAgregarIVA.AutoSize = True
        Me.chkAgregarIVA.Location = New System.Drawing.Point(493, 43)
        Me.chkAgregarIVA.Name = "chkAgregarIVA"
        Me.chkAgregarIVA.Size = New System.Drawing.Size(89, 19)
        Me.chkAgregarIVA.TabIndex = 203
        Me.chkAgregarIVA.Text = "Agregar IVA"
        Me.chkAgregarIVA.UseVisualStyleBackColor = True
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(58, 21)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(117, 21)
        Me.tbCliente.TabIndex = 200
        '
        'tbReferenciaProveedor
        '
        Me.tbReferenciaProveedor.Location = New System.Drawing.Point(300, 52)
        Me.tbReferenciaProveedor.MaxLength = 30
        Me.tbReferenciaProveedor.Name = "tbReferenciaProveedor"
        Me.tbReferenciaProveedor.Size = New System.Drawing.Size(181, 21)
        Me.tbReferenciaProveedor.TabIndex = 202
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 24)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Referencia del Cliente"
        '
        'btnGrabarCotizacion
        '
        Me.btnGrabarCotizacion.Location = New System.Drawing.Point(628, 492)
        Me.btnGrabarCotizacion.Name = "btnGrabarCotizacion"
        Me.btnGrabarCotizacion.Size = New System.Drawing.Size(75, 41)
        Me.btnGrabarCotizacion.TabIndex = 401
        Me.btnGrabarCotizacion.Text = "Grabar Cotización"
        Me.btnGrabarCotizacion.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(734, 492)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 41)
        Me.btnCancelar.TabIndex = 402
        Me.btnCancelar.Text = "Cancelar Cotización"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbTodo
        '
        Me.gbTodo.Controls.Add(Me.btnVistaPrevia)
        Me.gbTodo.Controls.Add(Me.btnCancelar)
        Me.gbTodo.Controls.Add(Me.btnGrabarCotizacion)
        Me.gbTodo.Controls.Add(Me.gbProveedor)
        Me.gbTodo.Controls.Add(Me.dgvProductos)
        Me.gbTodo.Controls.Add(Me.gbProductos)
        Me.gbTodo.Location = New System.Drawing.Point(10, 71)
        Me.gbTodo.Name = "gbTodo"
        Me.gbTodo.Size = New System.Drawing.Size(848, 543)
        Me.gbTodo.TabIndex = 15
        Me.gbTodo.TabStop = False
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(522, 492)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(75, 41)
        Me.btnVistaPrevia.TabIndex = 400
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
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
        Me.gbEmpresa.Text = "  Seleccione la empresa con la que desea cotizar  "
        '
        'btnAaron
        '
        Me.btnAaron.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAaron.Location = New System.Drawing.Point(505, 21)
        Me.btnAaron.Name = "btnAaron"
        Me.btnAaron.Size = New System.Drawing.Size(270, 33)
        Me.btnAaron.TabIndex = 2
        Me.btnAaron.Tag = "101"
        Me.btnAaron.Text = "AARON URDIALES GONZALEZ"
        Me.btnAaron.UseVisualStyleBackColor = True
        '
        'btnQuart
        '
        Me.btnQuart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuart.Location = New System.Drawing.Point(74, 21)
        Me.btnQuart.Name = "btnQuart"
        Me.btnQuart.Size = New System.Drawing.Size(270, 33)
        Me.btnQuart.TabIndex = 100
        Me.btnQuart.Text = "QUART INDUSTRIA S.A. DE C.V."
        Me.btnQuart.UseVisualStyleBackColor = True
        '
        'btnCancelaProductoNoCatalogado
        '
        Me.btnCancelaProductoNoCatalogado.Location = New System.Drawing.Point(212, 292)
        Me.btnCancelaProductoNoCatalogado.Name = "btnCancelaProductoNoCatalogado"
        Me.btnCancelaProductoNoCatalogado.Size = New System.Drawing.Size(122, 28)
        Me.btnCancelaProductoNoCatalogado.TabIndex = 511
        Me.btnCancelaProductoNoCatalogado.Text = "Cancelar"
        Me.btnCancelaProductoNoCatalogado.UseVisualStyleBackColor = True
        '
        'btnGrabarClienteD
        '
        Me.btnGrabarClienteD.Location = New System.Drawing.Point(9, 292)
        Me.btnGrabarClienteD.Name = "btnGrabarClienteD"
        Me.btnGrabarClienteD.Size = New System.Drawing.Size(184, 28)
        Me.btnGrabarClienteD.TabIndex = 510
        Me.btnGrabarClienteD.Text = "Grabar Cliente No Catalogado"
        Me.btnGrabarClienteD.UseVisualStyleBackColor = True
        '
        'tbContactoD
        '
        Me.tbContactoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContactoD.Location = New System.Drawing.Point(8, 265)
        Me.tbContactoD.Name = "tbContactoD"
        Me.tbContactoD.Size = New System.Drawing.Size(328, 21)
        Me.tbContactoD.TabIndex = 509
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 15)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Nombre del Contacto"
        '
        'tbCorreoD
        '
        Me.tbCorreoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCorreoD.Location = New System.Drawing.Point(8, 225)
        Me.tbCorreoD.Name = "tbCorreoD"
        Me.tbCorreoD.Size = New System.Drawing.Size(328, 21)
        Me.tbCorreoD.TabIndex = 508
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Correo Electrónico"
        '
        'tbTel2D
        '
        Me.tbTel2D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTel2D.Location = New System.Drawing.Point(175, 178)
        Me.tbTel2D.Name = "tbTel2D"
        Me.tbTel2D.Size = New System.Drawing.Size(161, 21)
        Me.tbTel2D.TabIndex = 507
        '
        'tbTel1D
        '
        Me.tbTel1D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTel1D.Location = New System.Drawing.Point(9, 178)
        Me.tbTel1D.Name = "tbTel1D"
        Me.tbTel1D.Size = New System.Drawing.Size(154, 21)
        Me.tbTel1D.TabIndex = 506
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(172, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 15)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Telefono 2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 161)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 15)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Telefono 1"
        '
        'tbEstadoD
        '
        Me.tbEstadoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEstadoD.Location = New System.Drawing.Point(175, 139)
        Me.tbEstadoD.Name = "tbEstadoD"
        Me.tbEstadoD.Size = New System.Drawing.Size(161, 21)
        Me.tbEstadoD.TabIndex = 505
        '
        'tbMunicipioD
        '
        Me.tbMunicipioD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMunicipioD.Location = New System.Drawing.Point(9, 139)
        Me.tbMunicipioD.Name = "tbMunicipioD"
        Me.tbMunicipioD.Size = New System.Drawing.Size(154, 21)
        Me.tbMunicipioD.TabIndex = 504
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(171, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 15)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Estado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Municipio"
        '
        'tbColoniaD
        '
        Me.tbColoniaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbColoniaD.Location = New System.Drawing.Point(8, 99)
        Me.tbColoniaD.Name = "tbColoniaD"
        Me.tbColoniaD.Size = New System.Drawing.Size(328, 21)
        Me.tbColoniaD.TabIndex = 503
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 15)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Colonia"
        '
        'tbDomicilioD
        '
        Me.tbDomicilioD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDomicilioD.Location = New System.Drawing.Point(8, 60)
        Me.tbDomicilioD.Name = "tbDomicilioD"
        Me.tbDomicilioD.Size = New System.Drawing.Size(328, 21)
        Me.tbDomicilioD.TabIndex = 501
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Domicilio (Calle y Numero)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Razon Social"
        '
        'tbRazonSocialD
        '
        Me.tbRazonSocialD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRazonSocialD.Location = New System.Drawing.Point(8, 21)
        Me.tbRazonSocialD.Name = "tbRazonSocialD"
        Me.tbRazonSocialD.Size = New System.Drawing.Size(328, 21)
        Me.tbRazonSocialD.TabIndex = 500
        '
        'lblDescProcuctoM
        '
        Me.lblDescProcuctoM.Enabled = False
        Me.lblDescProcuctoM.Location = New System.Drawing.Point(17, 22)
        Me.lblDescProcuctoM.MaxLength = 50
        Me.lblDescProcuctoM.Multiline = True
        Me.lblDescProcuctoM.Name = "lblDescProcuctoM"
        Me.lblDescProcuctoM.Size = New System.Drawing.Size(319, 57)
        Me.lblDescProcuctoM.TabIndex = 700
        '
        'lblUMedidaM
        '
        Me.lblUMedidaM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUMedidaM.Location = New System.Drawing.Point(17, 99)
        Me.lblUMedidaM.Name = "lblUMedidaM"
        Me.lblUMedidaM.Size = New System.Drawing.Size(115, 19)
        Me.lblUMedidaM.TabIndex = 1
        '
        'btnModificarPartida
        '
        Me.btnModificarPartida.Location = New System.Drawing.Point(136, 218)
        Me.btnModificarPartida.Name = "btnModificarPartida"
        Me.btnModificarPartida.Size = New System.Drawing.Size(137, 41)
        Me.btnModificarPartida.TabIndex = 703
        Me.btnModificarPartida.Text = "Modificar Partida"
        Me.btnModificarPartida.UseVisualStyleBackColor = True
        '
        'mtbPrecioUnitarioM
        '
        Me.mtbPrecioUnitarioM.Location = New System.Drawing.Point(192, 170)
        Me.mtbPrecioUnitarioM.Name = "mtbPrecioUnitarioM"
        Me.mtbPrecioUnitarioM.Size = New System.Drawing.Size(81, 21)
        Me.mtbPrecioUnitarioM.TabIndex = 702
        '
        'mtbCantidadM
        '
        Me.mtbCantidadM.Location = New System.Drawing.Point(192, 145)
        Me.mtbCantidadM.Name = "mtbCantidadM"
        Me.mtbCantidadM.Size = New System.Drawing.Size(81, 21)
        Me.mtbCantidadM.TabIndex = 701
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(49, 173)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 15)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Precio Unitario :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(49, 148)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Cantidad :"
        '
        'mtbPrecioNuevo
        '
        Me.mtbPrecioNuevo.Location = New System.Drawing.Point(250, 79)
        Me.mtbPrecioNuevo.Name = "mtbPrecioNuevo"
        Me.mtbPrecioNuevo.Size = New System.Drawing.Size(86, 21)
        Me.mtbPrecioNuevo.TabIndex = 602
        Me.mtbPrecioNuevo.Text = "0.00"
        '
        'btnGrabarProducto
        '
        Me.btnGrabarProducto.Location = New System.Drawing.Point(117, 162)
        Me.btnGrabarProducto.Name = "btnGrabarProducto"
        Me.btnGrabarProducto.Size = New System.Drawing.Size(113, 52)
        Me.btnGrabarProducto.TabIndex = 605
        Me.btnGrabarProducto.Text = "Grabar Producto No Catalogado"
        Me.btnGrabarProducto.UseVisualStyleBackColor = True
        '
        'cbProveedor
        '
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(9, 134)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(328, 23)
        Me.cbProveedor.TabIndex = 604
        Me.cbProveedor.Visible = False
        '
        'tbProveedor
        '
        Me.tbProveedor.Location = New System.Drawing.Point(93, 107)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(107, 21)
        Me.tbProveedor.TabIndex = 603
        Me.tbProveedor.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Proveedor"
        Me.Label4.Visible = False
        '
        'cbUnidadMedida
        '
        Me.cbUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadMedida.FormattingEnabled = True
        Me.cbUnidadMedida.Location = New System.Drawing.Point(83, 78)
        Me.cbUnidadMedida.Name = "cbUnidadMedida"
        Me.cbUnidadMedida.Size = New System.Drawing.Size(81, 23)
        Me.cbUnidadMedida.TabIndex = 601
        '
        'tbDescripcionProducto
        '
        Me.tbDescripcionProducto.Location = New System.Drawing.Point(9, 33)
        Me.tbDescripcionProducto.MaxLength = 140
        Me.tbDescripcionProducto.Name = "tbDescripcionProducto"
        Me.tbDescripcionProducto.Size = New System.Drawing.Size(328, 21)
        Me.tbDescripcionProducto.TabIndex = 600
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(185, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 33)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Precio Unitario"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 33)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Unidad de Medida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descripción del producto"
        '
        'cbClienteCotizacionAnterior
        '
        Me.cbClienteCotizacionAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClienteCotizacionAnterior.FormattingEnabled = True
        Me.cbClienteCotizacionAnterior.Location = New System.Drawing.Point(8, 40)
        Me.cbClienteCotizacionAnterior.Name = "cbClienteCotizacionAnterior"
        Me.cbClienteCotizacionAnterior.Size = New System.Drawing.Size(322, 23)
        Me.cbClienteCotizacionAnterior.TabIndex = 801
        Me.tTip.SetToolTip(Me.cbClienteCotizacionAnterior, """""")
        '
        'tcApoyos
        '
        Me.tcApoyos.Controls.Add(Me.tpClienteD)
        Me.tcApoyos.Controls.Add(Me.tpProductoD)
        Me.tcApoyos.Controls.Add(Me.tpModificarPartida)
        Me.tcApoyos.Controls.Add(Me.tpRepetirCotizacion)
        Me.tcApoyos.Location = New System.Drawing.Point(862, 12)
        Me.tcApoyos.Name = "tcApoyos"
        Me.tcApoyos.SelectedIndex = 0
        Me.tcApoyos.Size = New System.Drawing.Size(347, 602)
        Me.tcApoyos.TabIndex = 20
        '
        'tpClienteD
        '
        Me.tpClienteD.BackColor = System.Drawing.SystemColors.Control
        Me.tpClienteD.Controls.Add(Me.btnCancelaProductoNoCatalogado)
        Me.tpClienteD.Controls.Add(Me.Label7)
        Me.tpClienteD.Controls.Add(Me.btnGrabarClienteD)
        Me.tpClienteD.Controls.Add(Me.tbRazonSocialD)
        Me.tpClienteD.Controls.Add(Me.tbContactoD)
        Me.tpClienteD.Controls.Add(Me.Label14)
        Me.tpClienteD.Controls.Add(Me.Label21)
        Me.tpClienteD.Controls.Add(Me.tbDomicilioD)
        Me.tpClienteD.Controls.Add(Me.tbCorreoD)
        Me.tpClienteD.Controls.Add(Me.Label15)
        Me.tpClienteD.Controls.Add(Me.Label20)
        Me.tpClienteD.Controls.Add(Me.tbColoniaD)
        Me.tpClienteD.Controls.Add(Me.tbTel2D)
        Me.tpClienteD.Controls.Add(Me.Label16)
        Me.tpClienteD.Controls.Add(Me.tbTel1D)
        Me.tpClienteD.Controls.Add(Me.Label17)
        Me.tpClienteD.Controls.Add(Me.Label18)
        Me.tpClienteD.Controls.Add(Me.tbMunicipioD)
        Me.tpClienteD.Controls.Add(Me.Label19)
        Me.tpClienteD.Controls.Add(Me.tbEstadoD)
        Me.tpClienteD.Location = New System.Drawing.Point(4, 24)
        Me.tpClienteD.Name = "tpClienteD"
        Me.tpClienteD.Padding = New System.Windows.Forms.Padding(3)
        Me.tpClienteD.Size = New System.Drawing.Size(339, 574)
        Me.tpClienteD.TabIndex = 0
        Me.tpClienteD.Text = "Introduzca los datos del prospecto"
        '
        'tpProductoD
        '
        Me.tpProductoD.BackColor = System.Drawing.SystemColors.Control
        Me.tpProductoD.Controls.Add(Me.mtbPrecioNuevo)
        Me.tpProductoD.Controls.Add(Me.Label6)
        Me.tpProductoD.Controls.Add(Me.btnGrabarProducto)
        Me.tpProductoD.Controls.Add(Me.Label2)
        Me.tpProductoD.Controls.Add(Me.cbProveedor)
        Me.tpProductoD.Controls.Add(Me.Label3)
        Me.tpProductoD.Controls.Add(Me.tbProveedor)
        Me.tpProductoD.Controls.Add(Me.tbDescripcionProducto)
        Me.tpProductoD.Controls.Add(Me.Label4)
        Me.tpProductoD.Controls.Add(Me.cbUnidadMedida)
        Me.tpProductoD.Location = New System.Drawing.Point(4, 24)
        Me.tpProductoD.Name = "tpProductoD"
        Me.tpProductoD.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProductoD.Size = New System.Drawing.Size(339, 574)
        Me.tpProductoD.TabIndex = 1
        Me.tpProductoD.Text = "Producto Descatalogado"
        '
        'tpModificarPartida
        '
        Me.tpModificarPartida.BackColor = System.Drawing.SystemColors.Control
        Me.tpModificarPartida.Controls.Add(Me.btnModificarPartida)
        Me.tpModificarPartida.Controls.Add(Me.lblUMedidaM)
        Me.tpModificarPartida.Controls.Add(Me.mtbPrecioUnitarioM)
        Me.tpModificarPartida.Controls.Add(Me.lblDescProcuctoM)
        Me.tpModificarPartida.Controls.Add(Me.mtbCantidadM)
        Me.tpModificarPartida.Controls.Add(Me.Label22)
        Me.tpModificarPartida.Controls.Add(Me.Label23)
        Me.tpModificarPartida.Location = New System.Drawing.Point(4, 24)
        Me.tpModificarPartida.Name = "tpModificarPartida"
        Me.tpModificarPartida.Size = New System.Drawing.Size(339, 574)
        Me.tpModificarPartida.TabIndex = 2
        Me.tpModificarPartida.Text = "Modificación de partida"
        '
        'tpRepetirCotizacion
        '
        Me.tpRepetirCotizacion.BackColor = System.Drawing.SystemColors.Control
        Me.tpRepetirCotizacion.Controls.Add(Me.btnRegresar)
        Me.tpRepetirCotizacion.Controls.Add(Me.btnSeleccionarCotizacionFuente)
        Me.tpRepetirCotizacion.Controls.Add(Me.dgvPartidasAnteriores)
        Me.tpRepetirCotizacion.Controls.Add(Me.dgvCotizacionesAnteriores)
        Me.tpRepetirCotizacion.Controls.Add(Me.tbClienteCotizacionAnterior)
        Me.tpRepetirCotizacion.Controls.Add(Me.cbClienteCotizacionAnterior)
        Me.tpRepetirCotizacion.Controls.Add(Me.Label24)
        Me.tpRepetirCotizacion.Location = New System.Drawing.Point(4, 24)
        Me.tpRepetirCotizacion.Name = "tpRepetirCotizacion"
        Me.tpRepetirCotizacion.Size = New System.Drawing.Size(339, 574)
        Me.tpRepetirCotizacion.TabIndex = 3
        Me.tpRepetirCotizacion.Text = "Seleccione la Cotización"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(183, 538)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(94, 29)
        Me.btnRegresar.TabIndex = 806
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCotizacionFuente
        '
        Me.btnSeleccionarCotizacionFuente.Location = New System.Drawing.Point(73, 538)
        Me.btnSeleccionarCotizacionFuente.Name = "btnSeleccionarCotizacionFuente"
        Me.btnSeleccionarCotizacionFuente.Size = New System.Drawing.Size(94, 29)
        Me.btnSeleccionarCotizacionFuente.TabIndex = 805
        Me.btnSeleccionarCotizacionFuente.Text = "Seleccionar"
        Me.btnSeleccionarCotizacionFuente.UseVisualStyleBackColor = True
        '
        'dgvPartidasAnteriores
        '
        Me.dgvPartidasAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartidasAnteriores.Location = New System.Drawing.Point(8, 229)
        Me.dgvPartidasAnteriores.Name = "dgvPartidasAnteriores"
        Me.dgvPartidasAnteriores.Size = New System.Drawing.Size(319, 303)
        Me.dgvPartidasAnteriores.TabIndex = 804
        '
        'dgvCotizacionesAnteriores
        '
        Me.dgvCotizacionesAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCotizacionesAnteriores.Location = New System.Drawing.Point(8, 74)
        Me.dgvCotizacionesAnteriores.Name = "dgvCotizacionesAnteriores"
        Me.dgvCotizacionesAnteriores.Size = New System.Drawing.Size(321, 149)
        Me.dgvCotizacionesAnteriores.TabIndex = 803
        '
        'tbClienteCotizacionAnterior
        '
        Me.tbClienteCotizacionAnterior.Location = New System.Drawing.Point(66, 9)
        Me.tbClienteCotizacionAnterior.Name = "tbClienteCotizacionAnterior"
        Me.tbClienteCotizacionAnterior.Size = New System.Drawing.Size(262, 21)
        Me.tbClienteCotizacionAnterior.TabIndex = 800
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 14)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 15)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Cliente"
        '
        'Cotizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 620)
        Me.Controls.Add(Me.tcApoyos)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.gbTodo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cotizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Elaborar una Cotizacion Nueva"
        Me.gbProductos.ResumeLayout(False)
        Me.gbProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.gbTodo.ResumeLayout(False)
        Me.gbEmpresa.ResumeLayout(False)
        Me.tcApoyos.ResumeLayout(False)
        Me.tpClienteD.ResumeLayout(False)
        Me.tpClienteD.PerformLayout()
        Me.tpProductoD.ResumeLayout(False)
        Me.tpProductoD.PerformLayout()
        Me.tpModificarPartida.ResumeLayout(False)
        Me.tpModificarPartida.PerformLayout()
        Me.tpRepetirCotizacion.ResumeLayout(False)
        Me.tpRepetirCotizacion.PerformLayout()
        CType(Me.dgvPartidasAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCotizacionesAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnGrabarCotizacion As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbReferenciaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbTodo As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents btnAaron As System.Windows.Forms.Button
    Friend WithEvents btnQuart As System.Windows.Forms.Button
    Friend WithEvents tbProducto As System.Windows.Forms.TextBox
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents mtbPrecioNuevo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGrabarProducto As System.Windows.Forms.Button
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents tbDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbRazonSocialD As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbDomicilioD As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbEstadoD As System.Windows.Forms.TextBox
    Friend WithEvents tbMunicipioD As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbColoniaD As System.Windows.Forms.TextBox
    Friend WithEvents tbTel2D As System.Windows.Forms.TextBox
    Friend WithEvents tbTel1D As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbCorreoD As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnGrabarClienteD As System.Windows.Forms.Button
    Friend WithEvents tbContactoD As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnModificarPartida As System.Windows.Forms.Button
    Friend WithEvents mtbPrecioUnitarioM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCantidadM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblUMedidaM As System.Windows.Forms.Label
    Friend WithEvents btnCancelaProductoNoCatalogado As System.Windows.Forms.Button
    Friend WithEvents chkAgregarIVA As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents tTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblDescProcuctoM As System.Windows.Forms.TextBox
    Friend WithEvents btnUltimaCotizacion As System.Windows.Forms.Button
    Friend WithEvents tcApoyos As System.Windows.Forms.TabControl
    Friend WithEvents tpClienteD As System.Windows.Forms.TabPage
    Friend WithEvents tpProductoD As System.Windows.Forms.TabPage
    Friend WithEvents tpModificarPartida As System.Windows.Forms.TabPage
    Friend WithEvents tpRepetirCotizacion As System.Windows.Forms.TabPage
    Friend WithEvents btnSeleccionarCotizacionFuente As System.Windows.Forms.Button
    Friend WithEvents dgvPartidasAnteriores As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCotizacionesAnteriores As System.Windows.Forms.DataGridView
    Friend WithEvents tbClienteCotizacionAnterior As System.Windows.Forms.TextBox
    Friend WithEvents cbClienteCotizacionAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
