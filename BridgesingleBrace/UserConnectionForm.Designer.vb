<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class UserConnectionForm
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
        FormsInitialize()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
                fTerminateCalled = True
			End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture2 As System.Windows.Forms.PictureBox
	Public WithEvents picBitmap As System.Windows.Forms.PictureBox
    Public WithEvents TabStrip1 As System.Windows.Forms.TabControl
	Public WithEvents cmdGetLengthFromLine As System.Windows.Forms.Button
	Public WithEvents cmdAccept As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdBitmaps As System.Windows.Forms.Button
	Public WithEvents cmdForceUpdate As System.Windows.Forms.Button
	Public WithEvents cmdRollover As System.Windows.Forms.Button
	Public WithEvents cmdHelp As System.Windows.Forms.Button
	Public WithEvents cmdClone As System.Windows.Forms.Button
	Public WithEvents cmdTemplate As System.Windows.Forms.Button
	Public WithEvents imgBitmaps As System.Windows.Forms.ImageList
	Public WithEvents imgIcons As System.Windows.Forms.ImageList
	Public WithEvents imgBitmaps2 As System.Windows.Forms.ImageList
	Public WithEvents imgBitmaps3 As System.Windows.Forms.ImageList
	Public WithEvents imgBitmaps4 As System.Windows.Forms.ImageList
	Public WithEvents imgBitmaps5 As System.Windows.Forms.ImageList
	Public WithEvents imgBitmaps6 As System.Windows.Forms.ImageList
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserConnectionForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdGetLengthFromLine = New System.Windows.Forms.Button()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdBitmaps = New System.Windows.Forms.Button()
        Me.cmdForceUpdate = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdClone = New System.Windows.Forms.Button()
        Me.cmdTemplate = New System.Windows.Forms.Button()
        Me.Picture2 = New System.Windows.Forms.PictureBox()
        Me.picBitmap = New System.Windows.Forms.PictureBox()
        Me.TabStrip1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConnectCutBack2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConnectCutBack1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSupportCutBack2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupportCutBack1 = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me._TabFrames_0 = New System.Windows.Forms.GroupBox()
        Me.lblThick = New System.Windows.Forms.Label()
        Me.txtPlateThick = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.groupBolt = New System.Windows.Forms.GroupBox()
        Me.lblBoltStyle = New System.Windows.Forms.Label()
        Me.chkTurnBolts = New System.Windows.Forms.CheckBox()
        Me.cbBoltStyle = New System.Windows.Forms.ComboBox()
        Me.cmdRollover = New System.Windows.Forms.Button()
        Me.imgBitmaps = New System.Windows.Forms.ImageList(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps3 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps4 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps5 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps6 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me._TabFrames_0.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.groupBolt.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGetLengthFromLine
        '
        Me.cmdGetLengthFromLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetLengthFromLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetLengthFromLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetLengthFromLine.Image = CType(resources.GetObject("cmdGetLengthFromLine.Image"), System.Drawing.Image)
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(202, 276)
        Me.cmdGetLengthFromLine.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdGetLengthFromLine.Name = "cmdGetLengthFromLine"
        Me.cmdGetLengthFromLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetLengthFromLine.Size = New System.Drawing.Size(30, 32)
        Me.cmdGetLengthFromLine.TabIndex = 9
        Me.cmdGetLengthFromLine.Tag = "T0003"
        Me.cmdGetLengthFromLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGetLengthFromLine.UseVisualStyleBackColor = False
        Me.cmdGetLengthFromLine.Visible = False
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAccept.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAccept.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAccept.Image = CType(resources.GetObject("cmdAccept.Image"), System.Drawing.Image)
        Me.cmdAccept.Location = New System.Drawing.Point(4, 276)
        Me.cmdAccept.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAccept.Size = New System.Drawing.Size(30, 32)
        Me.cmdAccept.TabIndex = 8
        Me.cmdAccept.Tag = "S1000"
        Me.cmdAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(38, 276)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(30, 32)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Tag = "S1001"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdBitmaps
        '
        Me.cmdBitmaps.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBitmaps.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBitmaps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBitmaps.Image = CType(resources.GetObject("cmdBitmaps.Image"), System.Drawing.Image)
        Me.cmdBitmaps.Location = New System.Drawing.Point(389, 276)
        Me.cmdBitmaps.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBitmaps.Name = "cmdBitmaps"
        Me.cmdBitmaps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBitmaps.Size = New System.Drawing.Size(30, 32)
        Me.cmdBitmaps.TabIndex = 5
        Me.cmdBitmaps.Tag = "S1008"
        Me.cmdBitmaps.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBitmaps.UseVisualStyleBackColor = False
        '
        'cmdForceUpdate
        '
        Me.cmdForceUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdForceUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdForceUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdForceUpdate.Image = CType(resources.GetObject("cmdForceUpdate.Image"), System.Drawing.Image)
        Me.cmdForceUpdate.Location = New System.Drawing.Point(356, 276)
        Me.cmdForceUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdForceUpdate.Name = "cmdForceUpdate"
        Me.cmdForceUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdForceUpdate.Size = New System.Drawing.Size(30, 32)
        Me.cmdForceUpdate.TabIndex = 4
        Me.cmdForceUpdate.Tag = "S1010"
        Me.cmdForceUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdForceUpdate.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.Location = New System.Drawing.Point(71, 276)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp.Size = New System.Drawing.Size(30, 32)
        Me.cmdHelp.TabIndex = 2
        Me.cmdHelp.Tag = "S1006"
        Me.cmdHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdClone
        '
        Me.cmdClone.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClone.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClone.Image = CType(resources.GetObject("cmdClone.Image"), System.Drawing.Image)
        Me.cmdClone.Location = New System.Drawing.Point(139, 276)
        Me.cmdClone.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdClone.Name = "cmdClone"
        Me.cmdClone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClone.Size = New System.Drawing.Size(30, 32)
        Me.cmdClone.TabIndex = 1
        Me.cmdClone.Tag = "S1007"
        Me.cmdClone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClone.UseVisualStyleBackColor = False
        '
        'cmdTemplate
        '
        Me.cmdTemplate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTemplate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTemplate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTemplate.Image = CType(resources.GetObject("cmdTemplate.Image"), System.Drawing.Image)
        Me.cmdTemplate.Location = New System.Drawing.Point(105, 276)
        Me.cmdTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdTemplate.Name = "cmdTemplate"
        Me.cmdTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTemplate.Size = New System.Drawing.Size(30, 32)
        Me.cmdTemplate.TabIndex = 0
        Me.cmdTemplate.Tag = "S1004"
        Me.cmdTemplate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTemplate.UseVisualStyleBackColor = False
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.SystemColors.Control
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture2.Location = New System.Drawing.Point(776, 114)
        Me.Picture2.Margin = New System.Windows.Forms.Padding(2)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(200, 115)
        Me.Picture2.TabIndex = 55
        Me.Picture2.TabStop = False
        '
        'picBitmap
        '
        Me.picBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.picBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBitmap.Location = New System.Drawing.Point(426, 11)
        Me.picBitmap.Margin = New System.Windows.Forms.Padding(2)
        Me.picBitmap.Name = "picBitmap"
        Me.picBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBitmap.Size = New System.Drawing.Size(262, 258)
        Me.picBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBitmap.TabIndex = 6
        Me.picBitmap.TabStop = False
        '
        'TabStrip1
        '
        Me.TabStrip1.Controls.Add(Me.TabPage2)
        Me.TabStrip1.Controls.Add(Me.TabPage1)
        Me.TabStrip1.Controls.Add(Me.TabPage3)
        Me.TabStrip1.Controls.Add(Me.TabPage7)
        Me.TabStrip1.Location = New System.Drawing.Point(4, 1)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(416, 268)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtSupportCutBack2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtSupportCutBack1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(408, 242)
        Me.TabPage2.TabIndex = 11
        Me.TabPage2.Text = "D400'CutBack"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "D0402'Connect Cut back 2"
        '
        'txtConnectCutBack2
        '
        Me.txtConnectCutBack2.AcceptsReturn = True
        Me.txtConnectCutBack2.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack2.Location = New System.Drawing.Point(131, 108)
        Me.txtConnectCutBack2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnectCutBack2.MaxLength = 0
        Me.txtConnectCutBack2.Name = "txtConnectCutBack2"
        Me.txtConnectCutBack2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack2.Size = New System.Drawing.Size(57, 20)
        Me.txtConnectCutBack2.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(0, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D0402'Connect Cut back 1"
        '
        'txtConnectCutBack1
        '
        Me.txtConnectCutBack1.AcceptsReturn = True
        Me.txtConnectCutBack1.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack1.Location = New System.Drawing.Point(131, 80)
        Me.txtConnectCutBack1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnectCutBack1.MaxLength = 0
        Me.txtConnectCutBack1.Name = "txtConnectCutBack1"
        Me.txtConnectCutBack1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack1.Size = New System.Drawing.Size(57, 20)
        Me.txtConnectCutBack1.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "D0402'Support Cut back 2"
        '
        'txtSupportCutBack2
        '
        Me.txtSupportCutBack2.AcceptsReturn = True
        Me.txtSupportCutBack2.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportCutBack2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportCutBack2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportCutBack2.Location = New System.Drawing.Point(131, 37)
        Me.txtSupportCutBack2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupportCutBack2.MaxLength = 0
        Me.txtSupportCutBack2.Name = "txtSupportCutBack2"
        Me.txtSupportCutBack2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportCutBack2.Size = New System.Drawing.Size(57, 20)
        Me.txtSupportCutBack2.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "D0401'Support Cut back 1"
        '
        'txtSupportCutBack1
        '
        Me.txtSupportCutBack1.AcceptsReturn = True
        Me.txtSupportCutBack1.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportCutBack1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportCutBack1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportCutBack1.Location = New System.Drawing.Point(131, 9)
        Me.txtSupportCutBack1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupportCutBack1.MaxLength = 0
        Me.txtSupportCutBack1.Name = "txtSupportCutBack1"
        Me.txtSupportCutBack1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportCutBack1.Size = New System.Drawing.Size(57, 20)
        Me.txtSupportCutBack1.TabIndex = 80
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._TabFrames_0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(408, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "D0100'Plate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.txtPlateThick)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Margin = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.Padding = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(408, 242)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.BackColor = System.Drawing.Color.Transparent
        Me.lblThick.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblThick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThick.Location = New System.Drawing.Point(12, 22)
        Me.lblThick.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblThick.Size = New System.Drawing.Size(93, 13)
        Me.lblThick.TabIndex = 79
        Me.lblThick.Text = "D0101'Thickness:"
        '
        'txtPlateThick
        '
        Me.txtPlateThick.AcceptsReturn = True
        Me.txtPlateThick.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlateThick.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlateThick.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlateThick.Location = New System.Drawing.Point(116, 20)
        Me.txtPlateThick.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlateThick.MaxLength = 0
        Me.txtPlateThick.Name = "txtPlateThick"
        Me.txtPlateThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlateThick.Size = New System.Drawing.Size(57, 20)
        Me.txtPlateThick.TabIndex = 76
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(408, 242)
        Me.TabPage3.TabIndex = 8
        Me.TabPage3.Text = "D0200'Hole"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(408, 242)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.groupBolt)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(408, 242)
        Me.TabPage7.TabIndex = 10
        Me.TabPage7.Text = "D0300'Bolt/Weld"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'groupBolt
        '
        Me.groupBolt.Controls.Add(Me.lblBoltStyle)
        Me.groupBolt.Controls.Add(Me.chkTurnBolts)
        Me.groupBolt.Controls.Add(Me.cbBoltStyle)
        Me.groupBolt.Location = New System.Drawing.Point(4, 5)
        Me.groupBolt.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBolt.Name = "groupBolt"
        Me.groupBolt.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBolt.Size = New System.Drawing.Size(400, 42)
        Me.groupBolt.TabIndex = 149
        Me.groupBolt.TabStop = False
        Me.groupBolt.Text = "D0301'Bolt"
        '
        'lblBoltStyle
        '
        Me.lblBoltStyle.AutoSize = True
        Me.lblBoltStyle.BackColor = System.Drawing.Color.Transparent
        Me.lblBoltStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBoltStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBoltStyle.Location = New System.Drawing.Point(12, 15)
        Me.lblBoltStyle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBoltStyle.Name = "lblBoltStyle"
        Me.lblBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBoltStyle.Size = New System.Drawing.Size(86, 13)
        Me.lblBoltStyle.TabIndex = 135
        Me.lblBoltStyle.Text = "D0302'Bolt style:"
        '
        'chkTurnBolts
        '
        Me.chkTurnBolts.AutoSize = True
        Me.chkTurnBolts.BackColor = System.Drawing.Color.Transparent
        Me.chkTurnBolts.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTurnBolts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTurnBolts.Location = New System.Drawing.Point(277, 14)
        Me.chkTurnBolts.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTurnBolts.Name = "chkTurnBolts"
        Me.chkTurnBolts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTurnBolts.Size = New System.Drawing.Size(107, 17)
        Me.chkTurnBolts.TabIndex = 138
        Me.chkTurnBolts.Text = "D0303'Turn bolts"
        Me.chkTurnBolts.UseVisualStyleBackColor = False
        '
        'cbBoltStyle
        '
        Me.cbBoltStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cbBoltStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbBoltStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBoltStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbBoltStyle.Location = New System.Drawing.Point(154, 12)
        Me.cbBoltStyle.Margin = New System.Windows.Forms.Padding(2)
        Me.cbBoltStyle.Name = "cbBoltStyle"
        Me.cbBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBoltStyle.Size = New System.Drawing.Size(95, 21)
        Me.cbBoltStyle.TabIndex = 134
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(322, 276)
        Me.cmdRollover.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRollover.Name = "cmdRollover"
        Me.cmdRollover.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRollover.Size = New System.Drawing.Size(30, 32)
        Me.cmdRollover.TabIndex = 3
        Me.cmdRollover.Tag = "S1011"
        Me.cmdRollover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRollover.UseVisualStyleBackColor = False
        Me.cmdRollover.Visible = False
        '
        'imgBitmaps
        '
        Me.imgBitmaps.ImageStream = CType(resources.GetObject("imgBitmaps.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps.Images.SetKeyName(0, "")
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgIcons.Images.SetKeyName(0, "")
        Me.imgIcons.Images.SetKeyName(1, "")
        Me.imgIcons.Images.SetKeyName(2, "")
        Me.imgIcons.Images.SetKeyName(3, "")
        Me.imgIcons.Images.SetKeyName(4, "")
        Me.imgIcons.Images.SetKeyName(5, "")
        '
        'imgBitmaps2
        '
        Me.imgBitmaps2.ImageStream = CType(resources.GetObject("imgBitmaps2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps2.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps2.Images.SetKeyName(0, "")
        '
        'imgBitmaps3
        '
        Me.imgBitmaps3.ImageStream = CType(resources.GetObject("imgBitmaps3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps3.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps3.Images.SetKeyName(0, "")
        '
        'imgBitmaps4
        '
        Me.imgBitmaps4.ImageStream = CType(resources.GetObject("imgBitmaps4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps4.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps4.Images.SetKeyName(0, "")
        '
        'imgBitmaps5
        '
        Me.imgBitmaps5.ImageStream = CType(resources.GetObject("imgBitmaps5.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps5.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps5.Images.SetKeyName(0, "")
        '
        'imgBitmaps6
        '
        Me.imgBitmaps6.ImageStream = CType(resources.GetObject("imgBitmaps6.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBitmaps6.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgBitmaps6.Images.SetKeyName(0, "")
        '
        'UserConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(693, 311)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.picBitmap)
        Me.Controls.Add(Me.TabStrip1)
        Me.Controls.Add(Me.cmdGetLengthFromLine)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdBitmaps)
        Me.Controls.Add(Me.cmdForceUpdate)
        Me.Controls.Add(Me.cmdRollover)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdClone)
        Me.Controls.Add(Me.cmdTemplate)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(19, -1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserConnectionForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "D0001'Bridge K Brace Designer"
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me._TabFrames_0.ResumeLayout(False)
        Me._TabFrames_0.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.groupBolt.ResumeLayout(False)
        Me.groupBolt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _TabFrames_0 As System.Windows.Forms.GroupBox
    Public WithEvents txtPlateThick As System.Windows.Forms.TextBox
    Public WithEvents lblThick As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents groupBolt As System.Windows.Forms.GroupBox
    Public WithEvents lblBoltStyle As System.Windows.Forms.Label
    Public WithEvents chkTurnBolts As System.Windows.Forms.CheckBox
    Public WithEvents cbBoltStyle As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtSupportCutBack1 As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtSupportCutBack2 As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtConnectCutBack2 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtConnectCutBack1 As System.Windows.Forms.TextBox
#End Region
End Class