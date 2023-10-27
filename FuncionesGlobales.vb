Imports System.Net
Imports System.Management
Imports System.Data.SqlClient
Imports Modulo_Facturacion.Cn_Datos


Public Class FuncionesGlobales

#Region "Globales"

    Enum Func As Byte
        Suma = 1
        Conteo = 2
    End Enum

    Enum Modo As Byte
        TotalySeleccionados = 1
        Total = 2
    End Enum

    Public Enum ParametrosGlobales As Byte
        Puesto_JRU = 0
        Puesto_OPE = 1
        Puesto_CUS = 2
        Puesto_Ventas = 3
        Puesto_Sistemas = 4
        Puesto_Sproceso = 5
        Puesto_Cajero = 6
    End Enum

    Public Shared Function fn_ParametrosGlobales(ByVal Parametro As ParametrosGlobales) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Return EjecutaConsulta(cmd).Rows(0)(CByte(Parametro))
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Sub MostrarVentana(ByVal Ventana As Form, Optional ByVal Maximizada As Boolean = True)
        For Each element As Form In frm_MENU.MdiChildren
            If element Is Ventana Then Exit Sub
            element.Close()
        Next
        If Maximizada Then
            Ventana.MdiParent = frm_MENU
            Ventana.Show()
            Ventana.WindowState = FormWindowState.Maximized
        Else
            Ventana.ShowDialog()
        End If
    End Sub

    Public Shared Function fn_Menu_Progreso(ByVal Progreso As Byte) As Boolean
        'Aqui se actualiza la barra de progreso
        Try
            frm_MENU.prg_Barra.Value = Progreso
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Sub AgregarItem(ByVal Combo As Object, ByVal Value As String, ByVal Display As String)

        If Combo.DataSource Is Nothing Then
            Combo.DataSource = New DataTable
        End If
        Dim Tbl As DataTable = Combo.DataSource
        If Tbl.Columns.Count = 0 Then
            Tbl.Columns.Add("value")
            Tbl.Columns.Add("display")
        End If
        Combo.ValueMember = "value"
        Combo.DisplayMember = "display"
        Dim Row As DataRow = Tbl.NewRow
        Row("value") = Value
        Row("display") = Display
        Tbl.Rows.Add(Row)

    End Sub

    Public Shared Function fn_OrdenaTabla(ByVal dt As DataTable, ByVal Columa_Orden As String) As DataTable
        Dim Seleccione As Boolean = False

        If dt.Rows(0)(1).ToString.ToUpper = "SELECCIONE..." Then
            Seleccione = True
            dt.Rows.RemoveAt(0)
        End If

        Dim Vista As New DataView
        Vista = dt.DefaultView
        Vista.Sort = Columa_Orden 'ColumnaAordenar Orden 
        dt = Vista.ToTable

        If Seleccione Then
            Dim dr As DataRow = dt.NewRow
            dr("Value") = "0"
            dr("Display") = "Seleccione..."
            dt.Rows.InsertAt(dr, 0)
        End If

        Return dt

    End Function

    Public Shared Function ObtenPais() As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_PaisesSucursal_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
        If Tbl.Rows.Count = 0 Then
            Return 0
        Else
            Return Tbl.Rows(0).Item(0)
        End If

    End Function

    Public Shared Sub TrataEx(ByVal Ex As Exception, Optional ByVal Mostrar_Mensaje As Boolean = True)

        If TypeOf (Ex) Is System.Data.SqlClient.SqlException Then
            Dim SqlEx As System.Data.SqlClient.SqlException = CType(Ex, System.Data.SqlClient.SqlException)
            FuncionesGlobales.fn_GuardaError(SqlEx.Procedure, SqlEx.Number, SqlEx.Message, True)

        Else
            FuncionesGlobales.fn_GuardaError(Ex.StackTrace, 0, Ex.Message, True)
        End If
        If Mostrar_Mensaje Then MsgBox("No se ha podido realizar la acción consulte a su administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
    End Sub

#End Region

    Public Enum Validar_Cadena
        Ninguno = 0
        Numeros_Enteros = 1
        Numeros_Decimales = 2
        Letras = 3
        LetrasYcaracteres = 4
        LetrasYnumeros = 5
        LetrasNumerosYCar = 6
        Porcentaje = 7
        DireccionIP = 8
    End Enum

    ''' <summary>
    ''' Sirve para llenar un combo con intervalos de minutos definidos
    ''' </summary>
    ''' <param name="Minutos">Es el numero de minutos que se van a avanzar con cada ciclo</param>
    ''' <param name="combo">es el combo que se va a llentar</param>
    Public Shared Sub LlenarMinutos(ByVal Minutos As Integer, ByVal combo As cp_cmb_Manual)
        Dim t As DateTime = #12:00:00 AM#

        While t <= #11:59:59 PM#
            combo.AgregarItem(combo.Items.Count, t.ToShortTimeString)
            t = t.AddMinutes(Minutos)
        End While

    End Sub

    Public Shared Function RegistrosNum(ByVal Label As Label, ByVal Numero As Integer) As Boolean

        Label.Text = "Registros: " & Numero.ToString

    End Function

    Public Shared Function fn_GetComputerName() As String
        fn_GetComputerName = System.Net.Dns.GetHostName
    End Function

    Public Shared Function fn_GetComputerIP() As String
        fn_GetComputerIP = ""
        Try
            Dim hostName As String = Dns.GetHostName()
            Dim host As IPHostEntry = Dns.GetHostEntry(hostName)
            'Dim firstAddress As IPAddress = host.AddressList(0)
            Dim IP As IPAddress() = host.AddressList

            Dim index As Integer

            For index = 0 To IP.Length - 1
                If IP(index).ToString.Length > 7 And IP(index).ToString.Length < 16 Then
                    fn_GetComputerIP = IP(index).ToString
                    Exit For
                End If
            Next index
        Catch

        End Try

        Return fn_GetComputerIP '= firstAddress.ToString
    End Function

    Public Shared Function fn_GetComputarMAC() As String
        Dim mc As ManagementClass
        Dim moc As ManagementObjectCollection
        Dim MACAddress As String = String.Empty
        mc = New ManagementClass("Win32_NetworkAdapterConfiguration")
        moc = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If MACAddress = String.Empty Then ' only return MAC Address from first card
                If (mo("IPEnabled") = True) Then
                    MACAddress = mo("MacAddress").ToString()
                    Exit For
                End If
            End If
            mo.Dispose()
        Next
        fn_GetComputarMAC = MACAddress 'MACAddress.Replace(":", "")
    End Function

    Public Shared Function fn_Fecha102(ByVal fe As String) As String
        If fe.Length <> 10 Then
            fn_Fecha102 = fe
        Else
            fn_Fecha102 = Right(fe, 4) + "." + Mid(fe, 4, 2) + "." + Left(fe, 2)
        End If
    End Function

    Public Shared Function fn_PonerCeros(ByVal cadena As String, ByVal longitud As Integer) As String
        Dim n As Integer
        If cadena.Length >= longitud Then
            fn_PonerCeros = cadena
        Else
            fn_PonerCeros = cadena
            For n = cadena.Length To longitud - 1
                fn_PonerCeros = "0" & fn_PonerCeros
            Next n
        End If
    End Function

    Public Shared Function fn_Columna(ByVal lsv As ListView, ByVal Uno As Integer, ByVal Dos As Integer, _
            ByVal Tres As Integer, ByVal Cuatro As Integer, ByVal Cinco As Integer, ByVal Seis As Integer, _
            ByVal Siete As Integer, ByVal Ocho As Integer, ByVal Nueve As Integer, ByVal Diez As Integer) As Boolean

        On Error Resume Next
        fn_Columna = False
        Dim Columnas As Integer
        Dim anchos(10) As Integer
        Dim CC As Integer
        anchos(1) = Uno
        anchos(2) = Dos
        anchos(3) = Tres
        anchos(4) = Cuatro
        anchos(5) = Cinco
        anchos(6) = Seis
        anchos(7) = Siete
        anchos(8) = Ocho
        anchos(9) = Nueve
        anchos(10) = Diez
        If lsv.Columns.Count > 10 Then
            Columnas = 10
        End If
        For CC = 1 To lsv.Columns.Count
            If anchos(CC) <> 0 Then
                lsv.Columns(CC - 1).Width = anchos(CC) * (lsv.Width / 100)
            Else
                lsv.Columns(CC - 1).Width = 0
            End If
        Next
        fn_Columna = True
    End Function

    Public Shared Function fn_Columna2(ByVal lsv As cp_Listview, ByVal Uno As Integer, ByVal Dos As Integer, _
            ByVal Tres As Integer, ByVal Cuatro As Integer, ByVal Cinco As Integer, ByVal Seis As Integer, _
            ByVal Siete As Integer, ByVal Ocho As Integer, ByVal Nueve As Integer, ByVal Diez As Integer) As Boolean

        On Error Resume Next
        fn_Columna2 = False
        Dim Columnas As Integer
        Dim anchos(10) As Integer
        Dim CC As Integer
        anchos(1) = Uno
        anchos(2) = Dos
        anchos(3) = Tres
        anchos(4) = Cuatro
        anchos(5) = Cinco
        anchos(6) = Seis
        anchos(7) = Siete
        anchos(8) = Ocho
        anchos(9) = Nueve
        anchos(10) = Diez
        If lsv.Columns.Count > 10 Then
            Columnas = 10
        End If
        For CC = 1 To lsv.Columns.Count
            If anchos(CC) <> 0 Then
                lsv.Columns(CC - 1).Width = anchos(CC) * (lsv.Width / 100)
            Else
                lsv.Columns(CC - 1).Width = 0
            End If
        Next
        fn_Columna2 = True
    End Function

    Public Shared Function fn_Decimales(ByVal lsv As ListView, ByVal Uno As Integer, ByVal Dos As Integer, _
            ByVal Tres As Integer, ByVal Cuatro As Integer, ByVal Cinco As Integer, ByVal Seis As Integer, _
            ByVal Siete As Integer, ByVal Ocho As Integer, ByVal Nueve As Integer, ByVal Diez As Integer) As Boolean

        On Error Resume Next
        fn_Decimales = False
        Dim Columnas As Integer
        Dim Valores(10) As Integer
        Dim CC As Integer
        Valores(1) = Uno
        Valores(2) = Dos
        Valores(3) = Tres
        Valores(4) = Cuatro
        Valores(5) = Cinco
        Valores(6) = Seis
        Valores(7) = Siete
        Valores(8) = Ocho
        Valores(9) = Nueve
        Valores(10) = Diez

        For CC = 1 To lsv.Columns.Count
            If CC = 1 Then
                If Valores(CC) = 1 Then
                    For ii As Integer = 0 To lsv.Items.Count
                        lsv.Items(ii).Text = FormatCurrency(lsv.Items(ii).Text, 2)
                    Next
                End If
            Else
                If Valores(CC) = 1 Then
                    For ii As Integer = 0 To lsv.Items.Count - 1
                        'lsv.Items(ii).SubItems(CC - 1).Text = FormatCurrency(lsv.Items(ii).SubItems(CC - 1).Text, 2)
                        lsv.Items(ii).SubItems(CC - 1).Text = FormatNumber(lsv.Items(ii).SubItems(CC - 1).Text, 2)
                    Next
                End If
            End If
        Next
        fn_Decimales = True
    End Function

    Public Shared Function fn_Decimales2(ByVal lsv As cp_Listview, ByVal Uno As Integer, ByVal Dos As Integer, _
            ByVal Tres As Integer, ByVal Cuatro As Integer, ByVal Cinco As Integer, ByVal Seis As Integer, _
            ByVal Siete As Integer, ByVal Ocho As Integer, ByVal Nueve As Integer, ByVal Diez As Integer) As Boolean

        On Error Resume Next
        fn_Decimales2 = False
        Dim Columnas As Integer
        Dim Valores(10) As Integer
        Dim CC As Integer
        Valores(1) = Uno
        Valores(2) = Dos
        Valores(3) = Tres
        Valores(4) = Cuatro
        Valores(5) = Cinco
        Valores(6) = Seis
        Valores(7) = Siete
        Valores(8) = Ocho
        Valores(9) = Nueve
        Valores(10) = Diez

        For CC = 1 To lsv.Columns.Count
            If CC = 1 Then
                If Valores(CC) = 1 Then
                    For ii As Integer = 0 To lsv.Items.Count
                        lsv.Items(ii).Text = FormatCurrency(lsv.Items(ii).Text, 2)
                    Next
                End If
            Else
                If Valores(CC) = 1 Then
                    For ii As Integer = 0 To lsv.Items.Count - 1
                        'lsv.Items(ii).SubItems(CC - 1).Text = FormatCurrency(lsv.Items(ii).SubItems(CC - 1).Text, 2)
                        lsv.Items(ii).SubItems(CC - 1).Text = FormatNumber(lsv.Items(ii).SubItems(CC - 1).Text, 2)
                    Next
                End If
            End If
        Next
        fn_Decimales2 = True
    End Function

    Public Shared Function fn_Valida_Cadena(ByVal cadena As String, ByVal tipo As Validar_Cadena) As Boolean
        Dim Ii As Integer
        Dim Car As String
        Dim Numeros As String = "0123456789"
        Dim Numeros_Dec As String = "0123456789."
        Dim Letras As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
        Dim LetrasYcar As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ .,-()@\/_*"
        Dim LetrasYnumeros As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789 "
        Dim LetrasNumerosYCar As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789 .,-()@\/_*"
        Select Case tipo
            Case 0
                Return True
            Case 1 ' Solo Numeros
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    If InStr(Numeros, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 2, 7, 8 ' Numeros Decimales
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    If InStr(Numeros_Dec, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 3 ' Solo Letras
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(Letras, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 4 ' Letras y Caracteres
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(LetrasYcar, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 5 ' Letras y numeros
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(LetrasYnumeros, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 6
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(LetrasNumerosYCar, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
        End Select
    End Function

    Public Shared Function fn_Valida_Contra(ByVal cadena As String) As Boolean
        Dim Ii As Integer
        Dim Car As String
        Dim Numeros As String = "0123456789"
        Dim Mayus As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim Minus As String = "abcdefghijklmnopqrstuvwxyz"
        Dim Cant_Numeros As Integer = 0
        Dim Cant_Mayus As Integer = 0
        Dim Cant_Minus As Integer = 0

        fn_Valida_Contra = False
        If cadena.Length < 8 Then
            Exit Function
        End If
        For Ii = 1 To cadena.Length
            Car = Mid(cadena, Ii, 1)
            If InStr(Numeros, Car) > 0 Then
                Cant_Numeros = Cant_Numeros + 1
            End If
            If InStr(Mayus, Car) > 0 Then
                Cant_Mayus = Cant_Mayus + 1
            End If
            If InStr(Minus, Car) > 0 Then
                Cant_Minus = Cant_Minus + 1
            End If
        Next Ii
        If Cant_Mayus > 0 And Cant_Minus > 0 And Cant_Numeros > 3 And (Cant_Mayus + Cant_Minus) > 3 Then
            fn_Valida_Contra = True
        Else
            fn_Valida_Contra = False
        End If

    End Function

    Public Shared Function LetrA(ByVal ch As Integer) As String
        LetrA = ""
        If ch > 64 And ch < 91 Then
            LetrA = Chr(ch) 'A - Z
        ElseIf ch > 90 And ch < 117 Then
            LetrA = Chr(64 + 1) & Chr(ch - 26) 'AA - AZ
        ElseIf ch > 116 And ch < 143 Then
            LetrA = Chr(64 + 2) & Chr(ch - 52) 'BA - BZ
        ElseIf ch > 142 And ch < 169 Then
            LetrA = Chr(64 + 3) & Chr(ch - 78) 'CA - CZ
        ElseIf ch > 168 And ch < 195 Then
            LetrA = Chr(64 + 4) & Chr(ch - 104) 'DA - DZ
        ElseIf ch > 194 And ch < 221 Then
            LetrA = Chr(64 + 5) & Chr(ch - 130) 'EA - EZ
        ElseIf ch > 220 And ch < 247 Then
            LetrA = Chr(64 + 6) & Chr(ch - 156) 'FA - FZ
        ElseIf ch > 246 And ch < 273 Then
            LetrA = Chr(64 + 7) & Chr(ch - 182) 'GA - GZ
        ElseIf ch > 272 And ch < 299 Then
            LetrA = Chr(64 + 8) & Chr(ch - 208) 'HA - HZ
        ElseIf ch > 298 And ch < 325 Then
            LetrA = Chr(64 + 9) & Chr(ch - 234) 'IA - IZ
        ElseIf ch > 324 And ch < 351 Then
            LetrA = Chr(64 + 10) & Chr(ch - 260) 'JA - JZ
        End If
    End Function

    Public Shared Function fn_ExportarExcel_Microsoft_KingSoft(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar, ByVal ObjetoHC As String) As Boolean
        'Funcion que exporta a Hoja de Cálculo de Microsoft Office y Kingsoft Office
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then
            Try
                'mandamos la cadena Objeto ya sea Microsoft o Kinsoft
                Dim objExcel = CreateObject(ObjetoHC)

                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objExcel.UserControl = True
                Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

                objExcel.SheetsInNewWorkbook = 1
                objExcel.Workbooks.Add()

                With objExcel
                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Lista.Columns(I).Text
                            End If
                            If I = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = Lista.Items(J).Text
                            Else
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = Lista.Items(J).SubItems(I).Text
                            End If
                            Bar.Value += 1
                        Next J
                    Next I
                    For n = 0 To I + 1
                        .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                    Next n
                    .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True
                    If Filas_sin_Texto > 0 Then
                        .Range("A1").Value = Titulo
                        .Range("A1").Font.Bold = True
                        .Range("A1:" & LetrA(64 + I) & "1").Merge()
                        .Selection.HorizontalAlignment = -4108
                    End If
                End With

                Bar.Value = Bar.Maximum

                fn_ExportarExcel_Microsoft_KingSoft = True
                objExcel.Visible = True
                objExcel = Nothing
                Bar.Value = 0
            Catch ex As Exception
                fn_ExportarExcel_Microsoft_KingSoft = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_ExportarExcel_Microsoft_KingSoft = False
        End If
    End Function

    Public Shared Function fn_Exportar_CalcOpenOffice(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim Cont As Integer = 0
        Dim SumLetra As String = ""

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then

            Try
                Dim objServManager As Object
                Dim objDesktop As Object
                Dim objDocument As Object '--->
                Dim objSheet1 As Object
                Dim objArguments As Object() = {} 'ok

                objServManager = CreateObject("com.sun.star.ServiceManager")
                objDesktop = objServManager.createInstance("com.sun.star.frame.Desktop")
                objDocument = objDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, objArguments)
                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objSheet1 = objDocument.Sheets.getByIndex(0)
                With objSheet1

                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                'ESCRIBE ENCABEZADOS
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).SetString(Lista.Columns(I).Text)
                            End If
                            If I = 0 Then
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).Text)
                            Else
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).SubItems(I).Text)
                            End If
                            Bar.Value += 1
                        Next J
                    Next I

                    '--PONE EN NEGRITA LOS ENCABEZADOS
                    SumLetra = "A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString
                    .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita encabezado

                    '--AJUSTA LAS COLUMNAS - AUTOFIT
                    For Cont = 0 To I - 1
                        .Columns(Cont).OptimalWidth = True
                    Next Cont

                    If Filas_sin_Texto > 0 Then
                        'TITULO EN NEGRITA CENTRADO Y CELDA COMBINADO
                        .getCellRangeByName("A1").SetString(Titulo)

                        Cont = (Lista.Columns.Count) - (Cols_Derecha_Omitir + Cols_Izquierda_Omitir)
                        SumLetra = "A1:" & LetrA(64 + Cont) & "1"

                        .getCellRangeByName(SumLetra).Merge(True) 'combina celda
                        .getCellRangeByName(SumLetra).VertJustify = 2 'centrar
                        .getCellRangeByName(SumLetra).HoriJustify = 2 ' centrar
                        .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita
                    End If
                End With

                Bar.Value = Bar.Maximum
                fn_Exportar_CalcOpenOffice = True
                objServManager = Nothing
                Bar.Value = 0

            Catch ex As Exception
                fn_Exportar_CalcOpenOffice = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_Exportar_CalcOpenOffice = False
        End If

    End Function

    Public Shared Function fn_Exporta_ListviewToExcel(ByVal Lista As ListView, ByVal RutaficheroCSV As String) As Boolean
        Try

            'Dim Fecha As String = Format(Now, "_dd-MM-yyyy")
            'Dim Hora As String = Format(Now, "_HH-mm-ss")
            Dim sb As String = ""
            Dim i As Integer = 0, j As Integer = 0
            FileOpen(1, RutaficheroCSV, OpenMode.Output)

            For Each elemento As ColumnHeader In Lista.Columns
                sb &= Trim(elemento.Text) & ";"
            Next
            PrintLine(1, sb)
            '------------
            For i = 0 To Lista.Items.Count - 1
                sb = ""
                For j = 0 To Lista.Columns.Count - 1
                    sb &= Lista.Items(i).SubItems(j).Text.Trim & ";"
                Next j
                'va imprimiendo cada linea
                PrintLine(1, sb)
            Next i

            'cerrando el archivo
            FileClose(1)
            Return True
        Catch ex As Exception
            MsgBox("error al guadar archivo: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FileClose(1)
            Return False
        End Try

    End Function

    Public Shared Function fn_Exportar_Excel(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Try
            '-----para Microsoft Office(Excel)
            Try
                ObjetoHC = "Excel.Application"
                Dim objExcel = CreateObject(ObjetoHC)
                versionHC = True
                objExcel = Nothing
                Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
            Catch ex As Exception
                versionHC = False
            End Try

            '-----para KingSoft Office (Spreadsheets) 
            If versionHC = False Then
                Try
                    ObjetoHC = "Ket.Application"
                    Dim objExcel = CreateObject(ObjetoHC)
                    versionHC = True
                    objExcel = Nothing
                    Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            '----------para Apache OpenOffice 4.0 (Calc)--
            If versionHC = False Then

                Try
                    Dim objServManager = CreateObject("com.sun.star.ServiceManager")
                    versionHC = True
                    objServManager = Nothing
                    fn_Exportar_CalcOpenOffice(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar)

                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            If versionHC = False Then
                MsgBox("No se encontró niguna paqueteria  de gestión de hoja de cálculo para la exportación de la lista, por lo tanto se procederá a guardar el archivo.", MsgBoxStyle.Exclamation, frm_MENU.Text)

                Dim svd As New SaveFileDialog
                svd.Title = "Guardar Como"
                svd.Filter = "Texto CSV (*.csv)|*.csv"
                svd.FilterIndex = 1
                svd.DefaultExt = "csv"
                svd.OverwritePrompt = True
                svd.FileName = "Reporte"
                If svd.ShowDialog = DialogResult.OK Then
                    '--en caso de que no hay paqueteria, solo guarda con .csv
                    If fn_Exporta_ListviewToExcel(Lista, svd.FileName) Then
                        versionHC = True
                        MsgBox("El archivo se ha guardado correctamente en: " & svd.FileName, MsgBoxStyle.Information, frm_MENU.Text)

                    End If
                End If
            End If
            Return versionHC

        Catch ex As Exception
            MsgBox("No se pudo exportar lista a hoja de cálculo", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End Try

    End Function

    Public Shared Function fn_Exportar_ExcelAdminpaQ(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim objExcel As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            objExcel = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                objExcel = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then
            Try
                objExcel.SheetsInNewWorkbook = 1
                objExcel.Workbooks.Add()
                With objExcel
                    If Filas_sin_Texto > 0 Then
                        'Combinar las celdas para el titulo
                        .Range("A1:" & LetrA(65 + Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) & "1").merge()
                        .Range("A1").Value = Titulo
                        .Range("A1").Font.Bold = True
                    End If
                    '.Range(LetrA(64 + I + 1) & J + Filas_sin_Texto).Value = Lista.Columns(I).Text
                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        If I = 1 Then
                            'este if es solamente para quitarle la hora a la fecha (columna 1)
                            For J = 0 To Lista.Items.Count - 1
                                If J = 0 Then
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Lista.Columns(I).Text
                                End If
                                If I = 0 Then
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).Text
                                Else
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Left(Lista.Items(J).SubItems(I).Text, 10)
                                End If
                            Next J
                        Else

                            For J = 0 To Lista.Items.Count - 1
                                If J = 0 Then
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Lista.Columns(I).Text
                                End If
                                If I = 0 Then
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).Text
                                Else
                                    .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).SubItems(I).Text
                                End If
                            Next J
                        End If
                    Next I
                    For n = 0 To I + 1
                        .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                    Next n
                    .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True
                End With

                objExcel.Visible = True
                objExcel = Nothing
                Return True
            Catch ex As Exception
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End Try
        Else
            Return True
        End If

    End Function

    Public Shared Function fn_ExportarExcelDT(ByVal Dt_Datos As DataTable, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        'Funcion que exporta a Hoja de Cálculo de Microsoft Office y Kingsoft Office
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""

        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            Dim objExcel = CreateObject(ObjetoHC)
            versionHC = True
            objExcel = Nothing
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                Dim objExcel = CreateObject(ObjetoHC)
                versionHC = True
                objExcel = Nothing
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If versionHC = False Then
            MsgBox("No se encontró ningún software de Hoja de Cálculo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Return False
        End If
        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) > Dt_Datos.Columns.Count Then
            Return False
        End If
        Try
            'mandamos la cadena Objeto ya sea Microsoft o Kinsoft
            Dim objExcel = CreateObject(ObjetoHC)

            Bar.Maximum = (Dt_Datos.Rows.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Dt_Datos.Rows.Count + 2
            Bar.Value = 0

            objExcel.UserControl = True
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

            objExcel.SheetsInNewWorkbook = 1
            objExcel.Workbooks.Add()

            With objExcel
                For I = (0 + Cols_Izquierda_Omitir) To Dt_Datos.Columns.Count - 1 - Cols_Derecha_Omitir
                    For J = 0 To Dt_Datos.Rows.Count - 1
                        If J = 0 Then
                            .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Dt_Datos.Columns(I).Caption
                        End If

                        .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Dt_Datos.Rows(J)(I)

                        Bar.Value += 1
                    Next J
                Next I
                For n = 0 To I + 1
                    .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                Next n
                .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True
                If Filas_sin_Texto > 0 Then
                    .Range("A1").Value = Titulo
                    .Range("A1").Font.Bold = True
                    .Range("A1:" & LetrA(64 + I) & "1").Merge()
                    .Selection.HorizontalAlignment = -4108
                End If
            End With

            Bar.Value = Bar.Maximum

            objExcel.Visible = True
            objExcel = Nothing
            Bar.Value = 0
            Return True
        Catch ex As Exception

            MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Bar.Value = Bar.Minimum
            Return False
        End Try
        
    End Function

    Public Shared Function fn_Buscar_enListView(ByRef Lista As ListView, ByVal cadena As String, ByVal Columna As Integer, ByVal Fila_Inicio As Integer) As Boolean
        Dim n As Integer
        Dim col As Integer

        Lista.SelectedItems.Clear()
        If Columna = 0 Then
            For n = Fila_Inicio To Lista.Items.Count - 1
                For col = 0 To Lista.Columns.Count - 1
                    If col = 0 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(col).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    End If
                Next col
            Next n
        Else
            If Columna > Lista.Columns.Count Then
                fn_Buscar_enListView = False
                Exit Function
            Else
                For n = Fila_Inicio To Lista.Items.Count - 1
                    If Columna = 1 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(Columna - 1).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    End If
                Next n
            End If
        End If
        fn_Buscar_enListView = False
    End Function

    Public Shared Function fn_BuscarYmarcar_enListView(ByRef Lista As ListView, ByVal Cadena As String, ByVal Columna As Integer, ByVal Fila_Inicio As Integer) As Boolean
        Dim n As Integer
        Dim col As Integer

        Lista.SelectedItems.Clear()
        If Columna = 0 Then
            For n = Fila_Inicio To Lista.Items.Count - 1
                For col = 0 To Lista.Columns.Count - 1
                    If col = 0 Then
                        If Lista.Items(n).Text.ToUpper = Cadena Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscarYmarcar_enListView = True
                            'Lista.Items(n).BackColor = Color.LightSteelBlue
                            Exit Function
                        End If
                    Else
                        If Lista.Items(n).SubItems(col).Text.ToUpper = Cadena Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            'Lista.Items(n).BackColor = Color.LightSteelBlue
                            fn_BuscarYmarcar_enListView = True
                            Exit Function
                        End If
                    End If
                Next col
            Next n
        Else
            If Columna > Lista.Columns.Count Then
                fn_BuscarYmarcar_enListView = False
                Exit Function
            Else
                For n = Fila_Inicio To Lista.Items.Count - 1
                    If Columna = 1 Then
                        If Lista.Items(n).Text.ToUpper = Cadena Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscarYmarcar_enListView = True
                            'Lista.Items(n).BackColor = Color.LightSteelBlue
                            Exit Function
                        End If
                    Else
                        If Lista.Items(n).SubItems(Columna - 1).Text.ToUpper = Cadena Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscarYmarcar_enListView = True
                            'Lista.Items(n).BackColor = Color.LightSteelBlue
                            Exit Function
                        End If
                    End If
                Next n
            End If
        End If
        fn_BuscarYmarcar_enListView = False
    End Function

    Public Shared Function fn_CargaLista(ByVal Consulta As String, ByVal lsw As ListView, ByVal icono As Integer, ByVal Cadena As String) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim CnN0 As New SqlConnection
        Dim CmD0 As New SqlCommand
        Dim Dr0 As SqlDataReader
        fn_CargaLista = False
        Try
            CnN0 = Cn_Datos.Crea_Conexion(Cadena)
            CmD0 = Cn_Datos.Crea_Comando(Consulta, CommandType.Text, CnN0)
            CmD0.Connection.Open()
            Dr0 = CmD0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                lsw.Columns.Add(Dr0.GetName(I))
            Next I
            indeXX = 0
            While Dr0.Read
                lsw.Items.Add(Dr0.Item(0).ToString)
                For I = 1 To Dr0.FieldCount - 1
                    lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                Next
                indeXX = indeXX + 1
            End While
            fn_CargaLista = True
            Dr0.Close()
            CmD0.Connection.Close()
            CmD0.Dispose()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            If CnN0.State = ConnectionState.Open Then
                CnN0.Close()
            End If
            CnN0.Dispose()
            CmD0.Dispose()

            fn_CargaLista = False
            Call fn_GuardaError("fn_CargarLista", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaListaCMD(ByVal Cmd0 As SqlCommand, ByVal lsw As ListView, ByVal icono As Integer) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim Dr0 As SqlDataReader
        fn_CargaListaCMD = False
        Try
            Dr0 = Cmd0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                lsw.Columns.Add(Dr0.GetName(I))
            Next I
            indeXX = 0
            While Dr0.Read
                lsw.Items.Add(Dr0.Item(0).ToString)
                For I = 1 To Dr0.FieldCount - 1
                    lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                Next
                indeXX = indeXX + 1
            End While
            fn_CargaListaCMD = True
            Dr0.Close()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            fn_CargaListaCMD = False
            Call fn_GuardaError("fn_CargarListaCMD", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaListaCMDtag(ByVal Cmd0 As SqlCommand, ByVal lsw As ListView, ByVal icono As Integer, ByVal Campo_Tag As String) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim Dr0 As SqlDataReader
        fn_CargaListaCMDtag = False
        Try

            Dr0 = Cmd0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                If Not (Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper) Then
                    lsw.Columns.Add(Dr0.GetName(I))
                End If

            Next I
            indeXX = 0
            While Dr0.Read
                If Dr0.GetName(0).ToUpper = Campo_Tag.ToUpper Then
                    lsw.Items.Add(Dr0.Item(1).ToString)
                    lsw.Items(indeXX).Tag = Dr0.Item(0).ToString
                    For I = 2 To Dr0.FieldCount - 1

                        If Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper Then

                            lsw.Items(indeXX).Tag = Dr0.Item(I).ToString

                        Else
                            If IsDate(Dr0.Item(I)) Then
                                lsw.Items(indeXX).SubItems.Add(Left(Dr0.Item(I).ToString, 10))
                            Else
                                lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                            End If


                        End If
                    Next
                Else
                    lsw.Items.Add(Dr0.Item(0).ToString)
                    For I = 1 To Dr0.FieldCount - 1
                        If Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper Then
                            lsw.Items(indeXX).Tag = Dr0.Item(I).ToString
                        Else
                            lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                        End If
                    Next
                End If
                indeXX = indeXX + 1

            End While
            fn_CargaListaCMDtag = True
            Dr0.Close()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            fn_CargaListaCMDtag = False
            Call fn_GuardaError("fn_CargarListaCMDtag", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaListaDataTableTag(ByVal dt As DataTable, ByVal lsw As ListView, ByVal icono As Integer, ByVal Campo_Tag As String) As Boolean
        Dim Item As ListViewItem
        lsw.Items.Clear()
        lsw.Columns.Clear()

        For Each lc_dc As DataColumn In dt.Columns
            If Not lc_dc.ColumnName.ToUpper = Campo_Tag.ToUpper Then lsw.Columns.Add(lc_dc.ColumnName)
        Next

        For Each lc_dr As DataRow In dt.Rows
            Item = Nothing

            For I As Integer = 0 To lc_dr.ItemArray.Count - 1

                If Campo_Tag = "" OrElse Not Campo_Tag.ToUpper = dt.Columns(I).Caption.ToUpper Then
                    If Item Is Nothing And Campo_Tag <> "" Then
                        Item = New ListViewItem(lc_dr(I).ToString) With {.Tag = lc_dr(Campo_Tag).ToString}
                    Else
                        If Item Is Nothing Then Item = New ListViewItem(lc_dr(I).ToString.Trim) Else Item.SubItems.Add(lc_dr(I).ToString.Trim)

                        If IsNumeric(lc_dr(I)) Then
                            If I > 0 Then lsw.Columns(I - 1).TextAlign = HorizontalAlignment.Right
                        Else
                            If I > 0 Then lsw.Columns(I - 1).TextAlign = HorizontalAlignment.Left
                        End If

                    End If
                End If
            Next
            lsw.Items.Add(Item)
        Next

    End Function

    Public Shared Function fn_CargaCombo(ByVal cmb As ComboBox, ByVal dt As DataTable, ByVal ValueMember As String, ByVal DisplayMember As String) As Boolean
        On Error GoTo Err_1
        Dim Ilocal As Integer
        Dim dtr As DataRow = dt.NewRow
        Dim i As Integer
        fn_CargaCombo = False
        dtr.Item(ValueMember) = "0"
        dtr.Item(DisplayMember) = "Seleccione..."

        For i = 0 To dt.Columns.Count - 1
            If dt.Columns(i).ColumnName <> DisplayMember And dt.Columns(i).ColumnName <> ValueMember Then
                If dt.Columns(i).DataType Is GetType(DateTime) Then
                    dtr.Item(i) = Today
                Else
                    dtr.Item(i) = "0"
                End If

            End If
        Next i

        cmb.ValueMember = ValueMember
        cmb.DisplayMember = DisplayMember
        dt.Rows.InsertAt(dtr, 0)
        cmb.DataSource = dt
        If cmb.Items.Count > 0 Then
            cmb.SelectedIndex = 0
        End If
        fn_CargaCombo = True
        Exit Function
Err_1:
        fn_CargaCombo = False
        MsgBox("Ocurrió el siguiente Error: " & Err.Description, MsgBoxStyle.Critical, frm_MENU.Text)
        Err.Clear()
    End Function

    Public Shared Function fn_GuardaError(ByVal Donde As String, ByVal Numero_Error As String, ByVal Descripcion As String, ByVal Enviar_Mail As Boolean) As Boolean
        On Error GoTo kk
        Dim Resu As Integer
        Dim CnN1 As New SqlConnection
        Dim CmD1 As New SqlCommand
        Dim Consulta As String
        fn_GuardaError = False
        Dim Ruta As String = My.Application.Info.DirectoryPath & "\Error.jpg"
        Dim Texto_Mail As String = ""

        SendKeys.SendWait("({PRTSC})")
        My.Computer.Clipboard.GetImage().Save(Ruta)

        CnN1 = Cn_Datos.Crea_Conexion(Cnx_Datos)
        CmD1 = Cn_Datos.Crea_Comando("Usr_Errores_Create", CommandType.StoredProcedure, CnN1)

        Cn_Datos.Crea_Parametro(CmD1, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Empleado", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(CmD1, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Cn_Datos.Crea_Parametro(CmD1, "@Version", SqlDbType.VarChar, ModuloVersion)
        Cn_Datos.Crea_Parametro(CmD1, "@Estacion", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
        Cn_Datos.Crea_Parametro(CmD1, "@Donde", SqlDbType.VarChar, donde)
        Cn_Datos.Crea_Parametro(CmD1, "@Numero_Error", SqlDbType.VarChar, numero_error)
        Cn_Datos.Crea_Parametro(CmD1, "@Descripcion", SqlDbType.VarChar, descripcion)

        Resu = Cn_Datos.EjecutarScalar(CmD1)
        If Resu > 0 Then
            fn_GuardaError = True
        Else
            fn_GuardaError = False
        End If
        CmD1.Dispose()
        CnN1.Dispose()
        If Enviar_Mail Then
            Texto_Mail = "                  Módulo: " & frm_MENU.Text & Chr(13) _
                       & "         Usuario Firmado: " & UsuarioN & Chr(13) _
                       & "                  Equipo: " & EstacioN & Chr(13) _
                       & "                   Donde: " & donde & Chr(13) _
                       & "             Descripcion: " & descripcion & Chr(13) & Chr(13) _
                       & "Agente de Servicios SIAC."
            Cn_Mail.fn_Enviar_MailFallas("!!!SIAC: Error Manejado", Texto_Mail, Ruta)
        End If
        Exit Function
kk:
        fn_GuardaError = False
    End Function

    Public Shared Function fn_GuardaBitacora(ByVal Tipo As Integer, ByVal Descripcion As String) As Boolean
        On Error GoTo kk
        Dim Resu As Integer
        Dim CnN1 As New SqlConnection
        Dim CmD1 As New SqlCommand
        Dim Consulta As String

        CnN1 = Cn_Datos.Crea_Conexion(Cnx_Datos)
        CmD1 = Cn_Datos.Crea_Comando("Usr_Bitacora_Create", CommandType.StoredProcedure, CnN1)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Usuario", SqlDbType.BigInt, UsuarioId)
        Cn_Datos.Crea_Parametro(CmD1, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Cn_Datos.Crea_Parametro(CmD1, "@Tipo", SqlDbType.Int, Tipo)
        Cn_Datos.Crea_Parametro(CmD1, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(CmD1, "@Estacion", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
        Cn_Datos.Crea_Parametro(CmD1, "@Version", SqlDbType.VarChar, ModuloVersion)

        Resu = Cn_Datos.EjecutarNonQuery(CmD1)
        If Resu > 0 Then
            fn_GuardaBitacora = True
        Else
            fn_GuardaBitacora = False
        End If
        CmD1.Dispose()
        CnN1.Dispose()
        Exit Function
kk:
        fn_GuardaBitacora = False
    End Function

    Public Shared Function fn_DatatableToHTML(ByVal dt As DataTable, ByVal Titulo As String, ByVal Cols_Omitir_Izq As Integer, ByVal Cols_Omitir_Der As Integer) As String
        '"Prueba de Correo HTML.<Br><Table><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr></Table>"
        Dim Cadena As String = ""
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0
        'Titulo
        Cadena = "<Table border=" & Chr(34) & 1 & Chr(34) & ">"
        Cadena &= "<CAPTION>"
        Cadena &= Titulo
        Cadena &= "</CAPTION>"
        'Encabezados
        Cadena &= "<thead>"
        Cadena &= "<tr>"
        Dim indice As Integer = 0
        For Each cl As DataColumn In dt.Columns
            If indice >= Cols_Omitir_Izq Then
                If indice > (dt.Columns.Count - 1 - Cols_Omitir_Der) Then Exit For
                Cadena &= "<th>"
                Cadena &= cl.Caption
                Cadena &= "</th>"
            End If
            indice += 1
        Next
        Cadena &= "</tr>"
        Cadena &= "<thead>"
        'Filas
        For Fila = 0 To dt.Rows.Count - 1
            Cadena &= "<Tr>"
            For Columna = 0 + Cols_Omitir_Izq To dt.Columns.Count - 1 - Cols_Omitir_Der
                Cadena &= "<Td>"
                Cadena &= dt.Rows(Fila)(Columna).ToString
                Cadena &= "</Td>"
            Next
            Cadena &= "</Tr>"
        Next Fila
        Cadena &= "</Table>"
        Return Cadena
    End Function

    Public Shared Function fn_ListviewToHTML(ByVal lsv As cp_Listview, ByVal Titulo As String, ByVal Cols_Omitir_Izq As Integer, ByVal Cols_Omitir_Der As Integer) As String
        '"Prueba de Correo HTML.<Br><Table><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr></Table>"
        Dim Cadena As String = ""
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0
        'Titulo
        Cadena = "<Table border=" & Chr(34) & 1 & Chr(34) & ">"
        Cadena &= "<CAPTION>"
        Cadena &= Titulo
        Cadena &= "</CAPTION>"
        'Encabezados
        Cadena &= "<thead>"
        Cadena &= "<tr>"
        Dim indice As Integer = 0
        For Each cl As ColumnHeader In lsv.Columns
            If indice >= Cols_Omitir_Izq Then
                If indice > (lsv.Columns.Count - 1 - Cols_Omitir_Der) Then Exit For
                Cadena &= "<th>"
                Cadena &= cl.Text
                Cadena &= "</th>"
            End If
            indice += 1
        Next
        Cadena &= "</tr>"
        Cadena &= "<thead>"
        'Filas
        For Each Elemento As ListViewItem In lsv.Items
            Cadena &= "<Tr>"
            For Columna = 0 + Cols_Omitir_Izq To lsv.Columns.Count - 1 - Cols_Omitir_Der
                Cadena &= "<Td>"
                Cadena &= Elemento.SubItems(Columna).Text
                Cadena &= "</Td>"
            Next
            Cadena &= "</Tr>"
        Next
        Cadena &= "</Table>"
        Return Cadena
    End Function

    Public Shared Function fn_ValidarMail(ByVal sMail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(sMail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

End Class
