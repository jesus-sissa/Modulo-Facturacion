<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ClientesFacturacionAnticipada
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
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Me.gbx_Horarios = New System.Windows.Forms.GroupBox()
        Me.chk_Todos = New System.Windows.Forms.CheckBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.Lsv_Clientes = New Modulo_Facturacion.cp_Listview()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbx_UUID = New System.Windows.Forms.TextBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.rdb_ClaveCliente = New System.Windows.Forms.RadioButton()
        Me.rdb_Conpaq = New System.Windows.Forms.RadioButton()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_UUID = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New System.Windows.Forms.TextBox()
        Me.gbx_Horarios.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Horarios
        '
        Me.gbx_Horarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Horarios.Controls.Add(Me.chk_Todos)
        Me.gbx_Horarios.Controls.Add(Me.lbl_Registros)
        Me.gbx_Horarios.Controls.Add(Me.Lsv_Clientes)
        Me.gbx_Horarios.Location = New System.Drawing.Point(3, 162)
        Me.gbx_Horarios.Name = "gbx_Horarios"
        Me.gbx_Horarios.Size = New System.Drawing.Size(789, 271)
        Me.gbx_Horarios.TabIndex = 3
        Me.gbx_Horarios.TabStop = False
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(6, 11)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 3
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(643, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.lbl_Registros.TabIndex = 30
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Clientes
        '
        Me.Lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Clientes.CheckBoxes = True
        Me.Lsv_Clientes.FullRowSelect = True
        Me.Lsv_Clientes.HideSelection = False
        Me.Lsv_Clientes.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Clientes.Lvs = ListViewColumnSorter2
        Me.Lsv_Clientes.MultiSelect = False
        Me.Lsv_Clientes.Name = "Lsv_Clientes"
        Me.Lsv_Clientes.Row1 = 25
        Me.Lsv_Clientes.Row10 = 0
        Me.Lsv_Clientes.Row2 = 8
        Me.Lsv_Clientes.Row3 = 8
        Me.Lsv_Clientes.Row4 = 10
        Me.Lsv_Clientes.Row5 = 15
        Me.Lsv_Clientes.Row6 = 8
        Me.Lsv_Clientes.Row7 = 10
        Me.Lsv_Clientes.Row8 = 10
        Me.Lsv_Clientes.Row9 = 0
        Me.Lsv_Clientes.Size = New System.Drawing.Size(777, 231)
        Me.Lsv_Clientes.TabIndex = 0
        Me.Lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.Lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbx_Buscar)
        Me.Panel1.Controls.Add(Me.lbl_UUID)
        Me.Panel1.Controls.Add(Me.tbx_UUID)
        Me.Panel1.Controls.Add(Me.btn_Guardar)
        Me.Panel1.Controls.Add(Me.rdb_ClaveCliente)
        Me.Panel1.Controls.Add(Me.rdb_Conpaq)
        Me.Panel1.Controls.Add(Me.btn_Buscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 156)
        Me.Panel1.TabIndex = 4
        '
        'tbx_UUID
        '
        Me.tbx_UUID.Enabled = False
        Me.tbx_UUID.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_UUID.Location = New System.Drawing.Point(138, 80)
        Me.tbx_UUID.MaxLength = 60
        Me.tbx_UUID.Name = "tbx_UUID"
        Me.tbx_UUID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbx_UUID.Size = New System.Drawing.Size(498, 32)
        Me.tbx_UUID.TabIndex = 40
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(138, 123)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 39
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'rdb_ClaveCliente
        '
        Me.rdb_ClaveCliente.AutoSize = True
        Me.rdb_ClaveCliente.Location = New System.Drawing.Point(138, 21)
        Me.rdb_ClaveCliente.Name = "rdb_ClaveCliente"
        Me.rdb_ClaveCliente.Size = New System.Drawing.Size(87, 17)
        Me.rdb_ClaveCliente.TabIndex = 37
        Me.rdb_ClaveCliente.Text = "Clave Cliente"
        Me.rdb_ClaveCliente.UseVisualStyleBackColor = True
        '
        'rdb_Conpaq
        '
        Me.rdb_Conpaq.AutoSize = True
        Me.rdb_Conpaq.Location = New System.Drawing.Point(18, 22)
        Me.rdb_Conpaq.Name = "rdb_Conpaq"
        Me.rdb_Conpaq.Size = New System.Drawing.Size(95, 17)
        Me.rdb_Conpaq.TabIndex = 36
        Me.rdb_Conpaq.Text = "Clave Contpaq"
        Me.rdb_Conpaq.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(138, 44)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Buscar.TabIndex = 35
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        Me.btn_Buscar.Visible = False
        '
        'lbl_UUID
        '
        Me.lbl_UUID.AutoSize = True
        Me.lbl_UUID.Enabled = False
        Me.lbl_UUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UUID.Location = New System.Drawing.Point(12, 91)
        Me.lbl_UUID.Name = "lbl_UUID"
        Me.lbl_UUID.Size = New System.Drawing.Size(120, 13)
        Me.lbl_UUID.TabIndex = 64
        Me.lbl_UUID.Text = "Comprobante UUID:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Enabled = False
        Me.tbx_Buscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Buscar.Location = New System.Drawing.Point(18, 43)
        Me.tbx_Buscar.MaxLength = 60
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbx_Buscar.Size = New System.Drawing.Size(95, 32)
        Me.tbx_Buscar.TabIndex = 0
        '
        'frm_ClientesFacturacionAnticipada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbx_Horarios)
        Me.Name = "frm_ClientesFacturacionAnticipada"
        Me.Text = "frm_ClientesFacturacionAnticipada"
        Me.gbx_Horarios.ResumeLayout(False)
        Me.gbx_Horarios.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Horarios As GroupBox
    Friend WithEvents chk_Todos As CheckBox
    Friend WithEvents lbl_Registros As Label
    Friend WithEvents Lsv_Clientes As cp_Listview
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbx_UUID As TextBox
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents rdb_ClaveCliente As RadioButton
    Friend WithEvents rdb_Conpaq As RadioButton
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents lbl_UUID As Label
    Friend WithEvents tbx_Buscar As TextBox
End Class
