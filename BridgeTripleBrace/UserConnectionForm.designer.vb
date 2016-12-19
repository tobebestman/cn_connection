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
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtColumnCutBack = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtConnect1WebThickness = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.txtConnect2WebThickness = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtHoleDia = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtConnect1FlangeThickness = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtConnect2FlangeThickness = New System.Windows.Forms.TextBox()
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
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
        Me.TabPageWebConnPlate1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateInnerVerEdgeDist1 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateThickness1 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateVerCount1 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateHorCount1 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateHorEdgeDist1 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateVerEdgeDist1 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateVerDist1 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateHorDist1 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoltGroupHorSideDist1 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtBoltGroupSpan1 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TabPageWebConnPlate2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateInnerVerEdgeDist2 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateThickness2 = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateVerCount2 = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateHorCount2 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateHorEdgeDist2 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateVerEdgeDist2 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtWebConnectPlateVerDist2 = New System.Windows.Forms.TextBox()
        Me.txtWebConnectPlateHorDist2 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBoltGroupHorSideDist2 = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtBoltGroupSpan2 = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
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
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBottom.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageHoleGroup1.SuspendLayout()
        Me.TabPageHoleGroup2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPageConnPlate1.SuspendLayout()
        Me.TabPageConnPlate2.SuspendLayout()
        Me.TabPageWebConnPlate1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageWebConnPlate2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGetLengthFromLine
        '
        Me.cmdGetLengthFromLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetLengthFromLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetLengthFromLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetLengthFromLine.Image = CType(resources.GetObject("cmdGetLengthFromLine.Image"), System.Drawing.Image)
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(304, 567)
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
        Me.cmdAccept.Location = New System.Drawing.Point(8, 567)
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
        Me.cmdCancel.Location = New System.Drawing.Point(58, 567)
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(585, 567)
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(536, 567)
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
        Me.cmdHelp.Location = New System.Drawing.Point(108, 567)
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
        Me.cmdClone.Location = New System.Drawing.Point(210, 567)
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
        Me.cmdTemplate.Location = New System.Drawing.Point(159, 567)
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
        Me.picBitmap.Size = New System.Drawing.Size(393, 595)
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
        Me.TabStrip1.Controls.Add(Me.TabPageWebConnPlate1)
        Me.TabStrip1.Controls.Add(Me.TabPageWebConnPlate2)
        Me.TabStrip1.Location = New System.Drawing.Point(6, 14)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(624, 547)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.Label82)
        Me.TabPageGeneral.Controls.Add(Me.TextBox8)
        Me.TabPageGeneral.Controls.Add(Me.Label81)
        Me.TabPageGeneral.Controls.Add(Me.txtColumnCutBack)
        Me.TabPageGeneral.Controls.Add(Me.Label71)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect1WebThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label74)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect2WebThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label60)
        Me.TabPageGeneral.Controls.Add(Me.txtHoleDia)
        Me.TabPageGeneral.Controls.Add(Me.Label34)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect1FlangeThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label35)
        Me.TabPageGeneral.Controls.Add(Me.txtConnect2FlangeThickness)
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
        Me.TabPageGeneral.Size = New System.Drawing.Size(616, 514)
        Me.TabPageGeneral.TabIndex = 11
        Me.TabPageGeneral.Text = "D0400'Main"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label82.ForeColor = System.Drawing.Color.Red
        Me.Label82.Location = New System.Drawing.Point(303, 108)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(104, 20)
        Me.Label82.TabIndex = 147
        Me.Label82.Text = "D0514'Gap 3"
        '
        'TextBox8
        '
        Me.TextBox8.AcceptsReturn = True
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox8.Location = New System.Drawing.Point(480, 105)
        Me.TextBox8.MaxLength = 0
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox8.Size = New System.Drawing.Size(84, 26)
        Me.TextBox8.TabIndex = 146
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label81.ForeColor = System.Drawing.Color.Red
        Me.Label81.Location = New System.Drawing.Point(14, 198)
        Me.Label81.Name = "Label81"
        Me.Label81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label81.Size = New System.Drawing.Size(181, 20)
        Me.Label81.TabIndex = 145
        Me.Label81.Text = "D0411'Column Cut back"
        '
        'txtColumnCutBack
        '
        Me.txtColumnCutBack.AcceptsReturn = True
        Me.txtColumnCutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtColumnCutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtColumnCutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtColumnCutBack.Location = New System.Drawing.Point(196, 195)
        Me.txtColumnCutBack.MaxLength = 0
        Me.txtColumnCutBack.Name = "txtColumnCutBack"
        Me.txtColumnCutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtColumnCutBack.Size = New System.Drawing.Size(84, 26)
        Me.txtColumnCutBack.TabIndex = 144
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label71.Location = New System.Drawing.Point(303, 243)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label71.Size = New System.Drawing.Size(200, 20)
        Me.Label71.TabIndex = 143
        Me.Label71.Text = "D0409'Connect Web Thk 1"
        '
        'txtConnect1WebThickness
        '
        Me.txtConnect1WebThickness.AcceptsReturn = True
        Me.txtConnect1WebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1WebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1WebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1WebThickness.Location = New System.Drawing.Point(480, 240)
        Me.txtConnect1WebThickness.MaxLength = 0
        Me.txtConnect1WebThickness.Name = "txtConnect1WebThickness"
        Me.txtConnect1WebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1WebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1WebThickness.TabIndex = 142
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(303, 288)
        Me.Label74.Name = "Label74"
        Me.Label74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label74.Size = New System.Drawing.Size(200, 20)
        Me.Label74.TabIndex = 141
        Me.Label74.Text = "D0410'Connect Web Thk 2"
        '
        'txtConnect2WebThickness
        '
        Me.txtConnect2WebThickness.AcceptsReturn = True
        Me.txtConnect2WebThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2WebThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2WebThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2WebThickness.Location = New System.Drawing.Point(480, 285)
        Me.txtConnect2WebThickness.MaxLength = 0
        Me.txtConnect2WebThickness.Name = "txtConnect2WebThickness"
        Me.txtConnect2WebThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2WebThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2WebThickness.TabIndex = 140
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(14, 288)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(121, 20)
        Me.Label60.TabIndex = 139
        Me.Label60.Text = "D0408'Hole Dia"
        '
        'txtHoleDia
        '
        Me.txtHoleDia.AcceptsReturn = True
        Me.txtHoleDia.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleDia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleDia.Location = New System.Drawing.Point(196, 285)
        Me.txtHoleDia.MaxLength = 0
        Me.txtHoleDia.Name = "txtHoleDia"
        Me.txtHoleDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleDia.Size = New System.Drawing.Size(84, 26)
        Me.txtHoleDia.TabIndex = 138
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(303, 153)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(216, 20)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "D0406'Connect Flange Thk 1"
        '
        'txtConnect1FlangeThickness
        '
        Me.txtConnect1FlangeThickness.AcceptsReturn = True
        Me.txtConnect1FlangeThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1FlangeThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1FlangeThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1FlangeThickness.Location = New System.Drawing.Point(480, 150)
        Me.txtConnect1FlangeThickness.MaxLength = 0
        Me.txtConnect1FlangeThickness.Name = "txtConnect1FlangeThickness"
        Me.txtConnect1FlangeThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect1FlangeThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect1FlangeThickness.TabIndex = 136
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(303, 198)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(216, 20)
        Me.Label35.TabIndex = 135
        Me.Label35.Text = "D0407'Connect Flange Thk 2"
        '
        'txtConnect2FlangeThickness
        '
        Me.txtConnect2FlangeThickness.AcceptsReturn = True
        Me.txtConnect2FlangeThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2FlangeThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2FlangeThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2FlangeThickness.Location = New System.Drawing.Point(480, 195)
        Me.txtConnect2FlangeThickness.MaxLength = 0
        Me.txtConnect2FlangeThickness.Name = "txtConnect2FlangeThickness"
        Me.txtConnect2FlangeThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2FlangeThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnect2FlangeThickness.TabIndex = 134
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
        Me.Label14.Size = New System.Drawing.Size(104, 20)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "D0503'Gap 1"
        '
        'txtConnect1Gap
        '
        Me.txtConnect1Gap.AcceptsReturn = True
        Me.txtConnect1Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect1Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect1Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect1Gap.Location = New System.Drawing.Point(480, 15)
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
        Me.Label31.Location = New System.Drawing.Point(303, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(104, 20)
        Me.Label31.TabIndex = 131
        Me.Label31.Text = "D0513'Gap 2"
        '
        'txtConnect2Gap
        '
        Me.txtConnect2Gap.AcceptsReturn = True
        Me.txtConnect2Gap.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnect2Gap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnect2Gap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnect2Gap.Location = New System.Drawing.Point(480, 60)
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
        Me.Label9.Location = New System.Drawing.Point(14, 243)
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
        Me.txtMainChordPlateThickness.Location = New System.Drawing.Point(196, 240)
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
        Me.Label8.Location = New System.Drawing.Point(14, 63)
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
        Me.txtSupport2CutBack.Location = New System.Drawing.Point(196, 60)
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
        Me.txtSupport1CutBack.Location = New System.Drawing.Point(196, 15)
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
        Me.Label3.Location = New System.Drawing.Point(14, 153)
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
        Me.txtConnectCutBack2.Location = New System.Drawing.Point(196, 150)
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
        Me.Label4.Location = New System.Drawing.Point(10, 108)
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
        Me.txtConnectCutBack1.Location = New System.Drawing.Point(196, 105)
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
        Me.TabPageSidePlate.Size = New System.Drawing.Size(616, 514)
        Me.TabPageSidePlate.TabIndex = 0
        Me.TabPageSidePlate.Text = "D0100'Side Plate"
        Me.TabPageSidePlate.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.TabControl2)
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.txtPlateThickness)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(616, 514)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(3, 63)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(607, 445)
        Me.TabControl2.TabIndex = 101
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBottom)
        Me.TabPage1.Controls.Add(Me.TabControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(599, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "D0121'Brace Member"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.GroupBottom.Location = New System.Drawing.Point(10, 6)
        Me.GroupBottom.Name = "GroupBottom"
        Me.GroupBottom.Size = New System.Drawing.Size(579, 151)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageHoleGroup1)
        Me.TabControl1.Controls.Add(Me.TabPageHoleGroup2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 184)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(580, 211)
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
        Me.TabPageHoleGroup1.Size = New System.Drawing.Size(572, 178)
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
        Me.Label48.Location = New System.Drawing.Point(297, 15)
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
        Me.txtInsidePlThickness1.Location = New System.Drawing.Point(448, 12)
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
        Me.Label49.Location = New System.Drawing.Point(40, 15)
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
        Me.txtOutsidePlThickness1.Location = New System.Drawing.Point(192, 12)
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
        Me.Label36.Location = New System.Drawing.Point(297, 135)
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
        Me.txtVerHoleCount1.Location = New System.Drawing.Point(448, 132)
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
        Me.Label37.Location = New System.Drawing.Point(40, 135)
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
        Me.txtHorHoleCount1.Location = New System.Drawing.Point(192, 132)
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
        Me.Label38.Location = New System.Drawing.Point(297, 95)
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
        Me.txtVerDist1.Location = New System.Drawing.Point(448, 92)
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
        Me.Label39.Location = New System.Drawing.Point(297, 55)
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
        Me.txtVerSideDist1.Location = New System.Drawing.Point(448, 52)
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
        Me.Label40.Location = New System.Drawing.Point(40, 95)
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
        Me.txtHorDist1.Location = New System.Drawing.Point(192, 92)
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
        Me.Label41.Location = New System.Drawing.Point(40, 55)
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
        Me.txtHorSideDist1.Location = New System.Drawing.Point(192, 52)
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
        Me.TabPageHoleGroup2.Size = New System.Drawing.Size(572, 178)
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
        Me.Label50.Location = New System.Drawing.Point(297, 15)
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
        Me.txtInsidePlThickness2.Location = New System.Drawing.Point(448, 12)
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
        Me.Label51.Location = New System.Drawing.Point(40, 15)
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
        Me.txtOutsidePlThickness2.Location = New System.Drawing.Point(192, 12)
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
        Me.Label42.Location = New System.Drawing.Point(297, 135)
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
        Me.txtVerHoleCount2.Location = New System.Drawing.Point(448, 132)
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
        Me.Label43.Location = New System.Drawing.Point(40, 135)
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
        Me.txtHorHoleCount2.Location = New System.Drawing.Point(192, 132)
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
        Me.Label44.Location = New System.Drawing.Point(297, 95)
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
        Me.txtVerDist2.Location = New System.Drawing.Point(448, 92)
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
        Me.Label45.Location = New System.Drawing.Point(297, 55)
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
        Me.txtVerSideDist2.Location = New System.Drawing.Point(448, 52)
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
        Me.Label46.Location = New System.Drawing.Point(40, 95)
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
        Me.txtHorDist2.Location = New System.Drawing.Point(192, 92)
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
        Me.Label47.Location = New System.Drawing.Point(40, 55)
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
        Me.txtHorSideDist2.Location = New System.Drawing.Point(192, 52)
        Me.txtHorSideDist2.MaxLength = 0
        Me.txtHorSideDist2.Name = "txtHorSideDist2"
        Me.txtHorSideDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorSideDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtHorSideDist2.TabIndex = 138
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(599, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "D0122'Column"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label75)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label76)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.Label77)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.Label78)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.Label79)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label80)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(579, 155)
        Me.GroupBox5.TabIndex = 101
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "D0123'Top"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label75.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label75.Location = New System.Drawing.Point(297, 117)
        Me.Label75.Name = "Label75"
        Me.Label75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label75.Size = New System.Drawing.Size(114, 20)
        Me.Label75.TabIndex = 113
        Me.Label75.Text = "D0109'Angle 4"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(448, 111)
        Me.TextBox1.MaxLength = 0
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(84, 26)
        Me.TextBox1.TabIndex = 112
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label76.Location = New System.Drawing.Point(40, 117)
        Me.Label76.Name = "Label76"
        Me.Label76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label76.Size = New System.Drawing.Size(114, 20)
        Me.Label76.TabIndex = 109
        Me.Label76.Text = "D0107'Angle 3"
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(192, 111)
        Me.TextBox2.MaxLength = 0
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(84, 26)
        Me.TextBox2.TabIndex = 108
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label77.Location = New System.Drawing.Point(297, 75)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label77.Size = New System.Drawing.Size(114, 20)
        Me.Label77.TabIndex = 107
        Me.Label77.Text = "D0105'Angle 2"
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(448, 69)
        Me.TextBox3.MaxLength = 0
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(84, 26)
        Me.TextBox3.TabIndex = 106
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label78.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label78.Location = New System.Drawing.Point(297, 34)
        Me.Label78.Name = "Label78"
        Me.Label78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label78.Size = New System.Drawing.Size(106, 20)
        Me.Label78.TabIndex = 105
        Me.Label78.Text = "D0104'Fillet 2"
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox4.Location = New System.Drawing.Point(448, 28)
        Me.TextBox4.MaxLength = 0
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(84, 26)
        Me.TextBox4.TabIndex = 104
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label79.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label79.Location = New System.Drawing.Point(40, 75)
        Me.Label79.Name = "Label79"
        Me.Label79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label79.Size = New System.Drawing.Size(114, 20)
        Me.Label79.TabIndex = 103
        Me.Label79.Text = "D0103'Angle 1"
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox5.Location = New System.Drawing.Point(192, 69)
        Me.TextBox5.MaxLength = 0
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(84, 26)
        Me.TextBox5.TabIndex = 102
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label80.Location = New System.Drawing.Point(40, 34)
        Me.Label80.Name = "Label80"
        Me.Label80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label80.Size = New System.Drawing.Size(106, 20)
        Me.Label80.TabIndex = 101
        Me.Label80.Text = "D0102'Fillet 1"
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox6.Location = New System.Drawing.Point(192, 28)
        Me.TextBox6.MaxLength = 0
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(84, 26)
        Me.TextBox6.TabIndex = 100
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.BackColor = System.Drawing.Color.Transparent
        Me.lblThick.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblThick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThick.Location = New System.Drawing.Point(50, 25)
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
        Me.txtPlateThickness.Location = New System.Drawing.Point(201, 22)
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
        Me.TabPageConnPlate1.Size = New System.Drawing.Size(616, 514)
        Me.TabPageConnPlate1.TabIndex = 12
        Me.TabPageConnPlate1.Text = "D0500'Arc Plate 1"
        Me.TabPageConnPlate1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(316, 65)
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
        Me.txtConnect1Thickness.Location = New System.Drawing.Point(472, 58)
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
        Me.Label21.Location = New System.Drawing.Point(316, 111)
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
        Me.txtConnect1Angle.Location = New System.Drawing.Point(472, 105)
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
        Me.Label20.Location = New System.Drawing.Point(316, 205)
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
        Me.txtConnect1innerWebDist.Location = New System.Drawing.Point(472, 198)
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
        Me.Label19.Location = New System.Drawing.Point(316, 158)
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
        Me.txtConnect1innerWebCount.Location = New System.Drawing.Point(472, 152)
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
        Me.Label18.Location = New System.Drawing.Point(14, 203)
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
        Me.txtConnect1innerWebThickness.Location = New System.Drawing.Point(170, 197)
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
        Me.Label17.Location = New System.Drawing.Point(14, 157)
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
        Me.txtConnect1InnerWebHeight.Location = New System.Drawing.Point(170, 151)
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
        Me.Label16.Location = New System.Drawing.Point(316, 18)
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
        Me.txtConnect1Width.Location = New System.Drawing.Point(472, 12)
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
        Me.Label15.Location = New System.Drawing.Point(14, 111)
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
        Me.txtConnect1Length.Location = New System.Drawing.Point(170, 105)
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
        Me.Label13.Location = New System.Drawing.Point(14, 65)
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
        Me.Label11.Location = New System.Drawing.Point(14, 18)
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
        Me.TabPageConnPlate2.Size = New System.Drawing.Size(616, 514)
        Me.TabPageConnPlate2.TabIndex = 13
        Me.TabPageConnPlate2.Text = "D0600'Arc Plate 2"
        Me.TabPageConnPlate2.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(316, 65)
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
        Me.txtConnect2Thickness.Location = New System.Drawing.Point(472, 58)
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
        Me.Label24.Location = New System.Drawing.Point(316, 111)
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
        Me.txtConnect2Angle.Location = New System.Drawing.Point(472, 105)
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
        Me.Label25.Location = New System.Drawing.Point(316, 205)
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
        Me.txtConnect2innerWebDist.Location = New System.Drawing.Point(472, 198)
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
        Me.Label26.Location = New System.Drawing.Point(316, 158)
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
        Me.txtConnect2innerWebCount.Location = New System.Drawing.Point(472, 152)
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
        Me.Label27.Location = New System.Drawing.Point(14, 203)
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
        Me.txtConnect2innerWebThickness.Location = New System.Drawing.Point(170, 197)
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
        Me.Label28.Location = New System.Drawing.Point(14, 157)
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
        Me.txtConnect2InnerWebHeight.Location = New System.Drawing.Point(170, 151)
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
        Me.Label29.Location = New System.Drawing.Point(316, 18)
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
        Me.txtConnect2Width.Location = New System.Drawing.Point(472, 12)
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
        Me.Label30.Location = New System.Drawing.Point(14, 111)
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
        Me.txtConnect2Length.Location = New System.Drawing.Point(170, 105)
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
        Me.Label32.Location = New System.Drawing.Point(14, 65)
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
        Me.Label33.Location = New System.Drawing.Point(14, 18)
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
        'TabPageWebConnPlate1
        '
        Me.TabPageWebConnPlate1.Controls.Add(Me.GroupBox2)
        Me.TabPageWebConnPlate1.Controls.Add(Me.GroupBox1)
        Me.TabPageWebConnPlate1.Location = New System.Drawing.Point(4, 29)
        Me.TabPageWebConnPlate1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageWebConnPlate1.Name = "TabPageWebConnPlate1"
        Me.TabPageWebConnPlate1.Size = New System.Drawing.Size(616, 514)
        Me.TabPageWebConnPlate1.TabIndex = 14
        Me.TabPageWebConnPlate1.Text = "D0700'Web Connect Plate 1"
        Me.TabPageWebConnPlate1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateInnerVerEdgeDist1)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateThickness1)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateVerCount1)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateHorCount1)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateHorEdgeDist1)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateVerEdgeDist1)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.Label58)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateVerDist1)
        Me.GroupBox2.Controls.Add(Me.txtWebConnectPlateHorDist1)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(585, 278)
        Me.GroupBox2.TabIndex = 167
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "D0706'Plate"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(312, 217)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(200, 20)
        Me.Label62.TabIndex = 167
        Me.Label62.Text = "D0713'Inner Ver Edge Dist"
        '
        'txtWebConnectPlateInnerVerEdgeDist1
        '
        Me.txtWebConnectPlateInnerVerEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateInnerVerEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateInnerVerEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateInnerVerEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateInnerVerEdgeDist1.Location = New System.Drawing.Point(483, 212)
        Me.txtWebConnectPlateInnerVerEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateInnerVerEdgeDist1.Name = "txtWebConnectPlateInnerVerEdgeDist1"
        Me.txtWebConnectPlateInnerVerEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateInnerVerEdgeDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateInnerVerEdgeDist1.TabIndex = 166
        '
        'txtWebConnectPlateThickness1
        '
        Me.txtWebConnectPlateThickness1.AcceptsReturn = True
        Me.txtWebConnectPlateThickness1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateThickness1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateThickness1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateThickness1.Location = New System.Drawing.Point(182, 28)
        Me.txtWebConnectPlateThickness1.MaxLength = 0
        Me.txtWebConnectPlateThickness1.Name = "txtWebConnectPlateThickness1"
        Me.txtWebConnectPlateThickness1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateThickness1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateThickness1.TabIndex = 146
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(26, 32)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(131, 20)
        Me.Label61.TabIndex = 147
        Me.Label61.Text = "D0701'Thickness"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(312, 171)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(132, 20)
        Me.Label56.TabIndex = 157
        Me.Label56.Text = "D0712'Ver Count"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(26, 171)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(133, 20)
        Me.Label54.TabIndex = 161
        Me.Label54.Text = "D0710'Hor Count"
        '
        'txtWebConnectPlateVerCount1
        '
        Me.txtWebConnectPlateVerCount1.AcceptsReturn = True
        Me.txtWebConnectPlateVerCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerCount1.Location = New System.Drawing.Point(483, 166)
        Me.txtWebConnectPlateVerCount1.MaxLength = 0
        Me.txtWebConnectPlateVerCount1.Name = "txtWebConnectPlateVerCount1"
        Me.txtWebConnectPlateVerCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerCount1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerCount1.TabIndex = 156
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(310, 78)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(159, 20)
        Me.Label52.TabIndex = 165
        Me.Label52.Text = "D0708'Edge Ver Dist"
        '
        'txtWebConnectPlateHorCount1
        '
        Me.txtWebConnectPlateHorCount1.AcceptsReturn = True
        Me.txtWebConnectPlateHorCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorCount1.Location = New System.Drawing.Point(182, 166)
        Me.txtWebConnectPlateHorCount1.MaxLength = 0
        Me.txtWebConnectPlateHorCount1.Name = "txtWebConnectPlateHorCount1"
        Me.txtWebConnectPlateHorCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorCount1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorCount1.TabIndex = 160
        '
        'txtWebConnectPlateHorEdgeDist1
        '
        Me.txtWebConnectPlateHorEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateHorEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorEdgeDist1.Location = New System.Drawing.Point(182, 74)
        Me.txtWebConnectPlateHorEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateHorEdgeDist1.Name = "txtWebConnectPlateHorEdgeDist1"
        Me.txtWebConnectPlateHorEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorEdgeDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorEdgeDist1.TabIndex = 152
        '
        'txtWebConnectPlateVerEdgeDist1
        '
        Me.txtWebConnectPlateVerEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateVerEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerEdgeDist1.Location = New System.Drawing.Point(482, 74)
        Me.txtWebConnectPlateVerEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateVerEdgeDist1.Name = "txtWebConnectPlateVerEdgeDist1"
        Me.txtWebConnectPlateVerEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerEdgeDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerEdgeDist1.TabIndex = 164
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(312, 125)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(117, 20)
        Me.Label53.TabIndex = 163
        Me.Label53.Text = "D0711'Ver Dist"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(26, 78)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(160, 20)
        Me.Label58.TabIndex = 153
        Me.Label58.Text = "D0707'Edge Hor Dist"
        '
        'txtWebConnectPlateVerDist1
        '
        Me.txtWebConnectPlateVerDist1.AcceptsReturn = True
        Me.txtWebConnectPlateVerDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerDist1.Location = New System.Drawing.Point(483, 120)
        Me.txtWebConnectPlateVerDist1.MaxLength = 0
        Me.txtWebConnectPlateVerDist1.Name = "txtWebConnectPlateVerDist1"
        Me.txtWebConnectPlateVerDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerDist1.TabIndex = 162
        '
        'txtWebConnectPlateHorDist1
        '
        Me.txtWebConnectPlateHorDist1.AcceptsReturn = True
        Me.txtWebConnectPlateHorDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorDist1.Location = New System.Drawing.Point(182, 120)
        Me.txtWebConnectPlateHorDist1.MaxLength = 0
        Me.txtWebConnectPlateHorDist1.Name = "txtWebConnectPlateHorDist1"
        Me.txtWebConnectPlateHorDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorDist1.TabIndex = 158
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(26, 125)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(118, 20)
        Me.Label55.TabIndex = 159
        Me.Label55.Text = "D0709'Hor Dist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoltGroupHorSideDist1)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.txtBoltGroupSpan1)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(585, 118)
        Me.GroupBox1.TabIndex = 166
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "D0702'Bolt Group"
        '
        'txtBoltGroupHorSideDist1
        '
        Me.txtBoltGroupHorSideDist1.AcceptsReturn = True
        Me.txtBoltGroupHorSideDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupHorSideDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupHorSideDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupHorSideDist1.Location = New System.Drawing.Point(182, 28)
        Me.txtBoltGroupHorSideDist1.MaxLength = 0
        Me.txtBoltGroupHorSideDist1.Name = "txtBoltGroupHorSideDist1"
        Me.txtBoltGroupHorSideDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupHorSideDist1.Size = New System.Drawing.Size(84, 26)
        Me.txtBoltGroupHorSideDist1.TabIndex = 150
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(24, 32)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(154, 20)
        Me.Label59.TabIndex = 151
        Me.Label59.Text = "D0704'Hor Side Dist"
        '
        'txtBoltGroupSpan1
        '
        Me.txtBoltGroupSpan1.AcceptsReturn = True
        Me.txtBoltGroupSpan1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupSpan1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupSpan1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupSpan1.Location = New System.Drawing.Point(482, 28)
        Me.txtBoltGroupSpan1.MaxLength = 0
        Me.txtBoltGroupSpan1.Name = "txtBoltGroupSpan1"
        Me.txtBoltGroupSpan1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupSpan1.Size = New System.Drawing.Size(84, 26)
        Me.txtBoltGroupSpan1.TabIndex = 154
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(312, 32)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(137, 20)
        Me.Label57.TabIndex = 155
        Me.Label57.Text = "D0705'Group Dist"
        '
        'TabPageWebConnPlate2
        '
        Me.TabPageWebConnPlate2.Controls.Add(Me.GroupBox3)
        Me.TabPageWebConnPlate2.Controls.Add(Me.GroupBox4)
        Me.TabPageWebConnPlate2.Location = New System.Drawing.Point(4, 29)
        Me.TabPageWebConnPlate2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageWebConnPlate2.Name = "TabPageWebConnPlate2"
        Me.TabPageWebConnPlate2.Size = New System.Drawing.Size(616, 514)
        Me.TabPageWebConnPlate2.TabIndex = 15
        Me.TabPageWebConnPlate2.Text = "D0800'Web Connect Plate 2"
        Me.TabPageWebConnPlate2.UseVisualStyleBackColor = True
        Me.TabPageWebConnPlate2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label63)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateInnerVerEdgeDist2)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateThickness2)
        Me.GroupBox3.Controls.Add(Me.Label64)
        Me.GroupBox3.Controls.Add(Me.Label65)
        Me.GroupBox3.Controls.Add(Me.Label66)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateVerCount2)
        Me.GroupBox3.Controls.Add(Me.Label67)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateHorCount2)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateHorEdgeDist2)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateVerEdgeDist2)
        Me.GroupBox3.Controls.Add(Me.Label68)
        Me.GroupBox3.Controls.Add(Me.Label69)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateVerDist2)
        Me.GroupBox3.Controls.Add(Me.txtWebConnectPlateHorDist2)
        Me.GroupBox3.Controls.Add(Me.Label70)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(585, 278)
        Me.GroupBox3.TabIndex = 169
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "D0706'Plate"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(312, 217)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(200, 20)
        Me.Label63.TabIndex = 167
        Me.Label63.Text = "D0713'Inner Ver Edge Dist"
        '
        'txtWebConnectPlateInnerVerEdgeDist2
        '
        Me.txtWebConnectPlateInnerVerEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateInnerVerEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateInnerVerEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateInnerVerEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateInnerVerEdgeDist2.Location = New System.Drawing.Point(483, 212)
        Me.txtWebConnectPlateInnerVerEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateInnerVerEdgeDist2.Name = "txtWebConnectPlateInnerVerEdgeDist2"
        Me.txtWebConnectPlateInnerVerEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateInnerVerEdgeDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateInnerVerEdgeDist2.TabIndex = 166
        '
        'txtWebConnectPlateThickness2
        '
        Me.txtWebConnectPlateThickness2.AcceptsReturn = True
        Me.txtWebConnectPlateThickness2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateThickness2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateThickness2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateThickness2.Location = New System.Drawing.Point(182, 28)
        Me.txtWebConnectPlateThickness2.MaxLength = 0
        Me.txtWebConnectPlateThickness2.Name = "txtWebConnectPlateThickness2"
        Me.txtWebConnectPlateThickness2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateThickness2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateThickness2.TabIndex = 146
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(26, 32)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(131, 20)
        Me.Label64.TabIndex = 147
        Me.Label64.Text = "D0701'Thickness"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(312, 171)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(132, 20)
        Me.Label65.TabIndex = 157
        Me.Label65.Text = "D0712'Ver Count"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(26, 171)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(133, 20)
        Me.Label66.TabIndex = 161
        Me.Label66.Text = "D0710'Hor Count"
        '
        'txtWebConnectPlateVerCount2
        '
        Me.txtWebConnectPlateVerCount2.AcceptsReturn = True
        Me.txtWebConnectPlateVerCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerCount2.Location = New System.Drawing.Point(483, 166)
        Me.txtWebConnectPlateVerCount2.MaxLength = 0
        Me.txtWebConnectPlateVerCount2.Name = "txtWebConnectPlateVerCount2"
        Me.txtWebConnectPlateVerCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerCount2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerCount2.TabIndex = 156
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(310, 78)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(159, 20)
        Me.Label67.TabIndex = 165
        Me.Label67.Text = "D0708'Edge Ver Dist"
        '
        'txtWebConnectPlateHorCount2
        '
        Me.txtWebConnectPlateHorCount2.AcceptsReturn = True
        Me.txtWebConnectPlateHorCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorCount2.Location = New System.Drawing.Point(182, 166)
        Me.txtWebConnectPlateHorCount2.MaxLength = 0
        Me.txtWebConnectPlateHorCount2.Name = "txtWebConnectPlateHorCount2"
        Me.txtWebConnectPlateHorCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorCount2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorCount2.TabIndex = 160
        '
        'txtWebConnectPlateHorEdgeDist2
        '
        Me.txtWebConnectPlateHorEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateHorEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorEdgeDist2.Location = New System.Drawing.Point(182, 74)
        Me.txtWebConnectPlateHorEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateHorEdgeDist2.Name = "txtWebConnectPlateHorEdgeDist2"
        Me.txtWebConnectPlateHorEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorEdgeDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorEdgeDist2.TabIndex = 152
        '
        'txtWebConnectPlateVerEdgeDist2
        '
        Me.txtWebConnectPlateVerEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateVerEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerEdgeDist2.Location = New System.Drawing.Point(482, 74)
        Me.txtWebConnectPlateVerEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateVerEdgeDist2.Name = "txtWebConnectPlateVerEdgeDist2"
        Me.txtWebConnectPlateVerEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerEdgeDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerEdgeDist2.TabIndex = 164
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(312, 125)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(117, 20)
        Me.Label68.TabIndex = 163
        Me.Label68.Text = "D0711'Ver Dist"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label69.Location = New System.Drawing.Point(26, 78)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(160, 20)
        Me.Label69.TabIndex = 153
        Me.Label69.Text = "D0707'Edge Hor Dist"
        '
        'txtWebConnectPlateVerDist2
        '
        Me.txtWebConnectPlateVerDist2.AcceptsReturn = True
        Me.txtWebConnectPlateVerDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerDist2.Location = New System.Drawing.Point(483, 120)
        Me.txtWebConnectPlateVerDist2.MaxLength = 0
        Me.txtWebConnectPlateVerDist2.Name = "txtWebConnectPlateVerDist2"
        Me.txtWebConnectPlateVerDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateVerDist2.TabIndex = 162
        '
        'txtWebConnectPlateHorDist2
        '
        Me.txtWebConnectPlateHorDist2.AcceptsReturn = True
        Me.txtWebConnectPlateHorDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorDist2.Location = New System.Drawing.Point(182, 120)
        Me.txtWebConnectPlateHorDist2.MaxLength = 0
        Me.txtWebConnectPlateHorDist2.Name = "txtWebConnectPlateHorDist2"
        Me.txtWebConnectPlateHorDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtWebConnectPlateHorDist2.TabIndex = 158
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(26, 125)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(118, 20)
        Me.Label70.TabIndex = 159
        Me.Label70.Text = "D0709'Hor Dist"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBoltGroupHorSideDist2)
        Me.GroupBox4.Controls.Add(Me.Label72)
        Me.GroupBox4.Controls.Add(Me.txtBoltGroupSpan2)
        Me.GroupBox4.Controls.Add(Me.Label73)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(585, 118)
        Me.GroupBox4.TabIndex = 168
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "D0702'Bolt Group"
        '
        'txtBoltGroupHorSideDist2
        '
        Me.txtBoltGroupHorSideDist2.AcceptsReturn = True
        Me.txtBoltGroupHorSideDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupHorSideDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupHorSideDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupHorSideDist2.Location = New System.Drawing.Point(182, 28)
        Me.txtBoltGroupHorSideDist2.MaxLength = 0
        Me.txtBoltGroupHorSideDist2.Name = "txtBoltGroupHorSideDist2"
        Me.txtBoltGroupHorSideDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupHorSideDist2.Size = New System.Drawing.Size(84, 26)
        Me.txtBoltGroupHorSideDist2.TabIndex = 150
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label72.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label72.Location = New System.Drawing.Point(24, 32)
        Me.Label72.Name = "Label72"
        Me.Label72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label72.Size = New System.Drawing.Size(154, 20)
        Me.Label72.TabIndex = 151
        Me.Label72.Text = "D0704'Hor Side Dist"
        '
        'txtBoltGroupSpan2
        '
        Me.txtBoltGroupSpan2.AcceptsReturn = True
        Me.txtBoltGroupSpan2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupSpan2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupSpan2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupSpan2.Location = New System.Drawing.Point(482, 28)
        Me.txtBoltGroupSpan2.MaxLength = 0
        Me.txtBoltGroupSpan2.Name = "txtBoltGroupSpan2"
        Me.txtBoltGroupSpan2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupSpan2.Size = New System.Drawing.Size(84, 26)
        Me.txtBoltGroupSpan2.TabIndex = 154
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(312, 32)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(137, 20)
        Me.Label73.TabIndex = 155
        Me.Label73.Text = "D0705'Group Dist"
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(484, 567)
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
        Me.ClientSize = New System.Drawing.Size(1042, 624)
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
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBottom.ResumeLayout(False)
        Me.GroupBottom.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageHoleGroup1.ResumeLayout(False)
        Me.TabPageHoleGroup1.PerformLayout()
        Me.TabPageHoleGroup2.ResumeLayout(False)
        Me.TabPageHoleGroup2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPageConnPlate1.ResumeLayout(False)
        Me.TabPageConnPlate1.PerformLayout()
        Me.TabPageConnPlate2.ResumeLayout(False)
        Me.TabPageConnPlate2.PerformLayout()
        Me.TabPageWebConnPlate1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageWebConnPlate2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Public WithEvents txtConnect1FlangeThickness As Windows.Forms.TextBox
    Public WithEvents Label35 As Windows.Forms.Label
    Public WithEvents txtConnect2FlangeThickness As Windows.Forms.TextBox
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
    Friend WithEvents TabPageWebConnPlate1 As Windows.Forms.TabPage
    Friend WithEvents TabPageWebConnPlate2 As Windows.Forms.TabPage
    Public WithEvents Label52 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateVerEdgeDist1 As Windows.Forms.TextBox
    Public WithEvents Label53 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateVerDist1 As Windows.Forms.TextBox
    Public WithEvents Label54 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateHorCount1 As Windows.Forms.TextBox
    Public WithEvents Label55 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateHorDist1 As Windows.Forms.TextBox
    Public WithEvents Label56 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateVerCount1 As Windows.Forms.TextBox
    Public WithEvents Label57 As Windows.Forms.Label
    Public WithEvents txtBoltGroupSpan1 As Windows.Forms.TextBox
    Public WithEvents Label58 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateHorEdgeDist1 As Windows.Forms.TextBox
    Public WithEvents Label59 As Windows.Forms.Label
    Public WithEvents txtBoltGroupHorSideDist1 As Windows.Forms.TextBox
    Public WithEvents Label61 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateThickness1 As Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Public WithEvents Label62 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateInnerVerEdgeDist1 As Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Public WithEvents Label63 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateInnerVerEdgeDist2 As Windows.Forms.TextBox
    Public WithEvents txtWebConnectPlateThickness2 As Windows.Forms.TextBox
    Public WithEvents Label64 As Windows.Forms.Label
    Public WithEvents Label65 As Windows.Forms.Label
    Public WithEvents Label66 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateVerCount2 As Windows.Forms.TextBox
    Public WithEvents Label67 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateHorCount2 As Windows.Forms.TextBox
    Public WithEvents txtWebConnectPlateHorEdgeDist2 As Windows.Forms.TextBox
    Public WithEvents txtWebConnectPlateVerEdgeDist2 As Windows.Forms.TextBox
    Public WithEvents Label68 As Windows.Forms.Label
    Public WithEvents Label69 As Windows.Forms.Label
    Public WithEvents txtWebConnectPlateVerDist2 As Windows.Forms.TextBox
    Public WithEvents txtWebConnectPlateHorDist2 As Windows.Forms.TextBox
    Public WithEvents Label70 As Windows.Forms.Label
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Public WithEvents txtBoltGroupHorSideDist2 As Windows.Forms.TextBox
    Public WithEvents Label72 As Windows.Forms.Label
    Public WithEvents txtBoltGroupSpan2 As Windows.Forms.TextBox
    Public WithEvents Label73 As Windows.Forms.Label
    Public WithEvents Label60 As Windows.Forms.Label
    Public WithEvents txtHoleDia As Windows.Forms.TextBox
    Public WithEvents Label71 As Windows.Forms.Label
    Public WithEvents txtConnect1WebThickness As Windows.Forms.TextBox
    Public WithEvents Label74 As Windows.Forms.Label
    Public WithEvents txtConnect2WebThickness As Windows.Forms.TextBox
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Public WithEvents Label75 As Windows.Forms.Label
    Public WithEvents TextBox1 As Windows.Forms.TextBox
    Public WithEvents Label76 As Windows.Forms.Label
    Public WithEvents TextBox2 As Windows.Forms.TextBox
    Public WithEvents Label77 As Windows.Forms.Label
    Public WithEvents TextBox3 As Windows.Forms.TextBox
    Public WithEvents Label78 As Windows.Forms.Label
    Public WithEvents TextBox4 As Windows.Forms.TextBox
    Public WithEvents Label79 As Windows.Forms.Label
    Public WithEvents TextBox5 As Windows.Forms.TextBox
    Public WithEvents Label80 As Windows.Forms.Label
    Public WithEvents TextBox6 As Windows.Forms.TextBox
    Public WithEvents Label81 As Windows.Forms.Label
    Public WithEvents txtColumnCutBack As Windows.Forms.TextBox
    Public WithEvents Label82 As Windows.Forms.Label
    Public WithEvents TextBox8 As Windows.Forms.TextBox
#End Region
End Class