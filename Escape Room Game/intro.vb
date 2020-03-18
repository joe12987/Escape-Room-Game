Public Class intro
    Dim box As New PictureBox
    Dim _farright As Integer = 670
    Protected _farbottom As Integer = 440
    Public timerValue As Integer
    Protected thistimer As New mytimer()
    Private Sub intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.Size = New Size(670, 440)
        box.BackColor = Color.Red
        box.Size = New Size(30, 30)
        box.Left = 350
        box.Top = 250

        Me.Controls.Add(box)
        Me.Controls.Add(thistimer.lblTimer)


    End Sub

    Private Sub form1_keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim bottomStop As Integer = _farbottom - 70
        If e.KeyCode = Keys.S Then
            If box.Top <> (bottomStop) Then
                box.Top += 10

            End If
        ElseIf e.KeyCode = Keys.W Then
            If box.Top > 0 Then
                box.Top -= 10
            End If
        ElseIf e.KeyCode = Keys.A Then
            If box.Left > 0 Then
                box.Left -= 10
            End If
        ElseIf e.KeyCode = Keys.D Then
            If box.Left <> (_farright - 50) Then
                box.Left += 10
            End If
        End If

    End Sub



End Class