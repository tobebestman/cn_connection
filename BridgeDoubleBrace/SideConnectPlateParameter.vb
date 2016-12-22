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

Imports System.Windows.Forms


Public Class SideConnectPlateParameter
    Implements IParameters, ISetToDefauts
    Public FlangeThickness As Double
    Public horSideDistance As Double
    Public horDistance As Double
    Public horHoleCount As Integer
    Public verSideDistance As Double
    Public verDistance As Double
    Public verHoleCount As Integer
    Public outSidePlateThickness As Double
    Public insidePlateThickness As Double

    Public drillModifyIndices As List(Of Integer)

    Public owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
        drillModifyIndices = New List(Of Integer)
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.FlangeThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horSideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        Me.verSideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.verDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.verHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        Me.outSidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.insidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer
        count = eConnection.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To count - 1
            Me.drillModifyIndices.Add(eConnection.Number(iNum))
            iNum = iNum + 1
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.FlangeThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horSideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horHoleCount = Template.Number(iNum) : iNum = iNum + 1
        Me.verSideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.verDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.verHoleCount = Template.Number(iNum) : iNum = iNum + 1
        Me.outSidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.insidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.FlangeThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.horSideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.horDistance : iDbl = iDbl + 1
        eConnection.Number(iNum) = Me.horHoleCount : iNum = iNum + 1
        eConnection.Double(iDbl) = Me.verSideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.verDistance : iDbl = iDbl + 1
        eConnection.Number(iNum) = Me.verHoleCount : iNum = iNum + 1
        eConnection.Double(iDbl) = Me.outSidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.insidePlateThickness : iDbl = iDbl + 1

        eConnection.Number(iNum) = Me.drillModifyIndices.Count : iNum = iNum + 1
        For Each id As Integer In Me.drillModifyIndices
            eConnection.Number(iNum) = id
            iNum = iNum + 1
        Next

    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.FlangeThickness)
        Template.AppendDouble(Me.horSideDistance)
        Template.AppendDouble(Me.horDistance)
        Template.AppendNumber(Me.horHoleCount)
        Template.AppendDouble(Me.verSideDistance)
        Template.AppendDouble(Me.verDistance)
        Template.AppendNumber(Me.verHoleCount)
        Template.AppendDouble(Me.outSidePlateThickness)
        Template.AppendDouble(Me.insidePlateThickness)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        FlangeThickness = 30
        horSideDistance = 50
        horDistance = 100
        horHoleCount = 4
        verSideDistance = 50
        verDistance = 100
        verHoleCount = 8
        outSidePlateThickness = 22
        insidePlateThickness = 26
    End Sub
End Class