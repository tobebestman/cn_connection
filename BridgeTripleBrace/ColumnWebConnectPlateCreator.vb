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
End Class

Public Class ColumnWebConnectPlateCreator
    Dim supporingId2 As Long
    Dim columnId As Long
    Dim param As Parameters

    Dim higherPlates As CreatedColumnPlates
    Dim lowerPlates As CreatedColumnPlates

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
        Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                              Me.ColumnWebConnectPlateHeight(),
                              param.mColumnWebConnectPlate.outterPlateThickness,
                              0, 0, VerticalPosition.kDown,
                              higherPlatesUcs)

        Utility.CreatePlate(Me.ColumWebConnectPlateWidth(),
                              Me.ColumnWebConnectPlateHeight,
                              param.mColumnWebConnectPlate.outterPlateThickness,
                              0, 0, VerticalPosition.kDown,
                              lowerPlatesUcs)
    End Sub

    Private Function higherPlatesUcs() As PsMatrix
        Dim upperPoints As List(Of PsPoint) =
            Utility.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim instPt As New PsPoint
        Dim oMat As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(columnId, supporingId2, instPt, oMat) = False Then
            Debug.Assert(False)
        End If
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getZAxis(yAxis)

        oMat.getYAxis(zAxis)
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        Dim oResult As New PsMatrix
        oResult.SetCoordinateSystem(upperPoints(1), xAxis, yAxis)
        Return oResult
    End Function

    Private Function lowerPlatesUcs() As PsMatrix
        Dim upperPoints As List(Of PsPoint) =
            Utility.GetTopHalfSidePlateBooleanCutBoundary(param, supporingId2, columnId)

        Dim instPt As New PsPoint
        Dim oMat As New PsMatrix
        If Utility.GetIntersectPtAndUcsBySupportAndConnectMembers(columnId, supporingId2, instPt, oMat) = False Then
            Debug.Assert(False)
        End If
        Dim xAxis As New PsVector
        Dim yAxis As New PsVector
        Dim zAxis As New PsVector

        oMat.getZAxis(yAxis)
        yAxis = -yAxis

        oMat.getYAxis(zAxis)
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        Dim oResult As New PsMatrix
        oResult.SetCoordinateSystem(upperPoints(2), xAxis, yAxis)
        Return oResult
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
