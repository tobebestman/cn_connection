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

        Dim horId As Long = mBuilder.getOriginHorShapeIdFromAdapter(oConnAdpt)
        If horId = 0 Then
            Return False
        End If
        Dim diagnalId As Long = mBuilder.getOriginDiagnalShapeIdFromAdapter(oConnAdpt)
        If diagnalId = 0 Then
            Return False
        End If

        Dim plateId As Long = mBuilder.getOriginSidePlateIdFromAdapter(oConnAdpt)
        If plateId = 0 Then
            Return False
        End If

        If Utility.GetIntersectPtAndUcsByShapeAndPlate(horId, diagnalId, plateId,
                                                       instPt1, connUcs1,
                                                       instPt2, connUcs2) = False Then
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

            Dim horId = mBuilder.getOriginHorShapeIdFromAdapter(oConnAdpt)
            Dim diagnalId = mBuilder.getOriginDiagnalShapeIdFromAdapter(oConnAdpt)
            Dim sidePlateId = mBuilder.getOriginSidePlateIdFromAdapter(oConnAdpt)

            If (horId <= 0 Or diagnalId <= 0 Or
                    sidePlateId <= 0) Then
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

            'Utility.drawUcs(connMat1)
            'Utility.drawUcs(connMat2)

            CutHorMember(horId, connMat1, data)

            Dim cBdr As New ConnectionBuilder
            Dim foldLine As List(Of PsPoint) = CalculateFoldingLine(cBdr.getOriginHorShapeIdFromAdapter(oConnAdpt),
                                                                    cBdr.getOriginDiagnalShapeIdFromAdapter(oConnAdpt),
                                                                    data, connMat1, connMat2)
            Debug.Assert(foldLine.Count = 4)

            Dim oSidePlateCreator1 As New SidePlateCreator(sidePlateId,
                                                           horId, diagnalId,
                                                           connMat1, connMat2,
                                                           foldLine(0), foldLine(1), data)
            If (CheckFoldLine(foldLine(0), foldLine(1), horId, diagnalId, connMat1, data)) Then
                oSidePlateCreator1.Create(True)
            End If

            data.mDiagnalCutbackCutIndex = IIf(oSidePlateCreator1.mDiagCutIndex = -1, -1, oSidePlateCreator1.mDiagCutIndex)

            'Utility.DrawLines(foldLine)

            Dim oSidePlateCreator2 As New SidePlateCreator(sidePlateId,
                                                           horId, diagnalId,
                                                           connMat1, connMat2,
                                                           foldLine(2), foldLine(3), data)
            If (CheckFoldLine(foldLine(2), foldLine(3), horId, diagnalId, connMat1, data)) Then
                oSidePlateCreator2.Create(False)
            End If

            Dim webPlatesCreater As New WebPlatesCreator(horId, data, connMat1)
            webPlatesCreater.Create()

            Dim flangePlatesCreater As New FlangeConnectPlateCreator(horId, connMat1, data)
            flangePlatesCreater.Create()

            oConnAdpt = Nothing

            oConnAdpt = New ConnectionAdapter(ConnectionId)

            oConnAdpt.AppendAdditionalObjectId(horId)
            oConnAdpt.AppendAdditionalObjectId(diagnalId)
            oConnAdpt.AppendAdditionalObjectId(sidePlateId)

            For Each id As Long In webPlatesCreater.ConnectPlateIds
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            oConnAdpt.AppendCreatedObjectId(webPlatesCreater.ChordSidePlateId)
            oConnAdpt.AppendCreatedObjectId(webPlatesCreater.BraceSidePlateId)
            oConnAdpt.AppendCreatedObjectId(webPlatesCreater.SupportPlateId1)
            oConnAdpt.AppendCreatedObjectId(webPlatesCreater.SupportPlateId2)

            oConnAdpt.AppendSecondActiveObjectId(oSidePlateCreator1.mCreatedDiagPlateId)
            oConnAdpt.AppendSecondActiveObjectId(oSidePlateCreator1.mCreatedHorPlateId)

            oConnAdpt.AppendSecondActiveObjectId(oSidePlateCreator2.mCreatedDiagPlateId)
            oConnAdpt.AppendSecondActiveObjectId(oSidePlateCreator2.mCreatedHorPlateId)

            For Each id As Long In oSidePlateCreator1.mAccessoryPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            For Each id As Long In oSidePlateCreator2.mAccessoryPlates
                oConnAdpt.AppendCreatedObjectId(id)
            Next

            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mOutsidePlateId1)
            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mOutsidePlateId2)

            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mInsidePlateId11)
            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mInsidePlateId12)
            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mInsidePlateId21)
            oConnAdpt.AppendCreatedObjectId(flangePlatesCreater.mInsidePlateId22)

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

    Public Function CheckFoldLine(spt As PsPoint, ept As PsPoint,
                                  horId As Long, diagId As Long, connMat1 As PsMatrix, data As Parameters) As Boolean


        Dim horAdpt As New ShapeAdapter(horId)
        Dim diagAdpt As New ShapeAdapter(diagId)
        Dim zDir As New PsVector
        connMat1.getZAxis(zDir)
        Dim planeOrg As New PsPoint
        connMat1.getOrigin(planeOrg)
        planeOrg = MathTool.GetPointInDirection(planeOrg, -zDir, data.mHorCutback)

        Dim horInst As New PsPoint
        MathTool.IntersectLineWithPlane(horAdpt.MidLineStart, horAdpt.MidLineEnd, planeOrg, -zDir, horInst)
        Dim diagInst As New PsPoint
        MathTool.IntersectLineWithPlane(diagAdpt.MidLineStart, diagAdpt.MidLineEnd, planeOrg, -zDir, diagInst)
        Dim pt As New PsPoint
        MathTool.IntersectLineWithPlane(spt, ept, planeOrg, -zDir, pt)

        'make sure the org point is on the same line
        Dim orgOnline As PsPoint = MathTool.OrthoProjectPointToLine(pt, horInst, diagInst)

        'the expected result should be:
        'horInst --> pt --> diagInst

        Dim vec1 As New PsVector
        Dim vec2 As New PsVector
        vec1.SetFromPoints(horInst, orgOnline)
        vec1.Normalize()
        vec2.SetFromPoints(orgOnline, diagInst)
        vec2.Normalize()

        'drawBall(horInst, 20)
        'drawBall(pt, 40)
        'drawBall(diagInst, 60)

        If (GeoHelper.IsInSameDirection(vec1, vec2)) Then
            Return True
        Else
            'the fold line is not between the two 
            'member. skip it.
            Debug.Assert(False)
            Return False
        End If
    End Function

    Public Shared Function GetHorMemberWebHeight(id As Long,
                                                 connMat As PsMatrix,
                                                 param As Parameters) As Double
        Dim shpAdpt As New ShapeAdapter(id)
        Dim org As New PsPoint
        Dim xDir As New PsVector
        Dim yDir As New PsVector

        connMat.getOrigin(org)
        connMat.getZAxis(xDir)
        connMat.getYAxis(yDir)

        Dim width As Double = param.mHorWebCutback * 2
        Dim height As Double = 0
        If (GeoHelper.IsInSameDirection(shpAdpt.XAxis, yDir) Or
            GeoHelper.IsInSameDirection(-shpAdpt.XAxis, yDir)) Then
            height = shpAdpt.Width - param.mHorPlateThickness * 2
        ElseIf (GeoHelper.IsInSameDirection(shpAdpt.YAxis, yDir) Or
                 GeoHelper.IsInSameDirection(-shpAdpt.XAxis, yDir)) Then
            height = shpAdpt.Height - param.mHorPlateThickness * 2
        Else
            Debug.Assert(False)
            height = shpAdpt.Height
        End If
        Return height
    End Function

    Public Shared Function GetHorMemberFlangeWidth(id As Long,
                                                 connMat As PsMatrix,
                                                 param As Parameters) As Double
        Dim shpAdpt As New ShapeAdapter(id)
        Dim org As New PsPoint
        Dim xDir As New PsVector
        Dim yDir As New PsVector

        connMat.getOrigin(org)
        connMat.getZAxis(xDir)
        connMat.getYAxis(yDir)

        Dim width As Double = param.mHorWebCutback * 2
        Dim height As Double = 0
        If (GeoHelper.IsInSameDirection(shpAdpt.XAxis, yDir) Or
            GeoHelper.IsInSameDirection(-shpAdpt.XAxis, yDir)) Then
            height = shpAdpt.Height
        ElseIf (GeoHelper.IsInSameDirection(shpAdpt.YAxis, yDir) Or
                 GeoHelper.IsInSameDirection(-shpAdpt.XAxis, yDir)) Then
            height = shpAdpt.Width
        Else
            Debug.Assert(False)
            height = shpAdpt.Width
        End If
        Return height
    End Function

    Private Sub CutHorMember(id As Long, connMat As PsMatrix, param As Parameters)
        Dim shpAdpt As New ShapeAdapter(id)
        Dim org As New PsPoint
        Dim xDir As New PsVector
        Dim yDir As New PsVector

        connMat.getOrigin(org)
        connMat.getZAxis(xDir)
        connMat.getYAxis(yDir)

        Dim width As Double = param.mHorWebCutback * 2
        Dim height As Double = GetHorMemberWebHeight(id, connMat, param)

        Dim oPoly As New PsPolygon
        oPoly.createRectangle(width, height)

        Dim cut As New PsCutObjects
        cut.SetToDefaults()
        Dim cutNormal As New PsVector
        cutNormal.SetFromCrossProduct(xDir, yDir)
        cut.SetAsPolyCut(oPoly, MathTool.GetPointInDirection(org, cutNormal, height * 2), xDir, yDir, height * 4)
        cut.SetObjectId(id)
        If cut.Apply() > 0 Then
            param.mHorWebCutIndex = cut.GetModifyIndex()
        Else
            param.mHorWebCutIndex = -1
            'Debug.Assert(False)
        End If

        cut.SetToDefaults()
        Dim oPlane As New PsCutPlane
        oPlane.InsertPoint = MathTool.GetPointInDirection(org, -xDir,
                                param.mHorCutback + param.mHorGap)
        oPlane.Normal = xDir
        cut.SetAsPlaneCut(oPlane)
        cut.SetObjectId(id)
        If cut.Apply() > 0 Then
            param.mHorCutbackCutIndex = cut.GetModifyIndex()
        Else
            param.mHorCutbackCutIndex = -1
            'Debug.Assert(False)
        End If

        Return
    End Sub

    Private Function GetSidePlane(id As Long, connMat As PsMatrix, backingPlateThk As Double) As List(Of PsCutPlane)
        Dim result As New List(Of PsCutPlane)

        Dim diagAdpt As New DiagShapeAdapter(connMat, id)
        Dim org As PsPoint = diagAdpt.org()

        Dim oPlanePos As New PsCutPlane
        oPlanePos.SetFromNormal(MathTool.GetPointInDirection(org,
                                         diagAdpt.SideDir, backingPlateThk + diagAdpt.GetFaceDistanceInSideDir / 2),
                                         diagAdpt.SideDir)

        Dim oPlaneNeg As New PsCutPlane
        oPlaneNeg.SetFromNormal(MathTool.GetPointInDirection(org,
                                         -diagAdpt.SideDir, backingPlateThk + diagAdpt.GetFaceDistanceInSideDir / 2),
                                         diagAdpt.SideDir)

        result.Add(oPlanePos)
        result.Add(oPlaneNeg)
        Return result
    End Function

    Private Function CalculateFoldingLine(horId As Long, diagId As Long,
                                          param As Parameters,
                                          connMat1 As PsMatrix, connMat2 As PsMatrix) As List(Of PsPoint)
        Dim result As New List(Of PsPoint)

        Dim diagSidePlanes As List(Of PsCutPlane) = GetSidePlane(diagId,
                                                                 connMat2,
                                                                 param.mSidePlate.mOutsidePlateThickness)

        CalculateFoldLine(horId, param, connMat1, result, diagSidePlanes(0))
        CalculateFoldLine(horId, param, connMat1, result, diagSidePlanes(1))

        'If (result.Count > 1) Then
        '    Dim oLine As New PsGeoLine
        '    oLine.StartPoint = result(0)
        '    oLine.EndPoint = result(1)
        '    oLine.DrawLine(CoordSystem.kWcs, "0", "0", 1, 1)
        'End If

        'If (result.Count > 3) Then
        '    Dim oLine As New PsGeoLine
        '    oLine.StartPoint = result(2)
        '    oLine.EndPoint = result(3)
        '    oLine.DrawLine(CoordSystem.kWcs, "0", "0", 3, 1)
        'End If

        'now we need check of the fold line is between the 
        'two members.

        'oLine.StartPoint = highPt1
        'oLine.EndPoint = highPt2
        'oLine.DrawLine(CoordSystem.kWcs, "0", "0", 3, 1)

        'oLine.StartPoint = highPt2
        'oLine.EndPoint = highInst
        'oLine.DrawLine(CoordSystem.kWcs, "0", "0", 3, 1)
        Return result
    End Function

    Private Shared Sub CalculateFoldLine(horId As Long, param As Parameters, connMat1 As PsMatrix, result As List(Of PsPoint), plane As PsCutPlane)
        Dim yDir As New PsVector
        Dim org As New PsPoint
        connMat1.getYAxis(yDir)
        connMat1.getOrigin(org)

        Dim zDir As New PsVector
        connMat1.getZAxis(zDir)
        Dim horAdpt As New ShapeAdapter(horId)
        Dim ptPosLow1 As PsPoint = MathTool.GetPointInDirection(org, yDir, horAdpt.Height / 2)
        Dim ptPosLow2 As PsPoint = MathTool.GetPointInDirection(org, -yDir, horAdpt.Height / 2)

        Dim ptPosLow = IIf(ptPosLow1.get_DistanceTo(plane.InsertPoint) < ptPosLow2.get_DistanceTo(plane.InsertPoint),
                            ptPosLow1, ptPosLow2)

        Dim ptPosHight As PsPoint = MathTool.GetPointInDirection(ptPosLow, -zDir, param.mHorCutback)

        Dim xDir As New PsVector
        connMat1.getXAxis(xDir)
        Dim foldPoslow As New PsPoint

        'Utility.drawLine(ptPosLow, MathTool.GetPointInDirection(ptPosLow, xDir, 2000), 1, 1)
        MathTool.IntersectLineWithPlane(ptPosLow, MathTool.GetPointInDirection(ptPosLow, xDir, 2000),
                                        plane.InsertPoint, plane.Normal, foldPoslow)
        Dim foldPosHigh As New PsPoint

        'Utility.drawLine(ptPosHight, MathTool.GetPointInDirection(ptPosHight, xDir, 2000), 2, 1)
        MathTool.IntersectLineWithPlane(ptPosHight, MathTool.GetPointInDirection(ptPosHight, xDir, 2000),
                                        plane.InsertPoint, plane.Normal, foldPosHigh)



        result.Add(foldPoslow)
        result.Add(foldPosHigh)

    End Sub

    Private Shared Function SidePlateTopToCenterDistance(data As Parameters, supportingId1 As Long)
        Dim sidePlateDist As Double
        Dim connShap As New ShapeAdapter(supportingId1)
        sidePlateDist = connShap.Width / 2 - data.mHorPlateThickness + data.mDiagnalGap
        Return sidePlateDist
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

    Private Shared Function CalculatePositiveXSidePlateMatrix(data As Parameters, supportId As Long, connMat As PsMatrix) As PsMatrix
        Dim org As New PsPoint
        connMat.getOrigin(org)

        Dim xAxis As New PsVector
        connMat.getXAxis(xAxis)

        Dim yAxis As New PsVector
        connMat.getYAxis(yAxis)
        org = MathTool.GetPointInDirection(org, xAxis, New ShapeAdapter(supportId).Width / 2 +
                                           data.mDiagnalGap - data.mHorPlateThickness)

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
        oCreater.SetThickness(data.mDiagnalGap)
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
                                           data.mDiagnalGap - data.mHorPlateThickness)

        connMat.getZAxis(xAxis)
        Dim insMat As New PsMatrix()
        insMat.SetCoordinateSystem(org, xAxis, yAxis)
        Return insMat
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
        spt = MathTool.GetPointInDirection(org2, -zAxis2, data.mHorWebCutback)
        spt = MathTool.GetPointInDirection(spt, yAxis2, New ShapeAdapter(supportId2).Height / 2)
        TopHalf.Add(spt)

        Dim org1 As New PsPoint
        Dim yAxis1 As New PsVector
        Dim zAxis1 As New PsVector

        connMat1.getOrigin(org1)
        connMat1.getZAxis(zAxis1)
        connMat1.getYAxis(yAxis1)
        Dim ept As PsPoint
        ept = MathTool.GetPointInDirection(org1, -zAxis1, data.mHorCutback)
        ept = MathTool.GetPointInDirection(ept, yAxis1, New ShapeAdapter(supportId1).Height / 2)

        Dim mPt As New PsPoint
        If MathTool.IntersectLineWithLine(spt, MathTool.GetPointInDirection(spt, -zAxis2, 10),
                                        ept, MathTool.GetPointInDirection(ept, zAxis1, 10), 0, mPt) = False Then
            Debug.Assert(False)
            TopHalf.Add(ept)
            Return
        End If
        TopHalf.Add(mPt)
        TopHalf.Add(ept)
    End Sub

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
        Dim cutHeight = oAdpt.Height + 2 * oData.mHorPlateThickness

        Dim oStart As New PsPoint
        oMat.getOrigin(oStart)
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getXAxis(xAxis)
        oMat.getYAxis(yAxis)
        oMat.getZAxis(zAxis)

        If (isFirstPair) Then
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mHorCutback)
        Else
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mHorWebCutback)
        End If

        oStart = MathTool.GetPointInDirection(oStart, xAxis, width / 2 - oData.mHorPlateThickness)
        oStart = MathTool.GetPointInDirection(oStart, -yAxis, cutHeight / 2)

        Dim polyLength As Double = oData.mHorCutback +
                             MathTool.GetDistanceBetween(instPt1, instPt2) +
                             oData.mHorWebCutback
        Dim polyWidth As Double = 2 * oData.mHorPlateThickness

        Dim oPoly As New PsPolygon
        oPoly.appendVertex(0, 0, 0)
        oPoly.appendVertex(polyLength, 0, 0)
        oPoly.appendVertex(polyLength, polyWidth, 0)
        oPoly.appendVertex(0, polyWidth, 0)
        oPoly.appendVertex(0, 0, 0)

        Return DoPolyCut(supportId, cutHeight, oStart, zAxis, xAxis, oPoly)
    End Function


    Private Function CutSupportLeftSide(oMat As PsMatrix, supportId As Long,
                                         oData As Parameters,
                                         instPt1 As PsPoint,
                                         instPt2 As PsPoint,
                                         isFirstPair As Boolean) As Integer
        Dim oAdpt As New ShapeAdapter(supportId)
        Dim width = oAdpt.Width
        Dim cutHeight = oAdpt.Height + 2 * oData.mHorPlateThickness

        Dim oStart As New PsPoint
        oMat.getOrigin(oStart)
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getXAxis(xAxis)
        oMat.getYAxis(yAxis)
        oMat.getZAxis(zAxis)

        If isFirstPair = True Then
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mHorCutback)
        Else
            oStart = MathTool.GetPointInDirection(oStart, -zAxis, oData.mHorWebCutback)
        End If

        oStart = MathTool.GetPointInDirection(oStart, -xAxis, width / 2 - oData.mHorPlateThickness)
        oStart = MathTool.GetPointInDirection(oStart, -yAxis, cutHeight / 2)

        Dim polyLength As Double = oData.mHorCutback +
                             MathTool.GetDistanceBetween(instPt1, instPt2) +
                             oData.mHorWebCutback
        Dim polyWidth As Double = 2 * oData.mHorPlateThickness

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

                End If
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            Finally
                oTrans.Close()
                oEdit = Nothing
            End Try

            Dim oAdpt As New ConnectionAdapter(ConnectionId)
            oAdpt.ReadAddtionalObjects()
            Dim oBuilder As New ConnectionBuilder
            Dim horId As Long = oBuilder.getOriginHorShapeIdFromAdapter(oAdpt)
            Dim diagId As Long = oBuilder.getOriginDiagnalShapeIdFromAdapter(oAdpt)
            Dim plateId As Long = oBuilder.getOriginSidePlateIdFromAdapter(oAdpt)

            Utility.RecoverShapeLengthTo(horId, plateId)
            Utility.RecoverShapeLengthTo(diagId, plateId)

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

        Dim support1 As Long = oConnection.AdditionalObjectId(0)
        Dim support2 As Long = oConnection.AdditionalObjectId(1)

        Dim oModify As New PsEditModification

        If (param.mHorCutbackCutIndex <> -1) Then
            oModify.SetObjectId(support1)
            oModify.DeleteCutPlane(param.mHorCutbackCutIndex)
        End If

        If (param.mHorWebCutIndex <> -1) Then
            oModify.SetObjectId(support1)
            oModify.DeletePolyCut(param.mHorWebCutIndex)
        End If

        If (param.mHorCutbackCutIndex <> -1) Then
            oModify.SetObjectId(support1)
            oModify.DeleteCutPlane(param.mHorCutbackCutIndex)
        End If

        If (param.mDiagnalCutbackCutIndex <> -1) Then
            oModify.SetObjectId(support2)
            oModify.DeleteCutPlane(param.mDiagnalCutbackCutIndex)
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

        Dim horId As Long
        Do
            horId = Selection.PickObject(RSS.RSS("M0000"))
            If horId <= 0 Then Return 0
        Loop Until (IsWeldShape(horId))

        Dim diagnalId As Long
        Do
            diagnalId = Selection.PickObject(RSS.RSS("M0001"))
            If diagnalId <= 0 Then Return 0
        Loop Until (IsWeldShape(diagnalId))

        Dim plateId As Long
        Do
            plateId = Selection.PickObject(RSS.RSS("M0002"))
            If plateId <= 0 Then Return 0
        Loop Until (IsPlate(plateId))

        Dim oCreateConnection As New PsCreateConnection

        IsCreatingConn = True

        oCreateConnection.SetIdentifier(PLUGIN_IDENTIFIER)
        oCreateConnection.SetDescription(PLUGIN_DESCRIPTION)
        If (oCreateConnection.Create()) Then
            ConnectionId = oCreateConnection.ObjectId
        End If

        Dim connAdpt As New ConnectionAdapter(ConnectionId)
        connAdpt.SetBuilt(False)
        connAdpt.AppendAdditionalObjectId(horId)
        connAdpt.AppendAdditionalObjectId(diagnalId)
        connAdpt.AppendAdditionalObjectId(plateId)

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

    Public Class DiagShapeAdapter
        Private _mat As PsMatrix
        Private _id As Long
        Public Sub New(connMat As PsMatrix, id As Long)
            _id = id
            _mat = connMat
        End Sub

        Public Function SideDir() As PsVector
            Dim yDir As New PsVector
            _mat.getYAxis(yDir)
            Return yDir
        End Function

        Public Function NoneSideDir() As PsVector
            Dim result As New PsVector
            _mat.getXAxis(result)
            Return result
        End Function

        Public Function org() As PsPoint
            Dim result As New PsPoint
            _mat.getOrigin(result)
            Return result
        End Function

        Public Function SideDirIsXDir() As Boolean
            Dim oAdpt As New ShapeAdapter(_id)

            If Math.Abs(Math.Abs(MathTool.GetDotProductFrom(oAdpt.XAxis, SideDir)) - 1) < PRECISION Then
                Return True
            ElseIf Math.Abs(Math.Abs(MathTool.GetDotProductFrom(oAdpt.YAxis, SideDir)) - 1) < PRECISION Then
                Return False
            End If

            Debug.Assert(False)
            Return True
        End Function

        Public Function GetFaceDistanceInSideDir() As Double
            Dim shpAdpt As New ShapeAdapter(_id)
            If (SideDirIsXDir()) Then
                Return shpAdpt.Width
            Else
                Return shpAdpt.Height
            End If
        End Function

        Public Function getFaceDistancePerpendToSideDir() As Double
            Dim width As Double
            Dim diagShp As New ShapeAdapter(_id)
            If SideDirIsXDir() Then
                width = diagShp.Height
            Else
                width = diagShp.Width
            End If
            Return width
        End Function
    End Class

End Class


