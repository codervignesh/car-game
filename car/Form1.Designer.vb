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
        Me.right_mve = New System.Windows.Forms.Timer(Me.components)
        Me.left_mve = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_strt = New System.Windows.Forms.Timer(Me.components)
        Me.car_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.time_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.line_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.scre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.count = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sped = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gear = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.life3 = New System.Windows.Forms.PictureBox()
        Me.life2 = New System.Windows.Forms.PictureBox()
        Me.life1 = New System.Windows.Forms.PictureBox()
        Me.op_car1 = New System.Windows.Forms.PictureBox()
        Me.op_car2 = New System.Windows.Forms.PictureBox()
        Me.op_car3 = New System.Windows.Forms.PictureBox()
        Me.my_car = New System.Windows.Forms.PictureBox()
        Me.line31 = New System.Windows.Forms.PictureBox()
        Me.line30 = New System.Windows.Forms.PictureBox()
        Me.line21 = New System.Windows.Forms.PictureBox()
        Me.line20 = New System.Windows.Forms.PictureBox()
        Me.line11 = New System.Windows.Forms.PictureBox()
        Me.line10 = New System.Windows.Forms.PictureBox()
        Me.line01 = New System.Windows.Forms.PictureBox()
        Me.line00 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.life3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.life2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.life1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.op_car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.op_car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.op_car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.my_car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'right_mve
        '
        Me.right_mve.Interval = 10
        '
        'left_mve
        '
        Me.left_mve.Interval = 10
        '
        'Timer_strt
        '
        Me.Timer_strt.Interval = 1000
        '
        'car_tmr
        '
        Me.car_tmr.Interval = 70
        '
        'time_tmr
        '
        Me.time_tmr.Interval = 1000
        '
        'line_tmr
        '
        Me.line_tmr.Interval = 10
        '
        'scre
        '
        Me.scre.AutoSize = True
        Me.scre.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.scre.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scre.Location = New System.Drawing.Point(1490, 240)
        Me.scre.Name = "scre"
        Me.scre.Size = New System.Drawing.Size(35, 38)
        Me.scre.TabIndex = 20
        Me.scre.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1323, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 38)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "SCORE"
        '
        'count
        '
        Me.count.AutoSize = True
        Me.count.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.Location = New System.Drawing.Point(574, 372)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(83, 91)
        Me.count.TabIndex = 22
        Me.count.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1324, 615)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "RULES :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1324, 668)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 32)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Enter : To start new game "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1324, 733)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 32)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Left arrow : To move left"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1324, 803)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(353, 32)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Right arrow : To move right"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1324, 1001)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(342, 32)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Escape : To exit the game"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1324, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "SPEED:"
        '
        'sped
        '
        Me.sped.AutoSize = True
        Me.sped.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sped.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sped.Location = New System.Drawing.Point(1472, 320)
        Me.sped.Name = "sped"
        Me.sped.Size = New System.Drawing.Size(31, 32)
        Me.sped.TabIndex = 29
        Me.sped.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1324, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 32)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "GEAR:"
        '
        'gear
        '
        Me.gear.AutoSize = True
        Me.gear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gear.Location = New System.Drawing.Point(1472, 382)
        Me.gear.Name = "gear"
        Me.gear.Size = New System.Drawing.Size(31, 32)
        Me.gear.TabIndex = 31
        Me.gear.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1324, 870)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(375, 32)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Top arrow : To reduce speed"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1324, 939)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(409, 32)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Botton arrow : To reduce speed"
        '
        'life3
        '
        Me.life3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.life3.Image = Global.car.My.Resources.Resources.lifes
        Me.life3.Location = New System.Drawing.Point(1572, 130)
        Me.life3.Name = "life3"
        Me.life3.Size = New System.Drawing.Size(79, 68)
        Me.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.life3.TabIndex = 19
        Me.life3.TabStop = False
        '
        'life2
        '
        Me.life2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.life2.Image = Global.car.My.Resources.Resources.lifes
        Me.life2.Location = New System.Drawing.Point(1446, 130)
        Me.life2.Name = "life2"
        Me.life2.Size = New System.Drawing.Size(79, 68)
        Me.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.life2.TabIndex = 18
        Me.life2.TabStop = False
        '
        'life1
        '
        Me.life1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.life1.Image = Global.car.My.Resources.Resources.lifes
        Me.life1.Location = New System.Drawing.Point(1330, 130)
        Me.life1.Name = "life1"
        Me.life1.Size = New System.Drawing.Size(79, 68)
        Me.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.life1.TabIndex = 17
        Me.life1.TabStop = False
        '
        'op_car1
        '
        Me.op_car1.Image = CType(resources.GetObject("op_car1.Image"), System.Drawing.Image)
        Me.op_car1.Location = New System.Drawing.Point(232, 180)
        Me.op_car1.Name = "op_car1"
        Me.op_car1.Size = New System.Drawing.Size(148, 209)
        Me.op_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.op_car1.TabIndex = 15
        Me.op_car1.TabStop = False
        '
        'op_car2
        '
        Me.op_car2.Image = CType(resources.GetObject("op_car2.Image"), System.Drawing.Image)
        Me.op_car2.Location = New System.Drawing.Point(921, 120)
        Me.op_car2.Name = "op_car2"
        Me.op_car2.Size = New System.Drawing.Size(148, 209)
        Me.op_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.op_car2.TabIndex = 14
        Me.op_car2.TabStop = False
        '
        'op_car3
        '
        Me.op_car3.Image = CType(resources.GetObject("op_car3.Image"), System.Drawing.Image)
        Me.op_car3.Location = New System.Drawing.Point(555, 106)
        Me.op_car3.Name = "op_car3"
        Me.op_car3.Size = New System.Drawing.Size(148, 209)
        Me.op_car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.op_car3.TabIndex = 13
        Me.op_car3.TabStop = False
        '
        'my_car
        '
        Me.my_car.BackColor = System.Drawing.Color.Transparent
        Me.my_car.Image = Global.car.My.Resources.Resources.mycar
        Me.my_car.Location = New System.Drawing.Point(555, 834)
        Me.my_car.Name = "my_car"
        Me.my_car.Size = New System.Drawing.Size(148, 209)
        Me.my_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.my_car.TabIndex = 12
        Me.my_car.TabStop = False
        '
        'line31
        '
        Me.line31.BackColor = System.Drawing.Color.White
        Me.line31.Location = New System.Drawing.Point(801, 896)
        Me.line31.Name = "line31"
        Me.line31.Size = New System.Drawing.Size(34, 236)
        Me.line31.TabIndex = 11
        Me.line31.TabStop = False
        '
        'line30
        '
        Me.line30.BackColor = System.Drawing.Color.White
        Me.line30.Location = New System.Drawing.Point(426, 896)
        Me.line30.Name = "line30"
        Me.line30.Size = New System.Drawing.Size(34, 236)
        Me.line30.TabIndex = 10
        Me.line30.TabStop = False
        '
        'line21
        '
        Me.line21.BackColor = System.Drawing.Color.White
        Me.line21.Location = New System.Drawing.Point(801, 564)
        Me.line21.Name = "line21"
        Me.line21.Size = New System.Drawing.Size(34, 236)
        Me.line21.TabIndex = 9
        Me.line21.TabStop = False
        '
        'line20
        '
        Me.line20.BackColor = System.Drawing.Color.White
        Me.line20.Location = New System.Drawing.Point(426, 564)
        Me.line20.Name = "line20"
        Me.line20.Size = New System.Drawing.Size(34, 236)
        Me.line20.TabIndex = 8
        Me.line20.TabStop = False
        '
        'line11
        '
        Me.line11.BackColor = System.Drawing.Color.White
        Me.line11.Location = New System.Drawing.Point(801, 239)
        Me.line11.Name = "line11"
        Me.line11.Size = New System.Drawing.Size(34, 236)
        Me.line11.TabIndex = 7
        Me.line11.TabStop = False
        '
        'line10
        '
        Me.line10.BackColor = System.Drawing.Color.White
        Me.line10.Location = New System.Drawing.Point(426, 239)
        Me.line10.Name = "line10"
        Me.line10.Size = New System.Drawing.Size(34, 236)
        Me.line10.TabIndex = 6
        Me.line10.TabStop = False
        '
        'line01
        '
        Me.line01.BackColor = System.Drawing.Color.White
        Me.line01.Location = New System.Drawing.Point(801, -104)
        Me.line01.Name = "line01"
        Me.line01.Size = New System.Drawing.Size(34, 236)
        Me.line01.TabIndex = 5
        Me.line01.TabStop = False
        '
        'line00
        '
        Me.line00.BackColor = System.Drawing.Color.White
        Me.line00.Location = New System.Drawing.Point(426, -104)
        Me.line00.Name = "line00"
        Me.line00.Size = New System.Drawing.Size(34, 236)
        Me.line00.TabIndex = 4
        Me.line00.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pb1.Location = New System.Drawing.Point(63, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(36, 1054)
        Me.pb1.TabIndex = 3
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pb2.Location = New System.Drawing.Point(1137, 0)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(36, 1054)
        Me.pb2.TabIndex = 2
        Me.pb2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox2.Location = New System.Drawing.Point(1285, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(872, 1054)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1283, 1054)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sped)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scre)
        Me.Controls.Add(Me.life3)
        Me.Controls.Add(Me.life2)
        Me.Controls.Add(Me.life1)
        Me.Controls.Add(Me.op_car1)
        Me.Controls.Add(Me.op_car2)
        Me.Controls.Add(Me.op_car3)
        Me.Controls.Add(Me.my_car)
        Me.Controls.Add(Me.line31)
        Me.Controls.Add(Me.line30)
        Me.Controls.Add(Me.line21)
        Me.Controls.Add(Me.line20)
        Me.Controls.Add(Me.line11)
        Me.Controls.Add(Me.line10)
        Me.Controls.Add(Me.line01)
        Me.Controls.Add(Me.line00)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.life3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.life2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.life1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.op_car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.op_car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.op_car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.my_car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents line00 As PictureBox
    Friend WithEvents line01 As PictureBox
    Friend WithEvents line11 As PictureBox
    Friend WithEvents line10 As PictureBox
    Friend WithEvents line21 As PictureBox
    Friend WithEvents line20 As PictureBox
    Friend WithEvents line31 As PictureBox
    Friend WithEvents line30 As PictureBox
    Friend WithEvents my_car As PictureBox
    Friend WithEvents op_car3 As PictureBox
    Friend WithEvents op_car2 As PictureBox
    Friend WithEvents op_car1 As PictureBox
    Friend WithEvents life1 As PictureBox
    Friend WithEvents life2 As PictureBox
    Friend WithEvents life3 As PictureBox
    Friend WithEvents right_mve As Timer
    Friend WithEvents left_mve As Timer
    Friend WithEvents Timer_strt As Timer
    Friend WithEvents car_tmr As Timer
    Friend WithEvents time_tmr As Timer
    Friend WithEvents line_tmr As Timer
    Friend WithEvents scre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents count As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents sped As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gear As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
