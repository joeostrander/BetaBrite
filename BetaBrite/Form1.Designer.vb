<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelLEDPort = New System.Windows.Forms.Label()
        Me.ComboBoxLEDPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.ContextMenuStripMessage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtendedCharsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ComboBoxMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxFont = New System.Windows.Forms.ComboBox()
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.ButtonSetClock = New System.Windows.Forms.Button()
        Me.ComboBoxSpeed = New System.Windows.Forms.ComboBox()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.ButtonSendImage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripBLANK = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelBlack = New System.Windows.Forms.Panel()
        Me.PanelRed = New System.Windows.Forms.Panel()
        Me.PanelGreen = New System.Windows.Forms.Panel()
        Me.PanelAmber = New System.Windows.Forms.Panel()
        Me.PanelDarkRed = New System.Windows.Forms.Panel()
        Me.PanelDarkGreen = New System.Windows.Forms.Panel()
        Me.PanelBrown = New System.Windows.Forms.Panel()
        Me.PanelYellow = New System.Windows.Forms.Panel()
        Me.PanelOrange = New System.Windows.Forms.Panel()
        Me.ButtonClearImage = New System.Windows.Forms.Button()
        Me.ButtonLoadImage = New System.Windows.Forms.Button()
        Me.ButtonSaveImage = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxText = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.CheckBoxUseFile = New System.Windows.Forms.CheckBox()
        Me.TextBoxUpdateSeconds = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStripTRAY = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunAtStartupToolStripMenuItemTRAY = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSaveSettings = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxRunAtStartup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMilitaryTime = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSynchClock = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStripMessage.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxText.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        Me.ContextMenuStripTRAY.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelLEDPort
        '
        Me.LabelLEDPort.AutoSize = True
        Me.LabelLEDPort.Location = New System.Drawing.Point(4, 11)
        Me.LabelLEDPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLEDPort.Name = "LabelLEDPort"
        Me.LabelLEDPort.Size = New System.Drawing.Size(69, 17)
        Me.LabelLEDPort.TabIndex = 0
        Me.LabelLEDPort.Text = "&LED Port:"
        '
        'ComboBoxLEDPort
        '
        Me.ComboBoxLEDPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLEDPort.FormattingEnabled = True
        Me.ComboBoxLEDPort.Location = New System.Drawing.Point(8, 31)
        Me.ComboBoxLEDPort.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxLEDPort.Name = "ComboBoxLEDPort"
        Me.ComboBoxLEDPort.Size = New System.Drawing.Size(593, 24)
        Me.ComboBoxLEDPort.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Text to Send:"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.ContextMenuStrip = Me.ContextMenuStripMessage
        Me.TextBoxMessage.Location = New System.Drawing.Point(8, 106)
        Me.TextBoxMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(585, 22)
        Me.TextBoxMessage.TabIndex = 9
        '
        'ContextMenuStripMessage
        '
        Me.ContextMenuStripMessage.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripMessage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorsToolStripMenuItem, Me.ExtendedCharsToolStripMenuItem, Me.FontsToolStripMenuItem, Me.DateToolStripMenuItem, Me.TimeToolStripMenuItem, Me.SystemTimeToolStripMenuItem, Me.SystemDateToolStripMenuItem, Me.URLToolStripMenuItem})
        Me.ContextMenuStripMessage.Name = "ContextMenuStripMessage"
        Me.ContextMenuStripMessage.ShowImageMargin = False
        Me.ContextMenuStripMessage.Size = New System.Drawing.Size(156, 196)
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ColorsToolStripMenuItem.Text = "&Colors"
        '
        'ExtendedCharsToolStripMenuItem
        '
        Me.ExtendedCharsToolStripMenuItem.Name = "ExtendedCharsToolStripMenuItem"
        Me.ExtendedCharsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ExtendedCharsToolStripMenuItem.Text = "&Extended Chars"
        '
        'FontsToolStripMenuItem
        '
        Me.FontsToolStripMenuItem.Name = "FontsToolStripMenuItem"
        Me.FontsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.FontsToolStripMenuItem.Text = "&Fonts"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.DateToolStripMenuItem.Text = "&Date"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.TimeToolStripMenuItem.Text = "&Time"
        '
        'SystemTimeToolStripMenuItem
        '
        Me.SystemTimeToolStripMenuItem.Name = "SystemTimeToolStripMenuItem"
        Me.SystemTimeToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.SystemTimeToolStripMenuItem.Text = "&System Time"
        '
        'SystemDateToolStripMenuItem
        '
        Me.SystemDateToolStripMenuItem.Name = "SystemDateToolStripMenuItem"
        Me.SystemDateToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.SystemDateToolStripMenuItem.Text = "S&ystem Date"
        '
        'URLToolStripMenuItem
        '
        Me.URLToolStripMenuItem.Name = "URLToolStripMenuItem"
        Me.URLToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.URLToolStripMenuItem.Text = "&URL"
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Items.AddRange(New Object() {""})
        Me.ComboBoxColor.Location = New System.Drawing.Point(8, 44)
        Me.ComboBoxColor.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxColor.TabIndex = 1
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.Location = New System.Drawing.Point(4, 25)
        Me.LabelColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(45, 17)
        Me.LabelColor.TabIndex = 0
        Me.LabelColor.Text = "C&olor:"
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(24, 514)
        Me.ButtonSend.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(133, 43)
        Me.ButtonSend.TabIndex = 5
        Me.ButtonSend.Text = "&Send Text"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClear.Location = New System.Drawing.Point(309, 514)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(133, 43)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "&Clear Display"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ComboBoxMode
        '
        Me.ComboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMode.FormattingEnabled = True
        Me.ComboBoxMode.Items.AddRange(New Object() {""})
        Me.ComboBoxMode.Location = New System.Drawing.Point(177, 44)
        Me.ComboBoxMode.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMode.Name = "ComboBoxMode"
        Me.ComboBoxMode.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxMode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Mode:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(95, 28)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(right-click field to insert special)"
        '
        'ComboBoxFont
        '
        Me.ComboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFont.FormattingEnabled = True
        Me.ComboBoxFont.Items.AddRange(New Object() {""})
        Me.ComboBoxFont.Location = New System.Drawing.Point(347, 44)
        Me.ComboBoxFont.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxFont.Name = "ComboBoxFont"
        Me.ComboBoxFont.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxFont.TabIndex = 5
        '
        'LabelFont
        '
        Me.LabelFont.AutoSize = True
        Me.LabelFont.Location = New System.Drawing.Point(343, 25)
        Me.LabelFont.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(40, 17)
        Me.LabelFont.TabIndex = 4
        Me.LabelFont.Text = "&Font:"
        '
        'ButtonSetClock
        '
        Me.ButtonSetClock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSetClock.Location = New System.Drawing.Point(451, 514)
        Me.ButtonSetClock.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSetClock.Name = "ButtonSetClock"
        Me.ButtonSetClock.Size = New System.Drawing.Size(132, 43)
        Me.ButtonSetClock.TabIndex = 0
        Me.ButtonSetClock.Text = "Set Cloc&k"
        Me.ButtonSetClock.UseVisualStyleBackColor = True
        '
        'ComboBoxSpeed
        '
        Me.ComboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpeed.FormattingEnabled = True
        Me.ComboBoxSpeed.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5"})
        Me.ComboBoxSpeed.Location = New System.Drawing.Point(516, 44)
        Me.ComboBoxSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSpeed.Name = "ComboBoxSpeed"
        Me.ComboBoxSpeed.Size = New System.Drawing.Size(77, 24)
        Me.ComboBoxSpeed.TabIndex = 7
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Location = New System.Drawing.Point(512, 25)
        Me.LabelSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(53, 17)
        Me.LabelSpeed.TabIndex = 6
        Me.LabelSpeed.Text = "S&peed:"
        '
        'ButtonSendImage
        '
        Me.ButtonSendImage.Location = New System.Drawing.Point(165, 514)
        Me.ButtonSendImage.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSendImage.Name = "ButtonSendImage"
        Me.ButtonSendImage.Size = New System.Drawing.Size(133, 43)
        Me.ButtonSendImage.TabIndex = 6
        Me.ButtonSendImage.Text = "Send &Image"
        Me.ButtonSendImage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStripBLANK
        Me.PictureBox1.Location = New System.Drawing.Point(15, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 52)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStripBLANK
        '
        Me.ContextMenuStripBLANK.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripBLANK.Name = "ContextMenuStripBLANK"
        Me.ContextMenuStripBLANK.Size = New System.Drawing.Size(61, 4)
        '
        'PanelBlack
        '
        Me.PanelBlack.BackColor = System.Drawing.Color.Black
        Me.PanelBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelBlack.Location = New System.Drawing.Point(15, 82)
        Me.PanelBlack.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBlack.Name = "PanelBlack"
        Me.PanelBlack.Size = New System.Drawing.Size(53, 34)
        Me.PanelBlack.TabIndex = 0
        '
        'PanelRed
        '
        Me.PanelRed.BackColor = System.Drawing.Color.Red
        Me.PanelRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelRed.Location = New System.Drawing.Point(76, 82)
        Me.PanelRed.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRed.Name = "PanelRed"
        Me.PanelRed.Size = New System.Drawing.Size(53, 34)
        Me.PanelRed.TabIndex = 1
        '
        'PanelGreen
        '
        Me.PanelGreen.BackColor = System.Drawing.Color.Lime
        Me.PanelGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelGreen.Location = New System.Drawing.Point(137, 82)
        Me.PanelGreen.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelGreen.Name = "PanelGreen"
        Me.PanelGreen.Size = New System.Drawing.Size(53, 34)
        Me.PanelGreen.TabIndex = 2
        '
        'PanelAmber
        '
        Me.PanelAmber.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelAmber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAmber.Location = New System.Drawing.Point(199, 82)
        Me.PanelAmber.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelAmber.Name = "PanelAmber"
        Me.PanelAmber.Size = New System.Drawing.Size(53, 34)
        Me.PanelAmber.TabIndex = 3
        '
        'PanelDarkRed
        '
        Me.PanelDarkRed.BackColor = System.Drawing.Color.Maroon
        Me.PanelDarkRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelDarkRed.Location = New System.Drawing.Point(260, 82)
        Me.PanelDarkRed.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDarkRed.Name = "PanelDarkRed"
        Me.PanelDarkRed.Size = New System.Drawing.Size(53, 34)
        Me.PanelDarkRed.TabIndex = 4
        '
        'PanelDarkGreen
        '
        Me.PanelDarkGreen.BackColor = System.Drawing.Color.Green
        Me.PanelDarkGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelDarkGreen.Location = New System.Drawing.Point(321, 82)
        Me.PanelDarkGreen.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDarkGreen.Name = "PanelDarkGreen"
        Me.PanelDarkGreen.Size = New System.Drawing.Size(53, 34)
        Me.PanelDarkGreen.TabIndex = 5
        '
        'PanelBrown
        '
        Me.PanelBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PanelBrown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelBrown.Location = New System.Drawing.Point(383, 82)
        Me.PanelBrown.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBrown.Name = "PanelBrown"
        Me.PanelBrown.Size = New System.Drawing.Size(53, 34)
        Me.PanelBrown.TabIndex = 6
        '
        'PanelYellow
        '
        Me.PanelYellow.BackColor = System.Drawing.Color.Yellow
        Me.PanelYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelYellow.Location = New System.Drawing.Point(505, 82)
        Me.PanelYellow.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelYellow.Name = "PanelYellow"
        Me.PanelYellow.Size = New System.Drawing.Size(52, 34)
        Me.PanelYellow.TabIndex = 8
        '
        'PanelOrange
        '
        Me.PanelOrange.BackColor = System.Drawing.Color.Orange
        Me.PanelOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelOrange.Location = New System.Drawing.Point(444, 82)
        Me.PanelOrange.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(53, 34)
        Me.PanelOrange.TabIndex = 7
        '
        'ButtonClearImage
        '
        Me.ButtonClearImage.Location = New System.Drawing.Point(23, 124)
        Me.ButtonClearImage.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClearImage.Name = "ButtonClearImage"
        Me.ButtonClearImage.Size = New System.Drawing.Size(107, 28)
        Me.ButtonClearImage.TabIndex = 9
        Me.ButtonClearImage.Text = "&Erase Image"
        Me.ButtonClearImage.UseVisualStyleBackColor = True
        '
        'ButtonLoadImage
        '
        Me.ButtonLoadImage.Location = New System.Drawing.Point(137, 124)
        Me.ButtonLoadImage.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLoadImage.Name = "ButtonLoadImage"
        Me.ButtonLoadImage.Size = New System.Drawing.Size(107, 28)
        Me.ButtonLoadImage.TabIndex = 10
        Me.ButtonLoadImage.Text = "Load Image"
        Me.ButtonLoadImage.UseVisualStyleBackColor = True
        '
        'ButtonSaveImage
        '
        Me.ButtonSaveImage.Location = New System.Drawing.Point(252, 124)
        Me.ButtonSaveImage.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveImage.Name = "ButtonSaveImage"
        Me.ButtonSaveImage.Size = New System.Drawing.Size(107, 28)
        Me.ButtonSaveImage.TabIndex = 11
        Me.ButtonSaveImage.Text = "Save Image"
        Me.ButtonSaveImage.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bitmap Files|*.bmp"
        '
        'GroupBoxText
        '
        Me.GroupBoxText.Controls.Add(Me.ButtonBrowse)
        Me.GroupBoxText.Controls.Add(Me.CheckBoxUseFile)
        Me.GroupBoxText.Controls.Add(Me.TextBoxUpdateSeconds)
        Me.GroupBoxText.Controls.Add(Me.Label4)
        Me.GroupBoxText.Controls.Add(Me.ComboBoxColor)
        Me.GroupBoxText.Controls.Add(Me.Label1)
        Me.GroupBoxText.Controls.Add(Me.TextBoxMessage)
        Me.GroupBoxText.Controls.Add(Me.LabelColor)
        Me.GroupBoxText.Controls.Add(Me.Label2)
        Me.GroupBoxText.Controls.Add(Me.ComboBoxMode)
        Me.GroupBoxText.Controls.Add(Me.Label3)
        Me.GroupBoxText.Controls.Add(Me.LabelFont)
        Me.GroupBoxText.Controls.Add(Me.ComboBoxFont)
        Me.GroupBoxText.Controls.Add(Me.LabelSpeed)
        Me.GroupBoxText.Controls.Add(Me.ComboBoxSpeed)
        Me.GroupBoxText.Location = New System.Drawing.Point(8, 76)
        Me.GroupBoxText.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxText.Name = "GroupBoxText"
        Me.GroupBoxText.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxText.Size = New System.Drawing.Size(724, 166)
        Me.GroupBoxText.TabIndex = 2
        Me.GroupBoxText.TabStop = False
        Me.GroupBoxText.Text = "Text"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(518, 103)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 28)
        Me.ButtonBrowse.TabIndex = 13
        Me.ButtonBrowse.Text = "&Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        Me.ButtonBrowse.Visible = False
        '
        'CheckBoxUseFile
        '
        Me.CheckBoxUseFile.AutoSize = True
        Me.CheckBoxUseFile.Location = New System.Drawing.Point(604, 108)
        Me.CheckBoxUseFile.Name = "CheckBoxUseFile"
        Me.CheckBoxUseFile.Size = New System.Drawing.Size(81, 21)
        Me.CheckBoxUseFile.TabIndex = 11
        Me.CheckBoxUseFile.Text = "Use File"
        Me.CheckBoxUseFile.UseVisualStyleBackColor = True
        '
        'TextBoxUpdateSeconds
        '
        Me.TextBoxUpdateSeconds.Location = New System.Drawing.Point(604, 46)
        Me.TextBoxUpdateSeconds.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxUpdateSeconds.Name = "TextBoxUpdateSeconds"
        Me.TextBoxUpdateSeconds.Size = New System.Drawing.Size(77, 22)
        Me.TextBoxUpdateSeconds.TabIndex = 12
        Me.TextBoxUpdateSeconds.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "&Update (secs)"
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.Button1)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox1)
        Me.GroupBoxImage.Controls.Add(Me.PanelBlack)
        Me.GroupBoxImage.Controls.Add(Me.PanelRed)
        Me.GroupBoxImage.Controls.Add(Me.PanelGreen)
        Me.GroupBoxImage.Controls.Add(Me.PanelAmber)
        Me.GroupBoxImage.Controls.Add(Me.ButtonSaveImage)
        Me.GroupBoxImage.Controls.Add(Me.PanelDarkRed)
        Me.GroupBoxImage.Controls.Add(Me.ButtonLoadImage)
        Me.GroupBoxImage.Controls.Add(Me.PanelDarkGreen)
        Me.GroupBoxImage.Controls.Add(Me.ButtonClearImage)
        Me.GroupBoxImage.Controls.Add(Me.PanelBrown)
        Me.GroupBoxImage.Controls.Add(Me.PanelOrange)
        Me.GroupBoxImage.Controls.Add(Me.PanelYellow)
        Me.GroupBoxImage.Location = New System.Drawing.Point(8, 250)
        Me.GroupBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxImage.Size = New System.Drawing.Size(724, 176)
        Me.GroupBoxImage.TabIndex = 4
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Image"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 88)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.TabStop = False
        Me.Button1.Text = "TEST"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStripTRAY
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "BetaBrite"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStripTRAY
        '
        Me.ContextMenuStripTRAY.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripTRAY.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunAtStartupToolStripMenuItemTRAY, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStripTRAY.Name = "ContextMenuStripTRAY"
        Me.ContextMenuStripTRAY.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStripTRAY.ShowCheckMargin = True
        Me.ContextMenuStripTRAY.ShowImageMargin = False
        Me.ContextMenuStripTRAY.Size = New System.Drawing.Size(173, 76)
        '
        'RunAtStartupToolStripMenuItemTRAY
        '
        Me.RunAtStartupToolStripMenuItemTRAY.CheckOnClick = True
        Me.RunAtStartupToolStripMenuItemTRAY.Name = "RunAtStartupToolStripMenuItemTRAY"
        Me.RunAtStartupToolStripMenuItemTRAY.Size = New System.Drawing.Size(172, 24)
        Me.RunAtStartupToolStripMenuItemTRAY.Text = "&Run at Startup"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(172, 24)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ButtonSaveSettings
        '
        Me.ButtonSaveSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSaveSettings.Location = New System.Drawing.Point(591, 514)
        Me.ButtonSaveSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveSettings.Name = "ButtonSaveSettings"
        Me.ButtonSaveSettings.Size = New System.Drawing.Size(132, 43)
        Me.ButtonSaveSettings.TabIndex = 8
        Me.ButtonSaveSettings.Text = "Sa&ve Settings"
        Me.ButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(745, 25)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxRunAtStartup)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMilitaryTime)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSynchClock)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 433)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(724, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settin&gs"
        '
        'CheckBoxRunAtStartup
        '
        Me.CheckBoxRunAtStartup.AutoSize = True
        Me.CheckBoxRunAtStartup.Location = New System.Drawing.Point(391, 23)
        Me.CheckBoxRunAtStartup.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxRunAtStartup.Name = "CheckBoxRunAtStartup"
        Me.CheckBoxRunAtStartup.Size = New System.Drawing.Size(120, 21)
        Me.CheckBoxRunAtStartup.TabIndex = 2
        Me.CheckBoxRunAtStartup.Text = "Run at startup"
        Me.CheckBoxRunAtStartup.UseVisualStyleBackColor = True
        '
        'CheckBoxMilitaryTime
        '
        Me.CheckBoxMilitaryTime.AutoSize = True
        Me.CheckBoxMilitaryTime.Location = New System.Drawing.Point(207, 23)
        Me.CheckBoxMilitaryTime.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxMilitaryTime.Name = "CheckBoxMilitaryTime"
        Me.CheckBoxMilitaryTime.Size = New System.Drawing.Size(138, 21)
        Me.CheckBoxMilitaryTime.TabIndex = 1
        Me.CheckBoxMilitaryTime.Text = "Use Military Time"
        Me.CheckBoxMilitaryTime.UseVisualStyleBackColor = True
        '
        'CheckBoxSynchClock
        '
        Me.CheckBoxSynchClock.AutoSize = True
        Me.CheckBoxSynchClock.Location = New System.Drawing.Point(23, 23)
        Me.CheckBoxSynchClock.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSynchClock.Name = "CheckBoxSynchClock"
        Me.CheckBoxSynchClock.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxSynchClock.TabIndex = 0
        Me.CheckBoxSynchClock.Text = "Synchronize Clock"
        Me.ToolTip1.SetToolTip(Me.CheckBoxSynchClock, "Synchronize the clock with PC clock")
        Me.CheckBoxSynchClock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.ButtonSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClear
        Me.ClientSize = New System.Drawing.Size(745, 597)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ButtonSaveSettings)
        Me.Controls.Add(Me.GroupBoxImage)
        Me.Controls.Add(Me.GroupBoxText)
        Me.Controls.Add(Me.ButtonSendImage)
        Me.Controls.Add(Me.ButtonSetClock)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.ComboBoxLEDPort)
        Me.Controls.Add(Me.LabelLEDPort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(761, 585)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ContextMenuStripMessage.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxText.ResumeLayout(False)
        Me.GroupBoxText.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.ContextMenuStripTRAY.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelLEDPort As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLEDPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMessage As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxColor As System.Windows.Forms.ComboBox
    Friend WithEvents LabelColor As System.Windows.Forms.Label
    Friend WithEvents ButtonSend As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ComboBoxMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripMessage As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxFont As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFont As System.Windows.Forms.Label
    Friend WithEvents ButtonSetClock As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents ButtonSendImage As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelBlack As System.Windows.Forms.Panel
    Friend WithEvents PanelRed As System.Windows.Forms.Panel
    Friend WithEvents PanelGreen As System.Windows.Forms.Panel
    Friend WithEvents PanelAmber As System.Windows.Forms.Panel
    Friend WithEvents PanelDarkRed As System.Windows.Forms.Panel
    Friend WithEvents PanelDarkGreen As System.Windows.Forms.Panel
    Friend WithEvents PanelBrown As System.Windows.Forms.Panel
    Friend WithEvents PanelYellow As System.Windows.Forms.Panel
    Friend WithEvents PanelOrange As System.Windows.Forms.Panel
    Friend WithEvents ButtonClearImage As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadImage As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveImage As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStripBLANK As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBoxText As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxImage As System.Windows.Forms.GroupBox
    Friend WithEvents FontsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtendedCharsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxUpdateSeconds As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SystemTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStripTRAY As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunAtStartupToolStripMenuItemTRAY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonSaveSettings As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxRunAtStartup As CheckBox
    Friend WithEvents CheckBoxMilitaryTime As CheckBox
    Friend WithEvents CheckBoxSynchClock As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxUseFile As CheckBox
    Friend WithEvents ButtonBrowse As Button
End Class
