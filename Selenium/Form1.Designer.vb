﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timertext = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Stopbutton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tokeninput = New System.Windows.Forms.TextBox()
        Me.tokenlogin = New System.Windows.Forms.CheckBox()
        Me.Namebox = New System.Windows.Forms.MaskedTextBox()
        Me.Passbox = New System.Windows.Forms.MaskedTextBox()
        Me.Remainingtime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Streamerinput = New System.Windows.Forms.TextBox()
        Me.Watchstreamer = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Waitbox = New System.Windows.Forms.TextBox()
        Me.Followbox = New System.Windows.Forms.CheckBox()
        Me.proxycheckbox = New System.Windows.Forms.CheckBox()
        Me.proxyinput = New System.Windows.Forms.TextBox()
        Me.volinput = New System.Windows.Forms.TextBox()
        Me.customaudio = New System.Windows.Forms.CheckBox()
        Me.muteaudio = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Claimpoints = New System.Windows.Forms.CheckBox()
        Me.Checkdrop = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chatinput = New System.Windows.Forms.TextBox()
        Me.Chatinput2 = New System.Windows.Forms.TextBox()
        Me.Chatminute = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Chatbox = New System.Windows.Forms.CheckBox()
        Me.prioritymode = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cookiessave = New System.Windows.Forms.CheckBox()
        Me.chromehide = New System.Windows.Forms.CheckBox()
        Me.commandhide = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker5 = New System.ComponentModel.BackgroundWorker()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Dropfound = New System.Windows.Forms.Label()
        Me.Valorantdrop = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chromebox = New System.Windows.Forms.CheckBox()
        Me.Firefoxbox = New System.Windows.Forms.CheckBox()
        Me.backgroundbox = New System.Windows.Forms.CheckBox()
        Me.crossthreadbox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timertext
        '
        Me.Timertext.AutoSize = True
        Me.Timertext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timertext.Location = New System.Drawing.Point(579, 365)
        Me.Timertext.Name = "Timertext"
        Me.Timertext.Size = New System.Drawing.Size(0, 20)
        Me.Timertext.TabIndex = 13
        Me.Timertext.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        '
        'Stopbutton
        '
        Me.Stopbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Stopbutton.Location = New System.Drawing.Point(518, 460)
        Me.Stopbutton.Name = "Stopbutton"
        Me.Stopbutton.Size = New System.Drawing.Size(117, 99)
        Me.Stopbutton.TabIndex = 28
        Me.Stopbutton.Text = "Stop"
        Me.ToolTip1.SetToolTip(Me.Stopbutton, "This will stop all sessions")
        Me.Stopbutton.UseMnemonic = False
        Me.Stopbutton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(402, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 99)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Start another Account"
        Me.ToolTip1.SetToolTip(Me.Button2, "You can run multiple Accounts at once. Just type in other Login Credentials and p" &
        "ress this Button everytime you want to start another instance.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(286, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 99)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.Button1, "Press this Button to start your first Account.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tokeninput
        '
        Me.tokeninput.Location = New System.Drawing.Point(16, 508)
        Me.tokeninput.Name = "tokeninput"
        Me.tokeninput.Size = New System.Drawing.Size(232, 20)
        Me.tokeninput.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.tokeninput, resources.GetString("tokeninput.ToolTip"))
        '
        'tokenlogin
        '
        Me.tokenlogin.AutoSize = True
        Me.tokenlogin.Location = New System.Drawing.Point(17, 487)
        Me.tokenlogin.Name = "tokenlogin"
        Me.tokenlogin.Size = New System.Drawing.Size(231, 17)
        Me.tokenlogin.TabIndex = 27
        Me.tokenlogin.Text = "Or else login with your Twtich ""auth-token"":"
        Me.ToolTip1.SetToolTip(Me.tokenlogin, resources.GetString("tokenlogin.ToolTip"))
        Me.tokenlogin.UseVisualStyleBackColor = True
        '
        'Namebox
        '
        Me.Namebox.Location = New System.Drawing.Point(111, 432)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.Size = New System.Drawing.Size(138, 20)
        Me.Namebox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Namebox, "Type in your Twitch Username")
        '
        'Passbox
        '
        Me.Passbox.Location = New System.Drawing.Point(111, 457)
        Me.Passbox.Name = "Passbox"
        Me.Passbox.Size = New System.Drawing.Size(138, 20)
        Me.Passbox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Passbox, "Type in your Twitch Password")
        Me.Passbox.UseSystemPasswordChar = True
        '
        'Remainingtime
        '
        Me.Remainingtime.AutoSize = True
        Me.Remainingtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remainingtime.Location = New System.Drawing.Point(316, 365)
        Me.Remainingtime.Name = "Remainingtime"
        Me.Remainingtime.Size = New System.Drawing.Size(257, 20)
        Me.Remainingtime.TabIndex = 14
        Me.Remainingtime.Text = "Remaining watchtime on Streamer:"
        Me.ToolTip1.SetToolTip(Me.Remainingtime, "This shows the remaining Seconds it watches on this Stream")
        Me.Remainingtime.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Name:"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        '
        'Streamerinput
        '
        Me.Streamerinput.Location = New System.Drawing.Point(61, 316)
        Me.Streamerinput.Name = "Streamerinput"
        Me.Streamerinput.Size = New System.Drawing.Size(143, 20)
        Me.Streamerinput.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.Streamerinput, resources.GetString("Streamerinput.ToolTip"))
        '
        'Watchstreamer
        '
        Me.Watchstreamer.AutoSize = True
        Me.Watchstreamer.Location = New System.Drawing.Point(19, 298)
        Me.Watchstreamer.Name = "Watchstreamer"
        Me.Watchstreamer.Size = New System.Drawing.Size(145, 17)
        Me.Watchstreamer.TabIndex = 40
        Me.Watchstreamer.Text = "Watch specific Streamer:"
        Me.ToolTip1.SetToolTip(Me.Watchstreamer, resources.GetString("Watchstreamer.ToolTip"))
        Me.Watchstreamer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "in Minutes:"
        Me.ToolTip1.SetToolTip(Me.Label6, "It will watch a Streamer for X Minutes until it searches a new one." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use a smal" &
        "l Value 15-30 Minutes. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If a streamer goes offline it will still continue to wa" &
        "tch the streamer this time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Search every X minutes a new Stream:"
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'Waitbox
        '
        Me.Waitbox.Location = New System.Drawing.Point(74, 263)
        Me.Waitbox.Name = "Waitbox"
        Me.Waitbox.Size = New System.Drawing.Size(130, 20)
        Me.Waitbox.TabIndex = 11
        Me.Waitbox.Text = "20"
        Me.Waitbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Waitbox, "It will watch a Streamer for X Minutes until it searches a new one." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use a smal" &
        "l Value 15-30 Minutes. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If a streamer goes offline it will still continue to wa" &
        "tch the streamer this time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Followbox
        '
        Me.Followbox.AutoSize = True
        Me.Followbox.Location = New System.Drawing.Point(223, 253)
        Me.Followbox.Name = "Followbox"
        Me.Followbox.Size = New System.Drawing.Size(223, 30)
        Me.Followbox.TabIndex = 7
        Me.Followbox.Text = "Follow the Streamer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( to be able to write in follower-only chats )"
        Me.ToolTip1.SetToolTip(Me.Followbox, "Some streamers disabled their chat for non-followers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can use this to follow" &
        " the streamer so you will be able to write in chat.")
        Me.Followbox.UseVisualStyleBackColor = True
        '
        'proxycheckbox
        '
        Me.proxycheckbox.AutoSize = True
        Me.proxycheckbox.Location = New System.Drawing.Point(224, 298)
        Me.proxycheckbox.Name = "proxycheckbox"
        Me.proxycheckbox.Size = New System.Drawing.Size(85, 17)
        Me.proxycheckbox.TabIndex = 30
        Me.proxycheckbox.Text = "Use a proxy:"
        Me.ToolTip1.SetToolTip(Me.proxycheckbox, resources.GetString("proxycheckbox.ToolTip"))
        Me.proxycheckbox.UseVisualStyleBackColor = True
        '
        'proxyinput
        '
        Me.proxyinput.Location = New System.Drawing.Point(223, 315)
        Me.proxyinput.Name = "proxyinput"
        Me.proxyinput.Size = New System.Drawing.Size(218, 20)
        Me.proxyinput.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.proxyinput, resources.GetString("proxyinput.ToolTip"))
        '
        'volinput
        '
        Me.volinput.Location = New System.Drawing.Point(483, 318)
        Me.volinput.Name = "volinput"
        Me.volinput.Size = New System.Drawing.Size(117, 20)
        Me.volinput.TabIndex = 44
        Me.volinput.Text = "0.5"
        Me.volinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.volinput, "You can change the Twitch Volume with it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = 100% Volume (Max V" &
        "olume)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.5 = 50% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 = 1% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 = 0% Volume (Muted)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'customaudio
        '
        Me.customaudio.AutoSize = True
        Me.customaudio.Location = New System.Drawing.Point(483, 294)
        Me.customaudio.Name = "customaudio"
        Me.customaudio.Size = New System.Drawing.Size(102, 17)
        Me.customaudio.TabIndex = 43
        Me.customaudio.Text = "Custom Volume:"
        Me.ToolTip1.SetToolTip(Me.customaudio, "You can change the Twitch Volume with it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type in Numbers from 0 to 1." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For ex" &
        "ample:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = 100% Volume (Max Volume)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.5 = 50% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 = 1% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 = 0%" &
        " Volume (Muted)")
        Me.customaudio.UseVisualStyleBackColor = True
        '
        'muteaudio
        '
        Me.muteaudio.AutoSize = True
        Me.muteaudio.Location = New System.Drawing.Point(483, 271)
        Me.muteaudio.Name = "muteaudio"
        Me.muteaudio.Size = New System.Drawing.Size(80, 17)
        Me.muteaudio.TabIndex = 20
        Me.muteaudio.Text = "Mute Audio"
        Me.ToolTip1.SetToolTip(Me.muteaudio, "This will mute your Chromeaudio - you still will get Valorant drops with this ena" &
        "bled")
        Me.muteaudio.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(483, 248)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(158, 17)
        Me.CheckBox3.TabIndex = 35
        Me.CheckBox3.Text = "Set Stream Quality to lowest"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Changes the Stream Quality from Auto to 160p for faster loading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Claimpoints
        '
        Me.Claimpoints.AutoSize = True
        Me.Claimpoints.Location = New System.Drawing.Point(483, 171)
        Me.Claimpoints.Name = "Claimpoints"
        Me.Claimpoints.Size = New System.Drawing.Size(171, 17)
        Me.Claimpoints.TabIndex = 46
        Me.Claimpoints.Text = "Claim Streamers Channelpoints"
        Me.ToolTip1.SetToolTip(Me.Claimpoints, "Will claim Streamers Channelpoint rewards as long as you watch their Streams")
        Me.Claimpoints.UseVisualStyleBackColor = True
        '
        'Checkdrop
        '
        Me.Checkdrop.AutoSize = True
        Me.Checkdrop.Location = New System.Drawing.Point(483, 139)
        Me.Checkdrop.Name = "Checkdrop"
        Me.Checkdrop.Size = New System.Drawing.Size(140, 17)
        Me.Checkdrop.TabIndex = 45
        Me.Checkdrop.Text = "Check for Valorant Drop"
        Me.ToolTip1.SetToolTip(Me.Checkdrop, "Checks your inventory if you got a Valorant Drop")
        Me.Checkdrop.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(213, 111)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 17)
        Me.CheckBox2.TabIndex = 34
        Me.CheckBox2.Text = "Hide - Disable - Streamchat"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "This will hide and close the Streamerschat - feature on request")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Custom Message in Streamerchat:"
        Me.ToolTip1.SetToolTip(Me.Label3, "This writes the Custom Messages below in the Streamers Chat")
        '
        'Chatinput
        '
        Me.Chatinput.Location = New System.Drawing.Point(213, 153)
        Me.Chatinput.Multiline = True
        Me.Chatinput.Name = "Chatinput"
        Me.Chatinput.Size = New System.Drawing.Size(228, 20)
        Me.Chatinput.TabIndex = 9
        Me.Chatinput.Text = "Message 1"
        Me.ToolTip1.SetToolTip(Me.Chatinput, "This is the first Message it will write in the streamers chat")
        '
        'Chatinput2
        '
        Me.Chatinput2.Location = New System.Drawing.Point(213, 178)
        Me.Chatinput2.Multiline = True
        Me.Chatinput2.Name = "Chatinput2"
        Me.Chatinput2.Size = New System.Drawing.Size(228, 20)
        Me.Chatinput2.TabIndex = 16
        Me.Chatinput2.Text = "Message 2"
        Me.ToolTip1.SetToolTip(Me.Chatinput2, "After X Minutes it will write this second Message in the Chat")
        '
        'Chatminute
        '
        Me.Chatminute.Location = New System.Drawing.Point(74, 176)
        Me.Chatminute.Name = "Chatminute"
        Me.Chatminute.Size = New System.Drawing.Size(100, 20)
        Me.Chatminute.TabIndex = 24
        Me.Chatminute.Text = "3"
        Me.Chatminute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Chatminute, "It will wait X Minutes until it writes another Custom Message in the Streamers ch" &
        "at." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It alternately writes both messages." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "in Minutes:"
        Me.ToolTip1.SetToolTip(Me.Label9, "It will wait X Minutes until it writes another Custom Message in the Streamers ch" &
        "at." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It alternately writes both messages." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Write every X Minutes in Chat:"
        Me.ToolTip1.SetToolTip(Me.Label8, "It will wait X Minutes until it writes another Custom Message in the Streamers ch" &
        "at." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It alternately writes both messages.")
        '
        'Chatbox
        '
        Me.Chatbox.AutoSize = True
        Me.Chatbox.Location = New System.Drawing.Point(16, 133)
        Me.Chatbox.Name = "Chatbox"
        Me.Chatbox.Size = New System.Drawing.Size(179, 17)
        Me.Chatbox.TabIndex = 8
        Me.Chatbox.Text = "Write Messages in Streamerchat"
        Me.ToolTip1.SetToolTip(Me.Chatbox, "This will enable Custom Messages." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It automatically writes your 2 custom messages" &
        " every X Minutes in the streamers Chat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Chatbox.UseVisualStyleBackColor = True
        '
        'prioritymode
        '
        Me.prioritymode.AutoSize = True
        Me.prioritymode.Location = New System.Drawing.Point(16, 68)
        Me.prioritymode.Name = "prioritymode"
        Me.prioritymode.Size = New System.Drawing.Size(110, 17)
        Me.prioritymode.TabIndex = 47
        Me.prioritymode.Text = "Low Priority Mode"
        Me.ToolTip1.SetToolTip(Me.prioritymode, "This will start a new Bot Thread with lowest Priority to lower the CPU usage." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It" &
        " can slow down the speed of the Bot tho..")
        Me.prioritymode.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(141, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Restart with lowest Priority"
        Me.ToolTip1.SetToolTip(Me.Button3, "Restart the whole Program to auto change its Priority to lowest Settings." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This w" &
        "ill lower the CPU usage but can slow down the Program.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cookiessave
        '
        Me.cookiessave.AutoSize = True
        Me.cookiessave.Location = New System.Drawing.Point(469, 12)
        Me.cookiessave.Name = "cookiessave"
        Me.cookiessave.Size = New System.Drawing.Size(166, 17)
        Me.cookiessave.TabIndex = 26
        Me.cookiessave.Text = "Save Session - Store Cookies"
        Me.ToolTip1.SetToolTip(Me.cookiessave, "If you get verification emails everytime you restart this bot you can use this op" &
        "tion." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will save your session and cookies, you won't have to verify your emai" &
        "l and twitch account anymore.")
        Me.cookiessave.UseVisualStyleBackColor = True
        '
        'chromehide
        '
        Me.chromehide.AutoSize = True
        Me.chromehide.Location = New System.Drawing.Point(348, 12)
        Me.chromehide.Name = "chromehide"
        Me.chromehide.Size = New System.Drawing.Size(102, 17)
        Me.chromehide.TabIndex = 19
        Me.chromehide.Text = "Hide Chrometab"
        Me.ToolTip1.SetToolTip(Me.chromehide, "This hides your google chrome tab - you still receive valorant drops")
        Me.chromehide.UseVisualStyleBackColor = True
        '
        'commandhide
        '
        Me.commandhide.AutoSize = True
        Me.commandhide.Location = New System.Drawing.Point(202, 12)
        Me.commandhide.Name = "commandhide"
        Me.commandhide.Size = New System.Drawing.Size(130, 17)
        Me.commandhide.TabIndex = 18
        Me.commandhide.Text = "Hide Commandprompt"
        Me.ToolTip1.SetToolTip(Me.commandhide, "This hides your chrome commandprompt")
        Me.commandhide.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Hide Tooltips"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Hides this Tooltips which you see right now" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you don't know what the followi" &
        "ng checkboxes are keep it enabled and read the tooltip informations")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerSupportsCancellation = True
        '
        'BackgroundWorker4
        '
        Me.BackgroundWorker4.WorkerSupportsCancellation = True
        '
        'BackgroundWorker5
        '
        Me.BackgroundWorker5.WorkerSupportsCancellation = True
        '
        'Timer5
        '
        Me.Timer5.Interval = 120000
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(14, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Stream Settings:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(480, 224)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Stream Video Settings:"
        '
        'Textbox
        '
        Me.Textbox.Location = New System.Drawing.Point(16, 591)
        Me.Textbox.Multiline = True
        Me.Textbox.Name = "Textbox"
        Me.Textbox.ReadOnly = True
        Me.Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Textbox.Size = New System.Drawing.Size(619, 96)
        Me.Textbox.TabIndex = 5
        Me.Textbox.Text = "Twitchbot by Baseult" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Twitch Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Twitch Username:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(14, 410)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Login:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(283, 410)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Start:"
        '
        'Dropfound
        '
        Me.Dropfound.AutoSize = True
        Me.Dropfound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dropfound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dropfound.ForeColor = System.Drawing.Color.Black
        Me.Dropfound.Location = New System.Drawing.Point(179, 365)
        Me.Dropfound.Name = "Dropfound"
        Me.Dropfound.Size = New System.Drawing.Size(126, 20)
        Me.Dropfound.TabIndex = 37
        Me.Dropfound.Text = "Not Checked yet"
        '
        'Valorantdrop
        '
        Me.Valorantdrop.AutoSize = True
        Me.Valorantdrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Valorantdrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valorantdrop.ForeColor = System.Drawing.Color.Black
        Me.Valorantdrop.Location = New System.Drawing.Point(16, 365)
        Me.Valorantdrop.Name = "Valorantdrop"
        Me.Valorantdrop.Size = New System.Drawing.Size(162, 20)
        Me.Valorantdrop.TabIndex = 36
        Me.Valorantdrop.Text = "Valorant Drop Found:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(480, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Reward Settings:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(13, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Streamchat Settings:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(14, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "CPU - Performance:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(315, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Multithreading:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(126, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Bot Settings:"
        '
        'chromebox
        '
        Me.chromebox.AutoSize = True
        Me.chromebox.Location = New System.Drawing.Point(332, 430)
        Me.chromebox.Name = "chromebox"
        Me.chromebox.Size = New System.Drawing.Size(118, 17)
        Me.chromebox.TabIndex = 60
        Me.chromebox.Text = "Use GoogleChrome"
        Me.chromebox.UseVisualStyleBackColor = True
        '
        'Firefoxbox
        '
        Me.Firefoxbox.AutoSize = True
        Me.Firefoxbox.Location = New System.Drawing.Point(541, 430)
        Me.Firefoxbox.Name = "Firefoxbox"
        Me.Firefoxbox.Size = New System.Drawing.Size(82, 17)
        Me.Firefoxbox.TabIndex = 61
        Me.Firefoxbox.Text = "Use FireFox"
        Me.Firefoxbox.UseVisualStyleBackColor = True
        '
        'backgroundbox
        '
        Me.backgroundbox.AutoSize = True
        Me.backgroundbox.Location = New System.Drawing.Point(320, 68)
        Me.backgroundbox.Name = "backgroundbox"
        Me.backgroundbox.Size = New System.Drawing.Size(143, 17)
        Me.backgroundbox.TabIndex = 62
        Me.backgroundbox.Text = "Use Backgroundworkers"
        Me.backgroundbox.UseVisualStyleBackColor = True
        '
        'crossthreadbox
        '
        Me.crossthreadbox.AutoSize = True
        Me.crossthreadbox.Location = New System.Drawing.Point(524, 68)
        Me.crossthreadbox.Name = "crossthreadbox"
        Me.crossthreadbox.Size = New System.Drawing.Size(130, 17)
        Me.crossthreadbox.TabIndex = 63
        Me.crossthreadbox.Text = "Use CrossThreadCalls"
        Me.crossthreadbox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "<- or ->"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "<- or ->"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Twitchbot.My.Resources.Resources.frame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 699)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.crossthreadbox)
        Me.Controls.Add(Me.backgroundbox)
        Me.Controls.Add(Me.Firefoxbox)
        Me.Controls.Add(Me.chromebox)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.prioritymode)
        Me.Controls.Add(Me.Claimpoints)
        Me.Controls.Add(Me.Checkdrop)
        Me.Controls.Add(Me.volinput)
        Me.Controls.Add(Me.customaudio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Streamerinput)
        Me.Controls.Add(Me.Watchstreamer)
        Me.Controls.Add(Me.Dropfound)
        Me.Controls.Add(Me.Valorantdrop)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.proxycheckbox)
        Me.Controls.Add(Me.proxyinput)
        Me.Controls.Add(Me.Stopbutton)
        Me.Controls.Add(Me.tokenlogin)
        Me.Controls.Add(Me.cookiessave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Chatminute)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tokeninput)
        Me.Controls.Add(Me.muteaudio)
        Me.Controls.Add(Me.chromehide)
        Me.Controls.Add(Me.commandhide)
        Me.Controls.Add(Me.Chatinput2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Remainingtime)
        Me.Controls.Add(Me.Timertext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Waitbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chatinput)
        Me.Controls.Add(Me.Chatbox)
        Me.Controls.Add(Me.Followbox)
        Me.Controls.Add(Me.Textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Passbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Namebox)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Twitchbot by Baseult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timertext As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Textbox As TextBox
    Friend WithEvents Stopbutton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tokeninput As TextBox
    Friend WithEvents tokenlogin As CheckBox
    Friend WithEvents Namebox As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Passbox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Dropfound As Label
    Friend WithEvents Remainingtime As Label
    Friend WithEvents Valorantdrop As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Streamerinput As TextBox
    Friend WithEvents Watchstreamer As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Waitbox As TextBox
    Friend WithEvents Followbox As CheckBox
    Friend WithEvents proxycheckbox As CheckBox
    Friend WithEvents proxyinput As TextBox
    Friend WithEvents volinput As TextBox
    Friend WithEvents customaudio As CheckBox
    Friend WithEvents muteaudio As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Claimpoints As CheckBox
    Friend WithEvents Checkdrop As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Chatinput As TextBox
    Friend WithEvents Chatinput2 As TextBox
    Friend WithEvents Chatminute As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Chatbox As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents prioritymode As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents cookiessave As CheckBox
    Friend WithEvents chromehide As CheckBox
    Friend WithEvents commandhide As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chromebox As CheckBox
    Friend WithEvents Firefoxbox As CheckBox
    Friend WithEvents backgroundbox As CheckBox
    Friend WithEvents crossthreadbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
