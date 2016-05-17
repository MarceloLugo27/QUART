Imports QuartOK.ProcedimientosGenerales
Imports QuartOK.MDIPrincipal

Public Class frmUnidadesdeMedida

    Private Sub frmUnidadesdeMedida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'VerificarServer(2)

        CargarUnidades()
    End Sub

    Private Sub CargarUnidades()
        Me.Height = 347
        Me.Width = 347
        Dim strqry As String = "SELECT IDUnidadMedida as ID , strUnidadMedida as [Unidad de Medida] " &
            " FROM tblCatUnidadMedida order by ID"
        PrepararDGV(dgvUnidadesMedida)

        LlenarDataGrid(strqry, dgvUnidadesMedida)
        ' dgvUnidadesMedida.EditingControl.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub btnAgregarUM_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarUM.Click
        Me.Height = 547
        Me.Width = 347
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim strqry As String = "INSERT INTO tblCatUnidadMedida (strUnidadMedida) VALUES ('" &
            TextBox1.Text & "')"
        Dim nuevo As Long
        nuevo = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se pudo agregar la Unidad de medida")
        If nuevo = 0 Then
            MessageBox.Show("No pudo ingresrase la nueva unidad de medida. Intente nuevamente." & vbCr & "En caso de persistir el problema, reporte al administrador del sistema.",
                            "Problemas para ingresar nueva Unidad de Medida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Unidad de medida " & TextBox1.Text & " ingresada correctamente.",
                "Unidad de Medida nueva.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GrabarAccion(70, nuevo)
            CargarUnidades()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "'"c Then
            e.Handled = True
            SendKeys.Send("´ ")
        End If
    End Sub

    Private Sub frmUnidadesdeMedida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MDIPrincipal.PantUnidadesMedida = False
    End Sub
End Class