<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecalcularTraslado
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
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RecalcularTraslado))
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.gbx_Ingresos = New System.Windows.Forms.GroupBox
        Me.Lbl_RegistrosP = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_TipoMov = New System.Windows.Forms.CheckBox
        Me.lbl_TipoMov = New System.Windows.Forms.Label
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recalcular = New System.Windows.Forms.Button
        Me.gbx_RemisionesD = New System.Windows.Forms.GroupBox
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.prg_Barra = New System.Windows.Forms.ProgressBar
        Me.lsv_RemisionesD = New Modulo_Facturacion.cp_Listview
        Me.lsv_Remisiones = New Modulo_Facturacion.cp_Listview
        Me.cmb_TipoMov = New Modulo_Facturacion.cp_cmb_Manual
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual
        Me.cmb_Clientes = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.txt_Clave = New Modulo_Facturacion.cp_Textbox
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview
        Me.gbx_Ingresos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_RemisionesD.SuspendLayout()
        Me.gbx_Remisiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Ingresos
        '
        Me.gbx_Ingresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Ingresos.Controls.Add(Me.Lbl_RegistrosP)
        Me.gbx_Ingresos.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Ingresos.Controls.Add(Me.dtp_Desde)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.chk_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_TipoMov)
        Me.gbx_Ingresos.Controls.Add(Me.txt_Clave)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Ingresos.Controls.Add(Me.cmb_Status)
        Me.gbx_Ingresos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Ingresos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Ingresos.Controls.Add(Me.chk_Status)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Status)
        Me.gbx_Ingresos.Controls.Add(Me.Lbl_Cliente)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Desde)
        Me.gbx_Ingresos.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Ingresos.Location = New System.Drawing.Point(10, 6)
        Me.gbx_Ingresos.Name = "gbx_Ingresos"
        Me.gbx_Ingresos.Size = New System.Drawing.Size(774, 286)
        Me.gbx_Ingresos.TabIndex = 0
        Me.gbx_Ingresos.TabStop = False
        '
        'Lbl_RegistrosP
        '
        Me.Lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosP.Location = New System.Drawing.Point(600, 144)
        Me.Lbl_RegistrosP.Name = "Lbl_RegistrosP"
        Me.Lbl_RegistrosP.Size = New System.Drawing.Size(168, 18)
        Me.Lbl_RegistrosP.TabIndex = 17
        Me.Lbl_RegistrosP.Text = "Registros: 0"
        Me.Lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(244, 17)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(102, 17)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(102, 123)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 15
        Me.btn_Mostrar.Text = "Consultar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
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
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(62, 101)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 12
        Me.Lbl_Cliente.Text = "Cliente"
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
        Me.lbl_Hasta.Location = New System.Drawing.Point(203, 23)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Recalcular)
        Me.gbx_Botones.Location = New System.Drawing.Point(10, 515)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(774, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Recalcular
        '
        Me.btn_Recalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recalcular.Enabled = False
        Me.btn_Recalcular.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Recalcular.Location = New System.Drawing.Point(6, 12)
        Me.btn_Recalcular.Name = "btn_Recalcular"
        Me.btn_Recalcular.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recalcular.TabIndex = 0
        Me.btn_Recalcular.Text = "&Recalcular"
        Me.btn_Recalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recalcular.UseVisualStyleBackColor = True
        '
        'gbx_RemisionesD
        '
        Me.gbx_RemisionesD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesD.Controls.Add(Me.lsv_RemisionesD)
        Me.gbx_RemisionesD.Location = New System.Drawing.Point(403, 295)
        Me.gbx_RemisionesD.Name = "gbx_RemisionesD"
        Me.gbx_RemisionesD.Size = New System.Drawing.Size(381, 196)
        Me.gbx_RemisionesD.TabIndex = 2
        Me.gbx_RemisionesD.TabStop = False
        Me.gbx_RemisionesD.Text = "Importes por Remisión"
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(10, 295)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(387, 196)
        Me.gbx_Remisiones.TabIndex = 1
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Text = "Remisiones por Traslado"
        '
        'prg_Barra
        '
        Me.prg_Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prg_Barra.Location = New System.Drawing.Point(10, 496)
        Me.prg_Barra.Name = "prg_Barra"
        Me.prg_Barra.Size = New System.Drawing.Size(773, 20)
        Me.prg_Barra.TabIndex = 4
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
        Me.lsv_RemisionesD.Size = New System.Drawing.Size(369, 171)
        Me.lsv_RemisionesD.TabIndex = 0
        Me.lsv_RemisionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_RemisionesD.View = System.Windows.Forms.View.Details
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
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter3
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
        Me.lsv_Remisiones.Size = New System.Drawing.Size(375, 171)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'cmb_TipoMov
        '
        Me.cmb_TipoMov.Control_Siguiente = Me.cmb_Status
        Me.cmb_TipoMov.DisplayMember = "display"
        Me.cmb_TipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoMov.FormattingEnabled = True
        Me.cmb_TipoMov.Location = New System.Drawing.Point(103, 43)
        Me.cmb_TipoMov.Name = "cmb_TipoMov"
        Me.cmb_TipoMov.Size = New System.Drawing.Size(223, 21)
        Me.cmb_TipoMov.TabIndex = 5
        Me.cmb_TipoMov.ValueMember = "value"
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
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.txt_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(200, 97)
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = True
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 14
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'txt_Clave
        '
        Me.txt_Clave.Control_Siguiente = Me.cmb_Clientes
        Me.txt_Clave.Filtrado = True
        Me.txt_Clave.Location = New System.Drawing.Point(102, 97)
        Me.txt_Clave.MaxLength = 12
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(92, 20)
        Me.txt_Clave.TabIndex = 13
        Me.txt_Clave.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 165)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 10
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 15
        Me.lsv_Datos.Row4 = 15
        Me.lsv_Datos.Row5 = 10
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(762, 115)
        Me.lsv_Datos.TabIndex = 16
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'frm_RecalcularTraslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.prg_Barra)
        Me.Controls.Add(Me.gbx_RemisionesD)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Ingresos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_RecalcularTraslado"
        Me.Text = "RecalcularTraslado"
        Me.gbx_Ingresos.ResumeLayout(False)
        Me.gbx_Ingresos.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_RemisionesD.ResumeLayout(False)
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Ingresos As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipoMov As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents chk_TipoMov As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_TipoMov As System.Windows.Forms.Label
    Friend WithEvents txt_Clave As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Clientes As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recalcular As System.Windows.Forms.Button
    Friend WithEvents gbx_RemisionesD As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_RemisionesD As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Facturacion.cp_Listview
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_RegistrosP As System.Windows.Forms.Label
    Friend WithEvents prg_Barra As System.Windows.Forms.ProgressBar
End Class
