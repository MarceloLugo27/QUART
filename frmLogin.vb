Imports QuartOK.ProcedimientosGenerales

Public Class frmLogin

    'que servidor usare?????
    '1 el de Marcelo
    '2 el de papá
    '3 el de Ulises

    Public Shared intServer As Integer = 1

    Dim loginExitoso As Boolean
    Dim intentos As Integer = 0

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación.
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub SeleccionarServer()
        intServer = 3
        VerificarServer(intServer)
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        intentos = intentos + 1
        If intentos < 4 Then
            Me.Cursor = Cursors.WaitCursor
            EvaluarUsuario()
            Me.Cursor = Cursors.Arrow
        Else
            MessageBox.Show("Varios intentos de acceso fallidos. Verifique datos de usuario y contraseña con el administrador del sistema", "Saliendo del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'frmAbout.HabiltarReloj = True
            'frmAbout.Show()
            Me.Hide()
            End
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        frmAbout.HabiltarReloj = True
        frmAbout.Show()
        Me.Hide()
        ' End
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SeleccionarServer()
        ' MessageBox.Show(strNombreServer)

        ttip.SetToolTip(LogoPictureBox, strNombreServer)
        If intServer < 3 Then
            UsernameTextBox.Text = "1"
            PasswordTextBox.Text = "1"
            OK.Focus()
        End If
    End Sub

    Private Sub EvaluarUsuario()
        loginExitoso = False
        Dim dsTemp As New System.Data.DataSet
        Dim strqry As String = "SELECT intIDUsuario, strNombreUsuario, strPassword FROM tblUsuarios " &
                                " WHERE strIdUsuario = '" & UsernameTextBox.Text & "' AND " &
                                " intVarControlUsuario = 1 "
        Dim strTabla As String = "Usuario"
        dsTemp = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, strTabla, "")
        If dsTemp IsNot Nothing Then
            If dsTemp.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Verifique el usuario", "Usuario no localizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Focus()
            Else
                If dsTemp.Tables(0).Rows(0)(2).ToString <> PasswordTextBox.Text Then
                    MessageBox.Show("Verifique contraseña", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    PasswordTextBox.Text = ""
                    PasswordTextBox.Focus()
                Else
                    intUsuario = Integer.Parse(dsTemp.Tables(0).Rows(0)(0).ToString)
                    strNombreUsuario = dsTemp.Tables(0).Rows(0)(1).ToString
                    ObtenerDatosEquipo()
                    GrabarAccion(1, 0)
                    Dim UsuarioActivo As Boolean
                    UsuarioActivo = VerificarPermisos(intUsuario)
                    If UsuarioActivo = True Then
                        MDIPrincipal.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("El usuario que intenta utilizar no está autorizado." & vbCr & "Reportelo al administrador del sistema.", "Usuario no autorizado.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End
                    End If
                End If
            End If
        Else
            MessageBox.Show("Problemas de comunicacion con el servidor" & vbCr & "Intente nuevamente.",
                            "Error comunicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ObtenerDatosEquipo()
        strIP = funObtenerIP()
        strComputadora = funObtenerHost()
    End Sub

    Private Sub UsernameLabel_MouseHover(sender As System.Object, e As System.EventArgs) Handles UsernameLabel.MouseHover
        Me.Size = New System.Drawing.Size(560, 250)
        'UsernameTextBox.Text = "1"
        'PasswordTextBox.Text = "1"
        'TextBox1.Text = "2"
        'OK.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        VerificarServer(TextBox1.Text)
        Me.Size = New System.Drawing.Size(480, 250)
    End Sub

    Private Sub PasswordLabel_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PasswordLabel.MouseDoubleClick
        UsernameTextBox.Text = "1"
        PasswordTextBox.Text = "1"
        TextBox1.Text = "2"
        OK_Click(sender:="", e:=e)
    End Sub

    Function VerificarPermisos(ByRef intUsuario As Integer) As Boolean
        Dim Permiso As Boolean
        Dim strqry As String = "SELECT top 1 intValor from vstPermisosUsuarios where idPermiso = 1 and idUsuario = " & intUsuario &
            " order by idttyPermiso desc"
        Dim dsPermisos As New DataSet
        dsPermisos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Acceso", "")
        If dsPermisos.Tables(0).Rows.Count > 0 Then
            If dsPermisos.Tables(0).Rows(0)(0) = 1 Then
                Permiso = True
            Else
                Permiso = False
            End If
        Else
            Permiso = False
        End If

        If Permiso = True Then
            'verifica los accesos al sistema
        End If

        Return Permiso
    End Function

End Class