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
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtConnect1WebThickness = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtConnect2WebThickness = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtConnect1Gap = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtConnect2Gap = New System.Windows.Forms.TextBox()
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
        Me.TabPageSidePlate = New System.Windows.Forms.TabPage()
        Me._TabFrames_0 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageHoleGroup1 = New System.Windows.Forms.TabPage()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtInsidePlThickness1 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtOutsidePlThickness1 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtVerHoleCount1 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtHorHoleCount1 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtVerDist1 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtVerSideDist1 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtHorDist1 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtHorSideDist1 = New System.Windows.Forms.TextBox()
        Me.TabPageHoleGroup2 = New System.Windows.Forms.TabPage()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtInsidePlThickness2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtOutsidePlThickness2 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtVerHoleCount2 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtHorHoleCount2 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtVerDist2 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtVerSideDist2 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtHorDist2 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtHorSideDist2 = New System.Windows.Forms.TextBox()
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
        Me.TabPageConnPlate1 = New System.Windows.Forms.TabPage()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConnect1Radius = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConnect1SideDistance = New System.Windows.Forms.TextBox()
        Me.TabPageConnPlate2 = New System.Windows.Forms.TabPage()
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtConnect2Radius = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtConnect2SideDistance = New System.Windows.Forms.TextBox()
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
        Me.TabPageGeneral.SuspendLayout()
        Me.TabPageSidePlate.SuspendLayout()
        Me._TabFrames_0.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageHoleGroup1.SuspendLayout()
        Me.TabPageHoleGroup2.SuspendLayout()
        Me.GroupBottom.SuspendLayout()
        Me.TabPageConnPlate1.SuspendLayout()
        Me.TabPageConnPlate2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGetLengthFromLine
        '
        Me.cmdGetLengthFromLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetLengthFromLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetLengthFromLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetLengthFromLine.Image = CType(resources.GetObject("cmdGetLengthFromLine.Image"), System.Drawing.Image)
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(304, 492)
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
        Me.cmdAccept.Location = New System.Drawing.Point(8, 492)
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
        Me.cmdCancel.Location = New System.Drawing.Point(58, 492)
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(585, 492)
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(536, 492)
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
        Me.cmdHelp.Location = New System.Drawing.Point(108, 492)
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
        Me.cmdClone.Location = New System.Drawing.Point(210, 492)
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
        Me.cmdTemplate.Location = New System.Drawing.Point(159, 492)
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
        Me.picBitmap.Size = New System.Drawing.Size(393, 525)
        Me.picBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBitmap.TabIndex = 6
        Me.picBitmap.TabStop = False
        '
        'TabStrip1
        '
        Me.TabStrip1.Controls.Add(Me.TabPageGeneral)
        Me.TabStrip1.Controls.Add(Me.TabPageSidePlate)
        Me.TabStrip1.Controls.Add(Me.TabPageConnPlate1)
        Me.TabStrip1.Controls.Add(Me.TabPageConnPlate2)
        Me.TabStrip1.Location = New System.Drawing.Point(6, 14)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(624, 472)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.Label34)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect1WebThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label35)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect2WebThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label14)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect1Gap)
        Me.TabPageGeneral.Controls.Add(Me.Label31)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect2Gap)
        Me.TabPageGeneral.Controls.Add(Me.Label9)
        Me.TabPageGeneral.Controls.Add(Me.txtMainChordPlateThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label8)
        Me.TabPageGeneral.Controls.Add(Me.txtSupport2CutBack)
        Me.TabPageGeneral.Controls.Add(Me.Label7)
        Me.TabPageGeneral.Controls.Add(Me.txtSupport1CutBack)
        Me.TabPageGeneral.Controls.Add(Me.Label3)
        Me.TabPageGeneral.Controls.Add(Me.txtConnectCutBack2)
        Me.TabPageGeneral.Controls.Add(Me.Label4)
        Me.TabPageGeneral.Controls.Add(Me.txtConnectCutBack1)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGeneral.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageGeneral.Size = New System.Drawing.Size(616, 439)
        Me.TabPageGeneral.TabIndex = 11
        Me.TabPageGeneral.Text = "D400'CutBack"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(303, 117)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(200, 20)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "D0406'Connect Web Thk 1"
        '
        'txtConnect1WebThickness
        '
        Me.txtConnect1WebThickness.AcceptsReturn = True
        Me.txtConnect1WebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1WebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1WebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1WebThickness.Location = New System.Drawing.Point(472, 111)
        Me.txtConnect1WebThickness.MaxLength = 0
        Me.txtConnect1WebThickness.Name = "txtConnect1WebThickness"
        Me.txtConnect1WebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1WebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1WebThickness.TabIndex = 136
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(303, 166)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(200, 20)
        Me.Label35.TabIndex = 135
        Me.Label35.Text = "D0406'Connect Web Thk 2"
        '
        'txtConnect2WebThickness
        '
        Me.txtConnect2WebThickness.AcceptsReturn = True
        Me.txtConnect2WebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2WebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2WebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2WebThickness.Location = New System.Drawing.Point(472, 160)
        Me.txtConnect2WebThickness.MaxLength = 0
        Me.txtConnect2WebThickness.Name = "txtConnect2WebThickness"
        Me.txtConnect2WebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2WebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2WebThickness.TabIndex = 134
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(303, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "D0503'Gap"
        '
        'txtConnect1Gap
        '
        Me.txtConnect1Gap.AcceptsReturn = True
        Me.txtConnect1Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Gap.Location = New System.Drawing.Point(472, 12)
        Me.txtConnect1Gap.MaxLength = 0
        Me.txtConnect1Gap.Name = "txtConnect1Gap"
        Me.txtConnect1Gap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Gap.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Gap.TabIndex = 132
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(303, 68)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(91, 20)
        Me.Label31.TabIndex = 131
        Me.Label31.Text = "D0503'Gap"
        '
        'txtConnect2Gap
        '
        Me.txtConnect2Gap.AcceptsReturn = True
        Me.txtConnect2Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Gap.Location = New System.Drawing.Point(472, 62)
        Me.txtConnect2Gap.MaxLength = 0
        Me.txtConnect2Gap.Name = "txtConnect2Gap"
        Me.txtConnect2Gap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Gap.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Gap.TabIndex = 130
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(14, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(171, 20)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "D0405'Main Chord Thk"
        '
        'txtMainChordPlateThickness
        '
        Me.txtMainChordPlateThickness.AcceptsReturn = True
        Me.txtMainChordPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtMainChordPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainChordPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMainChordPlateThickness.Location = New System.Drawing.Point(196, 209)
        Me.txtMainChordPlateThickness.MaxLength = 0
        Me.txtMainChordPlateThickness.Name = "txtMainChordPlateThickness"
        Me.txtMainChordPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainChordPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtMainChordPlateThickness.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 68)
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
        Me.Label7.Location = New System.Drawing.Point(14, 18)
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
        Me.txtSupport1CutBack.Location = New System.Drawing.Point(196, 12)
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
        Me.Label3.Location = New System.Drawing.Point(14, 166)
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
        Me.txtConnectCutBack2.Location = New System.Drawing.Point(196, 160)
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
        Me.Label4.Location = New System.Drawing.Point(10, 117)
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
        Me.txtConnectCutBack1.Location = New System.Drawing.Point(196, 111)
        Me.txtConnectCutBack1.MaxLength = 0
        Me.txtConnectCutBack1.Name = "txtConnectCutBack1"
        Me.txtConnectCutBack1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectCutBack1.Size = New System.Drawing.Size(84, 26)
        Me.txtConnectCutBack1.TabIndex = 84
        '
        'TabPageSidePlate
        '
        Me.TabPageSidePlate.Controls.Add(Me._TabFrames_0)
        Me.TabPageSidePlate.Location = New System.Drawing.Point(4, 29)
        Me.TabPageSidePlate.Name = "TabPageSidePlate"
        Me.TabPageSidePlate.Size = New System.Drawing.Size(616, 439)
        Me.TabPageSidePlate.TabIndex = 0
        Me.TabPageSidePlate.Text = "D0100'Side Plate"
        Me.TabPageSidePlate.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.TabControl1)
        Me._TabFrames_0.Controls.Add(Me.GroupBottom)
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.txtPlateThickness)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(616, 439)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageHoleGroup1)
        Me.TabControl1.Controls.Add(Me.TabPageHoleGroup2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 214)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 211)
        Me.TabControl1.TabIndex = 13
        '
        'TabPageHoleGroup1
        '
        Me.TabPageHoleGroup1.Controls.Add(Me.Label48)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtInsidePlThickness1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label49)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtOutsidePlThickness1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label36)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtVerHoleCount1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label37)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtHorHoleCount1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label38)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtVerDist1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label39)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtVerSideDist1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label40)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtHorDist1)
        Me.TabPageHoleGroup1.Controls.Add(Me.Label41)
        Me.TabPageHoleGroup1.Controls.Add(Me.txtHorSideDist1)
        Me.TabPageHoleGroup1.Location = New System.Drawing.Point(4, 29)
        Me.TabPageHoleGroup1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHoleGroup1.Name = "TabPageHoleGroup1"
        Me.TabPageHoleGroup1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHoleGroup1.Size = New System.Drawing.Size(589, 178)
        Me.TabPageHoleGroup1.TabIndex = 0
        Me.TabPageHoleGroup1.Text = "D0111'Hole Group 1"
        Me.TabPageHoleGroup1.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(297, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(152, 20)
        Me.Label48.TabIndex = 141
        Me.Label48.Text = "D0120'Inside PL thk"
        '
        'txtInsidePlThickness1
        '
        Me.txtInsidePlThickness1.AcceptsReturn = True
        Me.txtInsidePlThickness1.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsidePlThickness1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsidePlThickness1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsidePlThickness1.Location = New System.Drawing.Point(448, 13)
        Me.txtInsidePlThickness1.MaxLength = 0
        Me.txtInsidePlThickness1.Name = "txtInsidePlThickness1"
        Me.txtInsidePlThickness1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsidePlThickness1.Size = New System.Drawing.Size(84, 26)
        Me.txtInsidePlThickness1.TabIndex = 140
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(40, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(164, 20)
        Me.Label49.TabIndex = 139
        Me.Label49.Text = "D0119'Outside PL thk"
        '
        'txtOutsidePlThickness1
        '
        Me.txtOutsidePlThickness1.AcceptsReturn = True
        Me.txtOutsidePlThickness1.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutsidePlThickness1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutsidePlThickness1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutsidePlThickness1.Location = New System.Drawing.Point(192, 13)
        Me.txtOutsidePlThickness1.MaxLength = 0
        Me.txtOutsidePlThickness1.Name = "txtOutsidePlThickness1"
        Me.txtOutsidePlThickness1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOutsidePlThickness1.Size = New System.Drawing.Size(84, 26)
        Me.txtOutsidePlThickness1.TabIndex = 138
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(297, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(132, 20)
        Me.Label36.TabIndex = 137
        Me.Label36.Text = "D0117'Ver Count"
        '
        'txtVerHoleCount1
        '
        Me.txtVerHoleCount1.AcceptsReturn = True
        Me.txtVerHoleCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleCount1.Location = New System.Drawing.Point(448, 133)
        Me.txtVerHoleCount1.MaxLength = 0
        Me.txtVerHoleCount1.Name = "txtVerHoleCount1"
        Me.txtVerHoleCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleCount1.Size = New System.Drawing.Size(84, 26)
        Me.txtVerHoleCount1.TabIndex = 136
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(40, 136)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(133, 20)
        Me.Label37.TabIndex = 135
        Me.Label37.Text = "D0114'Hor Count"
        '
        'txtHorHoleCount1
        '
        Me.txtHorHoleCount1.AcceptsReturn = True
        Me.txtHorHoleCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleCount1.Location = New System.Drawing.Point(192, 133)
        Me.txtHorHoleCount1.MaxLength = 0
        Me.txtHorHoleCount1.Name = "txtHorHoleCount1"
        Me.txtHorHoleCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleCount1.Size = New System.Drawing.Size(84, 26)
        Me.txtHorHoleCount1.TabIndex = 134
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(297, 96)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(117, 20)
        Me.Label38.TabIndex = 133
        Me.Label38.Text = "D0116'Ver Dist"
        '
        'txtVerDist1
        '
        Me.txtVerDist1.AcceptsReturn = True
        Me.txtVerDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerDist1.Location = New System.Drawing.Point(448, 93)
        Me.txtVerDist1.MaxLength = 0
        Me.txtVerDist1.Name = "txtVerDist1"
        Me.txtVerDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtVerDist1.TabIndex = 132
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(297, 56)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(153, 20)
        Me.Label39.TabIndex = 131
        Me.Label39.Text = "D0115'Ver Side Dist"
        '
        'txtVerSideDist1
        '
        Me.txtVerSideDist1.AcceptsReturn = True
        Me.txtVerSideDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerSideDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerSideDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerSideDist1.Location = New System.Drawing.Point(448, 53)
        Me.txtVerSideDist1.MaxLength = 0
        Me.txtVerSideDist1.Name = "txtVerSideDist1"
        Me.txtVerSideDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerSideDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtVerSideDist1.TabIndex = 130
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(40, 96)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(118, 20)
        Me.Label40.TabIndex = 129
        Me.Label40.Text = "D0113'Hor Dist"
        '
        'txtHorDist1
        '
        Me.txtHorDist1.AcceptsReturn = True
        Me.txtHorDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorDist1.Location = New System.Drawing.Point(192, 93)
        Me.txtHorDist1.MaxLength = 0
        Me.txtHorDist1.Name = "txtHorDist1"
        Me.txtHorDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtHorDist1.TabIndex = 128
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(40, 56)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(154, 20)
        Me.Label41.TabIndex = 127
        Me.Label41.Text = "D0112'Hor Side Dist"
        '
        'txtHorSideDist1
        '
        Me.txtHorSideDist1.AcceptsReturn = True
        Me.txtHorSideDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorSideDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorSideDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorSideDist1.Location = New System.Drawing.Point(192, 53)
        Me.txtHorSideDist1.MaxLength = 0
        Me.txtHorSideDist1.Name = "txtHorSideDist1"
        Me.txtHorSideDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorSideDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtHorSideDist1.TabIndex = 126
        '
        'TabPageHoleGroup2
        '
        Me.TabPageHoleGroup2.Controls.Add(Me.Label50)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtInsidePlThickness2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label51)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtOutsidePlThickness2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label42)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtVerHoleCount2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label43)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtHorHoleCount2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label44)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtVerDist2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label45)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtVerSideDist2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label46)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtHorDist2)
        Me.TabPageHoleGroup2.Controls.Add(Me.Label47)
        Me.TabPageHoleGroup2.Controls.Add(Me.txtHorSideDist2)
        Me.TabPageHoleGroup2.Location = New System.Drawing.Point(4, 29)
        Me.TabPageHoleGroup2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHoleGroup2.Name = "TabPageHoleGroup2"
        Me.TabPageHoleGroup2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHoleGroup2.Size = New System.Drawing.Size(589, 178)
        Me.TabPageHoleGroup2.TabIndex = 1
        Me.TabPageHoleGroup2.Text = "D0118'Hole Group 2"
        Me.TabPageHoleGroup2.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(297, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(152, 20)
        Me.Label50.TabIndex = 153
        Me.Label50.Text = "D0120'Inside PL thk"
        '
        'txtInsidePlThickness2
        '
        Me.txtInsidePlThickness2.AcceptsReturn = True
        Me.txtInsidePlThickness2.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsidePlThickness2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsidePlThickness2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsidePlThickness2.Location = New System.Drawing.Point(448, 13)
        Me.txtInsidePlThickness2.MaxLength = 0
        Me.txtInsidePlThickness2.Name = "txtInsidePlThickness2"
        Me.txtInsidePlThickness2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsidePlThickness2.Size = New System.Drawing.Size(84, 26)
        Me.txtInsidePlThickness2.TabIndex = 152
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Location = New System.Drawing.Point(40, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(164, 20)
        Me.Label51.TabIndex = 151
        Me.Label51.Text = "D0119'Outside PL thk"
        '
        'txtOutsidePlThickness2
        '
        Me.txtOutsidePlThickness2.AcceptsReturn = True
        Me.txtOutsidePlThickness2.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutsidePlThickness2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutsidePlThickness2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutsidePlThickness2.Location = New System.Drawing.Point(192, 13)
        Me.txtOutsidePlThickness2.MaxLength = 0
        Me.txtOutsidePlThickness2.Name = "txtOutsidePlThickness2"
        Me.txtOutsidePlThickness2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOutsidePlThickness2.Size = New System.Drawing.Size(84, 26)
        Me.txtOutsidePlThickness2.TabIndex = 150
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(297, 136)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(132, 20)
        Me.Label42.TabIndex = 149
        Me.Label42.Text = "D0117'Ver Count"
        '
        'txtVerHoleCount2
        '
        Me.txtVerHoleCount2.AcceptsReturn = True
        Me.txtVerHoleCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleCount2.Location = New System.Drawing.Point(448, 133)
        Me.txtVerHoleCount2.MaxLength = 0
        Me.txtVerHoleCount2.Name = "txtVerHoleCount2"
        Me.txtVerHoleCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleCount2.Size = New System.Drawing.Size(84, 26)
        Me.txtVerHoleCount2.TabIndex = 148
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(40, 136)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(133, 20)
        Me.Label43.TabIndex = 147
        Me.Label43.Text = "D0114'Hor Count"
        '
        'txtHorHoleCount2
        '
        Me.txtHorHoleCount2.AcceptsReturn = True
        Me.txtHorHoleCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleCount2.Location = New System.Drawing.Point(192, 133)
        Me.txtHorHoleCount2.MaxLength = 0
        Me.txtHorHoleCount2.Name = "txtHorHoleCount2"
        Me.txtHorHoleCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleCount2.Size = New System.Drawing.Size(84, 26)
        Me.txtHorHoleCount2.TabIndex = 146
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(297, 96)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(117, 20)
        Me.Label44.TabIndex = 145
        Me.Label44.Text = "D0116'Ver Dist"
        '
        'txtVerDist2
        '
        Me.txtVerDist2.AcceptsReturn = True
        Me.txtVerDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerDist2.Location = New System.Drawing.Point(448, 93)
        Me.txtVerDist2.MaxLength = 0
        Me.txtVerDist2.Name = "txtVerDist2"
        Me.txtVerDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtVerDist2.TabIndex = 144
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(297, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(153, 20)
        Me.Label45.TabIndex = 143
        Me.Label45.Text = "D0115'Ver Side Dist"
        '
        'txtVerSideDist2
        '
        Me.txtVerSideDist2.AcceptsReturn = True
        Me.txtVerSideDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerSideDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerSideDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerSideDist2.Location = New System.Drawing.Point(448, 53)
        Me.txtVerSideDist2.MaxLength = 0
        Me.txtVerSideDist2.Name = "txtVerSideDist2"
        Me.txtVerSideDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerSideDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtVerSideDist2.TabIndex = 142
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(40, 96)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(118, 20)
        Me.Label46.TabIndex = 141
        Me.Label46.Text = "D0113'Hor Dist"
        '
        'txtHorDist2
        '
        Me.txtHorDist2.AcceptsReturn = True
        Me.txtHorDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorDist2.Location = New System.Drawing.Point(192, 93)
        Me.txtHorDist2.MaxLength = 0
        Me.txtHorDist2.Name = "txtHorDist2"
        Me.txtHorDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtHorDist2.TabIndex = 140
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(40, 56)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(154, 20)
        Me.Label47.TabIndex = 139
        Me.Label47.Text = "D0112'Hor Side Dist"
        '
        'txtHorSideDist2
        '
        Me.txtHorSideDist2.AcceptsReturn = True
        Me.txtHorSideDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorSideDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorSideDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorSideDist2.Location = New System.Drawing.Point(192, 53)
        Me.txtHorSideDist2.MaxLength = 0
        Me.txtHorSideDist2.Name = "txtHorSideDist2"
        Me.txtHorSideDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorSideDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtHorSideDist2.TabIndex = 138
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
        Me.GroupBottom.Location = New System.Drawing.Point(8, 55)
        Me.GroupBottom.Name = "GroupBottom"
        Me.GroupBottom.Size = New System.Drawing.Size(598, 151)
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
        Me.Label10.Location = New System.Drawing.Point(297, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "D0109'Angle 4"
        '
        'txtAngle4
        '
        Me.txtAngle4.AcceptsReturn = True
        Me.txtAngle4.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle4.Location = New System.Drawing.Point(448, 111)
        Me.txtAngle4.MaxLength = 0
        Me.txtAngle4.Name = "txtAngle4"
        Me.txtAngle4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle4.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle4.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(40, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "D0107'Angle 3"
        '
        'txtAngle3
        '
        Me.txtAngle3.AcceptsReturn = True
        Me.txtAngle3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle3.Location = New System.Drawing.Point(192, 111)
        Me.txtAngle3.MaxLength = 0
        Me.txtAngle3.Name = "txtAngle3"
        Me.txtAngle3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle3.Size = New System.Drawing.Size(84, 26)
        Me.txtAngle3.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(297, 75)
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
        Me.txtAngle2.Location = New System.Drawing.Point(448, 69)
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
        Me.txtFillet2.Location = New System.Drawing.Point(448, 28)
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
        Me.Label2.Location = New System.Drawing.Point(40, 75)
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
        Me.txtAngle1.Location = New System.Drawing.Point(192, 69)
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
        Me.txtFillet1.Location = New System.Drawing.Point(192, 28)
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
        Me.lblThick.Location = New System.Drawing.Point(22, 25)
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
        Me.txtPlateThickness.Location = New System.Drawing.Point(192, 22)
        Me.txtPlateThickness.MaxLength = 0
        Me.txtPlateThickness.Name = "txtPlateThickness"
        Me.txtPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtPlateThickness.TabIndex = 76
        '
        'TabPageConnPlate1
        '
        Me.TabPageConnPlate1.Controls.Add(Me.Label22)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1Thickness)
        Me.TabPageConnPlate1.Controls.Add(Me.Label21)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1Angle)
        Me.TabPageConnPlate1.Controls.Add(Me.Label20)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1innerWebDist)
        Me.TabPageConnPlate1.Controls.Add(Me.Label19)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1innerWebCount)
        Me.TabPageConnPlate1.Controls.Add(Me.Label18)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1innerWebThickness)
        Me.TabPageConnPlate1.Controls.Add(Me.Label17)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1InnerWebHeight)
        Me.TabPageConnPlate1.Controls.Add(Me.Label16)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1Width)
        Me.TabPageConnPlate1.Controls.Add(Me.Label15)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1Length)
        Me.TabPageConnPlate1.Controls.Add(Me.Label13)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1Radius)
        Me.TabPageConnPlate1.Controls.Add(Me.Label11)
        Me.TabPageConnPlate1.Controls.Add(Me.txtConnect1SideDistance)
        Me.TabPageConnPlate1.Location = New System.Drawing.Point(4, 29)
        Me.TabPageConnPlate1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageConnPlate1.Name = "TabPageConnPlate1"
        Me.TabPageConnPlate1.Size = New System.Drawing.Size(616, 439)
        Me.TabPageConnPlate1.TabIndex = 12
        Me.TabPageConnPlate1.Text = "D0500'Connect Plate 1"
        Me.TabPageConnPlate1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(14, 220)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(131, 20)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "D0506'Thickness"
        '
        'txtConnect1Thickness
        '
        Me.txtConnect1Thickness.AcceptsReturn = True
        Me.txtConnect1Thickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Thickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Thickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Thickness.Location = New System.Drawing.Point(170, 217)
        Me.txtConnect1Thickness.MaxLength = 0
        Me.txtConnect1Thickness.Name = "txtConnect1Thickness"
        Me.txtConnect1Thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Thickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Thickness.TabIndex = 122
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(14, 274)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "D0507'Angle"
        '
        'txtConnect1Angle
        '
        Me.txtConnect1Angle.AcceptsReturn = True
        Me.txtConnect1Angle.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Angle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Angle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Angle.Location = New System.Drawing.Point(170, 271)
        Me.txtConnect1Angle.MaxLength = 0
        Me.txtConnect1Angle.Name = "txtConnect1Angle"
        Me.txtConnect1Angle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Angle.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Angle.TabIndex = 120
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(332, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(161, 20)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "D0511'Web Side Dist"
        '
        'txtConnect1innerWebDist
        '
        Me.txtConnect1innerWebDist.AcceptsReturn = True
        Me.txtConnect1innerWebDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebDist.Location = New System.Drawing.Point(488, 157)
        Me.txtConnect1innerWebDist.MaxLength = 0
        Me.txtConnect1innerWebDist.Name = "txtConnect1innerWebDist"
        Me.txtConnect1innerWebDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebDist.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1innerWebDist.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(332, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(140, 20)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "D0510'Web Count"
        '
        'txtConnect1innerWebCount
        '
        Me.txtConnect1innerWebCount.AcceptsReturn = True
        Me.txtConnect1innerWebCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebCount.Location = New System.Drawing.Point(488, 109)
        Me.txtConnect1innerWebCount.MaxLength = 0
        Me.txtConnect1innerWebCount.Name = "txtConnect1innerWebCount"
        Me.txtConnect1innerWebCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebCount.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1innerWebCount.TabIndex = 116
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(332, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(168, 20)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "D0509'Web Thickness"
        '
        'txtConnect1innerWebThickness
        '
        Me.txtConnect1innerWebThickness.AcceptsReturn = True
        Me.txtConnect1innerWebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1innerWebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1innerWebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1innerWebThickness.Location = New System.Drawing.Point(488, 62)
        Me.txtConnect1innerWebThickness.MaxLength = 0
        Me.txtConnect1innerWebThickness.Name = "txtConnect1innerWebThickness"
        Me.txtConnect1innerWebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1innerWebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1innerWebThickness.TabIndex = 114
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(332, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(144, 20)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "D0508'Web Height"
        '
        'txtConnect1InnerWebHeight
        '
        Me.txtConnect1InnerWebHeight.AcceptsReturn = True
        Me.txtConnect1InnerWebHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1InnerWebHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1InnerWebHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1InnerWebHeight.Location = New System.Drawing.Point(488, 15)
        Me.txtConnect1InnerWebHeight.MaxLength = 0
        Me.txtConnect1InnerWebHeight.Name = "txtConnect1InnerWebHeight"
        Me.txtConnect1InnerWebHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1InnerWebHeight.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1InnerWebHeight.TabIndex = 112
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(14, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(101, 20)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "D0505'Width"
        '
        'txtConnect1Width
        '
        Me.txtConnect1Width.AcceptsReturn = True
        Me.txtConnect1Width.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Width.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Width.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Width.Location = New System.Drawing.Point(170, 160)
        Me.txtConnect1Width.MaxLength = 0
        Me.txtConnect1Width.Name = "txtConnect1Width"
        Me.txtConnect1Width.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Width.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Width.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(14, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "D0504'Length"
        '
        'txtConnect1Length
        '
        Me.txtConnect1Length.AcceptsReturn = True
        Me.txtConnect1Length.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Length.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Length.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Length.Location = New System.Drawing.Point(170, 109)
        Me.txtConnect1Length.MaxLength = 0
        Me.txtConnect1Length.Name = "txtConnect1Length"
        Me.txtConnect1Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Length.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Length.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(14, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(110, 20)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "D0502'Radius"
        '
        'txtConnect1Radius
        '
        Me.txtConnect1Radius.AcceptsReturn = True
        Me.txtConnect1Radius.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Radius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Radius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Radius.Location = New System.Drawing.Point(170, 58)
        Me.txtConnect1Radius.MaxLength = 0
        Me.txtConnect1Radius.Name = "txtConnect1Radius"
        Me.txtConnect1Radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1Radius.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1Radius.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(14, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "D0501'Dist"
        '
        'txtConnect1SideDistance
        '
        Me.txtConnect1SideDistance.AcceptsReturn = True
        Me.txtConnect1SideDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1SideDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1SideDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1SideDistance.Location = New System.Drawing.Point(170, 12)
        Me.txtConnect1SideDistance.MaxLength = 0
        Me.txtConnect1SideDistance.Name = "txtConnect1SideDistance"
        Me.txtConnect1SideDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1SideDistance.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1SideDistance.TabIndex = 102
        '
        'TabPageConnPlate2
        '
        Me.TabPageConnPlate2.Controls.Add(Me.Label23)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2Thickness)
        Me.TabPageConnPlate2.Controls.Add(Me.Label24)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2Angle)
        Me.TabPageConnPlate2.Controls.Add(Me.Label25)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2innerWebDist)
        Me.TabPageConnPlate2.Controls.Add(Me.Label26)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2innerWebCount)
        Me.TabPageConnPlate2.Controls.Add(Me.Label27)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2innerWebThickness)
        Me.TabPageConnPlate2.Controls.Add(Me.Label28)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2InnerWebHeight)
        Me.TabPageConnPlate2.Controls.Add(Me.Label29)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2Width)
        Me.TabPageConnPlate2.Controls.Add(Me.Label30)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2Length)
        Me.TabPageConnPlate2.Controls.Add(Me.Label32)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2Radius)
        Me.TabPageConnPlate2.Controls.Add(Me.Label33)
        Me.TabPageConnPlate2.Controls.Add(Me.txtConnect2SideDistance)
        Me.TabPageConnPlate2.Location = New System.Drawing.Point(4, 29)
        Me.TabPageConnPlate2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageConnPlate2.Name = "TabPageConnPlate2"
        Me.TabPageConnPlate2.Size = New System.Drawing.Size(616, 439)
        Me.TabPageConnPlate2.TabIndex = 13
        Me.TabPageConnPlate2.Text = "D0600'Connect Plate 2"
        Me.TabPageConnPlate2.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(14, 220)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(131, 20)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "D0506'Thickness"
        '
        'txtConnect2Thickness
        '
        Me.txtConnect2Thickness.AcceptsReturn = True
        Me.txtConnect2Thickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Thickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Thickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Thickness.Location = New System.Drawing.Point(170, 217)
        Me.txtConnect2Thickness.MaxLength = 0
        Me.txtConnect2Thickness.Name = "txtConnect2Thickness"
        Me.txtConnect2Thickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Thickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Thickness.TabIndex = 144
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(14, 274)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(101, 20)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "D0507'Angle"
        '
        'txtConnect2Angle
        '
        Me.txtConnect2Angle.AcceptsReturn = True
        Me.txtConnect2Angle.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Angle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Angle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Angle.Location = New System.Drawing.Point(170, 271)
        Me.txtConnect2Angle.MaxLength = 0
        Me.txtConnect2Angle.Name = "txtConnect2Angle"
        Me.txtConnect2Angle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Angle.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Angle.TabIndex = 142
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(332, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(161, 20)
        Me.Label25.TabIndex = 141
        Me.Label25.Text = "D0511'Web Side Dist"
        '
        'txtConnect2innerWebDist
        '
        Me.txtConnect2innerWebDist.AcceptsReturn = True
        Me.txtConnect2innerWebDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebDist.Location = New System.Drawing.Point(488, 157)
        Me.txtConnect2innerWebDist.MaxLength = 0
        Me.txtConnect2innerWebDist.Name = "txtConnect2innerWebDist"
        Me.txtConnect2innerWebDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebDist.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2innerWebDist.TabIndex = 140
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(332, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(140, 20)
        Me.Label26.TabIndex = 139
        Me.Label26.Text = "D0510'Web Count"
        '
        'txtConnect2innerWebCount
        '
        Me.txtConnect2innerWebCount.AcceptsReturn = True
        Me.txtConnect2innerWebCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebCount.Location = New System.Drawing.Point(488, 109)
        Me.txtConnect2innerWebCount.MaxLength = 0
        Me.txtConnect2innerWebCount.Name = "txtConnect2innerWebCount"
        Me.txtConnect2innerWebCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebCount.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2innerWebCount.TabIndex = 138
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(332, 65)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(168, 20)
        Me.Label27.TabIndex = 137
        Me.Label27.Text = "D0509'Web Thickness"
        '
        'txtConnect2innerWebThickness
        '
        Me.txtConnect2innerWebThickness.AcceptsReturn = True
        Me.txtConnect2innerWebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2innerWebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2innerWebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2innerWebThickness.Location = New System.Drawing.Point(488, 62)
        Me.txtConnect2innerWebThickness.MaxLength = 0
        Me.txtConnect2innerWebThickness.Name = "txtConnect2innerWebThickness"
        Me.txtConnect2innerWebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2innerWebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2innerWebThickness.TabIndex = 136
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(332, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(144, 20)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "D0508'Web Height"
        '
        'txtConnect2InnerWebHeight
        '
        Me.txtConnect2InnerWebHeight.AcceptsReturn = True
        Me.txtConnect2InnerWebHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2InnerWebHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2InnerWebHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2InnerWebHeight.Location = New System.Drawing.Point(488, 15)
        Me.txtConnect2InnerWebHeight.MaxLength = 0
        Me.txtConnect2InnerWebHeight.Name = "txtConnect2InnerWebHeight"
        Me.txtConnect2InnerWebHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2InnerWebHeight.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2InnerWebHeight.TabIndex = 134
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(14, 163)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(101, 20)
        Me.Label29.TabIndex = 133
        Me.Label29.Text = "D0505'Width"
        '
        'txtConnect2Width
        '
        Me.txtConnect2Width.AcceptsReturn = True
        Me.txtConnect2Width.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Width.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Width.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Width.Location = New System.Drawing.Point(170, 160)
        Me.txtConnect2Width.MaxLength = 0
        Me.txtConnect2Width.Name = "txtConnect2Width"
        Me.txtConnect2Width.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Width.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Width.TabIndex = 132
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(14, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(110, 20)
        Me.Label30.TabIndex = 131
        Me.Label30.Text = "D0504'Length"
        '
        'txtConnect2Length
        '
        Me.txtConnect2Length.AcceptsReturn = True
        Me.txtConnect2Length.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Length.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Length.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Length.Location = New System.Drawing.Point(170, 109)
        Me.txtConnect2Length.MaxLength = 0
        Me.txtConnect2Length.Name = "txtConnect2Length"
        Me.txtConnect2Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Length.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Length.TabIndex = 130
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(14, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(110, 20)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "D0502'Radius"
        '
        'txtConnect2Radius
        '
        Me.txtConnect2Radius.AcceptsReturn = True
        Me.txtConnect2Radius.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Radius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Radius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Radius.Location = New System.Drawing.Point(170, 58)
        Me.txtConnect2Radius.MaxLength = 0
        Me.txtConnect2Radius.Name = "txtConnect2Radius"
        Me.txtConnect2Radius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Radius.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2Radius.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(14, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(88, 20)
        Me.Label33.TabIndex = 125
        Me.Label33.Text = "D0501'Dist"
        '
        'txtConnect2SideDistance
        '
        Me.txtConnect2SideDistance.AcceptsReturn = True
        Me.txtConnect2SideDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2SideDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2SideDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2SideDistance.Location = New System.Drawing.Point(170, 12)
        Me.txtConnect2SideDistance.MaxLength = 0
        Me.txtConnect2SideDistance.Name = "txtConnect2SideDistance"
        Me.txtConnect2SideDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2SideDistance.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2SideDistance.TabIndex = 124
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(484, 492)
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
        Me.ClientSize = New System.Drawing.Size(1040, 558)
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
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.TabPageSidePlate.ResumeLayout(False)
        Me._TabFrames_0.ResumeLayout(False)
        Me._TabFrames_0.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageHoleGroup1.ResumeLayout(False)
        Me.TabPageHoleGroup1.PerformLayout()
        Me.TabPageHoleGroup2.ResumeLayout(False)
        Me.TabPageHoleGroup2.PerformLayout()
        Me.GroupBottom.ResumeLayout(False)
        Me.GroupBottom.PerformLayout()
        Me.TabPageConnPlate1.ResumeLayout(False)
        Me.TabPageConnPlate1.PerformLayout()
        Me.TabPageConnPlate2.ResumeLayout(False)
        Me.TabPageConnPlate2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPageSidePlate As System.Windows.Forms.TabPage
    Public WithEvents _TabFrames_0 As System.Windows.Forms.GroupBox
    Public WithEvents txtPlateThickness As System.Windows.Forms.TextBox
    Public WithEvents lblThick As System.Windows.Forms.Label
    Friend WithEvents TabPageGeneral As System.Windows.Forms.TabPage
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
    Friend WithEvents TabPageConnPlate1 As Windows.Forms.TabPage
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
    Public WithEvents Label13 As Windows.Forms.Label
    Public WithEvents txtConnect1Radius As Windows.Forms.TextBox
    Friend WithEvents TabPageConnPlate2 As Windows.Forms.TabPage
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
    Public WithEvents Label32 As Windows.Forms.Label
    Public WithEvents txtConnect2Radius As Windows.Forms.TextBox
    Public WithEvents Label33 As Windows.Forms.Label
    Public WithEvents txtConnect2SideDistance As Windows.Forms.TextBox
    Public WithEvents Label14 As Windows.Forms.Label
    Public WithEvents txtConnect1Gap As Windows.Forms.TextBox
    Public WithEvents Label31 As Windows.Forms.Label
    Public WithEvents txtConnect2Gap As Windows.Forms.TextBox
    Public WithEvents Label34 As Windows.Forms.Label
    Public WithEvents txtConnect1WebThickness As Windows.Forms.TextBox
    Public WithEvents Label35 As Windows.Forms.Label
    Public WithEvents txtConnect2WebThickness As Windows.Forms.TextBox
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPageHoleGroup1 As Windows.Forms.TabPage
    Public WithEvents Label36 As Windows.Forms.Label
    Public WithEvents txtVerHoleCount1 As Windows.Forms.TextBox
    Public WithEvents Label37 As Windows.Forms.Label
    Public WithEvents txtHorHoleCount1 As Windows.Forms.TextBox
    Public WithEvents Label38 As Windows.Forms.Label
    Public WithEvents txtVerDist1 As Windows.Forms.TextBox
    Public WithEvents Label39 As Windows.Forms.Label
    Public WithEvents txtVerSideDist1 As Windows.Forms.TextBox
    Public WithEvents Label40 As Windows.Forms.Label
    Public WithEvents txtHorDist1 As Windows.Forms.TextBox
    Public WithEvents Label41 As Windows.Forms.Label
    Public WithEvents txtHorSideDist1 As Windows.Forms.TextBox
    Friend WithEvents TabPageHoleGroup2 As Windows.Forms.TabPage
    Public WithEvents Label42 As Windows.Forms.Label
    Public WithEvents txtVerHoleCount2 As Windows.Forms.TextBox
    Public WithEvents Label43 As Windows.Forms.Label
    Public WithEvents txtHorHoleCount2 As Windows.Forms.TextBox
    Public WithEvents Label44 As Windows.Forms.Label
    Public WithEvents txtVerDist2 As Windows.Forms.TextBox
    Public WithEvents Label45 As Windows.Forms.Label
    Public WithEvents txtVerSideDist2 As Windows.Forms.TextBox
    Public WithEvents Label46 As Windows.Forms.Label
    Public WithEvents txtHorDist2 As Windows.Forms.TextBox
    Public WithEvents Label47 As Windows.Forms.Label
    Public WithEvents txtHorSideDist2 As Windows.Forms.TextBox
    Public WithEvents Label48 As Windows.Forms.Label
    Public WithEvents txtInsidePlThickness1 As Windows.Forms.TextBox
    Public WithEvents Label49 As Windows.Forms.Label
    Public WithEvents txtOutsidePlThickness1 As Windows.Forms.TextBox
    Public WithEvents Label50 As Windows.Forms.Label
    Public WithEvents txtInsidePlThickness2 As Windows.Forms.TextBox
    Public WithEvents Label51 As Windows.Forms.Label
    Public WithEvents txtOutsidePlThickness2 As Windows.Forms.TextBox
#End Region
End Class