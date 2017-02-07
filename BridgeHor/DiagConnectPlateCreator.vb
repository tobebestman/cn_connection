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

    Public mCutPlane As PsCutPlane
    Public mConnMat As PsMatrix
    Public mDiagId As Long
    Public mParam As Parameters

    Public mResult As List(Of Long)

    Public Sub New(cutPlane As PsCutPlane,
                   connMat As PsMatrix,
                   id As Long,
                   param As Parameters)
        mConnMat = connMat
        mDiagId = id
        mCutPlane = cutPlane
        mParam = param

        mResult = New List(Of Long)
    End Sub

    Public Function Create() As Boolean

        Dim oMat As PsMatrix = calculateInsertMatrix()
        Dim diagAdpt As New UserConnection.DiagShapeAdapter(mConnMat, mDiagId)
        Dim length As Double = getPlateLength()
        Dim width As Double = getPlateWidth()

        Dim insertOffset As Double
        insertOffset = diagAdpt.GetFaceDistanceInSideDir() / 2 +
                       mParam.mSidePlate.mBackingPlateThickness +
                       mParam.mDiagFlangeConnectPlate.thickness / 2

        Dim id As Long = Utility.CreatePlate(width, length, mParam.mDiagFlangeConnectPlate.thickness,
                             0, 0, insertOffset,
                             VerticalPosition.kMiddle, oMat)

        If (id <> -1) Then
            mResult.Add(id)
        Else
            Debug.Assert(False)
            Return False
        End If
        id = Utility.CreatePlate(width, length, mParam.mDiagFlangeConnectPlate.thickness,
                             0, 0, -insertOffset,
                             VerticalPosition.kMiddle, oMat)
        If (id <> -1) Then
            mResult.Add(id)
        Else
            Debug.Assert(False)
            Return False
        End If

        Return True

    End Function


    Private Function calculateInsertMatrix() As PsMatrix

        Dim xDir As New PsVector
        mConnMat.getZAxis(xDir)

        Dim org As PsPoint = MathTool.GetPointInDirection(mCutPlane.InsertPoint, xDir, mParam.mDiagnalGap / 2)



        Dim diagAdpt As New UserConnection.DiagShapeAdapter(mConnMat, mDiagId)

        Dim zDir As PsVector = diagAdpt.SideDir()
        Dim yDir As New PsVector
        yDir.SetFromCrossProduct(zDir, xDir)
        yDir.Normalize()

        'make sure the org is on the center line of the shape
        Dim shpAdpt As New ShapeAdapter(mDiagId)
        org = MathTool.OrthoProjectPointToLine(org, shpAdpt.MidLineEnd, shpAdpt.MidLineStart)

        Dim result As New PsMatrix
        result.SetCoordinateSystem(org, xDir, yDir)

        Return result
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
