<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PreFacturaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PreFacturaClientes))
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.chk_Sucursales = New System.Windows.Forms.CheckBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.pgb = New System.Windows.Forms.ProgressBar
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_Grupo = New System.Windows.Forms.CheckBox
        Me.Cmb_Grupo = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Status = New Modulo_Facturacion.cp_cmb_Manual
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.cmb_Clientes = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clientes = New Modulo_Facturacion.cp_Textbox
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ImpLavado = New System.Windows.Forms.Button
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(6, 25)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(50, 21)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(151, 25)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(192, 21)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(5, 50)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(475, 79)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(179, 17)
        Me.chk_Todos.TabIndex = 8
        Me.chk_Todos.Text = "Todos los Clientes y SubClientes"
        Me.chk_Todos.UseVisualStyleBackColor = True
        Me.chk_Todos.Visible = False
        '
        'chk_Sucursales
        '
        Me.chk_Sucursales.AutoSize = True
        Me.chk_Sucursales.Location = New System.Drawing.Point(545, 51)
        Me.chk_Sucursales.Name = "chk_Sucursales"
        Me.chk_Sucursales.Size = New System.Drawing.Size(109, 17)
        Me.chk_Sucursales.TabIndex = 7
        Me.chk_Sucursales.Text = "Incluir Sucursales"
        Me.chk_Sucursales.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(530, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Exportar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(11, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Generar F7"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'pgb
        '
        Me.pgb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgb.Location = New System.Drawing.Point(8, 148)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(682, 23)
        Me.pgb.TabIndex = 1
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Controls.Add(Me.Chk_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.Cmb_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Nota)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.chk_Sucursales)
        Me.gbx_Filtro.Controls.Add(Me.chk_Todos)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Clientes)
        Me.gbx_Filtro.Location = New System.Drawing.Point(8, 4)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(682, 137)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Grupo"
        '
        'Chk_Grupo
        '
        Me.Chk_Grupo.AutoSize = True
        Me.Chk_Grupo.Location = New System.Drawing.Point(306, 79)
        Me.Chk_Grupo.Name = "Chk_Grupo"
        Me.Chk_Grupo.Size = New System.Drawing.Size(113, 17)
        Me.Chk_Grupo.TabIndex = 13
        Me.Chk_Grupo.Text = "No filtrar por grupo"
        Me.Chk_Grupo.UseVisualStyleBackColor = True
        '
        'Cmb_Grupo
        '
        Me.Cmb_Grupo.Clave = ""
        Me.Cmb_Grupo.Control_Siguiente = Me.cmb_Status
        Me.Cmb_Grupo.DisplayMember = "Descripcion"
        Me.Cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Grupo.Empresa = False
        Me.Cmb_Grupo.Filtro = Nothing
        Me.Cmb_Grupo.FormattingEnabled = True
        Me.Cmb_Grupo.Location = New System.Drawing.Point(50, 77)
        Me.Cmb_Grupo.MaxDropDownItems = 20
        Me.Cmb_Grupo.Name = "Cmb_Grupo"
        Me.Cmb_Grupo.Pista = False
        Me.Cmb_Grupo.Size = New System.Drawing.Size(250, 21)
        Me.Cmb_Grupo.StoredProcedure = "Cat_ClientesGrupos_Get"
        Me.Cmb_Grupo.Sucursal = True
        Me.Cmb_Grupo.TabIndex = 12
        Me.Cmb_Grupo.Tipo = 0
        Me.Cmb_Grupo.ValueMember = "Id_ClienteGrupo"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Exportar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(50, 104)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(179, 21)
        Me.cmb_Status.TabIndex = 10
        Me.cmb_Status.ValueMember = "value"
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(235, 107)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(229, 13)
        Me.Lbl_Nota.TabIndex = 11
        Me.Lbl_Nota.Text = "(El Status solo aplica para Traslado de Valores)"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.Cmb_Grupo
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.tbx_Clientes
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(139, 47)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "cat_ClientesCombo_GetAB"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 6
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'tbx_Clientes
        '
        Me.tbx_Clientes.Control_Siguiente = Me.cmb_Clientes
        Me.tbx_Clientes.Filtrado = True
        Me.tbx_Clientes.Location = New System.Drawing.Point(50, 47)
        Me.tbx_Clientes.MaxLength = 12
        Me.tbx_Clientes.Name = "tbx_Clientes"
        Me.tbx_Clientes.Size = New System.Drawing.Size(83, 20)
        Me.tbx_Clientes.TabIndex = 5
        Me.tbx_Clientes.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(5, 107)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 9
        Me.Lbl_Status.Text = "Status"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ImpLavado)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 174)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(682, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_ImpLavado
        '
        Me.btn_ImpLavado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ImpLavado.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_ImpLavado.Location = New System.Drawing.Point(279, 14)
        Me.btn_ImpLavado.Name = "btn_ImpLavado"
        Me.btn_ImpLavado.Size = New System.Drawing.Size(140, 30)
        Me.btn_ImpLavado.TabIndex = 3
        Me.btn_ImpLavado.Text = "Ley Lavado"
        Me.btn_ImpLavado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpLavado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImpLavado.UseVisualStyleBackColor = True
        '
        'frm_PreFacturaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 228)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.pgb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PreFacturaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar PreFactura"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Clientes As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Clientes As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Sucursales As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents pgb As System.Windows.Forms.ProgressBar
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Status As Modulo_Facturacion.cp_cmb_Manual
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents Cmb_Grupo As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ImpLavado As System.Windows.Forms.Button
End Class
