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
Public Class WebPlatesCreator

    Public ChordSidePlateId As Long
    Public BraceSidePlateId As Long
    Public SupportPlateId1 As Long
    Public SupportPlateId2 As Long

    Public ConnectPlateIds As New List(Of Long)

    Private MathTool As New PsGeometryFunctions

    Private mParam As Parameters
    Private mBaseUcs As PsMatrix
    Private mHorId As Long

    ReadOnly Property mChordSidePlateUcs() As PsMatrix
        Get
            Dim xDir As New PsVector
            Dim yDir As New PsVector
            Dim org As New PsPoint

            mBaseUcs.getOrigin(org)
            mBaseUcs.getZAxis(xDir)
            mBaseUcs.getYAxis(yDir)

            org = MathTool.GetPointInDirection(org, -xDir, mParam.mHorCutback / 2)

            Dim result As New PsMatrix
            result.SetCoordinateSystem(org, xDir, yDir)
            Return result
        End Get
    End Property

    ReadOnly Property mBraceSidePlateUcs() As PsMatrix
        Get
            Dim xDir As New PsVector
            Dim yDir As New PsVector
            Dim org As New PsPoint

            mBaseUcs.getOrigin(org)
            mBaseUcs.getZAxis(xDir)
            mBaseUcs.getYAxis(yDir)

            org = MathTool.GetPointInDirection(org, -xDir,
                 (mParam.mHorCutback + mParam.mHorGap) + mParam.mWebPlates.mBraceSidePlateLength / 2)

            Dim result As New PsMatrix
            result.SetCoordinateSystem(org, xDir, yDir)
            Return result
        End Get
    End Property


    Private Sub DrillPlates()

        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim zDir As New PsVector
        Dim org As New PsPoint

        mBaseUcs.getOrigin(org)
        mBaseUcs.getZAxis(xDir)
        mBaseUcs.getYAxis(yDir)
        mBaseUcs.getXAxis(zDir)

        Dim plateOrg As PsPoint = MathTool.GetPointInDirection(org, -xDir,
                 (mParam.mHorCutback + mParam.mHorGap / 2))

        Dim drillOrg As PsPoint = MathTool.GetPointInDirection(plateOrg, -zDir,
                         (mParam.mWebPlates.mChordSidePlateThickness / 2 + mParam.mWebPlates.mConnectPlateThickness))

        Dim oDriller As New PsDrillObject
        oDriller.SetToDefaults()
        oDriller.SetInsertPoint(drillOrg)
        oDriller.SetXYPlane(xDir, yDir)
        Dim xDesc As String
        xDesc = mParam.mWebPlates.mHorHoleCount.ToString() + "x" + mParam.mWebPlates.mHorHoleDist.ToString() + "," +
                (2 * mParam.mWebPlates.mHorHoleEdgeDist + mParam.mHorGap).ToString() + "," +
                mParam.mWebPlates.mHorHoleCount.ToString() + "x" + mParam.mWebPlates.mHorHoleDist.ToString()

        oDriller.SetLinearHoleField(mParam.mWebPlates.mHoleDiameter, xDesc,
                                     mParam.mWebPlates.mVerHoleCount.ToString() + "x" + mParam.mWebPlates.mVerHoleDist.ToString())

        oDriller.SetObjectId(Me.ChordSidePlateId)
        oDriller.Apply()
        oDriller.SetObjectId(Me.BraceSidePlateId)
        oDriller.Apply()

        For Each id As Long In Me.ConnectPlateIds
            oDriller.SetObjectId(id)
            oDriller.Apply()
        Next

    End Sub

    Private Sub CreateConnectPlates()

        Dim plateWidth = 2 * ((mParam.mWebPlates.mHorHoleCount - 1) *
                          mParam.mWebPlates.mHorHoleDist +
                          2 * mParam.mWebPlates.mHorHoleEdgeDist) +
                          mParam.mHorGap

        Dim plateLength = (mParam.mWebPlates.mVerHoleCount - 1) *
                          mParam.mWebPlates.mVerHoleDist +
                          2 * mParam.mWebPlates.mVerHoleEdgeDist

        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim zDir As New PsVector
        Dim org As New PsPoint

        mBaseUcs.getOrigin(org)
        mBaseUcs.getZAxis(xDir)
        mBaseUcs.getYAxis(yDir)
        mBaseUcs.getXAxis(zDir)

        Dim plateOrg As PsPoint = MathTool.GetPointInDirection(org, -xDir,
                 (mParam.mHorCutback + mParam.mHorGap / 2))

        If ConnectPlateIds.Count > 0 Then
            ConnectPlateIds.Clear()
            Debug.Assert(False)
        End If

        Dim plateUcs As New PsMatrix
        plateUcs.SetCoordinateSystem(
                MathTool.GetPointInDirection(plateOrg, zDir,
                         (mParam.mWebPlates.mChordSidePlateThickness + mParam.mWebPlates.mConnectPlateThickness) / 2),
                         xDir, yDir)
        Dim plateId As Long = Utility.CreatePlate(plateWidth, plateLength, mParam.mWebPlates.mConnectPlateThickness,
                                                  0, 0, VerticalPosition.kMiddle, plateUcs)
        Me.ConnectPlateIds.Add(plateId)

        plateUcs.SetCoordinateSystem(
                MathTool.GetPointInDirection(plateOrg, -zDir,
                         (mParam.mWebPlates.mChordSidePlateThickness + mParam.mWebPlates.mConnectPlateThickness) / 2),
                         xDir, yDir)
        plateId = Utility.CreatePlate(plateWidth, plateLength, mParam.mWebPlates.mConnectPlateThickness,
                                                  0, 0, VerticalPosition.kMiddle, plateUcs)

        Me.ConnectPlateIds.Add(plateId)

    End Sub

    Private Function CreateSupportPlate1() As Long

        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim org As New PsPoint

        mBaseUcs.getOrigin(org)
        mBaseUcs.getZAxis(xDir)
        mBaseUcs.getYAxis(yDir)

        Dim plateOrg As PsPoint = MathTool.GetPointInDirection(org, -xDir,
                 (mParam.mHorCutback + mParam.mHorGap) +
                  mParam.mWebPlates.mBraceSidePlateLength -
                  mParam.mWebPlates.mSupportPlateOffset)

        Dim zDir As New PsVector
        mBaseUcs.getXAxis(zDir)

        Dim Length As Double = UserConnection.GetHorMemberFlangeWidth(mHorId, mBaseUcs, mParam) -
                               mParam.mHorPlateThickness

        Dim sidePt As New PsPoint
        sidePt = MathTool.GetPointInDirection(org, -xDir, mParam.mHorWebCutback)
        sidePt = MathTool.GetPointInDirection(sidePt, zDir,
                 Length / 2)

        Dim Width As Double = sidePt.get_DistanceTo(plateOrg)

        xDir.SetFromPoints(plateOrg, sidePt)
        xDir.Normalize()

        plateOrg = MathTool.GetPointInDirection(plateOrg, xDir, Width / 2)

        Dim plateUcs As New PsMatrix
        plateUcs.SetCoordinateSystem(plateOrg, xDir, yDir)

        Dim result As Long = Utility.CreatePlate(Width, Length, mParam.mWebPlates.mBraceSidePlateThickness,
                            0, 0, VerticalPosition.kMiddle, plateUcs)
        Return result
    End Function

    Private Function CreateSupportPlate2() As Long

        Dim xDir As New PsVector
        Dim yDir As New PsVector
        Dim org As New PsPoint

        mBaseUcs.getOrigin(org)
        mBaseUcs.getZAxis(xDir)
        mBaseUcs.getYAxis(yDir)

        Dim plateOrg As PsPoint = MathTool.GetPointInDirection(org, -xDir,
                 (mParam.mHorCutback + mParam.mHorGap) +
                  mParam.mWebPlates.mBraceSidePlateLength -
                  mParam.mWebPlates.mSupportPlateOffset)

        Dim zDir As New PsVector
        mBaseUcs.getXAxis(zDir)

        Dim Length As Double = UserConnection.GetHorMemberFlangeWidth(mHorId, mBaseUcs, mParam) -
                               mParam.mHorPlateThickness

        Dim sidePt As New PsPoint
        sidePt = MathTool.GetPointInDirection(org, -xDir, mParam.mHorWebCutback)
        sidePt = MathTool.GetPointInDirection(sidePt, -zDir,
                 Length / 2)

        Dim Width As Double = sidePt.get_DistanceTo(plateOrg)

        xDir.SetFromPoints(plateOrg, sidePt)
        xDir.Normalize()

        plateOrg = MathTool.GetPointInDirection(plateOrg, xDir, Width / 2)

        Dim plateUcs As New PsMatrix
        plateUcs.SetCoordinateSystem(plateOrg, xDir, yDir)

        Dim result As Long = Utility.CreatePlate(Width, Length, mParam.mWebPlates.mBraceSidePlateThickness,
                            0, 0, VerticalPosition.kMiddle, plateUcs)
        Return result
    End Function


    Public Sub New(horId As Long, param As Parameters, connMat As PsMatrix)
        Me.mHorId = horId
        Me.mParam = param
        Me.mBaseUcs = connMat
    End Sub

    Public Sub Create()
        CreateChordSidePlate()
        CreateBraceSidePlate()

        SupportPlateId1 = CreateSupportPlate1()
        SupportPlateId2 = CreateSupportPlate2()

        CreateConnectPlates()

        DrillPlates()
    End Sub
    Private Sub CreateChordSidePlate()
        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetThickness(mParam.mWebPlates.mChordSidePlateThickness)
        oCreater.SetInsertMatrix(mChordSidePlateUcs)
        oCreater.SetNormalPosition(VerticalPosition.kMiddle)
        oCreater.SetAsRectangularPlate(mParam.mHorCutback,
                                       UserConnection.GetHorMemberWebHeight(mHorId, mBaseUcs, mParam))
        If oCreater.Create() = False Then
            Debug.Assert(False)
        Else
            ChordSidePlateId = oCreater.ObjectId
        End If
    End Sub

    Private Sub CreateBraceSidePlate()
        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetThickness(mParam.mWebPlates.mBraceSidePlateThickness)
        oCreater.SetInsertMatrix(mBraceSidePlateUcs)
        oCreater.SetNormalPosition(VerticalPosition.kMiddle)
        oCreater.SetAsRectangularPlate(mParam.mWebPlates.mBraceSidePlateLength,
                                       UserConnection.GetHorMemberWebHeight(mHorId, mBaseUcs, mParam))
        If oCreater.Create() = False Then
            Debug.Assert(False)
        Else
            BraceSidePlateId = oCreater.ObjectId
        End If
    End Sub
End Class
