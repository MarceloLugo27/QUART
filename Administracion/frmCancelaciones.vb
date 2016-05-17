Imports QuartOK.ProcedimientosGenerales

Public Class frmCancelaciones

    Dim strConsulta As String
    Dim intIdDocumento As Integer

#Region "Carga del Form"

    Private Sub frmCancelaciones_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantCancelarDocumento = False
    End Sub

    Private Sub frmCancelaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Private Sub Iniciar()
        cbDocumento.Text = "COMPRAS"
        lblCuenta.Text = "0"
        tbMotivo.Text = ""
        dgvDocumentos.DataSource = Nothing
        dgvDocumentos.Rows.Clear()
        dgvDocumentos.Columns.Clear()
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
        btnCancelar.Enabled = False
        intIdDocumento = 0
    End Sub

    Private Sub cbDocumento_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbDocumento.SelectedValueChanged
        dgvDocumentos.DataSource = Nothing
        dgvDocumentos.Rows.Clear()
        dgvDocumentos.Columns.Clear()
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Iniciar()
    End Sub

#End Region

#Region "Cambio en Fechas"
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

#End Region

#Region "Cargar Listas de Documentos y Partidas"
    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Dim strqry As String
        Dim strCampoFecha As String
        Dim strOrden As String
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()

        PrepararDGV(dgvDocumentos)
        If cbDocumento.Text = "COMPRAS" Then
            strqry = "SELECT IDProveedor as [Num Proveedor], strNombreProveedor as [Nombre del Proveedor], dtFechaCompra as [Fecha de Compra], " &
                                        " strReferenciaProveedor as [Referecia Proveedor], idCompra as [Num Compra], strRazonSocialEmpresa as Empresa, " &
                                        " strNombreUsuario as Comprador FROM  vstCompras "
            strCampoFecha = " dtFechaCompra "
            strOrden = " order by idCompra desc"
        Else
            strqry = "SELECT  IDCliente as [Num Cliente], strNombreCliente as [Nombre del Cliente], dtFechaVentaXML as [Fecha de Venta], " &
                                   " strIdFactura as [Factura], idVenta as [Num Venta], strRazonSocialEmpresa as Empresa, strNombreUsuarioVenta as Vendedor, " &
                                   " deFechaOrdenSalida as [Fecha Salida Almacen], strNombreUsuarioAlmacen as [Entregó Mercancía], MontoAntesIVA as SubTotal, " &
                                   " IVA, Total FROM  vstOrdenesSalida "
            strCampoFecha = " dtFechaIngresoSistema "
            strOrden = " ORDER BY idVenta DESC "
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

    Private Sub dgvDocumentos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentos.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intIdDocumento = dgvDocumentos.Rows(intRenglon).Cells(4).Value
            LlenardgvPartidas(intIdDocumento)
        End If
    End Sub

    Private Sub LlenardgvPartidas(ByRef intDocumento As Integer)
        Dim strqry As String
        PrepararDGV(dgvPartidas)
        If cbDocumento.Text = "COMPRAS" Then
            strqry = "SELECT intPartida as Partida, CantidadComprada as Cantidad, strUnidadMedida as [Unid_Med], strDescripcionProducto as Producto, " &
                                    "PrecioUnitarioCompra  as [Precio Unitario], IDProducto as ID_Producto, PKUnidadMedida as [U/M] FROM vstPartidasCompradas  where idCompra = " & intDocumento &
                                    " order by intPartida"

        Else
            strqry = "SELECT intPartida as Partida, Cantidad, strUnidadMedida as [Unid_Med], strDescripcionProducto as Producto, " &
                                "PrecioUnitario  as [Precio Unitario], IDProducto as ID_Producto, PKUnidadMedida as [U/M] FROM vstTransaccionesVenta  where idVenta = " & intDocumento &
                                " ORDER BY intPartida"

        End If

        LlenarDataGrid(strqry, dgvPartidas)

    End Sub

#End Region

#Region "Texto de Motivo de Cancelacion"

    Private Sub tbMotivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbMotivo.TextChanged
        lblCuenta.Text = Len(tbMotivo.Text).ToString
        If Len(tbMotivo.Text) > 29 Then
            btnCancelar.Enabled = True
            lblCuenta.Font = New Font(Label1.Font, FontStyle.Bold)
        Else
            btnCancelar.Enabled = False
            lblCuenta.Font = New Font(Label1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub tbMotivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMotivo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Dim strqry As String = ""
        If intIdDocumento > 0 Then
            Me.Enabled = False
            If cbDocumento.Text = "COMPRAS" Then
                strqry = "UPDATE tblListaCompras SET intVarControlCompra = 0 WHERE idCompra = " & intIdDocumento
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No pudo eliminarse la Compra")
                For i = 0 To dgvPartidas.Rows.Count - 1 Step 1

                    strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvPartidas.Rows(i).Cells(5).Value &
                        " and idUnidadMedida = " & dgvPartidas.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                    Dim dsExiste As New DataSet
                    dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al buscar Invetario existente")

                    strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) -
                        Decimal.Parse(dgvPartidas.Rows(i).Cells(1).Value) &
                        " where IdProducto = " & dgvPartidas.Rows(i).Cells(5).Value &
                        " and idUnidadMedida = " & dgvPartidas.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al actualizar inventario.")
                    dgvPartidas.Item(1, i).Style.BackColor = Color.Green
                    Pausa(50)
                Next

                strqry = "INSERT INTO tblCancelaciones (strTipoDocumento,intIdDocumento,strMotivoCancelacion,intUsuarioCancela) " &
                    "VALUES ('COMPRA', " & intIdDocumento & ", '" & tbMotivo.Text & "', " & intUsuario & ") "
                Dim idCancela As Long = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No pudo registrarse movimiento de cancelación")

                GrabarAccion(22, idCancela)

                MsgBox("Documento de Compra cancelado")

            Else
                strqry = "UPDATE tblListaVentas SET intVarControlVenta = 0 WHERE idVenta = " & intIdDocumento
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No pudo eliminarse la Venta")

                strqry = "SELECT intUsuarioOrdenSalida from tblListaVentas WHERE idVenta = " & intIdDocumento
                Dim dsSurtido As New DataSet
                dsSurtido = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al verificar si el pedido esta surtido")
                If dsSurtido.Tables(0).Rows(0)(0) > 0 Then
                    For i = 0 To dgvPartidas.Rows.Count - 1 Step 1
                        strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvPartidas.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvPartidas.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                        Dim dsExiste As New DataSet
                        dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al buscar Invetario existente")

                        strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) +
                            Decimal.Parse(dgvPartidas.Rows(i).Cells(1).Value) &
                            " where IdProducto = " & dgvPartidas.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvPartidas.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al actualizar inventario.")
                        dgvPartidas.Item(1, i).Style.BackColor = Color.Green
                        Pausa(50)
                    Next
                End If
                strqry = "INSERT INTO tblCancelaciones (strTipoDocumento,intIdDocumento,strMotivoCancelacion,intUsuarioCancela) " &
                        "VALUES ('VENTA', " & intIdDocumento & ", '" & tbMotivo.Text & "', " & intUsuario & ") "
                Dim idCancela As Long = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No pudo registrarse movimiento de cancelación")

                GrabarAccion(23, idCancela)

                MsgBox("Documento de Venta Cancelado")

            End If
            Me.Enabled = True
            Me.Focus()
        End If
        Iniciar()
    End Sub

End Class