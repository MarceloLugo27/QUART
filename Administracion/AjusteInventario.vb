Imports QuartOK.ProcedimientosGenerales

Public Class AjusteInventario

    Private Sub AjusteInventario_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantAjusteInventario = False
    End Sub

    Private Sub AjusteInventario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        PrepararDGVAjustes()
        CargarDGVAjustes()

    End Sub

    Private Sub Limpiar()
        LimpiarDataGrid(dgvAjustes)
    End Sub

    Private Sub PrepararDGVAjustes()
        dgvAjustes.RowHeadersVisible = False
        dgvAjustes.AllowUserToAddRows = False
        dgvAjustes.AllowUserToDeleteRows = False
        dgvAjustes.AllowUserToResizeRows = False
        dgvAjustes.AllowUserToResizeColumns = False            'cambiar a false
        dgvAjustes.AllowUserToOrderColumns = False
        dgvAjustes.EditMode = DataGridViewEditMode.EditProgrammatically

        dgvAjustes.Columns.Add("strDescProdUnit", "Producto a Ajustar")             '0
        dgvAjustes.Columns.Add("intCantidad", "Cantidad")                           '1
        dgvAjustes.Columns.Add("strUMProdUnit", "U.M.")                             '2

        dgvAjustes.Columns.Add("strDescProdEqui", "Producto Equivalente")           '3
        dgvAjustes.Columns.Add("Equivalente", "Cant. Equiv.")                       '4
        dgvAjustes.Columns.Add("strUMProdEqui", "U.M.")                             '5

        dgvAjustes.Columns.Add("Ajustar", "Ajustar")                                '6

        dgvAjustes.Columns.Add("IdProdUnit", "")                                    '7
        dgvAjustes.Columns.Add("idUMProdUnit", "")                                  '8
        dgvAjustes.Columns.Add("IdProdEqui", "")                                    '9
        dgvAjustes.Columns.Add("IdUMProdEqui", "")                                  '10
        dgvAjustes.Columns.Add("intSentido", "")                                    '11

        dgvAjustes.Columns(0).Width = 330
        dgvAjustes.Columns(1).Width = 60
        dgvAjustes.Columns(2).Width = 55

        dgvAjustes.Columns(3).Width = 330
        dgvAjustes.Columns(4).Width = 60
        dgvAjustes.Columns(5).Width = 55

        dgvAjustes.Columns(6).Width = 80
        '...
        dgvAjustes.Columns(7).Width = 0
        dgvAjustes.Columns(8).Width = 0
        dgvAjustes.Columns(9).Width = 0
        dgvAjustes.Columns(10).Width = 0
        dgvAjustes.Columns(11).Width = 0

        dgvAjustes.Visible = True
    End Sub

    Private Sub CargarDGVAjustes()
        Dim strqry As String = "SELECT strDescProdUnit as [Nombre Producto Unitario], intCantidad as [Cant. Unit.], strUMProdUnit as [U.M.]," &
                                "strDescProdEqui as [Nombre Producto Equivalente], Equivalente, strUMProdEqui as [U.M.E.]," &
                    " 'Ajustar', IdProdUnit,idUMProdUnit,IdProdEqui,IdUMProdEqui,intSentido FROM vstListaAjustesInventario"
        Dim dsAjustes As New DataSet
        dsAjustes = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Ajustes", "No se cargó la tabla de ajustes pendientes")
        If dsAjustes.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No hay ajustes de mercancía pendientes.")
        Else
            Dim renglones As Integer = dsAjustes.Tables(0).Rows.Count
            For i As Integer = 0 To renglones - 1
                dgvAjustes.Rows.Add(dsAjustes.Tables(0).Rows(i)(0).ToString,
                                      dsAjustes.Tables(0).Rows(i)(1).ToString,
                                      dsAjustes.Tables(0).Rows(i)(2).ToString,
                                      dsAjustes.Tables(0).Rows(i)(3).ToString,
                                      dsAjustes.Tables(0).Rows(i)(4).ToString,
                                      dsAjustes.Tables(0).Rows(i)(5).ToString,
                                      dsAjustes.Tables(0).Rows(i)(6).ToString,
                                      dsAjustes.Tables(0).Rows(i)(7).ToString,
                                      dsAjustes.Tables(0).Rows(i)(8).ToString,
                                      dsAjustes.Tables(0).Rows(i)(9).ToString,
                                      dsAjustes.Tables(0).Rows(i)(10).ToString,
                                      dsAjustes.Tables(0).Rows(i)(11).ToString)
            Next
        End If
    End Sub

    Private Sub dgvAjustes_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAjustes.CellClick
        Me.Enabled = False
        Dim intColumna As Integer
        intColumna = e.ColumnIndex
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            If intColumna = 6 Then
                Dim j As Long = 0
                Dim intProceso As Integer
                intProceso = Integer.Parse(dgvAjustes.Rows(intRenglon).Cells(11).Value)
                Dim strqry As String = ""
                If intProceso = 1 Then
                    'agregamos el producto en negativo (pasamos la cantidad a cero)
                    'No verificamos existencia, pues si esta en la vista, esta en el inventario
                    strqry = "UPDATE tblInventario SET intCantidad = 0 where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(7).Value &
                            " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(8).Value & " And intVarControlInventario = 1"
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar nuevo producto al inventario.")

                    'Verificamos si realmente se hizo una compra anterior, si se ha hecho, actualiza, si no ha hecho, se inserta
                    strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(9).Value &
                            " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(10).Value & "And intVarControlInventario = 1"
                    Dim dsExiste As New DataSet
                    dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al buscar Invetario existente")
                    If dsExiste.Tables(0).Rows.Count = 0 Then
                        'se debe insertar la compra, o la transaccion y quedara en negativo. al momento de insertar la compra se ajustara a cero o positivo.
                        strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" &
                                    dgvAjustes.Rows(intRenglon).Cells(9).Value & ", " & dgvAjustes.Rows(intRenglon).Cells(10).Value &
                                    ", " & dgvAjustes.Rows(intRenglon).Cells(4).Value * -1 & ") "
                        j = 0
                        j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al afectar al Invetarion en una partida.")
                        If j = 0 Then
                            'No se pudo grabar la partida en la tabla
                            dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Red
                        Else
                            dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Green
                        End If
                    Else
                        'se debe actualizar el valor de cantidad, sumando...
                        strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) -
                                    Decimal.Parse(dgvAjustes.Rows(intRenglon).Cells(4).Value) &
                                    " where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(9).Value &
                                " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(10).Value & " And intVarControlInventario = 1"
                        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar nuevo producto al inventario.")
                        dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Green
                    End If
                End If
                If intProceso = 2 Then
                    'Primero definimos la cantidad que es un entero en las facciones
                    strqry = "Select decCantEquivalente from vstEquivalencias " &
                        " where IdProdEqui = " & dgvAjustes.Rows(intRenglon).Cells(9).Value &
                        " and IdUMProdEqui = " & dgvAjustes.Rows(intRenglon).Cells(10).Value
                    Dim dsCantidadContenida As New DataSet
                    dsCantidadContenida = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al obtener cantidad Contenida en equivalente")
                    Dim decCantidadContenida As Decimal
                    decCantidadContenida = 1 / dsCantidadContenida.Tables(0).Rows(0)(0)

                    'obtenemos la cantidad que vamos a sumar al producto unitario
                    Dim decCantidadAgregarUnitario As Decimal
                    Dim decCantidadRestarEquivalente As Decimal
                    Dim verifica As Decimal
                    verifica = (dgvAjustes.Rows(intRenglon).Cells(4).Value) - (Int(dgvAjustes.Rows(intRenglon).Cells(4).Value))
                    If verifica <= 0 Then
                        decCantidadRestarEquivalente = (Int(dgvAjustes.Rows(intRenglon).Cells(4).Value))   '+ 1)
                    Else
                        decCantidadRestarEquivalente = (Int(dgvAjustes.Rows(intRenglon).Cells(4).Value) + 1)
                    End If


                    decCantidadAgregarUnitario = decCantidadContenida * decCantidadRestarEquivalente


                    Dim decCantidadAjuste As Decimal = decCantidadAgregarUnitario + dgvAjustes.Rows(intRenglon).Cells(1).Value
                    'MsgBox(decCantidadAjuste & " / " & decCantidadRestarEquivalente)

                    'agregamos el producto en negativo (No pasamos la cantidad a cero, se ajusta a existente (negativo) mas cantidadagregarunitario)
                    'No verificamos existencia, pues si esta en la vista, esta en el inventario
                    strqry = "UPDATE tblInventario SET intCantidad = " & decCantidadAjuste & " where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(7).Value &
                            " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(8).Value & " And intVarControlInventario = 1"
                    funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar nuevo producto al inventario.")

                    'Verificamos si realmente se hizo una compra anterior, si se ha hecho, actualiza, si no ha hecho, se inserta
                    strqry = "SELECT intCantidad from tblInventario where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(9).Value &
                            " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(10).Value & " And intVarControlInventario = 1"
                    Dim dsExiste As New DataSet
                    dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al buscar Invetario existente")
                    If dsExiste.Tables(0).Rows.Count = 0 Then
                        'se debe insertar la compra, o la transaccion y quedara en negativo. al momento de insertar la compra se ajustara a cero o positivo.
                        strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" &
                                    dgvAjustes.Rows(intRenglon).Cells(9).Value & ", " & dgvAjustes.Rows(intRenglon).Cells(10).Value &
                                    ", " & decCantidadRestarEquivalente & ") "
                        j = 0
                        j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al afectar al Invetarion en una partida.")
                        If j = 0 Then
                            'No se pudo grabar la partida en la tabla
                            dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Red
                        Else
                            dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Green
                        End If
                    Else
                        Dim decCantidadActual As Decimal
                        decCantidadActual = dsExiste.Tables(0).Rows(0)(0)
                        Dim decCantidadRemanente As Decimal
                        decCantidadRemanente = decCantidadActual - decCantidadRestarEquivalente
                        'se debe actualizar el valor de cantidad, sumando...
                        strqry = "UPDATE tblInventario SET intCantidad = " & decCantidadRemanente &
                                    " where IdProducto = " & dgvAjustes.Rows(intRenglon).Cells(9).Value &
                                " and idUnidadMedida = " & dgvAjustes.Rows(intRenglon).Cells(10).Value & " And intVarControlInventario = 1"
                        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al ingresar nuevo producto al inventario.")
                        dgvAjustes.Item(1, intRenglon).Style.BackColor = Color.Green
                    End If
                End If
                    strqry = "INSERT INTO tblTransaccionesAjustesInventario (intProdUnitario,decCantUnitaria,intProdEqui,decCantEqui,intSentido) VALUES(" &
                    dgvAjustes.Rows(intRenglon).Cells(7).Value & ", " & dgvAjustes.Rows(intRenglon).Cells(1).Value & ", " & dgvAjustes.Rows(intRenglon).Cells(8).Value &
                    ", " & dgvAjustes.Rows(intRenglon).Cells(4).Value & ", " & dgvAjustes.Rows(intRenglon).Cells(11).Value & ") "
                    j = 0
                    j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al Ingresar transaccion.")
                    GrabarAccion(26, j)

                    Pausa(100)

                    Limpiar()
                    PrepararDGVAjustes()
                    CargarDGVAjustes()

                End If
            End If

            Me.Enabled = True
    End Sub

    Private Sub btnRecargar_Click(sender As System.Object, e As System.EventArgs) Handles btnRecargar.Click
        Limpiar()
        PrepararDGVAjustes()
        CargarDGVAjustes()
    End Sub
End Class