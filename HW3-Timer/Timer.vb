Public Class Timer
    REM NUMBER ZERO
    Public Sub Zero()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 6 To 16 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 10 To 20 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 12 To 14
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
    End Sub
    REM NUMBER ONE 
    Public Sub One()

        For i As Integer = 3 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label7.Visible = True

        For i As Integer = 4 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 5 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 1 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        Label2.Visible = False

        For i As Integer = 12 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

    End Sub
    REM NUMBER TWO
    Public Sub Two()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label10.Visible = True
        Label16.Visible = True

        For i As Integer = 6 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
        For i As Integer = 17 To 20
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER THREE
    Public Sub Three()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 12 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label20.Visible = True

        For i As Integer = 6 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 16 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        Label11.Visible = False
    End Sub
    REM NUMBER FOUR
    Public Sub Four()
        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 5 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 1 To 11 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 2 To 4
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 24
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER FIVE
    Public Sub Five()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label20.Visible = True

        Label10.Visible = False
        Label16.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER SIX
    Public Sub Six()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label20.Visible = True
        Label16.Visible = True

        Label10.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER SEVEN
    Public Sub Seven()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 5 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label6.Visible = True

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 11 To 14
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 16 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 24
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER EIGHT
    Public Sub Eight()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label10.Visible = True
        Label20.Visible = True
        Label16.Visible = True

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER NINE
    Public Sub Nine()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label10.Visible = True
        Label20.Visible = True
        Label16.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER BLOCK TRUE
    Public Sub Block_True()
        For i As Integer = 1 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
    End Sub
    REM NUMBER BLOCK FALSE
    Public Sub Block_False()
        For i As Integer = 1 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub
    REM NUMBER ROCK N ROLL
    Public Sub Rock()
        Label1.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label10.Visible = True

        For i As Integer = 11 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
    End Sub
    REM RESET
    Public Sub Reset()
        For i As Integer = 1 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
    End Sub
    REM DELAY INTERVAL
    Sub delay(ByVal delay_ms As Integer)
        Dim tspan As New TimeSpan
        Dim tstart = Now
        While tspan.TotalMilliseconds < delay_ms
            tspan = Now - tstart
            Application.DoEvents()
        End While
    End Sub
    REM START_BTN
    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Block_False()
        delay(250)

        Zero()
        delay(1000)

        One()
        delay(1000)

        Two()
        delay(1000)

        Three()
        delay(1000)

        Four()
        delay(1000)

        Five()
        delay(1000)

        Six()
        delay(1000)

        Seven()
        delay(1000)

        Eight()
        delay(1000)

        Nine()
        delay(750)

        Block_False()
        delay(250)

        Rock()
        delay(1000)

        Block_False()
        delay(250)
        Block_False()
    End Sub
    REM EXIT BUTTON
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
    REM COUNTDOWN
    Private Sub tminus_btn_Click(sender As Object, e As EventArgs) Handles tminus_btn.Click
        Nine()
        delay(1000)

        Eight()
        delay(1000)

        Seven()
        delay(1000)

        Six()
        delay(1000)

        Five()
        delay(1000)

        Four()
        delay(1000)

        Three()
        delay(1000)

        Two()
        delay(1000)

        One()
        delay(1000)

        Zero()
        delay(750)

        Block_False()
        delay(250)

        Rock()
        delay(1000)

        Block_False()
        delay(250)
        Block_False()
    End Sub

End Class
