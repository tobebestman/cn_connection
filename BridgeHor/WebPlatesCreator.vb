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
    Public SupportPlateIds As List(Of Long)

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


    Private MathTool As New PsGeometryFunctions


    Public Sub New(horId As Long, param As Parameters, connMat As PsMatrix)
        Me.mHorId = horId
        Me.mParam = param
        Me.mBaseUcs = connMat
    End Sub

    Public Sub CreatePlates()
        CreateChordSidePlate()
        CreateBraceSidePlate()
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
