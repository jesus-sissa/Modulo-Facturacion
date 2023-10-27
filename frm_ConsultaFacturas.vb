Public Class frm_ConsultaFacturas
    Dim list As New cp_Listview
    Private FacturaOServicio As Integer = 0
    Private Sub Rdb_FechaFacturacion_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_FechaFacturacion.CheckedChanged
        If rdb_FechaFacturacion.Checked Then
            rdb_FechaServicio.Checked = False
            FacturaOServicio = 1
        End If
    End Sub

    Private Sub Rdb_FechaServicio_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_FechaServicio.CheckedChanged
        If rdb_FechaServicio.Checked Then
            rdb_FechaFacturacion.Checked = False
            FacturaOServicio = 2
        End If
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Frm_ConsultaFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lvFacturas.Columns.Add("IDDOCUMENTO")
        'lvFacturas.Columns.Add("DESCRIPCION")
        'lvFacturas.Columns.Add("NOMBRECONCEPTO")
        'lvFacturas.Columns.Add("DOCUMENTO")
        'lvFacturas.Columns.Add("FOLIO")
        'lvFacturas.Columns.Add("FECHA")
        'lvFacturas.Columns.Add("Fecha Servicio")
        'lvFacturas.Columns.Add("CODIGOCLIENTE")
        'lvFacturas.Columns.Add("RAZON SOCIAL")
        'lvFacturas.Columns.Add("RFC")
        'lvFacturas.Columns.Add("UUID")
        'lvFacturas.Columns.Add("CREFERENCIA")
        'lvFacturas.Columns.Add("COBSERVACIONES")
        'lvFacturas.Columns.Add("IMPORTE")
        'lvFacturas.Columns.Add("IVA")
        'lvFacturas.Columns.Add("RETENCION IVA")
        'lvFacturas.Columns.Add("TOTAL")
        'lvFacturas.Columns.Add("ClienteCodigo")
        'lvFacturas.Columns.Add("DomicilioOrigen")
        'lvFacturas.Columns.Add("CR")
        'lvFacturas.Columns.Add("Origen")
        'lvFacturas.Columns.Add("Plaza")
        'lvFacturas.Columns.Add("DomicilioDestino")
        'lvFacturas.Columns.Add("CR")
        'lvFacturas.Columns.Add("Destino")
        'lvFacturas.Columns.Add("Plaza")


    End Sub



    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        'btn_Exportar.Enabled = True
        If dtp_Hasta.Value < dtp_Desde.Value Then
            MsgBox("La Fecha Hasta debe ser mayor que la Fecha Desde.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Hasta.Focus()
            Exit Sub
        End If
        If FacturaOServicio = 0 Then
            MsgBox("Seleccione Fecha Factura o Fecha Servicio", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call LimpiarLista()

        Dim ccliente As Integer
        Dim ccVal As Integer = 0
        Dim Tval As String = "Ambos"

        If txt_codidocliente.Text = "" Then
            ccliente = 0

        Else
            ccliente = txt_codidocliente.Text
            ccVal = 1
        End If
        If rdb_ICCP.Checked Then
            Tval = "ICCP"
        End If
        If rdb_TCCP.Checked Then
            Tval = "TCCP"
        End If
        Dim dt As New DataTable
        dt = Cn_Facturacion.fn_ConsultaFacturas(List, dtp_Desde.Value, dtp_Hasta.Value, FacturaOServicio, ccliente, ccVal, Tval)


        Dgb_Facturas.DataSource = dt






        If Dgb_Facturas.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros", MsgBoxStyle.Information, frm_MENU.Text)

        End If
        ' btn_Exportar.Enabled = lvFacturas.Items.Count > 0
        Lbl_RegistrosR.Text = "Registros: " & Dgb_Facturas.Rows.Count
    End Sub
    Sub LimpiarLista()
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0


        btn_Exportar.Enabled = False
    End Sub

    Private Sub Btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        'FuncionesGlobales.fn_Exportar_Excel(lvFacturas, 2, "ENTRADAS Y SALIDAS DE RUTAS " & dtp_Desde.Value.ToShortDateString & "-" & dtp_Hasta.Value.ToShortDateString, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Cmb_Clientes_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Rdb_ICCP_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_ICCP.CheckedChanged
        If rdb_ICCP.Checked Then
            rdb_TCCP.Checked = False
            rdb_ambos.Checked = False
        End If
    End Sub

    Private Sub Rdb_TCCP_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_TCCP.CheckedChanged
        If rdb_TCCP.Checked Then
            rdb_ICCP.Checked = False
            rdb_ambos.Checked = False
        End If
    End Sub

    Private Sub Rdb_ambos_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_ambos.CheckedChanged
        If rdb_ambos.Checked Then
            rdb_TCCP.Checked = False
            rdb_ICCP.Checked = False
        End If
    End Sub

    Private Sub Dgb_Facturas_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Dgb_Facturas.RowLeave
        SegundosDesconexion = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dgb_Facturas.SelectAll()
        Dim dataObj As DataObject = Dgb_Facturas.GetClipboardContent()
        If dataObj IsNot Nothing Then Clipboard.SetDataObject(dataObj)
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Dim dataObj As DataObject = Dgb_Facturas.GetClipboardContent()
        If dataObj IsNot Nothing Then Clipboard.SetDataObject(dataObj)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dgb_Facturas.SelectAll()
        Dim dataObj As DataObject = Dgb_Facturas.GetClipboardContent()
        If dataObj IsNot Nothing Then Clipboard.SetDataObject(dataObj)
    End Sub
End Class