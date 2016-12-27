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
                                        ByRef connUcs1 As PsMatrix,
                                        ByRef connUcs2 As PsMatrix) As Boolean

        Dim supportId1 As Long = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt, 0)
        If supportId1 = 0 Then
            Return False
        End If
        Dim supportId2 As Long = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt, 1)
        If supportId2 = 0 Then
            Return False
        End If

        Dim connectId1 As Long = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 2)
        If connectId1 = 0 Then
            Return False
        End If
        Dim connectId2 As Long = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 3)
        If connectId2 = 0 Then
            Return False
        End If

        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(supportId1, connectId1, instPt1, connUcs1) = False Then
            Return False
        End If

        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(supportId2, connectId2, instPt2, connUcs2) = False Then
            Return False
        End If

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

    Private Function GetDriectConnectedPlateBoundaryBetweenLines(pts1 As PsPoint, pte1 As PsPoint,
                                                        cut1 As Double, w1 As Double,
                                                        pts2 As PsPoint, pte2 As PsPoint,
                                                        cut2 As Double, w2 As Double) As List(Of PsPoint)
        Dim oMat1 As PsMatrix
        oMat1 = GeoHelper.CalculateConnectingMemberUcs(pts1, pte1, pts2, pte2, True)
        Dim oMat2 As PsMatrix
        oMat2 = GeoHelper.CalculateConnectingMemberUcs(pts1, pte1, pts2, pte2, False)

        If (oMat1 Is Nothing Or oMat2 Is Nothing) Then
            Debug.Assert(False)
            Return Nothing
        End If

        'calculate the first part of the boundary
        Dim firstPart As New List(Of PsPoint)
        Dim pt1 As New PsPoint
        Dim xAxis1 As New PsVector
        Dim yAxis1 As New PsVector
        Dim zAxis1 As New PsVector

        oMat1.getOrigin(pt1)
        oMat1.getXAxis(xAxis1)
        oMat1.getYAxis(yAxis1)
        oMat1.getZAxis(zAxis1)

        pt1 = MathTool.GetPointInDirection(pt1, xAxis1, cut1)
        pt1 = MathTool.GetPointInDirection(pt1, yAxis1, w1 / 2)
        firstPart.Add(pt1)

        'calcualte the 2nd half of the boundary
        Dim secondPart As New List(Of PsPoint)
        Dim pt2 As New PsPoint
        Dim xAxis2 As New PsVector
        Dim yAxis2 As New PsVector
        Dim zAxis2 As New PsVector

        oMat2.getOrigin(pt2)
        oMat2.getXAxis(xAxis2)
        oMat2.getYAxis(yAxis2)
        oMat2.getZAxis(zAxis2)

        pt2 = MathTool.GetPointInDirection(pt2, xAxis2, cut2)
        pt2 = MathTool.GetPointInDirection(pt2, -yAxis2, w2 / 2)
        firstPart.Add(pt2)

        Debug.Assert(firstPart.Count = 2)
        Return firstPart
    End Function

    ''' <summary>
    ''' some assumptions: pts1 and pte1 are at the same side of the intersection.
    ''' </summary>
    ''' <param name="pts1"></param>
    ''' <param name="pte1"></param>
    ''' <param name="cut1"></param>
    ''' <param name="w1"></param>
    ''' <param name="angle1"></param>
    ''' <param name="pts2"></param>
    ''' <param name="pte2"></param>
    ''' <param name="cut2"></param>
    ''' <param name="w2"></param>
    ''' <param name="angle2"></param>
    ''' <param name="radius"></param>
    ''' <returns></returns>
    Private Function GetPlateBoundaryBetweenLines(pts1 As PsPoint, pte1 As PsPoint,
                                                  cut1 As Double, w1 As Double, angle1 As Double,
                                                  pts2 As PsPoint, pte2 As PsPoint,
                                                  cut2 As Double, w2 As Double, angle2 As Double,
                                                  radius As Double) As List(Of PsPoint)
        Dim oMat1 As PsMatrix
        oMat1 = GeoHelper.CalculateConnectingMemberUcs(pts1, pte1, pts2, pte2, True)
        Dim oMat2 As PsMatrix
        oMat2 = GeoHelper.CalculateConnectingMemberUcs(pts1, pte1, pts2, pte2, False)

        If (oMat1 Is Nothing Or oMat2 Is Nothing) Then
            Debug.Assert(False)
            Return Nothing
        End If

        'calculate the first part of the boundary
        Dim firstPart As New List(Of PsPoint)
        Dim pt1 As New PsPoint
        Dim xAxis1 As New PsVector
        Dim yAxis1 As New PsVector
        Dim zAxis1 As New PsVector

        oMat1.getOrigin(pt1)
        oMat1.getXAxis(xAxis1)
        oMat1.getYAxis(yAxis1)
        oMat1.getZAxis(zAxis1)

        pt1 = MathTool.GetPointInDirection(pt1, xAxis1, cut1)
        firstPart.Add(pt1)

        pt1 = MathTool.GetPointInDirection(pt1, yAxis1, w1 / 2)
        firstPart.Add(pt1)

        Dim newEnd1 As New PsPoint
        GeoHelper.RotateLineByStart(pt1,
                                    MathTool.GetPointInDirection(pt1, -xAxis1,
                                                                 MathTool.GetDistanceBetween(pts1, pte1)),
                                    -angle1,
                                    zAxis1, newEnd1)

        'calcualte the 2nd half of the boundary
        Dim secondPart As New List(Of PsPoint)
        Dim pt2 As New PsPoint
        Dim xAxis2 As New PsVector
        Dim yAxis2 As New PsVector
        Dim zAxis2 As New PsVector

        oMat2.getOrigin(pt2)
        oMat2.getXAxis(xAxis2)
        oMat2.getYAxis(yAxis2)
        oMat2.getZAxis(zAxis2)

        pt2 = MathTool.GetPointInDirection(pt2, xAxis2, cut2)
        secondPart.Add(pt2)

        pt2 = MathTool.GetPointInDirection(pt2, -yAxis2, w2 / 2)
        secondPart.Add(pt2)

        Dim newEnd2 As New PsPoint
        GeoHelper.RotateLineByStart(pt2,
                                    MathTool.GetPointInDirection(pt2, -xAxis2,
                                                                 MathTool.GetDistanceBetween(pts2, pte2)),
                                    angle2,
                                    zAxis2, newEnd2)

        'now we have the connecting part of part1 and part2 calcualte the 
        'fillet points between these two lines
        Dim filletPoints As List(Of PsPoint)
        filletPoints = GeoHelper.FilletTwoLine(pt1, newEnd1, pt2, newEnd2, radius)

        firstPart.AddRange(filletPoints)
        secondPart.Reverse()
        firstPart.AddRange(secondPart)

        Debug.Assert(firstPart.Count = 6)
        Return firstPart
    End Function

    Private Shared Function CreatePlate(plateWidth As Double, plateLength As Double,
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

        'Utility.CreateBall(org)

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

            Dim supportingId1 = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt, 0)
            Dim supportingId2 = mBuilder.getOriginSupportingShapeIdFromAdapter(oConnAdpt, 1)
            Dim connectingId1 = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 2)
            Dim connectingId2 = mBuilder.getConnectingShapeIdFromAdapter(oConnAdpt, 3)

            Dim supportingColumnId = mBuilder.getSupportColumnIdFromAdapter(oConnAdpt, 4)

            If (supportingId1 <= 0 Or supportingId2 <= 0 Or
                connectingId1 <= 0 Or connectingId2 <= 0 Or
                supportingColumnId <= 0) Then
                Debug.Assert(False)
                Return
            End If

            'execute creation
            If oConnAdpt.IsBuilt Then
                CleanI(ConnectionId, False)
            End If

            Dim instPt1 As PsPoint = New PsPoint
            Dim instPt2 As PsPoint = New PsPoint
            Dim connMat1 As PsMatrix = New PsMatrix
            Dim connMat2 As PsMatrix = New PsMatrix

            If GetConnectionIntersectPtAndUcs(oConnAdpt,
                                              instPt1, instPt2,
                                              connMat1, connMat2) = False Then
                Return
            End If

            Dim cutId As Integer = CutColumnBySupportShape(data, supportingId2, supportingColumnId)
            data.mColumnCutIndex = IIf(cutId <> -1, cutId, -1)

            Dim boolIds As List(Of Integer) = BooleanCutColumn(data, supportingId2, supportingColumnId)
            If (boolIds.Count = 4) Then
                data.mColumnBoolCutIndex1 = IIf(boolIds(0) <> -1, boolIds(0), -1)
                data.mColumnBoolCutIndex2 = IIf(boolIds(1) <> -1, boolIds(1), -1)
                data.mColumnBoolCutIndex3 = IIf(boolIds(2) <> -1, boolIds(2), -1)
                data.mColumnBoolCutIndex4 = IIf(boolIds(3) <> -1, boolIds(3), -1)
            End If

            Dim cutIds As List(Of Integer) = CutSupportShapeSidePlate(connMat1, supportingId1, data, instPt1, instPt2, True)
            If (cutIds.Count = 2) Then
                data.mFirstLeftCutIndex = IIf(cutIds(0) <> -1, cutIds(0), -1)
                data.mFirstRightCutIndex = IIf(cutIds(1) <> -1, cutIds(1), -1)
            End If

            cutIds = CutSupportShapeSidePlate(connMat2, supportingId2, data, instPt1, instPt2, False)
            If (cutIds.Count = 2) Then
                data.mSecondLeftCutIndex = IIf(cutIds(0) <> -1, cutIds(0), -1)
                data.mSecondRightcutIndex = IIf(cutIds(1) <> -1, cutIds(1), -1)
            End If

            cutId = Utility.CutShapeInwards(connectingId1, instPt1, data.mConnect1CutBack +
                                                           data.mConnectPlate1.gap)
            data.mFirstCutBackCutIndex = IIf(cutId <> -1, cutId, -1)
            cutId = Utility.CutShapeInwards(connectingId2, instPt2, data.mConnect2CutBack +
                                                           data.mConnectPlate2.gap)
            data.mSecondCutBackCutIndex = IIf(cutId <> -1, cutId, -1)

            Dim oPoly As PsPolygon = CreateSidePlateProfile(data,
                                                            supportingId1, supportingId2,
                                                            connectingId1, connectingId2,
                                                            supportingColumnId,
                                                            connMat1, connMat2, instPt1, instPt2)
            Dim dist As Double = MathTool.GetDistanceBetween(instPt1, instPt2)
            Dim sidePlateCreator1 As New SidePlateCreator(data, supportingId1,
                           CalculatePositiveXSidePlateMatrix(data, supportingId1, connMat1), oPoly)
            sidePlateCreator1.Create(VerticalPosition.kDown)

            Dim sidePlateCreator2 As New SidePlateCreator(data, supportingId1,
                            CalculateNegtiveXSidePlateMatrix(data, supportingId1, connMat1), oPoly)
            sidePlateCreator2.Create(VerticalPosition.kTop)


            Dim ConnectPlatesCreater1 As New ArcPlatesCreator(data.mConnectPlate1,
                                                     GetConnectPlateInsertMatrix(connectingId1, instPt1))
            ConnectPlatesCreater1.Create()
            Dim ConnectPlatesCreater2 As New ArcPlatesCreator(data.mConnectPlate2,
                                                     GetConnectPlateInsertMatrix(connectingId2, instPt2))
            ConnectPlatesCreater2.Create()

            Dim SideConnectPlatesCreater1 As New SideConnectPlatesCreater(supportingId1, connectingId1,
                        data.mSideConnectPlate1,
                        SidePlateTopToCenterDistance(data, supportingId1),
                        (New ShapeAdapter(connectingId1).Height - data.mConnectPlate1.width) / 2,
                        data.mConnectPlate1.gap,
                        GetSideConnectPlatesMatrix(data.mSideConnectPlate1,
                                                   data.mConnectPlate1.gap,
                                                   connectingId1, instPt1))
            SideConnectPlatesCreater1.Create()
            SideConnectPlatesCreater1.CreateDrill(SideConnectPlatesCreater1.FirstMainPlateMatrix, sidePlateCreator1.sidePlateId)
            SideConnectPlatesCreater1.CreateDrill(SideConnectPlatesCreater1.SecondMainPlateMatrix, sidePlateCreator2.sidePlateId)
            Dim drillId1 As List(Of Integer) = SideConnectPlatesCreater1.CreateDrill(SideConnectPlatesCreater1.FirstMainPlateMatrix, connectingId1)
            Dim drillId2 As List(Of Integer) = SideConnectPlatesCreater1.CreateDrill(SideConnectPlatesCreater1.SecondMainPlateMatrix, connectingId1)
            data.mSideConnectPlate1.drillModifyIndices.AddRange(drillId1)
            data.mSideConnectPlate1.drillModifyIndices.AddRange(drillId2)

            Dim SideConnectPlatesCreater2 As New SideConnectPlatesCreater(supportingId2, connectingId2, data.mSideConnectPlate2,
                        SidePlateTopToCenterDistance(data, supportingId2),
                        (New ShapeAdapter(connectingId2).Height - data.mConnectPlate2.width) / 2,
                        data.mConnectPlate2.gap,
                        GetSideConnectPlatesMatrix(data.mSideConnectPlate2,
                                                   data.mConnectPlate2.gap,
                                                   connectingId2, instPt2))
            SideConnectPlatesCreater2.Create()
            SideConnectPlatesCreater2.CreateDrill(SideConnectPlatesCreater2.FirstMainPlateMatrix, sidePlateCreator1.sidePlateId)
            SideConnectPlatesCreater2.CreateDrill(SideConnectPlatesCreater2.SecondMainPlateMatrix, sidePlateCreator2.sidePlateId)
            drillId1 = SideConnectPlatesCreater2.CreateDrill(SideConnectPlatesCreater2.FirstMainPlateMatrix, connectingId2)
            drillId2 = SideConnectPlatesCreater2.CreateDrill(SideConnectPlatesCreater2.SecondMainPlateMatrix, connectingId2)
            data.mSideConnectPlate2.drillModifyIndices.AddRange(drillId1)
            data.mSideConnectPlate2.drillModifyIndices.AddRange(drillId2)

            Dim webConnectPlatesCreater1 As New WebConnectPlatesCreater(data.mWebConnectPlate1,
                                                     data.mConnectPlate1,
                                                     GetConnectPlateInsertMatrix(connectingId1, instPt1))
            webConnectPlatesCreater1.Create()
            DrillConnectMemberWeb(data, connectingId1, instPt1, data.mWebConnectPlate1, webConnectPlatesCreater1)

            Dim webConnectPlatesCreater2 As New WebConnectPlatesCreater(data.mWebConnectPlate2,
                                                     data.mConnectPlate2,
                                                     GetConnectPlateInsertMatrix(connectingId2, instPt2))
            webConnectPlatesCreater2.Create()
            DrillConnectMemberWeb(data, connectingId2, instPt2, data.mWebConnectPlate2, webConnectPlatesCreater2)

            oConnAdpt = Nothing

            oConnAdpt = New ConnectionAdapter(ConnectionId)

            oConnAdpt.AppendAdditionalObjectId(supportingId1)
            oConnAdpt.AppendAdditionalObjectId(supportingId2)
            oConnAdpt.AppendAdditionalObjectId(connectingId1)
            oConnAdpt.AppendAdditionalObjectId(connectingId2)

            oConnAdpt.AppendAdditionalObjectId(supportingColumnId)

            oConnAdpt.AppendCreatedObjectArray(0, sidePlateCreator1.sidePlateId)
            oConnAdpt.AppendCreatedObjectArray(0, sidePlateCreator2.sidePlateId)
            oConnAdpt.AppendCreatedObjectArray(1, ConnectPlatesCreater1.mainPlate)
            oConnAdpt.AppendCreatedObjectArray(1, ConnectPlatesCreater2.mainPlate)

            For Each id As Long In ConnectPlatesCreater1.webPlates
                oConnAdpt.AppendCreatedObjectArray(2, id)
            Next
            For Each id As Long In ConnectPlatesCreater2.webPlates
                oConnAdpt.AppendCreatedObjectArray(2, id)
            Next

            For Each id As Long In SideConnectPlatesCreater1.outsideSidePlates
                oConnAdpt.AppendCreatedObjectArray(3, id)
            Next
            For Each id As Long In SideConnectPlatesCreater1.accessorySidePlates
                oConnAdpt.AppendCreatedObjectArray(3, id)
            Next
            For Each id As Long In SideConnectPlatesCreater1.insideSidePlates
                oConnAdpt.AppendCreatedObjectArray(3, id)
            Next

            For Each id As Long In SideConnectPlatesCreater2.outsideSidePlates
                oConnAdpt.AppendCreatedObjectArray(4, id)
            Next
            For Each id As Long In SideConnectPlatesCreater2.accessorySidePlates
                oConnAdpt.AppendCreatedObjectArray(4, id)
            Next
            For Each id As Long In SideConnectPlatesCreater2.insideSidePlates
                oConnAdpt.AppendCreatedObjectArray(4, id)
            Next

            For Each id As Long In webConnectPlatesCreater1.webPlates
                oConnAdpt.AppendCreatedObjectArray(5, id)
            Next
            For Each id As Long In webConnectPlatesCreater1.accessoryPlates
                oConnAdpt.AppendCreatedObjectArray(5, id)
            Next

            For Each id As Long In webConnectPlatesCreater2.webPlates
                oConnAdpt.AppendCreatedObjectArray(6, id)
            Next
            For Each id As Long In webConnectPlatesCreater2.accessoryPlates
                oConnAdpt.AppendCreatedObjectArray(6, id)
            Next

            oConnAdpt.AppendCreatedObjectId(ConnectPlatesCreater1.mainPlate)
            oConnAdpt.AppendCreatedObjectId(ConnectPlatesCreater2.mainPlate)
            For Each id As Long In ConnectPlatesCreater1.webPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In ConnectPlatesCreater2.webPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In SideConnectPlatesCreater1.outsideSidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In SideConnectPlatesCreater1.accessorySidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In SideConnectPlatesCreater1.insideSidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            For Each id As Long In SideConnectPlatesCreater2.outsideSidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In SideConnectPlatesCreater2.accessorySidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In SideConnectPlatesCreater2.insideSidePlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            For Each id As Long In webConnectPlatesCreater1.webPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In webConnectPlatesCreater2.webPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            For Each id As Long In webConnectPlatesCreater1.accessoryPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next
            For Each id As Long In webConnectPlatesCreater2.accessoryPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            oConnAdpt.AppendSecondActiveObjectId(sidePlateCreator1.sidePlateId)
            oConnAdpt.AppendSecondActiveObjectId(sidePlateCreator2.sidePlateId)

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

    Private Function BooleanCutColumnSide(data As Parameters,
                                                 supportingColumnId As Long,
                                                 oPtOrg As PsPoint,
                                                 oMat As PsMatrix,
                                                 topSidePlateBoolPoints As List(Of PsPoint)) As List(Of Integer)

        Dim result As New List(Of Integer)

        Dim oBoolPoly As New PsPolygon
        oBoolPoly.init()

        Dim xDir As New PsVector
        Dim yDir As New PsVector

        oMat.getYAxis(xDir)
        oMat.getZAxis(yDir)

        Dim oInsertMat As New PsMatrix
        oInsertMat.SetCoordinateSystem(oPtOrg, xDir, yDir)

        Utility.TransformPointListToPolygon(topSidePlateBoolPoints, oBoolPoly, oInsertMat)
        oBoolPoly.Close()

        Dim colAdpt As New ShapeAdapter(supportingColumnId)

        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetInsertMatrix(oInsertMat)
        oCreater.SetInsertHeight(colAdpt.Width / 2 + data.mPlateThickness - data.mMainChordPlateThickness)
        oCreater.SetFromPolygon(oBoolPoly)
        oCreater.SetNormalPosition(VerticalPosition.kTop)
        oCreater.SetThickness(data.mPlateThickness)
        If oCreater.Create() = False Then
            Debug.Assert(False)
        End If
        Dim pId1 As Long = oCreater.ObjectId
        Dim oCut As New PsCutObjects
        oCut.SetToDefaults()
        oCut.SetAsBooleanCut(pId1)
        oCut.SetObjectId(supportingColumnId)
        If oCut.Apply() < 0 Then
            Debug.Assert(False)
        End If

        result.Add(oCut.GetModifyIndex)

        oCreater.SetToDefaults()
        oCreater.SetInsertMatrix(oInsertMat)
        oCreater.SetInsertHeight(-(colAdpt.Width / 2 + data.mPlateThickness - data.mMainChordPlateThickness))
        oCreater.SetFromPolygon(oBoolPoly)
        oCreater.SetNormalPosition(VerticalPosition.kDown)
        oCreater.SetThickness(data.mPlateThickness)
        If oCreater.Create() = False Then
            Debug.Assert(False)
        End If
        Dim pId2 As Long = oCreater.ObjectId
        oCut.SetToDefaults()
        oCut.SetAsBooleanCut(pId2)
        oCut.SetObjectId(supportingColumnId)
        If oCut.Apply() < 0 Then
            Debug.Assert(False)
        End If

        result.Add(oCut.GetModifyIndex)

        Utility.EraseObjectId(pId1)
        Utility.EraseObjectId(pId2)

        Return result
    End Function

    Private Function BooleanCutColumnFlange(data As Parameters, supportingColumnId As Long,
                                            oMat As PsMatrix, pt1 As PsPoint,
                                            pt2 As PsPoint,
                                            vertPos As VerticalPosition) As Integer

        Dim platePts1 As List(Of PsPoint) = CalculateColumnFlangeBoolPoints(supportingColumnId,
                                                                          oMat, pt1, pt2)
        Dim oPoly As New PsPolygon
        oPoly.init()

        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim org As PsPoint = MathTool.GetPointBetween(platePts1(0), platePts1(3))

        oMat.getXAxis(xDir)
        oMat.getZAxis(yDir)

        Dim oTransMat As New PsMatrix
        oTransMat.SetCoordinateSystem(org, xDir, -yDir)

        Utility.TransformPointListToPolygon(platePts1, oPoly, oTransMat)
        oPoly.Close()

        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetThickness(data.mMainChordPlateThickness * 2)
        oCreater.SetInsertMatrix(oTransMat)
        oCreater.SetFromPolygon(oPoly)
        oCreater.SetNormalPosition(vertPos)

        If oCreater.Create() = False Then
            Debug.Assert(False)
        End If

        Dim pId1 As Long = oCreater.ObjectId
        Dim oCut As New PsCutObjects
        oCut.SetToDefaults()
        oCut.SetAsBooleanCut(pId1)
        oCut.SetObjectId(supportingColumnId)
        If oCut.Apply() < 0 Then
            Debug.Assert(False)
        End If

        Utility.EraseObjectId(pId1)

        Return oCut.GetModifyIndex

    End Function
    Private Function BooleanCutColumn(data As Parameters,
                                                 supportingId2 As Long,
                                                 supportingColumnId As Long) As List(Of Integer)

        'Dim topSidePlateBoolPoints As List(Of PsPoint) =
        '    GetTopHalfSidePlateBooleanCutBoundary(data,
        '                                          supportingId2,
        '                                          supportingColumnId)
        'Dim oMat As New PsMatrix
        'Dim oPtOrg As New PsPoint
        'Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(supportingColumnId, supportingId2, oPtOrg, oMat)

        'Dim result As List(Of Integer) = BooleanCutColumnSide(data, supportingColumnId,
        '                              oPtOrg, oMat, topSidePlateBoolPoints)

        'Dim modIndex As Integer = BooleanCutColumnFlange(data, supportingColumnId, oMat,
        '                                                  topSidePlateBoolPoints(0),
        '                                                  topSidePlateBoolPoints(1),
        '                                                  VerticalPosition.kDown)
        'result.Add(modIndex)

        'modIndex = BooleanCutColumnFlange(data, supportingColumnId, oMat,
        '                                   topSidePlateBoolPoints(2),
        '                                   topSidePlateBoolPoints(3),
        '                                   VerticalPosition.kTop)

        'result.Add(modIndex)
        Dim result = New List(Of Integer)
        Return result
    End Function


    Public Function CalculateColumnFlangeBoolPoints(supportingColumnId As Long,
                                                    oMat As PsMatrix,
                                                    pt1 As PsPoint,
                                                    pt2 As PsPoint) As List(Of PsPoint)
        Dim pts As New List(Of PsPoint)
        Dim xDir As New PsVector
        oMat.getXAxis(xDir)

        Dim columAdpt As New ShapeAdapter(supportingColumnId)
        pts.Add(MathTool.GetPointInDirection(pt1, xDir, columAdpt.Width / 2))
        pts.Add(MathTool.GetPointInDirection(pt2, xDir, columAdpt.Width / 2))
        pts.Add(MathTool.GetPointInDirection(pt2, -xDir, columAdpt.Width / 2))
        pts.Add(MathTool.GetPointInDirection(pt1, -xDir, columAdpt.Width / 2))
        Return pts
    End Function


    Private Shared Function CutColumnBySupportShape(data As Parameters, supportingId2 As Long, supportingColumnId As Long) As Integer
        Dim instPt3 As New PsPoint
        Dim connMat3 As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(
            supportingColumnId, supportingId2, instPt3, connMat3) = False Then
            Debug.Assert(False)
            Return -1
        End If

        Dim zAxis As New PsVector
        connMat3.getZAxis(zAxis)
        Dim yAxis As New PsVector
        connMat3.getYAxis(yAxis)

        Dim instPt2 As New PsPoint
        Dim connMat2 As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(
            supportingId2, supportingColumnId, instPt2, connMat2) = False Then
            Debug.Assert(False)
        End If

        Dim zAxis2 As New PsVector
        connMat2.getZAxis(zAxis2)
        Dim yAxis2 As New PsVector
        connMat2.getYAxis(yAxis2)

        Dim ang As Double = zAxis2.GetAngleTo(zAxis)

        Dim columnAdpt As New ShapeAdapter(supportingColumnId)

        Dim pt1 As New PsPoint
        pt1 = MathTool.GetPointInDirection(instPt3, -yAxis, columnAdpt.Height / 2)

        Dim pt2 As New PsPoint
        pt2 = MathTool.GetPointInDirection(pt1, -zAxis, data.mColumnCutBack)

        'drawBall(pt1, 50)
        'drawBall(pt2, 100)

        Dim oPlane As New PsCutPlane
        oPlane.InsertPoint = pt2
        oPlane.Normal = yAxis2

        Dim oCut As New PsCutObjects
        oCut.SetToDefaults()
        oCut.SetAsPlaneCut(oPlane)
        oCut.SetObjectId(supportingColumnId)
        oCut.Apply()
        Return oCut.GetModifyIndex

    End Function

    ''' <summary>
    '''                                   +   pt2
    '''                                 / |
    '''                                /  |
    '''                          pt3  *   |
    '''                               |   |
    '''                          pt4  +---+  pt1
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="supportingId2"></param>
    ''' <param name="supportingColumnId"></param>
    ''' <returns></returns>
    Private Shared Function GetTopHalfSidePlateBooleanCutBoundary(data As Parameters,
                                                  supportingId2 As Long,
                                                  supportingColumnId As Long) As List(Of PsPoint)
        Dim result As New List(Of PsPoint)

        Dim instPt3 As New PsPoint
        Dim connMat3 As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(
            supportingColumnId, supportingId2, instPt3, connMat3) = False Then
            Debug.Assert(False)
        End If

        Dim yAxis As New PsVector
        Dim zAxis As New PsVector
        connMat3.getYAxis(yAxis)
        connMat3.getZAxis(zAxis)
        Dim colAdpt As New ShapeAdapter(supportingColumnId)

        Dim pt1 As New PsPoint
        pt1 = MathTool.GetPointInDirection(instPt3, -yAxis, colAdpt.Height / 2)

        Dim pt2 As New PsPoint
        pt2 = MathTool.GetPointInDirection(pt1, -zAxis, data.mColumnCutBack)

        Dim instPt2 As New PsPoint
        Dim connMat2 As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(
            supportingId2, supportingColumnId, instPt2, connMat2) = False Then
            Debug.Assert(False)
        End If

        Dim zAxis2 As New PsVector
        connMat2.getZAxis(zAxis2)
        Dim ang As Double = zAxis2.GetAngleTo(zAxis)

        Dim pt3 As New PsPoint
        pt3 = MathTool.GetPointInDirection(pt2, yAxis, colAdpt.Height)
        pt3 = MathTool.GetPointInDirection(pt3, zAxis, colAdpt.Height / Math.Tan(ang))

        Dim pt4 As New PsPoint
        pt4 = MathTool.GetPointInDirection(instPt3, yAxis, colAdpt.Height / 2)

        result.Add(pt1)
        result.Add(pt2)
        result.Add(pt3)
        result.Add(pt4)

        'drawBall(pt1, 100)
        'drawBall(pt2, 150)
        'drawBall(pt3, 200)
        'drawBall(pt4, 250)
        Return result
    End Function

    Private Shared Sub DrillConnectMemberWeb(data As Parameters,
                                             shpId As Long,
                                             instPt1 As PsPoint,
                                             webConnectPlateDef As WebConnectPlateParameter,
                                             webCreator As WebConnectPlatesCreater)
        Dim centers As List(Of PsPoint) = webCreator.CalculateDrillCenter()
        Dim oMat As PsMatrix = GetConnectPlateInsertMatrix(shpId, instPt1)
        Dim xDir As New PsVector
        Dim yDir As New PsVector
        oMat.getXAxis(xDir)
        oMat.getYAxis(yDir)
        Dim ModIds As New List(Of Integer)
        For Each center As PsPoint In centers
            Dim ModId As Integer = webCreator.CreateDrill(shpId, xDir, yDir, center)
            If (ModId > 0) Then
                ModIds.Add(ModId)
            End If
        Next
        For Each modId As Integer In ModIds
            webConnectPlateDef.webConnectDrillModifyIds.Add(modId)
        Next
    End Sub

    Private Shared Function SidePlateTopToCenterDistance(data As Parameters, supportingId1 As Long)
        Dim sidePlateDist As Double
        Dim connShap As New ShapeAdapter(supportingId1)
        sidePlateDist = connShap.Width / 2 - data.mMainChordPlateThickness + data.mPlateThickness
        Return sidePlateDist
    End Function

    Private Shared Function GetSideConnectPlatesMatrix(ConnectPlate As SideConnectPlateParameter,
                                                       gap As Double,
                                                       connectingId1 As Long,
                                                       instPt1 As PsPoint) As PsMatrix
        Dim oMat As New PsMatrix
        Dim adpt As New ShapeAdapter(connectingId1)
        Dim zDir As New PsVector
        zDir.SetFromPoints(adpt.GetEndpointTo(instPt1), instPt1)
        zDir.Normalize()
        Dim xDir As New PsVector
        xDir = adpt.XAxis
        Dim org As New PsPoint
        org = adpt.GetEndpointTo(instPt1)
        org = MathTool.GetPointInDirection(org, zDir, gap / 2)
        oMat.SetCoordinateSystem(org, xDir, zDir)
        Return oMat
    End Function

    Private Shared Function GetConnectPlateInsertMatrix(connectingId1 As Long,
                                                        instPt1 As PsPoint) As PsMatrix
        Dim oMat As New PsMatrix
        Dim adpt As New ShapeAdapter(connectingId1)
        Dim zDir As New PsVector
        zDir.SetFromPoints(adpt.GetEndpointTo(instPt1), instPt1)
        zDir.Normalize()
        Dim xDir As New PsVector
        xDir = adpt.YAxis
        Dim org As New PsPoint
        org = adpt.GetEndpointTo(instPt1)
        org = MathTool.GetPointInDirection(org, zDir, 0)
        oMat.SetCoordinateSystem(org, xDir, zDir)
        Return oMat
    End Function



    Class SideConnectPlatesCreater
        Public outsideSidePlates As List(Of Integer)
        Public accessorySidePlates As List(Of Integer)
        Public insideSidePlates As List(Of Integer)

        Private param As SideConnectPlateParameter
        Private gap As Double
        Private flangeThickness As Double
        Private sidePlateTopToCenterDistance As Double
        Private baseMatrix As PsMatrix
        Private supportId As Long
        Private connectId As Long

        Public Sub New(supportShp As Long, connectShp As Long,
                       sidePlateData As SideConnectPlateParameter,
                       sidePlateTopToCenterDistance As Double,
                       flangeThickness As Double,
                       gap As Double, oMat As PsMatrix)
            supportId = supportShp
            connectId = connectShp

            outsideSidePlates = New List(Of Integer)
            accessorySidePlates = New List(Of Integer)
            insideSidePlates = New List(Of Integer)

            param = sidePlateData
            Me.sidePlateTopToCenterDistance = sidePlateTopToCenterDistance
            Me.flangeThickness = flangeThickness
            Me.gap = gap
            baseMatrix = oMat
        End Sub

        Private Function CalHoleGroupCenters(oMat As PsMatrix) As List(Of PsPoint)
            Dim result As New List(Of PsPoint)

            Dim xDir As New PsVector
            Dim yDir As New PsVector
            Dim org As New PsPoint

            oMat.getXAxis(xDir)
            oMat.getYAxis(yDir)
            oMat.getOrigin(org)

            Dim xDist As Double
            xDist = MainPlateWidth() / 2
            xDist -= param.horSideDistance
            xDist -= ((param.horHoleCount - 1) * param.horDistance) / 2


            Dim yDist As Double
            yDist = MainPlateLength() / 2 - param.verSideDistance - ((param.verHoleCount - 1) * param.verDistance) / 2

            For r As Integer = -1 To 1 Step 2
                For c As Integer = -1 To 1 Step 2

                    Dim pt As PsPoint = MathTool.GetPointInDirection(org, c * xDir, xDist)
                    pt = MathTool.GetPointInDirection(pt, r * yDir, yDist)
                    result.Add(pt)
                Next
            Next
            Return result
        End Function

        Public Function CreateDrill(oMat As PsMatrix, id As Long) As List(Of Integer)
            Dim result As New List(Of Integer)

            Dim centers As List(Of PsPoint) = CalHoleGroupCenters(oMat)

            Dim oDrill As New PsDrillObject
            oDrill.SetToDefaults()
            Dim xDir As New PsVector
            Dim ydir As New PsVector

            For Each center As PsPoint In centers
                oMat.getXAxis(xDir)
                oMat.getYAxis(ydir)
                oDrill.SetXYPlane(xDir, ydir)
                oDrill.SetLinearHoleField(param.owner.mHoleDia, param.horHoleCount.ToString() + "x" + param.horDistance.ToString(),
                                           param.verHoleCount.ToString() + "x" + param.verDistance.ToString())
                oDrill.SetInsertPoint(center)
                oDrill.SetHoleType(HoleType.kHoleNormal)
                oDrill.SetObjectId(id)
                oDrill.Apply()
                Dim modIndex As Integer = oDrill.GetModifyIndex()
                If (modIndex <> -1) Then
                    result.Add(modIndex)
                End If
            Next

            Return result
        End Function

        Public Sub Create()
            Dim mainPlateWidth As Double = Me.MainPlateWidth()
            Dim mainPlateLength As Double = Me.MainPlateLength()

            Dim oMainMat As PsMatrix = FirstMainPlateMatrix()
            Dim oMainMat2 As PsMatrix = SecondMainPlateMatrix()

            Dim id As Long = CreatePlate(mainPlateWidth, mainPlateLength, param.outSidePlateThickness, 0, 0, VerticalPosition.kTop, oMainMat)
            outsideSidePlates.Add(id)
            CreateDrill(oMainMat, id)

            id = CreatePlate(mainPlateWidth, mainPlateLength, param.outSidePlateThickness, 0, 0, VerticalPosition.kTop, oMainMat2)
            outsideSidePlates.Add(id)
            CreateDrill(oMainMat2, id)

            If (AccessoryPlateThickness() > 0) Then
                Dim xAxis As New PsVector
                oMainMat.getXAxis(xAxis)
                Dim yAxis As New PsVector
                oMainMat.getYAxis(yAxis)
                Dim org As New PsPoint
                Dim aMat As New PsMatrix

                oMainMat.getOrigin(org)
                org = MathTool.GetPointInDirection(org, -yAxis, gap / 2)
                aMat.SetCoordinateSystem(org, xAxis, yAxis)

                id = CreatePlate(mainPlateWidth, (mainPlateLength - gap) / 2,
                                 AccessoryPlateThickness, 0, (mainPlateLength - gap) / 4,
                                 VerticalPosition.kDown, aMat)
                accessorySidePlates.Add(id)
                CreateDrill(oMainMat, id)

                Dim xAxis2 As New PsVector
                oMainMat2.getXAxis(xAxis2)
                Dim yAxis2 As New PsVector
                oMainMat2.getYAxis(yAxis2)
                Dim org2 As New PsPoint
                Dim aMat2 As New PsMatrix

                oMainMat2.getOrigin(org2)
                org2 = MathTool.GetPointInDirection(org2, -yAxis2, gap / 2)
                aMat2.SetCoordinateSystem(org2, xAxis2, yAxis2)

                id = CreatePlate(mainPlateWidth, (mainPlateLength - gap) / 2,
                                 AccessoryPlateThickness, 0, (mainPlateLength - gap) / 4,
                                 VerticalPosition.kDown, aMat2)
                accessorySidePlates.Add(id)
                CreateDrill(oMainMat2, id)
            ElseIf (AccessoryPlateThickness() < 0) Then
                'this should not happen. so just omit it.
                'id = CreatePlate(mainPlateWidth, mainPlateLength / 2,
                '                 Math.Abs(AccessoryPlateThickness), 0, -mainPlateLength / 4,
                '                 VerticalPosition.kDown, oMainMat)
                'accessorySidePlates.Add(id)
                'CreateDrill(oMainMat, id)
                'id = CreatePlate(mainPlateWidth, mainPlateLength / 2,
                '                 Math.Abs(AccessoryPlateThickness), 0, -mainPlateLength / 4,
                '                 VerticalPosition.kDown, oMainMat2)
                'accessorySidePlates.Add(id)
                'CreateDrill(oMainMat2, id)
            End If


            AddInsidePlates(mainPlateWidth, mainPlateLength, oMainMat)
            AddInsidePlates(mainPlateWidth, mainPlateLength, oMainMat2)

        End Sub

        Private Sub AddInsidePlates(mainPlateWidth As Double, mainPlateLength As Double, oMainMat As PsMatrix)
            Dim org1 As New PsPoint
            Dim xAxis As New PsVector
            Dim yAxis As New PsVector
            Dim zAxis As New PsVector
            oMainMat.getOrigin(org1)
            oMainMat.getXAxis(xAxis)
            oMainMat.getYAxis(yAxis)
            oMainMat.getZAxis(zAxis)
            org1 = MathTool.GetPointInDirection(org1, zAxis, flangeThickness + AccessoryPlateThickness())
            oMainMat.SetCoordinateSystem(org1, xAxis, yAxis)
            Dim w As Double = (mainPlateWidth - param.FlangeThickness) / 2
            Dim pid As Long = CreatePlate(w, mainPlateLength, param.insidePlateThickness,
                                          w / 2 + param.FlangeThickness / 2, 0, VerticalPosition.kDown, oMainMat)
            insideSidePlates.Add(pid)
            CreateDrill(oMainMat, pid)

            pid = CreatePlate(w, mainPlateLength, param.insidePlateThickness,
                                         -w / 2 - param.FlangeThickness / 2, 0, VerticalPosition.kDown, oMainMat)
            insideSidePlates.Add(pid)
            CreateDrill(oMainMat, pid)
        End Sub

        Private Function AccessoryPlateThickness() As Double
            Dim thk As Double
            Dim shpAdpt As New ShapeAdapter(connectId)
            thk = sidePlateTopToCenterDistance - shpAdpt.Height / 2
            Return thk
        End Function

        Public Function SecondMainPlateMatrix() As PsMatrix

            Dim org As New PsPoint
            Dim yAxis As New PsVector
            Dim zAxis As New PsVector
            Dim xAxis As New PsVector

            Dim oMainMat As PsMatrix = FirstMainPlateMatrix()
            oMainMat.getOrigin(org)
            oMainMat.getXAxis(xAxis)
            oMainMat.getYAxis(yAxis)
            oMainMat.getZAxis(zAxis)

            org = MathTool.GetPointInDirection(org, zAxis, 2 * sidePlateTopToCenterDistance)
            oMainMat.SetCoordinateSystem(org, -xAxis, yAxis)

            Return oMainMat
        End Function

        Public Function FirstMainPlateMatrix() As PsMatrix
            Dim org As New PsPoint
            Dim yAxis As New PsVector
            Dim zAxis As New PsVector
            Dim xAxis As New PsVector
            Dim oMainMat As New PsMatrix

            baseMatrix.getOrigin(org)
            baseMatrix.getYAxis(yAxis)

            org = MathTool.GetPointInDirection(org, -yAxis, 0)
            baseMatrix.getZAxis(zAxis)
            Dim outSideOrg = MathTool.GetPointInDirection(org, zAxis, sidePlateTopToCenterDistance)
            zAxis.SetFromPoints(outSideOrg, org)
            zAxis.Normalize()
            xAxis.SetFromCrossProduct(yAxis, zAxis)
            xAxis.Normalize()
            oMainMat.SetCoordinateSystem(outSideOrg, xAxis, yAxis)

            Return oMainMat
        End Function

        Private Function MainPlateLength() As Double
            Dim result = 2 * param.verSideDistance + (param.verHoleCount - 1) * param.verDistance
            result *= 2
            result += gap
            Return result
        End Function

        Private Function MainPlateWidth() As Double

            Dim result = param.horSideDistance + param.horHoleCount * param.horDistance
            result *= 2

            'Dim shpAdpt As New ShapeAdapter(connectId)
            'Dim result As Double = shpAdpt.Width
            Return result
        End Function

        Private Function CreateAssessoryPlate(oMat As PsMatrix) As Integer
            Dim id As Integer

            Dim org As New PsPoint
            oMat.getOrigin(org)

            Dim xAxis As New PsVector
            oMat.getXAxis(xAxis)
            Dim yAxis As New PsVector
            oMat.getYAxis(yAxis)



            Return id
        End Function


    End Class

    Class WebConnectPlatesCreater
        Public webPlates As List(Of Integer)
        Public accessoryPlates As List(Of Integer)
        Private param As WebConnectPlateParameter
        Private arcPlateParam As ArcPlateParameter
        Private insertMatrix As PsMatrix

        Public Sub New(param As WebConnectPlateParameter,
                       arcParam As ArcPlateParameter,
                       oMat As PsMatrix)
            Me.param = param
            Me.arcPlateParam = arcParam
            insertMatrix = oMat
            webPlates = New List(Of Integer)
            accessoryPlates = New List(Of Integer)
        End Sub

        Public Function CalculateDrillCenter() As List(Of PsPoint)
            Dim result = New List(Of PsPoint)
            Dim xAxis As New PsVector
            insertMatrix.getXAxis(xAxis)

            Dim yAxis As New PsVector
            insertMatrix.getYAxis(yAxis)

            Dim org As New PsPoint
            insertMatrix.getOrigin(org)
            org = MathTool.GetPointInDirection(org, -yAxis, param.gap / 2)
            org = MathTool.GetPointInDirection(org, -xAxis,
                   arcPlateParam.width / 2 - param.boltGroupHorSideDist + param.webConnectPlateHorEdgeDist -
                   plateWidth() / 2)

            For c As Integer = 0 To 2
                For r As Integer = 0 To 1
                    Dim org1 As PsPoint = org
                    Dim dist As Double = param.boltGroupSpan + (param.webConnectPlateHorCount - 1) * param.webConnectPlateHorDist
                    org1 = MathTool.GetPointInDirection(org, xAxis, c * dist)
                    org1 = MathTool.GetPointInDirection(org1, Math.Pow(-1, r) * yAxis,
                               param.webConnectPlateInnerVerEdgeDist + param.gap / 2 +
                               (param.webConnectPlateVerCount - 1) * param.webConnectPlateVerDist / 2)
                    result.Add(org1)
                Next
            Next
            Return result
        End Function

        Public Function Create() As Boolean
            Dim result As Boolean = False
            Dim yAxis As New PsVector
            insertMatrix.getYAxis(yAxis)

            Dim org As New PsPoint
            insertMatrix.getOrigin(org)
            org = MathTool.GetPointInDirection(org, -yAxis, param.gap / 2)

            Dim xAxis As New PsVector
            insertMatrix.getXAxis(xAxis)

            Dim zAxis As New PsVector
            insertMatrix.getZAxis(zAxis)

            org = MathTool.GetPointInDirection(org, -xAxis,
                   arcPlateParam.width / 2 - param.boltGroupHorSideDist + param.webConnectPlateHorEdgeDist -
                   plateWidth() / 2)

            For i As Integer = 0 To arcPlateParam.innerWebCount

                CreatePlateOnOneSide(org, xAxis, yAxis, zAxis)
                CreatePlateOnOneSide(org, xAxis, yAxis, -zAxis)

                org = MathTool.GetPointInDirection(org, xAxis, (param.boltGroupSpan +
                                                   (param.webConnectPlateHorCount - 1) * param.webConnectPlateHorDist))
            Next

            Return result
        End Function


        Private Sub CreatePlateOnOneSide(org As PsPoint, xAxis As PsVector, yAxis As PsVector, zAxis As PsVector)
            Dim org1 As New PsPoint
            org1 = MathTool.GetPointInDirection(org, zAxis, arcPlateParam.thickness / 2 + param.webConnectPlateThickness / 2)
            Dim oMat1 As New PsMatrix
            oMat1.SetCoordinateSystem(org1, xAxis, yAxis)
            Dim id As Long = CreatePlate(plateWidth(), plateLength(), param.webConnectPlateThickness,
                         0, 0, VerticalPosition.kMiddle, oMat1)
            Debug.Assert(id > 0)
            webPlates.Add(id)

            Dim accessoryPlateThickness As Double = (arcPlateParam.thickness - param.connectMemberWebThickness) / 2
            Dim aId As Long
            If (accessoryPlateThickness > 0) Then
                Dim oAccessOrg As New PsPoint
                oAccessOrg = MathTool.GetPointInDirection(org, zAxis, param.connectMemberWebThickness / 2 + param.webConnectPlateThickness / 2)
                Dim oAccessMat As New PsMatrix
                oAccessMat.SetCoordinateSystem(oAccessOrg, xAxis, yAxis)
                aId = CreatePlate(plateWidth(), plateLength() / 2, accessoryPlateThickness,
                                               0, plateLength() / 4, VerticalPosition.kMiddle, oAccessMat)
                Debug.Assert(aId > 0)
                accessoryPlates.Add(aId)
            End If

            Dim center As New PsPoint
            center = org1
            center = MathTool.GetPointInDirection(org1, yAxis,
                           param.webConnectPlateInnerVerEdgeDist + param.gap / 2 +
                           (param.webConnectPlateVerCount - 1) * param.webConnectPlateVerDist / 2)
            CreateDrill(id, xAxis, yAxis, center)
            CreateDrill(aId, xAxis, yAxis, center)

            center = MathTool.GetPointInDirection(org1, -yAxis,
                           param.webConnectPlateInnerVerEdgeDist + param.gap / 2 +
                           (param.webConnectPlateVerCount - 1) * param.webConnectPlateVerDist / 2)
            CreateDrill(id, xAxis, yAxis, center)
            CreateDrill(aId, xAxis, yAxis, center)

        End Sub

        Public Function CreateDrill(id As Long, xAxis As PsVector, yAxis As PsVector, center As PsPoint) As Integer
            Dim oDrill As New PsDrillObject
            oDrill.SetToDefaults()
            oDrill.SetXYPlane(xAxis, yAxis)
            oDrill.SetInsertPoint(center)
            oDrill.SetLinearHoleField(param.owner.mHoleDia, param.webConnectPlateHorCount.ToString() + "x" +
                                           param.webConnectPlateHorDist.ToString(),
                                           param.webConnectPlateVerCount.ToString() + "x" +
                                           param.webConnectPlateVerDist.ToString())
            oDrill.SetXOffset(0)
            oDrill.SetYOffset(0)
            oDrill.SetHoleBoltType(HoleBoltType.kHoleBoltNormal)
            oDrill.SetObjectId(id)
            oDrill.Apply()

            Dim result As Integer = oDrill.GetModifyIndex()

            Return result

        End Function

        Private Function plateLength() As Double
            Dim result As Double = 2 * (param.webConnectPlateInnerVerEdgeDist + param.webConnectPlateVerEdgeDist +
                (param.webConnectPlateVerCount - 1) * param.webConnectPlateVerDist) +
                param.gap
            Return result
        End Function

        Private Function plateWidth() As Double
            Dim result As Double = (param.webConnectPlateHorCount - 1) * param.webConnectPlateHorDist +
                                        2 * param.webConnectPlateHorEdgeDist
            Return result
        End Function
    End Class

    Class ArcPlatesCreator
        Public webPlates As List(Of Integer)
        Public mainPlate As Integer

        Private param As ArcPlateParameter
        Private insertMatrix As PsMatrix

        Public Sub New(plateDef As ArcPlateParameter, oMat As PsMatrix)
            webPlates = New List(Of Integer)
            mainPlate = -1
            param = plateDef
            insertMatrix = oMat
        End Sub

        Public Function Create() As Boolean

            CreateMainPlate()
            CreateWebPlates()

            Dim cutX As New PsVector
            Dim cutY As New PsVector
            Dim cutZ As New PsVector
            Dim cutOrg As New PsPoint

            insertMatrix.getXAxis(cutX)
            insertMatrix.getYAxis(cutY)
            insertMatrix.getZAxis(cutZ)
            insertMatrix.getOrigin(cutOrg)

            Dim dy As Double = param.radius * Math.Cos(MathTool.Degrees2Radians(param.angle))
            cutOrg = MathTool.GetPointInDirection(cutOrg, cutY, param.length + dy)

            Dim cutMat As New PsMatrix
            cutMat.SetCoordinateSystem(cutOrg, cutX, cutY)

            Dim cutPoly As PsPolygon = CutArcPolygon()
            'cutPoly.DrawAsPolyline(0, 0, 2)

            Dim cutId As Integer = DoPolyCut(mainPlate, 4 * param.innerWebHeight,
                       MathTool.GetPointInDirection(cutOrg, -cutZ, 2 * param.innerWebHeight),
                       cutX, cutY, cutPoly)
            Debug.Assert(cutId >= 0)

            For Each webId As Long In webPlates
                cutId = DoPolyCut(webId, 4 * param.innerWebHeight,
                       MathTool.GetPointInDirection(cutOrg, -cutZ, 2 * param.innerWebHeight),
                       cutX, cutY, cutPoly)
                Debug.Assert(cutId >= 0)
            Next

            Return True
        End Function

        Private Sub CreateMainPlate()
            mainPlate = CreatePlate(param.width, param.length, param.thickness, 0, -param.length / 2, VerticalPosition.kMiddle, insertMatrix)
            Debug.Assert(mainPlate > 0)
        End Sub

        Private Sub CreateWebPlates()
            Dim webX As New PsVector
            Dim webY As New PsVector
            Dim webZ As New PsVector
            Dim webOrg As New PsPoint

            insertMatrix.getYAxis(webX)
            insertMatrix.getZAxis(webY)
            insertMatrix.getXAxis(webZ)

            insertMatrix.getOrigin(webOrg)
            webOrg = MathTool.GetPointInDirection(webOrg, webZ, param.width / 2 - param.innerWebDist)
            Dim webGap As Long = (param.width - 2 * param.innerWebDist) / (param.innerWebCount - 1)

            For i As Integer = 0 To param.innerWebCount - 1
                Dim webMat As New PsMatrix
                webMat.SetCoordinateSystem(webOrg, webX, webY)
                Dim webId As Long = CreatePlate(param.length, param.innerWebHeight, param.innerWebThickness, -param.length / 2, 0, VerticalPosition.kMiddle, webMat)
                Debug.Assert(webId > 0)
                webPlates.Add(webId)
                webOrg = MathTool.GetPointInDirection(webOrg, -webZ, webGap)
            Next

            Debug.Assert(webPlates.Count = param.innerWebCount)
        End Sub

        Private Function CutArcPolygon() As PsPolygon
            Dim oPoly As New PsPolygon
            oPoly.createCircle(param.radius)
            Return oPoly
        End Function

    End Class

    Class SidePlateCreator
        Public sidePlateId As Long
        Private data As Parameters
        Private supportId As Long
        Private insertMat As PsMatrix
        Private oPoly As PsPolygon

        Public Sub New(data As Parameters, supportId As Long, oMat As PsMatrix, oPoly As PsPolygon)
            Me.data = data
            Me.supportId = supportId
            Me.insertMat = oMat
            Me.oPoly = oPoly
        End Sub

        Public Function Create(pos As VerticalPosition) As Long
            Dim oCreater As New PsCreatePlate
            oCreater.SetToDefaults()
            oCreater.SetInsertMatrix(insertMat)
            oCreater.SetNormalPosition(pos)
            oCreater.SetThickness(data.mPlateThickness)
            oCreater.SetFromPolygon(oPoly)

            If oCreater.Create() = False Then
                Return -1
            End If
            sidePlateId = oCreater.ObjectId
            Return sidePlateId
        End Function

    End Class


    Private Shared Function CalculatePositiveXSidePlateMatrix(data As Parameters, supportId As Long, connMat As PsMatrix) As PsMatrix
        Dim org As New PsPoint
        connMat.getOrigin(org)

        Dim xAxis As New PsVector
        connMat.getXAxis(xAxis)

        Dim yAxis As New PsVector
        connMat.getYAxis(yAxis)
        org = MathTool.GetPointInDirection(org, xAxis, New ShapeAdapter(supportId).Width / 2 +
                                           data.mPlateThickness - data.mMainChordPlateThickness)

        connMat.getZAxis(xAxis)
        Dim insMat As New PsMatrix()
        insMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return insMat
    End Function

    Private Shared Function CreateRightPlate(data As Parameters, supportId As Long, connMat As PsMatrix, oPoly As PsPolygon) As Long
        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()

        Dim insMat As PsMatrix = CalculateNegtiveXSidePlateMatrix(data, supportId, connMat)
        oCreater.SetInsertMatrix(insMat)
        oCreater.SetNormalPosition(VerticalPosition.kTop)
        oCreater.SetThickness(data.mPlateThickness)
        oCreater.SetFromPolygon(oPoly)
        Dim newId As Long
        If oCreater.Create() = False Then
            Return -1
        End If
        newId = oCreater.ObjectId
        Return newId
    End Function

    Private Shared Function CalculateNegtiveXSidePlateMatrix(data As Parameters, supportId As Long, connMat As PsMatrix) As PsMatrix
        Dim org As New PsPoint
        connMat.getOrigin(org)

        Dim xAxis As New PsVector
        connMat.getXAxis(xAxis)

        Dim yAxis As New PsVector
        connMat.getYAxis(yAxis)
        org = MathTool.GetPointInDirection(org, -xAxis, New ShapeAdapter(supportId).Width / 2 +
                                           data.mPlateThickness - data.mMainChordPlateThickness)

        connMat.getZAxis(xAxis)
        Dim insMat As New PsMatrix()
        insMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return insMat
    End Function

    Private Function CreateSidePlateProfile(data As Parameters,
                                       supportId1 As Long,
                                       supportId2 As Long,
                                       connectingId1 As Long,
                                       connectingId2 As Long,
                                       columnId As Long,
                                       connMat1 As PsMatrix,
                                       connMat2 As PsMatrix,
                                       instPt1 As PsPoint,
                                       instPt2 As PsPoint) As PsPolygon

        Dim bottomHalf As List(Of PsPoint) = GetBottomHalfPlateProfile(data, supportId1, supportId2, connectingId1, connectingId2, connMat1, connMat2)

        Dim zDir1 As New PsVector
        Dim zDir2 As New PsVector

        connMat1.getZAxis(zDir1)
        connMat2.getZAxis(zDir2)

        Dim oPoly As New PsPolygon
        oPoly.init()

        Dim transMat As PsMatrix = ConvertConnectionMatToSidePlateInsertMat(connMat1)
        Utility.TransformPointListToPolygon(bottomHalf, oPoly, transMat)

        SetFirstBottomFillet(oPoly, data.mBottomFillet1)
        SetSecondBottomFillet(oPoly, data.mBottomFillet2)

        Dim TopHalf As New List(Of PsPoint)
        GetTopHalfProfileWithTopColumn(data, supportId1, supportId2,
                                       columnId,
                                       connMat1, connMat2, instPt1, instPt2, TopHalf)

        Dim oPoly2 As New PsPolygon
        oPoly2.init()
        Utility.TransformPointListToPolygon(TopHalf, oPoly2, transMat)
        FilletPolyBetween(0, 1, 2, 3, oPoly2, data.mTopFillet1)
        FilletPolyBetween(4, 5, 6, 7, oPoly2, data.mTopFillet2)

        oPoly.append(oPoly2, True, PRECISION)

        oPoly.draw(CoordSystem.kWcs, "0", "0", 1)

        Return oPoly
    End Function



    Private Shared Sub SetFirstBottomFillet(oPoly As PsPolygon, r As Double)
        FilletPolyBetween(1, 2, 3, 4, oPoly, r)
    End Sub

    Private Shared Sub SetSecondBottomFillet(oPoly As PsPolygon, r As Double)
        FilletPolyBetween(9, 10, 11, 12, oPoly, r)
    End Sub

    Private Shared Function ConvertConnectionMatToSidePlateInsertMat(connMat As PsMatrix) As PsMatrix
        Dim transMat As New PsMatrix
        Dim transX As New PsVector
        Dim transY As New PsVector
        Dim transOrg As New PsPoint
        connMat.getOrigin(transOrg)
        connMat.getZAxis(transX)
        connMat.getYAxis(transY)

        transMat.SetCoordinateSystem(transOrg, transX, transY)
        Return transMat
    End Function

    Private Shared Sub GetTopHalfProfileWithTopColumn(data As Parameters,
                                                         supportId1 As Long, supportId2 As Long,
                                                         columnId As Long,
                                                         connMat1 As PsMatrix, connMat2 As PsMatrix,
                                                         instPt1 As PsPoint, instPt2 As PsPoint, TopHalf As List(Of PsPoint))
        Dim org2 As New PsPoint
        Dim yAxis2 As New PsVector
        Dim zAxis2 As New PsVector

        connMat2.getOrigin(org2)
        connMat2.getZAxis(zAxis2)
        connMat2.getYAxis(yAxis2)

        Dim dist As Double = MathTool.GetDistanceBetween(instPt1, instPt2)
        Dim spt As PsPoint
        spt = MathTool.GetPointInDirection(org2, -zAxis2, data.mSupport2CutBack)
        spt = MathTool.GetPointInDirection(spt, yAxis2, New ShapeAdapter(supportId2).Height / 2)

        Dim org1 As New PsPoint
        Dim yAxis1 As New PsVector
        Dim zAxis1 As New PsVector

        connMat1.getOrigin(org1)
        connMat1.getZAxis(zAxis1)
        connMat1.getYAxis(yAxis1)
        Dim ept As PsPoint
        ept = MathTool.GetPointInDirection(org1, -zAxis1, data.mSupport1CutBack)
        ept = MathTool.GetPointInDirection(ept, yAxis1, New ShapeAdapter(supportId1).Height / 2)

        Dim mPt As New PsPoint
        If MathTool.IntersectLineWithLine(spt, MathTool.GetPointInDirection(spt, -zAxis2, 10),
                                        ept, MathTool.GetPointInDirection(ept, zAxis1, 10), 0, mPt) = False Then
            Debug.Assert(False)
            TopHalf.Add(ept)
            Return
        End If

        'now we have spt, mpt and ept  at the
        'bottom of the top half

        Dim upperPoints As List(Of PsPoint) =
            GetTopHalfSidePlateBooleanCutBoundary(data, supportId2, columnId)

        Debug.Assert(upperPoints.Count = 4)

        For Each ppt As PsPoint In upperPoints
            drawBall(ppt, 100)
        Next

        Dim inst1 As New PsPoint
        If MathTool.IntersectLineWithLine(spt, mPt, upperPoints(0), upperPoints(1), 0, inst1) = False Then
            Debug.Assert(False)
        End If

        Dim inst2 As New PsPoint
        If MathTool.IntersectLineWithLine(ept, mPt, upperPoints(2), upperPoints(3), 0, inst2) = False Then
            Debug.Assert(False)
        End If

        Dim newEndPt As New PsPoint
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        xAxis.SetFromPoints(inst1, spt)
        yAxis.SetFromPoints(inst1, upperPoints(1))

        xAxis.Normalize()
        yAxis.Normalize()

        Dim zAxis As New PsVector
        zAxis.SetFromCrossProduct(xAxis, yAxis)

        GeoHelper.RotateLineByStart(upperPoints(1), inst1, data.mTopAngle1,
                                     zAxis, newEndPt)

        Dim pts1 As List(Of PsPoint) = GeoHelper.FilletTwoLine(spt, mPt, upperPoints(1), newEndPt, data.mTopFillet1)

        Dim newEndPt2 As New PsPoint
        GeoHelper.RotateLineByStart(upperPoints(2), inst2, -data.mBottomAngle2,
                                    zAxis, newEndPt2)
        Dim pts2 As List(Of PsPoint) = GeoHelper.FilletTwoLine(ept, mPt,
                                                               upperPoints(2), newEndPt2, data.mTopFillet2)

        TopHalf.Add(spt)
        TopHalf.Add(pts1(0))
        TopHalf.Add(pts1(1))
        TopHalf.Add(upperPoints(1))
        TopHalf.Add(upperPoints(2))
        TopHalf.Add(pts2(1))
        TopHalf.Add(pts2(0))
        TopHalf.Add(ept)

        'For Each pt As PsPoint In TopHalf
        '    Utility.drawBall(pt, 80)
        'Next

    End Sub

    Private Function GetBottomHalfPlateProfile(data As Parameters,
                                               supportId1 As Long, supportId2 As Long,
                                               connectingId1 As Long, connectingId2 As Long,
                                               connMat1 As PsMatrix, connMat2 As PsMatrix) As List(Of PsPoint)
        Dim ls1 As New PsPoint
        Dim ls2 As New PsPoint
        GetSupportPointsInOrder(supportId1, connMat1, True, ls1, ls2)

        Dim lc1 As New PsPoint
        Dim lc2 As New PsPoint
        GetConnectingPointsInOrder(connectingId1, connMat1, lc1, lc2)

        Dim leftBoundary As List(Of PsPoint) = GetPlateBoundaryBetweenLines(ls1, ls2,
                                               data.mSupport1CutBack,
                                               New ShapeAdapter(supportId1).Height, data.mBottomAngle1,
                                               lc1, lc2,
                                               data.mConnect1CutBack,
                                               New ShapeAdapter(connectingId1).Width, data.mBottomAngle2, data.mBottomFillet1)

        Dim rs1 As New PsPoint
        Dim rs2 As New PsPoint
        GetSupportPointsInOrder(supportId2, connMat2, True, rs1, rs2)


        Dim rc1 As New PsPoint
        Dim rc2 As New PsPoint
        GetConnectingPointsInOrder(connectingId2, connMat2, rc1, rc2)
        Dim rightBoundary As List(Of PsPoint) = GetPlateBoundaryBetweenLines(rs1, rs2,
                                               data.mSupport2CutBack,
                                               New ShapeAdapter(supportId2).Height, data.mBottomAngle4,
                                               rc1, rc2,
                                               data.mConnect2CutBack,
                                               New ShapeAdapter(connectingId2).Width, data.mBottomAngle3, data.mBottomFillet2)

        Dim middleBounary As List(Of PsPoint) = GetDriectConnectedPlateBoundaryBetweenLines(
                                                lc1, lc2, data.mConnect1CutBack,
                                                New ShapeAdapter(connectingId1).Width,
                                                rc1, rc2, data.mConnect2CutBack,
                                                New ShapeAdapter(connectingId2).Width)

        'combine the bottom 3 parts together
        leftBoundary.AddRange(middleBounary)
        rightBoundary.Reverse()
        leftBoundary.AddRange(rightBoundary)
        Return leftBoundary
    End Function

    Private Sub GetConnectingPointsInOrder(id As Long, oMat As PsMatrix, ByRef spt As PsPoint, ByRef ept As PsPoint)
        Dim org As New PsPoint
        oMat.getOrigin(org)

        Dim adpt As New ShapeAdapter(id)
        Debug.Assert(GeoHelper.IsOnTheSameSide(adpt.MidLineStart, adpt.MidLineMid, org) = True)

        If adpt.GetEndSideTo(org) = 1 Then
            'ept---spt--org
            spt = adpt.MidLineEnd
            ept = adpt.MidLineMid
        Else
            'spt--ept--org
            spt = adpt.MidLineStart
            ept = adpt.MidLineMid
        End If
    End Sub

    ''' <summary>
    ''' "normalize the" spt,ept make sure they
    ''' are on the same side of the org point of the oMat 
    ''' and along the z axis of the matrix. 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="oMat"></param>
    ''' <param name="spt"></param>
    ''' <param name="ept"></param>
    Private Sub GetSupportPointsInOrder(id As Long, oMat As PsMatrix,
                                        firstHalf As Boolean,
                                        ByRef spt As PsPoint, ByRef ept As PsPoint)
        Dim adpt As New ShapeAdapter(id)
        Dim vec As New PsVector
        vec.SetFromPoints(adpt.MidLineStart, adpt.MidLineEnd)
        vec.Normalize()
        Dim zaxis As New PsVector
        oMat.getZAxis(zaxis)

        If (Not firstHalf) Then
            zaxis = -zaxis
        End If

        Debug.Assert(IsInSameDirection(New PsVector(1, 0, 0), New PsVector(1, 0, 0)))
        Debug.Assert(IsInSameDirection(New PsVector(-1, 0, 0), New PsVector(-1, 0, 0)))
        Debug.Assert(IsInSameDirection(New PsVector(-1, 0, 0), New PsVector(1, 0, 0)) = False)
        Debug.Assert(IsInSameDirection(New PsVector(0, 1, 0), New PsVector(0, 1, 0)))
        Debug.Assert(IsInSameDirection(New PsVector(0, -1, 0), New PsVector(0, -1, 0)))
        Debug.Assert(IsInSameDirection(New PsVector(0, 1, 0), New PsVector(0, -1, 0)) = False)

        'spt---ept---org
        If IsInSameDirection(vec, zaxis) Then
            spt = adpt.MidLineStart
            oMat.getOrigin(ept)
            ept = MathTool.GetPointInDirection(ept, zaxis, MathTool.GetDistanceBetween(spt, ept) / 2)
        Else
            'ept---spt---org
            spt = adpt.MidLineEnd
            oMat.getOrigin(ept)
            ept = MathTool.GetPointInDirection(ept, -zaxis, MathTool.GetDistanceBetween(spt, ept) / 2)
        End If
    End Sub

    Private Function CutSupportRightSide(oMat As PsMatrix, supportId As Long,
                                         oData As Parameters,
                                         instPt1 As PsPoint,
                                         instPt2 As PsPoint,
                                         isFirstPair As Boolean) As Integer
        Dim oAdpt As New ShapeAdapter(supportId)
        Dim width = oAdpt.Width
        Dim cutHeight = oAdpt.Height + 2 * oData.mMainChordPlateThickness

        Dim oStart As New PsPoint
        oMat.getOrigin(oStart)
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getXAxis(xAxis)
        oMat.getYAxis(yAxis)
        oMat.getZAxis(zAxis)

        If (isFirstPair) Then
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mSupport1CutBack)
        Else
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mSupport2CutBack)
        End If

        oStart = MathTool.GetPointInDirection(oStart, xAxis, width / 2 - oData.mMainChordPlateThickness)
        oStart = MathTool.GetPointInDirection(oStart, -yAxis, cutHeight / 2)

        Dim polyLength As Double = oData.mSupport1CutBack +
                             MathTool.GetDistanceBetween(instPt1, instPt2) +
                             oData.mSupport2CutBack
        Dim polyWidth As Double = 2 * oData.mMainChordPlateThickness

        Dim oPoly As New PsPolygon
        oPoly.appendVertex(0, 0, 0)
        oPoly.appendVertex(polyLength, 0, 0)
        oPoly.appendVertex(polyLength, polyWidth, 0)
        oPoly.appendVertex(0, polyWidth, 0)
        oPoly.appendVertex(0, 0, 0)

        Return DoPolyCut(supportId, cutHeight, oStart, zAxis, xAxis, oPoly)
    End Function

    Private Shared Function DoPolyCut(supportId As Long, cutHeight As Double,
                                      oStart As PsPoint,
                                      xAxis As PsVector,
                                      yAxis As PsVector, oPoly As PsPolygon) As Integer
        Dim oCut As New PsCutObjects
        oCut.SetAsPolyCut(oPoly, oStart, xAxis, yAxis, cutHeight)
        oCut.SetObjectId(supportId)

        Dim result As Long = -1
        If oCut.Apply() > 0 Then
            result = oCut.GetModifyIndex()
        End If
        Return result
    End Function

    Private Function CutSupportLeftSide(oMat As PsMatrix, supportId As Long,
                                         oData As Parameters,
                                         instPt1 As PsPoint,
                                         instPt2 As PsPoint,
                                         isFirstPair As Boolean) As Integer
        Dim oAdpt As New ShapeAdapter(supportId)
        Dim width = oAdpt.Width
        Dim cutHeight = oAdpt.Height + 2 * oData.mMainChordPlateThickness

        Dim oStart As New PsPoint
        oMat.getOrigin(oStart)
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getXAxis(xAxis)
        oMat.getYAxis(yAxis)
        oMat.getZAxis(zAxis)

        If isFirstPair = True Then
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mSupport1CutBack)
        Else
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mSupport2CutBack)
        End If

        oStart = MathTool.GetPointInDirection(oStart, -xAxis, width / 2 - oData.mMainChordPlateThickness)
        oStart = MathTool.GetPointInDirection(oStart, -yAxis, cutHeight / 2)

        Dim polyLength As Double = oData.mSupport1CutBack +
                             MathTool.GetDistanceBetween(instPt1, instPt2) +
                             oData.mSupport2CutBack
        Dim polyWidth As Double = 2 * oData.mMainChordPlateThickness

        Dim oPoly As New PsPolygon
        oPoly.appendVertex(0, 0, 0)
        oPoly.appendVertex(polyLength, 0, 0)
        oPoly.appendVertex(polyLength, polyWidth, 0)
        oPoly.appendVertex(0, polyWidth, 0)
        oPoly.appendVertex(0, 0, 0)

        Return DoPolyCut(supportId, cutHeight, oStart, zAxis, -xAxis, oPoly)
    End Function


    Private Function CutSupportShapeSidePlate(oMat As PsMatrix, supportId As Long,
                                              oData As Parameters,
                                              instPt1 As PsPoint,
                                              instPt2 As PsPoint,
                                              isFirstPair As Boolean) As List(Of Integer)
        Dim oResult As New List(Of Integer)
        oResult.Add(CutSupportRightSide(oMat, supportId, oData, instPt1, instPt2, isFirstPair))
        oResult.Add(CutSupportLeftSide(oMat, supportId, oData, instPt1, instPt2, isFirstPair))
        Return oResult
    End Function

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

            'oAdpt.ReadAddtionalObjects()
            'oAdpt.ReadCreatedObjectArray()

            Dim oTrans As New PsTransaction
            Dim oConnection As PsConnection = Nothing
            Dim oEdit As New PsEditModification

            Try
                oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, oConnection)
                If oConnection IsNot Nothing Then

                    oConnection = RemoveModifications(oConnection)

                    oConnection.RemoveAllAdditionalEntity(False)

                    'now remove the new created left/right plate
                    For i As Integer = oConnection.ArrayCreatedEntityCount(0) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(0, i)
                    Next

                    'now remove the new created connecting main plate
                    For i As Integer = oConnection.ArrayCreatedEntityCount(1) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(1, i)
                    Next

                    'now remove the new created connecting inner plates
                    For i As Integer = oConnection.ArrayCreatedEntityCount(2) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(2, i)
                    Next

                    'now remove the new created side plates for connect member 1
                    For i As Integer = oConnection.ArrayCreatedEntityCount(3) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(3, i)
                    Next

                    'now remove the new created side plates for connect member 2
                    For i As Integer = oConnection.ArrayCreatedEntityCount(4) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(4, i)
                    Next

                    'now remove the new created web plates for connect member 1
                    For i As Integer = oConnection.ArrayCreatedEntityCount(5) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(5, i)
                    Next

                    'now remove the new created web plates for connect member 2
                    For i As Integer = oConnection.ArrayCreatedEntityCount(6) - 1 To 0 Step -1
                        oConnection.RemoveArrayCreatedObjectId(6, i)
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

    Private Shared Function RemoveModifications(oConnection As PsConnection) As PsConnection
        Dim param As New Parameters
        param.ReadFromConnection(oConnection)

        Dim support1 As Long = oConnection.AdditionalObjectId(0)
        Dim support2 As Long = oConnection.AdditionalObjectId(1)

        Dim columnId As Long = oConnection.AdditionalObjectId(4)

        Dim oModify As New PsEditModification

        If (param.mFirstLeftCutIndex <> -1) Then
            oModify.SetObjectId(support1)
            oModify.DeletePolyCut(param.mFirstLeftCutIndex)
        End If

        If (param.mFirstRightCutIndex <> -1) Then
            oModify.SetObjectId(support1)
            oModify.DeletePolyCut(param.mFirstRightCutIndex)
        End If

        If (param.mSecondLeftCutIndex <> -1) Then
            oModify.SetObjectId(support2)
            oModify.DeletePolyCut(param.mSecondLeftCutIndex)
        End If

        If (param.mSecondRightcutIndex <> -1) Then
            oModify.SetObjectId(support2)
            oModify.DeletePolyCut(param.mSecondRightcutIndex)
        End If

        If (param.mColumnCutIndex <> -1) Then
            oModify.SetObjectId(columnId)
            oModify.DeleteCutPlane(param.mColumnCutIndex)
        End If

        If (param.mColumnBoolCutIndex1 <> -1) Then
            oModify.SetObjectId(columnId)
            oModify.DeleteSubBody(param.mColumnBoolCutIndex1)
        End If
        If (param.mColumnBoolCutIndex2 <> -1) Then
            oModify.SetObjectId(columnId)
            oModify.DeleteSubBody(param.mColumnBoolCutIndex2)
        End If
        If (param.mColumnBoolCutIndex3 <> -1) Then
            oModify.SetObjectId(columnId)
            oModify.DeleteSubBody(param.mColumnBoolCutIndex3)
        End If
        If (param.mColumnBoolCutIndex4 <> -1) Then
            oModify.SetObjectId(columnId)
            oModify.DeleteSubBody(param.mColumnBoolCutIndex4)
        End If

        Dim connectId1 As Long = oConnection.AdditionalObjectId(2)
        Dim connectId2 As Long = oConnection.AdditionalObjectId(3)

        If (param.mFirstCutBackCutIndex <> -1) Then
            oModify.SetObjectId(connectId1)
            oModify.DeleteCutPlane(param.mFirstCutBackCutIndex)
        End If
        If (param.mSecondCutBackCutIndex <> -1) Then
            oModify.SetObjectId(connectId2)
            oModify.DeleteCutPlane(param.mSecondCutBackCutIndex)
        End If

        For Each mid As Integer In param.mSideConnectPlate1.drillModifyIndices
            If (mid <> -1) Then
                oModify.SetObjectId(connectId1)
                oModify.DeleteHoleField(mid)
            End If
        Next

        For Each mid As Integer In param.mSideConnectPlate2.drillModifyIndices
            If (mid <> -1) Then
                oModify.SetObjectId(connectId2)
                oModify.DeleteHoleField(mid)
            End If
        Next

        oModify.SetObjectId(connectId1)
        For Each modId As Integer In param.mWebConnectPlate1.webConnectDrillModifyIds
            If (modId <> -1) Then
                oModify.DeleteHoleField(modId)
            End If
        Next

        oModify.SetObjectId(connectId2)
        For Each modId As Integer In param.mWebConnectPlate2.webConnectDrillModifyIds
            If (modId <> -1) Then
                oModify.DeleteHoleField(modId)
            End If
        Next

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

        Dim supportingShape1 As Long
        Do
            supportingShape1 = Selection.PickObject(RSS.RSS("M0000"))
            If supportingShape1 <= 0 Then Return 0
        Loop Until (IsWeldShape(supportingShape1))

        Dim supportingShape2 As Long
        Do
            supportingShape2 = Selection.PickObject(RSS.RSS("M0001"))
            If supportingShape2 <= 0 Then Return 0
        Loop Until (IsWeldShape(supportingShape2))

        Dim connectingShape1 As Long
        Do
            connectingShape1 = Selection.PickObject(RSS.RSS("M0002"))
            If connectingShape1 <= 0 Then Return 0
        Loop Until (IsWeldShape(connectingShape1))

        Dim connectingShape2 As Long
        Do
            connectingShape2 = Selection.PickObject(RSS.RSS("M0003"))
            If connectingShape2 <= 0 Then Return 0
        Loop Until (IsWeldShape(connectingShape2))

        Dim supportingColumn As Long
        Do
            supportingColumn = Selection.PickObject(RSS.RSS("M0004"))
            If supportingColumn <= 0 Then Return 0
        Loop Until (IsWeldShape(supportingColumn))
        Dim oCreateConnection As New PsCreateConnection

        IsCreatingConn = True

        oCreateConnection.SetIdentifier(PLUGIN_IDENTIFIER)
        oCreateConnection.SetDescription(PLUGIN_DESCRIPTION)
        If (oCreateConnection.Create()) Then
            ConnectionId = oCreateConnection.ObjectId
        End If

        Dim connAdpt As New ConnectionAdapter(ConnectionId)
        connAdpt.SetBuilt(False)
        connAdpt.AppendAdditionalObjectId(supportingShape1)
        connAdpt.AppendAdditionalObjectId(supportingShape2)
        connAdpt.AppendAdditionalObjectId(connectingShape1)
        connAdpt.AppendAdditionalObjectId(connectingShape2)
        connAdpt.AppendAdditionalObjectId(supportingColumn)
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