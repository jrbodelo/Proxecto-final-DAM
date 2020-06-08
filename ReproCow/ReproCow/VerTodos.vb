Imports MySql.Data.MySqlClient

Public Class VerTodos

    Dim DtaInseminacions As MySqlDataAdapter
    Dim DtaPartos As MySqlDataAdapter
    Dim DtaRevisions1 As MySqlDataAdapter
    Dim DtaRevisions2 As MySqlDataAdapter
    Dim DtaSecados As MySqlDataAdapter
    Dim Fila As DataRow
    Public DtsConsulta As New DataSet

    Private Sub VerTodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigoAnimal As Integer = Integer.Parse(lblCodigo.Text)
        Principal.CnnReproducion.Open()
        Dim consultaInseminacion As String
        consultaInseminacion = "SELECT * FROM Inseminacion where cod_animal=" & codigoAnimal & ";"
        DtaInseminacions = New MySqlDataAdapter(consultaInseminacion, Principal.CnnReproducion)
        DtsConsulta = New DataSet
        DtaInseminacions.Fill(DtsConsulta, "Inseminacion")
        dgvInseminacions.DataSource = DtsConsulta.Tables("Inseminacion")


        Dim consultaRevision1 As String
        consultaRevision1 = "Select * from Revision where cod_animal =" & codigoAnimal & " and segunda=0;"
        DtaRevisions1 = New MySqlDataAdapter(consultaRevision1, Principal.CnnReproducion)
        DtaRevisions1.Fill(DtsConsulta, "Revision1")
        dgvrevisions1.DataSource = DtsConsulta.Tables("Revision1")

        Dim consultaRevision2 As String
        consultaRevision2 = "Select * from Revision where cod_animal =" & codigoAnimal & " and segunda=1;"
        DtaRevisions2 = New MySqlDataAdapter(consultaRevision2, Principal.CnnReproducion)
        DtaRevisions2.Fill(DtsConsulta, "Revision2")
        dgvRevision2.DataSource = DtsConsulta.Tables("Revision2")

        Dim consultaSecado As String
        consultaSecado = "SELECT * from Secado where cod_animal =" & codigoAnimal & ";"
        DtaSecados = New MySqlDataAdapter(consultaSecado, Principal.CnnReproducion)
        DtaSecados.Fill(DtsConsulta, "Secado")
        dgvSecados.DataSource = DtsConsulta.Tables("Secado")

        Dim consultaPartos As String
        consultaPartos = "Select * from Parto where cod_animal=" & codigoAnimal & ";"
        DtaPartos = New MySqlDataAdapter(consultaPartos, Principal.CnnReproducion)
        DtaPartos.Fill(DtsConsulta, "Parto")
        dgvPartos.DataSource = DtsConsulta.Tables("Parto")
        Principal.CnnReproducion.Close()
        AxustarCabeceiraInseminacions()
        AxustarCabeceiraRevision1()
        AxustarCabeceiraRevision2()
        AxustarCabeceiraSecado()
        AxustarCabeceiraParto()
    End Sub

    Private Sub AxustarCabeceiraInseminacions()
        dgvInseminacions.Columns(0).HeaderText = "Código Inseminación"
        dgvInseminacions.Columns(1).HeaderText = "Data"
        dgvInseminacions.Columns(2).HeaderText = "Código Animal"
        dgvInseminacions.Columns(3).HeaderText = "Semental"

    End Sub
    Private Sub AxustarCabeceiraRevision1()
        dgvrevisions1.Columns(0).HeaderText = "Código Revisión"
        dgvrevisions1.Columns(1).HeaderText = "Data"
        dgvrevisions1.Columns(2).HeaderText = "Resultado"
        dgvrevisions1.Columns(3).HeaderText = "Revisión"
        dgvrevisions1.Columns(4).HeaderText = "Sexo"
        dgvrevisions1.Columns(5).HeaderText = "Codigo Animal"
    End Sub

    Private Sub AxustarCabeceiraRevision2()
        dgvRevision2.Columns(0).HeaderText = "Código Revisión"
        dgvRevision2.Columns(1).HeaderText = "Data"
        dgvRevision2.Columns(2).HeaderText = "Resultado"
        dgvRevision2.Columns(3).HeaderText = "Revisión"
        dgvRevision2.Columns(4).HeaderText = "Sexo"
        dgvRevision2.Columns(5).HeaderText = "Código Animal"
    End Sub

    Private Sub AxustarCabeceiraSecado()
        dgvSecados.Columns(0).HeaderText = "Código Secado"
        dgvSecados.Columns(1).HeaderText = "Data"
        dgvSecados.Columns(2).HeaderText = "Código Animal"
    End Sub

    Private Sub AxustarCabeceiraParto()
        dgvPartos.Columns(0).HeaderText = "Código Parto"
        dgvPartos.Columns(1).HeaderText = "Data"
        dgvPartos.Columns(2).HeaderText = "Estado"
        dgvPartos.Columns(3).HeaderText = "Sexo"
        dgvPartos.Columns(4).HeaderText = "Código Animal"
    End Sub

End Class