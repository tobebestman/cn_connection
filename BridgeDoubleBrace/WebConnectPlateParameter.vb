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

Public Class WebConnectPlateParameter
    Implements IParameters, ISetToDefauts

    Public connectMemberWebThickness As Double

    Public boltGroupHorSideDist As Double
    Public boltGroupSpan As Double

    Public webConnectPlateThickness As Double

    Public webConnectPlateHorEdgeDist As Double
    Public webConnectPlateHorDist As Double
    Public webConnectPlateHorCount As Integer

    Public webConnectPlateVerEdgeDist As Double
    Public webConnectPlateVerDist As Double
    Public webConnectPlateVerCount As Integer
    Public webConnectPlateInnerVerEdgeDist As Double

    Public webConnectDrillModifyIds As List(Of Integer)
    Public gap As Double

    Public owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection

        connectMemberWebThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        boltGroupHorSideDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        boltGroupSpan = eConnection.Double(iDbl) : iDbl = iDbl + 1

        webConnectPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        webConnectPlateHorEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateHorDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateHorCount = eConnection.Number(iNum) : iNum = iNum + 1

        webConnectPlateVerEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateVerDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateVerCount = eConnection.Number(iNum) : iNum = iNum + 1
        webConnectPlateInnerVerEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        gap = eConnection.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer
        count = eConnection.Number(iNum) : iNum = iNum + 1
        Me.webConnectDrillModifyIds = New List(Of Integer)
        For i As Integer = 0 To count - 1
            Me.webConnectDrillModifyIds.Add(eConnection.Number(iNum))
            iNum = iNum + 1
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate

        connectMemberWebThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        boltGroupHorSideDist = Template.Double(iDbl) : iDbl = iDbl + 1
        boltGroupSpan = Template.Double(iDbl) : iDbl = iDbl + 1

        webConnectPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        webConnectPlateHorEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateHorDist = Template.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateHorCount = Template.Number(iNum) : iNum = iNum + 1

        webConnectPlateVerEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateVerDist = Template.Double(iDbl) : iDbl = iDbl + 1
        webConnectPlateVerCount = Template.Number(iNum) : iNum = iNum + 1
        webConnectPlateInnerVerEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1

        gap = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults

        connectMemberWebThickness = 28

        boltGroupHorSideDist = 130
        boltGroupSpan = 210

        webConnectPlateThickness = 30

        webConnectPlateHorEdgeDist = 50
        webConnectPlateHorDist = 110
        webConnectPlateHorCount = 5

        webConnectPlateVerEdgeDist = 50
        webConnectPlateVerDist = 110
        webConnectPlateVerCount = 5
        webConnectPlateInnerVerEdgeDist = 100

        gap = 20

        webConnectDrillModifyIds = New List(Of Integer)
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection

        eConnection.Double(iDbl) = connectMemberWebThickness : iDbl = iDbl + 1

        eConnection.Double(iDbl) = boltGroupHorSideDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = boltGroupSpan : iDbl = iDbl + 1

        eConnection.Double(iDbl) = webConnectPlateThickness : iDbl = iDbl + 1

        eConnection.Double(iDbl) = webConnectPlateHorEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = webConnectPlateHorDist : iDbl = iDbl + 1
        eConnection.Number(iNum) = webConnectPlateHorCount : iNum = iNum + 1

        eConnection.Double(iDbl) = webConnectPlateVerEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = webConnectPlateVerDist : iDbl = iDbl + 1
        eConnection.Number(iNum) = webConnectPlateVerCount : iNum = iNum + 1
        eConnection.Double(iDbl) = webConnectPlateInnerVerEdgeDist : iDbl = iDbl + 1

        eConnection.Double(iDbl) = gap : iDbl = iDbl + 1

        eConnection.Number(iNum) = Me.webConnectDrillModifyIds.Count : iNum = iNum + 1
        For i As Integer = 0 To Me.webConnectDrillModifyIds.Count - 1
            eConnection.Number(iNum) = Me.webConnectDrillModifyIds(i)
            iNum = iNum + 1
        Next
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate

        Template.AppendDouble(connectMemberWebThickness)

        Template.AppendDouble(boltGroupHorSideDist)
        Template.AppendDouble(boltGroupSpan)

        Template.AppendDouble(webConnectPlateThickness)

        Template.AppendDouble(webConnectPlateHorEdgeDist)
        Template.AppendDouble(webConnectPlateHorDist)
        Template.AppendNumber(webConnectPlateHorCount)

        Template.AppendDouble(webConnectPlateVerEdgeDist)
        Template.AppendDouble(webConnectPlateVerDist)
        Template.AppendNumber(webConnectPlateVerCount)
        Template.AppendDouble(webConnectPlateInnerVerEdgeDist)

        Template.AppendDouble(gap)
    End Sub
End Class
