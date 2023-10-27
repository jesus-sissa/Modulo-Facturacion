<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GruposFacturacion
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
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Clientes = New System.Windows.Forms.TabPage
        Me.tlp_Grupos = New System.Windows.Forms.TableLayoutPanel
        Me.gbx_Grupos = New System.Windows.Forms.GroupBox
        Me.lsv_Grupos = New Modulo_Facturacion.cp_Listview
        Me.gbx_ClientesSG = New System.Windows.Forms.GroupBox
        Me.chk_TodosSG = New System.Windows.Forms.CheckBox
        Me.Btn_Asignar = New System.Windows.Forms.Button
        Me.lsv_ClientesSG = New Modulo_Facturacion.cp_Listview
        Me.gbx_ClientesDG = New System.Windows.Forms.GroupBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.btn_Desasignar = New System.Windows.Forms.Button
        Me.lsv_ClientesDG = New Modulo_Facturacion.cp_Listview
        Me.gbx_Conceptos = New System.Windows.Forms.GroupBox
        Me.lsv_Conceptos = New Modulo_Facturacion.cp_Listview
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.cmb_Concepto = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.Btn_AgregarConcepto = New System.Windows.Forms.Button
        Me.lbl_AgregarConcepto = New System.Windows.Forms.Label
        Me.Tab_Grupos = New System.Windows.Forms.TabPage
        Me.tbx_Grupo = New Modulo_Facturacion.cp_Textbox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lsv_Grupos2 = New Modulo_Facturacion.cp_Listview
        Me.lbl_Grupo = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_CajaBancaria = New System.Windows.Forms.GroupBox
        Me.cmb_CajaBancaria = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Clientes.SuspendLayout()
        Me.tlp_Grupos.SuspendLayout()
        Me.gbx_Grupos.SuspendLayout()
        Me.gbx_ClientesSG.SuspendLayout()
        Me.gbx_ClientesDG.SuspendLayout()
        Me.gbx_Conceptos.SuspendLayout()
        Me.Tab_Grupos.SuspendLayout()
        Me.gbx_CajaBancaria.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Clientes)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Grupos)
        Me.Tab_Catalogo.Location = New System.Drawing.Point(3, 54)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(708, 472)
        Me.Tab_Catalogo.TabIndex = 1
        '
        'tab_Clientes
        '
        Me.tab_Clientes.Controls.Add(Me.tlp_Grupos)
        Me.tab_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.tab_Clientes.Name = "tab_Clientes"
        Me.tab_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Clientes.Size = New System.Drawing.Size(700, 446)
        Me.tab_Clientes.TabIndex = 0
        Me.tab_Clientes.Text = "Clientes por grupos"
        Me.tab_Clientes.UseVisualStyleBackColor = True
        '
        'tlp_Grupos
        '
        Me.tlp_Grupos.ColumnCount = 2
        Me.tlp_Grupos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Grupos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Grupos.Controls.Add(Me.gbx_Grupos, 0, 0)
        Me.tlp_Grupos.Controls.Add(Me.gbx_ClientesSG, 1, 0)
        Me.tlp_Grupos.Controls.Add(Me.gbx_ClientesDG, 0, 1)
        Me.tlp_Grupos.Controls.Add(Me.gbx_Conceptos, 1, 1)
        Me.tlp_Grupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Grupos.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Grupos.Name = "tlp_Grupos"
        Me.tlp_Grupos.RowCount = 2
        Me.tlp_Grupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Grupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Grupos.Size = New System.Drawing.Size(694, 440)
        Me.tlp_Grupos.TabIndex = 0
        '
        'gbx_Grupos
        '
        Me.gbx_Grupos.Controls.Add(Me.lsv_Grupos)
        Me.gbx_Grupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Grupos.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Grupos.Name = "gbx_Grupos"
        Me.gbx_Grupos.Size = New System.Drawing.Size(341, 214)
        Me.gbx_Grupos.TabIndex = 0
        Me.gbx_Grupos.TabStop = False
        Me.gbx_Grupos.Text = "Grupos"
        '
        'lsv_Grupos
        '
        Me.lsv_Grupos.AllowColumnReorder = True
        Me.lsv_Grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Grupos.FullRowSelect = True
        Me.lsv_Grupos.HideSelection = False
        Me.lsv_Grupos.Location = New System.Drawing.Point(3, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Grupos.Lvs = ListViewColumnSorter1
        Me.lsv_Grupos.MultiSelect = False
        Me.lsv_Grupos.Name = "lsv_Grupos"
        Me.lsv_Grupos.Row1 = 70
        Me.lsv_Grupos.Row10 = 10
        Me.lsv_Grupos.Row2 = 20
        Me.lsv_Grupos.Row3 = 10
        Me.lsv_Grupos.Row4 = 10
        Me.lsv_Grupos.Row5 = 10
        Me.lsv_Grupos.Row6 = 10
        Me.lsv_Grupos.Row7 = 10
        Me.lsv_Grupos.Row8 = 10
        Me.lsv_Grupos.Row9 = 10
        Me.lsv_Grupos.Size = New System.Drawing.Size(335, 192)
        Me.lsv_Grupos.TabIndex = 0
        Me.lsv_Grupos.UseCompatibleStateImageBehavior = False
        Me.lsv_Grupos.View = System.Windows.Forms.View.Details
        '
        'gbx_ClientesSG
        '
        Me.gbx_ClientesSG.Controls.Add(Me.chk_TodosSG)
        Me.gbx_ClientesSG.Controls.Add(Me.Btn_Asignar)
        Me.gbx_ClientesSG.Controls.Add(Me.lsv_ClientesSG)
        Me.gbx_ClientesSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_ClientesSG.Location = New System.Drawing.Point(350, 3)
        Me.gbx_ClientesSG.Name = "gbx_ClientesSG"
        Me.gbx_ClientesSG.Size = New System.Drawing.Size(341, 214)
        Me.gbx_ClientesSG.TabIndex = 1
        Me.gbx_ClientesSG.TabStop = False
        Me.gbx_ClientesSG.Text = "Clientes sin Grupo: 0"
        '
        'chk_TodosSG
        '
        Me.chk_TodosSG.AutoSize = True
        Me.chk_TodosSG.Location = New System.Drawing.Point(8, 21)
        Me.chk_TodosSG.Name = "chk_TodosSG"
        Me.chk_TodosSG.Size = New System.Drawing.Size(115, 17)
        Me.chk_TodosSG.TabIndex = 2
        Me.chk_TodosSG.Text = "Seleccionar Todos"
        Me.chk_TodosSG.UseVisualStyleBackColor = True
        '
        'Btn_Asignar
        '
        Me.Btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Asignar.Enabled = False
        Me.Btn_Asignar.Location = New System.Drawing.Point(6, 184)
        Me.Btn_Asignar.Name = "Btn_Asignar"
        Me.Btn_Asignar.Size = New System.Drawing.Size(129, 24)
        Me.Btn_Asignar.TabIndex = 1
        Me.Btn_Asignar.Text = "&Agregar cliente a grupo"
        Me.Btn_Asignar.UseVisualStyleBackColor = False
        '
        'lsv_ClientesSG
        '
        Me.lsv_ClientesSG.AllowColumnReorder = True
        Me.lsv_ClientesSG.AllowDrop = True
        Me.lsv_ClientesSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ClientesSG.CheckBoxes = True
        Me.lsv_ClientesSG.FullRowSelect = True
        Me.lsv_ClientesSG.HideSelection = False
        Me.lsv_ClientesSG.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ClientesSG.Lvs = ListViewColumnSorter2
        Me.lsv_ClientesSG.MultiSelect = False
        Me.lsv_ClientesSG.Name = "lsv_ClientesSG"
        Me.lsv_ClientesSG.Row1 = 25
        Me.lsv_ClientesSG.Row10 = 0
        Me.lsv_ClientesSG.Row2 = 50
        Me.lsv_ClientesSG.Row3 = 20
        Me.lsv_ClientesSG.Row4 = 0
        Me.lsv_ClientesSG.Row5 = 0
        Me.lsv_ClientesSG.Row6 = 0
        Me.lsv_ClientesSG.Row7 = 0
        Me.lsv_ClientesSG.Row8 = 0
        Me.lsv_ClientesSG.Row9 = 0
        Me.lsv_ClientesSG.Size = New System.Drawing.Size(329, 138)
        Me.lsv_ClientesSG.TabIndex = 0
        Me.lsv_ClientesSG.UseCompatibleStateImageBehavior = False
        Me.lsv_ClientesSG.View = System.Windows.Forms.View.Details
        '
        'gbx_ClientesDG
        '
        Me.gbx_ClientesDG.Controls.Add(Me.chk_Todos)
        Me.gbx_ClientesDG.Controls.Add(Me.btn_Desasignar)
        Me.gbx_ClientesDG.Controls.Add(Me.lsv_ClientesDG)
        Me.gbx_ClientesDG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_ClientesDG.Location = New System.Drawing.Point(3, 223)
        Me.gbx_ClientesDG.Name = "gbx_ClientesDG"
        Me.gbx_ClientesDG.Size = New System.Drawing.Size(341, 214)
        Me.gbx_ClientesDG.TabIndex = 2
        Me.gbx_ClientesDG.TabStop = False
        Me.gbx_ClientesDG.Text = "Clientes del Grupo: 0"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(8, 19)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(115, 17)
        Me.chk_Todos.TabIndex = 3
        Me.chk_Todos.Text = "Seleccionar Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'btn_Desasignar
        '
        Me.btn_Desasignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Desasignar.Enabled = False
        Me.btn_Desasignar.Location = New System.Drawing.Point(6, 183)
        Me.btn_Desasignar.Name = "btn_Desasignar"
        Me.btn_Desasignar.Size = New System.Drawing.Size(133, 24)
        Me.btn_Desasignar.TabIndex = 1
        Me.btn_Desasignar.Text = "&Eliminar cliente de grupo"
        Me.btn_Desasignar.UseVisualStyleBackColor = True
        '
        'lsv_ClientesDG
        '
        Me.lsv_ClientesDG.AllowColumnReorder = True
        Me.lsv_ClientesDG.AllowDrop = True
        Me.lsv_ClientesDG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ClientesDG.CheckBoxes = True
        Me.lsv_ClientesDG.FullRowSelect = True
        Me.lsv_ClientesDG.HideSelection = False
        Me.lsv_ClientesDG.Location = New System.Drawing.Point(6, 39)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_ClientesDG.Lvs = ListViewColumnSorter3
        Me.lsv_ClientesDG.MultiSelect = False
        Me.lsv_ClientesDG.Name = "lsv_ClientesDG"
        Me.lsv_ClientesDG.Row1 = 25
        Me.lsv_ClientesDG.Row10 = 0
        Me.lsv_ClientesDG.Row2 = 50
        Me.lsv_ClientesDG.Row3 = 20
        Me.lsv_ClientesDG.Row4 = 0
        Me.lsv_ClientesDG.Row5 = 0
        Me.lsv_ClientesDG.Row6 = 0
        Me.lsv_ClientesDG.Row7 = 0
        Me.lsv_ClientesDG.Row8 = 0
        Me.lsv_ClientesDG.Row9 = 0
        Me.lsv_ClientesDG.Size = New System.Drawing.Size(329, 138)
        Me.lsv_ClientesDG.TabIndex = 0
        Me.lsv_ClientesDG.UseCompatibleStateImageBehavior = False
        Me.lsv_ClientesDG.View = System.Windows.Forms.View.Details
        '
        'gbx_Conceptos
        '
        Me.gbx_Conceptos.Controls.Add(Me.Btn_AgregarConcepto)
        Me.gbx_Conceptos.Controls.Add(Me.cmb_Concepto)
        Me.gbx_Conceptos.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Conceptos.Controls.Add(Me.lbl_AgregarConcepto)
        Me.gbx_Conceptos.Controls.Add(Me.lsv_Conceptos)
        Me.gbx_Conceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Conceptos.Location = New System.Drawing.Point(350, 223)
        Me.gbx_Conceptos.Name = "gbx_Conceptos"
        Me.gbx_Conceptos.Size = New System.Drawing.Size(341, 214)
        Me.gbx_Conceptos.TabIndex = 3
        Me.gbx_Conceptos.TabStop = False
        Me.gbx_Conceptos.Text = "Conceptos de facturación"
        '
        'lsv_Conceptos
        '
        Me.lsv_Conceptos.AllowColumnReorder = True
        Me.lsv_Conceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Conceptos.FullRowSelect = True
        Me.lsv_Conceptos.HideSelection = False
        Me.lsv_Conceptos.Location = New System.Drawing.Point(6, 18)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Conceptos.Lvs = ListViewColumnSorter4
        Me.lsv_Conceptos.MultiSelect = False
        Me.lsv_Conceptos.Name = "lsv_Conceptos"
        Me.lsv_Conceptos.Row1 = 50
        Me.lsv_Conceptos.Row10 = 0
        Me.lsv_Conceptos.Row2 = 35
        Me.lsv_Conceptos.Row3 = 12
        Me.lsv_Conceptos.Row4 = 0
        Me.lsv_Conceptos.Row5 = 0
        Me.lsv_Conceptos.Row6 = 0
        Me.lsv_Conceptos.Row7 = 0
        Me.lsv_Conceptos.Row8 = 0
        Me.lsv_Conceptos.Row9 = 0
        Me.lsv_Conceptos.Size = New System.Drawing.Size(329, 159)
        Me.lsv_Conceptos.TabIndex = 0
        Me.lsv_Conceptos.UseCompatibleStateImageBehavior = False
        Me.lsv_Conceptos.View = System.Windows.Forms.View.Details
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 183)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 0
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'cmb_Concepto
        '
        Me.cmb_Concepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Concepto.Clave = Nothing
        Me.cmb_Concepto.Control_Siguiente = Me.Btn_AgregarConcepto
        Me.cmb_Concepto.DisplayMember = "Descripcion"
        Me.cmb_Concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Concepto.Empresa = False
        Me.cmb_Concepto.Filtro = Nothing
        Me.cmb_Concepto.FormattingEnabled = True
        Me.cmb_Concepto.Location = New System.Drawing.Point(146, 185)
        Me.cmb_Concepto.MaxDropDownItems = 15
        Me.cmb_Concepto.Name = "cmb_Concepto"
        Me.cmb_Concepto.Pista = False
        Me.cmb_Concepto.Size = New System.Drawing.Size(102, 21)
        Me.cmb_Concepto.StoredProcedure = "Cat_ConceptosFproceso_Get"
        Me.cmb_Concepto.Sucursal = False
        Me.cmb_Concepto.TabIndex = 2
        Me.cmb_Concepto.Tipo = 0
        Me.cmb_Concepto.ValueMember = "Id_Concepto"
        '
        'Btn_AgregarConcepto
        '
        Me.Btn_AgregarConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AgregarConcepto.Enabled = False
        Me.Btn_AgregarConcepto.Location = New System.Drawing.Point(260, 183)
        Me.Btn_AgregarConcepto.Name = "Btn_AgregarConcepto"
        Me.Btn_AgregarConcepto.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AgregarConcepto.TabIndex = 3
        Me.Btn_AgregarConcepto.Text = "Agregar"
        Me.Btn_AgregarConcepto.UseVisualStyleBackColor = True
        '
        'lbl_AgregarConcepto
        '
        Me.lbl_AgregarConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_AgregarConcepto.AutoSize = True
        Me.lbl_AgregarConcepto.Location = New System.Drawing.Point(87, 188)
        Me.lbl_AgregarConcepto.Name = "lbl_AgregarConcepto"
        Me.lbl_AgregarConcepto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_AgregarConcepto.TabIndex = 1
        Me.lbl_AgregarConcepto.Text = "Concepto"
        '
        'Tab_Grupos
        '
        Me.Tab_Grupos.Controls.Add(Me.tbx_Grupo)
        Me.Tab_Grupos.Controls.Add(Me.lsv_Grupos2)
        Me.Tab_Grupos.Controls.Add(Me.lbl_Grupo)
        Me.Tab_Grupos.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Grupos.Controls.Add(Me.btn_Guardar)
        Me.Tab_Grupos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Grupos.Name = "Tab_Grupos"
        Me.Tab_Grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Grupos.Size = New System.Drawing.Size(700, 446)
        Me.Tab_Grupos.TabIndex = 1
        Me.Tab_Grupos.Text = "Grupos"
        Me.Tab_Grupos.UseVisualStyleBackColor = True
        '
        'tbx_Grupo
        '
        Me.tbx_Grupo.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Grupo.Filtrado = True
        Me.tbx_Grupo.Location = New System.Drawing.Point(45, 6)
        Me.tbx_Grupo.MaxLength = 50
        Me.tbx_Grupo.Name = "tbx_Grupo"
        Me.tbx_Grupo.Size = New System.Drawing.Size(286, 20)
        Me.tbx_Grupo.TabIndex = 1
        Me.tbx_Grupo.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(45, 33)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lsv_Grupos2
        '
        Me.lsv_Grupos2.AllowColumnReorder = True
        Me.lsv_Grupos2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Grupos2.FullRowSelect = True
        Me.lsv_Grupos2.HideSelection = False
        Me.lsv_Grupos2.Location = New System.Drawing.Point(6, 69)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Grupos2.Lvs = ListViewColumnSorter5
        Me.lsv_Grupos2.MultiSelect = False
        Me.lsv_Grupos2.Name = "lsv_Grupos2"
        Me.lsv_Grupos2.Row1 = 70
        Me.lsv_Grupos2.Row10 = 0
        Me.lsv_Grupos2.Row2 = 20
        Me.lsv_Grupos2.Row3 = 10
        Me.lsv_Grupos2.Row4 = 0
        Me.lsv_Grupos2.Row5 = 0
        Me.lsv_Grupos2.Row6 = 0
        Me.lsv_Grupos2.Row7 = 0
        Me.lsv_Grupos2.Row8 = 0
        Me.lsv_Grupos2.Row9 = 0
        Me.lsv_Grupos2.Size = New System.Drawing.Size(686, 371)
        Me.lsv_Grupos2.TabIndex = 4
        Me.lsv_Grupos2.UseCompatibleStateImageBehavior = False
        Me.lsv_Grupos2.View = System.Windows.Forms.View.Details
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(3, 9)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Grupo.TabIndex = 0
        Me.lbl_Grupo.Text = "Grupo"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(191, 33)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_CajaBancaria
        '
        Me.gbx_CajaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CajaBancaria.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_CajaBancaria.Controls.Add(Me.lbl_Nombre)
        Me.gbx_CajaBancaria.Location = New System.Drawing.Point(3, 4)
        Me.gbx_CajaBancaria.Name = "gbx_CajaBancaria"
        Me.gbx_CajaBancaria.Size = New System.Drawing.Size(708, 44)
        Me.gbx_CajaBancaria.TabIndex = 0
        Me.gbx_CajaBancaria.TabStop = False
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Banco"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(91, 15)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(15, 20)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Caja Bancaria"
        '
        'frm_GruposFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 538)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Controls.Add(Me.gbx_CajaBancaria)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_GruposFacturacion"
        Me.Text = "Grupos de Facturación a Bancos"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Clientes.ResumeLayout(False)
        Me.tlp_Grupos.ResumeLayout(False)
        Me.gbx_Grupos.ResumeLayout(False)
        Me.gbx_ClientesSG.ResumeLayout(False)
        Me.gbx_ClientesSG.PerformLayout()
        Me.gbx_ClientesDG.ResumeLayout(False)
        Me.gbx_ClientesDG.PerformLayout()
        Me.gbx_Conceptos.ResumeLayout(False)
        Me.gbx_Conceptos.PerformLayout()
        Me.Tab_Grupos.ResumeLayout(False)
        Me.Tab_Grupos.PerformLayout()
        Me.gbx_CajaBancaria.ResumeLayout(False)
        Me.gbx_CajaBancaria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Grupos As System.Windows.Forms.TabPage
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents lsv_Grupos2 As Modulo_Facturacion.cp_Listview
    Friend WithEvents tlp_Grupos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbx_Grupos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_ClientesSG As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_ClientesDG As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Conceptos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Grupos As Modulo_Facturacion.cp_Listview
    Friend WithEvents lsv_ClientesSG As Modulo_Facturacion.cp_Listview
    Friend WithEvents lsv_ClientesDG As Modulo_Facturacion.cp_Listview
    Friend WithEvents lsv_Conceptos As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_CajaBancaria As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents lbl_AgregarConcepto As System.Windows.Forms.Label
    Friend WithEvents Btn_AgregarConcepto As System.Windows.Forms.Button
    Friend WithEvents cmb_Concepto As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CajaBancaria As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Grupo As Modulo_Facturacion.cp_Textbox
    Friend WithEvents btn_Desasignar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_TodosSG As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
End Class
