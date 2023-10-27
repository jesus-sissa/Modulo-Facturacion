Public Class frm_AgregaRemision

    Public dt_Dinero As DataTable
    Public dt_Paso As DataTable
    Private lc_CantEnvases As Integer = 0
    Private dt_Envases As DataTable

    Public Id_Movimiento As Long

    '1=Validar Movimientos 2=Agregar Movimiento Manual
    Public Origen As Integer

    Private Sub frm_AgregaRemision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyValue

            Case Keys.Escape
                If Btn_Cancelar.Enabled Then Me.Close()

            Case Keys.F3
                If Btn_Agregar.Enabled Then Btn_Agregar_Click(Btn_Agregar, Nothing)

            Case Keys.F4
                If btn_Eliminar.Enabled Then btn_Eliminar_Click(btn_Eliminar, Nothing)

            Case Keys.F5
                If Btn_Guardar.Enabled Then Btn_Guardar_Click(Btn_Guardar, Nothing)

            Case Keys.F6
                If btn_Comprobar.Enabled Then btn_Comprobar_Click(btn_Comprobar, Nothing)

        End Select

    End Sub

    Private Sub frm_AgregaRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = True
        lbl_Movimiento.Text = Id_Movimiento

        dt_Paso = Cn_Facturacion.fn_MonedasGridView()
        If dt_Paso Is Nothing Then
            Me.Close()
            Exit Sub
        End If
        dgv_Dinero.DataSource = dt_Paso

        dt_Dinero = Cn_Facturacion.fn_MonedasGridView()
        dgv_Dinero.DataSource = dt_Dinero

        FormatoGrid()
        Btn_Guardar.Enabled = False

        cmb_TipoEnvase.Actualizar()

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        End If

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)

        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

        tbx_TotalRemision.Text = "0.00"
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        tbx_Remision.Tag = 0
        Me.Close()
    End Sub


    Private Sub FormatoGrid()

        With dgv_Dinero.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(dgv_Dinero.Font, FontStyle.Bold)
        End With

        With dgv_Dinero
            .Name = "dgDinero"

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .Columns(0).Name = "Id_Moneda"
            .Columns(0).Visible = False

            .Columns(1).Name = "Moneda"
            .Columns(1).Width = 70
            .Columns(1).ReadOnly = True

            .Columns(2).Name = "Importe Efectivo"
            .Columns(2).ReadOnly = False
            .Columns(2).Width = 145
            .Columns(2).DefaultCellStyle.Format = "N2"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).Name = "Importe Documentos"
            .Columns(3).ReadOnly = False
            .Columns(3).Width = 150
            .Columns(3).DefaultCellStyle.Format = "N2"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(4).Name = "TipoCambio"
            .Columns(4).ReadOnly = True
            .Columns(4).Width = 80
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            '.Columns(4).DefaultCellStyle.Font = _
            '    New Font(Me.dgDinero.DefaultCellStyle.Font, FontStyle.Italic)

            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .MultiSelect = False

        End With


    End Sub

    Private Sub dgDinero_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Dinero.CellFormatting
        'If Me.dgDinero.Columns(e.ColumnIndex).Name = "Importe Efectivo" Then

        '    If e IsNot Nothing Then
        '        If e.Value IsNot Nothing Then
        '            Try
        '                'e.Value = DateTime.Parse(e.Value.ToString()).ToLongDateString()
        '                e.Value = Integer.Parse(e.Value.ToString).ToString
        '                e.FormattingApplied = True
        '            Catch ex As FormatException
        '                Console.WriteLine("{0} is not a valid date.", e.Value.ToString())
        '            End Try
        '        End If
        '    End If

        'End If

    End Sub

    Private Sub dgDinero_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Dinero.DataError

        MsgBox("Dato no válido. Capture un número.", MsgBoxStyle.Critical, frm_MENU.Text)
        'dgDinero.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0.00"
        'dgDinero.CurrentCell.Value = "1584"


    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        ' If ValidaGrid() > 0 Then
        If tbx_TotalRemision.Text = "" Then tbx_TotalRemision.Text = 0

        If tbx_Remision.Text.Trim <> "" Then
            If lsv_Envases.Items.Count + CInt(tbx_EnvasesSn.Text) = 0 Then
                MsgBox("Indique por lo menos un Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Numero.Focus()
                Exit Sub
            End If
            If Origen = 1 Then 'Al Validar un movimiento
                If tbx_Remision.Tag = 0 Then
                    If Cn_Facturacion.fn_Remision_Guardar(tbx_Remision.Text, lsv_Envases.Items.Count, tbx_EnvasesSn.Text, ValidaGrid(), CiaId, dt_Dinero, lsv_Envases, Id_Movimiento) Then
                        MsgBox("Se guardó con exito", MsgBoxStyle.Information, frm_MENU.Text)
                        LimpiarPantalla()
                        Me.Close()
                    End If
                ElseIf tbx_Remision.Tag > 0 Then
                    'Solo Ligarlo
                    Cn_Facturacion.fn_MovimientosD_Guardar(Id_Movimiento, tbx_Remision.Tag)
                    MsgBox("Se guardó con exito", MsgBoxStyle.Information, frm_MENU.Text)
                    LimpiarPantalla()
                    Me.Close()
                End If
            ElseIf Origen = 2 Then 'Al agregar un Movimiento Nuevo
                If tbx_Remision.Tag = 0 Then
                    Dim Remi As Long = 0
                    Remi = Cn_Facturacion.fn_Remision_Guardar2(tbx_Remision.Text, lsv_Envases.Items.Count, tbx_EnvasesSn.Text, ValidaGrid(), CiaId, dt_Dinero, lsv_Envases, Id_Movimiento)
                    If Remi > 0 Then
                        MsgBox("Se guardó con exito", MsgBoxStyle.Information, frm_MENU.Text)
                        LimpiarPantalla()
                        tbx_Remision.Tag = Remi 'Id Remision resultante
                        Me.Close()
                    Else
                        MsgBox("Hubo un problema al intentar Guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                ElseIf tbx_Remision.Tag > 0 Then
                    LimpiarPantalla()
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Indique el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        'Else
        'MsgBox("El Importe debe ser Mayor que Cero.", MsgBoxStyle.Critical, frm_MENU.Text)
        'End If 'ValidaGrid
    End Sub

    Private Sub lbl_TotalEnvases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lbl_TotalEnvases.Text = 0 Then
            Btn_Guardar.Enabled = False
        Else
            If tbx_Remision.Text.Trim <> "" Then
                Btn_Guardar.Enabled = True
            End If
        End If
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If tbx_Numero.Text = "" Then
            MsgBox("Capture un Número de Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If
        If cmb_TipoEnvase.SelectedValue = 0 Then
            MsgBox("Seleccione un Tipo de Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoEnvase.Focus()
            Exit Sub
        End If

        'If cmb_TipoEnvase.SelectedValue = 0 Or tbx_Numero.Text.Trim = "" Then
        '    Exit Sub
        'Else
        If ValidaEnvase() = True Then

            lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
            lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = cmb_TipoEnvase.SelectedValue.ToString
            lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(tbx_Numero.Text)
        Else
            MsgBox("Envase ya capturado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If

        'End If
        tbx_Numero.Clear()
        tbx_Numero.Focus()
        Btn_Agregar.Enabled = False
        CalculaEnvases()
    End Sub

    Private Function ValidaEnvase() As Boolean
        Dim Elemento As ListViewItem
        For Each Elemento In lsv_Envases.Items
            If Elemento.SubItems(1).Text = tbx_Numero.Text Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub cmb_TipoEnvase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEnvase.SelectedIndexChanged
        validabotonagregar()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        validabotonagregar()
    End Sub

    Private Sub ValidaBotonAgregar()
        If cmb_TipoEnvase.SelectedValue <> 0 And tbx_Numero.Text <> "" Then
            'If tbx_Numero.Text.Trim <> "" Then
            Btn_Agregar.Enabled = True
            'End If
        Else
            Btn_Agregar.Enabled = False
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Envases.Items(lsv_Envases.SelectedItems(0).Index).Remove()
        CalculaEnvases()
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        If lsv_Envases.SelectedItems.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub tbx_EnvasesSn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_EnvasesSn.TextChanged
        CalculaEnvases()
    End Sub

    Private Sub CalculaEnvases()
        Dim lc_TotalEnvases As Integer = 0
        lc_CantEnvases = lsv_Envases.Items.Count
        If tbx_EnvasesSn.Text.Trim = "" Then
            tbx_EnvasesSn.Text = 0
        End If
        lc_TotalEnvases = tbx_EnvasesSn.Text + lc_CantEnvases
        lbl_TotalEnvases.Text = lc_TotalEnvases
        If lbl_TotalEnvases.Text > 0 Then
            Btn_Guardar.Enabled = True
        Else
            Btn_Guardar.Enabled = False
        End If
    End Sub

    Private Function ValidaGrid() As Decimal
        Dim lc_Dr As DataRow
        Dim lc_Efectivo As Decimal = 0.0
        Dim lc_Documento As Decimal = 0.0
        For Each lc_Dr In dt_Dinero.Rows
            lc_Efectivo += (lc_Dr(2) * lc_Dr(4))
            lc_Documento += (lc_Dr(3) * lc_Dr(4))
        Next
        Return lc_Efectivo + lc_Documento
    End Function

    Private Sub LimpiarPantalla()
        tbx_Remision.Clear()
        dt_Dinero = Cn_Facturacion.fn_MonedasGridView()
        dgv_Dinero.DataSource = dt_Dinero
        FormatoGrid()
        lsv_Envases.Items.Clear()
        tbx_EnvasesSn.Text = ""
        Btn_Guardar.Enabled = False
    End Sub

    Private Sub btn_Comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Comprobar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call Comprobar()
    End Sub

    Sub Comprobar()
        'Revisar si la remision existe.
        'Si existe hay que desplegarla
        'Si no, avisarle al usuario para que la capture
        Dim dt As DataTable
        Dim Id_Remision As Long = 0
        If tbx_Remision.Text = "" Then
            MsgBox("Indique el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        dt = Cn_Facturacion.fn_ConsultaIdRemision(tbx_Remision.Text)
        If dt IsNot Nothing Then
            If dt.Rows.Count = 0 Then
                'No se encontró la remision
                tbx_Remision.Tag = 0
                MsgBox("La Remisión no se encontró y Debe capturarla.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
            'Si se encontró y hay que consultarla
            Id_Remision = dt.Rows(0)("Id_Remision")
            tbx_Remision.Tag = Id_Remision
            MsgBox("El Número de Remisión ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            dt_Paso = Cn_Facturacion.fn_ConsultaRemisionesD(Id_Remision)
            CargaDatosEnvases()
            If dt_Paso IsNot Nothing Then
                LlenaGridDinero()
            End If
            'CalculaImporteTotal()
            Call CalculaTotalGrid()
            Btn_Guardar.Enabled = True
        Else
            'No se encontró la remision
            tbx_Remision.Tag = 0
            Btn_Guardar.Enabled = True
            MsgBox("La Remisión no se encontró y Debe capturarla.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub CargaDatosEnvases()
        lsv_Envases.Items.Clear()
        dt_Envases = Cn_Facturacion.fn_ConsultaEnvasesRemision(tbx_Remision.Tag)
        If dt_Envases IsNot Nothing Then
            If dt_Envases.Rows.Count > 0 Then
                Dim dr_e As DataRow
                For Each dr_e In dt_Envases.Rows
                    lsv_Envases.Items.Add(dr_e(1).ToString)
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = dr_e(0).ToString
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(dr_e(2).ToString)
                Next
            End If
        End If
    End Sub

    Private Sub LlenaGridDinero()
        Dim lc_dr As DataRow
        Dim lc_drD As DataRow
        For Each lc_dr In dt_Dinero.Rows
            For Each lc_drD In dt_Paso.Rows
                If lc_dr(0) = lc_drD(0) Then
                    lc_dr(2) = lc_drD(2)
                    lc_dr(3) = lc_drD(3)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub tbx_Remision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Comprobar()
        End If
    End Sub

    Private Sub tbx_Remision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Remision.TextChanged
        dgv_Dinero.DataSource = dt_Dinero
        tbx_TotalRemision.Clear()
    End Sub

    Private Sub dgDinero_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Dinero.CellEndEdit
        Call CalculaTotalGrid()
    End Sub

    Sub CalculaTotalGrid()
        Dim Efectivo As Decimal = 0
        Dim Documentos As Decimal = 0
        For ilocal As Integer = 0 To dgv_Dinero.Rows.Count - 1
            Efectivo += (dgv_Dinero.Rows(ilocal).Cells(2).Value).ToString * (dgv_Dinero.Rows(ilocal).Cells(4).Value).ToString
            Documentos += (dgv_Dinero.Rows(ilocal).Cells(3).Value).ToString * (dgv_Dinero.Rows(ilocal).Cells(4).Value).ToString
        Next
        tbx_TotalRemision.Text = Format(Efectivo + Documentos, "n2")
    End Sub

    'Private Sub CalculaImporteTotal()
    'If dt_Paso.Rows.Count > 0 Then
    '    Dim DR_lc As DataRow
    '    Dim Efectivo As Decimal = 0
    '    Dim Documentos As Decimal = 0
    '    For Each DR_lc In dt_Paso.Rows
    '        Efectivo += DR_lc(2).ToString * DR_lc(4).ToString
    '        Documentos += DR_lc(3).ToString
    '    Next
    '    tbx_TotalRemision.Text = Format((Efectivo + Documentos), "###,###,##0.00")
    'Else
    '    tbx_TotalRemision.Text = 0
    'End If
    'End Sub

    'Private Sub dgDinero_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgDinero.CellValidating
    '    If Me.dgDinero.Columns(e.ColumnIndex).Name = "Importe Efectivo" Then

    '        If e IsNot Nothing Then
    '            If Not IsNumeric(e.FormattedValue) Then
    '                Try
    '                    dgDinero.Rows(e.RowIndex).ErrorText = "Debe ser númerico"
    '                    'e.Cancel = True
    '                Catch ex As FormatException
    '                    Console.WriteLine("{0} is not a valid date.", e.FormattedValue.ToString())
    '                End Try
    '            End If
    '        End If

    '    End If

    'End Sub

    'Private Sub dgDinero_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellValueChanged
    '    If e.RowIndex = -1 Then Exit Sub
    '    If Not IsNumeric(dgDinero.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
    '        dgDinero.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = "0.00"
    '        MsgBox("ingrese un dato numerico")
    '    End If
    'End Sub

    'Private Sub dgDinero_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellClick
    '    If e.ColumnIndex Then
    '        'dgDinero.currentcell.Value = 0
    '    End If
    'End Sub

    'Private Sub dgDinero_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellValidated
    '    If Me.dgDinero.Columns(e.ColumnIndex).Name = "Importe Efectivo" Then
    '        dgDinero.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0.00"
    '    End If
    'End Sub   
End Class


