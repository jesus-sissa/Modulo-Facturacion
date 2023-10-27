<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Remison_Digital
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
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_path = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Descargar = New System.Windows.Forms.Button()
        Me.tbx_numeroRemision = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRuta.ForeColor = System.Drawing.Color.Yellow
        Me.TxtRuta.Location = New System.Drawing.Point(42, 22)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(272, 22)
        Me.TxtRuta.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_path
        '
        Me.btn_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_path.Location = New System.Drawing.Point(318, 24)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(39, 20)
        Me.btn_path.TabIndex = 9
        Me.btn_path.Text = "***"
        Me.btn_path.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(181, 147)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(133, 39)
        Me.Btn_Salir.TabIndex = 13
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Descargar
        '
        Me.Btn_Descargar.Location = New System.Drawing.Point(42, 147)
        Me.Btn_Descargar.Name = "Btn_Descargar"
        Me.Btn_Descargar.Size = New System.Drawing.Size(133, 39)
        Me.Btn_Descargar.TabIndex = 12
        Me.Btn_Descargar.Text = "Descargar"
        Me.Btn_Descargar.UseVisualStyleBackColor = True
        '
        'tbx_numeroRemision
        '
        Me.tbx_numeroRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_numeroRemision.Location = New System.Drawing.Point(42, 93)
        Me.tbx_numeroRemision.Name = "tbx_numeroRemision"
        Me.tbx_numeroRemision.Size = New System.Drawing.Size(272, 38)
        Me.tbx_numeroRemision.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Numero Remision"
        '
        'frm_Remison_Digital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Descargar)
        Me.Controls.Add(Me.tbx_numeroRemision)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_path)
        Me.Name = "frm_Remison_Digital"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargar remisiones "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtRuta As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_path As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Descargar As Button
    Friend WithEvents tbx_numeroRemision As TextBox
    Friend WithEvents Label2 As Label
End Class
