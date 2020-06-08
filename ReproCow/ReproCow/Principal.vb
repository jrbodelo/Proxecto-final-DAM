Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Principal
    Public CnnReproducion As New MySqlConnection
    Dim DtaAnimales As MySqlDataAdapter
    Dim DtaInseminacions As MySqlDataAdapter
    Dim DtaPartos As MySqlDataAdapter
    Dim DtaToros As MySqlDataAdapter
    Dim DtaRevisions1 As MySqlDataAdapter
    Dim DtaSecados As MySqlDataAdapter
    Dim DtaRevisions2 As MySqlDataAdapter
    Dim Fila As DataRow
    Public DtsRepro As New DataSet
    Public DtsConsulta As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvAnimales.AllowUserToAddRows = False
        CnnReproducion.ConnectionString = "server=localhost;user=root;password=abc123.,;database=reproducion"
        Try
            CnnReproducion.Open()
        Catch ex As Exception
            MsgBox("Non se pode acceder a base de datos!", MsgBoxStyle.Critical)
            Me.Close()
            Exit Sub
        End Try

        Dim consulta As String
        consulta = "SELECT * FROM Animal"
        DtaAnimales = New MySqlDataAdapter(consulta, CnnReproducion)
        DtsRepro = New DataSet
        DtaAnimales.Fill(DtsRepro, "Animal")
        dgvAnimales.DataSource = DtsRepro.Tables("Animal")
        AxustarCabeceira()

        EncherCampos()

        CnnReproducion.Close()
        OcultarRexistros()
        ConectarUltimoRexistro()

    End Sub

    Private Sub EncherCampos()
        lblNome.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "nome")
        lblCrotal.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "crotal")
        lblApeMaterno.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "apelido_1")
        lblApePaterno.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "apelido_2")
        lblDataNac.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "data_nac")
        lblRaza.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "raza")
        lblTipo.DataBindings.Add("Text", DtsRepro.Tables("Animal"), "vaca")
        ComprobarVisible()
    End Sub

    Private Sub ComprobarVisible()
        If lblNome.Text.Length < 1 Or lblNome.Text = "<vacio>" Then
            lblNome.Visible = False
            lblNumero.Visible = False
            lblRaza.Visible = False
            lblTipo.Visible = False
            lblDataNac.Visible = False
            lblCrotal.Visible = False
            lblApePaterno.Visible = False
            lblApeMaterno.Visible = False
        Else
            lblNome.Visible = True
            lblNumero.Visible = True
            lblRaza.Visible = True
            lblTipo.Visible = True
            lblDataNac.Visible = True
            lblCrotal.Visible = True
            lblApePaterno.Visible = True
            lblApeMaterno.Visible = True
        End If
    End Sub

    Private Sub lblCrotal_TextChanged(sender As Object, e As EventArgs) Handles lblCrotal.TextChanged
        If lblCrotal.Text.Length < 4 Then
            lblNumero.Text = ""
            Exit Sub
        End If
        lblNumero.Text = lblCrotal.Text.Substring(lblCrotal.Text.Length - 4)
        ConectarUltimoRexistro()

    End Sub

    Private Sub OcultarRexistros()
        lblResultadoRexistro.Visible = False
        lblDataRexistro.Visible = False
        lblEstadoRexistro.Visible = False
        lblSexoRexistro.Visible = False
        lblSementalRexistro.Visible = False
        lblTipoRexistro.Visible = False
    End Sub
    Private Sub lblTipo_TextChanged(sender As Object, e As EventArgs) Handles lblTipo.TextChanged
        If lblTipo.Text = "1" Then
            lblTipo.Text = "Vaca"
        Else
            If lblTipo.Text = "0" Then
                lblTipo.Text = "Novilla"
            End If
        End If
    End Sub

    Private Sub EngadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngadirToolStripMenuItem.Click
        NovoAnimal()
    End Sub

    Private Sub NovoAnimal()
        Dim frmNuevo As New Nuevo_Modificar
        With frmNuevo
            .Text = "Novo animal"
            .cmbTipo.SelectedIndex = 0
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            Dim crotal As String = .txtCrotal.Text
            Dim nome As String = .txtNome.Text
            Dim apelido1 As String = .txtApelido1.Text
            Dim apelido2 As String = .txtApelido2.Text
            Dim raza As String = .txtRaza.Text
            Dim fechaNac As Date = .dtpNacemento.Value
            Dim cartaRex As String = .txtRexistro.Text
            Dim ficheiroXen As String = .txtXenomica.Text
            Dim ficheiroAcop As String = .txtAcoplamento.Text

            Dim tipo As Boolean
            If .cmbTipo.SelectedItem = "Vaca" Then
                tipo = True
            Else
                tipo = False
            End If
            Dim stringData As String = fechaNac.Date

            Dim cadeaInsertar As String
            cadeaInsertar = "INSERT INTO Animal (crotal,nome,apelido_1,apelido_2,data_nac,raza,carta_rexistro,ficheiro_xenomica,ficheiro_acoplamento,vaca) VALUES ("
            cadeaInsertar += "'" & crotal & "',"
            cadeaInsertar += "'" & nome & "',"
            cadeaInsertar += "'" & apelido1 & "',"
            cadeaInsertar += "'" & apelido2 & "',"
            cadeaInsertar += "'" & ConvertirData(stringData) & "',"
            cadeaInsertar += "'" & raza & "',"
            cadeaInsertar += "'" & cartaRex & "',"
            cadeaInsertar += "'" & ficheiroXen & "',"
            cadeaInsertar += "'" & ficheiroAcop & "',"
            cadeaInsertar += tipo & ");"
            Dim engade As New MySqlCommand(cadeaInsertar, CnnReproducion)

            If .txtCrotal.Text.Length < 14 And .txtCrotal.Text.Length > 1 Or .txtCrotal.Text.Length > 14 Then
                MsgBox("O crotal introducido ten un formato incorrecto!", MsgBoxStyle.Exclamation)
                NovoAnimal()
            Else
                If .txtCrotal.Text = "" Or .txtNome.Text = "" Or .txtApelido1.Text = "" Or .txtApelido2.Text = "" Then
                    MsgBox("Debes cubrir os campos obrigatorios (*) !", MsgBoxStyle.Exclamation)
                    NovoAnimal()
                Else
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    Fila = DtsRepro.Tables("Animal").NewRow
                    Dim codigo As String

                    Try
                        codigo = DtsRepro.Tables("Animal").Rows(DtsRepro.Tables("Animal").Rows.Count - 1).Item(0) + 1
                    Catch ex As Exception
                        codigo = 1
                    End Try


                    Fila("cod_animal") = codigo
                    Fila("crotal") = crotal
                    Fila("nome") = nome
                    Fila("apelido_1") = apelido1
                    Fila("apelido_2") = apelido2
                    Fila("data_nac") = fechaNac.Date
                    Fila("raza") = raza
                    Fila("carta_rexistro") = cartaRex
                    Fila("ficheiro_xenomica") = ficheiroXen
                    Fila("ficheiro_acoplamento") = ficheiroAcop
                    Fila("vaca") = tipo

                    DtsRepro.Tables("Animal").Rows.Add(Fila)
                    DtsRepro.Tables("Animal").AcceptChanges()

                    engade.Connection.Close()
                End If

            End If
            ComprobarVisible()



        End With
    End Sub

    Private Sub AxustarCabeceira()
        dgvAnimales.Columns(0).HeaderText = "Código"
        dgvAnimales.Columns(1).HeaderText = "Crotal"
        dgvAnimales.Columns(2).HeaderText = "Nome"
        dgvAnimales.Columns(3).HeaderText = "1º Apelido"
        dgvAnimales.Columns(4).HeaderText = "2º Apelido"
        dgvAnimales.Columns(5).HeaderText = "Data Nacemento"
        dgvAnimales.Columns(6).HeaderText = "Raza"
    End Sub

    Private Function ConvertirData(stringData As String) As String
        Dim arrayfinal As String()
        arrayfinal = stringData.Split("/")
        Dim final As String = arrayfinal(2) & "-" & arrayfinal(1) & "-" & arrayfinal(0)
        Return final
    End Function

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        BorrarAnimal()
    End Sub

    Private Sub BorrarAnimal()
        Dim posicion As Integer
        posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
        Try
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Dim codigoAnimal As Integer = DtsRepro.Tables("Animal").Rows(posicion).Item(0)

        If MsgBox("Estás seguro de que queres borrar este animal?",
        MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
        "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If


        Fila.Delete()
        DtsRepro.Tables("Animal").AcceptChanges()

        Dim cadeaBorrar As String = "DELETE FROM Animal WHERE cod_animal=" & codigoAnimal & ";"
        Dim borra As New MySqlCommand(cadeaBorrar, CnnReproducion)
        borra.Connection.Open()
        borra.ExecuteNonQuery()
        borra.Connection.Close()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ModificarAnimal()
    End Sub

    Private Sub ModificarAnimal()
        Dim frmModificar As New Nuevo_Modificar
        With frmModificar
            Dim posicion As Integer
            posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
            Try
                Fila = DtsRepro.Tables("Animal").Rows(posicion)
            Catch ex As Exception
                MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation)
                Exit Sub
            End Try


            .Text = "Modificar Animal"
            .txtCrotal.Text = lblCrotal.Text
            .txtNome.Text = lblNome.Text
            .txtApelido1.Text = lblApePaterno.Text
            .txtApelido2.Text = lblApeMaterno.Text
            .txtRaza.Text = lblRaza.Text
            .dtpNacemento.Value = DtsRepro.Tables("Animal").Rows(posicion).Item(5)
            .txtRexistro.Text = DtsRepro.Tables("Animal").Rows(posicion).Item(7)
            .txtXenomica.Text = DtsRepro.Tables("Animal").Rows(posicion).Item(8)
            .txtAcoplamento.Text = DtsRepro.Tables("Animal").Rows(posicion).Item(9)

            If lblTipo.Text = "Vaca" Then
                .cmbTipo.SelectedIndex = 0
            Else
                .cmbTipo.SelectedIndex = 1
            End If
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            If .txtCrotal.Text.Length < 14 And .txtCrotal.Text.Length > 1 Or .txtCrotal.Text.Length > 14 Then
                MsgBox("O crotal introducido ten un formato incorrecto!", MsgBoxStyle.Exclamation)
                ModificarAnimal()
            End If

            If .txtCrotal.Text = "" Or .txtNome.Text = "" Or .txtApelido1.Text = "" Or .txtApelido2.Text = "" Then
                MsgBox("Debes cubrir os campos obrigatorios (*) !", MsgBoxStyle.Exclamation)
                ModificarAnimal()
            End If

            posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
            Dim codigoAnimal As Integer = DtsRepro.Tables("Animal").Rows(posicion).Item(0)
            Fila.BeginEdit()

            Fila("crotal") = .txtCrotal.Text
            Fila("nome") = .txtNome.Text
            Fila("apelido_1") = .txtApelido1.Text
            Fila("apelido_2") = .txtApelido2.Text
            Fila("data_nac") = .dtpNacemento.Value
            Fila("raza") = .txtRaza.Text
            Fila("carta_rexistro") = .txtRexistro.Text
            Fila("ficheiro_xenomica") = .txtXenomica.Text
            Fila("ficheiro_acoplamento") = .txtAcoplamento.Text
            Dim tipo As Boolean
            If .cmbTipo.SelectedItem = "Vaca" Then
                tipo = True
            Else
                tipo = False
            End If
            Fila("vaca") = tipo
            Fila.EndEdit()
            DtsRepro.Tables("Animal").AcceptChanges()

            Dim crotal As String = .txtCrotal.Text
            Dim nome As String = .txtNome.Text
            Dim apelido1 As String = .txtApelido1.Text
            Dim apelido2 As String = .txtApelido2.Text
            Dim raza As String = .txtRaza.Text
            Dim fechaNac As Date = .dtpNacemento.Value
            Dim cartaRex As String = .txtRexistro.Text
            Dim ficheiroXen As String = .txtXenomica.Text
            Dim ficheiroAcop As String = .txtAcoplamento.Text

            Dim stringData As String = fechaNac.Date

            Dim cadeaModificar As String
            cadeaModificar = "UPDATE Animal SET "
            cadeaModificar += "crotal='" & crotal & "',"
            cadeaModificar += "nome='" & nome & "',"
            cadeaModificar += "apelido_1='" & apelido1 & "',"
            cadeaModificar += "apelido_2='" & apelido2 & "',"
            cadeaModificar += "data_nac='" & ConvertirData(stringData) & "',"
            cadeaModificar += "raza='" & raza & "',"
            cadeaModificar += "carta_rexistro='" & cartaRex & "',"
            cadeaModificar += "ficheiro_xenomica='" & ficheiroXen & "',"
            cadeaModificar += "ficheiro_acoplamento='" & ficheiroAcop & "',"
            cadeaModificar += "vaca=" & tipo
            cadeaModificar += " WHERE cod_animal=" & codigoAnimal & ";"
            Dim modifica As New MySqlCommand(cadeaModificar, CnnReproducion)
            modifica.Connection.Open()
            modifica.ExecuteNonQuery()
            modifica.Connection.Close()

        End With
    End Sub

    Private Sub btnRexistro_Click(sender As Object, e As EventArgs) Handles btnRexistro.Click

        Dim posicion As Integer
        posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position

        Dim path As String
        Try
            path = DtsRepro.Tables("Animal").Rows(posicion).Item(7)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try


        If path = "" Then
            MsgBox("Non existe a carta de rexistro deste animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim pdfRexistro As New visorPDF
        With pdfRexistro
            .Text = "Carta de Rexistro"
            .AxPDF.src = path
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If



        End With
    End Sub

    Private Sub btnXenomica_Click(sender As Object, e As EventArgs) Handles btnXenomica.Click
        Dim posicion As Integer
        posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
        Dim path As String
        Try
            path = DtsRepro.Tables("Animal").Rows(posicion).Item(8)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try


        If path = "" Then
            MsgBox("Non existe o ficheiro de xenómica deste animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim pdfXenomica As New visorPDF
        With pdfXenomica
            .Text = "Ficheiro de Xenómica"
            .AxPDF.src = path
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
        End With
    End Sub

    Private Sub btnAcoplamento_Click(sender As Object, e As EventArgs) Handles btnAcoplamento.Click
        Dim posicion As Integer
        posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
        Dim path As String
        Try
            path = DtsRepro.Tables("Animal").Rows(posicion).Item(9)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try


        If path = "" Then
            MsgBox("Non existe o ficheiro de acoplamento deste animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim pdfAcoplamento As New visorPDF
        With pdfAcoplamento
            .Text = "Ficheiro de Xenómica"
            .AxPDF.src = path
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
        End With
    End Sub

    Private Sub TorosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TorosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TorosToolStripMenuItem.Click
        Dim frmToros As New Toros
        frmToros.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim posicion As Integer = Me.BindingContext(DtsRepro.Tables("Animal")).Position
        Try
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Dim codigoAnimal As Integer = DtsRepro.Tables("Animal").Rows(posicion).Item(0)

        Dim frmNovoRexistro As New Rexistro
        With frmNovoRexistro
            .Text = "Engadir Rexistro"
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Select Case .lblProceso.Text
                Case "Inseminación"
                    If .cmbSemental.SelectedItem Is Nothing Then
                        MsgBox("Debes introducir un semental!", MsgBoxStyle.Exclamation, "Atención")
                        Exit Sub
                    End If
                    Dim data As Date = .dtpInseminacion.Value
                    Dim cod_toro As Integer = DtsRepro.Tables("Toro").Rows(.cmbSemental.SelectedIndex).Item(0)
                    Dim cadeaModificar As String
                    cadeaModificar = "INSERT INTO Inseminacion(fecha,cod_animal,cod_toro) values('" & ConvertirData(data.Date) & "'," & codigoAnimal & "," & cod_toro & ");"
                    Dim engade As New MySqlCommand(cadeaModificar, CnnReproducion)
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    engade.Connection.Close()
                    DosisMenos(cod_toro)

                Case "1ª Revisión"
                    Dim data As Date = .dtpRevision1.Value
                    Dim resultado As Boolean
                    If .cmbResultadoRevision1.SelectedItem = "Positivo" Then
                        resultado = True
                    Else
                        resultado = False
                    End If
                    Dim cadeaModificar As String
                    cadeaModificar = "INSERT INTO Revision(fecha,positivo,segunda,cod_animal) values('" & ConvertirData(data.Date) & "'," & resultado & "," & False & "," & codigoAnimal & ");"
                    Dim engade As New MySqlCommand(cadeaModificar, CnnReproducion)
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    engade.Connection.Close()

                Case "2ª Revisión"
                    Dim data As Date = .dtpRevision2.Value
                    Dim resultado As Boolean
                    If .cmbResultadoRevision2.SelectedItem = "Positivo" Then
                        resultado = True
                    Else
                        resultado = False
                    End If
                    Dim sexo As Boolean
                    If .cmbSexoRevision.SelectedItem = "Macho" Then
                        sexo = True
                    Else
                        sexo = False
                    End If

                    Dim cadeaModificar As String
                    cadeaModificar = "INSERT INTO Revision(fecha,positivo,segunda,macho,cod_animal) values('" & ConvertirData(data.Date) & "'," & resultado & "," & True & "," & sexo & "," & codigoAnimal & ");"
                    Dim engade As New MySqlCommand(cadeaModificar, CnnReproducion)
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    engade.Connection.Close()

                Case "Secado"
                    Dim data As Date = .dtpSecado.Value
                    Dim cadeaModificar As String
                    cadeaModificar = "INSERT INTO Secado(fecha,cod_animal) values('" & ConvertirData(data.Date) & "'," & codigoAnimal & ");"
                    Dim engade As New MySqlCommand(cadeaModificar, CnnReproducion)
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    engade.Connection.Close()

                Case "Parto"
                    Dim data As Date = .dtpParto.Value
                    Dim sexo As Boolean
                    If .cmbSexoParto.SelectedItem = "Macho" Then
                        sexo = True
                    Else
                        sexo = False
                    End If

                    If DtsConsulta.Tables("Parto") Is Nothing Then
                        ConvertirVaca(codigoAnimal)
                    End If
                    Dim estadoCria As String = .txtEstado.Text
                    Dim cadeaModificar As String
                    cadeaModificar = "INSERT INTO Parto(fecha,estado,sexo,cod_animal) values('" & ConvertirData(data.Date) & "','" & estadoCria & "'," & sexo & "," & codigoAnimal & ");"
                    Dim engade As New MySqlCommand(cadeaModificar, CnnReproducion)
                    engade.Connection.Open()
                    engade.ExecuteNonQuery()
                    engade.Connection.Close()
            End Select
            ConectarUltimoRexistro()

        End With
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        VerRexistros()
    End Sub

    Private Sub VerRexistros()
        Dim posicion As Integer = Me.BindingContext(DtsRepro.Tables("Animal")).Position
        Try
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Catch ex As Exception
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        Dim codigoAnimal As Integer = DtsRepro.Tables("Animal").Rows(posicion).Item(0)

        Dim formVerTodosRexistros As New VerTodos
        With formVerTodosRexistros
            .Text = "Todos os rexistros da vaca nº " & lblNumero.Text
            .lblCodigo.Text = codigoAnimal
            .lblNome.Text = lblNome.Text
            .lblNumero.Text = lblNumero.Text

        End With
        formVerTodosRexistros.Show()

    End Sub

    Private Sub ConectarUltimoRexistro()
        Dim posicion As Integer
        Try
            posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Catch ex As Exception
            Exit Sub
        End Try

        Dim codigoAnimal As Integer

        Try
            codigoAnimal = DtsRepro.Tables("Animal").Rows(posicion).Item(0)
        Catch ex As Exception
            Exit Sub
        End Try
        If CnnReproducion.State = ConnectionState.Open Then
        Else
            CnnReproducion.Open()
        End If

        Dim consultaInseminacion As String
        consultaInseminacion = "SELECT * FROM Inseminacion where cod_animal=" & codigoAnimal & " order by fecha desc;"
        DtaInseminacions = New MySqlDataAdapter(consultaInseminacion, CnnReproducion)
        DtsConsulta = New DataSet
        DtaInseminacions.Fill(DtsConsulta, "Inseminacion")



        Dim consultaRevision1 As String
        consultaRevision1 = "Select * from Revision where cod_animal =" & codigoAnimal & " and segunda=0 order by fecha desc;"
        DtaRevisions1 = New MySqlDataAdapter(consultaRevision1, CnnReproducion)
        DtaRevisions1.Fill(DtsConsulta, "Revision1")


        Dim consultaRevision2 As String
        consultaRevision2 = "Select * from Revision where cod_animal =" & codigoAnimal & " and segunda=1 order by fecha desc;"
        DtaRevisions2 = New MySqlDataAdapter(consultaRevision2, CnnReproducion)
        DtaRevisions2.Fill(DtsConsulta, "Revision2")


        Dim consultaSecado As String
        consultaSecado = "SELECT * from Secado where cod_animal =" & codigoAnimal & " order by fecha desc;"
        DtaSecados = New MySqlDataAdapter(consultaSecado, CnnReproducion)
        DtaSecados.Fill(DtsConsulta, "Secado")


        Dim consultaPartos As String
        consultaPartos = "Select * from Parto where cod_animal=" & codigoAnimal & " order by fecha desc;"
        DtaPartos = New MySqlDataAdapter(consultaPartos, CnnReproducion)
        DtaPartos.Fill(DtsConsulta, "Parto")
        CnnReproducion.Close()

        Dim dataInseminacion As Date
        Dim dataRevision1 As Date
        Dim dataRevision2 As Date
        Dim dataSecado As Date
        Dim dataParto As Date

        Dim fechaDefecto = "01/01/0001"
        Dim fechaConvertida As DateTime = DateTime.ParseExact(fechaDefecto, "MM/dd/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None)

        If DtsConsulta.Tables("Inseminacion").Rows.Count = 0 Then
            dataInseminacion = fechaConvertida
        Else
            dataInseminacion = DtsConsulta.Tables("Inseminacion").Rows(0).Item(1)
        End If

        If DtsConsulta.Tables("Revision1").Rows.Count = 0 Then
            dataRevision1 = fechaConvertida
        Else
            dataRevision1 = DtsConsulta.Tables("Revision1").Rows(0).Item(1)
        End If

        If DtsConsulta.Tables("Revision2").Rows.Count = 0 Then
            dataRevision2 = fechaConvertida
        Else
            dataRevision2 = DtsConsulta.Tables("Revision2").Rows(0).Item(1)
        End If

        If DtsConsulta.Tables("Secado").Rows.Count = 0 Then
            dataSecado = fechaConvertida
        Else
            dataSecado = DtsConsulta.Tables("Secado").Rows(0).Item(1)
        End If

        If DtsConsulta.Tables("Parto").Rows.Count = 0 Then
            dataParto = fechaConvertida
        Else
            dataParto = DtsConsulta.Tables("Parto").Rows(0).Item(1)
        End If


        Dim datas As Date() = {dataInseminacion, dataRevision1, dataRevision2, dataSecado, dataParto}

        Dim datasOrdenadas = From d In datas Order By d.Date Descending

        Select Case datasOrdenadas(0)
            Case fechaConvertida
                lblResultadoRexistro.Visible = False
                lblDataRexistro.Visible = False
                lblEstadoRexistro.Visible = False
                lblSexoRexistro.Visible = False
                lblSementalRexistro.Visible = False
                lblTipoRexistro.Visible = False
                lblTipoRexistro.Text = ""
            Case dataInseminacion
                lblResultadoRexistro.Visible = False
                lblDataRexistro.Visible = True
                lblEstadoRexistro.Visible = False
                lblSexoRexistro.Visible = False
                lblSementalRexistro.Visible = True
                lblTipoRexistro.Visible = True
                lblDataRexistro.Text = dataInseminacion
                lblTipoRexistro.Text = "Inseminación"
                Dim cod_semental = DtsConsulta.Tables("Inseminacion").Rows(0).Item(3)
                lblSementalRexistro.Text = BuscarToro(cod_semental)
            Case dataRevision1
                lblResultadoRexistro.Visible = True
                lblDataRexistro.Visible = True
                lblEstadoRexistro.Visible = False
                lblSexoRexistro.Visible = False
                lblSementalRexistro.Visible = True
                lblTipoRexistro.Visible = True
                lblDataRexistro.Text = dataRevision1
                lblTipoRexistro.Text = "1ª Revisión"
                Dim resultado As Integer = DtsConsulta.Tables("Revision1").Rows(0).Item(2)
                If resultado = 1 Then
                    lblResultadoRexistro.Text = "Positivo"
                Else
                    lblResultadoRexistro.Text = "Negativo"
                End If
                Dim cod_semental As Integer
                Try
                    cod_semental = DtsConsulta.Tables("Inseminacion").Rows(0).Item(3)
                Catch ex As Exception
                    cod_semental = 0
                End Try


                lblSementalRexistro.Text = BuscarToro(cod_semental)
            Case dataRevision2
                lblResultadoRexistro.Visible = True
                lblDataRexistro.Visible = True
                lblEstadoRexistro.Visible = False
                lblSexoRexistro.Visible = True
                lblSementalRexistro.Visible = True
                lblTipoRexistro.Visible = True
                lblDataRexistro.Text = dataRevision2
                lblTipoRexistro.Text = "2ª Revisión"
                Dim resultado As Integer = DtsConsulta.Tables("Revision2").Rows(0).Item(2)
                If resultado = 1 Then
                    lblResultadoRexistro.Text = "Positivo"
                Else
                    lblResultadoRexistro.Text = "Negativo"
                End If
                Dim sexo As Integer = DtsConsulta.Tables("Revision2").Rows(0).Item(4)
                If sexo = 1 Then
                    lblSexoRexistro.Text = "Femia"
                Else
                    lblSexoRexistro.Text = "Macho"
                End If
                Dim cod_semental As Integer
                Try
                    cod_semental = DtsConsulta.Tables("Inseminacion").Rows(0).Item(3)
                Catch ex As Exception
                    cod_semental = 0
                End Try
                lblSementalRexistro.Text = BuscarToro(cod_semental)
            Case dataSecado
                lblResultadoRexistro.Visible = False
                lblDataRexistro.Visible = True
                lblEstadoRexistro.Visible = False
                lblSexoRexistro.Visible = False
                lblSementalRexistro.Visible = True
                lblTipoRexistro.Visible = True
                lblDataRexistro.Text = dataSecado
                lblTipoRexistro.Text = "Secado"
                Dim cod_semental As Integer
                Try
                    cod_semental = DtsConsulta.Tables("Inseminacion").Rows(0).Item(3)
                Catch ex As Exception
                    cod_semental = 0
                End Try
                lblSementalRexistro.Text = BuscarToro(cod_semental)
            Case dataParto
                lblResultadoRexistro.Visible = False
                lblDataRexistro.Visible = True
                lblEstadoRexistro.Visible = True
                lblSexoRexistro.Visible = True
                lblSementalRexistro.Visible = True
                lblTipoRexistro.Visible = True
                lblDataRexistro.Text = dataParto
                lblTipoRexistro.Text = "Parto"
                Dim sexo As Integer = DtsConsulta.Tables("Parto").Rows(0).Item(3)
                If sexo = 1 Then
                    lblSexoRexistro.Text = "Femia"
                Else
                    lblSexoRexistro.Text = "Macho"
                End If
                lblEstadoRexistro.Text = DtsConsulta.Tables("Parto").Rows(0).Item(2)

                Dim cod_semental As Integer
                Try
                    cod_semental = DtsConsulta.Tables("Inseminacion").Rows(0).Item(3)
                Catch ex As Exception
                    cod_semental = 0
                End Try
                lblSementalRexistro.Text = BuscarToro(cod_semental)
        End Select


    End Sub
    Private Function BuscarToro(cod_semental As Integer) As String
        Dim toro As String
        If cod_semental = 0 Then
            toro = "Non rexistrado"
        Else
            CnnReproducion.Open()
            Dim cadeaBusca As String = "Select * from Toro where cod_toro=" & cod_semental & ";"
            DtaToros = New MySqlDataAdapter(cadeaBusca, CnnReproducion)
            DtaToros.Fill(DtsConsulta, "Toro")
            toro = DtsConsulta.Tables("Toro").Rows(0).Item(2)
            CnnReproducion.Close()
        End If

        Return toro
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim data As Date
        Try
            data = lblDataRexistro.Text
        Catch ex As Exception
            data = "01/01/0001"
        End Try
        Dim fechaConvertida As DateTime
        Try
            fechaConvertida = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None)
        Catch ex As Exception
            If lblTipoRexistro.Text.Length < 2 Or lblTipoRexistro.Text = "<vacio>" Then
                MsgBox("O animal seleccionado non ten rexistros!", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            End If
            MsgBox("Debes seleccionar un animal!", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try

        Dim posicion As Integer
        Try
            posicion = Me.BindingContext(DtsRepro.Tables("Animal")).Position
            Fila = DtsRepro.Tables("Animal").Rows(posicion)
        Catch ex As Exception
            Exit Sub
        End Try


        Dim codigoAnimal As Integer = DtsRepro.Tables("Animal").Rows(posicion).Item(0)
        If lblTipoRexistro.Text = "" Or lblTipoRexistro.Text = "<vacio>" Or lblTipoRexistro.Text.Length < 2 Then
            MsgBox("Non existe o rexistro a borrar!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        MsgBox("Estás seguro de que queres eliminar este rexistro?", MsgBoxStyle.Question, "Atención")
        Dim tipoOperacion As String
        Select Case lblTipoRexistro.Text
            Case "Inseminación"
                tipoOperacion = "DELETE FROM Inseminacion where cod_animal=" & codigoAnimal & " and fecha='" & ConvertirData(fechaConvertida.Date) & "';"
                DosisMais(DtsConsulta.Tables("Inseminacion").Rows(0).Item(3))
            Case "1ª Revisión"
                tipoOperacion = "DELETE FROM Revision where cod_animal=" & codigoAnimal & " and fecha='" & ConvertirData(fechaConvertida.Date) & "' and segunda = 0;"
            Case "2ª Revisión"
                tipoOperacion = "DELETE FROM Revision where cod_animal=" & codigoAnimal & " and fecha='" & ConvertirData(fechaConvertida.Date) & "' and segunda = 1;"
            Case "Secado"
                tipoOperacion = "DELETE FROM Secado where cod_animal=" & codigoAnimal & " and fecha='" & ConvertirData(fechaConvertida.Date) & "';"
            Case "Parto"
                tipoOperacion = "DELETE FROM Parto where cod_animal=" & codigoAnimal & " and fecha='" & ConvertirData(fechaConvertida.Date) & "';"
        End Select

        Dim borra As New MySqlCommand(tipoOperacion, CnnReproducion)
        borra.Connection.Open()
        borra.ExecuteNonQuery()
        borra.Connection.Close()
        ConectarUltimoRexistro()
    End Sub


    Private Sub DosisMais(cod_toro As Integer)
        Dim cadeaAxustar As String = "UPDATE Toro SET dosis_stock=dosis_stock+1 WHERE cod_toro=" & cod_toro & ";"
        Dim axusta As New MySqlCommand(cadeaAxustar, CnnReproducion)
        axusta.Connection.Open()
        axusta.ExecuteNonQuery()
        axusta.Connection.Close()
    End Sub

    Private Sub DosisMenos(cod_toro As Integer)
        Dim cadeaAxustar As String = "UPDATE Toro SET dosis_stock=dosis_stock-1 WHERE cod_toro=" & cod_toro & ";"
        Dim axusta As New MySqlCommand(cadeaAxustar, CnnReproducion)
        axusta.Connection.Open()
        axusta.ExecuteNonQuery()
        axusta.Connection.Close()
    End Sub



    Private Sub ConvertirVaca(codigoAnimal As Integer)
        Dim cadeaAxustar As String = "UPDATE Animal SET vaca=1 WHERE cod_animal=" & codigoAnimal & ";"
        Dim axusta As New MySqlCommand(cadeaAxustar, CnnReproducion)
        axusta.Connection.Open()
        axusta.ExecuteNonQuery()
        axusta.Connection.Close()
    End Sub

    Private Sub PróximasTarefasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PróximasTarefasToolStripMenuItem.Click
        Dim frmInforme As New frmInforme
        frmInforme.Show()

    End Sub
End Class
