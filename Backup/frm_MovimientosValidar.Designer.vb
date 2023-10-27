<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MovimientosValidar
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
        Dim ListViewColumnSorter4 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter
        Me.Lbl_NumeroRemision = New System.Windows.Forms.Label
        Me.gbx_Movimientos = New System.Windows.Forms.GroupBox
        Me.Lbl_CantidadKM = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.Lbl_Kilometraje = New System.Windows.Forms.Label
        Me.Lbl_CoutaRiesgo = New System.Windows.Forms.Label
        Me.Lbl_Precio = New System.Windows.Forms.Label
        Me.Lbl_Hora2 = New System.Windows.Forms.Label
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.Lbl_ServiciosCliente = New System.Windows.Forms.Label
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.Lbl_Ruta = New System.Windows.Forms.Label
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.lbl_Origen = New System.Windows.Forms.Label
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.btn_BuscaRemision = New System.Windows.Forms.Button
        Me.Lbl_LocRemision = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.lbl_ImporteProcesado = New System.Windows.Forms.Label
        Me.Lbl_DiceContener = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_RemisionesD = New System.Windows.Forms.GroupBox
        Me.lbl_Sobres = New System.Windows.Forms.Label
        Me.gbx_Tipo2 = New System.Windows.Forms.GroupBox
        Me.rdb_PagoMorralla = New System.Windows.Forms.RadioButton
        Me.rdb_NominaProcesada = New System.Windows.Forms.RadioButton
        Me.rdb_PagoNomina = New System.Windows.Forms.RadioButton
        Me.gbx_Tipo = New System.Windows.Forms.GroupBox
        Me.rdb_DotacionMorralla = New System.Windows.Forms.RadioButton
        Me.rdb_DotacionBillete = New System.Windows.Forms.RadioButton
        Me.btn_AgregarE = New System.Windows.Forms.Button
        Me.btn_EliminarE = New System.Windows.Forms.Button
        Me.Lbl_Tipo = New System.Windows.Forms.Label
        Me.Lbl_NoEnvase = New System.Windows.Forms.Label
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_ValidarServicio = New System.Windows.Forms.Button
        Me.btn_ValidarRemision = New System.Windows.Forms.Button
        Me.dgv_Importes = New System.Windows.Forms.DataGridView
        Me.Lbl_EnvasesSN = New System.Windows.Forms.Label
        Me.Lbl_HoraRem = New System.Windows.Forms.Label
        Me.tbx_Sobres = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Destino = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Origen = New Modulo_Facturacion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Envase = New Modulo_Facturacion.cp_Textbox
        Me.tbx_HoraR = New Modulo_Facturacion.cp_Textbox
        Me.lsv_Envases = New Modulo_Facturacion.cp_Listview
        Me.tbx_EnvasesSN = New Modulo_Facturacion.cp_Textbox
        Me.tbx_ImporteProcesado = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Total = New Modulo_Facturacion.cp_Textbox
        Me.tbx_BuscaRemision = New Modulo_Facturacion.cp_Textbox
        Me.lsv_Remisiones = New Modulo_Facturacion.cp_Listview
        Me.tbx_CantidadKM = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Numero = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Descripcion = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Hora = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Ruta = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Kilometraje = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Cuota = New Modulo_Facturacion.cp_Textbox
        Me.tbx_Cliente = New Modulo_Facturacion.cp_Textbox
        Me.cmb_Ruta = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cliente = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Kilometraje = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Precio = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cuota = New Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
        Me.lsv_Precios = New Modulo_Facturacion.cp_Listview
        Me.lsv_Datos = New Modulo_Facturacion.cp_Listview
        Me.gbx_Movimientos.SuspendLayout()
        Me.gbx_Remisiones.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_RemisionesD.SuspendLayout()
        Me.gbx_Tipo2.SuspendLayout()
        Me.gbx_Tipo.SuspendLayout()
        CType(Me.dgv_Importes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_NumeroRemision
        '
        Me.Lbl_NumeroRemision.AutoSize = True
        Me.Lbl_NumeroRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NumeroRemision.Location = New System.Drawing.Point(18, 15)
        Me.Lbl_NumeroRemision.Name = "Lbl_NumeroRemision"
        Me.Lbl_NumeroRemision.Size = New System.Drawing.Size(188, 17)
        Me.Lbl_NumeroRemision.TabIndex = 0
        Me.Lbl_NumeroRemision.Text = "Número de Remisión(F1)"
        '
        'gbx_Movimientos
        '
        Me.gbx_Movimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_CantidadKM)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_CantidadKM)
        Me.gbx_Movimientos.Controls.Add(Me.btn_Buscar)
        Me.gbx_Movimientos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Movimientos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Numero)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_NumeroRemision)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Fecha)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Hora)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Ruta)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Cuota)
        Me.gbx_Movimientos.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Ruta)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Precio)
        Me.gbx_Movimientos.Controls.Add(Me.cmb_Cuota)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Kilometraje)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_CoutaRiesgo)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Precio)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Hora2)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Hora)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_ServiciosCliente)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Cliente)
        Me.gbx_Movimientos.Controls.Add(Me.Lbl_Ruta)
        Me.gbx_Movimientos.Controls.Add(Me.lsv_Precios)
        Me.gbx_Movimientos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Movimientos.Location = New System.Drawing.Point(4, 0)
        Me.gbx_Movimientos.Name = "gbx_Movimientos"
        Me.gbx_Movimientos.Size = New System.Drawing.Size(926, 286)
        Me.gbx_Movimientos.TabIndex = 0
        Me.gbx_Movimientos.TabStop = False
        '
        'Lbl_CantidadKM
        '
        Me.Lbl_CantidadKM.AutoSize = True
        Me.Lbl_CantidadKM.Location = New System.Drawing.Point(36, 211)
        Me.Lbl_CantidadKM.Name = "Lbl_CantidadKM"
        Me.Lbl_CantidadKM.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_CantidadKM.TabIndex = 29
        Me.Lbl_CantidadKM.Text = "Cantidad KM"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(642, 115)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(25, 23)
        Me.btn_Buscar.TabIndex = 7
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(371, 8)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(40, 30)
        Me.btn_Mostrar.TabIndex = 2
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(106, 255)
        Me.dtp_Fecha.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Fecha.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 26
        Me.dtp_Fecha.Value = New Date(2009, 11, 23, 0, 0, 0, 0)
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(67, 258)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 25
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Lbl_Kilometraje
        '
        Me.Lbl_Kilometraje.AutoSize = True
        Me.Lbl_Kilometraje.Location = New System.Drawing.Point(46, 188)
        Me.Lbl_Kilometraje.Name = "Lbl_Kilometraje"
        Me.Lbl_Kilometraje.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_Kilometraje.TabIndex = 19
        Me.Lbl_Kilometraje.Text = "Kilometraje"
        '
        'Lbl_CoutaRiesgo
        '
        Me.Lbl_CoutaRiesgo.AutoSize = True
        Me.Lbl_CoutaRiesgo.Location = New System.Drawing.Point(18, 165)
        Me.Lbl_CoutaRiesgo.Name = "Lbl_CoutaRiesgo"
        Me.Lbl_CoutaRiesgo.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_CoutaRiesgo.TabIndex = 13
        Me.Lbl_CoutaRiesgo.Text = "Cuota de Riesgo"
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.Location = New System.Drawing.Point(67, 143)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Precio.TabIndex = 8
        Me.Lbl_Precio.Text = "Precio"
        '
        'Lbl_Hora2
        '
        Me.Lbl_Hora2.AutoSize = True
        Me.Lbl_Hora2.Location = New System.Drawing.Point(395, 261)
        Me.Lbl_Hora2.Name = "Lbl_Hora2"
        Me.Lbl_Hora2.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_Hora2.TabIndex = 27
        Me.Lbl_Hora2.Text = "(Hora del Servicio)"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(207, 258)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(127, 13)
        Me.Lbl_Hora.TabIndex = 27
        Me.Lbl_Hora.Text = "Hora Entrega/Recepción"
        '
        'Lbl_ServiciosCliente
        '
        Me.Lbl_ServiciosCliente.AutoSize = True
        Me.Lbl_ServiciosCliente.Location = New System.Drawing.Point(673, 113)
        Me.Lbl_ServiciosCliente.Name = "Lbl_ServiciosCliente"
        Me.Lbl_ServiciosCliente.Size = New System.Drawing.Size(177, 13)
        Me.Lbl_ServiciosCliente.TabIndex = 11
        Me.Lbl_ServiciosCliente.Text = "Servicios Contratados por el Cliente."
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(65, 119)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 4
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Location = New System.Drawing.Point(74, 235)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Ruta.TabIndex = 22
        Me.Lbl_Ruta.Text = "Ruta"
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(654, 180)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 22
        Me.lbl_Destino.Text = "Destino"
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(659, 145)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Origen.TabIndex = 22
        Me.lbl_Origen.Text = "Origen"
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.btn_BuscaRemision)
        Me.gbx_Remisiones.Controls.Add(Me.tbx_BuscaRemision)
        Me.gbx_Remisiones.Controls.Add(Me.Lbl_LocRemision)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(4, 292)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(926, 102)
        Me.gbx_Remisiones.TabIndex = 1
        Me.gbx_Remisiones.TabStop = False
        '
        'btn_BuscaRemision
        '
        Me.btn_BuscaRemision.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow
        Me.btn_BuscaRemision.Location = New System.Drawing.Point(250, 9)
        Me.btn_BuscaRemision.Name = "btn_BuscaRemision"
        Me.btn_BuscaRemision.Size = New System.Drawing.Size(30, 20)
        Me.btn_BuscaRemision.TabIndex = 9
        Me.btn_BuscaRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscaRemision.UseVisualStyleBackColor = True
        '
        'Lbl_LocRemision
        '
        Me.Lbl_LocRemision.AutoSize = True
        Me.Lbl_LocRemision.Location = New System.Drawing.Point(9, 12)
        Me.Lbl_LocRemision.Name = "Lbl_LocRemision"
        Me.Lbl_LocRemision.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_LocRemision.TabIndex = 7
        Me.Lbl_LocRemision.Text = "Localizar Remisión"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.tbx_ImporteProcesado)
        Me.Gbx_Botones.Controls.Add(Me.lbl_ImporteProcesado)
        Me.Gbx_Botones.Controls.Add(Me.tbx_Total)
        Me.Gbx_Botones.Controls.Add(Me.Lbl_DiceContener)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 607)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(926, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'lbl_ImporteProcesado
        '
        Me.lbl_ImporteProcesado.AutoSize = True
        Me.lbl_ImporteProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ImporteProcesado.Location = New System.Drawing.Point(314, 18)
        Me.lbl_ImporteProcesado.Name = "lbl_ImporteProcesado"
        Me.lbl_ImporteProcesado.Size = New System.Drawing.Size(144, 17)
        Me.lbl_ImporteProcesado.TabIndex = 0
        Me.lbl_ImporteProcesado.Text = "Importe Procesado"
        '
        'Lbl_DiceContener
        '
        Me.Lbl_DiceContener.AutoSize = True
        Me.Lbl_DiceContener.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DiceContener.Location = New System.Drawing.Point(27, 19)
        Me.Lbl_DiceContener.Name = "Lbl_DiceContener"
        Me.Lbl_DiceContener.Size = New System.Drawing.Size(111, 17)
        Me.Lbl_DiceContener.TabIndex = 0
        Me.Lbl_DiceContener.Text = "Dice Contener"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(780, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar ESC"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_RemisionesD
        '
        Me.gbx_RemisionesD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_Sobres)
        Me.gbx_RemisionesD.Controls.Add(Me.lbl_Sobres)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_Destino)
        Me.gbx_RemisionesD.Controls.Add(Me.gbx_Tipo2)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_Origen)
        Me.gbx_RemisionesD.Controls.Add(Me.gbx_Tipo)
        Me.gbx_RemisionesD.Controls.Add(Me.cmb_TipoEnvase)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_EliminarE)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_AgregarE)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_Envase)
        Me.gbx_RemisionesD.Controls.Add(Me.Lbl_Tipo)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_HoraR)
        Me.gbx_RemisionesD.Controls.Add(Me.Lbl_NoEnvase)
        Me.gbx_RemisionesD.Controls.Add(Me.lsv_Envases)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_Eliminar)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_Agregar)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_ValidarServicio)
        Me.gbx_RemisionesD.Controls.Add(Me.btn_ValidarRemision)
        Me.gbx_RemisionesD.Controls.Add(Me.tbx_EnvasesSN)
        Me.gbx_RemisionesD.Controls.Add(Me.dgv_Importes)
        Me.gbx_RemisionesD.Controls.Add(Me.Lbl_EnvasesSN)
        Me.gbx_RemisionesD.Controls.Add(Me.Lbl_HoraRem)
        Me.gbx_RemisionesD.Controls.Add(Me.lbl_Origen)
        Me.gbx_RemisionesD.Controls.Add(Me.lbl_Destino)
        Me.gbx_RemisionesD.Location = New System.Drawing.Point(4, 394)
        Me.gbx_RemisionesD.Name = "gbx_RemisionesD"
        Me.gbx_RemisionesD.Size = New System.Drawing.Size(926, 214)
        Me.gbx_RemisionesD.TabIndex = 2
        Me.gbx_RemisionesD.TabStop = False
        '
        'lbl_Sobres
        '
        Me.lbl_Sobres.AutoSize = True
        Me.lbl_Sobres.Enabled = False
        Me.lbl_Sobres.Location = New System.Drawing.Point(490, 192)
        Me.lbl_Sobres.Name = "lbl_Sobres"
        Me.lbl_Sobres.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Sobres.TabIndex = 30
        Me.lbl_Sobres.Text = "Cantidad de Sobres"
        '
        'gbx_Tipo2
        '
        Me.gbx_Tipo2.Controls.Add(Me.rdb_PagoMorralla)
        Me.gbx_Tipo2.Controls.Add(Me.rdb_NominaProcesada)
        Me.gbx_Tipo2.Controls.Add(Me.rdb_PagoNomina)
        Me.gbx_Tipo2.Location = New System.Drawing.Point(657, 55)
        Me.gbx_Tipo2.Name = "gbx_Tipo2"
        Me.gbx_Tipo2.Size = New System.Drawing.Size(116, 82)
        Me.gbx_Tipo2.TabIndex = 15
        Me.gbx_Tipo2.TabStop = False
        '
        'rdb_PagoMorralla
        '
        Me.rdb_PagoMorralla.AutoSize = True
        Me.rdb_PagoMorralla.Location = New System.Drawing.Point(7, 11)
        Me.rdb_PagoMorralla.Name = "rdb_PagoMorralla"
        Me.rdb_PagoMorralla.Size = New System.Drawing.Size(105, 17)
        Me.rdb_PagoMorralla.TabIndex = 1
        Me.rdb_PagoMorralla.TabStop = True
        Me.rdb_PagoMorralla.Text = "Pago de Morralla"
        Me.rdb_PagoMorralla.UseVisualStyleBackColor = True
        '
        'rdb_NominaProcesada
        '
        Me.rdb_NominaProcesada.Location = New System.Drawing.Point(8, 48)
        Me.rdb_NominaProcesada.Name = "rdb_NominaProcesada"
        Me.rdb_NominaProcesada.Size = New System.Drawing.Size(104, 30)
        Me.rdb_NominaProcesada.TabIndex = 1
        Me.rdb_NominaProcesada.TabStop = True
        Me.rdb_NominaProcesada.Text = "Entrega Nómina Procesada"
        Me.rdb_NominaProcesada.UseVisualStyleBackColor = True
        '
        'rdb_PagoNomina
        '
        Me.rdb_PagoNomina.AutoSize = True
        Me.rdb_PagoNomina.Location = New System.Drawing.Point(7, 30)
        Me.rdb_PagoNomina.Name = "rdb_PagoNomina"
        Me.rdb_PagoNomina.Size = New System.Drawing.Size(104, 17)
        Me.rdb_PagoNomina.TabIndex = 1
        Me.rdb_PagoNomina.TabStop = True
        Me.rdb_PagoNomina.Text = "Pago de Nómina"
        Me.rdb_PagoNomina.UseVisualStyleBackColor = True
        '
        'gbx_Tipo
        '
        Me.gbx_Tipo.Controls.Add(Me.rdb_DotacionMorralla)
        Me.gbx_Tipo.Controls.Add(Me.rdb_DotacionBillete)
        Me.gbx_Tipo.Enabled = False
        Me.gbx_Tipo.Location = New System.Drawing.Point(657, 7)
        Me.gbx_Tipo.Name = "gbx_Tipo"
        Me.gbx_Tipo.Size = New System.Drawing.Size(116, 48)
        Me.gbx_Tipo.TabIndex = 14
        Me.gbx_Tipo.TabStop = False
        '
        'rdb_DotacionMorralla
        '
        Me.rdb_DotacionMorralla.AutoSize = True
        Me.rdb_DotacionMorralla.Location = New System.Drawing.Point(6, 27)
        Me.rdb_DotacionMorralla.Name = "rdb_DotacionMorralla"
        Me.rdb_DotacionMorralla.Size = New System.Drawing.Size(108, 17)
        Me.rdb_DotacionMorralla.TabIndex = 1
        Me.rdb_DotacionMorralla.TabStop = True
        Me.rdb_DotacionMorralla.Text = "Dotación Morralla"
        Me.rdb_DotacionMorralla.UseVisualStyleBackColor = True
        '
        'rdb_DotacionBillete
        '
        Me.rdb_DotacionBillete.AutoSize = True
        Me.rdb_DotacionBillete.Location = New System.Drawing.Point(6, 9)
        Me.rdb_DotacionBillete.Name = "rdb_DotacionBillete"
        Me.rdb_DotacionBillete.Size = New System.Drawing.Size(99, 17)
        Me.rdb_DotacionBillete.TabIndex = 1
        Me.rdb_DotacionBillete.TabStop = True
        Me.rdb_DotacionBillete.Text = "Dotación Billete"
        Me.rdb_DotacionBillete.UseVisualStyleBackColor = True
        '
        'btn_AgregarE
        '
        Me.btn_AgregarE.Image = Global.Modulo_Facturacion.My.Resources.Resources.Agregar
        Me.btn_AgregarE.Location = New System.Drawing.Point(577, 34)
        Me.btn_AgregarE.Name = "btn_AgregarE"
        Me.btn_AgregarE.Size = New System.Drawing.Size(30, 30)
        Me.btn_AgregarE.TabIndex = 6
        Me.btn_AgregarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarE.UseVisualStyleBackColor = True
        '
        'btn_EliminarE
        '
        Me.btn_EliminarE.Enabled = False
        Me.btn_EliminarE.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_EliminarE.Location = New System.Drawing.Point(614, 34)
        Me.btn_EliminarE.Name = "btn_EliminarE"
        Me.btn_EliminarE.Size = New System.Drawing.Size(30, 30)
        Me.btn_EliminarE.TabIndex = 7
        Me.btn_EliminarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EliminarE.UseVisualStyleBackColor = True
        '
        'Lbl_Tipo
        '
        Me.Lbl_Tipo.AutoSize = True
        Me.Lbl_Tipo.Location = New System.Drawing.Point(417, 20)
        Me.Lbl_Tipo.Name = "Lbl_Tipo"
        Me.Lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_Tipo.TabIndex = 2
        Me.Lbl_Tipo.Text = "Tipo"
        '
        'Lbl_NoEnvase
        '
        Me.Lbl_NoEnvase.AutoSize = True
        Me.Lbl_NoEnvase.Location = New System.Drawing.Point(387, 40)
        Me.Lbl_NoEnvase.Name = "Lbl_NoEnvase"
        Me.Lbl_NoEnvase.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_NoEnvase.TabIndex = 4
        Me.Lbl_NoEnvase.Text = "No. Envase"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(776, 76)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 13
        Me.btn_Eliminar.Text = "&Eliminar Remisión F4"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Facturacion.My.Resources.Resources.editcopy
        Me.btn_Agregar.Location = New System.Drawing.Point(776, 44)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "&Agregar Remisión F3"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_ValidarServicio
        '
        Me.btn_ValidarServicio.Enabled = False
        Me.btn_ValidarServicio.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_ValidarServicio.Location = New System.Drawing.Point(776, 108)
        Me.btn_ValidarServicio.Name = "btn_ValidarServicio"
        Me.btn_ValidarServicio.Size = New System.Drawing.Size(140, 30)
        Me.btn_ValidarServicio.TabIndex = 0
        Me.btn_ValidarServicio.Text = "Validar &Servicio F5"
        Me.btn_ValidarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ValidarServicio.UseVisualStyleBackColor = True
        '
        'btn_ValidarRemision
        '
        Me.btn_ValidarRemision.Enabled = False
        Me.btn_ValidarRemision.Image = Global.Modulo_Facturacion.My.Resources.Resources.Guardar
        Me.btn_ValidarRemision.Location = New System.Drawing.Point(776, 12)
        Me.btn_ValidarRemision.Name = "btn_ValidarRemision"
        Me.btn_ValidarRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_ValidarRemision.TabIndex = 11
        Me.btn_ValidarRemision.Text = "&Validar Remisión F2"
        Me.btn_ValidarRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidarRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ValidarRemision.UseVisualStyleBackColor = True
        '
        'dgv_Importes
        '
        Me.dgv_Importes.AllowUserToResizeRows = False
        Me.dgv_Importes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_Importes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Importes.Location = New System.Drawing.Point(6, 13)
        Me.dgv_Importes.Name = "dgv_Importes"
        Me.dgv_Importes.Size = New System.Drawing.Size(373, 194)
        Me.dgv_Importes.TabIndex = 0
        '
        'Lbl_EnvasesSN
        '
        Me.Lbl_EnvasesSN.AutoSize = True
        Me.Lbl_EnvasesSN.Location = New System.Drawing.Point(381, 169)
        Me.Lbl_EnvasesSN.Name = "Lbl_EnvasesSN"
        Me.Lbl_EnvasesSN.Size = New System.Drawing.Size(85, 13)
        Me.Lbl_EnvasesSN.TabIndex = 9
        Me.Lbl_EnvasesSN.Text = "Envases S/Num"
        '
        'Lbl_HoraRem
        '
        Me.Lbl_HoraRem.AutoSize = True
        Me.Lbl_HoraRem.Location = New System.Drawing.Point(519, 169)
        Me.Lbl_HoraRem.Name = "Lbl_HoraRem"
        Me.Lbl_HoraRem.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_HoraRem.TabIndex = 27
        Me.Lbl_HoraRem.Text = "Hora Remisión"
        '
        'tbx_Sobres
        '
        Me.tbx_Sobres.Control_Siguiente = Nothing
        Me.tbx_Sobres.Enabled = False
        Me.tbx_Sobres.Filtrado = True
        Me.tbx_Sobres.Location = New System.Drawing.Point(596, 189)
        Me.tbx_Sobres.MaxLength = 5
        Me.tbx_Sobres.Name = "tbx_Sobres"
        Me.tbx_Sobres.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Sobres.TabIndex = 31
        Me.tbx_Sobres.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Destino
        '
        Me.tbx_Destino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Destino.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Destino.Control_Siguiente = Nothing
        Me.tbx_Destino.Filtrado = True
        Me.tbx_Destino.Location = New System.Drawing.Point(703, 177)
        Me.tbx_Destino.MaxLength = 50
        Me.tbx_Destino.Multiline = True
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.ReadOnly = True
        Me.tbx_Destino.Size = New System.Drawing.Size(217, 33)
        Me.tbx_Destino.TabIndex = 29
        Me.tbx_Destino.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Origen
        '
        Me.tbx_Origen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Origen.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Origen.Control_Siguiente = Nothing
        Me.tbx_Origen.Filtrado = True
        Me.tbx_Origen.Location = New System.Drawing.Point(703, 142)
        Me.tbx_Origen.MaxLength = 50
        Me.tbx_Origen.Multiline = True
        Me.tbx_Origen.Name = "tbx_Origen"
        Me.tbx_Origen.ReadOnly = True
        Me.tbx_Origen.Size = New System.Drawing.Size(217, 33)
        Me.tbx_Origen.TabIndex = 29
        Me.tbx_Origen.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_TipoEnvase
        '
        Me.cmb_TipoEnvase.Clave = Nothing
        Me.cmb_TipoEnvase.Control_Siguiente = Me.tbx_Envase
        Me.cmb_TipoEnvase.DisplayMember = "Descripcion"
        Me.cmb_TipoEnvase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEnvase.Empresa = False
        Me.cmb_TipoEnvase.Filtro = Nothing
        Me.cmb_TipoEnvase.FormattingEnabled = True
        Me.cmb_TipoEnvase.Location = New System.Drawing.Point(451, 12)
        Me.cmb_TipoEnvase.Name = "cmb_TipoEnvase"
        Me.cmb_TipoEnvase.Pista = True
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(145, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.Tipo = 0
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
        '
        'tbx_Envase
        '
        Me.tbx_Envase.Control_Siguiente = Me.btn_AgregarE
        Me.tbx_Envase.Filtrado = True
        Me.tbx_Envase.Location = New System.Drawing.Point(451, 37)
        Me.tbx_Envase.MaxLength = 20
        Me.tbx_Envase.Name = "tbx_Envase"
        Me.tbx_Envase.Size = New System.Drawing.Size(108, 20)
        Me.tbx_Envase.TabIndex = 5
        Me.tbx_Envase.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_HoraR
        '
        Me.tbx_HoraR.Control_Siguiente = Nothing
        Me.tbx_HoraR.Filtrado = True
        Me.tbx_HoraR.Location = New System.Drawing.Point(596, 166)
        Me.tbx_HoraR.MaxLength = 5
        Me.tbx_HoraR.Name = "tbx_HoraR"
        Me.tbx_HoraR.Size = New System.Drawing.Size(49, 20)
        Me.tbx_HoraR.TabIndex = 28
        Me.tbx_HoraR.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(385, 67)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter4
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 45
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(261, 91)
        Me.lsv_Envases.TabIndex = 8
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'tbx_EnvasesSN
        '
        Me.tbx_EnvasesSN.Control_Siguiente = Nothing
        Me.tbx_EnvasesSN.Filtrado = True
        Me.tbx_EnvasesSN.Location = New System.Drawing.Point(467, 166)
        Me.tbx_EnvasesSN.MaxLength = 4
        Me.tbx_EnvasesSN.Name = "tbx_EnvasesSN"
        Me.tbx_EnvasesSN.Size = New System.Drawing.Size(49, 20)
        Me.tbx_EnvasesSN.TabIndex = 10
        Me.tbx_EnvasesSN.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_ImporteProcesado
        '
        Me.tbx_ImporteProcesado.BackColor = System.Drawing.Color.White
        Me.tbx_ImporteProcesado.Control_Siguiente = Nothing
        Me.tbx_ImporteProcesado.Filtrado = False
        Me.tbx_ImporteProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImporteProcesado.Location = New System.Drawing.Point(464, 13)
        Me.tbx_ImporteProcesado.MaxLength = 20
        Me.tbx_ImporteProcesado.Name = "tbx_ImporteProcesado"
        Me.tbx_ImporteProcesado.ReadOnly = True
        Me.tbx_ImporteProcesado.Size = New System.Drawing.Size(155, 26)
        Me.tbx_ImporteProcesado.TabIndex = 1
        Me.tbx_ImporteProcesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteProcesado.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Total
        '
        Me.tbx_Total.BackColor = System.Drawing.Color.White
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = False
        Me.tbx_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Total.Location = New System.Drawing.Point(144, 14)
        Me.tbx_Total.MaxLength = 20
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.ReadOnly = True
        Me.tbx_Total.Size = New System.Drawing.Size(155, 26)
        Me.tbx_Total.TabIndex = 1
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Total.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_BuscaRemision
        '
        Me.tbx_BuscaRemision.Control_Siguiente = Me.btn_BuscaRemision
        Me.tbx_BuscaRemision.Filtrado = True
        Me.tbx_BuscaRemision.Location = New System.Drawing.Point(106, 9)
        Me.tbx_BuscaRemision.MaxLength = 20
        Me.tbx_BuscaRemision.Name = "tbx_BuscaRemision"
        Me.tbx_BuscaRemision.Size = New System.Drawing.Size(138, 20)
        Me.tbx_BuscaRemision.TabIndex = 8
        Me.tbx_BuscaRemision.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.AllowColumnReorder = True
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 32)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter3
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 10
        Me.lsv_Remisiones.Row10 = 10
        Me.lsv_Remisiones.Row2 = 7
        Me.lsv_Remisiones.Row3 = 7
        Me.lsv_Remisiones.Row4 = 7
        Me.lsv_Remisiones.Row5 = 10
        Me.lsv_Remisiones.Row6 = 20
        Me.lsv_Remisiones.Row7 = 10
        Me.lsv_Remisiones.Row8 = 10
        Me.lsv_Remisiones.Row9 = 10
        Me.lsv_Remisiones.Size = New System.Drawing.Size(914, 65)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'tbx_CantidadKM
        '
        Me.tbx_CantidadKM.Control_Siguiente = Nothing
        Me.tbx_CantidadKM.Filtrado = True
        Me.tbx_CantidadKM.Location = New System.Drawing.Point(106, 208)
        Me.tbx_CantidadKM.MaxLength = 3
        Me.tbx_CantidadKM.Name = "tbx_CantidadKM"
        Me.tbx_CantidadKM.ReadOnly = True
        Me.tbx_CantidadKM.Size = New System.Drawing.Size(71, 20)
        Me.tbx_CantidadKM.TabIndex = 30
        Me.tbx_CantidadKM.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Nothing
        Me.tbx_Numero.Filtrado = True
        Me.tbx_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Numero.Location = New System.Drawing.Point(210, 10)
        Me.tbx_Numero.MaxLength = 20
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(155, 24)
        Me.tbx_Numero.TabIndex = 1
        Me.tbx_Numero.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(669, 232)
        Me.tbx_Descripcion.MaxLength = 150
        Me.tbx_Descripcion.Multiline = True
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.ReadOnly = True
        Me.tbx_Descripcion.Size = New System.Drawing.Size(251, 50)
        Me.tbx_Descripcion.TabIndex = 28
        Me.tbx_Descripcion.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Hora
        '
        Me.tbx_Hora.Control_Siguiente = Nothing
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(340, 255)
        Me.tbx_Hora.MaxLength = 5
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(49, 20)
        Me.tbx_Hora.TabIndex = 28
        Me.tbx_Hora.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Ruta
        '
        Me.tbx_Ruta.Control_Siguiente = Nothing
        Me.tbx_Ruta.Filtrado = True
        Me.tbx_Ruta.Location = New System.Drawing.Point(106, 232)
        Me.tbx_Ruta.MaxLength = 4
        Me.tbx_Ruta.Name = "tbx_Ruta"
        Me.tbx_Ruta.Size = New System.Drawing.Size(71, 20)
        Me.tbx_Ruta.TabIndex = 23
        Me.tbx_Ruta.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Kilometraje
        '
        Me.tbx_Kilometraje.Control_Siguiente = Nothing
        Me.tbx_Kilometraje.Enabled = False
        Me.tbx_Kilometraje.Filtrado = True
        Me.tbx_Kilometraje.Location = New System.Drawing.Point(106, 185)
        Me.tbx_Kilometraje.MaxLength = 12
        Me.tbx_Kilometraje.Name = "tbx_Kilometraje"
        Me.tbx_Kilometraje.ReadOnly = True
        Me.tbx_Kilometraje.Size = New System.Drawing.Size(71, 20)
        Me.tbx_Kilometraje.TabIndex = 20
        Me.tbx_Kilometraje.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Cuota
        '
        Me.tbx_Cuota.Control_Siguiente = Nothing
        Me.tbx_Cuota.Enabled = False
        Me.tbx_Cuota.Filtrado = True
        Me.tbx_Cuota.Location = New System.Drawing.Point(106, 163)
        Me.tbx_Cuota.MaxLength = 12
        Me.tbx_Cuota.Name = "tbx_Cuota"
        Me.tbx_Cuota.ReadOnly = True
        Me.tbx_Cuota.Size = New System.Drawing.Size(71, 20)
        Me.tbx_Cuota.TabIndex = 14
        Me.tbx_Cuota.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Nothing
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(106, 117)
        Me.tbx_Cliente.MaxLength = 12
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(71, 20)
        Me.tbx_Cliente.TabIndex = 5
        Me.tbx_Cliente.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Clave = "Clave"
        Me.cmb_Ruta.Control_Siguiente = Nothing
        Me.cmb_Ruta.DisplayMember = "Descripcion"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.Empresa = False
        Me.cmb_Ruta.Filtro = Me.tbx_Ruta
        Me.cmb_Ruta.FormattingEnabled = True
        Me.cmb_Ruta.Location = New System.Drawing.Point(179, 231)
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Pista = True
        Me.cmb_Ruta.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Ruta.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_Ruta.Sucursal = True
        Me.cmb_Ruta.TabIndex = 24
        Me.cmb_Ruta.Tipo = 0
        Me.cmb_Ruta.ValueMember = "Id_Ruta"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(179, 116)
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Cliente.StoredProcedure = "cat_ClientesCombo_GetAB"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'cmb_Kilometraje
        '
        Me.cmb_Kilometraje.Clave = "Clave"
        Me.cmb_Kilometraje.Control_Siguiente = Nothing
        Me.cmb_Kilometraje.DisplayMember = "Descripcion"
        Me.cmb_Kilometraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Kilometraje.Empresa = True
        Me.cmb_Kilometraje.Enabled = False
        Me.cmb_Kilometraje.Filtro = Me.tbx_Kilometraje
        Me.cmb_Kilometraje.FormattingEnabled = True
        Me.cmb_Kilometraje.Location = New System.Drawing.Point(179, 185)
        Me.cmb_Kilometraje.Name = "cmb_Kilometraje"
        Me.cmb_Kilometraje.Pista = True
        Me.cmb_Kilometraje.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Kilometraje.StoredProcedure = "Cat_KilometrosEmpresa_Get"
        Me.cmb_Kilometraje.Sucursal = False
        Me.cmb_Kilometraje.TabIndex = 21
        Me.cmb_Kilometraje.Tipo = 0
        Me.cmb_Kilometraje.ValueMember = "Id_KM"
        '
        'cmb_Precio
        '
        Me.cmb_Precio.Clave = "Clave_Precio"
        Me.cmb_Precio.Control_Siguiente = Nothing
        Me.cmb_Precio.DisplayMember = "Descripcion"
        Me.cmb_Precio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Precio.Empresa = False
        Me.cmb_Precio.Filtro = Nothing
        Me.cmb_Precio.FormattingEnabled = True
        Me.cmb_Precio.Location = New System.Drawing.Point(106, 139)
        Me.cmb_Precio.Name = "cmb_Precio"
        Me.cmb_Precio.Pista = False
        Me.cmb_Precio.Size = New System.Drawing.Size(530, 21)
        Me.cmb_Precio.StoredProcedure = "Cat_PreciosXclienteCombo_Get2"
        Me.cmb_Precio.Sucursal = False
        Me.cmb_Precio.TabIndex = 10
        Me.cmb_Precio.Tipo = 0
        Me.cmb_Precio.ValueMember = "Id_CS"
        '
        'cmb_Cuota
        '
        Me.cmb_Cuota.Clave = "Clave"
        Me.cmb_Cuota.Control_Siguiente = Nothing
        Me.cmb_Cuota.DisplayMember = "Descripcion"
        Me.cmb_Cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cuota.Empresa = False
        Me.cmb_Cuota.Enabled = False
        Me.cmb_Cuota.Filtro = Me.tbx_Cuota
        Me.cmb_Cuota.FormattingEnabled = True
        Me.cmb_Cuota.Location = New System.Drawing.Point(179, 162)
        Me.cmb_Cuota.Name = "cmb_Cuota"
        Me.cmb_Cuota.Pista = False
        Me.cmb_Cuota.Size = New System.Drawing.Size(457, 21)
        Me.cmb_Cuota.StoredProcedure = "Cat_CuotaXclienteCombo_Get"
        Me.cmb_Cuota.Sucursal = False
        Me.cmb_Cuota.TabIndex = 15
        Me.cmb_Cuota.Tipo = 0
        Me.cmb_Cuota.ValueMember = "Id_CR"
        '
        'lsv_Precios
        '
        Me.lsv_Precios.AllowColumnReorder = True
        Me.lsv_Precios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Precios.FullRowSelect = True
        Me.lsv_Precios.HideSelection = False
        Me.lsv_Precios.Location = New System.Drawing.Point(669, 132)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Precios.Lvs = ListViewColumnSorter1
        Me.lsv_Precios.MultiSelect = False
        Me.lsv_Precios.Name = "lsv_Precios"
        Me.lsv_Precios.Row1 = 15
        Me.lsv_Precios.Row10 = 0
        Me.lsv_Precios.Row2 = 67
        Me.lsv_Precios.Row3 = 15
        Me.lsv_Precios.Row4 = 0
        Me.lsv_Precios.Row5 = 0
        Me.lsv_Precios.Row6 = 0
        Me.lsv_Precios.Row7 = 0
        Me.lsv_Precios.Row8 = 0
        Me.lsv_Precios.Row9 = 0
        Me.lsv_Precios.Size = New System.Drawing.Size(251, 99)
        Me.lsv_Precios.TabIndex = 12
        Me.lsv_Precios.UseCompatibleStateImageBehavior = False
        Me.lsv_Precios.View = System.Windows.Forms.View.Details
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter2
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 10
        Me.lsv_Datos.Row10 = 10
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 8
        Me.lsv_Datos.Row4 = 7
        Me.lsv_Datos.Row5 = 7
        Me.lsv_Datos.Row6 = 25
        Me.lsv_Datos.Row7 = 10
        Me.lsv_Datos.Row8 = 7
        Me.lsv_Datos.Row9 = 7
        Me.lsv_Datos.Size = New System.Drawing.Size(914, 72)
        Me.lsv_Datos.TabIndex = 3
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'frm_MovimientosValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 664)
        Me.Controls.Add(Me.gbx_RemisionesD)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Movimientos)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(950, 700)
        Me.Name = "frm_MovimientosValidar"
        Me.Text = "Validar"
        Me.gbx_Movimientos.ResumeLayout(False)
        Me.gbx_Movimientos.PerformLayout()
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Remisiones.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Botones.PerformLayout()
        Me.gbx_RemisionesD.ResumeLayout(False)
        Me.gbx_RemisionesD.PerformLayout()
        Me.gbx_Tipo2.ResumeLayout(False)
        Me.gbx_Tipo2.PerformLayout()
        Me.gbx_Tipo.ResumeLayout(False)
        Me.gbx_Tipo.PerformLayout()
        CType(Me.dgv_Importes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_Numero As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_NumeroRemision As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Movimientos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents tbx_Ruta As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Kilometraje As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Cuota As Modulo_Facturacion.cp_Textbox
    Friend WithEvents tbx_Cliente As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_Ruta As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Cliente As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Kilometraje As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Precio As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Cuota As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Kilometraje As System.Windows.Forms.Label
    Friend WithEvents Lbl_CoutaRiesgo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents tbx_Hora As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents gbx_RemisionesD As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Importes As System.Windows.Forms.DataGridView
    Friend WithEvents tbx_Total As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_DiceContener As System.Windows.Forms.Label
    Friend WithEvents btn_ValidarRemision As System.Windows.Forms.Button
    Friend WithEvents btn_ValidarServicio As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_Precios As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_ServiciosCliente As System.Windows.Forms.Label
    Friend WithEvents Lbl_NoEnvase As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Facturacion.cp_Listview
    Friend WithEvents tbx_EnvasesSN As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_EnvasesSN As System.Windows.Forms.Label
    Friend WithEvents btn_EliminarE As System.Windows.Forms.Button
    Friend WithEvents btn_AgregarE As System.Windows.Forms.Button
    Friend WithEvents tbx_Envase As Modulo_Facturacion.cp_Textbox
    Friend WithEvents cmb_TipoEnvase As Modulo_Facturacion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As Modulo_Facturacion.cp_Textbox
    Friend WithEvents gbx_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_PagoMorralla As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_DotacionMorralla As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_DotacionBillete As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PagoNomina As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Tipo2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_HoraR As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_HoraRem As System.Windows.Forms.Label
    Friend WithEvents rdb_NominaProcesada As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Hora2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Origen As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents tbx_Destino As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents tbx_Sobres As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_Sobres As System.Windows.Forms.Label
    Friend WithEvents btn_BuscaRemision As System.Windows.Forms.Button
    Friend WithEvents tbx_BuscaRemision As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_LocRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_CantidadKM As Modulo_Facturacion.cp_Textbox
    Friend WithEvents Lbl_CantidadKM As System.Windows.Forms.Label
    Friend WithEvents tbx_ImporteProcesado As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_ImporteProcesado As System.Windows.Forms.Label
End Class
