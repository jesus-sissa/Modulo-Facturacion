<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FichasMorralla_Consulta
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
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_FechaOperacionF = New System.Windows.Forms.DateTimePicker
        Me.cmb_CajaBancaria = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Grupo = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cliente = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.chk_Grupo = New System.Windows.Forms.CheckBox
        Me.lbl_GrupoCliente = New System.Windows.Forms.Label
        Me.cmb_Corte = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.dtp_FechaOperacionI = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaOperacion = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Fichas = New Modulo_Facturacion.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ExportarGrupos = New System.Windows.Forms.Button
        Me.btn_ExportarLista = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.Label2)
        Me.gbx_Filtro.Controls.Add(Me.dtp_FechaOperacionF)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.chk_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.lbl_GrupoCliente)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Corte)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Corte)
        Me.gbx_Filtro.Controls.Add(Me.dtp_FechaOperacionI)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaOperacion)
        Me.gbx_Filtro.Location = New System.Drawing.Point(1, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(902, 158)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'dtp_FechaOperacionF
        '
        Me.dtp_FechaOperacionF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaOperacionF.Location = New System.Drawing.Point(294, 19)
        Me.dtp_FechaOperacionF.Name = "dtp_FechaOperacionF"
        Me.dtp_FechaOperacionF.Size = New System.Drawing.Size(101, 20)
        Me.dtp_FechaOperacionF.TabIndex = 3
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = Nothing
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Grupo
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(136, 72)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 7
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.Clave = Nothing
        Me.cmb_Grupo.Control_Siguiente = Me.cmb_Cliente
        Me.cmb_Grupo.DisplayMember = "Descripcion"
        Me.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupo.Empresa = False
        Me.cmb_Grupo.Filtro = Nothing
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(136, 126)
        Me.cmb_Grupo.MaxDropDownItems = 20
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.Pista = False
        Me.cmb_Grupo.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Grupo.StoredProcedure = "Cat_ClientesGrupos_Get0"
        Me.cmb_Grupo.Sucursal = False
        Me.cmb_Grupo.TabIndex = 11
        Me.cmb_Grupo.Tipo = 0
        Me.cmb_Grupo.ValueMember = "Id_ClienteGrupo"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = Nothing
        Me.cmb_Cliente.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(136, 99)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "cat_ClientesProceso_GetPadres"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 9
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(620, 120)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 13
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(57, 75)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 6
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(60, 102)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Cliente.TabIndex = 8
        Me.lbl_Cliente.Text = "Cliente Padre"
        '
        'chk_Grupo
        '
        Me.chk_Grupo.AutoSize = True
        Me.chk_Grupo.Location = New System.Drawing.Point(542, 128)
        Me.chk_Grupo.Name = "chk_Grupo"
        Me.chk_Grupo.Size = New System.Drawing.Size(56, 17)
        Me.chk_Grupo.TabIndex = 12
        Me.chk_Grupo.Text = "Todos"
        Me.chk_Grupo.UseVisualStyleBackColor = True
        '
        'lbl_GrupoCliente
        '
        Me.lbl_GrupoCliente.AutoSize = True
        Me.lbl_GrupoCliente.Location = New System.Drawing.Point(94, 129)
        Me.lbl_GrupoCliente.Name = "lbl_GrupoCliente"
        Me.lbl_GrupoCliente.Size = New System.Drawing.Size(36, 13)
        Me.lbl_GrupoCliente.TabIndex = 10
        Me.lbl_GrupoCliente.Text = "Grupo"
        '
        'cmb_Corte
        '
        Me.cmb_Corte.Clave = Nothing
        Me.cmb_Corte.Control_Siguiente = Me.cmb_CajaBancaria
        Me.cmb_Corte.DisplayMember = "FechaOperacion"
        Me.cmb_Corte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corte.Empresa = False
        Me.cmb_Corte.Filtro = Nothing
        Me.cmb_Corte.FormattingEnabled = True
        Me.cmb_Corte.Location = New System.Drawing.Point(136, 45)
        Me.cmb_Corte.MaxDropDownItems = 20
        Me.cmb_Corte.Name = "cmb_Corte"
        Me.cmb_Corte.Pista = False
        Me.cmb_Corte.Size = New System.Drawing.Size(200, 21)
        Me.cmb_Corte.StoredProcedure = "Mor_FichasC_Get0"
        Me.cmb_Corte.Sucursal = False
        Me.cmb_Corte.TabIndex = 5
        Me.cmb_Corte.Tipo = 0
        Me.cmb_Corte.ValueMember = "Id_Cierre"
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(61, 48)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Corte.TabIndex = 4
        Me.lbl_Corte.Text = "Cierre Parcial"
        '
        'dtp_FechaOperacionI
        '
        Me.dtp_FechaOperacionI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaOperacionI.Location = New System.Drawing.Point(136, 19)
        Me.dtp_FechaOperacionI.Name = "dtp_FechaOperacionI"
        Me.dtp_FechaOperacionI.Size = New System.Drawing.Size(101, 20)
        Me.dtp_FechaOperacionI.TabIndex = 1
        '
        'lbl_FechaOperacion
        '
        Me.lbl_FechaOperacion.AutoSize = True
        Me.lbl_FechaOperacion.Location = New System.Drawing.Point(7, 23)
        Me.lbl_FechaOperacion.Name = "lbl_FechaOperacion"
        Me.lbl_FechaOperacion.Size = New System.Drawing.Size(123, 13)
        Me.lbl_FechaOperacion.TabIndex = 0
        Me.lbl_FechaOperacion.Text = "Fecha Operacion Desde"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.lsv_Fichas)
        Me.gbx_Datos.Location = New System.Drawing.Point(1, 161)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(901, 354)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(723, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(169, 17)
        Me.lbl_Registros.TabIndex = 4
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Fichas
        '
        Me.lsv_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Fichas.FullRowSelect = True
        Me.lsv_Fichas.HideSelection = False
        Me.lsv_Fichas.Location = New System.Drawing.Point(7, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Fichas.Lvs = ListViewColumnSorter1
        Me.lsv_Fichas.MultiSelect = False
        Me.lsv_Fichas.Name = "lsv_Fichas"
        Me.lsv_Fichas.Row1 = 10
        Me.lsv_Fichas.Row10 = 8
        Me.lsv_Fichas.Row2 = 8
        Me.lsv_Fichas.Row3 = 7
        Me.lsv_Fichas.Row4 = 8
        Me.lsv_Fichas.Row5 = 25
        Me.lsv_Fichas.Row6 = 6
        Me.lsv_Fichas.Row7 = 6
        Me.lsv_Fichas.Row8 = 8
        Me.lsv_Fichas.Row9 = 8
        Me.lsv_Fichas.Size = New System.Drawing.Size(885, 312)
        Me.lsv_Fichas.TabIndex = 0
        Me.lsv_Fichas.UseCompatibleStateImageBehavior = False
        Me.lsv_Fichas.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarGrupos)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarLista)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(2, 514)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(901, 50)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_ExportarGrupos
        '
        Me.btn_ExportarGrupos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarGrupos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_ExportarGrupos.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_ExportarGrupos.Location = New System.Drawing.Point(152, 14)
        Me.btn_ExportarGrupos.Name = "btn_ExportarGrupos"
        Me.btn_ExportarGrupos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarGrupos.TabIndex = 1
        Me.btn_ExportarGrupos.Text = "Exportar &Grupos"
        Me.btn_ExportarGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarGrupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarGrupos.UseVisualStyleBackColor = True
        '
        'btn_ExportarLista
        '
        Me.btn_ExportarLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarLista.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_ExportarLista.Image = Global.Modulo_Facturacion.My.Resources.Resources.Exportar
        Me.btn_ExportarLista.Location = New System.Drawing.Point(6, 14)
        Me.btn_ExportarLista.Name = "btn_ExportarLista"
        Me.btn_ExportarLista.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarLista.TabIndex = 0
        Me.btn_ExportarLista.Text = "Exportar &Lista"
        Me.btn_ExportarLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarLista.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(752, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_FichasMorralla_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 567)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.MinimizeBox = False
        Me.Name = "frm_FichasMorralla_Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Fichas de Morralla"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaOperacionI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaOperacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Corte As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents chk_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Grupo As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_GrupoCliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Cliente As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ExportarGrupos As System.Windows.Forms.Button
    Friend WithEvents btn_ExportarLista As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Fichas As Modulo_Facturacion.cp_Listview
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_CajaBancaria As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaOperacionF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
