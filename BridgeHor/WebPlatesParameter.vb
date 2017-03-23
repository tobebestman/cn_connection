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

Public Class WebPlatesParameter
    Implements IParameters
    Implements ISetToDefauts

    Public mChordSidePlateThickness As Double
    Public mBraceSidePlateThickness As Double
    Public mBraceSidePlateLength As Double
    Public mSupportPlateOffset As Double
    Public mSupportPlateThickness As Double
    Public mConnectPlateThickness As Double

    Public mHoleDiameter As Double
    Public mHorHoleDist As Double
    Public mHorHoleEdgeDist As Double
    Public mVerHoleDist As Double
    Public mVerHoleEdgeDist As Double
    Public mHorHoleCount As Integer
    Public mVerHoleCount As Integer

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        mChordSidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBraceSidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBraceSidePlateLength = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSupportPlateOffset = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSupportPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mHoleDiameter = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorHoleDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorHoleEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mVerHoleDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mVerHoleEdgeDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnectPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mHorHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        mVerHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        mChordSidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mBraceSidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mBraceSidePlateLength = Template.Double(iDbl) : iDbl = iDbl + 1
        mSupportPlateOffset = Template.Double(iDbl) : iDbl = iDbl + 1
        mSupportPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        mHoleDiameter = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorHoleDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorHoleEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mVerHoleDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mVerHoleEdgeDist = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnectPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        mHorHoleCount = Template.Number(iNum) : iNum = iNum + 1
        mVerHoleCount = Template.Number(iNum) : iNum = iNum + 1
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        mChordSidePlateThickness = 24
        mBraceSidePlateThickness = 24
        mBraceSidePlateLength = 400
        mSupportPlateOffset = 100
        mSupportPlateThickness = 24

        mHoleDiameter = 26
        mHorHoleDist = 80
        mHorHoleEdgeDist = 60
        mVerHoleDist = 80
        mVerHoleEdgeDist = 60
        mConnectPlateThickness = 25

        mHorHoleCount = 2
        mVerHoleCount = 11
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = mChordSidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBraceSidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBraceSidePlateLength : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSupportPlateOffset : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSupportPlateThickness : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mHoleDiameter : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorHoleDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorHoleEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mVerHoleDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mVerHoleEdgeDist : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnectPlateThickness : iDbl = iDbl + 1

        eConnection.Number(iNum) = mHorHoleCount : iNum = iNum + 1
        eConnection.Number(iNum) = mVerHoleCount : iNum = iNum + 1
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(mChordSidePlateThickness)
        Template.AppendDouble(mBraceSidePlateThickness)
        Template.AppendDouble(mBraceSidePlateLength)
        Template.AppendDouble(mSupportPlateOffset)
        Template.AppendDouble(mSupportPlateThickness)

        Template.AppendDouble(mHoleDiameter)
        Template.AppendDouble(mHorHoleDist)
        Template.AppendDouble(mHorHoleEdgeDist)
        Template.AppendDouble(mVerHoleDist)
        Template.AppendDouble(mVerHoleEdgeDist)
        Template.AppendDouble(mConnectPlateThickness)

        Template.AppendNumber(mHorHoleCount)
        Template.AppendNumber(mVerHoleCount)
    End Sub
End Class
