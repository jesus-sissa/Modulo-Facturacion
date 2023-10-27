<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Domicilios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Domicilios))
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.btn_Fiscales = New System.Windows.Forms.Button
        Me.btn_Comerciales = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.pgb = New System.Windows.Forms.ProgressBar
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Datos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Datos.Controls.Add(Me.btn_Fiscales)
        Me.Gbx_Datos.Controls.Add(Me.btn_Comerciales)
        Me.Gbx_Datos.Location = New System.Drawing.Point(6, 5)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(445, 146)
        Me.Gbx_Datos.TabIndex = 0
        Me.Gbx_Datos.TabStop = False
        '
        'btn_Fiscales
        '
        Me.btn_Fiscales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Fiscales.Image = Global.Modulo_Facturacion.My.Resources.Resources.signature
        Me.btn_Fiscales.Location = New System.Drawing.Point(6, 67)
        Me.btn_Fiscales.Name = "btn_Fiscales"
        Me.btn_Fiscales.Size = New System.Drawing.Size(433, 30)
        Me.btn_Fiscales.TabIndex = 4
        Me.btn_Fiscales.Text = "Leer Domicilios Fiscales"
        Me.btn_Fiscales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Fiscales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Fiscales.UseVisualStyleBackColor = True
        '
        'btn_Comerciales
        '
        Me.btn_Comerciales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Comerciales.Image = Global.Modulo_Facturacion.My.Resources.Resources.signature
        Me.btn_Comerciales.Location = New System.Drawing.Point(6, 19)
        Me.btn_Comerciales.Name = "btn_Comerciales"
        Me.btn_Comerciales.Size = New System.Drawing.Size(433, 30)
        Me.btn_Comerciales.TabIndex = 3
        Me.btn_Comerciales.Text = "Leer Domicilios Comerciales"
        Me.btn_Comerciales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Comerciales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Comerciales.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(299, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 179)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(445, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'pgb
        '
        Me.pgb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgb.Location = New System.Drawing.Point(6, 157)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(445, 23)
        Me.pgb.TabIndex = 2
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(6, 110)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(433, 26)
        Me.lbl_Registros.TabIndex = 5
        Me.lbl_Registros.Text = "0 Registros Leídos"
        '
        'frm_Domicilios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 234)
        Me.Controls.Add(Me.pgb)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Domicilios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recalcular Domicilios de Clientes"
        Me.Gbx_Datos.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents pgb As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_Fiscales As System.Windows.Forms.Button
    Friend WithEvents btn_Comerciales As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
