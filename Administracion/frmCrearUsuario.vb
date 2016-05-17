Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class frmCrearUsuario
    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        Dim strQuery As String
        Dim strCount As String
        Dim valida As Integer
        strCount = ""
        strQuery = "INSERT INTO [dbQuart].[dbo].[tblUsuarios]([strIdUsuario],[strPassword],[intVarControlUsuario],[strNombreUsuario],[strPuesto])" &
        "VALUES('" & tbLogin.Text & "','" & tbPassword.Text & "', 1, '" & tbNombreUsuario.Text & "','" & tbPuesto.Text & "')"
        valida = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strQuery, "")

        If valida > 1 Then
            MsgBox("El usuario ha sido ingresado correctamente.")
            tbLogin.Text = ""
            tbNombreUsuario.Text = ""
            tbPassword.Text = ""
            tbPuesto.Text = ""
        End If

        If valida = 0 Then
            MsgBox("HA habido error al momento de ingresar el usuario.")
            tbLogin.Text = ""
            tbNombreUsuario.Text = ""
            tbPassword.Text = ""
            tbPuesto.Text = ""
        End If

    End Sub

    Private Sub frmCrearUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantCrearUsuarios = False
    End Sub

    Private Sub tbLogin_TextChanged(sender As Object, e As EventArgs) Handles tbLogin.TextChanged
        tbLogin.Focus()
    End Sub
End Class