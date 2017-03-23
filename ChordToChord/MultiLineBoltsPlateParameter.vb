Option Strict Off
Option Explicit On

Imports System.Collections.Generic

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
Imports PSN_ChordToChord

Public Class HoleLineDefinition
    Implements IParameters, ISetToDefauts

    Public horDistance As Double
    Public YDesc As String
    Public groupId As Integer

    Public Sub New(horDistance As Double, YDesc As String, groupId As Integer)
        Me.horDistance = horDistance
        Me.YDesc = YDesc
        Me.groupId = groupId
    End Sub

    Public Sub New()
        SetToMetricDefaults()
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.horDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = eConnection.String(iStr) : iStr = iStr + 1
        Me.groupId = eConnection.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.horDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = Template.String(iStr) : iStr = iStr + 1
        Me.groupId = Template.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.horDistance : iDbl = iDbl + 1
        eConnection.String(iStr) = Me.YDesc : iStr = iStr + 1
        eConnection.Number(iNum) = Me.groupId : iNum = iNum + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.horDistance)
        Template.AppendString(Me.YDesc)
        Template.AppendNumber(Me.groupId)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        horDistance = 0
        YDesc = ""
        groupId = 0
    End Sub
End Class

Public Class HoleGroupDefinition
    Implements IParameters

    Public upperEdgeDistance As Double
    Public lowerEdgeDistance As Double
    Public HoleColumnDefinitions As List(Of HoleLineDefinition)
    Public Sub New()
        HoleColumnDefinitions = New List(Of HoleLineDefinition)()
    End Sub
    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.upperEdgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.lowerEdgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer = eConnection.Number(iNum) : iNum = iNum + 1
        HoleColumnDefinitions = New List(Of HoleLineDefinition)
        For i As Integer = 0 To count - 1
            Dim oDef As New HoleLineDefinition
            oDef.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
            HoleColumnDefinitions.Add(oDef)
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.upperEdgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.lowerEdgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer = Template.Number(iNum) : iNum = iNum + 1
        HoleColumnDefinitions = New List(Of HoleLineDefinition)
        For i As Integer = 0 To count - 1
            Dim oDef As New HoleLineDefinition
            oDef.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
            HoleColumnDefinitions.Add(oDef)
        Next
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.upperEdgeDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.lowerEdgeDistance : iDbl = iDbl + 1
        eConnection.Number(iNum) = HoleColumnDefinitions.Count : iNum = iNum + 1
        For i As Integer = 0 To HoleColumnDefinitions.Count - 1
            HoleColumnDefinitions(i).WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        Next
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(upperEdgeDistance)
        Template.AppendDouble(lowerEdgeDistance)
        Template.AppendNumber(HoleColumnDefinitions.Count)
        For i As Integer = 0 To HoleColumnDefinitions.Count - 1
            HoleColumnDefinitions(i).WriteToTemplate(Template)
        Next
    End Sub
End Class

Public Class MultiBoltsPlateParameters
    Implements IParameters

    Public outterPlateThickness As Double
    Public innerPlateThickness As Double

    Public centerDistance As Double
    Public radius As Double

    Public HoleGrop As HoleGroupDefinition

    Public owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
        HoleGrop = New HoleGroupDefinition()
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.outterPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.innerPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.centerDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = eConnection.Double(iDbl) : iDbl = iDbl + 1
        HoleGrop.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)


    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.outterPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.innerPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.centerDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = Template.Double(iDbl) : iDbl = iDbl + 1
        HoleGrop.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.outterPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.innerPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.centerDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.radius : iDbl = iDbl + 1
        HoleGrop.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.outterPlateThickness)
        Template.AppendDouble(Me.innerPlateThickness)
        Template.AppendDouble(Me.centerDistance)
        Template.AppendDouble(Me.radius)
        HoleGrop.WriteToTemplate(Template)

    End Sub
End Class


