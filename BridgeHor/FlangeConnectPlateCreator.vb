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


Public Class FlangeConnectPlateCreator

    Private mConnMat1 As PsMatrix
    Private mHorId As Long
    Private mParam As Parameters

    Public mOutsidePlateId1 As Long
    Public mOutsidePlateId2 As Long

    Public mInsidePlateId11 As Long
    Public mInsidePlateId12 As Long

    Public mInsidePlateId21 As Long
    Public mInsidePlateId22 As Long

    Public Sub New(horId As Long,
                   connMat1 As PsMatrix,
                   param As Parameters)
        mHorId = horId
        mConnMat1 = connMat1
        mParam = param
    End Sub

    Public Sub Create()

        Dim org As New PsPoint
        mConnMat1.getOrigin(org)
        Dim zDir As New PsVector
        mConnMat1.getZAxis(zDir)
        org = MathTool.GetPointInDirection(org, -zDir, mParam.mHorCutback + mParam.mHorGap / 2)

        Dim shpAdpt As New ShapeAdapter(mHorId)

        Dim plateMatrix As New PsMatrix
        Dim xDir As New PsVector
        mConnMat1.getXAxis(xDir)
        plateMatrix.SetCoordinateSystem(org, xDir, zDir)

        Dim outPlateLength As Double = 2 * ((mParam.mFlangeConnectPlate.mVerCount - 1) * mParam.mFlangeConnectPlate.mVerDist +
                                  mParam.mFlangeConnectPlate.mVerEdgeDist) + mParam.mFlangeConnectPlate.mVerMiddleDist
        Dim outPlateWidth As Double = 2 * ((mParam.mFlangeConnectPlate.mHorCount - 1) * mParam.mFlangeConnectPlate.mHorDist +
                                  mParam.mFlangeConnectPlate.mHorEdgeDist) + mParam.mHorGap

        Dim oCreater As New PsCreatePlate
        oCreater.SetToDefaults()
        oCreater.SetInsertMatrix(plateMatrix)
        Dim instHeight As Double = (shpAdpt.Height + mParam.mFlangeConnectPlate.mOutsidePlateThickness) / 2
        oCreater.SetInsertHeight(instHeight)
        oCreater.SetAsRectangularPlate(outPlateLength, outPlateWidth)
        oCreater.SetThickness(mParam.mFlangeConnectPlate.mOutsidePlateThickness)
        If oCreater.Create() = True Then
            mOutsidePlateId1 = oCreater.ObjectId
        End If

        oCreater.SetInsertHeight(-instHeight)
        If oCreater.Create() = True Then
            mOutsidePlateId2 = oCreater.ObjectId
        End If


        Dim inPlateLength As Double = 2 * ((mParam.mFlangeConnectPlate.mVerCount - 1) * mParam.mFlangeConnectPlate.mVerDist +
                          mParam.mFlangeConnectPlate.mVerEdgeDist) + mParam.mFlangeConnectPlate.mVerMiddleDist
        Dim inPlateWidth As Double = (mParam.mFlangeConnectPlate.mHorCount - 1) * mParam.mFlangeConnectPlate.mHorDist +
                                  mParam.mFlangeConnectPlate.mHorEdgeDist

        instHeight = shpAdpt.Height / 2 - mParam.mHorPlateThickness - mParam.mFlangeConnectPlate.mInsidePlateThickness / 2
        oCreater.SetAsRectangularPlate(inPlateLength, inPlateWidth)
        oCreater.SetThickness(mParam.mFlangeConnectPlate.mInsidePlateThickness)
        oCreater.SetYOffset(inPlateWidth / 2 + mParam.mHorGap / 2)
        oCreater.SetInsertHeight(instHeight)
        If oCreater.Create() = True Then
            mInsidePlateId11 = oCreater.ObjectId
        End If
        oCreater.SetThickness(mParam.mFlangeConnectPlate.mInsidePlateThickness)
        oCreater.SetInsertHeight(-instHeight)
        If oCreater.Create() = True Then
            mInsidePlateId12 = oCreater.ObjectId
        End If

        oCreater.SetAsRectangularPlate(inPlateLength, inPlateWidth)
        oCreater.SetThickness(mParam.mFlangeConnectPlate.mInsidePlateThickness)
        oCreater.SetYOffset(-(inPlateWidth / 2 + mParam.mHorGap / 2))
        oCreater.SetInsertHeight(instHeight)
        If oCreater.Create() = True Then
            mInsidePlateId21 = oCreater.ObjectId
        End If
        oCreater.SetThickness(mParam.mFlangeConnectPlate.mInsidePlateThickness)
        oCreater.SetInsertHeight(-instHeight)
        If oCreater.Create() = True Then
            mInsidePlateId22 = oCreater.ObjectId
        End If

    End Sub

End Class
