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
Imports PSN_BridgeTripleBrace

Public Class ColumnWebDefinition
    Implements IParameters, ISetToDefauts

    Public edgeDistance As Double
    Public thickness As Double
    Public height As Double
    Public length As Double

    Public Sub New()
        SetToMetricDefaults()
    End Sub

    Public Sub New(edgeDistance As Double, thickness As Double,
                    height As Double, length As Double)
        Me.edgeDistance = edgeDistance
        Me.thickness = thickness
        Me.height = height
        Me.length = length
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        edgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        thickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        height = eConnection.Double(iDbl) : iDbl = iDbl + 1
        length = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        edgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        thickness = Template.Double(iDbl) : iDbl = iDbl + 1
        height = Template.Double(iDbl) : iDbl = iDbl + 1
        length = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = edgeDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = thickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = height : iDbl = iDbl + 1
        eConnection.Double(iDbl) = length : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(edgeDistance)
        Template.AppendDouble(thickness)
        Template.AppendDouble(height)
        Template.AppendDouble(length)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        edgeDistance = 0
        thickness = 0
        height = 0
        length = 0
    End Sub
End Class

Public Class HoleColumnDefinition
    Implements IParameters, ISetToDefauts

    Public horDistance As Double
    Public YDesc As String

    Public Sub New(horDistance As Double, YDesc As String)
        Me.horDistance = horDistance
        Me.YDesc = YDesc
    End Sub

    Public Sub New()
        SetToMetricDefaults()
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.horDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = eConnection.String(iStr) : iStr = iStr + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.horDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.YDesc = Template.String(iStr) : iStr = iStr + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.horDistance : iDbl = iDbl + 1
        eConnection.String(iStr) = Me.YDesc : iStr = iStr + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.horDistance)
        Template.AppendString(Me.YDesc)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        horDistance = 0
        YDesc = ""
    End Sub
End Class

Public Class HoleGroupDefinition
    Implements IParameters, ISetToDefauts

    Public upperEdgeDistance As Double
    Public lowerEdgeDistance As Double
    Public HoleColumnDefinitions As List(Of HoleColumnDefinition)

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.upperEdgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.lowerEdgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer = eConnection.Number(iNum) : iNum = iNum + 1
        HoleColumnDefinitions = New List(Of HoleColumnDefinition)
        For i As Integer = 0 To count - 1
            Dim oDef As New HoleColumnDefinition
            oDef.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
            HoleColumnDefinitions.Add(oDef)
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.upperEdgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.lowerEdgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer = Template.Number(iNum) : iNum = iNum + 1
        HoleColumnDefinitions = New List(Of HoleColumnDefinition)
        For i As Integer = 0 To count - 1
            Dim oDef As New HoleColumnDefinition
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

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        upperEdgeDistance = 50
        lowerEdgeDistance = 100

        HoleColumnDefinitions = New List(Of HoleColumnDefinition)
        HoleColumnDefinitions.Add(New HoleColumnDefinition(50, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))

        HoleColumnDefinitions.Add(New HoleColumnDefinition(200, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "4x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "3x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "3x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "4x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))

        HoleColumnDefinitions.Add(New HoleColumnDefinition(200, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
        HoleColumnDefinitions.Add(New HoleColumnDefinition(100, "6x100"))
    End Sub
End Class

Public Class ColumnWebConnectPlateParameter
    Implements IParameters, ISetToDefauts

    Public outterPlateThickness As Double
    Public innerPlateThickness As Double
    Public columnPlateThickness As Double

    Public centerDistance As Double
    Public radius As Double

    Public HoleGrop As HoleGroupDefinition

    Public XColumnWebs As List(Of ColumnWebDefinition)

    Public owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
        HoleGrop = New HoleGroupDefinition()
        XColumnWebs = New List(Of ColumnWebDefinition)
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.outterPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.innerPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.columnPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.centerDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = eConnection.Double(iDbl) : iDbl = iDbl + 1
        HoleGrop.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

        Dim count As Integer = eConnection.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To count - 1
            Dim oDef As New ColumnWebDefinition
            oDef.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
            XColumnWebs.Add(oDef)
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.outterPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.innerPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.columnPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.centerDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = Template.Double(iDbl) : iDbl = iDbl + 1
        HoleGrop.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

        Dim count As Integer = Template.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To count - 1
            Dim oDef As New ColumnWebDefinition
            oDef.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
            XColumnWebs.Add(oDef)
        Next

    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        Me.outterPlateThickness = 22
        Me.innerPlateThickness = 26
        Me.columnPlateThickness = 52
        Me.centerDistance = 300
        Me.radius = 150
        HoleGrop.SetToMetricDefaults()

        XColumnWebs.Add(New ColumnWebDefinition(650, 24, 250, 686))
        XColumnWebs.Add(New ColumnWebDefinition(700, 24, 250, 686))
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.outterPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.innerPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.columnPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.centerDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.radius : iDbl = iDbl + 1
        HoleGrop.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

        eConnection.Number(iNum) = Me.XColumnWebs.Count
        For i As Integer = 0 To Me.XColumnWebs.Count - 1
            XColumnWebs(i).WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        Next
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.outterPlateThickness)
        Template.AppendDouble(Me.innerPlateThickness)
        Template.AppendDouble(Me.columnPlateThickness)
        Template.AppendDouble(Me.centerDistance)
        Template.AppendDouble(Me.radius)
        HoleGrop.WriteToTemplate(Template)

        Template.AppendNumber(Me.XColumnWebs.Count)
        For i As Integer = 0 To XColumnWebs.Count - 1
            XColumnWebs(i).WriteToTemplate(Template)
        Next
    End Sub
End Class
