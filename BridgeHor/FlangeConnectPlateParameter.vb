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

Public Class FlangeConnectPlateParameter
    Implements IParameters
    Implements ISetToDefauts

    Public mOutsidePlateThickness As Double
    Public mInsidePlateThickness As Double
    Public mHorEdgeDist As Double
    Public mVerEdgeDist As Double
    Public mHorDist As Double
    Public mVerDist As Double
    Public mVerMiddleDist As Double
    Public mHorCount As Integer
    Public mVerCount As Integer

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        mOutsidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mInsidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mVerEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mVerDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mVerMiddleDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorCount = eConnection.Number(iNum) : iNum = iNum + 1
        mVerCount = eConnection.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        mOutsidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mInsidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mVerEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mVerDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mVerMiddleDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorCount = Template.Number(iNum) : iNum = iNum + 1
        mVerCount = Template.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        mOutsidePlateThickness = 16
        mInsidePlateThickness = 16
        mHorEdgeDist = 60
        mVerEdgeDist = 60
        mHorDist = 80
        mVerDist = 80
        mVerMiddleDist = 200
        mHorCount = 3
        mVerCount = 4
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = mOutsidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mInsidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mVerEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mVerDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mVerMiddleDist : iDbl = iDbl + 1
        eConnection.Number(iNum) = mHorCount : iNum = iNum + 1
        eConnection.Number(iNum) = mVerCount : iNum = iNum + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(mOutsidePlateThickness)
        Template.AppendDouble(mInsidePlateThickness)
        Template.AppendDouble(mHorEdgeDist)
        Template.AppendDouble(mVerEdgeDist)
        Template.AppendDouble(mHorDist)
        Template.AppendDouble(mVerDist)
        Template.AppendDouble(mVerMiddleDist)
        Template.AppendNumber(mHorCount)
        Template.AppendNumber(mVerCount)
    End Sub
End Class
