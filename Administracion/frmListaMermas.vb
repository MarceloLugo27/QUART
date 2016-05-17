Imports QuartOK.ProcedimientosGenerales

Public Class frmListaMermas

    Dim intMerma As Integer
    Dim strConsulta As String
    Dim intRevision As Integer

    Private Sub frmListaMermas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If
        Iniciar()
    End Sub

    Private Sub Iniciar()
        cbEstado.Text = "TODAS"
        LimpiarDataGrid(dgvMermas)
        intMerma = 0
        lblRazon.Text = ""
        lblComentarios.Text = ""
        LimpiarDataGrid(dgvMermas)
    End Sub

#Region "Cambio en Fechas"
    Private Sub cbFiltro_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbFiltro.SelectedValueChanged
        LimpiarDataGrid(dgvMermas)
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
        Dim strqry As String = ""
        Dim strCampoFecha As String
        Dim strOrden As String
        Dim strComplemento1 As String = " "
        LimpiarDataGrid(dgvMermas)
        PrepararDGV(dgvMermas)
        Dim strEstado As String
        strEstado = cbEstado.Text
        Select Case strEstado
            Case "TODAS"
                strComplemento1 = " and intVarControl = 1 "
            Case "REPORTADAS"
                strComplemento1 = " and intVarControl = 1 and intStatusMerma = 0 "
            Case "CON CARGO"
                strComplemento1 = " and intVarControl = 1 and intStatusMerma = 1 "
            Case "PERDIDA"
                strComplemento1 = " and intVarControl = 1 and intStatusMerma = 2 "
        End Select

        strqry = "SELECT idttyMerma as ID,strDescripcionProducto as Producto,strUnidadMedida as [U/M],decCantidad as Cantidad," &
            "dtFechaEvento as [Fecha Evento],UsuarioRegistra as [Usuario Registra],UsuarioEvalua as [Usuario Evalua],strStatusMerma as Estado from vstListadoMermas "

        strCampoFecha = " dtFechaEvento "
        strOrden = " order by idttyMerma desc"

        Dim strComplemento2 As String = ""
        Dim dtFecha1 As String = ""
        Dim dtFecha2 As String = ""

        Select Case cbFiltro.Text
            Case "TODAS"
                strComplemento2 = " where " & strCampoFecha & " >=  '1990-01-01 00:00' "
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

        strConsulta = strqry & " " & strComplemento2 & " " & strComplemento1 & " " & strOrden

        LlenarDataGrid(strConsulta, dgvMermas)

        'ProcedimientosGenerales.GrabarAccion(7)

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

                For i = 0 To dgvMermas.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvMermas.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvMermas.Columns.Count - 1
                    For j = 0 To dgvMermas.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvMermas(i, j).Value
                    Next
                Next
                obj_Excel.ActiveWorkbook.SaveAs(strArchivo)
                obj_Excel.Visible = True
            Catch ex As Exception
                MessageBox.Show("Problemas para exportar a Excel")
            End Try
        End If
    End Sub

    Private Sub frmListaMermas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantListadoMerma = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

    Private Sub dgvMermas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMermas.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intRevision = dgvMermas.Rows(intRenglon).Cells(0).Value
        End If
        If intRevision > 0 Then
            Dim strqry As String = ""
            Dim dsComentario As New DataSet
            strqry = "Select strRazon, strComentariosEvaluacion from vstListadoMermas where idttyMerma = " & intRevision
            dsComentario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al localizar Cancelacion")
            lblRazon.Text = dsComentario.Tables(0).Rows(0)(0).ToString
            lblComentarios.Text = dsComentario.Tables(0).Rows(0)(1).ToString

        End If
    End Sub

End Class