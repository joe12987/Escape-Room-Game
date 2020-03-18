Public Class userlogin
    Dim username As String


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If TextBox1.Text = "" Then
            Label1.Text = ("please enter a username")
        Else
            Label1.Visible = False
            intro.Show()
            Me.Close()

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        username = TextBox1.Text()
    End Sub
End Class