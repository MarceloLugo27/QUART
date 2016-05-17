Imports QuartOK.ProcedimientosGenerales

Public Class frmRevisarCancelaciones

    Dim intDocumento As Integer

    Private Sub frmRevisarCancelaciones_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantRevisarCancelaciones = False
    End Sub

    Private Sub frmRevisarCancelaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbDocumento.Text = "COMPRAS"
        Iniciar()
    End Sub

    Private Sub Iniciar()

        intDocumento = 0
        dgvDocumentos.DataSource = Nothing
        dgvDocumentos.Rows.Clear()
        dgvDocumentos.Columns.Clear()
        dgvPartidas.DataSource = Nothing
        dgvPartidas.Rows.Clear()
        dgvPartidas.Columns.Clear()
        lblMotivo.Text = ""
        tbComentarios.Text = ""
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Iniciar()
        ActualizaDGVDocumentos()
    End Sub

    Private Sub ActualizaDGVDocumentos()
        PrepararDGV(dgvDocumentos)
        Dim strqry As String = ""
        If cbDocumento.Text = "COMPRAS" Then
            strqry = "SELECT ID, [Num Compra], Proveedor, [Fecha Compra], [Usuario Cancelo], [Fecha Cancelacion] " &
                " from vstComprasCanceladas where intUsuarioRevisaCancelacion = 0 order by [Fecha Cancelacion] desc"
        Else
            strqry = "SELECT TOP 1000 Id,[Num Venta],Cliente,[Fecha Venta],[Usuario Cancelo],[Fecha Cancelacion] " &
                " FROM vstVentasCanceladas where intUsuarioRevisaCancelacion = 0 order by [Fecha Cancelacion] desc"
        End If
        LlenarDataGrid(strqry, dgvDocumentos)
    End Sub

    Private Sub dgvDocumentos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentos.CellClick

        Dim intRenglon As Integer
        intRenglon = e.RowIndex
        If intRenglon >= 0 Then
            PrepararDGV(dgvPartidas)
            intDocumento = dgvDocumentos.Rows(intRenglon).Cells(0).Value
        End If
        If intDocumento > 0 Then
            Dim strqry As String = ""
            Dim dsComentario As New DataSet
            strqry = "Select strMotivoCancelacion from tblCancelaciones where idCancelacion = " & intDocumento
            dsComentario = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Tabla", "Error al localizar Cancelacion")
            lblMotivo.Text = dsComentario.Tables(0).Rows(0)(0).ToString
            If cbDocumento.Text = "COMPRAS" Then
                strqry = "SELECT intPartida as Partida,CantidadComprada as Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto,PrecioUnitarioCompra as Precio " &
                     " FROM vstPartidasCompradasCanceladas where idCancelacion = " & intDocumento & " order by intPartida "

            Else
                strqry = "SELECT intPartida as Partida,Cantidad,strUnidadMedida as [U/M],strDescripcionProducto as Producto, " &
                    " PrecioUnitario as Precio FROM vstTransaccionesVentaCanceladas where idCancelacion = " & intDocumento & " order by intPartida "
            End If
            LlenarDataGrid(strqry, dgvPartidas)
        End If

    End Sub

    Private Sub tbComentarios_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbComentarios.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btnVoBo_Click(sender As System.Object, e As System.EventArgs) Handles btnVoBo.Click
        Dim strqry As String = "UPDATE tblCancelaciones SET intUsuarioRevisaCancelacion = " & intUsuario & ", [dtfechaRevision] = GETDATE(),  [strComentariosRevision] = '" & tbComentarios.Text & "'" &
        " WHERE idCancelacion = " & intDocumento & ""
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se actualizo comentario de revision")
        GrabarAccion(24, intDocumento)
        Iniciar()
        ActualizaDGVDocumentos()
    End Sub

    Private Sub cbDocumento_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbDocumento.SelectedValueChanged
        'Iniciar()
        'ActualizaDGVDocumentos()
    End Sub
End Class