Imports System.IO.Ports
Imports System.Management
Imports System.Text.RegularExpressions
Imports BetaBrite.Protocol
Imports Microsoft.Win32

Public Class Form1

    'TO DO 
    ' Fix error
    ' TransitionType was set to special, but SpecialMode was not specified (None).
    ' Parameter name: SpecialMode

    'Saved Settings
    Private strSetting_Color As String = ""
    Private strSetting_LEDPort As String = ""
    Private strSetting_Message As String = ""
    Private strSetting_Mode As String = ""
    Private strSetting_Font As String = ""
    Private strSetting_Speed As String = ""
    Private strSetting_UpdateSeconds As String = "0"
    Private boolStartup As Boolean = False


    Private boolTrayExit As Boolean = False


    Private Brush_Selected As Brush = Brushes.Yellow
    Private boolOnPhone As Boolean = False
    Private _serialPort_LED As New SerialPort
    'Private handshake_led As Handshake = Handshake.None
    'Private parity_led As Parity = IO.Ports.Parity.Even
    'Private baudrate_led As Integer = 9600
    'Private databits_led As Integer = 7
    'Private stopbits_led As Integer = 1

    Private listPortsLED As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))
    Private listModes As List(Of KeyValuePair(Of String, Byte)) = New List(Of KeyValuePair(Of String, Byte))

    Private LastUpdate As Date


    Private Sub LoadPortsList()

        listPortsLED.Clear()

        Dim strQuery As String = "Select * from Win32_PnPEntity Where Name LIKE '% (COM%)'"

        listPortsLED.Add(New KeyValuePair(Of String, String)("", ""))
        Try

            Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)

            Dim collection As ManagementObjectCollection = searcher.Get
            For Each item As ManagementObject In collection

                Dim fn As String = item.Properties("Name").Value

                Dim strPattern As String = "^.*?\((?<portname>COM[\d]+)\)$"
                Dim m As Match
                m = Regex.Match(fn, strPattern)

                If m.Success Then
                    listPortsLED.Add(New KeyValuePair(Of String, String)(m.Groups("portname").Value, fn))
                End If
            Next


        Catch ex As Exception

            For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
                listPortsLED.Add(New KeyValuePair(Of String, String)(My.Computer.Ports.SerialPortNames(i), My.Computer.Ports.SerialPortNames(i)))
            Next
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClearImage()

        Me.Text = Application.ProductName

        LoadPortsList()



        'Load Fonts
        Dim fnts() As String = System.Enum.GetNames(GetType(Protocol.Font))
        'Dim fntVals() As Byte = System.Enum.GetValues(GetType(Protocol.Font))
        For Each fnt In fnts
            ComboBoxFont.Items.Add(UnCamelCase(fnt))
            FontsToolStripMenuItem.DropDownItems.Add(UnCamelCase(fnt))
        Next


        'Load Colors
        Dim clrs() As String = System.Enum.GetNames(GetType(Protocol.Color))
        For Each clr In clrs
            ComboBoxColor.Items.Add(UnCamelCase(clr))
            ColorsToolStripMenuItem.DropDownItems.Add(UnCamelCase(clr))
        Next


        Dim modes() As String = System.Enum.GetNames(GetType(Protocol.Transition))
        Dim modeVals() As Byte = System.Enum.GetValues(GetType(Protocol.Transition))
        listModes.Add(New KeyValuePair(Of String, Byte)("", 0))
        For i = 0 To UBound(modes)
            Dim mode As String = UnCamelCase(modes(i))
            Dim val As Byte = modeVals(i)
            listModes.Add(New KeyValuePair(Of String, Byte)(mode, val))
        Next

        'Load special chars
        Dim chars() As String = System.Enum.GetNames(GetType(Protocol.ExtChar))
        Dim charsVals() As Integer = System.Enum.GetValues(GetType(Protocol.ExtChar))
        For Each ext As String In chars
            ExtendedCharsToolStripMenuItem.DropDownItems.Add(UnCamelCase(ext))
        Next

        DateToolStripMenuItem.DropDownItems.Add("DDD")
        DateToolStripMenuItem.DropDownItems.Add("MM/DD/YY")
        DateToolStripMenuItem.DropDownItems.Add("DD/MM/YY")
        DateToolStripMenuItem.DropDownItems.Add("MM-DD-YY")
        DateToolStripMenuItem.DropDownItems.Add("DD-MM-YY")
        DateToolStripMenuItem.DropDownItems.Add("MM.DD.YY")
        DateToolStripMenuItem.DropDownItems.Add("DD.MM.YY")
        DateToolStripMenuItem.DropDownItems.Add("MM DD YY")
        DateToolStripMenuItem.DropDownItems.Add("DD MM YY")
        DateToolStripMenuItem.DropDownItems.Add("MMM.DD,YYYY")

        ComboBoxMode.DataSource = listModes
        ComboBoxMode.ValueMember = "Value"
        ComboBoxMode.DisplayMember = "Key"



        'Fill up LED Serial Port Combobox
        'For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
        '    ComboBoxLEDPort.Items.Add(My.Computer.Ports.SerialPortNames(i))
        'Next
        'For Each prt As ComPort In listPorts
        '    ComboBoxLEDPort.Items.Add(prt.FriendlyName)
        'Next
        ComboBoxLEDPort.DataSource = listPortsLED
        ComboBoxLEDPort.ValueMember = "Key"
        ComboBoxLEDPort.DisplayMember = "Value"


        'ComboBoxLEDPort.SelectedIndex = 0
        ComboBoxColor.SelectedIndex = 0
        ComboBoxMode.SelectedIndex = 0

        LoadRegistrySettings()

        LastUpdate = DateAdd(DateInterval.Day, -1, Now)

    End Sub

    Private Sub SendMessage2(ByVal strTextToSend As String)

        Dim strPortName_LED As String = ComboBoxLEDPort.SelectedValue.ToString
        Dim trans As Transition = Transition.Hold


        If strPortName_LED = "" Then
            'MsgBox("No LED port selected!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If strTextToSend <> "" Then
            If Not ComboBoxColor.SelectedItem Is Nothing Then
                If ComboBoxColor.SelectedItem.ToString <> "" Then
                    strTextToSend = "<color=" & ComboBoxColor.SelectedItem.ToString.Replace(" ", "") & ">" & strTextToSend
                End If
            End If

            If Not ComboBoxMode.SelectedItem Is Nothing Then
                Dim key As String = DirectCast(ComboBoxMode.SelectedItem, KeyValuePair(Of String, Byte)).Key
                Dim value As String = DirectCast(ComboBoxMode.SelectedItem, KeyValuePair(Of String, Byte)).Value

                If key <> "" Then
                    trans = value
                End If
            End If

            If Not ComboBoxFont.SelectedItem Is Nothing Then
                If ComboBoxFont.SelectedItem.ToString <> "" Then
                    strTextToSend = "<font=" & ComboBoxFont.SelectedItem.ToString.Replace(" ", "") & ">" & strTextToSend
                End If
            End If

            If Not ComboBoxSpeed.SelectedItem Is Nothing Then
                If ComboBoxSpeed.SelectedItem.ToString <> "" Then
                    strTextToSend = "<speed" & ComboBoxSpeed.SelectedItem.ToString & ">" & strTextToSend
                End If
            End If
        End If


        Dim bb As New BetaBrite.Sign(strPortName_LED)
        With bb
            .Open()
            Try
                .Display(strTextToSend, trans)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

            .Close()

        End With
    End Sub


    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        SendMessage2("")
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Send()
    End Sub

    Private Sub Send()
        'Dim strMessage As String = FormatMessage(TextBoxMessage.Text)
        Dim strMessage As String = TextBoxMessage.Text
        SendMessage2(strMessage)
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub


    Private Sub ButtonSetClock_Click(sender As Object, e As EventArgs) Handles ButtonSetClock.Click

        Dim strPortName_LED As String = ComboBoxLEDPort.SelectedValue.ToString

        If strPortName_LED = "" Then
            MsgBox("No LED port selected!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dt As DateTime

        Dim tf As TimeFormat = TimeFormat.Standard
        Select Case MsgBox("Format Military time?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes
                tf = TimeFormat.Military
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select

        Dim strDate As String = InputBox("Enter the time:", "Set Date/Time", Now)
        If strDate = "" Then Exit Sub

        If Not IsDate(strDate) Then
            MsgBox("Invalid date.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        dt = DateTime.Parse(strDate)

        Dim bb As New BetaBrite.Sign(strPortName_LED)

        With bb
            .Open()
            .SetDateAndTime(dt, tf)
            .Close()
        End With

        System.Threading.Thread.Sleep(100)

        SendMessage2("<calldate=ddd> <calldate=MMM.DD,YYYY> <calltime>")


    End Sub


    Private Sub ButtonSendImage_Click(sender As Object, e As EventArgs) Handles ButtonSendImage.Click
        Dim strPortName_LED As String = ComboBoxLEDPort.SelectedValue.ToString

        If strPortName_LED = "" Then
            MsgBox("No LED port selected!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim bmp As New Bitmap(PictureBox1.Image, New Size(80, 7))

        Dim bb As New BetaBrite.Sign(strPortName_LED)
        With bb
            .Open()
            .UseMemoryText("A"c, 128)
            .UseMemoryPicture("B"c)
            .AllocateMemory()
            .SetPicture("B"c, bmp)

            .SetText("A"c, "<callpic=B>", Transition.Hold)
            .Close()

        End With

    End Sub



    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.None Then Exit Sub

        Dim img As Image = PictureBox1.Image
        Dim g As Graphics = Graphics.FromImage(img)

        Dim squarewidth As Integer
        squarewidth = PictureBox1.Height / 7

        Dim ypos As Integer = e.Y - (e.Y Mod squarewidth)
        Dim xpos As Integer = e.X - (e.X Mod squarewidth)

        Dim brsh As SolidBrush = Brush_Selected
        If e.Button = Windows.Forms.MouseButtons.Right Then
            brsh = New SolidBrush(Drawing.Color.Black)
        End If
        g.FillRectangle(brsh, New Rectangle(xpos, ypos, squarewidth, squarewidth))

        PictureBox1.Image = img
    End Sub

    Private Sub Panels_Click(sender As Object, e As EventArgs) Handles PanelBlack.Click, PanelRed.Click, PanelGreen.Click, PanelAmber.Click, PanelDarkRed.Click, PanelDarkGreen.Click, PanelBrown.Click, PanelOrange.Click, PanelYellow.Click
        For Each cntrl As Control In GroupBoxImage.Controls
            If TypeOf cntrl Is Panel Then
                DirectCast(cntrl, Panel).BorderStyle = BorderStyle.None
            End If
        Next
        Dim pnl As Panel = DirectCast(sender, Panel)
        pnl.BorderStyle = BorderStyle.Fixed3D
        Brush_Selected = New SolidBrush(pnl.BackColor)
    End Sub

    'Private Function map(ByVal x As Long, ByVal in_min As Long, ByVal in_max As Long, ByVal out_min As Long, ByVal out_max As Long) As Long
    '    Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_max + out_min
    'End Function

    Private Sub ClearImage()
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim bmpGraphics As Graphics = Graphics.FromImage(bmp)
        bmpGraphics.FillRectangle(Brushes.Black, 0, 0, bmp.Width, bmp.Height)
        PictureBox1.Image = bmp
    End Sub

    Private Sub ButtonClearImage_Click(sender As Object, e As EventArgs) Handles ButtonClearImage.Click
        ClearImage()
    End Sub

    Private Sub ButtonSaveImage_Click(sender As Object, e As EventArgs) Handles ButtonSaveImage.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fn As String = SaveFileDialog1.FileName
            Dim fi As IO.FileInfo = New IO.FileInfo(fn)
            Dim ext As String = fi.Extension.ToLower
            If ext <> ".bmp" Then
                MsgBox("Invalid extension:  " & ext & vbCrLf & vbCrLf & "Please only save as BMP.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            PictureBox1.Image.Save(fn, Imaging.ImageFormat.Bmp)
            MsgBox("File saved to:  " & fn, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ButtonLoadImage_Click(sender As Object, e As EventArgs) Handles ButtonLoadImage.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fn As String = OpenFileDialog1.FileName
            Dim fi As IO.FileInfo = New IO.FileInfo(fn)
            Dim ext As String = fi.Extension.ToLower
            If Not (ext = ".bmp" Or ext = ".jpg" Or ext = ".png") Then
                MsgBox("Invalid extension:  " & ext & vbCrLf & vbCrLf & "Only BMP,JPG or PNG files are allowed.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim bmp As New Bitmap(Image.FromFile(fn), PictureBox1.Size)
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Console.WriteLine(sender.GetType)

        If TypeOf sender Is Panel Then
            e.Cancel = True
        End If

    End Sub

    Private Sub FontsToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FontsToolStripMenuItem.DropDownItemClicked
        TextBoxMessage.SelectedText = "<font=" & e.ClickedItem.Text.ToLower.Replace(" ", "") & ">"
    End Sub

    Private Sub ExtendedCharsToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ExtendedCharsToolStripMenuItem.DropDownItemClicked
        TextBoxMessage.SelectedText = "<extchar=" & e.ClickedItem.Text.ToLower.Replace(" ", "") & ">"
    End Sub

    Private Sub DateToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles DateToolStripMenuItem.DropDownItemClicked
        TextBoxMessage.SelectedText = "<calldate=" & e.ClickedItem.Text.ToLower.Replace(" ", "") & ">"
    End Sub


    Private Sub ColorsToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ColorsToolStripMenuItem.DropDownItemClicked
        TextBoxMessage.SelectedText = "<color=" & e.ClickedItem.Text.ToLower.Replace(" ", "") & ">"
    End Sub


    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        TextBoxMessage.SelectedText = "<calltime>"
    End Sub

    Private Function UnCamelCase(ByVal strText As String)


        Dim strPattern As String = "([a-z])([A-Z])"
        Return Trim(Regex.Replace(strText, strPattern, "$1 $2"))

    End Function

    Private Sub LoadRegistrySettings()


        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

        Dim appRegKey As RegistryKey
        appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)

        If IsNothing(appRegKey) Then
            'Create the key
            Registry.CurrentUser.CreateSubKey("Software\" & Application.ProductName)
            appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)
            If IsNothing(appRegKey) Then
                Exit Sub
            End If

            'Ask user if they want it to launch auto...
            If MsgBox("Launch " & Application.ProductName & " at Startup?", _
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                            Application.ProductName) = MsgBoxResult.Yes Then
                boolStartup = True
            Else
                boolStartup = False
            End If

            SaveRegistrySettings()

        Else
            strSetting_LEDPort = appRegKey.GetValue("LEDPort", "")

            'Get Current Value and set it in the interface
            boolStartup = appRegKey.GetValue("RunAtStartup", False)

            strSetting_Color = appRegKey.GetValue("Color", "")
            strSetting_LEDPort = appRegKey.GetValue("LEDPort", "")
            strSetting_Message = appRegKey.GetValue("Message", "")
            strSetting_Mode = appRegKey.GetValue("Mode", "")

            strSetting_Font = appRegKey.GetValue("Font", "")
            strSetting_Speed = appRegKey.GetValue("Speed", "")
            strSetting_UpdateSeconds = appRegKey.GetValue("UpdateSeconds", "")

            'RunAtStartupToolStripMenuItem.Checked = boolStartup
            RunAtStartupToolStripMenuItemTRAY.Checked = boolStartup

        End If

        regKey.Close()
        appRegKey.Close()

        If strSetting_LEDPort <> "" Then
            Try
                ComboBoxLEDPort.SelectedValue = strSetting_LEDPort
            Catch ex As Exception
                ComboBoxLEDPort.SelectedIndex = 0
            End Try
        Else
            ComboBoxLEDPort.SelectedIndex = 0
        End If


        If strSetting_Color <> "" Then
            ComboBoxColor.SelectedItem = strSetting_Color
        Else
            ComboBoxColor.SelectedIndex = 0
        End If

        If strSetting_Mode <> "" Then
            For Each itm As KeyValuePair(Of String, Byte) In ComboBoxMode.Items
                If itm.Key.Equals(strSetting_Mode) Then
                    ComboBoxMode.SelectedItem = itm
                    Exit For
                End If
            Next
        Else
            ComboBoxMode.SelectedIndex = 0
        End If

        If strSetting_Font <> "" Then
            ComboBoxFont.SelectedItem = strSetting_Font
        Else
            ComboBoxFont.SelectedIndex = 0
        End If

        If strSetting_Speed <> "" Then
            ComboBoxSpeed.SelectedItem = strSetting_Speed
        Else
            ComboBoxSpeed.SelectedIndex = 0
        End If

        If strSetting_UpdateSeconds <> "" Then
            TextBoxUpdateSeconds.Text = strSetting_UpdateSeconds
        End If

        If strSetting_Message <> "" Then
            TextBoxMessage.Text = strSetting_Message
        End If



    End Sub


    Private Sub SaveRegistrySettings()

        On Error Resume Next

        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

        Dim appRegKey As RegistryKey
        appRegKey = Registry.CurrentUser.OpenSubKey("Software\" & Application.ProductName, True)

        'Save the response
        appRegKey.SetValue("RunAtStartup", boolStartup, RegistryValueKind.DWord)

        'If boolStartup=true, set to run at startup
        If boolStartup = True Then
            regKey.SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            regKey.DeleteValue(Application.ProductName)
        End If

        strSetting_Color = ComboBoxColor.SelectedItem.ToString
        strSetting_LEDPort = GetComboBox(ComboBoxLEDPort).Key
        strSetting_Message = TextBoxMessage.Text


        If Not ComboBoxMode.SelectedItem Is Nothing Then
            Dim pair As KeyValuePair(Of String, Byte) = ComboBoxMode.SelectedItem
            strSetting_Mode = pair.Key
        End If

        strSetting_Font = ComboBoxFont.SelectedItem.ToString
        strSetting_Speed = ComboBoxSpeed.SelectedItem.ToString
        strSetting_UpdateSeconds = TextBoxUpdateSeconds.Text

        appRegKey.SetValue("Color", strSetting_Color)
        appRegKey.SetValue("LEDPort", strSetting_LEDPort)
        appRegKey.SetValue("Message", strSetting_Message)
        appRegKey.SetValue("Mode", strSetting_Mode)
        appRegKey.SetValue("Font", strSetting_Font)
        appRegKey.SetValue("Speed", strSetting_Speed)
        appRegKey.SetValue("UpdateSeconds", strSetting_UpdateSeconds)


        regKey.Close()
        appRegKey.Close()

        MsgBox("Settings saved.", MsgBoxStyle.Information)

    End Sub


    'Private Sub ComboBoxLEDPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLEDPort.SelectedIndexChanged
    '    SaveRegistrySettings()
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsNumeric(TextBoxUpdateSeconds.Text) Then Exit Sub

        If ComboBoxLEDPort.Text = "" Then Exit Sub

        Dim intInterval As Double = CDbl(TextBoxUpdateSeconds.Text)
        If Not intInterval > 0 Then Exit Sub

        If DateDiff(DateInterval.Second, LastUpdate, Now) >= intInterval Then
            Send()
            LastUpdate = Now
        End If

    End Sub

    Private Sub SystemTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemTimeToolStripMenuItem.Click
        TextBoxMessage.SelectedText = "<systemtime>"
    End Sub

    Private Sub SystemDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemDateToolStripMenuItem.Click
        TextBoxMessage.SelectedText = "<systemdate>"
    End Sub

    Private Sub URLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles URLToolStripMenuItem.Click
        TextBoxMessage.SelectedText = "<url=ENTER-THE-URL-HERE>"
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Application.ProductName

        If Me.WindowState = FormWindowState.Minimized Then Me.Hide()
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If boolTrayExit = False Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Exit Sub
        End If
    End Sub


    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then
            'NotifyIcon1.ContextMenu = ContextMenuIcon
        End If
        If e.Button = MouseButtons.Left Then
            ShowMe()
        End If

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        boolTrayExit = True
        Application.Exit()
    End Sub



    Private Function GetComboBox(ByRef box As ComboBox) As KeyValuePair(Of String, String)
        Dim pair As KeyValuePair(Of String, String) = New KeyValuePair(Of String, String)("", "")
        If Not box.SelectedItem Is Nothing Then
            Dim key As String = DirectCast(box.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim value As String = DirectCast(box.SelectedItem, KeyValuePair(Of String, String)).Value
            pair = New KeyValuePair(Of String, String)(key, value)
        End If

        Return pair
    End Function


    Private Sub ShowMe()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        Me.Activate()
        If Me.Location.X < 0 Or Me.Location.Y < 0 Then Me.CenterToScreen()

    End Sub

    Private Sub ButtonSaveSettings_Click(sender As Object, e As EventArgs) Handles ButtonSaveSettings.Click
        SaveRegistrySettings()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub


    Private Sub RunAtStartupToolStripMenuItemTRAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAtStartupToolStripMenuItemTRAY.Click
        boolStartup = RunAtStartupToolStripMenuItemTRAY.Checked
        SaveRegistrySettings()
    End Sub


    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        ShowMe()
    End Sub


    Private Sub Form1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move

        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.ShowBalloonTip(600, Application.ProductName, "Click to activate", ToolTipIcon.Info)
            Me.ShowInTaskbar = False
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub


End Class
