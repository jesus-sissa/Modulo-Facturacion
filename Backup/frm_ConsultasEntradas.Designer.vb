<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaEntradas
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
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Btn_Consulta = New System.Windows.Forms.Button
        Me.Ckb_Cliente = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.Tbx_Clv_Cliente = New Modulo_Facturacion.cp_Textbox
        Me.Cmb_Cliente = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.Btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Procesos = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosP = New System.Windows.Forms.Label
        Me.Lsv_Procesos = New Modulo_Facturacion.cp_Listview
        Me.TabPage = New System.Windows.Forms.TabControl
        Me.Rutas = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosR = New System.Windows.Forms.Label
        Me.Lsv_Rutas = New Modulo_Facturacion.cp_Listview
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.Procesos.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.Rutas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.Btn_Consulta)
        Me.Gbx_Filtro.Controls.Add(Me.Ckb_Cliente)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_hasta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.Tbx_Clv_Cliente)
        Me.Gbx_Filtro.Controls.Add(Me.Cmb_Cliente)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(5, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(774, 79)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(66, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow
        Me.Btn_Consulta.Location = New System.Drawing.Point(593, 39)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Consulta.TabIndex = 8
        Me.Btn_Consulta.Text = "C&onsultar"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'Ckb_Cliente
        '
        Me.Ckb_Cliente.AutoSize = True
        Me.Ckb_Cliente.Location = New System.Drawing.Point(531, 47)
        Me.Ckb_Cliente.Name = "Ckb_Cliente"
        Me.Ckb_Cliente.Size = New System.Drawing.Size(56, 17)
        Me.Ckb_Cliente.TabIndex = 7
        Me.Ckb_Cliente.Text = "Todos"
        Me.Ckb_Cliente.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(208, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(167, 23)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 2
        Me.lbl_hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(22, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'Tbx_Clv_Cliente
        '
        Me.Tbx_Clv_Cliente.Control_Siguiente = Me.Cmb_Cliente
        Me.Tbx_Clv_Cliente.Filtrado = True
        Me.Tbx_Clv_Cliente.Location = New System.Drawing.Point(66, 45)
        Me.Tbx_Clv_Cliente.MaxLength = 4
        Me.Tbx_Clv_Cliente.Name = "Tbx_Clv_Cliente"
        Me.Tbx_Clv_Cliente.Size = New System.Drawing.Size(50, 20)
        Me.Tbx_Clv_Cliente.TabIndex = 5
        Me.Tbx_Clv_Cliente.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Cmb_Cliente
        '
        Me.Cmb_Cliente.Clave = "Clave_Cliente"
        Me.Cmb_Cliente.Control_Siguiente = Nothing
        Me.Cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.Cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Cliente.Empresa = False
        Me.Cmb_Cliente.Filtro = Me.Tbx_Clv_Cliente
        Me.Cmb_Cliente.FormattingEnabled = True
        Me.Cmb_Cliente.Location = New System.Drawing.Point(122, 45)
        Me.Cmb_Cliente.Name = "Cmb_Cliente"
        Me.Cmb_Cliente.Pista = False
        Me.Cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_Cliente.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.Cmb_Cliente.Sucursal = True
        Me.Cmb_Cliente.TabIndex = 6
        Me.Cmb_Cliente.Tipo = 0
        Me.Cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(21, 48)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Exportar.Enabled = False
        Me.Btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.Btn_Exportar.Location = New System.Drawing.Point(7, 12)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Exportar.TabIndex = 0
        Me.Btn_Exportar.Text = "&Exportar"
        Me.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.Btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 505)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(774, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'Procesos
        '
        Me.Procesos.Controls.Add(Me.Lbl_RegistrosP)
        Me.Procesos.Controls.Add(Me.Lsv_Procesos)
        Me.Procesos.Location = New System.Drawing.Point(4, 22)
        Me.Procesos.Name = "Procesos"
        Me.Procesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Procesos.Size = New System.Drawing.Size(766, 392)
        Me.Procesos.TabIndex = 0
        Me.Procesos.Text = "Proceso"
        Me.Procesos.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosP
        '
        Me.Lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosP.Location = New System.Drawing.Point(615, 3)
        Me.Lbl_RegistrosP.Name = "Lbl_RegistrosP"
        Me.Lbl_RegistrosP.Size = New System.Drawing.Size(145, 23)
        Me.Lbl_RegistrosP.TabIndex = 4
        Me.Lbl_RegistrosP.Text = "Registros: 0"
        Me.Lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Procesos
        '
        Me.Lsv_Procesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Procesos.FullRowSelect = True
        Me.Lsv_Procesos.HideSelection = False
        Me.Lsv_Procesos.Location = New System.Drawing.Point(3, 29)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Procesos.Lvs = ListViewColumnSorter1
        Me.Lsv_Procesos.MultiSelect = False
        Me.Lsv_Procesos.Name = "Lsv_Procesos"
        Me.Lsv_Procesos.Row1 = 9
        Me.Lsv_Procesos.Row10 = 10
        Me.Lsv_Procesos.Row2 = 11
        Me.Lsv_Procesos.Row3 = 11
        Me.Lsv_Procesos.Row4 = 30
        Me.Lsv_Procesos.Row5 = 10
        Me.Lsv_Procesos.Row6 = 30
        Me.Lsv_Procesos.Row7 = 10
        Me.Lsv_Procesos.Row8 = 10
        Me.Lsv_Procesos.Row9 = 10
        Me.Lsv_Procesos.Size = New System.Drawing.Size(760, 357)
        Me.Lsv_Procesos.TabIndex = 0
        Me.Lsv_Procesos.TabStop = False
        Me.Lsv_Procesos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Procesos.View = System.Windows.Forms.View.Details
        '
        'TabPage
        '
        Me.TabPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPage.Controls.Add(Me.Rutas)
        Me.TabPage.Controls.Add(Me.Procesos)
        Me.TabPage.Location = New System.Drawing.Point(5, 87)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(774, 418)
        Me.TabPage.TabIndex = 1
        '
        'Rutas
        '
        Me.Rutas.Controls.Add(Me.Lbl_RegistrosR)
        Me.Rutas.Controls.Add(Me.Lsv_Rutas)
        Me.Rutas.Location = New System.Drawing.Point(4, 22)
        Me.Rutas.Name = "Rutas"
        Me.Rutas.Size = New System.Drawing.Size(766, 392)
        Me.Rutas.TabIndex = 4
        Me.Rutas.Text = "Rutas"
        Me.Rutas.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosR
        '
        Me.Lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosR.Location = New System.Drawing.Point(623, 3)
        Me.Lbl_RegistrosR.Name = "Lbl_RegistrosR"
        Me.Lbl_RegistrosR.Size = New System.Drawing.Size(137, 23)
        Me.Lbl_RegistrosR.TabIndex = 0
        Me.Lbl_RegistrosR.Text = "Registros: 0"
        Me.Lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Rutas
        '
        Me.Lsv_Rutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Rutas.FullRowSelect = True
        Me.Lsv_Rutas.HideSelection = False
        Me.Lsv_Rutas.Location = New System.Drawing.Point(3, 29)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Rutas.Lvs = ListViewColumnSorter2
        Me.Lsv_Rutas.MultiSelect = False
        Me.Lsv_Rutas.Name = "Lsv_Rutas"
        Me.Lsv_Rutas.Row1 = 10
        Me.Lsv_Rutas.Row10 = 10
        Me.Lsv_Rutas.Row2 = 11
        Me.Lsv_Rutas.Row3 = 11
        Me.Lsv_Rutas.Row4 = 10
        Me.Lsv_Rutas.Row5 = 30
        Me.Lsv_Rutas.Row6 = 11
        Me.Lsv_Rutas.Row7 = 30
        Me.Lsv_Rutas.Row8 = 10
        Me.Lsv_Rutas.Row9 = 10
        Me.Lsv_Rutas.Size = New System.Drawing.Size(760, 360)
        Me.Lsv_Rutas.TabIndex = 1
        Me.Lsv_Rutas.TabStop = False
        Me.Lsv_Rutas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Rutas.View = System.Windows.Forms.View.Details
        '
        'frm_ConsultaEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabPage)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaEntradas"
        Me.Text = "Reporte de Entradas a Boveda"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.Procesos.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.Rutas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_Clv_Cliente As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Cmb_Cliente As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents Ckb_Cliente As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents Btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Procesos As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Procesos As Modulo_Facturacion.cp_Listview
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents Rutas As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Rutas As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosP As System.Windows.Forms.Label
End Class
