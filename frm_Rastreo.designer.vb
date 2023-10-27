<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rastreo
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
        Dim ListViewColumnSorter7 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim ListViewColumnSorter8 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Dim ListViewColumnSorter9 As Modulo_Facturacion.ListViewColumnSorter = New Modulo_Facturacion.ListViewColumnSorter()
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.cmb_Cia = New Modulo_Facturacion.cp_cmb_Parametro()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_CiaTraslado = New System.Windows.Forms.Label()
        Me.lbl_Leyenda = New System.Windows.Forms.Label()
        Me.lbl_Remision = New System.Windows.Forms.Label()
        Me.tbx_Remision = New Modulo_Facturacion.cp_Textbox()
        Me.tc = New System.Windows.Forms.TabControl()
        Me.tab_Remisiones = New System.Windows.Forms.TabPage()
        Me.gbx_Envases = New System.Windows.Forms.GroupBox()
        Me.lsv_Envases = New Modulo_Facturacion.cp_Listview()
        Me.gbx_Importes = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Importe = New Modulo_Facturacion.cp_Listview()
        Me.tab_Traslado = New System.Windows.Forms.TabPage()
        Me.lbl_StatusT = New System.Windows.Forms.Label()
        Me.lbl_HorarioEntregaT = New System.Windows.Forms.Label()
        Me.lbl_HorarioRecoleccionT = New System.Windows.Forms.Label()
        Me.lbl_OperadorT = New System.Windows.Forms.Label()
        Me.lbl_CajeroT = New System.Windows.Forms.Label()
        Me.lbl_DestinoT = New System.Windows.Forms.Label()
        Me.lbl_OrigenT = New System.Windows.Forms.Label()
        Me.lbl_FechaT = New System.Windows.Forms.Label()
        Me.tbx_StatusT = New System.Windows.Forms.TextBox()
        Me.tbx_HorarioEntregaT = New System.Windows.Forms.TextBox()
        Me.tbx_HorarioRecoleccionT = New System.Windows.Forms.TextBox()
        Me.tbx_OperadorT = New System.Windows.Forms.TextBox()
        Me.tbx_CajeroT = New System.Windows.Forms.TextBox()
        Me.tbx_DestinoT = New System.Windows.Forms.TextBox()
        Me.tbx_OrigenT = New System.Windows.Forms.TextBox()
        Me.tbx_FechaT = New System.Windows.Forms.TextBox()
        Me.lbl_RutaT = New System.Windows.Forms.Label()
        Me.tbx_RutaT = New System.Windows.Forms.TextBox()
        Me.tab_Boveda = New System.Windows.Forms.TabPage()
        Me.lsv_AsignaFecha = New Modulo_Facturacion.cp_Listview()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.tbx_Status = New System.Windows.Forms.TextBox()
        Me.cbx_DotacionNom = New System.Windows.Forms.CheckBox()
        Me.cbx_CustodiaATM = New System.Windows.Forms.CheckBox()
        Me.cbx_ConcentracionATM = New System.Windows.Forms.CheckBox()
        Me.cbx_Materiales = New System.Windows.Forms.CheckBox()
        Me.cbx_DotacionATM = New System.Windows.Forms.CheckBox()
        Me.cbx_DotacionMorralla = New System.Windows.Forms.CheckBox()
        Me.cbx_DotacionPro = New System.Windows.Forms.CheckBox()
        Me.lbl_UsuarioSalida = New System.Windows.Forms.Label()
        Me.lbl_UsuarioEntrada = New System.Windows.Forms.Label()
        Me.tbx_UsuarioSalida = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioEntrada = New System.Windows.Forms.TextBox()
        Me.lbl_HoraSalida = New System.Windows.Forms.Label()
        Me.lbl_FechaSalida = New System.Windows.Forms.Label()
        Me.tbx_HoraSalida = New System.Windows.Forms.TextBox()
        Me.tbx_FechaSalida = New System.Windows.Forms.TextBox()
        Me.tbx_HoraEntrada = New System.Windows.Forms.TextBox()
        Me.lbl_HoraEntrada = New System.Windows.Forms.Label()
        Me.tbx_FechaEntrada = New System.Windows.Forms.TextBox()
        Me.lbl_FechaEntrada = New System.Windows.Forms.Label()
        Me.Tab_Proceso = New System.Windows.Forms.TabPage()
        Me.lbl_EstacionVerifica = New System.Windows.Forms.Label()
        Me.lbl_Estacion_Asigna = New System.Windows.Forms.Label()
        Me.tbx_EstacionVerifica = New System.Windows.Forms.TextBox()
        Me.tbx_EstacionAsigna = New System.Windows.Forms.TextBox()
        Me.tbx_EstacionRecibe = New System.Windows.Forms.TextBox()
        Me.lbl_EstacionRecibe = New System.Windows.Forms.Label()
        Me.tbx_Corte = New System.Windows.Forms.TextBox()
        Me.lbl_CorteTurno = New System.Windows.Forms.Label()
        Me.tbx_FichasContabilizadas = New System.Windows.Forms.TextBox()
        Me.lbl_CantidadFichasC = New System.Windows.Forms.Label()
        Me.lbl_StatusPro = New System.Windows.Forms.Label()
        Me.tbx_StatusPro = New System.Windows.Forms.TextBox()
        Me.lbl_MinutosVerificando = New System.Windows.Forms.Label()
        Me.tbx_Fichas = New System.Windows.Forms.TextBox()
        Me.lbl_Fichas = New System.Windows.Forms.Label()
        Me.tbx_MinutosVerificando = New System.Windows.Forms.TextBox()
        Me.tbx_FechaContabilizacion = New System.Windows.Forms.TextBox()
        Me.lbl_FechaContabilizacion = New System.Windows.Forms.Label()
        Me.lbl_FechaFinVerificacion = New System.Windows.Forms.Label()
        Me.tbx_FechaFinVerificacion = New System.Windows.Forms.TextBox()
        Me.tbx_FechaInicioVerificacion = New System.Windows.Forms.TextBox()
        Me.lbl_FechaInicioVerificacion = New System.Windows.Forms.Label()
        Me.tbx_FechaAsignacion = New System.Windows.Forms.TextBox()
        Me.lbl_FechaAsignacion = New System.Windows.Forms.Label()
        Me.tbx_FechaRecepcion = New System.Windows.Forms.TextBox()
        Me.lbl_FechadeRecepcion = New System.Windows.Forms.Label()
        Me.tbx_GrupoDeposito = New System.Windows.Forms.TextBox()
        Me.lbl_GrupoDeposito = New System.Windows.Forms.Label()
        Me.tbx_Cliente = New System.Windows.Forms.TextBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.tbx_Cajero = New System.Windows.Forms.TextBox()
        Me.lbl_Cajero = New System.Windows.Forms.Label()
        Me.tbx_CajaBancaria = New System.Windows.Forms.TextBox()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.tbx_Sesion = New System.Windows.Forms.TextBox()
        Me.lbl_Sesion = New System.Windows.Forms.Label()
        Me.tab_DotacionesP = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_RutaEntrega = New System.Windows.Forms.TextBox()
        Me.Lbl_FechAsigRut = New System.Windows.Forms.Label()
        Me.tbx_FechaAsignaRuta = New System.Windows.Forms.TextBox()
        Me.Lbl_FechAsigFech = New System.Windows.Forms.Label()
        Me.Lbl_UsuAsigRut = New System.Windows.Forms.Label()
        Me.Lbl_UsuarioAsigFech = New System.Windows.Forms.Label()
        Me.tbx_FechaAsignaFecha = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioAsignaRuta = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioAsignaFecha = New System.Windows.Forms.TextBox()
        Me.lbl_StatusDP = New System.Windows.Forms.Label()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.lbl_Moneda = New System.Windows.Forms.Label()
        Me.lbl_Envases = New System.Windows.Forms.Label()
        Me.lbl_Importe = New System.Windows.Forms.Label()
        Me.lbl_UsuarioCancela = New System.Windows.Forms.Label()
        Me.lbl_UsuarioValida = New System.Windows.Forms.Label()
        Me.lbl_UsuarioCaptura = New System.Windows.Forms.Label()
        Me.lbl_NombreCliente = New System.Windows.Forms.Label()
        Me.lbl_Caja = New System.Windows.Forms.Label()
        Me.lbl_FechaCancela = New System.Windows.Forms.Label()
        Me.lbl_FechaEntrega = New System.Windows.Forms.Label()
        Me.lbl_FechaValida = New System.Windows.Forms.Label()
        Me.lbl_FechaCaptura = New System.Windows.Forms.Label()
        Me.tbx_StatusDP = New System.Windows.Forms.TextBox()
        Me.tbx_Tipo = New System.Windows.Forms.TextBox()
        Me.tbx_Moneda = New System.Windows.Forms.TextBox()
        Me.tbx_Envases = New System.Windows.Forms.TextBox()
        Me.tbx_Importe = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioCancela = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioValida = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioCaptura = New System.Windows.Forms.TextBox()
        Me.tbx_NombreCliente = New System.Windows.Forms.TextBox()
        Me.tbx_Caja = New System.Windows.Forms.TextBox()
        Me.tbx_FechaCancela = New System.Windows.Forms.TextBox()
        Me.tbx_FechaEntrega = New System.Windows.Forms.TextBox()
        Me.tbx_FechaValida = New System.Windows.Forms.TextBox()
        Me.tbx_FechaCaptura = New System.Windows.Forms.TextBox()
        Me.Tab_DotacionesC = New System.Windows.Forms.TabPage()
        Me.lbl_UsuarioCapturaC = New System.Windows.Forms.Label()
        Me.tbx_UsuarioCapturaC = New System.Windows.Forms.TextBox()
        Me.lbl_StatusDC = New System.Windows.Forms.Label()
        Me.lbl_MonedaC = New System.Windows.Forms.Label()
        Me.lbl_EnvasesC = New System.Windows.Forms.Label()
        Me.lbl_ImporteC = New System.Windows.Forms.Label()
        Me.lbl_UsuarioCancelaC = New System.Windows.Forms.Label()
        Me.lbl_UsuarioValidaC = New System.Windows.Forms.Label()
        Me.lbl_CajeroC = New System.Windows.Forms.Label()
        Me.lbl_NumeroCajeroC = New System.Windows.Forms.Label()
        Me.lbl_CajaC = New System.Windows.Forms.Label()
        Me.lbl_FechaCancelaC = New System.Windows.Forms.Label()
        Me.lbl_FechaEntregaC = New System.Windows.Forms.Label()
        Me.lbl_FechaValidaC = New System.Windows.Forms.Label()
        Me.lbl_FechaCapturaC = New System.Windows.Forms.Label()
        Me.tbx_StatusDC = New System.Windows.Forms.TextBox()
        Me.tbx_MonedaC = New System.Windows.Forms.TextBox()
        Me.tbx_EnvasesC = New System.Windows.Forms.TextBox()
        Me.tbx_ImporteC = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioCancelaC = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioValidaC = New System.Windows.Forms.TextBox()
        Me.tbx_CajeroC = New System.Windows.Forms.TextBox()
        Me.tbx_NumeroCajeroC = New System.Windows.Forms.TextBox()
        Me.tbx_CajaC = New System.Windows.Forms.TextBox()
        Me.tbx_FechaCancelaC = New System.Windows.Forms.TextBox()
        Me.tbx_FechaEntregaC = New System.Windows.Forms.TextBox()
        Me.tbx_FechaValidaC = New System.Windows.Forms.TextBox()
        Me.tbx_FechaCapturaC = New System.Windows.Forms.TextBox()
        Me.Tab_Materiales = New System.Windows.Forms.TabPage()
        Me.lbl_StatusM = New System.Windows.Forms.Label()
        Me.tbx_StatusM = New System.Windows.Forms.TextBox()
        Me.lbl_UsuarioValidaM = New System.Windows.Forms.Label()
        Me.lbl_UsuarioRegistroM = New System.Windows.Forms.Label()
        Me.lbl_HoraValidaM = New System.Windows.Forms.Label()
        Me.lbl_FechaValidaM = New System.Windows.Forms.Label()
        Me.lbl_HoraRegistroM = New System.Windows.Forms.Label()
        Me.lbl_FechaRegistroM = New System.Windows.Forms.Label()
        Me.lbl_DestinoM = New System.Windows.Forms.Label()
        Me.tbx_UsuarioValidaM = New System.Windows.Forms.TextBox()
        Me.tbx_UsuarioRegistroM = New System.Windows.Forms.TextBox()
        Me.tbx_HoraValidaM = New System.Windows.Forms.TextBox()
        Me.tbx_FechaValidaM = New System.Windows.Forms.TextBox()
        Me.tbx_HoraRegistroM = New System.Windows.Forms.TextBox()
        Me.tbx_FechaRegistroM = New System.Windows.Forms.TextBox()
        Me.tbx_DestinoM = New System.Windows.Forms.TextBox()
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.tc.SuspendLayout()
        Me.tab_Remisiones.SuspendLayout()
        Me.gbx_Envases.SuspendLayout()
        Me.gbx_Importes.SuspendLayout()
        Me.tab_Traslado.SuspendLayout()
        Me.tab_Boveda.SuspendLayout()
        Me.Tab_Proceso.SuspendLayout()
        Me.tab_DotacionesP.SuspendLayout()
        Me.Tab_DotacionesC.SuspendLayout()
        Me.Tab_Materiales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(9, 499)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Remisiones.TabIndex = 2
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Tag = ""
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Facturacion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.gbx_Filtro.Controls.Add(Me.btn_Buscar)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CiaTraslado)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Leyenda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Remision)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.gbx_Filtro.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(767, 79)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        Me.gbx_Filtro.Tag = ""
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Cia = False
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Location = New System.Drawing.Point(96, 45)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.NombreParametro = "@Numero_Remision"
        Me.cmb_Cia.Pista = False
        Me.cmb_Cia.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Remisiones_ExisteByNumero"
        Me.cmb_Cia.Sucursal = True
        Me.cmb_Cia.TabIndex = 4
        Me.cmb_Cia.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Cia.ValorParametro = Nothing
        Me.cmb_Cia.ValueMember = "Id_Remision"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Facturacion.My.Resources.Resources._1rightarrow1
        Me.btn_Buscar.Location = New System.Drawing.Point(302, 16)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_CiaTraslado
        '
        Me.lbl_CiaTraslado.AutoSize = True
        Me.lbl_CiaTraslado.Location = New System.Drawing.Point(9, 48)
        Me.lbl_CiaTraslado.Name = "lbl_CiaTraslado"
        Me.lbl_CiaTraslado.Size = New System.Drawing.Size(81, 13)
        Me.lbl_CiaTraslado.TabIndex = 3
        Me.lbl_CiaTraslado.Text = "Cia de Traslado"
        '
        'lbl_Leyenda
        '
        Me.lbl_Leyenda.AutoSize = True
        Me.lbl_Leyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Leyenda.Location = New System.Drawing.Point(330, 53)
        Me.lbl_Leyenda.Name = "lbl_Leyenda"
        Me.lbl_Leyenda.Size = New System.Drawing.Size(96, 13)
        Me.lbl_Leyenda.TabIndex = 0
        Me.lbl_Leyenda.Text = "La Remisión ... "
        Me.lbl_Leyenda.Visible = False
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(40, 22)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Remisión"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Location = New System.Drawing.Point(96, 19)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(200, 20)
        Me.tbx_Remision.TabIndex = 1
        Me.tbx_Remision.TipoDatos = Modulo_Facturacion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tc
        '
        Me.tc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc.Controls.Add(Me.tab_Remisiones)
        Me.tc.Controls.Add(Me.tab_Traslado)
        Me.tc.Controls.Add(Me.tab_Boveda)
        Me.tc.Controls.Add(Me.Tab_Proceso)
        Me.tc.Controls.Add(Me.tab_DotacionesP)
        Me.tc.Controls.Add(Me.Tab_DotacionesC)
        Me.tc.Controls.Add(Me.Tab_Materiales)
        Me.tc.Location = New System.Drawing.Point(9, 87)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.Size = New System.Drawing.Size(767, 406)
        Me.tc.TabIndex = 1
        '
        'tab_Remisiones
        '
        Me.tab_Remisiones.Controls.Add(Me.gbx_Envases)
        Me.tab_Remisiones.Controls.Add(Me.gbx_Importes)
        Me.tab_Remisiones.Location = New System.Drawing.Point(4, 22)
        Me.tab_Remisiones.Name = "tab_Remisiones"
        Me.tab_Remisiones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Remisiones.Size = New System.Drawing.Size(759, 380)
        Me.tab_Remisiones.TabIndex = 1
        Me.tab_Remisiones.Text = "Remisiones"
        Me.tab_Remisiones.UseVisualStyleBackColor = True
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Envases.Controls.Add(Me.lsv_Envases)
        Me.gbx_Envases.Location = New System.Drawing.Point(3, 291)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(753, 86)
        Me.gbx_Envases.TabIndex = 1
        Me.gbx_Envases.TabStop = False
        Me.gbx_Envases.Text = "Envases"
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter7
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 10
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 10
        Me.lsv_Envases.Row5 = 55
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(747, 67)
        Me.lsv_Envases.TabIndex = 0
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'gbx_Importes
        '
        Me.gbx_Importes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Importes.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Importes.Controls.Add(Me.lsv_Importe)
        Me.gbx_Importes.Location = New System.Drawing.Point(6, 3)
        Me.gbx_Importes.Name = "gbx_Importes"
        Me.gbx_Importes.Size = New System.Drawing.Size(750, 282)
        Me.gbx_Importes.TabIndex = 0
        Me.gbx_Importes.TabStop = False
        Me.gbx_Importes.Text = "Importes"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(570, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_Registros.TabIndex = 1
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Importe
        '
        Me.lsv_Importe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Importe.FullRowSelect = True
        Me.lsv_Importe.HideSelection = False
        Me.lsv_Importe.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.lsv_Importe.Lvs = ListViewColumnSorter8
        Me.lsv_Importe.MultiSelect = False
        Me.lsv_Importe.Name = "lsv_Importe"
        Me.lsv_Importe.Row1 = 10
        Me.lsv_Importe.Row10 = 10
        Me.lsv_Importe.Row2 = 10
        Me.lsv_Importe.Row3 = 10
        Me.lsv_Importe.Row4 = 10
        Me.lsv_Importe.Row5 = 10
        Me.lsv_Importe.Row6 = 10
        Me.lsv_Importe.Row7 = 10
        Me.lsv_Importe.Row8 = 10
        Me.lsv_Importe.Row9 = 10
        Me.lsv_Importe.Size = New System.Drawing.Size(744, 245)
        Me.lsv_Importe.TabIndex = 0
        Me.lsv_Importe.UseCompatibleStateImageBehavior = False
        Me.lsv_Importe.View = System.Windows.Forms.View.Details
        '
        'tab_Traslado
        '
        Me.tab_Traslado.Controls.Add(Me.lbl_StatusT)
        Me.tab_Traslado.Controls.Add(Me.lbl_HorarioEntregaT)
        Me.tab_Traslado.Controls.Add(Me.lbl_HorarioRecoleccionT)
        Me.tab_Traslado.Controls.Add(Me.lbl_OperadorT)
        Me.tab_Traslado.Controls.Add(Me.lbl_CajeroT)
        Me.tab_Traslado.Controls.Add(Me.lbl_DestinoT)
        Me.tab_Traslado.Controls.Add(Me.lbl_OrigenT)
        Me.tab_Traslado.Controls.Add(Me.lbl_FechaT)
        Me.tab_Traslado.Controls.Add(Me.tbx_StatusT)
        Me.tab_Traslado.Controls.Add(Me.tbx_HorarioEntregaT)
        Me.tab_Traslado.Controls.Add(Me.tbx_HorarioRecoleccionT)
        Me.tab_Traslado.Controls.Add(Me.tbx_OperadorT)
        Me.tab_Traslado.Controls.Add(Me.tbx_CajeroT)
        Me.tab_Traslado.Controls.Add(Me.tbx_DestinoT)
        Me.tab_Traslado.Controls.Add(Me.tbx_OrigenT)
        Me.tab_Traslado.Controls.Add(Me.tbx_FechaT)
        Me.tab_Traslado.Controls.Add(Me.lbl_RutaT)
        Me.tab_Traslado.Controls.Add(Me.tbx_RutaT)
        Me.tab_Traslado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Traslado.Name = "tab_Traslado"
        Me.tab_Traslado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Traslado.Size = New System.Drawing.Size(759, 380)
        Me.tab_Traslado.TabIndex = 6
        Me.tab_Traslado.Text = "Traslado"
        Me.tab_Traslado.UseVisualStyleBackColor = True
        '
        'lbl_StatusT
        '
        Me.lbl_StatusT.AutoSize = True
        Me.lbl_StatusT.Location = New System.Drawing.Point(88, 217)
        Me.lbl_StatusT.Name = "lbl_StatusT"
        Me.lbl_StatusT.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusT.TabIndex = 16
        Me.lbl_StatusT.Text = "Status"
        '
        'lbl_HorarioEntregaT
        '
        Me.lbl_HorarioEntregaT.AutoSize = True
        Me.lbl_HorarioEntregaT.Location = New System.Drawing.Point(40, 191)
        Me.lbl_HorarioEntregaT.Name = "lbl_HorarioEntregaT"
        Me.lbl_HorarioEntregaT.Size = New System.Drawing.Size(85, 13)
        Me.lbl_HorarioEntregaT.TabIndex = 14
        Me.lbl_HorarioEntregaT.Text = "Hora de Entrega"
        '
        'lbl_HorarioRecoleccionT
        '
        Me.lbl_HorarioRecoleccionT.AutoSize = True
        Me.lbl_HorarioRecoleccionT.Location = New System.Drawing.Point(17, 165)
        Me.lbl_HorarioRecoleccionT.Name = "lbl_HorarioRecoleccionT"
        Me.lbl_HorarioRecoleccionT.Size = New System.Drawing.Size(108, 13)
        Me.lbl_HorarioRecoleccionT.TabIndex = 12
        Me.lbl_HorarioRecoleccionT.Text = "Hora de Recolección"
        '
        'lbl_OperadorT
        '
        Me.lbl_OperadorT.AutoSize = True
        Me.lbl_OperadorT.Location = New System.Drawing.Point(74, 139)
        Me.lbl_OperadorT.Name = "lbl_OperadorT"
        Me.lbl_OperadorT.Size = New System.Drawing.Size(51, 13)
        Me.lbl_OperadorT.TabIndex = 10
        Me.lbl_OperadorT.Text = "Operador"
        '
        'lbl_CajeroT
        '
        Me.lbl_CajeroT.AutoSize = True
        Me.lbl_CajeroT.Location = New System.Drawing.Point(88, 113)
        Me.lbl_CajeroT.Name = "lbl_CajeroT"
        Me.lbl_CajeroT.Size = New System.Drawing.Size(37, 13)
        Me.lbl_CajeroT.TabIndex = 8
        Me.lbl_CajeroT.Text = "Cajero"
        '
        'lbl_DestinoT
        '
        Me.lbl_DestinoT.AutoSize = True
        Me.lbl_DestinoT.Location = New System.Drawing.Point(82, 87)
        Me.lbl_DestinoT.Name = "lbl_DestinoT"
        Me.lbl_DestinoT.Size = New System.Drawing.Size(43, 13)
        Me.lbl_DestinoT.TabIndex = 6
        Me.lbl_DestinoT.Text = "Destino"
        '
        'lbl_OrigenT
        '
        Me.lbl_OrigenT.AutoSize = True
        Me.lbl_OrigenT.Location = New System.Drawing.Point(87, 61)
        Me.lbl_OrigenT.Name = "lbl_OrigenT"
        Me.lbl_OrigenT.Size = New System.Drawing.Size(38, 13)
        Me.lbl_OrigenT.TabIndex = 4
        Me.lbl_OrigenT.Text = "Origen"
        '
        'lbl_FechaT
        '
        Me.lbl_FechaT.AutoSize = True
        Me.lbl_FechaT.Location = New System.Drawing.Point(88, 35)
        Me.lbl_FechaT.Name = "lbl_FechaT"
        Me.lbl_FechaT.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaT.TabIndex = 2
        Me.lbl_FechaT.Text = "Fecha"
        '
        'tbx_StatusT
        '
        Me.tbx_StatusT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_StatusT.Location = New System.Drawing.Point(131, 214)
        Me.tbx_StatusT.Name = "tbx_StatusT"
        Me.tbx_StatusT.ReadOnly = True
        Me.tbx_StatusT.Size = New System.Drawing.Size(161, 20)
        Me.tbx_StatusT.TabIndex = 17
        '
        'tbx_HorarioEntregaT
        '
        Me.tbx_HorarioEntregaT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_HorarioEntregaT.Location = New System.Drawing.Point(131, 188)
        Me.tbx_HorarioEntregaT.Name = "tbx_HorarioEntregaT"
        Me.tbx_HorarioEntregaT.ReadOnly = True
        Me.tbx_HorarioEntregaT.Size = New System.Drawing.Size(161, 20)
        Me.tbx_HorarioEntregaT.TabIndex = 15
        '
        'tbx_HorarioRecoleccionT
        '
        Me.tbx_HorarioRecoleccionT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_HorarioRecoleccionT.Location = New System.Drawing.Point(131, 162)
        Me.tbx_HorarioRecoleccionT.Name = "tbx_HorarioRecoleccionT"
        Me.tbx_HorarioRecoleccionT.ReadOnly = True
        Me.tbx_HorarioRecoleccionT.Size = New System.Drawing.Size(161, 20)
        Me.tbx_HorarioRecoleccionT.TabIndex = 13
        '
        'tbx_OperadorT
        '
        Me.tbx_OperadorT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_OperadorT.Location = New System.Drawing.Point(131, 136)
        Me.tbx_OperadorT.Name = "tbx_OperadorT"
        Me.tbx_OperadorT.ReadOnly = True
        Me.tbx_OperadorT.Size = New System.Drawing.Size(300, 20)
        Me.tbx_OperadorT.TabIndex = 11
        '
        'tbx_CajeroT
        '
        Me.tbx_CajeroT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CajeroT.Location = New System.Drawing.Point(131, 110)
        Me.tbx_CajeroT.Name = "tbx_CajeroT"
        Me.tbx_CajeroT.ReadOnly = True
        Me.tbx_CajeroT.Size = New System.Drawing.Size(300, 20)
        Me.tbx_CajeroT.TabIndex = 9
        '
        'tbx_DestinoT
        '
        Me.tbx_DestinoT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DestinoT.Location = New System.Drawing.Point(131, 84)
        Me.tbx_DestinoT.Name = "tbx_DestinoT"
        Me.tbx_DestinoT.ReadOnly = True
        Me.tbx_DestinoT.Size = New System.Drawing.Size(428, 20)
        Me.tbx_DestinoT.TabIndex = 7
        '
        'tbx_OrigenT
        '
        Me.tbx_OrigenT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_OrigenT.Location = New System.Drawing.Point(131, 58)
        Me.tbx_OrigenT.Name = "tbx_OrigenT"
        Me.tbx_OrigenT.ReadOnly = True
        Me.tbx_OrigenT.Size = New System.Drawing.Size(428, 20)
        Me.tbx_OrigenT.TabIndex = 5
        '
        'tbx_FechaT
        '
        Me.tbx_FechaT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaT.Location = New System.Drawing.Point(131, 32)
        Me.tbx_FechaT.Name = "tbx_FechaT"
        Me.tbx_FechaT.ReadOnly = True
        Me.tbx_FechaT.Size = New System.Drawing.Size(100, 20)
        Me.tbx_FechaT.TabIndex = 3
        '
        'lbl_RutaT
        '
        Me.lbl_RutaT.AutoSize = True
        Me.lbl_RutaT.Location = New System.Drawing.Point(95, 9)
        Me.lbl_RutaT.Name = "lbl_RutaT"
        Me.lbl_RutaT.Size = New System.Drawing.Size(30, 13)
        Me.lbl_RutaT.TabIndex = 0
        Me.lbl_RutaT.Text = "Ruta"
        '
        'tbx_RutaT
        '
        Me.tbx_RutaT.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_RutaT.Location = New System.Drawing.Point(131, 6)
        Me.tbx_RutaT.Name = "tbx_RutaT"
        Me.tbx_RutaT.ReadOnly = True
        Me.tbx_RutaT.Size = New System.Drawing.Size(300, 20)
        Me.tbx_RutaT.TabIndex = 1
        '
        'tab_Boveda
        '
        Me.tab_Boveda.Controls.Add(Me.lsv_AsignaFecha)
        Me.tab_Boveda.Controls.Add(Me.lbl_Status)
        Me.tab_Boveda.Controls.Add(Me.tbx_Status)
        Me.tab_Boveda.Controls.Add(Me.cbx_DotacionNom)
        Me.tab_Boveda.Controls.Add(Me.cbx_CustodiaATM)
        Me.tab_Boveda.Controls.Add(Me.cbx_ConcentracionATM)
        Me.tab_Boveda.Controls.Add(Me.cbx_Materiales)
        Me.tab_Boveda.Controls.Add(Me.cbx_DotacionATM)
        Me.tab_Boveda.Controls.Add(Me.cbx_DotacionMorralla)
        Me.tab_Boveda.Controls.Add(Me.cbx_DotacionPro)
        Me.tab_Boveda.Controls.Add(Me.lbl_UsuarioSalida)
        Me.tab_Boveda.Controls.Add(Me.lbl_UsuarioEntrada)
        Me.tab_Boveda.Controls.Add(Me.tbx_UsuarioSalida)
        Me.tab_Boveda.Controls.Add(Me.tbx_UsuarioEntrada)
        Me.tab_Boveda.Controls.Add(Me.lbl_HoraSalida)
        Me.tab_Boveda.Controls.Add(Me.lbl_FechaSalida)
        Me.tab_Boveda.Controls.Add(Me.tbx_HoraSalida)
        Me.tab_Boveda.Controls.Add(Me.tbx_FechaSalida)
        Me.tab_Boveda.Controls.Add(Me.tbx_HoraEntrada)
        Me.tab_Boveda.Controls.Add(Me.lbl_HoraEntrada)
        Me.tab_Boveda.Controls.Add(Me.tbx_FechaEntrada)
        Me.tab_Boveda.Controls.Add(Me.lbl_FechaEntrada)
        Me.tab_Boveda.Location = New System.Drawing.Point(4, 22)
        Me.tab_Boveda.Name = "tab_Boveda"
        Me.tab_Boveda.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Boveda.Size = New System.Drawing.Size(759, 380)
        Me.tab_Boveda.TabIndex = 0
        Me.tab_Boveda.Text = "Bóveda"
        Me.tab_Boveda.UseVisualStyleBackColor = True
        '
        'lsv_AsignaFecha
        '
        Me.lsv_AsignaFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_AsignaFecha.FullRowSelect = True
        Me.lsv_AsignaFecha.HideSelection = False
        Me.lsv_AsignaFecha.Location = New System.Drawing.Point(266, 162)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.lsv_AsignaFecha.Lvs = ListViewColumnSorter9
        Me.lsv_AsignaFecha.MultiSelect = False
        Me.lsv_AsignaFecha.Name = "lsv_AsignaFecha"
        Me.lsv_AsignaFecha.Row1 = 15
        Me.lsv_AsignaFecha.Row10 = 0
        Me.lsv_AsignaFecha.Row2 = 15
        Me.lsv_AsignaFecha.Row3 = 15
        Me.lsv_AsignaFecha.Row4 = 25
        Me.lsv_AsignaFecha.Row5 = 20
        Me.lsv_AsignaFecha.Row6 = 0
        Me.lsv_AsignaFecha.Row7 = 0
        Me.lsv_AsignaFecha.Row8 = 0
        Me.lsv_AsignaFecha.Row9 = 0
        Me.lsv_AsignaFecha.Size = New System.Drawing.Size(487, 181)
        Me.lsv_AsignaFecha.TabIndex = 21
        Me.lsv_AsignaFecha.UseCompatibleStateImageBehavior = False
        Me.lsv_AsignaFecha.View = System.Windows.Forms.View.Details
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(67, 326)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 20
        Me.lbl_Status.Text = "Status"
        '
        'tbx_Status
        '
        Me.tbx_Status.BackColor = System.Drawing.Color.White
        Me.tbx_Status.Location = New System.Drawing.Point(110, 323)
        Me.tbx_Status.Name = "tbx_Status"
        Me.tbx_Status.ReadOnly = True
        Me.tbx_Status.Size = New System.Drawing.Size(100, 20)
        Me.tbx_Status.TabIndex = 19
        '
        'cbx_DotacionNom
        '
        Me.cbx_DotacionNom.AutoSize = True
        Me.cbx_DotacionNom.Enabled = False
        Me.cbx_DotacionNom.Location = New System.Drawing.Point(110, 300)
        Me.cbx_DotacionNom.Name = "cbx_DotacionNom"
        Me.cbx_DotacionNom.Size = New System.Drawing.Size(128, 17)
        Me.cbx_DotacionNom.TabIndex = 18
        Me.cbx_DotacionNom.Text = "Dotación de Nóminas"
        Me.cbx_DotacionNom.UseVisualStyleBackColor = True
        '
        'cbx_CustodiaATM
        '
        Me.cbx_CustodiaATM.AutoSize = True
        Me.cbx_CustodiaATM.Enabled = False
        Me.cbx_CustodiaATM.Location = New System.Drawing.Point(110, 277)
        Me.cbx_CustodiaATM.Name = "cbx_CustodiaATM"
        Me.cbx_CustodiaATM.Size = New System.Drawing.Size(108, 17)
        Me.cbx_CustodiaATM.TabIndex = 17
        Me.cbx_CustodiaATM.Text = "Custodia de ATM"
        Me.cbx_CustodiaATM.UseVisualStyleBackColor = True
        '
        'cbx_ConcentracionATM
        '
        Me.cbx_ConcentracionATM.AutoSize = True
        Me.cbx_ConcentracionATM.Enabled = False
        Me.cbx_ConcentracionATM.Location = New System.Drawing.Point(110, 254)
        Me.cbx_ConcentracionATM.Name = "cbx_ConcentracionATM"
        Me.cbx_ConcentracionATM.Size = New System.Drawing.Size(136, 17)
        Me.cbx_ConcentracionATM.TabIndex = 16
        Me.cbx_ConcentracionATM.Text = "Concentración de ATM"
        Me.cbx_ConcentracionATM.UseVisualStyleBackColor = True
        '
        'cbx_Materiales
        '
        Me.cbx_Materiales.AutoSize = True
        Me.cbx_Materiales.Enabled = False
        Me.cbx_Materiales.Location = New System.Drawing.Point(110, 231)
        Me.cbx_Materiales.Name = "cbx_Materiales"
        Me.cbx_Materiales.Size = New System.Drawing.Size(135, 17)
        Me.cbx_Materiales.TabIndex = 15
        Me.cbx_Materiales.Text = "Dotación de Materiales"
        Me.cbx_Materiales.UseVisualStyleBackColor = True
        '
        'cbx_DotacionATM
        '
        Me.cbx_DotacionATM.AutoSize = True
        Me.cbx_DotacionATM.Enabled = False
        Me.cbx_DotacionATM.Location = New System.Drawing.Point(110, 208)
        Me.cbx_DotacionATM.Name = "cbx_DotacionATM"
        Me.cbx_DotacionATM.Size = New System.Drawing.Size(110, 17)
        Me.cbx_DotacionATM.TabIndex = 14
        Me.cbx_DotacionATM.Text = "Dotación de ATM"
        Me.cbx_DotacionATM.UseVisualStyleBackColor = True
        '
        'cbx_DotacionMorralla
        '
        Me.cbx_DotacionMorralla.AutoSize = True
        Me.cbx_DotacionMorralla.Enabled = False
        Me.cbx_DotacionMorralla.Location = New System.Drawing.Point(110, 185)
        Me.cbx_DotacionMorralla.Name = "cbx_DotacionMorralla"
        Me.cbx_DotacionMorralla.Size = New System.Drawing.Size(124, 17)
        Me.cbx_DotacionMorralla.TabIndex = 13
        Me.cbx_DotacionMorralla.Text = "Dotación de Morralla"
        Me.cbx_DotacionMorralla.UseVisualStyleBackColor = True
        '
        'cbx_DotacionPro
        '
        Me.cbx_DotacionPro.AutoSize = True
        Me.cbx_DotacionPro.Enabled = False
        Me.cbx_DotacionPro.Location = New System.Drawing.Point(110, 162)
        Me.cbx_DotacionPro.Name = "cbx_DotacionPro"
        Me.cbx_DotacionPro.Size = New System.Drawing.Size(126, 17)
        Me.cbx_DotacionPro.TabIndex = 12
        Me.cbx_DotacionPro.Text = "Dotación de Proceso"
        Me.cbx_DotacionPro.UseVisualStyleBackColor = True
        '
        'lbl_UsuarioSalida
        '
        Me.lbl_UsuarioSalida.AutoSize = True
        Me.lbl_UsuarioSalida.Location = New System.Drawing.Point(14, 139)
        Me.lbl_UsuarioSalida.Name = "lbl_UsuarioSalida"
        Me.lbl_UsuarioSalida.Size = New System.Drawing.Size(90, 13)
        Me.lbl_UsuarioSalida.TabIndex = 10
        Me.lbl_UsuarioSalida.Text = "Usuario de Salida"
        '
        'lbl_UsuarioEntrada
        '
        Me.lbl_UsuarioEntrada.AutoSize = True
        Me.lbl_UsuarioEntrada.Location = New System.Drawing.Point(6, 113)
        Me.lbl_UsuarioEntrada.Name = "lbl_UsuarioEntrada"
        Me.lbl_UsuarioEntrada.Size = New System.Drawing.Size(98, 13)
        Me.lbl_UsuarioEntrada.TabIndex = 8
        Me.lbl_UsuarioEntrada.Text = "Usuario de Entrada"
        '
        'tbx_UsuarioSalida
        '
        Me.tbx_UsuarioSalida.BackColor = System.Drawing.Color.White
        Me.tbx_UsuarioSalida.Location = New System.Drawing.Point(110, 136)
        Me.tbx_UsuarioSalida.Name = "tbx_UsuarioSalida"
        Me.tbx_UsuarioSalida.ReadOnly = True
        Me.tbx_UsuarioSalida.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioSalida.TabIndex = 11
        '
        'tbx_UsuarioEntrada
        '
        Me.tbx_UsuarioEntrada.BackColor = System.Drawing.Color.White
        Me.tbx_UsuarioEntrada.Location = New System.Drawing.Point(110, 110)
        Me.tbx_UsuarioEntrada.Name = "tbx_UsuarioEntrada"
        Me.tbx_UsuarioEntrada.ReadOnly = True
        Me.tbx_UsuarioEntrada.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioEntrada.TabIndex = 9
        '
        'lbl_HoraSalida
        '
        Me.lbl_HoraSalida.AutoSize = True
        Me.lbl_HoraSalida.Location = New System.Drawing.Point(27, 87)
        Me.lbl_HoraSalida.Name = "lbl_HoraSalida"
        Me.lbl_HoraSalida.Size = New System.Drawing.Size(77, 13)
        Me.lbl_HoraSalida.TabIndex = 6
        Me.lbl_HoraSalida.Text = "Hora de Salida"
        '
        'lbl_FechaSalida
        '
        Me.lbl_FechaSalida.AutoSize = True
        Me.lbl_FechaSalida.Location = New System.Drawing.Point(20, 61)
        Me.lbl_FechaSalida.Name = "lbl_FechaSalida"
        Me.lbl_FechaSalida.Size = New System.Drawing.Size(84, 13)
        Me.lbl_FechaSalida.TabIndex = 4
        Me.lbl_FechaSalida.Text = "Fecha de Salida"
        '
        'tbx_HoraSalida
        '
        Me.tbx_HoraSalida.BackColor = System.Drawing.Color.White
        Me.tbx_HoraSalida.Location = New System.Drawing.Point(110, 84)
        Me.tbx_HoraSalida.Name = "tbx_HoraSalida"
        Me.tbx_HoraSalida.ReadOnly = True
        Me.tbx_HoraSalida.Size = New System.Drawing.Size(100, 20)
        Me.tbx_HoraSalida.TabIndex = 7
        '
        'tbx_FechaSalida
        '
        Me.tbx_FechaSalida.BackColor = System.Drawing.Color.White
        Me.tbx_FechaSalida.Location = New System.Drawing.Point(110, 58)
        Me.tbx_FechaSalida.Name = "tbx_FechaSalida"
        Me.tbx_FechaSalida.ReadOnly = True
        Me.tbx_FechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.tbx_FechaSalida.TabIndex = 5
        '
        'tbx_HoraEntrada
        '
        Me.tbx_HoraEntrada.BackColor = System.Drawing.Color.White
        Me.tbx_HoraEntrada.Location = New System.Drawing.Point(110, 32)
        Me.tbx_HoraEntrada.Name = "tbx_HoraEntrada"
        Me.tbx_HoraEntrada.ReadOnly = True
        Me.tbx_HoraEntrada.Size = New System.Drawing.Size(100, 20)
        Me.tbx_HoraEntrada.TabIndex = 3
        '
        'lbl_HoraEntrada
        '
        Me.lbl_HoraEntrada.AutoSize = True
        Me.lbl_HoraEntrada.Location = New System.Drawing.Point(19, 35)
        Me.lbl_HoraEntrada.Name = "lbl_HoraEntrada"
        Me.lbl_HoraEntrada.Size = New System.Drawing.Size(85, 13)
        Me.lbl_HoraEntrada.TabIndex = 2
        Me.lbl_HoraEntrada.Text = "Hora de Entrada"
        '
        'tbx_FechaEntrada
        '
        Me.tbx_FechaEntrada.BackColor = System.Drawing.Color.White
        Me.tbx_FechaEntrada.Location = New System.Drawing.Point(110, 6)
        Me.tbx_FechaEntrada.Name = "tbx_FechaEntrada"
        Me.tbx_FechaEntrada.ReadOnly = True
        Me.tbx_FechaEntrada.Size = New System.Drawing.Size(100, 20)
        Me.tbx_FechaEntrada.TabIndex = 1
        '
        'lbl_FechaEntrada
        '
        Me.lbl_FechaEntrada.AutoSize = True
        Me.lbl_FechaEntrada.Location = New System.Drawing.Point(12, 9)
        Me.lbl_FechaEntrada.Name = "lbl_FechaEntrada"
        Me.lbl_FechaEntrada.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaEntrada.TabIndex = 0
        Me.lbl_FechaEntrada.Text = "Fecha de Entrada"
        '
        'Tab_Proceso
        '
        Me.Tab_Proceso.Controls.Add(Me.lbl_EstacionVerifica)
        Me.Tab_Proceso.Controls.Add(Me.lbl_Estacion_Asigna)
        Me.Tab_Proceso.Controls.Add(Me.tbx_EstacionVerifica)
        Me.Tab_Proceso.Controls.Add(Me.tbx_EstacionAsigna)
        Me.Tab_Proceso.Controls.Add(Me.tbx_EstacionRecibe)
        Me.Tab_Proceso.Controls.Add(Me.lbl_EstacionRecibe)
        Me.Tab_Proceso.Controls.Add(Me.tbx_Corte)
        Me.Tab_Proceso.Controls.Add(Me.lbl_CorteTurno)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FichasContabilizadas)
        Me.Tab_Proceso.Controls.Add(Me.lbl_CantidadFichasC)
        Me.Tab_Proceso.Controls.Add(Me.lbl_StatusPro)
        Me.Tab_Proceso.Controls.Add(Me.tbx_StatusPro)
        Me.Tab_Proceso.Controls.Add(Me.lbl_MinutosVerificando)
        Me.Tab_Proceso.Controls.Add(Me.tbx_Fichas)
        Me.Tab_Proceso.Controls.Add(Me.lbl_Fichas)
        Me.Tab_Proceso.Controls.Add(Me.tbx_MinutosVerificando)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FechaContabilizacion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_FechaContabilizacion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_FechaFinVerificacion)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FechaFinVerificacion)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FechaInicioVerificacion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_FechaInicioVerificacion)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FechaAsignacion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_FechaAsignacion)
        Me.Tab_Proceso.Controls.Add(Me.tbx_FechaRecepcion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_FechadeRecepcion)
        Me.Tab_Proceso.Controls.Add(Me.tbx_GrupoDeposito)
        Me.Tab_Proceso.Controls.Add(Me.lbl_GrupoDeposito)
        Me.Tab_Proceso.Controls.Add(Me.tbx_Cliente)
        Me.Tab_Proceso.Controls.Add(Me.lbl_Cliente)
        Me.Tab_Proceso.Controls.Add(Me.tbx_Cajero)
        Me.Tab_Proceso.Controls.Add(Me.lbl_Cajero)
        Me.Tab_Proceso.Controls.Add(Me.tbx_CajaBancaria)
        Me.Tab_Proceso.Controls.Add(Me.lbl_CajaBancaria)
        Me.Tab_Proceso.Controls.Add(Me.tbx_Sesion)
        Me.Tab_Proceso.Controls.Add(Me.lbl_Sesion)
        Me.Tab_Proceso.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Proceso.Name = "Tab_Proceso"
        Me.Tab_Proceso.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Proceso.Size = New System.Drawing.Size(759, 380)
        Me.Tab_Proceso.TabIndex = 2
        Me.Tab_Proceso.Text = "Proceso"
        Me.Tab_Proceso.UseVisualStyleBackColor = True
        '
        'lbl_EstacionVerifica
        '
        Me.lbl_EstacionVerifica.AutoSize = True
        Me.lbl_EstacionVerifica.Location = New System.Drawing.Point(351, 191)
        Me.lbl_EstacionVerifica.Name = "lbl_EstacionVerifica"
        Me.lbl_EstacionVerifica.Size = New System.Drawing.Size(86, 13)
        Me.lbl_EstacionVerifica.TabIndex = 30
        Me.lbl_EstacionVerifica.Text = "Estación Verifica"
        '
        'lbl_Estacion_Asigna
        '
        Me.lbl_Estacion_Asigna.AutoSize = True
        Me.lbl_Estacion_Asigna.Location = New System.Drawing.Point(354, 165)
        Me.lbl_Estacion_Asigna.Name = "lbl_Estacion_Asigna"
        Me.lbl_Estacion_Asigna.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Estacion_Asigna.TabIndex = 28
        Me.lbl_Estacion_Asigna.Text = "Estación Asigna"
        '
        'tbx_EstacionVerifica
        '
        Me.tbx_EstacionVerifica.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EstacionVerifica.Location = New System.Drawing.Point(443, 188)
        Me.tbx_EstacionVerifica.Name = "tbx_EstacionVerifica"
        Me.tbx_EstacionVerifica.ReadOnly = True
        Me.tbx_EstacionVerifica.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionVerifica.TabIndex = 31
        '
        'tbx_EstacionAsigna
        '
        Me.tbx_EstacionAsigna.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EstacionAsigna.Location = New System.Drawing.Point(443, 162)
        Me.tbx_EstacionAsigna.Name = "tbx_EstacionAsigna"
        Me.tbx_EstacionAsigna.ReadOnly = True
        Me.tbx_EstacionAsigna.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionAsigna.TabIndex = 29
        '
        'tbx_EstacionRecibe
        '
        Me.tbx_EstacionRecibe.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EstacionRecibe.Location = New System.Drawing.Point(443, 136)
        Me.tbx_EstacionRecibe.Name = "tbx_EstacionRecibe"
        Me.tbx_EstacionRecibe.ReadOnly = True
        Me.tbx_EstacionRecibe.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionRecibe.TabIndex = 27
        '
        'lbl_EstacionRecibe
        '
        Me.lbl_EstacionRecibe.AutoSize = True
        Me.lbl_EstacionRecibe.Location = New System.Drawing.Point(352, 139)
        Me.lbl_EstacionRecibe.Name = "lbl_EstacionRecibe"
        Me.lbl_EstacionRecibe.Size = New System.Drawing.Size(85, 13)
        Me.lbl_EstacionRecibe.TabIndex = 26
        Me.lbl_EstacionRecibe.Text = "Estación Recibe"
        '
        'tbx_Corte
        '
        Me.tbx_Corte.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Corte.Location = New System.Drawing.Point(181, 318)
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.ReadOnly = True
        Me.tbx_Corte.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Corte.TabIndex = 25
        '
        'lbl_CorteTurno
        '
        Me.lbl_CorteTurno.AutoSize = True
        Me.lbl_CorteTurno.Location = New System.Drawing.Point(143, 321)
        Me.lbl_CorteTurno.Name = "lbl_CorteTurno"
        Me.lbl_CorteTurno.Size = New System.Drawing.Size(32, 13)
        Me.lbl_CorteTurno.TabIndex = 24
        Me.lbl_CorteTurno.Text = "Corte"
        '
        'tbx_FichasContabilizadas
        '
        Me.tbx_FichasContabilizadas.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FichasContabilizadas.Location = New System.Drawing.Point(181, 292)
        Me.tbx_FichasContabilizadas.Name = "tbx_FichasContabilizadas"
        Me.tbx_FichasContabilizadas.ReadOnly = True
        Me.tbx_FichasContabilizadas.Size = New System.Drawing.Size(50, 20)
        Me.tbx_FichasContabilizadas.TabIndex = 23
        '
        'lbl_CantidadFichasC
        '
        Me.lbl_CantidadFichasC.AutoSize = True
        Me.lbl_CantidadFichasC.Location = New System.Drawing.Point(6, 295)
        Me.lbl_CantidadFichasC.Name = "lbl_CantidadFichasC"
        Me.lbl_CantidadFichasC.Size = New System.Drawing.Size(169, 13)
        Me.lbl_CantidadFichasC.TabIndex = 22
        Me.lbl_CantidadFichasC.Text = "Cantidad de Fichas Contabilizadas"
        '
        'lbl_StatusPro
        '
        Me.lbl_StatusPro.AutoSize = True
        Me.lbl_StatusPro.Location = New System.Drawing.Point(400, 243)
        Me.lbl_StatusPro.Name = "lbl_StatusPro"
        Me.lbl_StatusPro.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusPro.TabIndex = 34
        Me.lbl_StatusPro.Text = "Status"
        '
        'tbx_StatusPro
        '
        Me.tbx_StatusPro.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_StatusPro.Location = New System.Drawing.Point(443, 240)
        Me.tbx_StatusPro.Name = "tbx_StatusPro"
        Me.tbx_StatusPro.ReadOnly = True
        Me.tbx_StatusPro.Size = New System.Drawing.Size(200, 20)
        Me.tbx_StatusPro.TabIndex = 35
        '
        'lbl_MinutosVerificando
        '
        Me.lbl_MinutosVerificando.AutoSize = True
        Me.lbl_MinutosVerificando.Location = New System.Drawing.Point(337, 217)
        Me.lbl_MinutosVerificando.Name = "lbl_MinutosVerificando"
        Me.lbl_MinutosVerificando.Size = New System.Drawing.Size(100, 13)
        Me.lbl_MinutosVerificando.TabIndex = 32
        Me.lbl_MinutosVerificando.Text = "Minutos Verificando"
        '
        'tbx_Fichas
        '
        Me.tbx_Fichas.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Fichas.Location = New System.Drawing.Point(181, 266)
        Me.tbx_Fichas.Name = "tbx_Fichas"
        Me.tbx_Fichas.ReadOnly = True
        Me.tbx_Fichas.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Fichas.TabIndex = 21
        '
        'lbl_Fichas
        '
        Me.lbl_Fichas.AutoSize = True
        Me.lbl_Fichas.Location = New System.Drawing.Point(137, 269)
        Me.lbl_Fichas.Name = "lbl_Fichas"
        Me.lbl_Fichas.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Fichas.TabIndex = 20
        Me.lbl_Fichas.Text = "Fichas"
        '
        'tbx_MinutosVerificando
        '
        Me.tbx_MinutosVerificando.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_MinutosVerificando.Location = New System.Drawing.Point(443, 214)
        Me.tbx_MinutosVerificando.Name = "tbx_MinutosVerificando"
        Me.tbx_MinutosVerificando.ReadOnly = True
        Me.tbx_MinutosVerificando.Size = New System.Drawing.Size(200, 20)
        Me.tbx_MinutosVerificando.TabIndex = 33
        '
        'tbx_FechaContabilizacion
        '
        Me.tbx_FechaContabilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaContabilizacion.Location = New System.Drawing.Point(181, 240)
        Me.tbx_FechaContabilizacion.Name = "tbx_FechaContabilizacion"
        Me.tbx_FechaContabilizacion.ReadOnly = True
        Me.tbx_FechaContabilizacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaContabilizacion.TabIndex = 19
        '
        'lbl_FechaContabilizacion
        '
        Me.lbl_FechaContabilizacion.AutoSize = True
        Me.lbl_FechaContabilizacion.Location = New System.Drawing.Point(49, 243)
        Me.lbl_FechaContabilizacion.Name = "lbl_FechaContabilizacion"
        Me.lbl_FechaContabilizacion.Size = New System.Drawing.Size(126, 13)
        Me.lbl_FechaContabilizacion.TabIndex = 18
        Me.lbl_FechaContabilizacion.Text = "Fecha de Contabilización"
        '
        'lbl_FechaFinVerificacion
        '
        Me.lbl_FechaFinVerificacion.AutoSize = True
        Me.lbl_FechaFinVerificacion.Location = New System.Drawing.Point(33, 217)
        Me.lbl_FechaFinVerificacion.Name = "lbl_FechaFinVerificacion"
        Me.lbl_FechaFinVerificacion.Size = New System.Drawing.Size(142, 13)
        Me.lbl_FechaFinVerificacion.TabIndex = 16
        Me.lbl_FechaFinVerificacion.Text = "Fecha de Fin de Verificación"
        '
        'tbx_FechaFinVerificacion
        '
        Me.tbx_FechaFinVerificacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaFinVerificacion.Location = New System.Drawing.Point(181, 214)
        Me.tbx_FechaFinVerificacion.Name = "tbx_FechaFinVerificacion"
        Me.tbx_FechaFinVerificacion.ReadOnly = True
        Me.tbx_FechaFinVerificacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaFinVerificacion.TabIndex = 17
        '
        'tbx_FechaInicioVerificacion
        '
        Me.tbx_FechaInicioVerificacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaInicioVerificacion.Location = New System.Drawing.Point(181, 188)
        Me.tbx_FechaInicioVerificacion.Name = "tbx_FechaInicioVerificacion"
        Me.tbx_FechaInicioVerificacion.ReadOnly = True
        Me.tbx_FechaInicioVerificacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaInicioVerificacion.TabIndex = 15
        '
        'lbl_FechaInicioVerificacion
        '
        Me.lbl_FechaInicioVerificacion.AutoSize = True
        Me.lbl_FechaInicioVerificacion.Location = New System.Drawing.Point(22, 191)
        Me.lbl_FechaInicioVerificacion.Name = "lbl_FechaInicioVerificacion"
        Me.lbl_FechaInicioVerificacion.Size = New System.Drawing.Size(153, 13)
        Me.lbl_FechaInicioVerificacion.TabIndex = 14
        Me.lbl_FechaInicioVerificacion.Text = "Fecha de Inicio de Verificación"
        '
        'tbx_FechaAsignacion
        '
        Me.tbx_FechaAsignacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaAsignacion.Location = New System.Drawing.Point(181, 162)
        Me.tbx_FechaAsignacion.Name = "tbx_FechaAsignacion"
        Me.tbx_FechaAsignacion.ReadOnly = True
        Me.tbx_FechaAsignacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaAsignacion.TabIndex = 13
        '
        'lbl_FechaAsignacion
        '
        Me.lbl_FechaAsignacion.AutoSize = True
        Me.lbl_FechaAsignacion.Location = New System.Drawing.Point(68, 165)
        Me.lbl_FechaAsignacion.Name = "lbl_FechaAsignacion"
        Me.lbl_FechaAsignacion.Size = New System.Drawing.Size(107, 13)
        Me.lbl_FechaAsignacion.TabIndex = 12
        Me.lbl_FechaAsignacion.Text = "Fecha de Asignación"
        '
        'tbx_FechaRecepcion
        '
        Me.tbx_FechaRecepcion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaRecepcion.Location = New System.Drawing.Point(181, 136)
        Me.tbx_FechaRecepcion.Name = "tbx_FechaRecepcion"
        Me.tbx_FechaRecepcion.ReadOnly = True
        Me.tbx_FechaRecepcion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaRecepcion.TabIndex = 11
        '
        'lbl_FechadeRecepcion
        '
        Me.lbl_FechadeRecepcion.AutoSize = True
        Me.lbl_FechadeRecepcion.Location = New System.Drawing.Point(68, 139)
        Me.lbl_FechadeRecepcion.Name = "lbl_FechadeRecepcion"
        Me.lbl_FechadeRecepcion.Size = New System.Drawing.Size(107, 13)
        Me.lbl_FechadeRecepcion.TabIndex = 10
        Me.lbl_FechadeRecepcion.Text = "Fecha de Recepción"
        '
        'tbx_GrupoDeposito
        '
        Me.tbx_GrupoDeposito.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_GrupoDeposito.Location = New System.Drawing.Point(181, 110)
        Me.tbx_GrupoDeposito.Name = "tbx_GrupoDeposito"
        Me.tbx_GrupoDeposito.ReadOnly = True
        Me.tbx_GrupoDeposito.Size = New System.Drawing.Size(100, 20)
        Me.tbx_GrupoDeposito.TabIndex = 9
        '
        'lbl_GrupoDeposito
        '
        Me.lbl_GrupoDeposito.AutoSize = True
        Me.lbl_GrupoDeposito.Location = New System.Drawing.Point(79, 113)
        Me.lbl_GrupoDeposito.Name = "lbl_GrupoDeposito"
        Me.lbl_GrupoDeposito.Size = New System.Drawing.Size(96, 13)
        Me.lbl_GrupoDeposito.TabIndex = 8
        Me.lbl_GrupoDeposito.Text = "Grupo de Depósito"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Cliente.Location = New System.Drawing.Point(181, 58)
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.ReadOnly = True
        Me.tbx_Cliente.Size = New System.Drawing.Size(462, 20)
        Me.tbx_Cliente.TabIndex = 5
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(136, 61)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        '
        'tbx_Cajero
        '
        Me.tbx_Cajero.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Cajero.Location = New System.Drawing.Point(181, 84)
        Me.tbx_Cajero.Name = "tbx_Cajero"
        Me.tbx_Cajero.ReadOnly = True
        Me.tbx_Cajero.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Cajero.TabIndex = 7
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(138, 87)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 6
        Me.lbl_Cajero.Text = "Cajero"
        '
        'tbx_CajaBancaria
        '
        Me.tbx_CajaBancaria.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CajaBancaria.Location = New System.Drawing.Point(181, 32)
        Me.tbx_CajaBancaria.Name = "tbx_CajaBancaria"
        Me.tbx_CajaBancaria.ReadOnly = True
        Me.tbx_CajaBancaria.Size = New System.Drawing.Size(462, 20)
        Me.tbx_CajaBancaria.TabIndex = 3
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(102, 35)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 2
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'tbx_Sesion
        '
        Me.tbx_Sesion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Sesion.Location = New System.Drawing.Point(181, 6)
        Me.tbx_Sesion.Name = "tbx_Sesion"
        Me.tbx_Sesion.ReadOnly = True
        Me.tbx_Sesion.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Sesion.TabIndex = 1
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(136, 9)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 0
        Me.lbl_Sesion.Text = "Sesión"
        '
        'tab_DotacionesP
        '
        Me.tab_DotacionesP.Controls.Add(Me.Label5)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_RutaEntrega)
        Me.tab_DotacionesP.Controls.Add(Me.Lbl_FechAsigRut)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaAsignaRuta)
        Me.tab_DotacionesP.Controls.Add(Me.Lbl_FechAsigFech)
        Me.tab_DotacionesP.Controls.Add(Me.Lbl_UsuAsigRut)
        Me.tab_DotacionesP.Controls.Add(Me.Lbl_UsuarioAsigFech)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaAsignaFecha)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_UsuarioAsignaRuta)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_UsuarioAsignaFecha)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_StatusDP)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_Tipo)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_Moneda)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_Envases)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_Importe)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_UsuarioCancela)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_UsuarioValida)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_UsuarioCaptura)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_NombreCliente)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_Caja)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_FechaCancela)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_FechaEntrega)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_FechaValida)
        Me.tab_DotacionesP.Controls.Add(Me.lbl_FechaCaptura)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_StatusDP)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_Tipo)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_Moneda)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_Envases)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_Importe)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_UsuarioCancela)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_UsuarioValida)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_UsuarioCaptura)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_NombreCliente)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_Caja)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaCancela)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaEntrega)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaValida)
        Me.tab_DotacionesP.Controls.Add(Me.tbx_FechaCaptura)
        Me.tab_DotacionesP.Location = New System.Drawing.Point(4, 22)
        Me.tab_DotacionesP.Name = "tab_DotacionesP"
        Me.tab_DotacionesP.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DotacionesP.Size = New System.Drawing.Size(759, 380)
        Me.tab_DotacionesP.TabIndex = 3
        Me.tab_DotacionesP.Text = "Dotaciones Proceso"
        Me.tab_DotacionesP.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Ruta de Entrega"
        '
        'tbx_RutaEntrega
        '
        Me.tbx_RutaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_RutaEntrega.Location = New System.Drawing.Point(126, 84)
        Me.tbx_RutaEntrega.Name = "tbx_RutaEntrega"
        Me.tbx_RutaEntrega.ReadOnly = True
        Me.tbx_RutaEntrega.Size = New System.Drawing.Size(200, 20)
        Me.tbx_RutaEntrega.TabIndex = 37
        '
        'Lbl_FechAsigRut
        '
        Me.Lbl_FechAsigRut.AutoSize = True
        Me.Lbl_FechAsigRut.Location = New System.Drawing.Point(22, 346)
        Me.Lbl_FechAsigRut.Name = "Lbl_FechAsigRut"
        Me.Lbl_FechAsigRut.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_FechAsigRut.TabIndex = 34
        Me.Lbl_FechAsigRut.Text = "Fecha Asigna Ruta"
        '
        'tbx_FechaAsignaRuta
        '
        Me.tbx_FechaAsignaRuta.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaAsignaRuta.Location = New System.Drawing.Point(126, 343)
        Me.tbx_FechaAsignaRuta.Name = "tbx_FechaAsignaRuta"
        Me.tbx_FechaAsignaRuta.ReadOnly = True
        Me.tbx_FechaAsignaRuta.Size = New System.Drawing.Size(300, 20)
        Me.tbx_FechaAsignaRuta.TabIndex = 35
        '
        'Lbl_FechAsigFech
        '
        Me.Lbl_FechAsigFech.AutoSize = True
        Me.Lbl_FechAsigFech.Location = New System.Drawing.Point(15, 321)
        Me.Lbl_FechAsigFech.Name = "Lbl_FechAsigFech"
        Me.Lbl_FechAsigFech.Size = New System.Drawing.Size(105, 13)
        Me.Lbl_FechAsigFech.TabIndex = 32
        Me.Lbl_FechAsigFech.Text = "Fecha Asigna Fecha"
        '
        'Lbl_UsuAsigRut
        '
        Me.Lbl_UsuAsigRut.AutoSize = True
        Me.Lbl_UsuAsigRut.Location = New System.Drawing.Point(16, 295)
        Me.Lbl_UsuAsigRut.Name = "Lbl_UsuAsigRut"
        Me.Lbl_UsuAsigRut.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_UsuAsigRut.TabIndex = 30
        Me.Lbl_UsuAsigRut.Text = "Usuario Asigna Ruta"
        '
        'Lbl_UsuarioAsigFech
        '
        Me.Lbl_UsuarioAsigFech.AutoSize = True
        Me.Lbl_UsuarioAsigFech.Location = New System.Drawing.Point(9, 269)
        Me.Lbl_UsuarioAsigFech.Name = "Lbl_UsuarioAsigFech"
        Me.Lbl_UsuarioAsigFech.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_UsuarioAsigFech.TabIndex = 28
        Me.Lbl_UsuarioAsigFech.Text = "Usuario Asigna Fecha"
        '
        'tbx_FechaAsignaFecha
        '
        Me.tbx_FechaAsignaFecha.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaAsignaFecha.Location = New System.Drawing.Point(126, 318)
        Me.tbx_FechaAsignaFecha.Name = "tbx_FechaAsignaFecha"
        Me.tbx_FechaAsignaFecha.ReadOnly = True
        Me.tbx_FechaAsignaFecha.Size = New System.Drawing.Size(300, 20)
        Me.tbx_FechaAsignaFecha.TabIndex = 33
        '
        'tbx_UsuarioAsignaRuta
        '
        Me.tbx_UsuarioAsignaRuta.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioAsignaRuta.Location = New System.Drawing.Point(126, 292)
        Me.tbx_UsuarioAsignaRuta.Name = "tbx_UsuarioAsignaRuta"
        Me.tbx_UsuarioAsignaRuta.ReadOnly = True
        Me.tbx_UsuarioAsignaRuta.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioAsignaRuta.TabIndex = 31
        '
        'tbx_UsuarioAsignaFecha
        '
        Me.tbx_UsuarioAsignaFecha.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioAsignaFecha.Location = New System.Drawing.Point(126, 266)
        Me.tbx_UsuarioAsignaFecha.Name = "tbx_UsuarioAsignaFecha"
        Me.tbx_UsuarioAsignaFecha.ReadOnly = True
        Me.tbx_UsuarioAsignaFecha.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioAsignaFecha.TabIndex = 29
        '
        'lbl_StatusDP
        '
        Me.lbl_StatusDP.AutoSize = True
        Me.lbl_StatusDP.Location = New System.Drawing.Point(445, 347)
        Me.lbl_StatusDP.Name = "lbl_StatusDP"
        Me.lbl_StatusDP.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusDP.TabIndex = 26
        Me.lbl_StatusDP.Text = "Status"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(454, 321)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tipo.TabIndex = 24
        Me.lbl_Tipo.Text = "Tipo"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(436, 295)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 22
        Me.lbl_Moneda.Text = "Moneda"
        '
        'lbl_Envases
        '
        Me.lbl_Envases.AutoSize = True
        Me.lbl_Envases.Location = New System.Drawing.Point(434, 269)
        Me.lbl_Envases.Name = "lbl_Envases"
        Me.lbl_Envases.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Envases.TabIndex = 20
        Me.lbl_Envases.Text = "Envases"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Location = New System.Drawing.Point(440, 243)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Importe.TabIndex = 18
        Me.lbl_Importe.Text = "Importe"
        '
        'lbl_UsuarioCancela
        '
        Me.lbl_UsuarioCancela.AutoSize = True
        Me.lbl_UsuarioCancela.Location = New System.Drawing.Point(14, 242)
        Me.lbl_UsuarioCancela.Name = "lbl_UsuarioCancela"
        Me.lbl_UsuarioCancela.Size = New System.Drawing.Size(106, 13)
        Me.lbl_UsuarioCancela.TabIndex = 16
        Me.lbl_UsuarioCancela.Text = "Usuario que Cancela"
        '
        'lbl_UsuarioValida
        '
        Me.lbl_UsuarioValida.AutoSize = True
        Me.lbl_UsuarioValida.Location = New System.Drawing.Point(24, 216)
        Me.lbl_UsuarioValida.Name = "lbl_UsuarioValida"
        Me.lbl_UsuarioValida.Size = New System.Drawing.Size(96, 13)
        Me.lbl_UsuarioValida.TabIndex = 14
        Me.lbl_UsuarioValida.Text = "Usuario que Valida"
        '
        'lbl_UsuarioCaptura
        '
        Me.lbl_UsuarioCaptura.AutoSize = True
        Me.lbl_UsuarioCaptura.Location = New System.Drawing.Point(16, 190)
        Me.lbl_UsuarioCaptura.Name = "lbl_UsuarioCaptura"
        Me.lbl_UsuarioCaptura.Size = New System.Drawing.Size(104, 13)
        Me.lbl_UsuarioCaptura.TabIndex = 12
        Me.lbl_UsuarioCaptura.Text = "Usuario que Captura"
        '
        'lbl_NombreCliente
        '
        Me.lbl_NombreCliente.AutoSize = True
        Me.lbl_NombreCliente.Location = New System.Drawing.Point(81, 164)
        Me.lbl_NombreCliente.Name = "lbl_NombreCliente"
        Me.lbl_NombreCliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_NombreCliente.TabIndex = 10
        Me.lbl_NombreCliente.Text = "Cliente"
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(47, 138)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 8
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'lbl_FechaCancela
        '
        Me.lbl_FechaCancela.AutoSize = True
        Me.lbl_FechaCancela.Location = New System.Drawing.Point(6, 112)
        Me.lbl_FechaCancela.Name = "lbl_FechaCancela"
        Me.lbl_FechaCancela.Size = New System.Drawing.Size(114, 13)
        Me.lbl_FechaCancela.TabIndex = 6
        Me.lbl_FechaCancela.Text = "Fecha de Cancelación"
        '
        'lbl_FechaEntrega
        '
        Me.lbl_FechaEntrega.AutoSize = True
        Me.lbl_FechaEntrega.Location = New System.Drawing.Point(28, 61)
        Me.lbl_FechaEntrega.Name = "lbl_FechaEntrega"
        Me.lbl_FechaEntrega.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaEntrega.TabIndex = 4
        Me.lbl_FechaEntrega.Text = "Fecha de Entrega"
        '
        'lbl_FechaValida
        '
        Me.lbl_FechaValida.AutoSize = True
        Me.lbl_FechaValida.Location = New System.Drawing.Point(16, 35)
        Me.lbl_FechaValida.Name = "lbl_FechaValida"
        Me.lbl_FechaValida.Size = New System.Drawing.Size(104, 13)
        Me.lbl_FechaValida.TabIndex = 2
        Me.lbl_FechaValida.Text = "Fecha de Validación"
        '
        'lbl_FechaCaptura
        '
        Me.lbl_FechaCaptura.AutoSize = True
        Me.lbl_FechaCaptura.Location = New System.Drawing.Point(28, 9)
        Me.lbl_FechaCaptura.Name = "lbl_FechaCaptura"
        Me.lbl_FechaCaptura.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaCaptura.TabIndex = 0
        Me.lbl_FechaCaptura.Text = "Fecha de Captura"
        '
        'tbx_StatusDP
        '
        Me.tbx_StatusDP.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_StatusDP.Location = New System.Drawing.Point(488, 344)
        Me.tbx_StatusDP.Name = "tbx_StatusDP"
        Me.tbx_StatusDP.ReadOnly = True
        Me.tbx_StatusDP.Size = New System.Drawing.Size(200, 20)
        Me.tbx_StatusDP.TabIndex = 27
        '
        'tbx_Tipo
        '
        Me.tbx_Tipo.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Tipo.Location = New System.Drawing.Point(488, 318)
        Me.tbx_Tipo.Name = "tbx_Tipo"
        Me.tbx_Tipo.ReadOnly = True
        Me.tbx_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.tbx_Tipo.TabIndex = 25
        '
        'tbx_Moneda
        '
        Me.tbx_Moneda.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Moneda.Location = New System.Drawing.Point(488, 292)
        Me.tbx_Moneda.Name = "tbx_Moneda"
        Me.tbx_Moneda.ReadOnly = True
        Me.tbx_Moneda.Size = New System.Drawing.Size(100, 20)
        Me.tbx_Moneda.TabIndex = 23
        '
        'tbx_Envases
        '
        Me.tbx_Envases.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Envases.Location = New System.Drawing.Point(488, 266)
        Me.tbx_Envases.Name = "tbx_Envases"
        Me.tbx_Envases.ReadOnly = True
        Me.tbx_Envases.Size = New System.Drawing.Size(100, 20)
        Me.tbx_Envases.TabIndex = 21
        '
        'tbx_Importe
        '
        Me.tbx_Importe.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Importe.Location = New System.Drawing.Point(488, 240)
        Me.tbx_Importe.Name = "tbx_Importe"
        Me.tbx_Importe.ReadOnly = True
        Me.tbx_Importe.Size = New System.Drawing.Size(100, 20)
        Me.tbx_Importe.TabIndex = 19
        '
        'tbx_UsuarioCancela
        '
        Me.tbx_UsuarioCancela.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioCancela.Location = New System.Drawing.Point(126, 239)
        Me.tbx_UsuarioCancela.Name = "tbx_UsuarioCancela"
        Me.tbx_UsuarioCancela.ReadOnly = True
        Me.tbx_UsuarioCancela.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioCancela.TabIndex = 17
        '
        'tbx_UsuarioValida
        '
        Me.tbx_UsuarioValida.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioValida.Location = New System.Drawing.Point(126, 213)
        Me.tbx_UsuarioValida.Name = "tbx_UsuarioValida"
        Me.tbx_UsuarioValida.ReadOnly = True
        Me.tbx_UsuarioValida.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioValida.TabIndex = 15
        '
        'tbx_UsuarioCaptura
        '
        Me.tbx_UsuarioCaptura.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioCaptura.Location = New System.Drawing.Point(126, 187)
        Me.tbx_UsuarioCaptura.Name = "tbx_UsuarioCaptura"
        Me.tbx_UsuarioCaptura.ReadOnly = True
        Me.tbx_UsuarioCaptura.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioCaptura.TabIndex = 13
        '
        'tbx_NombreCliente
        '
        Me.tbx_NombreCliente.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreCliente.Location = New System.Drawing.Point(126, 161)
        Me.tbx_NombreCliente.Name = "tbx_NombreCliente"
        Me.tbx_NombreCliente.ReadOnly = True
        Me.tbx_NombreCliente.Size = New System.Drawing.Size(462, 20)
        Me.tbx_NombreCliente.TabIndex = 11
        '
        'tbx_Caja
        '
        Me.tbx_Caja.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Caja.Location = New System.Drawing.Point(126, 135)
        Me.tbx_Caja.Name = "tbx_Caja"
        Me.tbx_Caja.ReadOnly = True
        Me.tbx_Caja.Size = New System.Drawing.Size(462, 20)
        Me.tbx_Caja.TabIndex = 9
        '
        'tbx_FechaCancela
        '
        Me.tbx_FechaCancela.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaCancela.Location = New System.Drawing.Point(126, 109)
        Me.tbx_FechaCancela.Name = "tbx_FechaCancela"
        Me.tbx_FechaCancela.ReadOnly = True
        Me.tbx_FechaCancela.Size = New System.Drawing.Size(300, 20)
        Me.tbx_FechaCancela.TabIndex = 7
        '
        'tbx_FechaEntrega
        '
        Me.tbx_FechaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaEntrega.Location = New System.Drawing.Point(126, 58)
        Me.tbx_FechaEntrega.Name = "tbx_FechaEntrega"
        Me.tbx_FechaEntrega.ReadOnly = True
        Me.tbx_FechaEntrega.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaEntrega.TabIndex = 5
        '
        'tbx_FechaValida
        '
        Me.tbx_FechaValida.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaValida.Location = New System.Drawing.Point(126, 32)
        Me.tbx_FechaValida.Name = "tbx_FechaValida"
        Me.tbx_FechaValida.ReadOnly = True
        Me.tbx_FechaValida.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaValida.TabIndex = 3
        '
        'tbx_FechaCaptura
        '
        Me.tbx_FechaCaptura.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaCaptura.Location = New System.Drawing.Point(126, 6)
        Me.tbx_FechaCaptura.Name = "tbx_FechaCaptura"
        Me.tbx_FechaCaptura.ReadOnly = True
        Me.tbx_FechaCaptura.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaCaptura.TabIndex = 1
        '
        'Tab_DotacionesC
        '
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_UsuarioCapturaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_UsuarioCapturaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_StatusDC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_MonedaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_EnvasesC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_ImporteC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_UsuarioCancelaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_UsuarioValidaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_CajeroC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_NumeroCajeroC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_CajaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_FechaCancelaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_FechaEntregaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_FechaValidaC)
        Me.Tab_DotacionesC.Controls.Add(Me.lbl_FechaCapturaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_StatusDC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_MonedaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_EnvasesC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_ImporteC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_UsuarioCancelaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_UsuarioValidaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_CajeroC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_NumeroCajeroC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_CajaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_FechaCancelaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_FechaEntregaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_FechaValidaC)
        Me.Tab_DotacionesC.Controls.Add(Me.tbx_FechaCapturaC)
        Me.Tab_DotacionesC.Location = New System.Drawing.Point(4, 22)
        Me.Tab_DotacionesC.Name = "Tab_DotacionesC"
        Me.Tab_DotacionesC.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_DotacionesC.Size = New System.Drawing.Size(759, 380)
        Me.Tab_DotacionesC.TabIndex = 4
        Me.Tab_DotacionesC.Text = "Dotaciones Cajeros"
        Me.Tab_DotacionesC.UseVisualStyleBackColor = True
        '
        'lbl_UsuarioCapturaC
        '
        Me.lbl_UsuarioCapturaC.AutoSize = True
        Me.lbl_UsuarioCapturaC.Location = New System.Drawing.Point(16, 191)
        Me.lbl_UsuarioCapturaC.Name = "lbl_UsuarioCapturaC"
        Me.lbl_UsuarioCapturaC.Size = New System.Drawing.Size(104, 13)
        Me.lbl_UsuarioCapturaC.TabIndex = 14
        Me.lbl_UsuarioCapturaC.Text = "Usuario que Captura"
        '
        'tbx_UsuarioCapturaC
        '
        Me.tbx_UsuarioCapturaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioCapturaC.Location = New System.Drawing.Point(126, 188)
        Me.tbx_UsuarioCapturaC.Name = "tbx_UsuarioCapturaC"
        Me.tbx_UsuarioCapturaC.ReadOnly = True
        Me.tbx_UsuarioCapturaC.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioCapturaC.TabIndex = 15
        '
        'lbl_StatusDC
        '
        Me.lbl_StatusDC.AutoSize = True
        Me.lbl_StatusDC.Location = New System.Drawing.Point(83, 347)
        Me.lbl_StatusDC.Name = "lbl_StatusDC"
        Me.lbl_StatusDC.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusDC.TabIndex = 26
        Me.lbl_StatusDC.Text = "Status"
        '
        'lbl_MonedaC
        '
        Me.lbl_MonedaC.AutoSize = True
        Me.lbl_MonedaC.Location = New System.Drawing.Point(74, 321)
        Me.lbl_MonedaC.Name = "lbl_MonedaC"
        Me.lbl_MonedaC.Size = New System.Drawing.Size(46, 13)
        Me.lbl_MonedaC.TabIndex = 24
        Me.lbl_MonedaC.Text = "Moneda"
        '
        'lbl_EnvasesC
        '
        Me.lbl_EnvasesC.AutoSize = True
        Me.lbl_EnvasesC.Location = New System.Drawing.Point(72, 295)
        Me.lbl_EnvasesC.Name = "lbl_EnvasesC"
        Me.lbl_EnvasesC.Size = New System.Drawing.Size(48, 13)
        Me.lbl_EnvasesC.TabIndex = 22
        Me.lbl_EnvasesC.Text = "Envases"
        '
        'lbl_ImporteC
        '
        Me.lbl_ImporteC.AutoSize = True
        Me.lbl_ImporteC.Location = New System.Drawing.Point(78, 269)
        Me.lbl_ImporteC.Name = "lbl_ImporteC"
        Me.lbl_ImporteC.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ImporteC.TabIndex = 20
        Me.lbl_ImporteC.Text = "Importe"
        '
        'lbl_UsuarioCancelaC
        '
        Me.lbl_UsuarioCancelaC.AutoSize = True
        Me.lbl_UsuarioCancelaC.Location = New System.Drawing.Point(14, 243)
        Me.lbl_UsuarioCancelaC.Name = "lbl_UsuarioCancelaC"
        Me.lbl_UsuarioCancelaC.Size = New System.Drawing.Size(106, 13)
        Me.lbl_UsuarioCancelaC.TabIndex = 18
        Me.lbl_UsuarioCancelaC.Text = "Usuario que Cancela"
        '
        'lbl_UsuarioValidaC
        '
        Me.lbl_UsuarioValidaC.AutoSize = True
        Me.lbl_UsuarioValidaC.Location = New System.Drawing.Point(24, 217)
        Me.lbl_UsuarioValidaC.Name = "lbl_UsuarioValidaC"
        Me.lbl_UsuarioValidaC.Size = New System.Drawing.Size(96, 13)
        Me.lbl_UsuarioValidaC.TabIndex = 16
        Me.lbl_UsuarioValidaC.Text = "Usuario que Valida"
        '
        'lbl_CajeroC
        '
        Me.lbl_CajeroC.AutoSize = True
        Me.lbl_CajeroC.Location = New System.Drawing.Point(7, 165)
        Me.lbl_CajeroC.Name = "lbl_CajeroC"
        Me.lbl_CajeroC.Size = New System.Drawing.Size(113, 13)
        Me.lbl_CajeroC.TabIndex = 12
        Me.lbl_CajeroC.Text = "Descripción del Cajero"
        '
        'lbl_NumeroCajeroC
        '
        Me.lbl_NumeroCajeroC.AutoSize = True
        Me.lbl_NumeroCajeroC.Location = New System.Drawing.Point(28, 139)
        Me.lbl_NumeroCajeroC.Name = "lbl_NumeroCajeroC"
        Me.lbl_NumeroCajeroC.Size = New System.Drawing.Size(92, 13)
        Me.lbl_NumeroCajeroC.TabIndex = 10
        Me.lbl_NumeroCajeroC.Text = "Número de Cajero"
        '
        'lbl_CajaC
        '
        Me.lbl_CajaC.AutoSize = True
        Me.lbl_CajaC.Location = New System.Drawing.Point(47, 113)
        Me.lbl_CajaC.Name = "lbl_CajaC"
        Me.lbl_CajaC.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaC.TabIndex = 8
        Me.lbl_CajaC.Text = "Caja Bancaria"
        '
        'lbl_FechaCancelaC
        '
        Me.lbl_FechaCancelaC.AutoSize = True
        Me.lbl_FechaCancelaC.Location = New System.Drawing.Point(6, 87)
        Me.lbl_FechaCancelaC.Name = "lbl_FechaCancelaC"
        Me.lbl_FechaCancelaC.Size = New System.Drawing.Size(114, 13)
        Me.lbl_FechaCancelaC.TabIndex = 6
        Me.lbl_FechaCancelaC.Text = "Fecha de Cancelación"
        '
        'lbl_FechaEntregaC
        '
        Me.lbl_FechaEntregaC.AutoSize = True
        Me.lbl_FechaEntregaC.Location = New System.Drawing.Point(28, 61)
        Me.lbl_FechaEntregaC.Name = "lbl_FechaEntregaC"
        Me.lbl_FechaEntregaC.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaEntregaC.TabIndex = 4
        Me.lbl_FechaEntregaC.Text = "Fecha de Entrega"
        '
        'lbl_FechaValidaC
        '
        Me.lbl_FechaValidaC.AutoSize = True
        Me.lbl_FechaValidaC.Location = New System.Drawing.Point(16, 35)
        Me.lbl_FechaValidaC.Name = "lbl_FechaValidaC"
        Me.lbl_FechaValidaC.Size = New System.Drawing.Size(104, 13)
        Me.lbl_FechaValidaC.TabIndex = 2
        Me.lbl_FechaValidaC.Text = "Fecha de Validación"
        '
        'lbl_FechaCapturaC
        '
        Me.lbl_FechaCapturaC.AutoSize = True
        Me.lbl_FechaCapturaC.Location = New System.Drawing.Point(28, 9)
        Me.lbl_FechaCapturaC.Name = "lbl_FechaCapturaC"
        Me.lbl_FechaCapturaC.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaCapturaC.TabIndex = 0
        Me.lbl_FechaCapturaC.Text = "Fecha de Captura"
        '
        'tbx_StatusDC
        '
        Me.tbx_StatusDC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_StatusDC.Location = New System.Drawing.Point(126, 344)
        Me.tbx_StatusDC.Name = "tbx_StatusDC"
        Me.tbx_StatusDC.ReadOnly = True
        Me.tbx_StatusDC.Size = New System.Drawing.Size(200, 20)
        Me.tbx_StatusDC.TabIndex = 27
        '
        'tbx_MonedaC
        '
        Me.tbx_MonedaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_MonedaC.Location = New System.Drawing.Point(126, 318)
        Me.tbx_MonedaC.Name = "tbx_MonedaC"
        Me.tbx_MonedaC.ReadOnly = True
        Me.tbx_MonedaC.Size = New System.Drawing.Size(100, 20)
        Me.tbx_MonedaC.TabIndex = 25
        '
        'tbx_EnvasesC
        '
        Me.tbx_EnvasesC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EnvasesC.Location = New System.Drawing.Point(126, 292)
        Me.tbx_EnvasesC.Name = "tbx_EnvasesC"
        Me.tbx_EnvasesC.ReadOnly = True
        Me.tbx_EnvasesC.Size = New System.Drawing.Size(100, 20)
        Me.tbx_EnvasesC.TabIndex = 23
        '
        'tbx_ImporteC
        '
        Me.tbx_ImporteC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ImporteC.Location = New System.Drawing.Point(126, 266)
        Me.tbx_ImporteC.Name = "tbx_ImporteC"
        Me.tbx_ImporteC.ReadOnly = True
        Me.tbx_ImporteC.Size = New System.Drawing.Size(100, 20)
        Me.tbx_ImporteC.TabIndex = 21
        '
        'tbx_UsuarioCancelaC
        '
        Me.tbx_UsuarioCancelaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioCancelaC.Location = New System.Drawing.Point(126, 240)
        Me.tbx_UsuarioCancelaC.Name = "tbx_UsuarioCancelaC"
        Me.tbx_UsuarioCancelaC.ReadOnly = True
        Me.tbx_UsuarioCancelaC.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioCancelaC.TabIndex = 19
        '
        'tbx_UsuarioValidaC
        '
        Me.tbx_UsuarioValidaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioValidaC.Location = New System.Drawing.Point(126, 214)
        Me.tbx_UsuarioValidaC.Name = "tbx_UsuarioValidaC"
        Me.tbx_UsuarioValidaC.ReadOnly = True
        Me.tbx_UsuarioValidaC.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioValidaC.TabIndex = 17
        '
        'tbx_CajeroC
        '
        Me.tbx_CajeroC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CajeroC.Location = New System.Drawing.Point(126, 162)
        Me.tbx_CajeroC.Name = "tbx_CajeroC"
        Me.tbx_CajeroC.ReadOnly = True
        Me.tbx_CajeroC.Size = New System.Drawing.Size(462, 20)
        Me.tbx_CajeroC.TabIndex = 13
        '
        'tbx_NumeroCajeroC
        '
        Me.tbx_NumeroCajeroC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NumeroCajeroC.Location = New System.Drawing.Point(126, 136)
        Me.tbx_NumeroCajeroC.Name = "tbx_NumeroCajeroC"
        Me.tbx_NumeroCajeroC.ReadOnly = True
        Me.tbx_NumeroCajeroC.Size = New System.Drawing.Size(300, 20)
        Me.tbx_NumeroCajeroC.TabIndex = 11
        '
        'tbx_CajaC
        '
        Me.tbx_CajaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CajaC.Location = New System.Drawing.Point(126, 110)
        Me.tbx_CajaC.Name = "tbx_CajaC"
        Me.tbx_CajaC.ReadOnly = True
        Me.tbx_CajaC.Size = New System.Drawing.Size(462, 20)
        Me.tbx_CajaC.TabIndex = 9
        '
        'tbx_FechaCancelaC
        '
        Me.tbx_FechaCancelaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaCancelaC.Location = New System.Drawing.Point(126, 84)
        Me.tbx_FechaCancelaC.Name = "tbx_FechaCancelaC"
        Me.tbx_FechaCancelaC.ReadOnly = True
        Me.tbx_FechaCancelaC.Size = New System.Drawing.Size(300, 20)
        Me.tbx_FechaCancelaC.TabIndex = 7
        '
        'tbx_FechaEntregaC
        '
        Me.tbx_FechaEntregaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaEntregaC.Location = New System.Drawing.Point(126, 58)
        Me.tbx_FechaEntregaC.Name = "tbx_FechaEntregaC"
        Me.tbx_FechaEntregaC.ReadOnly = True
        Me.tbx_FechaEntregaC.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaEntregaC.TabIndex = 5
        '
        'tbx_FechaValidaC
        '
        Me.tbx_FechaValidaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaValidaC.Location = New System.Drawing.Point(126, 32)
        Me.tbx_FechaValidaC.Name = "tbx_FechaValidaC"
        Me.tbx_FechaValidaC.ReadOnly = True
        Me.tbx_FechaValidaC.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaValidaC.TabIndex = 3
        '
        'tbx_FechaCapturaC
        '
        Me.tbx_FechaCapturaC.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaCapturaC.Location = New System.Drawing.Point(126, 6)
        Me.tbx_FechaCapturaC.Name = "tbx_FechaCapturaC"
        Me.tbx_FechaCapturaC.ReadOnly = True
        Me.tbx_FechaCapturaC.Size = New System.Drawing.Size(200, 20)
        Me.tbx_FechaCapturaC.TabIndex = 1
        '
        'Tab_Materiales
        '
        Me.Tab_Materiales.Controls.Add(Me.lbl_StatusM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_StatusM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_UsuarioValidaM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_UsuarioRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_HoraValidaM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_FechaValidaM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_HoraRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_FechaRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.lbl_DestinoM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_UsuarioValidaM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_UsuarioRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_HoraValidaM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_FechaValidaM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_HoraRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_FechaRegistroM)
        Me.Tab_Materiales.Controls.Add(Me.tbx_DestinoM)
        Me.Tab_Materiales.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Materiales.Name = "Tab_Materiales"
        Me.Tab_Materiales.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Materiales.Size = New System.Drawing.Size(759, 380)
        Me.Tab_Materiales.TabIndex = 5
        Me.Tab_Materiales.Text = "Materiales"
        Me.Tab_Materiales.UseVisualStyleBackColor = True
        '
        'lbl_StatusM
        '
        Me.lbl_StatusM.AutoSize = True
        Me.lbl_StatusM.Location = New System.Drawing.Point(73, 191)
        Me.lbl_StatusM.Name = "lbl_StatusM"
        Me.lbl_StatusM.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusM.TabIndex = 14
        Me.lbl_StatusM.Text = "Status"
        '
        'tbx_StatusM
        '
        Me.tbx_StatusM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_StatusM.Location = New System.Drawing.Point(118, 188)
        Me.tbx_StatusM.Name = "tbx_StatusM"
        Me.tbx_StatusM.ReadOnly = True
        Me.tbx_StatusM.Size = New System.Drawing.Size(200, 20)
        Me.tbx_StatusM.TabIndex = 15
        '
        'lbl_UsuarioValidaM
        '
        Me.lbl_UsuarioValidaM.AutoSize = True
        Me.lbl_UsuarioValidaM.Location = New System.Drawing.Point(16, 165)
        Me.lbl_UsuarioValidaM.Name = "lbl_UsuarioValidaM"
        Me.lbl_UsuarioValidaM.Size = New System.Drawing.Size(96, 13)
        Me.lbl_UsuarioValidaM.TabIndex = 12
        Me.lbl_UsuarioValidaM.Text = "Usuario que Valida"
        '
        'lbl_UsuarioRegistroM
        '
        Me.lbl_UsuarioRegistroM.AutoSize = True
        Me.lbl_UsuarioRegistroM.Location = New System.Drawing.Point(6, 87)
        Me.lbl_UsuarioRegistroM.Name = "lbl_UsuarioRegistroM"
        Me.lbl_UsuarioRegistroM.Size = New System.Drawing.Size(106, 13)
        Me.lbl_UsuarioRegistroM.TabIndex = 6
        Me.lbl_UsuarioRegistroM.Text = "Usuario que Registra"
        '
        'lbl_HoraValidaM
        '
        Me.lbl_HoraValidaM.AutoSize = True
        Me.lbl_HoraValidaM.Location = New System.Drawing.Point(15, 139)
        Me.lbl_HoraValidaM.Name = "lbl_HoraValidaM"
        Me.lbl_HoraValidaM.Size = New System.Drawing.Size(97, 13)
        Me.lbl_HoraValidaM.TabIndex = 10
        Me.lbl_HoraValidaM.Text = "Hora de Validación"
        '
        'lbl_FechaValidaM
        '
        Me.lbl_FechaValidaM.AutoSize = True
        Me.lbl_FechaValidaM.Location = New System.Drawing.Point(8, 113)
        Me.lbl_FechaValidaM.Name = "lbl_FechaValidaM"
        Me.lbl_FechaValidaM.Size = New System.Drawing.Size(104, 13)
        Me.lbl_FechaValidaM.TabIndex = 8
        Me.lbl_FechaValidaM.Text = "Fecha de Validación"
        '
        'lbl_HoraRegistroM
        '
        Me.lbl_HoraRegistroM.AutoSize = True
        Me.lbl_HoraRegistroM.Location = New System.Drawing.Point(25, 61)
        Me.lbl_HoraRegistroM.Name = "lbl_HoraRegistroM"
        Me.lbl_HoraRegistroM.Size = New System.Drawing.Size(87, 13)
        Me.lbl_HoraRegistroM.TabIndex = 4
        Me.lbl_HoraRegistroM.Text = "Hora de Registro"
        '
        'lbl_FechaRegistroM
        '
        Me.lbl_FechaRegistroM.AutoSize = True
        Me.lbl_FechaRegistroM.Location = New System.Drawing.Point(18, 35)
        Me.lbl_FechaRegistroM.Name = "lbl_FechaRegistroM"
        Me.lbl_FechaRegistroM.Size = New System.Drawing.Size(94, 13)
        Me.lbl_FechaRegistroM.TabIndex = 2
        Me.lbl_FechaRegistroM.Text = "Fecha de Registro"
        '
        'lbl_DestinoM
        '
        Me.lbl_DestinoM.AutoSize = True
        Me.lbl_DestinoM.Location = New System.Drawing.Point(69, 9)
        Me.lbl_DestinoM.Name = "lbl_DestinoM"
        Me.lbl_DestinoM.Size = New System.Drawing.Size(43, 13)
        Me.lbl_DestinoM.TabIndex = 0
        Me.lbl_DestinoM.Text = "Destino"
        '
        'tbx_UsuarioValidaM
        '
        Me.tbx_UsuarioValidaM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioValidaM.Location = New System.Drawing.Point(118, 162)
        Me.tbx_UsuarioValidaM.Name = "tbx_UsuarioValidaM"
        Me.tbx_UsuarioValidaM.ReadOnly = True
        Me.tbx_UsuarioValidaM.Size = New System.Drawing.Size(300, 20)
        Me.tbx_UsuarioValidaM.TabIndex = 13
        '
        'tbx_UsuarioRegistroM
        '
        Me.tbx_UsuarioRegistroM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioRegistroM.Location = New System.Drawing.Point(118, 84)
        Me.tbx_UsuarioRegistroM.Name = "tbx_UsuarioRegistroM"
        Me.tbx_UsuarioRegistroM.ReadOnly = True
        Me.tbx_UsuarioRegistroM.Size = New System.Drawing.Size(100, 20)
        Me.tbx_UsuarioRegistroM.TabIndex = 7
        '
        'tbx_HoraValidaM
        '
        Me.tbx_HoraValidaM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_HoraValidaM.Location = New System.Drawing.Point(118, 136)
        Me.tbx_HoraValidaM.Name = "tbx_HoraValidaM"
        Me.tbx_HoraValidaM.ReadOnly = True
        Me.tbx_HoraValidaM.Size = New System.Drawing.Size(300, 20)
        Me.tbx_HoraValidaM.TabIndex = 11
        '
        'tbx_FechaValidaM
        '
        Me.tbx_FechaValidaM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaValidaM.Location = New System.Drawing.Point(118, 110)
        Me.tbx_FechaValidaM.Name = "tbx_FechaValidaM"
        Me.tbx_FechaValidaM.ReadOnly = True
        Me.tbx_FechaValidaM.Size = New System.Drawing.Size(100, 20)
        Me.tbx_FechaValidaM.TabIndex = 9
        '
        'tbx_HoraRegistroM
        '
        Me.tbx_HoraRegistroM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_HoraRegistroM.Location = New System.Drawing.Point(118, 58)
        Me.tbx_HoraRegistroM.Name = "tbx_HoraRegistroM"
        Me.tbx_HoraRegistroM.ReadOnly = True
        Me.tbx_HoraRegistroM.Size = New System.Drawing.Size(100, 20)
        Me.tbx_HoraRegistroM.TabIndex = 5
        '
        'tbx_FechaRegistroM
        '
        Me.tbx_FechaRegistroM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaRegistroM.Location = New System.Drawing.Point(118, 32)
        Me.tbx_FechaRegistroM.Name = "tbx_FechaRegistroM"
        Me.tbx_FechaRegistroM.ReadOnly = True
        Me.tbx_FechaRegistroM.Size = New System.Drawing.Size(100, 20)
        Me.tbx_FechaRegistroM.TabIndex = 3
        '
        'tbx_DestinoM
        '
        Me.tbx_DestinoM.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DestinoM.Location = New System.Drawing.Point(118, 6)
        Me.tbx_DestinoM.Name = "tbx_DestinoM"
        Me.tbx_DestinoM.ReadOnly = True
        Me.tbx_DestinoM.Size = New System.Drawing.Size(462, 20)
        Me.tbx_DestinoM.TabIndex = 1
        '
        'frm_Rastreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Rastreo"
        Me.Tag = "RASTREO DE REMISIONES"
        Me.Text = "RASTREO DE REMISIONES"
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.tc.ResumeLayout(False)
        Me.tab_Remisiones.ResumeLayout(False)
        Me.gbx_Envases.ResumeLayout(False)
        Me.gbx_Importes.ResumeLayout(False)
        Me.tab_Traslado.ResumeLayout(False)
        Me.tab_Traslado.PerformLayout()
        Me.tab_Boveda.ResumeLayout(False)
        Me.tab_Boveda.PerformLayout()
        Me.Tab_Proceso.ResumeLayout(False)
        Me.Tab_Proceso.PerformLayout()
        Me.tab_DotacionesP.ResumeLayout(False)
        Me.tab_DotacionesP.PerformLayout()
        Me.Tab_DotacionesC.ResumeLayout(False)
        Me.Tab_DotacionesC.PerformLayout()
        Me.Tab_Materiales.ResumeLayout(False)
        Me.Tab_Materiales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents tc As System.Windows.Forms.TabControl
    Friend WithEvents tab_Boveda As System.Windows.Forms.TabPage
    Friend WithEvents tab_Remisiones As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Facturacion.cp_Textbox
    Friend WithEvents lbl_CiaTraslado As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Cia As Modulo_Facturacion.cp_cmb_Parametro
    Friend WithEvents lsv_Importe As Modulo_Facturacion.cp_Listview
    Friend WithEvents lsv_Envases As Modulo_Facturacion.cp_Listview
    Friend WithEvents gbx_Importes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Envases As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_HoraSalida As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaSalida As System.Windows.Forms.Label
    Friend WithEvents tbx_HoraSalida As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaSalida As System.Windows.Forms.TextBox
    Friend WithEvents tbx_HoraEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lbl_HoraEntrada As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioSalida As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioEntrada As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioSalida As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioEntrada As System.Windows.Forms.TextBox
    Friend WithEvents cbx_ConcentracionATM As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_Materiales As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_DotacionATM As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_DotacionMorralla As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_DotacionPro As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents tbx_Status As System.Windows.Forms.TextBox
    Friend WithEvents cbx_DotacionNom As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_CustodiaATM As System.Windows.Forms.CheckBox
    Friend WithEvents Tab_Proceso As System.Windows.Forms.TabPage
    Friend WithEvents tbx_CajaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents tbx_Sesion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents tbx_Cajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents tbx_GrupoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GrupoDeposito As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechadeRecepcion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaInicioVerificacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaInicioVerificacion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaAsignacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaAsignacion As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFinVerificacion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaFinVerificacion As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaContabilizacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaContabilizacion As System.Windows.Forms.Label
    Friend WithEvents tbx_Fichas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Fichas As System.Windows.Forms.Label
    Friend WithEvents tbx_MinutosVerificando As System.Windows.Forms.TextBox
    Friend WithEvents lbl_StatusPro As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusPro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MinutosVerificando As System.Windows.Forms.Label
    Friend WithEvents lbl_CantidadFichasC As System.Windows.Forms.Label
    Friend WithEvents lbl_Estacion_Asigna As System.Windows.Forms.Label
    Friend WithEvents tbx_EstacionVerifica As System.Windows.Forms.TextBox
    Friend WithEvents tbx_EstacionAsigna As System.Windows.Forms.TextBox
    Friend WithEvents tbx_EstacionRecibe As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EstacionRecibe As System.Windows.Forms.Label
    Friend WithEvents tbx_Corte As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CorteTurno As System.Windows.Forms.Label
    Friend WithEvents tbx_FichasContabilizadas As System.Windows.Forms.TextBox
    Friend WithEvents tab_DotacionesP As System.Windows.Forms.TabPage
    Friend WithEvents lbl_EstacionVerifica As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaValida As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaCaptura As System.Windows.Forms.Label
    Friend WithEvents tbx_Moneda As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Envases As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Importe As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioCancela As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioValida As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioCaptura As System.Windows.Forms.TextBox
    Friend WithEvents tbx_NombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Caja As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaCancela As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaEntrega As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaValida As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaCaptura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents lbl_Envases As System.Windows.Forms.Label
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioCancela As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioValida As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioCaptura As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaCancela As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaEntrega As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusDP As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Tipo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_StatusDP As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents Tab_DotacionesC As System.Windows.Forms.TabPage
    Friend WithEvents lbl_StatusDC As System.Windows.Forms.Label
    Friend WithEvents lbl_MonedaC As System.Windows.Forms.Label
    Friend WithEvents lbl_EnvasesC As System.Windows.Forms.Label
    Friend WithEvents lbl_ImporteC As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioCancelaC As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioValidaC As System.Windows.Forms.Label
    Friend WithEvents lbl_CajeroC As System.Windows.Forms.Label
    Friend WithEvents lbl_NumeroCajeroC As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaC As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaCancelaC As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaEntregaC As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaValidaC As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaCapturaC As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusDC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_MonedaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_EnvasesC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ImporteC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioCancelaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioValidaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_CajeroC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_NumeroCajeroC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_CajaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaCancelaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaEntregaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaValidaC As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaCapturaC As System.Windows.Forms.TextBox
    Friend WithEvents lbl_UsuarioCapturaC As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioCapturaC As System.Windows.Forms.TextBox
    Friend WithEvents Tab_Materiales As System.Windows.Forms.TabPage
    Friend WithEvents lbl_UsuarioValidaM As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioRegistroM As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraValidaM As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaValidaM As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraRegistroM As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaRegistroM As System.Windows.Forms.Label
    Friend WithEvents lbl_DestinoM As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioValidaM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioRegistroM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_HoraValidaM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaValidaM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_HoraRegistroM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaRegistroM As System.Windows.Forms.TextBox
    Friend WithEvents tbx_DestinoM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_StatusM As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusM As System.Windows.Forms.TextBox
    Friend WithEvents tab_Traslado As System.Windows.Forms.TabPage
    Friend WithEvents lbl_StatusT As System.Windows.Forms.Label
    Friend WithEvents lbl_HorarioEntregaT As System.Windows.Forms.Label
    Friend WithEvents lbl_HorarioRecoleccionT As System.Windows.Forms.Label
    Friend WithEvents lbl_OperadorT As System.Windows.Forms.Label
    Friend WithEvents lbl_CajeroT As System.Windows.Forms.Label
    Friend WithEvents lbl_DestinoT As System.Windows.Forms.Label
    Friend WithEvents lbl_OrigenT As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaT As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_HorarioEntregaT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_HorarioRecoleccionT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_OperadorT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_CajeroT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_DestinoT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_OrigenT As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaT As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RutaT As System.Windows.Forms.Label
    Friend WithEvents tbx_RutaT As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Leyenda As System.Windows.Forms.Label
    Friend WithEvents lsv_AsignaFecha As Modulo_Facturacion.cp_Listview
    Friend WithEvents Lbl_FechAsigRut As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaAsignaRuta As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_FechAsigFech As System.Windows.Forms.Label
    Friend WithEvents Lbl_UsuAsigRut As System.Windows.Forms.Label
    Friend WithEvents Lbl_UsuarioAsigFech As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaAsignaFecha As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioAsignaRuta As System.Windows.Forms.TextBox
    Friend WithEvents tbx_UsuarioAsignaFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbx_RutaEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
