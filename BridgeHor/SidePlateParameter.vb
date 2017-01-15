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


Public Class SidePlateParameter
    Implements IParameters
    Implements ISetToDefauts

    Public mHorFillet As Double
    Public mHorAngle As Double
    Public mHorDist As Double
    Public mDiagFillet As Double
    Public mDiagAngle As Double
    Public mDiagDist As Double
    Public mOutsidePlateThickness As Double
    Public mInsidePlateThickness As Double

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        mHorFillet = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mDiagFillet = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorAngle = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mDiagAngle = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mDiagDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mOutsidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mInsidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        mHorFillet = Template.Double(iDbl) : iDbl = iDbl + 1
        mDiagFillet = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorAngle = Template.Double(iDbl) : iDbl = iDbl + 1
        mDiagAngle = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mDiagDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mOutsidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mInsidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        Me.mHorFillet = 200
        Me.mDiagFillet = 200
        Me.mHorAngle = 30
        Me.mDiagAngle = 90
        Me.mHorDist = 380
        Me.mDiagDist = 238.5
        Me.mOutsidePlateThickness = 20
        Me.mInsidePlateThickness = 16

    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = mHorFillet : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mDiagFillet : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorAngle : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mDiagAngle : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mDiagDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mOutsidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mInsidePlateThickness : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(mHorFillet)
        Template.AppendDouble(mDiagFillet)
        Template.AppendDouble(mHorAngle)
        Template.AppendDouble(mDiagAngle)
        Template.AppendDouble(mHorDist)
        Template.AppendDouble(mDiagDist)
        Template.AppendDouble(mOutsidePlateThickness)
        Template.AppendDouble(mInsidePlateThickness)
    End Sub
End Class
