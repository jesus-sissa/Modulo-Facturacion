<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConvertirPDF
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConvertirPDF))
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Archivo = New System.Windows.Forms.Button
        Me.gbx_Reportes = New System.Windows.Forms.GroupBox
        Me.btn_Convertir = New System.Windows.Forms.Button
        Me.gbx_Ubicacion = New System.Windows.Forms.GroupBox
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.rtb_Destino = New System.Windows.Forms.RichTextBox
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.rtb_Archivo = New System.Windows.Forms.RichTextBox
        Me.gbx_TipoConversion = New System.Windows.Forms.GroupBox
        Me.chk_pdf = New System.Windows.Forms.CheckBox
        Me.chk_jpg = New System.Windows.Forms.CheckBox
        Me.chk_png = New System.Windows.Forms.CheckBox
        Me.chk_bmp = New System.Windows.Forms.CheckBox
        Me.chk_tif = New System.Windows.Forms.CheckBox
        Me.fbd_Destino = New System.Windows.Forms.FolderBrowserDialog
        Me.ofd_Archivo = New System.Windows.Forms.OpenFileDialog
        Me.gbx_Programa = New System.Windows.Forms.GroupBox
        Me.rdb_PDFCreator = New System.Windows.Forms.RadioButton
        Me.rdb_Excel = New System.Windows.Forms.RadioButton
        Me.tmr_PDF = New System.Windows.Forms.Timer(Me.components)
        Me.gbx_Reportes.SuspendLayout()
        Me.gbx_Ubicacion.SuspendLayout()
        Me.gbx_TipoConversion.SuspendLayout()
        Me.gbx_Programa.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(249, 13)
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
        Me.btn_Archivo.Location = New System.Drawing.Point(353, 17)
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
        Me.gbx_Reportes.Controls.Add(Me.btn_Convertir)
        Me.gbx_Reportes.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Reportes.Location = New System.Drawing.Point(9, 176)
        Me.gbx_Reportes.Name = "gbx_Reportes"
        Me.gbx_Reportes.Size = New System.Drawing.Size(395, 50)
        Me.gbx_Reportes.TabIndex = 3
        Me.gbx_Reportes.TabStop = False
        '
        'btn_Convertir
        '
        Me.btn_Convertir.Enabled = False
        Me.btn_Convertir.Image = Global.Modulo_Facturacion.My.Resources.Resources.Imprimir
        Me.btn_Convertir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Convertir.Name = "btn_Convertir"
        Me.btn_Convertir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Convertir.TabIndex = 0
        Me.btn_Convertir.Text = "&Convertir"
        Me.btn_Convertir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Convertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Convertir.UseVisualStyleBackColor = True
        '
        'gbx_Ubicacion
        '
        Me.gbx_Ubicacion.Controls.Add(Me.lbl_Destino)
        Me.gbx_Ubicacion.Controls.Add(Me.rtb_Destino)
        Me.gbx_Ubicacion.Controls.Add(Me.btn_Destino)
        Me.gbx_Ubicacion.Controls.Add(Me.lbl_Archivo)
        Me.gbx_Ubicacion.Controls.Add(Me.rtb_Archivo)
        Me.gbx_Ubicacion.Controls.Add(Me.btn_Archivo)
        Me.gbx_Ubicacion.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Ubicacion.Name = "gbx_Ubicacion"
        Me.gbx_Ubicacion.Size = New System.Drawing.Size(394, 74)
        Me.gbx_Ubicacion.TabIndex = 0
        Me.gbx_Ubicacion.TabStop = False
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(7, 48)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 3
        Me.lbl_Destino.Text = "Destino"
        '
        'rtb_Destino
        '
        Me.rtb_Destino.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_Destino.Location = New System.Drawing.Point(56, 45)
        Me.rtb_Destino.Multiline = False
        Me.rtb_Destino.Name = "rtb_Destino"
        Me.rtb_Destino.ReadOnly = True
        Me.rtb_Destino.Size = New System.Drawing.Size(291, 20)
        Me.rtb_Destino.TabIndex = 4
        Me.rtb_Destino.TabStop = False
        Me.rtb_Destino.Text = ""
        '
        'btn_Destino
        '
        Me.btn_Destino.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Destino.Location = New System.Drawing.Point(353, 43)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(26, 23)
        Me.btn_Destino.TabIndex = 5
        Me.btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Destino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Destino.UseVisualStyleBackColor = True
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
        Me.rtb_Archivo.Size = New System.Drawing.Size(291, 20)
        Me.rtb_Archivo.TabIndex = 1
        Me.rtb_Archivo.TabStop = False
        Me.rtb_Archivo.Text = ""
        '
        'gbx_TipoConversion
        '
        Me.gbx_TipoConversion.Controls.Add(Me.chk_pdf)
        Me.gbx_TipoConversion.Controls.Add(Me.chk_jpg)
        Me.gbx_TipoConversion.Controls.Add(Me.chk_png)
        Me.gbx_TipoConversion.Controls.Add(Me.chk_bmp)
        Me.gbx_TipoConversion.Controls.Add(Me.chk_tif)
        Me.gbx_TipoConversion.Enabled = False
        Me.gbx_TipoConversion.Location = New System.Drawing.Point(161, 82)
        Me.gbx_TipoConversion.Name = "gbx_TipoConversion"
        Me.gbx_TipoConversion.Size = New System.Drawing.Size(242, 92)
        Me.gbx_TipoConversion.TabIndex = 2
        Me.gbx_TipoConversion.TabStop = False
        Me.gbx_TipoConversion.Text = "Tipo de Conversiones"
        '
        'chk_pdf
        '
        Me.chk_pdf.AutoSize = True
        Me.chk_pdf.Location = New System.Drawing.Point(13, 22)
        Me.chk_pdf.Name = "chk_pdf"
        Me.chk_pdf.Size = New System.Drawing.Size(87, 17)
        Me.chk_pdf.TabIndex = 0
        Me.chk_pdf.Text = "Adobe ( pdf )"
        Me.chk_pdf.UseVisualStyleBackColor = True
        '
        'chk_jpg
        '
        Me.chk_jpg.AutoSize = True
        Me.chk_jpg.Location = New System.Drawing.Point(13, 45)
        Me.chk_jpg.Name = "chk_jpg"
        Me.chk_jpg.Size = New System.Drawing.Size(90, 17)
        Me.chk_jpg.TabIndex = 2
        Me.chk_jpg.Text = "Imagen ( jpg )"
        Me.chk_jpg.UseVisualStyleBackColor = True
        '
        'chk_png
        '
        Me.chk_png.AutoSize = True
        Me.chk_png.Location = New System.Drawing.Point(13, 68)
        Me.chk_png.Name = "chk_png"
        Me.chk_png.Size = New System.Drawing.Size(94, 17)
        Me.chk_png.TabIndex = 4
        Me.chk_png.Text = "Imagen ( png )"
        Me.chk_png.UseVisualStyleBackColor = True
        '
        'chk_bmp
        '
        Me.chk_bmp.AutoSize = True
        Me.chk_bmp.Location = New System.Drawing.Point(109, 22)
        Me.chk_bmp.Name = "chk_bmp"
        Me.chk_bmp.Size = New System.Drawing.Size(96, 17)
        Me.chk_bmp.TabIndex = 1
        Me.chk_bmp.Text = "Imagen ( bmp )"
        Me.chk_bmp.UseVisualStyleBackColor = True
        '
        'chk_tif
        '
        Me.chk_tif.AutoSize = True
        Me.chk_tif.Location = New System.Drawing.Point(109, 45)
        Me.chk_tif.Name = "chk_tif"
        Me.chk_tif.Size = New System.Drawing.Size(84, 17)
        Me.chk_tif.TabIndex = 3
        Me.chk_tif.Text = "Imagen ( tif )"
        Me.chk_tif.UseVisualStyleBackColor = True
        '
        'ofd_Archivo
        '
        Me.ofd_Archivo.FileName = "OpenFileDialog1"
        '
        'gbx_Programa
        '
        Me.gbx_Programa.Controls.Add(Me.rdb_PDFCreator)
        Me.gbx_Programa.Controls.Add(Me.rdb_Excel)
        Me.gbx_Programa.Location = New System.Drawing.Point(9, 82)
        Me.gbx_Programa.Name = "gbx_Programa"
        Me.gbx_Programa.Size = New System.Drawing.Size(146, 92)
        Me.gbx_Programa.TabIndex = 1
        Me.gbx_Programa.TabStop = False
        Me.gbx_Programa.Text = "Programa de Conversión"
        '
        'rdb_PDFCreator
        '
        Me.rdb_PDFCreator.AutoSize = True
        Me.rdb_PDFCreator.Enabled = False
        Me.rdb_PDFCreator.Location = New System.Drawing.Point(10, 55)
        Me.rdb_PDFCreator.Name = "rdb_PDFCreator"
        Me.rdb_PDFCreator.Size = New System.Drawing.Size(80, 17)
        Me.rdb_PDFCreator.TabIndex = 1
        Me.rdb_PDFCreator.TabStop = True
        Me.rdb_PDFCreator.Text = "PDFCreator"
        Me.rdb_PDFCreator.UseVisualStyleBackColor = True
        '
        'rdb_Excel
        '
        Me.rdb_Excel.AutoSize = True
        Me.rdb_Excel.Enabled = False
        Me.rdb_Excel.Location = New System.Drawing.Point(10, 27)
        Me.rdb_Excel.Name = "rdb_Excel"
        Me.rdb_Excel.Size = New System.Drawing.Size(51, 17)
        Me.rdb_Excel.TabIndex = 0
        Me.rdb_Excel.TabStop = True
        Me.rdb_Excel.Text = "Excel"
        Me.rdb_Excel.UseVisualStyleBackColor = True
        '
        'tmr_PDF
        '
        Me.tmr_PDF.Interval = 20000
        '
        'frm_ConvertirPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 231)
        Me.Controls.Add(Me.gbx_Programa)
        Me.Controls.Add(Me.gbx_TipoConversion)
        Me.Controls.Add(Me.gbx_Reportes)
        Me.Controls.Add(Me.gbx_Ubicacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 260)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 260)
        Me.Name = "frm_ConvertirPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertir Archivos Excel a PDF"
        Me.gbx_Reportes.ResumeLayout(False)
        Me.gbx_Ubicacion.ResumeLayout(False)
        Me.gbx_Ubicacion.PerformLayout()
        Me.gbx_TipoConversion.ResumeLayout(False)
        Me.gbx_TipoConversion.PerformLayout()
        Me.gbx_Programa.ResumeLayout(False)
        Me.gbx_Programa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Archivo As System.Windows.Forms.Button
    Friend WithEvents gbx_Reportes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Ubicacion As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Archivo As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_Destino As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents btn_Convertir As System.Windows.Forms.Button
    Friend WithEvents chk_tif As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bmp As System.Windows.Forms.CheckBox
    Friend WithEvents chk_png As System.Windows.Forms.CheckBox
    Friend WithEvents chk_jpg As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pdf As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_TipoConversion As System.Windows.Forms.GroupBox
    Friend WithEvents fbd_Destino As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofd_Archivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbx_Programa As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_PDFCreator As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Excel As System.Windows.Forms.RadioButton
    Friend WithEvents tmr_PDF As System.Windows.Forms.Timer
End Class
