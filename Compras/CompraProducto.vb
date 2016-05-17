Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal


Public Class CompraProducto

    Dim idProducto, idProveedor, idEmpresa As Integer
    Dim strCompEmpresa, strCompFecha, strCompProducto, strCompProveedor, strCompGroup, strSeleccion As String

#Region "Codigo Marcelo"

    Private Sub AjustarDGVProductos()

        PrepararDGV(dgvProductos)
        dgvProductos.DataSource = Nothing
        dgvProductos.Columns.Clear()
        dgvProductos.Rows.Clear()
        dgvProductos.Columns.Add("Compra", "Compra")
        dgvProductos.Columns.Add("Ref.Proveedor", "Ref.Proveedor")
        dgvProductos.Columns.Add("Proveedor", "Proveedor")
        dgvProductos.Columns.Add("Fecha Compra", "Fecha Compra")
        dgvProductos.Columns.Add("Empresa Compradora", "Empresa Compradora")
        dgvProductos.Columns.Add("Cantidad", "Cantidad")
        dgvProductos.Columns.Add("U/M", "U/M")
        dgvProductos.Columns.Add("Producto", "Producto")
        dgvProductos.Columns.Add("P.Unitario", "P.Unitario")
        dgvProductos.Columns.Add("Fecha Captura", "Fecha Captura")

        dgvProductos.AllowUserToOrderColumns = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvProductos.Visible = True
    End Sub


    Private Sub Iniciar()
        AjustarDGVProductos()

        Dim strqry As String
        If tbProducto.Text = "" Then
            strqry = "SELECT idCompra as Compra,strReferenciaProveedor as [Ref.Proveedor],strNombreProveedor as Proveedor,dtFechaCompra as [Fecha Compra],strRazonSocialEmpresa as [Empresa Compradora]," &
"CantidadComprada As Cantidad,strUnidadMedida As [U/M],strDescripcionProducto As Producto,PrecioUnitarioCompra As [P.Unitario],dtIngresoSistemaCompra As [Fecha Captura]FROM vstPartidasCompradas"
        Else
            strqry = "SELECT idCompra as Compra,strReferenciaProveedor as [Ref.Proveedor],strNombreProveedor as Proveedor,dtFechaCompra as [Fecha Compra],strRazonSocialEmpresa as [Empresa Compradora]," &
"CantidadComprada As Cantidad,strUnidadMedida As [U/M],strDescripcionProducto As Producto,PrecioUnitarioCompra As [P.Unitario],dtIngresoSistemaCompra As [Fecha Captura]FROM vstPartidasCompradas where strDescripcionProducto LIKE '%" & tbProducto.Text & "%'"

        End If
        Dim dsDatos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")

        If dsDatos.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To dsDatos.Tables(0).Rows.Count - 1

                dgvProductos.Rows.Add(dsDatos.Tables(0).Rows(i)(0), dsDatos.Tables(0).Rows(i)(1), dsDatos.Tables(0).Rows(i)(2), dsDatos.Tables(0).Rows(i)(3),
                                  dsDatos.Tables(0).Rows(i)(4), dsDatos.Tables(0).Rows(i)(5), dsDatos.Tables(0).Rows(i)(6), dsDatos.Tables(0).Rows(i)(7), dsDatos.Tables(0).Rows(i)(8), dsDatos.Tables(0).Rows(i)(9))

            Next

        End If
    End Sub

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

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Iniciar()
    End Sub

    Private Sub CompraProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantReporteComprasProducto = False
    End Sub

    Private Sub tbProducto_Click(sender As Object, e As EventArgs) Handles tbProducto.Click
        tbProducto.Text = ""
    End Sub

#End Region

    Private Sub btnListado_Click(sender As System.Object, e As System.EventArgs) Handles btnListado.Click
        If idProducto = 0 Then strCompProducto = " " Else strCompProducto = " and idProducto = " & idProducto
        If idProveedor = 0 Then strCompProveedor = " " Else strCompProveedor = " and idProveedor = " & idProveedor
        strCompFecha = ObtenerRangoFechas()
        Dim strqry As String = strSeleccion & strCompEmpresa & strCompProducto & strCompProveedor & strCompFecha & strCompGroup
        'MsgBox(strqry)
        PrepararDGV(dgvProductos)
        LlenarDataGrid(strqry, dgvProductos)
    End Sub

    Private Sub CompraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararForm(Me)
        Inicio()
    End Sub

    Private Sub Inicio()
        idProducto = 0 : idEmpresa = 0 : idProveedor = 0
        cbEmpresa.Text = "TODAS"
        strCompEmpresa = " WHERE intEmpresa > 0 "
        strCompFecha = "" : strCompProducto = "" : strCompProveedor = "" : strCompGroup = ""
        strSeleccion = "SELECT idCompra as Compra,strReferenciaProveedor as [Ref.Proveedor],strNombreProveedor as Proveedor,dtFechaCompra as [Fecha Compra],strRazonSocialEmpresa as [Empresa Compradora]," &
    "CantidadComprada As Cantidad,strUnidadMedida As [U/M],strDescripcionProducto As Producto,PrecioUnitarioCompra As [P.Unitario],dtIngresoSistemaCompra As [Fecha Captura] FROM vstPartidasCompradas"
        strCompGroup = ""

        LimpiarDataGrid(dgvProductos)
    End Sub

    Private Sub tbProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbProveedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProveedor.TextChanged
        Dim intLargo As Integer = Len(tbProveedor.Text)
        If intLargo >= 4 Then
            Dim strqry As String = "SELECT IDProveedor,strNombreProveedor  FROM tblCatProveedores where strNombreProveedor like '%" & tbProveedor.Text & "%' order by strNombreProveedor "
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub chkAgrupar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAgrupar.CheckedChanged
        If chkAgrupar.Checked = False Then
            strSeleccion = "SELECT idCompra as Compra,strReferenciaProveedor as [Ref.Proveedor],strNombreProveedor as Proveedor,dtFechaCompra as [Fecha Compra],strRazonSocialEmpresa as [Empresa Compradora]," &
                "CantidadComprada As Cantidad,strUnidadMedida As [U/M],strDescripcionProducto As Producto,PrecioUnitarioCompra As [P.Unitario],dtIngresoSistemaCompra As [Fecha Captura] FROM vstPartidasCompradas"
            strCompGroup = ""
        End If

        If chkAgrupar.Checked = True Then
            strCompGroup = " group by strNombreProveedor, PrecioUnitarioCompra, strUnidadMedida, strDescripcionProducto "
            strSeleccion = "SELECT strNombreProveedor as Proveedor, sum(CantidadComprada) As Cantidad,strUnidadMedida As [U/M],strDescripcionProducto As Producto,PrecioUnitarioCompra As [P.Unitario] FROM vstPartidasCompradas "
        End If

    End Sub

    Private Sub cbEmpresa_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpresa.SelectedValueChanged
        Select Case cbEmpresa.Text
            Case "TODAS"
                strCompEmpresa = " WHERE intEmpresa > 0 "
            Case "QUART INDUSTRIA"
                strCompEmpresa = " WHERE intEmpresa = 1 "
            Case "AARON URDIALES"
                strCompEmpresa = " WHERE intEmpresa = 2 "
        End Select
    End Sub

    Private Sub cbProveedor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbProveedor.KeyUp
        Dim intLargo As Integer = Len(cbProveedor.Text)
        If intLargo > 3 Then
            Dim strqry As String = "SELECT IDProveedor,strNombreProveedor  FROM tblCatProveedores " &
                " where strNombreProveedor like '%" & cbProveedor.Text & "%' order by strNombreProveedor "
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cbProveedor_Click(sender As Object, e As EventArgs) Handles cbProveedor.Click

    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedor.SelectedIndexChanged
        If cbProveedor.DataSource IsNot Nothing Then
            idProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
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

    Private Function ObtenerRangoFechas() As String
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

        Return strComplemento2

    End Function



    Private Sub cbProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            idProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            cbProveedor.DroppedDown = False
            'CargarComboUnidadMedida()
        End If
    End Sub

    Private Sub tbProd_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProd.TextChanged
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

    Private Sub tbProveedor_Click(sender As System.Object, e As System.EventArgs) Handles tbProveedor.Click
        LimpiarCombo(cbProveedor)
        idProveedor = 0
        tbProveedor.Text = ""
    End Sub

    Private Sub tbProd_Click(sender As System.Object, e As System.EventArgs) Handles tbProd.Click
        LimpiarCombo(cbProducto)
        idProducto = 0
        tbProd.Text = ""
    End Sub
End Class