Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class frmValorInventario

    Private Sub AjustarDGVProductos()

        dgvProductos.DataSource = Nothing
        dgvProductos.Columns.Clear()
        dgvProductos.Rows.Clear()

        dgvProductos.AllowUserToOrderColumns = False

        dgvProductos.Columns.Add("Cod. Producto", "Cod. Producto")
        dgvProductos.Columns.Add("Nombre producto", "Nombre producto")
        dgvProductos.Columns.Add("UnidadMedida", "U.M.")
        dgvProductos.Columns.Add("Cantidad", "Cantidad")
        dgvProductos.Columns.Add("Precio compra", "Precio compra")
        dgvProductos.Columns.Add("Valor de inventario", "Valor de inventario")
        dgvProductos.Columns.Add("Precio venta", "Precio venta")
        dgvProductos.Columns.Add("Valor de venta", "Valor de venta")
        'dgvProductos.Columns.Add("Importe", "Importe")
        'dgvProductos.Columns.Add("IdUM", "")
        ''...
        'dgvProductos.Columns.Add("Cancela", "Cancelar Partida")
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'dgvProductos.Columns(0).Width = 60
        'dgvProductos.Columns(1).Width = 60
        'dgvProductos.Columns(2).Width = 80

        'dgvProductos.Columns(3).Width = 0
        'dgvProductos.Columns(4).Width = 400
        'dgvProductos.Columns(5).Width = 120
        'dgvProductos.Columns(6).Width = 120
        '...
        'dgvProductos.Columns(7).Width = 120

        dgvProductos.Visible = True

    End Sub

    Private Sub Iniciar()
        AjustarDGVProductos()

        Dim decTotalValorInventario As Decimal
        Dim decMaximoValorInventario As Decimal

        Dim strqry As String
        strqry = "Select strCodProdQuart, strDescripcionProducto, strUnidadMedida, intCantidad, decPrecioCompra, ValorInventario, decPrecioVenta, ValorVenta FROM vstInventarioCosteado"
        Dim dsDatos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")

        If dsDatos.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To dsDatos.Tables(0).Rows.Count - 1

                dgvProductos.Rows.Add(dsDatos.Tables(0).Rows(i)(0), dsDatos.Tables(0).Rows(i)(1), dsDatos.Tables(0).Rows(i)(2), dsDatos.Tables(0).Rows(i)(3),
                                  dsDatos.Tables(0).Rows(i)(4), dsDatos.Tables(0).Rows(i)(5), dsDatos.Tables(0).Rows(i)(6), dsDatos.Tables(0).Rows(i)(7))
                decTotalValorInventario = decTotalValorInventario + dsDatos.Tables(0).Rows(i)(5)
                decMaximoValorInventario = decMaximoValorInventario + dsDatos.Tables(0).Rows(i)(7)
            Next

            Label1.Text = FormatCurrency(decTotalValorInventario)
            Label2.Text = FormatCurrency(decMaximoValorInventario)

        End If
    End Sub


    Private Sub frmValorInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Private Sub frmValorInventario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantValoresInventario = False
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
End Class