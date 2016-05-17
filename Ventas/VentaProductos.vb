Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class VentaProductos
    Dim idProducto, idCliente, idEmpresa As Integer
    Dim strCompEmpresa, strCompOrigen, strCompFecha, strCompProducto, strCompCliente, strCompGroup, strSeleccion As String

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.DataSource IsNot Nothing Then
            idCliente = DirectCast(cbCliente.SelectedItem, DataRowView).Item("IDCliente")
        End If
    End Sub

    Private Sub tbProd_TextChanged(sender As Object, e As EventArgs) Handles tbProd.TextChanged
        Dim intLargo As Integer = Len(tbProd.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where strDescripcionProducto like '%" & tbProd.Text & "%'  and IdProducto > 1 order by strDescripcionProducto"
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

    Private Sub VentaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararForm(Me)
        Inicio()
    End Sub

    Private Sub Inicio()
        idProducto = 0 : idEmpresa = 0 : idCliente = 0
        cbEmpresa.Text = "TODAS"
        cbOrigen.Text = "TODAS"
        strCompEmpresa = " WHERE intEmpresa > 0 "
        strCompOrigen = " AND intOrigen > 0 "
        strCompFecha = "" : strCompProducto = "" : strCompCliente = "" : strCompGroup = ""
        strSeleccion = "SELECT  idVenta as Venta, strLeyendaSalidaAlmacen as [Tipo Documento],strIdFactura as Factura,dtFechaVentaXML as [Fecha Venta]" &
",strNombreCliente as Cliente,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitario as [P.Unitario]FROM vstTransaccionesVenta "

        strCompGroup = ""

        LimpiarDataGrid(dgvProductos)
    End Sub

    Private Sub chkAgrupar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgrupar.CheckedChanged
        If chkAgrupar.Checked = False Then
            strSeleccion = "SELECT  idVenta as Venta,strLeyendaSalidaAlmacen as [Tipo Documento],strIdFactura as Factura,dtFechaVentaXML as [Fecha Venta]" &
",strNombreCliente as Cliente,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitario as [P.Unitario] FROM vstTransaccionesVenta "
            strCompGroup = ""
        End If

        If chkAgrupar.Checked = True Then
            strCompGroup = " GROUP BY PrecioUnitario , strNombreCliente, strDescripcionProducto, strUnidadMedida "
            strSeleccion = "SELECT strNombreCliente as Cliente, SUM(Cantidad) as Cantidad, strUnidadMedida as [U/M], strDescripcionProducto as Producto, PrecioUnitario as [P.Unitario] FROM vstTransaccionesVenta "
        End If
    End Sub

    Private Sub tbCliente_Click(sender As Object, e As EventArgs) Handles tbCliente.Click
        LimpiarCombo(cbCliente)
        idCliente = 0
        tbCliente.Text = ""
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        If cbProducto.DataSource IsNot Nothing Then
            idProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            cbCliente.DroppedDown = False
        End If
    End Sub

    Private Sub cbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpresa.SelectedIndexChanged

    End Sub

    Private Sub cbEmpresa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEmpresa.SelectedValueChanged
        Select Case cbEmpresa.Text
            Case "TODAS"
                strCompEmpresa = " WHERE intEmpresa > 0 "
            Case "QUART INDUSTRIA"
                strCompEmpresa = " WHERE intEmpresa = 1 "
            Case "AARON URDIALES"
                strCompEmpresa = " WHERE intEmpresa = 2 "
        End Select
    End Sub

    Private Sub cbOrigen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbOrigen.SelectedValueChanged
        Select Case cbEmpresa.Text
            Case "TODAS"
                strCompEmpresa = " AND intOrigen > 0 "
            Case "XML"
                strCompEmpresa = " AND intOrigen = 1 "
            Case "MOSTRADOR"
                strCompEmpresa = " AND intOrigen = 0 "
        End Select
    End Sub

    Private Sub tbProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProd.KeyPress

    End Sub

    'Private Sub AjustarDGVProductos()

    '    PrepararDGV(dgvProductos)
    '    dgvProductos.DataSource = Nothing
    '    dgvProductos.Columns.Clear()
    '    dgvProductos.Rows.Clear()
    '    dgvProductos.Columns.Add("Venta", "Venta")
    '    dgvProductos.Columns.Add("Tipo Documento", "Tipo Documento")
    '    dgvProductos.Columns.Add("Factura", "Factura")
    '    dgvProductos.Columns.Add("Fecha de venta", "Fecha de venta")
    '    dgvProductos.Columns.Add("Cliente", "Cliente")
    '    dgvProductos.Columns.Add("Cantidad", "Cantidad")
    '    dgvProductos.Columns.Add("U/M", "U/M")
    '    dgvProductos.Columns.Add("Producto", "Producto")
    '    dgvProductos.Columns.Add("P.Unitario", "P.Unitario")

    '    dgvProductos.AllowUserToOrderColumns = False
    '    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    '    dgvProductos.Visible = True
    'End Sub


    'Private Sub Iniciar()

    '    AjustarDGVProductos()


    '    Dim strqry As String
    '    If tbProducto.Text = "" Then
    '        strqry = "SELECT  idVenta as Venta,strLeyendaSalidaAlmacen as [Tipo Documento],strIdFactura as Factura,dtFechaVentaXML as [Fecha Venta],strNombreCliente as Cliente,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitario as [P.Unitario]FROM vstTransaccionesVenta"
    '    Else
    '        strqry = "SELECT  idVenta as Venta,strLeyendaSalidaAlmacen as [Tipo Documento],strIdFactura as Factura,dtFechaVentaXML as [Fecha Venta],strNombreCliente as Cliente,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitario as [P.Unitario]FROM vstTransaccionesVenta where strDescripcionProducto like '%" & tbProducto.Text & "%' "
    '    End If
    '    Dim dsDatos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")

    '    If dsDatos.Tables(0).Rows.Count > 0 Then
    '        For i As Integer = 0 To dsDatos.Tables(0).Rows.Count - 1


    '            dgvProductos.Rows.Add(dsDatos.Tables(0).Rows(i)(0), dsDatos.Tables(0).Rows(i)(1), dsDatos.Tables(0).Rows(i)(2), dsDatos.Tables(0).Rows(i)(3),
    '                              dsDatos.Tables(0).Rows(i)(4), dsDatos.Tables(0).Rows(i)(5), dsDatos.Tables(0).Rows(i)(6), dsDatos.Tables(0).Rows(i)(7), dsDatos.Tables(0).Rows(i)(8))
    '        Next

    '    End If

    'End Sub

    'Private Sub VentaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Iniciar()
    'End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
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

                For i = 0 To dgvProductos.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvProductos.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvProductos.Columns.Count - 1
                    For j = 0 To dgvProductos.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvProductos(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

    Private Sub VentaProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantReporteVentaProducto = False
    End Sub

    'Private Sub tbProducto_Click(sender As Object, e As EventArgs) Handles tbProducto.Click
    '    tbProducto.Text = ""
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Iniciar()
    'End Sub

    Private Sub tbCliente_TextChanged(sender As Object, e As EventArgs) Handles tbCliente.TextChanged
        Dim intLargo As Integer = Len(tbCliente.Text)
        If intLargo >= 4 Then
            Dim strqry As String = "SELECT IDCliente,strNombreCliente  FROM tblCatClientes where strNombreCliente like '%" & tbCliente.Text & "%' order by strNombreCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strNombreCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub tbCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCliente.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cbCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles cbCliente.KeyUp
        Dim intLargo As Integer = Len(cbCliente.Text)
        If intLargo > 3 Then
            Dim strqry As String = "SELECT IDCliente,strNombreCliente  FROM tblCatClientes " &
                " where strNombreCliente like '%" & cbCliente.Text & "%' order by strNombreCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strNombreCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        If idProducto = 0 Then strCompProducto = " " Else strCompProducto = " and idProducto = " & idProducto
        If idCliente = 0 Then strCompCliente = " " Else strCompCliente = " and idCliente = " & idCliente
        strCompFecha = ObtenerRangoFechas()
        Dim strqry As String = strSeleccion & strCompEmpresa & strCompOrigen & strCompProducto & strCompCliente & strCompFecha & strCompGroup
        PrepararDGV(dgvProductos)
        LlenarDataGrid(strqry, dgvProductos)
    End Sub

    Private Function ObtenerRangoFechas() As String
        Dim strComplemento2 As String = ""
        Dim dtFecha1 As String = ""
        Dim dtFecha2 As String = ""

        Select Case cbFiltro.Text
            Case "TODAS"
                strComplemento2 = ""
            Case "El día de hoy"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML >=  '" & dtFecha1 & " 00:00' "
            Case "Esta semana"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Las ultimas dos semanas"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Este Mes"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El mes pasado"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El día de..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha1 & " 23:59:59' "
            Case "Entre los dias..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaVentaXML  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
        End Select

        Return strComplemento2

    End Function


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

        Dim strComplemento2 As String = ""
        Dim dtFecha1 As String = ""
        Dim dtFecha2 As String = ""

        Select Case cbFiltro.Text
            Case "TODAS"
                strComplemento2 = ""
            Case "El día de hoy"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra >=  '" & dtFecha1 & " 00:00' "
            Case "Esta semana"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Las ultimas dos semanas"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Este Mes"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El mes pasado"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El día de..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha1 & " 23:59:59' "
            Case "Entre los dias..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " and dtFechaCompra  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
        End Select

    End Sub



End Class