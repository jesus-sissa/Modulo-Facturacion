<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pernoctas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pernoctas))
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lsv_Pernoctas = New Modulo_Facturacion.cp_Listview
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_CS = New System.Windows.Forms.Label
        Me.gbx_Valores = New System.Windows.Forms.GroupBox
        Me.tbx_Cliente = New Modulo_Facturacion.cp_Textbox
        Me.lbl_ObservacionesValida = New System.Windows.Forms.Label
        Me.tbx_ObservacionesValida = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Observaciones = New Modulo_Facturacion.cp_Textbox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_CS = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Filtros.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Valores.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.chk_Status)
        Me.gbx_Filtros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtros.ForeColor = System.Drawing.Color.Black
        Me.gbx_Filtros.Location = New System.Drawing.Point(8, 4)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(774, 69)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(222, 43)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 6
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(308, 32)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(8, 44)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 4
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(51, 41)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(165, 21)
        Me.cmb_Status.TabIndex = 5
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(152, 18)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(193, 15)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(7, 18)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(51, 15)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Validar)
        Me.gbx_Controles.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Controles.Location = New System.Drawing.Point(8, 504)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(774, 50)
        Me.gbx_Controles.TabIndex = 3
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_Validar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Validar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar F2"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_Eliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(152, 12)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(148, 30)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "&Eliminar Pernocta F4"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(74, 99)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 6
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Pernoctas)
        Me.gbx_Detalle.Location = New System.Drawing.Point(8, 79)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(774, 257)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        '
        'lsv_Pernoctas
        '
        Me.lsv_Pernoctas.AllowColumnReorder = True
        Me.lsv_Pernoctas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Pernoctas.CheckBoxes = True
        Me.lsv_Pernoctas.FullRowSelect = True
        Me.lsv_Pernoctas.HideSelection = False
        Me.lsv_Pernoctas.Location = New System.Drawing.Point(6, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Pernoctas.Lvs = ListViewColumnSorter1
        Me.lsv_Pernoctas.MultiSelect = False
        Me.lsv_Pernoctas.Name = "lsv_Pernoctas"
        Me.lsv_Pernoctas.Row1 = 8
        Me.lsv_Pernoctas.Row10 = 0
        Me.lsv_Pernoctas.Row2 = 6
        Me.lsv_Pernoctas.Row3 = 20
        Me.lsv_Pernoctas.Row4 = 8
        Me.lsv_Pernoctas.Row5 = 8
        Me.lsv_Pernoctas.Row6 = 8
        Me.lsv_Pernoctas.Row7 = 20
        Me.lsv_Pernoctas.Row8 = 8
        Me.lsv_Pernoctas.Row9 = 20
        Me.lsv_Pernoctas.Size = New System.Drawing.Size(762, 214)
        Me.lsv_Pernoctas.TabIndex = 0
        Me.lsv_Pernoctas.UseCompatibleStateImageBehavior = False
        Me.lsv_Pernoctas.View = System.Windows.Forms.View.Details
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(114, 20)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(158, 17)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'lbl_CS
        '
        Me.lbl_CS.AutoSize = True
        Me.lbl_CS.Location = New System.Drawing.Point(107, 72)
        Me.lbl_CS.Name = "lbl_CS"
        Me.lbl_CS.Size = New System.Drawing.Size(45, 13)
        Me.lbl_CS.TabIndex = 4
        Me.lbl_CS.Text = "Servicio"
        '
        'gbx_Valores
        '
        Me.gbx_Valores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Valores.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Valores.Controls.Add(Me.lbl_ObservacionesValida)
        Me.gbx_Valores.Controls.Add(Me.tbx_ObservacionesValida)
        Me.gbx_Valores.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Valores.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Valores.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Valores.Controls.Add(Me.tbx_Observaciones)
        Me.gbx_Valores.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Valores.Controls.Add(Me.lbl_CS)
        Me.gbx_Valores.Controls.Add(Me.cmb_CS)
        Me.gbx_Valores.Location = New System.Drawing.Point(8, 342)
        Me.gbx_Valores.Name = "gbx_Valores"
        Me.gbx_Valores.Size = New System.Drawing.Size(774, 156)
        Me.gbx_Valores.TabIndex = 2
        Me.gbx_Valores.TabStop = False
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Cliente.Control_Siguiente = Nothing
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(158, 43)
        Me.tbx_Cliente.MaxLength = 200
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.ReadOnly = True
        Me.tbx_Cliente.Size = New System.Drawing.Size(461, 20)
        Me.tbx_Cliente.TabIndex = 3
        Me.tbx_Cliente.TabStop = False
        Me.tbx_Cliente.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_ObservacionesValida
        '
        Me.lbl_ObservacionesValida.AutoSize = True
        Me.lbl_ObservacionesValida.Location = New System.Drawing.Point(7, 125)
        Me.lbl_ObservacionesValida.Name = "lbl_ObservacionesValida"
        Me.lbl_ObservacionesValida.Size = New System.Drawing.Size(145, 13)
        Me.lbl_ObservacionesValida.TabIndex = 8
        Me.lbl_ObservacionesValida.Text = "Observaciones de Validación"
        '
        'tbx_ObservacionesValida
        '
        Me.tbx_ObservacionesValida.Control_Siguiente = Me.btn_Validar
        Me.tbx_ObservacionesValida.Filtrado = True
        Me.tbx_ObservacionesValida.Location = New System.Drawing.Point(158, 122)
        Me.tbx_ObservacionesValida.MaxLength = 200
        Me.tbx_ObservacionesValida.Name = "tbx_ObservacionesValida"
        Me.tbx_ObservacionesValida.Size = New System.Drawing.Size(461, 20)
        Me.tbx_ObservacionesValida.TabIndex = 9
        Me.tbx_ObservacionesValida.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Observaciones.Control_Siguiente = Nothing
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(158, 96)
        Me.tbx_Observaciones.MaxLength = 200
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.ReadOnly = True
        Me.tbx_Observaciones.Size = New System.Drawing.Size(461, 20)
        Me.tbx_Observaciones.TabIndex = 7
        Me.tbx_Observaciones.TabStop = False
        Me.tbx_Observaciones.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(113, 46)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 2
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cmb_CS
        '
        Me.cmb_CS.Clave = Nothing
        Me.cmb_CS.Control_Siguiente = Me.tbx_ObservacionesValida
        Me.cmb_CS.DisplayMember = "Descripcion"
        Me.cmb_CS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CS.Empresa = False
        Me.cmb_CS.Filtro = Nothing
        Me.cmb_CS.FormattingEnabled = True
        Me.cmb_CS.Location = New System.Drawing.Point(158, 69)
        Me.cmb_CS.MaxDropDownItems = 20
        Me.cmb_CS.Name = "cmb_CS"
        Me.cmb_CS.Pista = False
        Me.cmb_CS.Size = New System.Drawing.Size(461, 21)
        Me.cmb_CS.StoredProcedure = "Cat_ClientesServicios_GetCombo"
        Me.cmb_CS.Sucursal = False
        Me.cmb_CS.TabIndex = 5
        Me.cmb_CS.Tipo = 0
        Me.cmb_CS.ValueMember = "Id_CS"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(623, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(145, 18)
        Me.Lbl_Registros.TabIndex = 5
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Pernoctas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 567)
        Me.Controls.Add(Me.gbx_Valores)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Pernoctas"
        Me.Text = "Pernoctas"
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Valores.ResumeLayout(False)
        Me.gbx_Valores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents tbx_Observaciones As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lsv_Pernoctas As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_CS As System.Windows.Forms.Label
    Friend WithEvents cmb_CS As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Valores As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_ObservacionesValida As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_ObservacionesValida As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
