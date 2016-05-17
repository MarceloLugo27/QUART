Imports QuartOK.ProcedimientosGenerales

Public Class AltaProveedor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VerificarServer(2)
        Dim strQuery As String
        Dim j As Long
        strQuery = "INSERT INTO [dbo].[tblCatProveedores] ([strNombreProveedor]," &
            "[strDomicilio],[strColonia],[strEstado],[strMunicipio],[strTelefono1],[strTelefono2],[strTelefono3],[strCorreoElectronico],[strRFC]," &
            "[strNombreContacto],[strObservaciones])" &
        "VALUES('" & tbNombreProveedor.Text & "', '" & tbDomicilio.Text & "','" & tbColonia.Text & "','" & tbMunicipio.Text & "','" & tbEstado.Text & "'," &
        "'" & tbTelefono1.Text & "','" & tbTelefono2.Text & "','" & tbTelefono3.Text & "','" & tbEmail.Text & "', '" & tbRFC.Text & "', '" & tbNombreContacto.Text & "', '" & tbObservaciones.Text & "')"
        j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")
        If j = 0 Then
            MessageBox.Show("No pudo ingresarse el proveedor, intente nuevamente")
        Else
            MessageBox.Show("Proveedor nuevo ingresado con el identificador número " & j)
            LimpiarTXB()
        End If
    End Sub

    Private Sub LimpiarTXB()
        tbNombreProveedor.Text = ""
        tbID.Text = ""
        tbDomicilio.Text = ""
        tbColonia.Text = ""
        tbMunicipio.Text = ""
        tbEstado.Text = ""
        tbEmail.Text = ""
        tbNombreContacto.Text = ""
        tbRFC.Text = ""
        tbTelefono1.Text = ""
        tbTelefono2.Text = ""
        tbTelefono3.Text = ""
        tbObservaciones.Text = ""
    End Sub

    Private Sub AltaProveedor_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantAltaProveedores = False
    End Sub

    Private Sub AltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarTXB()
        tbID.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '   ListaProveedor.Parent = MDIPrincipal
        ListaProveedor.Show()
    End Sub
End Class