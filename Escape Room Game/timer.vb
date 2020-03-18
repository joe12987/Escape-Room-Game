Public Class mytimer
    Protected Timer1 As New Windows.Forms.Timer
    Public lblTimer As New Label
    Private _timerValue As Integer
    Public Sub New()
        MyNewTimer()
        With lblTimer
            .Location = New Point(1, 1)
            .Font = New Font("Font Name", 12, FontStyle.Bold)
            .Size = New Size(100, 20)
        End With
    End Sub

    Public Property timerValue As Integer
        Get
            Return _timerValue
        End Get

        Set(value As Integer)
            _timerValue = value
        End Set
    End Property

    Private Sub MyNewTimer()
        AddHandler Timer1.Tick, AddressOf TimerTick
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Sub TimerTick(ByVal sender As Object, e As EventArgs)
        _timerValue += 1
        lblTimer.Text = _timerValue
    End Sub

End Class

