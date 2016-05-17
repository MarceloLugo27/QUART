Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal


Public Class EdicionProductos
    Dim intProducto As Integer
    Dim intInventariable As Integer
    Dim intAplicaIVA As Integer
    Dim intIDProveedor As Integer
    Dim strProveedor As String
    Dim intUnidadMedida As Integer
    Dim strUnidadMedida As String


    Private Sub tbProducto_TextChanged(sender As Object, e As EventArgs) Handles tbProducto.TextChanged
        'tbProducto.Text = ""
        'cbProducto.Items.Clear()
        'tbProducto.Focus()
        Dim intLargo As Integer = Len(tbProducto.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT IDProducto, strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where strDescripcionProducto like '%" & tbProducto.Text & "%'  and IdProducto > 1 order by strDescripcionProducto"
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

    Private Sub tbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cbProducto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            intProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            Dim strqryProducto As String = "Select [strDescripcionProducto],[strMarcaProducto],[strModelo],[intInventariable],[intAplicaIVA],[IDProveedor],[IDUnidadMedida],[decPrecioA],[decPrecioB],[decPrecioC],[decPrecioD], strNombreProveedor,strUnidadMedida from vstProductosCompleto where IDProducto = " & intProducto
            Dim dsProductos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqryProducto, "vstProductosCompleto", "")
            ' MsgBox(dsProductos.Tables(0).Rows.Count)

            If dsProductos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se pudo recuperar la información")
            Else
                tbNombreProducto.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(0).ToString
                tbMarca.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(1).ToString
                tbModelo.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(2).ToString
                intInventariable = dsProductos.Tables("vstProductosCompleto").Rows(0)(3).ToString
                Select Case intInventariable
                    Case 1
                        chkbInventariable.Checked = True
                    Case Else
                        chkbInventariable.Checked = False
                End Select
                intAplicaIVA = dsProductos.Tables("vstProductosCompleto").Rows(0)(4).ToString
                Select Case intAplicaIVA
                    Case 1
                        chkAplicaIVA.Checked = True
                    Case Else
                        chkAplicaIVA.Checked = False
                End Select
                intIDProveedor = dsProductos.Tables("vstProductosCompleto").Rows(0)(5).ToString

                cbProveedor.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(11).ToString

                intUnidadMedida = dsProductos.Tables("vstProductosCompleto").Rows(0)(6).ToString
                cbTipoUnidad.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(12).ToString
                'cbTipoUnidad.SelectedValue = intUnidadMedida

                Precio1.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(7).ToString
                Precio2.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(8).ToString
                Precio3.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(9).ToString
                Precio4.Text = dsProductos.Tables("vstProductosCompleto").Rows(0)(10).ToString
            End If
        End If
    End Sub

    Private Sub EdicionProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantEdicionProductos = False
    End Sub

    Private Sub cbProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles cbProducto.MouseClick


    End Sub

    Private Sub EdicionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strqryProveedor As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores"
        LlenarCombo(strqryProveedor, cbProveedor, "IDProveedor", "strNombreProveedor")

        Dim strqryUM As String = "SELECT IDUnidadMedida, strUnidadMedida from tblCatUnidadMedida Order by strUnidadMedida"
        LlenarCombo(strqryUM, cbTipoUnidad, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedValueChanged
        If cbProveedor.DataSource IsNot Nothing Then
            '    intIDProveedor = cbProveedor.ValueMember = "IDProveedor"
            intIDProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
        End If
    End Sub

    Private Sub cbTipoUnidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoUnidad.SelectedValueChanged
        If cbTipoUnidad.DataSource IsNot Nothing Then
            intUnidadMedida = DirectCast(cbTipoUnidad.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If
    End Sub

    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click
        If chkbInventariable.Checked = True Then
            intInventariable = 1
        Else
            intInventariable = 0
        End If
        If chkAplicaIVA.Checked = True Then
            intAplicaIVA = 1
        Else
            intAplicaIVA = 0
        End If

        Dim strqryProductos As String = "UPDATE [dbQuart].[dbo].[tblCatProductos] SET [strDescripcionProducto] = '" & tbNombreProducto.Text & "'," &
"[strMarcaProducto] = '" & tbMarca.Text & "', [strModelo] = '" & tbModelo.Text & "'," &
"[intInventariable]=  " & intInventariable & ", [intAplicaIVA] =  " & intAplicaIVA &
" WHERE IDProducto = " & intProducto
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqryProductos, "")

        Dim strqryProovedorProducto As String = "UPDATE [dbQuart].[dbo].[tblProveedorProducto] SET [IDProveedor] = " & intIDProveedor & " ," &
"[IDUnidadMedida] = " & intUnidadMedida & " WHERE IDProducto = " & intProducto
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqryProovedorProducto, "")

        If Precio1.Text = "" Then Precio1.Text = "0.00"
        If Precio2.Text = "" Then Precio1.Text = "0.00"
        If Precio3.Text = "" Then Precio1.Text = "0.00"
        If Precio4.Text = "" Then Precio1.Text = "0.00"

        Dim strqryListaPrecios As String = "UPDATE [dbQuart].[dbo].[tblListaPrecios]" &
   "SET [IdUnidadMedida] = " & intUnidadMedida & ", [decPrecioA] = " & Precio1.Text & ", [decPrecioB] = " & Precio2.Text & ", [decPrecioC] = " & Precio3.Text & ", [decPrecioD] = " & Precio4.Text &
 "WHERE IDProducto = " & intProducto
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqryListaPrecios, "")

        MsgBox("Producto modificado.")

    End Sub
End Class