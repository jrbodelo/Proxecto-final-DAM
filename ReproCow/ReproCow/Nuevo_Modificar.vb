Public Class Nuevo_Modificar
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnExaminarRex_Click(sender As Object, e As EventArgs) Handles btnExaminarRex.Click
        Dim ofdRexistro As New OpenFileDialog()
        ofdRexistro.RestoreDirectory = True
        ofdRexistro.Multiselect = False
        ofdRexistro.Title = "Seleccione carta de rexistro do animal"
        ofdRexistro.Filter = "Archivos pdf (*.pdf)|*.pdf|" & "Todos los archivos (*.*)|*.*"

        If ofdRexistro.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtRexistro.Text = System.IO.Path.GetFullPath(ofdRexistro.FileName).Replace("\", "\\")
        End If
    End Sub

    Private Sub btnExaminarXen_Click(sender As Object, e As EventArgs) Handles btnExaminarXen.Click
        Dim ofdXenomica As New OpenFileDialog()
        ofdXenomica.RestoreDirectory = True
        ofdXenomica.Multiselect = False
        ofdXenomica.Title = "Seleccione carta de rexistro do animal"
        ofdXenomica.Filter = "Archivos PDF (*.pdf)|*.pdf|" & "Todos los archivos (*.*)|*.*"

        If ofdXenomica.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtXenomica.Text = System.IO.Path.GetFullPath(ofdXenomica.FileName).Replace("\", "\\")
        End If
    End Sub

    Private Sub btnExaminarAcop_Click(sender As Object, e As EventArgs) Handles btnExaminarAcop.Click
        Dim ofdAcoplamento As New OpenFileDialog()
        ofdAcoplamento.RestoreDirectory = True
        ofdAcoplamento.Multiselect = False
        ofdAcoplamento.Title = "Seleccione carta de rexistro do animal"
        ofdAcoplamento.Filter = "Archivos PDF (*.pdf)|*.pdf|" & "Todos los archivos (*.*)|*.*"

        If ofdAcoplamento.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtAcoplamento.Text = System.IO.Path.GetFullPath(ofdAcoplamento.FileName).Replace("\", "\\")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnCancelarRexistro_Click(sender As Object, e As EventArgs) Handles btnCancelarRexistro.Click
        txtRexistro.Text = ""
    End Sub

    Private Sub btnCancelarXenomica_Click(sender As Object, e As EventArgs) Handles btnCancelarXenomica.Click
        txtXenomica.Text = ""
    End Sub

    Private Sub btnCancelarAcoplamento_Click(sender As Object, e As EventArgs) Handles btnCancelarAcoplamento.Click
        txtAcoplamento.Text = ""
    End Sub
End Class