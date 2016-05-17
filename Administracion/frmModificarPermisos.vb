Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class frmModificarPermisos
    Dim intUsuarioModificar As Integer = 0

    Private Sub frmModificarPermisos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Private Sub Iniciar()
        ' VerificarServer(2)
        LimpiarDataGrid(dgvPermisos)
        dgvPermisos.Enabled = False
        LimpiarCombo(cbUsuarios)
        Dim strqry As String = "select strNombreUsuario, intIDUsuario  FROM tblUsuarios where intVarControlUsuario = 1 order by strNombreUsuario"
        LlenarCombo(strqry, cbUsuarios, "intIdUsuario", "strNombreUsuario")
        cbUsuarios.Text = ""
        intUsuarioModificar = 0

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

    Private Sub btnObtenerListaPermisos_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerListaPermisos.Click
        If intUsuarioModificar > 0 Then
            LimpiarDataGrid(dgvPermisos)
            CargarListadoTotalPermisos()
            ObtenerPermisosActivos()
        End If
    End Sub

    Private Sub CargarListadoTotalPermisos()
        PrepararDGV(dgvPermisos)
        Dim strqry As String = "Select idPermiso as ID, strDescripcionPermiso as Descripción from tblCatPermisosSistema where intVarControl = 1  order by id "
        LlenarDataGrid(strqry, dgvPermisos)
        dgvPermisos.Columns.Add("Permiso", "Permiso")
        dgvPermisos.Enabled = True
    End Sub

    Private Sub ObtenerPermisosActivos()
        Dim renglones As Integer = dgvPermisos.RowCount
        Dim dsPermisos As New DataSet
        For i As Integer = 0 To renglones - 1 Step 1
            Dim intPermiso As Integer = dgvPermisos.Rows(i).Cells(0).Value

            Dim strqry As String = "select intValor FROM tblPermisosUsuarios " &
                " where intVarControl = 1 and idUsuario =  " & intUsuarioModificar & " and idPermiso = " & intPermiso
            dsPermisos.Tables.Clear()
            dsPermisos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Permisos", "")
            If dsPermisos.Tables(0).Rows.Count = 0 Then
                dgvPermisos.Rows(i).Cells(2).Value = "NO HABILITADO"
                dgvPermisos.Item(2, i).Style.BackColor = Color.Red
            Else
                If dsPermisos.Tables(0).Rows(0)(0) = 1 Then
                    dgvPermisos.Rows(i).Cells(2).Value = "HABILITADO"
                    dgvPermisos.Item(2, i).Style.BackColor = Color.Green
                Else
                    dgvPermisos.Rows(i).Cells(2).Value = "NO HABILITADO"
                    dgvPermisos.Item(2, i).Style.BackColor = Color.Red
                End If
            End If
        Next
    End Sub

    Private Sub cbUsuarios_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbUsuarios.SelectedValueChanged
        If cbUsuarios.DataSource IsNot Nothing Then
            intUsuarioModificar = DirectCast(cbUsuarios.SelectedItem, DataRowView).Item("intIdUsuario")
        End If
    End Sub

    Private Sub dgvPermisos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPermisos.CellClick

        Dim intColumna As Integer = e.ColumnIndex
        If intColumna = 2 Then
            Dim intRenglon As Integer = e.RowIndex
            If intRenglon >= 0 Then
                If dgvPermisos.Item(2, intRenglon).Style.BackColor = Color.Red Then
                    dgvPermisos.Rows(intRenglon).Cells(2).Value = "HABILITADO"
                    dgvPermisos.Item(2, intRenglon).Style.BackColor = Color.Green
                Else
                    dgvPermisos.Rows(intRenglon).Cells(2).Value = "NO HABILITADO"
                    dgvPermisos.Item(2, intRenglon).Style.BackColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub btnGrabarPermisos_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarPermisos.Click
        Me.Enabled = False
        CancelarPermisosActuales()
        GrabarPermisosNuevos()
        Iniciar()
        Me.Enabled = True
    End Sub

    Private Sub CancelarPermisosActuales()
        Dim strqry As String = "UPDATE [tblPermisosUsuarios] SET [intValor] = 0, [intVarControl] = 0, [dtFechaRetiro] = GETDATE(), [intUsuarioRetiro] =  " & intUsuario &
            " WHERE [idUsuario] = " & intUsuarioModificar & " AND intVarControl = 1 "
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
    End Sub

    Private Sub GrabarPermisosNuevos()
        Dim renglones As Integer = dgvPermisos.RowCount
        For i As Integer = 0 To renglones - 1 Step 1
            If dgvPermisos.Rows(i).Cells(2).Value = "HABILITADO" Then
                Dim strqry As String = "INSERT INTO tblPermisosUsuarios (idUsuario,idpermiso,intValor,intUsuarioOtorgo,intVarControl) VALUES (" &
                    intUsuarioModificar & ", " & dgvPermisos.Rows(i).Cells(0).Value & ", 1, " & intUsuario & ", 1) "
                funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
            End If
        Next
    End Sub

    Private Sub frmModificarPermisos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantModificarPermisos = False
    End Sub
End Class