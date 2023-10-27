<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteDotaciones
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.rdb_Todo = New System.Windows.Forms.RadioButton
        Me.chk_Grupo = New System.Windows.Forms.CheckBox
        Me.cmb_Grupo = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_GpoFacturacion = New System.Windows.Forms.Label
        Me.rdb_Morralla = New System.Windows.Forms.RadioButton
        Me.rdb_Proceso = New System.Windows.Forms.RadioButton
        Me.cmb_Moneda = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox
        Me.lsv_Dotaciones = New Modulo_Facturacion.cp_Listview
        Me.gbx_Desglose = New System.Windows.Forms.GroupBox
        Me.lsv_Desglose = New Modulo_Facturacion.cp_Listview
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.gbx_Desglose.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(618, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Todo)
        Me.gbx_Filtro.Controls.Add(Me.chk_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_GpoFacturacion)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Morralla)
        Me.gbx_Filtro.Controls.Add(Me.rdb_Proceso)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(767, 152)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(264, 46)
        Me.dtp_Hasta.MinDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 6
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(122, 46)
        Me.dtp_Desde.MinDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 4
        '
        'rdb_Todo
        '
        Me.rdb_Todo.AutoSize = True
        Me.rdb_Todo.Location = New System.Drawing.Point(304, 128)
        Me.rdb_Todo.Name = "rdb_Todo"
        Me.rdb_Todo.Size = New System.Drawing.Size(57, 17)
        Me.rdb_Todo.TabIndex = 14
        Me.rdb_Todo.Text = "Ambos"
        Me.rdb_Todo.UseVisualStyleBackColor = True
        '
        'chk_Grupo
        '
        Me.chk_Grupo.AutoSize = True
        Me.chk_Grupo.Location = New System.Drawing.Point(360, 103)
        Me.chk_Grupo.Name = "chk_Grupo"
        Me.chk_Grupo.Size = New System.Drawing.Size(109, 17)
        Me.chk_Grupo.TabIndex = 11
        Me.chk_Grupo.Text = "Todos los Grupos"
        Me.chk_Grupo.UseVisualStyleBackColor = True
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.Clave = "Status"
        Me.cmb_Grupo.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Grupo.DisplayMember = "Descripcion"
        Me.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupo.Empresa = False
        Me.cmb_Grupo.Filtro = Nothing
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(122, 101)
        Me.cmb_Grupo.MaxDropDownItems = 20
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.Pista = False
        Me.cmb_Grupo.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Grupo.StoredProcedure = "Pro_GruposFactura_Get"
        Me.cmb_Grupo.Sucursal = False
        Me.cmb_Grupo.TabIndex = 10
        Me.cmb_Grupo.Tipo = 0
        Me.cmb_Grupo.ValueMember = "Id_GrupoF"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(471, 115)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 15
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Lbl_GpoFacturacion
        '
        Me.Lbl_GpoFacturacion.AutoSize = True
        Me.Lbl_GpoFacturacion.Location = New System.Drawing.Point(6, 104)
        Me.Lbl_GpoFacturacion.Name = "Lbl_GpoFacturacion"
        Me.Lbl_GpoFacturacion.Size = New System.Drawing.Size(110, 13)
        Me.Lbl_GpoFacturacion.TabIndex = 9
        Me.Lbl_GpoFacturacion.Text = "Grupo de Facturación"
        '
        'rdb_Morralla
        '
        Me.rdb_Morralla.AutoSize = True
        Me.rdb_Morralla.Location = New System.Drawing.Point(211, 128)
        Me.rdb_Morralla.Name = "rdb_Morralla"
        Me.rdb_Morralla.Size = New System.Drawing.Size(62, 17)
        Me.rdb_Morralla.TabIndex = 13
        Me.rdb_Morralla.Text = "Morralla"
        Me.rdb_Morralla.UseVisualStyleBackColor = True
        '
        'rdb_Proceso
        '
        Me.rdb_Proceso.AutoSize = True
        Me.rdb_Proceso.Checked = True
        Me.rdb_Proceso.Location = New System.Drawing.Point(122, 128)
        Me.rdb_Proceso.Name = "rdb_Proceso"
        Me.rdb_Proceso.Size = New System.Drawing.Size(64, 17)
        Me.rdb_Proceso.TabIndex = 12
        Me.rdb_Proceso.TabStop = True
        Me.rdb_Proceso.Text = "Proceso"
        Me.rdb_Proceso.UseVisualStyleBackColor = True
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
        Me.cmb_Moneda.Location = New System.Drawing.Point(122, 74)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 8
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(70, 77)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 7
        Me.lbl_Moneda.Text = "Moneda"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(78, 50)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 3
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(223, 50)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 5
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(43, 22)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.dtp_Desde
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(122, 19)
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
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(9, 160)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(767, 171)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        Me.gbx_Dotaciones.Text = "0 Dotaciones"
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.AllowColumnReorder = True
        Me.lsv_Dotaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 10
        Me.lsv_Dotaciones.Row10 = 8
        Me.lsv_Dotaciones.Row2 = 7
        Me.lsv_Dotaciones.Row3 = 25
        Me.lsv_Dotaciones.Row4 = 10
        Me.lsv_Dotaciones.Row5 = 10
        Me.lsv_Dotaciones.Row6 = 10
        Me.lsv_Dotaciones.Row7 = 8
        Me.lsv_Dotaciones.Row8 = 8
        Me.lsv_Dotaciones.Row9 = 8
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(761, 152)
        Me.lsv_Dotaciones.TabIndex = 0
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'gbx_Desglose
        '
        Me.gbx_Desglose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Desglose.Controls.Add(Me.lsv_Desglose)
        Me.gbx_Desglose.Location = New System.Drawing.Point(9, 334)
        Me.gbx_Desglose.Name = "gbx_Desglose"
        Me.gbx_Desglose.Size = New System.Drawing.Size(767, 169)
        Me.gbx_Desglose.TabIndex = 2
        Me.gbx_Desglose.TabStop = False
        Me.gbx_Desglose.Text = "Desglose"
        '
        'lsv_Desglose
        '
        Me.lsv_Desglose.AllowColumnReorder = True
        Me.lsv_Desglose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Desglose.FullRowSelect = True
        Me.lsv_Desglose.HideSelection = False
        Me.lsv_Desglose.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Desglose.Lvs = ListViewColumnSorter2
        Me.lsv_Desglose.MultiSelect = False
        Me.lsv_Desglose.Name = "lsv_Desglose"
        Me.lsv_Desglose.Row1 = 15
        Me.lsv_Desglose.Row10 = 0
        Me.lsv_Desglose.Row2 = 15
        Me.lsv_Desglose.Row3 = 15
        Me.lsv_Desglose.Row4 = 15
        Me.lsv_Desglose.Row5 = 0
        Me.lsv_Desglose.Row6 = 0
        Me.lsv_Desglose.Row7 = 0
        Me.lsv_Desglose.Row8 = 0
        Me.lsv_Desglose.Row9 = 0
        Me.lsv_Desglose.Size = New System.Drawing.Size(761, 150)
        Me.lsv_Desglose.TabIndex = 0
        Me.lsv_Desglose.UseCompatibleStateImageBehavior = False
        Me.lsv_Desglose.View = System.Windows.Forms.View.Details
        '
        'frm_ReporteDotaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Desglose)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReporteDotaciones"
        Me.Text = "Consulta de Dotaciones"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Desglose.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Desglose As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Dotaciones As Modulo_Facturacion.cp_Listview
    Friend WithEvents lsv_Desglose As Modulo_Facturacion.cp_Listview
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents rdb_Proceso As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Morralla As System.Windows.Forms.RadioButton
    Friend WithEvents chk_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Grupo As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_GpoFacturacion As System.Windows.Forms.Label
    Friend WithEvents rdb_Todo As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
End Class
