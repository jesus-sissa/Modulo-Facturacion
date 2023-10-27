Imports Modulo_Facturacion.Cn_Facturacion
Imports Modulo_Facturacion.FuncionesGlobales
Imports System.IO

Public Class frm_Antilavado

    Dim RutaOrigen As String = ""
    Dim RutaDestino As String = ""
    Dim BTipo As Integer = 0
    Dim BTipoP As Integer = 0
    Dim StatusPunto As String = ""
    Dim TipoConsulta As String = ""
    Dim dt_Datos As DataTable
    Dim HayOrigen As Boolean = False
    Dim HayDestino As Boolean = False

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consultar.Click
        Dim Fecha_Desde As Date = dtp_Desde.Value.Date
        Dim Fecha_Hasta As Date = dtp_Hasta.Value.Date

        SegundosDesconexion = 0
        btn_Generar.Enabled = False
        lbl_Inicio.Text = "Hr. Inicio: "
        lbl_Registros.Text = "0 Registros Encontrados"
        lbl_RegistrosG.Text = "0 Registros Exportados"

        If Rdb_Traslado.Checked = False And rdb_TrasladoCus.Checked = False And rdb_Proceso.Checked = False And rdb_Dotaciones.Checked = False Then
            MsgBox("Seleccione el tipo de reporte que desea generar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas seleccionado parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        If Rdb_Traslado.Checked = True Then
            'Solo trasladados que no entran a bóveda
            BTipo = 0
            BTipoP = 0
            StatusPunto = "EN"
            TipoConsulta = "TV"
        ElseIf rdb_TrasladoCus.Checked = True Then
            'Traslados que entran temporalmente a bóveda pero que no se procesan
            BTipo = 1
            BTipoP = 0
            StatusPunto = "RB"
            TipoConsulta = "TC"
        ElseIf rdb_Proceso.Checked = True Then
            'Traslados que entran a bóveda para Procesarse
            BTipo = 2
            BTipoP = 1
            'StatusPunto = "RB"
            StatusPunto = "CO"
            TipoConsulta = "PRO"
        ElseIf rdb_Dotaciones.Checked = True Then
            'Traslados que entran a bóveda para Procesarse
            BTipo = 0
            BTipoP = 0
            StatusPunto = ""
            TipoConsulta = "DO"
        End If
        dt_Datos = fn_Antilavado_GetDatos(Fecha_Desde, Fecha_Hasta, BTipo, BTipoP, StatusPunto, TipoConsulta)
        If dt_Datos Is Nothing Then
            Me.Cursor = Cursors.Default
            MsgBox("Ha ocurrido un error al intentar obtener los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub 'salir si ocurrio error
        End If

        If dt_Datos.Rows.Count = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("No se encontraron datos con los filtros seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_Registros.Text = dt_Datos.Rows.Count.ToString & " Registros Encontrados"
        btn_Generar.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Generar.Click
        Dim Contador As Integer = 0

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
        Dim Suma As String = ""

        Dim book As Object
        Dim sheet As Object

        Dim Fila As Integer = 1
        Dim InicioFila As Integer = 1

        SegundosDesconexion = 0
        lbl_Inicio.Text = "Hr. Inicio: " & DateTime.Now.ToShortTimeString
        Me.Cursor = Cursors.WaitCursor
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
            Me.Cursor = Cursors.Default
            MsgBox("No se encontró un Software de Hoja de Cálculo para poder generar el reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Try
            'Agregar la Hoja al libro
            xls.SheetsInNewWorkbook = 1
            book = xls.Workbooks.Add()

            sheet = book.Sheets.Add()
            sheet.name = "LeyLavado"
            If sheet.name = "Sheet1" Then Suma = "=Sum" Else Suma = "=Sum"
            'Cabecera
            'xls.visible = True

            sheet.Range("A" & Fila).Value = "RFC INFORMANTE"
            sheet.Range("B" & Fila).Value = "RAZON SOCIAL"
            sheet.Range("C" & Fila).Value = "TIPO SERVICIO"
            sheet.Range("D" & Fila).Value = "TIPO CONTRIBUYENTE"
            sheet.Range("E" & Fila).Value = "NOMBRE SUCURSAL"
            sheet.Range("F" & Fila).Value = "NACIONALIDAD"
            sheet.Range("G" & Fila).Value = "RFC INFORMADO"
            sheet.Range("H" & Fila).Value = "RAZON SOCIAL INFORMADO"
            sheet.Range("I" & Fila).Value = "CURP"
            sheet.Range("J" & Fila).Value = "DOMICILIO"
            sheet.Range("K" & Fila).Value = "TIPO CONTRIBUY. RECEPTOR"
            sheet.Range("L" & Fila).Value = "NOMBRE SUCURSAL RECEPTOR"
            sheet.Range("M" & Fila).Value = "RAZON SOCIAL RECEPTOR"
            sheet.Range("N" & Fila).Value = "RFC RECEPTOR"
            sheet.Range("O" & Fila).Value = "FECHA NAC. RECEPTOR"
            sheet.Range("P" & Fila).Value = "DOMICILIO DESTINATARIO"
            sheet.Range("Q" & Fila).Value = "FECHA OPERACION"
            sheet.Range("R" & Fila).Value = "TIPO DE BIEN"
            sheet.Range("S" & Fila).Value = "INSTRUMENTO MONETARIO"
            sheet.Range("T" & Fila).Value = "IMPORTE"
            sheet.Range("U" & Fila).Value = "MONEDA"
            sheet.Range("V" & Fila).Value = "FECHA ENTREGA"
            sheet.Range("W" & Fila).Value = "DOMICILIO RECEPTOR"
            sheet.Range("X" & Fila).Value = "NOMBRE PERSONA AUTORIZADA"
            sheet.Range("Y" & Fila).Value = "DOMICILIO PERSONA AUTORIZADA"
            sheet.Range("A1:" & "Y1").Font.Bold = True

            sheet.Range("A1").ColumnWidth = 13
            sheet.Range("B1").ColumnWidth = 45
            sheet.Range("C1").ColumnWidth = 13
            sheet.Range("D1").ColumnWidth = 13
            sheet.Range("E1").ColumnWidth = 45
            sheet.Range("F1").ColumnWidth = 13
            sheet.Range("G1").ColumnWidth = 13
            sheet.Range("H1").ColumnWidth = 45
            sheet.Range("I1").ColumnWidth = 13
            sheet.Range("J1").ColumnWidth = 65
            sheet.Range("K1").ColumnWidth = 13
            sheet.Range("L1").ColumnWidth = 45
            sheet.Range("M1").ColumnWidth = 45
            sheet.Range("N1").ColumnWidth = 13
            sheet.Range("O1").ColumnWidth = 13
            sheet.Range("P1").ColumnWidth = 65
            sheet.Range("Q1").ColumnWidth = 13
            sheet.Range("R1").ColumnWidth = 13
            sheet.Range("S1").ColumnWidth = 13
            sheet.Range("T1").ColumnWidth = 13
            sheet.Range("U1").ColumnWidth = 13
            sheet.Range("V1").ColumnWidth = 13
            sheet.Range("W1").ColumnWidth = 65
            sheet.Range("X1").ColumnWidth = 35
            sheet.Range("Y1").ColumnWidth = 35

            pgb.Maximum = dt_Datos.Rows.Count + 1
            If TipoConsulta = "DO" Then
                'Cuando son Dotaciones el Origen es la caja bancaria y no el cliente
                For Each Dr_Registro As DataRow In dt_Datos.Rows
                    Fila += 1
                    SegundosDesconexion = 0
                    'RFC Informante
                    sheet.Range("A" & Fila).Value = "SIS850415B31"
                    'Razon Social Informante
                    sheet.Range("B" & Fila).Value = "SERVICIO INTEGRAL DE SEGURIDAD, S.A. DE C.V."
                    'Tipo Servicio
                    If TipoConsulta = "TV" Or TipoConsulta = "DO" Then
                        sheet.Range("C" & Fila).Value = "1" '1=TV; 2=Cus; 3=TV y Cus
                    Else
                        sheet.Range("C" & Fila).Value = "3" '1=TV; 2=Cus; 3=TV y Cus
                    End If
                    'Tipo Cliente Contratante
                    If Dr_Registro("OrigenRFC").ToString.Length = 13 Then
                        sheet.Range("D" & Fila).Value = "1" 'Persona Fisica
                    Else
                        sheet.Range("D" & Fila).Value = "2" 'Persona Moral
                    End If
                    'Nombre Sucursal cuando sea Banco
                    If InStr(Dr_Registro("OrigenFiscal").ToString, "BANC") > 0 Or InStr(Dr_Registro("OrigenFiscal").ToString, "SANTANDER") > 0 _
                        Or InStr(Dr_Registro("OrigenFiscal").ToString, "SCOTIA") > 0 Or InStr(Dr_Registro("OrigenFiscal").ToString, "MULTIVA") > 0 _
                        Or InStr(Dr_Registro("OrigenFiscal").ToString, "HSBC") > 0 Then
                        sheet.Range("E" & Fila).Value = Dr_Registro("Origen").ToString
                    Else
                        sheet.Range("E" & Fila).Value = "N/A"
                    End If

                    'Nacionalidad
                    sheet.Range("F" & Fila).Value = "1" '1=Mexicana; 2=Extranjero
                    'RFC del Informado
                    sheet.Range("G" & Fila).Value = Dr_Registro("OrigenRFC").ToString
                    'Nombre del Informado
                    sheet.Range("H" & Fila).Value = Dr_Registro("OrigenFiscal")
                    'CURP
                    sheet.Range("I" & Fila).Value = "N/A"
                    'Domicilio del Informado
                    sheet.Range("J" & Fila).Value = Dr_Registro("OrigenDomicilioC")
                    'Tipo Contribuyente Receptor
                    If Dr_Registro("DestinoRFC").ToString.Length = 13 Then
                        sheet.Range("K" & Fila).Value = "1"
                    Else
                        sheet.Range("K" & Fila).Value = "2"
                    End If
                    'Nombre Sucursal Receptor cuando sea Banco
                    If InStr(Dr_Registro("DestinoFiscal").ToString, "BANC") > 0 Or InStr(Dr_Registro("DestinoFiscal").ToString, "SANTANDER") > 0 _
                        Or InStr(Dr_Registro("DestinoFiscal").ToString, "SCOTIA") > 0 Or InStr(Dr_Registro("DestinoFiscal").ToString, "MULTIVA") > 0 _
                        Or InStr(Dr_Registro("DestinoFiscal").ToString, "HSBC") > 0 Then
                        sheet.Range("L" & Fila).Value = Dr_Registro("Origen").ToString
                    Else
                        sheet.Range("L" & Fila).Value = "N/A"
                    End If
                    'Razon Social Destinatario
                    sheet.Range("M" & Fila).Value = Dr_Registro("OrigenFiscal")
                    'RFC Destinatario
                    sheet.Range("N" & Fila).Value = Dr_Registro("OrigenRFC")
                    'Fecha de Nacimiento
                    If Dr_Registro("DestinoRFC").ToString.Length = 13 Then 'P. Fisica
                        sheet.Range("O" & Fila).Value = ""
                    Else
                        sheet.Range("O" & Fila).Value = "N/A" 'P. Moral
                    End If
                    'Domicilio Completo Destinatario
                    sheet.Range("P" & Fila).Value = Dr_Registro("OrigenDomicilioC")
                    'Fecha Operacion
                    sheet.Range("Q" & Fila).Value = Dr_Registro("Fecha")
                    'Tipo de Bien: 1=Instrumento Monetario; 2=Piedras o Metales Preciosos; 3...
                    If Dr_Registro("Id_Moneda") = 1 Or Dr_Registro("Id_Moneda") = 2 Or Dr_Registro("Id_Moneda") = 3 Then
                        sheet.Range("R" & Fila).Value = "1"
                        'Instrumento Monetario: 1=Efectivo
                        sheet.Range("S" & Fila).Value = "1"
                    Else
                        sheet.Range("R" & Fila).Value = "2"
                        'Instrumento Monetario: 1=Efectivo
                        sheet.Range("S" & Fila).Value = "N/A"
                    End If
                    'Importe o Valor
                    sheet.Range("T" & Fila).Value = Dr_Registro("Importe_Efectivo") + IIf(IsDBNull(Dr_Registro("Importe_Documentos")), 0, Dr_Registro("Importe_Documentos"))
                    'Tipo Moneda: 1=Peso; 2=Dolar; 3=Euro
                    If Dr_Registro("Id_Moneda") = 1 Or Dr_Registro("Id_Moneda") = 2 Or Dr_Registro("Id_Moneda") = 3 Then
                        sheet.Range("U" & Fila).Value = Dr_Registro("Id_Moneda")
                    Else
                        sheet.Range("U" & Fila).Value = "4"
                    End If
                    'Fecha_Entrega
                    sheet.Range("V" & Fila).Value = Dr_Registro("Fecha")
                    'Domicilio Receptor
                    sheet.Range("W" & Fila).Value = Dr_Registro("OrigenDomicilioC")
                    'Nombre Persona Autorizada
                    sheet.Range("X" & Fila).Value = "N/A"
                    'Domicilio Persona Autorizada
                    sheet.Range("Y" & Fila).Value = "N/A"
                    pgb.Value += 1
                    If pgb.Value = pgb.Maximum Then pgb.Maximum += 1
                    Contador += 1
                    lbl_RegistrosG.Text = Contador.ToString & " Registros Exportados"
                Next
            Else 'TV, TC, PRO
                For Each Dr_Registro As DataRow In dt_Datos.Rows
                    Fila += 1
                    SegundosDesconexion = 0
                    'RFC Informante
                    sheet.Range("A" & Fila).Value = "SIS850415B31"
                    'Razon Social Informante
                    sheet.Range("B" & Fila).Value = "SERVICIO INTEGRAL DE SEGURIDAD, S.A. DE C.V."
                    'Tipo Servicio
                    If TipoConsulta = "TV" Or TipoConsulta = "DO" Then
                        sheet.Range("C" & Fila).Value = "1" '1=TV; 2=Cus; 3=TV y Cus
                    Else
                        sheet.Range("C" & Fila).Value = "3" '1=TV; 2=Cus; 3=TV y Cus
                    End If
                    'Tipo Cliente Contratante
                    If Dr_Registro("OrigenRFC").ToString.Length = 13 Then
                        sheet.Range("D" & Fila).Value = "1" 'Persona Fisica
                    Else
                        sheet.Range("D" & Fila).Value = "2" 'Persona Moral
                    End If
                    'Nombre Sucursal cuando sea Banco
                    If InStr(Dr_Registro("OrigenFiscal").ToString, "BANC") > 0 Or InStr(Dr_Registro("OrigenFiscal").ToString, "SANTANDER") > 0 _
                        Or InStr(Dr_Registro("OrigenFiscal").ToString, "SCOTIA") > 0 Or InStr(Dr_Registro("OrigenFiscal").ToString, "MULTIVA") > 0 _
                        Or InStr(Dr_Registro("OrigenFiscal").ToString, "HSBC") > 0 Then
                        sheet.Range("E" & Fila).Value = Dr_Registro("Origen").ToString
                    Else
                        sheet.Range("E" & Fila).Value = "N/A"
                    End If
                    'Nacionalidad
                    sheet.Range("F" & Fila).Value = "1" '1=Mexicana; 2=Extranjero
                    'RFC del Informado
                    sheet.Range("G" & Fila).Value = Dr_Registro("OrigenRFC").ToString
                    'Nombre del Informado
                    sheet.Range("H" & Fila).Value = Dr_Registro("OrigenFiscal")
                    'CURP
                    sheet.Range("I" & Fila).Value = "N/A"
                    'Domicilio del Informado
                    sheet.Range("J" & Fila).Value = Dr_Registro("OrigenDomicilioC")
                    'Tipo Contribuyente Receptor
                    If Dr_Registro("DestinoRFC").ToString.Length = 13 Then
                        sheet.Range("K" & Fila).Value = "1"
                    Else
                        sheet.Range("K" & Fila).Value = "2"
                    End If
                    'Nombre Sucursal Receptor cuando sea Banco
                    If InStr(Dr_Registro("DestinoFiscal").ToString, "BANC") > 0 Or InStr(Dr_Registro("DestinoFiscal").ToString, "SANTANDER") > 0 _
                        Or InStr(Dr_Registro("DestinoFiscal").ToString, "SCOTIA") > 0 Or InStr(Dr_Registro("DestinoFiscal").ToString, "MULTIVA") > 0 _
                        Or InStr(Dr_Registro("DestinoFiscal").ToString, "HSBC") > 0 Then
                        sheet.Range("L" & Fila).Value = Dr_Registro("Destino").ToString
                    Else
                        sheet.Range("L" & Fila).Value = "N/A"
                    End If
                    'Razon Social Destinatario
                    sheet.Range("M" & Fila).Value = Dr_Registro("DestinoFiscal")
                    'RFC Destinatario
                    sheet.Range("N" & Fila).Value = Dr_Registro("DestinoRFC")
                    'Fecha de Nacimiento
                    If Dr_Registro("DestinoRFC").ToString.Length = 13 Then 'P. Fisica
                        sheet.Range("O" & Fila).Value = ""
                    Else
                        sheet.Range("O" & Fila).Value = "N/A" 'P. Moral
                    End If
                    'Domicilio Completo Destinatario
                    sheet.Range("P" & Fila).Value = Dr_Registro("DestinoDomicilioC")
                    'Fecha Operacion
                    sheet.Range("Q" & Fila).Value = Dr_Registro("Fecha")
                    'Tipo de Bien: 1=Instrumento Monetario; 2=Piedras o Metales Preciosos; 3...
                    If Dr_Registro("Id_Moneda") = 1 Or Dr_Registro("Id_Moneda") = 2 Or Dr_Registro("Id_Moneda") = 3 Then
                        sheet.Range("R" & Fila).Value = "1"
                        'Instrumento Monetario: 1=Efectivo
                        sheet.Range("S" & Fila).Value = "1"
                    Else
                        sheet.Range("R" & Fila).Value = "2"
                        'Instrumento Monetario: 1=Efectivo
                        sheet.Range("S" & Fila).Value = "N/A"
                    End If

                    'Importe o Valor
                    If TipoConsulta = "PRO" Then
                        sheet.Range("T" & Fila).Value = Dr_Registro("Importe_Efectivo") + Dr_Registro("Importe_Documentos") + Dr_Registro("Importe_Otros")
                    Else
                        sheet.Range("T" & Fila).Value = Dr_Registro("Importe_Efectivo") + Dr_Registro("Importe_Documentos")
                    End If

                    'Tipo Moneda: 1=Peso; 2=Dolar; 3=Euro
                    If Dr_Registro("Id_Moneda") = 1 Or Dr_Registro("Id_Moneda") = 2 Or Dr_Registro("Id_Moneda") = 3 Then
                        sheet.Range("U" & Fila).Value = Dr_Registro("Id_Moneda")
                    Else
                        sheet.Range("U" & Fila).Value = "4"
                    End If
                    'Fecha_Entrega
                    sheet.Range("V" & Fila).Value = Dr_Registro("Fecha")
                    'Domicilio Receptor
                    sheet.Range("W" & Fila).Value = Dr_Registro("DestinoDomicilioC")
                    'Nombre Persona Autorizada
                    sheet.Range("X" & Fila).Value = "N/A"
                    'Domicilio Persona Autorizada
                    sheet.Range("Y" & Fila).Value = "N/A"
                    pgb.Value += 1
                    If pgb.Value = pgb.Maximum Then pgb.Maximum += 1
                    Contador += 1
                    lbl_RegistrosG.Text = Contador.ToString & " Registros Exportados"
                Next
            End If

            'TOTAL
            pgb.Value = pgb.Maximum
            xls.visible = True
            xls = Nothing
            Me.Cursor = Cursors.Default
            MsgBox("Archivo generado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            pgb.Value = 0
        Catch ex As Exception
            xls.visible = True
            xls = Nothing
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrio un error durante la generación de la Hoja de Excel. " & ex.Message, MsgBoxStyle.Information, frm_MENU.Text)
            pgb.Value = 0
        End Try
    End Sub

    Private Sub btn_Origen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Origen.Click
        HayOrigen = False
        btn_Destino.Enabled = False
        SegundosDesconexion = 0
        RutaOrigen = ""
        tbx_Origen.Clear()
        Dim DialogoOrigen As New OpenFileDialog
        DialogoOrigen.Title = "Abrir Archivo..."
        DialogoOrigen.Filter = "Libro de Excel 2007-2016 (*.xlsx)|*.xlsx"
        If DialogoOrigen.ShowDialog = DialogResult.OK Then
            RutaOrigen = DialogoOrigen.FileName.ToString
            tbx_Origen.Text = RutaOrigen.Trim
            tbx_Origen.Tag = System.IO.Path.GetFileNameWithoutExtension(tbx_Origen.Text.Trim)
            HayOrigen = True
            btn_Destino.Enabled = True
        End If
        If HayOrigen And HayDestino Then
            btn_Txt.Enabled = True
        Else
            btn_Txt.Enabled = False
        End If
    End Sub

    Private Sub btn_Destino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Destino.Click
        HayDestino = False
        SegundosDesconexion = 0
        RutaDestino = ""
        tbx_Destino.Clear()
        Dim DialogoDestino As New SaveFileDialog
        DialogoDestino.Title = "Guardar Como..."
        DialogoDestino.Filter = "Texto Plano TXT (*.txt)|*.txt"
        DialogoDestino.DefaultExt = "txt"
        DialogoDestino.OverwritePrompt = True
        DialogoDestino.FileName = tbx_Origen.Tag
        If DialogoDestino.ShowDialog = DialogResult.OK Then
            RutaDestino = DialogoDestino.FileName.ToString
            tbx_Destino.Text = RutaDestino.Trim
            HayDestino = True
        End If
        If HayOrigen And HayDestino Then
            btn_Txt.Enabled = True
        Else
            btn_Txt.Enabled = False
        End If
    End Sub

    Private Sub btn_Txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Txt.Click
        Dim Linea As String = ""
        Dim ILocal As Integer = 0
        Dim FilasTotales As Integer = 0
        pgb.Value = 0
        If dt_Datos IsNot Nothing Then dt_Datos.Dispose()
        btn_Generar.Enabled = False
        SegundosDesconexion = 0
        If tbx_Origen.Text.Trim = "" Then
            MsgBox("No ha seleccionado un Archivo Origen...", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        If tbx_Destino.Text.Trim = "" Then
            MsgBox("No ha seleccionado un Archivo Destino...", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
        Dim Suma As String = ""
        Me.Cursor = Cursors.WaitCursor
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
            Me.Cursor = Cursors.Default
            MsgBox("No se encontró un Software de Hoja de Cálculo para poder generar el reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Abrir el Excel para lextura
        Dim Libro = xls.Workbooks.Open(tbx_Origen.Text.Trim)
        Dim Hoja = Libro.Sheets(1)

        'Hacer Prueba con el libro abierto
        'Dim lc_dt As New DataTable
        'lc_dt.Columns.Add("Id")
        'For Each Valor As Object In Hoja.Range("A1:W1")
        '    lc_dt.Columns.Add(Valor.Value)
        'Next
        'lc_dt.Dispose()
        lbl_Inicio.Text = "Hr. Inicio: " & DateTime.Now.ToShortTimeString
        'Contar las Filas
        FilasTotales = 0
        For Each Elemento In Hoja.Rows
            If Elemento.Cells(1, 1).Value Is Nothing Then
                Exit For
            Else
                FilasTotales += 1
            End If

        Next
        'O, Q, V son fechas y deben estar en el formato aa/mm/dd

        pgb.Maximum = FilasTotales
        lbl_Registros.Text = FilasTotales.ToString & " Registros Exportados"
        'Abrir el TXT para Escritura
        FileOpen(1, RutaDestino, OpenMode.Output)
        Dim Cadena As String
        Dim Contador As Integer = 0
        For Each Elemento In Hoja.Rows
            SegundosDesconexion = 0
            Linea = ""
            If Elemento.Cells(1, 1).Value Is Nothing Then Exit For

            For ILocal = 1 To 25

                If Elemento.Cells(1, ILocal).Value Is Nothing Then
                    Cadena = ""
                Else
                    Cadena = Elemento.Cells(1, ILocal).Value.ToString.Trim
                    If Cadena.Trim.Length = 10 Then
                        If Cadena.Substring(4, 1) = "." And Cadena.Substring(7, 1) = "." Then
                            'Es fecha y se debe cambiar al formato "aa/mm/dd"
                            Cadena = Cadena.Substring(2, 8)
                            Cadena = Cadena.Replace(".", "/")
                        End If
                    End If
                    Linea &= Cadena
                End If


                If ILocal < 25 Then Linea &= "|"
            Next
            WriteLine(1, Linea.ToCharArray)
            pgb.Value += 1
            If pgb.Value = pgb.Maximum Then pgb.Maximum += 1
            Contador += 1
            lbl_RegistrosG.Text = Contador.ToString & " Registros Exportados"
        Next
        'Cerrar el TXT
        FileClose(1)
        'Cerrar el Excel
        xls.Workbooks.close()
        xls.Quit()
        xls = Nothing

        pgb.Value = pgb.Maximum
        Me.Cursor = Cursors.Default
        MsgBox("Archivo Terminado...", MsgBoxStyle.Information, frm_MENU.Text)
        pgb.Value = 0
    End Sub

    Private Sub Rdb_Traslado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdb_Traslado.CheckedChanged
        Call Limpiar()
    End Sub

    Private Sub rdb_TrasladoCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_TrasladoCus.CheckedChanged
        Call Limpiar()
    End Sub

    Private Sub rdb_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Proceso.CheckedChanged
        Call Limpiar()
    End Sub

    Private Sub rdb_Dotaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Dotaciones.CheckedChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call Limpiar()
    End Sub

    Sub Limpiar()
        SegundosDesconexion = 0
        lbl_Inicio.Text = "Hr. Inicio: "
        btn_Generar.Enabled = False
        lbl_Registros.Text = "0 Registros Encontrados"
        lbl_RegistrosG.Text = "0 Registros Exportados"
        btn_Destino.Enabled = False
        If dt_Datos IsNot Nothing Then dt_Datos.Dispose()
        pgb.Value = 0
        HayOrigen = False
        HayDestino = False
        btn_Txt.Enabled = False
    End Sub

    Private Sub frm_Antilavado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class