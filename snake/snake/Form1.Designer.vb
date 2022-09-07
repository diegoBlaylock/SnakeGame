<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UpDown = New System.Windows.Forms.Timer(Me.components)
        Me.Foward = New System.Windows.Forms.Timer(Me.components)
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlpause = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pctBerryclr = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pctback = New System.Windows.Forms.PictureBox()
        Me.pctScore = New System.Windows.Forms.PictureBox()
        Me.pctwall = New System.Windows.Forms.PictureBox()
        Me.pctsnkbody = New System.Windows.Forms.PictureBox()
        Me.pctheadcolor = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkWalls = New System.Windows.Forms.CheckBox()
        Me.pctBerry = New System.Windows.Forms.PictureBox()
        Me.pausetime = New System.Windows.Forms.Timer(Me.components)
        Me.colorhead = New System.Windows.Forms.ColorDialog()
        Me.pnlGameover = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pctrwall = New System.Windows.Forms.PictureBox()
        Me.lblscre = New System.Windows.Forms.Label()
        Me.prtHead = New snake.SnkePrt()
        Me.Panel1.SuspendLayout()
        Me.pnlpause.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pctBerryclr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctsnkbody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctheadcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBerry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGameover.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prtHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpDown
        '
        Me.UpDown.Enabled = True
        Me.UpDown.Interval = 1
        '
        'Foward
        '
        Me.Foward.Enabled = True
        Me.Foward.Interval = 64
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.BurlyWood
        Me.lblscore.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblscore.Location = New System.Drawing.Point(507, 24)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(31, 21)
        Me.lblscore.TabIndex = 2
        Me.lblscore.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlpause)
        Me.Panel1.Controls.Add(Me.prtHead)
        Me.Panel1.Controls.Add(Me.pctBerry)
        Me.Panel1.Location = New System.Drawing.Point(16, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 624)
        Me.Panel1.TabIndex = 7
        '
        'pnlpause
        '
        Me.pnlpause.Controls.Add(Me.Button3)
        Me.pnlpause.Controls.Add(Me.Button2)
        Me.pnlpause.Controls.Add(Me.Button1)
        Me.pnlpause.Controls.Add(Me.Label2)
        Me.pnlpause.Controls.Add(Me.Label1)
        Me.pnlpause.Controls.Add(Me.Button4)
        Me.pnlpause.Controls.Add(Me.PictureBox4)
        Me.pnlpause.Controls.Add(Me.Panel2)
        Me.pnlpause.Location = New System.Drawing.Point(285, 43)
        Me.pnlpause.Name = "pnlpause"
        Me.pnlpause.Size = New System.Drawing.Size(416, 551)
        Me.pnlpause.TabIndex = 9
        Me.pnlpause.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Press Start", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(133, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 51)
        Me.Button3.TabIndex = 13
        Me.Button3.TabStop = False
        Me.Button3.Text = "Settings"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Press Start", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(133, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 51)
        Me.Button2.TabIndex = 12
        Me.Button2.TabStop = False
        Me.Button2.Text = "Resume"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Press Start", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(133, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 51)
        Me.Button1.TabIndex = 11
        Me.Button1.TabStop = False
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Press Start", 24.25!)
        Me.Label2.Location = New System.Drawing.Point(118, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Snake"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Press Start", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(133, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pause"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(26, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.snake.My.Resources.Resources.New_Piskel__28_
        Me.PictureBox4.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(409, 544)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.pctBerryclr)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.pctback)
        Me.Panel2.Controls.Add(Me.pctScore)
        Me.Panel2.Controls.Add(Me.pctwall)
        Me.Panel2.Controls.Add(Me.pctsnkbody)
        Me.Panel2.Controls.Add(Me.pctheadcolor)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.chkWalls)
        Me.Panel2.Location = New System.Drawing.Point(20, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 190)
        Me.Panel2.TabIndex = 14
        Me.Panel2.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Press Start", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(239, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 15)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.Text = "Special"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Press Start", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(239, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 15)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Random"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(224, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Enemy"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'pctBerryclr
        '
        Me.pctBerryclr.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pctBerryclr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctBerryclr.Location = New System.Drawing.Point(356, 135)
        Me.pctBerryclr.Name = "pctBerryclr"
        Me.pctBerryclr.Size = New System.Drawing.Size(16, 16)
        Me.pctBerryclr.TabIndex = 14
        Me.pctBerryclr.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Berry:"
        '
        'pctback
        '
        Me.pctback.BackColor = System.Drawing.Color.LemonChiffon
        Me.pctback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctback.Location = New System.Drawing.Point(153, 109)
        Me.pctback.Name = "pctback"
        Me.pctback.Size = New System.Drawing.Size(16, 16)
        Me.pctback.TabIndex = 12
        Me.pctback.TabStop = False
        '
        'pctScore
        '
        Me.pctScore.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pctScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctScore.Location = New System.Drawing.Point(153, 135)
        Me.pctScore.Name = "pctScore"
        Me.pctScore.Size = New System.Drawing.Size(16, 16)
        Me.pctScore.TabIndex = 11
        Me.pctScore.TabStop = False
        '
        'pctwall
        '
        Me.pctwall.BackColor = System.Drawing.Color.BurlyWood
        Me.pctwall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctwall.Location = New System.Drawing.Point(356, 106)
        Me.pctwall.Name = "pctwall"
        Me.pctwall.Size = New System.Drawing.Size(16, 16)
        Me.pctwall.TabIndex = 10
        Me.pctwall.TabStop = False
        '
        'pctsnkbody
        '
        Me.pctsnkbody.BackColor = System.Drawing.Color.LightGreen
        Me.pctsnkbody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctsnkbody.Location = New System.Drawing.Point(153, 163)
        Me.pctsnkbody.Name = "pctsnkbody"
        Me.pctsnkbody.Size = New System.Drawing.Size(16, 16)
        Me.pctsnkbody.TabIndex = 9
        Me.pctsnkbody.TabStop = False
        '
        'pctheadcolor
        '
        Me.pctheadcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pctheadcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctheadcolor.Location = New System.Drawing.Point(355, 163)
        Me.pctheadcolor.Name = "pctheadcolor"
        Me.pctheadcolor.Size = New System.Drawing.Size(16, 16)
        Me.pctheadcolor.TabIndex = 8
        Me.pctheadcolor.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(236, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Walls:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Score:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Snake Body:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Snake Head:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Press Start", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BackGround:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Press Start", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "color:"
        '
        'chkWalls
        '
        Me.chkWalls.AutoSize = True
        Me.chkWalls.Checked = True
        Me.chkWalls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWalls.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkWalls.FlatAppearance.BorderSize = 4
        Me.chkWalls.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkWalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWalls.Font = New System.Drawing.Font("Press Start", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWalls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkWalls.Location = New System.Drawing.Point(6, 3)
        Me.chkWalls.Name = "chkWalls"
        Me.chkWalls.Size = New System.Drawing.Size(104, 20)
        Me.chkWalls.TabIndex = 1
        Me.chkWalls.Text = "Walls"
        Me.chkWalls.UseVisualStyleBackColor = True
        '
        'pctBerry
        '
        Me.pctBerry.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pctBerry.Location = New System.Drawing.Point(168, 227)
        Me.pctBerry.Name = "pctBerry"
        Me.pctBerry.Size = New System.Drawing.Size(16, 16)
        Me.pctBerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctBerry.TabIndex = 1
        Me.pctBerry.TabStop = False
        '
        'pausetime
        '
        Me.pausetime.Interval = 1
        '
        'colorhead
        '
        Me.colorhead.AnyColor = True
        Me.colorhead.SolidColorOnly = True
        '
        'pnlGameover
        '
        Me.pnlGameover.BackColor = System.Drawing.Color.DarkKhaki
        Me.pnlGameover.Controls.Add(Me.lblscre)
        Me.pnlGameover.Controls.Add(Me.Button6)
        Me.pnlGameover.Controls.Add(Me.Button5)
        Me.pnlGameover.Controls.Add(Me.Label11)
        Me.pnlGameover.Controls.Add(Me.Label10)
        Me.pnlGameover.Controls.Add(Me.PictureBox5)
        Me.pnlGameover.Location = New System.Drawing.Point(0, 0)
        Me.pnlGameover.Name = "pnlGameover"
        Me.pnlGameover.Size = New System.Drawing.Size(1024, 704)
        Me.pnlGameover.TabIndex = 8
        Me.pnlGameover.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Press Start", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(685, 587)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(298, 97)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Press Start", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(47, 585)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(298, 97)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Try Again"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Press Start", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(237, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(400, 35)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Your Score:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Press Start", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(217, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(604, 64)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Game Over"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.snake.My.Resources.Resources.New_Piskel__29_
        Me.PictureBox5.Location = New System.Drawing.Point(461, 173)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(115, 228)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 704)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.BurlyWood
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1024, 64)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.BurlyWood
        Me.PictureBox2.Location = New System.Drawing.Point(0, 688)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1024, 16)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'pctrwall
        '
        Me.pctrwall.BackColor = System.Drawing.Color.BurlyWood
        Me.pctrwall.Location = New System.Drawing.Point(1008, 0)
        Me.pctrwall.Name = "pctrwall"
        Me.pctrwall.Size = New System.Drawing.Size(16, 704)
        Me.pctrwall.TabIndex = 4
        Me.pctrwall.TabStop = False
        '
        'lblscre
        '
        Me.lblscre.AutoSize = True
        Me.lblscre.Font = New System.Drawing.Font("Press Start", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscre.Location = New System.Drawing.Point(643, 486)
        Me.lblscre.Name = "lblscre"
        Me.lblscre.Size = New System.Drawing.Size(39, 27)
        Me.lblscre.TabIndex = 5
        Me.lblscre.Text = "0"
        '
        'prtHead
        '
        Me.prtHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.prtHead.Location = New System.Drawing.Point(64, 64)
        Me.prtHead.Name = "prtHead"
        Me.prtHead.Size = New System.Drawing.Size(16, 16)
        Me.prtHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.prtHead.TabIndex = 0
        Me.prtHead.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1023, 699)
        Me.Controls.Add(Me.pnlGameover)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pctrwall)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Snake"
        Me.Panel1.ResumeLayout(False)
        Me.pnlpause.ResumeLayout(False)
        Me.pnlpause.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pctBerryclr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctsnkbody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctheadcolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBerry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGameover.ResumeLayout(False)
        Me.pnlGameover.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prtHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prtHead As SnkePrt
    Friend WithEvents UpDown As Timer
    Friend WithEvents Foward As Timer
    Public WithEvents pctBerry As PictureBox
    Friend WithEvents lblscore As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pctrwall As PictureBox
    Public WithEvents PictureBox3 As PictureBox
    Public WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents pnlpause As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pausetime As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chkWalls As CheckBox
    Friend WithEvents colorhead As ColorDialog
    Friend WithEvents pctback As PictureBox
    Friend WithEvents pctScore As PictureBox
    Friend WithEvents pctwall As PictureBox
    Friend WithEvents pctsnkbody As PictureBox
    Friend WithEvents pctheadcolor As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pctBerryclr As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents pnlGameover As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblscre As Label
End Class
