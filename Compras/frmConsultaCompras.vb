Imports QuartOK.ProcedimientosGenerales

Public Class frmConsultaCompras

    Dim intCompra As Integer
    Dim strConsulta As String
    Dim intProveedor As String

    Private Sub frmConsultaCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If
        If MDIPrincipal.PermisoReimpresion = False Then
            btnImprimirCotizacion.Visible = False
        End If

        Iniciar()
    End Sub

    Private Sub Iniciar()
        'CargardgvCotizaciones()
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
        cbProveedor.DataSource = Nothing
        dtFechaInicial.Enabled = False
        dtFechaFinal.Enabled = False
        dgvCompras.DataSource = Nothing
        dgvCompras.Rows.Clear()
        dgvCompras.Columns.Clear()
        intCompra = 0
        tbProveedor.Text = ""
        tbProveedor.Focus()
    End Sub

    Private Sub frmConsultaCompras_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantListadoEntredaAlmacen = False
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

    Private Sub cbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedor.SelectedIndexChanged
        If cbProveedor.DataSource IsNot Nothing Then
            intProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
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

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click

        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

        PrepararDGV(dgvCompras)
        Dim strqry As String = "SELECT IDProveedor as [Num Proveedor], strNombreProveedor as [Nombre del Proveedor], dtFechaCompra as [Fecha de Compra], " &
                                    " strReferenciaProveedor as [Referecia Proveedor], idCompra as [Num Compra], strRazonSocialEmpresa as Empresa, " &
                                    " strNombreUsuario as Comprador, MontoAntesIVA, IVA, Total FROM  vstCompras "
        Dim strComplemento1 As String

        If intProveedor = 0 Then
            strComplemento1 = " where IDProveedor > 0 "
        Else
            strComplemento1 = " where IDProveedor = " & intProveedor
        End If

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

        strConsulta = strqry & " " & strComplemento1 & " " & strComplemento2 & " order by idCompra desc"

        LlenarDataGrid(strConsulta, dgvCompras)
        intCompra = 0

        ProcedimientosGenerales.GrabarAccion(7)

    End Sub

    Private Sub dgvCompras_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCompras.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intCompra = dgvCompras.Rows(intRenglon).Cells(4).Value
            LlenardgvPartidas(intCompra)
        End If
    End Sub

    Private Sub LlenardgvPartidas(ByRef intCotizacion As Integer)

        PrepararDGV(dgvPartidas)
        Dim strqry As String = "SELECT intPartida as Partida, CantidadComprada as Cantidad, strUnidadMedida as [Unid_Med], strDescripcionProducto as Producto, " &
                                "PrecioUnitarioCompra  as [Precio Unitario] FROM vstPartidasCompradas  where idCompra = " & intCotizacion &
                                " order by intPartida"
        LlenarDataGrid(strqry, dgvPartidas)

    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Iniciar()
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged

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

    Private Sub btnImprimirCotizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirCotizacion.Click
        Compra.ImprimirEntradaAlmacen(intCompra)
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click

        Dim obj_Excel As Object
        Dim obj_hoja As Object
        Dim obj_libro As Object

        Dim LETEXCEL() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q"}

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

                For i = 0 To dgvCompras.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvCompras.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:Q1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvCompras.Columns.Count - 1
                    For j = 0 To dgvCompras.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvCompras(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

    Private Sub tbProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class