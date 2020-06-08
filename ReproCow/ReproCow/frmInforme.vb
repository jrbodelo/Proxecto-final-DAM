Imports System.Drawing.Printing
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmInforme
    Dim DtaAnimales As MySqlDataAdapter
    Dim DtaInseminacions As MySqlDataAdapter
    Dim DtaPartos As MySqlDataAdapter
    Dim DtaToros As MySqlDataAdapter
    Dim DtaRevisions1 As MySqlDataAdapter
    Dim DtaSecados As MySqlDataAdapter
    Dim DtaRevisions2 As MySqlDataAdapter

    Dim novillasInseminar As New List(Of InfoVaca)
    Dim vacasInseminar As New List(Of InfoVaca)
    Dim vacasRevision1 As New List(Of InfoVaca)
    Dim vacasRevision2 As New List(Of InfoVaca)
    Dim vacasSecado As New List(Of InfoVaca)
    Dim vacasParto As New List(Of InfoVaca)


    Public DtsConsulta As New DataSet
    Public DtsRepro As New DataSet

    Dim WithEvents Tarefas As New PrintDocument
    Private iFila As Integer
    Private Sub Imforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Principal.CnnReproducion.Open()
        Dim consulta As String
        consulta = "SELECT * FROM Animal"
        DtaAnimales = New MySqlDataAdapter(consulta, Principal.CnnReproducion)
        DtsRepro = New DataSet
        DtaAnimales.Fill(DtsRepro, "Animal")
        Principal.CnnReproducion.Close()

        CargarDatos()
        Try
            Imprimir()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CargarDatos()
        For Each Fila As DataRow In DtsRepro.Tables("Animal").Rows
            Dim codigoAnimal As Integer

            codigoAnimal = Fila.Item(0)

            Dim statusVaca As String() = Status(codigoAnimal)
            If statusVaca(0) = "Novilla" And statusVaca(1) = "Inseminar" Then
                Dim vaca As New InfoVaca
                vaca.numero = Fila.Item(1).ToString.Substring(Fila.Item(1).ToString.Length - 4)
                vaca.nome = Fila.Item(2).ToString
                vaca.dataInseminacion = Date.Today.ToShortDateString
                novillasInseminar.Add(vaca)
            Else
                Dim vaca As New InfoVaca
                vaca.numero = Fila.Item(1).ToString.Substring(Fila.Item(1).ToString.Length - 4)
                vaca.nome = Fila.Item(2).ToString
                Select Case statusVaca(1)
                    Case "Inseminar"
                        vaca.dataInseminacion = Date.Today.ToShortDateString
                        vacasInseminar.Add(vaca)
                    Case "Revision1"
                        vaca.dataInseminacion = statusVaca(2)
                        vacasRevision1.Add(vaca)
                    Case "Revision2"
                        vaca.dataInseminacion = statusVaca(2)
                        vacasRevision2.Add(vaca)
                    Case "Secar"
                        vaca.dataInseminacion = statusVaca(2)
                        vacasSecado.Add(vaca)
                    Case "Parir"
                        vaca.dataInseminacion = statusVaca(2)
                        vacasParto.Add(vaca)

                End Select
            End If

        Next
    End Sub

    Private Function Status(codigoanimal As Integer) As String()

        Principal.CnnReproducion.Open()


        Dim consultaInseminacion As String
        consultaInseminacion = "SELECT * FROM Inseminacion where cod_animal=" & codigoanimal & " order by fecha desc;"
        DtaInseminacions = New MySqlDataAdapter(consultaInseminacion, Principal.CnnReproducion)
        If DtsConsulta.Tables("Inseminacion") IsNot Nothing Then
            DtsConsulta.Tables("Inseminacion").Rows.Clear()
        End If
        DtaInseminacions.Fill(DtsConsulta, "Inseminacion")



        Dim consultaRevision1 As String
        consultaRevision1 = "Select * from Revision where cod_animal =" & codigoanimal & " and segunda=0 order by fecha desc;"
        DtaRevisions1 = New MySqlDataAdapter(consultaRevision1, Principal.CnnReproducion)
        If DtsConsulta.Tables("Revision1") IsNot Nothing Then
            DtsConsulta.Tables("Revision1").Rows.Clear()
        End If
        DtaRevisions1.Fill(DtsConsulta, "Revision1")


        Dim consultaRevision2 As String
        consultaRevision2 = "Select * from Revision where cod_animal =" & codigoanimal & " and segunda=1 order by fecha desc;"
        DtaRevisions2 = New MySqlDataAdapter(consultaRevision2, Principal.CnnReproducion)
        If DtsConsulta.Tables("Revision2") IsNot Nothing Then
            DtsConsulta.Tables("Revision2").Rows.Clear()
        End If
        DtaRevisions2.Fill(DtsConsulta, "Revision2")


        Dim consultaSecado As String
        consultaSecado = "SELECT * from Secado where cod_animal =" & codigoanimal & " order by fecha desc;"
        DtaSecados = New MySqlDataAdapter(consultaSecado, Principal.CnnReproducion)
        If DtsConsulta.Tables("Secado") IsNot Nothing Then
            DtsConsulta.Tables("Secado").Rows.Clear()
        End If
        DtaSecados.Fill(DtsConsulta, "Secado")


        Dim consultaPartos As String
        consultaPartos = "Select * from Parto where cod_animal=" & codigoanimal & " order by fecha desc;"
        DtaPartos = New MySqlDataAdapter(consultaPartos, Principal.CnnReproducion)
        If DtsConsulta.Tables("Parto") IsNot Nothing Then
            DtsConsulta.Tables("Parto").Rows.Clear()
        End If
        DtaPartos.Fill(DtsConsulta, "Parto")

        Principal.CnnReproducion.Close()

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
        Dim statusVaca As String()

        Select Case datasOrdenadas(0)
            Case fechaConvertida
                If ComprobarIdade(codigoanimal) > 12 Then
                    statusVaca = {"Novilla", "Inseminar"}
                Else
                    statusVaca = {"Novilla", "Nada"}
                End If

            Case dataInseminacion
                If ComprobarMes(dataInseminacion) > 21 Then
                    statusVaca = {"Vaca", "Revision1", dataInseminacion.ToShortDateString}
                Else
                    statusVaca = {"Vaca", "Nada"}
                End If
            Case dataRevision1
                Dim positivo As Integer = DtsConsulta.Tables("Revision1").Rows(0).Item(2)
                If positivo = 1 Then
                    If ComprobarMes(dataRevision1) > 30 Then
                        statusVaca = {"Vaca", "Revision2", dataInseminacion.ToShortDateString}
                    Else
                        statusVaca = {"Vaca", "Nada"}
                    End If
                Else
                    statusVaca = {"Vaca", "Inseminar"}
                End If
            Case dataRevision2
                Dim positivo As Integer = DtsConsulta.Tables("Revision2").Rows(0).Item(2)
                If positivo = 1 Then
                    If ComprobarMes(dataRevision1) > 150 Then
                        statusVaca = {"Vaca", "Secado", dataInseminacion.ToShortDateString}
                    Else
                        statusVaca = {"Vaca", "Nada"}
                    End If
                Else
                    statusVaca = {"Vaca", "Inseminar"}
                End If
            Case dataSecado
                If ComprobarMes(dataSecado) > 45 Then
                    statusVaca = {"Vaca", "Parir"}
                Else
                    statusVaca = {"Vaca", "Nada"}
                End If
            Case dataParto
                If ComprobarMes(dataParto) > 60 Then
                    statusVaca = {"Vaca", "Inseminar"}
                Else
                    statusVaca = {"Vaca", "Nada"}
                End If
        End Select

        Return statusVaca
    End Function

    Private Function ComprobarIdade(codigoAnimal As Integer) As Long
        Dim fechaActual As Date = Date.Today

        Dim idade As Long
        Principal.CnnReproducion.Open()
        Dim cadeaBusca As String = "Select * from Animal where cod_animal=" & codigoAnimal & ";"
        DtaAnimales = New MySqlDataAdapter(cadeaBusca, Principal.CnnReproducion)
        If DtsConsulta.Tables("Animal") IsNot Nothing Then
            DtsConsulta.Tables("Animal").Rows.Clear()
        End If
        DtaAnimales.Fill(DtsConsulta, "Animal")
        Dim dataNac As Date = DtsConsulta.Tables("Animal").Rows(0).Item(5)

        Principal.CnnReproducion.Close()
        idade = DateDiff(DateInterval.Month, dataNac, fechaActual)

        Return idade
    End Function

    Private Function ComprobarMes(dataInseminacion As Date) As Long
        Dim fechaActual As Date = Date.Today
        Dim diferencia As Long = DateDiff(DateInterval.Day, dataInseminacion, fechaActual)
        Return diferencia
    End Function


    Private Sub Imprimir()
        Dim frmImpresora As New PrintDialog
        frmImpresora.Document = Tarefas
        If frmImpresora.ShowDialog() = DialogResult.OK Then
            iFila = 0
            Dim VistaPrevia As New PrintPreviewDialog
            VistaPrevia.Document = Tarefas
            VistaPrevia.WindowState = FormWindowState.Maximized
            VistaPrevia.ShowDialog()
            Me.Close()
        End If
        Me.Close()

    End Sub

    Private Sub Tarefas_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Tarefas.PrintPage
        Dim sgLineasPágina As Single
        Dim sgPosicionY As Single
        Dim iContadorLineas As Integer
        Dim sgMargenIzquierdo As Single
        Dim sgMargenSuperior As Single
        Dim sgAltoLinea As Single
        Dim sgAltoPagina As Single
        Dim sLinea As String
        Dim Fila As DataRow
        Dim Fuente As Font
        Dim Fuente2 As Font
        Dim AlineacionDerecha As New StringFormat
        AlineacionDerecha.Alignment = StringAlignment.Far

        Try
            Fuente = New Font("Times New Roman", 28, FontStyle.Bold)
            Fuente2 = New Font("Times New Roman", 16, FontStyle.Bold)
            e.Graphics.DrawString("Tarefas Pendentes", Fuente, Brushes.Black, 250, 30)

            'TABLA DE NOVILLAS A INSEMINAR'
            e.Graphics.DrawString("Lista de novillas para inseminar", Fuente2, Brushes.Black, 80, 90)
            Fuente = New Font("Courier New", 10)
            sgMargenIzquierdo = e.MarginBounds.Left
            sgMargenSuperior = e.MarginBounds.Top + 50
            sgAltoLinea = Fuente.GetHeight(e.Graphics)
            sgAltoPagina = e.MarginBounds.Height
            sgPosicionY = 98 + (2 * sgAltoLinea) + 50
            sLinea = "   Nº de Vaca          Nome              "
            e.Graphics.DrawString(sLinea, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            Dim pincel As New Pen(Color.Black, 1)

            iContadorLineas = 2
            sgLineasPágina = sgAltoPagina / sgAltoLinea

            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 390, sgMargenSuperior + 25)


            For Each vaca As InfoVaca In novillasInseminar
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next


            e.Graphics.DrawLine(pincel, 250, sgMargenSuperior - 10, 250, sgPosicionY + 20)


            'TABLA DE VACAS A INSEMINAR
            e.Graphics.DrawString("Lista de novillas para inseminar", Fuente2, Brushes.Black, 80, sgPosicionY + 50)
            sgMargenSuperior = sgPosicionY + 100
            e.Graphics.DrawString(sLinea, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 390, sgMargenSuperior + 25)
            sgPosicionY = sgMargenSuperior + 30
            iContadorLineas = 2
            For Each vaca As InfoVaca In vacasInseminar
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next



            e.Graphics.DrawLine(pincel, 250, sgPosicionY + 10, 250, sgMargenSuperior - 10)

            'TABLA DE VACAS A REVISION 1
            Dim sLinea2 = "   Nº de Vaca          Nome              Data Inseminación"
            e.Graphics.DrawString("Lista de vacas e novillas para facer 1ª Revisión", Fuente2, Brushes.Black, 80, sgPosicionY + 50)
            sgMargenSuperior = sgPosicionY + 100
            e.Graphics.DrawString(sLinea2, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 640, sgMargenSuperior + 25)
            sgPosicionY = sgMargenSuperior + 30
            iContadorLineas = 2
            For Each vaca As InfoVaca In vacasRevision1
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                e.Graphics.DrawString(vaca.dataInseminacion, Fuente, Brushes.Black, 450, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next


            e.Graphics.DrawLine(pincel, 250, sgPosicionY + 10, 250, sgMargenSuperior - 10)
            e.Graphics.DrawLine(pincel, 400, sgPosicionY + 10, 400, sgMargenSuperior - 10)

            'TABLA DE VACAS A REVISION 2

            e.Graphics.DrawString("Lista de vacas e novillas para facer 2ª Revisión", Fuente2, Brushes.Black, 80, sgPosicionY + 50)
            sgMargenSuperior = sgPosicionY + 100
            e.Graphics.DrawString(sLinea2, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 640, sgMargenSuperior + 25)
            sgPosicionY = sgMargenSuperior + 30
            iContadorLineas = 2
            For Each vaca As InfoVaca In vacasRevision2
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                e.Graphics.DrawString(vaca.dataInseminacion, Fuente, Brushes.Black, 450, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next


            e.Graphics.DrawLine(pincel, 250, sgPosicionY + 10, 250, sgMargenSuperior - 10)
            e.Graphics.DrawLine(pincel, 400, sgPosicionY + 10, 400, sgMargenSuperior - 10)

            'TABLA DE VACAS A SECAR'
            e.Graphics.DrawString("Lista de vacas  para Secar", Fuente2, Brushes.Black, 80, sgPosicionY + 50)
            sgMargenSuperior = sgPosicionY + 100
            e.Graphics.DrawString(sLinea2, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 640, sgMargenSuperior + 25)
            sgPosicionY = sgMargenSuperior + 30
            iContadorLineas = 2
            For Each vaca As InfoVaca In vacasRevision2
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                e.Graphics.DrawString(vaca.dataInseminacion, Fuente, Brushes.Black, 450, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next

            e.Graphics.DrawLine(pincel, 250, sgPosicionY + 10, 250, sgMargenSuperior - 10)
            e.Graphics.DrawLine(pincel, 400, sgPosicionY + 10, 400, sgMargenSuperior - 10)

            'TABLA DE VACAS E NOVILLAS PARA PARIR'
            e.Graphics.DrawString("Lista de vacas  para Secar", Fuente2, Brushes.Black, 80, sgPosicionY + 50)
            sgMargenSuperior = sgPosicionY + 100
            e.Graphics.DrawString(sLinea2, Fuente, Brushes.Black, sgMargenIzquierdo, sgMargenSuperior)
            e.Graphics.DrawLine(pincel, sgMargenIzquierdo - 10, sgMargenSuperior + 25, 640, sgMargenSuperior + 25)
            sgPosicionY = sgMargenSuperior + 30
            iContadorLineas = 2
            For Each vaca As InfoVaca In vacasRevision2
                e.Graphics.DrawString(vaca.numero, Fuente, Brushes.Black, 150, sgPosicionY)
                e.Graphics.DrawString(vaca.nome, Fuente, Brushes.Black, 290, sgPosicionY)
                e.Graphics.DrawString(vaca.dataInseminacion, Fuente, Brushes.Black, 450, sgPosicionY)
                sgPosicionY = sgMargenSuperior + (iContadorLineas * sgAltoLinea)
                iContadorLineas += 1
                sgPosicionY += sgAltoLinea
            Next

            e.Graphics.DrawLine(pincel, 250, sgPosicionY + 10, 250, sgMargenSuperior - 10)
            e.Graphics.DrawLine(pincel, 400, sgPosicionY + 10, 400, sgMargenSuperior - 10)
        Catch ex As Exception
            e.Cancel = True
            MsgBox("Error durante la impresión. Descripción: " & ex.Message,
           MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Class