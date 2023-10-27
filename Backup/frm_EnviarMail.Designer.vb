<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EnviarMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EnviarMail))
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Archivo = New System.Windows.Forms.Button
        Me.gbx_Reportes = New System.Windows.Forms.GroupBox
        Me.btn_EnviarMail = New System.Windows.Forms.Button
        Me.gbx_Archivo = New System.Windows.Forms.GroupBox
        Me.lbl_Texto = New System.Windows.Forms.Label
        Me.rtb_Texto = New System.Windows.Forms.RichTextBox
        Me.lbl_Nota = New System.Windows.Forms.Label
        Me.lsv_Destinos = New Modulo_Facturacion.cp_Listview
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.rtb_Archivo = New System.Windows.Forms.RichTextBox
        Me.ofd_Archivo = New System.Windows.Forms.OpenFileDialog
        Me.gbx_Reportes.SuspendLayout()
        Me.gbx_Archivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(393, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Archivo
        '
        Me.btn_Archivo.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Archivo.Location = New System.Drawing.Point(501, 17)
        Me.btn_Archivo.Name = "btn_Archivo"
        Me.btn_Archivo.Size = New System.Drawing.Size(26, 23)
        Me.btn_Archivo.TabIndex = 2
        Me.btn_Archivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Archivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Archivo.UseVisualStyleBackColor = True
        '
        'gbx_Reportes
        '
        Me.gbx_Reportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Reportes.Controls.Add(Me.btn_EnviarMail)
        Me.gbx_Reportes.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Reportes.Location = New System.Drawing.Point(7, 456)
        Me.gbx_Reportes.Name = "gbx_Reportes"
        Me.gbx_Reportes.Size = New System.Drawing.Size(539, 50)
        Me.gbx_Reportes.TabIndex = 1
        Me.gbx_Reportes.TabStop = False
        '
        'btn_EnviarMail
        '
        Me.btn_EnviarMail.Enabled = False
        Me.btn_EnviarMail.Image = Global.Modulo_Facturacion.My.Resources.Resources.Mail_Enviado
        Me.btn_EnviarMail.Location = New System.Drawing.Point(6, 13)
        Me.btn_EnviarMail.Name = "btn_EnviarMail"
        Me.btn_EnviarMail.Size = New System.Drawing.Size(140, 30)
        Me.btn_EnviarMail.TabIndex = 0
        Me.btn_EnviarMail.Text = "&Enviar Mail"
        Me.btn_EnviarMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EnviarMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EnviarMail.UseVisualStyleBackColor = True
        '
        'gbx_Archivo
        '
        Me.gbx_Archivo.Controls.Add(Me.lbl_Texto)
        Me.gbx_Archivo.Controls.Add(Me.rtb_Texto)
        Me.gbx_Archivo.Controls.Add(Me.lbl_Nota)
        Me.gbx_Archivo.Controls.Add(Me.lsv_Destinos)
        Me.gbx_Archivo.Controls.Add(Me.lbl_Archivo)
        Me.gbx_Archivo.Controls.Add(Me.rtb_Archivo)
        Me.gbx_Archivo.Controls.Add(Me.btn_Archivo)
        Me.gbx_Archivo.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Archivo.Name = "gbx_Archivo"
        Me.gbx_Archivo.Size = New System.Drawing.Size(539, 452)
        Me.gbx_Archivo.TabIndex = 0
        Me.gbx_Archivo.TabStop = False
        '
        'lbl_Texto
        '
        Me.lbl_Texto.Location = New System.Drawing.Point(10, 371)
        Me.lbl_Texto.Name = "lbl_Texto"
        Me.lbl_Texto.Size = New System.Drawing.Size(54, 34)
        Me.lbl_Texto.TabIndex = 5
        Me.lbl_Texto.Text = "Texto del Correo"
        '
        'rtb_Texto
        '
        Me.rtb_Texto.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_Texto.Location = New System.Drawing.Point(70, 368)
        Me.rtb_Texto.MaxLength = 3000
        Me.rtb_Texto.Name = "rtb_Texto"
        Me.rtb_Texto.Size = New System.Drawing.Size(457, 78)
        Me.rtb_Texto.TabIndex = 6
        Me.rtb_Texto.Text = ""
        '
        'lbl_Nota
        '
        Me.lbl_Nota.Location = New System.Drawing.Point(56, 43)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(439, 39)
        Me.lbl_Nota.TabIndex = 3
        Me.lbl_Nota.Text = resources.GetString("lbl_Nota.Text")
        Me.lbl_Nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsv_Destinos
        '
        Me.lsv_Destinos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Destinos.CheckBoxes = True
        Me.lsv_Destinos.FullRowSelect = True
        Me.lsv_Destinos.HideSelection = False
        Me.lsv_Destinos.Location = New System.Drawing.Point(6, 85)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Destinos.Lvs = ListViewColumnSorter1
        Me.lsv_Destinos.MultiSelect = False
        Me.lsv_Destinos.Name = "lsv_Destinos"
        Me.lsv_Destinos.Row1 = 45
        Me.lsv_Destinos.Row10 = 0
        Me.lsv_Destinos.Row2 = 30
        Me.lsv_Destinos.Row3 = 30
        Me.lsv_Destinos.Row4 = 0
        Me.lsv_Destinos.Row5 = 0
        Me.lsv_Destinos.Row6 = 0
        Me.lsv_Destinos.Row7 = 0
        Me.lsv_Destinos.Row8 = 0
        Me.lsv_Destinos.Row9 = 0
        Me.lsv_Destinos.Size = New System.Drawing.Size(527, 277)
        Me.lsv_Destinos.TabIndex = 4
        Me.lsv_Destinos.UseCompatibleStateImageBehavior = False
        Me.lsv_Destinos.View = System.Windows.Forms.View.Details
        '
        'lbl_Archivo
        '
        Me.lbl_Archivo.AutoSize = True
        Me.lbl_Archivo.Location = New System.Drawing.Point(7, 22)
        Me.lbl_Archivo.Name = "lbl_Archivo"
        Me.lbl_Archivo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Archivo.TabIndex = 0
        Me.lbl_Archivo.Text = "Archivo"
        '
        'rtb_Archivo
        '
        Me.rtb_Archivo.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_Archivo.Location = New System.Drawing.Point(56, 19)
        Me.rtb_Archivo.Multiline = False
        Me.rtb_Archivo.Name = "rtb_Archivo"
        Me.rtb_Archivo.ReadOnly = True
        Me.rtb_Archivo.Size = New System.Drawing.Size(439, 20)
        Me.rtb_Archivo.TabIndex = 1
        Me.rtb_Archivo.TabStop = False
        Me.rtb_Archivo.Text = ""
        '
        'ofd_Archivo
        '
        Me.ofd_Archivo.FileName = "OpenFileDialog1"
        '
        'frm_EnviarMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 511)
        Me.Controls.Add(Me.gbx_Reportes)
        Me.Controls.Add(Me.gbx_Archivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 540)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 540)
        Me.Name = "frm_EnviarMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Mail"
        Me.gbx_Reportes.ResumeLayout(False)
        Me.gbx_Archivo.ResumeLayout(False)
        Me.gbx_Archivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Archivo As System.Windows.Forms.Button
    Friend WithEvents gbx_Reportes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Archivo As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Archivo As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents btn_EnviarMail As System.Windows.Forms.Button
    Friend WithEvents ofd_Archivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lsv_Destinos As Modulo_Facturacion.cp_Listview
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents lbl_Texto As System.Windows.Forms.Label
    Friend WithEvents rtb_Texto As System.Windows.Forms.RichTextBox
End Class
