Option Strict Off
Option Explicit On

Imports System
Imports System.Collections.Specialized

Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

Imports PlugInBase

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
Imports Bentley.ProStructures.Modeling

Imports PlugInBase.PlugInCommon
Imports PlugInBase.PlugInCommon.CommonFunctions
Imports System.Windows.Forms

Public Structure Assignments
    Dim Material As Integer
    Dim DetailStyle As String
    Dim DisplayClass As Integer
    Dim AreaClass As Integer
    Dim PartFamily As Integer
    Dim Description As Integer
    Dim Level As String
    Dim ItemNumber As String
End Structure

Public Class UserConnection
    Public Shared mDlgShownIds As New List(Of Long)
    Private Base As PlugInBase.KsPlugInBase

    Friend Shared MathTool As New PsGeometryFunctions
    Friend Shared GlobalSettings As New PsGlobalSettings
    Friend Shared RSS As New RSSReader(PLUGIN_IDENTIFIER)

    Private IsCreatingConn As Boolean

    Public Sub New()
        MyBase.New()
        Base = New PlugInBase.KsPlugInBase

        IsCreatingConn = False
    End Sub

    Public Sub Build(ByRef Handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As Long
        Id = oTool.HandleToId(Handle)
        CleanI(Id, False)
        BuildI(Id)
    End Sub
    Public Sub Edit(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As Long
        Id = oTool.HandleToId(handle)
        EditI(Id)
    End Sub
    Public Sub Clean(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As Long
        Id = oTool.HandleToId(handle)
        CleanI(Id)
    End Sub
    Public Sub Draw(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As Long
        Id = oTool.HandleToId(handle)
        DrawI(Id)
    End Sub
    Public Sub BuildI(ByVal ConnectionId As Long)

        If ConnectionId = 0 Then
            Return
        End If

        Try
            Dim oConnAdpt As New ConnectionAdapter(ConnectionId)
            Dim data As New Parameters
            data.ReadFromConnectionId(ConnectionId)

            oConnAdpt.ReadAddtionalObjects()
            oConnAdpt.ReadCreatedObjectArray()
            'oConnAdpt.ReadData()
            'oConnAdpt.ReadSecondObjects()
            Dim chordId1 As Long = oConnAdpt.AdditionalObject(0)
            Dim chordId2 As Long = oConnAdpt.AdditionalObject(1)
            Dim PlateID1 As Long = oConnAdpt.AdditionalObject(2)
            Dim PlateID2 As Long = oConnAdpt.AdditionalObject(3)

            If (chordId1 <= 0 Or chordId2 <= 0 Or
                    PlateID1 <= 0 Or PlateID2 <= 0) Then
                Debug.Assert(False)
                Return
            End If
            'execute creation
            If oConnAdpt.IsBuilt Then
                CleanI(ConnectionId, False)
            End If

            Dim instPt As PsPoint = New PsPoint
            Dim connUcs As PsMatrix = New PsMatrix
            Dim TempUcs As PsMatrix = New PsMatrix

            If GetIntersectPtAndUcsByTwoParallelMembers(chordId1, chordId2, instPt, connUcs, 2) = False Then
                Return
            End If
            TempUcs.CopyFrom(connUcs)
            OriPtTranslation(connUcs, 0, 0, data.mChordInnerHigh / 2 + data.mFlange1TopThk, 1, -1, 1)
            Dim TopPlatesCtreator As New OutterInnerPlatesCreator(chordId1, chordId2, data.mTopConnectPlateParameters, data.mFlange1TopThk, data.mFlange2TopThk, connUcs)
            TopPlatesCtreator.Create()

            connUcs.CopyFrom(TempUcs)
            OriPtTranslation(connUcs, 0, 0, -data.mChordInnerHigh / 2 - data.mFlange1BottomThk, 1, 1, 1)
            Dim BottomPlatesCtreator As New OutterInnerPlatesCreator(chordId1, chordId2, data.mBottomConnectPlateParameters, data.mFlange1BottomThk, data.mFlange2BottomThk, connUcs)
            BottomPlatesCtreator.Create()

            If GetIntersectPtAndUcsByTwoParallelMembers(chordId1, chordId2, instPt, connUcs, 3) = False Then
                Return
            End If
            TempUcs.CopyFrom(connUcs)
            Dim oTrans As New PsTransaction
            Dim oPlate As PsPlate = Nothing
            If oTrans.GetObject(PlateID1, PsOpenMode.kForRead, oPlate) = False Then
                Return
            End If
            OriPtTranslation(connUcs, 0, 0, -data.mChordInnerHigh / 2 - oPlate.Height, 1, -1, 1)
            Dim WebLeftPlatesCtreator As New OutterInnerPlatesCreator(chordId1, chordId2, data.mWebConnectPlateParameters, oPlate.Height, data.mWeb2Thk, connUcs)
            WebLeftPlatesCtreator.Create()

            If GetIntersectPtAndUcsByTwoParallelMembers(chordId1, chordId2, instPt, connUcs, 3) = False Then
                Return
            End If
            TempUcs.CopyFrom(connUcs)
            If oTrans.GetObject(PlateID2, PsOpenMode.kForRead, oPlate) = False Then
                Return
            End If
            OriPtTranslation(connUcs, 0, 0, data.mChordInnerHigh / 2 + oPlate.Height, 1, 1, 1)
            Dim WebRightPlatesCtreator As New OutterInnerPlatesCreator(chordId1, chordId2, data.mWebConnectPlateParameters, oPlate.Height, data.mWeb2Thk, connUcs)
            WebRightPlatesCtreator.Create()

            If TopPlatesCtreator.Plates.drillModifyIds.Count > 0 Then
                data.mTopSlotCutIndex = IIf(TopPlatesCtreator.Plates.drillModifyIds(0) <> -1,
                                             TopPlatesCtreator.Plates.drillModifyIds(0), -1)
            End If
            If BottomPlatesCtreator.Plates.drillModifyIds.Count > 0 Then
                data.mBottomSlotCutIndex = IIf(BottomPlatesCtreator.Plates.drillModifyIds(0) <> -1,
                                             BottomPlatesCtreator.Plates.drillModifyIds(0), -1)
            End If
            oConnAdpt = Nothing

            oConnAdpt = New ConnectionAdapter(ConnectionId)

            oConnAdpt.AppendAdditionalObjectId(chordId1)
            oConnAdpt.AppendAdditionalObjectId(chordId2)
            oConnAdpt.AppendAdditionalObjectId(PlateID1)
            oConnAdpt.AppendAdditionalObjectId(PlateID2)

            For Each id As Long In TopPlatesCtreator.Plates.innertPlateIds
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In BottomPlatesCtreator.Plates.innertPlateIds
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In WebLeftPlatesCtreator.Plates.innertPlateIds
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In WebRightPlatesCtreator.Plates.innertPlateIds
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            oConnAdpt.AppendCreatedObjectId(TopPlatesCtreator.Plates.accessoryPlateId)
            oConnAdpt.AppendCreatedObjectId(BottomPlatesCtreator.Plates.accessoryPlateId)
            oConnAdpt.AppendCreatedObjectId(WebLeftPlatesCtreator.Plates.accessoryPlateId)
            oConnAdpt.AppendCreatedObjectId(WebRightPlatesCtreator.Plates.accessoryPlateId)

            oConnAdpt.AppendSecondActiveObjectId(TopPlatesCtreator.Plates.outterPlateId)
            oConnAdpt.AppendSecondActiveObjectId(BottomPlatesCtreator.Plates.outterPlateId)
            oConnAdpt.AppendSecondActiveObjectId(WebLeftPlatesCtreator.Plates.outterPlateId)
            oConnAdpt.AppendSecondActiveObjectId(WebRightPlatesCtreator.Plates.outterPlateId)
            oConnAdpt.SetBuilt(True)
            oConnAdpt.CommitAppendObjects()

            data.WriteToConnectionId(ConnectionId)

            Dim Display As New PsDisplayClassManager
            Display.RefreshScreen()
            Display.Close()

            oConnAdpt = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub EditI(ByVal IntId As Long)
        Try
            If Not mDlgShownIds.Contains(IntId) Then
                mDlgShownIds.Add(IntId)
                Dim Dialog As New UserConnectionForm

                Dialog.TopMost = False
                Dialog.mCallBack = Me
                Dialog.mIsCreatingConn = IsCreatingConn
                Dialog.EditData(IntId)
                Dialog.Show()
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DrawI(ByVal ConnectionId As Long)

    End Sub
    Public Sub CleanI(ByVal ConnectionId As Long, Optional ByVal EraseConn As Boolean = True)
        If ConnectionId <> 0 Then

            Dim oTrans As New PsTransaction
            Dim oConnection As PsConnection = Nothing
            Dim oEdit As New PsEditModification

            Try
                oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, oConnection)
                If oConnection IsNot Nothing Then

                    oConnection = RemoveModifications(oConnection)

                    oConnection.RemoveAllAdditionalEntity(False)

                    oConnection.RemoveAllSecondActiveEntity(True)

                    oConnection.RemoveAllCreatedEntity(True)

                    If EraseConn Then
                        oConnection.Erase()
                    End If
                End If
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            Finally
                oTrans.Close()
                oEdit = Nothing
            End Try
        End If
    End Sub
    Private Shared Function RemoveModifications(oConnection As PsConnection) As PsConnection
        Dim param As New Parameters
        param.ReadFromConnection(oConnection)

        Dim Chord1 As Long = oConnection.AdditionalObjectId(0)
        Dim Chord2 As Long = oConnection.AdditionalObjectId(1)

        Dim oModify As New PsEditModification

        If (param.mTopSlotCutIndex <> -1) Then
            oModify.SetObjectId(Chord1)
            oModify.DeleteSubBody(param.mTopSlotCutIndex)
        End If

        If (param.mBottomSlotCutIndex <> -1) Then
            oModify.SetObjectId(Chord2)
            oModify.DeleteSubBody(param.mBottomSlotCutIndex)
        End If

        Return oConnection
    End Function
    Public Function Create() As Long
        Dim ConnectionId As Long

        IsCreatingConn = True

        Try
            ConnectionId = InitialCall()

            If ConnectionId <> 0 Then
                BuildI(ConnectionId)
                EditI(ConnectionId)
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        IsCreatingConn = False

        Return ConnectionId
    End Function

    ' Private sub-routines and functions

    Private Function InitialCall() As Long
        Dim ConnectionId As Long

        Dim ConnectionHandle As String = ""

        Dim Message As String = ""
        Dim Selection As New PsSelection

        Dim SupportingShape1 As Long
        Do
            SupportingShape1 = Selection.PickObject(RSS.RSS("M0000"))
            If SupportingShape1 <= 0 Then Return 0
        Loop Until (IsWeldShape(SupportingShape1))

        Dim SupportingShape2 As Long
        Do
            SupportingShape2 = Selection.PickObject(RSS.RSS("M0001"))
            If SupportingShape2 <= 0 Then Return 0
        Loop Until (IsWeldShape(SupportingShape2))

        Dim Plate1 As Long
        Do
            Plate1 = Selection.PickObject(RSS.RSS("M0002"))
            If Plate1 <= 0 Then Return 0
        Loop Until (IsPlate(Plate1))

        Dim Plate2 As Long
        Do
            Plate2 = Selection.PickObject(RSS.RSS("M0003"))
            If Plate2 <= 0 Then Return 0
        Loop Until (IsPlate(Plate2))

        Dim oCreateConnection As New PsCreateConnection

        IsCreatingConn = True

        oCreateConnection.SetIdentifier(PLUGIN_IDENTIFIER)
        oCreateConnection.SetDescription(PLUGIN_DESCRIPTION)
        If (oCreateConnection.Create()) Then
            ConnectionId = oCreateConnection.ObjectId
        End If

        Dim connAdpt As New ConnectionAdapter(ConnectionId)
        connAdpt.SetBuilt(False)
        connAdpt.AppendAdditionalObjectId(SupportingShape1)
        connAdpt.AppendAdditionalObjectId(SupportingShape2)
        connAdpt.AppendAdditionalObjectId(Plate1)
        connAdpt.AppendAdditionalObjectId(Plate2)
        connAdpt.CommitAppendObjects()

        Dim data As New Parameters
        data.SetToDefaults()

        Dim sFileName As String = GetTemplateFileName(PLUGIN_IDENTIFIER)
        If File.Exists(sFileName) Then
            Dim oTemplateMgr As New PsTemplateManager
            oTemplateMgr.LoadTemplateEntry(PLUGIN_IDENTIFIER)
            data.ReadFromTemplate(oTemplateMgr)
            oTemplateMgr = Nothing
        End If
        data.WriteToConnectionId(ConnectionId)

        Selection = Nothing
        oCreateConnection = Nothing
        Return ConnectionId
    End Function

    Private Sub CreateGroup(ByVal createdObjects As Collection)
        Dim oGroup As PsObjectGroup

        Try
            oGroup = New PsObjectGroup
            oGroup.setMainPart(Convert.ToInt32(createdObjects.Item(1)))
            For i As Integer = 2 To createdObjects.Count
                oGroup.AddSubPart(Convert.ToInt32(createdObjects.Item(i)))
            Next i
            oGroup.Create()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        oGroup = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        Base = Nothing
        MyBase.Finalize()
    End Sub
End Class