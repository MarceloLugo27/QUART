Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports QuartOK.ProcedimientosGenerales

Public Class Cotizar

#Region "Variables"

    Dim lblPartida() As Label
    Dim cmbProducto() As ComboBox
    Dim cmbUnidadMedida() As ComboBox
    Dim mtbCantidad() As MaskedTextBox
    Dim mtbPrecioUnitario() As MaskedTextBox

    Friend WithEvents btnSiguiente As Button
    Dim btnOtro() As Button

    Dim VariacionRenglon As Integer = 30
    Dim xInicial As Integer
    Dim yInicial As Integer

    Dim intContadorPartidas As Integer
    Dim intCliente As Integer = 0
    Dim intTipoCliente As Integer = 0
    Dim intProducto As Integer = 0
    Dim intUnidadMedida As Integer
    Dim decCantidad As Decimal
    Dim decPrecioUnitario As Decimal
    Dim decTotal As Decimal

    Dim intEmpresa As Integer = 0
    Dim strCatProdQuart As String = ""

    Dim intProductoD As Integer
    Dim strCodProdQuart As String
    Dim intUnidadMedidaD As Integer
    Dim intProveedor As Integer

    Dim strClienteQuart As String
    Dim strClienteQuartD As String

    Dim intRenglonModificar As Integer = 0
    Dim intAgregarIVA As Integer

    Dim intProductoCambiar As Integer

    Dim intCotizacionFuente As Integer
    Dim intClienteCotizacionFuente As Integer

#End Region

#Region "Iniciar Formato"

    Private Sub TamañoInicalForm()
        Me.Size = New System.Drawing.Size(870, 648)
    End Sub

    Private Sub TamañoGrandeForm()
        Me.Size = New System.Drawing.Size(1220, 648)
    End Sub

    Private Sub Compra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbTodo.Enabled = False

        'tabcontrol para apoyos
        'tcApoyos.Visible = True
        'tcApoyos.Enabled = True
        'tpClienteD.Visible = False
        ''gbClienteD.Enabled = False
        'tpProductoD.Visible = False
        'tpModificarPartida.Visible = False
        'tpRepetirCotizacion.Visible = False

        'tpProductoD.Enabled = False
        'tpModificarPartida.Enabled = False
        'tpRepetirCotizacion.Enabled = False

        lblEmpresa.Text = ""
        lblEmpresa.Visible = False
        Iniciar()
        TamañoInicalForm()
    End Sub

    Private Sub Iniciar()
        intContadorPartidas = 1
        dgvProductos.Visible = False

        IniciarVariablesUnicas()
        'IniciarVariablesRecurrentes()
        'CargarComboClientes()
        btnIniciarCompraDatagrid.Enabled = True
        dgvProductos.Rows.Clear()

        If dgvProductos.Columns.Count >= 1 Then
            Dim CantColumns As Integer = dgvProductos.Columns.Count - 1
            For i As Integer = CantColumns To 0 Step -1
                dgvProductos.Columns.RemoveAt(i)
            Next
        End If

        dgvProductos.DataSource = Nothing
        tbCliente.Text = ""
        cbCliente.DataSource = Nothing
        tbReferenciaProveedor.Text = ""
        cbProducto.DataSource = Nothing
        intCliente = 0
        tbProducto.Text = ""
        tbCliente.Focus()
    End Sub

    Private Sub IniciarVariablesUnicas()
        intCliente = 0
        intTipoCliente = 0
        decTotal = 0
        tbCliente.Text = ""
        intContadorPartidas = 1
        gbProductos.Enabled = False
        gbProveedor.Enabled = True
        btnGrabarCotizacion.Enabled = False
        btnCancelar.Enabled = False
        btnVistaPrevia.Enabled = False
    End Sub

    Private Sub IniciarVariablesRecurrentes()
        intProducto = 0
        intUnidadMedida = 0
        decCantidad = 0
        decPrecioUnitario = 0
        mtbCant.Text = ""
        mtbPrecio.Text = ""
        'CargarComboProductos() 'eliminado al incluir el tbProducto
        'las siguentes lineas se incluyen al agregar tbproducto
        'y se eliminan las 3 primeras para no tener que buscar otravez productos similares
        ' cbProducto.Text = ""
        'tbProducto.Text = ""
        'tbProducto.Focus()
        strCatProdQuart = ""
    End Sub

    Private Sub Cotizar_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantNuevaCotizacion = False
    End Sub

#End Region

#Region "Clientes"

    Private Sub chkAgregarIVA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAgregarIVA.CheckedChanged
        If chkAgregarIVA.Checked = True Then
            intAgregarIVA = 1
        Else
            intAgregarIVA = 0
        End If
    End Sub

    Private Sub CargarComboClientes()
        Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes order by strRazonSocialCliente "
        LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCliente.SelectedIndexChanged
        If cbCliente.DataSource IsNot Nothing Then
            intCliente = DirectCast(cbCliente.SelectedItem, DataRowView).Item("IDCliente")
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente, IdTipoCliente, IDClienteQuart, strDomicilio FROM tblCatClientes  where IDCliente = " & intCliente
            Dim dsTipo As New DataSet
            dsTipo = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            intTipoCliente = dsTipo.Tables(0).Rows(0).Item(2)
            strClienteQuart = dsTipo.Tables(0).Rows(0).Item(3)
            tTip.SetToolTip(Me.cbCliente, dsTipo.Tables(0).Rows(0).Item(4).ToString)
            cbCliente.DroppedDown = False
        End If
    End Sub

    Private Sub tbCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbCliente.TextChanged
        Dim intLargo As Integer = Len(tbCliente.Text)
        If intLargo >= 3 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & tbCliente.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbCliente, "IDCliente", "strRazonSocialCliente")
            cbCliente.DroppedDown = True

            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then

        End If
    End Sub

    Private Sub cbCliente_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cbCliente.MouseClick
        tbCliente.Text = ""
    End Sub

#End Region

#Region "Cliente prospecto"

    Private Sub IniciarProcesoClienteNuevo()
        tbColoniaD.Text = ""
        tbContactoD.Text = ""
        tbCorreoD.Text = ""
        tbDomicilioD.Text = ""
        tbEstadoD.Text = ""
        tbMunicipioD.Text = ""
        tbRazonSocialD.Text = ""
        tbTel1D.Text = ""
        tbTel2D.Text = ""
        strClienteQuartD = ""
        tbRazonSocialD.Focus()
    End Sub

    Private Sub btnGrabarClienteD_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarClienteD.Click
        Dim strqry As String
        Dim intNuevo As Integer
        strqry = "INSERT INTO tblListaProvisionales (strTipo,intUsuario) VALUES ('CLI'," & intUsuario & ")"
        intNuevo = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If intNuevo = 0 Then
            MessageBox.Show("No se grabó el cliente. Intente nuevamente")
            Iniciar()
            Exit Sub
        Else
            strClienteQuartD = "C" & intNuevo
        End If

        intNuevo = 0
        strqry = "INSERT INTO tblCatClientes (IDClienteQuart,strNombreCliente,strRazonSocialCliente,strDomicilio,strColonia" &
           ",strMunicipio,strEstado,strTelefono1,strTelefono2,strCorreoElectronico,strNombreContacto" &
           ",IdTipoCliente,intClienteCatalogo,intUsuario) VALUES ('" &
           strClienteQuartD & "','" & tbRazonSocialD.Text & "','" & tbRazonSocialD.Text & "','" & tbDomicilioD.Text & "','" &
           tbColoniaD.Text & "','" & tbMunicipioD.Text & "','" & tbEstadoD.Text & "','" & tbTel1D.Text & "','" & tbTel2D.Text & "','" &
           tbCorreoD.Text & "','" & tbContactoD.Text & "',1,0," & intUsuario & ")"
        intNuevo = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")

        If intNuevo = 0 Then
            MessageBox.Show("No se grabó el cliente. Intente nuevamente")
            Iniciar()
            Exit Sub
        Else
            GrabarAccion(13, intNuevo)
            tbCliente.Text = Microsoft.VisualBasic.Left(tbRazonSocialD.Text, 7)
            'tpClienteD.Enabled = False
            tpClienteD.Visible = False
            TamañoInicalForm()
            IniciarProcesoClienteNuevo()
            gbTodo.Enabled = True
        End If

    End Sub

#End Region

#Region "Copiar Cotizacion"

    Private Sub btnUltimaCotizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnUltimaCotizacion.Click
        If strClienteQuart = "C20999" Then
            MessageBox.Show("No pueden cotizar a clientes no catalogados. Indique los datos delcliente y vuelva a intentar.", "Inicie primero con los datos del prospecto.")
            btnIniciarCompraDatagrid.Focus()
            Exit Sub
        End If

        LimpiarDatagrid(dgvCotizacionesAnteriores)
        LimpiarDatagrid(dgvPartidasAnteriores)
        intCotizacionFuente = 0
        intClienteCotizacionFuente = 0
        tbClienteCotizacionAnterior.Text = cbCliente.Text
        CargarCotizacionesAnteriores(intClienteCotizacionFuente)

        tcApoyos.SelectedTab = tpRepetirCotizacion
        tpRepetirCotizacion.Enabled = True
        tpProductoD.Parent = Nothing
        tpModificarPartida.Parent = Nothing
        tpRepetirCotizacion.Parent = tcApoyos
        tpClienteD.Parent = Nothing

        TamañoGrandeForm()
    End Sub

    Private Sub CargarCotizacionesAnteriores(ByRef intCliente As Integer)
        LimpiarDatagrid(dgvCotizacionesAnteriores)
        PrepararDGV(dgvCotizacionesAnteriores)

        Dim strqry As String = "SELECT top 15 idCotizacion as [Num Cotización], dtFechaIngresoSistema as [Fecha Cotización], " &
                                    "  strNombreUsuario as vendedor FROM  vstCotizaciones  where IDCliente = " & intCliente &
                                    " order by idCotizacion desc "
        LlenarDataGrid(strqry, dgvCotizacionesAnteriores)
        intCotizacionFuente = 0

    End Sub

    Private Sub dgvCotizacionesAnteriores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCotizacionesAnteriores.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intCotizacionFuente = dgvCotizacionesAnteriores.Rows(intRenglon).Cells(0).Value
            LlenardgvPartidas(intCotizacionFuente)
        End If
    End Sub

    Private Sub LlenardgvPartidas(ByRef intCotizacion As Integer)

        PrepararDGV(dgvPartidasAnteriores)
        Dim strqry As String = "SELECT strUnidadMedida as [U/M], strDescripcionProducto as Producto, " &
                                "PrecioUnitario  as [Precio Unitario] FROM vstPartidasCotizadas  where idCotizacion = " & intCotizacion &
                                " ORDER BY intPartida"
        LlenarDataGrid(strqry, dgvPartidasAnteriores)

    End Sub

    Private Sub tbClienteCotizacionAnterior_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbClienteCotizacionAnterior.TextChanged
        Dim intLargo As Integer = Len(tbClienteCotizacionAnterior.Text)
        If intLargo >= 3 Then
            Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente  FROM tblCatClientes where strRazonSocialCliente like '%" & tbClienteCotizacionAnterior.Text & "%' order by strRazonSocialCliente "
            LlenarCombo(strqry, cbClienteCotizacionAnterior, "IDCliente", "strRazonSocialCliente")
            cbClienteCotizacionAnterior.DroppedDown = True

            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbClienteCotizacionAnterior.DataSource = Nothing
            cbClienteCotizacionAnterior.Items.Clear()
        End If
    End Sub

    Private Sub tbClienteCotizacionAnterior_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbClienteCotizacionAnterior.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbClienteCotizacionAnterior_Click(sender As System.Object, e As System.EventArgs) Handles tbClienteCotizacionAnterior.Click

        tbClienteCotizacionAnterior.Text = ""
        'If cbClienteCotizacionAnterior.DataSource IsNot Nothing Then
        '    cbClienteCotizacionAnterior.DataSource = Nothing
        ' cbClienteCotizacionAnterior.Items.Clear()
        'End If

        tbClienteCotizacionAnterior.Focus()
        LimpiarDatagrid(dgvCotizacionesAnteriores)
    End Sub

    Private Sub cbClienteCotizacionAnterior_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles cbClienteCotizacionAnterior.MouseClick
        'tbClienteCotizacionAnterior.Text = cbClienteCotizacionAnterior.Text

        'CargarCotizacionesAnteriores(cbClienteCotizacionAnterior.SelectedIndex)
    End Sub

    Private Sub cbClienteCotizacionAnterior_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbClienteCotizacionAnterior.SelectedValueChanged
        If cbClienteCotizacionAnterior.DataSource IsNot Nothing Then
            intClienteCotizacionFuente = DirectCast(cbClienteCotizacionAnterior.SelectedItem, DataRowView).Item("IDCliente")

            Dim strqry As String = "SELECT  strDomicilio FROM tblCatClientes  where IDCliente = " & intClienteCotizacionFuente
            Dim dsTipo As New DataSet
            dsTipo = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")

            tTip.SetToolTip(Me.cbClienteCotizacionAnterior, dsTipo.Tables(0).Rows(0).Item(0).ToString)

            'Dim strqry As String = "SELECT IDCliente,strRazonSocialCliente, IdTipoCliente, IDClienteQuart FROM tblCatClientes  where IDCliente = " & intCliente
            'Dim dsTipo As New DataSet
            'dsTipo = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            'intTipoCliente = dsTipo.Tables(0).Rows(0).Item(2)
            'strClienteQuart = dsTipo.Tables(0).Rows(0).Item(3)
            'tTip.SetToolTip(Me.cbClienteCotizacionAnterior, dsTipo.Tables(0).Rows(0).Item(1).ToString)
            cbClienteCotizacionAnterior.DroppedDown = False
        End If
        CargarCotizacionesAnteriores(intClienteCotizacionFuente)
        LimpiarDatagrid(dgvPartidasAnteriores)
    End Sub

    Private Sub LimpiarDatagrid(ByRef NombreDataGrid As DataGridView)
        NombreDataGrid.DataSource = Nothing
        NombreDataGrid.Rows.Clear()
        NombreDataGrid.Columns.Clear()
    End Sub

    Private Sub btnSeleccionarCotizacionFuente_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarCotizacionFuente.Click
        If intCotizacionFuente = 0 Then
            MessageBox.Show("Debe seleccionar una cotizacion")
            Exit Sub
        End If
        PreparaGridPartidas()
        CargarCotizacionFuente(intCotizacionFuente)
    End Sub

    Private Sub CargarCotizacionFuente(ByRef intCotizacionAnterior As Integer)
        'MessageBox.Show(intCliente)
        'Dim strqry As String = "Select top 1 idCotizacion from vstCotizaciones where [IDCliente] = " & intCliente & _
        '    " order by idCotizacion desc"
        'Dim dsLista As New DataSet
        'dsLista = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "No se obtuvo el numero de cotización anterior")
        'If dsLista.Tables(0).Rows.Count = 0 Then
        '    MessageBox.Show("Al cliente " & cbCliente.Text & " no se le ha realizado ninguna cotización. Realice una nueva cotización.")
        '    btnIniciarCompraDatagrid.Focus()
        '    Exit Sub
        'End If
        'Dim intCotizacionAnterior As Integer = Integer.Parse(dsLista.Tables(0).Rows(0)(0).ToString)
        'dsLista.Dispose()
        Dim strqry As String
        strqry = "SELECT intPartida, strDescripcionProducto, strUnidadMedida, Cantidad, PrecioUnitario, " &
            "IDProducto, IDUnidadMedida, 'Cancelar Partida', 'Modificar Partida', PrecioUnitario from vstPartidasCotizadas " &
            " where idCotizacion = " & intCotizacionAnterior & " order by intPartida"
        Dim dsPartidas As New DataSet
        dsPartidas = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "No se obtuvieron las partidas de la cotización anterior")
        Dim renglones As Integer = dsPartidas.Tables(0).Rows.Count
        For i As Integer = 0 To renglones - 1
            dgvProductos.Rows.Add(dsPartidas.Tables(0).Rows(i)(0).ToString,
                                  dsPartidas.Tables(0).Rows(i)(1).ToString,
                                  dsPartidas.Tables(0).Rows(i)(2).ToString,
                                  dsPartidas.Tables(0).Rows(i)(3).ToString,
                                  dsPartidas.Tables(0).Rows(i)(4).ToString,
                                  dsPartidas.Tables(0).Rows(i)(5).ToString,
                                  dsPartidas.Tables(0).Rows(i)(6).ToString,
                                  dsPartidas.Tables(0).Rows(i)(7).ToString,
                                  dsPartidas.Tables(0).Rows(i)(8).ToString,
                                  dsPartidas.Tables(0).Rows(i)(9).ToString)
        Next
        lblNumPartida.Text = renglones + 1
        intContadorPartidas = renglones + 2
        IniciarVariablesRecurrentes()

        '---------------------
        TamañoInicalForm()

    End Sub

#End Region

#Region "Datagrid Compras"

    Private Sub btnIniciarCompraDatagrid_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciarCompraDatagrid.Click
        If strClienteQuart = "C20999" Then
            'proceso de cliente nuevo descatalogado
            gbTodo.Enabled = False

            'prepara tabcontrol para que funcione en el tabulador deseado
            tcApoyos.SelectedTab = tpClienteD
            tpClienteD.Enabled = True
            tpProductoD.Parent = Nothing
            tpModificarPartida.Parent = Nothing
            tpRepetirCotizacion.Parent = Nothing
            tpClienteD.Parent = tcApoyos

            TamañoGrandeForm()
            IniciarProcesoClienteNuevo()
            Exit Sub
        End If

        PreparaGridPartidas()

    End Sub

    Private Sub PreparaGridPartidas()

        If intCliente > 0 Then
            tbCliente.Text = ""
            dgvProductos.RowHeadersVisible = False
            dgvProductos.AllowUserToAddRows = False
            dgvProductos.AllowUserToDeleteRows = False
            dgvProductos.AllowUserToResizeRows = False
            dgvProductos.AllowUserToResizeColumns = True            'cambiar a false
            dgvProductos.AllowUserToOrderColumns = False
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically

            dgvProductos.Columns.Add("Partida", "Partida")
            dgvProductos.Columns.Add("Producto", "Producto")
            dgvProductos.Columns.Add("UnidadMedida", "U.M.")
            dgvProductos.Columns.Add("Cantidad", "Cantidad")
            dgvProductos.Columns.Add("Precio", "P. Unitario")
            dgvProductos.Columns.Add("IdProd", "")
            dgvProductos.Columns.Add("IdUM", "")
            '...
            dgvProductos.Columns.Add("Cancela", "Cancelar Partida")
            dgvProductos.Columns.Add("Modifica", "Modificar Partida")
            dgvProductos.Columns.Add("PrecioValor", "")

            dgvProductos.Columns(0).Width = 50
            dgvProductos.Columns(1).Width = 400
            dgvProductos.Columns(2).Width = 60

            dgvProductos.Columns(3).Width = 60
            dgvProductos.Columns(4).Width = 60
            dgvProductos.Columns(5).Width = 0
            dgvProductos.Columns(6).Width = 0
            '...
            dgvProductos.Columns(7).Width = 100
            dgvProductos.Columns(8).Width = 100
            dgvProductos.Columns(9).Width = 0

            dgvProductos.Visible = True
            btnIniciarCompraDatagrid.Enabled = False

            lblNumPartida.Text = intContadorPartidas
            intContadorPartidas = intContadorPartidas + 1
            'dgvCompras.Rows.Add()
            gbProductos.Enabled = True
            gbProveedor.Enabled = False

            btnGrabarCotizacion.Enabled = True
            btnCancelar.Enabled = True
            btnVistaPrevia.Enabled = True

            IniciarVariablesRecurrentes()
        Else
            MessageBox.Show("Debe elegir un cliente")
            tbCliente.Focus()
        End If

    End Sub

    Private Sub dgvProductos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Dim intColumna As Integer
        intColumna = e.ColumnIndex
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then

            If intColumna = 7 Then

                Dim respuesta As Integer
                respuesta =
                MessageBox.Show("Desea cancelar la partida " & intRenglon + 1 & " ?", "Cancelar partida",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If respuesta = 6 Then
                    'iniciar proceso de cancelacion de partida (eliminar renglon en el datagrid)
                    dgvProductos.Rows.RemoveAt(intRenglon)
                    'reordenar columna de partidas
                    For i As Integer = 0 To dgvProductos.Rows.Count - 1
                        Dim suma As Integer
                        suma = i + 1
                        dgvProductos.Rows(i).Cells(0).Value = suma.ToString
                    Next
                    lblNumPartida.Text = dgvProductos.Rows.Count + 1
                    intContadorPartidas = dgvProductos.Rows.Count + 2
                Else
                End If
            ElseIf intColumna = 8 Then
                gbTodo.Enabled = False
                tpModificarPartida.Visible = True

                'prepara tabcontrol para que funcione en el tabulador deseado
                tcApoyos.SelectedTab = tpModificarPartida
                tpModificarPartida.Enabled = True
                tpProductoD.Parent = Nothing
                tpModificarPartida.Parent = tcApoyos
                tpRepetirCotizacion.Parent = Nothing
                tpClienteD.Parent = Nothing

                Dim strconsulta As String
                intProductoCambiar = dgvProductos.Rows(intRenglon).Cells(5).Value
                strconsulta = "select intProdProvisional from tblCatProductos where IDProducto = " &
                    intProductoCambiar
                Dim dsTipoProducto As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strconsulta, "Tabla", "No se consiguió el tipo de producto")
                If dsTipoProducto.Tables(0).Rows(0)(0) = 1 Then
                    lblDescProcuctoM.Enabled = True
                End If
                TamañoGrandeForm()
                lblDescProcuctoM.Text = dgvProductos.Rows(intRenglon).Cells(1).Value
                lblUMedidaM.Text = dgvProductos.Rows(intRenglon).Cells(2).Value
                mtbCantidadM.Text = dgvProductos.Rows(intRenglon).Cells(3).Value
                mtbPrecioUnitarioM.Text = dgvProductos.Rows(intRenglon).Cells(4).Value
                intRenglonModificar = intRenglon
            End If
        End If

    End Sub

#End Region

#Region "Partidas"

    Private Sub CargarComboProductos()
        Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto FROM tblCatProductos  where intTipoProducto >= 2 order by strDescripcionProducto"
        LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
    End Sub

    Private Sub cbProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            intProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            cbCliente.DroppedDown = False
            CargarComboUnidadMedida()
        End If
    End Sub

    Private Sub CargarComboUnidadMedida()
        Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where intVarControlProductos = 1 and IDProducto = " & intProducto & " Order by strUnidadMedida "
        LlenarCombo(strqry, cbUM, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbUM_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUM.SelectedValueChanged
        If cbUM.DataSource IsNot Nothing Then
            intUnidadMedida = DirectCast(cbUM.SelectedItem, DataRowView).Item("IDUnidadMedida")
            Dim strqry As String = "SELECT strCampo FROM tblCampoDescuento WHERE IDTipoCliente = " & intTipoCliente
            Dim dsNivel As New DataSet
            dsNivel = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            Dim strNivel As String = dsNivel.Tables(0).Rows(0).Item(0).ToString
            strqry = " SELECT " & strNivel & " FROM vstListaPrecios WHERE IDProducto = " & intProducto &
                " AND IDUnidadMedida = " & intUnidadMedida & " AND intVarControlProductos = 1 "
            Dim dsPrecio As New DataSet
            dsPrecio = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
            mtbPrecio.Text = Format(dsPrecio.Tables(0).Rows(0).Item(0), "#,##0.00")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If intProducto = 1 Then
            'MessageBox.Show("Producto nuevo solo para cotizar")
            gbTodo.Enabled = False

            'prepara tabcontrol para que funcione en el tabulador deseado
            tcApoyos.SelectedTab = tpProductoD
            tpProductoD.Enabled = True
            tpProductoD.Parent = tcApoyos
            tpModificarPartida.Parent = Nothing
            tpRepetirCotizacion.Parent = Nothing
            tpClienteD.Parent = Nothing

            TamañoGrandeForm()
            IniciarProcesoProductoNuevo()
            Exit Sub
        End If

        If intProducto > 0 And mtbCant.Text > "" Then
            Dim strprec As String = Format(Decimal.Parse(mtbPrecio.Text), "#,##0.00")
            Dim PrecioValor As Decimal = Decimal.Parse(mtbPrecio.Text)
            'MsgBox(strprec)
            Dim strqry As String
            strqry = "Select strDescripcionProducto from vstListaPrecios where IDProducto = " & intProducto
            Dim dsPro As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")

            dgvProductos.Rows.Add(lblNumPartida.Text, dsPro.Tables(0).Rows(0)(0).ToString, cbUM.Text, mtbCant.Text, strprec, intProducto, intUnidadMedida, "Cancelar Partida", "Modificar Partida", PrecioValor)
            lblNumPartida.Text = intContadorPartidas
            intContadorPartidas = intContadorPartidas + 1
            IniciarVariablesRecurrentes()
            cbProducto.DroppedDown = True

            '  Format(dsPrecio.Tables(0).Rows(0).Item(0), "##,##0.00")
        Else
            MessageBox.Show("Debe elegir un producto y una cantidad")
        End If
        Windows.Forms.Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub tbProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProducto.TextChanged
        Dim intLargo As Integer = Len(tbProducto.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where intTipoProducto >= 2 and strDescripcionProducto like '%" & tbProducto.Text & "%'  order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "Producto")
            cbProducto.DroppedDown = True
        End If
        If intLargo = 0 Then
            cbProducto.DroppedDown = False
            'cbProducto.DataSource = Nothing
            'cbProducto.Items.Clear()
        End If
        Windows.Forms.Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub tbProducto_Click(sender As System.Object, e As System.EventArgs) Handles tbProducto.Click
        tbProducto.Text = ""
        'cbProducto.Items.Clear()
        'tbProducto.Focus()
        'strCatProdQuart = ""
    End Sub

    Private Sub mtbPrecio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbPrecio.Enter
        If (Not String.IsNullOrEmpty(mtbPrecio.Text)) Then
            mtbPrecio.SelectionStart = 0
            mtbPrecio.SelectionLength = mtbPrecio.Text.Length
        End If
    End Sub

#End Region

#Region "producto No Catalogado"

    Private Sub IniciarProcesoProductoNuevo()
        tpClienteD.Visible = False
        tpProductoD.Visible = True
        tpModificarPartida.Visible = False
        intProductoD = 0
        strCodProdQuart = ""
        intUnidadMedidaD = 0
        intProveedor = 0
        tbDescripcionProducto.Text = ""
        CargarComboUnidadMedidaD()
    End Sub

    Private Sub CargarComboUnidadMedidaD()
        Dim strqry As String
        strqry = "SELECT IDUnidadMedida, strUnidadMedida FROM tblCatUnidadMedida where intVarControlUnidadMedida = 1  order by strUnidadMedida"
        LlenarCombo(strqry, cbUnidadMedida, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbUnidadMedida_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUnidadMedida.SelectedValueChanged
        If cbUnidadMedida.DataSource IsNot Nothing Then
            intUnidadMedidaD = DirectCast(cbUnidadMedida.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If
    End Sub

#End Region

#Region "Grabar Cotizacion e Imprimirla"

    Private Sub btnGrabarCotizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarCotizacion.Click
        Me.Enabled = False

        'Insertamos la cotizacion
        Dim strqry As String = ""
        Dim strdtFechaCompra As String
        strdtFechaCompra = Format(dtFechaCompra.Value, "dd/MM/yyyy")

        strqry = " INSERT INTO tblListaCotizaciones (IDCliente,dtFechaIngresoSistema,strReferenciaCliente, intUsuarioVenta, intEmpresa, intAgregarIVA) VALUES (" & intCliente & ", '" & strdtFechaCompra & "', '" &
                        tbReferenciaProveedor.Text & "', " & ProcedimientosGenerales.intUsuario & ", " & intEmpresa & ", " & intAgregarIVA & ")"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If IDCompra = 0 Then
            'System.Threading.Thread.Sleep(100)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(3, IDCompra)
            Dim SubTotal As Decimal
            'Ya insertada la compra traemos su identity para usarlo en las transacciones

            Dim TotalVenta As Decimal = 0
            Dim decIVAAcumulado As Decimal = 0.0

            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1

                Dim intAplicaIVA As Integer = 1
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where idProducto = " & dgvProductos.Rows(i).Cells(5).Value
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "Tabla", "Error al consultar si aplica IVA")

                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)



                'grabamos la transaccion, una por una...
                strqry = "INSERT INTO tblTransaccionesCotizaciones(" &
                    "idCotizacion,intPartida," &
                    "IDProducto,Cantidad," &
                    "PKUnidadMedida,PrecioUnitario) VALUES (" &
                            IDCompra & ", " &
                            dgvProductos.Rows(i).Cells(0).Value & ", " &
                            dgvProductos.Rows(i).Cells(5).Value & ", " &
                            dgvProductos.Rows(i).Cells(3).Value & ", " &
                            dgvProductos.Rows(i).Cells(6).Value & ", " &
                            dgvProductos.Rows(i).Cells(9).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar Partida")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                Me.Refresh()
                Pausa(50)
                'Agregamos los montos para que se reflejen en la compra
                Dim PrecioUnitario As Decimal
                Dim Cantidad As Decimal
                Dim Importe As Decimal
                Cantidad = Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value)
                PrecioUnitario = Decimal.Parse(dgvProductos.Rows(i).Cells(4).Value)
                Importe = Cantidad * PrecioUnitario
                SubTotal = SubTotal + Decimal.Round(Importe, 2)

                Dim decIVAArticulo As Decimal = 0
                Dim decIVAArt As Decimal = Importe * 0.16 * intAplicaIVA
                decIVAArticulo = Decimal.Round(decIVAArt, 2)
                decIVAAcumulado = decIVAAcumulado + decIVAArticulo

            Next

            'grabamos el monto antes de iva, iva y total
            Dim IVA, Total As Decimal
            Dim TotalLetra As String
            'Dim IVACalculo As Decimal = SubTotal * 0.16 * intAgregarIVA
            Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA

            'Dim decAgregarIVA As Decimal = intAgregarIVA
            IVA = Decimal.Round(IVACalculo, 2)
            Dim TotalCalculo As Decimal = SubTotal + IVA
            Total = Decimal.Round(TotalCalculo, 2)
            TotalLetra = Letras(Format(Total, "####.00"))
            Dim strLeyendaIVA, strLeyendaSubTotal, strLeyendaTotal, strIVA, strTotal As String
            If intAgregarIVA = 1 Then
                strLeyendaIVA = " IVA 16% "
                strLeyendaSubTotal = " Sub-Total"
                strLeyendaTotal = "Total"
                strIVA = Format(IVA, "$#,##0.00")
                strTotal = Format(Total, "$#,##0.00")
            Else
                strLeyendaIVA = ""
                strLeyendaSubTotal = "Total"
                strLeyendaTotal = ""
                strIVA = ""
                strTotal = ""
            End If

            strqry = "UPDATE tblListaCotizaciones SET MontoAntesIVA = " & SubTotal & ",Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " &
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " &
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal & "' WHERE idCotizacion = " & IDCompra
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar Montos totales a la cotización.")

            ImprimirCotizacion(IDCompra)
        End If
        'System.Threading.Thread.Sleep(100)
        ' MessageBox.Show("Realizar el proceso de impresion de la entrada a almacén")
        Me.Enabled = True

        Iniciar()
    End Sub

    Public Sub ImprimirCotizacion(ByRef IdCotizacion As Long)

        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT  * FROM vstPartidasCotizadas WHERE idCotizacion = " & IdCotizacion & " order by  intPartida   "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New rptCotizar

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        frm.VisorCrystalReport.Visible = True
        'Para indicar que solo exportara a PDF
        frm.VisorCrystalReport.AllowedExportFormats = ExportFormatType.PortableDocFormat

        frm.Text = "Cotización"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()
    End Sub

#End Region

#Region "Botones adicionales"

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

#End Region

#Region "Empresa"

    Private Sub btnQuart_Click(sender As System.Object, e As System.EventArgs) Handles btnQuart.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "QUART INDUSTRIA S.A. DE C.V."
        intEmpresa = 1
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbCliente.Focus()
    End Sub

    Private Sub btnAaron_Click(sender As System.Object, e As System.EventArgs) Handles btnAaron.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "AARON URDIALES GONZALEZ"
        intEmpresa = 2
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbCliente.Focus()
    End Sub

#End Region

#Region "Producto No Catalogado"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        tbProducto.Text = "Producto no catalogado"
        cbProducto.Focus()
    End Sub

    Private Sub tbProveedor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbProveedor.KeyUp
        Dim intLargo As Integer = Len(tbProveedor.Text)
        If intLargo >= 4 Then
            Dim strqry As String = "SELECT IDProveedor,strNombreProveedor  FROM tblCatProveedores where strNombreProveedor like '%" & tbProveedor.Text & "%' order by strNombreProveedor "
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If cbProveedor.DataSource IsNot Nothing Then
            intProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
        End If
    End Sub

    Private Sub btnGrabarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarProducto.Click
        Dim strqry As String
        Dim intNuevo As Integer
        strqry = "INSERT INTO tblListaProvisionales (strTipo,intUsuario) VALUES ('PRO'," & intUsuario & ")"
        intNuevo = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If intNuevo = 0 Then
            MessageBox.Show("No se grabó el producto. Intente nuevamente")
            Iniciar()
            Exit Sub
        Else
            strCodProdQuart = "P" & intNuevo
        End If

        intProducto = 0
        strqry = "INSERT INTO tblCatProductos  (strDescripcionProducto,intTipoProducto,intInventariable,strCodProdQuart,intUsuarioAlta, intProdProvisional) VALUES " &
            "('" & tbDescripcionProducto.Text & "', 3, 1, '" & strCodProdQuart & "', " & intUsuario & ", 1) "
        intProducto = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")

        intNuevo = 0
        intProveedor = 26
        strqry = "INSERT INTO tblProveedorProducto (IDProducto,IDProveedor,IDUnidadMedida, intUsuario) VALUES " &
            "(" & intProducto & ", " & intProveedor & ", " & intUnidadMedidaD & ", " & intUsuario & ")"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")

        strqry = "INSERT INTO tblListaPrecios (IdProducto,IdUnidadMedida,decPrecioA,strCodProdQuart) VALUES " &
            "(" & intProducto & ", " & intUnidadMedidaD & ", " & mtbPrecioNuevo.Text & ",'" & strCodProdQuart & "')"
        intNuevo = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")

        GrabarAccion(9, intProducto)
        tbProducto.Text = tbDescripcionProducto.Text
        mtbPrecio.Text = mtbPrecioNuevo.Text
        tpProductoD.Visible = False
        lblDescProcuctoM.Enabled = False
        TamañoInicalForm()
        IniciarProcesoProductoNuevo()
        gbTodo.Enabled = True

    End Sub

#End Region

#Region "Modificar Partida"

    Private Sub btnModificarPartida_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarPartida.Click
        dgvProductos.Rows(intRenglonModificar).Cells(3).Value = mtbCantidadM.Text
        Dim NuevaDescripcion As String
        NuevaDescripcion = lblDescProcuctoM.Text
        Dim precionuevo As Decimal
        precionuevo = Decimal.Parse(mtbPrecioUnitarioM.Text)
        dgvProductos.Rows(intRenglonModificar).Cells(4).Value = Format(precionuevo, "#,##0.00")
        dgvProductos.Rows(intRenglonModificar).Cells(9).Value = precionuevo
        dgvProductos.Rows(intRenglonModificar).Cells(1).Value = NuevaDescripcion
        Dim actualiza As String
        actualiza = "UPDATE tblCatProductos set strDescripcionProducto = '" & NuevaDescripcion &
            "' where IDProducto = " & intProductoCambiar
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, actualiza, "No actualizo nombre de producto")
        lblDescProcuctoM.Enabled = False
        tbProducto.Text = NuevaDescripcion
        tpModificarPartida.Visible = False
        TamañoInicalForm()
        intRenglonModificar = 0
        gbTodo.Enabled = True
    End Sub

    Private Sub mtbCantidadM_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbCantidadM.Enter
        If (Not String.IsNullOrEmpty(mtbCantidadM.Text)) Then
            mtbCantidadM.SelectionStart = 0
            mtbCantidadM.SelectionLength = mtbCantidadM.Text.Length
        End If
    End Sub

    Private Sub mtbPrecioUnitarioM_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbPrecioUnitarioM.Enter
        If (Not String.IsNullOrEmpty(mtbPrecioUnitarioM.Text)) Then
            mtbPrecioUnitarioM.SelectionStart = 0
            mtbPrecioUnitarioM.SelectionLength = mtbPrecioUnitarioM.Text.Length
        End If
    End Sub

    Private Sub mtbPrecioNuevo_Enter(sender As System.Object, e As System.EventArgs) Handles mtbPrecioNuevo.Enter
        If (Not String.IsNullOrEmpty(mtbPrecioNuevo.Text)) Then
            mtbPrecioNuevo.SelectionStart = 0
            mtbPrecioNuevo.SelectionLength = mtbPrecioNuevo.Text.Length
        End If
    End Sub

    Private Sub btnCancelaProductoNoCatalogado_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelaProductoNoCatalogado.Click
        gbTodo.Enabled = True
        tpProductoD.Enabled = False
        tbContactoD.Text = ""
        tbColoniaD.Text = ""
        tbCorreoD.Text = ""
        tbDomicilioD.Text = ""
        tbEstadoD.Text = ""
        tbMunicipioD.Text = ""
        tbRazonSocialD.Text = ""
        tbTel1D.Text = ""
        tbTel2D.Text = ""
        TamañoInicalForm()
        tbCliente.Text = ""
        cbCliente.DataSource = Nothing
        intCliente = 0
        tbCliente.Focus()
    End Sub

#End Region

#Region "Generar Vista Previa"

    Private Sub btnVistaPrevia_Click(sender As System.Object, e As System.EventArgs) Handles btnVistaPrevia.Click
        Me.Enabled = False

        'Insertamos la cotizacion
        Dim strqry As String = ""
        Dim strdtFechaCompra As String
        strdtFechaCompra = Format(dtFechaCompra.Value, "dd/MM/yyyy")

        strqry = " INSERT INTO tblListaCotizacionesPrevia (IDCliente,dtFechaIngresoSistema,strReferenciaCliente, intUsuarioVenta, intEmpresa, intAgregarIVA) VALUES (" & intCliente & ", '" & strdtFechaCompra & "', '" &
                        tbReferenciaProveedor.Text & "', " & ProcedimientosGenerales.intUsuario & ", " & intEmpresa & ", " & intAgregarIVA & ")"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If IDCompra = 0 Then
            'System.Threading.Thread.Sleep(100)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(3, IDCompra)
            Dim SubTotal As Decimal
            Dim decIVAAcumulado As Decimal = 0.0

            'Ya insertada la compra traemos su identity para usarlo en las transacciones
            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1

                Dim intAplicaIVA As Integer = 1
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where idProducto = " & dgvProductos.Rows(i).Cells(5).Value
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "Tabla", "Error al consultar si aplica IVA")

                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)

                'grabamos la transaccion, una por una...
                strqry = "INSERT INTO tblTransaccionesCotizacionesPrevia(" &
                    "idCotizacion,intPartida," &
                    "IDProducto,Cantidad," &
                    "PKUnidadMedida,PrecioUnitario) VALUES (" &
                            IDCompra & ", " &
                            dgvProductos.Rows(i).Cells(0).Value & ", " &
                            dgvProductos.Rows(i).Cells(5).Value & ", " &
                            dgvProductos.Rows(i).Cells(3).Value & ", " &
                            dgvProductos.Rows(i).Cells(6).Value & ", " &
                            dgvProductos.Rows(i).Cells(9).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar Partida")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(1, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                Me.Refresh()
                Pausa(50)
                'Agregamos los montos para que se reflejen en la compra
                Dim PrecioUnitario As Decimal
                Dim Cantidad As Decimal
                Dim Importe As Decimal
                Cantidad = Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value)
                PrecioUnitario = Decimal.Parse(dgvProductos.Rows(i).Cells(4).Value)
                Importe = Cantidad * PrecioUnitario
                SubTotal = SubTotal + Decimal.Round(Importe, 2)

                Dim decIVAArticulo As Decimal = 0
                Dim decIVAArt As Decimal = Importe * 0.16 * intAplicaIVA
                decIVAArticulo = Decimal.Round(decIVAArt, 2)

                decIVAAcumulado = decIVAAcumulado + decIVAArticulo

            Next

            'grabamos el monto antes de iva, iva y total
            Dim IVA, Total As Decimal
            Dim TotalLetra As String
            'Dim IVACalculo As Decimal = SubTotal * 0.16 * intAgregarIVA
            Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA

            'Dim decAgregarIVA As Decimal = intAgregarIVA
            IVA = Decimal.Round(IVACalculo, 2)
            Dim TotalCalculo As Decimal = SubTotal + IVA
            Total = Decimal.Round(TotalCalculo, 2)
            TotalLetra = Letras(Format(Total, "####.00"))
            Dim strLeyendaIVA, strLeyendaSubTotal, strLeyendaTotal, strIVA, strTotal As String
            If intAgregarIVA = 1 Then
                strLeyendaIVA = " IVA 16% "
                strLeyendaSubTotal = " Sub-Total"
                strLeyendaTotal = "Total"
                strIVA = Format(IVA, "$#,##0.00")
                strTotal = Format(Total, "$#,##0.00")
            Else
                strLeyendaIVA = ""
                strLeyendaSubTotal = "Total"
                strLeyendaTotal = ""
                strIVA = ""
                strTotal = ""
            End If

            strqry = "UPDATE tblListaCotizacionesPrevia SET MontoAntesIVA = " & SubTotal & ",Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " &
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " &
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal & "' WHERE idCotizacion = " & IDCompra
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar Montos totales a la cotización.")

            ImprimirCotizacionPrevia(IDCompra)
        End If
        'System.Threading.Thread.Sleep(100)
        ' MessageBox.Show("Realizar el proceso de impresion de la entrada a almacén")
        Me.Enabled = True

    End Sub

    Private Sub ImprimirCotizacionPrevia(ByRef IdCotizacion As Long)

        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String = "SELECT  * FROM vstPartidasCotizadasPrevia WHERE idCotizacion = " & IdCotizacion & " order by  intPartida   "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New rptCotizarPrevia

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        If frmLogin.intServer = 3 Then
            frm.VisorCrystalReport.ShowPrintButton = False
            frm.VisorCrystalReport.AllowedExportFormats = False
        Else
            frm.VisorCrystalReport.ShowPrintButton = True
            frm.VisorCrystalReport.AllowedExportFormats = True
        End If

        frm.VisorCrystalReport.Visible = True

        frm.Text = "Vista Previa de Cotización"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()

    End Sub
#End Region

#Region "Procesos no utilizados"

    Private Sub btnProductoNuevo_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("En esta parte aparecera la ventana de alta de productos," &
                        " seleccionando previamente al proovedor que se selecciono en al parte superior", "Desarrollo pendiente de Marcelo")
    End Sub

    Private Sub GrabarCompraNoUsar()
        MessageBox.Show("En esta parte se realiza el grabado, partida por partida en la tabla de transacciones de compras," &
               " y en la tabla de inventario debe de verificarse. Primero, que exista.. si no existe inserta, y si existe, verifica la cantidad actual " &
               " que haya actualmente en el producto y unidad de medida, y lo suma... ", "Desarrollo pendiente de Marcelo")
        Me.Enabled = False

        'Insertamos la compra
        Dim strqry As String = ""
        Dim strdtFechaCompra As String = Format(dtFechaCompra.Value, "yyyy-MM-dd")
        strqry = " INSERT INTO tblListaCompras (IDProveedor,dtFechaCompra,strReferenciaProveedor) VALUES (" & intCliente & ", '" & strdtFechaCompra & "', '" &
                        tbReferenciaProveedor.Text & "')"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        If IDCompra = 0 Then
            ' System.Threading.Thread.Sleep(200)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            'Ya insertada la compra traemos su identity para usarlo en las transacciones
            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1
                'grabamos la transaccion, una por una...
                strqry = "INSERT INTO tblTransaccionesCompra(idCompra,intPartida,IDProducto,CantidadComprada,PKUnidadMedida,PrecioUnitarioCompra) VALUES (" &
                            IDCompra & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value &
                            ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & dgvProductos.Rows(i).Cells(6).Value & ", " & dgvProductos.Rows(i).Cells(4).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(0, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(0, i).Style.BackColor = Color.Green
                End If
                Me.Refresh()
                'System.Threading.Thread.Sleep(200)
                'hacemos el calculo del inventario
                strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvProductos.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvProductos.Rows(i).Cells(6).Value & "And intVarControlInventario = 1"
                Dim dsExiste As New DataSet
                dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
                If dsExiste.Tables(0).Rows.Count = 0 Then
                    'se debe insertar la compra"
                    strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" &
                                dgvProductos.Rows(i).Cells(5).Value & ", " & dgvProductos.Rows(i).Cells(6).Value &
                                ", " & dgvProductos.Rows(i).Cells(3).Value & ") "
                    j = 0
                    j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                    If j = 0 Then
                        'No se pudo grabar la partida en la tabla
                        dgvProductos.Item(1, i).Style.BackColor = Color.Red
                    Else
                        dgvProductos.Item(1, i).Style.BackColor = Color.Green
                    End If
                Else
                    'se debe actualizar el valor de cantidad, sumando...
                    strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) +
                                Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value) &
                                " where IdProducto = " & dgvProductos.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvProductos.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                'System.Threading.Thread.Sleep(200)
                Me.Refresh()
            Next
        End If
        'System.Threading.Thread.Sleep(300)
        MessageBox.Show("Realizar el proceso de impresion de la entrada a almacén")

        Me.Enabled = True
        Iniciar()
    End Sub
#End Region

#Region "Restricciones de entrada a los TextBox"

    Private Sub mtbCant_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbCant.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCant.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecio_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecio.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecio.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbCantidadM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbCantidadM.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCantidadM.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecioUnitarioM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecioUnitarioM.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecioUnitarioM.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecioNuevo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecioNuevo.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecioNuevo.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub tbRazonSocialD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbRazonSocialD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbDomicilioD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDomicilioD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbColoniaD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbColoniaD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbMunicipioD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMunicipioD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbEstadoD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbEstadoD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbTel1D_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTel1D.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbTel2D_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTel2D.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbContactoD_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbContactoD.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbDescripcionProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDescripcionProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbCliente.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbReferenciaProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbReferenciaProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub lblDescProcuctoM_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lblDescProcuctoM.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

    Private Sub cbClienteCotizacionAnterior_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbClienteCotizacionAnterior.SelectedIndexChanged

    End Sub

    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        TamañoInicalForm()
    End Sub
End Class