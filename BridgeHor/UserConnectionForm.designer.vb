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
        Me.TabPageConnPlate1 = New System.Windows.Forms.TabPage()
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
        Me.TabPageConnPlate1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.TabStrip1.Controls.Add(Me.TabPageGeneral)
        Me.TabStrip1.Controls.Add(Me.TabPageSidePlate)
        Me.TabStrip1.Controls.Add(Me.TabPageConnPlate1)
        Me.TabStrip1.Controls.Add(Me.TabPageConnPlate2)
        Me.TabStrip1.Controls.Add(Me.TabPageWebConnPlate1)
        Me.TabStrip1.Controls.Add(Me.TabPageWebConnPlate2)
        Me.TabStrip1.Location = New System.Drawing.Point(4, 9)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(416, 307)
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
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(408, 281)
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
        Me.txtDiagnalGap.Location = New System.Drawing.Point(320, 38)
        Me.txtDiagnalGap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagnalGap.MaxLength = 0
        Me.txtDiagnalGap.Name = "txtDiagnalGap"
        Me.txtDiagnalGap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagnalGap.Size = New System.Drawing.Size(57, 20)
        Me.txtDiagnalGap.TabIndex = 144
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(9, 132)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(82, 13)
        Me.Label60.TabIndex = 139
        Me.Label60.Text = "D0408'Hole Dia"
        '
        'txtHoleDia
        '
        Me.txtHoleDia.AcceptsReturn = True
        Me.txtHoleDia.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleDia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleDia.Location = New System.Drawing.Point(131, 128)
        Me.txtHoleDia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoleDia.MaxLength = 0
        Me.txtHoleDia.Name = "txtHoleDia"
        Me.txtHoleDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleDia.Size = New System.Drawing.Size(57, 20)
        Me.txtHoleDia.TabIndex = 138
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(202, 41)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(100, 13)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "D0406'Diagnal Gap"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(9, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "D0405'Main Chord PL Thk"
        '
        'txtHorPlateThickness
        '
        Me.txtHorPlateThickness.AcceptsReturn = True
        Me.txtHorPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorPlateThickness.Location = New System.Drawing.Point(131, 98)
        Me.txtHorPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorPlateThickness.MaxLength = 0
        Me.txtHorPlateThickness.Name = "txtHorPlateThickness"
        Me.txtHorPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtHorPlateThickness.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(130, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "D0402'Hor Web Cut back"
        '
        'txtHorFlangeCutBack
        '
        Me.txtHorFlangeCutBack.AcceptsReturn = True
        Me.txtHorFlangeCutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorFlangeCutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorFlangeCutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorFlangeCutBack.Location = New System.Drawing.Point(131, 38)
        Me.txtHorFlangeCutBack.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorFlangeCutBack.MaxLength = 0
        Me.txtHorFlangeCutBack.Name = "txtHorFlangeCutBack"
        Me.txtHorFlangeCutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorFlangeCutBack.Size = New System.Drawing.Size(57, 20)
        Me.txtHorFlangeCutBack.TabIndex = 98
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
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "D0401'Hor Cut back"
        '
        'txtHorCutBack
        '
        Me.txtHorCutBack.AcceptsReturn = True
        Me.txtHorCutBack.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorCutBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorCutBack.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorCutBack.Location = New System.Drawing.Point(131, 8)
        Me.txtHorCutBack.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorCutBack.MaxLength = 0
        Me.txtHorCutBack.Name = "txtHorCutBack"
        Me.txtHorCutBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorCutBack.Size = New System.Drawing.Size(57, 20)
        Me.txtHorCutBack.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(202, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "D0404'Hor Gap"
        '
        'txtHorGap
        '
        Me.txtHorGap.AcceptsReturn = True
        Me.txtHorGap.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorGap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorGap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorGap.Location = New System.Drawing.Point(320, 9)
        Me.txtHorGap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorGap.MaxLength = 0
        Me.txtHorGap.Name = "txtHorGap"
        Me.txtHorGap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorGap.Size = New System.Drawing.Size(57, 20)
        Me.txtHorGap.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D0403'Diagnal Cut back"
        '
        'txtDiagnalCutback
        '
        Me.txtDiagnalCutback.AcceptsReturn = True
        Me.txtDiagnalCutback.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagnalCutback.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnalCutback.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagnalCutback.Location = New System.Drawing.Point(131, 68)
        Me.txtDiagnalCutback.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagnalCutback.MaxLength = 0
        Me.txtDiagnalCutback.Name = "txtDiagnalCutback"
        Me.txtDiagnalCutback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagnalCutback.Size = New System.Drawing.Size(57, 20)
        Me.txtDiagnalCutback.TabIndex = 84
        '
        'TabPageSidePlate
        '
        Me.TabPageSidePlate.Controls.Add(Me._TabFrames_0)
        Me.TabPageSidePlate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSidePlate.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageSidePlate.Name = "TabPageSidePlate"
        Me.TabPageSidePlate.Size = New System.Drawing.Size(408, 281)
        Me.TabPageSidePlate.TabIndex = 0
        Me.TabPageSidePlate.Text = "D0100'Side Plate"
        Me.TabPageSidePlate.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
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
        Me._TabFrames_0.Margin = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.Padding = New System.Windows.Forms.Padding(2)
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(408, 281)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(184, 102)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(120, 13)
        Me.Label38.TabIndex = 121
        Me.Label38.Text = "D0113'Diag Bottom Dist"
        '
        'txtBottomDiagDist
        '
        Me.txtBottomDiagDist.AcceptsReturn = True
        Me.txtBottomDiagDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomDiagDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomDiagDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomDiagDist.Location = New System.Drawing.Point(284, 100)
        Me.txtBottomDiagDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBottomDiagDist.MaxLength = 0
        Me.txtBottomDiagDist.Name = "txtBottomDiagDist"
        Me.txtBottomDiagDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomDiagDist.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomDiagDist.TabIndex = 120
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(12, 103)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(115, 13)
        Me.Label39.TabIndex = 119
        Me.Label39.Text = "D0112'Hor Bottom Dist"
        '
        'txtBottomHorDist
        '
        Me.txtBottomHorDist.AcceptsReturn = True
        Me.txtBottomHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomHorDist.Location = New System.Drawing.Point(113, 101)
        Me.txtBottomHorDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBottomHorDist.MaxLength = 0
        Me.txtBottomHorDist.Name = "txtBottomHorDist"
        Me.txtBottomHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomHorDist.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomHorDist.TabIndex = 118
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(184, 131)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "D0111'Inside PL thk"
        '
        'txtInsidePlateThickness
        '
        Me.txtInsidePlateThickness.AcceptsReturn = True
        Me.txtInsidePlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsidePlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsidePlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsidePlateThickness.Location = New System.Drawing.Point(284, 129)
        Me.txtInsidePlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInsidePlateThickness.MaxLength = 0
        Me.txtInsidePlateThickness.Name = "txtInsidePlateThickness"
        Me.txtInsidePlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsidePlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtInsidePlateThickness.TabIndex = 116
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(12, 132)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(111, 13)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "D0110'Outside PL thk"
        '
        'txtOutsidePlateThickness
        '
        Me.txtOutsidePlateThickness.AcceptsReturn = True
        Me.txtOutsidePlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutsidePlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutsidePlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutsidePlateThickness.Location = New System.Drawing.Point(113, 130)
        Me.txtOutsidePlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOutsidePlateThickness.MaxLength = 0
        Me.txtOutsidePlateThickness.Name = "txtOutsidePlateThickness"
        Me.txtOutsidePlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOutsidePlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtOutsidePlateThickness.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(183, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "D0109'Diag Dist"
        '
        'txtTopDiagDist
        '
        Me.txtTopDiagDist.AcceptsReturn = True
        Me.txtTopDiagDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopDiagDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopDiagDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopDiagDist.Location = New System.Drawing.Point(284, 70)
        Me.txtTopDiagDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTopDiagDist.MaxLength = 0
        Me.txtTopDiagDist.Name = "txtTopDiagDist"
        Me.txtTopDiagDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopDiagDist.Size = New System.Drawing.Size(57, 20)
        Me.txtTopDiagDist.TabIndex = 112
        '
        'txtHorFillet
        '
        Me.txtHorFillet.AcceptsReturn = True
        Me.txtHorFillet.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorFillet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorFillet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorFillet.Location = New System.Drawing.Point(113, 16)
        Me.txtHorFillet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorFillet.MaxLength = 0
        Me.txtHorFillet.Name = "txtHorFillet"
        Me.txtHorFillet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorFillet.Size = New System.Drawing.Size(57, 20)
        Me.txtHorFillet.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(12, 71)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "D0107'Hor Dist"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "D0102'Hor Fillet"
        '
        'txtTopHorDist
        '
        Me.txtTopHorDist.AcceptsReturn = True
        Me.txtTopHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopHorDist.Location = New System.Drawing.Point(113, 70)
        Me.txtTopHorDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTopHorDist.MaxLength = 0
        Me.txtTopHorDist.Name = "txtTopHorDist"
        Me.txtTopHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopHorDist.Size = New System.Drawing.Size(57, 20)
        Me.txtTopHorDist.TabIndex = 108
        '
        'txtHorAngle
        '
        Me.txtHorAngle.AcceptsReturn = True
        Me.txtHorAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorAngle.Location = New System.Drawing.Point(113, 43)
        Me.txtHorAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorAngle.MaxLength = 0
        Me.txtHorAngle.Name = "txtHorAngle"
        Me.txtHorAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorAngle.Size = New System.Drawing.Size(57, 20)
        Me.txtHorAngle.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(183, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "D0105'Diag Angle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "D0103'Hor Angle"
        '
        'txtDiagAngle
        '
        Me.txtDiagAngle.AcceptsReturn = True
        Me.txtDiagAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagAngle.Location = New System.Drawing.Point(284, 43)
        Me.txtDiagAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagAngle.MaxLength = 0
        Me.txtDiagAngle.Name = "txtDiagAngle"
        Me.txtDiagAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagAngle.Size = New System.Drawing.Size(57, 20)
        Me.txtDiagAngle.TabIndex = 106
        '
        'txtDiagFillet
        '
        Me.txtDiagFillet.AcceptsReturn = True
        Me.txtDiagFillet.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagFillet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagFillet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagFillet.Location = New System.Drawing.Point(284, 16)
        Me.txtDiagFillet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagFillet.MaxLength = 0
        Me.txtDiagFillet.Name = "txtDiagFillet"
        Me.txtDiagFillet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagFillet.Size = New System.Drawing.Size(57, 20)
        Me.txtDiagFillet.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(183, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "D0104'Diag Fillet"
        '
        'TabPageConnPlate1
        '
        Me.TabPageConnPlate1.Controls.Add(Me.GroupBox5)
        Me.TabPageConnPlate1.Controls.Add(Me.Label22)
        Me.TabPageConnPlate1.Controls.Add(Me.txtSupportPlateThickness)
        Me.TabPageConnPlate1.Controls.Add(Me.Label16)
        Me.TabPageConnPlate1.Controls.Add(Me.txtSupportPlateOffset)
        Me.TabPageConnPlate1.Controls.Add(Me.Label15)
        Me.TabPageConnPlate1.Controls.Add(Me.txtBraceSideWebPlateLength)
        Me.TabPageConnPlate1.Controls.Add(Me.Label13)
        Me.TabPageConnPlate1.Controls.Add(Me.txtBraceSideWebPlateThickness)
        Me.TabPageConnPlate1.Controls.Add(Me.Label11)
        Me.TabPageConnPlate1.Controls.Add(Me.txtChordSideWebPlateThickness)
        Me.TabPageConnPlate1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConnPlate1.Name = "TabPageConnPlate1"
        Me.TabPageConnPlate1.Size = New System.Drawing.Size(408, 281)
        Me.TabPageConnPlate1.TabIndex = 12
        Me.TabPageConnPlate1.Text = "D0500'Middle Web Plates"
        Me.TabPageConnPlate1.UseVisualStyleBackColor = True
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
        Me.GroupBox5.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(389, 146)
        Me.GroupBox5.TabIndex = 124
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "D0506'Connect Plates"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(209, 23)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(77, 13)
        Me.Label37.TabIndex = 127
        Me.Label37.Text = "D514'Plate thk"
        '
        'txtConnectPlateThickness
        '
        Me.txtConnectPlateThickness.AcceptsReturn = True
        Me.txtConnectPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtConnectPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConnectPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConnectPlateThickness.Location = New System.Drawing.Point(313, 21)
        Me.txtConnectPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnectPlateThickness.MaxLength = 0
        Me.txtConnectPlateThickness.Name = "txtConnectPlateThickness"
        Me.txtConnectPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnectPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtConnectPlateThickness.TabIndex = 126
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.ForeColor = System.Drawing.Color.Red
        Me.Label36.Location = New System.Drawing.Point(11, 23)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(82, 13)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "D0513'Hole Dia"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(11, 117)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(89, 13)
        Me.Label35.TabIndex = 123
        Me.Label35.Text = "D0511'Hor Count"
        '
        'txtHoleDiameter
        '
        Me.txtHoleDiameter.AcceptsReturn = True
        Me.txtHoleDiameter.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleDiameter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleDiameter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleDiameter.Location = New System.Drawing.Point(115, 21)
        Me.txtHoleDiameter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoleDiameter.MaxLength = 0
        Me.txtHoleDiameter.Name = "txtHoleDiameter"
        Me.txtHoleDiameter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleDiameter.Size = New System.Drawing.Size(57, 20)
        Me.txtHoleDiameter.TabIndex = 124
        '
        'txtHorHoleCount
        '
        Me.txtHorHoleCount.AcceptsReturn = True
        Me.txtHorHoleCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleCount.Location = New System.Drawing.Point(115, 115)
        Me.txtHorHoleCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorHoleCount.MaxLength = 0
        Me.txtHorHoleCount.Name = "txtHorHoleCount"
        Me.txtHorHoleCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleCount.Size = New System.Drawing.Size(57, 20)
        Me.txtHorHoleCount.TabIndex = 122
        '
        'txtHorHoleDist
        '
        Me.txtHorHoleDist.AcceptsReturn = True
        Me.txtHorHoleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleDist.Location = New System.Drawing.Point(115, 52)
        Me.txtHorHoleDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorHoleDist.MaxLength = 0
        Me.txtHorHoleDist.Name = "txtHorHoleDist"
        Me.txtHorHoleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleDist.Size = New System.Drawing.Size(57, 20)
        Me.txtHorHoleDist.TabIndex = 112
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(11, 54)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "D0507'Hor Dist"
        '
        'txtHorHoleEdgeDist
        '
        Me.txtHorHoleEdgeDist.AcceptsReturn = True
        Me.txtHorHoleEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorHoleEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorHoleEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorHoleEdgeDist.Location = New System.Drawing.Point(115, 83)
        Me.txtHorHoleEdgeDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorHoleEdgeDist.MaxLength = 0
        Me.txtHorHoleEdgeDist.Name = "txtHorHoleEdgeDist"
        Me.txtHorHoleEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorHoleEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtHorHoleEdgeDist.TabIndex = 114
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(209, 54)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 121
        Me.Label21.Text = "D0508'Ver Dist"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(11, 84)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(107, 13)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "D0509'Hor Edge Dist"
        '
        'txtVerHoleDist
        '
        Me.txtVerHoleDist.AcceptsReturn = True
        Me.txtVerHoleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleDist.Location = New System.Drawing.Point(313, 52)
        Me.txtVerHoleDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerHoleDist.MaxLength = 0
        Me.txtVerHoleDist.Name = "txtVerHoleDist"
        Me.txtVerHoleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleDist.Size = New System.Drawing.Size(57, 20)
        Me.txtVerHoleDist.TabIndex = 120
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(209, 117)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "D0512'Ver Count"
        '
        'txtVerHoleEdgeDist
        '
        Me.txtVerHoleEdgeDist.AcceptsReturn = True
        Me.txtVerHoleEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleEdgeDist.Location = New System.Drawing.Point(313, 83)
        Me.txtVerHoleEdgeDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerHoleEdgeDist.MaxLength = 0
        Me.txtVerHoleEdgeDist.Name = "txtVerHoleEdgeDist"
        Me.txtVerHoleEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtVerHoleEdgeDist.TabIndex = 116
        '
        'txtVerHoleCount
        '
        Me.txtVerHoleCount.AcceptsReturn = True
        Me.txtVerHoleCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerHoleCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerHoleCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerHoleCount.Location = New System.Drawing.Point(313, 115)
        Me.txtVerHoleCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerHoleCount.MaxLength = 0
        Me.txtVerHoleCount.Name = "txtVerHoleCount"
        Me.txtVerHoleCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerHoleCount.Size = New System.Drawing.Size(57, 20)
        Me.txtVerHoleCount.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(209, 84)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(106, 13)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "D0510'Ver Edge Dist"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(211, 42)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(127, 13)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "D0505'Support Plate Thk"
        '
        'txtSupportPlateThickness
        '
        Me.txtSupportPlateThickness.AcceptsReturn = True
        Me.txtSupportPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportPlateThickness.Location = New System.Drawing.Point(315, 38)
        Me.txtSupportPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupportPlateThickness.MaxLength = 0
        Me.txtSupportPlateThickness.Name = "txtSupportPlateThickness"
        Me.txtSupportPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtSupportPlateThickness.TabIndex = 122
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(211, 12)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(136, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "D0504'Support Plate Offset"
        '
        'txtSupportPlateOffset
        '
        Me.txtSupportPlateOffset.AcceptsReturn = True
        Me.txtSupportPlateOffset.BackColor = System.Drawing.SystemColors.Window
        Me.txtSupportPlateOffset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupportPlateOffset.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSupportPlateOffset.Location = New System.Drawing.Point(315, 8)
        Me.txtSupportPlateOffset.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupportPlateOffset.MaxLength = 0
        Me.txtSupportPlateOffset.Name = "txtSupportPlateOffset"
        Me.txtSupportPlateOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupportPlateOffset.Size = New System.Drawing.Size(57, 20)
        Me.txtSupportPlateOffset.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(9, 72)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(114, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "D0503'Brace Side Len"
        '
        'txtBraceSideWebPlateLength
        '
        Me.txtBraceSideWebPlateLength.AcceptsReturn = True
        Me.txtBraceSideWebPlateLength.BackColor = System.Drawing.SystemColors.Window
        Me.txtBraceSideWebPlateLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBraceSideWebPlateLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBraceSideWebPlateLength.Location = New System.Drawing.Point(113, 68)
        Me.txtBraceSideWebPlateLength.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBraceSideWebPlateLength.MaxLength = 0
        Me.txtBraceSideWebPlateLength.Name = "txtBraceSideWebPlateLength"
        Me.txtBraceSideWebPlateLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBraceSideWebPlateLength.Size = New System.Drawing.Size(57, 20)
        Me.txtBraceSideWebPlateLength.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(9, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "D0502'Brace Side Thk"
        '
        'txtBraceSideWebPlateThickness
        '
        Me.txtBraceSideWebPlateThickness.AcceptsReturn = True
        Me.txtBraceSideWebPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtBraceSideWebPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBraceSideWebPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBraceSideWebPlateThickness.Location = New System.Drawing.Point(113, 38)
        Me.txtBraceSideWebPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBraceSideWebPlateThickness.MaxLength = 0
        Me.txtBraceSideWebPlateThickness.Name = "txtBraceSideWebPlateThickness"
        Me.txtBraceSideWebPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBraceSideWebPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtBraceSideWebPlateThickness.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(9, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "D0501'Chord Side Thk"
        '
        'txtChordSideWebPlateThickness
        '
        Me.txtChordSideWebPlateThickness.AcceptsReturn = True
        Me.txtChordSideWebPlateThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtChordSideWebPlateThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChordSideWebPlateThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChordSideWebPlateThickness.Location = New System.Drawing.Point(113, 8)
        Me.txtChordSideWebPlateThickness.Margin = New System.Windows.Forms.Padding(2)
        Me.txtChordSideWebPlateThickness.MaxLength = 0
        Me.txtChordSideWebPlateThickness.Name = "txtChordSideWebPlateThickness"
        Me.txtChordSideWebPlateThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChordSideWebPlateThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtChordSideWebPlateThickness.TabIndex = 102
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
        Me.TabPageConnPlate2.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConnPlate2.Name = "TabPageConnPlate2"
        Me.TabPageConnPlate2.Size = New System.Drawing.Size(408, 281)
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
        Me.Label23.Location = New System.Drawing.Point(211, 42)
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
        Me.txtConnect2Thickness.Location = New System.Drawing.Point(315, 38)
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
        Me.Label24.Location = New System.Drawing.Point(211, 72)
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
        Me.txtConnect2Angle.Location = New System.Drawing.Point(315, 68)
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
        Me.Label25.Location = New System.Drawing.Point(211, 133)
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
        Me.txtConnect2innerWebDist.Location = New System.Drawing.Point(315, 129)
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
        Me.Label26.Location = New System.Drawing.Point(211, 103)
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
        Me.txtConnect2innerWebCount.Location = New System.Drawing.Point(315, 99)
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
        Me.Label27.Location = New System.Drawing.Point(9, 132)
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
        Me.txtConnect2innerWebThickness.Location = New System.Drawing.Point(113, 128)
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
        Me.Label28.Location = New System.Drawing.Point(9, 102)
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
        Me.txtConnect2InnerWebHeight.Location = New System.Drawing.Point(113, 98)
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
        Me.Label29.Location = New System.Drawing.Point(211, 12)
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
        Me.txtConnect2Width.Location = New System.Drawing.Point(315, 8)
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
        Me.Label30.Location = New System.Drawing.Point(9, 72)
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
        Me.txtConnect2Length.Location = New System.Drawing.Point(113, 68)
        Me.txtConnect2Length.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnect2Length.MaxLength = 0
        Me.txtConnect2Length.Name = "txtConnect2Length"
        Me.txtConnect2Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConnect2Length.Size = New System.Drawing.Size(57, 20)
        Me.txtConnect2Length.TabIndex = 130
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(9, 42)
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
        Me.Label33.Location = New System.Drawing.Point(9, 12)
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
        'TabPageWebConnPlate1
        '
        Me.TabPageWebConnPlate1.Controls.Add(Me.GroupBox2)
        Me.TabPageWebConnPlate1.Controls.Add(Me.GroupBox1)
        Me.TabPageWebConnPlate1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageWebConnPlate1.Name = "TabPageWebConnPlate1"
        Me.TabPageWebConnPlate1.Size = New System.Drawing.Size(408, 281)
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 181)
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
        Me.Label62.Location = New System.Drawing.Point(208, 141)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(133, 13)
        Me.Label62.TabIndex = 167
        Me.Label62.Text = "D0713'Inner Ver Edge Dist"
        '
        'txtWebConnectPlateInnerVerEdgeDist1
        '
        Me.txtWebConnectPlateInnerVerEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateInnerVerEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateInnerVerEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateInnerVerEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateInnerVerEdgeDist1.Location = New System.Drawing.Point(322, 138)
        Me.txtWebConnectPlateInnerVerEdgeDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateInnerVerEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateInnerVerEdgeDist1.Name = "txtWebConnectPlateInnerVerEdgeDist1"
        Me.txtWebConnectPlateInnerVerEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateInnerVerEdgeDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateInnerVerEdgeDist1.TabIndex = 166
        '
        'txtWebConnectPlateThickness1
        '
        Me.txtWebConnectPlateThickness1.AcceptsReturn = True
        Me.txtWebConnectPlateThickness1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateThickness1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateThickness1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateThickness1.Location = New System.Drawing.Point(121, 18)
        Me.txtWebConnectPlateThickness1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateThickness1.MaxLength = 0
        Me.txtWebConnectPlateThickness1.Name = "txtWebConnectPlateThickness1"
        Me.txtWebConnectPlateThickness1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateThickness1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateThickness1.TabIndex = 146
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(17, 21)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(90, 13)
        Me.Label61.TabIndex = 147
        Me.Label61.Text = "D0701'Thickness"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(208, 111)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(88, 13)
        Me.Label56.TabIndex = 157
        Me.Label56.Text = "D0712'Ver Count"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(17, 111)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(89, 13)
        Me.Label54.TabIndex = 161
        Me.Label54.Text = "D0710'Hor Count"
        '
        'txtWebConnectPlateVerCount1
        '
        Me.txtWebConnectPlateVerCount1.AcceptsReturn = True
        Me.txtWebConnectPlateVerCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerCount1.Location = New System.Drawing.Point(322, 108)
        Me.txtWebConnectPlateVerCount1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerCount1.MaxLength = 0
        Me.txtWebConnectPlateVerCount1.Name = "txtWebConnectPlateVerCount1"
        Me.txtWebConnectPlateVerCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerCount1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerCount1.TabIndex = 156
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(207, 51)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(106, 13)
        Me.Label52.TabIndex = 165
        Me.Label52.Text = "D0708'Edge Ver Dist"
        '
        'txtWebConnectPlateHorCount1
        '
        Me.txtWebConnectPlateHorCount1.AcceptsReturn = True
        Me.txtWebConnectPlateHorCount1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorCount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorCount1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorCount1.Location = New System.Drawing.Point(121, 108)
        Me.txtWebConnectPlateHorCount1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorCount1.MaxLength = 0
        Me.txtWebConnectPlateHorCount1.Name = "txtWebConnectPlateHorCount1"
        Me.txtWebConnectPlateHorCount1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorCount1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorCount1.TabIndex = 160
        '
        'txtWebConnectPlateHorEdgeDist1
        '
        Me.txtWebConnectPlateHorEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateHorEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorEdgeDist1.Location = New System.Drawing.Point(121, 48)
        Me.txtWebConnectPlateHorEdgeDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateHorEdgeDist1.Name = "txtWebConnectPlateHorEdgeDist1"
        Me.txtWebConnectPlateHorEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorEdgeDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorEdgeDist1.TabIndex = 152
        '
        'txtWebConnectPlateVerEdgeDist1
        '
        Me.txtWebConnectPlateVerEdgeDist1.AcceptsReturn = True
        Me.txtWebConnectPlateVerEdgeDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerEdgeDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerEdgeDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerEdgeDist1.Location = New System.Drawing.Point(321, 48)
        Me.txtWebConnectPlateVerEdgeDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerEdgeDist1.MaxLength = 0
        Me.txtWebConnectPlateVerEdgeDist1.Name = "txtWebConnectPlateVerEdgeDist1"
        Me.txtWebConnectPlateVerEdgeDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerEdgeDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerEdgeDist1.TabIndex = 164
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(208, 81)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(78, 13)
        Me.Label53.TabIndex = 163
        Me.Label53.Text = "D0711'Ver Dist"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(17, 51)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(107, 13)
        Me.Label58.TabIndex = 153
        Me.Label58.Text = "D0707'Edge Hor Dist"
        '
        'txtWebConnectPlateVerDist1
        '
        Me.txtWebConnectPlateVerDist1.AcceptsReturn = True
        Me.txtWebConnectPlateVerDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerDist1.Location = New System.Drawing.Point(322, 78)
        Me.txtWebConnectPlateVerDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerDist1.MaxLength = 0
        Me.txtWebConnectPlateVerDist1.Name = "txtWebConnectPlateVerDist1"
        Me.txtWebConnectPlateVerDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerDist1.TabIndex = 162
        '
        'txtWebConnectPlateHorDist1
        '
        Me.txtWebConnectPlateHorDist1.AcceptsReturn = True
        Me.txtWebConnectPlateHorDist1.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorDist1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorDist1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorDist1.Location = New System.Drawing.Point(121, 78)
        Me.txtWebConnectPlateHorDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorDist1.MaxLength = 0
        Me.txtWebConnectPlateHorDist1.Name = "txtWebConnectPlateHorDist1"
        Me.txtWebConnectPlateHorDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorDist1.TabIndex = 158
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(17, 81)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(79, 13)
        Me.Label55.TabIndex = 159
        Me.Label55.Text = "D0709'Hor Dist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoltGroupHorSideDist1)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.txtBoltGroupSpan1)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 77)
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
        Me.txtBoltGroupHorSideDist1.Location = New System.Drawing.Point(121, 18)
        Me.txtBoltGroupHorSideDist1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoltGroupHorSideDist1.MaxLength = 0
        Me.txtBoltGroupHorSideDist1.Name = "txtBoltGroupHorSideDist1"
        Me.txtBoltGroupHorSideDist1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupHorSideDist1.Size = New System.Drawing.Size(57, 20)
        Me.txtBoltGroupHorSideDist1.TabIndex = 150
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(16, 21)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(103, 13)
        Me.Label59.TabIndex = 151
        Me.Label59.Text = "D0704'Hor Side Dist"
        '
        'txtBoltGroupSpan1
        '
        Me.txtBoltGroupSpan1.AcceptsReturn = True
        Me.txtBoltGroupSpan1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupSpan1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupSpan1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupSpan1.Location = New System.Drawing.Point(321, 18)
        Me.txtBoltGroupSpan1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoltGroupSpan1.MaxLength = 0
        Me.txtBoltGroupSpan1.Name = "txtBoltGroupSpan1"
        Me.txtBoltGroupSpan1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupSpan1.Size = New System.Drawing.Size(57, 20)
        Me.txtBoltGroupSpan1.TabIndex = 154
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(208, 21)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(91, 13)
        Me.Label57.TabIndex = 155
        Me.Label57.Text = "D0705'Group Dist"
        '
        'TabPageWebConnPlate2
        '
        Me.TabPageWebConnPlate2.Controls.Add(Me.GroupBox3)
        Me.TabPageWebConnPlate2.Controls.Add(Me.GroupBox4)
        Me.TabPageWebConnPlate2.Location = New System.Drawing.Point(4, 22)
        Me.TabPageWebConnPlate2.Name = "TabPageWebConnPlate2"
        Me.TabPageWebConnPlate2.Size = New System.Drawing.Size(408, 281)
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
        Me.GroupBox3.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 181)
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
        Me.Label63.Location = New System.Drawing.Point(208, 141)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(133, 13)
        Me.Label63.TabIndex = 167
        Me.Label63.Text = "D0713'Inner Ver Edge Dist"
        '
        'txtWebConnectPlateInnerVerEdgeDist2
        '
        Me.txtWebConnectPlateInnerVerEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateInnerVerEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateInnerVerEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateInnerVerEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateInnerVerEdgeDist2.Location = New System.Drawing.Point(322, 138)
        Me.txtWebConnectPlateInnerVerEdgeDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateInnerVerEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateInnerVerEdgeDist2.Name = "txtWebConnectPlateInnerVerEdgeDist2"
        Me.txtWebConnectPlateInnerVerEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateInnerVerEdgeDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateInnerVerEdgeDist2.TabIndex = 166
        '
        'txtWebConnectPlateThickness2
        '
        Me.txtWebConnectPlateThickness2.AcceptsReturn = True
        Me.txtWebConnectPlateThickness2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateThickness2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateThickness2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateThickness2.Location = New System.Drawing.Point(121, 18)
        Me.txtWebConnectPlateThickness2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateThickness2.MaxLength = 0
        Me.txtWebConnectPlateThickness2.Name = "txtWebConnectPlateThickness2"
        Me.txtWebConnectPlateThickness2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateThickness2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateThickness2.TabIndex = 146
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(17, 21)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(90, 13)
        Me.Label64.TabIndex = 147
        Me.Label64.Text = "D0701'Thickness"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(208, 111)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(88, 13)
        Me.Label65.TabIndex = 157
        Me.Label65.Text = "D0712'Ver Count"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(17, 111)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(89, 13)
        Me.Label66.TabIndex = 161
        Me.Label66.Text = "D0710'Hor Count"
        '
        'txtWebConnectPlateVerCount2
        '
        Me.txtWebConnectPlateVerCount2.AcceptsReturn = True
        Me.txtWebConnectPlateVerCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerCount2.Location = New System.Drawing.Point(322, 108)
        Me.txtWebConnectPlateVerCount2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerCount2.MaxLength = 0
        Me.txtWebConnectPlateVerCount2.Name = "txtWebConnectPlateVerCount2"
        Me.txtWebConnectPlateVerCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerCount2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerCount2.TabIndex = 156
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(207, 51)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(106, 13)
        Me.Label67.TabIndex = 165
        Me.Label67.Text = "D0708'Edge Ver Dist"
        '
        'txtWebConnectPlateHorCount2
        '
        Me.txtWebConnectPlateHorCount2.AcceptsReturn = True
        Me.txtWebConnectPlateHorCount2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorCount2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorCount2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorCount2.Location = New System.Drawing.Point(121, 108)
        Me.txtWebConnectPlateHorCount2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorCount2.MaxLength = 0
        Me.txtWebConnectPlateHorCount2.Name = "txtWebConnectPlateHorCount2"
        Me.txtWebConnectPlateHorCount2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorCount2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorCount2.TabIndex = 160
        '
        'txtWebConnectPlateHorEdgeDist2
        '
        Me.txtWebConnectPlateHorEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateHorEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorEdgeDist2.Location = New System.Drawing.Point(121, 48)
        Me.txtWebConnectPlateHorEdgeDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateHorEdgeDist2.Name = "txtWebConnectPlateHorEdgeDist2"
        Me.txtWebConnectPlateHorEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorEdgeDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorEdgeDist2.TabIndex = 152
        '
        'txtWebConnectPlateVerEdgeDist2
        '
        Me.txtWebConnectPlateVerEdgeDist2.AcceptsReturn = True
        Me.txtWebConnectPlateVerEdgeDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerEdgeDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerEdgeDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerEdgeDist2.Location = New System.Drawing.Point(321, 48)
        Me.txtWebConnectPlateVerEdgeDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerEdgeDist2.MaxLength = 0
        Me.txtWebConnectPlateVerEdgeDist2.Name = "txtWebConnectPlateVerEdgeDist2"
        Me.txtWebConnectPlateVerEdgeDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerEdgeDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerEdgeDist2.TabIndex = 164
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(208, 81)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(78, 13)
        Me.Label68.TabIndex = 163
        Me.Label68.Text = "D0711'Ver Dist"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label69.Location = New System.Drawing.Point(17, 51)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(107, 13)
        Me.Label69.TabIndex = 153
        Me.Label69.Text = "D0707'Edge Hor Dist"
        '
        'txtWebConnectPlateVerDist2
        '
        Me.txtWebConnectPlateVerDist2.AcceptsReturn = True
        Me.txtWebConnectPlateVerDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateVerDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateVerDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateVerDist2.Location = New System.Drawing.Point(322, 78)
        Me.txtWebConnectPlateVerDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateVerDist2.MaxLength = 0
        Me.txtWebConnectPlateVerDist2.Name = "txtWebConnectPlateVerDist2"
        Me.txtWebConnectPlateVerDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateVerDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateVerDist2.TabIndex = 162
        '
        'txtWebConnectPlateHorDist2
        '
        Me.txtWebConnectPlateHorDist2.AcceptsReturn = True
        Me.txtWebConnectPlateHorDist2.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebConnectPlateHorDist2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebConnectPlateHorDist2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebConnectPlateHorDist2.Location = New System.Drawing.Point(121, 78)
        Me.txtWebConnectPlateHorDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebConnectPlateHorDist2.MaxLength = 0
        Me.txtWebConnectPlateHorDist2.Name = "txtWebConnectPlateHorDist2"
        Me.txtWebConnectPlateHorDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebConnectPlateHorDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtWebConnectPlateHorDist2.TabIndex = 158
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(17, 81)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(79, 13)
        Me.Label70.TabIndex = 159
        Me.Label70.Text = "D0709'Hor Dist"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBoltGroupHorSideDist2)
        Me.GroupBox4.Controls.Add(Me.Label72)
        Me.GroupBox4.Controls.Add(Me.txtBoltGroupSpan2)
        Me.GroupBox4.Controls.Add(Me.Label73)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(390, 77)
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
        Me.txtBoltGroupHorSideDist2.Location = New System.Drawing.Point(121, 18)
        Me.txtBoltGroupHorSideDist2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoltGroupHorSideDist2.MaxLength = 0
        Me.txtBoltGroupHorSideDist2.Name = "txtBoltGroupHorSideDist2"
        Me.txtBoltGroupHorSideDist2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupHorSideDist2.Size = New System.Drawing.Size(57, 20)
        Me.txtBoltGroupHorSideDist2.TabIndex = 150
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label72.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label72.Location = New System.Drawing.Point(16, 21)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label72.Size = New System.Drawing.Size(103, 13)
        Me.Label72.TabIndex = 151
        Me.Label72.Text = "D0704'Hor Side Dist"
        '
        'txtBoltGroupSpan2
        '
        Me.txtBoltGroupSpan2.AcceptsReturn = True
        Me.txtBoltGroupSpan2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltGroupSpan2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltGroupSpan2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltGroupSpan2.Location = New System.Drawing.Point(321, 18)
        Me.txtBoltGroupSpan2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoltGroupSpan2.MaxLength = 0
        Me.txtBoltGroupSpan2.Name = "txtBoltGroupSpan2"
        Me.txtBoltGroupSpan2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltGroupSpan2.Size = New System.Drawing.Size(57, 20)
        Me.txtBoltGroupSpan2.TabIndex = 154
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(208, 21)
        Me.Label73.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(91, 13)
        Me.Label73.TabIndex = 155
        Me.Label73.Text = "D0705'Group Dist"
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
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.TabPageSidePlate.ResumeLayout(False)
        Me._TabFrames_0.ResumeLayout(False)
        Me._TabFrames_0.PerformLayout()
        Me.TabPageConnPlate1.ResumeLayout(False)
        Me.TabPageConnPlate1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents TabPageConnPlate1 As Windows.Forms.TabPage
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
    Public WithEvents Label34 As Windows.Forms.Label
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
#End Region
End Class