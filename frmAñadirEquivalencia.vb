Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Class frmAñadirEquivalencia

    Dim intSentido As Integer
    Dim intProducto1 As Integer
    Dim intProducto2 As Integer
    Dim UM1 As Integer
    Dim UM2 As Integer


    Private Sub tbProducto1_Click(sender As Object, e As EventArgs) Handles tbProducto1.Click
        tbProducto1.Text = ""
        cbProducto1.Items.Clear()
        tbProducto1.Focus()
        cbUM1.DataSource = Nothing
    End Sub

    Private Sub tbProducto1_TextChanged(sender As Object, e As EventArgs) Handles tbProducto1.TextChanged
        Dim intLargo As Integer = Len(tbProducto1.Text)
        If intLargo >= 3 Then
            cbProducto1.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where strDescripcionProducto like '%" & tbProducto1.Text & "%'  and IdProducto > 1 order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto1, "IDProducto", "Producto")
            cbProducto1.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbProducto1.DroppedDown = False
            cbProducto1.DataSource = Nothing
            cbProducto1.Items.Clear()
        End If
    End Sub

    Private Sub tbProducto1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProducto1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cbUM1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbUM1.SelectedValueChanged
        If cbUM1.DataSource IsNot Nothing Then
            UM1 = DirectCast(cbUM1.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If

        'If cbUM1.DataSource IsNot Nothing Then
        '    UM1 = cbUM1.ValueMember
        'End If
    End Sub

    Private Sub frmAñadirEquivalencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbCantidadEquivalente1.Focus()
        ' cbSentido.Text = "Multiplicativa"
    End Sub

    Private Sub INICIAR()
        tbProducto1.Text = ""
        tbProducto2.Text = ""
        cbProducto1.Items.Clear()
        cbProducto2.Items.Clear()
        tbProducto1.Focus()

    End Sub
    Private Sub CargarComboUnidadMedida1()
        Dim strqry As String
        'strqry para usar cuando se haga la relacion producto - proveedor
        strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where IDProducto = " & cbProducto1.ValueMember & " Order by strUnidadMedida "
        LlenarCombo(strqry, cbUM1, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub CargarComboUnidadMedida2()
        Dim strqry As String
        'strqry para usar cuando se haga la relacion producto - proveedor
        strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where IDProducto = " & cbProducto2.ValueMember & " Order by strUnidadMedida "
        LlenarCombo(strqry, cbUM2, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub tbProducto2_Click(sender As Object, e As System.EventArgs) Handles tbProducto2.Click
        tbProducto2.Text = ""
        cbProducto2.Items.Clear()
        tbProducto2.Focus()
        cbUM2.DataSource = Nothing
    End Sub

    Private Sub tbProducto2_TextChanged(sender As Object, e As EventArgs) Handles tbProducto2.TextChanged
        Dim intLargo As Integer = Len(tbProducto2.Text)
        If intLargo >= 3 Then
            cbProducto2.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where strDescripcionProducto like '%" & tbProducto2.Text & "%'  and IdProducto > 1 order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto2, "IDProducto", "Producto")
            cbProducto2.DroppedDown = True
            Windows.Forms.Cursor.Current = Cursors.Arrow
        End If
        If intLargo = 0 Then
            cbProducto2.DroppedDown = False
            cbProducto2.DataSource = Nothing
            cbProducto2.Items.Clear()
        End If
    End Sub

    Private Sub tbProducto2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProducto2.KeyPress

        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cbSentido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSentido.SelectedIndexChanged
        'Select Case cbSentido.DisplayMember
        '    Case "Multiplicativa"
        '        intSentido = 1
        '    Case "Dividida"
        '        intSentido = 2
        'End Select
    End Sub

    Private Sub btnCrearEquivalencia_Click(sender As Object, e As EventArgs) Handles btnCrearEquivalencia.Click
        If tbCantidadEquivalente1.Text = "" Or cbProducto1.DataSource Is Nothing Or cbUM1.DataSource Is Nothing Or tbCantidadEquivalente2.Text = "" Or cbProducto2.DataSource Is Nothing Or cbUM2.DataSource Is Nothing Then
            MsgBox("Al menos uno de los campos está vacío, favor de verificar")
        Else
            Dim strqry As String
            Dim retorno As Long
            Dim Equivalencia As Decimal
            Dim yaexiste As Boolean = True
            Dim strConsulta As String =
                "select count (intProdUnitario) as cuantos from tblEquivalencias where intProdUnitario = " & intProducto1 &
                " and intProdEquivalente = " & intProducto2
            Dim dsCuantos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "Cuantos", "")
            If dsCuantos.Tables(0).Rows(0)(0) = 0 Then

                If tbCantidadEquivalente2.Text > tbCantidadEquivalente1.Text Then
                    intSentido = 1
                    Equivalencia = tbCantidadEquivalente2.Text * tbCantidadEquivalente1.Text
                Else

                    If tbCantidadEquivalente2.Text < tbCantidadEquivalente1.Text Then
                        intSentido = 2
                        Equivalencia = tbCantidadEquivalente2.Text / tbCantidadEquivalente1.Text
                    End If
                End If
                strqry = "INSERT INTO [dbQuart].[dbo].[tblEquivalencias]([intProdUnitario],[intUM_Prod1],[intProdEquivalente],[intUM_Prod2],[decCantEquivalente],[intSentido])" &
                "VALUES(" & intProducto1 & ", " & UM1 & ", " & intProducto2 & "," & UM2 & "," & Equivalencia & "," & intSentido & ")"
                retorno = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
                If retorno > 0 Then
                    MsgBox("La equivalencia fue ingresada correctamente.")
                    tbCantidadEquivalente1.Text = ""
                    tbCantidadEquivalente2.Text = ""
                    tbProducto1.Text = ""
                    tbProducto2.Text = ""
                    LimpiarCombo(cbProducto1)
                    LimpiarCombo(cbProducto2)
                    LimpiarCombo(cbUM1)
                    LimpiarCombo(cbUM2)
                Else
                    MsgBox("La equivalencia no fue ingresada correctamente.")
                End If
            Else
                MsgBox("Ya existe una equivalencia que involucre a ambos productos.")
            End If
        End If

    End Sub

    Private Sub frmAñadirEquivalencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantAñadirEquivalencias = False
    End Sub

    Private Sub cbProducto1_Click(sender As Object, e As System.EventArgs) Handles cbProducto1.Click

    End Sub

    Private Sub cbProducto1_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto1.SelectedValueChanged
        If cbProducto1.DataSource IsNot Nothing Then
            intProducto1 = DirectCast(cbProducto1.SelectedItem, DataRowView).Item("IDProducto")

            Dim strqry As String
            'strqry para usar cuando se haga la relacion producto - proveedor
            'strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstProductoProveedor  where IDProveedor = " & intProveedor & " and IDProducto = " & intProducto & " Order by strUnidadMedida "
            strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where IDProducto = " & _
                intProducto1 & " Order by strUnidadMedida "
            cbUM1.DataSource = Nothing
            LlenarCombo(strqry, cbUM1, "IDUnidadMedida", "strUnidadMedida")
            'UM1 = cbUM1.ValueMember
        End If
    End Sub

    Private Sub cbProducto2_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto2.SelectedValueChanged
        If cbProducto2.DataSource IsNot Nothing Then
            intProducto2 = DirectCast(cbProducto2.SelectedItem, DataRowView).Item("IDProducto")
            Dim strqry As String
            'strqry para usar cuando se haga la relacion producto - proveedor
            'strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstProductoProveedor  where IDProveedor = " & intProveedor & " and IDProducto = " & intProducto & " Order by strUnidadMedida "
            strqry = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where IDProducto = " & intProducto2 & " Order by strUnidadMedida "
            cbUM2.DataSource = Nothing
            LlenarCombo(strqry, cbUM2, "IDUnidadMedida", "strUnidadMedida")

        End If
    End Sub

    Private Sub cbUM2_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUM2.SelectedValueChanged
        If cbUM2.DataSource IsNot Nothing Then
            UM2 = DirectCast(cbUM2.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If
    End Sub
End Class
