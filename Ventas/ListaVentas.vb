Imports QuartOK.ProcedimientosGenerales

Public Class ListaVentas

    Dim strCondicion1 As String
    Dim strCondicion2 As String
    Dim strCondicion3 As String

    Dim intCliente As Integer
    Dim strConsulta As String
    Dim intVenta As Integer

    Private Sub ListaVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If
        If MDIPrincipal.PermisoReimpresion = False Then
            btnImprimirVenta.Visible = False
        End If
        Iniciar()
    End Sub
    Private Sub Iniciar()
        lblContar.Text = ""
        cbEmpresa.Text = "TODAS"
        cbTipoVenta.Text = "TODAS"
        cbOrigen.Text = "TODAS"
        tbCliente.Text = ""
        cbFiltro.Text = "TODAS"
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
        dgvVentas.DataSource = Nothing
        dgvVentas.Rows.Clear()
        dgvVentas.Columns.Clear()
        intVenta = 0
    End Sub
    Private Sub cbEmpresa_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpresa.SelectedValueChanged
        Select Case cbEmpresa.Text
            Case "TODAS"
                strCondicion1 = " intEmpresa > 0 "
            Case "QUART"
                strCondicion1 = " intEmpresa = 1 "
            Case "AARON"
                strCondicion1 = " intEmpresa = 2 "
            Case Else
                strCondicion1 = " intEmpresa = 0 "
        End Select
    End Sub

    Private Sub cbTipoVenta_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbTipoVenta.SelectedValueChanged
        Select Case cbTipoVenta.Text
            Case "TODAS"
                strCondicion2 = " intAgregarIVA >= 0 "
            Case "IVA DESGLOZADO"
                strCondicion2 = " intAgregarIVA = 1 "
            Case "SIN IVA"
                strCondicion2 = " intAgregarIVA = 0 "
            Case Else
                strCondicion2 = " intAgregarIVA < 0 "
        End Select
    End Sub

    Private Sub cbOrigen_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbOrigen.SelectedValueChanged
        Select Case cbOrigen.Text
            Case "TODAS"
                strCondicion3 = " intOrigen >= 0 "
            Case "XML"
                strCondicion3 = " intOrigen = 1 "
            Case "MOSTRADOR"
                strCondicion3 = " intOrigen = 0 "
            Case Else
                strCondicion3 = " intOrigen < 0 "
        End Select
    End Sub

    Private Sub tbCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbCliente.TextChanged
        Dim intLargo As Integer = Len(tbCliente.Text)
        If intLargo >= 3 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & tbCliente.Text & _
                        "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbCliente.DataSource = Nothing
            cbCliente.Items.Clear()
        End If
    End Sub

    Private Sub tbCliente_Click(sender As System.Object, e As System.EventArgs) Handles tbCliente.Click
        tbCliente.Text = ""
        intCliente = 0
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.DataSource IsNot Nothing Then
            intCliente = DirectCast(cbCliente.SelectedItem, DataRowView).Item("IDCliente")
            cbCliente.DroppedDown = False
        End If
    End Sub

    Private Sub cbFiltro_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbFiltro.SelectedValueChanged
        Dim strqry As String = ""
        Dim dsFecha As New DataSet
        Dim dtHoy As Date
        Dim hoy As String
        Dim diaSemana As Integer
        strqry = "select getdate() as fecha"
        dsFecha = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Fecha", "")
        dtHoy = dsFecha.Tables(0).Rows(0)(0).ToString
        hoy = Microsoft.VisualBasic.Left(dsFecha.Tables(0).Rows(0)(0).ToString, 10)
        diaSemana = dtHoy.DayOfWeek
        Dim intDiferenciaDias As Integer = diaSemana * (-1)

        dtFechaFinal.Enabled = False
        dtFechaInicial.Enabled = False

        Select Case cbFiltro.Text
            Case "TODAS"
                dtFechaFinal.Visible = False
                dtFechaInicial.Visible = False
            Case "El día de hoy"
                dtFechaFinal.Visible = False
                dtFechaInicial.Visible = True
                dtFechaFinal.Enabled = False
                dtFechaInicial.Enabled = False
                dtFechaInicial.Value = dtHoy
                dtFechaFinal.Value = dtHoy
            Case "Esta semana"
                dtFechaFinal.Visible = True
                dtFechaInicial.Visible = True
                dtFechaFinal.Enabled = False
                dtFechaInicial.Enabled = False
                dtFechaInicial.Value = DateAdd(DateInterval.Day, intDiferenciaDias, dtHoy)
                dtFechaFinal.Value = DateAdd(DateInterval.Day, 6, dtFechaInicial.Value)
            Case "Las ultimas dos semanas"
                dtFechaFinal.Visible = True
                dtFechaInicial.Visible = True
                dtFechaFinal.Enabled = False
                dtFechaInicial.Enabled = False
                dtFechaInicial.Value = DateAdd(DateInterval.Day, intDiferenciaDias - 14, dtHoy)
                dtFechaFinal.Value = dtHoy
            Case "Este Mes"
                dtFechaFinal.Visible = True
                dtFechaInicial.Visible = True
                dtFechaFinal.Enabled = False
                dtFechaInicial.Enabled = False
                dtFechaFinal.Value = dtHoy
                Dim intDiaDeHoy As Integer
                intDiaDeHoy = Microsoft.VisualBasic.DateAndTime.Day(dtHoy) * -1
                dtFechaInicial.Value = DateAdd(DateInterval.Day, intDiaDeHoy + 1, dtHoy)
            Case "El mes pasado"
                dtFechaFinal.Visible = True
                dtFechaInicial.Visible = True
                dtFechaFinal.Enabled = False
                dtFechaInicial.Enabled = False
                dtFechaFinal.Value = dtHoy
                Dim intDiaDeHoy As Integer
                intDiaDeHoy = Microsoft.VisualBasic.DateAndTime.Day(dtHoy) * -1
                dtFechaInicial.Value = DateAdd(DateInterval.Day, intDiaDeHoy + 1, dtHoy)
                dtFechaFinal.Value = DateAdd(DateInterval.Day, -1, dtFechaInicial.Value)
                dtFechaInicial.Value = DateAdd(DateInterval.Month, -1, dtFechaInicial.Value)
            Case "El día de..."
                dtFechaFinal.Visible = False
                dtFechaInicial.Visible = True
                dtFechaInicial.Value = dtHoy
                dtFechaInicial.Enabled = True
                dtFechaFinal.Enabled = False
            Case "Entre los dias..."
                dtFechaFinal.Visible = True
                dtFechaInicial.Visible = True
                dtFechaInicial.Value = dtHoy
                dtFechaFinal.Value = dtHoy
                dtFechaFinal.Enabled = True
                dtFechaInicial.Enabled = True
        End Select

    End Sub

    Private Sub ListaVentas_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantListaVentas = False
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

        PrepararDGV(dgvVentas)
        Dim strqry As String = "SELECT  IDCliente as [Num Cliente], strNombreCliente as [Nombre del Cliente], dtFechaVentaXML as [Fecha de Venta], " & _
                                    " strIdFactura as [Factura], idVenta as [Num Venta], strRazonSocialEmpresa as Empresa, strNombreUsuarioVenta as Vendedor, " & _
                                    " deFechaOrdenSalida as [Fecha Salida Almacen], strNombreUsuarioAlmacen as [Entregó Mercancía], MontoAntesIVA as SubTotal, " & _
                                    " IVA, Total FROM  vstOrdenesSalida "

        Dim strComplemento1 As String

        If intCliente = 0 Then
            strComplemento1 = " where IDCliente > 0 "
        Else
            strComplemento1 = " where IDCliente = " & intCliente
        End If

        Dim strComplemento2 As String = ""
        Dim dtFecha1 As String = ""
        Dim dtFecha2 As String = ""

        Select Case cbFiltro.Text
            Case "TODAS"
                strComplemento2 = ""
            Case "El día de hoy"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema >=  '" & dtFecha1 & " 00:00' "
            Case "Esta semana"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Las ultimas dos semanas"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Este Mes"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El mes pasado"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El día de..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha1 & " 23:59:59' "
            Case "Entre los dias..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaIngresoSistema  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
        End Select

        strConsulta = strqry & " " & strComplemento1 & " " & strComplemento2 & " and " & strCondicion1 & " and " & strCondicion2 & _
            "and " & strCondicion3 & " ORDER BY idVenta DESC "
        LlenarDataGrid(strConsulta, dgvVentas)
        lblContar.Text = "Ventas Realizadas: " & dgvVentas.Rows.Count.ToString
        'intVenta = 0
        ProcedimientosGenerales.GrabarAccion(22)

    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Iniciar()
    End Sub

    Private Sub dgvVentas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intVenta = dgvVentas.Rows(intRenglon).Cells(4).Value
            LlenardgvPartidas(intVenta)
        End If
    End Sub
    Private Sub LlenardgvPartidas(ByRef intVentaSeleccionada As Integer)

        PrepararDGV(dgvPartidas)
        Dim strqry As String = "SELECT intPartida as Partida, Cantidad, strUnidadMedida as [Unid_Med], strDescripcionProducto as Producto, " & _
                                "PrecioUnitario  as [Precio Unitario] FROM vstTransaccionesVenta  where idVenta = " & intVentaSeleccionada & _
                                " ORDER BY intPartida"
        LlenarDataGrid(strqry, dgvPartidas)

    End Sub

    Private Sub btnImprimirVenta_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirVenta.Click
        Dim strqry As String = "Select IVA, strIdFactura From vstTransaccionesVenta where idVenta = " & intVenta
        strqry = "SElect [intOrigen], strIdFactura  from [tblListaVentas] where idVenta = " & intVenta
        Dim dsIVA As DataSet
        dsIVA = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "IVA", "Error al obtener IVA")
        Dim IVA As Integer
        IVA = Single.Parse(dsIVA.Tables(0).Rows(0)(0).ToString)
        If IVA = 1 Then
            MessageBox.Show("Esta venta corresponde a la factura " & dsIVA.Tables(0).Rows(0)(1).ToString & " y es un archivo XML  y aparecerá el IVA desglozado, pero el documento no puede considerarse como una factura válida.", "Impresion de remisión de una factura", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        VentaMostrador.GenerarRemision(intVenta)
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Dim obj_Excel As Object
        Dim obj_hoja As Object
        Dim obj_libro As Object

        Dim LETEXCEL() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N"}

        Dim strArchivo As String

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Archivo Excel 97-2003|*.xls|Excel 2007-2013|*.xlsx"
        saveFileDialog.Title = "Salve el archivo Excel"
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName <> "" Then
            strArchivo = saveFileDialog.FileName

            Try
                obj_Excel = CreateObject("Excel.Application")
                obj_libro = obj_Excel.Workbooks.Add()
                obj_hoja = obj_libro.Worksheets(1)

                Dim i As Integer

                For i = 0 To dgvVentas.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvVentas.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvVentas.Columns.Count - 1
                    For j = 0 To dgvVentas.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvVentas(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

    Private Sub tbCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbCliente.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class