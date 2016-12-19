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

Public Class ArcPlateParameter
    Implements IParameters, ISetToDefauts
    Public sideDistance As Double
    Public radius As Double
    Public gap As Double
    Public length As Double
    Public width As Double
    Public thickness As Double
    Public angle As Double
    Public innerWebHeight As Double
    Public innerWebThickness As Double
    Public innerWebCount As Integer
    Public innerWebDist As Double

    Private owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
    End Sub

    Private Sub writeConnectPlate(ByRef plateParam As ArcPlateParameter,
                                 ByRef Template As PsTemplateManager)



    End Sub

    Private Sub readConnectPlate(ByRef plateParam As ArcPlateParameter,
                                 Template As PsTemplateManager,
                                 ByRef iDbl As Integer,
                                 ByRef iNum As Integer,
                                 ByRef iBln As Integer,
                                 ByRef iStr As Integer)

    End Sub
    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.sideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.gap = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.length = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.width = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.thickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.angle = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebHeight = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebCount = eConnection.Number(iNum) : iNum = iNum + 1
        Me.innerWebDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.sideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.radius = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.gap = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.length = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.width = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.thickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.angle = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebHeight = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.innerWebCount = Template.Number(iNum) : iNum = iNum + 1
        Me.innerWebDist = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.sideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.radius : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.gap : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.length : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.width : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.thickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.angle : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.innerWebHeight : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.innerWebThickness : iDbl = iDbl + 1
        eConnection.Number(iNum) = Me.innerWebCount : iNum = iNum + 1
        eConnection.Double(iDbl) = Me.innerWebDist : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.sideDistance)
        Template.AppendDouble(Me.radius)
        Template.AppendDouble(Me.gap)
        Template.AppendDouble(Me.length)
        Template.AppendDouble(Me.width)
        Template.AppendDouble(Me.thickness)
        Template.AppendDouble(Me.angle)
        Template.AppendDouble(Me.innerWebHeight)
        Template.AppendDouble(Me.innerWebThickness)
        Template.AppendNumber(Me.innerWebCount)
        Template.AppendDouble(Me.innerWebDist)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        MessageBox.Show("Can not support the imperial units.")
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        sideDistance = 30
        radius = 1000
        gap = 20
        length = 1400
        width = 2000
        thickness = 90 '36
        angle = 45
        innerWebHeight = 250
        innerWebThickness = 20
        innerWebCount = 2
        innerWebDist = 675
    End Sub
End Class

