<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start
    Inherits System.Windows.Forms.Form
    Public Shared levelx As Integer = 2
    Public Shared levely As Integer = 2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start))
        Me.StartButton = New System.Windows.Forms.PictureBox()
        Me.GameSartMenu = New System.Windows.Forms.MenuStrip()
        Me.Filetem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameSartMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.Image = Global.CardMatchingGame.My.Resources.Resources.start
        Me.StartButton.Location = New System.Drawing.Point(435, 298)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(148, 80)
        Me.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StartButton.TabIndex = 0
        Me.StartButton.TabStop = False
        '
        'GameSartMenu
        '
        Me.GameSartMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Filetem, Me.AboutToolStripMenuItem})
        Me.GameSartMenu.Location = New System.Drawing.Point(0, 0)
        Me.GameSartMenu.Name = "GameSartMenu"
        Me.GameSartMenu.Size = New System.Drawing.Size(1002, 24)
        Me.GameSartMenu.TabIndex = 7
        Me.GameSartMenu.Text = "GameStartMenu"
        '
        'Filetem
        '
        Me.Filetem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitSubMenu})
        Me.Filetem.Name = "Filetem"
        Me.Filetem.Size = New System.Drawing.Size(37, 20)
        Me.Filetem.Text = "File"
        '
        'ExitSubMenu
        '
        Me.ExitSubMenu.Name = "ExitSubMenu"
        Me.ExitSubMenu.Size = New System.Drawing.Size(92, 22)
        Me.ExitSubMenu.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CardMatchingGame.My.Resources.Resources.back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 637)
        Me.Controls.Add(Me.GameSartMenu)
        Me.Controls.Add(Me.StartButton)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Matching Game"
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameSartMenu.ResumeLayout(False)
        Me.GameSartMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents StartButton As System.Windows.Forms.PictureBox
    Friend WithEvents GameSartMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents Filetem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitSubMenu As System.Windows.Forms.ToolStripMenuItem

End Class
