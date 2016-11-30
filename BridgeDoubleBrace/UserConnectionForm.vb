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

        Data.mPlateThickness = UIConverter.ConvertToNumeric(txtPlateThickness.Text)

        Data.mSupport1CutBack = UIConverter.ConvertToNumeric(txtSupport1CutBack.Text)
        Data.mSupport2CutBack = UIConverter.ConvertToNumeric(txtSupport2CutBack.Text)

        Data.mConnect1CutBack = UIConverter.ConvertToNumeric(txtConnectCutBack1.Text)
        Data.mConnect2CutBack = UIConverter.ConvertToNumeric(txtConnectCutBack2.Text)

        Data.mBottomAngle1 = UIConverter.ConvertAngleToNumeric(txtAngle1.Text)
        Data.mBottomAngle2 = UIConverter.ConvertAngleToNumeric(txtAngle2.Text)
        Data.mBottomAngle3 = UIConverter.ConvertAngleToNumeric(txtAngle3.Text)
        Data.mBottomAngle4 = UIConverter.ConvertAngleToNumeric(txtAngle4.Text)

        Data.mBottomFillet1 = UIConverter.ConvertToNumeric(txtFillet1.Text)
        Data.mBottomFillet2 = UIConverter.ConvertToNumeric(txtFillet2.Text)

        Data.mMainChordPlateThickness = UIConverter.ConvertToNumeric(txtMainChordPlateThickness.Text)

        Data.mConnectPlate1.sideDistance = UIConverter.ConvertToNumeric(txtConnect1SideDistance.Text)
        Data.mConnectPlate1.radius = UIConverter.ConvertToNumeric(txtConnect1Radius.Text)
        Data.mConnectPlate1.gap = UIConverter.ConvertToNumeric(txtConnect1Gap.Text)
        Data.mConnectPlate1.length = UIConverter.ConvertToNumeric(txtConnect1Length.Text)
        Data.mConnectPlate1.width = UIConverter.ConvertToNumeric(txtConnect1Width.Text)
        Data.mConnectPlate1.thickness = UIConverter.ConvertToNumeric(txtConnect1Thickness.Text)
        Data.mConnectPlate1.angle = UIConverter.ConvertAngleToNumeric(txtConnect1Angle.Text)
        Data.mConnectPlate1.innerWebHeight = UIConverter.ConvertToNumeric(txtConnect1InnerWebHeight.Text)
        Data.mConnectPlate1.innerWebThickness = UIConverter.ConvertToNumeric(txtConnect1innerWebThickness.Text)
        Data.mConnectPlate1.innerWebCount = UIConverter.ConvertToNumeric(txtConnect1innerWebCount.Text)
        Data.mConnectPlate1.innerWebDist = UIConverter.ConvertToNumeric(txtConnect1innerWebDist.Text)

        Data.mConnectPlate2.sideDistance = UIConverter.ConvertToNumeric(txtConnect2SideDistance.Text)
        Data.mConnectPlate2.radius = UIConverter.ConvertToNumeric(txtConnect2Radius.Text)
        Data.mConnectPlate2.gap = UIConverter.ConvertToNumeric(txtConnect2Gap.Text)
        Data.mConnectPlate2.length = UIConverter.ConvertToNumeric(txtConnect2Length.Text)
        Data.mConnectPlate2.width = UIConverter.ConvertToNumeric(txtConnect2Width.Text)
        Data.mConnectPlate2.thickness = UIConverter.ConvertToNumeric(txtConnect2Thickness.Text)
        Data.mConnectPlate2.angle = UIConverter.ConvertAngleToNumeric(txtConnect2Angle.Text)
        Data.mConnectPlate2.innerWebHeight = UIConverter.ConvertToNumeric(txtConnect2InnerWebHeight.Text)
        Data.mConnectPlate2.innerWebThickness = UIConverter.ConvertToNumeric(txtConnect2innerWebThickness.Text)
        Data.mConnectPlate2.innerWebCount = UIConverter.ConvertToNumeric(txtConnect2innerWebCount.Text)
        Data.mConnectPlate2.innerWebDist = UIConverter.ConvertToNumeric(txtConnect2innerWebDist.Text)

        Data.mSideConnectPlate1.webThickness = UIConverter.ConvertToNumeric(txtConnect1WebThickness.Text)
        Data.mSideConnectPlate1.horSideDistance = UIConverter.ConvertToNumeric(txtHorSideDist1.Text)
        Data.mSideConnectPlate1.horDistance = UIConverter.ConvertToNumeric(txtHorDist1.Text)
        Data.mSideConnectPlate1.horHoleCount = UIConverter.ConvertToNumeric(txtHorHoleCount1.Text)
        Data.mSideConnectPlate1.verSideDistance = UIConverter.ConvertToNumeric(txtVerSideDist1.Text)
        Data.mSideConnectPlate1.verDistance = UIConverter.ConvertToNumeric(txtVerDist1.Text)
        Data.mSideConnectPlate1.verHoleCount = UIConverter.ConvertToNumeric(txtVerHoleCount1.Text)
        Data.mSideConnectPlate1.outSidePlateThickness = UIConverter.ConvertToNumeric(txtOutsidePlThickness1.Text)
        Data.mSideConnectPlate1.insidePlateThickness = UIConverter.ConvertToNumeric(txtInsidePlThickness1.Text)

        Data.mSideConnectPlate2.webThickness = UIConverter.ConvertToNumeric(txtConnect2WebThickness.Text)
        Data.mSideConnectPlate2.horSideDistance = UIConverter.ConvertToNumeric(txtHorSideDist2.Text)
        Data.mSideConnectPlate2.horDistance = UIConverter.ConvertToNumeric(txtHorDist2.Text)
        Data.mSideConnectPlate2.horHoleCount = UIConverter.ConvertToNumeric(txtHorHoleCount2.Text)
        Data.mSideConnectPlate2.verSideDistance = UIConverter.ConvertToNumeric(txtVerSideDist2.Text)
        Data.mSideConnectPlate2.verDistance = UIConverter.ConvertToNumeric(txtVerDist2.Text)
        Data.mSideConnectPlate2.verHoleCount = UIConverter.ConvertToNumeric(txtVerHoleCount2.Text)
        Data.mSideConnectPlate2.outSidePlateThickness = UIConverter.ConvertToNumeric(txtOutsidePlThickness2.Text)
        Data.mSideConnectPlate2.insidePlateThickness = UIConverter.ConvertToNumeric(txtInsidePlThickness2.Text)
    End Sub

    Private Sub WriteToDialog(ByRef Data As Parameters)

        txtPlateThickness.Text = UIConverter.ConvertToText(Data.mPlateThickness)

        txtSupport1CutBack.Text = UIConverter.ConvertToText(Data.mSupport1CutBack)
        txtSupport2CutBack.Text = UIConverter.ConvertToText(Data.mSupport2CutBack)

        txtConnectCutBack1.Text = UIConverter.ConvertToText(Data.mConnect1CutBack)
        txtConnectCutBack2.Text = UIConverter.ConvertToText(Data.mConnect2CutBack)

        txtAngle1.Text = UIConverter.ConvertAngleToText(Data.mBottomAngle1)
        txtAngle2.Text = UIConverter.ConvertAngleToText(Data.mBottomAngle2)
        txtAngle3.Text = UIConverter.ConvertAngleToText(Data.mBottomAngle3)
        txtAngle4.Text = UIConverter.ConvertAngleToText(Data.mBottomAngle4)

        txtFillet1.Text = UIConverter.ConvertToText(Data.mBottomFillet1)
        txtFillet2.Text = UIConverter.ConvertToText(Data.mBottomFillet2)

        txtMainChordPlateThickness.Text = UIConverter.ConvertToText(Data.mMainChordPlateThickness)

        txtConnect1SideDistance.Text = UIConverter.ConvertToText(Data.mConnectPlate1.sideDistance)
        txtConnect1Radius.Text = UIConverter.ConvertToText(Data.mConnectPlate1.radius)
        txtConnect1Gap.Text = UIConverter.ConvertToText(Data.mConnectPlate1.gap)
        txtConnect1Length.Text = UIConverter.ConvertToText(Data.mConnectPlate1.length)
        txtConnect1Width.Text = UIConverter.ConvertToText(Data.mConnectPlate1.width)
        txtConnect1Thickness.Text = UIConverter.ConvertToText(Data.mConnectPlate1.thickness)
        txtConnect1Angle.Text = UIConverter.ConvertAngleToText(Data.mConnectPlate1.angle)
        txtConnect1InnerWebHeight.Text = UIConverter.ConvertToText(Data.mConnectPlate1.innerWebHeight)
        txtConnect1innerWebThickness.Text = UIConverter.ConvertToText(Data.mConnectPlate1.innerWebThickness)
        txtConnect1innerWebCount.Text = UIConverter.ConvertToText(Data.mConnectPlate1.innerWebCount)
        txtConnect1innerWebDist.Text = UIConverter.ConvertToText(Data.mConnectPlate1.innerWebDist)

        txtConnect2SideDistance.Text = UIConverter.ConvertToText(Data.mConnectPlate2.sideDistance)
        txtConnect2Radius.Text = UIConverter.ConvertToText(Data.mConnectPlate2.radius)
        txtConnect2Gap.Text = UIConverter.ConvertToText(Data.mConnectPlate2.gap)
        txtConnect2Length.Text = UIConverter.ConvertToText(Data.mConnectPlate2.length)
        txtConnect2Width.Text = UIConverter.ConvertToText(Data.mConnectPlate2.width)
        txtConnect2Thickness.Text = UIConverter.ConvertToText(Data.mConnectPlate2.thickness)
        txtConnect2Angle.Text = UIConverter.ConvertAngleToText(Data.mConnectPlate2.angle)
        txtConnect2InnerWebHeight.Text = UIConverter.ConvertToText(Data.mConnectPlate2.innerWebHeight)
        txtConnect2innerWebThickness.Text = UIConverter.ConvertToText(Data.mConnectPlate2.innerWebThickness)
        txtConnect2innerWebCount.Text = UIConverter.ConvertToText(Data.mConnectPlate2.innerWebCount)
        txtConnect2innerWebDist.Text = UIConverter.ConvertToText(Data.mConnectPlate2.innerWebDist)

        txtConnect1WebThickness.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.webThickness)
        txtHorSideDist1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.horSideDistance)
        txtHorDist1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.horDistance)
        txtHorHoleCount1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.horHoleCount)
        txtVerSideDist1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.verSideDistance)
        txtVerDist1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.verDistance)
        txtVerHoleCount1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.verHoleCount)
        txtOutsidePlThickness1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.outSidePlateThickness)
        txtInsidePlThickness1.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate1.insidePlateThickness)

        txtConnect2WebThickness.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.webThickness)
        txtHorSideDist2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.horSideDistance)
        txtHorDist2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.horDistance)
        txtHorHoleCount2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.horHoleCount)
        txtVerSideDist2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.verSideDistance)
        txtVerDist2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.verDistance)
        txtVerHoleCount2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.verHoleCount)
        txtOutsidePlThickness2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.outSidePlateThickness)
        txtInsidePlThickness2.Text = UIConverter.ConvertToNumeric(Data.mSideConnectPlate2.insidePlateThickness)

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
                ReadFromDialog(data)
                data.WriteToConnectionId(ConnectionId)

                mCallBack.BuildI(ConnectionId)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Handles txtPlateThickness.Leave,
            txtConnectCutBack1.Leave, txtConnectCutBack2.Leave,
            txtSupport1CutBack.Leave, txtSupport2CutBack.Leave,
            txtFillet1.Leave, txtFillet2.Leave, txtConnect2Width.Leave, txtConnect2Thickness.Leave, txtConnect2SideDistance.Leave, txtConnect2Radius.Leave, txtConnect2Length.Leave, txtConnect2innerWebThickness.Leave, txtConnect2InnerWebHeight.Leave, txtConnect2innerWebDist.Leave, txtConnect1Width.Leave, txtConnect1Thickness.Leave, txtConnect1SideDistance.Leave, txtConnect1Radius.Leave, txtConnect1Length.Leave, txtConnect1innerWebThickness.Leave, txtConnect1InnerWebHeight.Leave, txtConnect1innerWebDist.Leave, TabPageConnPlate2.Leave,
            txtVerSideDist1.Leave, txtVerDist1.Leave, txtMainChordPlateThickness.Leave,
            txtHorSideDist1.Leave, txtHorDist1.Leave, txtConnect2WebThickness.Leave, txtConnect2Gap.Leave, txtConnect1WebThickness.Leave, txtConnect1Gap.Leave, txtOutsidePlThickness2.Leave, txtOutsidePlThickness1.Leave, txtInsidePlThickness2.Leave, txtInsidePlThickness1.Leave

        Dim oldValue As String = eventSender.Text
        eventSender.Text = oCheckInput.CheckPositive(eventSender.Text)
        If oldValue <> eventSender.Text Then
            UpdateConnection()
        End If

    End Sub


    Private Sub txtIntegerValue_leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVerHoleCount1.Leave, txtHorHoleCount1.Leave, txtConnect2innerWebCount.Leave, txtConnect1innerWebCount.Leave

        Dim oldValue As String = eventSender.Text
        eventSender.Text = oCheckInput.CheckPositiveInteger(eventSender.Text)
        If oldValue <> eventSender.Text Then
            UpdateConnection()
        End If

    End Sub

    Private Sub txtAngle3_Leave(sender As Object, e As EventArgs) Handles _
        txtAngle4.Leave, txtAngle3.Leave, txtAngle2.Leave, txtAngle1.Leave, txtConnect2Angle.Leave, txtConnect1Angle.Leave

        Dim oldValue As String = sender.Text
        sender.text = oCheckInput.CheckAngular(sender.text)
        If (oldValue <> sender.text) Then
            UpdateConnection()
        End If

    End Sub

End Class