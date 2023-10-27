Imports System.IO
Imports Modulo_Facturacion.Cn_PDFCreator

Public Class frm_ConvertirPDF

    Private Sub frm_ConvertirPDF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ExisteExcel As String
            Dim WS As Object = CreateObject("WScript.Shell")
            'Revisar si se tiene Excel 2007
            ExisteExcel = WS.RegRead("HKEY_LOCAL_MACHINE\Software\Microsoft\Office\12.0\Excel\InstallRoot\Path")
            ExisteExcel &= "EXCEL.EXE"
            If File.Exists(ExisteExcel) Then
                rdb_Excel.Enabled = True
                rdb_Excel.Checked = True
            End If
        Catch
        End Try

        'Try
        '    'Activar el PDFCreator
        '    pErr = New PDFCreator.clsPDFCreatorError
        '    rdb_PDFCreator.Enabled = fn_PDFCreator()
        'Catch
        'End Try
    End Sub

    Private Sub btn_Archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Archivo.Click
        SegundosDesconexion = 0

        rtb_Archivo.Clear()
        rtb_Archivo.Tag = Nothing

        With ofd_Archivo
            .Multiselect = False
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Excel 95 - 2003 (*.xls)|*.xls|Excel (*.xlsx)|*.xlsx"
        End With

        If ofd_Archivo.ShowDialog = DialogResult.OK Then
            rtb_Archivo.Text = Path.GetFileNameWithoutExtension(ofd_Archivo.FileName)
            rtb_Archivo.Tag = ofd_Archivo.FileName
        End If

        btn_Convertir.Enabled = rtb_Archivo.TextLength > 0 AndAlso rtb_Destino.TextLength > 0
    End Sub

    Private Sub btn_Destino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Destino.Click
        SegundosDesconexion = 0

        rtb_Destino.Clear()

        If fbd_Destino.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtb_Destino.Text = fbd_Destino.SelectedPath
            If rtb_Destino.TextLength = 3 Then
                rtb_Destino.Text = Microsoft.VisualBasic.Left(rtb_Destino.Text, 2) & "\"
            Else
                rtb_Destino.Text = rtb_Destino.Text & "\"
            End If
        End If

        btn_Convertir.Enabled = rtb_Archivo.TextLength > 0 AndAlso rtb_Destino.TextLength > 0
    End Sub

    Private Sub rdb_PDFCreator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PDFCreator.CheckedChanged
        SegundosDesconexion = 0

        chk_pdf.Checked = False
        chk_jpg.Checked = False
        chk_bmp.Checked = False
        chk_png.Checked = False
        chk_tif.Checked = False
        gbx_TipoConversion.Enabled = rdb_PDFCreator.Checked
    End Sub

    Private Sub btn_Convertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Convertir.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            
            If rdb_Excel.Checked Then
                Dim objExcel = CreateObject("Excel.Application")
                With objExcel
                    .Workbooks.Open(Filename:=rtb_Archivo.Tag)
                    .ActiveSheet.ExportAsFixedFormat(Type:=0, Filename:=rtb_Destino.Text & rtb_Archivo.Text & ".pdf", Quality:=0, IncludeDocProperties:=True, IgnorePrintAreas:=False, OpenAfterPublish:=False)
                End With
                objExcel.ActiveWorkbook.Close()
                objExcel = Nothing
                'Else
                '    If chk_bmp.Checked OrElse chk_jpg.Checked OrElse chk_pdf.Checked OrElse chk_png.Checked OrElse chk_tif.Checked Then
                '        Dim DefaultPrinter As String = _PDFCreator.cDefaultPrinter
                '        If chk_pdf.Checked Then Convertir(0)
                '        If chk_png.Checked Then Convertir(1)
                '        If chk_jpg.Checked Then Convertir(2)
                '        If chk_bmp.Checked Then Convertir(3)
                '        If chk_tif.Checked Then Convertir(5)
                '        _PDFCreator.cDefaultPrinter = DefaultPrinter
                '    Else
                '        MsgBox("Debe de Seleccionar los Tipos de Conversiones que desea realizar.", MsgBoxStyle.Critical, frm_MENU.Text)
                '        Exit Sub
                '    End If
            End If

            MsgBox("Conversión terminada.", MsgBoxStyle.Information, frm_MENU.Text)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub Convertir(ByVal Tipo As Integer)
    '    Dim opt As PDFCreator.clsPDFCreatorOptions = _PDFCreator.cOptions

    '    With opt
    '        .AutosaveDirectory = rtb_Destino.Text
    '        .AutosaveFormat = Tipo
    '        Select Case Tipo
    '            Case 1
    '                .PNGResolution = 100
    '            Case 2
    '                .JPEGQuality = 100
    '                .JPEGResolution = 100
    '            Case 3
    '                .BMPResolution = 100
    '            Case 5
    '                .TIFFResolution = 100
    '        End Select
    '        opt.AutosaveFilename = rtb_Archivo.Text
    '    End With

    '    With _PDFCreator
    '        .cOptions = opt
    '        .cDefaultPrinter = "PDFCreator"
    '        .cPrintFile(rtb_Archivo.Tag)
    '    End With

    '    With tmr_PDF
    '        .Enabled = True
    '        Do While .Enabled
    '            Application.DoEvents()
    '        Loop
    '        .Enabled = False
    '    End With
    '    opt = Nothing
    '    'Dim objExcel = CreateObject("Excel.Application")
    '    'objExcel.Workbooks.Open(Filename:=rtb_Archivo.Tag)
    '    'objExcel.Application.ActivePrinter = "PDFCreator en Ne00:"
    '    'objExcel.ExecuteExcel4Macro("PRINT(1,,,1,,,,,,,,2,""PDFCreator en Ne00:"",,TRUE,,FALSE)")
    '    'objExcel.ActiveWorkbook.Close()
    '    'objExcel = Nothing

    '    'objExcel.ExecuteExcel4Macro("PRINT(1,,,1,,,,,,,,2,,,TRUE,,FALSE)")
    '    'objExcel.Application.ActivePrinter = "PDFCreator"
    'End Sub

    Private Sub tmr_PDF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_PDF.Tick
        tmr_PDF.Enabled = False
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    'Private Sub frm_ConvertirPDF_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    Try
    '        _PDFCreator.cVisible = True
    '        _PDFCreator.cClose()
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(_PDFCreator)
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(pErr)
    '        pErr = Nothing
    '        GC.Collect()
    '        GC.WaitForPendingFinalizers()
    '        GC.Collect()
    '        GC.WaitForPendingFinalizers()
    '    Catch
    '    End Try
    'End Sub

End Class