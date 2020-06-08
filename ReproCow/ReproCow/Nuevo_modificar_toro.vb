Public Class Nuevo_modificar_toro
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
    End Sub
End Class