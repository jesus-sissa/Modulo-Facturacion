Public Class frm_PreFacturaProceso

    Private Sub frm_PreFacturaProceso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

        cmb_Clientes.Actualizar()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim Conceptos As DataTable = Cn_Facturacion.fn_PreFacturaProceso_Consultar(cmb_Clientes.SelectedValue)
        Dim Detalles As DataTable
        Dim Libro As Object
        Dim Hoja As Object
        Dim PrimerHoja As Boolean = True
        Dim Fila As Integer = 0
        Dim Clave_Linea As String = ""
        Dim DT As DataTable

        If Conceptos Is Nothing Then
            Me.Cursor = Cursors.Default
            MsgBox("No se encontró información para la Caja Bancaria seleccionada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        If Conceptos.Rows.Count = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("No se encontró información para la Caja Bancaria seleccionada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If
        pgb.Maximum = Conceptos.Rows.Count + 1
        pgb.Value = 0
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim xls As Object
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
            MsgBox("Es probable que no tenga instalado un sotware de Hoja de Cálculo ya que no se pudo generar el archivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Try
            xls.SheetsInNewWorkbook = 1
            Libro = xls.Workbooks.Add()
            Dim GrupoAnterior As Integer = 0

            Fila += 1
            xls.Range("A" & Fila & ":F" & Fila).Merge()
            xls.Range("A" & Fila).Value = "FACTURACION DE PROCESO"
            Fila += 1
            xls.Range("A" & Fila & ":F" & Fila).Merge()
            xls.Range("A" & Fila).Value = cmb_Clientes.Text
            Fila += 1
            xls.Range("A" & Fila & ":F" & Fila).Merge()
            xls.Range("A" & Fila).Value = dtp_Desde.Value.ToShortDateString & " AL " & dtp_Hasta.Value.ToShortDateString

            xls.Range("A1:A3").Font.Bold = True

            Fila += 2
            xls.Range("A" & Fila).Value = "Grupo"
            xls.Range("B" & Fila).Value = "Concepto"
            xls.Range("C" & Fila).Value = "Cantidad"
            xls.Range("D" & Fila).Value = "Precio"
            xls.Range("E" & Fila).Value = "Importe"
            xls.Range("F" & Fila).Value = "Subtotal"
            xls.Range("A" & Fila & ":F" & Fila).font.bold = True
            For Each Concepto As DataRow In Conceptos.Rows
                If GrupoAnterior <> Concepto("Id_GrupoF") Then
                    Fila += 1
                    xls.Range("A" & Fila).Value = Concepto("Grupo")
                    GrupoAnterior = Concepto("Id_GrupoF")
                End If
                Fila += 1
                xls.Range("B" & Fila).Value = Concepto("Concepto")
                'Ejecutar la Formula
                DT = Cn_Facturacion.fn_PreFacturaProceso_EjecutaFormula(CInt(cmb_Clientes.SelectedValue), CInt(Concepto("Id_GrupoF")), dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Concepto("Formula"))
                If DT.Rows.Count > 0 Then
                    xls.Range("C" & Fila).Value = DT.Rows(0)("Cantidad")
                Else
                    xls.Range("C" & Fila).Value = "0.00"
                End If
                xls.Range("C" & Fila).NumberFormat = "#,##0.00"

                ''se agarra solo a él mismo sin incluir los subclientes
                'Detalles = Cn_Facturacion.fn_PreFactura_GetHijos(dtp_Desde.Text, dtp_Hasta.Text, 0, 0, True, "A")
                'For Each Detalle As DataRow In Detalles.Rows
                '    If Not PrimerHoja Then
                '        Hoja = Libro.Sheets.Add()
                '    Else
                '        Hoja = Libro.Sheets(1)
                '    End If
                '    PrimerHoja = False
                '    Hoja.Cells.Font.Name = "Arial"
                '    Hoja.Range("C1:G1").Merge()
                '    Hoja.Range("C1:G1").Value = "" 'Hijo("Empresa")
                '    Hoja.Range("C1:G1").Font.Bold = True
                '    Hoja.Range("C1:G1").Font.Size = 12
                '    Hoja.Range("C1:G1").HorizontalAlignment = -4108
                'Next
                pgb.Value += 1
            Next
            xls.Range("A1:F1").EntireColumn.AutoFit()
            xls.visible = True
            pgb.Value = 0
            pgb.Value = pgb.Maximum
            Me.Cursor = Cursors.Default
            MsgBox("Prefactura Generada Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Catch ex As Exception
            pgb.Value = 0
            FuncionesGlobales.TrataEx(ex)
        End Try
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        pgb.Value = 0
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()

    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then cmb_Clientes.Focus()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        pgb.Value = 0
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        pgb.Value = 0
    End Sub
End Class