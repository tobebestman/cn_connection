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
Imports PSN_BridgeDoubleBrace
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

Public Class SideConnectPlateParameter
    Implements IParameters, ISetToDefauts
    Public FlangeThickness As Double
    Public horSideDistance As Double
    Public horDistance As Double
    Public horHoleCount As Integer
    Public verSideDistance As Double
    Public verDistance As Double
    Public verHoleCount As Integer
    Public outSidePlateThickness As Double
    Public insidePlateThickness As Double

    Public drillModifyIndices As List(Of Integer)

    Public owner As Parameters

    Public Sub New(owner As Parameters)
        Me.owner = owner
        drillModifyIndices = New List(Of Integer)
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        Me.FlangeThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horSideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.horHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        Me.verSideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.verDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.verHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        Me.outSidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        Me.insidePlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        Dim count As Integer
        count = eConnection.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To count - 1
            Me.drillModifyIndices.Add(eConnection.Number(iNum))
            iNum = iNum + 1
        Next
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        Me.FlangeThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horSideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.horHoleCount = Template.Number(iNum) : iNum = iNum + 1
        Me.verSideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.verDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.verHoleCount = Template.Number(iNum) : iNum = iNum + 1
        Me.outSidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        Me.insidePlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Double(iDbl) = Me.FlangeThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.horSideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.horDistance : iDbl = iDbl + 1
        eConnection.Number(iNum) = Me.horHoleCount : iNum = iNum + 1
        eConnection.Double(iDbl) = Me.verSideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.verDistance : iDbl = iDbl + 1
        eConnection.Number(iNum) = Me.verHoleCount : iNum = iNum + 1
        eConnection.Double(iDbl) = Me.outSidePlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = Me.insidePlateThickness : iDbl = iDbl + 1

        eConnection.Number(iNum) = Me.drillModifyIndices.Count : iNum = iNum + 1
        For Each id As Integer In Me.drillModifyIndices
            eConnection.Number(iNum) = id
            iNum = iNum + 1
        Next

    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.AppendDouble(Me.FlangeThickness)
        Template.AppendDouble(Me.horSideDistance)
        Template.AppendDouble(Me.horDistance)
        Template.AppendNumber(Me.horHoleCount)
        Template.AppendDouble(Me.verSideDistance)
        Template.AppendDouble(Me.verDistance)
        Template.AppendNumber(Me.verHoleCount)
        Template.AppendDouble(Me.outSidePlateThickness)
        Template.AppendDouble(Me.insidePlateThickness)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        FlangeThickness = 30
        horSideDistance = 50
        horDistance = 100
        horHoleCount = 4
        verSideDistance = 50
        verDistance = 100
        verHoleCount = 4
        outSidePlateThickness = 22
        insidePlateThickness = 26
    End Sub
End Class

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

Public Class Parameters
    Implements IParameters
    Implements ISetToDefauts

    'version 1
    Public mVersionNumber As Integer
    Public mFirstLeftCutIndex As Integer
    Public mFirstRightCutIndex As Integer
    Public mSecondLeftCutIndex As Integer
    Public mSecondRightcutIndex As Integer

    Public mCreateGroup As Boolean

    Public mSupport1CutBack As Double
    Public mSupport2CutBack As Double

    Public mConnect1CutBack As Double
    Public mConnect2CutBack As Double

    Public mPlateThickness As Double

    Public mBottomAngle1 As Double
    Public mBottomAngle2 As Double
    Public mBottomAngle3 As Double
    Public mBottomAngle4 As Double

    Public mBottomFillet1 As Double
    Public mBottomFillet2 As Double

    Public mMainChordPlateThickness As Double

    Public mHoleDia As Double

    Public mConnectPlate1 As ArcPlateParameter
    Public mConnectPlate2 As ArcPlateParameter

    Public mSideConnectPlate1 As SideConnectPlateParameter
    Public mSideConnectPlate2 As SideConnectPlateParameter

    Public mWebConnectPlate1 As WebConnectPlateParameter
    Public mWebConnectPlate2 As WebConnectPlateParameter

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

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

        mConnectPlate1.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mConnectPlate2.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

        mSideConnectPlate1.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mSideConnectPlate2.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

        mWebConnectPlate1.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
        mWebConnectPlate2.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection,
                                  ByRef iDbl As Integer,
                                  ByRef iNum As Integer,
                                  ByRef iBln As Integer,
                                  ByRef iStr As Integer) Implements IParameters.WriteToConnection
        eConnection.Number(iNum) = mVersionNumber : iNum = iNum + 1
        eConnection.Number(iNum) = mFirstLeftCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mFirstRightCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mSecondLeftCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mSecondRightcutIndex : iNum = iNum + 1

        eConnection.Double(iDbl) = mSupport1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSupport2CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect2CutBack : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mPlateThickness : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mBottomAngle1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle3 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle4 : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mBottomFillet1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomFillet2 : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mMainChordPlateThickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHoleDia : iDbl = iDbl + 1
    End Sub

    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

        mConnectPlate1.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mConnectPlate2.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

        mSideConnectPlate1.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mSideConnectPlate2.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

        mWebConnectPlate1.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mWebConnectPlate2.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub ReadFromConnection(eConnection As PsConnection,
                                   ByRef iDbl As Integer,
                                   ByRef iNum As Integer,
                                   ByRef iBln As Integer,
                                   ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1
        mFirstLeftCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mFirstRightCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mSecondLeftCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mSecondRightcutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mSupport1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mBottomAngle1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle3 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle4 = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mBottomFillet1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomFillet2 = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mMainChordPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub



    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        Template.AppendNumber(mVersionNumber)
        'Template.AppendNumber(mFirstLeftCutIndex)
        'Template.AppendNumber(mFirstRightCutIndex)
        'Template.AppendNumber(mSecondLeftCutIndex)
        'Template.AppendNumber(mSecondRightcutIndex)


        Template.AppendDouble(mSupport1CutBack)
        Template.AppendDouble(mSupport2CutBack)
        Template.AppendDouble(mConnect1CutBack)
        Template.AppendDouble(mConnect2CutBack)

        Template.AppendDouble(mPlateThickness)

        Template.AppendDouble(mBottomAngle1)
        Template.AppendDouble(mBottomAngle2)
        Template.AppendDouble(mBottomAngle3)
        Template.AppendDouble(mBottomAngle4)

        Template.AppendDouble(mBottomFillet1)
        Template.AppendDouble(mBottomFillet2)

        Template.AppendDouble(mMainChordPlateThickness)
        Template.AppendDouble(mHoleDia)

        mConnectPlate1.WriteToTemplate(Template)
        mConnectPlate2.WriteToTemplate(Template)

        mSideConnectPlate1.WriteToTemplate(Template)
        mSideConnectPlate2.WriteToTemplate(Template)

        mWebConnectPlate1.WriteToTemplate(Template)
        mWebConnectPlate2.WriteToTemplate(Template)
    End Sub


    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0
        ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

        mConnectPlate1.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mConnectPlate2.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

        mSideConnectPlate1.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mSideConnectPlate2.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

        mWebConnectPlate1.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mWebConnectPlate2.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager,
                                 ByRef iDbl As Integer,
                                 ByRef iNum As Integer,
                                 ByRef iBln As Integer,
                                 ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1
        'mFirstLeftCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mFirstRightCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mSecondLeftCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mSecondRightcutIndex = Template.Number(iNum) : iNum = iNum + 1


        mSupport1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect2CutBack = Template.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        mBottomAngle1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle3 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle4 = Template.Double(iDbl) : iDbl = iDbl + 1

        mBottomFillet1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomFillet2 = Template.Double(iDbl) : iDbl = iDbl + 1

        mMainChordPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub


    Public Sub New()
        MyBase.New()

        mConnectPlate1 = New ArcPlateParameter(Me)
        mConnectPlate2 = New ArcPlateParameter(Me)

        mSideConnectPlate1 = New SideConnectPlateParameter(Me)
        mSideConnectPlate2 = New SideConnectPlateParameter(Me)

        mWebConnectPlate1 = New WebConnectPlateParameter(Me)
        mWebConnectPlate2 = New WebConnectPlateParameter(Me)
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
        mSupport1CutBack = 2800
        mSupport2CutBack = 2800

        mConnect1CutBack = 2400
        mConnect2CutBack = 2400

        mPlateThickness = 104

        mBottomAngle1 = 0.1
        mBottomAngle2 = 45
        mBottomAngle3 = 45
        mBottomAngle4 = 0.1

        mBottomFillet1 = 100
        mBottomFillet2 = 100

        mMainChordPlateThickness = 52
        mHoleDia = 30

        mConnectPlate1.SetToMetricDefaults()
        mConnectPlate2.SetToMetricDefaults()

        mSideConnectPlate1.SetToMetricDefaults()
        mSideConnectPlate2.SetToMetricDefaults()

        mWebConnectPlate1.SetToMetricDefaults()
        mWebConnectPlate2.SetToMetricDefaults()
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        mSupport1CutBack = 20
        mSupport2CutBack = 30

        mConnect1CutBack = 10
        mConnect2CutBack = 10

        mPlateThickness = 2

        mBottomAngle1 = 5
        mBottomAngle2 = 5
        mBottomAngle3 = 5
        mBottomAngle4 = 5

        mBottomFillet1 = 5
        mBottomFillet2 = 5

        mMainChordPlateThickness = 2
        mHoleDia = 2

        mConnectPlate1.SetToImperialDefaults()
        mConnectPlate2.SetToImperialDefaults()

        mSideConnectPlate1.SetToImperialDefaults()
        mSideConnectPlate2.SetToImperialDefaults()

        mWebConnectPlate1.SetToImperialDefaults()
        mWebConnectPlate2.SetToImperialDefaults()
    End Sub
End Class