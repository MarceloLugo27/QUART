Imports QuartOK.ProcedimientosGenerales

Public Class frmReporteMerma

    Dim intProducto As Integer
    Dim intUM As Integer
    Dim dtFechaEvento As Date
    Dim decCantidad As Decimal

#Region "Iniciar Form"

    Private Sub frmReporteMerma_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MDIPrincipal.PantReporteMerma = False
    End Sub
    Private Sub frmReporteMerma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub
    Private Sub Iniciar()
        gbProducto.Enabled = True
        tbProducto.Text = ""
        LimpiarCombo(cbProducto)
        lblUM.Text = ""
        tbCantidad.Text = "0"
        mcFechaEvento.MaxDate = Today

        gbReporte.Enabled = False
        tbRazon.Text = ""
        mcFechaEvento.SelectionRange.End = Today

        btnReportar.Enabled = False
        decCantidad = Decimal.Parse(tbCantidad.Text)
        tbProducto.Focus()
    End Sub

#End Region

#Region "Registro de Merma"

    Private Sub tbRazon_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbRazon.TextChanged
        lblCuenta.Text = Len(tbRazon.Text).ToString
        If Len(tbRazon.Text) > 29 Then
            btnReportar.Enabled = True
            lblCuenta.Font = New Font(Label1.Font, FontStyle.Bold)
        Else
            btnReportar.Enabled = False
            lblCuenta.Font = New Font(Label1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub mcFechaEvento_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaEvento.DateChanged
        dtFechaEvento = mcFechaEvento.SelectionRange.End
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Iniciar()
    End Sub

    Private Sub btnReportar_Click(sender As System.Object, e As System.EventArgs) Handles btnReportar.Click
        Dim strqry As String = "INSERT INTO tblMermas (intProducto,intUM,decCantidad,strRazon,dtFechaEvento,intUsrRegistraMerma) VALUES (" &
            intProducto & ", " & intUM & ", " & tbCantidad.Text & ", '" & tbRazon.Text & "', '" & Format(dtFechaEvento.Date, "yyyy-MM-dd") & "', " & intUsuario & ")"
        Dim intMerma As Long = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se registro merma")
        If intMerma = 0 Then
            MsgBox("No se pudo registrar merma, intente nuevamente")
        Else
            MsgBox("Merma registrada correctamente")
            Iniciar()
        End If
    End Sub

#End Region

#Region "producto"

    Private Sub tbProducto_TextChanged(sender As Object, e As System.EventArgs) Handles tbProducto.TextChanged
        Dim intLargo As Integer = Len(tbProducto.Text)
        If intLargo >= 3 Then
            cbProducto.DroppedDown = False
            Dim strqry As String = "SELECT  IDProducto,strDescripcionProducto + ' -- ' + strUnidadMedida as Producto FROM vstListaPrecios  where intTipoProducto >= 2 and strDescripcionProducto like '%" & tbProducto.Text & "%'  order by strDescripcionProducto"
            LlenarCombo(strqry, cbProducto, "IDProducto", "Producto")
            cbProducto.DroppedDown = True
        End If
        If intLargo = 0 Then
            cbProducto.DroppedDown = False
            cbProducto.DataSource = Nothing
            cbProducto.Items.Clear()
        End If
        Windows.Forms.Cursor.Current = Cursors.Arrow
    End Sub

    Private Sub cbProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        If cbProducto.DataSource IsNot Nothing Then
            intProducto = DirectCast(cbProducto.SelectedItem, DataRowView).Item("IDProducto")
            cbProducto.DroppedDown = False
            'CargarComboUnidadMedida()
            Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from vstListaPrecios  where intVarControlProductos = 1 and IDProducto = " & intProducto & " Order by strUnidadMedida "
            Dim dsUM As DataSet
            dsUM = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "UM", "Error al cargar Unidad de Medida")
            lblUM.Text = dsUM.Tables(0).Rows(0)(1).ToString
            intUM = dsUM.Tables(0).Rows(0)(0)
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As System.Object, e As System.EventArgs) Handles btnContinuar.Click
        decCantidad = Decimal.Parse(tbCantidad.Text)
        If intProducto = 0 Then
            MsgBox("Debe seleccionar un producto")
            Exit Sub
        ElseIf decCantidad = 0 Then
            MsgBox("Debe ingresar cantidad de producto")
            Exit Sub
        End If

        gbProducto.Enabled = False
        gbReporte.Enabled = True
        tbRazon.Text = ""
        tbRazon.Focus()
    End Sub

    Private Sub tbCantidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles tbCantidad.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, tbCantidad.Text & CChar(eventArgs.KeyChar))
    End Sub

#End Region

End Class