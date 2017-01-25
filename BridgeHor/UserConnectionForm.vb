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
Imports PlugInBase.KsxUnits
Imports System.Windows.Forms

Friend Class UserConnectionForm
    Inherits System.Windows.Forms.Form

    Public mCallBack As UserConnection
    Public mIsCreatingConn As Boolean = False

    Private ConnectionId As Long

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
    Private UIConverter As New KsxUnits


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
        Entity = Selection.PickObject(UserConnection.RSS.RSS("M0005"))
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
                                Dim data As New Parameters
                                data.ReadFromConnection(SourceConnection, True)
                                WriteToDialog(data)
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
            CancelData.WriteToConnectionId(ConnectionId)
            Dim oTrans As New PsTransaction
            Try
                If oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, eConnection) Then
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

        Dim data As New Parameters

        ReadFromDialog(data)
        data.WriteToTemplate(Template)
        Template.SetTemplateFile(PLUGIN_IDENTIFIER)

        Me.Hide()
        'Me.TopMost = False
        Template.EditTemplates(PLUGIN_VERSION)
        Me.Show()
        'Me.TopMost = True

        data.ReadFromTemplate(Template)
        WriteToDialog(data)

        DisableUpdate = False
        UpdateConnection()

        Template = Nothing
    End Sub

    Private Sub cmdAccept_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAccept.Click
        Dim Template As New PsTemplateManager
        Dim data As New Parameters
        data.mVersionNumber = PLUGIN_VERSION
        ReadFromDialog(data)

        data.WriteToTemplate(Template)
        Template.SaveTemplateEntry(PLUGIN_IDENTIFIER, PLUGIN_VERSION)
        Template = Nothing

        Template = New PsTemplateManager
        Template.AppendDouble(Me.Top)
        Template.AppendDouble(Me.Left)
        Template.AppendNumber(Me.TabStrip1.SelectedIndex)
        Template.AppendBoolean(mBitmapStatus)
        Template.SaveTemplateEntry(PLUGIN_IDENTIFIER & "_WndCfg", PLUGIN_VERSION)

        Template = Nothing

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub ReadFromDialog(ByRef Data As Parameters)

        Data.mHorCutback = UIConverter.ConvertToNumeric(txtHorCutBack.Text)
        Data.mHorWebCutback = UIConverter.ConvertToNumeric(txtHorFlangeCutBack.Text)
        Data.mDiagnalCutback = UIConverter.ConvertToNumeric(txtDiagnalCutback.Text)

        Data.mHorGap = UIConverter.ConvertToNumeric(txtHorGap.Text)
        Data.mDiagnalGap = UIConverter.ConvertToNumeric(txtDiagnalGap.Text)

        Data.mHorPlateThickness = UIConverter.ConvertToNumeric(txtHorPlateThickness.Text)
        Data.mHoleDia = UIConverter.ConvertToNumeric(txtHoleDia.Text)

        Data.mSidePlate.mHorFillet = UIConverter.ConvertToNumeric(txtHorFillet.Text)
        Data.mSidePlate.mDiagFillet = UIConverter.ConvertToNumeric(txtDiagFillet.Text)
        Data.mSidePlate.mHorAngle = UIConverter.ConvertAngleToNumeric(txtHorAngle.Text)
        Data.mSidePlate.mDiagAngle = UIConverter.ConvertAngleToNumeric(txtDiagAngle.Text)
        Data.mSidePlate.mHorTopDist = UIConverter.ConvertToNumeric(txtTopHorDist.Text)
        Data.mSidePlate.mDiagTopDist = UIConverter.ConvertToNumeric(txtTopDiagDist.Text)
        Data.mSidePlate.mHorBottomDist = UIConverter.ConvertToNumeric(txtBottomHorDist.Text)
        Data.mSidePlate.mDiagBottomDist = UIConverter.ConvertToNumeric(txtBottomDiagDist.Text)
        Data.mSidePlate.mOutsidePlateThickness = UIConverter.ConvertToNumeric(txtOutsidePlateThickness.Text)
        Data.mSidePlate.mInsidePlateThickness = UIConverter.ConvertToNumeric(txtInsidePlateThickness.Text)

        Data.mWebPlates.mChordSidePlateThickness = UIConverter.ConvertToNumeric(txtChordSideWebPlateThickness.Text)
        Data.mWebPlates.mBraceSidePlateThickness = UIConverter.ConvertToNumeric(txtBraceSideWebPlateThickness.Text)
        Data.mWebPlates.mBraceSidePlateLength = UIConverter.ConvertToNumeric(txtBraceSideWebPlateLength.Text)
        Data.mWebPlates.mSupportPlateOffset = UIConverter.ConvertToNumeric(txtSupportPlateOffset.Text)
        Data.mWebPlates.mSupportPlateThickness = UIConverter.ConvertToNumeric(txtSupportPlateThickness.Text)

        Data.mWebPlates.mHoleDiameter = UIConverter.ConvertToNumeric(txtHoleDiameter.Text)
        Data.mWebPlates.mHorHoleDist = UIConverter.ConvertToNumeric(txtHorHoleDist.Text)
        Data.mWebPlates.mHorHoleEdgeDist = UIConverter.ConvertToNumeric(txtHorHoleEdgeDist.Text)
        Data.mWebPlates.mVerHoleDist = UIConverter.ConvertToNumeric(txtVerHoleDist.Text)
        Data.mWebPlates.mVerHoleEdgeDist = UIConverter.ConvertToNumeric(txtVerHoleEdgeDist.Text)
        Data.mWebPlates.mConnectPlateThickness = UIConverter.ConvertToNumeric(txtConnectPlateThickness.Text)

        Data.mWebPlates.mHorHoleCount = UIConverter.ConvertToNumeric(txtHorHoleCount.Text)
        Data.mWebPlates.mVerHoleCount = UIConverter.ConvertToNumeric(txtVerHoleCount.Text)

        Data.mFlangeConnectPlate.mOutsidePlateThickness = UIConverter.ConvertToNumeric(txtFlgConnPlateOutsidePlateThk.Text)
        Data.mFlangeConnectPlate.mInsidePlateThickness = UIConverter.ConvertToNumeric(txtFlgConnPlateInsidePlateThk.Text)
        Data.mFlangeConnectPlate.mHorEdgeDist = UIConverter.ConvertToNumeric(txtHorEdgeDist.Text)
        Data.mFlangeConnectPlate.mHorDist = UIConverter.ConvertToNumeric(txtHorDist.Text)
        Data.mFlangeConnectPlate.mHorCount = UIConverter.ConvertToNumeric(txtHorCount.Text)
        Data.mFlangeConnectPlate.mVerEdgeDist = UIConverter.ConvertToNumeric(txtVerEdgeDist.Text)
        Data.mFlangeConnectPlate.mVerMiddleDist = UIConverter.ConvertToNumeric(txtVerMiddleDist.Text)
        Data.mFlangeConnectPlate.mVerDist = UIConverter.ConvertToNumeric(txtVerDist.Text)
        Data.mFlangeConnectPlate.mVerCount = UIConverter.ConvertToNumeric(txtVerCount.Text)
    End Sub

    Private Sub WriteToDialog(ByRef Data As Parameters)

        txtHorCutBack.Text = UIConverter.ConvertToText(Data.mHorCutback)
        txtHorFlangeCutBack.Text = UIConverter.ConvertToText(Data.mHorWebCutback)
        txtDiagnalCutback.Text = UIConverter.ConvertToText(Data.mDiagnalCutback)

        txtHorGap.Text = UIConverter.ConvertToText(Data.mHorGap)
        txtDiagnalGap.Text = UIConverter.ConvertToText(Data.mDiagnalGap)

        txtHorPlateThickness.Text = UIConverter.ConvertToText(Data.mHorPlateThickness)
        txtHoleDia.Text = UIConverter.ConvertToText(Data.mHoleDia)

        txtHorFillet.Text = UIConverter.ConvertToText(Data.mSidePlate.mHorFillet)
        txtDiagFillet.Text = UIConverter.ConvertToText(Data.mSidePlate.mDiagFillet)
        txtHorAngle.Text = UIConverter.ConvertAngleToText(Data.mSidePlate.mHorAngle)
        txtDiagAngle.Text = UIConverter.ConvertAngleToText(Data.mSidePlate.mDiagAngle)
        txtTopHorDist.Text = UIConverter.ConvertToText(Data.mSidePlate.mHorTopDist)
        txtTopDiagDist.Text = UIConverter.ConvertToText(Data.mSidePlate.mDiagTopDist)
        txtBottomHorDist.Text = UIConverter.ConvertToText(Data.mSidePlate.mHorBottomDist)
        txtBottomDiagDist.Text = UIConverter.ConvertToText(Data.mSidePlate.mDiagBottomDist)
        txtOutsidePlateThickness.Text = UIConverter.ConvertToText(Data.mSidePlate.mOutsidePlateThickness)
        txtInsidePlateThickness.Text = UIConverter.ConvertToText(Data.mSidePlate.mInsidePlateThickness)

        txtChordSideWebPlateThickness.Text = UIConverter.ConvertToText(Data.mWebPlates.mChordSidePlateThickness)
        txtBraceSideWebPlateThickness.Text = UIConverter.ConvertToText(Data.mWebPlates.mBraceSidePlateThickness)
        txtBraceSideWebPlateLength.Text = UIConverter.ConvertToText(Data.mWebPlates.mBraceSidePlateLength)
        txtSupportPlateOffset.Text = UIConverter.ConvertToText(Data.mWebPlates.mSupportPlateOffset)
        txtSupportPlateThickness.Text = UIConverter.ConvertToText(Data.mWebPlates.mSupportPlateThickness)

        txtHoleDiameter.Text = UIConverter.ConvertToText(Data.mWebPlates.mHoleDiameter)
        txtHorHoleDist.Text = UIConverter.ConvertToText(Data.mWebPlates.mHorHoleDist)
        txtHorHoleEdgeDist.Text = UIConverter.ConvertToText(Data.mWebPlates.mHorHoleEdgeDist)
        txtVerHoleDist.Text = UIConverter.ConvertToText(Data.mWebPlates.mVerHoleDist)
        txtVerHoleEdgeDist.Text = UIConverter.ConvertToText(Data.mWebPlates.mVerHoleEdgeDist)
        txtConnectPlateThickness.Text = UIConverter.ConvertAngleToText(Data.mWebPlates.mConnectPlateThickness)

        txtHorHoleCount.Text = UIConverter.ConvertToText(Data.mWebPlates.mHorHoleCount)
        txtVerHoleCount.Text = UIConverter.ConvertToText(Data.mWebPlates.mVerHoleCount)

        txtFlgConnPlateOutsidePlateThk.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mOutsidePlateThickness)
        txtFlgConnPlateInsidePlateThk.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mInsidePlateThickness)
        txtHorEdgeDist.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mHorEdgeDist)
        txtHorDist.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mHorDist)
        txtHorCount.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mHorCount)
        txtVerEdgeDist.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mVerEdgeDist)
        txtVerMiddleDist.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mVerMiddleDist)
        txtVerDist.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mVerDist)
        txtVerCount.Text = UIConverter.ConvertToText(Data.mFlangeConnectPlate.mVerCount)

    End Sub

    Public Sub EditData(ByRef ConnId As Long)
        If ConnId <> 0 Then
            ConnectionId = ConnId
            Dim data As New Parameters
            data.ReadFromConnectionId(ConnId)

            If Not mIsCreatingConn Then
                CancelData.ReadFromConnectionId(ConnectionId)
            End If

            Me.Show(Owner)
            WriteToDialog(data)

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
                Me.Top = Template.Double(0)
                Me.Left = Template.Double(1)
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

        'Select Case Me.TabStrip1.SelectedIndex
        '    Case 0
        '        fileName = "BottomP"
        '    Case 1, 2
        '        fileName = "BoltWeld"
        '    Case 3
        '        fileName = "SideP"
        '    Case 4
        '        fileName = "SideP2"
        '    Case Else
        '        fileName = "All"
        'End Select

        'picBitmap.Image = Nothing

        'If Len(fileName) Then
        '    fileName = UserConnection.GlobalSettings.PluginDataPath & "\" & PLUGIN_IDENTIFIER & "\" & fileName & ".png"
        '    If Len(Dir(fileName)) > 0 Then
        '        picBitmap.Image = System.Drawing.Image.FromFile(fileName)
        '    End If
        'End If
    End Sub


    'Private Sub txt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    'Handles txtPlateThick.Enter

    '    oCheckInput.OldValue = eventSender.Text
    '    mCurrentTextBox = eventSender
    '    NoLine = 0
    '    GreyOptions()
    'End Sub



    'Private Sub txtNonNegative_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    '    eventSender.Text = oCheckInput.CheckNonNegative(eventSender.Text)
    '    If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    'End Sub

    'Private Sub txtAngle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    '    eventSender.Text = oCheckInput.CheckAngular(eventSender.Text)
    '    If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    'End Sub

    'Private Sub txtPositiveInt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    '    eventSender.Text = Math.Abs(Convert.ToInt32(Single.Parse(oCheckInput.CheckNumeric(eventSender.Text, True))))
    '    If oCheckInput.OldValue <> eventSender.Text Then UpdateConnection()
    'End Sub

    Private Sub UpdateConnection(Optional ByRef ForceUpdate As Boolean = False)
        If Not bFormLoadFinished OrElse DisableUpdate Then Return

        Try
            EnableUI()
            If (DisableUpdate = 0 And Not mEnableForceUpdate) Or ForceUpdate Then
                Dim oConnAdapter As ConnectionAdapter = New ConnectionAdapter(ConnectionId)
                If Not oConnAdapter.IsValidConnection Then Return
                oConnAdapter = Nothing

                Dim data As New Parameters
                data.ReadFromConnectionId(ConnectionId)
                ReadFromDialog(data)
                data.WriteToConnectionId(ConnectionId)
                Me.Cursor = Cursors.WaitCursor
                mCallBack.BuildI(ConnectionId)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GreyOptions()
        'If NoLine = 0 Then
        '    cmdGetLengthFromLine.Enabled = True
        'Else
        '    cmdGetLengthFromLine.Enabled = False
        'End If

        'cmdForceUpdate.Visible = mEnableForceUpdate

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        oCheckInput = Nothing
    End Sub

    Private Sub EnableUI()
    End Sub

    Protected Overrides Sub DefWndProc(ByRef m As System.Windows.Forms.Message)
        If (m.Msg = 2) Then 'WM_DESTORY
            Me.Close() 'remove the ConnectionId from the re-entry guard set
        End If
        MyBase.DefWndProc(m)
    End Sub

    Private Sub txtDoubleValue_leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) _
    Handles txtHorPlateThickness.Leave, txtHorGap.Leave, txtHorFlangeCutBack.Leave, txtHorCutBack.Leave, txtDiagFillet.Leave, txtHorFillet.Leave, txtDiagnalCutback.Leave, txtFlgConnPlateInsidePlateThk.Leave, txtVerEdgeDist.Leave, txtFlgConnPlateOutsidePlateThk.Leave, txtHorEdgeDist.Leave, txtHorDist.Leave, txtSupportPlateOffset.Leave, txtSupportPlateThickness.Leave, txtChordSideWebPlateThickness.Leave, txtBraceSideWebPlateThickness.Leave, txtBraceSideWebPlateLength.Leave, txtHorHoleEdgeDist.Leave, txtHorHoleDist.Leave,
        txtDiagnalCutback.Leave, txtHorGap.Leave,
        txtHorCutBack.Leave, txtHorFlangeCutBack.Leave,
        txtHorFillet.Leave, txtDiagFillet.Leave, txtFlgConnPlateInsidePlateThk.Leave,
        txtVerEdgeDist.Leave, txtFlgConnPlateOutsidePlateThk.Leave,
        txtHorEdgeDist.Leave, txtHorDist.Leave,
        txtHorCount.Leave,
        txtSupportPlateOffset.Leave,
        txtSupportPlateThickness.Leave, txtChordSideWebPlateThickness.Leave,
        txtBraceSideWebPlateThickness.Leave, txtBraceSideWebPlateLength.Leave,
        txtHorHoleEdgeDist.Leave, txtHorHoleDist.Leave, txtOutsidePlateThickness.Leave,
        txtInsidePlateThickness.Leave, txtTopHorDist.Leave,
        txtTopDiagDist.Leave, txtVerHoleEdgeDist.Leave, txtVerHoleDist.Leave,
        txtHoleDiameter.Leave, txtConnectPlateThickness.Leave, txtBottomHorDist.Leave, txtBottomDiagDist.Leave, txtVerDist.Leave, txtVerMiddleDist.Leave

        Dim oldValue As String = eventSender.Text
        eventSender.Text = oCheckInput.CheckPositive(eventSender.Text)
        If oldValue <> eventSender.Text Then
            'UpdateConnection()
        End If

    End Sub


    Private Sub txtIntegerValue_leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVerCount.Leave, txtHorCount.Leave, txtVerHoleCount.Leave, txtHorHoleCount.Leave

        Dim oldValue As String = eventSender.Text
        eventSender.Text = oCheckInput.CheckPositiveInteger(eventSender.Text)
        If oldValue <> eventSender.Text Then
            'UpdateConnection()
        End If

    End Sub

    Private Sub txtAngle3_Leave(sender As Object, e As EventArgs) Handles _
        txtDiagAngle.Leave, txtHorAngle.Leave

        Dim oldValue As String = sender.Text
        sender.text = oCheckInput.CheckAngular(sender.text)
        If (oldValue <> sender.text) Then
            'UpdateConnection()
        End If

    End Sub

End Class