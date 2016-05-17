Imports QuartOK.ProcedimientosGenerales

Public Class AltaProductos



    Private Sub btnAltaProductos_Click(sender As Object, e As EventArgs) Handles btnAltaProductos.Click

        Dim strQuery As String
        Dim intTipoProducto As Integer
        Dim intInventariable As Integer

        If rbMateriaPrima.Checked = True Then
            intTipoProducto = 1
        End If
        If rbMixto.Checked = True Then
            intTipoProducto = 2
        End If
        If rbTerminado.Checked = True Then
            intTipoProducto = 3
        End If

        If chkbInventariable.Checked = True Then
            intInventariable = 1
        Else
            intInventariable = 0
        End If


        strQuery = "INSERT INTO [dbo].[tblCatProductos] ([IDProducto], [strDescripcionProducto],[strMarcaProducto],[strModelo],[intTipoProducto],[intInventariable])" &
        "VALUES(" & tbID.Text & ",'" & tbNombreProducto.Text & "','" & tbMarca.Text & "','" & tbModelo.Text & "'," & intTipoProducto & ", " & intInventariable & ")"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")

        strNombreProducto = tbNombreProducto.Text

        ProcedimientosGenerales.GrabarAccion(11, tbID.Text)
        ProductoProveedor.Show()

        Limpiar()

    End Sub

    Private Sub AltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMixto.Checked = True
        chkbInventariable.Checked = True
        'Limpiar()
        EvaluaOrigen()
    End Sub

    Private Sub EvaluaOrigen()
        If ProductoXML = 0 Then
            Exit Sub
        Else
            tbID.Text = LeerXML.strNumIDProdXML
            tbID.Enabled = False
            tbNombreProducto.Text = LeerXML.strDescripcionProdXML
            tbNombreProducto.Enabled = False

            ProductoXML = 0
        End If
    End Sub

    Private Sub Limpiar()
        tbID.Text = ""
        tbNombreProducto.Text = ""
        tbMarca.Text = ""
        tbModelo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProductoProveedor.Show()

    End Sub

    Private Sub AltaProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantAltaProductos = False
    End Sub
End Class