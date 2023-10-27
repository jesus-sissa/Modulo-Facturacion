<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipodeCambio
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
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.Tab_TipoCambio = New System.Windows.Forms.TabControl
        Me.tbp_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.cmb_Monedas = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.lsv_TipodeCambio = New Modulo_Facturacion.cp_Listview
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.tbp_Modificar = New System.Windows.Forms.TabPage
        Me.tbx_TipoCambioAntes = New System.Windows.Forms.TextBox
        Me.tbx_Fecha = New System.Windows.Forms.TextBox
        Me.tbx_Moneda = New System.Windows.Forms.TextBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbx_TipoCambioNuevo = New Modulo_Facturacion.cp_Textbox
        Me.Tab_TipoCambio.SuspendLayout()
        Me.tbp_Listado.SuspendLayout()
        Me.tbp_Modificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_TipoCambio
        '
        Me.Tab_TipoCambio.Controls.Add(Me.tbp_Listado)
        Me.Tab_TipoCambio.Controls.Add(Me.tbp_Modificar)
        Me.Tab_TipoCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_TipoCambio.Location = New System.Drawing.Point(0, 0)
        Me.Tab_TipoCambio.Name = "Tab_TipoCambio"
        Me.Tab_TipoCambio.SelectedIndex = 0
        Me.Tab_TipoCambio.Size = New System.Drawing.Size(515, 518)
        Me.Tab_TipoCambio.TabIndex = 0
        '
        'tbp_Listado
        '
        Me.tbp_Listado.Controls.Add(Me.Lbl_Registros)
        Me.tbp_Listado.Controls.Add(Me.dtp_Hasta)
        Me.tbp_Listado.Controls.Add(Me.dtp_Desde)
        Me.tbp_Listado.Controls.Add(Me.cmb_Monedas)
        Me.tbp_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tbp_Listado.Controls.Add(Me.btn_Modificar)
        Me.tbp_Listado.Controls.Add(Me.lsv_TipodeCambio)
        Me.tbp_Listado.Controls.Add(Me.chk_Todos)
        Me.tbp_Listado.Controls.Add(Me.Label1)
        Me.tbp_Listado.Controls.Add(Me.btn_Mostrar)
        Me.tbp_Listado.Controls.Add(Me.lbl_Desde)
        Me.tbp_Listado.Controls.Add(Me.lbl_Hasta)
        Me.tbp_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Listado.Name = "tbp_Listado"
        Me.tbp_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Listado.Size = New System.Drawing.Size(507, 492)
        Me.tbp_Listado.TabIndex = 0
        Me.tbp_Listado.Text = "Listado"
        Me.tbp_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(354, 63)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(145, 18)
        Me.Lbl_Registros.TabIndex = 11
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(197, 10)
        Me.dtp_Hasta.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Hasta.TabIndex = 4
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(62, 10)
        Me.dtp_Desde.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Desde.TabIndex = 2
        '
        'cmb_Monedas
        '
        Me.cmb_Monedas.Clave = Nothing
        Me.cmb_Monedas.Control_Siguiente = Nothing
        Me.cmb_Monedas.DisplayMember = "Nombre"
        Me.cmb_Monedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Monedas.Empresa = False
        Me.cmb_Monedas.Filtro = Nothing
        Me.cmb_Monedas.FormattingEnabled = True
        Me.cmb_Monedas.Location = New System.Drawing.Point(62, 36)
        Me.cmb_Monedas.Name = "cmb_Monedas"
        Me.cmb_Monedas.Pista = False
        Me.cmb_Monedas.Size = New System.Drawing.Size(223, 21)
        Me.cmb_Monedas.StoredProcedure = "Cat_Monedas_ComboGet"
        Me.cmb_Monedas.Sucursal = False
        Me.cmb_Monedas.TabIndex = 6
        Me.cmb_Monedas.Tipo = 0
        Me.cmb_Monedas.ValueMember = "Id_Moneda"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(369, 459)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(6, 459)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Modificar.TabIndex = 10
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lsv_TipodeCambio
        '
        Me.lsv_TipodeCambio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TipodeCambio.FullRowSelect = True
        Me.lsv_TipodeCambio.HideSelection = False
        Me.lsv_TipodeCambio.Location = New System.Drawing.Point(6, 84)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_TipodeCambio.Lvs = ListViewColumnSorter3
        Me.lsv_TipodeCambio.MultiSelect = False
        Me.lsv_TipodeCambio.Name = "lsv_TipodeCambio"
        Me.lsv_TipodeCambio.Row1 = 30
        Me.lsv_TipodeCambio.Row10 = 0
        Me.lsv_TipodeCambio.Row2 = 25
        Me.lsv_TipodeCambio.Row3 = 20
        Me.lsv_TipodeCambio.Row4 = 20
        Me.lsv_TipodeCambio.Row5 = 0
        Me.lsv_TipodeCambio.Row6 = 0
        Me.lsv_TipodeCambio.Row7 = 0
        Me.lsv_TipodeCambio.Row8 = 0
        Me.lsv_TipodeCambio.Row9 = 0
        Me.lsv_TipodeCambio.Size = New System.Drawing.Size(493, 369)
        Me.lsv_TipodeCambio.TabIndex = 9
        Me.lsv_TipodeCambio.UseCompatibleStateImageBehavior = False
        Me.lsv_TipodeCambio.View = System.Windows.Forms.View.Details
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(297, 42)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 7
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Moneda"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(359, 30)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 8
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(18, 20)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 1
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(156, 17)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 3
        Me.lbl_Hasta.Text = "Hasta"
        '
        'tbp_Modificar
        '
        Me.tbp_Modificar.Controls.Add(Me.tbx_TipoCambioAntes)
        Me.tbp_Modificar.Controls.Add(Me.tbx_Fecha)
        Me.tbp_Modificar.Controls.Add(Me.tbx_Moneda)
        Me.tbp_Modificar.Controls.Add(Me.btn_Cancelar)
        Me.tbp_Modificar.Controls.Add(Me.btn_Guardar)
        Me.tbp_Modificar.Controls.Add(Me.Label5)
        Me.tbp_Modificar.Controls.Add(Me.Label4)
        Me.tbp_Modificar.Controls.Add(Me.Label3)
        Me.tbp_Modificar.Controls.Add(Me.Label2)
        Me.tbp_Modificar.Controls.Add(Me.tbx_TipoCambioNuevo)
        Me.tbp_Modificar.Location = New System.Drawing.Point(4, 22)
        Me.tbp_Modificar.Name = "tbp_Modificar"
        Me.tbp_Modificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_Modificar.Size = New System.Drawing.Size(507, 492)
        Me.tbp_Modificar.TabIndex = 1
        Me.tbp_Modificar.Text = "Modificar"
        Me.tbp_Modificar.UseVisualStyleBackColor = True
        '
        'tbx_TipoCambioAntes
        '
        Me.tbx_TipoCambioAntes.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_TipoCambioAntes.Location = New System.Drawing.Point(142, 79)
        Me.tbx_TipoCambioAntes.Name = "tbx_TipoCambioAntes"
        Me.tbx_TipoCambioAntes.ReadOnly = True
        Me.tbx_TipoCambioAntes.Size = New System.Drawing.Size(86, 20)
        Me.tbx_TipoCambioAntes.TabIndex = 19
        '
        'tbx_Fecha
        '
        Me.tbx_Fecha.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Fecha.Location = New System.Drawing.Point(142, 53)
        Me.tbx_Fecha.Name = "tbx_Fecha"
        Me.tbx_Fecha.ReadOnly = True
        Me.tbx_Fecha.Size = New System.Drawing.Size(139, 20)
        Me.tbx_Fecha.TabIndex = 18
        '
        'tbx_Moneda
        '
        Me.tbx_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Moneda.Location = New System.Drawing.Point(142, 27)
        Me.tbx_Moneda.Name = "tbx_Moneda"
        Me.tbx_Moneda.ReadOnly = True
        Me.tbx_Moneda.Size = New System.Drawing.Size(139, 20)
        Me.tbx_Moneda.TabIndex = 17
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(289, 154)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Cancelar.TabIndex = 16
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(142, 154)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Guardar.TabIndex = 15
        Me.btn_Guardar.Text = "&Modificar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de Cambio Nuevo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Cambio Anterior"
        '
        'tbx_TipoCambioNuevo
        '
        Me.tbx_TipoCambioNuevo.Control_Siguiente = Nothing
        Me.tbx_TipoCambioNuevo.Filtrado = True
        Me.tbx_TipoCambioNuevo.Location = New System.Drawing.Point(142, 108)
        Me.tbx_TipoCambioNuevo.MaxLength = 6
        Me.tbx_TipoCambioNuevo.Name = "tbx_TipoCambioNuevo"
        Me.tbx_TipoCambioNuevo.Size = New System.Drawing.Size(86, 20)
        Me.tbx_TipoCambioNuevo.TabIndex = 4
        Me.tbx_TipoCambioNuevo.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'frm_TipodeCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 518)
        Me.Controls.Add(Me.Tab_TipoCambio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TipodeCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Cambio"
        Me.Tab_TipoCambio.ResumeLayout(False)
        Me.tbp_Listado.ResumeLayout(False)
        Me.tbp_Listado.PerformLayout()
        Me.tbp_Modificar.ResumeLayout(False)
        Me.tbp_Modificar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_TipoCambio As System.Windows.Forms.TabControl
    Friend WithEvents tbp_Listado As System.Windows.Forms.TabPage
    Friend WithEvents tbp_Modificar As System.Windows.Forms.TabPage
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents lsv_TipodeCambio As Modulo_Facturacion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_TipoCambioNuevo As Modulo_Facturacion.cp_Textbox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_Monedas As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_Moneda As System.Windows.Forms.TextBox
    Friend WithEvents tbx_TipoCambioAntes As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
