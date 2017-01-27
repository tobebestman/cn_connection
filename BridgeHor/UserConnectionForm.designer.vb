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
        Me.txtDiagnalGap = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtHoleDia = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHorPlateThickness = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHorFlangeCutBack = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHorCutBack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHorGap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiagnalCutback = New System.Windows.Forms.TextBox()
        Me.TabPageSidePlate = New System.Windows.Forms.TabPage()
        Me._TabFrames_0 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtBottomDiagDist = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtBottomHorDist = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtInsidePlateThickness = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtOutsidePlateThickness = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTopDiagDist = New System.Windows.Forms.TextBox()
        Me.txtHorFillet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTopHorDist = New System.Windows.Forms.TextBox()
        Me.txtHorAngle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiagAngle = New System.Windows.Forms.TextBox()
        Me.txtDiagFillet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPageMiddleWebConnPlate = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtConnectPlateThickness = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtHoleDiameter = New System.Windows.Forms.TextBox()
        Me.txtHorHoleCount = New System.Windows.Forms.TextBox()
        Me.txtHorHoleDist = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHorHoleEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtVerHoleDist = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtVerHoleEdgeDist = New System.Windows.Forms.TextBox()
        Me.txtVerHoleCount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSupportPlateThickness = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSupportPlateOffset = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBraceSideWebPlateLength = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBraceSideWebPlateThickness = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtChordSideWebPlateThickness = New System.Windows.Forms.TextBox()
        Me.TabPageHorConnPlate = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtVerMiddleDist = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtVerEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtVerDist = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtVerCount = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtHorCount = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFlgConnPlateInsidePlateThk = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtHorDist = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtHorEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtFlgConnPlateOutsidePlateThk = New System.Windows.Forms.TextBox()
        Me.cmdRollover = New System.Windows.Forms.Button()
        Me.imgBitmaps = New System.Windows.Forms.ImageList(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps3 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps4 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps5 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps6 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageDiagConnPlate = New System.Windows.Forms.TabPage()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtBackingPlateThickness = New System.Windows.Forms.TextBox()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStrip1.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.TabPageSidePlate.SuspendLayout()
        Me._TabFrames_0.SuspendLayout()
        Me.TabPageMiddleWebConnPlate.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPageHorConnPlate.SuspendLayout()
        Me.TabPageDiagConnPlate.SuspendLayout()
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
        Me.TabStrip1.Controls.Add(Me.TabPageMiddleWebConnPlate)
        Me.TabStrip1.Controls.Add(Me.TabPageHorConnPlate)
        Me.TabStrip1.Controls.Add(Me.TabPageDiagConnPlate)
        Me.TabStrip1.Location = New System.Drawing.Point(9, 18)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(624, 472)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.txtDiagnalGap)
        Me.TabPageGeneral.Controls.Add(Me.Label60)
        Me.TabPageGeneral.Controls.Add(Me.txtHoleDia)
        Me.TabPageGeneral.Controls.Add(Me.Label34)
        Me.TabPageGeneral.Controls.Add(Me.Label9)
        Me.TabPageGeneral.Controls.Add(Me.txtHorPlateThickness)
        Me.TabPageGeneral.Controls.Add(Me.Label8)
        Me.TabPageGeneral.Controls.Add(Me.txtHorFlangeCutBack)
        Me.TabPageGeneral.Controls.Add(Me.Label7)
        Me.TabPageGeneral.Controls.Add(Me.txtHorCutBack)
        Me.TabPageGeneral.Controls.Add(Me.Label3)
        Me.TabPageGeneral.Controls.Add(Me.txtHorGap)
        Me.TabPageGeneral.Controls.Add(Me.Label4)
        Me.TabPageGeneral.Controls.Add(Me.txtDiagnalCutback)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 29)
        Me.TabPageGeneral.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageGeneral.Size = New System.Drawing.Size(616, 439)
        Me.TabPageGeneral.TabIndex = 11
        Me.TabPageGeneral.Text = "D0400'CutBack"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'txtDiagnalGap
        '
        Me.txtDiagnalGap.AcceptsReturn = True
        Me.txtDiagnalGap.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagnalGap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnalGap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagnalGap.Location = New System.Drawing.Point(480, 58)
        Me.txtDiagnalGap.MaxLength = 0
        Me.txtDiagnalGap.Name = "txtDiagnalGap"
        Me.txtDiagnalGap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagnalGap.Size = New System.Drawing.Size(84, 26)
        Me.txtDiagnalGap.TabIndex = 144
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(14, 203)
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
        Me.txtHoleDia.Location = New System.Drawing.Point(196, 197)
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
        Me.Label34.Location = New System.Drawing.Point(303, 63)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(149, 20)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "D0406'Diagnal Gap"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(14, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(194, 20)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "D0405'Main Chord PL Thk"
        '
        'txtHorPlateThickness
        '
        Me.txtHorPlateThickness.AcceptsReturn = True
        Me.txtHorPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorPlateThickness.Location = New System.Drawing.Point(196, 151)
        Me.txtHorPlateThickness.MaxLength = 0
        Me.txtHorPlateThickness.Name = "txtHorPlateThickness"
        Me.txtHorPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtHorPlateThickness.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(190, 20)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "D0402'Hor Web Cut back"
        '
        'txtHorFlangeCutBack
        '
        Me.txtHorFlangeCutBack.AcceptsReturn = True
        Me.txtHorFlangeCutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorFlangeCutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorFlangeCutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorFlangeCutBack.Location = New System.Drawing.Point(196, 58)
        Me.txtHorFlangeCutBack.MaxLength = 0
        Me.txtHorFlangeCutBack.Name = "txtHorFlangeCutBack"
        Me.txtHorFlangeCutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorFlangeCutBack.Size = New System.Drawing.Size(84, 26)
        Me.txtHorFlangeCutBack.TabIndex = 98
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
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "D0401'Hor Cut back"
        '
        'txtHorCutBack
        '
        Me.txtHorCutBack.AcceptsReturn = True
        Me.txtHorCutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorCutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorCutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorCutBack.Location = New System.Drawing.Point(196, 12)
        Me.txtHorCutBack.MaxLength = 0
        Me.txtHorCutBack.Name = "txtHorCutBack"
        Me.txtHorCutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorCutBack.Size = New System.Drawing.Size(84, 26)
        Me.txtHorCutBack.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(303, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "D0404'Hor Gap"
        '
        'txtHorGap
        '
        Me.txtHorGap.AcceptsReturn = True
        Me.txtHorGap.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorGap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorGap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorGap.Location = New System.Drawing.Point(480, 14)
        Me.txtHorGap.MaxLength = 0
        Me.txtHorGap.Name = "txtHorGap"
        Me.txtHorGap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorGap.Size = New System.Drawing.Size(84, 26)
        Me.txtHorGap.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D0403'Diagnal Cut back"
        '
        'txtDiagnalCutback
        '
        Me.txtDiagnalCutback.AcceptsReturn = True
        Me.txtDiagnalCutback.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagnalCutback.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnalCutback.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagnalCutback.Location = New System.Drawing.Point(196, 105)
        Me.txtDiagnalCutback.MaxLength = 0
        Me.txtDiagnalCutback.Name = "txtDiagnalCutback"
        Me.txtDiagnalCutback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagnalCutback.Size = New System.Drawing.Size(84, 26)
        Me.txtDiagnalCutback.TabIndex = 84
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
        Me._TabFrames_0.Controls.Add(Me.Label27)
        Me._TabFrames_0.Controls.Add(Me.txtBackingPlateThickness)
        Me._TabFrames_0.Controls.Add(Me.Label38)
        Me._TabFrames_0.Controls.Add(Me.txtBottomDiagDist)
        Me._TabFrames_0.Controls.Add(Me.Label39)
        Me._TabFrames_0.Controls.Add(Me.txtBottomHorDist)
        Me._TabFrames_0.Controls.Add(Me.Label14)
        Me._TabFrames_0.Controls.Add(Me.txtInsidePlateThickness)
        Me._TabFrames_0.Controls.Add(Me.Label31)
        Me._TabFrames_0.Controls.Add(Me.txtOutsidePlateThickness)
        Me._TabFrames_0.Controls.Add(Me.Label10)
        Me._TabFrames_0.Controls.Add(Me.txtTopDiagDist)
        Me._TabFrames_0.Controls.Add(Me.txtHorFillet)
        Me._TabFrames_0.Controls.Add(Me.Label12)
        Me._TabFrames_0.Controls.Add(Me.Label1)
        Me._TabFrames_0.Controls.Add(Me.txtTopHorDist)
        Me._TabFrames_0.Controls.Add(Me.txtHorAngle)
        Me._TabFrames_0.Controls.Add(Me.Label5)
        Me._TabFrames_0.Controls.Add(Me.Label2)
        Me._TabFrames_0.Controls.Add(Me.txtDiagAngle)
        Me._TabFrames_0.Controls.Add(Me.txtDiagFillet)
        Me._TabFrames_0.Controls.Add(Me.Label6)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(616, 439)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(276, 157)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(181, 20)
        Me.Label38.TabIndex = 121
        Me.Label38.Text = "D0113'Diag Bottom Dist"
        '
        'txtBottomDiagDist
        '
        Me.txtBottomDiagDist.AcceptsReturn = True
        Me.txtBottomDiagDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomDiagDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomDiagDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomDiagDist.Location = New System.Drawing.Point(426, 154)
        Me.txtBottomDiagDist.MaxLength = 0
        Me.txtBottomDiagDist.Name = "txtBottomDiagDist"
        Me.txtBottomDiagDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomDiagDist.Size = New System.Drawing.Size(84, 26)
        Me.txtBottomDiagDist.TabIndex = 120
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(18, 158)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(174, 20)
        Me.Label39.TabIndex = 119
        Me.Label39.Text = "D0112'Hor Bottom Dist"
        '
        'txtBottomHorDist
        '
        Me.txtBottomHorDist.AcceptsReturn = True
        Me.txtBottomHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomHorDist.Location = New System.Drawing.Point(170, 155)
        Me.txtBottomHorDist.MaxLength = 0
        Me.txtBottomHorDist.Name = "txtBottomHorDist"
        Me.txtBottomHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomHorDist.Size = New System.Drawing.Size(84, 26)
        Me.txtBottomHorDist.TabIndex = 118
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(276, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(152, 20)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "D0111'Inside PL thk"
        '
        'txtInsidePlateThickness
        '
        Me.txtInsidePlateThickness.AcceptsReturn = True
        Me.txtInsidePlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsidePlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsidePlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsidePlateThickness.Location = New System.Drawing.Point(426, 198)
        Me.txtInsidePlateThickness.MaxLength = 0
        Me.txtInsidePlateThickness.Name = "txtInsidePlateThickness"
        Me.txtInsidePlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsidePlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtInsidePlateThickness.TabIndex = 116
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(18, 203)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(164, 20)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "D0110'Outside PL thk"
        '
        'txtOutsidePlateThickness
        '
        Me.txtOutsidePlateThickness.AcceptsReturn = True
        Me.txtOutsidePlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutsidePlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutsidePlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutsidePlateThickness.Location = New System.Drawing.Point(170, 200)
        Me.txtOutsidePlateThickness.MaxLength = 0
        Me.txtOutsidePlateThickness.Name = "txtOutsidePlateThickness"
        Me.txtOutsidePlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOutsidePlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtOutsidePlateThickness.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(274, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "D0109'Diag Dist"
        '
        'txtTopDiagDist
        '
        Me.txtTopDiagDist.AcceptsReturn = True
        Me.txtTopDiagDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopDiagDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopDiagDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopDiagDist.Location = New System.Drawing.Point(426, 108)
        Me.txtTopDiagDist.MaxLength = 0
        Me.txtTopDiagDist.Name = "txtTopDiagDist"
        Me.txtTopDiagDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopDiagDist.Size = New System.Drawing.Size(84, 26)
        Me.txtTopDiagDist.TabIndex = 112
        '
        'txtHorFillet
        '
        Me.txtHorFillet.AcceptsReturn = True
        Me.txtHorFillet.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorFillet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorFillet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorFillet.Location = New System.Drawing.Point(170, 25)
        Me.txtHorFillet.MaxLength = 0
        Me.txtHorFillet.Name = "txtHorFillet"
        Me.txtHorFillet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorFillet.Size = New System.Drawing.Size(84, 26)
        Me.txtHorFillet.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(18, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "D0107'Hor Dist"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "D0102'Hor Fillet"
        '
        'txtTopHorDist
        '
        Me.txtTopHorDist.AcceptsReturn = True
        Me.txtTopHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopHorDist.Location = New System.Drawing.Point(170, 108)
        Me.txtTopHorDist.MaxLength = 0
        Me.txtTopHorDist.Name = "txtTopHorDist"
        Me.txtTopHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopHorDist.Size = New System.Drawing.Size(84, 26)
        Me.txtTopHorDist.TabIndex = 108
        '
        'txtHorAngle
        '
        Me.txtHorAngle.AcceptsReturn = True
        Me.txtHorAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorAngle.Location = New System.Drawing.Point(170, 66)
        Me.txtHorAngle.MaxLength = 0
        Me.txtHorAngle.Name = "txtHorAngle"
        Me.txtHorAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorAngle.Size = New System.Drawing.Size(84, 26)
        Me.txtHorAngle.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(274, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "D0105'Diag Angle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "D0103'Hor Angle"
        '
        'txtDiagAngle
        '
        Me.txtDiagAngle.AcceptsReturn = True
        Me.txtDiagAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagAngle.Location = New System.Drawing.Point(426, 66)
        Me.txtDiagAngle.MaxLength = 0
        Me.txtDiagAngle.Name = "txtDiagAngle"
        Me.txtDiagAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagAngle.Size = New System.Drawing.Size(84, 26)
        Me.txtDiagAngle.TabIndex = 106
        '
        'txtDiagFillet
        '
        Me.txtDiagFillet.AcceptsReturn = True
        Me.txtDiagFillet.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagFillet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagFillet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagFillet.Location = New System.Drawing.Point(426, 25)
        Me.txtDiagFillet.MaxLength = 0
        Me.txtDiagFillet.Name = "txtDiagFillet"
        Me.txtDiagFillet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagFillet.Size = New System.Drawing.Size(84, 26)
        Me.txtDiagFillet.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(274, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "D0104'Diag Fillet"
        '
        'TabPageMiddleWebConnPlate
        '
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.GroupBox5)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.Label22)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.txtSupportPlateThickness)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.Label16)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.txtSupportPlateOffset)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.Label15)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.txtBraceSideWebPlateLength)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.Label13)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.txtBraceSideWebPlateThickness)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.Label11)
        Me.TabPageMiddleWebConnPlate.Controls.Add(Me.txtChordSideWebPlateThickness)
        Me.TabPageMiddleWebConnPlate.Location = New System.Drawing.Point(4, 29)
        Me.TabPageMiddleWebConnPlate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageMiddleWebConnPlate.Name = "TabPageMiddleWebConnPlate"
        Me.TabPageMiddleWebConnPlate.Size = New System.Drawing.Size(616, 439)
        Me.TabPageMiddleWebConnPlate.TabIndex = 12
        Me.TabPageMiddleWebConnPlate.Text = "D0500'Middle Web Plates"
        Me.TabPageMiddleWebConnPlate.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.txtConnectPlateThickness)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.txtHoleDiameter)
        Me.GroupBox5.Controls.Add(Me.txtHorHoleCount)
        Me.GroupBox5.Controls.Add(Me.txtHorHoleDist)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtHorHoleEdgeDist)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtVerHoleDist)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtVerHoleEdgeDist)
        Me.GroupBox5.Controls.Add(Me.txtVerHoleCount)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(584, 225)
        Me.GroupBox5.TabIndex = 124
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "D0506'Connect Plates"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(314, 35)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(113, 20)
        Me.Label37.TabIndex = 127
        Me.Label37.Text = "D514'Plate thk"
        '
        'txtConnectPlateThickness
        '
        Me.txtConnectPlateThickness.AcceptsReturn = True
        Me.txtConnectPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectPlateThickness.Location = New System.Drawing.Point(470, 32)
        Me.txtConnectPlateThickness.MaxLength = 0
        Me.txtConnectPlateThickness.Name = "txtConnectPlateThickness"
        Me.txtConnectPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtConnectPlateThickness.TabIndex = 126
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(16, 35)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(121, 20)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "D0513'Hole Dia"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(16, 180)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(133, 20)
        Me.Label35.TabIndex = 123
        Me.Label35.Text = "D0511'Hor Count"
        '
        'txtHoleDiameter
        '
        Me.txtHoleDiameter.AcceptsReturn = True
        Me.txtHoleDiameter.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleDiameter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleDiameter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleDiameter.Location = New System.Drawing.Point(172, 32)
        Me.txtHoleDiameter.MaxLength = 0
        Me.txtHoleDiameter.Name = "txtHoleDiameter"
        Me.txtHoleDiameter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleDiameter.Size = New System.Drawing.Size(84, 26)
        Me.txtHoleDiameter.TabIndex = 124
        '
        'txtHorHoleCount
        '
        Me.txtHorHoleCount.AcceptsReturn = True
        Me.txtHorHoleCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleCount.Location = New System.Drawing.Point(172, 177)
        Me.txtHorHoleCount.MaxLength = 0
        Me.txtHorHoleCount.Name = "txtHorHoleCount"
        Me.txtHorHoleCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleCount.Size = New System.Drawing.Size(84, 26)
        Me.txtHorHoleCount.TabIndex = 122
        '
        'txtHorHoleDist
        '
        Me.txtHorHoleDist.AcceptsReturn = True
        Me.txtHorHoleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleDist.Location = New System.Drawing.Point(172, 80)
        Me.txtHorHoleDist.MaxLength = 0
        Me.txtHorHoleDist.Name = "txtHorHoleDist"
        Me.txtHorHoleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleDist.Size = New System.Drawing.Size(84, 26)
        Me.txtHorHoleDist.TabIndex = 112
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(118, 20)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "D0507'Hor Dist"
        '
        'txtHorHoleEdgeDist
        '
        Me.txtHorHoleEdgeDist.AcceptsReturn = True
        Me.txtHorHoleEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleEdgeDist.Location = New System.Drawing.Point(172, 128)
        Me.txtHorHoleEdgeDist.MaxLength = 0
        Me.txtHorHoleEdgeDist.Name = "txtHorHoleEdgeDist"
        Me.txtHorHoleEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleEdgeDist.Size = New System.Drawing.Size(84, 26)
        Me.txtHorHoleEdgeDist.TabIndex = 114
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(314, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(117, 20)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "D0508'Ver Dist"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(160, 20)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "D0509'Hor Edge Dist"
        '
        'txtVerHoleDist
        '
        Me.txtVerHoleDist.AcceptsReturn = True
        Me.txtVerHoleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleDist.Location = New System.Drawing.Point(470, 80)
        Me.txtVerHoleDist.MaxLength = 0
        Me.txtVerHoleDist.Name = "txtVerHoleDist"
        Me.txtVerHoleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleDist.Size = New System.Drawing.Size(84, 26)
        Me.txtVerHoleDist.TabIndex = 120
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(314, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(132, 20)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "D0512'Ver Count"
        '
        'txtVerHoleEdgeDist
        '
        Me.txtVerHoleEdgeDist.AcceptsReturn = True
        Me.txtVerHoleEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleEdgeDist.Location = New System.Drawing.Point(470, 128)
        Me.txtVerHoleEdgeDist.MaxLength = 0
        Me.txtVerHoleEdgeDist.Name = "txtVerHoleEdgeDist"
        Me.txtVerHoleEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleEdgeDist.Size = New System.Drawing.Size(84, 26)
        Me.txtVerHoleEdgeDist.TabIndex = 116
        '
        'txtVerHoleCount
        '
        Me.txtVerHoleCount.AcceptsReturn = True
        Me.txtVerHoleCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleCount.Location = New System.Drawing.Point(470, 177)
        Me.txtVerHoleCount.MaxLength = 0
        Me.txtVerHoleCount.Name = "txtVerHoleCount"
        Me.txtVerHoleCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleCount.Size = New System.Drawing.Size(84, 26)
        Me.txtVerHoleCount.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(314, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(159, 20)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "D0510'Ver Edge Dist"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(316, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(187, 20)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "D0505'Support Plate Thk"
        '
        'txtSupportPlateThickness
        '
        Me.txtSupportPlateThickness.AcceptsReturn = True
        Me.txtSupportPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportPlateThickness.Location = New System.Drawing.Point(472, 58)
        Me.txtSupportPlateThickness.MaxLength = 0
        Me.txtSupportPlateThickness.Name = "txtSupportPlateThickness"
        Me.txtSupportPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtSupportPlateThickness.TabIndex = 122
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(316, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(205, 20)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "D0504'Support Plate Offset"
        '
        'txtSupportPlateOffset
        '
        Me.txtSupportPlateOffset.AcceptsReturn = True
        Me.txtSupportPlateOffset.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportPlateOffset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportPlateOffset.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportPlateOffset.Location = New System.Drawing.Point(472, 12)
        Me.txtSupportPlateOffset.MaxLength = 0
        Me.txtSupportPlateOffset.Name = "txtSupportPlateOffset"
        Me.txtSupportPlateOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportPlateOffset.Size = New System.Drawing.Size(84, 26)
        Me.txtSupportPlateOffset.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(14, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(169, 20)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "D0503'Brace Side Len"
        '
        'txtBraceSideWebPlateLength
        '
        Me.txtBraceSideWebPlateLength.AcceptsReturn = True
        Me.txtBraceSideWebPlateLength.BackColor = System.Drawing.SystemColors.Window
        Me.txtBraceSideWebPlateLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBraceSideWebPlateLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBraceSideWebPlateLength.Location = New System.Drawing.Point(170, 105)
        Me.txtBraceSideWebPlateLength.MaxLength = 0
        Me.txtBraceSideWebPlateLength.Name = "txtBraceSideWebPlateLength"
        Me.txtBraceSideWebPlateLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBraceSideWebPlateLength.Size = New System.Drawing.Size(84, 26)
        Me.txtBraceSideWebPlateLength.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(14, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(168, 20)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "D0502'Brace Side Thk"
        '
        'txtBraceSideWebPlateThickness
        '
        Me.txtBraceSideWebPlateThickness.AcceptsReturn = True
        Me.txtBraceSideWebPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtBraceSideWebPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBraceSideWebPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBraceSideWebPlateThickness.Location = New System.Drawing.Point(170, 58)
        Me.txtBraceSideWebPlateThickness.MaxLength = 0
        Me.txtBraceSideWebPlateThickness.Name = "txtBraceSideWebPlateThickness"
        Me.txtBraceSideWebPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBraceSideWebPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtBraceSideWebPlateThickness.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(14, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(169, 20)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "D0501'Chord Side Thk"
        '
        'txtChordSideWebPlateThickness
        '
        Me.txtChordSideWebPlateThickness.AcceptsReturn = True
        Me.txtChordSideWebPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtChordSideWebPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChordSideWebPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChordSideWebPlateThickness.Location = New System.Drawing.Point(170, 12)
        Me.txtChordSideWebPlateThickness.MaxLength = 0
        Me.txtChordSideWebPlateThickness.Name = "txtChordSideWebPlateThickness"
        Me.txtChordSideWebPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChordSideWebPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtChordSideWebPlateThickness.TabIndex = 102
        '
        'TabPageHorConnPlate
        '
        Me.TabPageHorConnPlate.Controls.Add(Me.Label25)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtVerMiddleDist)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label23)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtVerEdgeDist)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label24)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtVerDist)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label26)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtVerCount)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label28)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtHorCount)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label29)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtFlgConnPlateInsidePlateThk)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label30)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtHorDist)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label32)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtHorEdgeDist)
        Me.TabPageHorConnPlate.Controls.Add(Me.Label33)
        Me.TabPageHorConnPlate.Controls.Add(Me.txtFlgConnPlateOutsidePlateThk)
        Me.TabPageHorConnPlate.ForeColor = System.Drawing.Color.Red
        Me.TabPageHorConnPlate.Location = New System.Drawing.Point(4, 29)
        Me.TabPageHorConnPlate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHorConnPlate.Name = "TabPageHorConnPlate"
        Me.TabPageHorConnPlate.Size = New System.Drawing.Size(616, 439)
        Me.TabPageHorConnPlate.TabIndex = 13
        Me.TabPageHorConnPlate.Text = "D0600'Hor Flange Connect Plate"
        Me.TabPageHorConnPlate.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(316, 206)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(167, 20)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "D0609'Ver Middle Dist"
        '
        'txtVerMiddleDist
        '
        Me.txtVerMiddleDist.AcceptsReturn = True
        Me.txtVerMiddleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerMiddleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerMiddleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerMiddleDist.Location = New System.Drawing.Point(472, 200)
        Me.txtVerMiddleDist.MaxLength = 0
        Me.txtVerMiddleDist.Name = "txtVerMiddleDist"
        Me.txtVerMiddleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerMiddleDist.Size = New System.Drawing.Size(84, 26)
        Me.txtVerMiddleDist.TabIndex = 146
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(316, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(159, 20)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "D0606'Ver Edge Dist"
        '
        'txtVerEdgeDist
        '
        Me.txtVerEdgeDist.AcceptsReturn = True
        Me.txtVerEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerEdgeDist.Location = New System.Drawing.Point(472, 58)
        Me.txtVerEdgeDist.MaxLength = 0
        Me.txtVerEdgeDist.Name = "txtVerEdgeDist"
        Me.txtVerEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerEdgeDist.Size = New System.Drawing.Size(84, 26)
        Me.txtVerEdgeDist.TabIndex = 144
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(316, 111)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(117, 20)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "D0607'Ver Dist"
        '
        'txtVerDist
        '
        Me.txtVerDist.AcceptsReturn = True
        Me.txtVerDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerDist.Location = New System.Drawing.Point(472, 105)
        Me.txtVerDist.MaxLength = 0
        Me.txtVerDist.Name = "txtVerDist"
        Me.txtVerDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerDist.Size = New System.Drawing.Size(84, 26)
        Me.txtVerDist.TabIndex = 142
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(316, 158)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(132, 20)
        Me.Label26.TabIndex = 139
        Me.Label26.Text = "D0608'Ver Count"
        '
        'txtVerCount
        '
        Me.txtVerCount.AcceptsReturn = True
        Me.txtVerCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerCount.Location = New System.Drawing.Point(472, 152)
        Me.txtVerCount.MaxLength = 0
        Me.txtVerCount.Name = "txtVerCount"
        Me.txtVerCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerCount.Size = New System.Drawing.Size(84, 26)
        Me.txtVerCount.TabIndex = 138
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(14, 157)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(133, 20)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "D0605'Hor Count"
        '
        'txtHorCount
        '
        Me.txtHorCount.AcceptsReturn = True
        Me.txtHorCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorCount.Location = New System.Drawing.Point(170, 151)
        Me.txtHorCount.MaxLength = 0
        Me.txtHorCount.Name = "txtHorCount"
        Me.txtHorCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorCount.Size = New System.Drawing.Size(84, 26)
        Me.txtHorCount.TabIndex = 134
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(316, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(156, 20)
        Me.Label29.TabIndex = 133
        Me.Label29.Text = "D0505'Inside PL Thk"
        '
        'txtFlgConnPlateInsidePlateThk
        '
        Me.txtFlgConnPlateInsidePlateThk.AcceptsReturn = True
        Me.txtFlgConnPlateInsidePlateThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlgConnPlateInsidePlateThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlgConnPlateInsidePlateThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlgConnPlateInsidePlateThk.Location = New System.Drawing.Point(472, 12)
        Me.txtFlgConnPlateInsidePlateThk.MaxLength = 0
        Me.txtFlgConnPlateInsidePlateThk.Name = "txtFlgConnPlateInsidePlateThk"
        Me.txtFlgConnPlateInsidePlateThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlgConnPlateInsidePlateThk.Size = New System.Drawing.Size(84, 26)
        Me.txtFlgConnPlateInsidePlateThk.TabIndex = 132
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(14, 111)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(118, 20)
        Me.Label30.TabIndex = 131
        Me.Label30.Text = "D0604'Hor Dist"
        '
        'txtHorDist
        '
        Me.txtHorDist.AcceptsReturn = True
        Me.txtHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorDist.Location = New System.Drawing.Point(170, 105)
        Me.txtHorDist.MaxLength = 0
        Me.txtHorDist.Name = "txtHorDist"
        Me.txtHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorDist.Size = New System.Drawing.Size(84, 26)
        Me.txtHorDist.TabIndex = 130
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(14, 65)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(160, 20)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "D0603'Hor Edge Dist"
        '
        'txtHorEdgeDist
        '
        Me.txtHorEdgeDist.AcceptsReturn = True
        Me.txtHorEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorEdgeDist.Location = New System.Drawing.Point(170, 58)
        Me.txtHorEdgeDist.MaxLength = 0
        Me.txtHorEdgeDist.Name = "txtHorEdgeDist"
        Me.txtHorEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorEdgeDist.Size = New System.Drawing.Size(84, 26)
        Me.txtHorEdgeDist.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(14, 18)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(168, 20)
        Me.Label33.TabIndex = 125
        Me.Label33.Text = "D0601'Outside PL Thk"
        '
        'txtFlgConnPlateOutsidePlateThk
        '
        Me.txtFlgConnPlateOutsidePlateThk.AcceptsReturn = True
        Me.txtFlgConnPlateOutsidePlateThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlgConnPlateOutsidePlateThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlgConnPlateOutsidePlateThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlgConnPlateOutsidePlateThk.Location = New System.Drawing.Point(170, 12)
        Me.txtFlgConnPlateOutsidePlateThk.MaxLength = 0
        Me.txtFlgConnPlateOutsidePlateThk.Name = "txtFlgConnPlateOutsidePlateThk"
        Me.txtFlgConnPlateOutsidePlateThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlgConnPlateOutsidePlateThk.Size = New System.Drawing.Size(84, 26)
        Me.txtFlgConnPlateOutsidePlateThk.TabIndex = 124
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
        'TabPageDiagConnPlate
        '
        Me.TabPageDiagConnPlate.Controls.Add(Me.Label44)
        Me.TabPageDiagConnPlate.Controls.Add(Me.TextBox6)
        Me.TabPageDiagConnPlate.Controls.Add(Me.Label47)
        Me.TabPageDiagConnPlate.Controls.Add(Me.TextBox9)
        Me.TabPageDiagConnPlate.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDiagConnPlate.Name = "TabPageDiagConnPlate"
        Me.TabPageDiagConnPlate.Size = New System.Drawing.Size(616, 439)
        Me.TabPageDiagConnPlate.TabIndex = 14
        Me.TabPageDiagConnPlate.Text = "D0700'Diag Flange Connect Plate"
        Me.TabPageDiagConnPlate.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(323, 21)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(156, 20)
        Me.Label44.TabIndex = 155
        Me.Label44.Text = "D0505'Inside PL Thk"
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox6.Location = New System.Drawing.Point(479, 15)
        Me.TextBox6.MaxLength = 0
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(84, 26)
        Me.TextBox6.TabIndex = 154
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(21, 21)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(168, 20)
        Me.Label47.TabIndex = 149
        Me.Label47.Text = "D0601'Outside PL Thk"
        '
        'TextBox9
        '
        Me.TextBox9.AcceptsReturn = True
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox9.Location = New System.Drawing.Point(177, 15)
        Me.TextBox9.MaxLength = 0
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox9.Size = New System.Drawing.Size(84, 26)
        Me.TextBox9.TabIndex = 148
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(276, 247)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(170, 20)
        Me.Label27.TabIndex = 123
        Me.Label27.Text = "D0114,'Backing PL thk"
        '
        'txtBackingPlateThickness
        '
        Me.txtBackingPlateThickness.AcceptsReturn = True
        Me.txtBackingPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtBackingPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackingPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBackingPlateThickness.Location = New System.Drawing.Point(426, 243)
        Me.txtBackingPlateThickness.MaxLength = 0
        Me.txtBackingPlateThickness.Name = "txtBackingPlateThickness"
        Me.txtBackingPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackingPlateThickness.Size = New System.Drawing.Size(84, 26)
        Me.txtBackingPlateThickness.TabIndex = 122
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
        Me.TabPageMiddleWebConnPlate.ResumeLayout(False)
        Me.TabPageMiddleWebConnPlate.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPageHorConnPlate.ResumeLayout(False)
        Me.TabPageHorConnPlate.PerformLayout()
        Me.TabPageDiagConnPlate.ResumeLayout(False)
        Me.TabPageDiagConnPlate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPageSidePlate As System.Windows.Forms.TabPage
    Public WithEvents _TabFrames_0 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPageGeneral As System.Windows.Forms.TabPage
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtHorGap As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtDiagnalCutback As System.Windows.Forms.TextBox
    Public WithEvents Label8 As Windows.Forms.Label
    Public WithEvents txtHorFlangeCutBack As Windows.Forms.TextBox
    Public WithEvents Label7 As Windows.Forms.Label
    Public WithEvents txtHorCutBack As Windows.Forms.TextBox
    Public WithEvents Label10 As Windows.Forms.Label
    Public WithEvents txtTopDiagDist As Windows.Forms.TextBox
    Public WithEvents Label12 As Windows.Forms.Label
    Public WithEvents txtTopHorDist As Windows.Forms.TextBox
    Public WithEvents Label5 As Windows.Forms.Label
    Public WithEvents txtDiagAngle As Windows.Forms.TextBox
    Public WithEvents Label6 As Windows.Forms.Label
    Public WithEvents txtDiagFillet As Windows.Forms.TextBox
    Public WithEvents Label2 As Windows.Forms.Label
    Public WithEvents txtHorAngle As Windows.Forms.TextBox
    Public WithEvents Label1 As Windows.Forms.Label
    Public WithEvents txtHorFillet As Windows.Forms.TextBox
    Friend WithEvents TabPageMiddleWebConnPlate As Windows.Forms.TabPage
    Public WithEvents Label9 As Windows.Forms.Label
    Public WithEvents txtHorPlateThickness As Windows.Forms.TextBox
    Public WithEvents Label11 As Windows.Forms.Label
    Public WithEvents txtChordSideWebPlateThickness As Windows.Forms.TextBox
    Public WithEvents Label22 As Windows.Forms.Label
    Public WithEvents txtSupportPlateThickness As Windows.Forms.TextBox
    Public WithEvents Label21 As Windows.Forms.Label
    Public WithEvents txtVerHoleDist As Windows.Forms.TextBox
    Public WithEvents Label20 As Windows.Forms.Label
    Public WithEvents txtVerHoleCount As Windows.Forms.TextBox
    Public WithEvents Label19 As Windows.Forms.Label
    Public WithEvents txtVerHoleEdgeDist As Windows.Forms.TextBox
    Public WithEvents Label18 As Windows.Forms.Label
    Public WithEvents txtHorHoleEdgeDist As Windows.Forms.TextBox
    Public WithEvents Label17 As Windows.Forms.Label
    Public WithEvents txtHorHoleDist As Windows.Forms.TextBox
    Public WithEvents Label16 As Windows.Forms.Label
    Public WithEvents txtSupportPlateOffset As Windows.Forms.TextBox
    Public WithEvents Label15 As Windows.Forms.Label
    Public WithEvents txtBraceSideWebPlateLength As Windows.Forms.TextBox
    Public WithEvents Label13 As Windows.Forms.Label
    Public WithEvents txtBraceSideWebPlateThickness As Windows.Forms.TextBox
    Friend WithEvents TabPageHorConnPlate As Windows.Forms.TabPage
    Public WithEvents Label23 As Windows.Forms.Label
    Public WithEvents txtVerEdgeDist As Windows.Forms.TextBox
    Public WithEvents Label24 As Windows.Forms.Label
    Public WithEvents txtVerDist As Windows.Forms.TextBox
    Public WithEvents Label26 As Windows.Forms.Label
    Public WithEvents txtVerCount As Windows.Forms.TextBox
    Public WithEvents Label28 As Windows.Forms.Label
    Public WithEvents txtHorCount As Windows.Forms.TextBox
    Public WithEvents Label29 As Windows.Forms.Label
    Public WithEvents txtFlgConnPlateInsidePlateThk As Windows.Forms.TextBox
    Public WithEvents Label30 As Windows.Forms.Label
    Public WithEvents txtHorDist As Windows.Forms.TextBox
    Public WithEvents Label32 As Windows.Forms.Label
    Public WithEvents txtHorEdgeDist As Windows.Forms.TextBox
    Public WithEvents Label33 As Windows.Forms.Label
    Public WithEvents txtFlgConnPlateOutsidePlateThk As Windows.Forms.TextBox
    Public WithEvents Label34 As Windows.Forms.Label
    Public WithEvents Label60 As Windows.Forms.Label
    Public WithEvents txtHoleDia As Windows.Forms.TextBox
    Public WithEvents txtDiagnalGap As Windows.Forms.TextBox
    Public WithEvents Label14 As Windows.Forms.Label
    Public WithEvents txtInsidePlateThickness As Windows.Forms.TextBox
    Public WithEvents Label31 As Windows.Forms.Label
    Public WithEvents txtOutsidePlateThickness As Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Public WithEvents Label36 As Windows.Forms.Label
    Public WithEvents txtHoleDiameter As Windows.Forms.TextBox
    Public WithEvents Label35 As Windows.Forms.Label
    Public WithEvents txtHorHoleCount As Windows.Forms.TextBox
    Public WithEvents Label37 As Windows.Forms.Label
    Public WithEvents txtConnectPlateThickness As Windows.Forms.TextBox
    Public WithEvents Label38 As Windows.Forms.Label
    Public WithEvents txtBottomDiagDist As Windows.Forms.TextBox
    Public WithEvents Label39 As Windows.Forms.Label
    Public WithEvents txtBottomHorDist As Windows.Forms.TextBox
    Public WithEvents Label25 As Windows.Forms.Label
    Public WithEvents txtVerMiddleDist As Windows.Forms.TextBox
    Friend WithEvents TabPageDiagConnPlate As Windows.Forms.TabPage
    Public WithEvents Label44 As Windows.Forms.Label
    Public WithEvents TextBox6 As Windows.Forms.TextBox
    Public WithEvents Label47 As Windows.Forms.Label
    Public WithEvents TextBox9 As Windows.Forms.TextBox
    Public WithEvents Label27 As Windows.Forms.Label
    Public WithEvents txtBackingPlateThickness As Windows.Forms.TextBox
#End Region
End Class