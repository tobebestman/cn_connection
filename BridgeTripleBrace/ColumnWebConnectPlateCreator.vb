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
    Public innertPlateId As Long
    Public outterPlateId As Long
    Public accessoryPlateId As Long

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
        CreateHigherPlates()
        Dim highPlateMat As PsMatrix = higherPlatesUcs()
        AddSlotOnPlates(highPlateMat, higherPlates)
        DrillSlotOnColumn(highPlateMat, higherPlates)

        CreateLowerPlates()
        Dim lowerPlateMat As PsMatrix = lowerPlatesUcs()
        AddSlotOnPlates(lowerPlateMat, lowerPlates)
        DrillSlotOnColumn(lowerPlateMat, lowerPlates)
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
        oPolyCut.SetObjectId(plates.innertPlateId)
        oPolyCut.Apply()

        org = MathTool.GetPointInDirection(org, yDir, param.mColumnGap / 2)

        Dim oPlane As New PsCutPlane
        oPlane.SetFromNormal(org, -yDir)
        Dim oPlaneCut As New PsCutObjects
        oPlaneCut.SetToDefaults()
        oPlaneCut.SetAsPlaneCut(oPlane)
        oPlaneCut.SetObjectId(plates.accessoryPlateId)
        oPlaneCut.Apply()
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

    Private Sub CreateLowerPlates()
        Dim lowerPlateMat As PsMatrix = lowerPlatesUcs()
        lowerPlates.outterPlateId = Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                              Me.ColumnWebConnectPlateHeight,
                              param.mColumnWebConnectPlate.outterPlateThickness,
                              0, 0, VerticalPosition.kDown,
                              lowerPlateMat)

        Dim xDir2 As New PsVector
        lowerPlateMat.getXAxis(xDir2)
        Dim yDir2 As New PsVector
        lowerPlateMat.getYAxis(yDir2)

        Dim zDir2 As New PsVector
        lowerPlateMat.getZAxis(zDir2)
        Dim org2 As New PsPoint
        lowerPlateMat.getOrigin(org2)
        org2 = MathTool.GetPointInDirection(org2, zDir2, param.mColumnWebConnectPlate.innerPlateThickness +
                                             param.mColumnWebConnectPlate.columnPlateThickness)
        Dim lowerInnerMatrix As New PsMatrix
        lowerInnerMatrix.SetCoordinateSystem(org2, xDir2, yDir2)
        lowerPlates.innertPlateId = Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                      Me.ColumnWebConnectPlateHeight,
                      param.mColumnWebConnectPlate.outterPlateThickness,
                      0, 0, VerticalPosition.kDown,
                      lowerInnerMatrix)

        lowerPlateMat.getOrigin(org2)
        org2 = MathTool.GetPointInDirection(org2, yDir2, param.mColumnGap / 2)
        org2 = MathTool.GetPointInDirection(org2, zDir2, param.mColumnWebConnectPlate.outterPlateThickness)
        Dim lowAccessoryMatrix As New PsMatrix
        lowAccessoryMatrix.SetCoordinateSystem(org2, xDir2, yDir2)
        lowerPlates.accessoryPlateId = Utility.CreatePlate(Me.ColumnWebAccessoryPlateWidth(),
                                                              Me.ColumnWebAccessoryPlateHeight() * 2,
                                                              param.mColumnWebConnectPlate.columnPlateThickness,
                                                              0, 0,
                                                              VerticalPosition.kDown, lowAccessoryMatrix)

    End Sub

    Private Sub CreateHigherPlates()
        Dim oHighOutMat As PsMatrix = higherPlatesUcs()

        higherPlates.outterPlateId = Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                              Me.ColumnWebConnectPlateHeight(),
                              param.mColumnWebConnectPlate.outterPlateThickness,
                              0, 0, VerticalPosition.kDown,
                              oHighOutMat)

        Dim xDir As New PsVector
        oHighOutMat.getXAxis(xDir)
        Dim yDir As New PsVector
        oHighOutMat.getYAxis(yDir)

        Dim zDir As New PsVector
        oHighOutMat.getZAxis(zDir)
        Dim org As New PsPoint
        oHighOutMat.getOrigin(org)
        org = MathTool.GetPointInDirection(org, zDir, param.mColumnWebConnectPlate.outterPlateThickness +
                                             param.mColumnWebConnectPlate.columnPlateThickness)
        Dim highInnerMatrix As New PsMatrix
        highInnerMatrix.SetCoordinateSystem(org, xDir, yDir)
        higherPlates.innertPlateId = Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                                                            Me.ColumnWebConnectPlateHeight(),
                                                            param.mColumnWebConnectPlate.innerPlateThickness,
                                                            0, 0, VerticalPosition.kDown, highInnerMatrix)

        oHighOutMat.getOrigin(org)
        org = MathTool.GetPointInDirection(org, yDir, param.mColumnGap / 2)
        org = MathTool.GetPointInDirection(org, zDir, param.mColumnWebConnectPlate.outterPlateThickness)
        Dim highAccessoryMatrix As New PsMatrix
        highAccessoryMatrix.SetCoordinateSystem(org, xDir, yDir)
        higherPlates.accessoryPlateId = Utility.CreatePlate(Me.ColumnWebAccessoryPlateWidth(),
                                                              Me.ColumnWebAccessoryPlateHeight() * 2,
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
        oResult.SetCoordinateSystem(upperPoints(2), xAxis, yAxis)
        Return oResult
    End Function

    Private Function ColumnWebAccessoryPlateHeight() As Double
        Dim height As Double = ColumnWebConnectPlateHeight() - param.mColumnGap
        height /= 2
        Return height
    End Function

    Private Function ColumnWebAccessoryPlateWidth() As Double
        Dim colAdpt As New ShapeAdapter(Me.columnId)
        Dim width = colAdpt.Height
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

    Private Function ColumWebConnectPlateWidth() As Double
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
