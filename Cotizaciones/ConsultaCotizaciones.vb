Imports QuartOK.ProcedimientosGenerales

Public Class frmConsultaCotizaciones
    Dim intCotizacion As Integer
    Dim strConsulta As String
    Dim intCliente As String

    Private Sub dgvCotizaciones_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCotizaciones.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intCotizacion = dgvCotizaciones.Rows(intRenglon).Cells(4).Value
            LlenardgvPartidas(intCotizacion)
        End If
    End Sub

    Private Sub LlenardgvPartidas(ByRef intCotizacion As Integer)

        PrepararDGV(dgvPartidas)
        Dim strqry As String = "SELECT intPartida as Partida, Cantidad, strUnidadMedida as [Unid_Med], strDescripcionProducto as Producto, " &
                                "PrecioUnitario  as [Precio Unitario] FROM vstPartidasCotizadas  where idCotizacion = " & intCotizacion &
                                " ORDER BY intPartida"
        LlenarDataGrid(strqry, dgvPartidas)

    End Sub
    Private Sub Iniciar()
        'CargardgvCotizaciones()
        tbCliente.Text = ""

        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
        cbCliente.DataSource = Nothing
        cbCliente.Items.Clear()

        dtFechaInicial.Enabled = False
        dtFechaFinal.Enabled = False
        dgvCotizaciones.DataSource = Nothing
        dgvCotizaciones.Rows.Clear()
        dgvCotizaciones.Columns.Clear()

        tbCliente.Focus()
    End Sub
    Private Sub frmConsultaCotizaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MDIPrincipal.PermisoExportarExcel = False Then
            btnExportarExcel.Visible = False
        End If
        If MDIPrincipal.PermisoReimpresion = False Then
            btnImprimirCotizacion.Visible = False
        End If
        Iniciar()

    End Sub

    Private Sub CargardgvCotizaciones()
        PrepararDGV(dgvCotizaciones)
        Dim strqry As String = "SELECT IDCliente as [Num Cliente], strNombreCliente as [Nombre del Cliente], dtFechaIngresoSistema as [Fecha Cotización], " &
                                    " strReferenciaCliente as [Referecia Cliente], idCotizacion as [Num Cotización], strRazonSocialEmpresa as Empresa, strNombreUsuario as vendedor FROM  vstCotizaciones"
        LlenarDataGrid(strqry, dgvCotizaciones)
        intCotizacion = 0
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        ' CargardgvCotizaciones()
        Iniciar()

    End Sub

    Private Sub btnImprimirCotizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirCotizacion.Click
        ProcedimientosGenerales.GrabarAccion(4, intCotizacion)
        Cotizar.ImprimirCotizacion(intCotizacion)
    End Sub

    Private Sub frmConsultaCotizaciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantConsultaCotizaciones = False
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

        PrepararDGV(dgvCotizaciones)
        Dim strqry As String = "SELECT  IDCliente as [Num Cliente], strNombreCliente as [Nombre del Cliente], dtFechaIngresoSistema as [Fecha Cotización], " &
                                    " strReferenciaCliente as [Referecia Cliente], idCotizacion as [Num Cotización], strRazonSocialEmpresa as Empresa, strNombreUsuario as vendedor FROM  vstCotizaciones "

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

        strConsulta = strqry & " " & strComplemento1 & " " & strComplemento2 & " order by idCotizacion desc"

        LlenarDataGrid(strConsulta, dgvCotizaciones)
        intCotizacion = 0
        ProcedimientosGenerales.GrabarAccion(5)

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

    Private Sub cbCliente_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbCliente.KeyUp
        Dim intLargo As Integer = Len(cbCliente.Text)
        If intLargo > 3 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & cbCliente.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.DataSource IsNot Nothing Then
            intCliente = DirectCast(cbCliente.SelectedItem, DataRowView).Item("IDCliente")
            'Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes  where IDCliente = " & intCliente
            'Dim dsTipo As New DataSet
            'dsTipo = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            'intTipoCliente = dsTipo.Tables(0).Rows(0).Item(0)
        End If
    End Sub

    Private Sub tbCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbCliente.TextChanged
        Dim intLargo As Integer = Len(tbCliente.Text)
        If intLargo >= 4 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & tbCliente.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub tbCliente_Click(sender As System.Object, e As System.EventArgs) Handles tbCliente.Click
        tbCliente.Text = ""
        cbCliente.DataSource = Nothing
        cbCliente.Items.Clear()
        tbCliente.Focus()
        intCliente = 0
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

                For i = 0 To dgvCotizaciones.Columns.Count - 1
                    obj_hoja.Range(LETEXCEL(i) & "1").Value = dgvCotizaciones.Columns(i).HeaderText
                Next

                obj_hoja.Range("A1:N1").Font.Bold = True

                Dim j As Integer
                'Recorremos el datagridview (dtg) i exportamos celda a celda
                For i = 0 To dgvCotizaciones.Columns.Count - 1
                    For j = 0 To dgvCotizaciones.RowCount - 1
                        obj_hoja.range(LETEXCEL(i) & j + 2).value = dgvCotizaciones(i, j).Value
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