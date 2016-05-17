Imports QuartOK.ProcedimientosGenerales

Public Class frmRevisionMerma
    Dim intRevision As Integer
    Dim intProducto As Integer
    Dim decCantidad As Decimal
    Dim intUM As Integer

    Private Sub frmRevisionMerma_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantRevisaMerma = False
    End Sub

    Private Sub frmRevisionMerma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub
    Private Sub Iniciar()
        lblRazon.Text = ""
        tbComentarios.Text = ""
        LimpiarDataGrid(dgvMermas)
        PrepararDGV(dgvMermas)
        CargarGridMermas()
    End Sub

    Private Sub CargarGridMermas()
        Dim strqry As String = "SELECT idttyMerma as Id, decCantidad as cantidad, strDescripcionProducto as Producto,strUnidadMedida as [U/M],dtFechaEvento as Fecha_Evento,UsuarioRegistra as Usuario " &
            " FROM vstListadoMermas   where intVarControl = 1 and intStatusMerma = 0 order by dtFechaEvento desc"
        LlenarDataGrid(strqry, dgvMermas)
    End Sub

    Private Sub dgvMermas_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMermas.CellClick
        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            intRevision = dgvMermas.Rows(intRenglon).Cells(0).Value
        End If
        If intRevision > 0 Then
            Dim strqry As String = ""
            Dim dsComentario As New DataSet
            strqry = "Select strRazon from vstListadoMermas where idttyMerma = " & intRevision
            dsComentario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al localizar Cancelacion")
            lblRazon.Text = dsComentario.Tables(0).Rows(0)(0).ToString

        End If

    End Sub

    Private Sub btnAsumirPerdida_Click(sender As System.Object, e As System.EventArgs) Handles btnAsumirPerdida.Click
        AfectarInventario()
        Actualiza(2)
    End Sub

    Private Sub btnReportarCargo_Click(sender As System.Object, e As System.EventArgs) Handles btnReportarCargo.Click
        AfectarInventario()
        Actualiza(1)
    End Sub

    Private Sub Actualiza(ByVal Valor As Integer)
        Dim strqry As String = "UPDATE tblMermas SET intStatusMerma = " & Valor & ",intUsrEvaluaMerma = " & intUsuario & ",dtEvaluacionMerma = GETDATE(), " &
            "strComentariosEvaluacion = '" & tbComentarios.Text & "' WHERE idttyMerma = " & intRevision
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se actualizo el registro")
        Iniciar()
    End Sub

    Private Sub AfectarInventario()
        Dim strqry As String = "Select intProducto,intUM,decCantidad from tblMermas where idttyMerma = " & intRevision
        Dim dsDatos As DataSet
        dsDatos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Datos", "No se obtuvieron datos")
        intProducto = dsDatos.Tables(0).Rows(0)(0)
        intUM = dsDatos.Tables(0).Rows(0)(1)
        decCantidad = dsDatos.Tables(0).Rows(0)(2)
        'hacemos el calculo del inventario
        strqry = "SELECT intCantidad from tblInventario where IdProducto = " & intProducto &
                    " and idUnidadMedida = " & intUM & "And intVarControlInventario = 1"            'evaluar la unidad de medida   dgvProductos.Rows(i).Cells(2).Value
        Dim dsExiste As New DataSet
        dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "")
        If dsExiste.Tables(0).Rows.Count = 0 Then
            'se debe insertar la venta"
            Dim decCantAfectar As Decimal
            decCantAfectar = decCantidad * -1
            strqry = "INSERT INTO tblInventario (IdProducto,idUnidadMedida,intCantidad) VALUES (" &
                        intProducto & ", " & intUM &
                        ", " & decCantAfectar & ") "           'la afectacionde la unidad de medida debe de verificarse con su ID de Unidad de medida  dgvProductos.Rows(i).Cells(2).Value
            Dim j As Long = 0
            j = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al realizar ingreso de ajuste de inventario.")

        Else
            'se debe actualizar el valor de cantidad, restando...
            strqry = "UPDATE tblInventario SET intCantidad = " & Decimal.Parse(dsExiste.Tables(0).Rows(0)(0)) - decCantidad &
                        " where IdProducto = " & intProducto &
                    " and idUnidadMedida = " & intUM & " And intVarControlInventario = 1"                   'evaluar la unidad de medida: dgvProductos.Rows(i).Cells(2).Value
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

End Class