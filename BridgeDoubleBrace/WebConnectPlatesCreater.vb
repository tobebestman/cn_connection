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

