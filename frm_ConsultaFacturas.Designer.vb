<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ConsultaFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaFacturas))
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.txt_codidocliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_ICCP = New System.Windows.Forms.RadioButton()
        Me.rdb_ambos = New System.Windows.Forms.RadioButton()
        Me.rdb_TCCP = New System.Windows.Forms.RadioButton()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.rdb_FechaFacturacion = New System.Windows.Forms.RadioButton()
        Me.Lbl_RegistrosR = New System.Windows.Forms.Label()
        Me.rdb_FechaServicio = New System.Windows.Forms.RadioButton()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Dgb_Facturas = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbx_Filtro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.Dgb_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Controls.Add(Me.txt_codidocliente)
        Me.gbx_Filtro.Controls.Add(Me.GroupBox1)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.rdb_FechaFacturacion)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_RegistrosR)
        Me.gbx_Filtro.Controls.Add(Me.rdb_FechaServicio)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Filtro.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(949, 138)
        Me.gbx_Filtro.TabIndex = 1
        Me.gbx_Filtro.TabStop = False
        '
        'txt_codidocliente
        '
        Me.txt_codidocliente.Location = New System.Drawing.Point(70, 83)
        Me.txt_codidocliente.Name = "txt_codidocliente"
        Me.txt_codidocliente.Size = New System.Drawing.Size(147, 20)
        Me.txt_codidocliente.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_ICCP)
        Me.GroupBox1.Controls.Add(Me.rdb_ambos)
        Me.GroupBox1.Controls.Add(Me.rdb_TCCP)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 47)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Factura"
        '
        'rdb_ICCP
        '
        Me.rdb_ICCP.AutoSize = True
        Me.rdb_ICCP.Location = New System.Drawing.Point(18, 19)
        Me.rdb_ICCP.Name = "rdb_ICCP"
        Me.rdb_ICCP.Size = New System.Drawing.Size(49, 17)
        Me.rdb_ICCP.TabIndex = 15
        Me.rdb_ICCP.TabStop = True
        Me.rdb_ICCP.Text = "ICCP"
        Me.rdb_ICCP.UseVisualStyleBackColor = True
        '
        'rdb_ambos
        '
        Me.rdb_ambos.AutoSize = True
        Me.rdb_ambos.Location = New System.Drawing.Point(154, 19)
        Me.rdb_ambos.Name = "rdb_ambos"
        Me.rdb_ambos.Size = New System.Drawing.Size(57, 17)
        Me.rdb_ambos.TabIndex = 17
        Me.rdb_ambos.TabStop = True
        Me.rdb_ambos.Text = "Ambos"
        Me.rdb_ambos.UseVisualStyleBackColor = True
        '
        'rdb_TCCP
        '
        Me.rdb_TCCP.AutoSize = True
        Me.rdb_TCCP.Location = New System.Drawing.Point(85, 19)
        Me.rdb_TCCP.Name = "rdb_TCCP"
        Me.rdb_TCCP.Size = New System.Drawing.Size(53, 17)
        Me.rdb_TCCP.TabIndex = 16
        Me.rdb_TCCP.TabStop = True
        Me.rdb_TCCP.Text = "TCCP"
        Me.rdb_TCCP.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(242, 77)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 8
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'rdb_FechaFacturacion
        '
        Me.rdb_FechaFacturacion.AutoSize = True
        Me.rdb_FechaFacturacion.Location = New System.Drawing.Point(268, 38)
        Me.rdb_FechaFacturacion.Name = "rdb_FechaFacturacion"
        Me.rdb_FechaFacturacion.Size = New System.Drawing.Size(114, 17)
        Me.rdb_FechaFacturacion.TabIndex = 9
        Me.rdb_FechaFacturacion.TabStop = True
        Me.rdb_FechaFacturacion.Text = "Fecha Facturacion"
        Me.rdb_FechaFacturacion.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosR
        '
        Me.Lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosR.Location = New System.Drawing.Point(792, 103)
        Me.Lbl_RegistrosR.Name = "Lbl_RegistrosR"
        Me.Lbl_RegistrosR.Size = New System.Drawing.Size(137, 23)
        Me.Lbl_RegistrosR.TabIndex = 14
        Me.Lbl_RegistrosR.Text = "Registros: 0"
        Me.Lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb_FechaServicio
        '
        Me.rdb_FechaServicio.AutoSize = True
        Me.rdb_FechaServicio.Location = New System.Drawing.Point(400, 38)
        Me.rdb_FechaServicio.Name = "rdb_FechaServicio"
        Me.rdb_FechaServicio.Size = New System.Drawing.Size(96, 17)
        Me.rdb_FechaServicio.TabIndex = 10
        Me.rdb_FechaServicio.TabStop = True
        Me.rdb_FechaServicio.Text = "Fecha Servicio"
        Me.rdb_FechaServicio.UseVisualStyleBackColor = True
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(678, 42)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 6
        Me.lbl_Hasta.Text = "Hasta"
        Me.lbl_Hasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(16, 86)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 11
        Me.lbl_Cliente.Text = "Cliente"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(719, 38)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Hasta.TabIndex = 7
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(519, 42)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 4
        Me.lbl_Desde.Text = "Desde"
        Me.lbl_Desde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(563, 38)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Desde.TabIndex = 5
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(12, 542)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 3
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(797, 542)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Dgb_Facturas)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 138)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(949, 446)
        Me.panel1.TabIndex = 6
        '
        'Dgb_Facturas
        '
        Me.Dgb_Facturas.BackgroundColor = System.Drawing.Color.White
        Me.Dgb_Facturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.Dgb_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgb_Facturas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Dgb_Facturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgb_Facturas.Location = New System.Drawing.Point(0, 0)
        Me.Dgb_Facturas.Name = "Dgb_Facturas"
        Me.Dgb_Facturas.RowHeadersWidth = 40
        Me.Dgb_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgb_Facturas.Size = New System.Drawing.Size(949, 446)
        Me.Dgb_Facturas.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 26)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar "
        '
        'frm_ConsultaFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 584)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_Exportar)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Name = "frm_ConsultaFacturas"
        Me.Text = "Consulta de Facturas"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        CType(Me.Dgb_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_Filtro As GroupBox
    Friend WithEvents btn_Mostrar As Button
    Friend WithEvents lbl_Hasta As Label
    Friend WithEvents dtp_Hasta As DateTimePicker
    Friend WithEvents lbl_Desde As Label
    Friend WithEvents dtp_Desde As DateTimePicker
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents rdb_FechaServicio As RadioButton
    Friend WithEvents rdb_FechaFacturacion As RadioButton
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents Lbl_RegistrosR As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdb_ICCP As RadioButton
    Friend WithEvents rdb_ambos As RadioButton
    Friend WithEvents rdb_TCCP As RadioButton
    Friend WithEvents txt_codidocliente As TextBox
    Private WithEvents panel1 As Panel
    Private WithEvents Dgb_Facturas As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
End Class
