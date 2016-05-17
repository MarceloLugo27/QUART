Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports QuartOK.ProcedimientosGenerales

Public Class Compra

#Region "Variables"
    Dim lblPartida() As Label
    Dim cmbProducto() As ComboBox
    Dim cmbUnidadMedida() As ComboBox
    Dim mtbCantidad() As MaskedTextBox
    Dim mtbPrecioUnitario() As MaskedTextBox

    Friend WithEvents btnSiguiente As Button
    Dim btnOtro() As Button

    'Dim VariacionRenglon As Integer = 30
    'Dim xInicial As Integer
    'Dim yInicial As Integer

    Dim intContadorPartidas As Integer
    Public Shared intProveedor As Integer = 0
    Dim intProducto As Integer = 0
    Dim intUnidadMedida As Integer
    Dim decCantidad As Decimal
    Dim decPrecioUnitario As Decimal
    Dim decTotal As Decimal

    Dim intEmpresa As Integer = 0
    Dim intRenglonModificar As Integer = 0

    Dim intAgregarIVA As Integer = 0


    'Variables para Producto Nuevo
    Dim Inventariable As Integer
    Dim intTipoUnidadNuevo As Integer
    Dim intAplicaIVA As Integer

#End Region

#Region "Iniciar formato"

    Private Sub Compra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamañoInicalForm()
        gbModificarPartida.Enabled = False
        dgvProductos.AllowUserToOrderColumns = False
        gbTodo.Enabled = False
        lblEmpresa.Text = ""
        lblEmpresa.Visible = False
        Iniciar()
    End Sub

    Private Sub Iniciar()
        intContadorPartidas = 1
        dgvProductos.Visible = False
        IniciarVariablesUnicas()
        'IniciarVariablesRecurrentes()
        ' CargarComboProveedores()
        btnIniciarCompraDatagrid.Enabled = True
        dgvProductos.Rows.Clear()

        If dgvProductos.Columns.Count >= 1 Then
            Dim CantColumns As Integer = dgvProductos.Columns.Count - 1
            For i As Integer = CantColumns To 0 Step -1
                dgvProductos.Columns.RemoveAt(i)
            Next
        End If

        rbFactura.Checked = True
        tbReferenciaProveedor.Text = "FACTURA "
        rbRemision.Checked = False
        dtFechaCompra.Value = Today

        dgvProductos.DataSource = Nothing
        tbProveedor.Text = ""
        cbProveedor.DataSource = Nothing
        'tbReferenciaProveedor.Text = ""
        gbProductos.Enabled = False
        gbProveedor.Enabled = True
        tbProducto.Text = ""
        cbProducto.DataSource = Nothing

        cbUM.DataSource = Nothing



        tbObservaciones.Text = ""
        tbRecibioMercancia.Text = ""
        tbRecibioMercancia.Text = strNombreUsuario
        tbProveedor.Focus()
    End Sub

    Private Sub IniciarVariablesUnicas()
        intProveedor = 0
        decTotal = 0
        intContadorPartidas = 1
        gbProductos.Enabled = False
        gbProveedor.Enabled = True
        btnGrabarCompra.Enabled = False
        btnVistaPrevia.Enabled = False
        btnCancelar.Enabled = False
        rbFactura.Checked = False
        rbRemision.Checked = False
    End Sub

    Private Sub IniciarVariablesRecurrentes()
        intProducto = 0
        intUnidadMedida = 0
        decCantidad = 0
        decPrecioUnitario = 0
        mtbCant.Text = ""
        mtbPrecio.Text = ""
        'CargarComboProductos()
    End Sub

    Private Sub TamañoInicalForm()
        Me.Size = New System.Drawing.Size(934, 661)
    End Sub

    Private Sub TamañoGrandeForm()
        Me.Size = New System.Drawing.Size(1284, 661)
    End Sub

    Private Sub Compra_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantIngresoAlmacen = False
    End Sub
#End Region

#Region "Proveedores"

    Private Sub tbProveedor_Click(sender As System.Object, e As System.EventArgs) Handles tbProveedor.Click
        tbProveedor.Text = ""
        cbProveedor.Items.Clear()
        tbProveedor.Focus()
    End Sub

    Private Sub CargarComboProveedores()
        Dim strqry As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores order by strNombreProveedor"
        LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If cbProveedor.DataSource IsNot Nothing Then
            intProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
            'CargarPuestosCasilla(intCasilla)
            'btnContinuar.Enabled = True
            ' MessageBox.Show(intProveedor)
        End If
    End Sub

    Private Sub cbProveedor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbProveedor.KeyUp
        Dim intLargo As Integer = Len(cbProveedor.Text)
        If intLargo > 3 Then
            ' Select IDProveedor, strNombreProveedor FROM tblCatProveedores order by strNombreProveedor
            ' Dim strqry As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores order by strNombreProveedor"

            Dim strqry As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores where strNombreProveedor like '%" & cbProveedor.Text & "%' order by strNombreProveedor "
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub tbProveedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProveedor.TextChanged
        Dim intLargo As Integer = Len(tbProveedor.Text)
        If intLargo >= 4 Then
            cbProveedor.DroppedDown = False
            Dim strqry As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores where strNombreProveedor  like '%" & tbProveedor.Text & "%'  order by strNombreProveedor"
            'Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where intTipoProducto >= 2 and strDescripcionProducto like '%" & tbProducto.Text & "%'  order by strDescripcionProducto"
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbProveedor.DroppedDown = False
            cbProveedor.DataSource = Nothing
            cbProveedor.Items.Clear()

        End If
    End Sub

    Private Sub rbRemision_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbRemision.CheckedChanged
        If rbRemision.Checked = True Then
            tbReferenciaProveedor.Text = "REMISION "
            intAgregarIVA = 0
        End If
    End Sub

    Private Sub rbFactura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFactura.CheckedChanged
        If rbFactura.Checked = True Then
            tbReferenciaProveedor.Text = "FACTURA "
            intAgregarIVA = 1
        End If
    End Sub

    Private Sub tbProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbReferenciaProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbReferenciaProveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "Partidas"

    Private Sub tbProducto_Click(sender As System.Object, e As System.EventArgs) Handles tbProducto.Click
        tbProducto.Text = ""
        cbProducto.Items.Clear()
        tbProducto.Focus()
        mtbCant.Text = ""
        mtbPrecio.Text = ""
    End Sub

    Private Sub cbProducto_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbProducto.KeyUp
        Dim intLargo As Integer = Len(cbProducto.Text)
        If intLargo > 3 Then
            'Dim strqry As String = "Select DISTINCT IDProducto, [strDescripcionProducto] FROM vstProductoProveedor  where IDProveedor = " & intProveedor & " order by strDescripcionProducto"

            Dim strqry As String = "Select DISTINCT IDProducto, [strDescripcionProducto] FROM vstProductoProveedor  where strDescripcionProducto like '%" & cbProducto.Text & "%' and IDProveedor = " & intProveedor & " order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
            cbProducto.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If

    End Sub

    Private Sub CargarComboProductos()
        Dim strqry As String = "Select DISTINCT IDProducto, [strDescripcionProducto] FROM vstProductoProveedor  where IDProveedor = " & intProveedor & " order by strDescripcionProducto"
        LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
    End Sub

    Private Sub cbProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            intProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            cbProveedor.DroppedDown = False
            CargarComboUnidadMedida()
        End If
    End Sub

    Private Sub CargarComboUnidadMedida()
        Dim strqry As String
        'strqry para usar cuando se haga la relacion producto - proveedor
        strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstProductoProveedor  where IDProveedor = " & intProveedor & " and IDProducto = " & intProducto & " Order by strUnidadMedida "
        strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where IDProducto = " & intProducto & " Order by strUnidadMedida "
        LlenarCombo(strqry, cbUM, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbUM_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUM.SelectedValueChanged
        If cbUM.DataSource IsNot Nothing Then
            intUnidadMedida = DirectCast(cbUM.SelectedItem, DataRowView).Item("IDUnidadMedida")
            Dim strqry As String
            strqry = "Select top 1 PrecioUnitarioCompra from vstPartidasCompradas " & _
                " WHERE IDProducto = " & intProducto & " AND PKUnidadMedida = " & intUnidadMedida & _
                " AND IDProveedor = " & intProveedor & " ORDER BY dtFechaCompra desc"
            Dim dsUltimoPrecio As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, _
                                                                          strPasswordDB, strqry, "Precio", "Error al consultar último precio de compra")
            If dsUltimoPrecio Is Nothing Then
                mtbPrecio.Text = "0.00"
            Else
                If dsUltimoPrecio.Tables(0).Rows.Count = 0 Then
                    mtbPrecio.Text = "0.00"
                Else
                    Dim ultimoprecio As Decimal = Decimal.Parse(dsUltimoPrecio.Tables(0).Rows(0)(0).ToString)

                    mtbPrecio.Text = Format(ultimoprecio, "#,##0.00")
                End If
            End If

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If intProducto > 0 And mtbCant.Text > "" Then
            Dim precionuevo As Decimal
            precionuevo = Decimal.Parse(mtbPrecio.Text)
            dgvProductos.Rows.Add(lblNumPartida.Text, cbProducto.Text, cbUM.Text, mtbCant.Text, precionuevo, intProducto, intUnidadMedida, "Cancelar Partida", "Modificar Partida", precionuevo)
            Me.Update()
            lblNumPartida.Text = intContadorPartidas
            intContadorPartidas = intContadorPartidas + 1
            IniciarVariablesRecurrentes()
            Pausa(300)
            cbProducto.DroppedDown = True
            Cursor.Current = Cursors.Arrow
            cbProducto.Focus()
        Else
            MessageBox.Show("Debe elegir un producto y una cantidad")
        End If

    End Sub

    Private Sub tbProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbProducto.TextChanged
        Dim intLargo As Integer = Len(tbProducto.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where strDescripcionProducto like '%" & tbProducto.Text & "%'  and IdProducto > 1 order by strDescripcionProducto"
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

    Private Sub mtbCant_Enter(sender As System.Object, e As System.EventArgs) Handles mtbCant.Enter
        If (Not String.IsNullOrEmpty(mtbCant.Text)) Then
            mtbCant.SelectionStart = 0
            mtbCant.SelectionLength = mtbCant.Text.Length
        End If
    End Sub

    Private Sub mtbPrecio_Enter(sender As System.Object, e As System.EventArgs) Handles mtbPrecio.Enter
        If (Not String.IsNullOrEmpty(mtbPrecio.Text)) Then
            mtbPrecio.SelectionStart = 0
            mtbPrecio.SelectionLength = mtbPrecio.Text.Length
        End If
    End Sub

    Private Sub tbProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "DataGrid de productos"

    Private Sub btnIniciarCompraDatagrid_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciarCompraDatagrid.Click
        dgvProductos.RowHeadersVisible = False
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.AllowUserToResizeColumns = False
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
        'gbProveedor.Enabled = False
        btnIniciarCompraDatagrid.Enabled = False

        btnGrabarCompra.Enabled = True
        btnVistaPrevia.Enabled = True
        btnCancelar.Enabled = True

        IniciarVariablesRecurrentes()
        tbProducto.Text = ""
        tbProducto.Focus()

    End Sub

    Private Sub dgvProductos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Dim intColumna As Integer
        intColumna = e.ColumnIndex
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            If intColumna = 7 Then
                Dim respuesta As Integer
                respuesta = _
                MessageBox.Show("Desea cancelar la partida " & intRenglon + 1 & " ?", "Cancelar partida", _
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
                gbModificarPartida.Visible = True
                gbModificarPartida.Enabled = True
                'gbClienteD.Visible = False
                'gbProductoD.Visible = False
                TamañoGrandeForm()
                lblDescProcuctoM.Text = dgvProductos.Rows(intRenglon).Cells(1).Value
                lblUMedidaM.Text = dgvProductos.Rows(intRenglon).Cells(2).Value
                mtbCantidadM.Text = dgvProductos.Rows(intRenglon).Cells(3).Value
                mtbPrecioUnitarioM.Text = dgvProductos.Rows(intRenglon).Cells(4).Value
                intRenglonModificar = intRenglon
                mtbCantidadM.Focus()
                gbProductoNuevo.Visible = False

            End If
        End If
    End Sub

#End Region


#Region "Botones y objetos adicionales"

    Private Sub btnProductoNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnProductoNuevo.Click
        'Pendiente de Marcelo
        'Llevar al form altadeproducto el Id del proveedor y su nombre
        'debe regresar descripcion, unidad de medida, precio (obligado el 1), y tipo 
        'y que se indique si es o no inventariable
        'ProductoXML = 2
        'AltaDeProductos.Show()
        TamañoGrandeForm()
        gbProductoNuevo.Visible = True
        tbID.Enabled = True
        btnVerificaID.Enabled = True
        gbDatosProducto.Enabled = False
        gbModificarPartida.Visible = False
        chkbInventariable.Checked = True
        tbID.Focus()
        gbTodo.Enabled = False

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
        btnIniciarCompraDatagrid.Enabled = True
        IniciarVariablesUnicas()
        IniciarVariablesRecurrentes()
    End Sub

    Private Sub tbRecibioMercancia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbRecibioMercancia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbObservaciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbObservaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

#Region "Grabar Compra e Imprimirla"

    Private Sub btnGrabarCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarCompra.Click

        If tbRecibioMercancia.Text = "" Then
            MessageBox.Show("Debe indicar quien recibió la mercancía.")
            tbRecibioMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False

        'Insertamos la compra
        Dim strqry As String = ""
        Dim strdtFechaCompra As String = Format(dtFechaCompra.Value, "yyyy-MM-dd")
        strqry = " INSERT INTO tblListaCompras (IDProveedor,dtFechaCompra,strReferenciaProveedor, intEmpresa, intusuarioCompra, " & _
                        "intAgregarIVA, strObservaciones, strRecibioMercancia) VALUES (" & _
                        intProveedor & ", '" & strdtFechaCompra & "', '" & _
                        tbReferenciaProveedor.Text & "', " & intEmpresa & "," & ProcedimientosGenerales.intUsuario & ", " & _
                        intAgregarIVA & ", '" & tbObservaciones.Text & "', '" & tbRecibioMercancia.Text & "' )"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al Ingresar la Compra")
        If IDCompra = 0 Then
            Pausa(50)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            ProcedimientosGenerales.GrabarAccion(6, IDCompra)
            'Ya insertada la compra traemos su identity para usarlo en las transacciones
            Dim SubTotal As Decimal
            '**************************

            Dim decIVAAcumulado As Decimal = 0.0
            'Dim Importe As Decimal

            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1
                'grabamos la transaccion, una por una...


                Dim intAplicaIVA As Integer = 1
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where IDProducto = " & dgvProductos.Rows(i).Cells(5).Value
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "tblCatProductos", "Error al consultar si aplica IVA")

                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)
                'Importe = dgvProductos.Rows(i).Cells(3).Value * dgvProductos.Rows(i).Cells(9).Value



                strqry = "INSERT INTO tblTransaccionesCompra(idCompra,intPartida,IDProducto,CantidadComprada,PKUnidadMedida,PrecioUnitarioCompra) VALUES (" & _
                            IDCompra & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value & _
                            ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & dgvProductos.Rows(i).Cells(6).Value & ", " & dgvProductos.Rows(i).Cells(9).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar la partida.")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(0, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(0, i).Style.BackColor = Color.Green
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

                'hacemos el calculo del inventario
                strqry = "SELECT intCantidad, decPrecioCompra  from tblInventario where IdProducto = " & dgvProductos.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvProductos.Rows(i).Cells(6).Value & "And intVarControlInventario = 1"
                Dim dsExiste As New DataSet
                dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al buscar Invetario existente")
                If dsExiste.Tables(0).Rows.Count = 0 Then
                    'se debe insertar la compra"
                    strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad, decPrecioCompra) VALUES (" &
                                dgvProductos.Rows(i).Cells(5).Value & ", " & dgvProductos.Rows(i).Cells(6).Value &
                                ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & PrecioUnitario & ") "
                    j = 0
                    j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al afectar al Invetarion en una partida.")
                    If j = 0 Then
                        'No se pudo grabar la partida en la tabla
                        dgvProductos.Item(1, i).Style.BackColor = Color.Red
                    Else
                        dgvProductos.Item(1, i).Style.BackColor = Color.Green
                    End If
                Else
                    'se debe actualizar el valor de cantidad, sumando...
                    '------------------------------------------------------------
                    Dim ValorActual As Decimal = dsExiste.Tables(0).Rows(0)(1)
                    Dim ValorInsertar As Decimal
                    If ValorActual >= PrecioUnitario Then
                        ValorInsertar = ValorActual
                    Else
                        ValorInsertar = PrecioUnitario
                    End If

                    strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) +
                                Decimal.Parse(dgvProductos.Rows(i).Cells(3).Value) &
                                ", decPrecioCompra = " & ValorInsertar &
                                " where IdProducto = " & dgvProductos.Rows(i).Cells(5).Value &
                            " and idUnidadMedida = " & dgvProductos.Rows(i).Cells(6).Value & " And intVarControlInventario = 1"
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar nuevo producto al inventario.")
                    dgvProductos.Item(1, i).Style.BackColor = Color.Green
                End If
                Pausa(100)
                Me.Refresh()
            Next
            'grabamos el monto antes de iva, iva y total
            Dim IVA, Total As Decimal
            Dim TotalLetra As String
            'Dim ivacalculo As Decimal = SubTotal * 0.16 * intAgregarIVA
            Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA

            IVA = Decimal.Round(ivacalculo, 2)
            Dim totalCalculo As Decimal = SubTotal + IVA
            Total = Decimal.Round(totalCalculo, 2)
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

            strqry = "UPDATE tblListaCompras SET MontoAntesIVA = " & SubTotal & ",Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " & _
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " & _
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal & "' WHERE idCompra = " & IDCompra
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar Montos totales a la compra.")

            ImprimirEntradaAlmacen(IDCompra, True)
            Me.Enabled = True
        End If
        'System.Threading.Thread.Sleep(100)
        'MessageBox.Show("Realizar el proceso de impresion de la entrada a almacén")
        Iniciar()
    End Sub

    Public Sub ImprimirEntradaAlmacen(ByRef IdCompra As Integer, Optional ByRef boolActivaExport As Boolean = False)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String
        strqry = "SELECT *   FROM vstPartidasCompradas " & _
            " where idCompra = " & IdCompra & " order by intPartida "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New CompraNueva               '<<<<<<<<<<<--------------------------------------

        rep.SetDataSource(dtDatos)
        frm.VisorCrystalReport.ReportSource = rep
        frm.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.VisorCrystalReport.ToolPanelView = False
        'Para indicar que solo exportara a PDF
        frm.VisorCrystalReport.AllowedExportFormats = ExportFormatType.PortableDocFormat

        If boolActivaExport = False Then
            frm.VisorCrystalReport.ShowPrintButton = False
            frm.VisorCrystalReport.AllowedExportFormats = False
        Else
            frm.VisorCrystalReport.ShowPrintButton = True
            frm.VisorCrystalReport.AllowedExportFormats = True
        End If

        frm.VisorCrystalReport.Visible = True
        frm.Text = "Entrada a Almacen"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()

    End Sub

#End Region


#Region "Empresas"

    Private Sub btnQuart_Click(sender As System.Object, e As System.EventArgs) Handles btnQuart.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "QUART INDUSTRIA S.A. DE C.V."
        intEmpresa = 1
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbProveedor.Focus()
    End Sub

    Private Sub btnAaron_Click(sender As System.Object, e As System.EventArgs) Handles btnAaron.Click
        gbEmpresa.Visible = False
        lblEmpresa.Visible = True
        lblEmpresa.Text = "AARON URDIALES GONZALEZ"
        intEmpresa = 2
        gbTodo.Enabled = True
        Me.Text = Me.Text & " / " & lblEmpresa.Text
        tbProveedor.Focus()
    End Sub

#End Region

#Region "Modificar Partida"

    Private Sub btnModificarPartida_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarPartida.Click
        dgvProductos.Rows(intRenglonModificar).Cells(3).Value = mtbCantidadM.Text
        Dim precionuevo As Decimal
        precionuevo = Decimal.Parse(mtbPrecioUnitarioM.Text)
        dgvProductos.Rows(intRenglonModificar).Cells(4).Value = Format(precionuevo, "#,##0.00")
        dgvProductos.Rows(intRenglonModificar).Cells(9).Value = precionuevo
        TamañoInicalForm()
        intRenglonModificar = 0
        gbTodo.Enabled = True
        gbModificarPartida.Enabled = False
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

#End Region

#Region "Vista Previa"

    Private Sub btnVistaPrevia_Click(sender As System.Object, e As System.EventArgs) Handles btnVistaPrevia.Click
        If tbRecibioMercancia.Text = "" Then
            MessageBox.Show("Debe indicar quien recibió la mercancía.")
            tbRecibioMercancia.Focus()
            Exit Sub
        End If

        Me.Enabled = False

        'Insertamos la compra
        Dim strqry As String = ""
        Dim strdtFechaCompra As String = Format(dtFechaCompra.Value, "yyyy-MM-dd")
        strqry = " INSERT INTO tblListaComprasPrevia (IDProveedor,dtFechaCompra,strReferenciaProveedor, intEmpresa, intusuarioCompra, " & _
                        "intAgregarIVA, strObservaciones, strRecibioMercancia) VALUES (" & _
                        intProveedor & ", '" & strdtFechaCompra & "', '" & _
                        tbReferenciaProveedor.Text & "', " & intEmpresa & "," & ProcedimientosGenerales.intUsuario & ", " & _
                        intAgregarIVA & ", '" & tbObservaciones.Text & "', '" & tbRecibioMercancia.Text & "' )"
        Dim IDCompra As Long
        IDCompra = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al Ingresar la Compra")
        If IDCompra = 0 Then
            Pausa(50)
            MessageBox.Show("No se grabó la transaccion, intente de nuevo")
            Me.Enabled = True
            Exit Sub
        Else
            'ProcedimientosGenerales.GrabarAccion(6, IDCompra)
            'Ya insertada la compra traemos su identity para usarlo en las transacciones
            Dim SubTotal As Decimal
            Dim decIVAAcumulado As Decimal = 0.0

            Dim i As Integer
            For i = 0 To dgvProductos.Rows.Count - 1 Step 1
                'grabamos la transaccion, una por una...

                Dim intAplicaIVA As Integer = 1
                Dim strNuevoQuery As String = "SELECT intAplicaIVA from tblCatProductos where IDProducto = " & dgvProductos.Rows(i).Cells(5).Value
                Dim dsIVA As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strNuevoQuery, "Tabla", "Error al consultar si aplica IVA")
                intAplicaIVA = dsIVA.Tables(0).Rows(0)(0)

                strqry = "INSERT INTO tblTransaccionesCompraPrevia(idCompra,intPartida,IDProducto,CantidadComprada,PKUnidadMedida,PrecioUnitarioCompra) VALUES (" & _
                            IDCompra & ", " & dgvProductos.Rows(i).Cells(0).Value & ", " & dgvProductos.Rows(i).Cells(5).Value & _
                            ", " & dgvProductos.Rows(i).Cells(3).Value & ", " & dgvProductos.Rows(i).Cells(6).Value & ", " & dgvProductos.Rows(i).Cells(9).Value & ") "
                Dim j As Integer = 0
                j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al insertar la partida.")
                If j = 0 Then
                    'No se pudo grabar la partida en la tabla
                    dgvProductos.Item(0, i).Style.BackColor = Color.Red
                Else
                    dgvProductos.Item(0, i).Style.BackColor = Color.Green
                End If


                Me.Refresh()
                'Pausa(50)
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

                'Pausa(100)
                Me.Refresh()
            Next
            'grabamos el monto antes de iva, iva y total
            Dim IVA, Total As Decimal
            Dim TotalLetra As String
            'Dim IVACalculo As Decimal = SubTotal * 0.16 * intAgregarIVA
            Dim IVACalculo As Decimal = decIVAAcumulado * intAgregarIVA
            IVA = Decimal.Round(IVACalculo, 2)
            Dim TotalCalculo As Decimal = SubTotal + IVA
            Total = Decimal.Round(TotalCalculo, 2)
            Dim TotalALetra As String = Format(Total, "####.00")

            TotalLetra = Letras(TotalALetra)
            Dim strLeyendaIVA, strLeyendaSubTotal, strLeyendaTotal, strIVA, strTotal As String
            If intAgregarIVA = 1 Then
                strLeyendaIVA = " IVA 16% "
                strLeyendaSubTotal = " Sub-Total"
                strLeyendaTotal = "Total"
                strIVA = Format(IVA, "#,###.00")
                strTotal = Format(Total, "$ #,###.00")
            Else
                strLeyendaIVA = ""
                strLeyendaSubTotal = "Total"
                strLeyendaTotal = ""
                strIVA = ""
                strTotal = ""
            End If

            strqry = "UPDATE tblListaComprasPrevia SET MontoAntesIVA = " & SubTotal & ",Total = " & Total & ",IVA = " & IVA & ", TotalLetra = '" & TotalLetra & "', " & _
                        "strLeyendaIVA = '" & strLeyendaIVA & "', strLeyendaSubTotal = '" & strLeyendaSubTotal & "', strLeyendaTotal = '" & strLeyendaTotal & "', " & _
                        "strIVA = '" & strIVA & "', strTotal = '" & strTotal & "' WHERE idCompra = " & IDCompra
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar Montos totales a la compra.")

            ImprimirEntradaAlmacenPrevia(IDCompra)
            Me.Enabled = True
        End If
    End Sub

    Public Sub ImprimirEntradaAlmacenPrevia(ByRef IdCompra As Integer)
        Cursor.Current = Cursors.WaitCursor
        Dim strqry As String
        strqry = "SELECT *   FROM vstPartidasCompradasPrevia " & _
            " where idCompra = " & IdCompra & " order by intPartida "
        Dim dsDatos As New DataSet
        Dim dtDatos As New DataTable

        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        dtDatos = dsDatos.Tables(0)

        Dim frm As New frmCrystalReportContainer()

        Dim rep As New CompraNuevaPrevia               '<<<<<<<<<<<--------------------------------------

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

        frm.Text = "Vista Previa de Entrada a Almacen"
        frm.MdiParent = MDIPrincipal
        Cursor.Current = Cursors.Arrow
        frm.Show()

    End Sub

#End Region

#Region "Restricciones TextBox"

    Private Sub mtbCant_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbCant.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCant.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecio_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecio.KeyPress
        eventArgs.Handled = Fg_NumerosSigno(eventArgs.KeyChar, mtbPrecio.Text & eventArgs.KeyChar, mtbPrecio)
    End Sub

    Private Sub mtbCantidadM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbCantidadM.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbCantidadM.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub mtbPrecioUnitarioM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mtbPrecioUnitarioM.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, mtbPrecioUnitarioM.Text & CChar(eventArgs.KeyChar))
    End Sub

#End Region

    Public Shared Sub CargarProductoNuevo()
        Compra.tbProducto.Text = modProductoNuevo.strProductoNuevo
        Compra.Refresh()
        '' Compra.cbProducto.DataSource = Nothing
        '' Compra.cbProducto.Items.Clear()
        'Compra.intProducto = idProducto
        'Compra.cbProducto.Text = strNombreProductoNuevo
        'Compra.Refresh()
        ''Compra.tbProducto.Text = strNombreProductoNuevo
        ''Dim strqry As String = "Select IDProducto, strDescripcionProducto FROM vstProductoProveedor  where IDProducto = " & idProducto & " order by strDescripcionProducto"
        ''LlenarCombo(strqry, Compra.cbProducto, "IDProducto", "strDescripcionProducto")
        ''Compra.mtbCant.Focus()
        ''Pausa(100)
        'AltaDeProductos.Close()
    End Sub

    Private Sub tbID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbID.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            If InStr(1, Chr(13), e.KeyChar) = 1 Then
                btnVerificaID.Focus()
            Else
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub tbNombreProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombreProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbMarca_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMarca.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbModelo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Precio1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio1.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio1.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio2.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio2.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio3.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio3.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio4.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio4.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub cbTipoUnidad_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbTipoUnidad.SelectedValueChanged
        If cbTipoUnidad.DataSource IsNot Nothing Then
            intTipoUnidadNuevo = DirectCast(cbTipoUnidad.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If
    End Sub

    Private Sub chkbInventariable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbInventariable.CheckedChanged
        If chkbInventariable.Checked = True Then
            Inventariable = 1
        End If
        If chkbInventariable.Checked = False Then
            Inventariable = 0
        End If
    End Sub

    Private Sub btnVerificaID_Click(sender As System.Object, e As System.EventArgs) Handles btnVerificaID.Click
        If tbID.Text = "" Then
            MessageBox.Show("Debe insertar un numero de producto previamente establecido en el sistema de facturación,",
                            "Ingrese un número válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbID.Focus()
            Exit Sub
        End If
        Dim SeguirAdelante As Boolean
        SeguirAdelante = AltaDeProductos.VerificarNumeroProductoQuart(tbID.Text)
        If SeguirAdelante = False Then
            MessageBox.Show("El ID que pretende insertar ya esta ingresado en el sistema. Verifique en el sistema de facturación que está colocando el número correcto." & _
                            vbCr & vbCr & "Tome en cuenta que puede intentar colocar otro numero y continuar, pero de hacerlo asi el listado de productos de esta sistema " & _
                            "y el de facturación no serán compatibles y podría afectar a su sistema contable.", "Id de producto ya ingresado al sistema.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            gbTodo.Enabled = False
            tbID.Focus()
            Exit Sub
        End If
        gbDatosProducto.Enabled = True
        tbID.Enabled = False
        btnVerificaID.Enabled = False

        Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from tblCatUnidadMedida Order by strUnidadMedida"
        LlenarCombo(strqry, cbTipoUnidad, "IDUnidadMedida", "strUnidadMedida")


    End Sub

    Private Sub btnAñadirProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadirProducto.Click
        If tbNombreProducto.Text = "" Then
            MessageBox.Show("Debe insertar un nombre de producto")
            tbNombreProducto.Focus()
            Exit Sub
        ElseIf Precio1.Text = "" Then
            MessageBox.Show("Debe insertar siempre el precio 1.")
            Precio1.Focus()
            Exit Sub
        End If

        Dim strNombreProductoNuevo As String = tbNombreProducto.Text

        If Precio2.Text = "" Then Precio2.Text = "0.00"
        If Precio3.Text = "" Then Precio3.Text = "0.00"
        If Precio4.Text = "" Then Precio4.Text = "0.00"

        Dim TipoProducto As Integer = 3

        Dim ID As Long
        Dim strqry As String = ""
        strqry = "INSERT INTO tblCatProductos (strDescripcionProducto, strMarcaProducto," &
            "strModelo, intTipoProducto, intInventario, intVarControlProductos, intInventariable, strCodProdQuart, " &
            "intUsuarioAlta, intAplicaIVA) VALUES ('" & tbNombreProducto.Text & "','" & tbMarca.Text & "','" & tbModelo.Text & "'," &
           TipoProducto & ", 1, 1, " & Inventariable & ",'" & tbID.Text & "'," & intUsuario & ", " & intAplicaIVA & ")"
        ID = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se ha podido insertar el producto.")
        'IdNuevo = ID
        strProductoNuevo = strNombreProductoNuevo

        If ID > 0 Then
            strqry = "INSERT INTO tblProveedorProducto (IDProducto, IDProveedor, IDUnidadMedida, intVarControlproveedorProducto," &
                "intusuario) VALUES (" & ID & "," & intProveedor & ", " & intTipoUnidadNuevo & ", 1," & intUsuario & ")"
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se ha podido insertar el producto.")

            strqry = "INSERT INTO tblListaPrecios (IdProducto,IdUnidadMedida,decPrecioA,decPrecioB,decPrecioC,decPrecioD,strCodProdQuart) " &
                " VALUES (" & ID & ", " & intTipoUnidadNuevo & ", " & Precio1.Text & ", " & Precio2.Text & ", " & Precio3.Text & "," & Precio4.Text & ",'" & tbID.Text & "')"
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "El producto ha sido añadido, pero no se han podido asociar el producto a una lista de precios.")
            GrabarAccion(25, ID)
            tbProducto.Text = strNombreProductoNuevo
            LimpiarNuevo()
            TamañoInicalForm()
        End If

    End Sub

    Private Sub btnCancelaProductoNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelaProductoNuevo.Click
        LimpiarNuevo()
        TamañoInicalForm()
    End Sub

    Private Sub LimpiarNuevo()
        gbDatosProducto.Enabled = False
        gbProductoNuevo.Visible = False

        tbID.Text = ""
        tbID.Enabled = True
        btnVerificaID.Enabled = True
        tbNombreProducto.Text = ""
        tbMarca.Text = ""
        tbModelo.Text = ""
        Precio1.Text = ""
        Precio2.Text = ""
        Precio3.Text = ""
        Precio4.Text = ""
        gbTodo.Enabled = True



    End Sub

    Private Sub chkAplicaIVA_CheckedChanged(sender As Object, e As EventArgs) Handles chkAplicaIVA.CheckedChanged
        If chkAplicaIVA.Checked = True Then
            intAplicaIVA = 1
        End If
        If chkAplicaIVA.Checked = False Then
            intAplicaIVA = 0
        End If
    End Sub

    'Private Sub TxtSD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSD.KeyPress
    '    Dim sDecimal As String = ""
    '    Dim sCar As String '* 1
    '    Dim keyascii As Integer = Asc(sender)

    '    sCar = Chr(KeyAscii)

    '    'KeyAscii = SoloNumeros(KeyAscii)

    '    If sCar = "." Or sCar = "," Then
    '        ' comprueba si se ha pulsado coma o punto y lo convierte al
    '        ' formato del sistema
    '        KeyAscii = IIf(sDecimal = ",", 44, 46)
    '        sCar = Chr(KeyAscii)
    '        ' si ya se ha puesto un punto decimal, no admite otro
    '        If (InStr(TxtSD, sCar) > 0) Then
    '            KeyAscii = 0
    '            Exit Sub
    '        End If
    '    ElseIf InStr("0123456789.," & Chr(8), sCar) = 0 Then
    '        ' sólo admite números, signo negativo, punto, coma y retroceso
    '        KeyAscii = 0
    '        Exit Sub
    '        ' comprueba que el signo menos esté sólo al principio
    '        ' Nota: Si no queremos negativos, quitar esta condición
    '    ElseIf sCar = "-" Then
    '        'If InStr(2, "-", TxtNumeroSalida) = 0 Then
    '        If TxtSD.SelStart <> 0 Or InStr(TxtSD.Text, "-") > 0 Then
    '            KeyAscii = 0
    '        End If
    '    End If
    'End Sub
End Class