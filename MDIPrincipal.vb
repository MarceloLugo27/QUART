Imports System.Windows.Forms
Imports QuartOK.ProcedimientosGenerales

Public Class MDIPrincipal

    Private m_ChildFormNumber As Integer

    Public PantNuevaCotizacion As Boolean = False
    Public PantConsultaCotizaciones As Boolean = False
    Public PantListadoIngresos As Boolean = False
    Public PantIngresoAlmacen As Boolean = False
    Public PantListadoEntredaAlmacen As Boolean = False
    Public PantVentaXML As Boolean = False
    Public PantSalidasAlmacen As Boolean = False
    Public PantListadoSalidasAlmacen As Boolean = False
    Public PantListadoClientes As Boolean = False
    Public PantAltaClientes As Boolean = False
    Public PantListadoProveedores As Boolean = False
    Public PantAltaProveedores As Boolean = False
    Public PantVentaMostrador As Boolean = False
    Public PantProductoProveedor As Boolean = False
    Public PantAltaProductos As Boolean = False
    Public PantListaVentas As Boolean = False
    Public PantListaSalidas As Boolean = False
    Public PantCancelarDocumento As Boolean = False
    Public PantInventario As Boolean = False
    Public PantRevisarCancelaciones As Boolean = False
    Public PantListaCancelaciones As Boolean = False
    Public PantAjusteInventario As Boolean = False
    Public PantReporteMerma As Boolean = False
    Public PantRevisaMerma As Boolean = False
    Public PantListadoMerma As Boolean = False
    Public PantListadoProductos As Boolean = False
    Public PantListadoUsuarios As Boolean = False
    Public PantCrearUsuarios As Boolean = False
    Public PantUnidadesMedida As Boolean = False
    Public PantModificarPermisos As Boolean = False
    Public PantAñadirEquivalencias As Boolean = False
    Public PantEdicionProductos As Boolean = False
    Public PantValoresInventario As Boolean = False
    Public PantReporteComprasProducto As Boolean = False
    Public PantReporteVentaProducto As Boolean = False

    Dim pListadoProductos As New Form
    Dim pNuevaCotizacion As New Form
    Dim pConsultaCotizaciones As New Form
    Dim pListadoIngresos As New Form
    Dim pIngresoAlmacen As New Form
    Dim pListadoIngresoAlmacen As New Form
    Dim pVentaXML As New Form
    Dim pSalidasAlmacen As New Form
    Dim pListadoSalidasAlmacen As New Form
    Dim pListadoClientes As New Form
    Dim pAltaClientes As New Form
    Dim pListadoProveedores As New Form
    Dim pAltaProveedores As New Form
    Dim pVentaMostrador As New Form
    Dim pListaVentas As New Form
    Dim pListaSalidas As New Form
    Dim pAltaProductos As New Form
    Dim pCancelarDocumento As New Form
    Dim pInventario As New Form
    Dim pRevisarCancelaciones As New Form
    Dim pListaCancelaciones As New Form
    Dim pAjusteInventario As New Form
    Dim pReporteMerma As New Form
    Dim pRevisaMerma As New Form
    Dim pListadoMerma As New Form
    Dim pListaUsuarios As New Form
    Dim pCrearUsuarios As New Form
    Dim pUnidadesMedida As New Form
    Dim pModificarPermisos As New Form
    Dim pAñadirEquivalencias As New Form
    Dim pEdicionProductos As New Form
    Dim pValoresInventario As New Form
    Dim pReporteCompraProductos As New Form
    Dim pReporteVentaproductos As New Form


#Region "Variables de Permisos"

    Public PermisoEditarClientes As Boolean = False
    Public PermisoEditarProveedores As Boolean = False
    Public PermisoEditarProducto As Boolean = False
    Public PermisoExportarExcel As Boolean = False
    Public PermisoReimpresion As Boolean = False

    'Dim p_PermisoAcceso As Boolean = False              '1
    'Dim p_Cotizar As Boolean = False                    '2
    'Dim p_AltaCotizacion As Boolean = False             '3
    'Dim p_ListadoCotizacion As Boolean = False          '4
    'Dim p_Compras As Boolean = False
    'Dim p_AltaCompras As Boolean = False
    'Dim p_ListadoCompras As Boolean = False
    'Dim p_Ventas As Boolean = False
    'Dim p_XML As Boolean = False
    'Dim p_Mostrador As Boolean = False
    'Dim p_ListadoVentas As Boolean = False
    'Dim p_SalidaAlmacen As Boolean = False
    'Dim p_SalidasPendientes As Boolean = False
    'Dim p_ListadoSalida As Boolean = False
    'Dim p_Cancelaciones As Boolean = False
    'Dim p_CancelaDocumento As Boolean = False
    'Dim p_RevisaCancelacion As Boolean = False
    'Dim p_ListadoCancelaciones As Boolean = False
    'Dim p_ListaPrecios As Boolean = False
    'Dim p_VerListaPrecios As Boolean = False
    'Dim p_ModificarPrecios As Boolean = False
    'Dim p_Inventarios As Boolean = False
    'Dim p_ListaProductos As Boolean = False
    'Dim p_VerInventario As Boolean = False
    'Dim p_AjusteInventario As Boolean = False
    'Dim p_Mermas As Boolean = False
    'Dim p_RegistroMermas As Boolean = False
    'Dim p_RevisionMermas As Boolean = False
    'Dim p_ListaMermas As Boolean = False
    'Dim p_catalogos As Boolean = False
    'Dim p_CatalogoClientes As Boolean = False
    'Dim p_ListaClientes As Boolean = False
    'Dim p_AltaClientes As Boolean = False
    'Dim p_CatalogoProveedores As Boolean = False
    'Dim p_ListaProveedores As Boolean = False
    'Dim p_AltaProveedores As Boolean = False
    'Dim p_CatalogoProductos As Boolean = False
    'Dim p_AltaProductos As Boolean = False
    'Dim p_edicionProductos As Boolean = False
    'Dim p_UnidadesdeMedida As Boolean = False
    'Dim p_ProductoProveedor As Boolean = False
    'Dim p_EquivalenciasProducto As Boolean = False
    'Dim p_Administracion As Boolean = False
    'Dim p_Altausuarios As Boolean = False
    'Dim p_Permisos As Boolean = False
    'Dim p_ModificarContraseña As Boolean = False
    'Dim p_BitacoradeEventos As Boolean = False
    'Dim p_ExportarExcel As Boolean = False
#End Region

#Region "Carga del formato"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub MDIPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Control de Inventario y Ventas / " & ProcedimientosGenerales.strNombreUsuario

        NiegaTodo()
        verificarPermisos(intUsuario)

        '    If PermSalidaAlmacen = True Then
        '        tmrOrdenesSalida.Enabled = True
        '        tmrOrdenesSalida.Interval = 10000
        '    Else
        '        tmrOrdenesSalida.Enabled = False
        '    End If
    End Sub

    Private Sub VerificarPermisos(ByVal intUser)
        Dim strqry As String =
                "SELECT idPermiso, intValor from vstPermisosUsuarios where intVarControl = 1 and idUsuario = " & intUser
        Dim dsPermisos As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Permisos", "No pudieron obtenerse los permisos del usuario")
        If dsPermisos.Tables(0).Rows.Count > 0 Then
            Dim renglones As Integer = dsPermisos.Tables(0).Rows.Count
            For i As Integer = 0 To renglones - 1
                Dim j As Integer = dsPermisos.Tables(0).Rows(i)(0)
                Dim k As Integer = dsPermisos.Tables(0).Rows(i)(1)
                Select Case j
                    Case 1
                        If k = 0 Then : MsgBox("Sin acceso al sistema") : End : End If
                    Case 2
                        If k = 1 Then CotizacionesToolStripMenuItem.Visible = True
                    Case 3
                        If k = 1 Then NuevaCotizaciónToolStripMenuItem.Visible = True
                    Case 4
                        If k = 1 Then ListadoDeCotizacionesToolStripMenuItem.Visible = True
                    Case 5
                        If k = 1 Then IngresoAAlmacenToolStripMenuItem.Visible = True
                    Case 6
                        If k = 1 Then NuevoIngresoToolStripMenuItem.Visible = True
                    Case 7
                        If k = 1 Then ListadoIngresosToolStripMenuItem.Visible = True
                    Case 8
                        If k = 1 Then VentasToolStripMenuItem.Visible = True
                    Case 9
                        If k = 1 Then ImportarXMLToolStripMenuItem.Visible = True
                    Case 10
                        If k = 1 Then VentaMostradorToolStripMenuItem.Visible = True
                    Case 11
                        If k = 1 Then ListadoDeVentasToolStripMenuItem.Visible = True
                    Case 12
                        If k = 1 Then SalidaAlmacenToolStripMenuItem.Visible = True
                    Case 13
                        If k = 1 Then SalidasPorSurtirToolStripMenuItem.Visible = True
                    Case 14
                        If k = 1 Then ListadoDeSalidasToolStripMenuItem.Visible = True
                    Case 15
                        If k = 1 Then CancelacionesToolStripMenuItem.Visible = True
                    Case 16
                        If k = 1 Then CancelarDocumentoToolStripMenuItem.Visible = True
                    Case 17
                        If k = 1 Then RevisarCancelacionesToolStripMenuItem.Visible = True
                    Case 18
                        If k = 1 Then ListaDeCancelacionesToolStripMenuItem.Visible = True
                    Case 19
                        If k = 1 Then ListaDePreciosToolStripMenuItem.Visible = True
                    Case 20
                        If k = 1 Then VerListaToolStripMenuItem.Visible = True
                    Case 21
                        If k = 1 Then ModificarPreciosToolStripMenuItem.Visible = True
                    Case 22
                        If k = 1 Then InventarioToolStripMenuItem.Visible = True
                    Case 23
                        If k = 1 Then InventarioProductosToolStripMenuItem.Visible = True
                        If k = 1 Then ListaDeProductosToolStripMenuItem.Visible = True
                    Case 24
                        If k = 1 Then InventarioActualToolStripMenuItem.Visible = True
                    Case 25
                        If k = 1 Then AjusteDeInventarioToolStripMenuItem.Visible = True
                    Case 26
                        If k = 1 Then MermasToolStripMenuItem.Visible = True
                    Case 27
                        If k = 1 Then RegistroDeMermaToolStripMenuItem.Visible = True
                    Case 28
                        If k = 1 Then AutorizaciónDeMermaToolStripMenuItem.Visible = True
                    Case 29
                        If k = 1 Then ListadoDeMermasToolStripMenuItem.Visible = True
                    Case 30
                        If k = 1 Then CatalogosToolStripMenuItem.Visible = True
                    Case 31
                        If k = 1 Then ClientesToolStripMenuItem.Visible = True
                    Case 32
                        If k = 1 Then ListadeClientesToolStripMenuItem.Visible = True
                    Case 33
                        If k = 1 Then AltadeClientesToolStripMenuItem.Visible = True
                        If k = 1 Then PermisoEditarClientes = True
                    Case 34
                        If k = 1 Then ProveedoresToolStripMenuItem.Visible = True
                    Case 35
                        If k = 1 Then ListaDeProveedoresToolStripMenuItem.Visible = True
                    Case 36
                        If k = 1 Then AltaDeProveedoresToolStripMenuItem.Visible = True
                        If k = 1 Then PermisoEditarProveedores = True
                    Case 37
                        If k = 1 Then ProductosToolStripMenuItem.Visible = True
                    Case 39
                        If k = 1 Then AltaDeProductosToolStripMenuItem.Visible = True
                        If k = 1 Then PermisoEditarProducto = True
                    Case 40
                        If k = 1 Then EdiciónDeProductosToolStripMenuItem.Visible = True
                        If k = 1 Then PermisoEditarProducto = True
                    Case 41
                        If k = 1 Then UnidadesDeMedidaToolStripMenuItem.Visible = True
                    Case 42
                        '    If k = 1 Then ProductoProveedorToolStripMenuItem.Visible = True
                    Case 43
                        If k = 1 Then EquivalenciasDeProductosToolStripMenuItem.Visible = True
                    Case 44
                        If k = 1 Then AdminsitraciónToolStripMenuItem.Visible = True
                        If k = 1 Then PermisoReimpresion = True
                    Case 45
                        If k = 1 Then UsuariosToolStripMenuItem.Visible = True
                    Case 46
                        If k = 1 Then PermisosToolStripMenuItem.Visible = True
                    Case 47
                        If k = 1 Then ModificarContraseñaToolStripMenuItem.Visible = True
                    Case 48
                        If k = 1 Then BitácoraDeEventosToolStripMenuItem.Visible = True
                    Case 49
                        If k = 1 Then PermisoExportarExcel = True

                End Select
            Next
        End If

        Try
        Catch ex As Exception
            NiegaTodo()
        End Try

    End Sub

    Private Sub NiegaTodo()

        CotizacionesToolStripMenuItem.Visible = False
        NuevaCotizaciónToolStripMenuItem.Visible = False
        ListadoDeCotizacionesToolStripMenuItem.Visible = False
        IngresoAAlmacenToolStripMenuItem.Visible = False
        NuevoIngresoToolStripMenuItem.Visible = False
        ListadoIngresosToolStripMenuItem.Visible = False
        VentasToolStripMenuItem.Visible = False
        ImportarXMLToolStripMenuItem.Visible = False
        VentaMostradorToolStripMenuItem.Visible = False
        ListadoDeVentasToolStripMenuItem.Visible = False
        SalidaAlmacenToolStripMenuItem.Visible = False
        SalidasPorSurtirToolStripMenuItem.Visible = False
        ListadoDeSalidasToolStripMenuItem.Visible = False
        CancelacionesToolStripMenuItem.Visible = False
        CancelarDocumentoToolStripMenuItem.Visible = False
        RevisarCancelacionesToolStripMenuItem.Visible = False
        ListaDeCancelacionesToolStripMenuItem.Visible = False
        ListaDePreciosToolStripMenuItem.Visible = False
        VerListaToolStripMenuItem.Visible = False
        ModificarPreciosToolStripMenuItem.Visible = False
        InventarioToolStripMenuItem.Visible = False
        InventarioProductosToolStripMenuItem.Visible = False
        ListaDeProductosToolStripMenuItem.Visible = False
        InventarioActualToolStripMenuItem.Visible = False
        AjusteDeInventarioToolStripMenuItem.Visible = False
        MermasToolStripMenuItem.Visible = False
        RegistroDeMermaToolStripMenuItem.Visible = False
        AutorizaciónDeMermaToolStripMenuItem.Visible = False
        ListadoDeMermasToolStripMenuItem.Visible = False
        CatalogosToolStripMenuItem.Visible = False
        ClientesToolStripMenuItem.Visible = False
        ListadeClientesToolStripMenuItem.Visible = False
        AltadeClientesToolStripMenuItem.Visible = False
        PermisoEditarClientes = False
        ProveedoresToolStripMenuItem.Visible = False
        ListaDeProveedoresToolStripMenuItem.Visible = False
        AltaDeProveedoresToolStripMenuItem.Visible = False
        PermisoEditarProveedores = False
        ProductosToolStripMenuItem.Visible = False
        AltaDeProductosToolStripMenuItem.Visible = False
        PermisoEditarProducto = False
        EdiciónDeProductosToolStripMenuItem.Visible = False
        PermisoEditarProducto = False
        UnidadesDeMedidaToolStripMenuItem.Visible = False
        EquivalenciasDeProductosToolStripMenuItem.Visible = False
        AdminsitraciónToolStripMenuItem.Visible = False
        UsuariosToolStripMenuItem.Visible = False
        PermisosToolStripMenuItem.Visible = False
        ModificarContraseñaToolStripMenuItem.Visible = False
        BitácoraDeEventosToolStripMenuItem.Visible = False
        PermisoExportarExcel = False
        PermisoReimpresion = False
    End Sub

#End Region

#Region "Botones Originales o sin usar"

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub FileMenu_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub WindowsMenu_Click(sender As System.Object, e As System.EventArgs) Handles WindowsMenu.Click

    End Sub

    Private Sub HelpToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripButton.Click

    End Sub

#End Region

#Region "Cotizaciones"

    Private Sub NuevaCotizaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCotizaciónToolStripMenuItem.Click
        If PantNuevaCotizacion = False Then
            Dim f As New Cotizar
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantNuevaCotizacion = True
            pNuevaCotizacion = f
        Else
            pNuevaCotizacion.Focus()
            Exit Sub
        End If
        Me.ToolStripStatusLabel.Text = "Elaborar una nueva Cotización"
    End Sub

    Private Sub ListadoDeCotizacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeCotizacionesToolStripMenuItem.Click
        If PantConsultaCotizaciones = False Then
            Dim f As New frmConsultaCotizaciones
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantConsultaCotizaciones = True
            pConsultaCotizaciones = f
        Else
            pConsultaCotizaciones.Focus()
            Exit Sub
        End If
        Me.ToolStripStatusLabel.Text = "Consulta de Cotizaciones"
    End Sub

#End Region

#Region "Compras"

    Private Sub NuevoIngresoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoIngresoToolStripMenuItem.Click
        If PantIngresoAlmacen = False Then
            Dim f As New Compra
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantIngresoAlmacen = True
            pIngresoAlmacen = f
        Else
            pIngresoAlmacen.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListadoIngresosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoIngresosToolStripMenuItem.Click
        If PantListadoEntredaAlmacen = False Then
            Dim f As New frmConsultaCompras
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoEntredaAlmacen = True
            pListadoIngresoAlmacen = f
        Else
            pListadoIngresoAlmacen.Focus()
            Exit Sub
        End If

    End Sub

#End Region

#Region "Ventas"

    Private Sub ImportarXMLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportarXMLToolStripMenuItem.Click
        If PantVentaXML = False Then
            Dim f As New LeerXML
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantVentaXML = True
            pVentaXML = f
        Else
            pVentaXML.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub VentaMostradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaMostradorToolStripMenuItem.Click
        If PantVentaMostrador = False Then
            Dim f As New VentaMostrador
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantVentaMostrador = True
            pVentaMostrador = f
        Else
            pVentaMostrador.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click
        If PantListaVentas = False Then
            Dim f As New ListaVentas
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListaVentas = True
            pListaVentas = f
        Else
            pListaVentas.Focus()
            Exit Sub
        End If
    End Sub
#End Region

#Region "Salidas de Almacen"

    Private Sub SalidasPorSurtirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalidasPorSurtirToolStripMenuItem.Click
        If PantSalidasAlmacen = False Then
            Dim f As New SalidaAlamcen
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantSalidasAlmacen = True
            pSalidasAlmacen = f
        Else
            pSalidasAlmacen.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListadoDeSalidasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeSalidasToolStripMenuItem.Click
        If PantListaSalidas = False Then
            Dim f As New ListaSalidaAlmacen
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListaSalidas = True
            pListaSalidas = f
        Else
            pListaSalidas.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Catalogo Proveedores"

    Private Sub ListaDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProveedoresToolStripMenuItem.Click
        If PantListadoProveedores = False Then
            Dim f As New ListaProveedor
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoProveedores = True
            pListadoProveedores = f
        Else
            pListadoProveedores.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub AltaDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeProveedoresToolStripMenuItem.Click
        If PantAltaProveedores = False Then
            Dim f As New AltaProveedor
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantAltaProveedores = True
            pAltaProveedores = f
        Else
            pAltaProveedores.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Catalogo Clientes"

    Private Sub ListadeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadeClientesToolStripMenuItem.Click
        If PantListadoClientes = False Then
            Dim f As New ListaClientes
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoClientes = True
            pListadoClientes = f
        Else
            pListadoClientes.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub AltadeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltadeClientesToolStripMenuItem.Click
        If PantAltaClientes = False Then
            Dim f As New AltaClientes
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoClientes = True
            pAltaClientes = f
        Else
            pAltaClientes.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Procesos Adicionales"

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.HabiltarReloj = False
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub tmrOrdenesSalida_Tick(sender As System.Object, e As System.EventArgs) Handles tmrOrdenesSalida.Tick
        tmrOrdenesSalida.Interval = 3000000
        Dim strqry As String =
            "SELECT count (intUsuarioOrdenSalida) as Cuantos from vstOrdenesSalida where intUsuarioOrdenSalida = 0"
        Dim dsCuantos As DataSet
        dsCuantos = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB,
                                                 strqry, "Cuantos", "Error al contar Ordenes de Salida por Surtir.")
        Dim strCuantos As String
        strCuantos = dsCuantos.Tables(0).Rows(0)(0).ToString
        If strCuantos = "0" Then
            Exit Sub
        Else
            MessageBox.Show("En este momento hay " & strCuantos & " Ordenes de Salida por surtir.",
                            "Mercancia pendiente de surtir.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region "Catalogo de Productos"
    Private Sub AltaDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaDeProductosToolStripMenuItem.Click
        If PantAltaProductos = False Then
            Dim f As New AltaDeProductos
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantAltaProductos = True
            pAltaProductos = f
        Else
            pAltaProductos.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Cancelaciones"
    Private Sub CancelarDocumentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarDocumentoToolStripMenuItem.Click
        If PantCancelarDocumento = False Then
            Dim f As New frmCancelaciones
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantCancelarDocumento = True
            pCancelarDocumento = f
        Else
            pCancelarDocumento.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub RevisarCancelacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RevisarCancelacionesToolStripMenuItem.Click
        If PantRevisarCancelaciones = False Then
            Dim f As New frmRevisarCancelaciones
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantRevisarCancelaciones = True
            pRevisarCancelaciones = f
        Else
            pRevisarCancelaciones.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListaDeCancelacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeCancelacionesToolStripMenuItem.Click
        If PantListaCancelaciones = False Then
            Dim f As New frmListaCancelaciones
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListaCancelaciones = True
            pListaCancelaciones = f
        Else
            pListaCancelaciones.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Inventario"

    Private Sub InventarioActualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioActualToolStripMenuItem.Click
        If PantInventario = False Then
            Dim f As New frmInventario
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantInventario = True
            pInventario = f
        Else
            pInventario.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub AjusteDeInventarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjusteDeInventarioToolStripMenuItem.Click
        If PantAjusteInventario = False Then
            Dim f As New AjusteInventario
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantAjusteInventario = True
            pAjusteInventario = f
        Else
            pAjusteInventario.Focus()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Mermas"

    Private Sub RegistroDeMermaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeMermaToolStripMenuItem.Click
        If PantReporteMerma = False Then
            Dim f As New frmReporteMerma
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantReporteMerma = True
            pReporteMerma = f
        Else
            pReporteMerma.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub AutorizaciónDeMermaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutorizaciónDeMermaToolStripMenuItem.Click
        If PantRevisaMerma = False Then
            Dim f As New frmRevisionMerma
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantRevisaMerma = True
            pRevisaMerma = f
        Else
            pRevisaMerma.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListadoDeMermasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeMermasToolStripMenuItem.Click
        If PantListadoMerma = False Then
            Dim f As New frmListaMermas
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoMerma = True
            pListadoMerma = f
        Else
            pListadoMerma.Focus()
            Exit Sub
        End If
    End Sub

#End Region

    Private Sub InventarioProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioProductosToolStripMenuItem.Click
        If PantListadoProductos = False Then
            Dim f As New frmListaProductos
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoProductos = True
            pListadoProductos = f
        Else
            pListadoProductos.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ListaDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeProductosToolStripMenuItem.Click
        If PantListadoProductos = False Then
            Dim f As New frmListaProductos
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoProductos = True
            pListadoProductos = f
        Else
            pListadoProductos.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub EdiciónDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EdiciónDeProductosToolStripMenuItem.Click
        If PantListadoProductos = False Then
            Dim f As New EdicionProductos
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantEdicionProductos = True
            pEdicionProductos = f
        Else
            pEdicionProductos.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ViewMenu_Click(sender As System.Object, e As System.EventArgs) Handles ViewMenu.Click

    End Sub

    Private Sub AdminsitraciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdminsitraciónToolStripMenuItem.Click

    End Sub

    Private Sub RespaldoBaseDeDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RespaldoBaseDeDatosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim strqry As String
        Dim dsFecha As DataSet = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, "select getdate()", "Fecha", "")
        Dim dtfecha As Date
        dtfecha = dsFecha.Tables(0).Rows(0)(0)
        Dim strFecha As String = Format(dtfecha, "yyyyMMddHHmmss")

        strqry = "BACKUP DATABASE [dbQuart] TO  DISK = N'C:\BaseDatos\MSSQL10_50.DBQUART\MSSQL\Backup\dbQuart " & strFecha &
            ".bak' WITH NOFORMAT, NOINIT,  NAME = N'dbQuart-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        Dim RespaldoOK As Boolean = False
        RespaldoOK = funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al crear Respaldo")

        If RespaldoOK = True Then
            MsgBox("Respaldo realizado correctamente")
            GrabarAccion(99)
        Else
            MsgBox("Problemas al realizar respaldo.")
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DepurarBaseDeDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepurarBaseDeDatosToolStripMenuItem.Click
        Dim strqry As String
        strqry = "delete FROM tblListaComprasPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        strqry = "delete FROM tblListaCotizacionesPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        strqry = "delete FROM tblListaVentasPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        strqry = "delete FROM tblTransaccionesCompraPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        strqry = "delete FROM tblTransaccionesCotizacionesPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        strqry = "delete FROM tblTransaccionesVentaPrevia"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "")
        GrabarAccion(98)
        MsgBox("Depuración terminada")
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If PantListadoUsuarios = False Then
            Dim f As New frmUsuarios
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoUsuarios = True
            pListaUsuarios = f
        Else
            pListaUsuarios.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        If PantCrearUsuarios = False Then
            Dim f As New frmCrearUsuario
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantListadoUsuarios = True
            pCrearUsuarios = f
        Else
            pCrearUsuarios.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        If PantUnidadesMedida = False Then
            Dim f As New frmUnidadesdeMedida
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantUnidadesMedida = True
            pUnidadesMedida = f
        Else
            pUnidadesMedida.Focus()

        End If
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        If PantModificarPermisos = False Then
            Dim f As New frmModificarPermisos

            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantModificarPermisos = True
            pModificarPermisos = f
        Else
            pModificarPermisos.Focus()
        End If
    End Sub

    Private Sub EquivalenciasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquivalenciasDeProductosToolStripMenuItem.Click
        If PantAñadirEquivalencias = False Then
            Dim f As New frmAñadirEquivalencia

            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantModificarPermisos = True
            pAñadirEquivalencias = f

        Else
            pAñadirEquivalencias.Focus()
        End If
    End Sub

    Private Sub MostrarValoresDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarValoresDeInventarioToolStripMenuItem.Click
        If PantValoresInventario = False Then
            Dim f As New frmValorInventario
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantValoresInventario = True
            pValoresInventario = f

        Else
            pValoresInventario.Focus()
        End If
    End Sub

    Private Sub ComprasPorProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProductoToolStripMenuItem.Click
        If PantReporteComprasProducto = False Then
            Dim f As New CompraProducto
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantReporteComprasProducto = True
            pReporteCompraProductos = f

        Else
            pReporteCompraProductos.Focus()
        End If
    End Sub

    Private Sub VentasPorProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorProductoToolStripMenuItem.Click
        If PantReporteVentaProducto = False Then
            Dim f As New VentaProductos
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.Manual
            f.Show()
            PantReporteVentaProducto = True
            pReporteVentaproductos = f

        Else
            pReporteVentaproductos.Focus()
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class