Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports QuartOK.ProcedimientosGenerales

Public Class VentaMostrador

#Region "Variables"

    Dim lblPartida() As Label
    Dim cmbProducto() As ComboBox
    Dim cmbUnidadMedida() As ComboBox
    Dim mtbCantidad() As MaskedTextBox
    Dim mtbPrecioUnitario() As MaskedTextBox

    Friend WithEvents btnSiguiente As Button
    Dim btnOtro() As Button

    Dim VariacionRenglon As Integer = 30
    Dim xInicial As Integer
    Dim yInicial As Integer

    Dim intContadorPartidas As Integer
    Dim intCliente As Integer = 0
    Dim intTipoCliente As Integer = 0
    Dim intProducto As Integer = 0
    Dim intUnidadMedida As Integer
    Dim decCantidad As Decimal
    Dim decPrecioUnitario As Decimal
    Dim decTotal As Decimal

    Dim intEmpresa As Integer = 0
    Dim intRenglonModificar As Integer = 0

    Dim strCatProdQuart As String = ""
    Dim strClienteQuart As String

    Dim intAgregarIVA As Integer

    Dim intCotizacionFuente As Integer
#End Region

#Region "Iniciar Formato"

    Private Sub Compra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbTodo.Enabled = False
        lblEmpresa.Text = ""
        lblEmpresa.Visible = False
        Iniciar()
    End Sub

    Private Sub TamañoGrandeForm()
        Me.Size = New System.Drawing.Size(1201, 589)
    End Sub

    Private Sub Iniciar()
        intContadorPartidas = 1
        dgvProductos.Visible = False

        IniciarVariablesUnicas()
        'IniciarVariablesRecurrentes()
        'CargarComboClientes()
        btnIniciarCompraDatagrid.Enabled = True
        dgvProductos.Rows.Clear()

        If dgvProductos.Columns.Count >= 1 Then
            Dim CantColumns As Integer = dgvProductos.Columns.Count - 1
            For i As Integer = CantColumns To 0 Step -1
                dgvProductos.Columns.RemoveAt(i)
            Next
        End If

        dgvProductos.DataSource = Nothing

        cbCliente.DataSource = Nothing
        tbReferenciaProveedor.Text = ""
        cbProducto.DataSource = Nothing


        tbObservaciones.Text = ""

        gbProveedor.Enabled = True
        tbCliente.Text = ""
        tbProducto.Text = ""
        tbCliente.Focus()
        TamañoInicialForm()

        chkIVA.Checked = False

        tbDomicilioEntrega.Text = ""
        tbObservaciones.Text = ""
        tbRecibioMercancia.Text = ""

    End Sub

    Private Sub IniciarVariablesUnicas()
        intCliente = 0
        intTipoCliente = 0
        decTotal = 0
        intContadorPartidas = 1
        gbProductos.Enabled = False
        gbProveedor.Enabled = True
        btnGenerarSalida.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub IniciarVariablesRecurrentes()
        intProducto = 0
        intUnidadMedida = 0
        decCantidad = 0
        decPrecioUnitario = 0
        mtbCant.Text = ""
        mtbPrecio.Text = ""
        'CargarComboProductos()
        cbProducto.Text = ""
        cbProducto.Focus()
    End Sub

    Private Sub VentaMostrador_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantVentaMostrador = False
    End Sub

    Private Sub TamañoInicialForm()
        Me.Size = New System.Drawing.Size(869, 592)
        Me.Update()
    End Sub

    Private Sub CrecerForm()
        Me.Size = New System.Drawing.Size(869, 705)
    End Sub

#End Region

#Region "Clientes"

    Private Sub CargarComboClientes()
        Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes order by strRazonSocialCliente "
        LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.DataSource IsNot Nothing Then
            intCliente = DirectCast(cbCliente.SelectedItem, DataRowView).Item("IDCliente")
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente, IdTipoCliente, IDClienteQuart  FROM tblCatClientes  where IDCliente = " & intCliente
            Dim dsTipo As New DataSet
            dsTipo = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            intTipoCliente = dsTipo.Tables(0).Rows(0).Item(2)
            strClienteQuart = dsTipo.Tables(0).Rows(0).Item(3)
            cbCliente.DroppedDown = False
        End If
    End Sub

    Private Sub cbCliente_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbCliente.KeyUp
        Dim intLargo As Integer = Len(cbCliente.Text)
        If intLargo > 4 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & cbCliente.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub chkIVA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIVA.CheckedChanged
        If chkIVA.Checked = True Then
            intAgregarIVA = 1
        Else
            intAgregarIVA = 0
        End If
    End Sub

    Private Sub tbCliente_Click(sender As Object, e As System.EventArgs) Handles tbCliente.Click

    End Sub

    Private Sub tbCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbCliente.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbReferenciaProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbReferenciaProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "DataGrid Ventas"

    Private Sub btnIniciarCompraDatagrid_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciarCompraDatagrid.Click
        If intCliente > 0 Then
            PreparaDatagridPartidas()
        Else
            MessageBox.Show("Debe elegir un cliente")
        End If

    End Sub

    Private Sub PreparaDatagridPartidas()
        dgvProductos.RowHeadersVisible = False
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeRows = False

        dgvProductos.AllowUserToResizeColumns = True
        dgvProductos.AllowUserToOrderColumns = False
        dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically

        dgvProductos.Columns.Add("Partida", "Partida")
        dgvProductos.Columns.Add("Producto", "Producto")
        dgvProductos.Columns.Add("UnidadMedida", "U.M.")
        dgvProductos.Columns.Add("Cantidad", "Cantidad")
        dgvProductos.Columns.Add("Precio", "P. Unitario")
        dgvProductos.Columns.Add("IdProd", "")
        dgvProductos.Columns.Add("IdUM", "")
        '...
        dgvProductos.Columns.Add("Cancela", "Cancelar Partida")
        dgvProductos.Columns.Add("Modifica", "Modificar Partida")
        dgvProductos.Columns.Add("PrecioValor", "")

        dgvProductos.Columns(0).Width = 50
        dgvProductos.Columns(1).Width = 400
        dgvProductos.Columns(2).Width = 60

        dgvProductos.Columns(3).Width = 60
        dgvProductos.Columns(4).Width = 60
        dgvProductos.Columns(5).Width = 0
        dgvProductos.Columns(6).Width = 0
        '...
        dgvProductos.Columns(7).Width = 100
        dgvProductos.Columns(8).Width = 100
        dgvProductos.Columns(9).Width = 0

        dgvProductos.Visible = True
        btnIniciarCompraDatagrid.Enabled = False
        btnPrecotizado.Enabled = False

        lblNumPartida.Text = intContadorPartidas
        intContadorPartidas = intContadorPartidas + 1
        'dgvCompras.Rows.Add()
        gbProductos.Enabled = True
        gbProveedor.Enabled = False

        btnGenerarSalida.Enabled = True
        btnCancelar.Enabled = True

        IniciarVariablesRecurrentes()
        tbProducto.Focus()
    End Sub

    Private Sub dgvProductos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Dim intColumna As Integer
        intColumna = e.ColumnIndex
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            If intColumna = 7 Then
                Dim respuesta As Integer
                respuesta = _
                MessageBox.Show("Desea cancelar la partida " & intRenglon + 1 & " ?", "Cancelar partida", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If respuesta = 6 Then
                    'iniciar proceso de cancelacion de partida (eliminar renglon en el datagrid)
                    dgvProductos.Rows.RemoveAt(intRenglon)
                    'reordenar columna de partidas
                    For i As Integer = 0 To dgvProductos.Rows.Count - 1
                        Dim suma As Integer
                        suma = i + 1
                        dgvProductos.Rows(i).Cells(0).Value = suma.ToString
                    Next
                    lblNumPartida.Text = dgvProductos.Rows.Count + 1
                    intContadorPartidas = dgvProductos.Rows.Count + 2
                End If

            ElseIf intColumna = 8 Then
                gbTodo.Enabled = False
                tcApoyos.Enabled = True
                tpModificarPartida.Parent = tcApoyos
                tpRepetirCotizacion.Parent = Nothing
                'gbProductoD.Visible = False
                TamañoGrandeForm()
                lblDescProcuctoM.Text = dgvProductos.Rows(intRenglon).Cells(1).Value
                lblUMedidaM.Text = dgvProductos.Rows(intRenglon).Cells(2).Value
                mtbCantidadM.Text = dgvProductos.Rows(intRenglon).Cells(3).Value
                mtbPrecioUnitarioM.Text = dgvProductos.Rows(intRenglon).Cells(4).Value
                intRenglonModificar = intRenglon
                mtbCantidadM.Focus()
            End If
        End If

    End Sub

#End Region

#Region "Partidas"

    Private Sub CargarComboProductos()
        Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto FROM tblCatProductos  where intTipoProducto >= 2 order by strDescripcionProducto"
        LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
    End Sub

    Private Sub cbProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            intProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            CargarComboUnidadMedida()
        End If
    End Sub

    Private Sub CargarComboUnidadMedida()
        Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where intVarControlProductos = 1 and IDProducto = " & intProducto & " Order by strUnidadMedida "
        LlenarCombo(strqry, cbUM, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbUM_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUM.SelectedValueChanged
        If cbUM.DataSource IsNot Nothing Then
            intUnidadMedida = DirectCast(cbUM.SelectedItem, DataRowView).Item("IDUnidadMedida")
            Dim strqry As String = "SELECT strCampo FROM tblCampoDescuento WHERE IDTipoCliente = " & intTipoCliente
            Dim dsNivel As New DataSet
            dsNivel = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            Dim strNivel As String = dsNivel.Tables(0).Rows(0).Item(0).ToString
            strqry = " SELECT " & strNivel & " FROM vstListaPrecios WHERE IDProducto = " & intProducto & _
                " AND IDUnidadMedida = " & intUnidadMedida & " AND intVarControlProductos = 1 "
            Dim dsPrecio As New DataSet
            dsPrecio = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            mtbPrecio.Text = Format(dsPrecio.Tables(0).Rows(0).Item(0), "##,##0.00")


        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If intProducto > 0 And mtbCant.Text > "" Then
            Dim PrecioValor As Decimal = Decimal.Parse(mtbPrecio.Text)

            dgvProductos.Rows.Add(lblNumPartida.Text, cbProducto.Text, cbUM.Text, mtbCant.Text, mtbPrecio.Text, intProducto, intUnidadMedida, "Cancelar Partida", "Modificar Partida", PrecioValor)
            lblNumPartida.Text = intContadorPartidas
            intContadorPartidas = intContadorPartidas + 1
            IniciarVariablesRecurrentes()
        Else
            MessageBox.Show("Debe elegir un producto y una cantidad")
        End If
    End Sub

    Private Sub cbProducto_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbProducto.KeyUp
        Dim intLargo As Integer = Len(cbProducto.Text)
        If intLargo > 4 Then
            ' Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & cbCliente.Text & "%' order by strRazonSocialCliente "
            ' LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto FROM tblCatProductos  where intTipoProducto >= 2 and strDescripcionProducto like '%" & cbProducto.Text & "%'  order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
            cbProducto.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub tbCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbCliente.TextChanged
        Dim intLargo As Integer = Len(tbCliente.Text)
        If intLargo >= 3 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & tbCliente.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbCliente.DroppedDown = False
            cbCliente.DataSource = Nothing
            cbCliente.Items.Clear()
        End If
    End Sub

    Private Sub mtbPrecio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbPrecio.Enter
        If (Not String.IsNullOrEmpty(mtbPrecio.Text)) Then
            mtbPrecio.SelectionStart = 0
            mtbPrecio.SelectionLength = mtbPrecio.Text.Length
        End If
    End Sub

    Private Sub tbProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProducto.TextChanged
        Dim intLargo As Integer = Len(tbProducto.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where intTipoProducto >= 2 and strDescripcionProducto like '%" & tbProducto.Text & "%'  order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "Producto")
            cbProducto.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then

            cbProducto.DroppedDown = False
            cbProducto.DataSource = Nothing
            cbProducto.Items.Clear()
        End If
    End Sub

    Private Sub tbProducto_Click(sender As System.Object, e As System.EventArgs) Handles tbProducto.Click
        tbProducto.Text = ""
        'cbProducto.Items.Clear()
        tbProducto.Focus()
        strCatProdQuart = ""
    End Sub

    Private Sub tbProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub mtbCant_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbCant.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCant.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecio_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecio.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecio.Text & CChar(eventArgs.KeyChar))
    End Sub

#End Region

#Region "Procesos sin uso"

    Private Sub btnProductoNuevo_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("En esta parte aparecera la ventana de alta de productos," & _
                        " seleccionando previamente al proovedor que se selecciono en al parte superior", "Desarrollo pendiente de Marcelo")
    End Sub

    Private Sub btnGrabarCotizacion_Click(sender As System.Object, e As System.EventArgs)
        Me.Enabled = False

        'Insertamos la cotizacion
        Dim strqry As String = ""
        Dim strdtFechaCompra As String
        strdtFechaCompra = Format(dtFechaCompra.Value, "dd/MM/yyyy")

        strqry = " INSERT INTO tblListaCotizaciones (IDCliente,dtFechaIngresoSistema,strReferenciaCliente, intUsuarioVenta, intEmpresa) VALUES (" & intCliente & ", '" & strdtFechaCompra & "', '" &
                        tbReferenciaProveedor.Text & "', " & ProcedimientosGenerales.intUsuario & ", " & intEmpresa & ")"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If IDCompra = 0 Then

            System.Threading.Thread.Sleep(100)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            'Ya insertada la compra traemos su identity para usarlo en las transacciones
            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1
                'grabamos la transaccion, una por una...
                strqry = "INSERT INTO tblTransaccionesCotizaciones(idCotizacion,intPartida,IDProducto,Cantidad,PKUnidadMedida,PrecioUnitario) VALUES (" &
                            IDCompra & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value &
                            ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & dgvProductos.Rows(i).Cells(6).Value & ", " & dgvProductos.Rows(i).Cells(9).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                Me.Refresh()
                System.Threading.Thread.Sleep(100)
                Me.Refresh()
            Next
            ImprimirCotizacion(IDCompra)
        End If
        System.Threading.Thread.Sleep(100)
        ' MessageBox.Show("Realizar el proceso de impresion de la entrada a almacén")
        Me.Enabled = True
        ProcedimientosGenerales.GrabarAccion(3, IDCompra)
        Iniciar()
    End Sub

    Public Sub ImprimirCotizacion(ByRef IdCotizacion As Long)

        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT    intPartida, Cantidad, strUnidadMedida, strDescripcionProducto, PrecioUnitario, intConsecutivo, idCotizacion, strNombreCliente, strDomicilio, strColonia, " &
                                " strMunicipio, strEstado, strTelefono1, strTelefono2, strCorreoElectronico, strRFC, strNombreContacto, strObservaciones, strDomicilioAlmacen, " &
                                " dtFechaIngresoSistema, strReferenciaCliente, strRFCEmpresa, strRazonSocialEmpresa, strNombreUsuario FROM vstPartidasCotizadas WHERE idCotizacion = " & IdCotizacion & " order by  intPartida   "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New rptCotizar

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        frm.VisorCrystalReport.Visible = True
        frm.Text = "Cotización"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub

#End Region

#Region "Botones adicionales"

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

    Private Sub btnCancelarTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarTodo.Click
        Iniciar()
    End Sub

    Private Sub btnGenerarSalida_Click(sender As Object, e As EventArgs) Handles btnGenerarSalida.Click
        'aqui se evaluara si este XML ya fue cargado anteriormente en otro momento, para evitar que se dupliquen las salidas
        CrecerForm()
        gbTodo.Enabled = False
        Dim strqry As String
        strqry = "SELECT strDomicilioAlmacen FROM tblCatClientes where IDCliente = " & intCliente & ""
        Dim dsCliente As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        tbDomicilioEntrega.Text = dsCliente.Tables(0).Rows(0)(0).ToString
        'Se genera la orden de salida (en Transacciones de venta) y sus facturas.
        'ampliar en el formato el area de comentarios adicionales 

    End Sub

    Private Sub tbDomicilioEntrega_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDomicilioEntrega.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbObservaciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbObservaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbRecibioMercancia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbRecibioMercancia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "Grabas Venta e Imprimirla"

    Private Sub btnGrabarOrdenSalida_Click(sender As Object, e As EventArgs) Handles btnGrabarOrdenSalida.Click





        If tbRecibioMercancia.Text = "" Then
            MessageBox.Show("Debe indicar que persora recibirá la mercancía.", "Faltan datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbRecibioMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False
        Dim strqry As String
        'strqry = "SELECT IDCliente FROM tblCatClientes WHERE strRFC = '" & strReceptorRFC & "'"
        'Dim dsClientes As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        'Dim intCliente As Integer = Integer.Parse(dsClientes.Tables(0).Rows(0)(0).ToString)
        'dsClientes.Dispose()
        strqry = "INSERT INTO tblListaVentas (IDCliente,strIdFactura,dtFechaVentaXML, strDomicilioEntrega,strObservaciones, intUsuarioVenta, intEmpresa, intAgregarIVA, strRecibioMercancia) VALUES (" &
                    intCliente & ", '" & tbReferenciaProveedor.Text & "', '" & Microsoft.VisualBasic.Left(dtFechaCompra.Value, 10) &
                    "', '" & tbDomicilioEntrega.Text & "', '" & tbObservaciones.Text & "', " & ProcedimientosGenerales.intUsuario & "," & intEmpresa & ", " & intAgregarIVA & ", '" & tbRecibioMercancia.Text & "' )"            'int de usuario al final
        Dim InserteOk As Integer = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al crear la Orden de Salida.")
        If InserteOk = 0 Then
            MsgBox("No se genero la orden de salida Correctamente")
            Me.Enabled = True
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(9, InserteOk)
            Dim PartidasCorrectas As Boolean = True
            'insertar transacciones de la aplicacion
            Dim TotalVenta As Decimal = 0

            'Nota IVA segun producto ***************
            'se agrega esta variable decimal, para acumular el IVA de cada partida
            Dim decIVAAcumulado As Decimal = 0.0
            '***************************************

            For i = 0 To dgvProductos.RowCount - 1
                'obtenemos el nuemro de id de la Unidad de medida
                Dim intUniMed As Integer
                strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
                Dim dsUM As New DataSet
                dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al obtener Unidad de Medida")
                intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

                'Nota IVA segun producto ***************
                'creamos la variable si aplica iav o no
                Dim intAplicaIVA As Integer = 1
                ' en este for, leer de la tabla lista de productos una nueva columna (AplicaIVA)
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where idProducto = " & dgvProductos.Rows(i).Cells(5).Value
                'Cambiar el 100 por la columna donde esta el IdProducto
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "Tabla", "Error al consultar si aplica IVA")

                'los valores deben de ser 1 cuando si aplica (Valor por omision)
                'o cero (0) cuando no aplica
                'tomamos ese valor y lo guardamos en la siguiente variable
                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)
                '***************************************
                Dim precio As Decimal
                precio = dgvProductos.Rows(i).Cells(9).Value
                Dim Cantidad As Decimal
                Cantidad = Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value)
                Dim Importe As Decimal
                Importe = precio * Cantidad
                TotalVenta = TotalVenta + Decimal.Round(Importe, 2)

                'Nota IVA segun producto ***************
                'ahora tomamos el iva que pudiese haber causado este articulo
                'y lo multiplicamos por el valor de intAplicaIVA
                Dim decIVAArticulo As Decimal = 0
                Dim decIVAArt As Decimal = Importe * 0.16 * intAplicaIVA
                decIVAArticulo = Decimal.Round(decIVAArt, 2)

                'y nos llevamo el agregado de IVA a la variable final
                decIVAAcumulado = decIVAAcumulado + decIVAArticulo
                '****************************************************


                strqry = "INSERT INTO tblTransaccionesVenta (idVenta,intPartida,IDProducto,Cantidad,PKUnidadMedida,PrecioUnitario) VALUES (" &
                    InserteOk & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value & ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & intUniMed &
                    ", " & precio & ")"

                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar Partida.")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                    PartidasCorrectas = False
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
            Next


            If PartidasCorrectas = True Then
                Dim IVA, Total As Decimal
                Dim TotalLetra As String
                'Nota IVA segun producto ***************
                'Comentamos la siguiente linea
                'Dim IVACalculo As Decimal = TotalVenta * 0.16 * intAgregarIVA
                'y volvemos a definir la variable, ahora con este nuevo valor
                Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA
                'se deja el agregar IVA ya que ese valor es que indica si es iva incluido o no, 
                'y ahora se acumula el IVA de cada producto en IVAAcumulado
                '*************************************

                IVA = Decimal.Round(IVACalculo, 2)
                Dim TotalCalculo As Decimal = TotalVenta + IVA
                Total = Decimal.Round(TotalCalculo, 2)
                TotalLetra = Letras(Format(Total, "####.00"))

                Dim strLeyendaIVA, strLeyendaSubTotal, strLeyendaTotal, strIVA, strTotal As String
                If intAgregarIVA = 1 Then
                    strLeyendaIVA = " IVA 16% "
                    strLeyendaSubTotal = " Sub-Total"
                    strLeyendaTotal = "Total"
                    strIVA = Format(IVA, "$#,##0.00")
                    strTotal = Format(Total, "$#,##0.00")
                Else
                    strLeyendaIVA = ""
                    strLeyendaSubTotal = "Total"
                    strLeyendaTotal = ""
                    strIVA = ""
                    strTotal = ""
                End If

                strqry = "UPDATE tblListaVentas SET MontoAntesIVA = " & TotalVenta &
                        ", Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " &
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " &
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal &
                        "' WHERE idVenta = " & InserteOk
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al grabar Monto Total de la Venta")

                MsgBox("Orden de salida de almacen generada correctamente. A continuación se generará la Remisión.")
                GenerarRemision(InserteOk, True)
            Else
                MsgBox("No se pudieron ingresar todas las partidas. Revise en el listado de ordenes de salida")
            End If
        End If

        TamañoInicialForm()
        Iniciar()
        Me.Enabled = True
        gbTodo.Enabled = True

    End Sub

    Public Sub GenerarRemision(ByRef intVenta As Integer, Optional ByRef boolActivaExport As Boolean = True)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT * FROM vstTransaccionesVenta WHERE idVenta = " & intVenta & " order by  intPartida   "

        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New rptRemision

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        frm.VisorCrystalReport.Visible = True
        frm.Text = "Nota de Remisión"
        'Para indicar que solo exportara a PDF
        frm.VisorCrystalReport.AllowedExportFormats = ExportFormatType.PortableDocFormat
        If boolActivaExport = False Then
            frm.VisorCrystalReport.ShowPrintButton = False
            frm.VisorCrystalReport.AllowedExportFormats = False
        Else
            frm.VisorCrystalReport.ShowPrintButton = True
            frm.VisorCrystalReport.AllowedExportFormats = True
        End If
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub

#End Region

#Region "Empresa"

    Private Sub btnQuart_Click(sender As System.Object, e As System.EventArgs) Handles btnQuart.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "QUART INDUSTRIA S.A. DE C.V."
        intEmpresa = 1
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbCliente.Focus()
    End Sub

    Private Sub btnAaron_Click(sender As System.Object, e As System.EventArgs) Handles btnAaron.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "AARON URDIALES GONZALEZ"
        intEmpresa = 2
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbCliente.Focus()
    End Sub

#End Region

#Region "Modificar partida"

    Private Sub btnModificarPartida_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarPartida.Click
        dgvProductos.Rows(intRenglonModificar).Cells(3).Value = mtbCantidadM.Text
        Dim precionuevo As Decimal
        precionuevo = Decimal.Parse(mtbPrecioUnitarioM.Text)
        dgvProductos.Rows(intRenglonModificar).Cells(4).Value = Format(precionuevo, "#,##0.00")
        dgvProductos.Rows(intRenglonModificar).Cells(9).Value = precionuevo
        TamañoInicialForm()
        intRenglonModificar = 0
        gbTodo.Enabled = True
        'gbModificarPartida.Enabled = False
    End Sub

    Private Sub mtbCantidadM_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        If (Not String.IsNullOrEmpty(mtbCantidadM.Text)) Then
            mtbCantidadM.SelectionStart = 0
            mtbCantidadM.SelectionLength = mtbCantidadM.Text.Length
        End If
    End Sub

    Private Sub mtbPrecioUnitarioM_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        If (Not String.IsNullOrEmpty(mtbPrecioUnitarioM.Text)) Then
            mtbPrecioUnitarioM.SelectionStart = 0
            mtbPrecioUnitarioM.SelectionLength = mtbPrecioUnitarioM.Text.Length
        End If
    End Sub

    Private Sub mtbCantidadM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCantidadM.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecioUnitarioM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecioUnitarioM.Text & CChar(eventArgs.KeyChar))
    End Sub

#End Region

#Region "Vista Previa"

    Private Sub btnVistaPrevia_Click(sender As System.Object, e As System.EventArgs) Handles btnVistaPrevia.Click
        If tbRecibioMercancia.Text = "" Then
            MessageBox.Show("Debe indicar que persora recibirá la mercancía.", "Faltan datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbRecibioMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False
        Dim strqry As String
        'strqry = "SELECT IDCliente FROM tblCatClientes WHERE strRFC = '" & strReceptorRFC & "'"
        'Dim dsClientes As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        'Dim intCliente As Integer = Integer.Parse(dsClientes.Tables(0).Rows(0)(0).ToString)
        'dsClientes.Dispose()
        strqry = "INSERT INTO tblListaVentasPrevia (IDCliente,strIdFactura,dtFechaVentaXML, strDomicilioEntrega,strObservaciones, intUsuarioVenta, intEmpresa, intAgregarIVA, strRecibioMercancia) VALUES (" &
                    intCliente & ", '" & tbReferenciaProveedor.Text & "', '" & Microsoft.VisualBasic.Left(dtFechaCompra.Value, 10) &
                    "', '" & tbDomicilioEntrega.Text & "', '" & tbObservaciones.Text & "', " & ProcedimientosGenerales.intUsuario & "," & intEmpresa & ", " & intAgregarIVA & ", '" & tbRecibioMercancia.Text & "' )"            'int de usuario al final
        Dim InserteOk As Integer = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al crear la Orden de Salida.")
        If InserteOk = 0 Then
            MsgBox("No se genero la orden de salida Correctamente")
            Me.Enabled = True
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(9, InserteOk)
            Dim PartidasCorrectas As Boolean = True
            'insertar transacciones de la aplicacion
            Dim TotalVenta As Decimal = 0
            Dim decIVAAcumulado As Decimal = 0.0
            For i = 0 To dgvProductos.RowCount - 1

                Dim intAplicaIVA As Integer = 1
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where idProducto = " & dgvProductos.Rows(i).Cells(5).Value
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "Tabla", "Error al consultar si aplica IVA")


                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)

                'obtenemos el nuemro de id de la Unidad de medida
                Dim intUniMed As Integer
                strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
                Dim dsUM As New DataSet
                dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al obtener Unidad de Medida")
                intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

                Dim precio As Decimal
                precio = dgvProductos.Rows(i).Cells(9).Value
                Dim Cantidad As Decimal
                Cantidad = Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value)
                Dim Importe As Decimal
                Importe = precio * Cantidad
                TotalVenta = TotalVenta + Decimal.Round(Importe, 2)

                Dim decIVAArticulo As Decimal = 0
                Dim decIVAArt As Decimal = Importe * 0.16 * intAplicaIVA
                decIVAArticulo = Decimal.Round(decIVAArt, 2)
                decIVAAcumulado = decIVAAcumulado + decIVAArticulo


                strqry = "INSERT INTO tblTransaccionesVentaPrevia (idVenta,intPartida,IDProducto,Cantidad,PKUnidadMedida,PrecioUnitario) VALUES (" &
                    InserteOk & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value & ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & intUniMed &
                    ", " & precio & ")"

                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar Partida.")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                    PartidasCorrectas = False
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
            Next


            If PartidasCorrectas = True Then
                Dim IVA, Total As Decimal
                Dim TotalLetra As String
                'Dim IVACalculo As Decimal = TotalVenta * 0.16 * intAgregarIVA
                Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA
                IVA = Decimal.Round(IVACalculo, 2)
                Dim TotalCalculo As Decimal = TotalVenta + IVA
                Total = Decimal.Round(TotalCalculo, 2)
                TotalLetra = Letras(Format(Total, "####.00"))

                Dim strLeyendaIVA, strLeyendaSubTotal, strLeyendaTotal, strIVA, strTotal As String
                If intAgregarIVA = 1 Then
                    strLeyendaIVA = " IVA 16% "
                    strLeyendaSubTotal = " Sub-Total"
                    strLeyendaTotal = "Total"
                    strIVA = Format(IVA, "$#,##0.00")
                    strTotal = Format(Total, "$#,##0.00")
                Else
                    strLeyendaIVA = ""
                    strLeyendaSubTotal = "Total"
                    strLeyendaTotal = ""
                    strIVA = ""
                    strTotal = ""
                End If

                strqry = "UPDATE tblListaVentasPrevia SET MontoAntesIVA = " & TotalVenta & _
                        ", Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " & _
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " & _
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal & _
                        "' WHERE idVenta = " & InserteOk
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al grabar Monto Total de la Venta")

                'MsgBox("Orden de salida de almacen generada correctamente. A continuación se generará la Remisión.")
                GenerarRemisionPrevia(InserteOk)
            Else
                MsgBox("No se pudieron ingresar todas las partidas. Revise en el listado de ordenes de salida")
            End If
        End If

        'TamañoInicialForm()

        Me.Enabled = True
        gbTodo.Enabled = True
    End Sub

    Public Sub GenerarRemisionPrevia(ByRef intVenta As Integer)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT * FROM vstTransaccionesVentaPrevia WHERE idVenta = " & intVenta & " order by  intPartida   "

        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New rptRemisionPrevia

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        If frmLogin.intServer = 3 Then
            frm.VisorCrystalReport.ShowPrintButton = False
            frm.VisorCrystalReport.AllowedExportFormats = False
        Else
            frm.VisorCrystalReport.ShowPrintButton = True
            frm.VisorCrystalReport.AllowedExportFormats = True
        End If

        frm.VisorCrystalReport.Visible = True

        frm.Text = "Vista Precia de Venta de Mostrador"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub
#End Region

#Region "Cotizacion Previa"

    Private Sub btnPrecotizado_Click(sender As System.Object, e As System.EventArgs) Handles btnPrecotizado.Click
        gbTodo.Enabled = False

        tcApoyos.Enabled = True
        tpModificarPartida.Parent = Nothing
        tpRepetirCotizacion.Parent = tcApoyos

        tbClienteCotizacionAnterior.Text = cbCliente.Text
        tbCliente.Enabled = False
        LimpiarDatagrid(dgvCotizacionesAnteriores)
        PrepararDGV(dgvCotizacionesAnteriores)

        Dim strqry As String = "SELECT top 15 idCotizacion as [Num Cotización], dtFechaIngresoSistema as [Fecha Cotización], " & _
                                    "  strNombreUsuario as Vendedor FROM  vstCotizaciones  where IDCliente = " & intCliente & _
                                    " order by idCotizacion desc "
        LlenarDataGrid(strqry, dgvCotizacionesAnteriores)
        intCotizacionFuente = 0
        TamañoGrandeForm()
    End Sub

    Private Sub LimpiarDatagrid(ByRef NombreDataGrid As DataGridView)
        NombreDataGrid.DataSource = Nothing
        NombreDataGrid.Rows.Clear()
        NombreDataGrid.Columns.Clear()
    End Sub

    Private Sub dgvCotizacionesAnteriores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCotizacionesAnteriores.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intCotizacionFuente = dgvCotizacionesAnteriores.Rows(intRenglon).Cells(0).Value
            LlenardgvPartidas(intCotizacionFuente)
        End If
    End Sub

    Private Sub LlenardgvPartidas(ByRef intCotizacion As Integer)

        PrepararDGV(dgvPartidasAnteriores)
        Dim strqry As String = "SELECT strUnidadMedida as [U/M], strDescripcionProducto as Producto, " & _
                                "PrecioUnitario  as [Precio Unitario] FROM vstPartidasCotizadas  where idCotizacion = " & intCotizacion & _
                                " ORDER BY intPartida"
        LlenarDataGrid(strqry, dgvPartidasAnteriores)
    End Sub

    Private Sub btnSeleccionarCotizacionFuente_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarCotizacionFuente.Click
        If intCotizacionFuente = 0 Then
            MessageBox.Show("Debe seleccionar una cotizacion")
            Exit Sub
        End If
        PreparaDatagridPartidas()
        CargarCotizacionFuente(intCotizacionFuente)
    End Sub

    Private Sub CargarCotizacionFuente(ByRef intCotizacionAnterior As Integer)

        Dim strqry As String
        strqry = "SELECT intPartida, strDescripcionProducto, strUnidadMedida, Cantidad, PrecioUnitario, " & _
            "IDProducto, IDUnidadMedida, 'Cancelar Partida', 'Modificar Partida', PrecioUnitario from vstPartidasCotizadas " & _
            " where idCotizacion = " & intCotizacionAnterior & " order by intPartida"
        Dim dsPartidas As New DataSet
        dsPartidas = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "No se obtuvieron las partidas de la cotización anterior")
        Dim renglones As Integer = dsPartidas.Tables(0).Rows.Count
        For i As Integer = 0 To renglones - 1
            dgvProductos.Rows.Add(dsPartidas.Tables(0).Rows(i)(0).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(1).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(2).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(3).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(4).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(5).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(6).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(7).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(8).ToString, _
                                  dsPartidas.Tables(0).Rows(i)(9).ToString)
        Next
        lblNumPartida.Text = renglones + 1
        intContadorPartidas = renglones + 2
        IniciarVariablesRecurrentes()

        '---------------------
        gbTodo.Enabled = True
        TamañoInicialForm()

    End Sub

#End Region

    'Private Sub btnModificarPartida_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarPartida.Click

    'End Sub

End Class