Public Class Form1
    Dim s As Integer
    Dim Start As Integer = 3
    Dim mve As Boolean = False
    Dim life As Integer
    Dim car(2) As PictureBox
    Dim road(7) As PictureBox
    Dim h(2) As PictureBox
    Dim flag As Boolean
    Dim gme_ovr As Boolean = False
    Dim speed As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        road(0) = line00
        road(1) = line10
        road(2) = line20
        road(3) = line30
        road(4) = line01
        road(5) = line11
        road(6) = line21
        road(7) = line31

        car(0) = op_car1
        car(1) = op_car2
        car(2) = op_car3

        h(0) = life1
        h(1) = life2
        h(2) = life3

        For y = 0 To 2
            car(y).Top = -Int(Rnd() * 550)
        Next
        gme_ovr = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            speed = 0
            gear.Text = "0"
            sped.Text = "0"
            new_gme()
        End If
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
        If e.KeyCode = Keys.Right And mve = True Then
            right_mve.Start()
        End If
        If e.KeyCode = Keys.Left And mve = True Then
            left_mve.Start()
        End If
        If e.KeyCode = Keys.Up And mve = True Then
            If speed <= 50 Then
                speed = speed + 10
                car_tmr.Interval = car_tmr.Interval - 10
            End If
        End If
        If e.KeyCode = Keys.Down And mve = True Then
            If speed >= 20 Then
                speed = speed - 10
                car_tmr.Interval = car_tmr.Interval + 10
            End If
        End If

        sped.Text = speed
        gear.Text = speed / 10

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        left_mve.Stop()
        right_mve.Stop()
    End Sub

    Private Sub right_mve_Tick(sender As Object, e As EventArgs) Handles right_mve.Tick
        If my_car.Location.X < 733 Then
            my_car.Left += 5
        End If
    End Sub

    Private Sub left_mve_Tick(sender As Object, e As EventArgs) Handles left_mve.Tick
        If my_car.Location.X > 80 Then
            my_car.Left -= 5
        End If
    End Sub

    Private Sub line_tmr_Tick(sender As Object, e As EventArgs) Handles line_tmr.Tick
        For x = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
    End Sub

    Private Sub time_tmr_Tick(sender As Object, e As EventArgs) Handles time_tmr.Tick
        s += 1
        scre.Text = s
    End Sub

    Private Sub Timer_strt_Tick(sender As Object, e As EventArgs) Handles Timer_strt.Tick
        If Start > 0 Then
            Start -= 1
        End If

        count.Text = Start
        If Start = 0 Then
            speed = 10
            sped.Text = speed
            gear.Text = speed / 10
            time_tmr.Start()
            line_tmr.Start()
            car_tmr.Start()
            count.Visible = False
            mve = True
            Timer_strt.Stop()
            flag = True
        End If
        flag = True
    End Sub

    Private Sub car_tmr_Tick(sender As Object, e As EventArgs) Handles car_tmr.Tick
        For y = 0 To 2
            car(y).Top += 15

            If car(y).Top > Me.Height Then
                car(y).Top = -Int(Rnd() * 550)
            End If
            If my_car.Bounds.IntersectsWith(car(y).Bounds) Then
                life += 1
                car(y).Top = -Int(Rnd() * 550)
                h(life - 1).Hide()
                If life = 3 Then
                    car_tmr.Stop()
                    time_tmr.Stop()
                    left_mve.Stop()
                    right_mve.Stop()
                    line_tmr.Stop()
                    mve = False
                    life = 0
                    count.Visible = True
                    count.Text = "Game Over"
                    gme_ovr = True
                End If
            End If
        Next
    End Sub

    Private Sub new_gme()
        scre.Text = "0"
        gear.Text = "0"
        sped.Text = "0"
        For y = 0 To 2
            car(y).Top = -Int(Rnd() * 550)
        Next
        flag = True
        Timer_strt.Start()
        count.Text = 3
        my_car.Left = 425
        my_car.Top = 634
        Start = 3
        time_tmr.Stop()
        line_tmr.Stop()
        car_tmr.Stop()
        count.Visible = True
        mve = False
        flag = False
        gme_ovr = False
    End Sub
End Class
