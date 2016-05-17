Imports QuartOK.ProcedimientosGenerales

Public Class ListaProveedor


    Private Sub LimpiarTXB()
        tbNombreProveedor.Text = ""
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
        If MDIPrincipal.PermisoEditarProveedores = False Then
            gbEditarProveedor.Visible = False
        End If
        LimpiarTXB()
        btnEditar.Enabled = False
        GroupBox1.Enabled = False
        cbParamBusqueda.Text = "Nombre de Proveedor"
        'VerificarServer(1)
        Dim strConsulta As String
        strConsulta = "SELECT [IDProveedor] as [ID],[strNombreProveedor] as [Nombre de Proveedor],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 2],[strCorreoElectronico]as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatProveedores]"
        PrepararDGV(dgvListaProveedores)

        LlenarDataGrid(strConsulta, dgvListaProveedores)

    End Sub

    Private Sub tbProveedor_TextChanged(sender As Object, e As EventArgs) Handles tbParametroBusqueda.TextChanged
        'VerificarServer(1)
        PrepararDGV(dgvListaProveedores)
        Dim strConsulta As String
        Select Case cbParamBusqueda.DisplayMember
            Case "Nombre de Proveedor"
                strConsulta = "SELECT [IDProveedor] as [ID],[strNombreProveedor] as [Nombre de Proveedor],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 2],[strCorreoElectronico]as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatProveedores]" & _
        "WHERE strNombreProveedor LIKE '%" & tbParametroBusqueda.Text & "%'"
                LlenarDataGridNoMensaje(strConsulta, dgvListaProveedores)
            Case "Nombre de Contacto"
                strConsulta = "SELECT [IDProveedor] as [ID],[strNombreProveedor] as [Nombre de Proveedor],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 2],[strCorreoElectronico]as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatProveedores]" &
        "WHERE strNombreContacto LIKE '%" & tbParametroBusqueda.Text & "%'"
                LlenarDataGridNoMensaje(strConsulta, dgvListaProveedores)
        End Select

    End Sub

    Private Sub dgvListaProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProveedores.CellClick

        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            Dim intProveedor As Integer
            intProveedor = dgvListaProveedores.Rows(intRenglon).Cells(0).Value


            Dim dsProveedor As New DataSet
            Dim strQuery As String
            strQuery = "SELECT [IDProveedor],[strNombreProveedor],[strDomicilio],[strColonia],[strMunicipio],[strEstado],[strTelefono1]," &
      "[strTelefono2],[strTelefono3],[strCorreoElectronico],[strRFC],[strNombreContacto],[strObservaciones] FROM [dbQuart].[dbo].[tblCatProveedores]" &
      " where IDProveedor = " & intProveedor
            dsProveedor = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "tblProveedores", "")

            LimpiarTXB()
            tbID.Text = dsProveedor.Tables("tblProveedores").Rows(0)(0).ToString
            tbNombreProveedor.Text = dsProveedor.Tables("tblProveedores").Rows(0)(1).ToString
            tbDomicilio.Text = dsProveedor.Tables("tblProveedores").Rows(0)(2).ToString
            tbColonia.Text = dsProveedor.Tables("tblProveedores").Rows(0)(3).ToString
            tbMunicipio.Text = dsProveedor.Tables("tblProveedores").Rows(0)(4).ToString
            tbEstado.Text = dsProveedor.Tables("tblProveedores").Rows(0)(5).ToString
            tbTelefono1.Text = dsProveedor.Tables("tblProveedores").Rows(0)(6).ToString
            tbTelefono2.Text = dsProveedor.Tables("tblProveedores").Rows(0)(7).ToString
            tbTelefono3.Text = dsProveedor.Tables("tblProveedores").Rows(0)(8).ToString
            tbEmail.Text = dsProveedor.Tables("tblProveedores").Rows(0)(9).ToString
            tbRFC.Text = dsProveedor.Tables("tblProveedores").Rows(0)(10).ToString
            tbNombreContacto.Text = dsProveedor.Tables("tblProveedores").Rows(0)(11).ToString
            tbObservaciones.Text = dsProveedor.Tables("tblProveedores").Rows(0)(12).ToString
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
        strQuery = "UPDATE [dbo].[tblCatProveedores]" & _
        "SET [strNombreProveedor] = '" & tbNombreProveedor.Text & "',[strDomicilio] = '" & tbDomicilio.Text & "'" & _
      ",[strColonia] = '" & tbColonia.Text & "'" & _
      ",[strMunicipio] = '" & tbMunicipio.Text & "',[strEstado] = '" & tbEstado.Text & "'" & _
      ",[strTelefono1] = '" & tbTelefono1.Text & "',[strTelefono2] = '" & tbTelefono2.Text & "'" & _
      ",[strTelefono3] = '" & tbTelefono3.Text & "',[strCorreoElectronico] = '" & tbEmail.Text & "'" & _
      ",[strRFC] = '" & tbRFC.Text & "',[strNombreContacto] = '" & tbNombreContacto.Text & "'" & _
      ",[strObservaciones] = '" & tbObservaciones.Text & "' WHERE [IDProveedor] = " & tbID.Text & ""
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")
        chkbEditar.Checked = False
        LimpiarTXB()

        Dim strConsulta As String
        strConsulta = "SELECT [IDProveedor] as [ID],[strNombreProveedor] as [Nombre de Proveedor],[strDomicilio] as [Domicilio],[strColonia] as [Colonia],[strMunicipio] as [Municipio],[strEstado] as [Estado],[strTelefono1] as [Teléfono]," &
      "[strTelefono2] as [Teléfono 2],[strTelefono3] as [Teléfono 2],[strCorreoElectronico]as [E-mail],[strRFC] as [RFC],[strNombreContacto] as [Nombre de contacto],[strObservaciones] as [Observaciones] FROM [dbQuart].[dbo].[tblCatProveedores]"
        PrepararDGV(dgvListaProveedores)

        LlenarDataGrid(strConsulta, dgvListaProveedores)

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

    Private Sub ListaProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantListadoProveedores = False
    End Sub

    Private Sub dgvListaProveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaProveedores.CellContentClick

    End Sub
End Class