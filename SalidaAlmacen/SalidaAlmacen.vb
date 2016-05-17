Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports QuartOK.ProcedimientosGenerales

Public Class SalidaAlamcen

#Region "Variables"
    Dim InteVentaSurtida As Integer
#End Region

#Region "Iniciar Formato"

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        LimpiarForm()
        CargarOrdenes()
    End Sub

    Private Sub LimpiarForm()
        dgvOrdenes.DataSource = Nothing
        dgvOrdenes.Rows.Clear()
        dgvOrdenes.Columns.Clear()
        PrepararDGV(dgvOrdenes)
        PrepararDGV(dgvProductos)
        btnAfectarInvetario.Enabled = False
        lblLugarEntrega.Text = ""
        lblObservaciones.Text = ""
        lblTelefonos.Text = ""
        lblContacto.Text = ""
        tbRecibeMercancia.Text = ""
        AjustarDGVOrdenes()
        AjustarDGVProductos()
    End Sub

    Private Sub SalidaAlamcen_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIPrincipal.PantSalidasAlmacen = False
    End Sub

    Private Sub SalidaAlamcen_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LimpiarForm()
        tbEntregaMercancía.Text = strNombreUsuario
        tbEntregaMercancía.Enabled = False
        CargarOrdenes()
    End Sub
#End Region

#Region "Cargar dgvListaOrdenes"

    Private Sub CargarOrdenes()
        Dim strqry As String
        strqry = "SELECT idVenta, strIdFactura, strNombreCliente, dtFechaVentaXML, dtFechaIngresoSistema from vstOrdenesSalida where intUsuarioOrdenSalida = 0 order by idVenta DESC"
        Dim dsOrdenes As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al Cargar Ordenes de Salida")
        If dsOrdenes.Tables(0).Rows.Count = 0 Then
            MsgBox("No hay ordenes pendientes de surtir")
        Else
            For i = 0 To dsOrdenes.Tables(0).Rows.Count - 1
                dgvOrdenes.Rows.Add(dsOrdenes.Tables(0).Rows(i)(0), dsOrdenes.Tables(0).Rows(i)(1), dsOrdenes.Tables(0).Rows(i)(2), _
                                    Format(dsOrdenes.Tables(0).Rows(i)(3), "dd/MMM/yyyy"), Format(dsOrdenes.Tables(0).Rows(i)(4), "dd/MMM/yyyy HH:MM"))
            Next
        End If
        lblPendientes.Text = "Ordenes pendientes de surtir: " & dsOrdenes.Tables(0).Rows.Count.ToString
        dsOrdenes.Dispose()
    End Sub

    Private Sub AjustarDGVOrdenes()

        'dgvProductos.RowHeadersVisible = False
        'dgvProductos.AllowUserToAddRows = False
        'dgvProductos.AllowUserToDeleteRows = False
        'dgvProductos.AllowUserToResizeRows = False
        'dgvProductos.AllowUserToResizeColumns = False
        'dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically

        dgvOrdenes.AllowUserToOrderColumns = False

        dgvOrdenes.Columns.Add("IdVenta", "Venta")
        dgvOrdenes.Columns.Add("strIdFactura", "Factura")
        dgvOrdenes.Columns.Add("strNombreCliente", "Cliente")
        dgvOrdenes.Columns.Add("dtFechaVentaXML", "Fecha de factura")
        dgvOrdenes.Columns.Add("dtFechaIngresoSistema", "Fecha Orden Salida")

        dgvOrdenes.Columns(0).Width = 55
        dgvOrdenes.Columns(1).Width = 100
        dgvOrdenes.Columns(2).Width = 450
        dgvOrdenes.Columns(3).Width = 200
        dgvOrdenes.Columns(4).Width = 200
    End Sub

    Private Sub dgvOrdenes_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenes.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            Dim intVenta As Integer
            intVenta = dgvOrdenes.Rows(intRenglon).Cells(0).Value
            LlenarDatosVenta(intVenta)
            btnAfectarInvetario.Enabled = True
        Else
            lblLugarEntrega.Text = ""
            lblObservaciones.Text = ""
            lblTelefonos.Text = ""
            lblContacto.Text = ""

            AjustarDGVProductos()
            btnAfectarInvetario.Enabled = False
        End If

    End Sub

    Private Sub LlenarDatosVenta(ByRef intVenta As Integer)
        lblLugarEntrega.Text = ""
        lblObservaciones.Text = ""
        lblTelefonos.Text = ""
        lblContacto.Text = ""

        AjustarDGVProductos()

        Dim strqry As String
        strqry = "SELECT strTelefono1,strTelefono2,strTelefono3,strCorreoElectronico,strNombreContacto,strDomicilioEntrega,strObservaciones " & _
            " FROM vstOrdenesSalida where idVenta = " & intVenta
        Dim dsDatos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        lblLugarEntrega.Text = dsDatos.Tables(0).Rows(0)(5).ToString
        lblObservaciones.Text = dsDatos.Tables(0).Rows(0)(6).ToString
        lblTelefonos.Text = dsDatos.Tables(0).Rows(0)(0).ToString & " / " & dsDatos.Tables(0).Rows(0)(1).ToString & " / " & dsDatos.Tables(0).Rows(0)(2).ToString
        lblContacto.Text = dsDatos.Tables(0).Rows(0)(4).ToString

        strqry = "SELECT intPartida,Cantidad,strUnidadMedida,IDProducto,strDescripcionProducto,PrecioUnitario FROM vstTransaccionesVenta " &
                    " WHERE idVenta = " & intVenta & " ORDER BY intPartida "
        Dim dsProductos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al Obtener las partidas de la Orden de Salida.")
        For i = 0 To dsProductos.Tables(0).Rows.Count - 1

            dgvProductos.Rows.Add(dsProductos.Tables(0).Rows(i)(0), dsProductos.Tables(0).Rows(i)(1), dsProductos.Tables(0).Rows(i)(2), dsProductos.Tables(0).Rows(i)(3),
                                  dsProductos.Tables(0).Rows(i)(4), dsProductos.Tables(0).Rows(i)(5))

        Next
        InteVentaSurtida = intVenta

    End Sub

#End Region

#Region "Cargar dgvPartidas"

    Private Sub AjustarDGVProductos()

        dgvProductos.DataSource = Nothing
        dgvProductos.Columns.Clear()
        dgvProductos.Rows.Clear()

        dgvProductos.AllowUserToOrderColumns = False

        dgvProductos.Columns.Add("Partida", "Partida")
        dgvProductos.Columns.Add("Cantidad", "Cantidad")
        dgvProductos.Columns.Add("UnidadMedida", "U.M.")
        dgvProductos.Columns.Add("IdProd", "Num. Producto")
        dgvProductos.Columns.Add("Producto", "Producto")
        dgvProductos.Columns.Add("Precio", "P. Unitario")
        'dgvProductos.Columns.Add("Importe", "Importe")
        'dgvProductos.Columns.Add("IdUM", "")
        ''...
        'dgvProductos.Columns.Add("Cancela", "Cancelar Partida")
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvProductos.Columns(0).Width = 60
        dgvProductos.Columns(1).Width = 60
        dgvProductos.Columns(2).Width = 80

        dgvProductos.Columns(3).Width = 0
        dgvProductos.Columns(4).Width = 400
        dgvProductos.Columns(5).Width = 120
        'dgvProductos.Columns(6).Width = 120
        '...
        'dgvProductos.Columns(7).Width = 120

        dgvProductos.Visible = True

    End Sub

#End Region

#Region "Afectar Inventarios e Imprimir Orden de Salida"

    Private Sub btnAfectarInvetario_Click(sender As System.Object, e As System.EventArgs) Handles btnAfectarInvetario.Click

        If tbRecibeMercancia.Text = "" Then
            MessageBox.Show("Debe indicar que persona recibe la mercancía para entregar al cliente.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbRecibeMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False

        Dim strqry As String = ""

        Dim dsVerifica As New DataSet
        strqry = "SELECT intVarControlVenta FROM tblListaVentas  WHERE idVenta = " & InteVentaSurtida
        dsVerifica = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "No se pudo verificar activación de la Venta")
        '--------------
        If dsVerifica.Tables(0).Rows(0)(0) = 1 Then

            Dim j As Integer
            Dim i As Integer
            Dim decCantAfectar As Double
            Dim intUniMed As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1

                Dim PrecioUnitario As Decimal
                PrecioUnitario = Decimal.Parse(dgvProductos.Rows(i).Cells(5).Value)

                'obtenemos el nuemro de id de la Unidad de medida
                strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
                Dim dsUM As New DataSet
                dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
                intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

                'hacemos el calculo del inventario
                strqry = "SELECT intCantidad, decPrecioVenta  from tblInventario where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value &
                            " and idUnidadMedida = " & intUniMed & "And intVarControlInventario = 1"            'evaluar la unidad de medida   dgvProductos.Rows(i).Cells(2).Value
                Dim dsExiste As New DataSet
                dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
                If dsExiste.Tables(0).Rows.Count = 0 Then
                    'se debe insertar la venta"
                    decCantAfectar = dgvProductos.Rows(i).Cells(1).Value * -1
                    strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad,decPrecioVenta) VALUES (" &
                                dgvProductos.Rows(i).Cells(3).Value & ", " & intUniMed &
                                ", " & decCantAfectar & ", " & PrecioUnitario & " ) "           'la afectacionde la unidad de medida debe de verificarse con su ID de Unidad de medida  dgvProductos.Rows(i).Cells(2).Value
                    j = 0
                    j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar la partida de salida.")
                    If j = 0 Then
                        'No se pudo grabar la partida en la tabla
                        dgvProductos.Item(1, i).Style.BackColor = Color.Red
                    Else
                        dgvProductos.Item(1, i).Style.BackColor = Color.Green
                    End If
                Else
                    'se debe actualizar el valor de cantidad, restando...
                    Dim ValorActual As Decimal = dsExiste.Tables(0).Rows(0)(1)
                    Dim ValorInsertar As Decimal
                    If ValorActual >= PrecioUnitario Then
                        ValorInsertar = ValorActual
                    Else
                        ValorInsertar = PrecioUnitario
                    End If

                    strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) -
                                Decimal.Parse(dgvProductos.Rows(i).Cells(1).Value) &
                                ", decPrecioVenta = " & ValorInsertar &
                                " where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value &
                            " and idUnidadMedida = " & intUniMed & " And intVarControlInventario = 1"                   'evaluar la unidad de medida: dgvProductos.Rows(i).Cells(2).Value
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                Pausa(50)
                Me.Refresh()
            Next

            strqry = "UPDATE tblListaVentas set deFechaOrdenSalida = getdate(), intUsuarioOrdenSalida =  " & intUsuario & ", " &
                      " strRecibioMercancia = '" & tbRecibeMercancia.Text & "' WHERE idVenta = " & InteVentaSurtida
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
            GrabarAccion(15, InteVentaSurtida)

            MsgBox("Orden de salida marcada como surtida. Se generará la Salida de Almacén.")
            GenerarSalidaAlmacen(InteVentaSurtida, True)
        Else
            MsgBox("Orden de salida " & InteVentaSurtida & " fue cancelada mientras se estaba surtiendo. Proceso Cancelado. ")
        End If

        Me.Update()
        Me.Enabled = True
        LimpiarForm()
        CargarOrdenes()
    End Sub

    Public Sub GenerarSalidaAlmacen(ByRef intSalida As Integer, Optional ByRef boolActivaExport As Boolean = True)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT * " &
                                " FROM vstTransaccionesVenta WHERE idVenta = " & intSalida & " order by  intPartida   "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable
        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)
        Dim frm As New frmCrystalReportContainer()
        Dim rep As New rptSalidaAlmacen
        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        frm.VisorCrystalReport.Visible = True
        'Para indicar que solo exportara a PDF
        frm.VisorCrystalReport.AllowedExportFormats = ExportFormatType.PortableDocFormat
        If boolActivaExport = False Then
            frm.VisorCrystalReport.ShowPrintButton = False
            frm.VisorCrystalReport.AllowedExportFormats = False
        Else
            frm.VisorCrystalReport.ShowPrintButton = True
            frm.VisorCrystalReport.AllowedExportFormats = True
        End If
        frm.Text = "Salida de Almacén"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub

#End Region

    Private Sub tbEntregaMercancía_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbEntregaMercancía.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbRecibeMercancia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbRecibeMercancia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
#Region "Vista Previa"

    Private Sub btnVistaPrevia_Click(sender As System.Object, e As System.EventArgs) Handles btnVistaPrevia.Click
        If tbRecibeMercancia.Text = "" Then
            MessageBox.Show("Debe indicar que persona recibe la mercancía para entregar al cliente.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbRecibeMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False

        Dim strqry As String = ""
        'Dim j As Integer
        'Dim i As Integer
        'Dim decCantAfectar As Double
        'Dim intUniMed As Integer
        'For i = 0 To dgvProductos.Rows.Count - 1 Step 1
        '    'obtenemos el nuemro de id de la Unidad de medida
        '    strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
        '    Dim dsUM As New DataSet
        '    dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        '    intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

        '    'hacemos el calculo del inventario
        '    strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value & _
        '                " and idUnidadMedida = " & intUniMed & "And intVarControlInventario = 1"            'evaluar la unidad de medida   dgvProductos.Rows(i).Cells(2).Value
        '    Dim dsExiste As New DataSet
        '    dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        '    If dsExiste.Tables(0).Rows.Count = 0 Then
        '        'se debe insertar la venta"
        '        decCantAfectar = dgvProductos.Rows(i).Cells(1).Value * -1
        '        strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" & _
        '                    dgvProductos.Rows(i).Cells(3).Value & ", " & intUniMed & _
        '                    ", " & decCantAfectar & ") "           'la afectacionde la unidad de medida debe de verificarse con su ID de Unidad de medida  dgvProductos.Rows(i).Cells(2).Value
        '        j = 0
        '        j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar la partida de salida.")
        '        If j = 0 Then
        '            'No se pudo grabar la partida en la tabla
        '            dgvProductos.Item(1, i).Style.BackColor = Color.Red
        '        Else
        '            dgvProductos.Item(1, i).Style.BackColor = Color.Green
        '        End If
        '    Else
        '        'se debe actualizar el valor de cantidad, restando...
        '        strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) - _
        '                    Decimal.Parse(dgvProductos.Rows(i).Cells(1).Value) & _
        '                    " where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value & _
        '                " and idUnidadMedida = " & intUniMed & " And intVarControlInventario = 1"                   'evaluar la unidad de medida: dgvProductos.Rows(i).Cells(2).Value
        '        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        '        dgvProductos.Item(1, i).Style.BackColor = Color.Green
        '    End If
        '    Pausa(50)
        '    Me.Refresh()
        'Next

        'strqry = "UPDATE tblListaVentasPrevia set deFechaOrdenSalida = getdate(), intUsuarioOrdenSalida =  " & intUsuario & ", " & _
        '          " strRecibioMercancia = '" & tbRecibeMercancia.Text & "' WHERE idVenta = " & InteVentaSurtida
        'funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        'GrabarAccion(15, InteVentaSurtida)
        Me.Update()
        Me.Enabled = True

        'MsgBox("Orden de compra marcada como surtida. Se generará la Salida de Almacén.")
        GenerarSalidaAlmacenPrevia(InteVentaSurtida)

    End Sub

    Public Sub GenerarSalidaAlmacenPrevia(ByRef intSalida As Integer)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT * " & _
                                " FROM vstTransaccionesVenta WHERE idVenta = " & intSalida & " order by  intPartida   "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable
        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)
        Dim frm As New frmCrystalReportContainer()
        Dim rep As New rptSalidaAlmacenPrevia
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

        frm.Text = "Vista Previa de Salida de Almacén"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub

#End Region

End Class