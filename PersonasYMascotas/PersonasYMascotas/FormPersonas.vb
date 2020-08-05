Public Class FormPyM
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles labelPersonas.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textCi.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCapturarPersonas_Click(sender As Object, e As EventArgs) Handles btnCapturarPersonas.Click
        Dim ci As Integer
        Dim nombre As String
        Dim telefono As Integer
        Dim direccion As String

        ci = textCi.Text
        nombre = textNombre.Text
        telefono = textTelefono.Text
        direccion = textDireccion.Text

        labelVerResultado.Text = ci & "   |   " & nombre & "   |   " & telefono & "   |   " & direccion
    End Sub

    Private Sub labelVerResultado_Click(sender As Object, e As EventArgs) Handles labelVerResultado.Click


    End Sub
End Class
