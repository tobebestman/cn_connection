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

Public Class Parameters
    Implements IParameters
    Implements ISetToDefauts

    'version 1
    Public mVersionNumber As Integer
    Public mHorCutbackCutIndex As Integer
    Public mHorWebCutIndex As Integer
    Public mDiagnalCutbackCutIndex As Integer

    Public mCreateGroup As Boolean

    Public mHorCutback As Double
    Public mHorFlangeCutback As Double
    Public mDiagnalCutback As Double

    Public mHorGap As Double
    Public mDiagnalGap As Double

    Public mHorPlateThickness As Double
    Public mHoleDia As Double

    Public mSidePlate As SidePlateParameter
    Public mWebPlates As WebPlatesParameter

    Public Sub WriteToConnectionId(ByVal ConnectionId As Long)
        Dim oTrans As New PsTransaction
        Dim eConn As PsConnection = Nothing

        Try
            If oTrans.GetObject(ConnectionId, PsOpenMode.kForWrite, eConn) Then
                WriteToConnection(eConn)
            End If
        Catch ex As Exception
        Finally
            oTrans.Close()
        End Try
    End Sub
    Public Sub ReadFromConnectionId(ByVal ConnectionId As Long)
        Dim oTrans As New PsTransaction
        Dim eConn As PsConnection = Nothing

        Try
            If oTrans.GetObject(ConnectionId, PsOpenMode.kForRead, eConn) Then
                ReadFromConnection(eConn)
            End If
        Catch ex As Exception
        Finally
            oTrans.Close()
        End Try
    End Sub

    Private Sub WriteToConnection(ByRef eConnection As PsConnection)
        If eConnection Is Nothing Then Return

        eConnection.DeleteAllDoubles()
        eConnection.DeleteAllNumbers()
        eConnection.DeleteAllBools()
        eConnection.DeleteAllStrings()
        eConnection.DeleteAllVectors()

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection,
                                  ByRef iDbl As Integer,
                                  ByRef iNum As Integer,
                                  ByRef iBln As Integer,
                                  ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Number(iNum) = mVersionNumber : iNum = iNum + 1
        eConnection.Number(iNum) = mHorCutbackCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mHorWebCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mDiagnalCutbackCutIndex : iNum = iNum + 1

        eConnection.Double(iDbl) = mHorCutback : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHorFlangeCutback : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mDiagnalCutback : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mHorGap : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mDiagnalGap : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mHorPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHoleDia : iDbl = iDbl + 1

        mSidePlate.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mWebPlates.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0
        ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection,
                                   ByRef iDbl As Integer,
                                   ByRef iNum As Integer,
                                   ByRef iBln As Integer,
                                   ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1
        mHorCutbackCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mHorWebCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mDiagnalCutbackCutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mHorCutback = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHorFlangeCutback = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mDiagnalCutback = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mHorGap = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mDiagnalGap = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mHorPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mSidePlate.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mWebPlates.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        Template.AppendNumber(mVersionNumber)

        Template.AppendDouble(mHorCutback)
        Template.AppendDouble(mHorFlangeCutback)
        Template.AppendDouble(mDiagnalCutback)

        Template.AppendDouble(mHorGap)
        Template.AppendDouble(mDiagnalGap)

        Template.AppendDouble(mHorPlateThickness)
        Template.AppendDouble(mHoleDia)

        mSidePlate.WriteToTemplate(Template)
        mWebPlates.WriteToTemplate(Template)
    End Sub

    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)
        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0
        ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager,
                                 ByRef iDbl As Integer,
                                 ByRef iNum As Integer,
                                 ByRef iBln As Integer,
                                 ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1

        mHorCutback = Template.Double(iDbl) : iDbl = iDbl + 1
        mHorFlangeCutback = Template.Double(iDbl) : iDbl = iDbl + 1
        mDiagnalCutback = Template.Double(iDbl) : iDbl = iDbl + 1

        mHorGap = Template.Double(iDbl) : iDbl = iDbl + 1
        mDiagnalGap = Template.Double(iDbl) : iDbl = iDbl + 1

        mHorPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = Template.Double(iDbl) : iDbl = iDbl + 1

        mSidePlate.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mWebPlates.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
    End Sub


    Public Sub New()
        MyBase.New()

        mSidePlate = New SidePlateParameter()
        mWebPlates = New WebPlatesParameter()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub SetToDefaults()
        Dim Measurement As Integer
        Measurement = GetCurMeasurement()

        mVersionNumber = PLUGIN_VERSION

        If Measurement = 1 Then
            SetToMetricDefaults()
        Else
            SetToImperialDefaults()
        End If

    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        mHorCutback = 2000.7
        mHorFlangeCutback = 3000.7

        mDiagnalCutback = 2400

        mHorGap = 40
        mDiagnalGap = 40

        mHorPlateThickness = 24
        mHoleDia = 30

        mSidePlate.SetToMetricDefaults()
        mWebPlates.SetToMetricDefaults()
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException
    End Sub
End Class