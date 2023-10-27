<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetalleDepositos
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
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.Cmb_ClientesP = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.Cmb_Compañia = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_Compañia = New System.Windows.Forms.Label()
        Me.Chk_Clientes = New System.Windows.Forms.CheckBox()
        Me.Cmb_Clientes = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.Cmb_grupo = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.chk_Grupo = New System.Windows.Forms.CheckBox()
        Me.lbl_Grupo = New System.Windows.Forms.Label()
        Me.rdb_Todo = New System.Windows.Forms.RadioButton()
        Me.Lbl_NotaT = New System.Windows.Forms.Label()
        Me.Lbl_Nota = New System.Windows.Forms.Label()
        Me.rdb_Morralla = New System.Windows.Forms.RadioButton()
        Me.rdb_Proceso = New System.Windows.Forms.RadioButton()
        Me.cmb_Hasta = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Moneda = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Desde = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Moneda = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.cmb_CajaBancaria = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.lbl_remisionesDescargadas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_path = New System.Windows.Forms.Button()
        Me.txb_path = New System.Windows.Forms.TextBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Dotaciones = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.Cmb_ClientesP)
        Me.gbx_Filtro.Controls.Add(Me.Cmb_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.Chk_Clientes)
        Me.gbx_Filtro.Controls.Add(Me.Cmb_Clientes)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.Cmb_grupo)
        Me.gbx_Filtro.Controls.Add(Me.chk_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Todo)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_NotaT)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Nota)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Morralla)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Proceso)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Desde)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Location = New System.Drawing.Point(3, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(895, 234)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'Cmb_ClientesP
        '
        Me.Cmb_ClientesP.Clave = "Clave_Cliente"
        Me.Cmb_ClientesP.Control_Siguiente = Nothing
        Me.Cmb_ClientesP.DisplayMember = "Nombre Comercial"
        Me.Cmb_ClientesP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_ClientesP.Empresa = False
        Me.Cmb_ClientesP.Enabled = False
        Me.Cmb_ClientesP.Filtro = Nothing
        Me.Cmb_ClientesP.FormattingEnabled = True
        Me.Cmb_ClientesP.Location = New System.Drawing.Point(106, 67)
        Me.Cmb_ClientesP.MaxDropDownItems = 20
        Me.Cmb_ClientesP.Name = "Cmb_ClientesP"
        Me.Cmb_ClientesP.Pista = True
        Me.Cmb_ClientesP.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_ClientesP.StoredProcedure = "Cat_ClientesProceso_Get"
        Me.Cmb_ClientesP.Sucursal = True
        Me.Cmb_ClientesP.TabIndex = 8
        Me.Cmb_ClientesP.Tipo = 0
        Me.Cmb_ClientesP.ValueMember = "Id_ClienteP"
        Me.Cmb_ClientesP.Visible = False
        '
        'Cmb_Compañia
        '
        Me.Cmb_Compañia.Clave = Nothing
        Me.Cmb_Compañia.Control_Siguiente = Nothing
        Me.Cmb_Compañia.DisplayMember = "Alias"
        Me.Cmb_Compañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Compañia.Empresa = False
        Me.Cmb_Compañia.Filtro = Nothing
        Me.Cmb_Compañia.FormattingEnabled = True
        Me.Cmb_Compañia.Location = New System.Drawing.Point(106, 40)
        Me.Cmb_Compañia.MaxDropDownItems = 20
        Me.Cmb_Compañia.Name = "Cmb_Compañia"
        Me.Cmb_Compañia.Pista = True
        Me.Cmb_Compañia.Size = New System.Drawing.Size(171, 21)
        Me.Cmb_Compañia.StoredProcedure = "Cat_Cias_Get"
        Me.Cmb_Compañia.Sucursal = False
        Me.Cmb_Compañia.TabIndex = 4
        Me.Cmb_Compañia.Tipo = 0
        Me.Cmb_Compañia.ValueMember = "Id_Cia"
        '
        'Lbl_Compañia
        '
        Me.Lbl_Compañia.AutoSize = True
        Me.Lbl_Compañia.Location = New System.Drawing.Point(46, 43)
        Me.Lbl_Compañia.Name = "Lbl_Compañia"
        Me.Lbl_Compañia.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_Compañia.TabIndex = 3
        Me.Lbl_Compañia.Text = "Compañia"
        '
        'Chk_Clientes
        '
        Me.Chk_Clientes.AutoSize = True
        Me.Chk_Clientes.Location = New System.Drawing.Point(512, 69)
        Me.Chk_Clientes.Name = "Chk_Clientes"
        Me.Chk_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Clientes.TabIndex = 9
        Me.Chk_Clientes.Text = "Todos"
        Me.Chk_Clientes.UseVisualStyleBackColor = True
        '
        'Cmb_Clientes
        '
        Me.Cmb_Clientes.Clave = "Clave_Cliente"
        Me.Cmb_Clientes.Control_Siguiente = Nothing
        Me.Cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.Cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Clientes.Empresa = False
        Me.Cmb_Clientes.Enabled = False
        Me.Cmb_Clientes.Filtro = Nothing
        Me.Cmb_Clientes.FormattingEnabled = True
        Me.Cmb_Clientes.Location = New System.Drawing.Point(106, 67)
        Me.Cmb_Clientes.MaxDropDownItems = 20
        Me.Cmb_Clientes.Name = "Cmb_Clientes"
        Me.Cmb_Clientes.Pista = False
        Me.Cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_Clientes.StoredProcedure = "Cat_Clientes_GetPadres"
        Me.Cmb_Clientes.Sucursal = True
        Me.Cmb_Clientes.TabIndex = 7
        Me.Cmb_Clientes.Tipo = 0
        Me.Cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(61, 70)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 5
        Me.lbl_Cliente.Text = "Cliente"
        '
        'Cmb_grupo
        '
        Me.Cmb_grupo.Clave = ""
        Me.Cmb_grupo.Control_Siguiente = Me.btn_Mostrar
        Me.Cmb_grupo.DisplayMember = "Descripcion"
        Me.Cmb_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_grupo.Empresa = False
        Me.Cmb_grupo.Filtro = Nothing
        Me.Cmb_grupo.FormattingEnabled = True
        Me.Cmb_grupo.Location = New System.Drawing.Point(106, 149)
        Me.Cmb_grupo.MaxDropDownItems = 20
        Me.Cmb_grupo.Name = "Cmb_grupo"
        Me.Cmb_grupo.Pista = False
        Me.Cmb_grupo.Size = New System.Drawing.Size(232, 21)
        Me.Cmb_grupo.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.Cmb_grupo.Sucursal = False
        Me.Cmb_grupo.TabIndex = 17
        Me.Cmb_grupo.Tipo = 0
        Me.Cmb_grupo.ValueMember = "Id_GrupoDepo"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(106, 199)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 24
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Grupo
        '
        Me.chk_Grupo.AutoSize = True
        Me.chk_Grupo.Location = New System.Drawing.Point(344, 151)
        Me.chk_Grupo.Name = "chk_Grupo"
        Me.chk_Grupo.Size = New System.Drawing.Size(56, 17)
        Me.chk_Grupo.TabIndex = 18
        Me.chk_Grupo.Text = "Todos"
        Me.chk_Grupo.UseVisualStyleBackColor = True
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(22, 152)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Grupo.TabIndex = 16
        Me.lbl_Grupo.Text = "Grupo Proceso"
        '
        'rdb_Todo
        '
        Me.rdb_Todo.AutoSize = True
        Me.rdb_Todo.Location = New System.Drawing.Point(276, 176)
        Me.rdb_Todo.Name = "rdb_Todo"
        Me.rdb_Todo.Size = New System.Drawing.Size(57, 17)
        Me.rdb_Todo.TabIndex = 21
        Me.rdb_Todo.Text = "Ambos"
        Me.rdb_Todo.UseVisualStyleBackColor = True
        '
        'Lbl_NotaT
        '
        Me.Lbl_NotaT.Location = New System.Drawing.Point(423, 176)
        Me.Lbl_NotaT.Name = "Lbl_NotaT"
        Me.Lbl_NotaT.Size = New System.Drawing.Size(322, 52)
        Me.Lbl_NotaT.TabIndex = 23
        Me.Lbl_NotaT.Text = "Si selecciona el grupo de facturacion de Clientes y un periodo muy amplio, la con" &
    "sulta puede tardar algunos segundos extra debido a la cantidad de depósitos que " &
    "existen."
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(374, 180)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Nota.TabIndex = 22
        Me.Lbl_Nota.Text = "NOTA: "
        '
        'rdb_Morralla
        '
        Me.rdb_Morralla.AutoSize = True
        Me.rdb_Morralla.Location = New System.Drawing.Point(195, 176)
        Me.rdb_Morralla.Name = "rdb_Morralla"
        Me.rdb_Morralla.Size = New System.Drawing.Size(62, 17)
        Me.rdb_Morralla.TabIndex = 20
        Me.rdb_Morralla.Text = "Morralla"
        Me.rdb_Morralla.UseVisualStyleBackColor = True
        '
        'rdb_Proceso
        '
        Me.rdb_Proceso.AutoSize = True
        Me.rdb_Proceso.Checked = True
        Me.rdb_Proceso.Location = New System.Drawing.Point(106, 176)
        Me.rdb_Proceso.Name = "rdb_Proceso"
        Me.rdb_Proceso.Size = New System.Drawing.Size(64, 17)
        Me.rdb_Proceso.TabIndex = 19
        Me.rdb_Proceso.TabStop = True
        Me.rdb_Proceso.Text = "Proceso"
        Me.rdb_Proceso.UseVisualStyleBackColor = True
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Clave = Nothing
        Me.cmb_Hasta.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.Filtro = Nothing
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(286, 94)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 13
        Me.cmb_Hasta.Tipo = 0
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Clave = Nothing
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Filtro = Nothing
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(106, 122)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 15
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Clave = Nothing
        Me.cmb_Desde.Control_Siguiente = Me.cmb_Hasta
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.Filtro = Nothing
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(106, 94)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 11
        Me.cmb_Desde.Tipo = 0
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(54, 125)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 14
        Me.lbl_Moneda.Text = "Moneda"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(62, 97)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 10
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(242, 97)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 12
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(27, 16)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Desde
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(106, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 2
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.lbl_remisionesDescargadas)
        Me.gbx_Botones.Controls.Add(Me.Label1)
        Me.gbx_Botones.Controls.Add(Me.btn_path)
        Me.gbx_Botones.Controls.Add(Me.txb_path)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 570)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(895, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'lbl_remisionesDescargadas
        '
        Me.lbl_remisionesDescargadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_remisionesDescargadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remisionesDescargadas.Location = New System.Drawing.Point(619, 29)
        Me.lbl_remisionesDescargadas.Name = "lbl_remisionesDescargadas"
        Me.lbl_remisionesDescargadas.Size = New System.Drawing.Size(71, 16)
        Me.lbl_remisionesDescargadas.TabIndex = 7
        Me.lbl_remisionesDescargadas.Text = "0"
        Me.lbl_remisionesDescargadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Remisiones Descargadas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_path
        '
        Me.btn_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_path.Location = New System.Drawing.Point(469, 17)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(37, 20)
        Me.btn_path.TabIndex = 6
        Me.btn_path.Text = "***"
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'txb_path
        '
        Me.txb_path.Enabled = False
        Me.txb_path.Location = New System.Drawing.Point(175, 17)
        Me.txb_path.Name = "txb_path"
        Me.txb_path.Size = New System.Drawing.Size(288, 20)
        Me.txb_path.TabIndex = 5
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 11)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Descargar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(746, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(3, 239)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(895, 325)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        Me.gbx_Dotaciones.Text = "Concentraciones o Depósitos"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(749, 11)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 13)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.AllowColumnReorder = True
        Me.lsv_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(3, 27)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 10
        Me.lsv_Dotaciones.Row10 = 0
        Me.lsv_Dotaciones.Row2 = 10
        Me.lsv_Dotaciones.Row3 = 10
        Me.lsv_Dotaciones.Row4 = 35
        Me.lsv_Dotaciones.Row5 = 10
        Me.lsv_Dotaciones.Row6 = 10
        Me.lsv_Dotaciones.Row7 = 10
        Me.lsv_Dotaciones.Row8 = 0
        Me.lsv_Dotaciones.Row9 = 0
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(889, 294)
        Me.lsv_Dotaciones.TabIndex = 1
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'frm_DetalleDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 624)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DetalleDepositos"
        Me.Text = "Descarga Remision por Fechas"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Botones.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Morralla As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Proceso As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Hasta As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Desde As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Moneda As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Dotaciones As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents Lbl_NotaT As System.Windows.Forms.Label
    Friend WithEvents rdb_Todo As System.Windows.Forms.RadioButton
    Friend WithEvents Cmb_grupo As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Cmb_Clientes As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents Chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Compañia As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents Cmb_ClientesP As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents btn_path As Button
    Friend WithEvents txb_path As TextBox
    Friend WithEvents lbl_remisionesDescargadas As Label
    Friend WithEvents Label1 As Label
End Class
