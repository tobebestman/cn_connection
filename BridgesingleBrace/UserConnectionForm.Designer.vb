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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserConnectionForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.cboDescription = New System.Windows.Forms.ComboBox
        Me.cboPartFamily = New System.Windows.Forms.ComboBox
        Me.cboAreaClass = New System.Windows.Forms.ComboBox
        Me.cboDisplayClass = New System.Windows.Forms.ComboBox
        Me.cboDetailStyle = New System.Windows.Forms.ComboBox
        Me.cboMaterial = New System.Windows.Forms.ComboBox
        Me.txtItemNumber = New System.Windows.Forms.TextBox
        Me.cmdGetLengthFromLine = New System.Windows.Forms.Button
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdBitmaps = New System.Windows.Forms.Button
        Me.cmdForceUpdate = New System.Windows.Forms.Button
        Me.cmdHelp = New System.Windows.Forms.Button
        Me.cmdClone = New System.Windows.Forms.Button
        Me.cmdTemplate = New System.Windows.Forms.Button
        Me.Picture2 = New System.Windows.Forms.PictureBox
        Me.picBitmap = New System.Windows.Forms.PictureBox
        Me.TabStrip1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me._TabFrames_0 = New System.Windows.Forms.GroupBox
        Me.lblThick = New System.Windows.Forms.Label
        Me.lblWidth = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.txtBpGapEnd = New System.Windows.Forms.TextBox
        Me.txtBpE = New System.Windows.Forms.TextBox
        Me.txtBpD = New System.Windows.Forms.TextBox
        Me.txtBpTolerance = New System.Windows.Forms.TextBox
        Me.txtBpC = New System.Windows.Forms.TextBox
        Me.txtBpB = New System.Windows.Forms.TextBox
        Me.txtBpA = New System.Windows.Forms.TextBox
        Me.txtBpThick = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.groupHoles = New System.Windows.Forms.GroupBox
        Me.txtBoltSize = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtWorkLoose = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSlotLen = New System.Windows.Forms.TextBox
        Me.txtSlotRotation = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtBpVerHoleNum = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBpVerA = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBpVerB = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtBpHorHoleNum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBpHorA = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtBpHorB = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.groupWeld = New System.Windows.Forms.GroupBox
        Me.lblWeldStyle = New System.Windows.Forms.Label
        Me.cbWeldStyle = New System.Windows.Forms.ComboBox
        Me.groupBolt = New System.Windows.Forms.GroupBox
        Me.lblBoltStyle = New System.Windows.Forms.Label
        Me.chkTurnBolts = New System.Windows.Forms.CheckBox
        Me.cbBoltStyle = New System.Windows.Forms.ComboBox
        Me.radioWeld = New System.Windows.Forms.RadioButton
        Me.radioHoleBolt = New System.Windows.Forms.RadioButton
        Me.radioHole = New System.Windows.Forms.RadioButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me._TabFrames_1 = New System.Windows.Forms.GroupBox
        Me.chkParallelToLeg = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSpThick = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSpChamferDistance = New System.Windows.Forms.TextBox
        Me.txtSpHeight = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSp2Thick = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSp2ChamferDistance = New System.Windows.Forms.TextBox
        Me.txtSp2Height = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me._TabFrames_5 = New System.Windows.Forms.GroupBox
        Me.chkCreateGroup = New System.Windows.Forms.CheckBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me._TabFrames_6 = New System.Windows.Forms.GroupBox
        Me.cboElement = New PlugInBase.ImageCombo
        Me.lblItem = New System.Windows.Forms.Label
        Me.lblLayer = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblFamily = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.lblDetail = New System.Windows.Forms.Label
        Me.lblMaterial = New System.Windows.Forms.Label
        Me.lblElement = New System.Windows.Forms.Label
        Me.cmdRollover = New System.Windows.Forms.Button
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
        Me.TabPage1.SuspendLayout()
        Me._TabFrames_0.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupHoles.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.groupWeld.SuspendLayout()
        Me.groupBolt.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me._TabFrames_1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me._TabFrames_5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me._TabFrames_6.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLevel
        '
        Me.cboLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cboLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.Location = New System.Drawing.Point(280, 229)
        Me.cboLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLevel.Size = New System.Drawing.Size(207, 24)
        Me.cboLevel.TabIndex = 37
        Me.cboLevel.Tag = "S0097"
        '
        'cboDescription
        '
        Me.cboDescription.BackColor = System.Drawing.SystemColors.Window
        Me.cboDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDescription.Location = New System.Drawing.Point(280, 199)
        Me.cboDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDescription.Size = New System.Drawing.Size(207, 24)
        Me.cboDescription.TabIndex = 36
        Me.cboDescription.Tag = "S0096"
        '
        'cboPartFamily
        '
        Me.cboPartFamily.BackColor = System.Drawing.SystemColors.Window
        Me.cboPartFamily.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPartFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartFamily.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPartFamily.Location = New System.Drawing.Point(280, 169)
        Me.cboPartFamily.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboPartFamily.Name = "cboPartFamily"
        Me.cboPartFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPartFamily.Size = New System.Drawing.Size(207, 24)
        Me.cboPartFamily.TabIndex = 35
        Me.cboPartFamily.Tag = "S0095"
        '
        'cboAreaClass
        '
        Me.cboAreaClass.BackColor = System.Drawing.SystemColors.Window
        Me.cboAreaClass.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAreaClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAreaClass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAreaClass.Location = New System.Drawing.Point(280, 139)
        Me.cboAreaClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAreaClass.Name = "cboAreaClass"
        Me.cboAreaClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAreaClass.Size = New System.Drawing.Size(207, 24)
        Me.cboAreaClass.TabIndex = 34
        Me.cboAreaClass.Tag = "S0094"
        '
        'cboDisplayClass
        '
        Me.cboDisplayClass.BackColor = System.Drawing.SystemColors.Window
        Me.cboDisplayClass.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDisplayClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisplayClass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDisplayClass.Location = New System.Drawing.Point(280, 110)
        Me.cboDisplayClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDisplayClass.Name = "cboDisplayClass"
        Me.cboDisplayClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDisplayClass.Size = New System.Drawing.Size(207, 24)
        Me.cboDisplayClass.TabIndex = 33
        Me.cboDisplayClass.Tag = "S0093"
        '
        'cboDetailStyle
        '
        Me.cboDetailStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cboDetailStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDetailStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDetailStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDetailStyle.Location = New System.Drawing.Point(280, 79)
        Me.cboDetailStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDetailStyle.Name = "cboDetailStyle"
        Me.cboDetailStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDetailStyle.Size = New System.Drawing.Size(207, 24)
        Me.cboDetailStyle.TabIndex = 32
        Me.cboDetailStyle.Tag = "S0092"
        '
        'cboMaterial
        '
        Me.cboMaterial.BackColor = System.Drawing.SystemColors.Window
        Me.cboMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaterial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMaterial.Location = New System.Drawing.Point(280, 49)
        Me.cboMaterial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMaterial.Size = New System.Drawing.Size(207, 24)
        Me.cboMaterial.TabIndex = 31
        Me.cboMaterial.Tag = "S0091"
        '
        'txtItemNumber
        '
        Me.txtItemNumber.AcceptsReturn = True
        Me.txtItemNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtItemNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtItemNumber.Location = New System.Drawing.Point(280, 258)
        Me.txtItemNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtItemNumber.MaxLength = 0
        Me.txtItemNumber.Name = "txtItemNumber"
        Me.txtItemNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtItemNumber.Size = New System.Drawing.Size(207, 22)
        Me.txtItemNumber.TabIndex = 30
        Me.txtItemNumber.Tag = "S0098"
        '
        'cmdGetLengthFromLine
        '
        Me.cmdGetLengthFromLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetLengthFromLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetLengthFromLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetLengthFromLine.Image = CType(resources.GetObject("cmdGetLengthFromLine.Image"), System.Drawing.Image)
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(269, 340)
        Me.cmdGetLengthFromLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdGetLengthFromLine.Name = "cmdGetLengthFromLine"
        Me.cmdGetLengthFromLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetLengthFromLine.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdAccept.Location = New System.Drawing.Point(5, 340)
        Me.cmdAccept.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAccept.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdCancel.Location = New System.Drawing.Point(51, 340)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(519, 340)
        Me.cmdBitmaps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdBitmaps.Name = "cmdBitmaps"
        Me.cmdBitmaps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBitmaps.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(474, 340)
        Me.cmdForceUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdForceUpdate.Name = "cmdForceUpdate"
        Me.cmdForceUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdForceUpdate.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdHelp.Location = New System.Drawing.Point(95, 340)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdClone.Location = New System.Drawing.Point(185, 340)
        Me.cmdClone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdClone.Name = "cmdClone"
        Me.cmdClone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClone.Size = New System.Drawing.Size(40, 39)
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
        Me.cmdTemplate.Location = New System.Drawing.Point(140, 340)
        Me.cmdTemplate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdTemplate.Name = "cmdTemplate"
        Me.cmdTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTemplate.Size = New System.Drawing.Size(40, 39)
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
        Me.Picture2.Location = New System.Drawing.Point(1035, 140)
        Me.Picture2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(267, 142)
        Me.Picture2.TabIndex = 55
        Me.Picture2.TabStop = False
        '
        'picBitmap
        '
        Me.picBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.picBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBitmap.Location = New System.Drawing.Point(568, 14)
        Me.picBitmap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picBitmap.Name = "picBitmap"
        Me.picBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBitmap.Size = New System.Drawing.Size(350, 318)
        Me.picBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBitmap.TabIndex = 6
        Me.picBitmap.TabStop = False
        '
        'TabStrip1
        '
        Me.TabStrip1.Controls.Add(Me.TabPage1)
        Me.TabStrip1.Controls.Add(Me.TabPage3)
        Me.TabStrip1.Controls.Add(Me.TabPage7)
        Me.TabStrip1.Controls.Add(Me.TabPage2)
        Me.TabStrip1.Controls.Add(Me.TabPage6)
        Me.TabStrip1.Controls.Add(Me.TabPage4)
        Me.TabStrip1.Controls.Add(Me.TabPage5)
        Me.TabStrip1.Location = New System.Drawing.Point(5, 2)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(554, 330)
        Me.TabStrip1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._TabFrames_0)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(546, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "D0100'Plate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_TabFrames_0
        '
        Me._TabFrames_0.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_0.Controls.Add(Me.lblThick)
        Me._TabFrames_0.Controls.Add(Me.lblWidth)
        Me._TabFrames_0.Controls.Add(Me.Label2)
        Me._TabFrames_0.Controls.Add(Me.Label21)
        Me._TabFrames_0.Controls.Add(Me.Label15)
        Me._TabFrames_0.Controls.Add(Me.Label18)
        Me._TabFrames_0.Controls.Add(Me.Label1)
        Me._TabFrames_0.Controls.Add(Me.lblHeight)
        Me._TabFrames_0.Controls.Add(Me.txtBpGapEnd)
        Me._TabFrames_0.Controls.Add(Me.txtBpE)
        Me._TabFrames_0.Controls.Add(Me.txtBpD)
        Me._TabFrames_0.Controls.Add(Me.txtBpTolerance)
        Me._TabFrames_0.Controls.Add(Me.txtBpC)
        Me._TabFrames_0.Controls.Add(Me.txtBpB)
        Me._TabFrames_0.Controls.Add(Me.txtBpA)
        Me._TabFrames_0.Controls.Add(Me.txtBpThick)
        Me._TabFrames_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_0.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_0.Name = "_TabFrames_0"
        Me._TabFrames_0.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_0.Size = New System.Drawing.Size(546, 301)
        Me._TabFrames_0.TabIndex = 12
        Me._TabFrames_0.TabStop = False
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.BackColor = System.Drawing.Color.Transparent
        Me.lblThick.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblThick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblThick.Location = New System.Drawing.Point(16, 27)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblThick.Size = New System.Drawing.Size(121, 17)
        Me.lblThick.TabIndex = 79
        Me.lblThick.Text = "D0101'Thickness:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.BackColor = System.Drawing.Color.Transparent
        Me.lblWidth.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWidth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWidth.Location = New System.Drawing.Point(19, 61)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWidth.Size = New System.Drawing.Size(118, 17)
        Me.lblWidth.TabIndex = 80
        Me.lblWidth.Text = "1.D0102'Angle A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(271, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "7.D0108'Tolerance:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(271, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(124, 17)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "6.D0107'Gap end:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(19, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(141, 17)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "5.D0106'Side Gap E:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(19, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(175, 17)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "4.D0105'Edge Distance D:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(178, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "3.D0104'Right Side Gap C:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Transparent
        Me.lblHeight.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeight.Location = New System.Drawing.Point(19, 97)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHeight.Size = New System.Drawing.Size(169, 17)
        Me.lblHeight.TabIndex = 81
        Me.lblHeight.Text = "2.D0103'Left Side Gap B:"
        '
        'txtBpGapEnd
        '
        Me.txtBpGapEnd.AcceptsReturn = True
        Me.txtBpGapEnd.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpGapEnd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpGapEnd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpGapEnd.Location = New System.Drawing.Point(410, 24)
        Me.txtBpGapEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpGapEnd.MaxLength = 0
        Me.txtBpGapEnd.Name = "txtBpGapEnd"
        Me.txtBpGapEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpGapEnd.Size = New System.Drawing.Size(75, 22)
        Me.txtBpGapEnd.TabIndex = 90
        '
        'txtBpE
        '
        Me.txtBpE.AcceptsReturn = True
        Me.txtBpE.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpE.Location = New System.Drawing.Point(158, 201)
        Me.txtBpE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpE.MaxLength = 0
        Me.txtBpE.Name = "txtBpE"
        Me.txtBpE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpE.Size = New System.Drawing.Size(75, 22)
        Me.txtBpE.TabIndex = 88
        '
        'txtBpD
        '
        Me.txtBpD.AcceptsReturn = True
        Me.txtBpD.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpD.Location = New System.Drawing.Point(158, 165)
        Me.txtBpD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpD.MaxLength = 0
        Me.txtBpD.Name = "txtBpD"
        Me.txtBpD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpD.Size = New System.Drawing.Size(75, 22)
        Me.txtBpD.TabIndex = 86
        '
        'txtBpTolerance
        '
        Me.txtBpTolerance.AcceptsReturn = True
        Me.txtBpTolerance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpTolerance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpTolerance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpTolerance.Location = New System.Drawing.Point(410, 61)
        Me.txtBpTolerance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpTolerance.MaxLength = 0
        Me.txtBpTolerance.Name = "txtBpTolerance"
        Me.txtBpTolerance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpTolerance.Size = New System.Drawing.Size(75, 22)
        Me.txtBpTolerance.TabIndex = 84
        '
        'txtBpC
        '
        Me.txtBpC.AcceptsReturn = True
        Me.txtBpC.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpC.Location = New System.Drawing.Point(158, 130)
        Me.txtBpC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpC.MaxLength = 0
        Me.txtBpC.Name = "txtBpC"
        Me.txtBpC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpC.Size = New System.Drawing.Size(75, 22)
        Me.txtBpC.TabIndex = 82
        '
        'txtBpB
        '
        Me.txtBpB.AcceptsReturn = True
        Me.txtBpB.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpB.Location = New System.Drawing.Point(158, 94)
        Me.txtBpB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpB.MaxLength = 0
        Me.txtBpB.Name = "txtBpB"
        Me.txtBpB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpB.Size = New System.Drawing.Size(75, 22)
        Me.txtBpB.TabIndex = 78
        '
        'txtBpA
        '
        Me.txtBpA.AcceptsReturn = True
        Me.txtBpA.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpA.Location = New System.Drawing.Point(158, 58)
        Me.txtBpA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpA.MaxLength = 0
        Me.txtBpA.Name = "txtBpA"
        Me.txtBpA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpA.Size = New System.Drawing.Size(75, 22)
        Me.txtBpA.TabIndex = 77
        '
        'txtBpThick
        '
        Me.txtBpThick.AcceptsReturn = True
        Me.txtBpThick.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpThick.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpThick.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpThick.Location = New System.Drawing.Point(155, 24)
        Me.txtBpThick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpThick.MaxLength = 0
        Me.txtBpThick.Name = "txtBpThick"
        Me.txtBpThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpThick.Size = New System.Drawing.Size(75, 22)
        Me.txtBpThick.TabIndex = 76
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(546, 301)
        Me.TabPage3.TabIndex = 8
        Me.TabPage3.Text = "D0200'Hole"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.groupHoles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(546, 301)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'groupHoles
        '
        Me.groupHoles.Controls.Add(Me.txtBoltSize)
        Me.groupHoles.Controls.Add(Me.Label12)
        Me.groupHoles.Controls.Add(Me.txtWorkLoose)
        Me.groupHoles.Controls.Add(Me.Label25)
        Me.groupHoles.Controls.Add(Me.Label5)
        Me.groupHoles.Controls.Add(Me.Label13)
        Me.groupHoles.Controls.Add(Me.txtSlotLen)
        Me.groupHoles.Controls.Add(Me.txtSlotRotation)
        Me.groupHoles.Location = New System.Drawing.Point(6, 172)
        Me.groupHoles.Name = "groupHoles"
        Me.groupHoles.Size = New System.Drawing.Size(533, 80)
        Me.groupHoles.TabIndex = 137
        Me.groupHoles.TabStop = False
        Me.groupHoles.Text = "D0209'Hole/Slot"
        '
        'txtBoltSize
        '
        Me.txtBoltSize.AcceptsReturn = True
        Me.txtBoltSize.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoltSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoltSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoltSize.Location = New System.Drawing.Point(157, 20)
        Me.txtBoltSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoltSize.MaxLength = 0
        Me.txtBoltSize.Name = "txtBoltSize"
        Me.txtBoltSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoltSize.Size = New System.Drawing.Size(75, 22)
        Me.txtBoltSize.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(4, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(147, 17)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "D0210'Hole Diameter:"
        '
        'txtWorkLoose
        '
        Me.txtWorkLoose.AcceptsReturn = True
        Me.txtWorkLoose.BackColor = System.Drawing.SystemColors.Window
        Me.txtWorkLoose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWorkLoose.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWorkLoose.Location = New System.Drawing.Point(447, 20)
        Me.txtWorkLoose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWorkLoose.MaxLength = 0
        Me.txtWorkLoose.Name = "txtWorkLoose"
        Me.txtWorkLoose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWorkLoose.Size = New System.Drawing.Size(75, 22)
        Me.txtWorkLoose.TabIndex = 122
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(6, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(138, 17)
        Me.Label25.TabIndex = 128
        Me.Label25.Text = "D0212'Slot Rotation:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(250, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(133, 17)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "D0211'Work Loose:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(250, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(129, 17)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "D0213'Slot Length:"
        '
        'txtSlotLen
        '
        Me.txtSlotLen.AcceptsReturn = True
        Me.txtSlotLen.BackColor = System.Drawing.SystemColors.Window
        Me.txtSlotLen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSlotLen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSlotLen.Location = New System.Drawing.Point(447, 49)
        Me.txtSlotLen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSlotLen.MaxLength = 0
        Me.txtSlotLen.Name = "txtSlotLen"
        Me.txtSlotLen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSlotLen.Size = New System.Drawing.Size(75, 22)
        Me.txtSlotLen.TabIndex = 120
        '
        'txtSlotRotation
        '
        Me.txtSlotRotation.AcceptsReturn = True
        Me.txtSlotRotation.BackColor = System.Drawing.SystemColors.Window
        Me.txtSlotRotation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSlotRotation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSlotRotation.Location = New System.Drawing.Point(157, 49)
        Me.txtSlotRotation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSlotRotation.MaxLength = 0
        Me.txtSlotRotation.Name = "txtSlotRotation"
        Me.txtSlotRotation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSlotRotation.Size = New System.Drawing.Size(75, 22)
        Me.txtSlotRotation.TabIndex = 127
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBpVerHoleNum)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtBpVerA)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtBpVerB)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(536, 74)
        Me.GroupBox4.TabIndex = 136
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "D0201'Distribution in Shape Direction"
        '
        'txtBpVerHoleNum
        '
        Me.txtBpVerHoleNum.AcceptsReturn = True
        Me.txtBpVerHoleNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpVerHoleNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpVerHoleNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpVerHoleNum.Location = New System.Drawing.Point(157, 20)
        Me.txtBpVerHoleNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpVerHoleNum.MaxLength = 0
        Me.txtBpVerHoleNum.Name = "txtBpVerHoleNum"
        Me.txtBpVerHoleNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpVerHoleNum.Size = New System.Drawing.Size(75, 22)
        Me.txtBpVerHoleNum.TabIndex = 113
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(250, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(157, 17)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "3.D0203'Edge Distance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(4, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(103, 17)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "D0202'Number"
        '
        'txtBpVerA
        '
        Me.txtBpVerA.AcceptsReturn = True
        Me.txtBpVerA.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpVerA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpVerA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpVerA.Location = New System.Drawing.Point(447, 20)
        Me.txtBpVerA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpVerA.MaxLength = 0
        Me.txtBpVerA.Name = "txtBpVerA"
        Me.txtBpVerA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpVerA.Size = New System.Drawing.Size(75, 22)
        Me.txtBpVerA.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(250, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(178, 17)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "4.D0204'Distance Between"
        '
        'txtBpVerB
        '
        Me.txtBpVerB.AcceptsReturn = True
        Me.txtBpVerB.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpVerB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpVerB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpVerB.Location = New System.Drawing.Point(447, 47)
        Me.txtBpVerB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpVerB.MaxLength = 0
        Me.txtBpVerB.Name = "txtBpVerB"
        Me.txtBpVerB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpVerB.Size = New System.Drawing.Size(75, 22)
        Me.txtBpVerB.TabIndex = 116
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBpHorHoleNum)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtBpHorA)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txtBpHorB)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 77)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "D0205'Distribution in Cross Shape Direction"
        '
        'txtBpHorHoleNum
        '
        Me.txtBpHorHoleNum.AcceptsReturn = True
        Me.txtBpHorHoleNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpHorHoleNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpHorHoleNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpHorHoleNum.Location = New System.Drawing.Point(157, 20)
        Me.txtBpHorHoleNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpHorHoleNum.MaxLength = 0
        Me.txtBpHorHoleNum.Name = "txtBpHorHoleNum"
        Me.txtBpHorHoleNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpHorHoleNum.Size = New System.Drawing.Size(75, 22)
        Me.txtBpHorHoleNum.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(4, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "D0206'Number"
        '
        'txtBpHorA
        '
        Me.txtBpHorA.AcceptsReturn = True
        Me.txtBpHorA.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpHorA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpHorA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpHorA.Location = New System.Drawing.Point(447, 20)
        Me.txtBpHorA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpHorA.MaxLength = 0
        Me.txtBpHorA.Name = "txtBpHorA"
        Me.txtBpHorA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpHorA.Size = New System.Drawing.Size(75, 22)
        Me.txtBpHorA.TabIndex = 78
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(250, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(157, 17)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "1.D0207'Edge Distance"
        '
        'txtBpHorB
        '
        Me.txtBpHorB.AcceptsReturn = True
        Me.txtBpHorB.BackColor = System.Drawing.SystemColors.Window
        Me.txtBpHorB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBpHorB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBpHorB.Location = New System.Drawing.Point(447, 47)
        Me.txtBpHorB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBpHorB.MaxLength = 0
        Me.txtBpHorB.Name = "txtBpHorB"
        Me.txtBpHorB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBpHorB.Size = New System.Drawing.Size(75, 22)
        Me.txtBpHorB.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(250, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(178, 17)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "2.D0208'Distance Between"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.groupWeld)
        Me.TabPage7.Controls.Add(Me.groupBolt)
        Me.TabPage7.Controls.Add(Me.radioWeld)
        Me.TabPage7.Controls.Add(Me.radioHoleBolt)
        Me.TabPage7.Controls.Add(Me.radioHole)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(546, 301)
        Me.TabPage7.TabIndex = 10
        Me.TabPage7.Text = "D0300'Bolt/Weld"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'groupWeld
        '
        Me.groupWeld.Controls.Add(Me.lblWeldStyle)
        Me.groupWeld.Controls.Add(Me.cbWeldStyle)
        Me.groupWeld.Location = New System.Drawing.Point(6, 68)
        Me.groupWeld.Name = "groupWeld"
        Me.groupWeld.Size = New System.Drawing.Size(534, 54)
        Me.groupWeld.TabIndex = 150
        Me.groupWeld.TabStop = False
        Me.groupWeld.Text = "D0304'Weld"
        '
        'lblWeldStyle
        '
        Me.lblWeldStyle.AutoSize = True
        Me.lblWeldStyle.BackColor = System.Drawing.Color.Transparent
        Me.lblWeldStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWeldStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeldStyle.Location = New System.Drawing.Point(16, 27)
        Me.lblWeldStyle.Name = "lblWeldStyle"
        Me.lblWeldStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWeldStyle.Size = New System.Drawing.Size(122, 17)
        Me.lblWeldStyle.TabIndex = 137
        Me.lblWeldStyle.Text = "D0305'Weld style:"
        '
        'cbWeldStyle
        '
        Me.cbWeldStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cbWeldStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbWeldStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWeldStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbWeldStyle.Location = New System.Drawing.Point(205, 20)
        Me.cbWeldStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbWeldStyle.Name = "cbWeldStyle"
        Me.cbWeldStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbWeldStyle.Size = New System.Drawing.Size(125, 24)
        Me.cbWeldStyle.TabIndex = 136
        '
        'groupBolt
        '
        Me.groupBolt.Controls.Add(Me.lblBoltStyle)
        Me.groupBolt.Controls.Add(Me.chkTurnBolts)
        Me.groupBolt.Controls.Add(Me.cbBoltStyle)
        Me.groupBolt.Location = New System.Drawing.Point(6, 6)
        Me.groupBolt.Name = "groupBolt"
        Me.groupBolt.Size = New System.Drawing.Size(534, 52)
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
        Me.lblBoltStyle.Location = New System.Drawing.Point(16, 18)
        Me.lblBoltStyle.Name = "lblBoltStyle"
        Me.lblBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBoltStyle.Size = New System.Drawing.Size(114, 17)
        Me.lblBoltStyle.TabIndex = 135
        Me.lblBoltStyle.Text = "D0302'Bolt style:"
        '
        'chkTurnBolts
        '
        Me.chkTurnBolts.AutoSize = True
        Me.chkTurnBolts.BackColor = System.Drawing.Color.Transparent
        Me.chkTurnBolts.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTurnBolts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTurnBolts.Location = New System.Drawing.Point(369, 17)
        Me.chkTurnBolts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTurnBolts.Name = "chkTurnBolts"
        Me.chkTurnBolts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTurnBolts.Size = New System.Drawing.Size(139, 21)
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
        Me.cbBoltStyle.Location = New System.Drawing.Point(205, 15)
        Me.cbBoltStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbBoltStyle.Name = "cbBoltStyle"
        Me.cbBoltStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBoltStyle.Size = New System.Drawing.Size(125, 24)
        Me.cbBoltStyle.TabIndex = 134
        '
        'radioWeld
        '
        Me.radioWeld.AutoSize = True
        Me.radioWeld.Location = New System.Drawing.Point(25, 181)
        Me.radioWeld.Name = "radioWeld"
        Me.radioWeld.Size = New System.Drawing.Size(106, 21)
        Me.radioWeld.TabIndex = 148
        Me.radioWeld.TabStop = True
        Me.radioWeld.Text = "D0308'Weld"
        Me.radioWeld.UseVisualStyleBackColor = True
        '
        'radioHoleBolt
        '
        Me.radioHoleBolt.AutoSize = True
        Me.radioHoleBolt.Checked = True
        Me.radioHoleBolt.Location = New System.Drawing.Point(25, 128)
        Me.radioHoleBolt.Name = "radioHoleBolt"
        Me.radioHoleBolt.Size = New System.Drawing.Size(249, 21)
        Me.radioHoleBolt.TabIndex = 146
        Me.radioHoleBolt.TabStop = True
        Me.radioHoleBolt.Text = "D0306'Create holes/slots with bolts"
        Me.radioHoleBolt.UseVisualStyleBackColor = True
        '
        'radioHole
        '
        Me.radioHole.AutoSize = True
        Me.radioHole.Location = New System.Drawing.Point(25, 155)
        Me.radioHole.Name = "radioHole"
        Me.radioHole.Size = New System.Drawing.Size(213, 21)
        Me.radioHole.TabIndex = 147
        Me.radioHole.TabStop = True
        Me.radioHole.Text = "D0307'Create just holes/slots"
        Me.radioHole.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me._TabFrames_1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(546, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "D0400'Gusset"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '_TabFrames_1
        '
        Me._TabFrames_1.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_1.Controls.Add(Me.chkParallelToLeg)
        Me._TabFrames_1.Controls.Add(Me.Label16)
        Me._TabFrames_1.Controls.Add(Me.txtSpThick)
        Me._TabFrames_1.Controls.Add(Me.Label3)
        Me._TabFrames_1.Controls.Add(Me.txtSpChamferDistance)
        Me._TabFrames_1.Controls.Add(Me.txtSpHeight)
        Me._TabFrames_1.Controls.Add(Me.Label17)
        Me._TabFrames_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_1.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_1.Name = "_TabFrames_1"
        Me._TabFrames_1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_1.Size = New System.Drawing.Size(546, 301)
        Me._TabFrames_1.TabIndex = 13
        Me._TabFrames_1.TabStop = False
        '
        'chkParallelToLeg
        '
        Me.chkParallelToLeg.AutoSize = True
        Me.chkParallelToLeg.Location = New System.Drawing.Point(22, 137)
        Me.chkParallelToLeg.Name = "chkParallelToLeg"
        Me.chkParallelToLeg.Size = New System.Drawing.Size(163, 21)
        Me.chkParallelToLeg.TabIndex = 138
        Me.chkParallelToLeg.Text = "D0404'ParallelToLeg"
        Me.chkParallelToLeg.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(19, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(179, 17)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "2.D0403'Chamfer distance:"
        '
        'txtSpThick
        '
        Me.txtSpThick.AcceptsReturn = True
        Me.txtSpThick.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpThick.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpThick.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpThick.Location = New System.Drawing.Point(284, 27)
        Me.txtSpThick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSpThick.MaxLength = 0
        Me.txtSpThick.Name = "txtSpThick"
        Me.txtSpThick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpThick.Size = New System.Drawing.Size(75, 22)
        Me.txtSpThick.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "D0401'Thick:"
        '
        'txtSpChamferDistance
        '
        Me.txtSpChamferDistance.AcceptsReturn = True
        Me.txtSpChamferDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpChamferDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpChamferDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpChamferDistance.Location = New System.Drawing.Point(284, 99)
        Me.txtSpChamferDistance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSpChamferDistance.MaxLength = 0
        Me.txtSpChamferDistance.Name = "txtSpChamferDistance"
        Me.txtSpChamferDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpChamferDistance.Size = New System.Drawing.Size(75, 22)
        Me.txtSpChamferDistance.TabIndex = 123
        '
        'txtSpHeight
        '
        Me.txtSpHeight.AcceptsReturn = True
        Me.txtSpHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpHeight.Location = New System.Drawing.Point(284, 63)
        Me.txtSpHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSpHeight.MaxLength = 0
        Me.txtSpHeight.Name = "txtSpHeight"
        Me.txtSpHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpHeight.Size = New System.Drawing.Size(75, 22)
        Me.txtSpHeight.TabIndex = 116
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(19, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(110, 17)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "1.D0402'Height:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(546, 301)
        Me.TabPage6.TabIndex = 9
        Me.TabPage6.Text = "D0500'Branch Gusset"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtSp2Thick)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSp2ChamferDistance)
        Me.GroupBox2.Controls.Add(Me.txtSp2Height)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(546, 301)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(19, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(179, 17)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "2.D0503'Chamfer distance:"
        '
        'txtSp2Thick
        '
        Me.txtSp2Thick.AcceptsReturn = True
        Me.txtSp2Thick.BackColor = System.Drawing.SystemColors.Window
        Me.txtSp2Thick.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSp2Thick.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSp2Thick.Location = New System.Drawing.Point(284, 27)
        Me.txtSp2Thick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSp2Thick.MaxLength = 0
        Me.txtSp2Thick.Name = "txtSp2Thick"
        Me.txtSp2Thick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSp2Thick.Size = New System.Drawing.Size(75, 22)
        Me.txtSp2Thick.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(19, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "D0501'Thick:"
        '
        'txtSp2ChamferDistance
        '
        Me.txtSp2ChamferDistance.AcceptsReturn = True
        Me.txtSp2ChamferDistance.BackColor = System.Drawing.SystemColors.Window
        Me.txtSp2ChamferDistance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSp2ChamferDistance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSp2ChamferDistance.Location = New System.Drawing.Point(284, 99)
        Me.txtSp2ChamferDistance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSp2ChamferDistance.MaxLength = 0
        Me.txtSp2ChamferDistance.Name = "txtSp2ChamferDistance"
        Me.txtSp2ChamferDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSp2ChamferDistance.Size = New System.Drawing.Size(75, 22)
        Me.txtSp2ChamferDistance.TabIndex = 123
        '
        'txtSp2Height
        '
        Me.txtSp2Height.AcceptsReturn = True
        Me.txtSp2Height.BackColor = System.Drawing.SystemColors.Window
        Me.txtSp2Height.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSp2Height.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSp2Height.Location = New System.Drawing.Point(284, 63)
        Me.txtSp2Height.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSp2Height.MaxLength = 0
        Me.txtSp2Height.Name = "txtSp2Height"
        Me.txtSp2Height.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSp2Height.Size = New System.Drawing.Size(75, 22)
        Me.txtSp2Height.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(19, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "1.D0502'Height:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me._TabFrames_5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(546, 301)
        Me.TabPage4.TabIndex = 7
        Me.TabPage4.Text = "D0600'Group"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        '_TabFrames_5
        '
        Me._TabFrames_5.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_5.Controls.Add(Me.chkCreateGroup)
        Me._TabFrames_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_5.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_5.Name = "_TabFrames_5"
        Me._TabFrames_5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_5.Size = New System.Drawing.Size(546, 301)
        Me._TabFrames_5.TabIndex = 14
        Me._TabFrames_5.TabStop = False
        '
        'chkCreateGroup
        '
        Me.chkCreateGroup.AutoSize = True
        Me.chkCreateGroup.Location = New System.Drawing.Point(19, 27)
        Me.chkCreateGroup.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkCreateGroup.Name = "chkCreateGroup"
        Me.chkCreateGroup.Size = New System.Drawing.Size(158, 21)
        Me.chkCreateGroup.TabIndex = 1
        Me.chkCreateGroup.Text = "D0601'Create group"
        Me.chkCreateGroup.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me._TabFrames_6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(546, 301)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "D0700'Assignments"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        '_TabFrames_6
        '
        Me._TabFrames_6.BackColor = System.Drawing.Color.Transparent
        Me._TabFrames_6.Controls.Add(Me.cboLevel)
        Me._TabFrames_6.Controls.Add(Me.cboDescription)
        Me._TabFrames_6.Controls.Add(Me.cboPartFamily)
        Me._TabFrames_6.Controls.Add(Me.cboAreaClass)
        Me._TabFrames_6.Controls.Add(Me.cboDisplayClass)
        Me._TabFrames_6.Controls.Add(Me.cboDetailStyle)
        Me._TabFrames_6.Controls.Add(Me.cboMaterial)
        Me._TabFrames_6.Controls.Add(Me.txtItemNumber)
        Me._TabFrames_6.Controls.Add(Me.cboElement)
        Me._TabFrames_6.Controls.Add(Me.lblItem)
        Me._TabFrames_6.Controls.Add(Me.lblLayer)
        Me._TabFrames_6.Controls.Add(Me.lblDescription)
        Me._TabFrames_6.Controls.Add(Me.lblFamily)
        Me._TabFrames_6.Controls.Add(Me.lblArea)
        Me._TabFrames_6.Controls.Add(Me.lblDisplay)
        Me._TabFrames_6.Controls.Add(Me.lblDetail)
        Me._TabFrames_6.Controls.Add(Me.lblMaterial)
        Me._TabFrames_6.Controls.Add(Me.lblElement)
        Me._TabFrames_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me._TabFrames_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TabFrames_6.Location = New System.Drawing.Point(0, 0)
        Me._TabFrames_6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_6.Name = "_TabFrames_6"
        Me._TabFrames_6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._TabFrames_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TabFrames_6.Size = New System.Drawing.Size(546, 301)
        Me._TabFrames_6.TabIndex = 23
        Me._TabFrames_6.TabStop = False
        '
        'cboElement
        '
        Me.cboElement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboElement.Location = New System.Drawing.Point(280, 18)
        Me.cboElement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboElement.Name = "cboElement"
        Me.cboElement.Size = New System.Drawing.Size(207, 23)
        Me.cboElement.TabIndex = 38
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItem.Location = New System.Drawing.Point(11, 263)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItem.Size = New System.Drawing.Size(133, 17)
        Me.lblItem.TabIndex = 47
        Me.lblItem.Text = "D0709'Item Number"
        '
        'lblLayer
        '
        Me.lblLayer.AutoSize = True
        Me.lblLayer.BackColor = System.Drawing.Color.Transparent
        Me.lblLayer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLayer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLayer.Location = New System.Drawing.Point(11, 234)
        Me.lblLayer.Name = "lblLayer"
        Me.lblLayer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLayer.Size = New System.Drawing.Size(89, 17)
        Me.lblLayer.TabIndex = 46
        Me.lblLayer.Text = "D0708'Layer"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescription.Location = New System.Drawing.Point(11, 204)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(124, 17)
        Me.lblDescription.TabIndex = 45
        Me.lblDescription.Text = "D0707'Description"
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.BackColor = System.Drawing.Color.Transparent
        Me.lblFamily.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFamily.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFamily.Location = New System.Drawing.Point(11, 174)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFamily.Size = New System.Drawing.Size(123, 17)
        Me.lblFamily.TabIndex = 44
        Me.lblFamily.Text = "D0706'Part Family"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.Transparent
        Me.lblArea.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblArea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArea.Location = New System.Drawing.Point(11, 144)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArea.Size = New System.Drawing.Size(121, 17)
        Me.lblArea.TabIndex = 43
        Me.lblArea.Text = "D0705'Area Class"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDisplay.Location = New System.Drawing.Point(11, 114)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDisplay.Size = New System.Drawing.Size(137, 17)
        Me.lblDisplay.TabIndex = 42
        Me.lblDisplay.Text = "D0704'Display Class"
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.BackColor = System.Drawing.Color.Transparent
        Me.lblDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDetail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDetail.Location = New System.Drawing.Point(11, 84)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDetail.Size = New System.Drawing.Size(124, 17)
        Me.lblDetail.TabIndex = 41
        Me.lblDetail.Text = "D0703'Detail Style"
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.BackColor = System.Drawing.Color.Transparent
        Me.lblMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaterial.Location = New System.Drawing.Point(11, 54)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaterial.Size = New System.Drawing.Size(103, 17)
        Me.lblMaterial.TabIndex = 40
        Me.lblMaterial.Text = "D0702'Material"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.BackColor = System.Drawing.Color.Transparent
        Me.lblElement.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblElement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblElement.Location = New System.Drawing.Point(11, 25)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblElement.Size = New System.Drawing.Size(104, 17)
        Me.lblElement.TabIndex = 39
        Me.lblElement.Text = "D0701'Element"
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(429, 340)
        Me.cmdRollover.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdRollover.Name = "cmdRollover"
        Me.cmdRollover.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRollover.Size = New System.Drawing.Size(40, 39)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(924, 383)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserConnectionForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "D0001'Single Horizontal Leg Brace Designer"
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStrip1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me._TabFrames_0.ResumeLayout(False)
        Me._TabFrames_0.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.groupHoles.ResumeLayout(False)
        Me.groupHoles.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.groupWeld.ResumeLayout(False)
        Me.groupWeld.PerformLayout()
        Me.groupBolt.ResumeLayout(False)
        Me.groupBolt.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me._TabFrames_1.ResumeLayout(False)
        Me._TabFrames_1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me._TabFrames_5.ResumeLayout(False)
        Me._TabFrames_5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me._TabFrames_6.ResumeLayout(False)
        Me._TabFrames_6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents _TabFrames_0 As System.Windows.Forms.GroupBox
    Public WithEvents _TabFrames_1 As System.Windows.Forms.GroupBox
    Public WithEvents _TabFrames_6 As System.Windows.Forms.GroupBox
    Public WithEvents cboLevel As System.Windows.Forms.ComboBox
    Public WithEvents cboDescription As System.Windows.Forms.ComboBox
    Public WithEvents cboPartFamily As System.Windows.Forms.ComboBox
    Public WithEvents cboAreaClass As System.Windows.Forms.ComboBox
    Public WithEvents cboDisplayClass As System.Windows.Forms.ComboBox
    Public WithEvents cboDetailStyle As System.Windows.Forms.ComboBox
    Public WithEvents cboMaterial As System.Windows.Forms.ComboBox
    Public WithEvents txtItemNumber As System.Windows.Forms.TextBox
    Public WithEvents cboElement As PlugInBase.ImageCombo
    Public WithEvents lblItem As System.Windows.Forms.Label
    Public WithEvents lblLayer As System.Windows.Forms.Label
    Public WithEvents lblDescription As System.Windows.Forms.Label
    Public WithEvents lblFamily As System.Windows.Forms.Label
    Public WithEvents lblArea As System.Windows.Forms.Label
    Public WithEvents lblDisplay As System.Windows.Forms.Label
    Public WithEvents lblDetail As System.Windows.Forms.Label
    Public WithEvents lblMaterial As System.Windows.Forms.Label
    Public WithEvents lblElement As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents txtSpChamferDistance As System.Windows.Forms.TextBox
    Public WithEvents txtSpHeight As System.Windows.Forms.TextBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents _TabFrames_5 As System.Windows.Forms.GroupBox
    Public WithEvents txtSpThick As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtBpThick As System.Windows.Forms.TextBox
    Public WithEvents lblThick As System.Windows.Forms.Label
    Public WithEvents chkCreateGroup As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtBpTolerance As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents txtBpE As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtBpD As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txtBpC As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtBpB As System.Windows.Forms.TextBox
    Public WithEvents txtBpA As System.Windows.Forms.TextBox
    Public WithEvents lblHeight As System.Windows.Forms.Label
    Public WithEvents lblWidth As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtSp2Thick As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtSp2ChamferDistance As System.Windows.Forms.TextBox
    Public WithEvents txtSp2Height As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtBpGapEnd As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkParallelToLeg As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents groupHoles As System.Windows.Forms.GroupBox
    Public WithEvents txtBoltSize As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtWorkLoose As System.Windows.Forms.TextBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtSlotLen As System.Windows.Forms.TextBox
    Public WithEvents txtSlotRotation As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents txtBpVerHoleNum As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtBpVerA As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtBpVerB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents txtBpHorHoleNum As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtBpHorA As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents txtBpHorB As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents groupWeld As System.Windows.Forms.GroupBox
    Public WithEvents lblWeldStyle As System.Windows.Forms.Label
    Public WithEvents cbWeldStyle As System.Windows.Forms.ComboBox
    Friend WithEvents groupBolt As System.Windows.Forms.GroupBox
    Public WithEvents lblBoltStyle As System.Windows.Forms.Label
    Public WithEvents chkTurnBolts As System.Windows.Forms.CheckBox
    Public WithEvents cbBoltStyle As System.Windows.Forms.ComboBox
    Friend WithEvents radioWeld As System.Windows.Forms.RadioButton
    Friend WithEvents radioHoleBolt As System.Windows.Forms.RadioButton
    Friend WithEvents radioHole As System.Windows.Forms.RadioButton
#End Region
End Class