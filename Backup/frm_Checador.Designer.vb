<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Checador
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Lista = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Lista.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Lista
        '
        Me.Gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Lista.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Lista.Controls.Add(Me.lsv_Datos)
        Me.Gbx_Lista.Location = New System.Drawing.Point(5, 54)
        Me.Gbx_Lista.Name = "Gbx_Lista"
        Me.Gbx_Lista.Size = New System.Drawing.Size(775, 450)
        Me.Gbx_Lista.TabIndex = 1
        Me.Gbx_Lista.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(614, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(155, 17)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 15
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 25
        Me.lsv_Datos.Row4 = 10
        Me.lsv_Datos.Row5 = 10
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(763, 408)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.Tag = "id_Bitacora"
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(5, 0)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(775, 50)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(164, 23)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 2
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(19, 23)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(205, 17)
        Me.dtp_Hasta.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(63, 17)
        Me.dtp_Desde.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(321, 12)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 4
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'frm_Checador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Lista)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Checador"
        Me.Text = "Consulta de Reloj Checador"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Lista.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
