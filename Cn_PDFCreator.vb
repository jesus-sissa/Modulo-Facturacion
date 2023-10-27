Imports System.IO

Public Class Cn_PDFCreator

    Public Shared WithEvents _PDFCreator As PDFCreator.clsPDFCreator
    Public Shared pErr As PDFCreator.clsPDFCreatorError

    Public Shared Function fn_PDFCreator() As Boolean
        Try
            _PDFCreator = New PDFCreator.clsPDFCreator
            If _PDFCreator.cStart("/NoProcessingAtStartup") = True Then
                _PDFCreator.cVisible = False
                _PDFCreator.cClearCache()
                _PDFCreator.cOption("UseAutosave") = 1
                _PDFCreator.cOption("UseAutosaveDirectory") = 1
                _PDFCreator.cPrinterStop = False
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Sub _PDFCreator_eError() Handles _PDFCreator.eError
        pErr = _PDFCreator.cError
    End Sub

End Class
