Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class frmUsuarios
    Dim Status As Integer
    Private Sub LimpiarTBX()
        tbLogin.Text = ""
        tbNombreUsuario.Text = ""
        tbPassword.Text = ""
        tbPuesto.Text = ""
    End Sub

    Private Sub dgvListaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaUsuarios.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then

            Dim intUsuarioEdit As Integer
            intUsuarioEdit = dgvListaUsuarios.Rows(intRenglon).Cells(0).Value

            Dim dsUsuario As New DataSet
            Dim strQuery As String
            strQuery = "SELECT [intIDUsuario] AS [ID], [strIdUsuario] AS [Login],[intVarControlUsuario] AS [Usuario activo]," &
            "[strNombreUsuario] As [Nombre de usuario], [strPuesto] AS [Puesto], [strPassword] AS [Contraseña] FROM [dbQuart].[dbo].[tblUsuarios] WHERE [intIDUsuario] = " & intUsuarioEdit
            dsUsuario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "tblUsuarios", "")

            LimpiarTBX()
            tbID.Text = dsUsuario.Tables("tblUsuarios").Rows(0)(0).ToString
            tbLogin.Text = dsUsuario.Tables("tblUsuarios").Rows(0)(1).ToString
            If dsUsuario.Tables("tblUsuarios").Rows(0)(2).ToString = 1 Then
                chkActivado.Checked = True
            End If
            If dsUsuario.Tables("tblUsuarios").Rows(0)(2).ToString = 0 Then
                chkActivado.Checked = False
            End If
            tbPassword.Text = dsUsuario.Tables("tblUsuarios").Rows(0)(5).ToString
            tbNombreUsuario.Text = dsUsuario.Tables("tblUsuarios").Rows(0)(3).ToString
            tbPuesto.Text = dsUsuario.Tables("tblUsuarios").Rows(0)(4).ToString

        End If
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarTBX()

        Dim dsUsuario As New DataSet
        Dim strConsulta As String
        strConsulta = "SELECT [intIDUsuario] AS [ID], [strIdUsuario] AS [Login], [intVarControlUsuario] AS [Usuario activo]," &
        "[strNombreUsuario] As [Nombre de usuario], [strPuesto] AS [Puesto] FROM [dbQuart].[dbo].[tblUsuarios]"
        dsUsuario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "tblUsuarios", "")

        PrepararDGV(dgvListaUsuarios)

        LlenarDataGrid(strConsulta, dgvListaUsuarios)
        tbLogin.Enabled = False
        tbNombreUsuario.Enabled = False
        tbPassword.Enabled = False
        tbPuesto.Enabled = False
        btnEditar.Enabled = False
        chkActivado.Enabled = False

    End Sub

    Private Sub frmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantListadoUsuarios = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tbLogin.Text = "" Or tbNombreUsuario.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Falta algún campo requerido para modificar el usuario.")
        Else
            Dim strQuery As String
            strQuery = "Update [dbQuart].[dbo].[tblUsuarios] Set [strIdUsuario] = '" & tbLogin.Text & "',[strPassword] ='" & tbPassword.Text & "'" &
          ",[intVarControlUsuario] = " & Status & ",[strPuesto] = '" & tbPuesto.Text & "'" &
            "WHERE [intIDUsuario] = '" & tbID.Text & "'"
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")

            chkEditar.Checked = False
            LimpiarTBX()

            Dim dsUsuario As New DataSet
            Dim strConsulta As String
            strConsulta = "SELECT [intIDUsuario] AS [ID], [strIdUsuario] AS [Login],[intVarControlUsuario] AS [Usuario activo]," &
            "[strNombreUsuario] As [Nombre de usuario], [strPuesto] AS [Puesto] FROM [dbQuart].[dbo].[tblUsuarios]"
            dsUsuario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "tblUsuarios", "")

            PrepararDGV(dgvListaUsuarios)

            LlenarDataGrid(strConsulta, dgvListaUsuarios)
        End If
    End Sub

    Private Sub btnSwap_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSwap.MouseClick
        If tbPassword.UseSystemPasswordChar = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkEditar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEditar.CheckedChanged
        If chkEditar.Checked = True Then
            tbLogin.Enabled = True
            tbPassword.Enabled = True
            tbNombreUsuario.Enabled = True
            tbPuesto.Enabled = True
            btnEditar.Enabled = True
            dgvListaUsuarios.Enabled = False
            chkActivado.Enabled = True
        Else
            tbLogin.Enabled = False
            tbPassword.Enabled = False
            tbNombreUsuario.Enabled = False
            tbPuesto.Enabled = False
            btnEditar.Enabled = False
            dgvListaUsuarios.Enabled = True
            chkActivado.Enabled = False
        End If
    End Sub

    Private Sub chkActivado_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivado.CheckedChanged
        If chkActivado.Checked = True Then
            Status = 1
        Else
            Status = 0
        End If
    End Sub
End Class