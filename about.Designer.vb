<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.TextBox = New System.Windows.Forms.RichTextBox()
        Me.lName = New System.Windows.Forms.Label()
        Me.version = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, 34)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(168, 168)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox.Location = New System.Drawing.Point(197, 64)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(296, 138)
        Me.TextBox.TabIndex = 1
        Me.TextBox.TabStop = False
        Me.TextBox.Text = ""
        '
        'lName
        '
        Me.lName.AutoSize = True
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lName.Location = New System.Drawing.Point(193, 25)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(106, 24)
        Me.lName.TabIndex = 2
        Me.lName.Text = "Card Match"
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.version.Location = New System.Drawing.Point(208, 49)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(26, 12)
        Me.version.TabIndex = 3
        Me.version.Text = "v 1.0"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 261)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents lName As System.Windows.Forms.Label
    Friend WithEvents version As System.Windows.Forms.Label
End Class
