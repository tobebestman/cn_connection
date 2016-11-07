Option Strict Off
Option Explicit On

Imports Bentley.ProStructures
Imports Bentley.ProStructures.Annotation
Imports Bentley.ProStructures.Assignment
Imports Bentley.ProStructures.CadSystem
Imports Bentley.ProStructures.Concrete
Imports Bentley.ProStructures.Concrete.Footing
Imports Bentley.ProStructures.Concrete.Miscellaneous
Imports Bentley.ProStructures.Concrete.Panel
Imports Bentley.ProStructures.Concrete.Reinforcement.Mesh
Imports Bentley.ProStructures.Concrete.Reinforcement.Rebar
Imports Bentley.ProStructures.Concrete.Reinforcement.Stirrup
Imports Bentley.ProStructures.Concrete.Shape
Imports Bentley.ProStructures.Concrete.Slab
Imports Bentley.ProStructures.Configuration
Imports Bentley.ProStructures.Connection.General
Imports Bentley.ProStructures.Connection.LinkData
Imports Bentley.ProStructures.Connection.Standard
Imports Bentley.ProStructures.Drawing
Imports Bentley.ProStructures.Entity
Imports Bentley.ProStructures.Geometry.Data
Imports Bentley.ProStructures.Geometry.Utilities
Imports Bentley.ProStructures.LogicalLink
Imports Bentley.ProStructures.Miscellaneous
Imports Bentley.ProStructures.ModelBuild
Imports Bentley.ProStructures.Modification.Edit
Imports Bentley.ProStructures.Modification.LinkData
Imports Bentley.ProStructures.Modification.ObjectData
Imports Bentley.ProStructures.Modification
Imports Bentley.ProStructures.Property
Imports Bentley.ProStructures.Property.RebarCodes
Imports Bentley.ProStructures.Steel.Bolt
Imports Bentley.ProStructures.Steel.Plate
Imports Bentley.ProStructures.Steel.Primitive
Imports Bentley.ProStructures.Steel.Shape
Imports Bentley.ProStructures.StructuralObject
Imports Bentley.ProStructures.StructuralObject.JoistData


Imports PlugInBase
Imports PlugInBase.PlugInCommon
Imports PlugInBase.PlugInCommon.CommonFunctions
Imports PlugInBase.PlugInCommon.ListsFunctions
Imports PlugInBase.PlugInCommon.CommonConstants
Imports PlugInBase.PlugInCommon.KeyBoard
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility

Friend Class UserConnectionForm
    Inherits System.Windows.Forms.Form

    Public mCallBack As UserConnection
    Public mIsCreatingConn As Boolean = False

    Private ConnectionId As IntPtr
    Private CancelData As Parameters
    Private hOriginalParent As Integer
    Private mEnableBitmaps As Boolean
    Private mBitmapStatus As Boolean
    Private mActivePage As Integer
    Private mCurrentBitmap As String
    Private bFormLoadFinished As Boolean = False
    Private DisableUpdate As Boolean
    Private mEnableForceUpdate As Boolean
    Private NoLine As Integer
    Private mCurrentTextBox As System.Windows.Forms.TextBox
    Private oCheckInput As CheckInput


    Private Sub cmdBitmaps_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBitmaps.Click
        If mBitmapStatus Then
            mBitmapStatus = False
        Else
            mBitmapStatus = True
        End If

        If mBitmapStatus Then
            Me.Width = TabStrip1.Width + picBitmap.Width + LAYOUTGAP * 3
            cmdBitmaps.Image = imgIcons.Images.Item(0)
            ToolTip1.SetToolTip(cmdBitmaps, UserConnection.RSS.RSS("S1009"))
        Else
            Me.Width = TabStrip1.Width + LAYOUTGAP * 2
            cmdBitmaps.Image = imgIcons.Images.Item(2)
            ToolTip1.SetToolTip(cmdBitmaps, UserConnection.RSS.RSS("S1008"))
        End If
    End Sub

    Private Sub cmdClone_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClone.Click
        Dim Index As Integer
        Dim ConnId As Long

        Dim Identifier As String
        Dim Entity As Long

        Dim Selection As New PsSelection
        Dim EditLogicalLink As New PsEditLogicalLink

        Dim oTrans As New PsTransaction
        Dim SourceConnection As PsConnection = Nothing

        DisableUpdate = True
        Me.Hide()
        Entity = Selection.PickObject(UserConnection.RSS.RSS("M0004"))
        Me.Show(Owner)

        If Entity <> 0 Then
            EditLogicalLink.SetObjectId(Entity)

            Dim c As Integer = EditLogicalLink.get_ConnectionCount() - 1
            For Index = 0 To c
                ConnId = EditLogicalLink.ConnectionId(Index)
                If ConnId <> 0 Then
                    Try
                        oTrans.GetObject(ConnId, PsOpenMode.kForRead, SourceConnection)
                        If Not SourceConnection Is Nothing Then
                            Identifier = SourceConnection.GetIdentifier

                            If Identifier = PLUGIN_IDENTIFIER Then
                                Index = -1
                                UserConnection.Data.ReadFromConnection(SourceConnection, True)
                                WriteToDialog(UserConnection.Data)
                                Exit For
                            End If
                        End If
                    Catch ex As Exception
                    Finally
                        oTrans.Close()
                    End Try
                End If
            Next Index
        End If

        DisableUpdate = False
        If Index = -1 Then UpdateConnection()

        EditLogicalLink = Nothing
        SourceConnection = Nothing
        Selection = Nothing
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Dim eConnection As PsConnection = Nothing
        If mIsCreatingConn Then
            mCallBack.CleanI(ConnectionId)
        Else
            mCallBack.CleanI(ConnectionId, False)
            CancelData.WriteToConnectionId(ConnectionId.ToInt64)
            Dim oTrans As New PsTransaction
            Try
                If oTrans.GetObject(ConnectionId.ToInt64, PsOpenMode.kForWrite, eConnection) Then
                    eConnection.IsBuilt = True
                End If
            Catch ex As Exception
            Finally
                oTrans.Close()
            End Try

            mCallBack.BuildI(ConnectionId)
        End If

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub cmdForceUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdForceUpdate.Click
        UpdateConnection(True)
    End Sub

    Private Sub GetDistFromLine()
        Dim oSel As New PsSelection
        Dim Line As New PsGeoLine
        Dim pickId As Long

        Me.Hide()

        pickId = oSel.PickObject("Select Line to Get Length:")

        If Line.GetPointsFromLine(pickId) Then
            mCurrentTextBox.Text = FToA(Line.Length)
            UpdateConnection()
        End If

        Me.Show()
    End Sub

    Private Sub cmdGetLengthFromLine_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetLengthFromLine.Click
        GetDistFromLine()
    End Sub

    Private Sub cmdHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelp.Click
        Help.ShowHelp(Me, UserConnection.GlobalSettings.PluginDataPath & "\" + PLUGIN_IDENTIFIER + ".chm")
    End Sub

    Private Sub cmdTemplate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTemplate.Click
        Dim Template As New PsTemplateManager

        DisableUpdate = True

        ReadFromDialog(UserConnection.Data)
        UserConnection.Data.WriteToTemplate(Template)
        Template.SetTemplateFile(PLUGIN_IDENTIFIER)

        Me.Hide()
        'Me.TopMost = False
        Template.EditTemplates(PLUGIN_VERSION)
        Me.Show()
        'Me.TopMost = True

        UserConnection.Data.ReadFromTemplate(Template)
        WriteToDialog(UserConnection.Data)

        DisableUpdate = False
        UpdateConnection()

        Template = Nothing
    End Sub

    Private Sub cmdAccept_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAccept.Click
        Dim Template As New PsTemplateManager

        UserConnection.Data.WriteToTemplate(Template)
        Template.SaveTemplateEntry(PLUGIN_IDENTIFIER, PLUGIN_VERSION)
        Template = Nothing

        Template = New PsTemplateManager
        Template.AppendDouble(Top)
        Template.AppendDouble(Left)
        Template.AppendNumber(Me.TabStrip1.SelectedIndex)
        Template.AppendBoolean(mBitmapStatus)
        Template.SaveTemplateEntry(PLUGIN_IDENTIFIER & "_WndCfg", PLUGIN_VERSION)

        Template = Nothing

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub ReadFromDialog(ByRef Data As Parameters)
        'bottom plate
        Data.mBpAngleA = AngToF(txtBpA.Text)
        Data.mBpEdgeOuter = AToF(txtBpB.Text)
        Data.mBpEdgeInter = AToF(txtBpC.Text)
        Data.mBpEdgeDistance = AToF(txtBpD.Text)
        Data.mBpOffsetGusset = AToF(txtBpE.Text)
        Data.mBpThick = AToF(txtBpThick.Text)
        Data.mBpGapEnd = AToF(txtBpGapEnd.Text)
        Data.mBpTolerance = AToF(txtBpTolerance.Text)

        Data.mBpHorHoleNum = Convert.ToInt32(txtBpHorHoleNum.Text)
        Data.mBpA = AToF(txtBpHorA.Text)
        Data.mBpB = AToF(txtBpHorB.Text)
        Data.mBpVerHoleNum = Convert.ToInt32(txtBpVerHoleNum.Text)
        Data.mBpA2 = AToF(txtBpVerA.Text)
        Data.mBpB2 = AToF(txtBpVerB.Text)

        Data.mHoleDia = AToF(txtBoltSize.Text)
        Data.mSlotLen = AToF(txtSlotLen.Text)
        Data.mWorkLoose = AToF(txtWorkLoose.Text)
        Data.mSlotRotation = AToF(txtSlotRotation.Text)

        Data.mBoltStyle = cbBoltStyle.Text
        Data.mWeldStyle = cbWeldStyle.Text
        Data.mBoltWeldStatus = IIf(Me.radioWeld.Checked, 2, IIf(Me.radioHole.Checked, 1, 0))
        Data.mTurnBolt = Me.chkTurnBolts.CheckState

        'side plate 1
        Data.mSpHeight = AToF(txtSpHeight.Text)
        Data.mSpThick = AToF(txtSpThick.Text)
        Data.mSpChamferDistance = AToF(txtSpChamferDistance.Text)
        Data.mSpParallelToLeg = chkParallelToLeg.Checked

        'side plate 2
        Data.mSp2Height = AToF(txtSp2Height.Text)
        Data.mSp2Thick = AToF(txtSp2Thick.Text)
        Data.mSp2ChamferDistance = AToF(txtSp2ChamferDistance.Text)

        'Group
        Data.mCreateGroup = chkCreateGroup.Checked

        'Assignment
        Data.mElement = CInt(GetImageCombo(cboElement, (Data.mElement)))
        Dim index As Integer = Data.mElement
        Data.mAssign(index).Material = GetMaterialIndex(cboMaterial)
        Data.mAssign(index).DetailStyle = cboDetailStyle.Text
        Data.mAssign(index).DisplayClass = cboDisplayClass.SelectedIndex
        Data.mAssign(index).AreaClass = cboAreaClass.SelectedIndex
        Data.mAssign(index).PartFamily = GetPartFamilyIndex((cboPartFamily))
        Data.mAssign(index).Description = cboDescription.SelectedIndex
        Data.mAssign(index).Level = cboLevel.Text
        Data.mAssign(index).ItemNumber = txtItemNumber.Text
    End Sub

    Private Sub WriteToDialog(ByRef Data As Parameters)
        'bottom plate
        txtBpA.Text = oCheckInput.CheckAngular(FToA(Data.mBpAngleA))
        txtBpB.Text = FToA(Data.mBpEdgeOuter)
        txtBpC.Text = FToA(Data.mBpEdgeInter)
        txtBpD.Text = FToA(Data.mBpEdgeDistance)
        txtBpE.Text = FToA(Data.mBpOffsetGusset)
        txtBpThick.Text = FToA(Data.mBpThick)
        txtBpGapEnd.Text = FToA(Data.mBpGapEnd)
        txtBpTolerance.Text = FToA(Data.mBpTolerance)

        txtBpHorHoleNum.Text = Data.mBpHorHoleNum.ToString()
        txtBpHorA.Text = FToA(Data.mBpA)
        txtBpHorB.Text = FToA(Data.mBpB)
        txtBpVerHoleNum.Text = Data.mBpVerHoleNum.ToString()
        txtBpVerA.Text = FToA(Data.mBpA2)
        txtBpVerB.Text = FToA(Data.mBpB2)

        txtBoltSize.Text = FToA(Data.mHoleDia)
        txtSlotLen.Text = FToA(Data.mSlotLen)
        txtWorkLoose.Text = FToA(Data.mWorkLoose)
        txtSlotRotation.Text = oCheckInput.CheckAngular(FToA(Data.mSlotRotation))

        cbBoltStyle.Text = Data.mBoltStyle
        cbWeldStyle.Text = Data.mWeldStyle

        Me.radioHoleBolt.Checked = Data.mBoltWeldStatus = 0
        Me.radioHole.Checked = Data.mBoltWeldStatus = 1
        Me.radioWeld.Checked = Data.mBoltWeldStatus = 2
        Me.chkTurnBolts.CheckState = Data.mTurnBolt

        'side plate 1
        txtSpHeight.Text = FToA(Data.mSpHeight)
        txtSpThick.Text = FToA(Data.mSpThick)
        txtSpChamferDistance.Text = FToA(Data.mSpChamferDistance)
        chkParallelToLeg.Checked = Data.mSpParallelToLeg

        'side plate 2
        txtSp2Height.Text = FToA(Data.mSp2Height)
        txtSp2Thick.Text = FToA(Data.mSp2Thick)
        txtSp2ChamferDistance.Text = FToA(Data.mSp2ChamferDistance)

        'Group
        chkCreateGroup.Checked = Data.mCreateGroup

        'Assignment
        Dim index As Integer = Data.mElement
        SetImageCombo(cboElement, (index))
        SetMaterialIndex(cboMaterial, Data.mAssign(index).Material)
        cboDetailStyle.Text = Data.mAssign(index).DetailStyle

        SafeSetIndex(cboDisplayClass, Data.mAssign(index).DisplayClass)
        SafeSetIndex(cboAreaClass, Data.mAssign(index).AreaClass)
        SafeSetIndex(cboPartFamily, Data.mAssign(index).PartFamily)
        SafeSetIndex(cboDescription, Data.mAssign(index).Description)

        cboLevel.Text = Data.mAssign(index).Level
        txtItemNumber.Text = Data.mAssign(index).ItemNumber
    End Sub

    Public Sub EditData(ByRef ConnId As IntPtr)
        If ConnId <> 0 Then
            ConnectionId = ConnId

            UserConnection.Data.ReadFromConnectionId(ConnectionId.ToInt64)

            If Not mIsCreatingConn Then
                CancelData.ReadFromConnectionId(ConnectionId.ToInt64)
            End If

            Me.Show(Owner)
            WriteToDialog(UserConnection.Data)
            bFormLoadFinished = True

            DisableUpdate = False
            GreyOptions()
        End If
    End Sub

    Private Sub FormsInitialize()
        DisableUpdate = True
        mEnableForceUpdate = Not UserConnection.GlobalSettings.DynamicConnections
        NoLine = 1
        oCheckInput = New CheckInput()
        CancelData = New Parameters
        EnableUI()
        TabStrip1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub UserConnectionForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'Dim userconnection.GlobalSettings As PSCOMWRAPPERLib.Ks_ComGlobalSettings
            'userconnection.GlobalSettings = AcadApp.GetInterfaceObject("PSCOMWRAPPER.Ks_ComGlobalSettings")
            Help.ShowHelp(Me, UserConnection.GlobalSettings.PluginDataPath & "\" + PLUGIN_IDENTIFIER + ".chm")
        End If
    End Sub

    Private Sub UserConnectionForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Width = TabStrip1.Width + LAYOUTGAP * 2

        'bolt style
        DisplayBoltTypeList(Me.cbBoltStyle, UserConnection.Data.mBoltStyle)

        'weld style
        Dim weldStyle As New WeldStyleManager
        For Each style As String In weldStyle.WeldStyle
            Me.cbWeldStyle.Items.Add(style)
        Next
        weldStyle = Nothing

        'Assignment
        cboElement.AddNewItem(UserConnection.RSS.RSS("S0100"), -1)
        cboElement.AddNewItem(UserConnection.RSS.RSS("S0101"), -1)

        cboMaterial.Enabled = DisplayMaterialList(cboMaterial) > 0
        cboDetailStyle.Enabled = DisplayDetailStyleList(cboDetailStyle) > 0
        cboDisplayClass.Enabled = DisplayDisplayClassList(cboDisplayClass) > 0
        cboAreaClass.Enabled = DisplayAreaClassList(cboAreaClass) > 0
        cboPartFamily.Enabled = DisplayFamilyClassList(cboPartFamily) > 0
        cboDescription.Enabled = DisplayDescriptionClassList(cboDescription) > 0
        cboLevel.Enabled = DisplayLayerList(cboLevel) > 0

        '
        Dim Resource As New KsxLanguage

        'LaterModify
        'Resource.ToolTips = mEnableToolTips
        Resource.SetResourceFile(PLUGIN_IDENTIFIER & ".rss")
        Resource.UpdateForm(Me)
        Resource.Reset()

        Resource = Nothing

        Dim Filename As String
        Dim ReturnValue As String
        Dim Template As New PsTemplateManager

        Filename = UserConnection.GlobalSettings.TempPath(True) & "\" & PLUGIN_IDENTIFIER & "_WndCfg" & ".sve"
        ReturnValue = Dir(Filename)

        If ReturnValue <> "" Then
            Template.LoadTemplateEntry(PLUGIN_IDENTIFIER & "_WndCfg")

            If Template.DoubleCount > 1 Then
                Me.Top = (Template.Double(0))
                Me.Left = (Template.Double(1))
            End If

            If Template.NumberCount > 0 Then
                If Template.Number(0) < Me.TabStrip1.TabCount Then
                    Me.TabStrip1.SelectedIndex = Template.Number(0)
                End If
            End If

            If Template.BooleanCount > 0 Then
                If mBitmapStatus <> Template.Boolean(0) Then Me.cmdBitmaps_Click(Nothing, Nothing)
            End If
        End If

        Template = Nothing
    End Sub

    Private Sub UserConnectionForm_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UserConnection.mDlgShownIds.Remove(Me.ConnectionId)
        System.Windows.Forms.SendKeys.SendWait("{ESC}")
        CancelData = Nothing
    End Sub

    Private Sub TabStrip1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChanged
        Dim fileName As String = String.Empty

        Select Case Me.TabStrip1.SelectedIndex
            Case 0
                fileName = "BottomP"
            Case 1, 2
                fileName = "BoltWeld"
            Case 3
                fileName = "SideP"
            Case 4
                fileName = "SideP2"
            Case Else
                fileName = "All"
        End Select

        picBitmap.Image = Nothing

        If Len(fileName) Then
            fileName = UserConnection.GlobalSettings.PluginDataPath & "\" & PLUGIN_IDENTIFIER & "\" & fileName & ".png"
            If Len(Dir(fileName)) > 0 Then
                picBitmap.Image = System.Drawing.Image.FromFile(fileName)
            End If
        End If
    End Sub

    Private Sub txt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtWorkLoose.Enter, txtSlotRotation.Enter, txtSlotLen.Enter, txtBoltSize.Enter, _
        txtBpVerB.Enter, txtBpHorB.Enter, txtBpVerA.Enter, txtBpHorA.Enter, txtBpVerHoleNum.Enter, txtBpHorHoleNum.Enter, _
        txtBpTolerance.Enter, txtBpGapEnd.Enter, txtBpThick.Enter, txtBpE.Enter, txtBpD.Enter, txtBpC.Enter, txtBpB.Enter, txtBpA.Enter, _
        txtSpThick.Enter, txtSpHeight.Enter, txtSpChamferDistance.Enter, _
        txtSp2Thick.Enter, txtSp2Height.Enter, txtSp2ChamferDistance.Enter

        oCheckInput.OldValue = eventSender.Text
        mCurrentTextBox = eventSender
        NoLine = 0
        GreyOptions()
    End Sub

    Private Sub txtPositive_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtBoltSize.Leave, _
        txtBpVerB.Leave, txtBpHorB.Leave, txtBpVerA.Leave, txtBpHorA.Leave, _
        txtBpThick.Leave, txtBpC.Leave, txtBpB.Leave, txtBpE.Leave, _
        txtSpThick.Leave, txtSpHeight.Leave, txtSpChamferDistance.Leave, _
        txtSp2Thick.Leave, txtSp2Height.Leave, txtSp2ChamferDistance.Leave

        eventSender.Text = oCheckInput.CheckPositive(eventSender.Text)
        If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    End Sub

    Private Sub txtNonNegative_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtWorkLoose.Leave, txtSlotLen.Leave, _
        txtBpTolerance.Leave, txtBpGapEnd.Leave, txtBpD.Leave

        eventSender.Text = oCheckInput.CheckNonNegative(eventSender.Text)
        If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    End Sub

    Private Sub txtAngle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtSlotRotation.Leave, txtBpA.Leave

        eventSender.Text = oCheckInput.CheckAngular(eventSender.Text)
        If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    End Sub

    Private Sub txtPositiveInt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtBpVerHoleNum.Leave, txtBpHorHoleNum.Leave

        eventSender.Text = Math.Abs(Convert.ToInt32(Single.Parse(oCheckInput.CheckNumeric(eventSender.Text, True))))
        If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    End Sub

    Private Sub UpdateConnection(Optional ByRef ForceUpdate As Boolean = False)
        If Not bFormLoadFinished OrElse DisableUpdate Then Return

        Try
            EnableUI()
            If (DisableUpdate = 0 And Not mEnableForceUpdate) Or ForceUpdate Then
                Dim oConnAdapter As ConnectionAdapter = New ConnectionAdapter(ConnectionId.ToInt64)
                If Not oConnAdapter.IsValidConnection Then Return
                oConnAdapter = Nothing

                ReadFromDialog(UserConnection.Data)
                UserConnection.Data.WriteToConnectionId(ConnectionId.ToInt64)

                mCallBack.BuildI(ConnectionId)
            End If
        Catch ex As Exception
            ErrorLog.ShowError(ex)
        End Try
    End Sub

    Private Sub GreyOptions()
        If NoLine = 0 Then
            cmdGetLengthFromLine.Enabled = True
        Else
            cmdGetLengthFromLine.Enabled = False
        End If

        cmdForceUpdate.Visible = mEnableForceUpdate

        If cboMaterial.Items.Count > 0 Then
            cboMaterial.Visible = True
        Else
            cboMaterial.Visible = False
        End If

        If cboDescription.Items.Count > 0 Then
            cboDescription.Visible = True
        Else
            cboDescription.Visible = False
        End If

        If cboDetailStyle.Items.Count > 0 Then
            cboDetailStyle.Visible = True
        Else
            cboDetailStyle.Visible = False
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        oCheckInput = Nothing
    End Sub

    Private Sub EnableUI()
        groupHoles.Enabled = Not radioWeld.Checked
        groupBolt.Enabled = Not radioWeld.Checked
        groupWeld.Enabled = radioWeld.Checked
    End Sub
    Private Sub radioHoleBolt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles radioHoleBolt.CheckedChanged, radioHole.CheckedChanged, radioWeld.CheckedChanged
        If sender Is radioWeld Then EnableUI()
        UpdateConnection()
    End Sub

    Private Sub chkCreateGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreateGroup.CheckedChanged
        UpdateConnection()
    End Sub

    Private Sub cboElement_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboElement.SelectedIndexChanged
        If DisableUpdate = True Then Return
        Try
            Dim index As Integer
            index = CInt(GetImageCombo(cboElement, (index)))
            If index <> UserConnection.Data.mElement Then
                DisableUpdate = True

                SetMaterialIndex(cboMaterial, UserConnection.Data.mAssign(index).Material)
                cboDetailStyle.Text = UserConnection.Data.mAssign(index).DetailStyle

                If cboDisplayClass.Items.Count > UserConnection.Data.mAssign(index).DisplayClass Then
                    cboDisplayClass.SelectedIndex = UserConnection.Data.mAssign(index).DisplayClass
                End If

                If cboAreaClass.Items.Count > UserConnection.Data.mAssign(index).AreaClass Then
                    cboAreaClass.SelectedIndex = UserConnection.Data.mAssign(index).AreaClass
                End If

                SetPartFamilyIndex((cboPartFamily), UserConnection.Data.mAssign(index).PartFamily)

                If cboDescription.Items.Count > UserConnection.Data.mAssign(index).Description Then
                    cboDescription.SelectedIndex = UserConnection.Data.mAssign(index).Description
                End If

                cboLevel.Text = UserConnection.Data.mAssign(index).Level
                txtItemNumber.Text = UserConnection.Data.mAssign(index).ItemNumber

                DisableUpdate = False
                UpdateConnection()
            End If
        Catch ex As Exception
            ErrorLog.ShowError(ex)
        End Try
    End Sub

    Private Sub cboMaterial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaterial.SelectedIndexChanged
        If GetMaterialIndex(cboMaterial) <> UserConnection.Data.mAssign(UserConnection.Data.mElement).Material Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboDetailStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetailStyle.SelectedIndexChanged
        If Not cboDetailStyle.Text.Equals(UserConnection.Data.mAssign(UserConnection.Data.mElement).DetailStyle) Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboDisplayClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDisplayClass.SelectedIndexChanged
        If cboDisplayClass.SelectedIndex <> UserConnection.Data.mAssign(UserConnection.Data.mElement).DisplayClass Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboAreaClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaClass.SelectedIndexChanged
        If cboAreaClass.SelectedIndex <> UserConnection.Data.mAssign(UserConnection.Data.mElement).AreaClass Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboPartFamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPartFamily.SelectedIndexChanged
        If GetPartFamilyIndex((cboPartFamily)) <> UserConnection.Data.mAssign(UserConnection.Data.mElement).PartFamily Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboDescription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDescription.SelectedIndexChanged
        If cboDescription.SelectedIndex <> UserConnection.Data.mAssign(UserConnection.Data.mElement).Description Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cboLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLevel.SelectedIndexChanged
        If Not cboLevel.Text.Equals(UserConnection.Data.mAssign(UserConnection.Data.mElement).Level) Then
            UpdateConnection()
        End If
    End Sub

    Private Sub txtItemNumber_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNumber.Leave
        If Not txtItemNumber.Text.Equals(UserConnection.Data.mAssign(UserConnection.Data.mElement).ItemNumber) Then
            UpdateConnection()
        End If
    End Sub

    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles _
        cbBoltStyle.SelectedIndexChanged, cbWeldStyle.SelectedIndexChanged
        UpdateConnection()
    End Sub

    Private Sub chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles _
        chkTurnBolts.CheckedChanged, chkParallelToLeg.CheckedChanged
        UpdateConnection()
    End Sub
    Protected Overrides Sub DefWndProc(ByRef m As System.Windows.Forms.Message)
        If (m.Msg = 2) Then 'WM_DESTORY
            Me.Close() 'remove the ConnectionId from the re-entry guard set
        End If
        MyBase.DefWndProc(m)
    End Sub
End Class