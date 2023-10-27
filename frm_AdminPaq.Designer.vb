<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminPaq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminPaq))
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Me.gbx_Datos = New System.Windows.Forms.GroupBox()
        Me.btn_Fiscales = New System.Windows.Forms.Button()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.chk_Cliente = New System.Windows.Forms.CheckBox()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_TotalF = New System.Windows.Forms.Label()
        Me.lbl_TotalS = New System.Windows.Forms.Label()
        Me.lbl_TotalSaldo = New System.Windows.Forms.Label()
        Me.lbl_TotalFacturado = New System.Windows.Forms.Label()
        Me.tbx_Cancelada = New System.Windows.Forms.TextBox()
        Me.lbl_Cancelada = New System.Windows.Forms.Label()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.cmb_Cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Facturas = New System.Windows.Forms.ListView()
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.lsv_Detalle = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.lbl_FechaRespaldo = New System.Windows.Forms.Label()
        Me.lbl_Nota = New System.Windows.Forms.Label()
        Me.btn_Respaldos = New System.Windows.Forms.Button()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.btn_Fiscales)
        Me.gbx_Datos.Controls.Add(Me.chk_Status)
        Me.gbx_Datos.Controls.Add(Me.lbl_Status)
        Me.gbx_Datos.Controls.Add(Me.cmb_Status)
        Me.gbx_Datos.Controls.Add(Me.chk_Cliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Datos.Controls.Add(Me.lbl_Desde)
        Me.gbx_Datos.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Datos.Controls.Add(Me.dtp_Desde)
        Me.gbx_Datos.Controls.Add(Me.lbl_TotalF)
        Me.gbx_Datos.Controls.Add(Me.lbl_TotalS)
        Me.gbx_Datos.Controls.Add(Me.lbl_TotalSaldo)
        Me.gbx_Datos.Controls.Add(Me.lbl_TotalFacturado)
        Me.gbx_Datos.Controls.Add(Me.tbx_Cancelada)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cancelada)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Datos.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Datos.Controls.Add(Me.lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.lsv_Facturas)
        Me.gbx_Datos.Enabled = False
        Me.gbx_Datos.Location = New System.Drawing.Point(12, 48)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(760, 281)
        Me.gbx_Datos.TabIndex = 3
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Facturas"
        '
        'btn_Fiscales
        '
        Me.btn_Fiscales.Enabled = False
        Me.btn_Fiscales.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Fiscales.Location = New System.Drawing.Point(538, 11)
        Me.btn_Fiscales.Name = "btn_Fiscales"
        Me.btn_Fiscales.Size = New System.Drawing.Size(140, 30)
        Me.btn_Fiscales.TabIndex = 19
        Me.btn_Fiscales.Text = "&Ver Datos Fiscales"
        Me.btn_Fiscales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Fiscales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Fiscales.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(232, 78)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 9
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(24, 78)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 7
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(67, 75)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(159, 21)
        Me.cmb_Status.TabIndex = 8
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Enabled = False
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(330, 71)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Cliente
        '
        Me.chk_Cliente.AutoSize = True
        Me.chk_Cliente.Location = New System.Drawing.Point(476, 24)
        Me.chk_Cliente.Name = "chk_Cliente"
        Me.chk_Cliente.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cliente.TabIndex = 2
        Me.chk_Cliente.Text = "Todos"
        Me.chk_Cliente.UseVisualStyleBackColor = True
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(168, 53)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 5
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(23, 53)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 3
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(209, 49)
        Me.dtp_Hasta.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 6
        Me.dtp_Hasta.Value = New Date(2011, 7, 7, 0, 0, 0, 0)
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(67, 49)
        Me.dtp_Desde.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 4
        Me.dtp_Desde.Value = New Date(2011, 7, 7, 0, 0, 0, 0)
        '
        'lbl_TotalF
        '
        Me.lbl_TotalF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_TotalF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalF.Location = New System.Drawing.Point(345, 248)
        Me.lbl_TotalF.Name = "lbl_TotalF"
        Me.lbl_TotalF.Size = New System.Drawing.Size(155, 24)
        Me.lbl_TotalF.TabIndex = 16
        Me.lbl_TotalF.Text = "0.00"
        Me.lbl_TotalF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TotalS
        '
        Me.lbl_TotalS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_TotalS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalS.Location = New System.Drawing.Point(599, 248)
        Me.lbl_TotalS.Name = "lbl_TotalS"
        Me.lbl_TotalS.Size = New System.Drawing.Size(155, 24)
        Me.lbl_TotalS.TabIndex = 18
        Me.lbl_TotalS.Text = "0.00"
        Me.lbl_TotalS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TotalSaldo
        '
        Me.lbl_TotalSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalSaldo.AutoSize = True
        Me.lbl_TotalSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalSaldo.Location = New System.Drawing.Point(517, 256)
        Me.lbl_TotalSaldo.Name = "lbl_TotalSaldo"
        Me.lbl_TotalSaldo.Size = New System.Drawing.Size(76, 13)
        Me.lbl_TotalSaldo.TabIndex = 17
        Me.lbl_TotalSaldo.Text = "Total Saldo:"
        '
        'lbl_TotalFacturado
        '
        Me.lbl_TotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalFacturado.AutoSize = True
        Me.lbl_TotalFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalFacturado.Location = New System.Drawing.Point(238, 256)
        Me.lbl_TotalFacturado.Name = "lbl_TotalFacturado"
        Me.lbl_TotalFacturado.Size = New System.Drawing.Size(101, 13)
        Me.lbl_TotalFacturado.TabIndex = 15
        Me.lbl_TotalFacturado.Text = "Total Facturado:"
        '
        'tbx_Cancelada
        '
        Me.tbx_Cancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Cancelada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Cancelada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Cancelada.Location = New System.Drawing.Point(6, 252)
        Me.tbx_Cancelada.Name = "tbx_Cancelada"
        Me.tbx_Cancelada.Size = New System.Drawing.Size(21, 20)
        Me.tbx_Cancelada.TabIndex = 13
        Me.tbx_Cancelada.TabStop = False
        '
        'lbl_Cancelada
        '
        Me.lbl_Cancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cancelada.AutoSize = True
        Me.lbl_Cancelada.Location = New System.Drawing.Point(30, 255)
        Me.lbl_Cancelada.Name = "lbl_Cancelada"
        Me.lbl_Cancelada.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Cancelada.TabIndex = 14
        Me.lbl_Cancelada.Text = "Cancelada"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(22, 25)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 0
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.DisplayMember = "Nombre"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(67, 22)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Size = New System.Drawing.Size(403, 21)
        Me.cmb_Cliente.TabIndex = 1
        Me.cmb_Cliente.ValueMember = "Id"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(614, 87)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 17)
        Me.lbl_Registros.TabIndex = 11
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Facturas
        '
        Me.lsv_Facturas.AllowColumnReorder = True
        Me.lsv_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Facturas.FullRowSelect = True
        Me.lsv_Facturas.HideSelection = False
        Me.lsv_Facturas.Location = New System.Drawing.Point(6, 107)
        Me.lsv_Facturas.MultiSelect = False
        Me.lsv_Facturas.Name = "lsv_Facturas"
        Me.lsv_Facturas.Size = New System.Drawing.Size(748, 132)
        Me.lsv_Facturas.TabIndex = 12
        Me.lsv_Facturas.UseCompatibleStateImageBehavior = False
        Me.lsv_Facturas.View = System.Windows.Forms.View.Details
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Detalle.Enabled = False
        Me.gbx_Detalle.Location = New System.Drawing.Point(12, 335)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(760, 158)
        Me.gbx_Detalle.TabIndex = 4
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle"
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.AllowColumnReorder = True
        Me.lsv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter1
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 15
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 15
        Me.lsv_Detalle.Row3 = 15
        Me.lsv_Detalle.Row4 = 15
        Me.lsv_Detalle.Row5 = 15
        Me.lsv_Detalle.Row6 = 15
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(754, 139)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(760, 50)
        Me.gbx_Botones.TabIndex = 5
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(614, 14)
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
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'lbl_FechaRespaldo
        '
        Me.lbl_FechaRespaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaRespaldo.Location = New System.Drawing.Point(185, 11)
        Me.lbl_FechaRespaldo.Name = "lbl_FechaRespaldo"
        Me.lbl_FechaRespaldo.Size = New System.Drawing.Size(437, 24)
        Me.lbl_FechaRespaldo.TabIndex = 1
        Me.lbl_FechaRespaldo.Text = "Último Respaldo: No Definido"
        Me.lbl_FechaRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Nota
        '
        Me.lbl_Nota.AutoSize = True
        Me.lbl_Nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Nota.Location = New System.Drawing.Point(186, 36)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Nota.TabIndex = 2
        Me.lbl_Nota.Text = "Nota"
        Me.lbl_Nota.Visible = False
        '
        'btn_Respaldos
        '
        Me.btn_Respaldos.Image = Global.Modulo_Facturacion.My.Resources.Resources.agt_reload
        Me.btn_Respaldos.Location = New System.Drawing.Point(20, 8)
        Me.btn_Respaldos.Name = "btn_Respaldos"
        Me.btn_Respaldos.Size = New System.Drawing.Size(160, 35)
        Me.btn_Respaldos.TabIndex = 0
        Me.btn_Respaldos.Text = "Actualizar Respaldos"
        Me.btn_Respaldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Respaldos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Respaldos.UseVisualStyleBackColor = True
        '
        'frm_AdminPaq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbl_Nota)
        Me.Controls.Add(Me.lbl_FechaRespaldo)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.btn_Respaldos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AdminPaq"
        Me.Text = "Consulta de Documentos de Adminpaq"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Facturas As System.Windows.Forms.ListView
    Friend WithEvents lsv_Detalle As Modulo_Facturacion.cp_Listview
    Friend WithEvents btn_Respaldos As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Cancelada As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cancelada As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalS As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalSaldo As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalFacturado As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalF As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaRespaldo As System.Windows.Forms.Label
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_Cliente As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents btn_Fiscales As System.Windows.Forms.Button

End Class
