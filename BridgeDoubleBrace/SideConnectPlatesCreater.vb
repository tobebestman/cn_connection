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

