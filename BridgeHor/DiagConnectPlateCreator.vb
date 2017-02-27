Option Strict Off
Option Explicit On

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

Imports PlugInBase
Imports PlugInBase.PlugInCommon
Imports PlugInBase.PlugInCommon.CommonFunctions
Imports PSN_SubstationShared.UnitConvert
Imports PSN_BridgeHor

Public Class DiagConnectPlateCreator

    Public mMidPt As PsPoint
    Public mDiagHoleMat As PsMatrix
    Public mDiagId As Long
    Public mParam As Parameters

    Public mResult As List(Of Long)

    Public Sub New(midPt As PsPoint,
                   diagHoleMat As PsMatrix,
                   id As Long,
                   param As Parameters)
        mDiagHoleMat = diagHoleMat
        mDiagId = id
        mMidPt = midPt
        mParam = param

        mResult = New List(Of Long)
    End Sub

    Public Function Create(plateId As Long) As Boolean

        If mParam.mDiagFlangeConnectPlate.holeDefs Is Nothing Then
            Return False
        End If

        Dim xDir As New PsVector
        mDiagHoleMat.getXAxis(xDir)
        Dim yDir As New PsVector
        mDiagHoleMat.getYAxis(yDir)
        Dim zDir As New PsVector
        mDiagHoleMat.getZAxis(zDir)

        Dim org As New PsPoint
        mDiagHoleMat.getOrigin(org)

        Dim xDist As Double = mParam.mDiagFlangeConnectPlate.middleDistance / 2
        Dim oDef As HoleColumnDefinition

        For i As Integer = mParam.mDiagFlangeConnectPlate.holeDefs.Count - 1 To 0 Step -1
            oDef = mParam.mDiagFlangeConnectPlate.holeDefs(i)

            Dim oCenter As New PsPoint
            oCenter = MathTool.GetPointInDirection(org, xDir, xDist)
            oCenter = MathTool.GetPointInDirection(oCenter, yDir, oDef.edgeDistance)

            'Utility.drawBall(oCenter, 30)

            Dim oPlateAdpt As New PlateAdapter(plateId)
            Dim plateDir As PsVector = oPlateAdpt.GetDirection
            If GeoHelper.IsInSameDirection(plateDir, zDir) = True Then
                oCenter = MathTool.OrthoProjectPointToPlane(oCenter, oPlateAdpt.MidLineStart, zDir)
            Else
                oCenter = MathTool.OrthoProjectPointToPlane(oCenter, oPlateAdpt.MidLineEnd, zDir)
            End If


            xDist += oDef.horDistance

            Dim oDrill As New PsDrillObject
            oDrill.SetToDefaults()
            oDrill.SetXYPlane(xDir, yDir)

            Dim oParser As New Utility.BoltDescParser()
            If oParser.Parse(oDef.YDesc) = False Then
                Debug.Assert(False)
                Continue For
            End If

            Dim yOffset As Double = oParser.count * oParser.distance
            oDrill.SetYOffset(yOffset / 2)
            oDrill.SetInsertPoint(oCenter)
            oDrill.SetLinearHoleField(mParam.mHoleDia, "1*0", oDef.YDesc.Replace("x", "*"))
            oDrill.SetObjectId(plateId)
            oDrill.Apply()
        Next

        'Utility.drawUcs(oMat)
        Dim xDist2 As Double = mParam.mDiagFlangeConnectPlate.middleDistance / 2
        Dim oDef2 As HoleColumnDefinition

        For i As Integer = mParam.mDiagFlangeConnectPlate.holeDefs.Count - 1 To 0 Step -1
            oDef2 = mParam.mDiagFlangeConnectPlate.holeDefs(i)

            Dim oCenter As New PsPoint
            oCenter = MathTool.GetPointInDirection(org, -xDir, xDist2)
            oCenter = MathTool.GetPointInDirection(oCenter, yDir, oDef2.edgeDistance)

            'Utility.drawBall(oCenter, 30)

            Dim oPlateAdpt As New PlateAdapter(plateId)
            Dim plateDir As PsVector = oPlateAdpt.GetDirection
            If GeoHelper.IsInSameDirection(plateDir, zDir) = True Then
                oCenter = MathTool.OrthoProjectPointToPlane(oCenter, oPlateAdpt.MidLineStart, zDir)
            Else
                oCenter = MathTool.OrthoProjectPointToPlane(oCenter, oPlateAdpt.MidLineEnd, zDir)
            End If


            xDist2 += oDef2.horDistance

            Dim oDrill As New PsDrillObject
            oDrill.SetToDefaults()
            oDrill.SetXYPlane(xDir, yDir)

            Dim oParser As New Utility.BoltDescParser()
            If oParser.Parse(oDef2.YDesc) = False Then
                Debug.Assert(False)
                Continue For
            End If

            Dim yOffset As Double = oParser.count * oParser.distance
            oDrill.SetYOffset(yOffset / 2)
            oDrill.SetInsertPoint(oCenter)
            oDrill.SetLinearHoleField(mParam.mHoleDia, "1*0", oDef2.YDesc.Replace("x", "*"))
            oDrill.SetObjectId(plateId)
            oDrill.Apply()
        Next

        Return True

    End Function


    Public Function getPlateLength() As Double
        If (mParam.mDiagFlangeConnectPlate Is Nothing) Then
            Debug.Assert(False)
            Return 0
        End If

        Dim length As Double = 0
        For Each oDef As HoleColumnDefinition In mParam.mDiagFlangeConnectPlate.holeDefs
            length = length + oDef.horDistance
        Next
        Return length
    End Function

    Public Function getPlateWidth() As Double
        If (mParam.mDiagFlangeConnectPlate Is Nothing) Then
            Debug.Assert(False)
            Return 0
        End If

        Dim bp As New BoltDescParser
        Dim maxLength As Double = 0
        For Each oDef As HoleColumnDefinition In mParam.mDiagFlangeConnectPlate.holeDefs
            Dim length As Double = oDef.edgeDistance * 2
            If bp.Parse(oDef.YDesc) = True Then
                length = length + bp.count * bp.distance
            End If

            length = length + mParam.mDiagFlangeConnectPlate.middleDistance
            If length > maxLength Then
                maxLength = length
            End If
        Next

        Return maxLength
    End Function

End Class
