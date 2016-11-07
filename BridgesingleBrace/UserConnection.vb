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
    Friend Shared Data As New Parameters
    Friend Shared RSS As New RSSReader(PLUGIN_IDENTIFIER)

    Friend Shared TheExchange As ExchangeClass

    Private IsCreatingConn As Boolean


    Public Sub New()
        MyBase.New()
        Base = New PlugInBase.KsPlugInBase

        IsCreatingConn = False
    End Sub


    Public Sub Build(ByRef Handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As IntPtr
        Id = oTool.HandleToId(Handle)
        CleanI(Id, False)
        BuildI(Id)
    End Sub
    Public Sub Edit(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As IntPtr
        Id = oTool.HandleToId(handle)
        EditI(Id)
    End Sub
    Public Sub Clean(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As IntPtr
        Id = oTool.HandleToId(handle)
        CleanI(Id)
    End Sub
    Public Sub Draw(ByRef handle As String)
        Dim oTool As New PsMiscTools
        Dim Id As IntPtr
        Id = oTool.HandleToId(handle)
        DrawI(Id)
    End Sub

    Public Sub BuildI(ByVal ConnectionId As IntPtr)
        Dim CC As New clsCreate1LegBrace
        Dim eConnAdapter As New ConnectionAdapter(ConnectionId.ToInt64)

        If ConnectionId <> 0 Then
            Data.ReadFromConnectionId(ConnectionId.ToInt64)

            TheExchange = New ExchangeClass(CreatedEntitySize)
            TheExchange.InitialiseCreatedEntity(ConnectionId)
            TheExchange.ReadFromConnectionCreated()

            Data.mVersionNumber = PLUGIN_VERSION

            'execute creation
            If CC.GetBaseMatrix() Then
                If eConnAdapter.IsBuilt Then
                    CleanI(ConnectionId, False)
                End If

                CC.SetMatrix(0)
                CC.CreateBottomPlate()
                CC.SetMatrix(1)
                CC.CreateSidePlate()
                CC.SetMatrix(2)
                CC.CreateSide2Plate()

                For Each objId As Long In CC.mCreatedObjects
                    eConnAdapter.AppendSecondActiveObjectId(objId)
                Next
                eConnAdapter.AppendSecondActiveObjectId(Data.mPickedMPipeId)
                eConnAdapter.AppendSecondActiveObjectId(Data.mPickedBPipeId)
                eConnAdapter.AppendSecondActiveObjectId(Data.mPickedAngleId)

                CreateGroup(CC.mCreatedObjects)

                eConnAdapter.SetBuilt(True)
                eConnAdapter.CommitAppendObjects()

                Data.WriteToConnectionId(ConnectionId.ToInt64)

                Dim Display As New PsDisplayClassManager
                Display.RefreshScreen()
                Display.Close()
            End If
        End If

        CC = Nothing
        TheExchange = Nothing
        eConnAdapter = Nothing
    End Sub

    Public Sub EditI(ByVal IntId As IntPtr)
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
            ErrorLog.ShowError(ex)
        End Try
    End Sub

    Public Sub DrawI(ByVal ConnectionId As IntPtr)

    End Sub

    Public Sub CleanI(ByVal ConnectionId As IntPtr, Optional ByVal EraseConn As Boolean = True)
        If ConnectionId <> 0 Then

            Dim oTrans As New PsTransaction
            Dim eConnection As PsConnection = Nothing
            Dim oEdit As New PsEditModification
            Dim i, Id As Integer

            Try
                oTrans.GetObject(ConnectionId.ToInt64, PsOpenMode.kForWrite, eConnection)
                If Not eConnection Is Nothing Then
                    Data.ReadFromConnection(eConnection)

                    'eConnection.RemoveAllCreatedEntity(True)
                    'eConnection.RemoveAllActiveEntity(True)
                    If eConnection.SecondActiveEntityCount > 1 Then
                        Id = eConnection.SecondActiveObjectId(eConnection.SecondActiveEntityCount - 1)
                        eConnection.RemoveSecondActiveObjectId(Id, False)
                    End If
                    If eConnection.SecondActiveEntityCount > 1 Then
                        Id = eConnection.SecondActiveObjectId(eConnection.SecondActiveEntityCount - 1)
                        eConnection.RemoveSecondActiveObjectId(Id, False)
                    End If
                    If eConnection.SecondActiveEntityCount > 1 Then
                        Id = eConnection.SecondActiveObjectId(eConnection.SecondActiveEntityCount - 1)
                        eConnection.RemoveSecondActiveObjectId(Id, False)
                    End If
                    eConnection.RemoveAllSecondActiveEntity(True)

                    'remove added holes from picked angle 
                    oEdit.SetObjectId(Data.mPickedAngleId)
                    For i = 0 To Data.mPickedAngleHoleCount - 1
                        oEdit.DeleteHoleField(Data.mPickedAngleHoleLastHandle - i)
                    Next i
                    Data.mPickedAngleHoleCount = 0
                    Data.mPickedAngleHoleLastHandle = 0

                    If EraseConn Then eConnection.Erase()
                End If
            Catch ex As System.Exception
                ErrorLog.ShowError(ex)
            Finally
                oTrans.Close()
                oEdit = Nothing
            End Try
        End If
    End Sub

    Public Function Create() As IntPtr
        Dim ConnectionId As IntPtr

        IsCreatingConn = True

        Try
            ConnectionId = InitialCall()

            If ConnectionId <> 0 Then
                BuildI(ConnectionId)
                EditI(ConnectionId)
            End If
        Catch ex As System.Exception
            ErrorLog.ShowError(ex)
        End Try

        IsCreatingConn = False

        Return ConnectionId
    End Function

    ' Private sub-routines and functions

    Private Function InitialCall() As IntPtr
        Dim ConnectionId As IntPtr

        Dim ConnectionHandle As String = ""
        Dim Measurement As Integer

        Dim Entity As Integer
        Dim Message As String = ""
        Dim Selection As New PsSelection

        Do
            Entity = Selection.PickObject(RSS.RSS("M0000"))
            If Entity <= 0 Then Return 0

            Dim oShape As PsShape = Nothing
            Dim oTrans2 As New PsTransaction
            If (oTrans2.GetObject(Entity, PsOpenMode.kForRead, oShape, False) = True) Then
                MessageBox.Show(oShape.CrossSectionCatalog + " " + oShape.CrossSectionName + " <---> " + oShape.Width.ToString + "x" + oShape.Height.ToString)
            End If

            Return 0

        Loop Until (IsPipe(Entity))
        Data.mPickedMPipeId = Entity

        Do
            Entity = Selection.PickObject(RSS.RSS("M0001"))
            If Entity <= 0 Then Return 0
        Loop Until (IsPipe(Entity))
        Data.mPickedBPipeId = Entity

        Do
            Entity = Selection.PickObject(RSS.RSS("M0003"))
            If Entity <= 0 Then Return 0
        Loop Until (IsAngle(Entity))
        Data.mPickedAngleId = Entity

        Dim oCreateConnection As New PsCreateConnection

        IsCreatingConn = True

        oCreateConnection.SetIdentifier(PLUGIN_IDENTIFIER)
        oCreateConnection.SetDescription(PLUGIN_DESCRIPTION)
        If (oCreateConnection.Create()) Then
            ConnectionId = oCreateConnection.ObjectId
        End If

        Dim eConnection As PsConnection = Nothing
        Dim oTrans As New PsTransaction

        Try
            oTrans.GetObject(ConnectionId.ToInt64, PsOpenMode.kForWrite, eConnection)
            If Not eConnection Is Nothing Then
                eConnection.IsBuilt = False

                Data.SetToDefaults()
                Data.mVersionNumber = PLUGIN_VERSION

                Dim sFileName As String = GetTemplateFileName(PLUGIN_IDENTIFIER)
                If File.Exists(sFileName) Then
                    Dim oTemplateMgr As New PsTemplateManager
                    oTemplateMgr.LoadTemplateEntry(PLUGIN_IDENTIFIER)
                    Data.ReadFromTemplate(oTemplateMgr)
                    oTemplateMgr = Nothing
                End If

                Data.WriteToConnection(eConnection)
            End If

        Catch ex As System.Exception
        Finally
            oTrans.Close()
        End Try

        Selection = Nothing
        oCreateConnection = Nothing
        Return ConnectionId
    End Function

    Private Sub CreateGroup(ByVal createdObjects As Collection)
        If Not Data.mCreateGroup Then Return

        Dim oGroup As PsObjectGroup

        Try
            oGroup = New PsObjectGroup
            oGroup.setMainPart(Convert.ToInt32(createdObjects.Item(1)))
            For i As Integer = 2 To createdObjects.Count
                oGroup.AddSubPart(Convert.ToInt32(createdObjects.Item(i)))
            Next i
            oGroup.Create()
        Catch ex As Exception
            ErrorLog.ShowError(ex)
        End Try

        oGroup = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        Base = Nothing
        MyBase.Finalize()
    End Sub
End Class