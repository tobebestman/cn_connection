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

Public Class CreatedColumnPlates
    Public innertPlateIds As New List(Of Long)
    Public outterPlateId As Long
    Public accessoryPlateId As Long

    Public innerWebPlateIds As New List(Of Long)

    Public drillModifyIds As New List(Of Integer)
End Class

Public Class ColumnWebConnectPlateCreator
    Dim supporingId2 As Long
    Dim columnId As Long
    Dim param As Parameters

    Public higherPlates As CreatedColumnPlates
    Public lowerPlates As CreatedColumnPlates

    Public Sub New(supportingId2 As Long,
                columnId As Long,
                data As Parameters)
        Me.supporingId2 = supportingId2
        Me.columnId = columnId
        Me.param = data

        higherPlates = New CreatedColumnPlates
        lowerPlates = New CreatedColumnPlates
    End Sub

    Public Sub Create()
        Dim higherPlateMat As PsMatrix = higherPlatesUcs()
        CreatePlates(higherPlateMat, higherPlates)
        AddSlotOnPlates(higherPlateMat, higherPlates)
        DrillSlotOnColumn(higherPlateMat, higherPlates)
        DrillHoles(higherPlateMat, higherPlates)

        Dim lowerPlateMat As PsMatrix = lowerPlatesUcs()
        CreatePlates(lowerPlateMat, lowerPlates)
        AddSlotOnPlates(lowerPlateMat, lowerPlates)
        DrillSlotOnColumn(lowerPlateMat, lowerPlates)
        DrillHoles(lowerPlateMat, lowerPlates)
    End Sub

    Private Function DistanceToUpperOfShape(pt As PsPoint) As Double
        Dim instPt As New PsPoint
        Dim ucs As New PsMatrix
        Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(supporingId2, columnId, instPt, ucs)

        Dim colAdpt As New ShapeAdapter(columnId)
        Dim colDir As New PsVector
        colDir.SetFromPoints(colAdpt.MidLineMid, colAdpt.GetEndpointTo(instPt))
        colDir.Normalize()

        Dim yDir As New PsVector
        ucs.getYAxis(yDir)
        instPt = MathTool.GetPointInDirection(instPt, -yDir, New ShapeAdapter(supporingId2).Height / 2)

        Dim endPoint As New PsPoint
        MathTool.IntersectLineWithPlane(pt, MathTool.GetPointInDirection(pt, colDir, 10),
                    instPt, -yDir, endPoint)

        'drawBall(pt, 20)
        'drawBall(endPoint, 40)
        Dim dist As Double = MathTool.GetDistanceBetween(endPoint, pt)
        Return dist
    End Function

    Private Sub DrillHoles(highPlateMat As PsMatrix, plates As CreatedColumnPlates)
        Dim org As New PsPoint
        highPlateMat.getOrigin(org)
        Dim xDir As New PsVector
        highPlateMat.getXAxis(xDir)
        Dim yDir As New PsVector
        highPlateMat.getYAxis(yDir)
        Dim zDir As New PsVector
        highPlateMat.getZAxis(zDir)

        Dim width As Double = ColumnWebConnectPlateWidth()
        Dim height As Double = ColumnWebConnectPlateHeight()

        Dim drillLoc As PsPoint = MathTool.GetPointInDirection(org, -xDir, width / 2)
        drillLoc = MathTool.GetPointInDirection(drillLoc, yDir,
                height / 2 - param.mColumnWebConnectPlate.HoleGrop.upperEdgeDistance)

        Dim oDriller As New PsDrillObject
        oDriller.SetToDefaults()
        oDriller.SetXYPlane(xDir, yDir)
        oDriller.SetHoleType(HoleType.kHoleLenLimited)
        oDriller.SetHoleDepth(Me.SlotCutThickness)
        Dim parser As New Utility.BoltDescParser
        For Each oDef In param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions
            'drawBall(drillLoc, 20)
            drillLoc = MathTool.GetPointInDirection(drillLoc, xDir, oDef.horDistance)
            oDriller.SetInsertPoint(drillLoc)
            oDriller.SetLinearHoleField(param.mHoleDia, "1*0", oDef.YDesc.Replace("x", "*"))
            parser.Parse(oDef.YDesc)
            Dim len As Double = parser.count * parser.distance / 2
            oDriller.SetYOffset(-len)
            oDriller.SetObjectId(plates.outterPlateId)
            oDriller.Apply()

            For i As Integer = 0 To plates.innertPlateIds.Count - 1
                If (oDef.groupId <> i) Then
                    Continue For
                End If
                oDriller.SetObjectId(plates.innertPlateIds(i))
                oDriller.Apply()
            Next

            oDriller.SetObjectId(plates.accessoryPlateId)
            oDriller.Apply()
        Next

        '------drill the upper part-------------------
        Dim drillLoc2 As PsPoint = MathTool.GetPointInDirection(org, -xDir, width / 2)
        drillLoc2 = MathTool.GetPointInDirection(drillLoc2, -yDir,
                height / 2 - param.mColumnWebConnectPlate.HoleGrop.upperEdgeDistance)

        Dim colAdpt As New ShapeAdapter(columnId)

        Dim oDriller2 As New PsDrillObject
        oDriller2.SetToDefaults()
        oDriller2.SetXYPlane(xDir, yDir)
        oDriller2.SetIgnoreInnerContour(True)
        Dim parser2 As New Utility.BoltDescParser
        For Each oDef In param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions
            'drawBall(drillLoc2, 20)

            oDriller2.SetHoleType(HoleType.kHoleLenLimited)
            oDriller2.SetHoleDepth(Me.SlotCutThickness)
            oDriller2.SetDrillType(DrillType.kDrillFlangeBoth)

            drillLoc2 = MathTool.GetPointInDirection(drillLoc2, xDir, oDef.horDistance)
            oDriller2.SetInsertPoint(drillLoc2)
            oDriller2.SetLinearHoleField(param.mHoleDia, "1*0", oDef.YDesc.Replace("x", "*"))
            parser2.Parse(oDef.YDesc)
            Dim len As Double = parser2.count * parser2.distance / 2
            oDriller2.SetYOffset(len)
            oDriller2.SetObjectId(plates.outterPlateId)
            oDriller2.Apply()

            For i As Integer = 0 To plates.innertPlateIds.Count - 1
                If (oDef.groupId <> i) Then
                    Continue For
                End If
                oDriller2.SetObjectId(plates.innertPlateIds(i))
                oDriller2.Apply()
            Next

            ''''''Because of the bug in the PS for handling the drill on the
            ''''''welding shape, we make a decision do not drill the column
            ''''''any more.
            'If GeoHelper.IsInSameDirection(colAdpt.YAxis, zDir) Then
            '    oDriller2.SetDrillType(DrillType.kDrillFlangeTop)
            'Else
            '    oDriller2.SetDrillType(DrillType.kDrillFlangeDown)
            'End If
            'oDriller2.SetObjectId(columnId)
            'If oDriller2.Apply() < 0 Then
            '    Debug.Assert(False)
            '    plates.drillModifyIds.Add(-1)
            'Else
            '    Dim id As Integer = oDriller2.GetModifyIndex()
            '    plates.drillModifyIds.Add(id)
            'End If
        Next

    End Sub

    Private Sub DrillSlotOnColumn(highPlateMat As PsMatrix, plates As CreatedColumnPlates)
        Dim org As New PsPoint
        highPlateMat.getOrigin(org)
        Dim xDir As New PsVector
        highPlateMat.getXAxis(xDir)
        Dim yDir As New PsVector
        highPlateMat.getYAxis(yDir)
        Dim zDir As New PsVector
        highPlateMat.getZAxis(zDir)

        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetFromPolygon(GetSlotPoly())
        oCreater.SetInsertMatrix(highPlateMat)
        oCreater.SetThickness(SlotCutThickness() * 2)
        If oCreater.Create() = False Then
            Debug.Assert(False)
        End If
        Dim boolPlate As Long = oCreater.ObjectId

        Dim oBoolCut As New PsCutObjects
        oBoolCut.SetToDefaults()
        oBoolCut.SetAsBooleanCut(boolPlate)
        oBoolCut.SetObjectId(columnId)
        If oBoolCut.Apply() = -1 Then
            Debug.Assert(False)
        End If

        plates.drillModifyIds.Add(oBoolCut.GetModifyIndex())

        Utility.EraseObjectId(boolPlate)

    End Sub

    Private Function SlotCutThickness() As Double
        Return param.mColumnWebConnectPlate.columnPlateThickness +
            param.mColumnWebConnectPlate.innerPlateThickness +
            param.mColumnWebConnectPlate.outterPlateThickness
    End Function

    Private Sub AddSlotOnPlates(highPlateMat As PsMatrix,
                                plates As CreatedColumnPlates)
        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim zDir As New PsVector
        highPlateMat.getXAxis(xDir)
        highPlateMat.getYAxis(yDir)
        Dim org As New PsPoint
        highPlateMat.getOrigin(org)

        Dim oPolyCut As New PsCutObjects
        oPolyCut.SetToDefaults()
        oPolyCut.SetAsPolyCut(GetSlotPoly(),
                                org, xDir, yDir, SlotCutThickness())

        oPolyCut.SetObjectId(plates.accessoryPlateId)
        oPolyCut.Apply()
        oPolyCut.SetObjectId(plates.outterPlateId)
        oPolyCut.Apply()

        For Each plateId As Long In plates.innertPlateIds
            oPolyCut.SetObjectId(plateId)
            oPolyCut.Apply()
        Next

        'org = MathTool.GetPointInDirection(org, yDir, param.mColumnGap / 2)
        Dim shpAdpt As New ShapeAdapter(supporingId2)
        Dim pt As PsPoint = MathTool.OrthoProjectPointToLine(org, shpAdpt.MidLineStart, shpAdpt.MidLineEnd)
        Dim cutDir As New PsVector
        cutDir.SetFromPoints(pt, org)
        cutDir.Normalize()

        Dim upperPoints As List(Of PsPoint) =
            UserConnection.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim oPlane As New PsCutPlane
        oPlane.SetFromNormal(upperPoints(1), cutDir)
        Dim oPlaneCut As New PsCutObjects
        oPlaneCut.SetToDefaults()
        oPlaneCut.SetAsPlaneCut(oPlane)
        oPlaneCut.SetObjectId(plates.accessoryPlateId)
        oPlaneCut.Apply()


        'For Each id In plates.innerWebPlateIds
        '    oPlaneCut.SetObjectId(id)
        '    oPlaneCut.Apply()
        'Next

    End Sub

    Private Function GetSlotPoly() As PsPolygon
        Dim l As Double = param.mColumnWebConnectPlate.centerDistance
        Dim r As Double = param.mColumnWebConnectPlate.radius

        Dim oPoly As New PsPolygon

        oPoly.appendVertex(r, 0, 0)
        oPoly.appendVertex(r, l / 2, 1)
        oPoly.appendVertex(-r, l / 2, 0)
        oPoly.appendVertex(-r, 0, 0)
        oPoly.appendVertex(-r, -l / 2, 1)
        oPoly.appendVertex(r, -l / 2, 0)
        oPoly.appendVertex(r, 0, 0)
        'oPoly.draw(CoordSystem.kWcs, "0", "0", 1)
        Return oPoly
    End Function

    Private Sub CreatePlates(oPlateMat As PsMatrix, plates As CreatedColumnPlates)

        plates.outterPlateId = Utility.CreatePlate(Me.ColumnWebConnectPlateWidth(),
                              Me.ColumnWebConnectPlateHeight(),
                              param.mColumnWebConnectPlate.outterPlateThickness,
                              0, 0, VerticalPosition.kDown,
                              oPlateMat)

        CreateInnerPlates(oPlateMat, plates)

        CreateAccessoryPlate(oPlateMat, plates)

        CreateInnerWebPlates(oPlateMat, plates)
    End Sub


    Private Sub CreateInnerWebPlates(oPlateMat As PsMatrix, plates As CreatedColumnPlates)
        Dim xDir As New PsVector
        oPlateMat.getXAxis(xDir)
        Dim yDir As New PsVector
        oPlateMat.getYAxis(yDir)
        Dim zDir As New PsVector
        oPlateMat.getZAxis(zDir)
        Dim org As New PsPoint
        oPlateMat.getOrigin(org)

        Dim webOrg As PsPoint = MathTool.GetPointInDirection(org, zDir, param.mColumnWebConnectPlate.outterPlateThickness +
                                             param.mColumnWebConnectPlate.columnPlateThickness +
                                             param.mColumnWebConnectPlate.innerPlateThickness)
        webOrg = MathTool.GetPointInDirection(webOrg, yDir, param.mColumnGap / 2)

        Dim colAdpt As New ShapeAdapter(columnId)
        webOrg = MathTool.GetPointInDirection(webOrg, -xDir, colAdpt.Width / 2)

        Dim shpAdpt As New ShapeAdapter(supporingId2)

        Dim pt As PsPoint = MathTool.OrthoProjectPointToLine(org, shpAdpt.MidLineStart, shpAdpt.MidLineEnd)
        Dim cutDir As New PsVector
        cutDir.SetFromPoints(pt, org)
        cutDir.Normalize()

        Dim upperPoints As List(Of PsPoint) =
            UserConnection.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim oPlane As New PsCutPlane
        Dim oPlane2 As New PsCutPlane
        oPlane.SetFromNormal(upperPoints(1), cutDir)
        Dim oPlaneCut As New PsCutObjects
        Dim oPlaneCut2 As New PsCutObjects

        Dim plateOrg As PsPoint
        Dim dist As Double = 0
        Dim webMat As New PsMatrix
        For Each oDef As ColumnWebDefinition In param.mColumnWebConnectPlate.XColumnWebs
            dist += oDef.edgeDistance
            plateOrg = MathTool.GetPointInDirection(webOrg, xDir, dist)
            webMat.SetCoordinateSystem(plateOrg, yDir, zDir)
            Dim id As Long = Utility.CreatePlate(oDef.length * 3 + param.mColumnGap, oDef.height, oDef.thickness,
                                                   0, -oDef.height / 2, VerticalPosition.kDown, webMat)

            oPlaneCut.SetToDefaults()
            oPlaneCut.SetAsPlaneCut(oPlane)
            oPlaneCut.SetObjectId(id)
            oPlaneCut.Apply()

            oPlaneCut2.SetToDefaults()
            oPlane2.SetFromNormal(MathTool.GetPointInDirection(upperPoints(1), yDir, oDef.length), -cutDir)
            oPlaneCut2.SetAsPlaneCut(oPlane2)
            oPlaneCut2.SetObjectId(id)
            oPlaneCut2.Apply()

            plates.innerWebPlateIds.Add(id)
            dist += oDef.thickness
        Next
    End Sub

    Private Sub CreateInnerPlates(oPlateMat As PsMatrix, plates As CreatedColumnPlates)
        Dim xDir As New PsVector
        oPlateMat.getXAxis(xDir)
        Dim yDir As New PsVector
        oPlateMat.getYAxis(yDir)
        Dim zDir As New PsVector
        oPlateMat.getZAxis(zDir)
        Dim org As New PsPoint
        oPlateMat.getOrigin(org)

        org = MathTool.GetPointInDirection(org, zDir, param.mColumnWebConnectPlate.outterPlateThickness +
                                             param.mColumnWebConnectPlate.columnPlateThickness)
        Dim highInnerMatrix As New PsMatrix

        Dim currentGroup = -1
        Dim edgeDist As Double = 0

        Dim holeLoc As Double = 0

        Dim startEdge As Double = 0
        Dim endEdge As Double = 0

        Dim plateOrg As PsPoint

        Dim innerOrg As PsPoint =
            MathTool.GetPointInDirection(org, -xDir, Me.ColumnWebConnectPlateWidth() / 2)

        Dim plateId As Long
        For i = 0 To Me.param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions.Count - 1
            Dim def As HoleColumnDefinition = param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions(i)
            If currentGroup = -1 Then
                currentGroup = def.groupId
                holeLoc = def.horDistance
                edgeDist = def.horDistance
            ElseIf currentGroup = def.groupId Then
                holeLoc += def.horDistance
            ElseIf currentGroup = def.groupId - 1 Then
                'we start the new group
                endEdge = holeLoc + edgeDist
                plateOrg = MathTool.GetPointInDirection(innerOrg, xDir, startEdge + (endEdge - startEdge) / 2)
                'drawBall(plateOrg, 20)
                highInnerMatrix.SetCoordinateSystem(plateOrg, xDir, yDir)
                plateId = Utility.CreatePlate(endEdge - startEdge,
                                                          Me.ColumnWebConnectPlateHeight(),
                                                          param.mColumnWebConnectPlate.innerPlateThickness,
                                                          0, 0, VerticalPosition.kDown, highInnerMatrix)
                plates.innertPlateIds.Add(plateId)

                holeLoc += def.horDistance
                startEdge = holeLoc - edgeDist
                endEdge = startEdge
                currentGroup = def.groupId
            End If
        Next
        endEdge = holeLoc + edgeDist
        plateOrg = MathTool.GetPointInDirection(innerOrg, xDir, startEdge + (endEdge - startEdge) / 2)
        'drawBall(plateOrg, 20)
        highInnerMatrix.SetCoordinateSystem(plateOrg, xDir, yDir)
        plateId = Utility.CreatePlate(endEdge - startEdge,
                                                          Me.ColumnWebConnectPlateHeight(),
                                                          param.mColumnWebConnectPlate.innerPlateThickness,
                                                          0, 0, VerticalPosition.kDown, highInnerMatrix)
        plates.innertPlateIds.Add(plateId)
    End Sub

    Private Sub CreateAccessoryPlate(oPlateMat As PsMatrix, plates As CreatedColumnPlates)

        Dim xDir2 As New PsVector
        oPlateMat.getXAxis(xDir2)
        Dim yDir2 As New PsVector
        oPlateMat.getYAxis(yDir2)
        Dim zDir2 As New PsVector
        oPlateMat.getZAxis(zDir2)
        Dim org2 As New PsPoint

        oPlateMat.getOrigin(org2)
        org2 = MathTool.GetPointInDirection(org2, zDir2, param.mColumnWebConnectPlate.outterPlateThickness)
        'drawBall(org, 20)
        Dim highAccessoryMatrix As New PsMatrix
        highAccessoryMatrix.SetCoordinateSystem(org2, xDir2, yDir2)
        plates.accessoryPlateId = Utility.CreatePlate(Me.ColumnWebAccessoryPlateWidth(),
                                                              Me.ColumnWebAccessoryPlateHeight(org2) * 2,
                                                              param.mColumnWebConnectPlate.columnPlateThickness,
                                                              0, 0,
                                                              VerticalPosition.kDown, highAccessoryMatrix)

    End Sub

    Private Function higherPlatesUcs() As PsMatrix
        Dim upperPoints As List(Of PsPoint) =
            UserConnection.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim instPt As New PsPoint
        Dim oMat As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(columnId, supporingId2, instPt, oMat) = False Then
            Debug.Assert(False)
        End If
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getZAxis(yAxis)
        Dim org As New PsPoint
        org = MathTool.GetPointInDirection(upperPoints(1), -yAxis, param.mColumnGap / 2)

        oMat.getYAxis(zAxis)
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        Dim oResult As New PsMatrix
        oResult.SetCoordinateSystem(org, xAxis, yAxis)

        'drawUcs(oResult)

        Return oResult
    End Function

    Private Function lowerPlatesUcs() As PsMatrix
        Dim upperPoints As List(Of PsPoint) =
            UserConnection.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim instPt As New PsPoint
        Dim oMat As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(columnId, supporingId2, instPt, oMat) = False Then
            Debug.Assert(False)
        End If
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getZAxis(yAxis)
        Dim org As New PsPoint
        org = MathTool.GetPointInDirection(upperPoints(2), -yAxis, param.mColumnGap / 2)

        oMat.getYAxis(zAxis)
        zAxis = -zAxis
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        Dim oResult As New PsMatrix
        oResult.SetCoordinateSystem(org, xAxis, yAxis)

        'drawUcs(oResult)

        Return oResult
    End Function

    Private Function ColumnWebAccessoryPlateHeight(pt As PsPoint) As Double
        'Dim height As Double = ColumnWebConnectPlateHeight() - param.mColumnGap
        'height /= 2
        Dim height As Double = Me.DistanceToUpperOfShape(pt)
        Return height
    End Function

    Private Function ColumnWebAccessoryPlateWidth() As Double
        Dim colAdpt As New ShapeAdapter(Me.columnId)
        Dim width = colAdpt.Width
        width -= 2 * param.mColumnWebConnectPlate.columnPlateThickness
        Return width
    End Function

    Private Function ColumnWebConnectPlateHeight() As Double
        Dim maxDist = 0
        Dim parser As New BoltDescParser
        For i As Integer = 0 To param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions.Count - 1
            Dim def As HoleColumnDefinition =
                param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions(i)
            If (parser.Parse(def.YDesc) = False) Then
                Debug.Assert(False)
                Continue For
            End If

            Dim len = parser.count * parser.distance
            If (maxDist < len) Then
                maxDist = len
            End If
        Next

        Dim result As Double = maxDist +
            param.mColumnWebConnectPlate.HoleGrop.upperEdgeDistance +
            param.mColumnWebConnectPlate.HoleGrop.lowerEdgeDistance

        result *= 2
        result += param.mColumnGap

        Return result
    End Function

    Private Function ColumnWebConnectPlateWidth() As Double
        Dim dist As Double = 0
        For i As Integer = 0 To param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions.Count - 1
            Dim def As HoleColumnDefinition =
                param.mColumnWebConnectPlate.HoleGrop.HoleColumnDefinitions(i)
            If i = 0 Then
                dist += def.horDistance * 2
            Else
                dist += def.horDistance
            End If
        Next
        Return dist
    End Function
End Class
