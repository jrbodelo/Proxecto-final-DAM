Imports MySql.Data.MySqlClient

Public Class Toros
    Dim DtaToros As New MySqlDataAdapter
    Dim Fila As DataRow
    Private Sub Toros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvToros.AllowUserToAddRows = False

        Principal.CnnReproducion.Open()
        Dim consulta As String
        consulta = "SELECT * FROM Toro"
        DtaToros = New MySqlDataAdapter(consulta, Principal.CnnReproducion)
        If Principal.DtsRepro.Tables("Toro") IsNot Nothing Then
            Principal.DtsRepro.Tables("Toro").Rows.Clear()
        End If

        DtaToros.Fill(Principal.DtsRepro, "Toro")
        dgvToros.DataSource = Principal.DtsRepro.Tables("Toro")
        Principal.CnnReproducion.Close()

        AxustarCabeceira()
        EncherCampos()
    End Sub
    Private Sub AxustarCabeceira()
        dgvToros.Columns(0).HeaderText = "Código"
        dgvToros.Columns(0).FillWeight = "50"
        dgvToros.Columns(1).HeaderText = "Crotal"
        dgvToros.Columns(2).HeaderText = "Nome"
        dgvToros.Columns(3).HeaderText = "1º Apelido"
        dgvToros.Columns(4).HeaderText = "2º Apelido"
        dgvToros.Columns(5).HeaderText = "Dosis"
        dgvToros.Columns(1).Width = dgvToros.Columns(1).Width + 20
    End Sub

    Private Sub EncherCampos()
        lblNome.DataBindings.Add("Text", Principal.DtsRepro.Tables("Toro"), "nome")
        lblCrotal.DataBindings.Add("Text", Principal.DtsRepro.Tables("Toro"), "crotal")
        lblApelido1.DataBindings.Add("Text", Principal.DtsRepro.Tables("Toro"), "apelido_1")
        lblApelido2.DataBindings.Add("Text", Principal.DtsRepro.Tables("Toro"), "apelido_2")
        lblDosis.DataBindings.Add("Text", Principal.DtsRepro.Tables("Toro"), "dosis_stock")

    End Sub

    Private Sub NovoToroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToroToolStripMenuItem.Click
        NovoToro()
    End Sub

    Private Sub NovoToro()
        Dim frmNovoToro As New Nuevo_modificar_toro
        With frmNovoToro
            .Text = "Novo Toro"
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If


            Dim crotal As String = .txtCrotal.Text
            Dim nome As String = .txtNome.Text
            Dim apelido1 As String = .txtApelido1.Text
            Dim apelido2 As String = .txtApelido2.Text
            Dim dosis As Integer = .nudDosis.Value

            If crotal = "" Or nome = "" Or apelido1 = "" Or apelido2 = "" Then
                MsgBox("Debes cubrir os campos obrigatorios (*)!", MsgBoxStyle.Exclamation)
                NovoToro()
            End If

            Dim cadeaInsertar As String
            cadeaInsertar = "INSERT INTO Toro (crotal,nome,apelido_1,apelido_2,dosis_stock) VALUES ("
            cadeaInsertar += "'" & crotal & "',"
            cadeaInsertar += "'" & nome & "',"
            cadeaInsertar += "'" & apelido1 & "',"
            cadeaInsertar += "'" & apelido2 & "',"
            cadeaInsertar += dosis & ");"
            Dim engade As New MySqlCommand(cadeaInsertar, Principal.CnnReproducion)
            engade.Connection.Open()
            engade.ExecuteNonQuery()

            Fila = Principal.DtsRepro.Tables("Toro").NewRow
            Dim codigo As String

            Try
                codigo = Principal.DtsRepro.Tables("Toro").Rows(Principal.DtsRepro.Tables("Toro").Rows.Count - 1).Item(0) + 1
            Catch ex As Exception
                codigo = 1
            End Try


            Fila("cod_toro") = codigo
            Fila("crotal") = crotal
            Fila("nome") = nome
            Fila("apelido_1") = apelido1
            Fila("apelido_2") = apelido2
            Fila("dosis_stock") = dosis

            Principal.DtsRepro.Tables("Toro").Rows.Add(Fila)
            Principal.DtsRepro.Tables("Toro").AcceptChanges()

            engade.Connection.Close()
        End With
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ModificarToro()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        BorrarToro()
    End Sub

    Private Sub BorrarToro()
        If MsgBox("Estás seguro de que queres borrar este toro?",
        MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
        "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim posicion As Integer
        posicion = Me.BindingContext(Principal.DtsRepro.Tables("Toro")).Position
        Fila = Principal.DtsRepro.Tables("Toro").Rows(posicion)
        Dim codigoToro As Integer = Principal.DtsRepro.Tables("Toro").Rows(posicion).Item(0)
        Fila.Delete()
        Principal.DtsRepro.Tables("Toro").AcceptChanges()

        Dim cadeaBorrar As String = "DELETE FROM Toro WHERE cod_toro=" & codigoToro & ";"
        Dim borra As New MySqlCommand(cadeaBorrar, Principal.CnnReproducion)
        borra.Connection.Open()
        borra.ExecuteNonQuery()
        borra.Connection.Close()

    End Sub

    Private Sub ModificarToro()
        Dim frmModificarToro As New Nuevo_modificar_toro

        With frmModificarToro
            Dim posicion As Integer
            posicion = Me.BindingContext(Principal.DtsRepro.Tables("Toro")).Position
            Fila = Principal.DtsRepro.Tables("Toro").Rows(posicion)

            .Text = "Modificar Toro"
            .txtCrotal.Text = lblCrotal.Text
            .txtNome.Text = lblNome.Text
            .txtApelido1.Text = lblApelido1.Text
            .txtApelido2.Text = lblApelido2.Text
            .nudDosis.Value = Integer.Parse(lblDosis.Text)

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            If .txtCrotal.Text = "" Or .txtNome.Text = "" Or .txtApelido1.Text = "" Or .txtApelido2.Text = "" Then
                MsgBox("Debes cubrir os campos obrigatorios (*)!", MsgBoxStyle.Exclamation)
                ModificarToro()
            End If

            posicion = Me.BindingContext(Principal.DtsRepro.Tables("Toro")).Position
            Fila = Principal.DtsRepro.Tables("Toro").Rows(posicion)
            Dim codigoAnimal As Integer = Principal.DtsRepro.Tables("Toro").Rows(posicion).Item(0)
            Fila.BeginEdit()

            Fila("crotal") = .txtCrotal.Text
            Fila("nome") = .txtNome.Text
            Fila("apelido_1") = .txtApelido1.Text
            Fila("apelido_2") = .txtApelido2.Text
            Fila("dosis_stock") = .nudDosis.Value

            Fila.EndEdit()
            Principal.DtsRepro.Tables("Toro").AcceptChanges()

            Dim crotal As String = .txtCrotal.Text
            Dim nome As String = .txtNome.Text
            Dim apelido1 As String = .txtApelido1.Text
            Dim apelido2 As String = .txtApelido2.Text
            Dim dosis As Integer = .nudDosis.Value

            Dim cadeaModificar As String
            cadeaModificar = "UPDATE Toro SET "
            cadeaModificar += "crotal='" & crotal & "',"
            cadeaModificar += "nome='" & nome & "',"
            cadeaModificar += "apelido_1='" & apelido1 & "',"
            cadeaModificar += "apelido_2='" & apelido2 & "',"
            cadeaModificar += "dosis_stock=" & dosis
            cadeaModificar += " WHERE cod_toro=" & codigoAnimal & ";"
            Dim modifica As New MySqlCommand(cadeaModificar, Principal.CnnReproducion)
            modifica.Connection.Open()
            modifica.ExecuteNonQuery()
            modifica.Connection.Close()

        End With
    End Sub
End Class