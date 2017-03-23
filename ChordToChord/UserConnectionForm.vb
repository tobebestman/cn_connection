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
Public Class UserConnectionForm
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

        'If mBitmapStatus Then
        '    Me.Width = TabStrip1.Width + picBitmap.Width + LAYOUTGAP * 3
        '    cmdBitmaps.Image = imgIcons.Images.Item(0)
        '    ToolTip1.SetToolTip(cmdBitmaps, UserConnection.RSS.RSS("S1009"))
        'Else
        '    Me.Width = TabStrip1.Width + LAYOUTGAP * 2
        '    cmdBitmaps.Image = imgIcons.Images.Item(2)
        '    ToolTip1.SetToolTip(cmdBitmaps, UserConnection.RSS.RSS("S1008"))
        'End If
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
            Dim oConnAdpt As New ConnectionAdapter(ConnectionId)
            Dim data As New Parameters

            data.ReadFromConnectionId(ConnectionId)
            oConnAdpt.ReadAddtionalObjects()

            mCallBack.CleanI(ConnectionId, False)

            CancelData.WriteToConnectionId(ConnectionId)
            oConnAdpt.CommitAppendObjects()

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
    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
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

        Data.mFlange1TopThk = UIConverter.ConvertToNumeric(txtFlange1TopThk.Text)
        Data.mFlange2TopThk = UIConverter.ConvertToNumeric(txtFlange2TopThk.Text)
        Data.mFlange1BottomThk = UIConverter.ConvertToNumeric(txtFlange1BottomThk.Text)
        Data.mFlange2BottomThk = UIConverter.ConvertToNumeric(txtFlange2BottomThk.Text)
        Data.mWeb2Thk = UIConverter.ConvertToNumeric(txtWeb2Thk.Text)
        Data.mHoleDia = UIConverter.ConvertToNumeric(txtHoleDia.Text)
        Data.mChordInnerHigh = UIConverter.ConvertToNumeric(txtChordInnerHigh.Text)

        'Top connection plates parameters
        Data.mTopConnectPlateParameters.outterPlateThickness = UIConverter.ConvertToNumeric(txtTopOutterPLThk.Text)
        Data.mTopConnectPlateParameters.innerPlateThickness = UIConverter.ConvertToNumeric(txtTopInnerPLThk.Text)
        Data.mTopConnectPlateParameters.HoleGrop.upperEdgeDistance = UIConverter.ConvertToNumeric(txtTopUpperEdgeDist.Text)
        Data.mTopConnectPlateParameters.HoleGrop.lowerEdgeDistance = UIConverter.ConvertToNumeric(txtTopLowerEdgeDist.Text)
        Data.mTopConnectPlateParameters.radius = UIConverter.ConvertToNumeric(txtTopSlotRadius.Text)
        Data.mTopConnectPlateParameters.centerDistance = UIConverter.ConvertToNumeric(txtTopSlotStraightlengh.Text)

        Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Clear()
        For i As Integer = 0 To Me.DataGridViewTopPlate.RowCount - 1
            Try
                Dim edgeDist As String = DataGridViewTopPlate.Rows(i).Cells(0).Value
                Dim YDesc As String = DataGridViewTopPlate.Rows(i).Cells(1).Value
                Dim GroupId As String = DataGridViewTopPlate.Rows(i).Cells(2).Value

                If edgeDist Is Nothing Or YDesc Is Nothing Then
                    Continue For
                End If

                Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.
                Add(New HoleLineDefinition(Integer.Parse(edgeDist), YDesc, Integer.Parse(GroupId)))
            Catch ex As Exception
                Debug.Assert(False)
                Continue For
            End Try
        Next

        'Bottom connection plates parameters
        Data.mBottomConnectPlateParameters.outterPlateThickness = UIConverter.ConvertToNumeric(txtBottomOutterPLThickness.Text)
        Data.mBottomConnectPlateParameters.innerPlateThickness = UIConverter.ConvertToNumeric(txtBottomInnerPLThickness.Text)
        Data.mBottomConnectPlateParameters.HoleGrop.upperEdgeDistance = UIConverter.ConvertToNumeric(txtBottomPlateUpperEdgeDist.Text)
        Data.mBottomConnectPlateParameters.HoleGrop.lowerEdgeDistance = UIConverter.ConvertToNumeric(txtBottomPlateLowerEdgeDist.Text)
        Data.mBottomConnectPlateParameters.radius = UIConverter.ConvertToNumeric(txtBottomSlotRadius.Text)
        Data.mBottomConnectPlateParameters.centerDistance = UIConverter.ConvertToNumeric(txtBottomSlotStraightlengh.Text)

        Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Clear()
        For i As Integer = 0 To Me.DataGridViewBottomPlate.RowCount - 1
            Try
                Dim edgeDist As String = DataGridViewBottomPlate.Rows(i).Cells(0).Value
                Dim YDesc As String = DataGridViewBottomPlate.Rows(i).Cells(1).Value
                Dim GroupId As String = DataGridViewBottomPlate.Rows(i).Cells(2).Value

                If edgeDist Is Nothing Or YDesc Is Nothing Then
                    Continue For
                End If

                Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.
                Add(New HoleLineDefinition(Integer.Parse(edgeDist), YDesc, Integer.Parse(GroupId)))
            Catch ex As Exception
                Debug.Assert(False)
                Continue For
            End Try
        Next

        'Web connection plates parameters
        Data.mWebConnectPlateParameters.outterPlateThickness = UIConverter.ConvertToNumeric(txtWebOutterPLThk.Text)
        Data.mWebConnectPlateParameters.innerPlateThickness = UIConverter.ConvertToNumeric(txtWebInnerPLThk.Text)
        Data.mWebConnectPlateParameters.HoleGrop.upperEdgeDistance = UIConverter.ConvertToNumeric(txtWebUpperEdgeDist.Text)
        Data.mWebConnectPlateParameters.HoleGrop.lowerEdgeDistance = UIConverter.ConvertToNumeric(txtWebLowerEdgeDist.Text)

        Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Clear()
        For i As Integer = 0 To Me.DataGridViewWebPlate.RowCount - 1
            Try
                Dim edgeDist As String = DataGridViewWebPlate.Rows(i).Cells(0).Value
                Dim YDesc As String = DataGridViewWebPlate.Rows(i).Cells(1).Value
                Dim GroupId As String = DataGridViewWebPlate.Rows(i).Cells(2).Value

                If edgeDist Is Nothing Or YDesc Is Nothing Then
                    Continue For
                End If

                Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.
                Add(New HoleLineDefinition(Integer.Parse(edgeDist), YDesc, Integer.Parse(GroupId)))
            Catch ex As Exception
                Debug.Assert(False)
                Continue For
            End Try
        Next
    End Sub

    Private Sub WriteToDialog(ByRef Data As Parameters)

        txtFlange1TopThk.Text = UIConverter.ConvertToText(Data.mFlange1TopThk)
        txtFlange2TopThk.Text = UIConverter.ConvertToText(Data.mFlange2TopThk)
        txtFlange1BottomThk.Text = UIConverter.ConvertToText(Data.mFlange1BottomThk)
        txtFlange2BottomThk.Text = UIConverter.ConvertToText(Data.mFlange2BottomThk)
        txtWeb2Thk.Text = UIConverter.ConvertToText(Data.mWeb2Thk)
        txtHoleDia.Text = UIConverter.ConvertToText(Data.mHoleDia)
        txtChordInnerHigh.Text = UIConverter.ConvertToText(Data.mChordInnerHigh)

        'Top connection plates parameters
        txtTopOutterPLThk.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.outterPlateThickness)
        txtTopInnerPLThk.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.innerPlateThickness)
        txtTopUpperEdgeDist.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.HoleGrop.upperEdgeDistance)
        txtTopLowerEdgeDist.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.HoleGrop.lowerEdgeDistance)
        txtTopSlotRadius.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.radius)
        txtTopSlotStraightlengh.Text = UIConverter.ConvertToText(Data.mTopConnectPlateParameters.centerDistance)

        For i As Integer = 0 To Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Count - 1
            DataGridViewTopPlate.Rows.Add(Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).horDistance.ToString(),
                                           Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).YDesc,
                                           Data.mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).groupId.ToString())
        Next

        'Bottom connection plates parameters
        txtBottomOutterPLThickness.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.outterPlateThickness)
        txtBottomInnerPLThickness.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.innerPlateThickness)
        txtBottomPlateUpperEdgeDist.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.HoleGrop.upperEdgeDistance)
        txtBottomPlateLowerEdgeDist.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.HoleGrop.lowerEdgeDistance)
        txtBottomSlotRadius.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.radius)
        txtBottomSlotStraightlengh.Text = UIConverter.ConvertToText(Data.mBottomConnectPlateParameters.centerDistance)

        For i As Integer = 0 To Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Count - 1
            DataGridViewBottomPlate.Rows.Add(Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).horDistance.ToString(),
                                           Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).YDesc,
                                           Data.mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).groupId.ToString())
        Next

        'Web connection plates parameters
        txtWebOutterPLThk.Text = UIConverter.ConvertToText(Data.mWebConnectPlateParameters.outterPlateThickness)
        txtWebInnerPLThk.Text = UIConverter.ConvertToText(Data.mWebConnectPlateParameters.innerPlateThickness)
        txtWebUpperEdgeDist.Text = UIConverter.ConvertToText(Data.mWebConnectPlateParameters.HoleGrop.upperEdgeDistance)
        txtWebLowerEdgeDist.Text = UIConverter.ConvertToText(Data.mWebConnectPlateParameters.HoleGrop.lowerEdgeDistance)

        For i As Integer = 0 To Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Count - 1
            DataGridViewWebPlate.Rows.Add(Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).horDistance.ToString(),
                                           Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).YDesc,
                                           Data.mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions(i).groupId.ToString())
        Next

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
            'GreyOptions()
        End If
    End Sub
    Private Sub FormsInitialize()
        DisableUpdate = True
        mEnableForceUpdate = Not UserConnection.GlobalSettings.DynamicConnections
        NoLine = 1
        oCheckInput = New CheckInput()
        CancelData = New Parameters
        EnableUI()
        'TabStrip1_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub EnableUI()
    End Sub
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
    Private Sub UserConnectionForm_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UserConnection.mDlgShownIds.Remove(Me.ConnectionId)
        System.Windows.Forms.SendKeys.SendWait("{ESC}")
        CancelData = Nothing
    End Sub
End Class