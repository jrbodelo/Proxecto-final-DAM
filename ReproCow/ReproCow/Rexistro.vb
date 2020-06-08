Imports MySql.Data.MySqlClient

Public Class Rexistro
    Dim DtaToros As New MySqlDataAdapter
    Dim Fila As DataRow
    Dim arrayTipos As String() = {"Inseminación", "1ª Revisión", "2ª Revisión", "Secado", "Parto"}
    Dim proceso As String
    Dim arrayResultado As String() = {"Positivo", "Negativo"}

    Dim arraySexoRevision As String() = {"Macho", "Femia"}
    Private Sub Rexistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proceso = Principal.lblTipoRexistro.Text.ToString
        If proceso.Length < 2 Then
            proceso = "Inseminación"
        Else
            Select Case proceso

                Case "Inseminación"
                    proceso = "1ª Revisión"
                Case "1ª Revisión"
                    proceso = "2ª Revisión"
                Case "2ª Revisión"
                    proceso = "Secado"
                Case "Secado"
                    proceso = "Parto"
                Case "Parto"
                    proceso = "Inseminación"

            End Select
        End If

        lblProceso.Text = proceso
        cmbResultadoRevision1.Items.Clear()
        cmbResultadoRevision1.Items.AddRange(arrayResultado)
        cmbResultadoRevision1.SelectedIndex = 0

        cmbResultadoRevision2.Items.Clear()
        cmbResultadoRevision2.Items.AddRange(arrayResultado)
        cmbResultadoRevision2.SelectedIndex = 0

        cmbSexoRevision.Items.Clear()
        cmbSexoRevision.Items.AddRange(arraySexoRevision)
        cmbSexoRevision.SelectedIndex = 0

        cmbSexoParto.Items.Clear()
        cmbSexoParto.Items.AddRange(arraySexoRevision)
        cmbSexoParto.SelectedIndex = 0

        gbInseminacion.Visible = True
        gbParto.Visible = False
        gbRevision1.Visible = False
        gbRevision2.Visible = False
        gbSecado.Visible = False
        CargarCajas()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub


    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub CargarCajas()
        Select Case lblProceso.Text
            Case "Inseminación"
                gbInseminacion.Visible = True
                gbParto.Visible = False
                gbRevision1.Visible = False
                gbRevision2.Visible = False
                gbSecado.Visible = False

                Principal.CnnReproducion.Open()
                Dim consulta As String
                consulta = "SELECT * FROM Toro where dosis_stock > 0"
                DtaToros = New MySqlDataAdapter(consulta, Principal.CnnReproducion)
                If Principal.DtsRepro.Tables("Toro") IsNot Nothing Then
                    Principal.DtsRepro.Tables("Toro").Rows.Clear()
                End If
                DtaToros.Fill(Principal.DtsRepro, "Toro")
                cmbSemental.DataSource = Principal.DtsRepro.Tables("Toro")
                cmbSemental.DisplayMember = "nome"
                Principal.CnnReproducion.Close()

            Case "1ª Revisión"
                gbInseminacion.Visible = False
                gbParto.Visible = False
                gbRevision1.Visible = True
                gbRevision2.Visible = False
                gbSecado.Visible = False
            Case "2ª Revisión"
                gbInseminacion.Visible = False
                gbParto.Visible = False
                gbRevision1.Visible = False
                gbRevision2.Visible = True
                gbSecado.Visible = False
            Case "Secado"
                gbInseminacion.Visible = False
                gbParto.Visible = False
                gbRevision1.Visible = False
                gbRevision2.Visible = False
                gbSecado.Visible = True
            Case "Parto"
                gbInseminacion.Visible = False
                gbParto.Visible = True
                gbRevision1.Visible = False
                gbRevision2.Visible = False
                gbSecado.Visible = False
        End Select
    End Sub
End Class