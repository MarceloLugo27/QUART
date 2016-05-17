Imports System.Windows
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Net

Public Class ProcedimientosGenerales



#Region "Variables para server de pruebas"

    Public Shared strNombreServer As String
    Public Shared strPasswordDB As String
    Public Shared strUsuarioBD As String
    Public Shared UbicacionListado As String

    Public Shared strNombreBD As String

    Public Shared MacAddr As String
    Public Shared IPAddr As String
    Public Shared HostName As String

    Public Shared intIDProducto As Integer
    Public Shared strNombreProducto As String

    Public Shared ClienteXML As Integer
    Public Shared ProductoXML As Integer

    ''VARIABLES DE USUARIO
    Public Shared intUsuario As Integer = 0
    Public Shared strNombreUsuario As String = ""
    Public Shared strComputadora As String
    Public Shared strIP As String

    ''Variables de permisos
    Public Shared PermCotizaciones As Boolean = False
    Public Shared PermCompras As Boolean = False
    Public Shared PermVentas As Boolean = False
    Public Shared PermSalidaAlmacen As Boolean = True
    Public Shared PermInventario As Boolean = False
    Public Shared PermCatalogos As Boolean = False
    Public Shared PermListaPrecios As Boolean = False



    Public Shared Sub VerificarServer(Optional ByRef server As Integer = 1)
        Select Case server
            Case 1
                strNombreBD = "dbQuart"
                strNombreServer = "MSL\MSL"
                strPasswordDB = "SWcrbyGLin77"
                strUsuarioBD = "sa"
            Case 2
                strNombreBD = "dbQuart"
                strNombreServer = "CART\CART"
                strPasswordDB = "wininasltotis27w*"
                strUsuarioBD = "sa"
            Case 3
                strNombreBD = "dbQuart"
                strNombreServer = "URDIALES-PC\DBQUART"   'equipo mas instancia Quart
                strPasswordDB = "marcelo123"     'contraseña
                strUsuarioBD = "sa"
            Case 4
                strNombreBD = "dbQuart"
                strNombreServer = "MSLSERVER\MSL"   'equipo mas instancia Quart
                strPasswordDB = "SWcrbyGLin77"     'contraseña
                strUsuarioBD = "sa"
        End Select
        frmLogin.intServer = server
    End Sub

#End Region


#Region "Crear Dataset para consultas"
    Public Shared Function funCrearDataset(ByVal strServidor As String, _
                ByVal strBaseDatos As String, _
                ByVal strQuery As String, _
                ByVal strTabla As String, _
                ByRef MiError As String) As DataSet
        MiError = ""
        Dim cnnSQL As New SqlConnection
        cnnSQL.ConnectionString = "Integrated Security=True;" & _
                                    "Data Source=" & strServidor & "; " & _
                                    "Initial Catalog=" & strBaseDatos & ";"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strQuery, cnnSQL)
        Dim ds As New DataSet
        Try
            da.Fill(ds, strTabla)
            cnnSQL.Open()
            funCrearDataset = ds
        Catch ex As Exception
            funCrearDataset = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
        cnnSQL.Close()
    End Function

    Public Shared Function funCrearDatasetValidaUsuario(ByVal strServidor As String, _
        ByVal strBaseDatos As String, _
        ByVal strUsuario As String, _
        ByVal strPassword As String, _
        ByVal strQuery As String, _
        ByVal strTabla As String, _
        ByRef MiError As String) As DataSet

        'MiError = ""
        Dim cnnSQL As New SqlConnection
        cnnSQL.ConnectionString = "Persist Security Info=False;" & _
                                    "User ID = " & strUsuario & ";" & _
                                    "Password = " & strPassword & ";" & _
                                    "Data Source =" & strServidor & ";" & _
                                    "Initial Catalog =" & strBaseDatos
        '"Provider=SQLOLEDB.1;" & _

        Dim da As SqlDataAdapter = New SqlDataAdapter(strQuery, cnnSQL)
        Dim ds As New DataSet
        Try
            da.Fill(ds, strTabla)
            cnnSQL.Open()
            funCrearDatasetValidaUsuario = ds
        Catch ex As Exception
            funCrearDatasetValidaUsuario = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
        cnnSQL.Close()
    End Function

#End Region

#Region "Enviar Comando SQL (Consultas)"
    Public Shared Function funEnviarComandoSQL(ByVal strServidor As String, _
                ByVal strBaseDatos As String, _
                ByVal strQuery As String, _
                ByRef MiError As String) As Boolean

        Dim strCon As String
        Try
           ' MiError = ""
            strCon = "Integrated Security=True;" & _
                   "Data Source=" & strServidor & "; " & _
                   "Initial Catalog=" & strBaseDatos & ";"

            Using con As New SqlConnection(strCon)
                Dim cmdSQL As New SqlCommand
                cmdSQL.CommandText = strQuery
                cmdSQL.Connection = con
                con.Open()
                Dim t As Integer = cmdSQL.ExecuteNonQuery()
                con.Close()
                funEnviarComandoSQL = True
            End Using

        Catch ex As Exception
            funEnviarComandoSQL = False
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
    End Function

    Public Shared Function funEnviarComandoSQLValidaUsuario(ByVal strServidor As String, _
        ByVal strBaseDatos As String, _
        ByVal strUsuario As String, _
        ByVal strPassword As String, _
        ByVal strQuery As String, _
        ByRef MiError As String) As Boolean

        Dim strCon As String
        Try
            ' MiError = ""

            strCon = "Persist Security Info=False;" & _
                    "User ID = " & strUsuario & ";" & _
                    "Password = " & strPassword & ";" & _
                    "Data Source =" & strServidor & ";" & _
                    "Initial Catalog =" & strBaseDatos

            Using con As New SqlConnection(strCon)
                Dim cmdSQL As New SqlCommand
                cmdSQL.CommandText = strQuery
                cmdSQL.Connection = con
                con.Open()
                Dim t As Integer = cmdSQL.ExecuteNonQuery()
                con.Close()
                funEnviarComandoSQLValidaUsuario = True
            End Using

        Catch ex As Exception
            funEnviarComandoSQLValidaUsuario = False
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
    End Function

#End Region

#Region "Enviar Comando SQL INSERT regresando IDENTITY"

    Public Shared Function funSQLINSERTregresaIDENTITY(ByVal strServidor As String, _
                ByVal strBaseDatos As String, _
                ByVal strQuery As String, _
                ByRef MiError As String) As Long

        Dim strCon As String
        Try
            MiError = ""
            strCon = "Integrated Security=True;" & _
                   "Data Source=" & strServidor & "; " & _
                   "Initial Catalog=" & strBaseDatos & ";"

            Using con As New SqlConnection(strCon)
                Dim cmdSQL As New SqlCommand
                cmdSQL.CommandText = strQuery & " SELECT @@IDENTITY"
                cmdSQL.Connection = con
                con.Open()
                Dim t As Integer = CInt(cmdSQL.ExecuteScalar())
                con.Close()
                Return t
            End Using

        Catch ex As Exception
            funSQLINSERTregresaIDENTITY = 0
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
    End Function

    Public Shared Function funSQLINSERTregresaIDENTITYValidaUsuario(ByVal strServidor As String, _
    ByVal strBaseDatos As String, _
    ByVal strUsuario As String, _
    ByVal strPassword As String, _
    ByVal strQuery As String, _
    ByRef MiError As String) As Long

        Dim strCon As String

        Try
            'MiError = ""

            strCon = "Persist Security Info=False;" & _
                    "User ID = " & strUsuario & ";" & _
                    "Password = " & strPassword & ";" & _
                    "Data Source =" & strServidor & ";" & _
                    "Initial Catalog =" & strBaseDatos

            Using con As New SqlConnection(strCon)
                Dim cmdSQL As New SqlCommand
                cmdSQL.CommandText = strQuery & " select @@IDENTITY"
                cmdSQL.Connection = con
                con.Open()
                Dim t As Integer = cmdSQL.ExecuteScalar()
                con.Close()
                Return t
            End Using

        Catch ex As Exception
            funSQLINSERTregresaIDENTITYValidaUsuario = 0
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, MiError)
        End Try
    End Function

#End Region

#Region "Obtener datos de la computadora local"

    Public Shared Function funObtenerIP() As String
        Dim i_cont As Integer = 0
        Dim Host As String
        ' Si no se pasa como parametro un nombre, muestra las ip locales
        If Environment.GetCommandLineArgs().Length > 1 Then
            Host = Environment.GetCommandLineArgs(1)
        Else
            Host = Dns.GetHostName
        End If
        Dim IPs As IPHostEntry = Dns.GetHostEntry(Host)
        Dim Direcciones As IPAddress() = IPs.AddressList
        'Se despliega la lista de IP's
        'For i_cont = 0 To i_cont = Direcciones.Length
        Console.WriteLine("IP {0}: {1} ", i_cont + 1, Direcciones(i_cont).ToString())
        'Next
        'Console.Read()
        funObtenerIP = Direcciones(i_cont).ToString
    End Function

    Public Shared Function funObtenerHost() As String
        Dim Host As String
        ' Si no se pasa como parametro un nombre, muestra las ip locales
        If Environment.GetCommandLineArgs().Length > 1 Then
            Host = Environment.GetCommandLineArgs(1)
        Else
            Host = Dns.GetHostName
        End If
        funObtenerHost = Host
    End Function

#End Region

#Region "Llenado de DataGrid"
    Public Shared Sub LlenarDataGrid(ByVal strConsulta As String, _
                                 ByVal dgvDataGrid As Object, _
                                 Optional ByVal msgNada As String = "Sin conexión a la base de datos.", _
                                 Optional ByVal encNada As String = "Error de Conexión.", _
                                 Optional ByVal msgVacio As String = "No hay informacion.", _
                                 Optional ByVal encVacio As String = "Sin Datos.")
        Dim dsListado As New DataSet
        dsListado = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "Tabla", "Error al llenar Datagrid " & dgvDataGrid.ToString)
        If dsListado Is Nothing Then    'No hay conexion o hay error"
            MessageBox.Show(msgNada, encNada, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If dsListado.Tables(0).Rows.Count = 0 Then  'No existen datos
                MessageBox.Show(msgVacio, encVacio, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgvDataGrid.datasource = dsListado.Tables(0)
            End If
        End If
    End Sub

    Public Shared Sub LlenarDataGridNoMensaje(ByVal strConsulta As String, _
                                 ByVal dgvDataGrid As Object, _
                                 Optional ByVal msgNada As String = "Sin conexión a la base de datos.", _
                                 Optional ByVal encNada As String = "Error de Conexión.", _
                                 Optional ByVal msgVacio As String = "No hay informacion.", _
                                 Optional ByVal encVacio As String = "Sin Datos.")
        Dim dsListado As New DataSet
        dsListado = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "Tabla", "Error al llenar Datagrid " & dgvDataGrid.ToString)
        If dsListado Is Nothing Then    'No hay conexion o hay error"

        Else
            If dsListado.Tables(0).Rows.Count = 0 Then  'No existen datos

            Else
                dgvDataGrid.datasource = dsListado.Tables(0)
            End If
        End If
    End Sub

    Public Shared Sub PrepararDGV(ByVal dgvDataGrid As Object)
        With dgvDataGrid
            .DataSource = Nothing
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = True
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Public Shared Sub LimpiarDataGrid(ByVal dgvDataGrid As DataGridView)
        With dgvDataGrid
            .DataSource = Nothing
            .Columns.Clear()
            .Rows.Clear()
        End With
    End Sub

#End Region

#Region "Cargar Combos"
    Public Shared Sub LlenarCombo(ByVal strConsulta As String, _
                               ByVal cbComboBox As Object, _
                               ByVal strValueMember As String, _
                               ByVal strDisplaymember As String, _
                               Optional ByVal msgNada As String = "Sin conexión a la base de datos.", _
                               Optional ByVal encNada As String = "Error de Conexión.", _
                               Optional ByVal msgVacio As String = "No hay informacion.", _
                               Optional ByVal encVacio As String = "Sin Datos.")
        Dim dsListado As New DataSet
        dsListado = funCrearDatasetValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strConsulta, "Tabla", "Error al llenar Combo " & cbComboBox.ToString)
        If dsListado Is Nothing Then    'No hay conexion o hay error"
            ' MessageBox.Show(msgNada, encNada, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If dsListado.Tables(0).Rows.Count = 0 Then  'No existen datos
                '   MessageBox.Show(msgVacio, encVacio, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cbComboBox.datasource = dsListado.Tables(0)
                'cbComboBox.Valuememeber = strValueMember
                cbComboBox.DisplayMember = strDisplaymember
            End If
        End If
    End Sub

    Public Shared Sub LimpiarCombo(ByVal cbComboBox As ComboBox)
        With cbComboBox
            .DataSource = Nothing
            .Items.Clear()
        End With
    End Sub

#End Region

    Public Shared Sub Pausa(Optional ByRef intMiliSec As Integer = 200)
        System.Threading.Thread.Sleep(intMiliSec)
    End Sub

    Public Shared Sub GrabarAccion(ByRef intAccion As Integer, Optional ByRef intIdAccion As Integer = 0)
        Dim strqry As String = "INSERT INTO tblBitacoras ([idUsuario],[strComputadora],[strIP],[intAccion],[intIDAccion]) VALUES (" &
            intUsuario & ", '" & strComputadora & "', '" & strIP & "', " & intAccion & ", " & intIdAccion & ")"
        funEnviarComandoSQLValidaUsuario(strNombreServer, strNombreBD, strUsuarioBD, strPasswordDB, strqry, "Error al registarse evento " & intAccion.ToString)
        ' DESCRIPCION DE aCCIONES
        '1 Ingreso al sistema
        '2 Salida del Sistema
        '3 Generar una cotizacion Nueva
        '4 Imprimir cotizacion
        '5 Entrar a Consulta de Cotizaciones
        '6 Ingresar una compra Nueva
        '7 Consulta de adquisiciones
        '8 Importar XML (Venta por factura)
        '9 Venta de Mostrador
        '10 Consulta de Ordenes de Salida
        '11 Impresion de Ordenes de Salida
        '12 Consulta de Clientes
        '13 Ingreso de Cliente
        '14 Modificacion de cliente
        '15 Surtir Orden de salida
        '16 Alta de Cliente
        '17 Modificar Cliente
        '18 Listado de Clientes
        '19 Alta de Producto
        '20 Modificar Producto
        '21 Listado Producto
        '22 Cancelación de Compra
        '23 Cancelacion de Venta
        '24 Revision de cancelacion
        '25 Ejecutar ajuste inventario
    End Sub


    Public Shared Function Fg_NumerosSigno(ByVal Digito As String, ByVal texto As String, txtb As MaskedTextBox) As Boolean
        Dim Salida As Boolean = False
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        Dim posicion As Integer = Len(txtb.Text)

        If Dt_Entero = 8 Then
            Salida = False
        Else
            If posicion = 0 And Dt_Entero = 45 Then
                Salida = False
            ElseIf InStr("1234567890.", Digito) = 0 Then
                Salida = True
            ElseIf IsNumeric(texto) = True Then
                Salida = False
            ElseIf IsNumeric(texto) = False Then
                Salida = True
            End If

        End If


        Return Salida
    End Function



    Public Shared Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean

        '***************************************************************************
        'la siguiente funcion se aplica en un textbox en el proceso key press
        'solo permite insertar numeros y UN solo punto decimal.
        'el evento textbox_keypress debe modificarse
        'para un textbox llamado txtNumero el evento debe quedar de la siguiente manera 
        '
        'Tener cuidado con el nomber del TextBox... debe de ponerse adento del evento

        'Private Sub txtNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        '    eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtNumero.Text & CChar(eventArgs.KeyChar))
        'End Sub

        'FUNCIONA IGUAL CON MASKED TEXT BOX

        '***************************************************************************


        Dim Salida As Boolean = False
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Salida = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Salida = True
            ElseIf IsNumeric(Texto) = True Then
                Salida = False
            ElseIf IsNumeric(Texto) = False Then
                Salida = True
            End If
        End If
        Return Salida
    End Function

    Public Shared Sub PrepararForm(ByRef ventana As Form)
        ventana.MaximizeBox = False
        ventana.MinimizeBox = False
        ventana.FormBorderStyle = FormBorderStyle.Fixed3D
    End Sub

End Class


