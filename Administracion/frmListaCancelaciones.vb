Imports QuartOK.ProcedimientosGenerales

Public Class frmListaCancelaciones
    Dim strConsulta As String
    Dim intDocumento As Integer

#Region "cargar Form"

    Private Sub frmListaCancelaciones_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantListaCancelaciones = False
    End Sub

    Private Sub frmListaCancelaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If

        Iniciar()
    End Sub

    Private Sub Iniciar()
        cbDocumento.Text = "COMPRAS"
        cbEmpresa.Text = "TODAS"
        LimpiarDataGrids()
        intDocumento = 0
    End Sub

    Private Sub LimpiarDataGrids()
        dgvDocumentos.DataSource = Nothing
        dgvDocumentos.Rows.Clear()
        dgvDocumentos.Columns.Clear()
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
    End Sub

    Private Sub cbDocumento_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbDocumento.SelectedValueChanged
        LimpiarDataGrids()
    End Sub

    Private Sub cbEmpresa_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpresa.SelectedValueChanged
        LimpiarDataGrids()
    End Sub

#End Region

#Region "Cambio en Fechas"
    Private Sub cbFiltro_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbFiltro.SelectedValueChanged
        LimpiarDataGrids()
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

#End Region

#Region "Consultar"

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Dim strqry As String
        Dim strCampoFecha As String
        Dim strOrden As String
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

        PrepararDGV(dgvDocumentos)
        If cbDocumento.Text = "COMPRAS" Then
            strqry = "SELECT Id, [Num Compra], [Fecha Cancelacion], Proveedor, [Fecha Compra], " &
                    " strReferenciaProveedor as [Referecia Proveedor], strRazonSocialEmpresa as Empresa, " &
                    " [Usuario Cancelo], [Usuario Reviso], [MontoAntesIVA] as SubTotal, IVA, Total FROM  vstComprasCanceladas "
            strCampoFecha = " [Fecha Cancelacion] "
            strOrden = " order by [Id] desc"
        Else
            strqry = "SELECT  ID, [Num Venta], [Fecha Cancelacion], [Cliente], [Fecha Venta], " &
                " [strDocumentoReferencia] as [Docuemnto Referencia], strRazonSocialEmpresa as Empresa, " &
                " [Usuario Cancelo], [Usuario Reviso], [MontoAntesIVA] as SubTotal, IVA, Total FROM vstVentasCanceladas "
            strCampoFecha = " [Fecha Cancelacion] "
            strOrden = " ORDER BY id DESC "
        End If

        Dim strComplemento1 As String = " "

        Dim strComplemento2 As String = ""
        Dim dtFecha1 As String = ""
        Dim dtFecha2 As String = ""

        Select Case cbFiltro.Text
            Case "TODAS"
                strComplemento2 = ""
            Case "El día de hoy"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & " >=  '" & dtFecha1 & " 00:00' "
            Case "Esta semana"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Las ultimas dos semanas"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "Este Mes"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El mes pasado"
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
            Case "El día de..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha1 & " 23:59:59' "
            Case "Entre los dias..."
                dtFecha1 = Microsoft.VisualBasic.Left(Format(dtFechaInicial.Value, "dd/MM/yyyy"), 10)
                dtFecha2 = Microsoft.VisualBasic.Left(Format(dtFechaFinal.Value, "dd/MM/yyyy"), 10)
                strComplemento2 = " where " & strCampoFecha & "  between '" & dtFecha1 & " 00:00'  and '" & dtFecha2 & " 23:59:59' "
        End Select

        strConsulta = strqry & " " & strComplemento1 & " " & strComplemento2 & strOrden

        LlenarDataGrid(strConsulta, dgvDocumentos)

        'ProcedimientosGenerales.GrabarAccion(7)

    End Sub

#End Region

#Region "Cargar Partidas"

    Private Sub dgvDocumentos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentos.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            PrepararDGV(dgvPartidas)
            intDocumento = dgvDocumentos.Rows(intRenglon).Cells(0).Value
        End If
        If intDocumento > 0 Then
            Dim strqry As String = ""
            Dim dsComentario As New DataSet
            'strqry = "Select strMotivoCancelacion from tblCancelaciones where idCancelacion = " & intDocumento
            'dsComentario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al localizar Cancelacion")
            'lblMotivo.Text = dsComentario.Tables(0).Rows(0)(0).ToString
            If cbDocumento.Text = "COMPRAS" Then
                strqry = "SELECT intPartida as Partida,CantidadComprada as Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitarioCompra as Precio " &
                     " FROM vstPartidasCompradasCanceladas where idCancelacion = " & intDocumento & " order by intPartida "

            Else
                strqry = "SELECT intPartida as Partida,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto, " &
                    " PrecioUnitario as Precio FROM vstTransaccionesVentaCanceladas where idCancelacion = " & intDocumento & " order by intPartida "
            End If
            LlenarDataGrid(strqry, dgvPartidas)
        End If
    End Sub

#End Region

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

                For i = 0 To dgvDocumentos.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvDocumentos.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvDocumentos.Columns.Count - 1
                    For j = 0 To dgvDocumentos.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvDocumentos(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

End Class