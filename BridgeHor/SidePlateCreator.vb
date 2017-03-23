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

Public Class SidePlateCreator
    Private mPlateId As Long
    Private mHorId As Long
    Private mDiagId As Long
    Private MathTool As New PsGeometryFunctions

    Private mHorUcs As PsMatrix
    Private mDiagUcs As PsMatrix
    Private mParam As Parameters

    Private mFoldStart As PsPoint
    Private mFoldEnd As PsPoint

    Public mCreatedHorPlateId As Long
    Public mCreatedDiagPlateId As Long

    Public mAccessoryPlates As List(Of Long)

    Public mDiagCutIndex As Integer

    Public mSideCutPlane As PsCutPlane
    Public mHorCutPlane As PsCutPlane

    Public Sub New(plateId As Long,
                   horId As Long,
                   diagId As Long,
                   horUcs As PsMatrix,
                   diagUcs As PsMatrix,
                   foldStart As PsPoint,
                   foldEnd As PsPoint,
                   param As Parameters)
        mPlateId = plateId
        mHorId = horId
        mDiagId = diagId
        mHorUcs = horUcs
        mDiagUcs = diagUcs
        mParam = param
        mFoldStart = foldStart
        mFoldEnd = foldEnd

        mHorCutPlane = Nothing
        mSideCutPlane = Nothing

        mAccessoryPlates = New List(Of Long)


    End Sub

    Public Sub Create(isFirstFoldLine As Boolean)
        CreateHorSidePlate()
        CreateDiagSidePlate(isFirstFoldLine)
    End Sub

    Private Sub CreateDiagSidePlate(isFirstFoldLine As Boolean)

        Dim diagAdpt As New UserConnection.DiagShapeAdapter(mDiagUcs, mDiagId)

        Dim points As New List(Of PsPoint)
        points.Add(mFoldStart)
        points.Add(mFoldEnd)

        Dim oMidPlane As New PsCutPlane
        oMidPlane.SetFromNormal(diagAdpt.org, diagAdpt.NoneSideDir)

        Dim upperDir As PsVector = GetDiagSidePlateUpperEdgeDir()
        Dim zDir As New PsVector
        mDiagUcs.getZAxis(zDir)
        Dim org As New PsPoint
        mDiagUcs.getOrigin(org)

        org = MathTool.OrthoProjectPointToPlane(org, mFoldStart, diagAdpt.SideDir)

        Dim inst As New PsPoint
        Dim memberPt As PsPoint = MathTool.GetPointInDirection(org, -zDir, 100)
        Dim sidePt As PsPoint = MathTool.GetPointInDirection(mFoldEnd, upperDir, 100)

        'Utility.drawLine(org, memberPt, 1, 1)
        'Utility.drawLine(mFoldEnd, sidePt, 2, 1)

        If MathTool.IntersectLineWithLine(org, memberPt,
                                       mFoldEnd, sidePt,
                                       0, inst) = False Then
            Debug.Assert(False)
            Return
        End If

        Dim angle As Double = upperDir.GetAngleTo(zDir)
        angle = MathTool.Radians2Degrees(angle)
        If angle > 90 Then
            angle = 180 - angle
        End If
        angle = MathTool.Degrees2Radians(angle)

        Dim instDist As Double = inst.get_DistanceTo(mFoldEnd)
        Dim dist As Double = mParam.mSidePlate.mDiagTopDist / Math.Sin(angle)

        instDist = instDist - dist

        Dim cornerPt As PsPoint = MathTool.GetPointInDirection(mFoldEnd, upperDir, mParam.mSidePlate.mDiagTopDist)
        'drawBall(cornerPt, 50)
        points.Add(New PsPoint(cornerPt.x, cornerPt.y, cornerPt.z))

        Dim midPt As New PsPoint
        'midPt = MathTool.GetPointInDirection(inst, zDir, dist * Math.Cos(angle))
        midPt = MathTool.OrthoProjectPointToLine(cornerPt, org, memberPt)
        If (isFirstFoldLine) Then
            CutDiagShape(zDir, midPt)
        End If

        'drawBall(midPt, 60)

        Dim diagCutDir As New PsVector
        diagCutDir.SetFromPoints(points(2), midPt)
        diagCutDir.Normalize()

        points.Add(MathTool.GetPointInDirection(points(2), diagCutDir, (midPt.get_DistanceTo(cornerPt) + diagAdpt.getFaceDistancePerpendToSideDir / 2)))
        'drawBall(points(2), 80)
        Dim sideDir As PsVector = GetDiagSideEdge(points)

        Dim plateAdpt As New PlateAdapter(mPlateId)
        Dim lowerInst As New PsPoint
        If (MathTool.IntersectLineWithPlane(points(3),
              MathTool.GetPointInDirection(points(3), sideDir, 10),
              mFoldStart, plateAdpt.GetDirection(), lowerInst) = False) Then
            Debug.Assert(False)
        End If

        points.Add(lowerInst)

        Dim oPoly As New PsPolygon
        Dim oMat As PsMatrix = GenerateInwardsUcsByFoldLineAndShape(diagAdpt)
        Utility.TransformPointListToPolygon(points, oPoly, oMat)

        'For Each ptTest In points
        '    drawBall(ptTest, 40)
        'Next
        'Utility.DrawLines(points)
        mCreatedDiagPlateId = Utility.CreatePlate(oPoly, oMat,
                                                   mParam.mSidePlate.mInsidePlateThickness,
                                                   0, 0, VerticalPosition.kDown)

        'Utility.DrawLines(points)

        Dim dirInwards As New PsVector
        oMat.getZAxis(dirInwards)

        Dim yDir As New PsVector
        mDiagUcs.getZAxis(yDir)

        If (isFirstFoldLine = False) Then
            dirInwards = -dirInwards
        End If

        Dim xDir As New PsVector
        xDir.SetFromCrossProduct(dirInwards, yDir)

        Dim oDiagHoleMat As New PsMatrix
        oDiagHoleMat.SetCoordinateSystem(midPt, xDir, yDir)

        Dim diagConnPlateCreator As New DiagConnectPlateCreator(midPt, oDiagHoleMat, mDiagId, mParam)

        If diagConnPlateCreator.Create(mCreatedDiagPlateId) = False Then
            Debug.Assert(False)
        End If

        'Dim length As Double = diagConnPlateCreator.getPlateWidth() / 2
        'Dim width As Double = diagAdpt.getFaceDistancePerpendToSideDir()

        'Dim oAccessMat As New PsMatrix
        'oAccessMat.SetCoordinateSystem(MathTool.GetPointInDirection(midPt, xDir, mParam.mDiagnalGap),
        '                                xDir, yDir)

        'Dim accessoryId As Long = Utility.CreatePlate(length, width,
        '                    mParam.mSidePlate.mBackingPlateThickness, length / 2,
        '                    0, VerticalPosition.kTop, oAccessMat)
        'mAccessoryPlates.Add(accessoryId)

        Dim oBCut As New PsCutObjects
        oBCut.SetToDefaults()
        oBCut.SetSubBodyType(SubBodyType.kSubBody)
        oBCut.SetAsBooleanCut(mPlateId)
        oBCut.SetObjectId(mCreatedDiagPlateId)
        oBCut.Apply()

    End Sub

    Private Sub CutDiagShape(zDir As PsVector, midPt As PsPoint)
        mSideCutPlane = New PsCutPlane()
        mSideCutPlane.SetFromNormal(midPt, zDir)

        Dim oPlane As PsCutPlane = getDiagShapeCutPlane(zDir, midPt)

        Dim oCut As New PsCutObjects
        oCut.SetAsPlaneCut(oPlane)
        oCut.SetObjectId(mDiagId)
        If oCut.Apply > 0 Then
            mDiagCutIndex = oCut.GetModifyIndex
        Else
            mDiagCutIndex = -1
        End If
    End Sub

    Private Function getDiagShapeCutPlane(zDir As PsVector, midPt As PsPoint) As PsCutPlane
        Dim oPlane As New PsCutPlane
        oPlane.SetFromNormal(MathTool.GetPointInDirection(midPt, zDir, mParam.mDiagnalExtend), zDir)
        Return oPlane
    End Function

    Private Function GetDiagSideEdge(points As List(Of PsPoint)) As PsVector
        Dim axis As New PsVector
        Dim dir1 As New PsVector
        dir1.SetFromPoints(points(2), points(3))
        dir1.Normalize()
        Dim zDir2 As New PsVector
        mDiagUcs.getZAxis(zDir2)
        axis.SetFromCrossProduct(dir1, zDir2)
        axis.Normalize()
        Dim newEnd2 As New PsPoint
        GeoHelper.RotateLineByStart(points(3), points(2), 90 + mParam.mSidePlate.mDiagAngle, -axis, newEnd2)
        dir1.SetFromPoints(points(3), newEnd2)
        dir1.Normalize()
        Return dir1
    End Function

    Private Function GetDiagSidePlateUpperEdgeDir() As PsVector
        Dim dir1 As New PsVector
        dir1.SetFromPoints(mFoldStart, mFoldEnd)
        dir1.Normalize()

        Dim dirZ As New PsVector
        mDiagUcs.getZAxis(dirZ)

        Dim axis As New PsVector
        axis.SetFromCrossProduct(dirZ, dir1)
        axis.Normalize()

        axis.SetFromCrossProduct(axis, dir1)
        axis.Normalize()
        Return axis
    End Function

    Private Function GenerateInwardsUcsByFoldLineAndShape(diagAdpt As UserConnection.DiagShapeAdapter) As PsMatrix
        Dim xDir As PsVector = diagAdpt.NoneSideDir()
        Dim yDir As PsVector = diagAdpt.SideDir()

        Dim org As PsPoint = diagAdpt.org
        Dim outPt As PsPoint = MathTool.OrthoProjectPointToPlane(mFoldStart, org, xDir)

        Dim inPt As PsPoint = MathTool.OrthoProjectPointToPlane(outPt, org, yDir)

        Dim zDir As New PsVector
        zDir.SetFromPoints(outPt, inPt)

        Dim result As New PsMatrix
        xDir.SetFromPoints(mFoldStart, mFoldEnd)
        xDir.Normalize()
        yDir.SetFromCrossProduct(zDir, xDir)
        yDir.Normalize()
        result.SetCoordinateSystem(mFoldEnd, xDir, yDir)
        Return result
    End Function

    Private Function GenerateInwardsUcsByFoldLineAndShape(ucs As PsMatrix) As PsMatrix
        Dim xDir As New PsVector
        ucs.getXAxis(xDir)
        Dim yDir As New PsVector
        ucs.getYAxis(yDir)

        Dim org As New PsPoint
        ucs.getOrigin(org)
        Dim outPt As PsPoint = MathTool.OrthoProjectPointToPlane(mFoldStart, org, xDir)

        Dim zDir As New PsVector
        zDir.SetFromPoints(outPt, org)

        Dim result As New PsMatrix
        xDir.SetFromPoints(mFoldStart, mFoldEnd)
        xDir.Normalize()
        yDir.SetFromCrossProduct(zDir, xDir)
        yDir.Normalize()
        result.SetCoordinateSystem(mFoldEnd, xDir, yDir)
        Return result
    End Function

    Private Sub CreateHorSidePlate()
        Dim xDir As New PsVector
        mHorUcs.getXAxis(xDir)
        Dim zDir As New PsVector
        mHorUcs.getZAxis(zDir)
        Dim org As New PsPoint
        mHorUcs.getOrigin(org)

        Dim points As New List(Of PsPoint)
        points.Add(mFoldStart)
        points.Add(mFoldEnd)

        Dim pt As PsPoint
        pt = MathTool.OrthoProjectPointToPlane(mFoldEnd, org, -xDir)

        mHorCutPlane = New PsCutPlane
        mHorCutPlane.SetFromNormal(pt, zDir)

        Dim lineDir As New PsVector
        lineDir.SetFromPoints(mFoldEnd, pt)
        lineDir.Normalize()

        'drawBall(pt, 80)

        pt = MathTool.GetPointInDirection(pt, lineDir, mParam.mSidePlate.mHorTopDist)
        points.Add(pt)

        'drawBall(pt, 40)

        Dim rotateAxis As PsVector = GeoHelper.getAxisByThreePoints(points(1), points(0), points(2))
        Dim newEndpt As New PsPoint
        GeoHelper.RotateLineByStart(points(2), points(1), mParam.mSidePlate.mHorAngle + 90, rotateAxis, newEndpt)

        Dim plateAdpt As New PlateAdapter(mPlateId)
        Dim newPt As New PsPoint
        MathTool.IntersectLineWithPlane(points(2), newEndpt, org, plateAdpt.GetDirection, newPt)

        points.Add(newPt)

        'Dim oPoly As New PsPolygon
        'Dim plateMat As New PsMatrix
        'plateMat.SetCoordinateSystem(points(0), xDir, zDir)
        'Utility.TransformPointListToPolygon(points, oPoly, plateMat)

        'Utility.DrawLines(points)

        Dim oMat As PsMatrix = GenerateInwardsUcsByFoldLineAndShape(mHorUcs)
        Dim oPoly As New PsPolygon
        Utility.TransformPointListToPolygon(points, oPoly, oMat)

        mCreatedHorPlateId = Utility.CreatePlate(oPoly, oMat, mParam.mSidePlate.mInsidePlateThickness,
                                           0, 0, VerticalPosition.kDown)

        Dim oBCut As New PsCutObjects
        oBCut.SetToDefaults()
        oBCut.SetSubBodyType(SubBodyType.kSubBody)
        oBCut.SetAsBooleanCut(mPlateId)
        oBCut.SetObjectId(mCreatedDiagPlateId)
        oBCut.Apply()

    End Sub
End Class
