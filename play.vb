Imports CardMatchingGame.start
Public Class play
    Private Sub play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetupGrid(levelx, levely)
    End Sub
    Private Sub cardFlip(sender As Object, e As EventArgs)
        pb = DirectCast(sender, PictureBox) ' Access the card which is clicked
        num = Convert.ToInt32(pb.Name) ' Get the index of image which is in card facedown
        If (pb.Tag) Then    'To Check if the card is filped or not
            clickCount = clickCount + 1  ' Counter Click
            Me.valCurClick.Text = clickCount ' Update it on the label
            If (clickCount Mod 2 = 0) Then
                pb.Image = Me.images(num)
                pb.Tag = False
                If (lastClick = num) Then  ' If the previous and the current image are same
                    ' Then both the picture box is invalidated
                    ClearPictureBox(pb)
                    ClearPictureBox(lastOb)
                    removed = removed + 2
                    scoreCount = scoreCount + 10
                    If (removed = levelx * levely) Then ' To check if all the correct matches are done
                        If (scoreCount > valBestScore.Text) Then ' Checks if a new best score is made
                            valBestScore.Text = scoreCount
                            valClicks.Text = clickCount
                            Dim objWriter As New System.IO.StreamWriter("input/score.txt", False)
                            objWriter.WriteLine(valBestScore.Text)
                            objWriter.WriteLine(valClicks.Text)
                            objWriter.Close()
                        End If
                        MsgBox("You Have Advanced a Level")
                        Me.increaseLevel() ' To increase the level
                    End If
                    lastClick = Nothing
                Else
                    ' Executes if both cards are not same.
                    ' A timer is started which displays the code
                    timercount = 0
                    timerdisplay.Enabled = True ' A timer is enabled
                End If
            Else
                'timerdisplay.Enabled
                lastOb = pb ' If only 1 card is fliped
                lastOb.Image = Me.images(num) ' amke the lastOb refer to the card that was fliped now
                lastOb.Tag = False
                lastClick = num
            End If
            Me.valCurScore.Text = scoreCount ' Update the score
        End If
    End Sub
    ' Method to invalidate the picturebox
    Private Sub ClearPictureBox(ByVal pb As PictureBox)
        pb.Image = Nothing
        pb.BackColor = Color.Empty
        pb.Tag = False
        pb.Invalidate()
    End Sub
    'Method called when New Game is clicked in Menu
    Private Sub bnewGame_Click(sender As Object, e As EventArgs) Handles bnewGame.Click
        levelx = 2
        levely = 2
        start.Show() ' start.vb shown
        Me.Dispose() 'current form disposed
    End Sub
    'Method called when New Game Button
    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        Me.dieGame() 'Kill the application
    End Sub
    ' Method to reset the level
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        clickCount = 0
        scoreCount = 0
        tLeft.Text = 0
        Me.valCurScore.Text = scoreCount
        Me.valCurClick.Text = clickCount
        For y As Integer = 1 To levely 'starts a For loop (1 to zonesY number of loops)
            For x As Integer = 1 To levelx  'starts a For loop (1 to zonesX number of loops)                
                Me.oGrid(levelx * (y - 1) + x).Dispose()
            Next
        Next
        Me.SetupGrid(levelx, levely)
    End Sub
    'Method to kill the application
    Private Sub dieGame()
        start.Dispose()
        Me.Dispose()
        Application.Exit()
    End Sub
    'Method to kill the application
    Private Sub formClose(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.dieGame()
    End Sub
    'Method to increase the level
    Private Sub increaseLevel()
        For y As Integer = 1 To levely 'starts a For loop (1 to zonesY number of loops)
            For x As Integer = 1 To levelx  'starts a For loop (1 to zonesX number of loops)                
                Me.oGrid(levelx * (y - 1) + x).Dispose()
            Next
        Next
        If (levelx < 5 And levely < 4) Then
            levelx = levelx + 2
            levely = levely + 1
            Me.SetupGrid(levelx, levely)
        Else
            'If grid size can't be increased further
            timerdisplay.Interval = timerdisplay.Interval * (4 / 5)
            Me.SetupGrid(levelx, levely)
        End If
    End Sub
    'Method called when New Game in file menuis clicked
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSubMenu.Click
        levelx = 2
        levely = 2
        start.Show()
        Me.Dispose()
    End Sub
    'Method called when Reset Game in file menu is clicked
    Private Sub ResetGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSubMenu.Click
        clickCount = 0
        scoreCount = 0
        Me.valCurScore.Text = scoreCount
        Me.valCurClick.Text = clickCount
        For y As Integer = 1 To levely 'starts a For loop (1 to zonesY number of loops)
            For x As Integer = 1 To levelx  'starts a For loop (1 to zonesX number of loops)                
                Me.oGrid(levelx * (y - 1) + x).Dispose()
            Next
        Next
        Me.SetupGrid(levelx, levely)
    End Sub
    'Method called when Exit in file is clicked
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitSubMenu.Click
        Me.dieGame()
    End Sub
    'Method to handle timer ticks
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GameTime.Tick
        tLeft.Text = Val(tLeft.Text) + 1

    End Sub
    'method to handle timerdisplay ticks
    Private Sub timerdisplay_Tick(sender As Object, e As EventArgs) Handles timerdisplay.Tick
        timercount = timercount + 1
        If (timercount = 2) Then 'when 2 intervals are passsed the code executes
            lastOb.Image = Me.upImg
            pb.Image = Me.upImg
            lastOb.Tag = True
            pb.Tag = True
            lastClick = Nothing
            lastOb = Nothing
            scoreCount = scoreCount - 3
            timerdisplay.Enabled = False
        End If

    End Sub
    'Method to call about.vb
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

End Class