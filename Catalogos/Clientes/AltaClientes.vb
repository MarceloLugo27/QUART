Imports QuartOK.ProcedimientosGenerales

Public Class AltaClientes

#Region "Agregar Cliente"

    Private Sub btnAñadirCliente_Click(sender As Object, e As EventArgs) Handles btnAñadirCliente.Click
        'VerificarServer(2)
        Dim strQuery As String
        Dim idCliente As Integer
        strQuery = "INSERT INTO [dbo].[tblCatClientes] ([strNombreCliente],[strRazonSocialCliente]," &
            "[strDomicilio],[strColonia],[strEstado],[strMunicipio],[strTelefono1],[strTelefono2],[strTelefono3],[strCorreoElectronico],[strRFC]," &
            "[strNombreContacto],[strObservaciones], IDClienteQuart)" &
        "VALUES('" & tbNombreCliente.Text & "', '" & tbNombreCliente.Text & "', '" & tbDomicilio.Text & "','" & tbColonia.Text & "','" & tbMunicipio.Text & "','" & tbEstado.Text & "'," &
        "'" & tbTelefono1.Text & "','" & tbTelefono2.Text & "','" & tbTelefono3.Text & "','" & tbEmail.Text & "', '" & tbRFC.Text & "', '" & tbNombreContacto.Text & "', '" & tbObservaciones.Text &
        "', '" & tbID.Text & "')"

        idCliente = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "Error al grabar un cliente nuevo.")

        If idCliente = 0 Then
            MessageBox.Show("El cliente no se grabo correctamente.")
            Exit Sub
        End If

        If ClienteXML = 0 Then
            GrabarAccion(11, idCliente)
        Else
            GrabarAccion(10, idCliente)
            ClienteXML = 0
            LeerXML.btnVerificarProductos.Enabled = True
            Me.Close()
        End If

        LimpiarTXB()
    End Sub

#End Region

#Region "Cargar Formato"

    Private Sub LimpiarTXB()
        tbNombreCliente.Text = ""
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

    Private Sub AltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarTXB()
        tbID.Enabled = True
        EvaluaOrigen()

    End Sub

    Private Sub AltaClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantListadoClientes = False
    End Sub

#End Region

#Region "Mostrar Lista de Clientes"

    Private Sub btnListaClientes_Click(sender As Object, e As EventArgs) Handles btnListaClientes.Click
        ListaClientes.Parent = MDIPrincipal
        ListaClientes.Show()
    End Sub

#End Region

#Region "Evaluar Origen del Cliente"

    Private Sub EvaluaOrigen()
        If ClienteXML = 0 Then
            gbTodo.Enabled = False
            Exit Sub
        ElseIf ClienteXML Then
            tbNombreCliente.Text = LeerXML.strReceptorNombre
            tbNombreCliente.Enabled = False
            tbDomicilio.Text = LeerXML.strReceptorCalle & ", " & LeerXML.strReceptorNoExterior
            tbDomicilio.Enabled = False
            tbColonia.Text = LeerXML.strReceptorColonia
            tbColonia.Enabled = False
            tbMunicipio.Text = LeerXML.strReceptorMunicipio
            tbMunicipio.Enabled = False
            tbEstado.Text = LeerXML.strReceptorEstado
            tbEstado.Enabled = False
            tbRFC.Text = LeerXML.strReceptorRFC
            tbRFC.Enabled = False
            gbTodo.Enabled = False

        End If

    End Sub

#End Region

#Region "Validar ID del cliente"
    Private Sub tbID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbID.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            If InStr(1, Chr(13), e.KeyChar) = 1 Then
                btnAñadirID.Focus()
            Else
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub btnAñadirID_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadirID.Click
        Dim Adelante As Boolean = VerificaID(tbID.Text)
        If Adelante = False Then
            MessageBox.Show("El ID que esta ingresando ya esta siendo utilizado por otro cliente. Verifique correctamente el ID, el cual debe de ser el mismo en la base de datos de facturacion" &
                            vbCr & vbCr & "Recuerdo que el no tener consistencia en ambas bases de datos puede llevar a perder la consistencia de toda la información de este sistema",
                            "ID del Cliente ya existente.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbID.Text = ""
            tbID.Focus()
            Exit Sub
        End If
        If ClienteXML = 0 Then
            gbTodo.Enabled = True
            tbNombreCliente.Focus()
            gbTodo.Enabled = True
        Else
            gbTodo.Enabled = True
            tbEmail.Focus()
        End If

    End Sub

    Function VerificaID(ByRef IdCliente As String) As Boolean
        Dim SigueAdelante As Boolean = False
        If IdCliente <> "" Then

            Dim strqry As String = "SELECT IDCliente FROM tblCatClientes where IDClienteQuart = '" & IdCliente & "' "
            Dim dsExiste As DataSet
            dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Existe", "Error al verificar Cliente Existente")
            If dsExiste.Tables(0).Rows.Count = 0 Then
                SigueAdelante = True
            End If
        End If
        Return SigueAdelante
    End Function

#End Region

#Region "Restricciones de entrada a los TextBox"

    Private Sub tbNombreCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombreCliente.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbDomicilio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbDomicilio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbMunicipio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMunicipio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbColonia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbColonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbEstado_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbEstado.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbRFC_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbRFC.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbNombreContacto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombreContacto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbObservaciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbObservaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbTelefono1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTelefono1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbTelefono2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTelefono2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbTelefono3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTelefono3.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

End Class