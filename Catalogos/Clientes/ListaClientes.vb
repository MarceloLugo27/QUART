Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class ListaClientes

    Private Sub LimpiarTXB()
        tbNombreCliente.Text = ""
        tbID.Text = ""
        tbParametroBusqueda.Text = ""
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

    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarTXB()
        If MDIPrincipal.PermisoEditarClientes = False Then
            gbEditarCliente.Visible = False
        End If
        btnEditar.Enabled = False
        cbParamBusqueda.Text = "Nombre de cliente"
        GroupBox1.Enabled = False
        'VerificarServer(2)
        Dim strConsulta As String
        strConsulta = "SELECT [IDCliente] as [ID],[strNombreCliente] as [Nombre de cliente],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 3],[strCorreoElectronico] as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatClientes]"
        PrepararDGV(dgvListaClientes)

        LlenarDataGrid(strConsulta, dgvListaClientes)

    End Sub

    Private Sub tbCliente_TextChanged(sender As Object, e As EventArgs) Handles tbParametroBusqueda.TextChanged
        'VerificarServer(1)
        PrepararDGV(dgvListaClientes)
        Dim strConsulta As String
        Select Case cbParamBusqueda.DisplayMember
            Case "Nombre de cliente"
                strConsulta = "SELECT [IDCliente] as [ID],[strNombreCliente] as [Nombre de cliente],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 3],[strCorreoElectronico] as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatClientes]" &
        "WHERE strNombreCliente LIKE '%" & tbParametroBusqueda.Text & "%'"
                LlenarDataGridNoMensaje(strConsulta, dgvListaClientes)
            Case "Nombre de contacto"
                strConsulta = "SELECT [IDCliente] as [ID],[strNombreCliente] as [Nombre de cliente],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 3],[strCorreoElectronico] as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatClientes]" &
        "WHERE strNombreContacto LIKE '%" & tbParametroBusqueda.Text & "%'"
                LlenarDataGridNoMensaje(strConsulta, dgvListaClientes)
            Case Else
                strConsulta = "SELECT [IDCliente] as [ID],[strNombreCliente] as [Nombre de cliente],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 3],[strCorreoElectronico] as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatClientes]" &
        "WHERE strNombreCliente LIKE '%" & tbParametroBusqueda.Text & "%'"
                LlenarDataGridNoMensaje(strConsulta, dgvListaClientes)
        End Select

    End Sub

    Private Sub dgvListaClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaClientes.CellClick

        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then

            Dim intProveedor As Integer
            intProveedor = dgvListaClientes.Rows(intRenglon).Cells(0).Value

            Dim dsCliente As New DataSet
            Dim strQuery As String
            strQuery = "SELECT [IDCliente],[strNombreCliente],[strDomicilio],[strColonia],[strMunicipio],[strEstado],[strTelefono1]," &
          "[strTelefono2],[strTelefono3],[strCorreoElectronico],[strRFC],[strNombreContacto],[strObservaciones] FROM [dbQuart].[dbo].[tblCatClientes] where IDCliente = " & intProveedor
            dsCliente = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "tblClientes", "")

            LimpiarTXB()
            tbID.Text = dsCliente.Tables("tblClientes").Rows(0)(0).ToString
            tbNombreCliente.Text = dsCliente.Tables("tblClientes").Rows(0)(1).ToString
            tbDomicilio.Text = dsCliente.Tables("tblClientes").Rows(0)(2).ToString
            tbColonia.Text = dsCliente.Tables("tblClientes").Rows(0)(3).ToString
            tbMunicipio.Text = dsCliente.Tables("tblClientes").Rows(0)(4).ToString
            tbEstado.Text = dsCliente.Tables("tblClientes").Rows(0)(5).ToString
            tbTelefono1.Text = dsCliente.Tables("tblClientes").Rows(0)(6).ToString
            tbTelefono2.Text = dsCliente.Tables("tblClientes").Rows(0)(7).ToString
            tbTelefono3.Text = dsCliente.Tables("tblClientes").Rows(0)(8).ToString
            tbEmail.Text = dsCliente.Tables("tblClientes").Rows(0)(9).ToString
            tbRFC.Text = dsCliente.Tables("tblClientes").Rows(0)(10).ToString
            tbNombreContacto.Text = dsCliente.Tables("tblClientes").Rows(0)(11).ToString
            tbObservaciones.Text = dsCliente.Tables("tblClientes").Rows(0)(12).ToString

        End If
    End Sub

    Private Sub PrepararTextBoxes(ByVal Textbox As TextBox)
        With Textbox
            .ReadOnly = True
            .Text = Nothing
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'VerificarServer(1)
        Dim strQuery As String
        strQuery = "UPDATE [dbo].[tblCatClientes]" &
        " SET [strNombreCliente] = '" & tbNombreCliente.Text & "',[strDomicilio] = '" & tbDomicilio.Text & "'" &
      ",[strColonia] = '" & tbColonia.Text & "',[strMunicipio] = '" & tbMunicipio.Text & "'" &
      ",[strEstado] = '" & tbEstado.Text & "'" &
      ",[strTelefono1] = '" & tbTelefono1.Text & "',[strTelefono2] = '" & tbTelefono2.Text & "'" &
      ",[strTelefono3] = '" & tbTelefono3.Text & "',[strCorreoElectronico] = '" & tbEmail.Text & "'" &
      ",[strRFC] = '" & tbRFC.Text & "',[strNombreContacto] = '" & tbNombreContacto.Text & "'" &
      ",[strObservaciones] = '" & tbObservaciones.Text & "' WHERE [IDCliente] = " & tbID.Text & ""
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")
        chkbEditar.Checked = False
        LimpiarTXB()
        Dim strConsulta As String
        strConsulta = "SELECT [IDCliente] as [ID],[strNombreCliente] as [Nombre de cliente],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 3],[strCorreoElectronico] as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatClientes]"
        PrepararDGV(dgvListaClientes)

        LlenarDataGrid(strConsulta, dgvListaClientes)

    End Sub

    Private Sub chkbEditar_CheckedChanged(sender As Object, e As EventArgs) Handles chkbEditar.CheckedChanged
        Select Case chkbEditar.Checked
            Case True
                GroupBox1.Enabled = True
                tbID.Enabled = False
                btnEditar.Enabled = True
            Case False
                GroupBox1.Enabled = False
                btnEditar.Enabled = False
        End Select
    End Sub

    Private Sub ListaClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantListadoClientes = False
    End Sub

    Private Sub dgvListaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaClientes.CellContentClick

    End Sub

    Private Sub cbParamBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbParamBusqueda.SelectedIndexChanged

    End Sub
End Class