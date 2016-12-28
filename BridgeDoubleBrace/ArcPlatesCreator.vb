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