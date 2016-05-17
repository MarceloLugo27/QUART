Imports System.ComponentModel
Imports System.Xml
'Imports QUART.clProcedimientos
Imports QuartOK.ProcedimientosGenerales

Public Class LeerXML

#Region "Variables"

    Dim intEmpresa As Integer
    Dim strTipoComprobante As String
    Dim strSerie As String
    Dim strFolio As String
    Dim strFechaEmision As String
    Dim strSello As String
    Dim strNoCertificado As String
    Dim strSubTotal As String
    Dim strTotal As String
    Dim strMoneda As String
    Dim strCondiciones As String
    Dim strFormaPago As String
    Dim strMetodoPago As String
    Dim strLugarExpedicion As String
    Public Shared strReceptorRFC As String
    Public Shared strReceptorNombre As String

    Public Shared strEmisorRFC As String
    Public Shared strEmisorNombre As String

    Dim strCantidad As String
    Dim strUnidad As String
    Dim strNumID As String
    Dim strDescripcion As String
    Dim strValUnitario As String
    Dim strImporte As String
    Dim strIVA As String

    Dim strTotalLetra As String
    Dim strArchivoXML As String

    Public Shared strReceptorCalle As String
    Public Shared strReceptorNoExterior As String
    Public Shared strReceptorNoInterior As String
    Public Shared strReceptorColonia As String
    Public Shared strReceptorReferencia As String
    Public Shared strReceptorMunicipio As String
    Public Shared strReceptorEstado As String
    Public Shared strReceptorPais As String
    Public Shared strReceptorCodigoPostal As String

    Public Shared strNumIDProdXML As String
    Public Shared strDescripcionProdXML As String
    Public Shared strValUnitarioProdXML As String
    Public Shared strUnidadProdXML As String
#End Region

    Private Sub btnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionar.Click
        dgvProductos.DataSource = Nothing
        dgvProductos.Rows.Clear()

        'If dgvProductos.RowCount > 0 Then
        '    For i = 1 To dgvProductos.RowCount
        '        dgvProductos.Rows.RemoveAt(i - 1)
        '    Next
        'End If

        lblArchivoXML.Text = ""
        'ListBox1.Items.Clear()
        Dim dr As New DialogResult
        dr = ofdXML.ShowDialog
        Try
            If dr = Windows.Forms.DialogResult.OK Then
                lblArchivoXML.Text = ofdXML.FileName
                strArchivoXML = ofdXML.SafeFileName
            End If
        Catch ex As Exception
            lblArchivoXML.Text = ""
        End Try
        If lblArchivoXML.Text <> "" Then
            RevisarArchivoXML()

            'btnOrdenSalida.Enabled = True

        End If

    End Sub

    Private Sub AjustarDGV()
        dgvProductos.RowHeadersVisible = False
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.AllowUserToResizeColumns = False
        dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically

        dgvProductos.AllowUserToOrderColumns = False

        dgvProductos.Columns.Add("Partida", "Partida")
        dgvProductos.Columns.Add("Cantidad", "Cantidad")
        dgvProductos.Columns.Add("UnidadMedida", "U.M.")
        dgvProductos.Columns.Add("IdProd", "Num. Producto")
        dgvProductos.Columns.Add("Producto", "Producto")
        dgvProductos.Columns.Add("Precio", "P. Unitario")
        dgvProductos.Columns.Add("Importe", "Importe")
        'dgvProductos.Columns.Add("IdUM", "")
        ''...
        'dgvProductos.Columns.Add("Cancela", "Cancelar Partida")

        dgvProductos.Columns(0).Width = 55
        dgvProductos.Columns(1).Width = 100
        dgvProductos.Columns(2).Width = 200

        dgvProductos.Columns(3).Width = 70
        dgvProductos.Columns(4).Width = 400
        dgvProductos.Columns(5).Width = 120
        dgvProductos.Columns(6).Width = 120
        '...
        'dgvProductos.Columns(7).Width = 120

        dgvProductos.Visible = True
    End Sub

    Private Sub RevisarArchivoXML()
        Dim xDoc As XmlDocument
        Dim xNodo As XmlNodeList
        Dim xAtt As XmlElement
        'Dim intConsecutivo As Integer
        xDoc = New XmlDocument
        xDoc.Load(lblArchivoXML.Text)

        xNodo = xDoc.GetElementsByTagName("cfdi:Emisor")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                strEmisorRFC = VarXml(xAtt, "rfc")
                strEmisorNombre = VarXml(xAtt, "nombre")
            Next
        End If

        Dim strqry As String = "Select strRFCEmpresa, strRazonSocialEmpresa, intEmpresa From tblEmpresas where intVarControlEmpresa = 1 and " &
            " strRFCEmpresa = '" & strEmisorRFC & "'"
        Dim dsEmpresa As New DataSet
        dsEmpresa = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")


        If dsEmpresa.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("La empresa con nombre " & strEmisorNombre & " no está autorizada como emisor.")
            LimpiarForm()
            Exit Sub
        Else
            lblEmpresa.Text = dsEmpresa.Tables(0).Rows(0)(1).ToString
            intEmpresa = dsEmpresa.Tables(0).Rows(0)(2)
        End If


        xNodo = xDoc.GetElementsByTagName("cfdi:Comprobante")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                strTipoComprobante = VarXml(xAtt, "tipoDeComprobante")
                strSerie = VarXml(xAtt, "serie")
                strFolio = VarXml(xAtt, "folio")
                strFechaEmision = VarXml(xAtt, "fecha")
                strSello = VarXml(xAtt, "sello")
                strNoCertificado = VarXml(xAtt, "noCertificado")
                strSubTotal = VarXml(xAtt, "subTotal")
                strTotal = VarXml(xAtt, "total")
                strMoneda = VarXml(xAtt, "Moneda")
                strCondiciones = VarXml(xAtt, "condicionesDePago")
                strFormaPago = VarXml(xAtt, "formaDePago")
                strMetodoPago = (VarXml(xAtt, "metodoDePago")) '+ " " + VarXml(xAtt, "NumCtaPago")).Trim
                strLugarExpedicion = VarXml(xAtt, "LugarExpedicion")
            Next
        End If

        lblFactura.Text = strSerie & " " & strFolio         'id de la factura
        lblFechaHora.Text = strFechaEmision
        lblSubtotal.Text = "$" & strSubTotal
        lblTotal.Text = "$" & strTotal


        xNodo = xDoc.GetElementsByTagName("cfdi:Receptor")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                strReceptorRFC = VarXml(xAtt, "rfc")
                strReceptorNombre = VarXml(xAtt, "nombre")
            Next

            For Each xAtt In xNodo.Item(0)
                'If xAtt.LocalName Like "*DomicilioFiscal*" Then
                strReceptorCalle = VarXml(xAtt, "calle")
                strReceptorNoExterior = VarXml(xAtt, "noExterior")
                strReceptorNoInterior = VarXml(xAtt, "noInterior")
                strReceptorColonia = VarXml(xAtt, "colonia")
                strReceptorReferencia = VarXml(xAtt, "referencia")
                strReceptorMunicipio = VarXml(xAtt, "municipio")
                strReceptorEstado = VarXml(xAtt, "estado")
                strReceptorPais = VarXml(xAtt, "pais")
                strReceptorCodigoPostal = VarXml(xAtt, "codigoPostal")
                '    End If
                '    If xAtt.LocalName Like "*RegimenFiscal*" Then
                '        strRegimen = VarXml(xAtt, "Regimen")
                '    End If
            Next
        End If

        lblRFC.Text = strReceptorRFC
        lblCliente.Text = strReceptorNombre


        xNodo = xDoc.GetElementsByTagName("cfdi:Conceptos")
        If xNodo.Count > 0 Then
            Dim intPartida As Integer = 0
            For Each xAtt In xNodo.Item(0)
                intPartida = intPartida + 1
                strCantidad = VarXml(xAtt, "cantidad")
                strUnidad = VarXml(xAtt, "unidad")
                strNumID = VarXml(xAtt, "noIdentificacion")
                strDescripcion = VarXml(xAtt, "descripcion")
                strValUnitario = VarXml(xAtt, "valorUnitario")
                strImporte = VarXml(xAtt, "importe")

                dgvProductos.Rows.Add(intPartida, strCantidad, strUnidad, strNumID, strDescripcion, strValUnitario, strImporte)
            Next
        End If

        xNodo = xDoc.GetElementsByTagName("cfdi:Impuestos")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                strIVA = VarXml(xAtt, "totalImpuestosTrasladados")
                'strReceptorNombre = VarXml(xAtt, "nombre")
            Next
        End If

        lblIVA.Text = "$" & strIVA
        strTotalLetra = Letras(strTotal)
        VerificarXMLProcesado()

    End Sub

    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function

    Private Sub LeerXML_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblEmpresa.Text = ""
        PrepararDGV(dgvProductos)
        AjustarDGV()
        ofdXML.Filter = "Archivos XML | *.XML"
        ofdXML.InitialDirectory = "C:\DPGeneraCFD\CFDS\QUART"
        ofdXML.FileName = "*.XML"
        btnSeleccionar.Enabled = True
        btnOrdenSalida.Enabled = False
        btnVerificarProductos.Enabled = False
        gbConfirmar.Enabled = False
        TamañoInicialForm()
    End Sub

    Private Sub TamañoInicialForm()
        Me.Size = New System.Drawing.Size(911, 550)
        'Me.Size.Width = 797
        'Me.Size.Height = 464
        Me.Update()
    End Sub

    Private Sub CrecerForm()
        Me.Size = New System.Drawing.Size(911, 693)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim strqry As String = ""
        Dim j As Integer
        Dim i As Integer
        Dim decCantAfectar As Double
        Dim intUniMed As Integer
        For i = 0 To dgvProductos.Rows.Count - 1 Step 1
            'obtenemos el nuemro de id de la Unidad de medida
            strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
            Dim dsUM As New DataSet
            dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

            'hacemos el calculo del inventario
            strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value &
                        " and idUnidadMedida = " & intUniMed & "And intVarControlInventario = 1"            'evaluar la unidad de medida   dgvProductos.Rows(i).Cells(2).Value
            Dim dsExiste As New DataSet
            dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            If dsExiste.Tables(0).Rows.Count = 0 Then
                'se debe insertar la venta"
                decCantAfectar = dgvProductos.Rows(i).Cells(1).Value * -1
                strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" &
                            dgvProductos.Rows(i).Cells(3).Value & ", " & intUniMed &
                            ", " & decCantAfectar & ") "           'la afectacionde la unidad de medida debe de verificarse con su ID de Unidad de medida  dgvProductos.Rows(i).Cells(2).Value
                j = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
            Else
                'se debe actualizar el valor de cantidad, restando...
                strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) -
                            Decimal.Parse(dgvProductos.Rows(i).Cells(1).Value) &
                            " where IdProducto = " & dgvProductos.Rows(i).Cells(3).Value &
                        " and idUnidadMedida = " & intUniMed & " And intVarControlInventario = 1"                   'evaluar la unidad de medida: dgvProductos.Rows(i).Cells(2).Value
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                dgvProductos.Item(1, i).Style.BackColor = Color.Green
            End If
            System.Threading.Thread.Sleep(200)
            Me.Refresh()
        Next

    End Sub

    Private Sub VerificarXMLProcesado()
        'evaluar si el xml ya se ha procesado o no...
        'se coloca como rutina, para colocarlo desde que se carga el XML o cuando se pide procesar, a eleccion del programador.
        'se sugiere sea desde que el xml sea consultado

        '********************************************************************************
        '******                                                                     *****
        '******         ES MUY IMPORTANTE INCLUIR UNA RUTINA DONDE SE VERIFIQUE     *****
        '******         QUE EL CLIENTE QUE SE ESTA INGRESANDO EN EL ARCHIVO XML     *****
        '******         YA SE ENCUENTRE DADO DE ALTA EN EL SISTEMA                  *****
        '******         SI ESTO NO OCURRE ASI, DETECTARLO Y ABRIR LA VENTA DE       *****
        '******         ALTA DE CLIENTE NUEVO Y HASTA QUE SE CONFIRME QUE SE        *****
        '******         INGRESO CORRECTAMENTE EN EL SISTEMA (CON EL IDENTITY)       *****
        '******         ENTONCES SE PERMITIRA GENERAR LA ORDEN DE SALIDA            *****
        '******                                                                     *****
        '********************************************************************************

        'primero verificamos que el cliente ya este dado de alta en el sistema
        'si no esta dado de alta, 
        Dim strqry As String
        strqry = "SELECT idCliente from tblCatClientes where strRFC = '" & strReceptorRFC & "'"
        Dim dsCliente As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        If dsCliente.Tables(0).Rows.Count = 0 Then
            ClienteXML = 1
            MsgBox("El cliente aún no esta registrado en el sistema, por favor ingrese al registro de clientes")
            '& vbCr &
            '       "El registro de clientes llevara precarados los datos siguientes: " & vbCr &
            '        strReceptorNombre & " / " & strReceptorRFC & " / " & strReceptorCalle & " / " &
            '        strReceptorNoExterior & " / " & strReceptorColonia & " / " & strReceptorReferencia & " / " &
            '        strReceptorMunicipio & " / " & strReceptorEstado & " / " & strReceptorPais & " / " & strReceptorCodigoPostal)
            'Inhabilitar este form y habilitar el de Nuevo Cliente
            'llenando espacios de Nombre, 
            btnVerificarProductos.Enabled = True
            AltaClientes.Show()
            Exit Sub
        End If

        strqry = "SELECT dtFechaIngresoSistema FROM tblListaVentas WHERE strXML = '" & strArchivoXML & "'  and intVarControlVenta = 1 "
        Dim dsExiste As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        If dsExiste.Tables(0).Rows.Count = 0 Then
            btnVerificarProductos.Enabled = True
            Exit Sub
        Else
            btnVerificarProductos.Enabled = False
            Dim strFechaIngreso As String
            strFechaIngreso = Format(dsExiste.Tables(0).Rows(0)(0), "dd/MM/yyyy")
            MsgBox("Este archivo XML fue ingresado al sistema el " & strFechaIngreso)
        End If
    End Sub

    Private Sub btnVerificarProductos_Click(sender As System.Object, e As System.EventArgs) Handles btnVerificarProductos.Click
        'Primero evaluaremos que todos los productos ya esten dados de alta
        Dim ProductosCorrectos As Boolean = True
        For i = 0 To dgvProductos.RowCount - 1
            Dim strqry As String = "SELECT idProducto from tblCatProductos where strCodProdQuart = '" & dgvProductos.Rows(i).Cells(3).Value & "' "
            Dim dsChecar As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            Dim j As Integer = dsChecar.Tables(0).Rows.Count
            If j = 0 Then
                'No se encontro el producto en la base de datos
                dgvProductos.Item(3, i).Style.BackColor = Color.Red
                ProductosCorrectos = False
            Else
                dgvProductos.Item(3, i).Style.BackColor = Color.Green
            End If
        Next

        If ProductosCorrectos = True Then
            btnOrdenSalida.Enabled = True
            btnVerificarProductos.Enabled = False
        Else
            btnOrdenSalida.Enabled = False
            btnVerificarProductos.Enabled = True
            MessageBox.Show("No se localizó por lo menos un producto en la base de datos. Los productos no localizados los encuentra con su código en rojo. " & _
                            vbCr & "De click en el código rojo para dar de alta el producto", "Productos no localizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub btnOrdenSalida_Click(sender As System.Object, e As System.EventArgs) Handles btnOrdenSalida.Click, btnOrdenSalida.Click
        CrecerForm()
        btnSeleccionar.Enabled = False
        btnOrdenSalida.Enabled = False
        btnVerificarProductos.Enabled = False
        Dim strqry As String
        strqry = "SELECT strDomicilioAlmacen FROM tblCatClientes where strRFC = '" & strReceptorRFC & "'"
        Dim dsCliente As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        tbDomicilioEntrega.Text = dsCliente.Tables(0).Rows(0)(0).ToString
        'Se genera la orden de salida (en Transacciones de venta) y sus facturas.
        'ampliar en el formato el area de comentarios adicionales 
        gbConfirmar.Enabled = True

    End Sub

    Private Sub LimpiarForm()
        lblEmpresa.Text = ""
        lblArchivoXML.Text = ""
        lblCliente.Text = ""
        lblFactura.Text = ""
        lblFechaHora.Text = ""
        lblRFC.Text = ""
        lblIVA.Text = ""
        lblSubtotal.Text = ""
        lblTotal.Text = ""
        btnSeleccionar.Enabled = True
        btnOrdenSalida.Enabled = False
        dgvProductos.DataSource = Nothing
        dgvProductos.Rows.Clear()
        tbDomicilioEntrega.Text = ""
        tbObservaciones.Text = ""
        gbConfirmar.Enabled = False
    End Sub

    Private Sub btnGrabarOrdenSalida_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarOrdenSalida.Click
        Me.Enabled = False
        Dim strqry As String
        strqry = "SELECT IDCliente FROM tblCatClientes WHERE strRFC = '" & strReceptorRFC & "'"
        Dim dsClientes As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        Dim intCliente As Integer = Integer.Parse(dsClientes.Tables(0).Rows(0)(0).ToString)
        dsClientes.Dispose()
        Dim decSubTotal As Decimal = Decimal.Parse(strSubTotal)
        Dim cscSubTotal As String = Format(decSubTotal, "$#,##0.00")

        Dim decIVA As Decimal = Decimal.Parse(strIVA)
        Dim cscIVA As String = Format(decIVA, "$#,##0.00")

        Dim decTotal As Decimal = Decimal.Parse(strTotal)
        Dim cscTotal As String = Format(decTotal, "$#,##0.00")


        strqry = "INSERT INTO tblListaVentas (IDCliente,strIdFactura,dtFechaVentaXML,MontoAntesIVA,IVA,Total,strXML,strDomicilioEntrega,strObservaciones, intUsuarioVenta, intAgregarIVA, " &
                    " strLeyendaSubTotal, strLeyendaIVA, strLeyendaTotal, strIVA, strTotal, TotalLetra, strLeyendaDocumento, strLeyendaSalidaAlmacen, intOrigen, intEmpresa) VALUES (" &
                    intCliente & ", '" & lblFactura.Text & "', '" & Microsoft.VisualBasic.Left(strFechaEmision, 10) &
                    "', " & strSubTotal & ", " & strIVA & "," & strTotal & ", '" & strArchivoXML & "', '" &
                    tbDomicilioEntrega.Text & "', '" & tbObservaciones.Text & "', " & intUsuario & ", 1 , " &
                    " 'Sub-Total', 'IVA 16%', 'Total', '" & cscIVA & "', '" & cscTotal & "', '" & strTotalLetra & "','FACTURACION – VENTA', 'FACTURA', 1," & intEmpresa & ")"            'int de usuario al final
        'agregar en este punto las leyendas de  subtotal, IVA y total, la cantidad con letras y los montos de Subtotal, IVA y Total ye l origen 1 para identificar que es XML
        Dim InserteOk As Integer = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se inserto el archivo XML de manera adecuada")
        If InserteOk = 0 Then
            MsgBox("No se inserto Correctamente")
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(8, InserteOk)
            'insertar transacciones de la aplicacion
            For i = 0 To dgvProductos.RowCount - 1
                'obtenemos el nuemro de id de la Unidad de medida
                Dim intUniMed As Integer
                strqry = "Select [IDUnidadMedida] from tblCatUnidadMedida where strUnidadMedida = '" & dgvProductos.Rows(i).Cells(2).Value & "'"
                Dim dsUM As New DataSet
                dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
                intUniMed = Integer.Parse(dsUM.Tables(0).Rows(0)(0).ToString)

                Dim intProductoMSL As Integer
                Dim dsProductoMSL As New DataSet
                strqry = "SELECT IDProducto FROM tblCatProductos WHERE strCodProdQuart = '" & dgvProductos.Rows(i).Cells(3).Value & "' "
                dsProductoMSL = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
                intProductoMSL = Integer.Parse(dsProductoMSL.Tables(0).Rows(0)(0).ToString)


                strqry = "INSERT INTO tblTransaccionesVenta (idVenta,intPartida,IDProducto,Cantidad,PKUnidadMedida,PrecioUnitario,TotalSinDescuento) VALUES (" &
                    InserteOk & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & intProductoMSL & ", " & dgvProductos.Rows(i).Cells(1).Value & ", " & intUniMed &
                    ", " & dgvProductos.Rows(i).Cells(5).Value & ", " & dgvProductos.Rows(i).Cells(6).Value & ")"

                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
            Next
            MsgBox("Orden de salida de almacen generada correctamente")

        End If

        TamañoInicialForm()
        LimpiarForm()
        Me.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        TamañoInicialForm()
        LimpiarForm()
    End Sub

    Private Sub LeerXML_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantVentaXML = False
    End Sub


    Private Sub dgvProductos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Dim intColumna As Integer = e.ColumnIndex
        If intColumna = 3 Then
            Dim intRenglon As Integer = e.RowIndex
            If intRenglon >= 0 Then
                If dgvProductos.Item(3, intRenglon).Style.BackColor = Color.Red Then
                    ProductoXML = 1
                    strNumIDProdXML = dgvProductos.Rows(intRenglon).Cells(3).Value
                    strDescripcionProdXML = dgvProductos.Rows(intRenglon).Cells(4).Value
                    strValUnitarioProdXML = dgvProductos.Rows(intRenglon).Cells(5).Value
                    strUnidadProdXML = dgvProductos.Rows(intRenglon).Cells(2).Value
                    AltaDeProductos.MdiParent = MDIPrincipal
                    AltaDeProductos.Show()
                    MDIPrincipal.PantAltaProductos = True
                End If
            End If
        End If
    End Sub

    Private Sub tbDomicilioEntrega_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDomicilioEntrega.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbObservaciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbObservaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class