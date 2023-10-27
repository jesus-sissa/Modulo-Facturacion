<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Antilavado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Antilavado))
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.btn_Consultar = New System.Windows.Forms.Button
        Me.rdb_Dotaciones = New System.Windows.Forms.RadioButton
        Me.rdb_TrasladoCus = New System.Windows.Forms.RadioButton
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.rdb_Proceso = New System.Windows.Forms.RadioButton
        Me.Rdb_Traslado = New System.Windows.Forms.RadioButton
        Me.btn_Generar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.lbl_Inicio = New System.Windows.Forms.Label
        Me.pgb = New System.Windows.Forms.ProgressBar
        Me.gbx_Registros = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosG = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Txt = New System.Windows.Forms.GroupBox
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.btn_Origen = New System.Windows.Forms.Button
        Me.tbx_Destino = New System.Windows.Forms.TextBox
        Me.tbx_Origen = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Txt = New System.Windows.Forms.Button
        Me.Gbx_Datos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Registros.SuspendLayout()
        Me.gbx_Txt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.btn_Consultar)
        Me.Gbx_Datos.Controls.Add(Me.rdb_Dotaciones)
        Me.Gbx_Datos.Controls.Add(Me.rdb_TrasladoCus)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Desde)
        Me.Gbx_Datos.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Hasta)
        Me.Gbx_Datos.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Datos.Controls.Add(Me.rdb_Proceso)
        Me.Gbx_Datos.Controls.Add(Me.Rdb_Traslado)
        Me.Gbx_Datos.Location = New System.Drawing.Point(6, 5)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(464, 166)
        Me.Gbx_Datos.TabIndex = 0
        Me.Gbx_Datos.TabStop = False
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Consultar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_Consultar.Location = New System.Drawing.Point(316, 127)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Consultar.TabIndex = 8
        Me.btn_Consultar.Text = "1 : &Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Consultar.UseVisualStyleBackColor = False
        '
        'rdb_Dotaciones
        '
        Me.rdb_Dotaciones.AutoSize = True
        Me.rdb_Dotaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Dotaciones.Location = New System.Drawing.Point(22, 100)
        Me.rdb_Dotaciones.Name = "rdb_Dotaciones"
        Me.rdb_Dotaciones.Size = New System.Drawing.Size(296, 21)
        Me.rdb_Dotaciones.TabIndex = 3
        Me.rdb_Dotaciones.TabStop = True
        Me.rdb_Dotaciones.Text = "Solo Dotaciones (Salidas de Bóveda)"
        Me.rdb_Dotaciones.UseVisualStyleBackColor = True
        '
        'rdb_TrasladoCus
        '
        Me.rdb_TrasladoCus.AutoSize = True
        Me.rdb_TrasladoCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_TrasladoCus.Location = New System.Drawing.Point(22, 44)
        Me.rdb_TrasladoCus.Name = "rdb_TrasladoCus"
        Me.rdb_TrasladoCus.Size = New System.Drawing.Size(171, 21)
        Me.rdb_TrasladoCus.TabIndex = 1
        Me.rdb_TrasladoCus.TabStop = True
        Me.rdb_TrasladoCus.Text = "Traslado y Custodia"
        Me.rdb_TrasladoCus.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(19, 136)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 4
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(63, 134)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 5
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(173, 136)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 6
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(214, 134)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 7
        '
        'rdb_Proceso
        '
        Me.rdb_Proceso.AutoSize = True
        Me.rdb_Proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Proceso.Location = New System.Drawing.Point(22, 72)
        Me.rdb_Proceso.Name = "rdb_Proceso"
        Me.rdb_Proceso.Size = New System.Drawing.Size(167, 21)
        Me.rdb_Proceso.TabIndex = 2
        Me.rdb_Proceso.TabStop = True
        Me.rdb_Proceso.Text = "Traslado y Proceso"
        Me.rdb_Proceso.UseVisualStyleBackColor = True
        '
        'Rdb_Traslado
        '
        Me.Rdb_Traslado.AutoSize = True
        Me.Rdb_Traslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Traslado.Location = New System.Drawing.Point(22, 16)
        Me.Rdb_Traslado.Name = "Rdb_Traslado"
        Me.Rdb_Traslado.Size = New System.Drawing.Size(127, 21)
        Me.Rdb_Traslado.TabIndex = 0
        Me.Rdb_Traslado.TabStop = True
        Me.Rdb_Traslado.Text = "Solo Traslado"
        Me.Rdb_Traslado.UseVisualStyleBackColor = True
        '
        'btn_Generar
        '
        Me.btn_Generar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Generar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_Generar.Enabled = False
        Me.btn_Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Generar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Generar.Location = New System.Drawing.Point(12, 75)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(443, 30)
        Me.btn_Generar.TabIndex = 1
        Me.btn_Generar.Text = "2 : &Generar Hoja de Excel"
        Me.btn_Generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Generar.UseVisualStyleBackColor = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(18, 531)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(443, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.lbl_Inicio)
        Me.gbx_Botones.Controls.Add(Me.btn_Generar)
        Me.gbx_Botones.Controls.Add(Me.pgb)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 219)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(464, 113)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'lbl_Inicio
        '
        Me.lbl_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Inicio.Location = New System.Drawing.Point(9, 46)
        Me.lbl_Inicio.Name = "lbl_Inicio"
        Me.lbl_Inicio.Size = New System.Drawing.Size(237, 20)
        Me.lbl_Inicio.TabIndex = 2
        Me.lbl_Inicio.Text = "Hr. Inicio:"
        '
        'pgb
        '
        Me.pgb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgb.Location = New System.Drawing.Point(12, 12)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(443, 23)
        Me.pgb.TabIndex = 0
        '
        'gbx_Registros
        '
        Me.gbx_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Registros.Controls.Add(Me.lbl_RegistrosG)
        Me.gbx_Registros.Controls.Add(Me.lbl_Registros)
        Me.gbx_Registros.Location = New System.Drawing.Point(6, 173)
        Me.gbx_Registros.Name = "gbx_Registros"
        Me.gbx_Registros.Size = New System.Drawing.Size(464, 44)
        Me.gbx_Registros.TabIndex = 1
        Me.gbx_Registros.TabStop = False
        '
        'lbl_RegistrosG
        '
        Me.lbl_RegistrosG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosG.Location = New System.Drawing.Point(235, 16)
        Me.lbl_RegistrosG.Name = "lbl_RegistrosG"
        Me.lbl_RegistrosG.Size = New System.Drawing.Size(220, 20)
        Me.lbl_RegistrosG.TabIndex = 1
        Me.lbl_RegistrosG.Text = "0 Registros Exportados"
        Me.lbl_RegistrosG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(6, 15)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(229, 20)
        Me.lbl_Registros.TabIndex = 0
        Me.lbl_Registros.Text = "0 Registros Encontrados"
        '
        'gbx_Txt
        '
        Me.gbx_Txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Txt.Controls.Add(Me.btn_Destino)
        Me.gbx_Txt.Controls.Add(Me.btn_Origen)
        Me.gbx_Txt.Controls.Add(Me.tbx_Destino)
        Me.gbx_Txt.Controls.Add(Me.tbx_Origen)
        Me.gbx_Txt.Controls.Add(Me.Label1)
        Me.gbx_Txt.Controls.Add(Me.btn_Txt)
        Me.gbx_Txt.Location = New System.Drawing.Point(6, 333)
        Me.gbx_Txt.Name = "gbx_Txt"
        Me.gbx_Txt.Size = New System.Drawing.Size(464, 192)
        Me.gbx_Txt.TabIndex = 3
        Me.gbx_Txt.TabStop = False
        '
        'btn_Destino
        '
        Me.btn_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Destino.Location = New System.Drawing.Point(12, 95)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(80, 26)
        Me.btn_Destino.TabIndex = 3
        Me.btn_Destino.Text = "Destino..."
        Me.btn_Destino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Destino.UseVisualStyleBackColor = True
        '
        'btn_Origen
        '
        Me.btn_Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Origen.Location = New System.Drawing.Point(12, 37)
        Me.btn_Origen.Name = "btn_Origen"
        Me.btn_Origen.Size = New System.Drawing.Size(80, 26)
        Me.btn_Origen.TabIndex = 1
        Me.btn_Origen.Text = "Origen..."
        Me.btn_Origen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Origen.UseVisualStyleBackColor = True
        '
        'tbx_Destino
        '
        Me.tbx_Destino.Location = New System.Drawing.Point(12, 130)
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.ReadOnly = True
        Me.tbx_Destino.Size = New System.Drawing.Size(443, 20)
        Me.tbx_Destino.TabIndex = 4
        '
        'tbx_Origen
        '
        Me.tbx_Origen.Location = New System.Drawing.Point(12, 71)
        Me.tbx_Origen.Name = "tbx_Origen"
        Me.tbx_Origen.ReadOnly = True
        Me.tbx_Origen.Size = New System.Drawing.Size(443, 20)
        Me.tbx_Origen.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convertir Hoja de Excel en Archivo TXT separado por ""|"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Txt
        '
        Me.btn_Txt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_Txt.Enabled = False
        Me.btn_Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Txt.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_Txt.Location = New System.Drawing.Point(12, 154)
        Me.btn_Txt.Name = "btn_Txt"
        Me.btn_Txt.Size = New System.Drawing.Size(443, 30)
        Me.btn_Txt.TabIndex = 5
        Me.btn_Txt.Text = "3: Generar &Archivo TXT"
        Me.btn_Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Txt.UseVisualStyleBackColor = False
        '
        'frm_Antilavado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 568)
        Me.Controls.Add(Me.gbx_Txt)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.gbx_Registros)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Antilavado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimiento de Información Ley Antilavado"
        Me.Gbx_Datos.ResumeLayout(False)
        Me.Gbx_Datos.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Registros.ResumeLayout(False)
        Me.gbx_Txt.ResumeLayout(False)
        Me.gbx_Txt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Proceso As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Traslado As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Generar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents pgb As System.Windows.Forms.ProgressBar
    Friend WithEvents gbx_Registros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosG As System.Windows.Forms.Label
    Friend WithEvents rdb_TrasladoCus As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Txt As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Txt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents btn_Origen As System.Windows.Forms.Button
    Friend WithEvents tbx_Destino As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Origen As System.Windows.Forms.TextBox
    Friend WithEvents rdb_Dotaciones As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents lbl_Inicio As System.Windows.Forms.Label
End Class
