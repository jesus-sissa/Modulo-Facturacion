Imports System.Data.Odbc

Public Class frm_AdminPaq

    Dim Cnn As OdbcConnection
    Dim CadenaLog As String = ""
    Dim Dt_Clientes As DataTable

    Private Sub frm_AdminPaq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        lsv_Facturas.Columns.Add("Folio")
        lsv_Facturas.Columns.Add("Fecha")
        lsv_Facturas.Columns.Add("Cliente")
        lsv_Facturas.Columns.Add("RazonSocial")
        lsv_Facturas.Columns.Add("Importe")
        lsv_Facturas.Columns.Add("IVA")
        lsv_Facturas.Columns.Add("Total")
        lsv_Facturas.Columns.Add("Retencion")
        lsv_Facturas.Columns.Add("Saldo")
        lsv_Facturas.Columns.Add("Observaciones")
        lsv_Facturas.Columns.Add("Cancelada")

        lsv_Detalle.Columns.Add("Cantidad")
        lsv_Detalle.Columns.Add("Producto")
        lsv_Detalle.Columns.Add("Precio")
        lsv_Detalle.Columns.Add("Neto")
        lsv_Detalle.Columns.Add("IVA")
        lsv_Detalle.Columns.Add("Total")

        cmb_Status.AgregarItem("1", "CANCELADAS")
        cmb_Status.AgregarItem("2", "NO CANCELADAS")
        cmb_Status.AgregarItem("3", "PAGADAS")
        cmb_Status.AgregarItem("4", "PENDIENTES DE PAGO")

        Dim FaltanArchivos As Boolean = False
        'Verificar si existe el respaldo
        If IO.Directory.Exists("C:\SIACadm") Then
            btn_Respaldos.Text = "&Actualizar Respaldo"
            'Revisar que existen todos los archivos necesarios
            If Not IO.File.Exists("C:\SIACadm\MGW10002.dbf") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10002.cdx") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10005.dbf") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10005.cdx") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10007.dbf") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10007.cdx") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10008.dbf") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10008.cdx") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10010.dbf") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10010.cdx") Then FaltanArchivos = True
            If Not IO.File.Exists("C:\SIACadm\MGW10011.cdx") Then FaltanArchivos = True

            If FaltanArchivos Then
                MsgBox("No se encontraron los archivos necesarios. Para continuar deberá Actualizar el Respaldo.", MsgBoxStyle.Critical, frm_MENU.Text)
                gbx_Datos.Enabled = False
                gbx_Detalle.Enabled = False
                Exit Sub
            End If

            'Mostrar la Fecha del ultimo Respaldo
            Dim FechaRespaldo As DateTime
            FechaRespaldo = IO.File.GetCreationTime("C:\SIACadm\MGW10002.dbf")
            lbl_FechaRespaldo.Text = "Último Respaldo: " & FechaRespaldo.ToShortDateString & " - " & FechaRespaldo.ToShortTimeString
            Dim DiasDiferencia As Integer = DateDiff(DateInterval.Day, FechaRespaldo, System.DateTime.Now.Date)
            If DiasDiferencia > 0 Then
                lbl_Nota.Visible = True
                lbl_Nota.Text = "ATENCIÓN: El respaldo no está actualizado. (" & DiasDiferencia.ToString & " Días Atrasado)"
            End If
            gbx_Datos.Enabled = True
            gbx_Detalle.Enabled = True
            Call Cargar_Clientes()
        Else
            btn_Respaldos.Text = "&Generar Respaldo"
            btn_Respaldos.Enabled = True
            MsgBox("No existe un Respaldo local de las Bases de Datos. Para continuar deberá Generar uno.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub Cargar_Clientes()
        Call LimpiarListas()
        Me.Cursor = Cursors.WaitCursor
        'FORMA ANTERIOR
        'Cnn = New OdbcConnection("DSN=SIACadm;DefaultDir=c:\\SIACadm;DBQ=c:\\SIACadm;")
        'FORMA NUEVA
        Cnn = New OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=c:\SIACadm;Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;")
        'probar la conexion
        Try
            Cnn.Open()
            Cnn.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudo conectar con la Base de Datos. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End Try
        Try
            Dim strSelection As String = "SELECT Cl.cidclien01 as Id, Cl.ccodigoc01 as Clave," _
                & " Cl.crazonso01 as Nombre, Cl.crfc as RFC, Dir.CNOMBREC01 as Calle," _
                & " Dir.CNUMEROE01 as NumExt, Dir.CNUMEROI01 as NumInt, Dir.CCOLONIA as Colonia," _
                & " Dir.CCIUDAD as Ciudad, Dir.CMUNICIPIO as Municipio, Dir.CESTADO as Estado, Dir.CPAIS as Pais," _
                & " Dir.CCODIGOP01 as CP, Dir.CTELEFONO1 as Telefono, Dir.CTELEFONO2 as Telefono2," _
                & " Dir.CEMAIL as Mail, Cl.CESTATUS as Status, Cl.CFECHABAJA as FechaBaja, Cl.CDENCOME01 as NombreComercial" _
                & " FROM MGW10002.dbf AS Cl" _
                & " join MGW10011.dbf AS Dir on Dir.CIDCATAL01 = Cl.cidclien01 and Dir.CTIPOCAT01=1 and Dir.CTIPODIR01=0" _
                & " where Cl.cidclien01>0 and Cl.CTIPOCLI01=1" _
                & " order by Cl.crazonso01"
            Dim cmd As OdbcCommand = New OdbcCommand(strSelection, Cnn)
            Dim DAdapter As OdbcDataAdapter = New OdbcDataAdapter(cmd)
            Dim ds As DataSet = New DataSet("DSClientes")
            DAdapter.Fill(ds)

            If ds.Tables.Count = 0 Then Exit Sub
            Dim dt As DataTable = ds.Tables(0)
            If FuncionesGlobales.fn_CargaCombo(cmb_Cliente, dt, "Id", "Nombre") Then
                btn_Mostrar.Enabled = True
                Dt_Clientes = cmb_Cliente.DataSource
            Else
                btn_Mostrar.Enabled = False
                Dt_Clientes = Nothing
            End If
            'fn_ColumnPropercase(lsv_Clientes)
            gbx_Datos.Enabled = True
            gbx_Detalle.Enabled = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            gbx_Datos.Enabled = False
            gbx_Detalle.Enabled = False
            MsgBox("Ocurrió el siguiente Error al intentar obtener los Clientes." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try

    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Facturas.Items.Clear()
        lsv_Detalle.Items.Clear()
        lbl_TotalF.Text = "0.00"
        lbl_TotalS.Text = "0.00"
        lbl_Registros.Text = "Registros: 0"
        btn_Exportar.Enabled = False
    End Sub

    Sub Cargar_Facturas()
        Call LimpiarListas()

        If cmb_Cliente.Enabled AndAlso cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("Las fechas seleccionadas parecen ser incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled AndAlso cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Estatus o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        CadenaLog = "CONSULTAR FACTURAS. "
        Try
            Dim IsQl As String = "SELECT f.ciddocum01 as Id," _
                                        & " f.cfolio as Folio," _
                                        & " f.cfecha as Fecha," _
                                        & " cl.ccodigoc01 as Cliente," _
                                        & " cl.crazonso01 as RazonSocial," _
                                        & " f.cneto as Importe," _
                                        & " f.cimpuesto1 as IVA," _
                                        & " f.ctotal as Total," _
                                        & " f.cretenci01 as Retencion," _
                                        & " f.cpendiente as Saldo," _
                                        & " f.cobserva01 as Observaciones," _
                                        & " f.ccancelado as Cancelado" _
                                        & " FROM MGW10008.dbf as f " _
                                        & " Join MGW10002.dbf as cl on cl.cidclien01=f.cidclien01"
            Dim IsQlwhere As String = " where f.ciddocum02=4"
            IsQlwhere &= " and f.cfecha >={^" & dtp_Desde.Value.Date.ToString("yyyy-MM-dd") & "} and  f.cfecha <={^" & dtp_Hasta.Value.Date.ToString("yyyy-MM-dd") & "}"
            CadenaLog &= dtp_Desde.Value.Date.ToShortDateString & "-" & dtp_Hasta.Value.Date.ToShortDateString
            If cmb_Cliente.Enabled Then
                IsQlwhere &= " and f.cidclien01=" & cmb_Cliente.SelectedValue
                CadenaLog &= " CLIENTE: " & cmb_Cliente.Text
            Else
                CadenaLog &= " CLIENTE: TODOS"
            End If
            If cmb_Status.Enabled Then
                Select Case cmb_Status.SelectedValue
                    Case "1" 'CANCELADAS
                        IsQlwhere &= " and f.ccancelado=1"
                    Case "2" 'ACTIVAS
                        IsQlwhere &= " and f.ccancelado=0"
                    Case "3" 'PAGADAS
                        IsQlwhere &= " and f.ccancelado=0"
                        IsQlwhere &= " and f.cpendiente=0"
                    Case "4" 'PENDIENTES DE PAGO
                        IsQlwhere &= " and f.ccancelado=0"
                        IsQlwhere &= " and f.cpendiente<>0"
                End Select
            End If
            IsQlwhere &= " order by f.cfolio"

            Dim cmd As OdbcCommand = New OdbcCommand(IsQl & IsQlwhere, Cnn)
            Dim DAdapter As OdbcDataAdapter = New OdbcDataAdapter(cmd)
            Dim ds As DataSet = New DataSet("DSClientes")
            DAdapter.Fill(ds)
            If ds.Tables.Count = 0 Then Exit Sub
            Dim dt As DataTable = ds.Tables(0)
            FuncionesGlobales.fn_CargaListaDataTableTag(dt, lsv_Facturas, 0, "Id")
            FuncionesGlobales.fn_Columna(lsv_Facturas, 7, 10, 7, 25, 10, 10, 10, 10, 10, 20)
            FuncionesGlobales.fn_Decimales(lsv_Facturas, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0)
            fn_ColumnPropercase(lsv_Facturas)
            lbl_Registros.Text = "Registros: 0" & lsv_Facturas.Items.Count
            'Sumatoria
            Dim TotalF As Decimal = 0.0
            Dim TotalS As Decimal = 0.0
            For Each Elemento As ListViewItem In lsv_Facturas.Items
                If CInt(Elemento.SubItems(10).Text) = 1 Then
                    Elemento.ForeColor = Color.Red
                    Elemento.SubItems(10).Text = "SI"
                Else
                    Elemento.SubItems(10).Text = "NO"
                    TotalF += CDec(Elemento.SubItems(6).Text)
                    TotalS += CDec(Elemento.SubItems(8).Text)
                End If
            Next
            lbl_TotalF.Text = Format(TotalF, "N2")
            lbl_TotalS.Text = Format(TotalS, "N2")
            btn_Exportar.Enabled = lsv_Facturas.Items.Count > 0
            Cn_Login.fn_Log_Create(CadenaLog)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrió el siguiente Error al intentar obtener las Facturas." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Sub Cargar_Detalle()
        Try
            'Cargar el detalle de la factura
            Dim strSelection As String = "SELECT D.cidmovim01 as Id, D.cunidades as Cantidad, DD.cnombrep01 as Producto, D.cprecio as Precio, D.cneto as Neto, D.cimpuesto1 as IVA, D.ctotal as Total" _
                                      & " FROM MGW10010.dbf as D" _
                                      & " Join MGW10005.dbf as DD on DD.cidprodu01=D.cidprodu01" _
                                      & " where ciddocum01=" & lsv_Facturas.SelectedItems(0).Tag & " order by cidmovim01"
            Dim cmd As OdbcCommand = New OdbcCommand(strSelection, Cnn)
            Dim DAdapter As OdbcDataAdapter = New OdbcDataAdapter(cmd)
            Dim ds As DataSet = New DataSet("DSClientes")
            DAdapter.Fill(ds)
            If ds.Tables.Count = 0 Then Exit Sub
            Dim dt As DataTable = ds.Tables(0)
            FuncionesGlobales.fn_CargaListaDataTableTag(dt, lsv_Detalle, 0, "Id")
            FuncionesGlobales.fn_Columna2(lsv_Detalle, 10, 40, 10, 10, 10, 10, 0, 0, 0, 0)
            fn_ColumnPropercase(lsv_Detalle)
            FuncionesGlobales.fn_Decimales2(lsv_Detalle, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0)
            lsv_Detalle.Columns(1).TextAlign = HorizontalAlignment.Left
        Catch ex As Exception
            MsgBox("Ocurrió el siguiente Error al intentar obtener el detalle de las Facturas." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_Respaldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Respaldos.Click
        Call LimpiarListas()
        gbx_Datos.Enabled = False
        gbx_Detalle.Enabled = False
        Dim frm As New frm_AdminpaqArchivos
        frm.ShowDialog()
        If frm.RespaldoRealizado Then
            gbx_Datos.Enabled = True
            gbx_Detalle.Enabled = True
            Dim FechaRespaldo As DateTime
            FechaRespaldo = IO.File.GetCreationTime("C:\SIACadm\MGW10002.dbf")
            lbl_FechaRespaldo.Text = "Último Respaldo: " & FechaRespaldo.ToShortDateString & " - " & FechaRespaldo.ToShortTimeString
            Call Cargar_Clientes()
        Else
            gbx_Datos.Enabled = False
            gbx_Detalle.Enabled = False
        End If
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Facturas.SelectedIndexChanged
        'Mostrar las Facturas de el cliente seleccionado
        lsv_Detalle.Items.Clear()
        If lsv_Facturas.SelectedItems.Count > 0 Then
            Call Cargar_Detalle()
        End If
    End Sub

    Sub Columnas(ByVal lsv As cp_Listview, ByVal Cols As Integer)
        lsv.Columns(0).Width = lsv.Row1
    End Sub

    Function fn_ColumnPropercase(ByVal lsv As ListView) As Boolean
        For ilocal As Integer = 0 To lsv.Columns.Count - 1
            lsv.Columns(ilocal).Text = StrConv(lsv.Columns(ilocal).Text, VbStrConv.ProperCase)
        Next
    End Function

    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Facturas.MouseHover, lsv_Detalle.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub Btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_ExcelAdminpaQ(lsv_Facturas, 2, "FACTURAS ADMINPAQ", 0, 0)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        Call LimpiarListas()
        If cmb_Cliente.SelectedValue = 0 Then
            btn_Fiscales.Enabled = False
        Else
            btn_Fiscales.Enabled = True
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call Cargar_Facturas()
    End Sub

    Private Sub chk_Cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cliente.CheckedChanged
        cmb_Cliente.SelectedValue = 0
        cmb_Cliente.Enabled = Not chk_Cliente.Checked
        Call LimpiarListas()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub btn_Fiscales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fiscales.Click
        If Dt_Clientes IsNot Nothing Then
            'Mostrar los Datos
            Dim frm As New frm_AdminpaqFiscales
            frm.rtb_Clave.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Clave").ToString.Trim
            frm.rtb_NombreFiscal.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Nombre").ToString.Trim
            frm.rtb_NombreComercial.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("NombreComercial").ToString.Trim
            frm.rtb_RFC.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("RFC").ToString.Trim
            frm.rtb_Calle.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Calle").ToString.Trim
            frm.rtb_NumExt.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("NumExt").ToString.Trim
            frm.rtb_NumInt.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("NumInt").ToString.Trim
            frm.rtb_Colonia.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Colonia").ToString.Trim
            frm.rtb_Ciudad.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Ciudad").ToString.Trim
            frm.rtb_Municipio.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Municipio").ToString.Trim
            frm.rtb_Estado.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Estado").ToString.Trim
            frm.rtb_Pais.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Pais").ToString.Trim
            frm.rtb_CP.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("CP").ToString.Trim
            frm.rtb_Telefono.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Telefono").ToString.Trim
            frm.rtb_Telefono2.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Telefono2").ToString.Trim
            frm.rtb_Mail.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Mail").ToString.Trim
            If Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("Status").ToString.Trim = "0" Then
                frm.rtb_Estatus.Text = "Baja"
                frm.rtb_FechaBaja.Text = Dt_Clientes.Rows(cmb_Cliente.SelectedIndex)("FechaBaja").ToString.Trim
            Else
                frm.rtb_Estatus.Text = "Activo"
                frm.rtb_FechaBaja.Text = ""
            End If

            frm.ShowDialog()
        Else
            MsgBox("Ocurrió un Error al intentar obtener los Datos del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

End Class

