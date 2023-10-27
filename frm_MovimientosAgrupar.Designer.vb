<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MovimientosAgrupar
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
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MovimientosAgrupar))
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox()
        Me.lsv_Remisiones = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Agrupar = New System.Windows.Forms.Button()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.tbx_Destino = New Modulo_Facturacion.cp_Textbox()
        Me.cmb_Destino = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.txt_Clave = New Modulo_Facturacion.cp_Textbox()
        Me.cmb_Clientes = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual()
        Me.chk_SubClientes = New System.Windows.Forms.CheckBox()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.Lbl_Destino = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.gbx_RemisionesD = New System.Windows.Forms.GroupBox()
        Me.lsv_RemisionesD = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Remisiones1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_RegistrosP = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Facturacion.cp_Textbox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview()
        Me.Lbl_Remisiones = New System.Windows.Forms.Label()
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_RemisionesD.SuspendLayout()
        Me.gbx_Remisiones1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(593, 326)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(182, 167)
        Me.gbx_Remisiones.TabIndex = 2
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Visible = False
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
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter1
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 15
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 15
        Me.lsv_Remisiones.Row3 = 10
        Me.lsv_Remisiones.Row4 = 10
        Me.lsv_Remisiones.Row5 = 20
        Me.lsv_Remisiones.Row6 = 10
        Me.lsv_Remisiones.Row7 = 0
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(170, 142)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Agrupar)
        Me.gbx_Botones.Location = New System.Drawing.Point(10, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(765, 50)
        Me.gbx_Botones.TabIndex = 4
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
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Agrupar
        '
        Me.btn_Agrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agrupar.Enabled = False
        Me.btn_Agrupar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Tipo_Licencia
        Me.btn_Agrupar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Agrupar.Name = "btn_Agrupar"
        Me.btn_Agrupar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agrupar.TabIndex = 0
        Me.btn_Agrupar.Text = "&Agrupar F2"
        Me.btn_Agrupar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agrupar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agrupar.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Destino)
        Me.gbx_Filtro.Controls.Add(Me.txt_Clave)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Destino)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.chk_SubClientes)
        Me.gbx_Filtro.Controls.Add(Me.chk_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Destino)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Location = New System.Drawing.Point(10, 12)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(765, 101)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'tbx_Destino
        '
        Me.tbx_Destino.Control_Siguiente = Me.cmb_Destino
        Me.tbx_Destino.Filtrado = True
        Me.tbx_Destino.Location = New System.Drawing.Point(69, 69)
        Me.tbx_Destino.MaxLength = 12
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.Size = New System.Drawing.Size(87, 20)
        Me.tbx_Destino.TabIndex = 12
        Me.tbx_Destino.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Destino
        '
        Me.cmb_Destino.Clave = "Clave_Cliente"
        Me.cmb_Destino.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Destino.DisplayMember = "Nombre_Comercial"
        Me.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Destino.Empresa = False
        Me.cmb_Destino.Filtro = Me.tbx_Destino
        Me.cmb_Destino.FormattingEnabled = True
        Me.cmb_Destino.Location = New System.Drawing.Point(162, 68)
        Me.cmb_Destino.Name = "cmb_Destino"
        Me.cmb_Destino.Pista = True
        Me.cmb_Destino.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Destino.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Destino.Sucursal = True
        Me.cmb_Destino.TabIndex = 13
        Me.cmb_Destino.Tipo = 0
        Me.cmb_Destino.ValueMember = "Id_Cliente"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(568, 61)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 14
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'txt_Clave
        '
        Me.txt_Clave.Control_Siguiente = Me.cmb_Clientes
        Me.txt_Clave.Filtrado = True
        Me.txt_Clave.Location = New System.Drawing.Point(69, 42)
        Me.txt_Clave.MaxLength = 12
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(87, 20)
        Me.txt_Clave.TabIndex = 8
        Me.txt_Clave.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.cmb_Destino
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.txt_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(162, 41)
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = True
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 9
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.cmb_Clientes
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(355, 15)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(207, 21)
        Me.cmb_Status.TabIndex = 5
        Me.cmb_Status.ValueMember = "value"
        '
        'chk_SubClientes
        '
        Me.chk_SubClientes.AutoSize = True
        Me.chk_SubClientes.Location = New System.Drawing.Point(568, 43)
        Me.chk_SubClientes.Name = "chk_SubClientes"
        Me.chk_SubClientes.Size = New System.Drawing.Size(112, 17)
        Me.chk_SubClientes.TabIndex = 10
        Me.chk_SubClientes.Text = "Incluir Subclientes"
        Me.chk_SubClientes.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(568, 20)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 6
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'Lbl_Destino
        '
        Me.Lbl_Destino.AutoSize = True
        Me.Lbl_Destino.Location = New System.Drawing.Point(20, 72)
        Me.Lbl_Destino.Name = "Lbl_Destino"
        Me.Lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Destino.TabIndex = 11
        Me.Lbl_Destino.Text = "Destino"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(312, 20)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 4
        Me.lbl_Status.Text = "Status"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(24, 45)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(25, 20)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(170, 20)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(211, 17)
        Me.dtp_Hasta.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        Me.dtp_Hasta.Value = New Date(2009, 11, 12, 0, 0, 0, 0)
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(69, 16)
        Me.dtp_Desde.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        Me.dtp_Desde.Value = New Date(2009, 11, 12, 0, 0, 0, 0)
        '
        'gbx_RemisionesD
        '
        Me.gbx_RemisionesD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesD.Controls.Add(Me.lsv_RemisionesD)
        Me.gbx_RemisionesD.Location = New System.Drawing.Point(10, 326)
        Me.gbx_RemisionesD.Name = "gbx_RemisionesD"
        Me.gbx_RemisionesD.Size = New System.Drawing.Size(577, 167)
        Me.gbx_RemisionesD.TabIndex = 3
        Me.gbx_RemisionesD.TabStop = False
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
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_RemisionesD.Lvs = ListViewColumnSorter2
        Me.lsv_RemisionesD.MultiSelect = False
        Me.lsv_RemisionesD.Name = "lsv_RemisionesD"
        Me.lsv_RemisionesD.Row1 = 24
        Me.lsv_RemisionesD.Row10 = 0
        Me.lsv_RemisionesD.Row2 = 25
        Me.lsv_RemisionesD.Row3 = 25
        Me.lsv_RemisionesD.Row4 = 25
        Me.lsv_RemisionesD.Row5 = 0
        Me.lsv_RemisionesD.Row6 = 0
        Me.lsv_RemisionesD.Row7 = 0
        Me.lsv_RemisionesD.Row8 = 0
        Me.lsv_RemisionesD.Row9 = 0
        Me.lsv_RemisionesD.Size = New System.Drawing.Size(565, 142)
        Me.lsv_RemisionesD.TabIndex = 0
        Me.lsv_RemisionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_RemisionesD.View = System.Windows.Forms.View.Details
        '
        'gbx_Remisiones1
        '
        Me.gbx_Remisiones1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones1.Controls.Add(Me.Lbl_RegistrosP)
        Me.gbx_Remisiones1.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Remisiones1.Controls.Add(Me.lsv_Datos)
        Me.gbx_Remisiones1.Controls.Add(Me.btn_Buscar)
        Me.gbx_Remisiones1.Controls.Add(Me.Lbl_Remisiones)
        Me.gbx_Remisiones1.Location = New System.Drawing.Point(10, 115)
        Me.gbx_Remisiones1.Name = "gbx_Remisiones1"
        Me.gbx_Remisiones1.Size = New System.Drawing.Size(765, 205)
        Me.gbx_Remisiones1.TabIndex = 1
        Me.gbx_Remisiones1.TabStop = False
        '
        'Lbl_RegistrosP
        '
        Me.Lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosP.Location = New System.Drawing.Point(614, 11)
        Me.Lbl_RegistrosP.Name = "Lbl_RegistrosP"
        Me.Lbl_RegistrosP.Size = New System.Drawing.Size(145, 19)
        Me.Lbl_RegistrosP.TabIndex = 5
        Me.Lbl_RegistrosP.Text = "Registros: 0"
        Me.Lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = True
        Me.tbx_Buscar.Location = New System.Drawing.Point(69, 17)
        Me.tbx_Buscar.MaxLength = 12
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(130, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(207, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "&Buscar y Marcar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.CheckBoxes = True
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 47)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter3
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 8
        Me.lsv_Datos.Row10 = 20
        Me.lsv_Datos.Row2 = 6
        Me.lsv_Datos.Row3 = 8
        Me.lsv_Datos.Row4 = 8
        Me.lsv_Datos.Row5 = 20
        Me.lsv_Datos.Row6 = 8
        Me.lsv_Datos.Row7 = 5
        Me.lsv_Datos.Row8 = 5
        Me.lsv_Datos.Row9 = 20
        Me.lsv_Datos.Size = New System.Drawing.Size(753, 152)
        Me.lsv_Datos.TabIndex = 3
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Lbl_Remisiones
        '
        Me.Lbl_Remisiones.AutoSize = True
        Me.Lbl_Remisiones.Location = New System.Drawing.Point(13, 20)
        Me.Lbl_Remisiones.Name = "Lbl_Remisiones"
        Me.Lbl_Remisiones.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_Remisiones.TabIndex = 0
        Me.Lbl_Remisiones.Text = "Remisión"
        '
        'frm_MovimientosAgrupar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Remisiones1)
        Me.Controls.Add(Me.gbx_RemisionesD)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MovimientosAgrupar"
        Me.Text = "Agrupar Movimientos"
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_RemisionesD.ResumeLayout(False)
        Me.gbx_Remisiones1.ResumeLayout(False)
        Me.gbx_Remisiones1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Agrupar As System.Windows.Forms.Button
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Clave As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Clientes As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_SubClientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_RemisionesD As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_RemisionesD As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Remisiones1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Buscar As Modulo_Facturacion.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Remisiones As System.Windows.Forms.Label
    Friend WithEvents tbx_Destino As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Destino As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosP As System.Windows.Forms.Label
End Class
