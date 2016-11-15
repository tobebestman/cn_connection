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

    Private mBuilder As New ConnectionBuilder

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

    Private Function GetConnectionIntersectPtAndUcs(ByRef oConnAdpt As ConnectionAdapter,
                                        ByRef instPt1 As PsPoint,
                                        ByRef instPt2 As PsPoint,
                                        ByRef connUcs As PsMatrix) As Boolean
        Dim supportId As Long = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt)
        If supportId = 0 Then
            Return False
        End If

        Dim connectId As Long = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 1)
        If connectId = 0 Then
            Return False
        End If

        Dim MathTool As New PsGeometryFunctions
        Dim supportAdpt As New ShapeAdapter(supportId)
        Dim connectAdpt As New ShapeAdapter(connectId)

        If MathTool.IntersectLineWithLine(supportAdpt.MidLineStart, supportAdpt.MidLineEnd,
                                                   connectAdpt.MidLineStart, connectAdpt.MidLineEnd, 4, instPt1) = False Then
            Return False
        End If
        Dim pt1 As PsPoint = MathTool.OrthoProjectPointToLine(connectAdpt.MidLineMid,
                                                              supportAdpt.MidLineStart,
                                                              supportAdpt.MidLineEnd)
        Dim yAxis As New PsVector
        yAxis.SetFromPoints(pt1, connectAdpt.MidLineMid)

        connectId = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 2)
        If connectId = 0 Then
            Return False
        End If

        connectAdpt.ReadFrom(connectId)
        If MathTool.IntersectLineWithLine(supportAdpt.MidLineStart, supportAdpt.MidLineEnd,
                                                   connectAdpt.MidLineStart, connectAdpt.MidLineEnd, 4, instPt2) = False Then
            Return False
        End If
        Dim pt2 As PsPoint = MathTool.OrthoProjectPointToLine(connectAdpt.MidLineMid,
                                                              supportAdpt.MidLineStart,
                                                              supportAdpt.MidLineEnd)
        Dim zAxis As New PsVector
        zAxis.SetFromPoints(pt1, pt2)

        Dim xAxis As New PsVector
        yAxis.Normalize()
        zAxis.Normalize()
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        connUcs.SetCoordinateSystem(instPt1, xAxis, yAxis)

        Return True
    End Function

    Private Function IsShapeInLine(first As Long, second As Long) As Long

        Dim firstAdpt As New ShapeAdapter(first)
        Dim secondAdpt As New ShapeAdapter(second)

        Dim firstVect As PsVector = firstAdpt.MidLineStart - firstAdpt.MidLineEnd
        Dim secondVect As PsVector = secondAdpt.MidLineStart - firstAdpt.MidLineMid

        If firstVect.IsParallelTo(secondVect) = False Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' try to "combine" the two input shape.
    ''' adjsut the start/end point of the first shape
    ''' make the new lenght of the first shape to the 
    ''' sum of the two shape's length.
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="second"></param>
    ''' <returns></returns>
    Private Function CombineInlineShape(first As Long, second As Long) As Boolean
        If first = 0 Or second = 0 Then
            Debug.Assert(False)
            Return False
        End If

        If (IsShapeInLine(first, second) = first) Then
            Return False
        End If

        Dim firstAdpt As New ShapeAdapter(first)
        Dim secondAdpt As New ShapeAdapter(second)

        Dim newEnd As New PsPoint
        Select Case secondAdpt.GetEndSideTo(secondAdpt.MidLineMid)
            Case 1
                newEnd = secondAdpt.MidLineStart
            Case 2
                newEnd = secondAdpt.MidLineEnd
            Case 0
                Return False
        End Select

        Select Case firstAdpt.GetEndSideTo(newEnd)
            Case 1
                firstAdpt.SetShapeStart(newEnd)
            Case 2
                firstAdpt.SetShapeEnd(newEnd)
            Case 0
                Return False
        End Select

        Return True
    End Function

    Function CutShapeInwards(shapeId As Long, ByRef basePoint As PsPoint, distance As Double) As Long

        Dim shapeAdpt As New ShapeAdapter(shapeId)
        Dim oMidPt As PsPoint
        oMidPt = shapeAdpt.MidLineMid

        'mid --> base
        Dim vect As New PsVector
        vect.SetFromPoints(oMidPt, basePoint)
        vect.Normalize()

        Dim cutPt As New PsPoint
        cutPt = MathTool.GetPointInDirection(basePoint, -vect, distance)

        'Dim oPrimit As New PsCreatePrimitive
        'oPrimit.Init()
        'oPrimit.SetInsertPoint(cutPt)
        'oPrimit.SetXYPlane(New PsVector(1, 0, 0), New PsVector(0, 1, 0))
        'oPrimit.CreateSphere(100)

        'oPrimit.SetInsertPoint(basePoint)
        'oPrimit.CreateSphere(200)

        'oPrimit.SetInsertPoint(oMidPt)
        'oPrimit.CreateSphere(150)

        Dim oCut As New PsCutObjects
        oCut.SetToDefaults()

        Dim oPlane As New PsCutPlane
        oPlane.SetFromNormal(cutPt, vect)
        oCut.SetAsPlaneCut(oPlane)
        oCut.SetObjectId(shapeId)

        Dim result As Long = oCut.Apply
        Return result
    End Function

    Private Function RecoverOriginSupporingShape(ByRef oConnAdpt As ConnectionAdapter) As Boolean
        Dim originId As Long = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt)
        Dim createdId As Long = mBuilder.getCreatedSupporingShapeFromAdapter(oConnAdpt)
        If (combineInlineShape(originId, createdId) = False) Then
            Debug.Assert(False)
            Return False
        End If
        Return True
    End Function

    Private Function CreateTopPlate(supportId As Long, splitDist As Double, oData As Parameters, oUcsMat As PsMatrix) As Long
        Dim shpApt As New ShapeAdapter(supportId)
        Dim plateWidth = shpApt.Width
        Dim plateThickness = oData.mPlateThickness
        Dim vertPos As VerticalPosition = VerticalPosition.kDown
        Dim plateLength = oData.mSupport1CutBack + oData.mSupport2CutBack + splitDist
        Dim oMat As New PsMatrix
        Dim yAxis As New PsVector
        Dim xAxis As New PsVector
        oUcsMat.getYAxis(yAxis)

        Dim org As New PsPoint
        oUcsMat.getOrigin(org)

        org = MathTool.GetPointInDirection(org, yAxis, shpApt.Height / 2)
        oUcsMat.getZAxis(yAxis)
        org = MathTool.GetPointInDirection(org, yAxis, (plateLength / 2 - oData.mSupport1CutBack))
        oUcsMat.getXAxis(xAxis)
        oUcsMat.getZAxis(yAxis)
        oMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return CreatePlate(plateWidth, plateLength, plateThickness,
                           0, 0, vertPos, oMat)
    End Function

    Private Function CreateBottomPlate(supportId As Long, splitDist As Double, oData As Parameters, oUcsMat As PsMatrix) As Long
        Dim shpApt As New ShapeAdapter(supportId)
        Dim plateWidth = shpApt.Width
        Dim plateThickness = oData.mPlateThickness
        Dim vertPos As VerticalPosition = VerticalPosition.kTop
        Dim plateLength = oData.mSupport1CutBack + oData.mSupport2CutBack + splitDist
        Dim oMat As New PsMatrix
        Dim yAxis As New PsVector
        Dim xAxis As New PsVector
        oUcsMat.getYAxis(yAxis)

        Dim org As New PsPoint
        oUcsMat.getOrigin(org)
        org = MathTool.GetPointInDirection(org, yAxis, -shpApt.Height / 2)
        oUcsMat.getZAxis(yAxis)
        org = MathTool.GetPointInDirection(org, yAxis, (plateLength / 2 - oData.mSupport1CutBack))

        oUcsMat.getXAxis(xAxis)
        oUcsMat.getZAxis(yAxis)
        oMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return CreatePlate(plateWidth, plateLength, plateThickness,
                           0, 0, vertPos, oMat)
    End Function

    Private Function CreateLeftPlate(supportId As Long, splitDist As Double, oData As Parameters, oUcsMat As PsMatrix) As Long
        Dim shpApt As New ShapeAdapter(supportId)
        Dim plateWidth = shpApt.Height
        Dim plateThickness = oData.mPlateThickness
        Dim vertPos As VerticalPosition = VerticalPosition.kTop
        Dim plateLength = oData.mSupport1CutBack + oData.mSupport2CutBack + splitDist
        Dim oMat As New PsMatrix
        Dim yAxis As New PsVector
        Dim xAxis As New PsVector
        oUcsMat.getXAxis(xAxis)

        Dim org As New PsPoint
        oUcsMat.getOrigin(org)
        org = MathTool.GetPointInDirection(org, xAxis, -shpApt.Width / 2)
        oUcsMat.getZAxis(yAxis)
        org = MathTool.GetPointInDirection(org, yAxis, (plateLength / 2 - oData.mSupport1CutBack))

        oUcsMat.getZAxis(xAxis)
        oUcsMat.getYAxis(yAxis)
        oMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return CreatePlate(plateLength, plateWidth, plateThickness,
                           0, 0, vertPos, oMat)
    End Function

    Private Function CreateRightPlate(supportId As Long, splitDist As Double, oData As Parameters, oUcsMat As PsMatrix) As Long
        Dim shpApt As New ShapeAdapter(supportId)
        Dim plateWidth = shpApt.Height
        Dim plateThickness = oData.mPlateThickness
        Dim vertPos As VerticalPosition = VerticalPosition.kDown
        Dim plateLength = oData.mSupport1CutBack + oData.mSupport2CutBack + splitDist
        Dim oMat As New PsMatrix
        Dim yAxis As New PsVector
        Dim xAxis As New PsVector
        oUcsMat.getXAxis(xAxis)

        Dim org As New PsPoint
        oUcsMat.getOrigin(org)
        org = MathTool.GetPointInDirection(org, xAxis, shpApt.Width / 2)
        oUcsMat.getZAxis(yAxis)
        org = MathTool.GetPointInDirection(org, yAxis, (plateLength / 2 - oData.mSupport1CutBack))

        oUcsMat.getZAxis(xAxis)
        oUcsMat.getYAxis(yAxis)
        oMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return CreatePlate(plateLength, plateWidth, plateThickness,
                           0, 0, vertPos, oMat)
    End Function


    Private Function CreatePlate(plateWidth As Double, plateLength As Double,
                                 plateThickness As Double,
                                 xOffset As Double, yOffset As Double,
                                 vertPos As VerticalPosition, oMat As PsMatrix) As Long
        Dim oCreatePlate As New PsCreatePlate
        oCreatePlate.SetToDefaults()
        oCreatePlate.SetAsRectangularPlate(plateWidth, plateLength)
        oCreatePlate.SetNormalPosition(vertPos)
        oCreatePlate.SetThickness(plateThickness)

        oCreatePlate.SetXOffset(xOffset)
        oCreatePlate.SetYOffset(yOffset)

        Dim org As New PsPoint
        oMat.getOrigin(org)

        Utility.CreateBall(org)

        oCreatePlate.SetInsertMatrix(oMat)
        If oCreatePlate.Create() = False Then
            Debug.Assert(False)
        End If
        Dim plateId As Long = oCreatePlate.ObjectId
        Return plateId
    End Function

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

            Dim supportId = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt)
            If supportId = 0 Then
                Return
            End If

            Dim connectingId1 = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 1)
            Dim connectingId2 = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 2)

            Debug.Assert(connectingId1 <> 0 And connectingId2 <> 0)

            'execute creation
            If oConnAdpt.IsBuilt Then
                'recoverOriginSupporingShape(oConnAdpt)
                CleanI(ConnectionId, False)
            End If

            Dim instPt1 As PsPoint = New PsPoint
            Dim instPt2 As PsPoint = New PsPoint
            Dim connMat As PsMatrix = New PsMatrix

            If getConnectionIntersectPtAndUcs(oConnAdpt, instPt1, instPt2, connMat) = False Then
                Return
            End If

            Dim spliter As New PsEditShapeModification
            spliter.SplitAtPoint(supportId, instPt1)
            If spliter.NewObjectCount < 1 Then
                Return
            End If

            Dim newSupportId = spliter.getNewObjectId(0)
            If ((instPt1 - instPt2).Length > PRECISION) Then
                AdjustShapeToPoint(instPt1, instPt2, supportId, newSupportId)
            End If

            'Dim oTrans As New PsTransaction
            'Dim oshape As PsShape = Nothing
            'If oTrans.GetObject(newSupportId, PsOpenMode.kForRead, oshape) = True Then
            '    oTrans.Close()
            'End If

            'Dim oInfo As New PsShapeInfo
            'oInfo.SetObjectId(newSupportId)
            'oInfo.GetInfo()

            'Dim oRef As New PsShapeReference
            'oRef.init(0)
            'oRef.setAccessKey(oInfo.SectionCatalog, oInfo.SectionName)
            'oRef.getExplodeInPlates()

            Dim firstSupportCutId As Long = CutShapeInwards(supportId, instPt1, data.mSupport1CutBack)
            Dim secondSupportCutId As Long = CutShapeInwards(newSupportId, instPt2, data.mSupport2CutBack)

            Dim firstConnectingCutId As Long = CutShapeInwards(connectingId1, instPt1, data.mConnect1CutBack)
            Dim secondConnectingCutId As Long = CutShapeInwards(connectingId2, instPt2, data.mConnect2CutBack)
            Dim dist As Double = Math.Abs((instPt2 - instPt1).Length)

            Dim topPlateId As Long = CreateTopPlate(supportId, dist, data, connMat)
            Dim bottomPlateId As Long = CreateBottomPlate(supportId, dist, data, connMat)
            Dim leftPlateId As Long = CreateLeftPlate(supportId, dist, data, connMat)
            Dim rightPlateId As Long = CreateRightPlate(supportId, dist, data, connMat)

            oConnAdpt = Nothing

            oConnAdpt = New ConnectionAdapter(ConnectionId)

            oConnAdpt.AppendAdditionalObjectId(supportId)
            oConnAdpt.AppendAdditionalObjectId(connectingId1)
            oConnAdpt.AppendAdditionalObjectId(connectingId2)
            oConnAdpt.AppendAdditionalObjectId(newSupportId)

            oConnAdpt.AppendCreatedObjectArray(0, topPlateId)
            oConnAdpt.AppendCreatedObjectArray(0, bottomPlateId)

            oConnAdpt.AppendCreatedObjectArray(1, leftPlateId)
            oConnAdpt.AppendCreatedObjectArray(1, rightPlateId)

            'oConnAdpt.AppendCreatedObjectId(plateId)
            oConnAdpt.AppendSecondActiveObjectId(topPlateId)
            oConnAdpt.AppendSecondActiveObjectId(bottomPlateId)
            oConnAdpt.AppendSecondActiveObjectId(leftPlateId)
            oConnAdpt.AppendSecondActiveObjectId(rightPlateId)

            oConnAdpt.SetBuilt(True)
            oConnAdpt.CommitAppendObjects()

            Dim Display As New PsDisplayClassManager
            Display.RefreshScreen()
            Display.Close()

            oConnAdpt = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' this function is used to adjsut the stat/end point of the split members
    ''' based on the intersect point 1, and 2.
    ''' the supporId is the origin shape
    ''' the newSupportId is the new created shape.
    ''' because of the split operation's result is not always stable. we need re-match
    ''' the shapes with the break points.
    ''' </summary>
    ''' <param name="instPt1"></param>
    ''' <param name="instPt2"></param>
    ''' <param name="supportId"></param>
    ''' <param name="newSupportId"></param>
    ''' <remarks></remarks>
    Private Sub AdjustShapeToPoint(instPt1 As PsPoint, instPt2 As PsPoint,
                                   ByRef supportId As Long, ByRef newSupportId As Long)
        Dim orgAdpt As New ShapeAdapter(supportId)
        Dim newAdpt As New ShapeAdapter(newSupportId)

        Dim dirVec1 As New PsVector
        dirVec1.SetFromPoints(orgAdpt.MidLineMid, newAdpt.MidLineMid)
        dirVec1.Normalize()

        Dim dirVec2 As New PsVector
        dirVec2.SetFromPoints(instPt1, instPt2)
        dirVec2.Normalize()

        'the shapes are following the break points
        '   orgShape --------------------> new Shape
        '            instPt1 ---> instPt2
        If (Math.Abs(dirVec1.GetAngleTo(dirVec2)) < PRECISION) Then
            Select Case newAdpt.GetEndSideTo(instPt1)
                Case 1
                    newAdpt.SetShapeStart(instPt2)
                Case 2
                    newAdpt.SetShapeEnd(instPt2)
            End Select
        Else
            'the shapes are opposite to the break points
            '   newShape <-------------------- orgShape
            '             instPt1 ---> instPt2
            Select Case orgAdpt.GetEndSideTo(instPt1)
                Case 1
                    orgAdpt.SetShapeStart(instPt2)
                Case 2
                    orgAdpt.SetShapeEnd(instPt2)
            End Select

            'change to this
            '   orgShape ----------------------> newShape
            '             instPt1 ---> instPt2
            Dim temp As Long = supportId
            supportId = newSupportId
            newSupportId = temp

        End If

    End Sub

    Public Sub EditI(ByVal connId As Long)
        Try
            If Not mDlgShownIds.Contains(connId) Then
                mDlgShownIds.Add(connId)
                Dim Dialog As New UserConnectionForm

                Dialog.TopMost = False
                Dialog.mCallBack = Me
                Dialog.mIsCreatingConn = IsCreatingConn
                Dialog.EditData(connId)
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

            'Dim oAdpt As New ConnectionAdapter(ConnectionId)
            'oAdpt.ReadAddtionalObjects()
            'oAdpt.ReadCreatedObjectArray()
            'recoverOriginSupporingShape(oAdpt)

            Dim oTrans As New PsTransaction
            Dim oConnection As PsConnection = Nothing
            Dim oEdit As New PsEditModification

            Try
                oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, oConnection)
                If oConnection IsNot Nothing Then

                    For i As Integer = oConnection.AdditionalEntityCount - 1 To 0 Step -1
                        Dim id As Long = oConnection.AdditionalObjectId(i)
                        oEdit.SetObjectId(id)
                        oEdit.DeleteAllCutPlanes()
                    Next

                    oConnection.RemoveAllAdditionalEntity(False)


                    ''now remove the new created supporing shape introduced by the split operation
                    For i As Integer = oConnection.ArrayCreatedEntityCount(0) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(0, i)
                    Next

                    'now remove the new created top/bottom plate
                    For i As Integer = oConnection.ArrayCreatedEntityCount(1) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(1, i)
                    Next

                    'now remove the new created left/right plate
                    For i As Integer = oConnection.ArrayCreatedEntityCount(2) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(2, i)
                    Next

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

        Dim supportingShape As Long
        Do
            supportingShape = Selection.PickObject(RSS.RSS("M0000"))
            If supportingShape <= 0 Then Return 0
        Loop Until (IsWeldShape(supportingShape))

        Dim connectingShape1 As Long
        Do
            connectingShape1 = Selection.PickObject(RSS.RSS("M0001"))
            If connectingShape1 <= 0 Then Return 0
        Loop Until (IsWeldShape(connectingShape1))

        Dim connectingShape2 As Long
        Do
            connectingShape2 = Selection.PickObject(RSS.RSS("M0003"))
            If connectingShape2 <= 0 Then Return 0
        Loop Until (IsWeldShape(connectingShape2))

        Dim oCreateConnection As New PsCreateConnection

        IsCreatingConn = True

        oCreateConnection.SetIdentifier(PLUGIN_IDENTIFIER)
        oCreateConnection.SetDescription(PLUGIN_DESCRIPTION)
        If (oCreateConnection.Create()) Then
            ConnectionId = oCreateConnection.ObjectId
        End If

        Dim connAdpt As New ConnectionAdapter(ConnectionId)
        connAdpt.SetBuilt(False)
        connAdpt.AppendAdditionalObjectId(supportingShape)
        connAdpt.AppendAdditionalObjectId(connectingShape1)
        connAdpt.AppendAdditionalObjectId(connectingShape2)
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