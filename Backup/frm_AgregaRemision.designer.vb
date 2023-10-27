<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgregaRemision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgregaRemision))
        Me.lbl_NumeroRemision = New System.Windows.Forms.Label
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.dgv_Dinero = New System.Windows.Forms.DataGridView
        Me.gbx_Envases = New System.Windows.Forms.GroupBox
        Me.lbl_TotalEnvases = New System.Windows.Forms.Label
        Me.lbl_Tcapturado = New System.Windows.Forms.Label
        Me.lbl_EnvasesSN = New System.Windows.Forms.Label
        Me.tbx_EnvasesSn = New Modulo_Facturacion.cp_Textbox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Facturacion.cp_Listview
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_Numero = New Modulo_Facturacion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Movimiento = New System.Windows.Forms.Label
        Me.btn_Comprobar = New System.Windows.Forms.Button
        Me.gbx_Total = New System.Windows.Forms.GroupBox
        Me.tbx_TotalRemision = New Modulo_Facturacion.cp_Textbox
        Me.lbl_TRemision = New System.Windows.Forms.Label
        Me.tbx_Remision = New Modulo_Facturacion.cp_Textbox
        CType(Me.dgv_Dinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Envases.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Total.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NumeroRemision
        '
        Me.lbl_NumeroRemision.AutoSize = True
        Me.lbl_NumeroRemision.Location = New System.Drawing.Point(5, 52)
        Me.lbl_NumeroRemision.Name = "lbl_NumeroRemision"
        Me.lbl_NumeroRemision.Size = New System.Drawing.Size(105, 13)
        Me.lbl_NumeroRemision.TabIndex = 1
        Me.lbl_NumeroRemision.Text = "Número de Remisión"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(387, 12)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cancelar ESC"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'dgv_Dinero
        '
        Me.dgv_Dinero.AllowUserToAddRows = False
        Me.dgv_Dinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Dinero.Location = New System.Drawing.Point(8, 78)
        Me.dgv_Dinero.Name = "dgv_Dinero"
        Me.dgv_Dinero.Size = New System.Drawing.Size(532, 156)
        Me.dgv_Dinero.TabIndex = 4
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Controls.Add(Me.lbl_TotalEnvases)
        Me.gbx_Envases.Controls.Add(Me.lbl_Tcapturado)
        Me.gbx_Envases.Controls.Add(Me.lbl_EnvasesSN)
        Me.gbx_Envases.Controls.Add(Me.tbx_EnvasesSn)
        Me.gbx_Envases.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Envases.Controls.Add(Me.lsv_Envases)
        Me.gbx_Envases.Controls.Add(Me.Btn_Agregar)
        Me.gbx_Envases.Controls.Add(Me.tbx_Numero)
        Me.gbx_Envases.Controls.Add(Me.cmb_TipoEnvase)
        Me.gbx_Envases.Controls.Add(Me.lbl_TipoEnvase)
        Me.gbx_Envases.Controls.Add(Me.lbl_numero)
        Me.gbx_Envases.Location = New System.Drawing.Point(8, 290)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(532, 222)
        Me.gbx_Envases.TabIndex = 6
        Me.gbx_Envases.TabStop = False
        Me.gbx_Envases.Text = "Envases"
        '
        'lbl_TotalEnvases
        '
        Me.lbl_TotalEnvases.AutoSize = True
        Me.lbl_TotalEnvases.Location = New System.Drawing.Point(111, 199)
        Me.lbl_TotalEnvases.Name = "lbl_TotalEnvases"
        Me.lbl_TotalEnvases.Size = New System.Drawing.Size(13, 13)
        Me.lbl_TotalEnvases.TabIndex = 10
        Me.lbl_TotalEnvases.Text = "0"
        '
        'lbl_Tcapturado
        '
        Me.lbl_Tcapturado.AutoSize = True
        Me.lbl_Tcapturado.Location = New System.Drawing.Point(90, 180)
        Me.lbl_Tcapturado.Name = "lbl_Tcapturado"
        Me.lbl_Tcapturado.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Tcapturado.TabIndex = 9
        Me.lbl_Tcapturado.Text = "Total Envases"
        '
        'lbl_EnvasesSN
        '
        Me.lbl_EnvasesSN.AutoSize = True
        Me.lbl_EnvasesSN.Location = New System.Drawing.Point(13, 180)
        Me.lbl_EnvasesSN.Name = "lbl_EnvasesSN"
        Me.lbl_EnvasesSN.Size = New System.Drawing.Size(71, 13)
        Me.lbl_EnvasesSN.TabIndex = 7
        Me.lbl_EnvasesSN.Text = "Envases S/N"
        '
        'tbx_EnvasesSn
        '
        Me.tbx_EnvasesSn.Control_Siguiente = Nothing
        Me.tbx_EnvasesSn.Filtrado = True
        Me.tbx_EnvasesSn.Location = New System.Drawing.Point(16, 196)
        Me.tbx_EnvasesSn.MaxLength = 4
        Me.tbx_EnvasesSn.Name = "tbx_EnvasesSn"
        Me.tbx_EnvasesSn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_EnvasesSn.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EnvasesSn.TabIndex = 8
        Me.tbx_EnvasesSn.Text = "0"
        Me.tbx_EnvasesSn.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 137)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.Text = "&Eliminar F4"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(153, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 50
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(373, 148)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Agregar
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 101)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "&Agregar F3"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_Numero.Filtrado = False
        Me.tbx_Numero.Location = New System.Drawing.Point(6, 35)
        Me.tbx_Numero.MaxLength = 15
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(141, 20)
        Me.tbx_Numero.TabIndex = 1
        Me.tbx_Numero.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_TipoEnvase
        '
        Me.cmb_TipoEnvase.Clave = Nothing
        Me.cmb_TipoEnvase.Control_Siguiente = Me.Btn_Agregar
        Me.cmb_TipoEnvase.DisplayMember = "Descripcion"
        Me.cmb_TipoEnvase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEnvase.Empresa = False
        Me.cmb_TipoEnvase.Filtro = Nothing
        Me.cmb_TipoEnvase.FormattingEnabled = True
        Me.cmb_TipoEnvase.Location = New System.Drawing.Point(6, 74)
        Me.cmb_TipoEnvase.Name = "cmb_TipoEnvase"
        Me.cmb_TipoEnvase.Pista = True
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(141, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.Tipo = 0
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
        '
        'lbl_TipoEnvase
        '
        Me.lbl_TipoEnvase.AutoSize = True
        Me.lbl_TipoEnvase.Location = New System.Drawing.Point(7, 58)
        Me.lbl_TipoEnvase.Name = "lbl_TipoEnvase"
        Me.lbl_TipoEnvase.Size = New System.Drawing.Size(82, 13)
        Me.lbl_TipoEnvase.TabIndex = 2
        Me.lbl_TipoEnvase.Text = "Tipo de Envase"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(6, 19)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Número"
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Controls.Add(Me.Btn_Guardar)
        Me.gbx_Controles.Controls.Add(Me.Btn_Cancelar)
        Me.gbx_Controles.Location = New System.Drawing.Point(8, 518)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(532, 50)
        Me.gbx_Controles.TabIndex = 7
        Me.gbx_Controles.TabStop = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(4, 12)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar F5"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Movimiento
        '
        Me.lbl_Movimiento.AutoSize = True
        Me.lbl_Movimiento.Location = New System.Drawing.Point(193, 9)
        Me.lbl_Movimiento.Name = "lbl_Movimiento"
        Me.lbl_Movimiento.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Movimiento.TabIndex = 0
        Me.lbl_Movimiento.Text = "Id_Movimiento"
        Me.lbl_Movimiento.Visible = False
        '
        'btn_Comprobar
        '
        Me.btn_Comprobar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Comprobar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Comprobar.Location = New System.Drawing.Point(311, -12)
        Me.btn_Comprobar.Name = "btn_Comprobar"
        Me.btn_Comprobar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Comprobar.TabIndex = 3
        Me.btn_Comprobar.Text = "&Comprobar F6"
        Me.btn_Comprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Comprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Comprobar.UseVisualStyleBackColor = True
        '
        'gbx_Total
        '
        Me.gbx_Total.Controls.Add(Me.tbx_TotalRemision)
        Me.gbx_Total.Controls.Add(Me.lbl_TRemision)
        Me.gbx_Total.Location = New System.Drawing.Point(8, 240)
        Me.gbx_Total.Name = "gbx_Total"
        Me.gbx_Total.Size = New System.Drawing.Size(532, 44)
        Me.gbx_Total.TabIndex = 5
        Me.gbx_Total.TabStop = False
        '
        'tbx_TotalRemision
        '
        Me.tbx_TotalRemision.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_TotalRemision.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_TotalRemision.Filtrado = False
        Me.tbx_TotalRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemision.Location = New System.Drawing.Point(379, 15)
        Me.tbx_TotalRemision.MaxLength = 15
        Me.tbx_TotalRemision.Name = "tbx_TotalRemision"
        Me.tbx_TotalRemision.ReadOnly = True
        Me.tbx_TotalRemision.Size = New System.Drawing.Size(141, 21)
        Me.tbx_TotalRemision.TabIndex = 1
        Me.tbx_TotalRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_TotalRemision.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_TRemision
        '
        Me.lbl_TRemision.AutoSize = True
        Me.lbl_TRemision.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TRemision.Location = New System.Drawing.Point(264, 18)
        Me.lbl_TRemision.Name = "lbl_TRemision"
        Me.lbl_TRemision.Size = New System.Drawing.Size(103, 13)
        Me.lbl_TRemision.TabIndex = 0
        Me.lbl_TRemision.Text = "Total de la Remisión"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.btn_Comprobar
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Remision.Location = New System.Drawing.Point(116, 43)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(189, 29)
        Me.tbx_Remision.TabIndex = 2
        Me.tbx_Remision.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_AgregaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_Total)
        Me.Controls.Add(Me.btn_Comprobar)
        Me.Controls.Add(Me.lbl_Movimiento)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Envases)
        Me.Controls.Add(Me.dgv_Dinero)
        Me.Controls.Add(Me.lbl_NumeroRemision)
        Me.Controls.Add(Me.tbx_Remision)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 600)
        Me.Name = "frm_AgregaRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Remisión"
        CType(Me.dgv_Dinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Envases.ResumeLayout(False)
        Me.gbx_Envases.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Total.ResumeLayout(False)
        Me.gbx_Total.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NumeroRemision As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dgv_Dinero As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_Envases As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Facturacion.cp_Listview
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_TipoEnvase As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_TipoEnvase As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalEnvases As System.Windows.Forms.Label
    Friend WithEvents lbl_Tcapturado As System.Windows.Forms.Label
    Friend WithEvents lbl_EnvasesSN As System.Windows.Forms.Label
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Movimiento As System.Windows.Forms.Label
    Friend WithEvents btn_Comprobar As System.Windows.Forms.Button
    Friend WithEvents gbx_Total As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Numero As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_EnvasesSn As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_TotalRemision As Modulo_Facturacion.cp_Textbox
End Class
