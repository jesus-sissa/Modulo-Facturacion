<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BuscarCliente
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
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Facturacion.cp_Textbox
        Me.lsv_Clientes = New Modulo_Facturacion.cp_Listview
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(61, 12)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(448, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.AllowColumnReorder = True
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 70
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 20
        Me.lsv_Clientes.Row3 = 0
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(504, 364)
        Me.lsv_Clientes.TabIndex = 2
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(3, 405)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(353, 13)
        Me.Lbl_Nota.TabIndex = 3
        Me.Lbl_Nota.Text = "Doble Click para Seleccionar un Cliente y cerrar la ventana de búsqueda."
        '
        'Frm_BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 421)
        Me.Controls.Add(Me.Lbl_Nota)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lsv_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 450)
        Me.Name = "Frm_BuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Clientes As Modulo_Facturacion.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
End Class
