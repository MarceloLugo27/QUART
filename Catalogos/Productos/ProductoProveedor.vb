Imports QuartOK.ProcedimientosGenerales

Public Class ProductoProveedor

    Private Sub ActualizarNombreProducto()
        If strNombreProducto <> "" Then
            Dim strqry As String = "SELECT IDProducto, strDescripcionProducto FROM tblCatProductos WHERE strDescripcionProducto = '" & strNombreProducto & "'"
            LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
        Else
            Dim strqry As String = "SELECT IDProducto, strDescripcionProducto FROM tblCatProductos"
            LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
        End If
    End Sub

    Private Sub ActualizarProveedor()
        Dim strqryProveedor As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores order by strNombreProveedor"
        LlenarCombo(strqryProveedor, cbProveedor, "IDProveedor", "strNombreProveedor")
    End Sub

    Private Sub ActualizarUnidadMedida()
        Dim strqryUM As String = "SELECT IDUnidadMedida, strUnidadMedida from tblCatUnidadMedida Order by strUnidadMedida"
        LlenarCombo(strqryUM, cbTipoUnidad, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub ProductoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarNombreProducto()
        ActualizarProveedor()
        ActualizarUnidadMedida()
    End Sub

    Private Sub btnAsociar_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        Dim strqryAsociar As String = "INSERT INTO [tblProveedorProducto]([IDProducto], [IDProveedor], [IDUnidadMedida], [intVarControlproveedorProducto])VALUES(" & cbProducto.ValueMember & ", " & cbProveedor.ValueMember & "," & cbTipoUnidad.ValueMember & ", 1)"
        cbProducto.Text = ""
        cbProveedor.Text = ""
        cbTipoUnidad.Text = ""
        MessageBox.Show("Producto asociado exitosamente.")
    End Sub

    Private Sub cbProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles cbProducto.KeyUp
        Dim intLargo As Integer = Len(cbProducto.Text)
        If intLargo > 3 Then
            'Dim strqry As String = "Select DISTINCT IDProducto, [strDescripcionProducto] FROM vstProductoProveedor  where IDProveedor = " & intProveedor & " order by strDescripcionProducto"

            Dim strqry As String = "Select DISTINCT IDProducto, [strDescripcionProducto] FROM vstProductoProveedor  where strDescripcionProducto like '%" & cbProducto.Text & "%' order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "strDescripcionProducto")
            cbProducto.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cbProveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles cbProveedor.KeyUp
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

    Private Sub ProductoProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantProductoProveedor = False
    End Sub
End Class