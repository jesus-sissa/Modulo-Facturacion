
Imports Modulo_Facturacion.Cn_Facturacion
Imports Modulo_Facturacion.FuncionesGlobales
Imports System.Globalization
Imports System.IO


Public Class frm_PreFacturaClientes

    Private Sub frm_PreFacturaClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyValue
            Case Keys.Escape
                If btn_Cerrar.Enabled Then Me.Close()

            Case Keys.F7
                If btn_Exportar.Enabled Then btn_Exportar_Click(btn_Exportar, Nothing)
        End Select

    End Sub

    Private Sub frm_PreFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        If cmb_Status.Items.Count = 1 Then
            cmb_Status.AgregarItem("V", "VALIDADOS")
            cmb_Status.AgregarItem("A", "PENDIENTES")

            'cmb_LineadeServicio.Actualizar()
            cmb_Clientes.Actualizar()
            cmb_Status.SelectedValue = "V"
            Cmb_Grupo.Actualizar()
            Chk_Grupo.Checked = True
            Chk_Grupo.Enabled = False
        End If


    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_Clientes.Focus()
    End Sub

    Private Sub Chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Grupo.CheckedChanged
        Cmb_Grupo.SelectedValue = "0"
        Cmb_Grupo.Enabled = Not Chk_Grupo.Checked
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_Sucursales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Sucursales.CheckedChanged
        SegundosDesconexion = 0
        If chk_Sucursales.Checked Then
            Chk_Grupo.Enabled = True
            Chk_Grupo.Checked = False
        Else
            Chk_Grupo.Checked = True
            Chk_Grupo.Enabled = False
        End If
    End Sub

    Private Sub cmb_Clientes_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.EnabledChanged
        tbx_Clientes.Enabled = cmb_Clientes.Enabled
        chk_Sucursales.Enabled = cmb_Clientes.Enabled
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        cmb_Clientes.Enabled = Not chk_Todos.Checked
        tbx_Clientes.Enabled = Not chk_Todos.Checked
        chk_Sucursales.Checked = False
        chk_Sucursales.Enabled = Not chk_Todos.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        'Call ExportarPorCS()
        Call ExportarCompleto()
    End Sub

    Private Sub btn_ImpLavado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpLavado.Click
        SegundosDesconexion = 0
        Call ExportarLavado()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

#Region "Funciones Privadas"

    Public Structure Facturacion
        Public Clave As String
        Public Cliente As String
        Public CantidadTraslados As Integer
        Public ImporteTrasladado As Decimal
        Public MilesTrasladados As Integer
        Public EnvasesTrasladados As Integer
        Public KilometrosRec As Integer
        Public CobroXTraslado As Decimal
        Public CobroXMiles As Decimal
        Public CobroXKilometros As Decimal
        Public CobroXCajaFuerte As Decimal
        Public CobroXProceso As Decimal
        Public CobroXPernoctas As Decimal
        Public CobroXMateriales As Decimal
        Public TotalACobrar As Decimal
    End Structure

    Public Function Validar() As Boolean
        If cmb_Clientes.Enabled And cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Return False
        End If

        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Return False
        End If

        Return True
    End Function

    Public Class ConceptosProceso
        Public Property Nombre As String
        Public Property Importe As Double
        Public Property Clave As String


        Public ConceptosLista As List(Of ConceptosProceso)
        Public Sub New()
            ConceptosLista = New List(Of ConceptosProceso)()
        End Sub
    End Class

    Sub ExportarCompleto()
        If Not Validar() Then Exit Sub

        Dim listaConceptos As New List(Of String)()
        Dim PrecioConceptos As New List(Of ConceptosProceso)()

        Dim Padres As DataTable
        Dim Hijos As DataTable
        Dim Prefactura As DataTable
        Dim Pernoctas As DataTable
        Dim book As Object
        Dim sheet As Object
        Dim PrimerHoja As Boolean = True
        Dim Misma As Boolean = False
        Dim FolioAnterior As Long
        Dim PrecioAnterior As Long
        Dim CSAnterior As Long
        Dim Indice As Integer = 2
        Dim Path As String
        Dim NombreArchivo As String = ""
        Dim Clave_Linea As String = ""
        Dim Miles, Servicios, Envases, EnvasesE, Kilometros, Sobres, Importe As Decimal
        Dim HayEE As Boolean = False
        Dim HayKM As Boolean = False
        Dim HaySobres As Boolean = False
        Dim CVMostrados As Boolean = False
        Dim TotalGral As Decimal = 0
        Dim RemisionAnterior As Long = 0
        Dim TotalImporteTraslado As Decimal = 0 'Total de todo lo trasladado
        Dim TotalImportePorTV As Decimal = 0 'Total por cada código de TV

        Dim cuenta As Integer = 0

        Dim TotalMilesT As Integer = 0
        Dim TotalTraslados As Integer = 0
        Dim TotalEnvasesT As Integer = 0
        Dim TotalKilometros As Integer = 0

        Dim CobroXTraslado As Decimal = 0
        Dim CobroXMiles As Decimal = 0
        Dim CobroXKm As Decimal = 0

        Dim Subtotal As Decimal = 0
        Dim subTotalaCobrar As Decimal = 0
        Dim PrecioCR As Decimal = 0
        Dim PrecioCServ As Decimal = 0
        Dim PrecioKM As Decimal = 0

        Dim TotalFilas As Integer = 0

        Dim ArrayFact() As Facturacion
        Try
            '----------- logo d elña empresa
            Dim ds As New ds_DatosEmpresa
            Call fn_DatosEmpresa_LlenarDataSet(ds)

            If Not IsDBNull(ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then
                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = ds.Tbl_DatosEmpresa.Rows(0)("logo")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                If IO.File.Exists(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg") Then
                    File.Delete(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
                End If
                imagenNueva.Save(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
            End If
            '----------------------

            'If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\LogoSISSA.jpg") Then
            '    My.Resources.LogoSISSA.Save(My.Application.Info.DirectoryPath & "\LogoSISSA.jpg")
            'End If
        Catch


        End Try
        Padres = Cn_Facturacion.fn_PreFactura_GetPadres(cmb_Clientes.SelectedValue)

        If Padres Is Nothing Then Exit Sub 'salir si ocurrio error
        If Padres.Rows.Count = 0 Then Exit Sub 'salir si no hay registros
        'Aquí se cargan los datos de la Sucursal
        Dim dt_Sucursal As DataTable = Modulo_Facturacion.Cn_Facturacion.fn_PreFactura_ObtenerDatosSucursal()
        If dt_Sucursal Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar obtener los datos de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Path = fbd.SelectedPath
        If Path.Length = 3 Then
            Path = Microsoft.VisualBasic.Left(Path, 2)
        End If

        pgb.Maximum = Padres.Rows.Count * 100

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
        Dim Suma As String = ""

        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            xls = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                xls = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If versionHC = False Then
            MsgBox("No se encontró un software de Hoja de Cálculo para poder generar la prefactura.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        '-----------------------------------------
        For Each Padre As DataRow In Padres.Rows

            'Inicializando variables
            Miles = 0
            Servicios = 0
            Envases = 0
            EnvasesE = 0
            Kilometros = 0
            Importe = 0
            Sobres = 0
            HayEE = False
            HayKM = False
            HaySobres = False
            TotalGral = 0
            TotalImportePorTV = 0
            '-----------------
            cuenta = 0 'new
            '--------------------
            xls.SheetsInNewWorkbook = 1
            book = xls.Workbooks.Add()

            '-----------------------
            If chk_Sucursales.Checked = True Or chk_Todos.Checked = True Then
                'se selecciona él mismo y a sus subclientes
                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), True, cmb_Status.SelectedValue, Cmb_Grupo.SelectedValue)
            Else
                'se agarra solo a él mismo sin incluir los subclientes
                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), False, cmb_Status.SelectedValue, Cmb_Grupo.SelectedValue)
            End If
            '---------
            TotalFilas = Hijos.Rows.Count - 1
            'ReDim ArregloFact(TotalFilas, 14) '
            ReDim ArrayFact(TotalFilas)
            '----------
            For Each Hijo As DataRow In Hijos.Rows 'For para hijos...

                PrecioAnterior = 0
                CSAnterior = 0
                Importe = 0
                Indice = 1
                '-----------------
                TotalMilesT = 0
                TotalTraslados = 0
                TotalEnvasesT = 0
                TotalKilometros = 0
                CobroXKm = 0
                CobroXMiles = 0
                CobroXTraslado = 0
                Subtotal = 0
                subTotalaCobrar = 0
                '-*---------------
                PrecioCR = 0
                PrecioCServ = 0
                TotalImporteTraslado = 0
                TotalImportePorTV = 0
                If Not PrimerHoja Then
                    If Not Misma Then
                        sheet = book.Sheets.Add()
                    End If
                Else
                    sheet = book.Sheets(1)
                End If

                '14/04/2014 lunes ------
                If sheet.name = "Sheet1" Then Suma = "=Sum" Else Suma = "=Sum"

                PrimerHoja = False
                Try
                    sheet.Name = Hijo("Clave")
                Finally
                End Try

                sheet.Cells.Font.Name = "Arial"

                sheet.Range("A1:I1").Merge()
                'Logo
                sheet.Shapes.AddPicture(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg", False, True, 0, 0, 40, 40)
                'Fin Logo

                sheet.Range("A1:I1").Value = dt_Sucursal.Rows(0)("Nombre")
                sheet.Range("A1:I1").Font.Bold = True
                sheet.Range("A1:I1").Font.Size = 11
                sheet.Range("A1:I1").HorizontalAlignment = -4108

                'sheet.Range("A2:K2").Merge()
                'sheet.Range("A2:K2").Value = dt_Sucursal.Rows(0)("Direccion")
                'sheet.Range("A2:K2").Font.Bold = True
                'sheet.Range("A2:K2").Font.Size = 10
                'sheet.Range("A2:K2").HorizontalAlignment = -4108

                sheet.Range("A1").ColumnWidth = 9
                sheet.Range("B1").ColumnWidth = 13
                sheet.Range("C1").ColumnWidth = 15
                sheet.Range("D1").ColumnWidth = 8
                sheet.Range("E1").ColumnWidth = 10
                sheet.Range("F1").ColumnWidth = 7
                sheet.Range("G1").ColumnWidth = 8
                sheet.Range("H1").ColumnWidth = 8
                sheet.Range("I1").ColumnWidth = 11
                sheet.Range("J1").ColumnWidth = 6

                sheet.Range("A2:I2").Merge()
                sheet.Range("A2:I2").Value = Hijo("Clave") & " " & Hijo("Cliente")
                ArrayFact(cuenta).Clave = Hijo("Clave") ''agrega la clave
                ArrayFact(cuenta).Cliente = Hijo("Cliente") ''agrega cliente
                sheet.Range("A2:I2").Font.Bold = True
                sheet.Range("A2:I2").Font.Size = 10
                sheet.Range("A2:I2").HorizontalAlignment = -4108

                '**********************************
                'MOVIMIENTOS DE TRASLADO DE VALORES
                '**********************************
                Prefactura = Cn_Facturacion.fn_PreFactura_GetReporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
                CVMostrados = False
                CSAnterior = -1

                If Prefactura.Rows.Count > 0 Then
                    'Indice += 2

                    ''Descripción de la Linea
                    'sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    'sheet.Range("A" & Indice).Value = "TRASLADO DE VALORES"
                    'sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 10
                    'sheet.Range("A" & Indice & ":L" & Indice).Font.Bold = True
                    'sheet.Range("A" & Indice).RowHeight = 15
                    'sheet.Range("A" & Indice).WrapText = True

                    Indice += 1
                    '---------------------------------------------------------------------
                    For Each row As DataRow In Prefactura.Rows
                        Clave_Linea = Microsoft.VisualBasic.Left(row("Linea"), 3) 'Obtiene la clave para saber que es ejem: TV
                        If CSAnterior <> row("Id_CS") Then
                            If Indice > 5 Then
                                'TOTALES

                                sheet.Range("B" & Indice).Value = "TOTAL"
                                sheet.Range("C" & Indice).Value = TotalImportePorTV
                                sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                                sheet.Range("D" & Indice).Value = Miles
                                sheet.Range("E" & Indice).Value = Servicios
                                sheet.Range("F" & Indice).Value = Envases
                                'sheet.Range("G" & Indice).Value = EnvasesE
                                sheet.Range("G" & Indice).Value = Kilometros
                                sheet.Range("I" & Indice).Value = Importe
                                sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                                sheet.Range("B" & Indice & ":I" & Indice).Font.Bold = True
                                sheet.Range("B" & Indice & ":I" & Indice).Font.Italic = True
                                sheet.Range("B" & Indice & ":I" & Indice).Font.Size = 10

                                TotalGral += Importe

                                If EnvasesE > 0 Then HayEE = True
                                If Kilometros > 0 Then HayKM = True
                                If Sobres > 0 Then HaySobres = True
                                '-----------------------------------
                                '*********************
                                TotalMilesT += Miles
                                TotalTraslados += Servicios
                                TotalEnvasesT += Envases
                                TotalKilometros += Kilometros
                                '*****************
                                Subtotal = PrecioCR * Miles
                                CobroXMiles += Subtotal

                                If Clave_Linea = "SCF" Then
                                    CobroXTraslado = PrecioCServ
                                Else
                                    Subtotal = PrecioCServ * Servicios
                                    CobroXTraslado += Subtotal
                                End If

                                Subtotal = PrecioKM * Kilometros
                                CobroXKm += CobroXKm
                                '-----------------------------------
                                Miles = 0
                                Servicios = 0
                                Envases = 0
                                EnvasesE = 0
                                Kilometros = 0
                                Importe = 0
                                Sobres = 0
                                TotalImportePorTV = 0

                            End If

                            Indice += 1

                            sheet.Range("D" & Indice).Value = "PrecioCR"
                            sheet.Range("E" & Indice).Value = "Precio"
                            'sheet.Range("G" & Indice).Value = "PrecioEE"
                            sheet.Range("G" & Indice).Value = "PrecioKM"
                            sheet.Range("D" & Indice & ":I" & Indice).Font.Bold = True
                            sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
                            sheet.Range("D" & Indice & ":I" & Indice).HorizontalAlignment = -4108

                            Indice += 1

                            'precios
                            sheet.Range("A" & Indice & ":C" & Indice).Merge()
                            'If row("Linea2") <> "" Then
                            '    sheet.Range("A" & Indice).Value = row("Linea") & "(" & row("Linea2") & ")"
                            'Else
                            sheet.Range("A" & Indice).Value = row("Linea") 'escribe descripcion tv,extraordinario ,morralla etc
                            'End If
                            sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 9
                            sheet.Range("A" & Indice & ":D" & Indice).HorizontalAlignment = -4108
                            sheet.Range("A" & Indice).RowHeight = 15
                            sheet.Range("A" & Indice).WrapText = True


                            sheet.Range("D" & Indice).Value = row("PrecioCR") 'tomar este precioCR (miles)*************
                            sheet.Range("E" & Indice).Value = row("Precio") ' este precio (Cantidad servicio)***********
                            'sheet.Range("G" & Indice).Value = row("PrecioEE")
                            sheet.Range("G" & Indice).Value = row("PrecioKM")

                            PrecioCR = row("PrecioCR") 'almacenamos precio a utilizar en calculos
                            PrecioCServ = row("Precio")
                            PrecioKM = row("PrecioKM")
                            sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
                            sheet.Range("D" & Indice & ":I" & Indice).NumberFormat = "$#,##0.00"

                            Indice += 1

                            'cabecera de la tabla
                            sheet.Range("A" & Indice).Value = "Folio Servicio"
                            sheet.Range("B" & Indice).Value = "Fecha"
                            sheet.Range("C" & Indice).Value = "Importe Traslado"
                            sheet.Range("D" & Indice).Value = "Miles"
                            sheet.Range("E" & Indice).Value = "Cantidad Servicios"
                            sheet.Range("F" & Indice).Value = "Envases"
                            'sheet.Range("G" & Indice).Value = "Envases Exceso"
                            sheet.Range("G" & Indice).Value = "Km"
                            sheet.Range("H" & Indice).Value = "Hora Remision"
                            sheet.Range("I" & Indice).Value = "Importe"

                            sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                            sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                            sheet.Range("A" & Indice & ":I" & Indice).WrapText = True

                            Indice += 1

                            PrecioAnterior = row("Id_Precio")
                            CSAnterior = row("Id_CS")
                        End If

                        If FolioAnterior <> row("Folio_Servicio") Then 'cuando es nuevo folio aquii va
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 10
                            sheet.Range("A" & Indice).Value = row("Folio_Servicio")
                            'sheet.Range("B" & Indice).NumberFormat = "dd/mm/yyyy"
                            'Dim fechaConvertida As DateTime = DateTime.ParseExact(row("Fecha").ToString, "MM/dd/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None)
                            Dim _fecha As String = Format(CDate(row("Fecha")), "MM/dd/yyyy")
                            sheet.Range("B" & Indice).Value = _fecha 'CStr(row("Fecha"))
                            sheet.Range("C" & Indice).Value = row("Importe_Traslado") 'total import Tras
                            TotalImporteTraslado += row("Importe_Traslado") 'VA sumando importe trasladado
                            TotalImportePorTV += row("Importe_Traslado") 'VA sumando importe trasladado
                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                            sheet.Range("D" & Indice).Value = row("Miles")
                            sheet.Range("E" & Indice).Value = 1
                            sheet.Range("F" & Indice).Value = row("Envases")
                            'sheet.Range("G" & Indice).Value = row("Envases_Exceso")
                            sheet.Range("G" & Indice).Value = row("Kilometros")

                            If Clave_Linea = "SCF" Then
                                sheet.Range("I" & Indice).Value = 0
                            Else
                                sheet.Range("I" & Indice).Value = row("Importe")
                            End If

                            sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"

                            If row("Id_ComprobanteV") > 0 Then
                                sheet.Range("J" & Indice).Value = "**C.V.**"
                            End If

                            Miles += row("Miles")
                            Servicios += 1
                            Envases += row("Envases")
                            EnvasesE += row("Envases_Exceso")
                            If EnvasesE > 0 Then HayEE = True

                            Kilometros += row("Kilometros")
                            If Kilometros > 0 Then HayKM = True

                            If Clave_Linea = "SCF" Then 'aki meter codigo cuanto es fijo SCF
                                Importe = row("Precio")
                            Else
                                Importe += row("Importe")
                            End If

                            Indice += 1
                            sheet.Range("A" & Indice & ":J" & Indice).Font.size = 8
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
                            sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
                            sheet.Range("C" & Indice).Value = row("Importe_Remision")
                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                            sheet.Range("F" & Indice).Value = row("Envases_Remision")
                            sheet.Range("H" & Indice).Value = row("Hora_Remision")
                            Indice += 1
                            FolioAnterior = row("Folio_Servicio")
                        Else
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 8
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
                            sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
                            sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
                            sheet.Range("C" & Indice).Value = row("Importe_Remision")
                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                            sheet.Range("F" & Indice).Value = row("Envases_Remision")
                            sheet.Range("H" & Indice).Value = row("Hora_Remision")
                            Indice += 1
                        End If

                    Next
                    '-------------------------------------------------------------------------------
                    sheet.Range("B" & Indice).Value = "TOTAL" ' imprime ya totales de clave linea (tv)
                    sheet.Range("C" & Indice).Value = TotalImportePorTV
                    sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("D" & Indice).Value = Miles
                    sheet.Range("E" & Indice).Value = Servicios
                    sheet.Range("F" & Indice).Value = Envases
                    sheet.Range("G" & Indice).Value = Kilometros
                    '*********************
                    TotalMilesT += Miles
                    TotalTraslados += Servicios
                    TotalEnvasesT += Envases
                    TotalKilometros += Kilometros
                    '*****************
                    Subtotal = PrecioCR * Miles
                    CobroXMiles += Subtotal
                    If Clave_Linea = "SCF" Then
                        CobroXTraslado = PrecioCServ
                    Else
                        Subtotal = PrecioCServ * Servicios
                        CobroXTraslado += Subtotal
                    End If

                    Subtotal = PrecioKM * Kilometros
                    CobroXKm += CobroXKm
                    ArrayFact(cuenta).CantidadTraslados = TotalTraslados
                    ArrayFact(cuenta).ImporteTrasladado = TotalImporteTraslado
                    ArrayFact(cuenta).MilesTrasladados = TotalMilesT
                    ArrayFact(cuenta).EnvasesTrasladados = TotalEnvasesT
                    ArrayFact(cuenta).KilometrosRec = TotalKilometros
                    ArrayFact(cuenta).CobroXTraslado = CobroXTraslado
                    ArrayFact(cuenta).CobroXMiles = CobroXMiles
                    ArrayFact(cuenta).CobroXKilometros = CobroXKm

                    '****************************
                    'sheet.Range("G" & Indice).Value = EnvasesE
                    'sheet.Range("J" & Indice).Value = Sobres

                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Size = 10
                Else
                    'si no hay nada entra aki 8/11/2012--**********************
                    'Si no tine Movimientos de Traslado

                    'Indice += 2

                    ''Descripción de la Linea
                    'sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    'sheet.Range("A" & Indice).Value = "TRASLADO DE VALORES"
                    'sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 10
                    'sheet.Range("A" & Indice & ":L" & Indice).Font.Bold = True
                    'sheet.Range("A" & Indice).RowHeight = 15
                    'sheet.Range("A" & Indice).WrapText = True

                    Indice += 4

                    'cabecera de la tabla
                    sheet.Range("A" & Indice).Value = "Folio Servicio"
                    sheet.Range("B" & Indice).Value = "Fecha"
                    sheet.Range("C" & Indice).Value = "Importe Traslado"
                    sheet.Range("D" & Indice).Value = "Miles"
                    sheet.Range("E" & Indice).Value = "Cantidad Servicios"
                    sheet.Range("F" & Indice).Value = "Envases"
                    'sheet.Range("G" & Indice).Value = "Envases Exceso"
                    sheet.Range("G" & Indice).Value = "Km"
                    sheet.Range("H" & Indice).Value = "Hora Remision"
                    sheet.Range("I" & Indice).Value = "Importe"

                    sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).WrapText = True

                    Indice += 1

                    'Totales de la Línea en cero
                    '-------------------------------------------------
                    'alcenar la estructura array --vacios

                    ArrayFact(cuenta).CantidadTraslados = 0
                    ArrayFact(cuenta).ImporteTrasladado = 0
                    ArrayFact(cuenta).MilesTrasladados = 0
                    ArrayFact(cuenta).EnvasesTrasladados = 0
                    ArrayFact(cuenta).KilometrosRec = 0
                    ArrayFact(cuenta).CobroXTraslado = 0
                    ArrayFact(cuenta).CobroXMiles = 0
                    ArrayFact(cuenta).CobroXKilometros = 0

                    '-------------------------------------------------
                    sheet.Range("B" & Indice).Value = "TOTAL"
                    sheet.Range("C" & Indice).Value = TotalImportePorTV
                    sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("B" & Indice & ":I" & Indice).Font.Size = 10
                End If

                TotalGral += Importe

                'resetea las variables para volever a usarlos 
                Miles = 0
                Servicios = 0
                Envases = 0
                EnvasesE = 0
                Kilometros = 0
                Importe = 0
                Sobres = 0
                TotalImportePorTV = 0

                HayEE = False
                HayKM = False
                HaySobres = False

                '**********************************
                'FIN TRASLADO DE VALORES
                '**********************************


                '**********************************
                'INICIO PERNOCTAS
                '**********************************
                Pernoctas = Cn_Facturacion.fn_PreFactura_GetPernoctas(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), "V")
                If Pernoctas IsNot Nothing AndAlso Pernoctas.Rows.Count > 0 Then
                    Indice += 2

                    sheet.Range("A" & Indice & ":J" & Indice).Borders(8).LineStyle = 9
                    sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    sheet.Range("A" & Indice).Value = "PERNOCTAS" 'row("Linea")
                    sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":L" & Indice).Font.Bold = True
                    sheet.Range("A" & Indice).RowHeight = 15
                    sheet.Range("A" & Indice).WrapText = True

                    Indice += 1

                    'cabecera de la tabla
                    sheet.Range("B" & Indice).Value = "Remision"
                    sheet.Range("C" & Indice).Value = "Fecha"
                    sheet.Range("F" & Indice).Value = "Miles"
                    sheet.Range("G" & Indice).Value = "Precio Dia"
                    sheet.Range("I" & Indice).Value = "Importe"
                    sheet.Range("A" & Indice & ":I" & Indice).WrapText = True


                    sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10

                    For Each row As DataRow In Pernoctas.Rows
                        Indice += 1
                        'valores del detalle
                        sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 9
                        sheet.Range("B" & Indice).Value = row("Remision")
                        sheet.Range("C" & Indice).Value = row("Fecha")
                        sheet.Range("F" & Indice).Value = row("Miles")
                        sheet.Range("G" & Indice).Value = row("Precio")
                        sheet.Range("I" & Indice).Value = row("Precio") * row("Miles")
                        sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"

                        Importe += (row("Precio") * row("Miles"))

                    Next

                    Indice += 1
                    sheet.Range("C" & Indice).Value = "TOTAL"
                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Size = 10

                    ArrayFact(cuenta).CobroXPernoctas = Importe

                    TotalGral += Importe

                    Importe = 0
                Else
                    ArrayFact(cuenta).CobroXPernoctas = 0

                End If

                '**********************************
                'FIN PERNOCTAS
                '**********************************


                '**********************************
                'INICIO CAJAS FUERTES
                '**********************************

                Prefactura = Cn_Facturacion.fn_PreFactura_GetCajasFuertes(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), "V")
                If Prefactura IsNot Nothing AndAlso Prefactura.Rows.Count > 0 Then

                    Indice += 2

                    sheet.Range("A" & Indice & ":I" & Indice).Borders(8).LineStyle = 9
                    sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    sheet.Range("A" & Indice).Value = "CAJAS FUERTES"
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("A" & Indice).RowHeight = 15
                    sheet.Range("A" & Indice).WrapText = True

                    Indice += 1

                    'cabecera de la tabla
                    sheet.Range("A" & Indice).Value = "Fecha"
                    sheet.Range("B" & Indice).Value = "Concepto"
                    sheet.Range("I" & Indice).Value = "Importe"

                    sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).WrapText = True

                    For Each row As DataRow In Prefactura.Rows
                        Clave_Linea = Microsoft.VisualBasic.Left(row("Linea"), 3)

                        Indice += 1

                        'valores del detalle
                        sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 9
                        sheet.Range("A" & Indice).Value = row("Fecha")
                        sheet.Range("B" & Indice & ":E" & Indice).Merge()
                        sheet.Range("B" & Indice).Value = row("Descripcion")
                        sheet.Range("I" & Indice).Value = row("Precio")
                        sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"

                        Importe += row("Precio")

                    Next
                    Indice += 1
                    sheet.Range("C" & Indice).Value = "TOTAL"
                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Size = 10

                    ArrayFact(cuenta).CobroXCajaFuerte = Importe
                    TotalGral += Importe
                    Importe = 0
                Else
                    ArrayFact(cuenta).CobroXCajaFuerte = 0
                End If

                '**********************************
                'FIN CAJAS FUERTES
                '**********************************


                '**********************************
                'INICIO PROCESO
                '**********************************

                Dim ConceptoAnterior As Integer = 0
                Dim dt_Formula As DataTable
                Dim ConceptosProceso As DataTable = Cn_Facturacion.fn_PreFactura_ProcesoObtenerConceptos(Hijo("Id_Cliente"), "A")
                If ConceptosProceso IsNot Nothing AndAlso ConceptosProceso.Rows.Count > 0 Then
                    Indice += 2

                    sheet.Range("A" & Indice & ":I" & Indice).Borders(8).LineStyle = 9
                    sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    sheet.Range("A" & Indice).Value = "PROCESO"
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("A" & Indice).RowHeight = 15
                    sheet.Range("A" & Indice).WrapText = True

                    Indice += 1

                    'cabecera de la tabla
                    sheet.Range("A" & Indice & ":D" & Indice).Merge()
                    sheet.Range("A" & Indice).Value = "Concepto"
                    sheet.Range("G" & Indice).Value = "Cantidad"
                    sheet.Range("H" & Indice).Value = "Precio"
                    sheet.Range("I" & Indice).Value = "Importe"

                    sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).WrapText = True

                    For Each Concepto As DataRow In ConceptosProceso.Rows
                        'Brandon Ibarra 2/11/2023
                        'Este if guarda los conceptos diferentes con sus precios en caso que se repitan para poder crear las columnas en el resumen de facturacion
                        If Not listaConceptos.Contains((Concepto("Descripcion") + (Concepto("Precio")).ToString()).ToString()) Then
                            listaConceptos.Add((Concepto("Descripcion") + (Concepto("Precio")).ToString()).ToString())
                        End If
                        If ConceptoAnterior <> Concepto("Id_Concepto") Then
                            Indice += 1
                            sheet.Range("A" & Indice & ":D" & Indice).Merge()
                            sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 9
                            sheet.Range("A" & Indice).Value = Concepto("Descripcion")
                            ConceptoAnterior = Concepto("Id_Concepto")
                        End If
                        dt_Formula = fn_PreFactura_ProcesoEjecutarFormula(Hijo("Id_Cliente"), dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Concepto("Formula"))
                        If dt_Formula IsNot Nothing Then
                            If dt_Formula.Rows.Count > 0 Then
                                sheet.Range("G" & Indice).Value = dt_Formula.Rows(0)("Cantidad")
                                sheet.Range("H" & Indice).Value = Concepto("Precio")
                                'Brandon Ibarra 2/11/2023
                                'Las siguentes 7 lineas de codigo guardan los conceptos con su clave y su importe en una lista para despues agregarlos mas abajo 
                                Dim Llenado As New ConceptosProceso
                                With Llenado
                                    .Clave = Hijo("Clave").ToString()
                                    .Nombre = Concepto("Descripcion") + (Concepto("Precio")).ToString()
                                    .Importe = dt_Formula.Rows(0)("Cantidad") * Concepto("Precio")
                                End With
                                PrecioConceptos.Add(Llenado)
                                Importe += dt_Formula.Rows(0)("Cantidad") * Concepto("Precio")
                                sheet.Range("I" & Indice).Value = dt_Formula.Rows(0)("Cantidad") * Concepto("Precio")
                                sheet.Range("G" & Indice & ":I" & Indice).NumberFormat = "#,##0.00"
                            Else
                                sheet.Range("G" & Indice).Value = "0.00"
                            End If
                        End If
                    Next
                    Indice += 1
                    sheet.Range("C" & Indice).Value = "TOTAL"
                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Size = 10

                    ArrayFact(cuenta).CobroXProceso = Importe
                    TotalGral += Importe
                    Importe = 0
                Else
                    ArrayFact(cuenta).CobroXProceso = 0
                End If

                '**********************************
                'FIN PROCESO
                '**********************************


                '**********************************
                'INICIO MATERIALES
                '**********************************
                Prefactura = Cn_Facturacion.fn_PreFactura_GetMateriales(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), "EM")

                If Prefactura IsNot Nothing AndAlso Prefactura.Rows.Count > 0 Then
                    Indice += 2

                    sheet.Range("A" & Indice & ":I" & Indice).Borders(8).LineStyle = 9
                    sheet.Range("A" & Indice & ":C" & Indice).Merge()
                    sheet.Range("A" & Indice).Value = "MATERIALES"
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("A" & Indice).RowHeight = 15
                    sheet.Range("A" & Indice).WrapText = True

                    Indice += 1

                    'cabecera de la tabla
                    sheet.Range("A" & Indice).Value = "Número Remisión"
                    sheet.Range("B" & Indice).Value = "Fecha"
                    sheet.Range("C" & Indice).Value = "Material"
                    sheet.Range("G" & Indice).Value = "Cantidad"
                    sheet.Range("H" & Indice).Value = "Precio"
                    sheet.Range("I" & Indice).Value = "Importe"

                    sheet.Range("A" & Indice & ":I" & Indice).Font.Underline = True
                    sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 10
                    sheet.Range("A" & Indice & ":I" & Indice).WrapText = True

                    For Each row As DataRow In Prefactura.Rows

                        Indice += 1
                        If RemisionAnterior <> row("Numero_Remision") Then
                            sheet.Range("A" & Indice).Value = row("Numero_Remision")
                            sheet.Range("B" & Indice).Value = row("Fecha")

                            sheet.Range("A" & Indice & ":B" & Indice).Font.Size = 9
                        End If

                        sheet.Range("C" & Indice & ":E" & Indice).Merge()
                        sheet.Range("C" & Indice).Value = row("Material")
                        sheet.Range("G" & Indice).Value = row("Cantidad")
                        sheet.Range("H" & Indice).Value = row("Precio")
                        sheet.Range("I" & Indice).Value = row("Importe")
                        sheet.Range("G" & Indice).NumberFormat = "#,##0"
                        sheet.Range("H" & Indice).NumberFormat = "#,##0.00"
                        sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"

                        sheet.Range("A" & Indice & ":I" & Indice).Font.Size = 9

                        Importe += row("Importe")
                        RemisionAnterior = row("Numero_Remision")
                    Next

                    Indice += 1

                    sheet.Range("C" & Indice).Value = "TOTAL"

                    sheet.Range("I" & Indice).Value = Importe
                    sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Bold = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Italic = True
                    sheet.Range("C" & Indice & ":I" & Indice).Font.Size = 10

                    ArrayFact(cuenta).CobroXMateriales = Importe
                    TotalGral += Importe
                    Importe = 0
                Else
                    ArrayFact(cuenta).CobroXMateriales = 0
                    'Indice += 1

                    'sheet.Range("C" & Indice).Value = "TOTAL"

                    'sheet.Range("K" & Indice).Value = Importe
                    'sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
                    'sheet.Range("C" & Indice & ":K" & Indice).Font.Bold = True
                    'sheet.Range("C" & Indice & ":K" & Indice).Font.Italic = True
                End If
                '**********************************
                'FIN MATERIALES
                '**********************************

                Indice += 2

                sheet.Range("F" & Indice & ":I" & Indice).Font.Size = 10
                sheet.Range("F" & Indice & ":H" & Indice).Merge()
                sheet.Range("F" & Indice).Value = "TOTAL GENERAL"
                sheet.Range("I" & Indice).Value = TotalGral
                sheet.Range("I" & Indice).NumberFormat = "$#,##0.00"
                sheet.Range("G" & Indice & ":I" & Indice).Font.Bold = True
                sheet.Range("G" & Indice & ":I" & Indice).Font.Italic = True

                sheet.Range("F" & Indice & ":I" & Indice).Borders(9).LineStyle = 9
                sheet.Range("F" & Indice & ":I" & Indice).Borders.Value = True

                If Hijo("Status") = "B" And TotalGral = 0 Then
                    'hoja = book.sheets(Hijo("Clave"))
                    'hoja.delete()
                    sheet.Range("A1" & ":I" & Indice).Value = ""
                    sheet.Range("A1" & ":I" & Indice).Borders.Value = False
                    sheet.Range("A1" & ":I" & Indice).Font.Bold = False
                    sheet.Range("A1" & ":I" & Indice).Font.Italic = False
                    For ff As Integer = 1 To 100
                        sheet.Range("A" & ff & ":I" & ff).unMerge()
                    Next ff
                    Misma = True
                Else
                    Misma = False
                    sheet.PageSetup.PrintArea = "A1:J" & Indice
                    Try
                        sheet.PageSetup.FitToPagesWide = 1
                        sheet.PageSetup.FitToPagesTall = 3
                        sheet.PageSetup.TopMargin = 1
                        sheet.PageSetup.LeftMargin = 1
                        sheet.PageSetup.RightMargin = 1
                        sheet.PageSetup.BottomMargin = 1
                    Catch ex As Exception
                    End Try
                End If

                TotalGral = 0

                pgb.Value = ((Padres.Rows.IndexOf(Padre) * 100) + (((Hijos.Rows.IndexOf(Hijo) + 1) / Hijos.Rows.Count) * 100))
                '<------------------------------------>

                'For ilocal As Byte = 7 To 13
                'subTotalaCobrar += ArregloFact(cuenta, ilocal)
                subTotalaCobrar = Val(ArrayFact(cuenta).CobroXTraslado) + Val(ArrayFact(cuenta).CobroXMiles) +
                                  Val(ArrayFact(cuenta).CobroXKilometros) + Val(ArrayFact(cuenta).CobroXCajaFuerte) +
                                  Val(ArrayFact(cuenta).CobroXProceso) + Val(ArrayFact(cuenta).CobroXPernoctas) +
                                 Val(ArrayFact(cuenta).CobroXMateriales)
                'Next
                ArrayFact(cuenta).TotalACobrar = subTotalaCobrar
                'ArregloFact(cuenta, 14) = subTotalaCobrar

                cuenta += 1 'valor que incremeta para saber el nuemro de filas a almavenar valores
                '<----------------------------------->
            Next

            NombreArchivo = Path & "\" & Trim(Padre("Clave_Cliente")) & "-" & dtp_Desde.Value.Month & "-" & dtp_Hasta.Value.Year

            Dim Hora As String = Microsoft.VisualBasic.Left(Now.ToLongTimeString, 2) & Microsoft.VisualBasic.Mid(Now.ToLongTimeString, 4, 2) & Microsoft.VisualBasic.Right(Now.ToLongTimeString, 2)

            If System.IO.File.Exists(NombreArchivo & ".xls") Or System.IO.File.Exists(NombreArchivo & ".xlsx") Then
                book.SaveAs(NombreArchivo & "_" & Hora & ".xls")
                MsgBox("El Archivo con nombre " & NombreArchivo & " ya existía y se guardó como " & NombreArchivo & "_" & Hora, MsgBoxStyle.Information, frm_MENU.Text)
            Else
                book.SaveAs(NombreArchivo & ".xls")
            End If

            'book.Close()
            If chk_Sucursales.Checked Then
                '-----------------hoja resumida de facturacion
                sheet = book.Sheets.Add() 'Agrega Una Hoja de todo Resumido
                sheet.name = "Facturacion"
                Dim filas As Integer = 5 'INICIAMOS EN FILA 5 DEL EXCEL
                Dim inicioFila As Integer = filas
                Dim ColumnasProceso As Integer = listaConceptos.Count 'El numero de columnas que se agregara para cada proceso 
                Dim letra As Char 'Saber que letra sigue despues de insertar las columas de proceso
                Dim ultimaLetra As Char 'saber cual es la ultima letra
                Dim penultimaletra As Char 'saber cual es la penultimaletra
                ' Dim LetrasCol() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"}

                sheet.Range("A" & filas).Value = "Clave"
                sheet.Range("B" & filas).Value = "Cliente"
                sheet.Range("C" & filas).Value = "Cantidad Traslados"
                sheet.Range("D" & filas).Value = "Importe Trasladado"
                sheet.Range("E" & filas).Value = "Miles Trasladados"
                sheet.Range("F" & filas).Value = "Envases Trasladados"
                sheet.Range("G" & filas).Value = "Kilometros Recorridos"
                sheet.Range("H" & filas).Value = "Cobro por Traslados"
                sheet.Range("I" & filas).Value = "Cobro por Miles"
                sheet.Range("J" & filas).Value = "Cobro por Kilometros"
                sheet.Range("K" & filas).Value = "Cobro por Caja Fuerte"
                sheet.Range("L" & filas).Value = "Cobro por Proceso"
                'Brandon Ibarra 2/11/2023
                'Agrega las columas de los procesos que estan en la lista y si no hay ninguna continua con ultimaletra = L
                If ColumnasProceso > 0 Then
                    For i As Integer = 0 To ColumnasProceso - 1
                        Dim elemento As String = listaConceptos(i)
                        'Brandon Ibarra 2/11/2023
                        'Funcion que nos da la leta que sigue 
                        letra = Chr(Asc("M") + i)
                        sheet.Range(letra & filas).Value = elemento
                        ultimaLetra = letra
                    Next
                Else
                    ultimaLetra = "L"
                End If
                ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                sheet.Range(ultimaLetra & filas).Value = "Cobro por Pernoctas"
                ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                sheet.Range(ultimaLetra & filas).Value = "Cobro por Materiales"
                ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                sheet.Range(ultimaLetra & filas).Value = "Total a Cobrar"
                '----FOR QUE IMPRIME EN LA HOJA DE EXCEL  YA RESUMIDO
                For ilocal As Integer = 0 To TotalFilas
                    filas += 1

                    sheet.Range("A" & filas).Value = ArrayFact(ilocal).Clave

                    sheet.Range("A" & filas).Value = ArrayFact(ilocal).Clave
                    sheet.Range("B" & filas).Value = ArrayFact(ilocal).Cliente
                    sheet.Range("C" & filas).Value = ArrayFact(ilocal).CantidadTraslados
                    sheet.Range("D" & filas).Value = ArrayFact(ilocal).ImporteTrasladado
                    sheet.Range("E" & filas).Value = ArrayFact(ilocal).MilesTrasladados
                    sheet.Range("F" & filas).Value = ArrayFact(ilocal).EnvasesTrasladados
                    sheet.Range("G" & filas).Value = ArrayFact(ilocal).KilometrosRec
                    sheet.Range("H" & filas).Value = ArrayFact(ilocal).CobroXTraslado
                    sheet.Range("I" & filas).Value = ArrayFact(ilocal).CobroXMiles
                    sheet.Range("J" & filas).Value = ArrayFact(ilocal).CobroXKilometros
                    sheet.Range("K" & filas).Value = ArrayFact(ilocal).CobroXCajaFuerte
                    sheet.Range("L" & filas).Value = ArrayFact(ilocal).CobroXProceso
                    'Brandon Ibarra 2/11/2023
                    'Valida que existan columas de proceso para despues buscar por clave cliente los que pertenencen a el e irlos ingresando en orden en caso de que este vacio le da 0.00
                    If ColumnasProceso > 0 Then
                        For i As Integer = 0 To ColumnasProceso - 1
                            Dim elemento As String = listaConceptos(i)
                            letra = Chr(Asc("M") + i)
                            For Each x As ConceptosProceso In PrecioConceptos
                                If (x.Clave = ArrayFact(ilocal).Clave.ToString()) Then
                                    If x.Nombre = elemento Then
                                        sheet.Range(letra & filas).Value = x.Importe
                                    End If
                                End If
                            Next
                            If sheet.Range(letra & filas).Value = Nothing Then
                                sheet.Range(letra & filas).Value = "0.00"
                            End If
                        Next
                    Else
                        letra = "M"
                    End If
                    ultimaLetra = letra
                    ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                    sheet.Range(ultimaLetra & filas).Value = ArrayFact(ilocal).CobroXPernoctas
                    ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                    sheet.Range(ultimaLetra & filas).Value = ArrayFact(ilocal).CobroXMateriales
                    ultimaLetra = Chr(Asc(ultimaLetra) + 1)
                    sheet.Range(ultimaLetra & filas).Value = ArrayFact(ilocal).TotalACobrar
                Next

                '-----------------------------------------------
                sheet.Shapes.AddPicture(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg", False, True, 0, 0, 40, 40)

                sheet.Range("A1").Value = dt_Sucursal.Rows(0)("Nombre")
                sheet.Range("A1:P1").Font.Bold = True
                sheet.Range("A1:P1").Font.Size = 11
                sheet.Range("A1:P1").HorizontalAlignment = -4108
                sheet.Range("A1:G1").Merge()
                '-------------------------------------------------------------------
                penultimaletra = Chr(Asc(ultimaLetra) - 1)
                sheet.Range(penultimaletra & filas + 2).Value = "Total General:"
                sheet.Range(ultimaLetra & filas + 2).Value = Suma & "(" & ultimaLetra & (inicioFila + 1) & ":" + ultimaLetra & (filas) & ")"
                sheet.Range(ultimaLetra & filas + 2).NumberFormat = "$#,##0.00"
                sheet.Range(penultimaletra & filas + 2 & ":" + ultimaLetra & filas + 2).Font.Bold = True

                sheet.Range("A" & inicioFila & ":" + penultimaletra & inicioFila).Font.Bold = True
                sheet.Range("A" & inicioFila & ":" + penultimaletra & filas).Font.Size = 10

                sheet.Range("D" & (inicioFila + 1) & ":D" & filas).NumberFormat = "$#,##0.00"
                sheet.Range("H" & (inicioFila + 1) & ":O" & filas).NumberFormat = "$#,##0.00"
                sheet.Range("A" & inicioFila & ":" + ultimaLetra & filas).borders.value = True
                sheet.Range("A" & inicioFila & ":" + ultimaLetra & filas).EntireColumn.AutoFit()
                ' sheet.Range("A2:N2").WrapText = True 'ajuste de texto
                '-----------------------------------------------------------------

            End If
            xls.visible = True
            xls = Nothing
        Next
        Me.Cursor = Cursors.Default
        pgb.Value = 0
        MsgBox("Todos los archivos se han generado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Sub ExportarLavado()
        If Not Validar() Then Exit Sub

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
        Dim Suma As String = ""

        Dim Padres As DataTable
        Dim Hijos As DataTable
        Dim Prefactura As DataTable
        Dim book As Object
        Dim sheet As Object

        Dim Path As String
        Dim NombreArchivo As String = ""
        Dim TotalFilas As Integer = 0
        Dim ArrayFact() As Facturacion

        Dim Fila As Integer = 5 'Inicia en la fila 5
        Dim col As Integer = 65 'Inica en 'A'
        Dim InicioFila As Integer = Fila
        Dim FinColumna As Integer = 0
        Dim FechaDesde As Date = dtp_Desde.Value.Date
        Dim CantidadDias As Integer = DateDiff(DateInterval.Day, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
        CantidadDias += 1 'aumentar +1 para que contemple columna

        '----------->>Logo Empresa
        Try
            Dim ds As New ds_DatosEmpresa
            Call fn_DatosEmpresa_LlenarDataSet(ds)

            If Not IsDBNull(ds.Tbl_DatosEmpresa.Rows(0)("logo")) Then
                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = ds.Tbl_DatosEmpresa.Rows(0)("logo")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                If IO.File.Exists(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg") Then
                    File.Delete(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
                End If
                imagenNueva.Save(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg")
            End If

        Catch
        End Try
        '<<--------------------

        Padres = fn_PreFactura_GetPadres(cmb_Clientes.SelectedValue)

        If Padres Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar obtener los datos del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)

            Exit Sub 'salir si ocurrio error
        End If

        If Padres.Rows.Count = 0 Then Exit Sub 'salir si no hay registros

        'Aquí se cargan los datos de la Sucursal
        Dim dt_Sucursal As DataTable = fn_PreFactura_ObtenerDatosSucursal()
        If dt_Sucursal Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar obtener los datos de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Path = fbd.SelectedPath
        If Path.Length = 3 Then
            Path = Microsoft.VisualBasic.Left(Path, 2)
        End If

        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            xls = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                xls = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If versionHC = False Then
            MsgBox("No se encontró un software de Hoja de Cálculo para poder generar la prefactura.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        '<<--------------------

        For Each Padre As DataRow In Padres.Rows

            '------>> Se agrega el libro
            xls.SheetsInNewWorkbook = 1
            book = xls.Workbooks.Add()

            sheet = book.Sheets.Add() 'Agrega Una Hoja de todo Resumido
            sheet.name = "LeyLavado"
            If sheet.name = "Sheet1" Then Suma = "=Sum" Else Suma = "=Sum"
            '-----------------------
            If chk_Sucursales.Checked = True Or chk_Todos.Checked = True Then
                'se selecciona él mismo y a sus subclientes
                Hijos = fn_PreFactura_GetHijos(Padre("Id_Cliente"), True, cmb_Status.SelectedValue, Cmb_Grupo.SelectedValue)
            Else
                'se agarra solo a él mismo sin incluir los subclientes
                Hijos = fn_PreFactura_GetHijos(Padre("Id_Cliente"), False, cmb_Status.SelectedValue, Cmb_Grupo.SelectedValue)
            End If
            '---------
            pgb.Maximum = Hijos.Rows.Count + 1

            TotalFilas = Hijos.Rows.Count - 1
            'ReDim ArregloFact(TotalFilas, 14) '
            ReDim ArrayFact(TotalFilas)

            '----->>Iniciar Impresion de filas y columnas en excel

            sheet.Range(LetrA(col) & Fila).Value = "Clave"
            col += 1
            sheet.Range(LetrA(col) & Fila).Value = "Cliente"
            col += 1

            '---->>Imprime las fechas en las columnas del Excel---

            While dtp_Hasta.Value.Date >= FechaDesde
                sheet.Range(LetrA(col) & Fila).Value = Format(FechaDesde, "yyyy.MM.dd")
                col += 1
                FechaDesde = FechaDesde.AddDays(1)
            End While
            sheet.Range(LetrA(col) & Fila).Value = "Total por Cliente"

            sheet.Range("A5:" & LetrA(col) & Fila).Font.Bold = True
            sheet.Range("A5:" & LetrA(col) & Fila).HorizontalAlignment = -4108

            FinColumna = col 'Almacena Fin columna

            '-----------------------------------------------
            sheet.Shapes.AddPicture(My.Application.Info.DirectoryPath & "\LogoEmpresa.jpg", False, True, 0, 0, 40, 40)

            sheet.Range("A1:" & LetrA(FinColumna) & 1).Merge()
            sheet.Range("A2:" & LetrA(FinColumna) & 2).Merge()
            sheet.Range("A3:" & LetrA(FinColumna) & 3).Merge()
            sheet.Range("A1").Value = dt_Sucursal.Rows(0)("Nombre")
            sheet.Range("A2").Value = "REPORTE DE IMPORTES TRASLADADOS"
            sheet.Range("A3").Value = Format(dtp_Desde.Value.Date, "dd/MM/yyyy") & " - " & Format(dtp_Hasta.Value.Date, "dd/MM/yyyy")
            sheet.Range("A1:" & LetrA(FinColumna) & 3).Font.Bold = True
            sheet.Range("A1:" & LetrA(FinColumna) & 3).HorizontalAlignment = -4108


            '<<-------------
            Fila += 1 'Aumentar fila + 1 
            col = 65 'Reinicia a letra 'A'
            '--------->>For para hijos---------
            For Each Hijo As DataRow In Hijos.Rows

                sheet.Range(LetrA(col) & Fila).Value = "'" & Hijo("Clave")
                col += 1
                sheet.Range(LetrA(col) & Fila).Value = Hijo("Cliente")

                'Consultar Importes
                Prefactura = fn_PreFactura_GetReporte2(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), cmb_Status.SelectedValue)

                'Imprimir importes en las columnas
                col = 67 'Inicia en 'C'

                'Rellenar con $ 0.00
                sheet.Range(LetrA(col) & Fila & ":" & LetrA(FinColumna) & Fila).Value = 0
                sheet.Range(LetrA(col) & Fila & ":" & LetrA(FinColumna) & Fila).NumberFormat = "#,##0.00"

                For Each elemento As DataRow In Prefactura.Rows
                    For I As Integer = col To FinColumna - 1
                        'Fila 5 porque en esa fila imprimimos la fecha
                        If elemento("Fecha") = sheet.Range(LetrA(col) & 5).Value.ToString.Trim Then
                            sheet.Range(LetrA(col) & Fila).Value = elemento("Importe")
                            col += 1
                            Exit For
                        End If
                        col += 1
                    Next
                Next

                ' imprimir totales del cliente Por Fila
                sheet.Range(LetrA(FinColumna) & Fila).Value = Suma & "(" & "C" & (Fila) & ":" & LetrA(FinColumna - 1) & (Fila) & ")"
                '---------------

                'pgb.Value = ((Padres.Rows.IndexOf(Padre) * 100) + (((Hijos.Rows.IndexOf(Hijo) + 1) / Hijos.Rows.Count) * 100))
                Fila += 1
                col = 65 'Reinicia a letra 'A'
                pgb.Value += 1
                If pgb.Value = pgb.Maximum Then pgb.Maximum += 1
            Next '<<-------Fin For Para Hijos

            sheet.Range("B" & Fila).Value = "Total por dia"
            col = 67 'Inicia en 'C'

            'Imprimir  totales por dia
            For I As Integer = 1 To CantidadDias
                '=SUMA(C6:C38)
                sheet.Range(LetrA(col) & Fila).Value = Suma & "(" & LetrA(col) & (InicioFila + 1) & ":" & LetrA(col) & (Fila - 1) & ")"
                col += 1
            Next

            'total por cliente
            'sheet.Range(LetrA(FinColumna) & (InicioFila + 1) & ":" & LetrA(FinColumna) & Fila).NumberFormat = "#,##0.00"
            sheet.Range(LetrA(FinColumna) & (InicioFila + 1) & ":" & LetrA(FinColumna) & Fila).Font.Bold = True

            'total por dia
            sheet.Range("C" & (Fila) & ":" & LetrA(FinColumna) & (Fila)).NumberFormat = "#,##0.00"
            sheet.Range("B" & (Fila) & ":" & LetrA(FinColumna) & (Fila)).Font.Bold = True


            pgb.Value = pgb.Maximum
            NombreArchivo = Path & "\LL_" & Trim(Padre("Clave_Cliente")) & "-" & dtp_Desde.Value.Month & "-" & dtp_Hasta.Value.Year

            Dim Hora As String = Microsoft.VisualBasic.Left(Now.ToLongTimeString, 2) & Microsoft.VisualBasic.Mid(Now.ToLongTimeString, 4, 2) & Microsoft.VisualBasic.Right(Now.ToLongTimeString, 2)

            If System.IO.File.Exists(NombreArchivo & ".xls") Or System.IO.File.Exists(NombreArchivo & ".xlsx") Then
                book.SaveAs(NombreArchivo & "_" & Hora & ".xlsx")
                MsgBox("El Archivo con nombre " & NombreArchivo & " ya existía y se guardó como " & NombreArchivo & "_" & Hora, MsgBoxStyle.Information, frm_MENU.Text)
            Else
                book.SaveAs(NombreArchivo & ".xlsx")
            End If

            '-------------------------------------------------------------------
            sheet.Range("A" & InicioFila & ":" & LetrA(FinColumna) & Fila).borders.value = True
            sheet.Range("A" & InicioFila & ":" & LetrA(FinColumna) & Fila).EntireColumn.AutoFit()
            '-----------------------------------------------------------------
            xls.visible = True
            xls = Nothing
        Next '<<--------Fin For para Padres

        Me.Cursor = Cursors.Default
        pgb.Value = 0
        MsgBox("Todos los archivos se han generado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub


#End Region

#Region "Metodos Anteriores"

    'Sub ExportarPorCS()
    '    If Validar() Then
    '        Dim Padres As DataTable = Cn_Facturacion.fn_PreFactura_GetPadres(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_LineadeServicio.SelectedValue, cmb_Clientes.SelectedValue)
    '        Dim Hijos As DataTable
    '        Dim Prefactura As DataTable
    '        Dim CV As DataTable
    '        Dim book As Object
    '        Dim sheet As Object
    '        Dim PrimerHoja As Boolean = True
    '        Dim FolioAnterior As Long
    '        Dim PrecioAnterior As Long
    '        Dim CSAnterior As Long
    '        Dim Indice As Integer = 3
    '        Dim Path As String
    '        Dim NombreArchivo As String = ""
    '        Dim Clave_Linea As String = ""
    '        Dim Miles, Servicios, Envases, EnvasesE, Kilometros, Sobres, HoraRemision, Importe As Decimal
    '        Dim HayEE As Boolean = False
    '        Dim HayKM As Boolean = False
    '        Dim HaySobres As Boolean = False
    '        Dim CVMostrados As Boolean = False

    '        If Padres Is Nothing Then Exit Sub
    '        If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '        Path = fbd.SelectedPath
    '        If Path.Length = 3 Then
    '            Path = Microsoft.VisualBasic.Left(Path, 2)
    '        End If

    '        pgb.Maximum = Padres.Rows.Count * 100

    '        Dim xls = CreateObject("Excel.Application")
    '        For Each Padre As DataRow In Padres.Rows
    '            xls.SheetsInNewWorkbook = 1
    '            book = xls.Workbooks.Add()

    '            If cbx_Sucursales.Checked = True Or cbx_Todos.Checked = True Then
    '                'se selecciona él mismo y a sus subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), False, cmb_Status.SelectedValue)
    '            Else
    '                'se agarra solo a él mismo sin incluir los subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), True, cmb_Status.SelectedValue)
    '            End If
    '            For Each Hijo As DataRow In Hijos.Rows
    '                PrecioAnterior = 0
    '                CSAnterior = 0
    '                If Not PrimerHoja Then
    '                    sheet = book.Sheets.Add()
    '                Else
    '                    sheet = book.Sheets(1)
    '                End If
    '                PrimerHoja = False
    '                Try
    '                    sheet.Name = Hijo("Clave")
    '                Finally
    '                End Try

    '                sheet.Cells.Font.Name = "Arial"

    '                sheet.Range("A1:K1").Merge()
    '                sheet.Range("A1:K1").Value = Hijo("Empresa")
    '                sheet.Range("A1:K1").Font.Bold = True
    '                sheet.Range("A1:K1").Font.Size = 12
    '                sheet.Range("A1:K1").HorizontalAlignment = -4108

    '                sheet.Range("A2:K2").Merge()
    '                sheet.Range("A2:K2").Value = Hijo("Direccion")
    '                sheet.Range("A2:K2").Font.Bold = True
    '                sheet.Range("A2:K2").Font.Size = 10
    '                sheet.Range("A2:K2").HorizontalAlignment = -4108

    '                'sheet.Range("A3:K3").Merge()
    '                'sheet.Range("A3:K3").Value = Hijo("Clave") & " " & Hijo("Cliente")
    '                'sheet.Range("A3:K3").Font.Bold = True
    '                'sheet.Range("A3:K3").Font.Size = 11
    '                'sheet.Range("A3:K3").HorizontalAlignment = -4108

    '                sheet.Range("A1").ColumnWidth = 13
    '                sheet.Range("B1").ColumnWidth = 13
    '                sheet.Range("C1").ColumnWidth = 15
    '                sheet.Range("I1").ColumnWidth = 12
    '                sheet.Range("J1").ColumnWidth = 13

    '                Prefactura = Cn_Facturacion.fn_PreFactura_GetReporte(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
    '                'CV = Cn_Facturacion.fn_PreFactura_GetCV(dtp_Desde.Text, dtp_Hasta.Text, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
    '                CVMostrados = False
    '                CSAnterior = -1
    '                If Prefactura IsNot Nothing Then
    '                    For Each row As DataRow In Prefactura.Rows
    '                        Clave_Linea = Microsoft.VisualBasic.Left(row("Linea"), 3)
    '                        'If PrecioAnterior <> row("Id_Precio") Then
    '                        If CSAnterior <> row("Id_CS") Then
    '                            If Indice > 3 Then
    '                                'TOTALES
    '                                sheet.Range("C" & Indice).Value = "TOTAL"
    '                                sheet.Range("D" & Indice).Value = Miles
    '                                sheet.Range("E" & Indice).Value = Servicios
    '                                sheet.Range("F" & Indice).Value = Envases
    '                                sheet.Range("G" & Indice).Value = EnvasesE
    '                                sheet.Range("H" & Indice).Value = Kilometros
    '                                sheet.Range("K" & Indice).Value = Importe
    '                                sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                                sheet.Range("C" & Indice & ":K" & Indice).Font.Bold = True
    '                                sheet.Range("C" & Indice & ":J" & Indice).Font.Italic = True

    '                                If EnvasesE > 0 Then HayEE = True
    '                                If Kilometros > 0 Then HayKM = True
    '                                If Sobres > 0 Then HaySobres = True

    '                                Miles = 0
    '                                Servicios = 0
    '                                Envases = 0
    '                                EnvasesE = 0
    '                                Kilometros = 0
    '                                Importe = 0
    '                                Sobres = 0
    '                                'Indice = 3

    '                            End If
    '                            Indice += 1

    '                            sheet.Range("A" & Indice & ":K" & Indice).Merge()
    '                            sheet.Range("A" & Indice & ":K" & Indice).Value = Hijo("Clave") & " " & Hijo("Cliente")
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Bold = True
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 11
    '                            sheet.Range("A" & Indice & ":K" & Indice).HorizontalAlignment = -4108

    '                            Indice += 1

    '                            sheet.Range("E" & Indice).Value = "Precio"
    '                            sheet.Range("D" & Indice).Value = "PrecioCR"
    '                            sheet.Range("G" & Indice).Value = "PrecioEE"
    '                            sheet.Range("H" & Indice).Value = "PrecioKM"
    '                            sheet.Range("D" & Indice & ":I" & Indice).Font.Bold = True
    '                            sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
    '                            sheet.Range("D" & Indice & ":I" & Indice).HorizontalAlignment = -4108

    '                            Indice += 1

    '                            'precios
    '                            sheet.Range("A" & Indice & ":C" & Indice).Merge()
    '                            'If row("Linea2") <> "" Then
    '                            '    sheet.Range("A" & Indice).Value = row("Linea") & "(" & row("Linea2") & ")"
    '                            'Else
    '                            sheet.Range("A" & Indice).Value = row("Linea")
    '                            'End If
    '                            sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 9
    '                            sheet.Range("A" & Indice & ":D" & Indice).HorizontalAlignment = -4108
    '                            sheet.Range("A" & Indice).RowHeight = 15
    '                            sheet.Range("A" & Indice).WrapText = True


    '                            sheet.Range("E" & Indice).Value = row("Precio")
    '                            sheet.Range("D" & Indice).Value = row("PrecioCR")
    '                            sheet.Range("G" & Indice).Value = row("PrecioEE")
    '                            sheet.Range("H" & Indice).Value = row("PrecioKM")
    '                            sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
    '                            sheet.Range("D" & Indice & ":I" & Indice).NumberFormat = "$#,##0.00"

    '                            Indice += 1
    '                            'cabecera de la tabla
    '                            sheet.Range("A" & Indice).Value = "Folio Servicio"
    '                            sheet.Range("B" & Indice).Value = "Fecha"
    '                            sheet.Range("C" & Indice).Value = "Importe Traslado"
    '                            sheet.Range("D" & Indice).Value = "Miles"
    '                            sheet.Range("E" & Indice).Value = "Cantidad Servicios"
    '                            sheet.Range("F" & Indice).Value = "Envases"
    '                            sheet.Range("G" & Indice).Value = "E. Exceso"
    '                            sheet.Range("H" & Indice).Value = "Kilometros"
    '                            sheet.Range("I" & Indice).Value = "Hora Remision"
    '                            sheet.Range("J" & Indice).Value = "Sobres Nómina"
    '                            sheet.Range("K" & Indice).Value = "Importe"

    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Underline = True
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 10

    '                            ''poner todos los comprobantes de visita que se encuentren
    '                            'If Not CVMostrados Then
    '                            '    For ii As Integer = 0 To CV.Rows.Count - 1
    '                            '        Indice += 1
    '                            '        sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 8
    '                            '        sheet.Range("A" & Indice & ":K" & Indice).Font.Name = "Times New Roman"
    '                            '        sheet.Range("A" & Indice).Value = CV.Rows(ii)("Numero")
    '                            '        sheet.Range("B" & Indice).Value = "'" & CV.Rows(ii)("Fecha")
    '                            '        sheet.Range("C" & Indice).Value = 0
    '                            '        sheet.Range("D" & Indice).Value = 0
    '                            '        sheet.Range("E" & Indice).Value = 1
    '                            '        sheet.Range("F" & Indice).Value = 0
    '                            '        sheet.Range("G" & Indice).Value = 0
    '                            '        sheet.Range("H" & Indice).Value = 0
    '                            '        sheet.Range("I" & Indice).Value = "'" & CV.Rows(ii)("Hora")
    '                            '        sheet.Range("K" & Indice).Value = CV.Rows(ii)("Precio")
    '                            '        sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                            '        sheet.Range("L" & Indice).Value = "** Comp. Visita"
    '                            '        Servicios += 1
    '                            '        Importe += CV.Rows(ii)("Precio")
    '                            '    Next
    '                            '    CVMostrados = True
    '                            'End If

    '                            Indice += 1

    '                            PrecioAnterior = row("Id_Precio")
    '                            CSAnterior = row("Id_CS")
    '                        End If

    '                        If FolioAnterior <> row("Folio_Servicio") Then
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 10
    '                            sheet.Range("A" & Indice).Value = row("Folio_Servicio")
    '                            sheet.Range("B" & Indice).Value = row("Fecha")
    '                            sheet.Range("C" & Indice).Value = row("Importe_Traslado")
    '                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("D" & Indice).Value = row("Miles")
    '                            sheet.Range("E" & Indice).Value = 1
    '                            sheet.Range("F" & Indice).Value = row("Envases")
    '                            sheet.Range("G" & Indice).Value = row("Envases_Exceso")
    '                            sheet.Range("H" & Indice).Value = row("Kilometros")
    '                            sheet.Range("K" & Indice).Value = row("Importe")
    '                            sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                            If row("Id_ComprobanteV") > 0 Then
    '                                sheet.Range("L" & Indice).Value = "** Comp. Visita"
    '                            End If

    '                            Miles += row("Miles")
    '                            Servicios += 1
    '                            Envases += row("Envases")
    '                            EnvasesE += row("Envases_Exceso")
    '                            If EnvasesE > 0 Then HayEE = True

    '                            Kilometros += row("Kilometros")
    '                            If Kilometros > 0 Then HayKM = True

    '                            If Clave_Linea = "SCF" Then
    '                                Importe = row("Precio")
    '                            Else
    '                                Importe += row("Importe")
    '                            End If

    '                            Indice += 1

    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.size = 8
    '                            sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                            sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                            sheet.Range("I" & Indice).Value = row("Hora_Remision")
    '                            If row("Cantidad_Sobres") > 0 Then
    '                                sheet.Range("J" & Indice).Value = row("Cantidad_Sobres")
    '                                Sobres += row("Cantidad_Sobres")
    '                                HaySobres = True
    '                            End If

    '                            Indice += 1

    '                            FolioAnterior = row("Folio_Servicio")
    '                        Else
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 8
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                            sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                            sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                            sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                            sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                            sheet.Range("I" & Indice).Value = row("Hora_Remision")
    '                            If row("Cantidad_Sobres") > 0 Then
    '                                sheet.Range("J" & Indice).Value = row("Cantidad_Sobres")
    '                                Sobres += row("Cantidad_Sobres")
    '                                HaySobres = True
    '                            End If

    '                            Indice += 1

    '                        End If
    '                    Next
    '                End If
    '                sheet.Range("C" & Indice).Value = "TOTAL"
    '                sheet.Range("D" & Indice).Value = Miles
    '                sheet.Range("E" & Indice).Value = Servicios
    '                sheet.Range("F" & Indice).Value = Envases
    '                sheet.Range("G" & Indice).Value = EnvasesE
    '                sheet.Range("H" & Indice).Value = Kilometros
    '                sheet.Range("J" & Indice).Value = Sobres

    '                sheet.Range("K" & Indice).Value = Importe
    '                sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                sheet.Range("C" & Indice & ":K" & Indice).Font.Bold = True
    '                sheet.Range("C" & Indice & ":K" & Indice).Font.Italic = True

    '                'Eliminar las columnas donde no haya nada (EE, KM, Sobres)

    '                If Not HaySobres Then
    '                    sheet.Range("J1").EntireColumn.Delete()
    '                End If
    '                If Not HayKM Then
    '                    sheet.Range("H1").EntireColumn.Delete()
    '                End If
    '                If Not HayEE Then
    '                    sheet.Range("G1").EntireColumn.Delete()
    '                End If

    '                Miles = 0
    '                Servicios = 0
    '                Envases = 0
    '                EnvasesE = 0
    '                Kilometros = 0
    '                Importe = 0
    '                Sobres = 0
    '                Indice = 3

    '                HayEE = False
    '                HayKM = False
    '                HaySobres = False

    '                pgb.Value = ((Padres.Rows.IndexOf(Padre) * 100) + (((Hijos.Rows.IndexOf(Hijo) + 1) / Hijos.Rows.Count) * 100))
    '            Next
    '            NombreArchivo = Path & "\" & Trim(Padre("Clave_Cliente")) & "-" & dtp_Desde.Value.Month & "-" & dtp_Hasta.Value.Year
    '            Dim Hora As String = Microsoft.VisualBasic.Left(Now.ToLongTimeString, 2) & Microsoft.VisualBasic.Mid(Now.ToLongTimeString, 4, 2) & Microsoft.VisualBasic.Right(Now.ToLongTimeString, 2)
    '            If System.IO.File.Exists(NombreArchivo & ".xls") Or System.IO.File.Exists(NombreArchivo & ".xlsx") Then
    '                book.SaveAs(NombreArchivo & "_" & Hora)
    '                MsgBox("El Archivo con nombre " & NombreArchivo & " ya existia y se guardó como " & NombreArchivo & "_" & Hora, MsgBoxStyle.Information, frm_MENU.Text)
    '            Else
    '                book.SaveAs(NombreArchivo)
    '            End If
    '            'book.Close()
    '            xls.visible = True
    '        Next
    '        pgb.Value = 0
    '        MsgBox("Todos los archivos se han generado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
    '    End If
    'End Sub

    'Sub ExportarPorPrecio()
    '    If Validar() Then
    '        Dim Padres As DataTable = Cn_Facturacion.fn_PreFactura_GetPadres(dtp_Desde.Text, dtp_Hasta.Text, cmb_LineadeServicio.SelectedValue, cmb_Clientes.SelectedValue)
    '        Dim Hijos As DataTable
    '        Dim Prefactura As DataTable
    '        Dim CV As DataTable
    '        Dim book As Object
    '        Dim sheet As Object
    '        Dim PrimerHoja As Boolean = True
    '        Dim FolioAnterior As Long
    '        Dim PrecioAnterior As Long

    '        Dim Indice As Integer = 3
    '        Dim path As String
    '        Dim Clave_Linea As String = ""
    '        Dim Miles, Servicios, Envases, EnvasesE, Kilometros, Sobres, HoraRemision, Importe As Decimal
    '        Dim HayEE As Boolean = False
    '        Dim HayKM As Boolean = False
    '        Dim HaySobres As Boolean = False

    '        If Padres Is Nothing Then Exit Sub
    '        If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '        path = fbd.SelectedPath

    '        pgb.Maximum = Padres.Rows.Count * 100

    '        Dim xls = CreateObject("Excel.Application")
    '        For Each Padre As DataRow In Padres.Rows
    '            xls.SheetsInNewWorkbook = 1
    '            book = xls.Workbooks.Add()
    '            If cbx_Sucursales.Checked = True Or cbx_Todos.Checked = True Then
    '                'se selecciona él mismo y a sus subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), False, cmb_Status.SelectedValue)
    '            Else
    '                'se agarra solo a él mismo sin incluir los subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), True, cmb_Status.SelectedValue)
    '            End If
    '            For Each Hijo As DataRow In Hijos.Rows
    '                PrecioAnterior = 0

    '                If Not PrimerHoja Then
    '                    sheet = book.Sheets.Add()
    '                Else
    '                    sheet = book.Sheets(1)
    '                End If
    '                PrimerHoja = False
    '                Try
    '                    sheet.Name = Hijo("Clave")
    '                Finally
    '                End Try

    '                sheet.Cells.Font.Name = "Arial"

    '                sheet.Range("A1:K1").Merge()
    '                sheet.Range("A1:K1").Value = Hijo("Empresa")
    '                sheet.Range("A1:K1").Font.Bold = True
    '                sheet.Range("A1:K1").Font.Size = 12
    '                sheet.Range("A1:K1").HorizontalAlignment = -4108

    '                sheet.Range("A2:K2").Merge()
    '                sheet.Range("A2:K2").Value = Hijo("Direccion")
    '                sheet.Range("A2:K2").Font.Bold = True
    '                sheet.Range("A2:K2").Font.Size = 10
    '                sheet.Range("A2:K2").HorizontalAlignment = -4108

    '                sheet.Range("A3:K3").Merge()
    '                sheet.Range("A3:K3").Value = Hijo("Clave") & " " & Hijo("Cliente")
    '                sheet.Range("A3:K3").Font.Bold = True
    '                sheet.Range("A3:K3").Font.Size = 11
    '                sheet.Range("A3:K3").HorizontalAlignment = -4108

    '                sheet.Range("A1").ColumnWidth = 13
    '                sheet.Range("B1").ColumnWidth = 13
    '                sheet.Range("C1").ColumnWidth = 15
    '                sheet.Range("I1").ColumnWidth = 12
    '                sheet.Range("J1").ColumnWidth = 13

    '                Prefactura = Cn_Facturacion.fn_PreFactura_GetReporte(dtp_Desde.Text, dtp_Hasta.Text, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
    '                CV = Cn_Facturacion.fn_PreFactura_GetCV(dtp_Desde.Text, dtp_Hasta.Text, Hijo("Id_Cliente"), cmb_Status.SelectedValue)

    '                For Each row As DataRow In Prefactura.Rows
    '                    Clave_Linea = Microsoft.VisualBasic.Left(row("Linea"), 3)
    '                    If PrecioAnterior <> row("Id_Precio") Then
    '                        If Indice > 3 Then
    '                            'TOTALES
    '                            sheet.Range("C" & Indice).Value = "TOTAL"
    '                            sheet.Range("D" & Indice).Value = Miles
    '                            sheet.Range("E" & Indice).Value = Servicios
    '                            sheet.Range("F" & Indice).Value = Envases
    '                            sheet.Range("G" & Indice).Value = EnvasesE
    '                            sheet.Range("H" & Indice).Value = Kilometros
    '                            sheet.Range("K" & Indice).Value = Importe
    '                            sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("C" & Indice & ":K" & Indice).Font.Bold = True
    '                            sheet.Range("C" & Indice & ":J" & Indice).Font.Italic = True

    '                            If EnvasesE > 0 Then HayEE = True
    '                            If Kilometros > 0 Then HayKM = True
    '                            If Sobres > 0 Then HaySobres = True

    '                            Miles = 0
    '                            Servicios = 0
    '                            Envases = 0
    '                            EnvasesE = 0
    '                            Kilometros = 0
    '                            Importe = 0
    '                            Sobres = 0
    '                            'Indice = 3

    '                        End If

    '                        Indice += 1

    '                        sheet.Range("E" & Indice).Value = "Precio"
    '                        sheet.Range("D" & Indice).Value = "PrecioCR"
    '                        sheet.Range("G" & Indice).Value = "PrecioEE"
    '                        sheet.Range("H" & Indice).Value = "PrecioKM"
    '                        sheet.Range("D" & Indice & ":I" & Indice).Font.Bold = True
    '                        sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
    '                        sheet.Range("D" & Indice & ":I" & Indice).HorizontalAlignment = -4108

    '                        Indice += 1

    '                        'precios
    '                        sheet.Range("A" & Indice & ":C" & Indice).Merge()
    '                        sheet.Range("A" & Indice).Value = row("Linea")
    '                        sheet.Range("A" & Indice & ":L" & Indice).Font.Size = 9
    '                        sheet.Range("A" & Indice & ":D" & Indice).HorizontalAlignment = -4108

    '                        sheet.Range("E" & Indice).Value = row("Precio")
    '                        sheet.Range("D" & Indice).Value = row("PrecioCR")
    '                        sheet.Range("G" & Indice).Value = row("PrecioEE")
    '                        sheet.Range("H" & Indice).Value = row("PrecioKM")
    '                        sheet.Range("D" & Indice & ":I" & Indice).Font.Size = 9
    '                        sheet.Range("D" & Indice & ":I" & Indice).NumberFormat = "$#,##0.00"

    '                        Indice += 1
    '                        'cabecera de la tabla
    '                        sheet.Range("A" & Indice).Value = "Folio Servicio"
    '                        sheet.Range("B" & Indice).Value = "Fecha"
    '                        sheet.Range("C" & Indice).Value = "Importe Traslado"
    '                        sheet.Range("D" & Indice).Value = "Miles"
    '                        sheet.Range("E" & Indice).Value = "Cantidad Servicios"
    '                        sheet.Range("F" & Indice).Value = "Envases"
    '                        sheet.Range("G" & Indice).Value = "E. Exceso"
    '                        sheet.Range("H" & Indice).Value = "Kilometros"
    '                        sheet.Range("I" & Indice).Value = "Hora Remision"
    '                        sheet.Range("J" & Indice).Value = "Sobres Nómina"
    '                        sheet.Range("K" & Indice).Value = "Importe"

    '                        sheet.Range("A" & Indice & ":K" & Indice).Font.Underline = True
    '                        sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 10

    '                        'poner todos los comprobantes de visita que se encuentren
    '                        For ii As Integer = 0 To CV.Rows.Count - 1
    '                            Indice += 1
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 8
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Name = "Times New Roman"
    '                            sheet.Range("A" & Indice).Value = CV.Rows(ii)("Numero")
    '                            sheet.Range("B" & Indice).Value = "'" & CV.Rows(ii)("Fecha")
    '                            sheet.Range("C" & Indice).Value = 0
    '                            sheet.Range("D" & Indice).Value = 0
    '                            sheet.Range("E" & Indice).Value = 1
    '                            sheet.Range("F" & Indice).Value = 0
    '                            sheet.Range("G" & Indice).Value = 0
    '                            sheet.Range("H" & Indice).Value = 0
    '                            sheet.Range("I" & Indice).Value = "'" & CV.Rows(ii)("Hora")
    '                            sheet.Range("K" & Indice).Value = CV.Rows(ii)("Precio")
    '                            sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("L" & Indice).Value = "** Comp. Visita"
    '                            Servicios += 1
    '                            Importe += CV.Rows(ii)("Precio")
    '                        Next
    '                        Indice += 1

    '                        PrecioAnterior = row("Id_Precio")
    '                    End If

    '                    If FolioAnterior <> row("Folio_Servicio") Then
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 10
    '                        sheet.Range("A" & Indice).Value = row("Folio_Servicio")
    '                        sheet.Range("B" & Indice).Value = row("Fecha")
    '                        sheet.Range("C" & Indice).Value = row("Importe_Traslado")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("D" & Indice).Value = row("Miles")
    '                        sheet.Range("E" & Indice).Value = 1
    '                        sheet.Range("F" & Indice).Value = row("Envases")
    '                        sheet.Range("G" & Indice).Value = row("Envases_Exceso")
    '                        sheet.Range("H" & Indice).Value = row("Kilometros")
    '                        sheet.Range("K" & Indice).Value = row("Importe")
    '                        sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"


    '                        Miles += row("Miles")
    '                        Servicios += 1
    '                        Envases += row("Envases")
    '                        EnvasesE += row("Envases_Exceso")
    '                        If EnvasesE > 0 Then HayEE = True

    '                        Kilometros += row("Kilometros")
    '                        If Kilometros > 0 Then HayKM = True

    '                        If Clave_Linea = "SCF" Then
    '                            Importe = row("Precio")
    '                        Else
    '                            Importe += row("Importe")
    '                        End If

    '                        Indice += 1

    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.size = 8
    '                        sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                        sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                        sheet.Range("I" & Indice).Value = row("Hora_Remision")
    '                        If row("Cantidad_Sobres") > 0 Then
    '                            sheet.Range("J" & Indice).Value = row("Cantidad_Sobres")
    '                            Sobres += row("Cantidad_Sobres")
    '                            HaySobres = True
    '                        End If

    '                        Indice += 1

    '                        FolioAnterior = row("Folio_Servicio")
    '                    Else
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 8
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                        sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                        sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                        sheet.Range("I" & Indice).Value = row("Hora_Remision")
    '                        If row("Cantidad_Sobres") > 0 Then
    '                            sheet.Range("J" & Indice).Value = row("Cantidad_Sobres")
    '                            Sobres += row("Cantidad_Sobres")
    '                            HaySobres = True
    '                        End If

    '                        Indice += 1

    '                    End If
    '                Next

    '                sheet.Range("C" & Indice).Value = "TOTAL"
    '                sheet.Range("D" & Indice).Value = Miles
    '                sheet.Range("E" & Indice).Value = Servicios
    '                sheet.Range("F" & Indice).Value = Envases
    '                sheet.Range("G" & Indice).Value = EnvasesE
    '                sheet.Range("H" & Indice).Value = Kilometros
    '                sheet.Range("J" & Indice).Value = Sobres

    '                sheet.Range("K" & Indice).Value = Importe
    '                sheet.Range("K" & Indice).NumberFormat = "$#,##0.00"
    '                sheet.Range("C" & Indice & ":K" & Indice).Font.Bold = True
    '                sheet.Range("C" & Indice & ":K" & Indice).Font.Italic = True

    '                'Eliminar las columnas donde no haya nada (EE, KM, Sobres)

    '                If Not HaySobres Then
    '                    sheet.Range("J1").EntireColumn.Delete()
    '                End If
    '                If Not HayKM Then
    '                    sheet.Range("H1").EntireColumn.Delete()
    '                End If
    '                If Not HayEE Then
    '                    sheet.Range("G1").EntireColumn.Delete()
    '                End If

    '                Miles = 0
    '                Servicios = 0
    '                Envases = 0
    '                EnvasesE = 0
    '                Kilometros = 0
    '                Importe = 0
    '                Sobres = 0
    '                Indice = 3

    '                HayEE = False
    '                HayKM = False
    '                HaySobres = False

    '                pgb.Value = ((Padres.Rows.IndexOf(Padre) * 100) + (((Hijos.Rows.IndexOf(Hijo) + 1) / Hijos.Rows.Count) * 100))
    '            Next
    '            book.SaveAs(path & "\" & Trim(Padre("Clave_Cliente")) & "-" & dtp_Desde.Value.Month & "-" & dtp_Hasta.Value.Year)
    '            'book.Close()
    '            xls.visible = True
    '        Next
    '        pgb.Value = 0
    '        MsgBox("Todos los archivos se han generado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
    '    End If
    'End Sub

    'Private Sub btn_GenerarPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GenerarPrueba.Click
    '    'Inicializar la variable de desconexion
    '    SegundosDesconexion = 0

    '    If Validar() Then

    '        Dim Padres As DataTable = Cn_Facturacion.fn_PreFactura_GetPadres(dtp_Desde.Text, dtp_Hasta.Text, cmb_LineadeServicio.SelectedValue, cmb_Clientes.SelectedValue)
    '        Dim Hijos As DataTable
    '        Dim Prefactura As DataTable
    '        Dim CV As DataTable
    '        Dim book As Object
    '        Dim sheet As Object
    '        Dim PrimerHoja As Boolean = True
    '        Dim FolioAnterior As Long
    '        Dim PrecioAnterior As Long
    '        Dim Indice As Integer = 3
    '        Dim path As String
    '        Dim Clave_Linea As String = ""
    '        Dim Miles, Servicios, Envases, EnvasesE, Kilometros, HoraRemision, Importe As Decimal

    '        If Padres Is Nothing Then Exit Sub
    '        If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '        path = fbd.SelectedPath

    '        pgb.Maximum = Padres.Rows.Count * 100

    '        Dim xls = CreateObject("Excel.Application")
    '        For Each Padre As DataRow In Padres.Rows
    '            xls.SheetsInNewWorkbook = 1
    '            book = xls.Workbooks.Add()
    '            If cbx_Sucursales.Checked = True Or cbx_Todos.Checked = True Then
    '                'se selecciona él mismo y a sus subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), False, cmb_Status.SelectedValue)
    '            Else
    '                'se agarra solo a él mismo sin incluir los subclientes
    '                Hijos = Cn_Facturacion.fn_PreFactura_GetHijos(Padre("Id_Cliente"), True, cmb_Status.SelectedValue)
    '            End If
    '            For Each Hijo As DataRow In Hijos.Rows
    '                PrecioAnterior = 0
    '                If Not PrimerHoja Then
    '                    sheet = book.Sheets.Add()
    '                Else
    '                    sheet = book.Sheets(1)
    '                End If
    '                PrimerHoja = False
    '                Try
    '                    sheet.Name = Hijo("Clave")
    '                Finally
    '                End Try

    '                sheet.Cells.Font.Name = "Arial"

    '                sheet.Range("C1:G1").Merge()
    '                sheet.Range("C1:G1").Value = Hijo("Empresa")
    '                sheet.Range("C1:G1").Font.Bold = True
    '                sheet.Range("C1:G1").Font.Size = 12
    '                sheet.Range("C1:G1").HorizontalAlignment = -4108

    '                sheet.Range("C2:G2").Merge()
    '                sheet.Range("C2:G2").Value = Hijo("Direccion")
    '                sheet.Range("C2:G2").Font.Bold = True
    '                sheet.Range("C2:G2").Font.Size = 10
    '                sheet.Range("C2:G2").HorizontalAlignment = -4108

    '                sheet.Range("A3:J3").Merge()
    '                sheet.Range("A3:J3").Value = Hijo("Clave") & " " & Hijo("Cliente")
    '                sheet.Range("A3:J3").Font.Bold = True
    '                sheet.Range("A3:J3").Font.Size = 11
    '                sheet.Range("A3:J3").HorizontalAlignment = -4108

    '                Prefactura = Cn_Facturacion.fn_PreFactura_GetReporte(dtp_Desde.Text, dtp_Hasta.Text, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
    '                CV = Cn_Facturacion.fn_PreFactura_GetCV(dtp_Desde.Text, dtp_Hasta.Text, Hijo("Id_Cliente"), cmb_Status.SelectedValue)
    '                For Each row As DataRow In Prefactura.Rows
    '                    Clave_Linea = Microsoft.VisualBasic.Left(row("Linea"), 3)
    '                    If PrecioAnterior <> row("Id_Precio") Then

    '                        If Indice > 3 Then

    '                            sheet.Range("C" & Indice).Value = "TOTAL"
    '                            sheet.Range("D" & Indice).Value = Miles
    '                            sheet.Range("E" & Indice).Value = Servicios
    '                            sheet.Range("F" & Indice).Value = Envases
    '                            sheet.Range("G" & Indice).Value = EnvasesE
    '                            sheet.Range("H" & Indice).Value = Kilometros
    '                            sheet.Range("J" & Indice).Value = Importe
    '                            sheet.Range("J" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("C" & Indice & ":J" & Indice).Font.Bold = True
    '                            sheet.Range("C" & Indice & ":J" & Indice).Font.Italic = True

    '                            Miles = 0
    '                            Servicios = 0
    '                            Envases = 0
    '                            EnvasesE = 0
    '                            Kilometros = 0
    '                            Importe = 0
    '                            'Indice = 3

    '                        End If

    '                        Indice += 1

    '                        sheet.Range("F" & Indice).Value = "Precio"
    '                        sheet.Range("G" & Indice).Value = "PrecioCR"
    '                        sheet.Range("H" & Indice).Value = "PrecioEE"
    '                        sheet.Range("I" & Indice).Value = "PrecioKM"
    '                        sheet.Range("F" & Indice & ":I" & Indice).Font.Bold = True
    '                        sheet.Range("F" & Indice & ":I" & Indice).Font.Size = 11
    '                        sheet.Range("F" & Indice & ":I" & Indice).HorizontalAlignment = -4108

    '                        Indice += 1

    '                        'precios
    '                        sheet.Range("A" & Indice & ":E" & Indice).Merge()
    '                        sheet.Range("A" & Indice).Value = row("Linea")
    '                        sheet.Range("B" & Indice & ":E" & Indice).Font.Size = 9
    '                        sheet.Range("B" & Indice & ":E" & Indice).HorizontalAlignment = -4108

    '                        sheet.Range("F" & Indice).Value = row("Precio")
    '                        sheet.Range("G" & Indice).Value = row("PrecioCR")
    '                        sheet.Range("H" & Indice).Value = row("PrecioEE")
    '                        sheet.Range("I" & Indice).Value = row("PrecioKM")
    '                        sheet.Range("F" & Indice & ":I" & Indice).Font.Size = 11
    '                        sheet.Range("F" & Indice & ":I" & Indice).NumberFormat = "$#,##0.00"

    '                        Indice += 1
    '                        'cabecera de la tabla
    '                        sheet.Range("A" & Indice).Value = "Folio Servicio"
    '                        sheet.Range("B" & Indice).Value = "Fecha"
    '                        sheet.Range("C" & Indice).Value = "Importe Traslado"
    '                        sheet.Range("D" & Indice).Value = "Miles"
    '                        sheet.Range("E" & Indice).Value = "Cantidad Servicios"
    '                        sheet.Range("F" & Indice).Value = "Envases"
    '                        sheet.Range("G" & Indice).Value = "E. Exceso"
    '                        sheet.Range("H" & Indice).Value = "Kilometros"
    '                        sheet.Range("I" & Indice).Value = "Hora Remision"
    '                        sheet.Range("J" & Indice).Value = "Importe"

    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Underline = True
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 10

    '                        'poner todos los comprobantes de visita que se encuentren
    '                        For ii As Integer = 0 To CV.Rows.Count - 1
    '                            Indice += 1
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Size = 8
    '                            sheet.Range("A" & Indice & ":K" & Indice).Font.Name = "Times New Roman"
    '                            sheet.Range("A" & Indice).Value = CV.Rows(ii)("Numero")
    '                            sheet.Range("B" & Indice).Value = "'" & CV.Rows(ii)("Fecha")
    '                            sheet.Range("C" & Indice).Value = 0
    '                            sheet.Range("D" & Indice).Value = 0
    '                            sheet.Range("E" & Indice).Value = 1
    '                            sheet.Range("F" & Indice).Value = 0
    '                            sheet.Range("G" & Indice).Value = 0
    '                            sheet.Range("H" & Indice).Value = 0
    '                            sheet.Range("I" & Indice).Value = "'" & CV.Rows(ii)("Hora")
    '                            sheet.Range("J" & Indice).Value = CV.Rows(ii)("Precio")
    '                            sheet.Range("J" & Indice).NumberFormat = "$#,##0.00"
    '                            sheet.Range("K" & Indice).Value = "** Comp. Visita"
    '                            Servicios += 1
    '                            Importe += CV.Rows(ii)("Precio")
    '                        Next
    '                        Indice += 1

    '                        PrecioAnterior = row("Id_Precio")
    '                    End If

    '                    If FolioAnterior <> row("Folio_Servicio") Then
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 10
    '                        sheet.Range("A" & Indice).Value = row("Folio_Servicio")
    '                        sheet.Range("B" & Indice).Value = row("Fecha")
    '                        sheet.Range("C" & Indice).Value = row("Importe_Traslado")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("D" & Indice).Value = row("Miles")
    '                        sheet.Range("E" & Indice).Value = 1
    '                        sheet.Range("F" & Indice).Value = row("Envases")
    '                        sheet.Range("G" & Indice).Value = row("Envases_Exceso")
    '                        sheet.Range("H" & Indice).Value = row("Kilometros")
    '                        sheet.Range("J" & Indice).Value = row("Importe")
    '                        sheet.Range("J" & Indice).NumberFormat = "$#,##0.00"


    '                        Miles += row("Miles")
    '                        Servicios += 1
    '                        Envases += row("Envases")
    '                        EnvasesE += row("Envases_Exceso")
    '                        Kilometros += row("Kilometros")
    '                        If Clave_Linea = "SCF" Then
    '                            Importe = row("Precio")
    '                        Else
    '                            Importe += row("Importe")
    '                        End If

    '                        Indice += 1

    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.size = 8
    '                        sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                        sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                        sheet.Range("I" & Indice).Value = row("Hora_Remision")

    '                        Indice += 1

    '                        FolioAnterior = row("Folio_Servicio")
    '                    Else
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Size = 8
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Name = "Times New Roman"
    '                        sheet.Range("A" & Indice & ":J" & Indice).Font.Italic = True
    '                        sheet.Range("B" & Indice).Value = "'" & row("Remision").ToString
    '                        sheet.Range("C" & Indice).Value = row("Importe_Remision")
    '                        sheet.Range("C" & Indice).NumberFormat = "$#,##0.00"
    '                        sheet.Range("F" & Indice).Value = row("Envases_Remision")
    '                        sheet.Range("I" & Indice).Value = row("Hora_Remision")

    '                        Indice += 1

    '                    End If
    '                Next

    '                sheet.Range("C" & Indice).Value = "TOTAL"
    '                sheet.Range("D" & Indice).Value = Miles
    '                sheet.Range("E" & Indice).Value = Servicios
    '                sheet.Range("F" & Indice).Value = Envases
    '                sheet.Range("G" & Indice).Value = EnvasesE
    '                sheet.Range("H" & Indice).Value = Kilometros

    '                sheet.Range("J" & Indice).Value = Importe
    '                sheet.Range("J" & Indice).NumberFormat = "$#,##0.00"
    '                sheet.Range("C" & Indice & ":J" & Indice).Font.Bold = True
    '                sheet.Range("C" & Indice & ":J" & Indice).Font.Italic = True

    '                Miles = 0
    '                Servicios = 0
    '                Envases = 0
    '                EnvasesE = 0
    '                Kilometros = 0
    '                Importe = 0
    '                Indice = 3

    '                pgb.Value = ((Padres.Rows.IndexOf(Padre) * 100) + (((Hijos.Rows.IndexOf(Hijo) + 1) / Hijos.Rows.Count) * 100))
    '            Next
    '            book.SaveAs(path & "\" & Trim(Padre("Clave_Cliente")) & "-" & dtp_Desde.Value.Month & "-" & dtp_Hasta.Value.Year)
    '            'book.Close()
    '            xls.visible = True
    '        Next
    '        pgb.Value = 0
    '        MsgBox("Todos los archivos se han generado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
    '    End If
    'End Sub

#End Region

End Class