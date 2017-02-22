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
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtDiagnalExtend = New System.Windows.Forms.TextBox()
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
        Me.TabPageDiagConnPlate = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewHole = New System.Windows.Forms.DataGridView()
        Me.txtHoleMiddleDist = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cmdRollover = New System.Windows.Forms.Button()
        Me.imgBitmaps = New System.Windows.Forms.ImageList(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps3 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps4 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps5 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBitmaps6 = New System.Windows.Forms.ImageList(Me.components)
        Me.EdgeDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewHole, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabStrip1.Controls.Add(Me.TabPageMiddleWebConnPlate)
        Me.TabStrip1.Controls.Add(Me.TabPageHorConnPlate)
        Me.TabStrip1.Controls.Add(Me.TabPageDiagConnPlate)
        Me.TabStrip1.Location = New System.Drawing.Point(6, 12)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(416, 307)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.Label40)
        Me.TabPageGeneral.Controls.Add(Me.txtDiagnalExtend)
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
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(199, 72)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(95, 13)
        Me.Label40.TabIndex = 146
        Me.Label40.Text = "D0409'Diagnal Ext"
        '
        'txtDiagnalExtend
        '
        Me.txtDiagnalExtend.AcceptsReturn = True
        Me.txtDiagnalExtend.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiagnalExtend.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnalExtend.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagnalExtend.Location = New System.Drawing.Point(320, 68)
        Me.txtDiagnalExtend.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiagnalExtend.MaxLength = 0
        Me.txtDiagnalExtend.Name = "txtDiagnalExtend"
        Me.txtDiagnalExtend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiagnalExtend.Size = New System.Drawing.Size(57, 20)
        Me.txtDiagnalExtend.TabIndex = 145
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
        Me.TabPageMiddleWebConnPlate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMiddleWebConnPlate.Name = "TabPageMiddleWebConnPlate"
        Me.TabPageMiddleWebConnPlate.Size = New System.Drawing.Size(408, 281)
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
        Me.Label37.ForeColor = System.Drawing.Color.Black
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
        Me.Label36.ForeColor = System.Drawing.Color.Black
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
        Me.Label35.ForeColor = System.Drawing.Color.Black
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
        Me.Label17.ForeColor = System.Drawing.Color.Black
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
        Me.Label21.ForeColor = System.Drawing.Color.Black
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
        Me.Label18.ForeColor = System.Drawing.Color.Black
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
        Me.Label20.ForeColor = System.Drawing.Color.Black
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
        Me.Label19.ForeColor = System.Drawing.Color.Black
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
        Me.TabPageHorConnPlate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageHorConnPlate.Name = "TabPageHorConnPlate"
        Me.TabPageHorConnPlate.Size = New System.Drawing.Size(408, 281)
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
        Me.Label25.Location = New System.Drawing.Point(211, 134)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(112, 13)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "D0609'Ver Middle Dist"
        '
        'txtVerMiddleDist
        '
        Me.txtVerMiddleDist.AcceptsReturn = True
        Me.txtVerMiddleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerMiddleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerMiddleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerMiddleDist.Location = New System.Drawing.Point(315, 130)
        Me.txtVerMiddleDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerMiddleDist.MaxLength = 0
        Me.txtVerMiddleDist.Name = "txtVerMiddleDist"
        Me.txtVerMiddleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerMiddleDist.Size = New System.Drawing.Size(57, 20)
        Me.txtVerMiddleDist.TabIndex = 146
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(211, 42)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(106, 13)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "D0606'Ver Edge Dist"
        '
        'txtVerEdgeDist
        '
        Me.txtVerEdgeDist.AcceptsReturn = True
        Me.txtVerEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerEdgeDist.Location = New System.Drawing.Point(315, 38)
        Me.txtVerEdgeDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerEdgeDist.MaxLength = 0
        Me.txtVerEdgeDist.Name = "txtVerEdgeDist"
        Me.txtVerEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtVerEdgeDist.TabIndex = 144
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(211, 72)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "D0607'Ver Dist"
        '
        'txtVerDist
        '
        Me.txtVerDist.AcceptsReturn = True
        Me.txtVerDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerDist.Location = New System.Drawing.Point(315, 68)
        Me.txtVerDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerDist.MaxLength = 0
        Me.txtVerDist.Name = "txtVerDist"
        Me.txtVerDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerDist.Size = New System.Drawing.Size(57, 20)
        Me.txtVerDist.TabIndex = 142
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(211, 103)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(88, 13)
        Me.Label26.TabIndex = 139
        Me.Label26.Text = "D0608'Ver Count"
        '
        'txtVerCount
        '
        Me.txtVerCount.AcceptsReturn = True
        Me.txtVerCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerCount.Location = New System.Drawing.Point(315, 99)
        Me.txtVerCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVerCount.MaxLength = 0
        Me.txtVerCount.Name = "txtVerCount"
        Me.txtVerCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerCount.Size = New System.Drawing.Size(57, 20)
        Me.txtVerCount.TabIndex = 138
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(9, 102)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(89, 13)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "D0605'Hor Count"
        '
        'txtHorCount
        '
        Me.txtHorCount.AcceptsReturn = True
        Me.txtHorCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorCount.Location = New System.Drawing.Point(113, 98)
        Me.txtHorCount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorCount.MaxLength = 0
        Me.txtHorCount.Name = "txtHorCount"
        Me.txtHorCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorCount.Size = New System.Drawing.Size(57, 20)
        Me.txtHorCount.TabIndex = 134
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(211, 12)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(107, 13)
        Me.Label29.TabIndex = 133
        Me.Label29.Text = "D0505'Inside PL Thk"
        '
        'txtFlgConnPlateInsidePlateThk
        '
        Me.txtFlgConnPlateInsidePlateThk.AcceptsReturn = True
        Me.txtFlgConnPlateInsidePlateThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlgConnPlateInsidePlateThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlgConnPlateInsidePlateThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlgConnPlateInsidePlateThk.Location = New System.Drawing.Point(315, 8)
        Me.txtFlgConnPlateInsidePlateThk.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFlgConnPlateInsidePlateThk.MaxLength = 0
        Me.txtFlgConnPlateInsidePlateThk.Name = "txtFlgConnPlateInsidePlateThk"
        Me.txtFlgConnPlateInsidePlateThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlgConnPlateInsidePlateThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlgConnPlateInsidePlateThk.TabIndex = 132
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(9, 72)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(79, 13)
        Me.Label30.TabIndex = 131
        Me.Label30.Text = "D0604'Hor Dist"
        '
        'txtHorDist
        '
        Me.txtHorDist.AcceptsReturn = True
        Me.txtHorDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorDist.Location = New System.Drawing.Point(113, 68)
        Me.txtHorDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorDist.MaxLength = 0
        Me.txtHorDist.Name = "txtHorDist"
        Me.txtHorDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorDist.Size = New System.Drawing.Size(57, 20)
        Me.txtHorDist.TabIndex = 130
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(9, 42)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(107, 13)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "D0603'Hor Edge Dist"
        '
        'txtHorEdgeDist
        '
        Me.txtHorEdgeDist.AcceptsReturn = True
        Me.txtHorEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorEdgeDist.Location = New System.Drawing.Point(113, 38)
        Me.txtHorEdgeDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorEdgeDist.MaxLength = 0
        Me.txtHorEdgeDist.Name = "txtHorEdgeDist"
        Me.txtHorEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtHorEdgeDist.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(9, 12)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(115, 13)
        Me.Label33.TabIndex = 125
        Me.Label33.Text = "D0601'Outside PL Thk"
        '
        'txtFlgConnPlateOutsidePlateThk
        '
        Me.txtFlgConnPlateOutsidePlateThk.AcceptsReturn = True
        Me.txtFlgConnPlateOutsidePlateThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlgConnPlateOutsidePlateThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlgConnPlateOutsidePlateThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlgConnPlateOutsidePlateThk.Location = New System.Drawing.Point(113, 8)
        Me.txtFlgConnPlateOutsidePlateThk.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFlgConnPlateOutsidePlateThk.MaxLength = 0
        Me.txtFlgConnPlateOutsidePlateThk.Name = "txtFlgConnPlateOutsidePlateThk"
        Me.txtFlgConnPlateOutsidePlateThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlgConnPlateOutsidePlateThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlgConnPlateOutsidePlateThk.TabIndex = 124
        '
        'TabPageDiagConnPlate
        '
        Me.TabPageDiagConnPlate.Controls.Add(Me.GroupBox1)
        Me.TabPageDiagConnPlate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDiagConnPlate.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageDiagConnPlate.Name = "TabPageDiagConnPlate"
        Me.TabPageDiagConnPlate.Size = New System.Drawing.Size(408, 281)
        Me.TabPageDiagConnPlate.TabIndex = 14
        Me.TabPageDiagConnPlate.Text = "D0700'Diag Flange Connect Plate"
        Me.TabPageDiagConnPlate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewHole)
        Me.GroupBox1.Controls.Add(Me.txtHoleMiddleDist)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(396, 266)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "D0703'Hole"
        '
        'DataGridViewHole
        '
        Me.DataGridViewHole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHole.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EdgeDist, Me.HorDist, Me.YDesc})
        Me.DataGridViewHole.Location = New System.Drawing.Point(4, 43)
        Me.DataGridViewHole.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewHole.Name = "DataGridViewHole"
        Me.DataGridViewHole.RowTemplate.Height = 28
        Me.DataGridViewHole.Size = New System.Drawing.Size(392, 219)
        Me.DataGridViewHole.TabIndex = 156
        '
        'txtHoleMiddleDist
        '
        Me.txtHoleMiddleDist.AcceptsReturn = True
        Me.txtHoleMiddleDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleMiddleDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleMiddleDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleMiddleDist.Location = New System.Drawing.Point(115, 16)
        Me.txtHoleMiddleDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoleMiddleDist.MaxLength = 0
        Me.txtHoleMiddleDist.Name = "txtHoleMiddleDist"
        Me.txtHoleMiddleDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleMiddleDist.Size = New System.Drawing.Size(57, 20)
        Me.txtHoleMiddleDist.TabIndex = 154
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(11, 18)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(93, 13)
        Me.Label44.TabIndex = 155
        Me.Label44.Text = "D0702'Middle Dist"
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
        'EdgeDist
        '
        Me.EdgeDist.HeaderText = "EdgeDist"
        Me.EdgeDist.Name = "EdgeDist"
        '
        'HorDist
        '
        Me.HorDist.HeaderText = "HorDist"
        Me.HorDist.Name = "HorDist"
        '
        'YDesc
        '
        Me.YDesc.HeaderText = "YDesc"
        Me.YDesc.Name = "YDesc"
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
        Me.Text = "D0001'Bridge Hor Brace Designer"
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewHole, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents txtHoleMiddleDist As Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents DataGridViewHole As Windows.Forms.DataGridView
    Public WithEvents Label40 As Windows.Forms.Label
    Public WithEvents txtDiagnalExtend As Windows.Forms.TextBox
    Friend WithEvents EdgeDist As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorDist As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YDesc As Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class