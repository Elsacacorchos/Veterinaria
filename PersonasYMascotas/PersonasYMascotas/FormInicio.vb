Public Class FormInicio
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked


    End Sub

    Private Sub FormPersonasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FormPersonasToolStripMenuItem2.Click
        Dim menuPersonas As New MenuItem()
        menuPersonas.Text = "File"

        menuPersonas.MenuItems.Add(menuPersonas)

        menuPersonas.MergeMenu()

    End Sub
End Class