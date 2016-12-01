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

    ''' <summary>
    ''' get the intersect point and usc defined by the input supportId and
    ''' connectId. 
    ''' </summary>
    ''' <param name="supportId"></param>
    ''' <param name="connectId"></param>
    ''' <param name="instPt"></param>
    ''' <param name="connUcs"></param>
    ''' <returns></returns>
    Private Function GetIntersectPtAndUcs(supportId As Long, connectId As Long,
                                          ByRef instPt As PsPoint, ByRef connUcs As PsMatrix) As Boolean
        Dim MathTool As New PsGeometryFunctions
        Dim supportAdpt As New ShapeAdapter(supportId)
        Dim connectAdpt As New ShapeAdapter(connectId)

        If MathTool.IntersectLineWithLine(supportAdpt.MidLineStart, supportAdpt.MidLineEnd,
                                                   connectAdpt.MidLineStart, connectAdpt.MidLineEnd, 4, instPt) = False Then
            Return False
        End If
        Dim pt1 As PsPoint = MathTool.OrthoProjectPointToLine(connectAdpt.MidLineMid,
                                                              supportAdpt.MidLineStart,
                                                              supportAdpt.MidLineEnd)
        Dim yAxis As New PsVector
        yAxis.SetFromPoints(connectAdpt.MidLineMid, pt1)

        Dim zAxis As New PsVector
        If supportAdpt.GetEndSideTo(instPt) = 1 Then
            zAxis.SetFromPoints(supportAdpt.MidLineEnd, supportAdpt.MidLineStart)
        Else
            zAxis.SetFromPoints(supportAdpt.MidLineStart, supportAdpt.MidLineMid)
        End If

        zAxis.Normalize() : yAxis.Normalize()
        Dim xAxis As New PsVector
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        connUcs.SetCoordinateSystem(instPt, xAxis, yAxis)
        Return True
    End Function

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

        If GetIntersectPtAndUcs(supportId1, connectId1, instPt1, connUcs1) = False Then
            Return False
        End If

        If GetIntersectPtAndUcs(supportId2, connectId2, instPt2, connUcs2) = False Then
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

            If (supportingId1 <= 0 Or supportingId2 <= 0 Or
                    connectingId1 <= 0 Or connectingId2 <= 0) Then
                Debug.Assert(False)
                Return
            End If

            'execute creation
            If oConnAdpt.IsBuilt Then
                'recoverOriginSupporingShape(oConnAdpt)
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

            Dim firstConnectingCutId As Long = CutShapeInwards(connectingId1, instPt1, data.mConnect1CutBack)
            Dim secondConnectingCutId As Long = CutShapeInwards(connectingId2, instPt2, data.mConnect2CutBack)

            Dim oPoly As PsPolygon = CreateSidePlateProfile(data,
                                                            supportingId1, supportingId2,
                                                            connectingId1, connectingId2,
                                                            connMat1, connMat2, instPt1, instPt2)
            Dim dist As Double = MathTool.GetDistanceBetween(instPt1, instPt2)

            Dim leftPlateId As Long = CreateLeftPlate(data, supportingId1, connMat1, oPoly)
            Dim rightPlateId As Long = CreateRightPlate(data, supportingId1, connMat1, oPoly)


            Dim ConnectPlatesCreater1 As New ConnectPlatesCreator(data.mConnectPlate1,
                                                     GetConnectPlateInsertMatrix(data.mConnectPlate1, connectingId1, instPt1))
            ConnectPlatesCreater1.Create()
            Dim ConnectPlatesCreater2 As New ConnectPlatesCreator(data.mConnectPlate2,
                                                     GetConnectPlateInsertMatrix(data.mConnectPlate2, connectingId2, instPt2))
            ConnectPlatesCreater2.Create()

            Dim SideConnectPlatesCreater1 As New SideConnectPlatesCreater(supportingId1, connectingId1, data.mSideConnectPlate1,
                        SidePlateTopToCenterDistance(data, supportingId1),
                        (New ShapeAdapter(connectingId1).Height - data.mConnectPlate1.width) / 2,
                        data.mConnectPlate1.gap,
                        GetSideConnectPlatesMatrix(data.mSideConnectPlate1, connectingId1, instPt1))
            SideConnectPlatesCreater1.Create()

            Dim SideConnectPlatesCreater2 As New SideConnectPlatesCreater(supportingId2, connectingId2, data.mSideConnectPlate2,
                        SidePlateTopToCenterDistance(data, supportingId2),
                        (New ShapeAdapter(connectingId2).Height - data.mConnectPlate2.width) / 2,
                        data.mConnectPlate2.gap,
                        GetSideConnectPlatesMatrix(data.mSideConnectPlate2, connectingId2, instPt2))
            SideConnectPlatesCreater2.Create()

            oConnAdpt = Nothing

            oConnAdpt = New ConnectionAdapter(ConnectionId)

            oConnAdpt.AppendAdditionalObjectId(supportingId1)
            oConnAdpt.AppendAdditionalObjectId(supportingId2)
            oConnAdpt.AppendAdditionalObjectId(connectingId1)
            oConnAdpt.AppendAdditionalObjectId(connectingId2)

            oConnAdpt.AppendCreatedObjectArray(0, leftPlateId)
            oConnAdpt.AppendCreatedObjectArray(0, rightPlateId)

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

            oConnAdpt.AppendSecondActiveObjectId(leftPlateId)
            oConnAdpt.AppendSecondActiveObjectId(rightPlateId)

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

    Private Shared Function SidePlateTopToCenterDistance(data As Parameters, supportingId1 As Long)
        Dim sidePlateDist As Double
        Dim connShap As New ShapeAdapter(supportingId1)
        sidePlateDist = connShap.Width / 2 - data.mMainChordPlateThickness + data.mPlateThickness
        Return sidePlateDist
    End Function

    Private Shared Function GetSideConnectPlatesMatrix(ConnectPlate As SideConnectPlateParameter,
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
        org = MathTool.GetPointInDirection(org, zDir, 0)
        oMat.SetCoordinateSystem(org, xDir, zDir)
        Return oMat
    End Function

    Private Shared Function GetConnectPlateInsertMatrix(ConnectPlate As ArcPlateParameter,
                                                        connectingId1 As Long,
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

        Public Sub Create()
            Dim mainPlateWidth As Double = Me.MainPlateWidth()
            Dim mainPlateLength As Double = Me.MainPlateLength()

            Dim oMainMat As PsMatrix = FirstMainPlateMatrix()
            Dim oMainMat2 As PsMatrix = SecondMainPlateMatrix()

            Dim id As Long = CreatePlate(mainPlateWidth, mainPlateLength, 10, 0, 0, VerticalPosition.kTop, oMainMat)
            outsideSidePlates.Add(id)
            id = CreatePlate(mainPlateWidth, mainPlateLength, 10, 0, 0, VerticalPosition.kTop, oMainMat2)
            outsideSidePlates.Add(id)

            id = CreatePlate(mainPlateWidth, mainPlateLength / 2, AccessoryPlateThickness, 0, mainPlateLength / 4, VerticalPosition.kDown, oMainMat)
            accessorySidePlates.Add(id)
            id = CreatePlate(mainPlateWidth, mainPlateLength / 2, AccessoryPlateThickness, 0, mainPlateLength / 4, VerticalPosition.kDown, oMainMat2)
            accessorySidePlates.Add(id)

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
            Dim w As Double = (mainPlateWidth - param.webThickness) / 2
            Dim pid As Long = CreatePlate(w, mainPlateLength, 26,
                                          w / 2 + param.webThickness / 2, 0, VerticalPosition.kDown, oMainMat)
            insideSidePlates.Add(pid)
            pid = CreatePlate(w, mainPlateLength, 26,
                                         -w / 2 - param.webThickness / 2, 0, VerticalPosition.kDown, oMainMat)
            insideSidePlates.Add(pid)
        End Sub

        Private Function AccessoryPlateThickness() As Double
            Dim thk As Double
            Dim shpAdpt As New ShapeAdapter(connectId)
            thk = sidePlateTopToCenterDistance - shpAdpt.Height / 2
            Return thk
        End Function

        Private Function SecondMainPlateMatrix() As PsMatrix

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

        Private Function FirstMainPlateMatrix() As PsMatrix
            Dim org As New PsPoint
            Dim yAxis As New PsVector
            Dim zAxis As New PsVector
            Dim xAxis As New PsVector
            Dim oMainMat As New PsMatrix

            baseMatrix.getOrigin(org)
            baseMatrix.getYAxis(yAxis)

            org = MathTool.GetPointInDirection(org, -yAxis, gap / 2)
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
            Return result
        End Function

        Private Function MainPlateWidth() As Double
            Dim shpAdpt As New ShapeAdapter(connectId)
            'Dim result = 2 * param.horSideDistance + (param.horHoleCount - 1) * param.horDistance
            'result *= 2
            Dim result As Double = shpAdpt.Width
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

    Class ConnectPlatesCreator
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

    Private Shared Function CreateLeftPlate(data As Parameters, supportId As Long, connMat As PsMatrix, oPoly As PsPolygon) As Long
        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()

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
        oCreater.SetInsertMatrix(insMat)
        oCreater.SetNormalPosition(VerticalPosition.kDown)
        oCreater.SetThickness(data.mPlateThickness)
        oCreater.SetFromPolygon(oPoly)
        Dim newId As Long
        If oCreater.Create() = False Then
            Return -1
        End If
        newId = oCreater.ObjectId
        Return newId
    End Function

    Private Shared Function CreateRightPlate(data As Parameters, supportId As Long, connMat As PsMatrix, oPoly As PsPolygon) As Long
        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()

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

    Private Function CreateSidePlateProfile(data As Parameters,
                                       supportId1 As Long,
                                       supportId2 As Long,
                                       connectingId1 As Long,
                                       connectingId2 As Long,
                                       connMat1 As PsMatrix,
                                       connMat2 As PsMatrix,
                                       instPt1 As PsPoint,
                                       instPt2 As PsPoint) As PsPolygon

        Dim bottomHalf As List(Of PsPoint) = GetBottomHalfPlateProfile(data, supportId1, supportId2, connectingId1, connectingId2, connMat1, connMat2)

        'For i As Long = 0 To bottomHalf.Count - 1
        '    Utility.drawBall(bottomHalf(i), 50)
        'Next

        Dim TopHalf As New List(Of PsPoint)
        GetTopHalfProfileWithoutTopColumn(data, supportId1, supportId2, connMat1, connMat2, instPt1, instPt2, TopHalf)

        'For i As Long = 0 To TopHalf.Count - 1
        '    Utility.drawBall(TopHalf(i), 100)
        'Next

        Dim transMat As PsMatrix = ConvertConnectionMatToSidePlateInsertMat(connMat1)
        transMat.Invert()
        Dim oPoly As New PsPolygon

        For i As Integer = 0 To bottomHalf.Count - 1
            Dim pt As PsPoint = transMat.TransformPoint(bottomHalf(i))
            Debug.Assert(Math.Abs(pt.z) < PRECISION)
            oPoly.appendVertex(pt)
        Next

        SetFirstBottomFillet(bottomHalf, oPoly)
        SetSecondBottomFillet(bottomHalf, oPoly)

        For i As Integer = 0 To TopHalf.Count - 1
            Dim pt As PsPoint = transMat.TransformPoint(TopHalf(i))
            oPoly.appendVertex(pt)
        Next

        Return oPoly

    End Function
    Private Shared Sub SetFirstBottomFillet(bottomHalf As List(Of PsPoint), oPoly As PsPolygon)
        Dim dir1 As New PsVector
        Dim dir2 As New PsVector
        dir1.SetFromPoints(bottomHalf(1), bottomHalf(2))
        dir1.Normalize()
        dir2.SetFromPoints(bottomHalf(4), bottomHalf(3))
        dir2.Normalize()
        Dim burge1 As Double = -Math.Tan(dir1.GetAngleTo(dir2) / 4)

        Dim roundVertex As New PsPolygonVertex
        oPoly.getVertex(2, roundVertex)
        roundVertex.Bulge = burge1
        oPoly.setVertex(2, roundVertex)
    End Sub


    Private Shared Sub SetSecondBottomFillet(bottomHalf As List(Of PsPoint), oPoly As PsPolygon)
        Dim dir1 As New PsVector
        Dim dir2 As New PsVector
        dir1.SetFromPoints(bottomHalf(10), bottomHalf(9))
        dir1.Normalize()
        dir2.SetFromPoints(bottomHalf(11), bottomHalf(12))
        dir2.Normalize()
        Dim burge1 As Double = -Math.Tan(dir1.GetAngleTo(dir2) / 4)

        Dim roundVertex As New PsPolygonVertex
        oPoly.getVertex(10, roundVertex)
        roundVertex.Bulge = burge1
        oPoly.setVertex(10, roundVertex)
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

    Private Shared Sub GetTopHalfProfileWithoutTopColumn(data As Parameters,
                                                         supportId1 As Long, supportId2 As Long,
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
        TopHalf.Add(spt)

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
                                        ept, MathTool.GetPointInDirection(ept, zAxis1, 10), 4, mPt) = False Then
            Debug.Assert(False)
            TopHalf.Add(ept)
            Return
        End If
        TopHalf.Add(mPt)
        TopHalf.Add(ept)
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
                                               New ShapeAdapter(supportId1).Height, data.mBottomAngle4,
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
            'recoverOriginSupporingShape(oAdpt)

            Dim oTrans As New PsTransaction
            Dim oConnection As PsConnection = Nothing
            Dim oEdit As New PsEditModification

            Try
                oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, oConnection)
                If oConnection IsNot Nothing Then

                    oConnection = RemoveModifications(oConnection)

                    'For i As Integer = oConnection.AdditionalEntityCount - 1 To 0 Step -1
                    '    Dim id As Long = oConnection.AdditionalObjectId(i)
                    '    oEdit.SetObjectId(id)
                    '    oEdit.DeleteAllCutPlanes()
                    'Next

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