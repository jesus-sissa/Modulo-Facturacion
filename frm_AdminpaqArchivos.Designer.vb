<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminpaqArchivos
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.prg_Barra = New System.Windows.Forms.ProgressBar
        Me.gbx_Origen = New System.Windows.Forms.GroupBox
        Me.btn_Examinar = New System.Windows.Forms.Button
        Me.tbx_Ruta = New System.Windows.Forms.RichTextBox
        Me.Gbx_Nota = New System.Windows.Forms.GroupBox
        Me.lbl_Nota = New System.Windows.Forms.Label
        Me.pct_Imagen = New System.Windows.Forms.PictureBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Copiar = New System.Windows.Forms.Button
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Origen.SuspendLayout()
        Me.Gbx_Nota.SuspendLayout()
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.prg_Barra)
        Me.Gbx_Botones.Controls.Add(Me.btn_Copiar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 180)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(527, 114)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'prg_Barra
        '
        Me.prg_Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prg_Barra.Location = New System.Drawing.Point(6, 73)
        Me.prg_Barra.Name = "prg_Barra"
        Me.prg_Barra.Size = New System.Drawing.Size(515, 25)
        Me.prg_Barra.Step = 1
        Me.prg_Barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prg_Barra.TabIndex = 2
        '
        'gbx_Origen
        '
        Me.gbx_Origen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Origen.Controls.Add(Me.btn_Examinar)
        Me.gbx_Origen.Controls.Add(Me.tbx_Ruta)
        Me.gbx_Origen.Location = New System.Drawing.Point(9, 124)
        Me.gbx_Origen.Name = "gbx_Origen"
        Me.gbx_Origen.Size = New System.Drawing.Size(527, 51)
        Me.gbx_Origen.TabIndex = 1
        Me.gbx_Origen.TabStop = False
        Me.gbx_Origen.Text = "Origen de los Archivos"
        '
        'btn_Examinar
        '
        Me.btn_Examinar.Location = New System.Drawing.Point(428, 19)
        Me.btn_Examinar.Name = "btn_Examinar"
        Me.btn_Examinar.Size = New System.Drawing.Size(82, 24)
        Me.btn_Examinar.TabIndex = 1
        Me.btn_Examinar.Text = "&Examinar"
        Me.btn_Examinar.UseVisualStyleBackColor = True
        '
        'tbx_Ruta
        '
        Me.tbx_Ruta.Location = New System.Drawing.Point(6, 19)
        Me.tbx_Ruta.Name = "tbx_Ruta"
        Me.tbx_Ruta.ReadOnly = True
        Me.tbx_Ruta.Size = New System.Drawing.Size(416, 24)
        Me.tbx_Ruta.TabIndex = 0
        Me.tbx_Ruta.Text = ""
        '
        'Gbx_Nota
        '
        Me.Gbx_Nota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Nota.Controls.Add(Me.lbl_Nota)
        Me.Gbx_Nota.Controls.Add(Me.pct_Imagen)
        Me.Gbx_Nota.Location = New System.Drawing.Point(9, 4)
        Me.Gbx_Nota.Name = "Gbx_Nota"
        Me.Gbx_Nota.Size = New System.Drawing.Size(527, 113)
        Me.Gbx_Nota.TabIndex = 0
        Me.Gbx_Nota.TabStop = False
        '
        'lbl_Nota
        '
        Me.lbl_Nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nota.Location = New System.Drawing.Point(109, 27)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(402, 72)
        Me.lbl_Nota.TabIndex = 0
        Me.lbl_Nota.Text = "NOTA: Esta tarea puede durar varios minutos dependiendo del tamaño y la cantidad " & _
            "de los archivos a respaldar y del tráfico en la red al momento de realizar el re" & _
            "spaldo."
        '
        'pct_Imagen
        '
        Me.pct_Imagen.Image = Global.Modulo_Facturacion.My.Resources.Resources.CopiarGrande2
        Me.pct_Imagen.Location = New System.Drawing.Point(6, 13)
        Me.pct_Imagen.Name = "pct_Imagen"
        Me.pct_Imagen.Size = New System.Drawing.Size(96, 94)
        Me.pct_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Imagen.TabIndex = 0
        Me.pct_Imagen.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(260, 17)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(250, 50)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Copiar
        '
        Me.btn_Copiar.Image = Global.Modulo_Facturacion.My.Resources.Resources.agt_reload
        Me.btn_Copiar.Location = New System.Drawing.Point(6, 17)
        Me.btn_Copiar.Name = "btn_Copiar"
        Me.btn_Copiar.Size = New System.Drawing.Size(250, 50)
        Me.btn_Copiar.TabIndex = 0
        Me.btn_Copiar.Text = "&Copiar Ahora"
        Me.btn_Copiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Copiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Copiar.UseVisualStyleBackColor = True
        '
        'frm_AdminpaqArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gbx_Nota)
        Me.Controls.Add(Me.gbx_Origen)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AdminpaqArchivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar/Actualizar Respaldo..."
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Origen.ResumeLayout(False)
        Me.Gbx_Nota.ResumeLayout(False)
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Copiar As System.Windows.Forms.Button
    Friend WithEvents prg_Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents gbx_Origen As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Examinar As System.Windows.Forms.Button
    Friend WithEvents tbx_Ruta As System.Windows.Forms.RichTextBox
    Friend WithEvents Gbx_Nota As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
