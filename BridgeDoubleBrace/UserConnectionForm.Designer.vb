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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMainChordPlateThickness = New System.Windows.Forms.TextBox()
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
        Me.GroupBottom = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAngle4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAngle3 = New System.Windows.Forms.TextBox()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtConnect1Thickness = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtConnect1Angle = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtConnect1innerWebDist = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtConnect1innerWebCount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtConnect1innerWebThickness = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtConnect1InnerWebHeight = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtConnect1Width = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtConnect1Length = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtConnect1Gap = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConnect1Radius = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConnect1SideDistance = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtConnect2Thickness = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtConnect2Angle = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtConnect2innerWebDist = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtConnect2innerWebCount = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtConnect2innerWebThickness = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtConnect2InnerWebHeight = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtConnect2Width = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtConnect2Length = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtConnect2Gap = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtConnect2Radius = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtConnect2SideDistance = New System.Windows.Forms.TextBox()
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
        Me.GroupBottom.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
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
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(203, 320)
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
        Me.cmdAccept.Location = New System.Drawing.Point(5, 320)
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
        Me.cmdCancel.Location = New System.Drawing.Point(39, 320)
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(390, 320)
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(357, 320)
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
        Me.cmdHelp.Location = New System.Drawing.Point(72, 320)
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
        Me.cmdClone.Location = New System.Drawing.Point(140, 320)
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
        Me.cmdTemplate.Location = New System.Drawing.Point(106, 320)
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
        Me.picBitmap.Size = New System.Drawing.Size(262, 341)
        Me.picBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBitmap.TabIndex = 6
        Me.picBitmap.TabStop = False
        '
        'TabStrip1
        '
        Me.TabStrip1.Controls.Add(Me.TabPage2)
        Me.TabStrip1.Controls.Add(Me.TabPage1)
        Me.TabStrip1.Controls.Add(Me.TabPage4)
        Me.TabStrip1.Controls.Add(Me.TabPage5)
        Me.TabStrip1.Controls.Add(Me.TabPage3)
        Me.TabStrip1.Controls.Add(Me.TabPage7)
        Me.TabStrip1.Location = New System.Drawing.Point(4, 1)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(416, 307)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtMainChordPlateThickness)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSupport2CutBack)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtSupport1CutBack)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtConnectCutBack1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(408, 281)
        Me.TabPage2.TabIndex = 11
        Me.TabPage2.Text = "D400'CutBack"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(193, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "D0405'Main Chord Thickness"
        '
        'txtMainChordPlateThickness
        '
        Me.txtMainChordPlateThickness.AcceptsReturn = True
        Me.txtMainChordPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtMainChordPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainChordPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMainChordPlateThickness.Location = New System.Drawing.Point(315, 10)
        Me.txtMainChordPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMainChordPlateThickness.MaxLength = 0
        Me.txtMainChordPlateThickness.Name = "txtMainChordPlateThickness"
        Me.txtMainChordPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainChordPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtMainChordPlateThickness.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "D0402'Support Cut back 2"
        '
        'txtSupport2CutBack
        '
        Me.txtSupport2CutBack.AcceptsReturn = True
        Me.txtSupport2CutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupport2CutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupport2CutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupport2CutBack.Location = New System.Drawing.Point(112, 40)
        Me.txtSupport2CutBack.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupport2CutBack.MaxLength = 0
        Me.txtSupport2CutBack.Name = "txtSupport2CutBack"
        Me.txtSupport2CutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupport2CutBack.Size = New System.Drawing.Size(57, 20)
        Me.txtSupport2CutBack.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(9, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "D0401'Support Cut back 1"
        '
        'txtSupport1CutBack
        '
        Me.txtSupport1CutBack.AcceptsReturn = True
        Me.txtSupport1CutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupport1CutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupport1CutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupport1CutBack.Location = New System.Drawing.Point(112, 8)
        Me.txtSupport1CutBack.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupport1CutBack.MaxLength = 0
        Me.txtSupport1CutBack.Name = "txtSupport1CutBack"
        Me.txtSupport1CutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupport1CutBack.Size = New System.Drawing.Size(57, 20)
        Me.txtSupport1CutBack.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "D0404'Connect Cut back 2"
        '
        'txtConnectCutBack2
        '
        Me.txtConnectCutBack2.AcceptsReturn = True
        Me.txtConnectCutBack2.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack2.Location = New System.Drawing.Point(112, 103)
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
        Me.Label4.Location = New System.Drawing.Point(7, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D0403'Connect Cut back 1"
        '
        'txtConnectCutBack1
        '
        Me.txtConnectCutBack1.AcceptsReturn = True
        Me.txtConnectCutBack1.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectCutBack1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectCutBack1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectCutBack1.Location = New System.Drawing.Point(112, 75)
        Me.txtConnectCutBack1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnectCutBack1.MaxLength = 0
        Me.txtConnectCutBack1.Name = "txtConnectCutBack1"
        Me.txtConnectCutBack1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack1.Size = New System.Drawing.Size(57, 20)
        Me.txtConnectCutBack1.TabIndex = 84
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._TabFrames_0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(408, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "D0100'Side Plate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.GroupBottom)
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.txtPlateThickness)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Margin = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.Padding = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(408, 281)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'GroupBottom
        '
        Me.GroupBottom.Controls.Add(Me.Label10)
        Me.GroupBottom.Controls.Add(Me.txtAngle4)
        Me.GroupBottom.Controls.Add(Me.Label12)
        Me.GroupBottom.Controls.Add(Me.txtAngle3)
        Me.GroupBottom.Controls.Add(Me.Label5)
        Me.GroupBottom.Controls.Add(Me.txtAngle2)
        Me.GroupBottom.Controls.Add(Me.Label6)
        Me.GroupBottom.Controls.Add(Me.txtFillet2)
        Me.GroupBottom.Controls.Add(Me.Label2)
        Me.GroupBottom.Controls.Add(Me.txtAngle1)
        Me.GroupBottom.Controls.Add(Me.Label1)
        Me.GroupBottom.Controls.Add(Me.txtFillet1)
        Me.GroupBottom.Location = New System.Drawing.Point(15, 39)
        Me.GroupBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBottom.Name = "GroupBottom"
        Me.GroupBottom.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBottom.Size = New System.Drawing.Size(381, 106)
        Me.GroupBottom.TabIndex = 100
        Me.GroupBottom.TabStop = False
        Me.GroupBottom.Text = "D0110'Bottom"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(198, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "D0109'Angle 4"
        '
        'txtAngle4
        '
        Me.txtAngle4.AcceptsReturn = True
        Me.txtAngle4.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle4.Location = New System.Drawing.Point(299, 74)
        Me.txtAngle4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAngle4.MaxLength = 0
        Me.txtAngle4.Name = "txtAngle4"
        Me.txtAngle4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle4.Size = New System.Drawing.Size(57, 20)
        Me.txtAngle4.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(27, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "D0107'Angle 3"
        '
        'txtAngle3
        '
        Me.txtAngle3.AcceptsReturn = True
        Me.txtAngle3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle3.Location = New System.Drawing.Point(128, 74)
        Me.txtAngle3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAngle3.MaxLength = 0
        Me.txtAngle3.Name = "txtAngle3"
        Me.txtAngle3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle3.Size = New System.Drawing.Size(57, 20)
        Me.txtAngle3.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(198, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "D0105'Angle 2"
        '
        'txtAngle2
        '
        Me.txtAngle2.AcceptsReturn = True
        Me.txtAngle2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle2.Location = New System.Drawing.Point(299, 47)
        Me.txtAngle2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAngle2.MaxLength = 0
        Me.txtAngle2.Name = "txtAngle2"
        Me.txtAngle2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle2.Size = New System.Drawing.Size(57, 20)
        Me.txtAngle2.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(198, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "D0104'Fillet 2"
        '
        'txtFillet2
        '
        Me.txtFillet2.AcceptsReturn = True
        Me.txtFillet2.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet2.Location = New System.Drawing.Point(299, 20)
        Me.txtFillet2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFillet2.MaxLength = 0
        Me.txtFillet2.Name = "txtFillet2"
        Me.txtFillet2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet2.Size = New System.Drawing.Size(57, 20)
        Me.txtFillet2.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "D0103'Angle 1"
        '
        'txtAngle1
        '
        Me.txtAngle1.AcceptsReturn = True
        Me.txtAngle1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle1.Location = New System.Drawing.Point(128, 47)
        Me.txtAngle1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAngle1.MaxLength = 0
        Me.txtAngle1.Name = "txtAngle1"
        Me.txtAngle1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle1.Size = New System.Drawing.Size(57, 20)
        Me.txtAngle1.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "D0102'Fillet 1"
        '
        'txtFillet1
        '
        Me.txtFillet1.AcceptsReturn = True
        Me.txtFillet1.BackColor = System.Drawing.SystemColors.Window
        Me.txtFillet1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFillet1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFillet1.Location = New System.Drawing.Point(128, 20)
        Me.txtFillet1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFillet1.MaxLength = 0
        Me.txtFillet1.Name = "txtFillet1"
        Me.txtFillet1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFillet1.Size = New System.Drawing.Size(57, 20)
        Me.txtFillet1.TabIndex = 100
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.BackColor = System.Drawing.Color.Transparent
        Me.lblThick.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblThick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThick.Location = New System.Drawing.Point(12, 16)
        Me.lblThick.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblThick.Size = New System.Drawing.Size(93, 13)
        Me.lblThick.TabIndex = 79
        Me.lblThick.Text = "D0101'Thickness:"
        '
        'txtPlateThickness
        '
        Me.txtPlateThickness.AcceptsReturn = True
        Me.txtPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlateThickness.Location = New System.Drawing.Point(113, 12)
        Me.txtPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlateThickness.MaxLength = 0
        Me.txtPlateThickness.Name = "txtPlateThickness"
        Me.txtPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtPlateThickness.TabIndex = 76
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.txtConnect1Thickness)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.txtConnect1Angle)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtConnect1innerWebDist)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.txtConnect1innerWebCount)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.txtConnect1innerWebThickness)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.txtConnect1InnerWebHeight)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.txtConnect1Width)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.txtConnect1Length)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.txtConnect1Gap)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.txtConnect1Radius)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.txtConnect1SideDistance)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(408, 281)
        Me.TabPage4.TabIndex = 12
        Me.TabPage4.Text = "D0500'Connect Plate 1"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(9, 176)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "D0506'Thickness"
        '
        'txtConnect1Thickness
        '
        Me.txtConnect1Thickness.AcceptsReturn = True
        Me.txtConnect1Thickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Thickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Thickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Thickness.Location = New System.Drawing.Point(113, 174)
        Me.txtConnect1Thickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Thickness.MaxLength = 0
        Me.txtConnect1Thickness.Name = "txtConnect1Thickness"
        Me.txtConnect1Thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Thickness.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Thickness.TabIndex = 122
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(9, 211)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "D0507'Angle"
        '
        'txtConnect1Angle
        '
        Me.txtConnect1Angle.AcceptsReturn = True
        Me.txtConnect1Angle.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Angle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Angle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Angle.Location = New System.Drawing.Point(113, 209)
        Me.txtConnect1Angle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Angle.MaxLength = 0
        Me.txtConnect1Angle.Name = "txtConnect1Angle"
        Me.txtConnect1Angle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Angle.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Angle.TabIndex = 120
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(221, 104)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(109, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "D0511'Web Side Dist"
        '
        'txtConnect1innerWebDist
        '
        Me.txtConnect1innerWebDist.AcceptsReturn = True
        Me.txtConnect1innerWebDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebDist.Location = New System.Drawing.Point(325, 102)
        Me.txtConnect1innerWebDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1innerWebDist.MaxLength = 0
        Me.txtConnect1innerWebDist.Name = "txtConnect1innerWebDist"
        Me.txtConnect1innerWebDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebDist.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1innerWebDist.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(221, 73)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "D0510'Web Count"
        '
        'txtConnect1innerWebCount
        '
        Me.txtConnect1innerWebCount.AcceptsReturn = True
        Me.txtConnect1innerWebCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebCount.Location = New System.Drawing.Point(325, 71)
        Me.txtConnect1innerWebCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1innerWebCount.MaxLength = 0
        Me.txtConnect1innerWebCount.Name = "txtConnect1innerWebCount"
        Me.txtConnect1innerWebCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebCount.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1innerWebCount.TabIndex = 116
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(221, 42)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(116, 13)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "D0509'Web Thickness"
        '
        'txtConnect1innerWebThickness
        '
        Me.txtConnect1innerWebThickness.AcceptsReturn = True
        Me.txtConnect1innerWebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebThickness.Location = New System.Drawing.Point(325, 40)
        Me.txtConnect1innerWebThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1innerWebThickness.MaxLength = 0
        Me.txtConnect1innerWebThickness.Name = "txtConnect1innerWebThickness"
        Me.txtConnect1innerWebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1innerWebThickness.TabIndex = 114
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(221, 12)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "D0508'Web Height"
        '
        'txtConnect1InnerWebHeight
        '
        Me.txtConnect1InnerWebHeight.AcceptsReturn = True
        Me.txtConnect1InnerWebHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1InnerWebHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1InnerWebHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1InnerWebHeight.Location = New System.Drawing.Point(325, 10)
        Me.txtConnect1InnerWebHeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1InnerWebHeight.MaxLength = 0
        Me.txtConnect1InnerWebHeight.Name = "txtConnect1InnerWebHeight"
        Me.txtConnect1InnerWebHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1InnerWebHeight.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1InnerWebHeight.TabIndex = 112
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(9, 139)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "D0505'Width"
        '
        'txtConnect1Width
        '
        Me.txtConnect1Width.AcceptsReturn = True
        Me.txtConnect1Width.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Width.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Width.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Width.Location = New System.Drawing.Point(113, 137)
        Me.txtConnect1Width.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Width.MaxLength = 0
        Me.txtConnect1Width.Name = "txtConnect1Width"
        Me.txtConnect1Width.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Width.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Width.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(9, 106)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "D0504'Length"
        '
        'txtConnect1Length
        '
        Me.txtConnect1Length.AcceptsReturn = True
        Me.txtConnect1Length.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Length.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Length.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Length.Location = New System.Drawing.Point(113, 104)
        Me.txtConnect1Length.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Length.MaxLength = 0
        Me.txtConnect1Length.Name = "txtConnect1Length"
        Me.txtConnect1Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Length.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Length.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(9, 71)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "D0503'Gap"
        '
        'txtConnect1Gap
        '
        Me.txtConnect1Gap.AcceptsReturn = True
        Me.txtConnect1Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Gap.Location = New System.Drawing.Point(113, 70)
        Me.txtConnect1Gap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Gap.MaxLength = 0
        Me.txtConnect1Gap.Name = "txtConnect1Gap"
        Me.txtConnect1Gap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Gap.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Gap.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(9, 40)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "D0502'Radius"
        '
        'txtConnect1Radius
        '
        Me.txtConnect1Radius.AcceptsReturn = True
        Me.txtConnect1Radius.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Radius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Radius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Radius.Location = New System.Drawing.Point(113, 38)
        Me.txtConnect1Radius.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1Radius.MaxLength = 0
        Me.txtConnect1Radius.Name = "txtConnect1Radius"
        Me.txtConnect1Radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Radius.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1Radius.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(9, 10)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "D0501'Dist"
        '
        'txtConnect1SideDistance
        '
        Me.txtConnect1SideDistance.AcceptsReturn = True
        Me.txtConnect1SideDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1SideDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1SideDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1SideDistance.Location = New System.Drawing.Point(113, 8)
        Me.txtConnect1SideDistance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect1SideDistance.MaxLength = 0
        Me.txtConnect1SideDistance.Name = "txtConnect1SideDistance"
        Me.txtConnect1SideDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1SideDistance.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect1SideDistance.TabIndex = 102
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.txtConnect2Thickness)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.txtConnect2Angle)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Controls.Add(Me.txtConnect2innerWebDist)
        Me.TabPage5.Controls.Add(Me.Label26)
        Me.TabPage5.Controls.Add(Me.txtConnect2innerWebCount)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.txtConnect2innerWebThickness)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.txtConnect2InnerWebHeight)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.txtConnect2Width)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.txtConnect2Length)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.txtConnect2Gap)
        Me.TabPage5.Controls.Add(Me.Label32)
        Me.TabPage5.Controls.Add(Me.txtConnect2Radius)
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Controls.Add(Me.txtConnect2SideDistance)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(408, 281)
        Me.TabPage5.TabIndex = 13
        Me.TabPage5.Text = "D0600'Connect Plate 2"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(9, 176)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "D0506'Thickness"
        '
        'txtConnect2Thickness
        '
        Me.txtConnect2Thickness.AcceptsReturn = True
        Me.txtConnect2Thickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Thickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Thickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Thickness.Location = New System.Drawing.Point(113, 174)
        Me.txtConnect2Thickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Thickness.MaxLength = 0
        Me.txtConnect2Thickness.Name = "txtConnect2Thickness"
        Me.txtConnect2Thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Thickness.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Thickness.TabIndex = 144
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(9, 211)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "D0507'Angle"
        '
        'txtConnect2Angle
        '
        Me.txtConnect2Angle.AcceptsReturn = True
        Me.txtConnect2Angle.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Angle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Angle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Angle.Location = New System.Drawing.Point(113, 209)
        Me.txtConnect2Angle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Angle.MaxLength = 0
        Me.txtConnect2Angle.Name = "txtConnect2Angle"
        Me.txtConnect2Angle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Angle.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Angle.TabIndex = 142
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(221, 104)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 141
        Me.Label25.Text = "D0511'Web Side Dist"
        '
        'txtConnect2innerWebDist
        '
        Me.txtConnect2innerWebDist.AcceptsReturn = True
        Me.txtConnect2innerWebDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebDist.Location = New System.Drawing.Point(325, 102)
        Me.txtConnect2innerWebDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2innerWebDist.MaxLength = 0
        Me.txtConnect2innerWebDist.Name = "txtConnect2innerWebDist"
        Me.txtConnect2innerWebDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebDist.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2innerWebDist.TabIndex = 140
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(221, 73)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(95, 13)
        Me.Label26.TabIndex = 139
        Me.Label26.Text = "D0510'Web Count"
        '
        'txtConnect2innerWebCount
        '
        Me.txtConnect2innerWebCount.AcceptsReturn = True
        Me.txtConnect2innerWebCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebCount.Location = New System.Drawing.Point(325, 71)
        Me.txtConnect2innerWebCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2innerWebCount.MaxLength = 0
        Me.txtConnect2innerWebCount.Name = "txtConnect2innerWebCount"
        Me.txtConnect2innerWebCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebCount.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2innerWebCount.TabIndex = 138
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(221, 42)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(116, 13)
        Me.Label27.TabIndex = 137
        Me.Label27.Text = "D0509'Web Thickness"
        '
        'txtConnect2innerWebThickness
        '
        Me.txtConnect2innerWebThickness.AcceptsReturn = True
        Me.txtConnect2innerWebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebThickness.Location = New System.Drawing.Point(325, 40)
        Me.txtConnect2innerWebThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2innerWebThickness.MaxLength = 0
        Me.txtConnect2innerWebThickness.Name = "txtConnect2innerWebThickness"
        Me.txtConnect2innerWebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2innerWebThickness.TabIndex = 136
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(221, 12)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(98, 13)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "D0508'Web Height"
        '
        'txtConnect2InnerWebHeight
        '
        Me.txtConnect2InnerWebHeight.AcceptsReturn = True
        Me.txtConnect2InnerWebHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2InnerWebHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2InnerWebHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2InnerWebHeight.Location = New System.Drawing.Point(325, 10)
        Me.txtConnect2InnerWebHeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2InnerWebHeight.MaxLength = 0
        Me.txtConnect2InnerWebHeight.Name = "txtConnect2InnerWebHeight"
        Me.txtConnect2InnerWebHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2InnerWebHeight.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2InnerWebHeight.TabIndex = 134
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(9, 139)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 133
        Me.Label29.Text = "D0505'Width"
        '
        'txtConnect2Width
        '
        Me.txtConnect2Width.AcceptsReturn = True
        Me.txtConnect2Width.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Width.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Width.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Width.Location = New System.Drawing.Point(113, 137)
        Me.txtConnect2Width.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Width.MaxLength = 0
        Me.txtConnect2Width.Name = "txtConnect2Width"
        Me.txtConnect2Width.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Width.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Width.TabIndex = 132
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(9, 106)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(74, 13)
        Me.Label30.TabIndex = 131
        Me.Label30.Text = "D0504'Length"
        '
        'txtConnect2Length
        '
        Me.txtConnect2Length.AcceptsReturn = True
        Me.txtConnect2Length.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Length.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Length.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Length.Location = New System.Drawing.Point(113, 104)
        Me.txtConnect2Length.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Length.MaxLength = 0
        Me.txtConnect2Length.Name = "txtConnect2Length"
        Me.txtConnect2Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Length.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Length.TabIndex = 130
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(9, 71)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(61, 13)
        Me.Label31.TabIndex = 129
        Me.Label31.Text = "D0503'Gap"
        '
        'txtConnect2Gap
        '
        Me.txtConnect2Gap.AcceptsReturn = True
        Me.txtConnect2Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Gap.Location = New System.Drawing.Point(113, 70)
        Me.txtConnect2Gap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Gap.MaxLength = 0
        Me.txtConnect2Gap.Name = "txtConnect2Gap"
        Me.txtConnect2Gap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Gap.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Gap.TabIndex = 128
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(9, 40)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(74, 13)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "D0502'Radius"
        '
        'txtConnect2Radius
        '
        Me.txtConnect2Radius.AcceptsReturn = True
        Me.txtConnect2Radius.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Radius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Radius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Radius.Location = New System.Drawing.Point(113, 38)
        Me.txtConnect2Radius.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Radius.MaxLength = 0
        Me.txtConnect2Radius.Name = "txtConnect2Radius"
        Me.txtConnect2Radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Radius.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Radius.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(9, 10)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(59, 13)
        Me.Label33.TabIndex = 125
        Me.Label33.Text = "D0501'Dist"
        '
        'txtConnect2SideDistance
        '
        Me.txtConnect2SideDistance.AcceptsReturn = True
        Me.txtConnect2SideDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2SideDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2SideDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2SideDistance.Location = New System.Drawing.Point(113, 8)
        Me.txtConnect2SideDistance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2SideDistance.MaxLength = 0
        Me.txtConnect2SideDistance.Name = "txtConnect2SideDistance"
        Me.txtConnect2SideDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2SideDistance.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2SideDistance.TabIndex = 124
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(408, 281)
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
        Me.GroupBox1.Size = New System.Drawing.Size(408, 281)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.groupBolt)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(408, 281)
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
        Me.cmdRollover.Location = New System.Drawing.Point(323, 320)
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
        Me.ClientSize = New System.Drawing.Size(693, 363)
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
        Me.GroupBottom.ResumeLayout(False)
        Me.GroupBottom.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
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
    Public WithEvents Label10 As Windows.Forms.Label
    Public WithEvents txtAngle4 As Windows.Forms.TextBox
    Public WithEvents Label12 As Windows.Forms.Label
    Public WithEvents txtAngle3 As Windows.Forms.TextBox
    Public WithEvents Label5 As Windows.Forms.Label
    Public WithEvents txtAngle2 As Windows.Forms.TextBox
    Public WithEvents Label6 As Windows.Forms.Label
    Public WithEvents txtFillet2 As Windows.Forms.TextBox
    Public WithEvents Label2 As Windows.Forms.Label
    Public WithEvents txtAngle1 As Windows.Forms.TextBox
    Public WithEvents Label1 As Windows.Forms.Label
    Public WithEvents txtFillet1 As Windows.Forms.TextBox
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Public WithEvents Label9 As Windows.Forms.Label
    Public WithEvents txtMainChordPlateThickness As Windows.Forms.TextBox
    Public WithEvents Label11 As Windows.Forms.Label
    Public WithEvents txtConnect1SideDistance As Windows.Forms.TextBox
    Public WithEvents Label22 As Windows.Forms.Label
    Public WithEvents txtConnect1Thickness As Windows.Forms.TextBox
    Public WithEvents Label21 As Windows.Forms.Label
    Public WithEvents txtConnect1Angle As Windows.Forms.TextBox
    Public WithEvents Label20 As Windows.Forms.Label
    Public WithEvents txtConnect1innerWebDist As Windows.Forms.TextBox
    Public WithEvents Label19 As Windows.Forms.Label
    Public WithEvents txtConnect1innerWebCount As Windows.Forms.TextBox
    Public WithEvents Label18 As Windows.Forms.Label
    Public WithEvents txtConnect1innerWebThickness As Windows.Forms.TextBox
    Public WithEvents Label17 As Windows.Forms.Label
    Public WithEvents txtConnect1InnerWebHeight As Windows.Forms.TextBox
    Public WithEvents Label16 As Windows.Forms.Label
    Public WithEvents txtConnect1Width As Windows.Forms.TextBox
    Public WithEvents Label15 As Windows.Forms.Label
    Public WithEvents txtConnect1Length As Windows.Forms.TextBox
    Public WithEvents Label14 As Windows.Forms.Label
    Public WithEvents txtConnect1Gap As Windows.Forms.TextBox
    Public WithEvents Label13 As Windows.Forms.Label
    Public WithEvents txtConnect1Radius As Windows.Forms.TextBox
    Friend WithEvents TabPage5 As Windows.Forms.TabPage
    Public WithEvents Label23 As Windows.Forms.Label
    Public WithEvents txtConnect2Thickness As Windows.Forms.TextBox
    Public WithEvents Label24 As Windows.Forms.Label
    Public WithEvents txtConnect2Angle As Windows.Forms.TextBox
    Public WithEvents Label25 As Windows.Forms.Label
    Public WithEvents txtConnect2innerWebDist As Windows.Forms.TextBox
    Public WithEvents Label26 As Windows.Forms.Label
    Public WithEvents txtConnect2innerWebCount As Windows.Forms.TextBox
    Public WithEvents Label27 As Windows.Forms.Label
    Public WithEvents txtConnect2innerWebThickness As Windows.Forms.TextBox
    Public WithEvents Label28 As Windows.Forms.Label
    Public WithEvents txtConnect2InnerWebHeight As Windows.Forms.TextBox
    Public WithEvents Label29 As Windows.Forms.Label
    Public WithEvents txtConnect2Width As Windows.Forms.TextBox
    Public WithEvents Label30 As Windows.Forms.Label
    Public WithEvents txtConnect2Length As Windows.Forms.TextBox
    Public WithEvents Label31 As Windows.Forms.Label
    Public WithEvents txtConnect2Gap As Windows.Forms.TextBox
    Public WithEvents Label32 As Windows.Forms.Label
    Public WithEvents txtConnect2Radius As Windows.Forms.TextBox
    Public WithEvents Label33 As Windows.Forms.Label
    Public WithEvents txtConnect2SideDistance As Windows.Forms.TextBox
#End Region
End Class