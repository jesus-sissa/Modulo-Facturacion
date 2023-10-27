<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaTraslados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaTraslados))
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.gbx_Ingresos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cp_tbx_varchar_4_LN1 = New Modulo_Facturacion.cp_Textbox()
        Me.gbx_ComprobanteVisita = New System.Windows.Forms.GroupBox()
        Me.rdb_ExcluyeCV = New System.Windows.Forms.RadioButton()
        Me.rdb_IncluyeCV = New System.Windows.Forms.RadioButton()
        Me.rdb_SoloCV = New System.Windows.Forms.RadioButton()
        Me.cmb_TipoMov = New Modulo_Facturacion.cp_cmb_Manual()
        Me.chk_TipoMov = New System.Windows.Forms.CheckBox()
        Me.lbl_TipoMov = New System.Windows.Forms.Label()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.txt_Clave = New Modulo_Facturacion.cp_Textbox()
        Me.cmb_Clientes = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual()
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview()
        Me.btn_MostrarC = New System.Windows.Forms.Button()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox()
        Me.lsv_Remisiones = New Modulo_Facturacion.cp_Listview()
        Me.gbx_RemisionesD = New System.Windows.Forms.GroupBox()
        Me.lsv_RemisionesD = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Ingresos.SuspendLayout()
        Me.gbx_ComprobanteVisita.SuspendLayout()
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_RemisionesD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 571)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(765, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(619, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Ingresos
        '
        Me.gbx_Ingresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Ingresos.Controls.Add(Me.Label2)
        Me.gbx_Ingresos.Controls.Add(Me.Cp_tbx_varchar_4_LN1)
        Me.gbx_Ingresos.Controls.Add(Me.gbx_ComprobanteVisita)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.chk_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Cantidad)
        Me.gbx_Ingresos.Controls.Add(Me.txt_Clave)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_Status)
        Me.gbx_Ingresos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Ingresos.Controls.Add(Me.btn_MostrarC)
        Me.gbx_Ingresos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Ingresos.Controls.Add(Me.chk_Status)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Status)
        Me.gbx_Ingresos.Controls.Add(Me.Label1)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Desde)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Ingresos.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Ingresos.Controls.Add(Me.dtp_Desde)
        Me.gbx_Ingresos.Location = New System.Drawing.Point(12, 2)
        Me.gbx_Ingresos.Name = "gbx_Ingresos"
        Me.gbx_Ingresos.Size = New System.Drawing.Size(765, 361)
        Me.gbx_Ingresos.TabIndex = 0
        Me.gbx_Ingresos.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Comprobantes de Visita"
        '
        'Cp_tbx_varchar_4_LN1
        '
        Me.Cp_tbx_varchar_4_LN1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_tbx_varchar_4_LN1.BackColor = System.Drawing.Color.Red
        Me.Cp_tbx_varchar_4_LN1.Control_Siguiente = Nothing
        Me.Cp_tbx_varchar_4_LN1.Filtrado = True
        Me.Cp_tbx_varchar_4_LN1.Location = New System.Drawing.Point(433, 189)
        Me.Cp_tbx_varchar_4_LN1.MaxLength = 4
        Me.Cp_tbx_varchar_4_LN1.Name = "Cp_tbx_varchar_4_LN1"
        Me.Cp_tbx_varchar_4_LN1.Size = New System.Drawing.Size(20, 20)
        Me.Cp_tbx_varchar_4_LN1.TabIndex = 16
        Me.Cp_tbx_varchar_4_LN1.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'gbx_ComprobanteVisita
        '
        Me.gbx_ComprobanteVisita.Controls.Add(Me.rdb_ExcluyeCV)
        Me.gbx_ComprobanteVisita.Controls.Add(Me.rdb_IncluyeCV)
        Me.gbx_ComprobanteVisita.Controls.Add(Me.rdb_SoloCV)
        Me.gbx_ComprobanteVisita.Location = New System.Drawing.Point(103, 94)
        Me.gbx_ComprobanteVisita.Name = "gbx_ComprobanteVisita"
        Me.gbx_ComprobanteVisita.Size = New System.Drawing.Size(493, 41)
        Me.gbx_ComprobanteVisita.TabIndex = 10
        Me.gbx_ComprobanteVisita.TabStop = False
        '
        'rdb_ExcluyeCV
        '
        Me.rdb_ExcluyeCV.AutoSize = True
        Me.rdb_ExcluyeCV.Location = New System.Drawing.Point(6, 14)
        Me.rdb_ExcluyeCV.Name = "rdb_ExcluyeCV"
        Me.rdb_ExcluyeCV.Size = New System.Drawing.Size(161, 17)
        Me.rdb_ExcluyeCV.TabIndex = 0
        Me.rdb_ExcluyeCV.TabStop = True
        Me.rdb_ExcluyeCV.Text = "Excluye Comprobantes Visita"
        Me.rdb_ExcluyeCV.UseVisualStyleBackColor = True
        '
        'rdb_IncluyeCV
        '
        Me.rdb_IncluyeCV.AutoSize = True
        Me.rdb_IncluyeCV.Location = New System.Drawing.Point(173, 14)
        Me.rdb_IncluyeCV.Name = "rdb_IncluyeCV"
        Me.rdb_IncluyeCV.Size = New System.Drawing.Size(158, 17)
        Me.rdb_IncluyeCV.TabIndex = 1
        Me.rdb_IncluyeCV.TabStop = True
        Me.rdb_IncluyeCV.Text = "Incluye Comprobantes Visita"
        Me.rdb_IncluyeCV.UseVisualStyleBackColor = True
        '
        'rdb_SoloCV
        '
        Me.rdb_SoloCV.AutoSize = True
        Me.rdb_SoloCV.Location = New System.Drawing.Point(337, 14)
        Me.rdb_SoloCV.Name = "rdb_SoloCV"
        Me.rdb_SoloCV.Size = New System.Drawing.Size(145, 17)
        Me.rdb_SoloCV.TabIndex = 2
        Me.rdb_SoloCV.TabStop = True
        Me.rdb_SoloCV.Text = "Solo Comprobantes Visita"
        Me.rdb_SoloCV.UseVisualStyleBackColor = True
        '
        'cmb_TipoMov
        '
        Me.cmb_TipoMov.Control_Siguiente = Nothing
        Me.cmb_TipoMov.DisplayMember = "display"
        Me.cmb_TipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoMov.FormattingEnabled = True
        Me.cmb_TipoMov.Location = New System.Drawing.Point(103, 43)
        Me.cmb_TipoMov.Name = "cmb_TipoMov"
        Me.cmb_TipoMov.Size = New System.Drawing.Size(223, 21)
        Me.cmb_TipoMov.TabIndex = 5
        Me.cmb_TipoMov.ValueMember = "value"
        '
        'chk_TipoMov
        '
        Me.chk_TipoMov.AutoSize = True
        Me.chk_TipoMov.Location = New System.Drawing.Point(332, 47)
        Me.chk_TipoMov.Name = "chk_TipoMov"
        Me.chk_TipoMov.Size = New System.Drawing.Size(56, 17)
        Me.chk_TipoMov.TabIndex = 6
        Me.chk_TipoMov.Text = "Todos"
        Me.chk_TipoMov.UseVisualStyleBackColor = True
        '
        'lbl_TipoMov
        '
        Me.lbl_TipoMov.AutoSize = True
        Me.lbl_TipoMov.Location = New System.Drawing.Point(12, 47)
        Me.lbl_TipoMov.Name = "lbl_TipoMov"
        Me.lbl_TipoMov.Size = New System.Drawing.Size(85, 13)
        Me.lbl_TipoMov.TabIndex = 4
        Me.lbl_TipoMov.Text = "Tipo Movimiento"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cantidad.Location = New System.Drawing.Point(596, 196)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(163, 13)
        Me.lbl_Cantidad.TabIndex = 18
        Me.lbl_Cantidad.Text = "Se encontraron 0 Servicios"
        Me.lbl_Cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Clave
        '
        Me.txt_Clave.Control_Siguiente = Me.cmb_Clientes
        Me.txt_Clave.Filtrado = True
        Me.txt_Clave.Location = New System.Drawing.Point(103, 141)
        Me.txt_Clave.MaxLength = 12
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(87, 20)
        Me.txt_Clave.TabIndex = 12
        Me.txt_Clave.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.txt_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(196, 140)
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = True
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 13
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(103, 167)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 39)
        Me.btn_Mostrar.TabIndex = 14
        Me.btn_Mostrar.Text = "Consulta Normal"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.cmb_Clientes
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(103, 70)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(223, 21)
        Me.cmb_Status.TabIndex = 8
        Me.cmb_Status.ValueMember = "value"
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 212)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 7
        Me.lsv_Datos.Row10 = 7
        Me.lsv_Datos.Row2 = 7
        Me.lsv_Datos.Row3 = 5
        Me.lsv_Datos.Row4 = 25
        Me.lsv_Datos.Row5 = 8
        Me.lsv_Datos.Row6 = 6
        Me.lsv_Datos.Row7 = 6
        Me.lsv_Datos.Row8 = 8
        Me.lsv_Datos.Row9 = 6
        Me.lsv_Datos.Size = New System.Drawing.Size(753, 143)
        Me.lsv_Datos.TabIndex = 19
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'btn_MostrarC
        '
        Me.btn_MostrarC.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarC.Location = New System.Drawing.Point(249, 167)
        Me.btn_MostrarC.Name = "btn_MostrarC"
        Me.btn_MostrarC.Size = New System.Drawing.Size(140, 39)
        Me.btn_MostrarC.TabIndex = 15
        Me.btn_MostrarC.Text = "Por Cantidad de Traslados"
        Me.btn_MostrarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarC.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(332, 74)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 9
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(60, 75)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 7
        Me.lbl_Status.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cliente"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(59, 21)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(197, 21)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(238, 18)
        Me.dtp_Hasta.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Hasta.TabIndex = 3
        Me.dtp_Hasta.Value = New Date(2012, 5, 8, 0, 0, 0, 0)
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(103, 17)
        Me.dtp_Desde.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Desde.TabIndex = 1
        Me.dtp_Desde.Value = New Date(2012, 5, 8, 0, 0, 0, 0)
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(12, 369)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(385, 196)
        Me.gbx_Remisiones.TabIndex = 1
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Text = "Remisiones por Traslado"
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.AllowColumnReorder = True
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter2
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 12
        Me.lsv_Remisiones.Row10 = 10
        Me.lsv_Remisiones.Row2 = 15
        Me.lsv_Remisiones.Row3 = 10
        Me.lsv_Remisiones.Row4 = 10
        Me.lsv_Remisiones.Row5 = 20
        Me.lsv_Remisiones.Row6 = 10
        Me.lsv_Remisiones.Row7 = 10
        Me.lsv_Remisiones.Row8 = 10
        Me.lsv_Remisiones.Row9 = 10
        Me.lsv_Remisiones.Size = New System.Drawing.Size(373, 171)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'gbx_RemisionesD
        '
        Me.gbx_RemisionesD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesD.Controls.Add(Me.lsv_RemisionesD)
        Me.gbx_RemisionesD.Location = New System.Drawing.Point(403, 369)
        Me.gbx_RemisionesD.Name = "gbx_RemisionesD"
        Me.gbx_RemisionesD.Size = New System.Drawing.Size(374, 196)
        Me.gbx_RemisionesD.TabIndex = 2
        Me.gbx_RemisionesD.TabStop = False
        Me.gbx_RemisionesD.Text = "Importes por Remisión"
        '
        'lsv_RemisionesD
        '
        Me.lsv_RemisionesD.AllowColumnReorder = True
        Me.lsv_RemisionesD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_RemisionesD.FullRowSelect = True
        Me.lsv_RemisionesD.HideSelection = False
        Me.lsv_RemisionesD.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_RemisionesD.Lvs = ListViewColumnSorter3
        Me.lsv_RemisionesD.MultiSelect = False
        Me.lsv_RemisionesD.Name = "lsv_RemisionesD"
        Me.lsv_RemisionesD.Row1 = 25
        Me.lsv_RemisionesD.Row10 = 0
        Me.lsv_RemisionesD.Row2 = 25
        Me.lsv_RemisionesD.Row3 = 25
        Me.lsv_RemisionesD.Row4 = 20
        Me.lsv_RemisionesD.Row5 = 0
        Me.lsv_RemisionesD.Row6 = 0
        Me.lsv_RemisionesD.Row7 = 0
        Me.lsv_RemisionesD.Row8 = 0
        Me.lsv_RemisionesD.Row9 = 0
        Me.lsv_RemisionesD.Size = New System.Drawing.Size(362, 171)
        Me.lsv_RemisionesD.TabIndex = 0
        Me.lsv_RemisionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_RemisionesD.View = System.Windows.Forms.View.Details
        '
        'frm_ConsultaTraslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 633)
        Me.Controls.Add(Me.gbx_RemisionesD)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Ingresos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(667, 587)
        Me.Name = "frm_ConsultaTraslados"
        Me.Text = "Consulta de Traslados"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Ingresos.ResumeLayout(False)
        Me.gbx_Ingresos.PerformLayout()
        Me.gbx_ComprobanteVisita.ResumeLayout(False)
        Me.gbx_ComprobanteVisita.PerformLayout()
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_RemisionesD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Ingresos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_RemisionesD As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_RemisionesD As Modulo_Facturacion.cp_Listview
    Friend WithEvents txt_Clave As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Clientes As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_MostrarC As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoMov As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents chk_TipoMov As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_TipoMov As System.Windows.Forms.Label
    Friend WithEvents rdb_IncluyeCV As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_ComprobanteVisita As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_SoloCV As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ExcluyeCV As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cp_tbx_varchar_4_LN1 As Modulo_Facturacion.cp_Textbox
End Class
