<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserConnectionForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        FormsInitialize()
    End Sub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserConnectionForm))
        Me.TabPageWebConnPlate1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtWebOutterPLThk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWebInnerPLThk = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtWebUpperEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWebLowerEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridViewWebPlate = New System.Windows.Forms.DataGridView()
        Me.DataGridEdgeDistWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridYDescWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridBoltGroupWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabStrip1 = New System.Windows.Forms.TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChordInnerHigh = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtHoleDia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFlange2TopThk = New System.Windows.Forms.TextBox()
        Me.txtFlange1BottomThk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtWeb2Thk = New System.Windows.Forms.TextBox()
        Me.txtFlange1TopThk = New System.Windows.Forms.TextBox()
        Me.txtFlange2BottomThk = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTopOutterPLThk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTopInnerPLThk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTopUpperEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTopLowerEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridViewTopPlate = New System.Windows.Forms.DataGridView()
        Me.DataGridEdgeDistTop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridYDescTop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridBoltGroupTop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtBottomSlotRadius = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBottomSlotStraightlengh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBottomOutterPLThickness = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txtBottomInnerPLThickness = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtBottomPlateUpperEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtBottomPlateLowerEdgeDist = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.DataGridViewBottomPlate = New System.Windows.Forms.DataGridView()
        Me.DataGridEdgeDistBottom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridYDescBottom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridBoltGroupBottom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picBitmap = New System.Windows.Forms.PictureBox()
        Me.cmdGetLengthFromLine = New System.Windows.Forms.Button()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdBitmaps = New System.Windows.Forms.Button()
        Me.cmdForceUpdate = New System.Windows.Forms.Button()
        Me.cmdRollover = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdClone = New System.Windows.Forms.Button()
        Me.cmdTemplate = New System.Windows.Forms.Button()
        Me.txtTopSlotRadius = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTopSlotStraightlengh = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPageWebConnPlate1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewWebPlate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStrip1.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewTopPlate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridViewBottomPlate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPageWebConnPlate1
        '
        Me.TabPageWebConnPlate1.Controls.Add(Me.GroupBox1)
        Me.TabPageWebConnPlate1.Controls.Add(Me.txtWebUpperEdgeDist)
        Me.TabPageWebConnPlate1.Controls.Add(Me.Label13)
        Me.TabPageWebConnPlate1.Controls.Add(Me.txtWebLowerEdgeDist)
        Me.TabPageWebConnPlate1.Controls.Add(Me.Label14)
        Me.TabPageWebConnPlate1.Controls.Add(Me.DataGridViewWebPlate)
        Me.TabPageWebConnPlate1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageWebConnPlate1.Name = "TabPageWebConnPlate1"
        Me.TabPageWebConnPlate1.Size = New System.Drawing.Size(413, 317)
        Me.TabPageWebConnPlate1.TabIndex = 14
        Me.TabPageWebConnPlate1.Text = "D0200'Web Plate"
        Me.TabPageWebConnPlate1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWebOutterPLThk)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtWebInnerPLThk)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 77)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "D0401'Dimension"
        '
        'txtWebOutterPLThk
        '
        Me.txtWebOutterPLThk.AcceptsReturn = True
        Me.txtWebOutterPLThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebOutterPLThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebOutterPLThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebOutterPLThk.Location = New System.Drawing.Point(121, 18)
        Me.txtWebOutterPLThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWebOutterPLThk.MaxLength = 0
        Me.txtWebOutterPLThk.Name = "txtWebOutterPLThk"
        Me.txtWebOutterPLThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebOutterPLThk.Size = New System.Drawing.Size(57, 20)
        Me.txtWebOutterPLThk.TabIndex = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "D0402'Outter PL Thk"
        '
        'txtWebInnerPLThk
        '
        Me.txtWebInnerPLThk.AcceptsReturn = True
        Me.txtWebInnerPLThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebInnerPLThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebInnerPLThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebInnerPLThk.Location = New System.Drawing.Point(321, 18)
        Me.txtWebInnerPLThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWebInnerPLThk.MaxLength = 0
        Me.txtWebInnerPLThk.Name = "txtWebInnerPLThk"
        Me.txtWebInnerPLThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebInnerPLThk.Size = New System.Drawing.Size(57, 20)
        Me.txtWebInnerPLThk.TabIndex = 154
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(208, 21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 155
        Me.Label12.Text = "D0403'Inner PL Thk"
        '
        'txtWebUpperEdgeDist
        '
        Me.txtWebUpperEdgeDist.AcceptsReturn = True
        Me.txtWebUpperEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebUpperEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebUpperEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebUpperEdgeDist.Location = New System.Drawing.Point(131, 111)
        Me.txtWebUpperEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWebUpperEdgeDist.MaxLength = 0
        Me.txtWebUpperEdgeDist.Name = "txtWebUpperEdgeDist"
        Me.txtWebUpperEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebUpperEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtWebUpperEdgeDist.TabIndex = 173
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(26, 114)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "D0406'Upper EdgeDist"
        '
        'txtWebLowerEdgeDist
        '
        Me.txtWebLowerEdgeDist.AcceptsReturn = True
        Me.txtWebLowerEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebLowerEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebLowerEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebLowerEdgeDist.Location = New System.Drawing.Point(331, 111)
        Me.txtWebLowerEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWebLowerEdgeDist.MaxLength = 0
        Me.txtWebLowerEdgeDist.Name = "txtWebLowerEdgeDist"
        Me.txtWebLowerEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebLowerEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtWebLowerEdgeDist.TabIndex = 175
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(218, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 176
        Me.Label14.Text = "D0407'Lower EdgeDist"
        '
        'DataGridViewWebPlate
        '
        Me.DataGridViewWebPlate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewWebPlate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridEdgeDistWeb, Me.DataGridYDescWeb, Me.DataGridBoltGroupWeb})
        Me.DataGridViewWebPlate.Location = New System.Drawing.Point(11, 147)
        Me.DataGridViewWebPlate.Name = "DataGridViewWebPlate"
        Me.DataGridViewWebPlate.Size = New System.Drawing.Size(393, 164)
        Me.DataGridViewWebPlate.TabIndex = 172
        '
        'DataGridEdgeDistWeb
        '
        Me.DataGridEdgeDistWeb.HeaderText = "EdgeDist"
        Me.DataGridEdgeDistWeb.Name = "DataGridEdgeDistWeb"
        '
        'DataGridYDescWeb
        '
        Me.DataGridYDescWeb.HeaderText = "YDesc"
        Me.DataGridYDescWeb.Name = "DataGridYDescWeb"
        '
        'DataGridBoltGroupWeb
        '
        Me.DataGridBoltGroupWeb.HeaderText = "BoltGroup"
        Me.DataGridBoltGroupWeb.Name = "DataGridBoltGroupWeb"
        '
        'TabStrip1
        '
        Me.TabStrip1.Controls.Add(Me.TabPageGeneral)
        Me.TabStrip1.Controls.Add(Me.TabPageWebConnPlate1)
        Me.TabStrip1.Controls.Add(Me.TabPage1)
        Me.TabStrip1.Controls.Add(Me.TabPage2)
        Me.TabStrip1.Location = New System.Drawing.Point(4, 2)
        Me.TabStrip1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabStrip1.Name = "TabStrip1"
        Me.TabStrip1.SelectedIndex = 0
        Me.TabStrip1.Size = New System.Drawing.Size(421, 343)
        Me.TabStrip1.TabIndex = 1
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.Label1)
        Me.TabPageGeneral.Controls.Add(Me.txtChordInnerHigh)
        Me.TabPageGeneral.Controls.Add(Me.Label60)
        Me.TabPageGeneral.Controls.Add(Me.txtHoleDia)
        Me.TabPageGeneral.Controls.Add(Me.Label2)
        Me.TabPageGeneral.Controls.Add(Me.txtFlange2TopThk)
        Me.TabPageGeneral.Controls.Add(Me.txtFlange1BottomThk)
        Me.TabPageGeneral.Controls.Add(Me.Label3)
        Me.TabPageGeneral.Controls.Add(Me.Label71)
        Me.TabPageGeneral.Controls.Add(Me.txtWeb2Thk)
        Me.TabPageGeneral.Controls.Add(Me.txtFlange1TopThk)
        Me.TabPageGeneral.Controls.Add(Me.txtFlange2BottomThk)
        Me.TabPageGeneral.Controls.Add(Me.Label34)
        Me.TabPageGeneral.Controls.Add(Me.Label35)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(413, 317)
        Me.TabPageGeneral.TabIndex = 11
        Me.TabPageGeneral.Text = "D0100'General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "D0107'Chord Inner High"
        '
        'txtChordInnerHigh
        '
        Me.txtChordInnerHigh.AcceptsReturn = True
        Me.txtChordInnerHigh.BackColor = System.Drawing.SystemColors.Window
        Me.txtChordInnerHigh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChordInnerHigh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChordInnerHigh.Location = New System.Drawing.Point(194, 252)
        Me.txtChordInnerHigh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtChordInnerHigh.MaxLength = 0
        Me.txtChordInnerHigh.Name = "txtChordInnerHigh"
        Me.txtChordInnerHigh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChordInnerHigh.Size = New System.Drawing.Size(57, 20)
        Me.txtChordInnerHigh.TabIndex = 150
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(13, 213)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(82, 13)
        Me.Label60.TabIndex = 149
        Me.Label60.Text = "D0106'Hole Dia"
        '
        'txtHoleDia
        '
        Me.txtHoleDia.AcceptsReturn = True
        Me.txtHoleDia.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoleDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoleDia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoleDia.Location = New System.Drawing.Point(194, 210)
        Me.txtHoleDia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoleDia.MaxLength = 0
        Me.txtHoleDia.Name = "txtHoleDia"
        Me.txtHoleDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoleDia.Size = New System.Drawing.Size(57, 20)
        Me.txtHoleDia.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "D0103'Flange 2 Top Thk"
        '
        'txtFlange2TopThk
        '
        Me.txtFlange2TopThk.AcceptsReturn = True
        Me.txtFlange2TopThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlange2TopThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlange2TopThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlange2TopThk.Location = New System.Drawing.Point(194, 109)
        Me.txtFlange2TopThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFlange2TopThk.MaxLength = 0
        Me.txtFlange2TopThk.Name = "txtFlange2TopThk"
        Me.txtFlange2TopThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlange2TopThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlange2TopThk.TabIndex = 146
        '
        'txtFlange1BottomThk
        '
        Me.txtFlange1BottomThk.AcceptsReturn = True
        Me.txtFlange1BottomThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlange1BottomThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlange1BottomThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlange1BottomThk.Location = New System.Drawing.Point(194, 50)
        Me.txtFlange1BottomThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFlange1BottomThk.MaxLength = 0
        Me.txtFlange1BottomThk.Name = "txtFlange1BottomThk"
        Me.txtFlange1BottomThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlange1BottomThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlange1BottomThk.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "D0102'Flange 1 Bottom Thk"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label71.Location = New System.Drawing.Point(13, 179)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label71.Size = New System.Drawing.Size(95, 13)
        Me.Label71.TabIndex = 143
        Me.Label71.Text = "D0105'Web 2 Thk"
        '
        'txtWeb2Thk
        '
        Me.txtWeb2Thk.AcceptsReturn = True
        Me.txtWeb2Thk.BackColor = System.Drawing.SystemColors.Window
        Me.txtWeb2Thk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeb2Thk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWeb2Thk.Location = New System.Drawing.Point(194, 172)
        Me.txtWeb2Thk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWeb2Thk.MaxLength = 0
        Me.txtWeb2Thk.Name = "txtWeb2Thk"
        Me.txtWeb2Thk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWeb2Thk.Size = New System.Drawing.Size(57, 20)
        Me.txtWeb2Thk.TabIndex = 142
        '
        'txtFlange1TopThk
        '
        Me.txtFlange1TopThk.AcceptsReturn = True
        Me.txtFlange1TopThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlange1TopThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlange1TopThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlange1TopThk.Location = New System.Drawing.Point(194, 17)
        Me.txtFlange1TopThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFlange1TopThk.MaxLength = 0
        Me.txtFlange1TopThk.Name = "txtFlange1TopThk"
        Me.txtFlange1TopThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlange1TopThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlange1TopThk.TabIndex = 136
        '
        'txtFlange2BottomThk
        '
        Me.txtFlange2BottomThk.AcceptsReturn = True
        Me.txtFlange2BottomThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlange2BottomThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFlange2BottomThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFlange2BottomThk.Location = New System.Drawing.Point(194, 142)
        Me.txtFlange2BottomThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFlange2BottomThk.MaxLength = 0
        Me.txtFlange2BottomThk.Name = "txtFlange2BottomThk"
        Me.txtFlange2BottomThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFlange2BottomThk.Size = New System.Drawing.Size(57, 20)
        Me.txtFlange2BottomThk.TabIndex = 134
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(13, 24)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(126, 13)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "D0101'Flange 1 Top Thk"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(13, 145)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(140, 13)
        Me.Label35.TabIndex = 135
        Me.Label35.Text = "D0104'Flange 2 Bottom Thk"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.txtTopUpperEdgeDist)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtTopLowerEdgeDist)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DataGridViewTopPlate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(413, 317)
        Me.TabPage1.TabIndex = 15
        Me.TabPage1.Text = "D0300'Top Plate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTopSlotRadius)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtTopOutterPLThk)
        Me.GroupBox3.Controls.Add(Me.txtTopSlotStraightlengh)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTopInnerPLThk)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 77)
        Me.GroupBox3.TabIndex = 177
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "D0401'Dimension"
        '
        'txtTopOutterPLThk
        '
        Me.txtTopOutterPLThk.AcceptsReturn = True
        Me.txtTopOutterPLThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopOutterPLThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopOutterPLThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopOutterPLThk.Location = New System.Drawing.Point(119, 17)
        Me.txtTopOutterPLThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTopOutterPLThk.MaxLength = 0
        Me.txtTopOutterPLThk.Name = "txtTopOutterPLThk"
        Me.txtTopOutterPLThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopOutterPLThk.Size = New System.Drawing.Size(57, 20)
        Me.txtTopOutterPLThk.TabIndex = 150
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "D0402'Outter PL Thk"
        '
        'txtTopInnerPLThk
        '
        Me.txtTopInnerPLThk.AcceptsReturn = True
        Me.txtTopInnerPLThk.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopInnerPLThk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopInnerPLThk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopInnerPLThk.Location = New System.Drawing.Point(319, 17)
        Me.txtTopInnerPLThk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTopInnerPLThk.MaxLength = 0
        Me.txtTopInnerPLThk.Name = "txtTopInnerPLThk"
        Me.txtTopInnerPLThk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopInnerPLThk.Size = New System.Drawing.Size(57, 20)
        Me.txtTopInnerPLThk.TabIndex = 154
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(206, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "D0403'Inner PL Thk"
        '
        'txtTopUpperEdgeDist
        '
        Me.txtTopUpperEdgeDist.AcceptsReturn = True
        Me.txtTopUpperEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopUpperEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopUpperEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopUpperEdgeDist.Location = New System.Drawing.Point(129, 110)
        Me.txtTopUpperEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTopUpperEdgeDist.MaxLength = 0
        Me.txtTopUpperEdgeDist.Name = "txtTopUpperEdgeDist"
        Me.txtTopUpperEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopUpperEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtTopUpperEdgeDist.TabIndex = 173
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(24, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "D0406'Upper EdgeDist"
        '
        'txtTopLowerEdgeDist
        '
        Me.txtTopLowerEdgeDist.AcceptsReturn = True
        Me.txtTopLowerEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopLowerEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopLowerEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopLowerEdgeDist.Location = New System.Drawing.Point(329, 110)
        Me.txtTopLowerEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTopLowerEdgeDist.MaxLength = 0
        Me.txtTopLowerEdgeDist.Name = "txtTopLowerEdgeDist"
        Me.txtTopLowerEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopLowerEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtTopLowerEdgeDist.TabIndex = 175
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(216, 113)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "D0407'Lower EdgeDist"
        '
        'DataGridViewTopPlate
        '
        Me.DataGridViewTopPlate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTopPlate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridEdgeDistTop, Me.DataGridYDescTop, Me.DataGridBoltGroupTop})
        Me.DataGridViewTopPlate.Location = New System.Drawing.Point(9, 146)
        Me.DataGridViewTopPlate.Name = "DataGridViewTopPlate"
        Me.DataGridViewTopPlate.Size = New System.Drawing.Size(393, 164)
        Me.DataGridViewTopPlate.TabIndex = 172
        '
        'DataGridEdgeDistTop
        '
        Me.DataGridEdgeDistTop.HeaderText = "EdgeDist"
        Me.DataGridEdgeDistTop.Name = "DataGridEdgeDistTop"
        '
        'DataGridYDescTop
        '
        Me.DataGridYDescTop.HeaderText = "YDesc"
        Me.DataGridYDescTop.Name = "DataGridYDescTop"
        '
        'DataGridBoltGroupTop
        '
        Me.DataGridBoltGroupTop.HeaderText = "BoltGroup"
        Me.DataGridBoltGroupTop.Name = "DataGridBoltGroupTop"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.txtBottomPlateUpperEdgeDist)
        Me.TabPage2.Controls.Add(Me.Label75)
        Me.TabPage2.Controls.Add(Me.txtBottomPlateLowerEdgeDist)
        Me.TabPage2.Controls.Add(Me.Label83)
        Me.TabPage2.Controls.Add(Me.DataGridViewBottomPlate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(413, 317)
        Me.TabPage2.TabIndex = 16
        Me.TabPage2.Text = "D0400 Bottom Plate"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtBottomSlotRadius)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtBottomSlotStraightlengh)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txtBottomOutterPLThickness)
        Me.GroupBox7.Controls.Add(Me.Label90)
        Me.GroupBox7.Controls.Add(Me.txtBottomInnerPLThickness)
        Me.GroupBox7.Controls.Add(Me.Label91)
        Me.GroupBox7.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(390, 77)
        Me.GroupBox7.TabIndex = 171
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "D0401'Dimension"
        '
        'txtBottomSlotRadius
        '
        Me.txtBottomSlotRadius.AcceptsReturn = True
        Me.txtBottomSlotRadius.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomSlotRadius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomSlotRadius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomSlotRadius.Location = New System.Drawing.Point(121, 48)
        Me.txtBottomSlotRadius.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomSlotRadius.MaxLength = 0
        Me.txtBottomSlotRadius.Name = "txtBottomSlotRadius"
        Me.txtBottomSlotRadius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomSlotRadius.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomSlotRadius.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "D0404'Slot Radius"
        '
        'txtBottomSlotStraightlengh
        '
        Me.txtBottomSlotStraightlengh.AcceptsReturn = True
        Me.txtBottomSlotStraightlengh.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomSlotStraightlengh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomSlotStraightlengh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomSlotStraightlengh.Location = New System.Drawing.Point(321, 48)
        Me.txtBottomSlotStraightlengh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomSlotStraightlengh.MaxLength = 0
        Me.txtBottomSlotStraightlengh.Name = "txtBottomSlotStraightlengh"
        Me.txtBottomSlotStraightlengh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomSlotStraightlengh.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomSlotStraightlengh.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(208, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "D0405'Slot Straight lengh"
        '
        'txtBottomOutterPLThickness
        '
        Me.txtBottomOutterPLThickness.AcceptsReturn = True
        Me.txtBottomOutterPLThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomOutterPLThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomOutterPLThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomOutterPLThickness.Location = New System.Drawing.Point(121, 18)
        Me.txtBottomOutterPLThickness.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomOutterPLThickness.MaxLength = 0
        Me.txtBottomOutterPLThickness.Name = "txtBottomOutterPLThickness"
        Me.txtBottomOutterPLThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomOutterPLThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomOutterPLThickness.TabIndex = 150
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label90.Location = New System.Drawing.Point(16, 21)
        Me.Label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label90.Size = New System.Drawing.Size(108, 13)
        Me.Label90.TabIndex = 151
        Me.Label90.Text = "D0402'Outter PL Thk"
        '
        'txtBottomInnerPLThickness
        '
        Me.txtBottomInnerPLThickness.AcceptsReturn = True
        Me.txtBottomInnerPLThickness.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomInnerPLThickness.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomInnerPLThickness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomInnerPLThickness.Location = New System.Drawing.Point(321, 18)
        Me.txtBottomInnerPLThickness.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomInnerPLThickness.MaxLength = 0
        Me.txtBottomInnerPLThickness.Name = "txtBottomInnerPLThickness"
        Me.txtBottomInnerPLThickness.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomInnerPLThickness.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomInnerPLThickness.TabIndex = 154
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label91.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label91.Location = New System.Drawing.Point(208, 21)
        Me.Label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(103, 13)
        Me.Label91.TabIndex = 155
        Me.Label91.Text = "D0403'Inner PL Thk"
        '
        'txtBottomPlateUpperEdgeDist
        '
        Me.txtBottomPlateUpperEdgeDist.AcceptsReturn = True
        Me.txtBottomPlateUpperEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomPlateUpperEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomPlateUpperEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomPlateUpperEdgeDist.Location = New System.Drawing.Point(128, 110)
        Me.txtBottomPlateUpperEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomPlateUpperEdgeDist.MaxLength = 0
        Me.txtBottomPlateUpperEdgeDist.Name = "txtBottomPlateUpperEdgeDist"
        Me.txtBottomPlateUpperEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomPlateUpperEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomPlateUpperEdgeDist.TabIndex = 161
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label75.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label75.Location = New System.Drawing.Point(23, 113)
        Me.Label75.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label75.Size = New System.Drawing.Size(116, 13)
        Me.Label75.TabIndex = 162
        Me.Label75.Text = "D0406'Upper EdgeDist"
        '
        'txtBottomPlateLowerEdgeDist
        '
        Me.txtBottomPlateLowerEdgeDist.AcceptsReturn = True
        Me.txtBottomPlateLowerEdgeDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtBottomPlateLowerEdgeDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBottomPlateLowerEdgeDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBottomPlateLowerEdgeDist.Location = New System.Drawing.Point(328, 110)
        Me.txtBottomPlateLowerEdgeDist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBottomPlateLowerEdgeDist.MaxLength = 0
        Me.txtBottomPlateLowerEdgeDist.Name = "txtBottomPlateLowerEdgeDist"
        Me.txtBottomPlateLowerEdgeDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBottomPlateLowerEdgeDist.Size = New System.Drawing.Size(57, 20)
        Me.txtBottomPlateLowerEdgeDist.TabIndex = 163
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label83.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label83.Location = New System.Drawing.Point(215, 113)
        Me.Label83.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(116, 13)
        Me.Label83.TabIndex = 164
        Me.Label83.Text = "D0407'Lower EdgeDist"
        '
        'DataGridViewBottomPlate
        '
        Me.DataGridViewBottomPlate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBottomPlate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridEdgeDistBottom, Me.DataGridYDescBottom, Me.DataGridBoltGroupBottom})
        Me.DataGridViewBottomPlate.Location = New System.Drawing.Point(8, 146)
        Me.DataGridViewBottomPlate.Name = "DataGridViewBottomPlate"
        Me.DataGridViewBottomPlate.Size = New System.Drawing.Size(393, 164)
        Me.DataGridViewBottomPlate.TabIndex = 160
        '
        'DataGridEdgeDistBottom
        '
        Me.DataGridEdgeDistBottom.HeaderText = "EdgeDist"
        Me.DataGridEdgeDistBottom.Name = "DataGridEdgeDistBottom"
        '
        'DataGridYDescBottom
        '
        Me.DataGridYDescBottom.HeaderText = "YDesc"
        Me.DataGridYDescBottom.Name = "DataGridYDescBottom"
        '
        'DataGridBoltGroupBottom
        '
        Me.DataGridBoltGroupBottom.HeaderText = "BoltGroup"
        Me.DataGridBoltGroupBottom.Name = "DataGridBoltGroupBottom"
        '
        'picBitmap
        '
        Me.picBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.picBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBitmap.Location = New System.Drawing.Point(448, 2)
        Me.picBitmap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picBitmap.Name = "picBitmap"
        Me.picBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBitmap.Size = New System.Drawing.Size(262, 387)
        Me.picBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBitmap.TabIndex = 7
        Me.picBitmap.TabStop = False
        '
        'cmdGetLengthFromLine
        '
        Me.cmdGetLengthFromLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetLengthFromLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetLengthFromLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetLengthFromLine.Image = CType(resources.GetObject("cmdGetLengthFromLine.Image"), System.Drawing.Image)
        Me.cmdGetLengthFromLine.Location = New System.Drawing.Point(202, 357)
        Me.cmdGetLengthFromLine.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdGetLengthFromLine.Name = "cmdGetLengthFromLine"
        Me.cmdGetLengthFromLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetLengthFromLine.Size = New System.Drawing.Size(30, 32)
        Me.cmdGetLengthFromLine.TabIndex = 18
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
        Me.cmdAccept.Location = New System.Drawing.Point(4, 357)
        Me.cmdAccept.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAccept.Size = New System.Drawing.Size(30, 32)
        Me.cmdAccept.TabIndex = 17
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
        Me.cmdCancel.Location = New System.Drawing.Point(38, 357)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(30, 32)
        Me.cmdCancel.TabIndex = 16
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
        Me.cmdBitmaps.Location = New System.Drawing.Point(389, 357)
        Me.cmdBitmaps.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdBitmaps.Name = "cmdBitmaps"
        Me.cmdBitmaps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBitmaps.Size = New System.Drawing.Size(30, 32)
        Me.cmdBitmaps.TabIndex = 15
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
        Me.cmdForceUpdate.Location = New System.Drawing.Point(356, 357)
        Me.cmdForceUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdForceUpdate.Name = "cmdForceUpdate"
        Me.cmdForceUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdForceUpdate.Size = New System.Drawing.Size(30, 32)
        Me.cmdForceUpdate.TabIndex = 14
        Me.cmdForceUpdate.Tag = "S1010"
        Me.cmdForceUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdForceUpdate.UseVisualStyleBackColor = False
        '
        'cmdRollover
        '
        Me.cmdRollover.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRollover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRollover.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRollover.Image = CType(resources.GetObject("cmdRollover.Image"), System.Drawing.Image)
        Me.cmdRollover.Location = New System.Drawing.Point(322, 357)
        Me.cmdRollover.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdRollover.Name = "cmdRollover"
        Me.cmdRollover.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRollover.Size = New System.Drawing.Size(30, 32)
        Me.cmdRollover.TabIndex = 13
        Me.cmdRollover.Tag = "S1011"
        Me.cmdRollover.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRollover.UseVisualStyleBackColor = False
        Me.cmdRollover.Visible = False
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.Location = New System.Drawing.Point(71, 357)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp.Size = New System.Drawing.Size(30, 32)
        Me.cmdHelp.TabIndex = 12
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
        Me.cmdClone.Location = New System.Drawing.Point(139, 357)
        Me.cmdClone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdClone.Name = "cmdClone"
        Me.cmdClone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClone.Size = New System.Drawing.Size(30, 32)
        Me.cmdClone.TabIndex = 11
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
        Me.cmdTemplate.Location = New System.Drawing.Point(105, 357)
        Me.cmdTemplate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdTemplate.Name = "cmdTemplate"
        Me.cmdTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTemplate.Size = New System.Drawing.Size(30, 32)
        Me.cmdTemplate.TabIndex = 10
        Me.cmdTemplate.Tag = "S1004"
        Me.cmdTemplate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTemplate.UseVisualStyleBackColor = False
        '
        'txtTopSlotRadius
        '
        Me.txtTopSlotRadius.AcceptsReturn = True
        Me.txtTopSlotRadius.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopSlotRadius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopSlotRadius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopSlotRadius.Location = New System.Drawing.Point(119, 52)
        Me.txtTopSlotRadius.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTopSlotRadius.MaxLength = 0
        Me.txtTopSlotRadius.Name = "txtTopSlotRadius"
        Me.txtTopSlotRadius.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopSlotRadius.Size = New System.Drawing.Size(57, 20)
        Me.txtTopSlotRadius.TabIndex = 178
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "D0404'Slot Radius"
        '
        'txtTopSlotStraightlengh
        '
        Me.txtTopSlotStraightlengh.AcceptsReturn = True
        Me.txtTopSlotStraightlengh.BackColor = System.Drawing.SystemColors.Window
        Me.txtTopSlotStraightlengh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTopSlotStraightlengh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTopSlotStraightlengh.Location = New System.Drawing.Point(319, 52)
        Me.txtTopSlotStraightlengh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTopSlotStraightlengh.MaxLength = 0
        Me.txtTopSlotStraightlengh.Name = "txtTopSlotStraightlengh"
        Me.txtTopSlotStraightlengh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTopSlotStraightlengh.Size = New System.Drawing.Size(57, 20)
        Me.txtTopSlotStraightlengh.TabIndex = 180
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(206, 55)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(127, 13)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = "D0405'Slot Straight lengh"
        '
        'UserConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 395)
        Me.Controls.Add(Me.cmdGetLengthFromLine)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdBitmaps)
        Me.Controls.Add(Me.cmdForceUpdate)
        Me.Controls.Add(Me.cmdRollover)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdClone)
        Me.Controls.Add(Me.cmdTemplate)
        Me.Controls.Add(Me.picBitmap)
        Me.Controls.Add(Me.TabStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UserConnectionForm"
        Me.Text = "UserConnectionForm"
        Me.TabPageWebConnPlate1.ResumeLayout(False)
        Me.TabPageWebConnPlate1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewWebPlate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStrip1.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewTopPlate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridViewBottomPlate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBitmap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPageWebConnPlate1 As TabPage
    Public WithEvents TabStrip1 As TabControl
    Friend WithEvents TabPageGeneral As TabPage
    Public WithEvents Label71 As Label
    Public WithEvents txtWeb2Thk As TextBox
    Public WithEvents txtFlange1TopThk As TextBox
    Public WithEvents txtFlange2BottomThk As TextBox
    Public WithEvents Label34 As Label
    Public WithEvents Label35 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents Label2 As Label
    Public WithEvents txtFlange2TopThk As TextBox
    Public WithEvents txtFlange1BottomThk As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Public WithEvents txtBottomSlotRadius As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtBottomSlotStraightlengh As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtBottomOutterPLThickness As TextBox
    Public WithEvents Label90 As Label
    Public WithEvents txtBottomInnerPLThickness As TextBox
    Public WithEvents Label91 As Label
    Public WithEvents txtBottomPlateUpperEdgeDist As TextBox
    Public WithEvents Label75 As Label
    Public WithEvents txtBottomPlateLowerEdgeDist As TextBox
    Public WithEvents Label83 As Label
    Friend WithEvents DataGridViewBottomPlate As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents txtWebOutterPLThk As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents txtWebInnerPLThk As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents txtWebUpperEdgeDist As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents txtWebLowerEdgeDist As TextBox
    Public WithEvents Label14 As Label
    Friend WithEvents DataGridViewWebPlate As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents txtTopOutterPLThk As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents txtTopInnerPLThk As TextBox
    Public WithEvents Label9 As Label
    Public WithEvents txtTopUpperEdgeDist As TextBox
    Public WithEvents Label10 As Label
    Public WithEvents txtTopLowerEdgeDist As TextBox
    Public WithEvents Label11 As Label
    Friend WithEvents DataGridViewTopPlate As DataGridView
    Friend WithEvents DataGridEdgeDistWeb As DataGridViewTextBoxColumn
    Friend WithEvents DataGridYDescWeb As DataGridViewTextBoxColumn
    Friend WithEvents DataGridBoltGroupWeb As DataGridViewTextBoxColumn
    Friend WithEvents DataGridEdgeDistTop As DataGridViewTextBoxColumn
    Friend WithEvents DataGridYDescTop As DataGridViewTextBoxColumn
    Friend WithEvents DataGridBoltGroupTop As DataGridViewTextBoxColumn
    Friend WithEvents DataGridEdgeDistBottom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridYDescBottom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridBoltGroupBottom As DataGridViewTextBoxColumn
    Public WithEvents picBitmap As PictureBox
    Public WithEvents cmdGetLengthFromLine As Button
    Public WithEvents cmdAccept As Button
    Public WithEvents cmdCancel As Button
    Public WithEvents cmdBitmaps As Button
    Public WithEvents cmdForceUpdate As Button
    Public WithEvents cmdRollover As Button
    Public WithEvents cmdHelp As Button
    Public WithEvents cmdClone As Button
    Public WithEvents cmdTemplate As Button
    Public WithEvents Label60 As Label
    Public WithEvents txtHoleDia As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtChordInnerHigh As TextBox
    Public WithEvents txtTopSlotRadius As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtTopSlotStraightlengh As TextBox
    Public WithEvents Label15 As Label
End Class
