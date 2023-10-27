<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MovimientosAgregar
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
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MovimientosAgregar))
        Me.gbx_Movimientos = New System.Windows.Forms.GroupBox
        Me.Lbl_Descripcion = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.Lbl_Kilometraje = New System.Windows.Forms.Label
        Me.Lbl_EnvasesExceso = New System.Windows.Forms.Label
        Me.Lbl_CoutaRiesgo = New System.Windows.Forms.Label
        Me.Lbl_Precio = New System.Windows.Forms.Label
        Me.Lbl_Tipo = New System.Windows.Forms.Label
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.Lbl_Ruta = New System.Windows.Forms.Label
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Lbl_ImporteRem = New System.Windows.Forms.Label
        Me.gbx_RemisionesD = New System.Windows.Forms.GroupBox
        Me.dgv_Importes = New System.Windows.Forms.DataGridView
        Me.lsv_Remisiones = New Modulo_Facturacion.cp_Listview
        Me.tbx_Descripcion = New Modulo_Facturacion.cp_Textbox
        Me.tbx_CantidadKM = New Modulo_Facturacion.cp_Textbox
        Me.cmb_Tipo = New Modulo_Facturacion.cp_cmb_Manual
        Me.cmb_Cliente = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cliente = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Hora = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Ruta = New Modulo_Facturacion.cp_Textbox
        Me.cmb_Ruta = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Kilometraje = New Modulo_Facturacion.cp_Textbox
        Me.tbx_EnvasesE = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Cuota = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Precio = New Modulo_Facturacion.cp_Textbox
        Me.cmb_Kilometraje = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_EnvasesE = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Precio = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cuota = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Total = New Modulo_Facturacion.cp_Textbox
        Me.gbx_Movimientos.SuspendLayout()
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_RemisionesD.SuspendLayout()
        CType(Me.dgv_Importes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Movimientos
        '
        Me.gbx_Movimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Descripcion)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_CantidadKM)
        Me.gbx_Movimientos.Controls.Add(Me.Label11)
        Me.gbx_Movimientos.Controls.Add(Me.btn_Buscar)
        Me.gbx_Movimientos.Controls.Add(Me.chk_Todos)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Tipo)
        Me.gbx_Movimientos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Fecha)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Hora)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Ruta)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_EnvasesE)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Cuota)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Precio)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Ruta)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_EnvasesE)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Precio)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Cuota)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_EnvasesExceso)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_CoutaRiesgo)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Precio)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Tipo)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Hora)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Ruta)
        Me.gbx_Movimientos.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Movimientos.Name = "gbx_Movimientos"
        Me.gbx_Movimientos.Size = New System.Drawing.Size(766, 251)
        Me.gbx_Movimientos.TabIndex = 0
        Me.gbx_Movimientos.TabStop = False
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(51, 86)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Descripcion.TabIndex = 10
        Me.Lbl_Descripcion.Text = "Descripción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(718, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "KM"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(663, 34)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(25, 23)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(665, 63)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 9
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        Me.chk_Todos.Visible = False
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(119, 223)
        Me.dtp_Fecha.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Fecha.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 27
        Me.dtp_Fecha.Value = New Date(2012, 1, 5, 0, 0, 0, 0)
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(76, 227)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 26
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Lbl_Kilometraje
        '
        Me.Lbl_Kilometraje.AutoSize = True
        Me.Lbl_Kilometraje.Location = New System.Drawing.Point(56, 179)
        Me.Lbl_Kilometraje.Name = "Lbl_Kilometraje"
        Me.Lbl_Kilometraje.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_Kilometraje.TabIndex = 18
        Me.Lbl_Kilometraje.Text = "Kilometraje"
        '
        'Lbl_EnvasesExceso
        '
        Me.Lbl_EnvasesExceso.AutoSize = True
        Me.Lbl_EnvasesExceso.Location = New System.Drawing.Point(13, 156)
        Me.Lbl_EnvasesExceso.Name = "Lbl_EnvasesExceso"
        Me.Lbl_EnvasesExceso.Size = New System.Drawing.Size(101, 13)
        Me.Lbl_EnvasesExceso.TabIndex = 15
        Me.Lbl_EnvasesExceso.Text = "Envases en Exceso"
        '
        'Lbl_CoutaRiesgo
        '
        Me.Lbl_CoutaRiesgo.AutoSize = True
        Me.Lbl_CoutaRiesgo.Location = New System.Drawing.Point(28, 133)
        Me.Lbl_CoutaRiesgo.Name = "Lbl_CoutaRiesgo"
        Me.Lbl_CoutaRiesgo.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_CoutaRiesgo.TabIndex = 12
        Me.Lbl_CoutaRiesgo.Text = "Cuota de Riesgo"
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.Location = New System.Drawing.Point(77, 63)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Precio.TabIndex = 6
        Me.Lbl_Precio.Text = "Precio"
        '
        'Lbl_Tipo
        '
        Me.Lbl_Tipo.AutoSize = True
        Me.Lbl_Tipo.Location = New System.Drawing.Point(85, 14)
        Me.Lbl_Tipo.Name = "Lbl_Tipo"
        Me.Lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_Tipo.TabIndex = 0
        Me.Lbl_Tipo.Text = "Tipo"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(220, 227)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 28
        Me.Lbl_Hora.Text = "Hora"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(75, 39)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 2
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Location = New System.Drawing.Point(84, 203)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Ruta.TabIndex = 23
        Me.Lbl_Ruta.Text = "Ruta"
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Controls.Add(Me.btn_Agregar)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(9, 259)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(766, 146)
        Me.gbx_Remisiones.TabIndex = 1
        Me.gbx_Remisiones.TabStop = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(154, 110)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 2
        Me.btn_Eliminar.Text = "&Eliminar F4"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Image = Global.Modulo_Facturacion.My.Resources.Resources.editcopy
        Me.btn_Agregar.Location = New System.Drawing.Point(8, 110)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.Text = "&Agregar Remisión F3"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 601)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(8, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar F5"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(613, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Lbl_ImporteRem
        '
        Me.Lbl_ImporteRem.AutoSize = True
        Me.Lbl_ImporteRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ImporteRem.Location = New System.Drawing.Point(524, 27)
        Me.Lbl_ImporteRem.Name = "Lbl_ImporteRem"
        Me.Lbl_ImporteRem.Size = New System.Drawing.Size(133, 17)
        Me.Lbl_ImporteRem.TabIndex = 1
        Me.Lbl_ImporteRem.Text = "Importe Remisión"
        '
        'gbx_RemisionesD
        '
        Me.gbx_RemisionesD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_Total)
        Me.gbx_RemisionesD.Controls.Add(Me.Lbl_ImporteRem)
        Me.gbx_RemisionesD.Controls.Add(Me.dgv_Importes)
        Me.gbx_RemisionesD.Location = New System.Drawing.Point(9, 405)
        Me.gbx_RemisionesD.Name = "gbx_RemisionesD"
        Me.gbx_RemisionesD.Size = New System.Drawing.Size(766, 190)
        Me.gbx_RemisionesD.TabIndex = 2
        Me.gbx_RemisionesD.TabStop = False
        '
        'dgv_Importes
        '
        Me.dgv_Importes.AllowUserToResizeRows = False
        Me.dgv_Importes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_Importes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Importes.Location = New System.Drawing.Point(6, 14)
        Me.dgv_Importes.Name = "dgv_Importes"
        Me.dgv_Importes.Size = New System.Drawing.Size(505, 170)
        Me.dgv_Importes.TabIndex = 0
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
        Me.lsv_Remisiones.Row1 = 10
        Me.lsv_Remisiones.Row10 = 10
        Me.lsv_Remisiones.Row2 = 10
        Me.lsv_Remisiones.Row3 = 10
        Me.lsv_Remisiones.Row4 = 10
        Me.lsv_Remisiones.Row5 = 25
        Me.lsv_Remisiones.Row6 = 10
        Me.lsv_Remisiones.Row7 = 10
        Me.lsv_Remisiones.Row8 = 10
        Me.lsv_Remisiones.Row9 = 10
        Me.lsv_Remisiones.Size = New System.Drawing.Size(754, 85)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(120, 83)
        Me.tbx_Descripcion.MaxLength = 5
        Me.tbx_Descripcion.Multiline = True
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.ReadOnly = True
        Me.tbx_Descripcion.Size = New System.Drawing.Size(537, 43)
        Me.tbx_Descripcion.TabIndex = 11
        Me.tbx_Descripcion.TabStop = False
        Me.tbx_Descripcion.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_CantidadKM
        '
        Me.tbx_CantidadKM.Control_Siguiente = Nothing
        Me.tbx_CantidadKM.Filtrado = True
        Me.tbx_CantidadKM.Location = New System.Drawing.Point(663, 176)
        Me.tbx_CantidadKM.MaxLength = 5
        Me.tbx_CantidadKM.Name = "tbx_CantidadKM"
        Me.tbx_CantidadKM.ReadOnly = True
        Me.tbx_CantidadKM.Size = New System.Drawing.Size(49, 20)
        Me.tbx_CantidadKM.TabIndex = 21
        Me.tbx_CantidadKM.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Me.cmb_Cliente
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(119, 10)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(158, 21)
        Me.cmb_Tipo.TabIndex = 1
        Me.cmb_Tipo.ValueMember = "value"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(200, 36)
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Cliente.StoredProcedure = "cat_ClientesCombo_GetAB"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 4
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(120, 37)
        Me.tbx_Cliente.MaxLength = 12
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Cliente.TabIndex = 3
        Me.tbx_Cliente.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Hora
        '
        Me.tbx_Hora.Control_Siguiente = Nothing
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(256, 224)
        Me.tbx_Hora.MaxLength = 5
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Hora.TabIndex = 29
        Me.tbx_Hora.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Ruta
        '
        Me.tbx_Ruta.Control_Siguiente = Me.cmb_Ruta
        Me.tbx_Ruta.Filtrado = True
        Me.tbx_Ruta.Location = New System.Drawing.Point(120, 199)
        Me.tbx_Ruta.MaxLength = 4
        Me.tbx_Ruta.Name = "tbx_Ruta"
        Me.tbx_Ruta.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Ruta.TabIndex = 24
        Me.tbx_Ruta.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Clave = "Clave"
        Me.cmb_Ruta.Control_Siguiente = Me.dtp_Fecha
        Me.cmb_Ruta.DisplayMember = "Descripcion"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.Empresa = False
        Me.cmb_Ruta.Filtro = Me.tbx_Ruta
        Me.cmb_Ruta.FormattingEnabled = True
        Me.cmb_Ruta.Location = New System.Drawing.Point(200, 200)
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Pista = True
        Me.cmb_Ruta.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Ruta.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_Ruta.Sucursal = True
        Me.cmb_Ruta.TabIndex = 25
        Me.cmb_Ruta.Tipo = 0
        Me.cmb_Ruta.ValueMember = "Id_Ruta"
        '
        'tbx_Kilometraje
        '
        Me.tbx_Kilometraje.Control_Siguiente = Nothing
        Me.tbx_Kilometraje.Filtrado = True
        Me.tbx_Kilometraje.Location = New System.Drawing.Point(120, 176)
        Me.tbx_Kilometraje.MaxLength = 4
        Me.tbx_Kilometraje.Name = "tbx_Kilometraje"
        Me.tbx_Kilometraje.ReadOnly = True
        Me.tbx_Kilometraje.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Kilometraje.TabIndex = 19
        Me.tbx_Kilometraje.TabStop = False
        Me.tbx_Kilometraje.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_EnvasesE
        '
        Me.tbx_EnvasesE.Control_Siguiente = Nothing
        Me.tbx_EnvasesE.Filtrado = True
        Me.tbx_EnvasesE.Location = New System.Drawing.Point(120, 153)
        Me.tbx_EnvasesE.MaxLength = 4
        Me.tbx_EnvasesE.Name = "tbx_EnvasesE"
        Me.tbx_EnvasesE.ReadOnly = True
        Me.tbx_EnvasesE.Size = New System.Drawing.Size(74, 20)
        Me.tbx_EnvasesE.TabIndex = 16
        Me.tbx_EnvasesE.TabStop = False
        Me.tbx_EnvasesE.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Cuota
        '
        Me.tbx_Cuota.Control_Siguiente = Nothing
        Me.tbx_Cuota.Filtrado = True
        Me.tbx_Cuota.Location = New System.Drawing.Point(120, 131)
        Me.tbx_Cuota.MaxLength = 4
        Me.tbx_Cuota.Name = "tbx_Cuota"
        Me.tbx_Cuota.ReadOnly = True
        Me.tbx_Cuota.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Cuota.TabIndex = 13
        Me.tbx_Cuota.TabStop = False
        Me.tbx_Cuota.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Precio
        '
        Me.tbx_Precio.Control_Siguiente = Nothing
        Me.tbx_Precio.Filtrado = True
        Me.tbx_Precio.Location = New System.Drawing.Point(120, 60)
        Me.tbx_Precio.MaxLength = 12
        Me.tbx_Precio.Name = "tbx_Precio"
        Me.tbx_Precio.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Precio.TabIndex = 7
        Me.tbx_Precio.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Kilometraje
        '
        Me.cmb_Kilometraje.Clave = "Clave"
        Me.cmb_Kilometraje.Control_Siguiente = Nothing
        Me.cmb_Kilometraje.DisplayMember = "Descripcion"
        Me.cmb_Kilometraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Kilometraje.Empresa = True
        Me.cmb_Kilometraje.Enabled = False
        Me.cmb_Kilometraje.Filtro = Me.tbx_Kilometraje
        Me.cmb_Kilometraje.FormattingEnabled = True
        Me.cmb_Kilometraje.Location = New System.Drawing.Point(200, 176)
        Me.cmb_Kilometraje.Name = "cmb_Kilometraje"
        Me.cmb_Kilometraje.Pista = True
        Me.cmb_Kilometraje.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Kilometraje.StoredProcedure = "Cat_KilometrosEmpresa_Get"
        Me.cmb_Kilometraje.Sucursal = False
        Me.cmb_Kilometraje.TabIndex = 20
        Me.cmb_Kilometraje.Tipo = 0
        Me.cmb_Kilometraje.ValueMember = "Id_KM"
        '
        'cmb_EnvasesE
        '
        Me.cmb_EnvasesE.Clave = "Clave"
        Me.cmb_EnvasesE.Control_Siguiente = Nothing
        Me.cmb_EnvasesE.DisplayMember = "Descripcion"
        Me.cmb_EnvasesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EnvasesE.Empresa = True
        Me.cmb_EnvasesE.Enabled = False
        Me.cmb_EnvasesE.Filtro = Me.tbx_EnvasesE
        Me.cmb_EnvasesE.FormattingEnabled = True
        Me.cmb_EnvasesE.Location = New System.Drawing.Point(200, 153)
        Me.cmb_EnvasesE.Name = "cmb_EnvasesE"
        Me.cmb_EnvasesE.Pista = True
        Me.cmb_EnvasesE.Size = New System.Drawing.Size(457, 21)
        Me.cmb_EnvasesE.StoredProcedure = "Cat_EnvasesEEmpresa_Get"
        Me.cmb_EnvasesE.Sucursal = False
        Me.cmb_EnvasesE.TabIndex = 17
        Me.cmb_EnvasesE.Tipo = 0
        Me.cmb_EnvasesE.ValueMember = "Id_EE"
        '
        'cmb_Precio
        '
        Me.cmb_Precio.Clave = "Clave_Precio"
        Me.cmb_Precio.Control_Siguiente = Nothing
        Me.cmb_Precio.DisplayMember = "Descripcion"
        Me.cmb_Precio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Precio.Empresa = False
        Me.cmb_Precio.Filtro = Me.tbx_Precio
        Me.cmb_Precio.FormattingEnabled = True
        Me.cmb_Precio.Location = New System.Drawing.Point(200, 60)
        Me.cmb_Precio.Name = "cmb_Precio"
        Me.cmb_Precio.Pista = False
        Me.cmb_Precio.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Precio.StoredProcedure = "Cat_PreciosXclienteCombo_Get"
        Me.cmb_Precio.Sucursal = False
        Me.cmb_Precio.TabIndex = 8
        Me.cmb_Precio.Tipo = 0
        Me.cmb_Precio.ValueMember = "Id_Precio"
        '
        'cmb_Cuota
        '
        Me.cmb_Cuota.Clave = "Clave"
        Me.cmb_Cuota.Control_Siguiente = Nothing
        Me.cmb_Cuota.DisplayMember = "Descripcion"
        Me.cmb_Cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cuota.Empresa = False
        Me.cmb_Cuota.Enabled = False
        Me.cmb_Cuota.Filtro = Me.tbx_Cuota
        Me.cmb_Cuota.FormattingEnabled = True
        Me.cmb_Cuota.Location = New System.Drawing.Point(200, 130)
        Me.cmb_Cuota.Name = "cmb_Cuota"
        Me.cmb_Cuota.Pista = False
        Me.cmb_Cuota.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Cuota.StoredProcedure = "Cat_CuotaXclienteCombo_Get"
        Me.cmb_Cuota.Sucursal = False
        Me.cmb_Cuota.TabIndex = 14
        Me.cmb_Cuota.Tipo = 0
        Me.cmb_Cuota.ValueMember = "Id_CR"
        '
        'tbx_Total
        '
        Me.tbx_Total.BackColor = System.Drawing.Color.White
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = False
        Me.tbx_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Total.Location = New System.Drawing.Point(517, 47)
        Me.tbx_Total.MaxLength = 20
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.ReadOnly = True
        Me.tbx_Total.Size = New System.Drawing.Size(155, 26)
        Me.tbx_Total.TabIndex = 2
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Total.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'frm_MovimientosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.gbx_RemisionesD)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Movimientos)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 700)
        Me.Name = "frm_MovimientosAgregar"
        Me.Text = "Capturar Movimientos"
        Me.gbx_Movimientos.ResumeLayout(False)
        Me.gbx_Movimientos.PerformLayout()
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_RemisionesD.ResumeLayout(False)
        Me.gbx_RemisionesD.PerformLayout()
        CType(Me.dgv_Importes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Movimientos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents tbx_Ruta As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Kilometraje As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_EnvasesE As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Cuota As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Precio As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Cliente As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Ruta As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Cliente As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Kilometraje As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_EnvasesE As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Precio As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Cuota As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Kilometraje As System.Windows.Forms.Label
    Friend WithEvents Lbl_EnvasesExceso As System.Windows.Forms.Label
    Friend WithEvents Lbl_CoutaRiesgo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents tbx_Hora As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents gbx_RemisionesD As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Importes As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_ImporteRem As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_Tipo As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents Lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_CantidadKM As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents tbx_Total As Modulo_Facturacion.cp_Textbox
End Class
