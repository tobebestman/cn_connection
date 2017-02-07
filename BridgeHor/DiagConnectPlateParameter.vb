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
Imports System.Windows.Forms
Public Class HoleColumnDefinition
    Implements IParameters, ISetToDefauts

    Public edgeDistance As Double
    Public horDistance As Double
    Public YDesc As String
    Public groupId As Integer

    Public Sub New(edgeDistance As Double,
                   horDistance As Double,
                   YDesc As String,
                   groupId As Integer)
        Me.edgeDistance = edgeDistance
        Me.horDistance = horDistance
        Me.YDesc = YDesc
        Me.groupId = groupId
    End Sub

    Public Sub New()
        SetToMetricDefaults()
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.edgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = eConnection.String(iStr) : iStr = iStr + 1
        Me.groupId = eConnection.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.edgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = Template.String(iStr) : iStr = iStr + 1
        Me.groupId = Template.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.edgeDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.horDistance : iDbl = iDbl + 1
        eConnection.String(iStr) = Me.YDesc : iStr = iStr + 1
        eConnection.Number(iNum) = Me.groupId : iNum = iNum + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(edgeDistance)
        Template.AppendDouble(Me.horDistance)
        Template.AppendString(Me.YDesc)
        Template.AppendNumber(Me.groupId)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        edgeDistance = 0
        horDistance = 0
        YDesc = ""
        groupId = 0
    End Sub
End Class

Public Class DiagConnectPlateParameter
    Implements IParameters
    Implements ISetToDefauts

    Public holeDefs As New List(Of HoleColumnDefinition)
    Public middleDistance As Double
    Public thickness As Double

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Dim count As Integer = eConnection.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To count - 1
            Dim holeDef As New HoleColumnDefinition
            holeDef.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
            holeDefs.Add(holeDef)
        Next
        middleDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        thickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Dim count As Integer = Template.Number(iNum) : iNum = iNum + 1

        For i As Integer = 0 To count - 1
            Dim holeDef As New HoleColumnDefinition
            holeDef.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
            holeDefs.Add(holeDef)
        Next
        middleDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        thickness = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        holeDefs.Add(New HoleColumnDefinition(130, 130, "2x80", 0))
        holeDefs.Add(New HoleColumnDefinition(50, 80, "3x80", 0))
        holeDefs.Add(New HoleColumnDefinition(50, 80, "3x80", 0))
        holeDefs.Add(New HoleColumnDefinition(130, 80, "3x80", 0))
        middleDistance = 100
        thickness = 20
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Number(iNum) = holeDefs.Count : iNum = iNum + 1
        For i As Integer = 0 To holeDefs.Count - 1
            holeDefs(i).WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        Next
        eConnection.Double(iDbl) = middleDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = thickness : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendNumber(holeDefs.Count)
        For i As Integer = 0 To holeDefs.Count - 1
            holeDefs(i).WriteToTemplate(Template)
        Next
        Template.AppendDouble(middleDistance)
        Template.AppendDouble(thickness)
    End Sub
End Class
