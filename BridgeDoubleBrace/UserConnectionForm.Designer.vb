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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupport2CutBack = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSupport1CutBack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConnectCutBack2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConnectCutBack1 = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me._TabFrames_0 = New System.Windows.Forms.GroupBox()
        Me.GroupTop = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.txtTopColumnDist = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTopColumnWidth = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTopAngle2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTopFillet2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTopAngle1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTopFillet1 = New System.Windows.Forms.TextBox()
        Me.chkHasTopColumn = New System.Windows.Forms.CheckBox()
        Me.GroupBottom = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAngle4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFillet4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAngle3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFillet3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAngle2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFillet2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAngle1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFillet1 = New System.Windows.Forms.TextBox()
        Me.lblThick = New System.Windows.Forms.Label()
        Me.txtPlateThickness = New System.Windows.Forms.TextBox()
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
        Me.GroupTop.SuspendLayout()
        Me.GroupBottom.SuspendLayout()
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
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(303, 508)
        Me.cmdGetLengthFromLine.Name = "cmdGetLengthFromLine"
        Me.cmdGetLengthFromLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetLengthFromLine.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdAccept.Location = New System.Drawing.Point(6, 508)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAccept.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdCancel.Location = New System.Drawing.Point(57, 508)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(584, 508)
        Me.cmdBitmaps.Name = "cmdBitmaps"
        Me.cmdBitmaps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBitmaps.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(534, 508)
        Me.cmdForceUpdate.Name = "cmdForceUpdate"
        Me.cmdForceUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdForceUpdate.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdHelp.Location = New System.Drawing.Point(106, 508)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdClone.Location = New System.Drawing.Point(208, 508)
        Me.cmdClone.Name = "cmdClone"
        Me.cmdClone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClone.Size = New System.Drawing.Size(45, 49)
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
        Me.cmdTemplate.Location = New System.Drawing.Point(158, 508)
        Me.cmdTemplate.Name = "cmdTemplate"
        Me.cmdTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTemplate.Size = New System.Drawing.Size(45, 49)
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
        Me.Picture2.Location = New System.Drawing.Point(1164, 175)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(300, 177)
        Me.Picture2.TabIndex = 55
        Me.Picture2.TabStop = False
        '
        'picBitmap
        '
        Me.picBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.picBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBitmap.Location = New System.Drawing.Point(639, 17)
        Me.picBitmap.Name = "picBitmap"
        Me.picBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBitmap.Size = New System.Drawing.Size(393, 540)
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
        Me.TabStrip1.Location = New System.Drawing.Point(6, 2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(624, 487)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSupport2CutBack)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtSupport1CutBack)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(616, 454)
        Me.TabPage2.TabIndex = 11
        Me.TabPage2.Text = "D400'CutBack"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(7, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(197, 20)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "D0402'Support Cut back 2"
        '
        'txtSupport2CutBack
        '
        Me.txtSupport2CutBack.AcceptsReturn = True
        Me.txtSupport2CutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupport2CutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupport2CutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupport2CutBack.Location = New System.Drawing.Point(196, 62)
        Me.txtSupport2CutBack.MaxLength = 0
        Me.txtSupport2CutBack.Name = "txtSupport2CutBack"
        Me.txtSupport2CutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupport2CutBack.Size = New System.Drawing.Size(84, 26)
        Me.txtSupport2CutBack.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(7, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(197, 20)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "D0401'Support Cut back 1"
        '
        'txtSupport1CutBack
        '
        Me.txtSupport1CutBack.AcceptsReturn = True
        Me.txtSupport1CutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupport1CutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupport1CutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupport1CutBack.Location = New System.Drawing.Point(196, 11)
        Me.txtSupport1CutBack.MaxLength = 0
        Me.txtSupport1CutBack.Name = "txtSupport1CutBack"
        Me.txtSupport1CutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupport1CutBack.Size = New System.Drawing.Size(84, 26)
        Me.txtSupport1CutBack.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(4, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "D0404'Connect Cut back 2"
        '
        'txtConnectCutBack2
        '
        Me.txtConnectCutBack2.AcceptsReturn = True
        Me.txtConnectCutBack2.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack2.Location = New System.Drawing.Point(193, 158)
        Me.txtConnectCutBack2.MaxLength = 0
        Me.txtConnectCutBack2.Name = "txtConnectCutBack2"
        Me.txtConnectCutBack2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack2.Size = New System.Drawing.Size(84, 26)
        Me.txtConnectCutBack2.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(4, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D0403'Connect Cut back 1"
        '
        'txtConnectCutBack1
        '
        Me.txtConnectCutBack1.AcceptsReturn = True
        Me.txtConnectCutBack1.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack1.Location = New System.Drawing.Point(193, 115)
        Me.txtConnectCutBack1.MaxLength = 0
        Me.txtConnectCutBack1.Name = "txtConnectCutBack1"
        Me.txtConnectCutBack1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack1.Size = New System.Drawing.Size(84, 26)
        Me.txtConnectCutBack1.TabIndex = 84
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._TabFrames_0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(616, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "D0100'Plate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.GroupTop)
        Me._TabFrames_0.Controls.Add(Me.chkHasTopColumn)
        Me._TabFrames_0.Controls.Add(Me.GroupBottom)
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.txtPlateThickness)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(616, 454)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'GroupTop
        '
        Me.GroupTop.Controls.Add(Me.label19)
        Me.GroupTop.Controls.Add(Me.txtTopColumnDist)
        Me.GroupTop.Controls.Add(Me.Label18)
        Me.GroupTop.Controls.Add(Me.txtTopColumnWidth)
        Me.GroupTop.Controls.Add(Me.Label13)
        Me.GroupTop.Controls.Add(Me.txtTopAngle2)
        Me.GroupTop.Controls.Add(Me.Label14)
        Me.GroupTop.Controls.Add(Me.txtTopFillet2)
        Me.GroupTop.Controls.Add(Me.Label15)
        Me.GroupTop.Controls.Add(Me.txtTopAngle1)
        Me.GroupTop.Controls.Add(Me.Label16)
        Me.GroupTop.Controls.Add(Me.txtTopFillet1)
        Me.GroupTop.Location = New System.Drawing.Point(22, 262)
        Me.GroupTop.Name = "GroupTop"
        Me.GroupTop.Size = New System.Drawing.Size(572, 172)
        Me.GroupTop.TabIndex = 102
        Me.GroupTop.TabStop = False
        Me.GroupTop.Text = "D0112'Top"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.BackColor = System.Drawing.Color.Transparent
        Me.label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label19.Location = New System.Drawing.Point(297, 28)
        Me.label19.Name = "label19"
        Me.label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label19.Size = New System.Drawing.Size(79, 20)
        Me.label19.TabIndex = 119
        Me.label19.Text = "D014'Dist"
        '
        'txtTopColumnDist
        '
        Me.txtTopColumnDist.AcceptsReturn = True
        Me.txtTopColumnDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopColumnDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopColumnDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopColumnDist.Location = New System.Drawing.Point(449, 25)
        Me.txtTopColumnDist.MaxLength = 0
        Me.txtTopColumnDist.Name = "txtTopColumnDist"
        Me.txtTopColumnDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopColumnDist.Size = New System.Drawing.Size(84, 26)
        Me.txtTopColumnDist.TabIndex = 118
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(40, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(101, 20)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "D0113'Width"
        '
        'txtTopColumnWidth
        '
        Me.txtTopColumnWidth.AcceptsReturn = True
        Me.txtTopColumnWidth.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopColumnWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopColumnWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopColumnWidth.Location = New System.Drawing.Point(192, 25)
        Me.txtTopColumnWidth.MaxLength = 0
        Me.txtTopColumnWidth.Name = "txtTopColumnWidth"
        Me.txtTopColumnWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopColumnWidth.Size = New System.Drawing.Size(84, 26)
        Me.txtTopColumnWidth.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(297, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(114, 20)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "D0105'Angle 2"
        '
        'txtTopAngle2
        '
        Me.txtTopAngle2.AcceptsReturn = True
        Me.txtTopAngle2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopAngle2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopAngle2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopAngle2.Location = New System.Drawing.Point(449, 117)
        Me.txtTopAngle2.MaxLength = 0
        Me.txtTopAngle2.Name = "txtTopAngle2"
        Me.txtTopAngle2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopAngle2.Size = New System.Drawing.Size(84, 26)
        Me.txtTopAngle2.TabIndex = 114
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(297, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "D0104'Fillet 2"
        '
        'txtTopFillet2
        '
        Me.txtTopFillet2.AcceptsReturn = True
        Me.txtTopFillet2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopFillet2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopFillet2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopFillet2.Location = New System.Drawing.Point(449, 74)
        Me.txtTopFillet2.MaxLength = 0
        Me.txtTopFillet2.Name = "txtTopFillet2"
        Me.txtTopFillet2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopFillet2.Size = New System.Drawing.Size(84, 26)
        Me.txtTopFillet2.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(40, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(114, 20)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "D0103'Angle 1"
        '
        'txtTopAngle1
        '
        Me.txtTopAngle1.AcceptsReturn = True
        Me.txtTopAngle1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopAngle1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopAngle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopAngle1.Location = New System.Drawing.Point(192, 117)
        Me.txtTopAngle1.MaxLength = 0
        Me.txtTopAngle1.Name = "txtTopAngle1"
        Me.txtTopAngle1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopAngle1.Size = New System.Drawing.Size(84, 26)
        Me.txtTopAngle1.TabIndex = 110
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(40, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(106, 20)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "D0102'Fillet 1"
        '
        'txtTopFillet1
        '
        Me.txtTopFillet1.AcceptsReturn = True
        Me.txtTopFillet1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopFillet1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopFillet1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopFillet1.Location = New System.Drawing.Point(192, 74)
        Me.txtTopFillet1.MaxLength = 0
        Me.txtTopFillet1.Name = "txtTopFillet1"
        Me.txtTopFillet1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopFillet1.Size = New System.Drawing.Size(84, 26)
        Me.txtTopFillet1.TabIndex = 108
        '
        'chkHasTopColumn
        '
        Me.chkHasTopColumn.AutoSize = True
        Me.chkHasTopColumn.Location = New System.Drawing.Point(323, 22)
        Me.chkHasTopColumn.Name = "chkHasTopColumn"
        Me.chkHasTopColumn.Size = New System.Drawing.Size(197, 24)
        Me.chkHasTopColumn.TabIndex = 101
        Me.chkHasTopColumn.Text = "D0111'Has top column"
        Me.chkHasTopColumn.UseVisualStyleBackColor = True
        '
        'GroupBottom
        '
        Me.GroupBottom.Controls.Add(Me.Label9)
        Me.GroupBottom.Controls.Add(Me.txtAngle4)
        Me.GroupBottom.Controls.Add(Me.Label10)
        Me.GroupBottom.Controls.Add(Me.txtFillet4)
        Me.GroupBottom.Controls.Add(Me.Label11)
        Me.GroupBottom.Controls.Add(Me.txtAngle3)
        Me.GroupBottom.Controls.Add(Me.Label12)
        Me.GroupBottom.Controls.Add(Me.txtFillet3)
        Me.GroupBottom.Controls.Add(Me.Label5)
        Me.GroupBottom.Controls.Add(Me.txtAngle2)
        Me.GroupBottom.Controls.Add(Me.Label6)
        Me.GroupBottom.Controls.Add(Me.txtFillet2)
        Me.GroupBottom.Controls.Add(Me.Label2)
        Me.GroupBottom.Controls.Add(Me.txtAngle1)
        Me.GroupBottom.Controls.Add(Me.Label1)
        Me.GroupBottom.Controls.Add(Me.txtFillet1)
        Me.GroupBottom.Location = New System.Drawing.Point(22, 60)
        Me.GroupBottom.Name = "GroupBottom"
        Me.GroupBottom.Size = New System.Drawing.Size(572, 195)
        Me.GroupBottom.TabIndex = 100
        Me.GroupBottom.TabStop = False
        Me.GroupBottom.Text = "D0110'Bottom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(297, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "D0109'Angle 4"
        '
        'txtAngle4
        '
        Me.txtAngle4.AcceptsReturn = True
        Me.txtAngle4.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle4.Location = New System.Drawing.Point(449, 159)
        Me.txtAngle4.MaxLength = 0
        Me.txtAngle4.Name = "txtAngle4"
        Me.txtAngle4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle4.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle4.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(297, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "D0108'Fillet 4"
        '
        'txtFillet4
        '
        Me.txtFillet4.AcceptsReturn = True
        Me.txtFillet4.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet4.Location = New System.Drawing.Point(449, 116)
        Me.txtFillet4.MaxLength = 0
        Me.txtFillet4.Name = "txtFillet4"
        Me.txtFillet4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet4.Size = New System.Drawing.Size(84, 26)
        Me.txtFillet4.TabIndex = 112
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(40, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "D0107'Angle 3"
        '
        'txtAngle3
        '
        Me.txtAngle3.AcceptsReturn = True
        Me.txtAngle3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle3.Location = New System.Drawing.Point(192, 159)
        Me.txtAngle3.MaxLength = 0
        Me.txtAngle3.Name = "txtAngle3"
        Me.txtAngle3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle3.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle3.TabIndex = 110
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(40, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "D0106'Fillet 3"
        '
        'txtFillet3
        '
        Me.txtFillet3.AcceptsReturn = True
        Me.txtFillet3.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet3.Location = New System.Drawing.Point(192, 116)
        Me.txtFillet3.MaxLength = 0
        Me.txtFillet3.Name = "txtFillet3"
        Me.txtFillet3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet3.Size = New System.Drawing.Size(84, 26)
        Me.txtFillet3.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(297, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "D0105'Angle 2"
        '
        'txtAngle2
        '
        Me.txtAngle2.AcceptsReturn = True
        Me.txtAngle2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle2.Location = New System.Drawing.Point(449, 74)
        Me.txtAngle2.MaxLength = 0
        Me.txtAngle2.Name = "txtAngle2"
        Me.txtAngle2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle2.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle2.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(297, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "D0104'Fillet 2"
        '
        'txtFillet2
        '
        Me.txtFillet2.AcceptsReturn = True
        Me.txtFillet2.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet2.Location = New System.Drawing.Point(449, 31)
        Me.txtFillet2.MaxLength = 0
        Me.txtFillet2.Name = "txtFillet2"
        Me.txtFillet2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet2.Size = New System.Drawing.Size(84, 26)
        Me.txtFillet2.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(40, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "D0103'Angle 1"
        '
        'txtAngle1
        '
        Me.txtAngle1.AcceptsReturn = True
        Me.txtAngle1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle1.Location = New System.Drawing.Point(192, 74)
        Me.txtAngle1.MaxLength = 0
        Me.txtAngle1.Name = "txtAngle1"
        Me.txtAngle1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle1.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle1.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "D0102'Fillet 1"
        '
        'txtFillet1
        '
        Me.txtFillet1.AcceptsReturn = True
        Me.txtFillet1.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet1.Location = New System.Drawing.Point(192, 31)
        Me.txtFillet1.MaxLength = 0
        Me.txtFillet1.Name = "txtFillet1"
        Me.txtFillet1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet1.Size = New System.Drawing.Size(84, 26)
        Me.txtFillet1.TabIndex = 100
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.BackColor = System.Drawing.Color.Transparent
        Me.lblThick.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblThick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThick.Location = New System.Drawing.Point(18, 27)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblThick.Size = New System.Drawing.Size(135, 20)
        Me.lblThick.TabIndex = 79
        Me.lblThick.Text = "D0101'Thickness:"
        '
        'txtPlateThickness
        '
        Me.txtPlateThickness.AcceptsReturn = True
        Me.txtPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlateThickness.Location = New System.Drawing.Point(170, 24)
        Me.txtPlateThickness.MaxLength = 0
        Me.txtPlateThickness.Name = "txtPlateThickness"
        Me.txtPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtPlateThickness.TabIndex = 76
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(616, 454)
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
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(616, 454)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.groupBolt)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(616, 454)
        Me.TabPage7.TabIndex = 10
        Me.TabPage7.Text = "D0300'Bolt/Weld"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'groupBolt
        '
        Me.groupBolt.Controls.Add(Me.lblBoltStyle)
        Me.groupBolt.Controls.Add(Me.chkTurnBolts)
        Me.groupBolt.Controls.Add(Me.cbBoltStyle)
        Me.groupBolt.Location = New System.Drawing.Point(6, 8)
        Me.groupBolt.Name = "groupBolt"
        Me.groupBolt.Size = New System.Drawing.Size(600, 65)
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
        Me.lblBoltStyle.Location = New System.Drawing.Point(18, 23)
        Me.lblBoltStyle.Name = "lblBoltStyle"
        Me.lblBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBoltStyle.Size = New System.Drawing.Size(128, 20)
        Me.lblBoltStyle.TabIndex = 135
        Me.lblBoltStyle.Text = "D0302'Bolt style:"
        '
        'chkTurnBolts
        '
        Me.chkTurnBolts.AutoSize = True
        Me.chkTurnBolts.BackColor = System.Drawing.Color.Transparent
        Me.chkTurnBolts.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTurnBolts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTurnBolts.Location = New System.Drawing.Point(416, 22)
        Me.chkTurnBolts.Name = "chkTurnBolts"
        Me.chkTurnBolts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTurnBolts.Size = New System.Drawing.Size(156, 24)
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
        Me.cbBoltStyle.Location = New System.Drawing.Point(231, 18)
        Me.cbBoltStyle.Name = "cbBoltStyle"
        Me.cbBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBoltStyle.Size = New System.Drawing.Size(140, 28)
        Me.cbBoltStyle.TabIndex = 134
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(483, 508)
        Me.cmdRollover.Name = "cmdRollover"
        Me.cmdRollover.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRollover.Size = New System.Drawing.Size(45, 49)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1040, 599)
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
        Me.GroupTop.ResumeLayout(False)
        Me.GroupTop.PerformLayout()
        Me.GroupBottom.ResumeLayout(False)
        Me.GroupBottom.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.groupBolt.ResumeLayout(False)
        Me.groupBolt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _TabFrames_0 As System.Windows.Forms.GroupBox
    Public WithEvents txtPlateThickness As System.Windows.Forms.TextBox
    Public WithEvents lblThick As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents groupBolt As System.Windows.Forms.GroupBox
    Public WithEvents lblBoltStyle As System.Windows.Forms.Label
    Public WithEvents chkTurnBolts As System.Windows.Forms.CheckBox
    Public WithEvents cbBoltStyle As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtConnectCutBack2 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtConnectCutBack1 As System.Windows.Forms.TextBox
    Public WithEvents Label8 As Windows.Forms.Label
    Public WithEvents txtSupport2CutBack As Windows.Forms.TextBox
    Public WithEvents Label7 As Windows.Forms.Label
    Public WithEvents txtSupport1CutBack As Windows.Forms.TextBox
    Friend WithEvents GroupBottom As Windows.Forms.GroupBox
    Public WithEvents Label9 As Windows.Forms.Label
    Public WithEvents txtAngle4 As Windows.Forms.TextBox
    Public WithEvents Label10 As Windows.Forms.Label
    Public WithEvents txtFillet4 As Windows.Forms.TextBox
    Public WithEvents Label11 As Windows.Forms.Label
    Public WithEvents txtAngle3 As Windows.Forms.TextBox
    Public WithEvents Label12 As Windows.Forms.Label
    Public WithEvents txtFillet3 As Windows.Forms.TextBox
    Public WithEvents Label5 As Windows.Forms.Label
    Public WithEvents txtAngle2 As Windows.Forms.TextBox
    Public WithEvents Label6 As Windows.Forms.Label
    Public WithEvents txtFillet2 As Windows.Forms.TextBox
    Public WithEvents Label2 As Windows.Forms.Label
    Public WithEvents txtAngle1 As Windows.Forms.TextBox
    Public WithEvents Label1 As Windows.Forms.Label
    Public WithEvents txtFillet1 As Windows.Forms.TextBox
    Friend WithEvents chkHasTopColumn As Windows.Forms.CheckBox
    Friend WithEvents GroupTop As Windows.Forms.GroupBox
    Public WithEvents label19 As Windows.Forms.Label
    Public WithEvents txtTopColumnDist As Windows.Forms.TextBox
    Public WithEvents Label18 As Windows.Forms.Label
    Public WithEvents txtTopColumnWidth As Windows.Forms.TextBox
    Public WithEvents Label13 As Windows.Forms.Label
    Public WithEvents txtTopAngle2 As Windows.Forms.TextBox
    Public WithEvents Label14 As Windows.Forms.Label
    Public WithEvents txtTopFillet2 As Windows.Forms.TextBox
    Public WithEvents Label15 As Windows.Forms.Label
    Public WithEvents txtTopAngle1 As Windows.Forms.TextBox
    Public WithEvents Label16 As Windows.Forms.Label
    Public WithEvents txtTopFillet1 As Windows.Forms.TextBox
#End Region
End Class