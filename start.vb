Public Class start
    'Method to call play.vb when Startbutton is clicked 
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StartButton.Click
        levelx = 2
        levely = 2
        play.Show() ' Show play.vb
        Me.Hide()   'Hide Current form
    End Sub
    'Method called when Exit in file is clicked
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitSubMenu.Click
        Me.Dispose() 'Dispose the current form
    End Sub
    'Method to call about.vb
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show() 'Show about.vb
    End Sub
End Class
