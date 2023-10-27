<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValidaCV
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Validar = New System.Windows.Forms.Button()
        Me.gbx_CV = New System.Windows.Forms.GroupBox()
        Me.chk_SubClientes = New System.Windows.Forms.CheckBox()
        Me.chk_TodosCf = New System.Windows.Forms.CheckBox()
        Me.Tbx_Filtro2 = New Modulo_Facturacion.cp_Textbox()
        Me.cmb_ClienteF = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Precio = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Hora = New Modulo_Facturacion.cp_Textbox()
        Me.tbx_HoraLL = New Modulo_Facturacion.cp_Textbox()
        Me.tbx_HoraS = New Modulo_Facturacion.cp_Textbox()
        Me.tbx_Comentarios = New Modulo_Facturacion.cp_Textbox()
        Me.tbx_ComentariosCancela = New Modulo_Facturacion.cp_Textbox()
        Me.tbx_Precio = New Modulo_Facturacion.cp_Textbox()
        Me.lbl_ClienteF = New System.Windows.Forms.Label()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.lbl_ComentariosC = New System.Windows.Forms.Label()
        Me.lbl_ComentariosV = New System.Windows.Forms.Label()
        Me.lbl_HoraS = New System.Windows.Forms.Label()
        Me.lbl_HoraL = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.txt_Clave = New Modulo_Facturacion.cp_Textbox()
        Me.cmb_Cliente = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_CV.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Location = New System.Drawing.Point(2, 505)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(781, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_Cancelar.Location = New System.Drawing.Point(153, 12)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cancelar CV      F4"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(635, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Validar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar CV    F2"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'gbx_CV
        '
        Me.gbx_CV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CV.Controls.Add(Me.chk_SubClientes)
        Me.gbx_CV.Controls.Add(Me.chk_TodosCf)
        Me.gbx_CV.Controls.Add(Me.Tbx_Filtro2)
        Me.gbx_CV.Controls.Add(Me.cmb_ClienteF)
        Me.gbx_CV.Controls.Add(Me.lbl_ClienteF)
        Me.gbx_CV.Controls.Add(Me.Lbl_Registros)
        Me.gbx_CV.Controls.Add(Me.lsv_Datos)
        Me.gbx_CV.Controls.Add(Me.btn_Mostrar)
        Me.gbx_CV.Controls.Add(Me.lbl_Desde)
        Me.gbx_CV.Controls.Add(Me.lbl_Hasta)
        Me.gbx_CV.Controls.Add(Me.dtp_Hasta)
        Me.gbx_CV.Controls.Add(Me.dtp_Desde)
        Me.gbx_CV.Location = New System.Drawing.Point(2, 2)
        Me.gbx_CV.Name = "gbx_CV"
        Me.gbx_CV.Size = New System.Drawing.Size(781, 333)
        Me.gbx_CV.TabIndex = 0
        Me.gbx_CV.TabStop = False
        '
        'chk_SubClientes
        '
        Me.chk_SubClientes.AutoSize = True
        Me.chk_SubClientes.Location = New System.Drawing.Point(603, 45)
        Me.chk_SubClientes.Name = "chk_SubClientes"
        Me.chk_SubClientes.Size = New System.Drawing.Size(82, 17)
        Me.chk_SubClientes.TabIndex = 8
        Me.chk_SubClientes.Text = "SubClientes"
        Me.chk_SubClientes.UseVisualStyleBackColor = True
        '
        'chk_TodosCf
        '
        Me.chk_TodosCf.AutoSize = True
        Me.chk_TodosCf.Location = New System.Drawing.Point(541, 45)
        Me.chk_TodosCf.Name = "chk_TodosCf"
        Me.chk_TodosCf.Size = New System.Drawing.Size(56, 17)
        Me.chk_TodosCf.TabIndex = 7
        Me.chk_TodosCf.Text = "Todos"
        Me.chk_TodosCf.UseVisualStyleBackColor = True
        '
        'Tbx_Filtro2
        '
        Me.Tbx_Filtro2.Control_Siguiente = Me.cmb_ClienteF
        Me.Tbx_Filtro2.Filtrado = True
        Me.Tbx_Filtro2.Location = New System.Drawing.Point(56, 44)
        Me.Tbx_Filtro2.MaxLength = 12
        Me.Tbx_Filtro2.Name = "Tbx_Filtro2"
        Me.Tbx_Filtro2.Size = New System.Drawing.Size(73, 20)
        Me.Tbx_Filtro2.TabIndex = 5
        Me.Tbx_Filtro2.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_ClienteF
        '
        Me.cmb_ClienteF.Clave = "Clave_Cliente"
        Me.cmb_ClienteF.Control_Siguiente = Me.cmb_Precio
        Me.cmb_ClienteF.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClienteF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteF.Empresa = False
        Me.cmb_ClienteF.Filtro = Me.Tbx_Filtro2
        Me.cmb_ClienteF.FormattingEnabled = True
        Me.cmb_ClienteF.Location = New System.Drawing.Point(135, 43)
        Me.cmb_ClienteF.Name = "cmb_ClienteF"
        Me.cmb_ClienteF.Pista = False
        Me.cmb_ClienteF.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClienteF.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_ClienteF.Sucursal = True
        Me.cmb_ClienteF.TabIndex = 6
        Me.cmb_ClienteF.Tipo = 0
        Me.cmb_ClienteF.ValueMember = "Id_Cliente"
        '
        'cmb_Precio
        '
        Me.cmb_Precio.Clave = "Clave_Precio"
        Me.cmb_Precio.Control_Siguiente = Me.tbx_Hora
        Me.cmb_Precio.DisplayMember = "Descripcion"
        Me.cmb_Precio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Precio.Empresa = False
        Me.cmb_Precio.Filtro = Me.tbx_Precio
        Me.cmb_Precio.FormattingEnabled = True
        Me.cmb_Precio.Location = New System.Drawing.Point(175, 41)
        Me.cmb_Precio.Name = "cmb_Precio"
        Me.cmb_Precio.Pista = False
        Me.cmb_Precio.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Precio.StoredProcedure = "Cat_PreciosXclienteCvCombo_Get"
        Me.cmb_Precio.Sucursal = False
        Me.cmb_Precio.TabIndex = 6
        Me.cmb_Precio.Tipo = 0
        Me.cmb_Precio.ValueMember = "Id_cs"
        '
        'tbx_Hora
        '
        Me.tbx_Hora.Control_Siguiente = Me.tbx_HoraLL
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(96, 68)
        Me.tbx_Hora.MaxLength = 5
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(73, 20)
        Me.tbx_Hora.TabIndex = 8
        Me.tbx_Hora.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_HoraLL
        '
        Me.tbx_HoraLL.Control_Siguiente = Me.tbx_HoraS
        Me.tbx_HoraLL.Filtrado = True
        Me.tbx_HoraLL.Location = New System.Drawing.Point(96, 94)
        Me.tbx_HoraLL.MaxLength = 5
        Me.tbx_HoraLL.Name = "tbx_HoraLL"
        Me.tbx_HoraLL.Size = New System.Drawing.Size(73, 20)
        Me.tbx_HoraLL.TabIndex = 10
        Me.tbx_HoraLL.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_HoraS
        '
        Me.tbx_HoraS.Control_Siguiente = Me.tbx_Comentarios
        Me.tbx_HoraS.Filtrado = True
        Me.tbx_HoraS.Location = New System.Drawing.Point(96, 120)
        Me.tbx_HoraS.MaxLength = 5
        Me.tbx_HoraS.Name = "tbx_HoraS"
        Me.tbx_HoraS.Size = New System.Drawing.Size(73, 20)
        Me.tbx_HoraS.TabIndex = 12
        Me.tbx_HoraS.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Control_Siguiente = Me.tbx_ComentariosCancela
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(257, 68)
        Me.tbx_Comentarios.MaxLength = 200
        Me.tbx_Comentarios.Multiline = True
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(375, 40)
        Me.tbx_Comentarios.TabIndex = 14
        Me.tbx_Comentarios.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_ComentariosCancela
        '
        Me.tbx_ComentariosCancela.Control_Siguiente = Me.btn_Validar
        Me.tbx_ComentariosCancela.Filtrado = True
        Me.tbx_ComentariosCancela.Location = New System.Drawing.Point(257, 113)
        Me.tbx_ComentariosCancela.MaxLength = 200
        Me.tbx_ComentariosCancela.Multiline = True
        Me.tbx_ComentariosCancela.Name = "tbx_ComentariosCancela"
        Me.tbx_ComentariosCancela.Size = New System.Drawing.Size(375, 38)
        Me.tbx_ComentariosCancela.TabIndex = 16
        Me.tbx_ComentariosCancela.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Precio
        '
        Me.tbx_Precio.Control_Siguiente = Me.cmb_Precio
        Me.tbx_Precio.Filtrado = True
        Me.tbx_Precio.Location = New System.Drawing.Point(95, 41)
        Me.tbx_Precio.MaxLength = 12
        Me.tbx_Precio.Name = "tbx_Precio"
        Me.tbx_Precio.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Precio.TabIndex = 5
        Me.tbx_Precio.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_ClienteF
        '
        Me.lbl_ClienteF.AutoSize = True
        Me.lbl_ClienteF.Location = New System.Drawing.Point(8, 47)
        Me.lbl_ClienteF.Name = "lbl_ClienteF"
        Me.lbl_ClienteF.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ClienteF.TabIndex = 4
        Me.lbl_ClienteF.Text = "Cliente:"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(630, 85)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(145, 18)
        Me.Lbl_Registros.TabIndex = 9
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 106)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 8
        Me.lsv_Datos.Row10 = 15
        Me.lsv_Datos.Row2 = 8
        Me.lsv_Datos.Row3 = 8
        Me.lsv_Datos.Row4 = 8
        Me.lsv_Datos.Row5 = 8
        Me.lsv_Datos.Row6 = 8
        Me.lsv_Datos.Row7 = 20
        Me.lsv_Datos.Row8 = 15
        Me.lsv_Datos.Row9 = 10
        Me.lsv_Datos.Size = New System.Drawing.Size(769, 221)
        Me.lsv_Datos.TabIndex = 11
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(56, 70)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(157, 20)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(198, 17)
        Me.dtp_Hasta.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        Me.dtp_Hasta.Value = New Date(2012, 1, 5, 0, 0, 0, 0)
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(56, 17)
        Me.dtp_Desde.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        Me.dtp_Desde.Value = New Date(2012, 1, 5, 0, 0, 0, 0)
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.lbl_ComentariosC)
        Me.gbx_Detalle.Controls.Add(Me.tbx_ComentariosCancela)
        Me.gbx_Detalle.Controls.Add(Me.lbl_ComentariosV)
        Me.gbx_Detalle.Controls.Add(Me.tbx_HoraS)
        Me.gbx_Detalle.Controls.Add(Me.lbl_HoraS)
        Me.gbx_Detalle.Controls.Add(Me.tbx_HoraLL)
        Me.gbx_Detalle.Controls.Add(Me.lbl_HoraL)
        Me.gbx_Detalle.Controls.Add(Me.btn_Buscar)
        Me.gbx_Detalle.Controls.Add(Me.tbx_Precio)
        Me.gbx_Detalle.Controls.Add(Me.cmb_Precio)
        Me.gbx_Detalle.Controls.Add(Me.lbl_Precio)
        Me.gbx_Detalle.Controls.Add(Me.tbx_Comentarios)
        Me.gbx_Detalle.Controls.Add(Me.tbx_Hora)
        Me.gbx_Detalle.Controls.Add(Me.lbl_Hora)
        Me.gbx_Detalle.Controls.Add(Me.txt_Clave)
        Me.gbx_Detalle.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Detalle.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Detalle.Location = New System.Drawing.Point(2, 341)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(781, 158)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        '
        'lbl_ComentariosC
        '
        Me.lbl_ComentariosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ComentariosC.Location = New System.Drawing.Point(186, 114)
        Me.lbl_ComentariosC.Name = "lbl_ComentariosC"
        Me.lbl_ComentariosC.Size = New System.Drawing.Size(65, 28)
        Me.lbl_ComentariosC.TabIndex = 15
        Me.lbl_ComentariosC.Text = "Comentarios Cancela"
        Me.lbl_ComentariosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ComentariosV
        '
        Me.lbl_ComentariosV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ComentariosV.Location = New System.Drawing.Point(186, 75)
        Me.lbl_ComentariosV.Name = "lbl_ComentariosV"
        Me.lbl_ComentariosV.Size = New System.Drawing.Size(65, 28)
        Me.lbl_ComentariosV.TabIndex = 13
        Me.lbl_ComentariosV.Text = "Comentarios Valida"
        Me.lbl_ComentariosV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_HoraS
        '
        Me.lbl_HoraS.AutoSize = True
        Me.lbl_HoraS.Location = New System.Drawing.Point(12, 123)
        Me.lbl_HoraS.Name = "lbl_HoraS"
        Me.lbl_HoraS.Size = New System.Drawing.Size(77, 13)
        Me.lbl_HoraS.TabIndex = 11
        Me.lbl_HoraS.Text = "Hora de Salida"
        '
        'lbl_HoraL
        '
        Me.lbl_HoraL.AutoSize = True
        Me.lbl_HoraL.Location = New System.Drawing.Point(3, 97)
        Me.lbl_HoraL.Name = "lbl_HoraL"
        Me.lbl_HoraL.Size = New System.Drawing.Size(86, 13)
        Me.lbl_HoraL.TabIndex = 9
        Me.lbl_HoraL.Text = "Hora de Llegada"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(638, 12)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(25, 23)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(52, 44)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Precio.TabIndex = 4
        Me.lbl_Precio.Text = "Precio"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Location = New System.Drawing.Point(27, 71)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(62, 13)
        Me.lbl_Hora.TabIndex = 7
        Me.lbl_Hora.Text = "Hora de CV"
        '
        'txt_Clave
        '
        Me.txt_Clave.Control_Siguiente = Me.cmb_Cliente
        Me.txt_Clave.Filtrado = True
        Me.txt_Clave.Location = New System.Drawing.Point(96, 15)
        Me.txt_Clave.MaxLength = 12
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(73, 20)
        Me.txt_Clave.TabIndex = 1
        Me.txt_Clave.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Me.cmb_Precio
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.txt_Clave
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(175, 14)
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_GetAB"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 2
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(50, 18)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        '
        'frm_ValidaCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_CV)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ValidaCV"
        Me.Text = "Validar Comprobantes de Visita"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_CV.ResumeLayout(False)
        Me.gbx_CV.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Detalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents gbx_CV As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Hora As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents txt_Clave As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_Precio As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Precio As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_ComentariosV As System.Windows.Forms.Label
    Friend WithEvents tbx_HoraS As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_HoraS As System.Windows.Forms.Label
    Friend WithEvents tbx_HoraLL As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_HoraL As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentarios As Modulo_Facturacion.cp_Textbox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_ComentariosC As System.Windows.Forms.Label
    Friend WithEvents tbx_ComentariosCancela As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Tbx_Filtro2 As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_ClienteF As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_ClienteF As System.Windows.Forms.Label
    Friend WithEvents chk_TodosCf As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SubClientes As System.Windows.Forms.CheckBox
End Class
