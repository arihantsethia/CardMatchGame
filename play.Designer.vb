Imports CardMatchingGame.start
Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class play
    Inherits System.Windows.Forms.Form
    Dim upImg As Image
    Dim images(12) As Image
    Dim oGrid(24) As PictureBox
    Dim lastClick As Integer
    Dim lastOb As Object
    Dim clickCount As Integer
    Dim scoreCount As Integer
    Dim removed As Integer
    Dim timercount As Integer
    Dim pb As Object
    Dim num As Integer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(play))
        Me.cardPane = New System.Windows.Forms.Panel()
        Me.cardContainer = New System.Windows.Forms.Panel()
        Me.bnewGame = New System.Windows.Forms.Button()
        Me.bexit = New System.Windows.Forms.Button()
        Me.best = New System.Windows.Forms.GroupBox()
        Me.valClicks = New System.Windows.Forms.Label()
        Me.clicks = New System.Windows.Forms.Label()
        Me.valBestScore = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.currScore = New System.Windows.Forms.GroupBox()
        Me.tLeft = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.valCurClick = New System.Windows.Forms.Label()
        Me.curClick = New System.Windows.Forms.Label()
        Me.valCurScore = New System.Windows.Forms.Label()
        Me.curScore = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.PlayMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerdisplay = New System.Windows.Forms.Timer(Me.components)
        Me.cardPane.SuspendLayout()
        Me.best.SuspendLayout()
        Me.currScore.SuspendLayout()
        Me.PlayMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'cardPane
        '
        Me.cardPane.BackColor = System.Drawing.Color.Transparent
        Me.cardPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cardPane.Controls.Add(Me.cardContainer)
        Me.cardPane.Location = New System.Drawing.Point(0, 27)
        Me.cardPane.Name = "cardPane"
        Me.cardPane.Size = New System.Drawing.Size(866, 607)
        Me.cardPane.TabIndex = 1
        '
        'cardContainer
        '
        Me.cardContainer.BackColor = System.Drawing.Color.Transparent
        Me.cardContainer.Location = New System.Drawing.Point(200, 100)
        Me.cardContainer.Name = "cardContainer"
        Me.cardContainer.Size = New System.Drawing.Size(165, 220)
        Me.cardContainer.TabIndex = 7
        '
        'bnewGame
        '
        Me.bnewGame.Location = New System.Drawing.Point(876, 40)
        Me.bnewGame.Name = "bnewGame"
        Me.bnewGame.Size = New System.Drawing.Size(120, 50)
        Me.bnewGame.TabIndex = 1
        Me.bnewGame.Text = "New Game"
        Me.bnewGame.UseVisualStyleBackColor = True
        '
        'bexit
        '
        Me.bexit.Location = New System.Drawing.Point(876, 105)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(120, 50)
        Me.bexit.TabIndex = 2
        Me.bexit.Text = "Exit"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'best
        '
        Me.best.Controls.Add(Me.valClicks)
        Me.best.Controls.Add(Me.clicks)
        Me.best.Controls.Add(Me.valBestScore)
        Me.best.Controls.Add(Me.score)
        Me.best.Location = New System.Drawing.Point(876, 175)
        Me.best.Name = "best"
        Me.best.Size = New System.Drawing.Size(120, 150)
        Me.best.TabIndex = 3
        Me.best.TabStop = False
        Me.best.Text = "Best Score"
        '
        'valClicks
        '
        Me.valClicks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valClicks.AutoSize = True
        Me.valClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.valClicks.Location = New System.Drawing.Point(55, 97)
        Me.valClicks.Name = "valClicks"
        Me.valClicks.Size = New System.Drawing.Size(16, 17)
        Me.valClicks.TabIndex = 3
        Me.valClicks.Text = "0"
        '
        'clicks
        '
        Me.clicks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clicks.AutoSize = True
        Me.clicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.clicks.Location = New System.Drawing.Point(38, 74)
        Me.clicks.Name = "clicks"
        Me.clicks.Size = New System.Drawing.Size(49, 18)
        Me.clicks.TabIndex = 2
        Me.clicks.Text = "Clicks"
        '
        'valBestScore
        '
        Me.valBestScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valBestScore.AutoSize = True
        Me.valBestScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.valBestScore.Location = New System.Drawing.Point(51, 47)
        Me.valBestScore.Name = "valBestScore"
        Me.valBestScore.Size = New System.Drawing.Size(16, 17)
        Me.valBestScore.TabIndex = 1
        Me.valBestScore.Text = "0"
        '
        'score
        '
        Me.score.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.score.Location = New System.Drawing.Point(23, 26)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(82, 18)
        Me.score.TabIndex = 0
        Me.score.Text = "Best Score"
        '
        'currScore
        '
        Me.currScore.Controls.Add(Me.tLeft)
        Me.currScore.Controls.Add(Me.time)
        Me.currScore.Controls.Add(Me.valCurClick)
        Me.currScore.Controls.Add(Me.curClick)
        Me.currScore.Controls.Add(Me.valCurScore)
        Me.currScore.Controls.Add(Me.curScore)
        Me.currScore.Location = New System.Drawing.Point(876, 344)
        Me.currScore.Name = "currScore"
        Me.currScore.Size = New System.Drawing.Size(120, 200)
        Me.currScore.TabIndex = 4
        Me.currScore.TabStop = False
        Me.currScore.Text = "Score"
        '
        'tLeft
        '
        Me.tLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tLeft.AutoSize = True
        Me.tLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.tLeft.Location = New System.Drawing.Point(43, 160)
        Me.tLeft.Name = "tLeft"
        Me.tLeft.Size = New System.Drawing.Size(24, 17)
        Me.tLeft.TabIndex = 9
        Me.tLeft.Text = "00"
        '
        'time
        '
        Me.time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.time.Location = New System.Drawing.Point(27, 138)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(86, 18)
        Me.time.TabIndex = 8
        Me.time.Text = "Time Taken"
        '
        'valCurClick
        '
        Me.valCurClick.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valCurClick.AutoSize = True
        Me.valCurClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.valCurClick.Location = New System.Drawing.Point(53, 109)
        Me.valCurClick.Name = "valCurClick"
        Me.valCurClick.Size = New System.Drawing.Size(16, 17)
        Me.valCurClick.TabIndex = 7
        Me.valCurClick.Text = "0"
        '
        'curClick
        '
        Me.curClick.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.curClick.AutoSize = True
        Me.curClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.curClick.Location = New System.Drawing.Point(36, 87)
        Me.curClick.Name = "curClick"
        Me.curClick.Size = New System.Drawing.Size(49, 18)
        Me.curClick.TabIndex = 6
        Me.curClick.Text = "Clicks"
        '
        'valCurScore
        '
        Me.valCurScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valCurScore.AutoSize = True
        Me.valCurScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.valCurScore.Location = New System.Drawing.Point(53, 59)
        Me.valCurScore.Name = "valCurScore"
        Me.valCurScore.Size = New System.Drawing.Size(16, 17)
        Me.valCurScore.TabIndex = 5
        Me.valCurScore.Text = "0"
        '
        'curScore
        '
        Me.curScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.curScore.AutoSize = True
        Me.curScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.curScore.Location = New System.Drawing.Point(36, 38)
        Me.curScore.Name = "curScore"
        Me.curScore.Size = New System.Drawing.Size(48, 18)
        Me.curScore.TabIndex = 4
        Me.curScore.Text = "Score"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(876, 550)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(120, 50)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'PlayMenuStrip
        '
        Me.PlayMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileItem, Me.AboutToolStripMenuItem})
        Me.PlayMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.PlayMenuStrip.Name = "PlayMenuStrip"
        Me.PlayMenuStrip.Size = New System.Drawing.Size(1002, 24)
        Me.PlayMenuStrip.TabIndex = 6
        Me.PlayMenuStrip.Text = "PlayMenuStrip"
        '
        'FileItem
        '
        Me.FileItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSubMenu, Me.ResetSubMenu, Me.ExitSubMenu})
        Me.FileItem.Name = "FileItem"
        Me.FileItem.Size = New System.Drawing.Size(37, 20)
        Me.FileItem.Text = "File"
        '
        'NewSubMenu
        '
        Me.NewSubMenu.Name = "NewSubMenu"
        Me.NewSubMenu.Size = New System.Drawing.Size(136, 22)
        Me.NewSubMenu.Text = "New Game"
        '
        'ResetSubMenu
        '
        Me.ResetSubMenu.Name = "ResetSubMenu"
        Me.ResetSubMenu.Size = New System.Drawing.Size(136, 22)
        Me.ResetSubMenu.Text = "Reset Game"
        '
        'ExitSubMenu
        '
        Me.ExitSubMenu.Name = "ExitSubMenu"
        Me.ExitSubMenu.Size = New System.Drawing.Size(136, 22)
        Me.ExitSubMenu.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GameTime
        '
        Me.GameTime.Interval = 1000
        '
        'timerdisplay
        '
        Me.timerdisplay.Interval = 200
        '
        'play
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackgroundImage = Global.CardMatchingGame.My.Resources.Resources.back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 637)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.currScore)
        Me.Controls.Add(Me.best)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.bnewGame)
        Me.Controls.Add(Me.cardPane)
        Me.Controls.Add(Me.PlayMenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.PlayMenuStrip
        Me.Name = "play"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Matching Game"
        Me.cardPane.ResumeLayout(False)
        Me.best.ResumeLayout(False)
        Me.best.PerformLayout()
        Me.currScore.ResumeLayout(False)
        Me.currScore.PerformLayout()
        Me.PlayMenuStrip.ResumeLayout(False)
        Me.PlayMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private Sub SetupGrid(ByVal levx As Integer, ByRef levy As Integer)
        Dim zonesizex As Integer
        Dim zonesizey As Integer
        Using reader As StreamReader = New StreamReader("Input/score.txt", False)
            valBestScore.Text = reader.ReadLine()
            valClicks.Text = reader.ReadLine()
        End Using
        zonesizex = 120 - 5 * (levelx - 1)
        zonesizey = 150 - 5 * (levely - 1)
        GameTime.Enabled = True
        timerdisplay.Interval = 300 / levelx
        Me.cardContainer.Size = New System.Drawing.Size(zonesizex * levelx - 15, zonesizey * levely - 15)
        Me.cardContainer.Location = New Point(cardPane.Width / 2 - cardContainer.Width / 2, cardPane.Height / 2 - cardContainer.Height / 2)
        lastClick = Nothing
        removed = 0
        Dim cards As New List(Of Integer)
        Dim item As Object
        Dim rand As New Random
        Dim index As Integer
        upImg = Image.FromFile("Input\top.png")
        For i As Integer = 1 To 13
            images(i - 1) = Image.FromFile("Input\" + i.ToString + ".png")
        Next
        For y As Integer = 1 To levely 'starts a For loop (1 to zonesY number of loops)
            For x As Integer = 1 To levelx  'starts a For loop (1 to zonesX number of loops)
                cards.Add(levelx * (y - 1) + x)
                Me.oGrid(levelx * (y - 1) + x) = New System.Windows.Forms.PictureBox()
                oGrid(levelx * (y - 1) + x).Tag = True
                oGrid(levelx * (y - 1) + x).BackgroundImage = Nothing
                oGrid(levelx * (y - 1) + x).Image = upImg
                oGrid(levelx * (y - 1) + x).Width = zonesizex - 15
                oGrid(levelx * (y - 1) + x).Height = zonesizey - 15
                oGrid(levelx * (y - 1) + x).SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                oGrid(levelx * (y - 1) + x).Left = ((x - 1) * zonesizex)
                oGrid(levelx * (y - 1) + x).Top = ((y - 1) * zonesizey)
                Me.cardContainer.Controls.Add(oGrid(levelx * (y - 1) + x))
                AddHandler oGrid(levelx * (y - 1) + x).Click, AddressOf cardFlip
            Next
        Next
        Dim count As Integer
        count = 0
        While cards.Count > 1
            index = rand.Next(1, cards.Count)
            item = cards(index)
            oGrid(item).Name = count
            cards.RemoveAt(index)
            index = rand.Next(0, cards.Count)
            item = cards(index)
            oGrid(item).Name = count
            cards.RemoveAt(index)
            count = count + 1
        End While
    End Sub
    Friend WithEvents cardPane As System.Windows.Forms.Panel
    Friend WithEvents bnewGame As System.Windows.Forms.Button
    Friend WithEvents bexit As System.Windows.Forms.Button
    Friend WithEvents best As System.Windows.Forms.GroupBox
    Friend WithEvents currScore As System.Windows.Forms.GroupBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents valClicks As System.Windows.Forms.Label
    Friend WithEvents clicks As System.Windows.Forms.Label
    Friend WithEvents valBestScore As System.Windows.Forms.Label
    Friend WithEvents score As System.Windows.Forms.Label
    Friend WithEvents tLeft As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents valCurClick As System.Windows.Forms.Label
    Friend WithEvents curClick As System.Windows.Forms.Label
    Friend WithEvents valCurScore As System.Windows.Forms.Label
    Friend WithEvents curScore As System.Windows.Forms.Label
    Friend WithEvents PlayMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSubMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetSubMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitSubMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cardContainer As System.Windows.Forms.Panel
    Friend WithEvents GameTime As System.Windows.Forms.Timer
    Friend WithEvents timerdisplay As System.Windows.Forms.Timer
End Class
