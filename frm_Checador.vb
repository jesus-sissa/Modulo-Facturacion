Public Class frm_Checador

    Private Sub frm_Checador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        lsv_Datos.Columns.Add("Reloj")
        lsv_Datos.Columns.Add("Calve")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Hora")

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de Fechas es incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If Not cn_Checador.fn_Checador_LlenarLista(lsv_Datos, dtp_Desde.Value.Date, dtp_Hasta.Value.Date) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lbl_Registros.Text = "Registros: " & lsv_Datos.Items.Count
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        lsv_Datos.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        lsv_Datos.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then btn_Mostrar.Focus()
    End Sub


End Class