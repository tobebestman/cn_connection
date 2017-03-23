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

Public Class Parameters
    Implements IParameters
    Implements ISetToDefauts

    'version 1
    Public mVersionNumber As Integer
    Public mCreateGroup As Boolean

    Public mFlange1TopThk As Double
    Public mFlange2TopThk As Double
    Public mFlange1BottomThk As Double
    Public mFlange2BottomThk As Double
    Public mWeb2Thk As Double
    Public mHoleDia As Double
    Public mChordInnerHigh As Double

    Public mWebConnectPlateParameters As MultiBoltsPlateParameters
    Public mTopConnectPlateParameters As MultiBoltsPlateParameters
    Public mBottomConnectPlateParameters As MultiBoltsPlateParameters

    Public mTopSlotCutIndex As Integer
    Public mBottomSlotCutIndex As Integer

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
    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

        mWebConnectPlateParameters.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mTopConnectPlateParameters.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mBottomConnectPlateParameters.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

    End Sub
    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        If eConnection Is Nothing Then Return

        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1
        mTopSlotCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mBottomSlotCutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mFlange1TopThk = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mFlange2TopThk = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mFlange1BottomThk = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mFlange2BottomThk = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mWeb2Thk = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mChordInnerHigh = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0
        ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

        mWebConnectPlateParameters.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mTopConnectPlateParameters.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mBottomConnectPlateParameters.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
    End Sub
    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1
        mTopSlotCutIndex = Template.Number(iNum) : iNum = iNum + 1
        mBottomSlotCutIndex = Template.Number(iNum) : iNum = iNum + 1

        mFlange1TopThk = Template.Double(iDbl) : iDbl = iDbl + 1
        mFlange2TopThk = Template.Double(iDbl) : iDbl = iDbl + 1
        mFlange1BottomThk = Template.Double(iDbl) : iDbl = iDbl + 1
        mFlange2BottomThk = Template.Double(iDbl) : iDbl = iDbl + 1
        mWeb2Thk = Template.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = Template.Double(iDbl) : iDbl = iDbl + 1
        mChordInnerHigh = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Private Sub WriteToConnection(ByRef eConnection As PsConnection)
        If eConnection Is Nothing Then Return

        eConnection.DeleteAllDoubles()
        eConnection.DeleteAllNumbers()
        eConnection.DeleteAllBools()
        eConnection.DeleteAllStrings()

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mWebConnectPlateParameters.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mTopConnectPlateParameters.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mBottomConnectPlateParameters.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

    End Sub
    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        If eConnection Is Nothing Then Return

        eConnection.Number(iNum) = mVersionNumber : iNum = iNum + 1
        eConnection.Number(iNum) = mTopSlotCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mBottomSlotCutIndex : iNum = iNum + 1

        eConnection.Double(iDbl) = mFlange1TopThk : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mFlange2TopThk : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mFlange1BottomThk : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mFlange2BottomThk : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mWeb2Thk : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHoleDia : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mChordInnerHigh : iDbl = iDbl + 1

    End Sub
    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        Template.AppendNumber(mVersionNumber)
        Template.AppendNumber(mTopSlotCutIndex)
        Template.AppendNumber(mBottomSlotCutIndex)

        Template.AppendDouble(mFlange1TopThk)
        Template.AppendDouble(mFlange2TopThk)
        Template.AppendDouble(mFlange1BottomThk)
        Template.AppendDouble(mFlange2BottomThk)
        Template.AppendDouble(mWeb2Thk)
        Template.AppendDouble(mHoleDia)
        Template.AppendDouble(mChordInnerHigh)

        mWebConnectPlateParameters.WriteToTemplate(Template)
        mTopConnectPlateParameters.WriteToTemplate(Template)
        mBottomConnectPlateParameters.WriteToTemplate(Template)
    End Sub

    Public Sub New()
        MyBase.New()

        mWebConnectPlateParameters = New MultiBoltsPlateParameters(Me)
        mTopConnectPlateParameters = New MultiBoltsPlateParameters(Me)
        mBottomConnectPlateParameters = New MultiBoltsPlateParameters(Me)
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
        mFlange1TopThk = 32
        mFlange2TopThk = 32
        mFlange1BottomThk = 32
        mFlange2BottomThk = 32
        mWeb2Thk = 32
        mHoleDia = 33
        mChordInnerHigh = 2000

        mWebConnectPlateParameters.innerPlateThickness = 30
        mWebConnectPlateParameters.outterPlateThickness = 26

        mWebConnectPlateParameters.HoleGrop.upperEdgeDistance = 50
        mWebConnectPlateParameters.HoleGrop.lowerEdgeDistance = 50

        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions = New List(Of HoleLineDefinition)
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(50, "6x100", 0))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))

        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 1))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))

        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 2))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mWebConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))

        mTopConnectPlateParameters.innerPlateThickness = 30
        mTopConnectPlateParameters.outterPlateThickness = 26

        mTopConnectPlateParameters.HoleGrop.upperEdgeDistance = 50
        mTopConnectPlateParameters.HoleGrop.lowerEdgeDistance = 100

        mTopConnectPlateParameters.centerDistance = 0
        mTopConnectPlateParameters.radius = 0

        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions = New List(Of HoleLineDefinition)
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(50, "6x100", 0))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))

        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 1))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))

        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 2))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mTopConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))

        mBottomConnectPlateParameters.innerPlateThickness = 36
        mBottomConnectPlateParameters.outterPlateThickness = 30

        mBottomConnectPlateParameters.HoleGrop.upperEdgeDistance = 50
        mBottomConnectPlateParameters.HoleGrop.lowerEdgeDistance = 100

        mBottomConnectPlateParameters.centerDistance = 0
        mBottomConnectPlateParameters.radius = 0

        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions = New List(Of HoleLineDefinition)
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(50, "6x100", 0))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 0))

        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 1))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "4x100", 1))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "3x100", 1))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "3x100", 1))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "4x100", 1))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 1))

        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(200, "6x100", 2))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
        mBottomConnectPlateParameters.HoleGrop.HoleColumnDefinitions.Add(New HoleLineDefinition(100, "6x100", 2))
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub
End Class