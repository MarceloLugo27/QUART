Imports QuartOK.ProcedimientosGenerales

Public Class frmInventario

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Actualiza()
    End Sub

    Private Sub Actualiza()
        PrepararDGV(dgvInventario)
        Dim strqry As String

        If tbProducto.Text = "" Then
            strqry = "Select [strCodProdQuart] as [Num. Prod. Q],[intCantidad] as Cantidad,[strUnidadMedida] as [U.M.],[strDescripcionProducto] as [Nombre del Producto],[strMarcaProducto] as Marca,[strModelo] as Modelo from vstInventario"
        Else
            strqry = "Select [strCodProdQuart] as [Num. Prod. Q],[intCantidad] as Cantidad,[strUnidadMedida] as [U.M.],[strDescripcionProducto] as [Nombre del Producto],[strMarcaProducto] as Marca,[strModelo] as Modelo from vstInventario where strDescripcionProducto like '%" & tbProducto.Text & "%' "
        End If

        LlenarDataGrid(strqry, dgvInventario)
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

                For i = 0 To dgvInventario.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvInventario.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvInventario.Columns.Count - 1
                    For j = 0 To dgvInventario.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvInventario(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

    Private Sub frmInventario_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantInventario = False
    End Sub

    Private Sub frmInventario_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If
        Actualiza()

    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbProducto_Click(sender As System.Object, e As System.EventArgs) Handles tbProducto.Click
        tbProducto.Text = ""
    End Sub
End Class