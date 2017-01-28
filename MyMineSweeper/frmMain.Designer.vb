<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.tsmiNew = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiNew2 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel1 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel2 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel3 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel4 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiLevel5 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.tsmiLevel, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiNew
        '
        Me.tsmiNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew2, Me.tsmiExit})
        Me.tsmiNew.Name = "tsmiNew"
        Me.tsmiNew.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmiNew.Size = New System.Drawing.Size(77, 20)
        Me.tsmiNew.Text = "&New Game"
        '
        'tsmiNew2
        '
        Me.tsmiNew2.Name = "tsmiNew2"
        Me.tsmiNew2.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmiNew2.Size = New System.Drawing.Size(117, 22)
        Me.tsmiNew2.Text = "&New"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeyDisplayString = "Esc"
        Me.tsmiExit.Size = New System.Drawing.Size(117, 22)
        Me.tsmiExit.Text = "&Exit"
        '
        'tsmiLevel
        '
        Me.tsmiLevel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLevel1, Me.tsmiLevel2, Me.tsmiLevel3, Me.tsmiLevel4, Me.tsmiLevel5})
        Me.tsmiLevel.Name = "tsmiLevel"
        Me.tsmiLevel.Size = New System.Drawing.Size(55, 20)
        Me.tsmiLevel.Text = "Level 1"
        '
        'tsmiLevel1
        '
        Me.tsmiLevel1.Checked = True
        Me.tsmiLevel1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiLevel1.Name = "tsmiLevel1"
        Me.tsmiLevel1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.tsmiLevel1.Size = New System.Drawing.Size(152, 22)
        Me.tsmiLevel1.Text = "Level &1"
        '
        'tsmiLevel2
        '
        Me.tsmiLevel2.Name = "tsmiLevel2"
        Me.tsmiLevel2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.tsmiLevel2.Size = New System.Drawing.Size(152, 22)
        Me.tsmiLevel2.Text = "Level &2"
        '
        'tsmiLevel3
        '
        Me.tsmiLevel3.Name = "tsmiLevel3"
        Me.tsmiLevel3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.tsmiLevel3.Size = New System.Drawing.Size(152, 22)
        Me.tsmiLevel3.Text = "Level &3"
        '
        'tsmiLevel4
        '
        Me.tsmiLevel4.Name = "tsmiLevel4"
        Me.tsmiLevel4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.tsmiLevel4.Size = New System.Drawing.Size(152, 22)
        Me.tsmiLevel4.Text = "Level &4"
        '
        'tsmiLevel5
        '
        Me.tsmiLevel5.Name = "tsmiLevel5"
        Me.tsmiLevel5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.tsmiLevel5.Size = New System.Drawing.Size(152, 22)
        Me.tsmiLevel5.Text = "Level &5"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiHelp, Me.tsmiAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmiHelp.Size = New System.Drawing.Size(184, 22)
        Me.tsmiHelp.Text = "&Help"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(184, 22)
        Me.tsmiAbout.Text = "&About Mine Sweeper"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(73, 17)
        Me.lblStatus.Text = "Click to start"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 17)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "De fréu Help.PNG")
        Me.ImageList1.Images.SetKeyName(1, "De fréu Info.PNG")
        Me.ImageList1.Images.SetKeyName(2, "1_Network.ico")
        Me.ImageList1.Images.SetKeyName(3, "De fréu Error.PNG")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Mine Sweeper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsmiNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmiNew2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem

End Class
