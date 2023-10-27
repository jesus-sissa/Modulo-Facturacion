<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SettingsAdminPaq
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
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_versionZK = New System.Windows.Forms.GroupBox
        Me.rdb_NO = New System.Windows.Forms.RadioButton
        Me.rdb_SI = New System.Windows.Forms.RadioButton
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_versionZK.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(199, 17)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_versionZK
        '
        Me.gbx_versionZK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_versionZK.Controls.Add(Me.rdb_NO)
        Me.gbx_versionZK.Controls.Add(Me.rdb_SI)
        Me.gbx_versionZK.Location = New System.Drawing.Point(12, 12)
        Me.gbx_versionZK.Name = "gbx_versionZK"
        Me.gbx_versionZK.Size = New System.Drawing.Size(345, 70)
        Me.gbx_versionZK.TabIndex = 1
        Me.gbx_versionZK.TabStop = False
        '
        'rdb_NO
        '
        Me.rdb_NO.AutoSize = True
        Me.rdb_NO.Location = New System.Drawing.Point(233, 30)
        Me.rdb_NO.Name = "rdb_NO"
        Me.rdb_NO.Size = New System.Drawing.Size(41, 17)
        Me.rdb_NO.TabIndex = 1
        Me.rdb_NO.TabStop = True
        Me.rdb_NO.Text = "NO"
        Me.rdb_NO.UseVisualStyleBackColor = True
        '
        'rdb_SI
        '
        Me.rdb_SI.AutoSize = True
        Me.rdb_SI.Location = New System.Drawing.Point(56, 30)
        Me.rdb_SI.Name = "rdb_SI"
        Me.rdb_SI.Size = New System.Drawing.Size(35, 17)
        Me.rdb_SI.TabIndex = 0
        Me.rdb_SI.TabStop = True
        Me.rdb_SI.Text = "SI"
        Me.rdb_SI.UseVisualStyleBackColor = True
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Location = New System.Drawing.Point(11, 88)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(345, 53)
        Me.gbx_botones.TabIndex = 0
        Me.gbx_botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 17)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'frm_SettingsGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 153)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_versionZK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SettingsGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enlazar Sistema con AdminPaq"
        Me.gbx_versionZK.ResumeLayout(False)
        Me.gbx_versionZK.PerformLayout()
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_versionZK As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_NO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_SI As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
End Class
