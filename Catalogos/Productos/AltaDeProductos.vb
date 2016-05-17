Imports QuartOK.ProcedimientosGenerales

Public Class AltaDeProductos

    Dim TipoProducto As Integer
    Dim IDProducto As Integer
    Dim intProveedor As Integer = 0
    Dim Inventariable As Integer
    Dim intUnidadMedida As Integer

    Dim IdNuevo As Integer
    Dim strProductoNuevo As String
    Dim intAplicaIVA As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region "Carga Inicial del Form"

    Private Sub AltaDeProductos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MDIPrincipal.PantAltaProductos = False
    End Sub

    Private Sub AltaDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAñadirProducto.Enabled = False
        rbTerminado.Checked = True
        chkbInventariable.Checked = True
        chkAplicaIVA.Checked = True
        EvaluarOrigen()
    End Sub

    Private Sub EvaluarOrigen()
        If ProductoXML = 0 Then
            IniciarNuevoProducto()
        End If

        If ProductoXML = 2 Then         'el producto proviene de una compra (Entrada a Almacen)
            Dim strqry As String
            intProveedor = Compra.intProveedor
            strqry = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores where IDProveedor = " & intProveedor
            LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
            cbProveedor.ValueMember = "IDProveedor"
            cbProveedor.Enabled = False
            gbTodo.Enabled = False
            tbID.Focus()
        End If
        If ProductoXML = 1 Then     'el producto procede de un archivo XML
            gbTodo.Enabled = False
            tbID.Enabled = False
            btnAñadirID.Enabled = False
            tbID.Text = LeerXML.strNumIDProdXML
            Dim SeguirAdelante As Boolean
            SeguirAdelante = VerificarNumeroProductoQuart(tbID.Text)
            If SeguirAdelante = False Then
                MessageBox.Show("El numero de ID utilizado proveniente del archivo XML ya esta en la base de datos. Cierre esta ventana e intente validar de nuevo los productos en la pantalla de Importación de XML",
                                "Producto ya insertado en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                CargarComboProveedores()
                tbID.Enabled = False
                tbNombreProducto.Text = LeerXML.strDescripcionProdXML
                tbNombreProducto.Enabled = False
                Precio1.Text = LeerXML.strValUnitarioProdXML
                Precio1.Enabled = False
                btnAñadirProducto.Enabled = True
                Dim strUM As String = LeerXML.strUnidadProdXML
                Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from tblCatUnidadMedida where strUnidadMedida = '" & strUM & "' Order by strUnidadMedida"
                LlenarCombo(strqry, cbTipoUnidad, "IDUnidadMedida", "strUnidadMedida")
                cbTipoUnidad.ValueMember = "IDUnidadMedida"
                cbTipoUnidad.Enabled = False
                gbTodo.Enabled = True
                tbMarca.Focus()
            End If
        End If
    End Sub

    Private Sub IniciarNuevoProducto()      'producto XML = 0
        tbID.Focus()
        MessageBox.Show("Al dar de alta un producto, recuerde verificar que el valor de la ID sea el mismo que en el sistema de facturación.")
        tbID.Enabled = True
        btnAñadirID.Enabled = True
        gbTodo.Enabled = False
    End Sub

#End Region

#Region "Combos Proveedor y Unidad de Medida"

    Private Sub CargarComboProveedores()
        Dim strqry As String = "Select IDProveedor, strNombreProveedor FROM tblCatProveedores"
        LlenarCombo(strqry, cbProveedor, "IDProveedor", "strNombreProveedor")
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If cbProveedor.DataSource IsNot Nothing Then
            intProveedor = DirectCast(cbProveedor.SelectedItem, DataRowView).Item("IDProveedor")
        End If
    End Sub

    Private Sub CargarComboUnidadMedida()
        Dim strqry As String = "SELECT IDUnidadMedida, strUnidadMedida from tblCatUnidadMedida Order by strUnidadMedida"
        LlenarCombo(strqry, cbTipoUnidad, "IDUnidadMedida", "strUnidadMedida")
    End Sub

    Private Sub cbTipoUnidad_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbTipoUnidad.SelectedValueChanged
        If cbTipoUnidad.DataSource IsNot Nothing Then
            intUnidadMedida = DirectCast(cbTipoUnidad.SelectedItem, DataRowView).Item("IDUnidadMedida")
        End If
    End Sub

    Private Sub cbTipoUnidad_ValueMemberChanged(sender As Object, e As System.EventArgs) Handles cbTipoUnidad.ValueMemberChanged

    End Sub

#End Region

#Region "Validar ID del Producto"

    Private Sub tbID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbID.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            If InStr(1, Chr(13), e.KeyChar) = 1 Then
                btnAñadirID.Focus()
            Else
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub btnAñadirID_Click(sender As Object, e As EventArgs) Handles btnAñadirID.Click
        If tbID.Text = "" Then
            MessageBox.Show("Debe insertar un numero de producto previamente establecido en el sistema de facturación,",
                            "Ingrese un número válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbID.Focus()
            Exit Sub
        End If
        Dim SeguirAdelante As Boolean
        SeguirAdelante = VerificarNumeroProductoQuart(tbID.Text)
        If SeguirAdelante = False Then
            MessageBox.Show("El ID que pretende insertar ya esta ingresado en el sistema. Verifique en el sistema de facturación que está colocando el número correcto." & _
                            vbCr & vbCr & "Tome en cuenta que puede intentar colocar otro numero y continuar, pero de hacerlo asi el listado de productos de esta sistema " & _
                            "y el de facturación no serán compatibles y podría afectar a su sistema contable.", "Id de producto ya ingresado al sistema.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            gbTodo.Enabled = False
            tbID.Focus()
            Exit Sub
        End If
        Select Case ProductoXML
            Case 0
                tbID.Enabled = False
                btnAñadirID.Enabled = False
                gbTodo.Enabled = True
                CargarComboProveedores()
                CargarComboUnidadMedida()
                tbNombreProducto.Focus()
            Case 2
                tbID.Enabled = False
                btnAñadirID.Enabled = False
                gbTodo.Enabled = True
                cbProveedor.Enabled = False
                CargarComboUnidadMedida()
                tbNombreProducto.Focus()
        End Select


    End Sub

    Public Shadows Function VerificarNumeroProductoQuart(ByRef Numero As String) As Boolean
        Dim Noexiste As Boolean = False
        Dim dsExiste As New DataSet
        Dim strqry As String = "SELECT [IDProducto] FROM [dbQuart].[dbo].[tblCatProductos] where strCodProdQuart = '" & Numero & "'"
        dsExiste = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Cuenta", "Error al revisar producto existente.")

        If dsExiste.Tables(0).Rows.Count = 0 Then
            tbID.Enabled = False
            tbNombreProducto.Enabled = True
            tbMarca.Enabled = True
            tbModelo.Enabled = True
            cbProveedor.Enabled = True
            Precio1.Enabled = True
            btnAñadirProducto.Enabled = True
            Noexiste = True
        Else
            Noexiste = False
        End If
        Return Noexiste
    End Function

#End Region

#Region "Inventariable"

    Private Sub chkbInventariable_CheckedChanged(sender As Object, e As EventArgs) Handles chkbInventariable.CheckedChanged
        If chkbInventariable.Checked = True Then
            Inventariable = 1
        End If
        If chkbInventariable.Checked = False Then
            Inventariable = 0
        End If
    End Sub

#End Region

#Region "Tipo de Producto"

    Private Sub rbTerminado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTerminado.CheckedChanged
        If rbTerminado.Checked = True Then
            TipoProducto = 3
        End If
    End Sub

    Private Sub rbMateriaPrima_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMateriaPrima.CheckedChanged
        If rbMateriaPrima.Checked = True Then
            TipoProducto = 1
        End If
    End Sub

    Private Sub rbMixto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMixto.CheckedChanged
        If rbMixto.Checked = True Then
            TipoProducto = 2
        End If
    End Sub

#End Region

#Region "validación de precios"

    Private Sub Precio1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio1.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio1.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio2.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio2.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio3.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio3.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub Precio4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Precio4.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, Precio4.Text & CChar(eventArgs.KeyChar))
    End Sub

#End Region


    Private Sub btnAñadirProducto_Click(sender As Object, e As EventArgs) Handles btnAñadirProducto.Click
        If tbNombreProducto.Text = "" Then
            MessageBox.Show("Debe insertar un nombre de producto")
            tbNombreProducto.Focus()
            Exit Sub
        ElseIf Precio1.Text = "" Then
            MessageBox.Show("Debe insertar siempre el precio 1.")
            Precio1.Focus()
            Exit Sub
        End If

        Dim strNombreProductoNuevo As String = tbNombreProducto.Text

        If Precio2.Text = "" Then Precio2.Text = "0.00"
        If Precio3.Text = "" Then Precio3.Text = "0.00"
        If Precio4.Text = "" Then Precio4.Text = "0.00"



        Dim ID As Long
        Dim strqry As String = ""
        strqry = "INSERT INTO tblCatProductos (strDescripcionProducto, strMarcaProducto," &
            "strModelo, intTipoProducto, intInventario, intVarControlProductos, intInventariable, strCodProdQuart, " &
            "intUsuarioAlta, intAplicaIVA) VALUES ('" & tbNombreProducto.Text & "','" & tbMarca.Text & "','" & tbModelo.Text & "'," &
           TipoProducto & ", 1, 1, " & Inventariable & ",'" & tbID.Text & "'," & intUsuario & ", " & intAplicaIVA & ")"
        ID = funSQLINSERTregresaIDENTITYValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se ha podido insertar el producto.")
        'IdNuevo = ID
        strProductoNuevo = strNombreProductoNuevo

        If ID > 0 Then
            strqry = "INSERT INTO tblProveedorProducto (IDProducto, IDProveedor, IDUnidadMedida, intVarControlproveedorProducto," &
                "intusuario) VALUES (" & ID & "," & intProveedor & ", " & intUnidadMedida & ", 1," & intUsuario & ")"
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se ha podido insertar el producto.")

            strqry = "INSERT INTO tblListaPrecios (IdProducto,IdUnidadMedida,decPrecioA,decPrecioB,decPrecioC,decPrecioD,strCodProdQuart) " &
                " VALUES (" & ID & ", " & intUnidadMedida & ", " & Precio1.Text & ", " & Precio2.Text & ", " & Precio3.Text & "," & Precio4.Text & ",'" & tbID.Text & "')"
            funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "No se ha podido insertar el precio del producto.")

            Select Case ProductoXML
                Case 0
                    GrabarAccion(19, ID)
                    Limpiar()
                Case 1
                    GrabarAccion(24, ID)
                    Me.Close()
                Case 2
                    'GrabarAccion(25, ID)
                    'modProductoNuevo.idProductoNuevo = ID
                    'modProductoNuevo.strProductoNuevo = strProductoNuevo
                    'Compra.CargarProductoNuevo()
                    'Me.Close()
                    'Compra.tbProducto.Text = strNombreProductoNuevo
                    'Compra.CargarProductoNuevo(Me.IdNuevo, Me.strProductoNuevo, Me.intUnidadMedida)
            End Select
        End If


    End Sub

    Private Sub Limpiar()
        gbTodo.Enabled = False
        tbID.Enabled = True
        tbID.Text = ""
        btnAñadirID.Enabled = True
        tbNombreProducto.Text = ""
        tbMarca.Text = ""
        tbModelo.Text = ""
        Precio1.Text = ""
        Precio2.Text = ""
        Precio3.Text = ""
        Precio4.Text = ""
        cbProveedor.DataSource = Nothing
        cbProveedor.Items.Clear()
        cbTipoUnidad.DataSource = Nothing
        cbTipoUnidad.Items.Clear()
        chkbInventariable.Checked = True
    End Sub


    Private Sub tbMarca_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbMarca.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbModelo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub tbNombreProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombreProducto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAplicaIVA.CheckedChanged
        If chkAplicaIVA.Checked = True Then
            intAplicaIVA = 1
        End If
        If chkAplicaIVA.Checked = False Then
            intAplicaIVA = 0
        End If
    End Sub
End Class