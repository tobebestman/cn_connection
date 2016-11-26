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

Public Class ConnectPlateParameter
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

    Private Sub writeConnectionPlate(ByRef plateParam As ConnectPlateParameter,
                                     ByRef eConnection As PsConnection,
                                  ByRef iDbl As Integer,
                                  ByRef iNum As Integer,
                                  ByRef iBln As Integer,
                                  ByRef iStr As Integer)
        eConnection.Double(iDbl) = plateParam.sideDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.radius : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.gap : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.length : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.width : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.thickness : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.angle : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.innerWebHeight : iDbl = iDbl + 1
        eConnection.Double(iDbl) = plateParam.innerWebThickness : iDbl = iDbl + 1
        eConnection.Number(iNum) = plateParam.innerWebCount : iNum = iNum + 1
        eConnection.Double(iDbl) = plateParam.innerWebDist : iDbl = iDbl + 1
    End Sub

    Private Sub readConnectPlate(ByRef plateParam As ConnectPlateParameter,
                                 eConnection As PsConnection,
                                   ByRef iDbl As Integer,
                                   ByRef iNum As Integer,
                                   ByRef iBln As Integer,
                                   ByRef iStr As Integer)
        plateParam.sideDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.radius = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.gap = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.length = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.width = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.thickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.angle = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebHeight = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebCount = eConnection.Number(iNum) : iNum = iNum + 1
        plateParam.innerWebDist = eConnection.Double(iDbl) : iDbl = iDbl + 1
    End Sub


    Private Sub writeConnectPlate(ByRef plateParam As ConnectPlateParameter,
                                 ByRef Template As PsTemplateManager)
        Template.AppendDouble(plateParam.sideDistance)
        Template.AppendDouble(plateParam.radius)
        Template.AppendDouble(plateParam.gap)
        Template.AppendDouble(plateParam.length)
        Template.AppendDouble(plateParam.width)
        Template.AppendDouble(plateParam.thickness)
        Template.AppendDouble(plateParam.angle)
        Template.AppendDouble(plateParam.innerWebHeight)
        Template.AppendDouble(plateParam.innerWebThickness)
        Template.AppendNumber(plateParam.innerWebCount)
        Template.AppendDouble(plateParam.innerWebDist)
    End Sub

    Private Sub readConnectPlate(ByRef plateParam As ConnectPlateParameter,
                                 Template As PsTemplateManager,
                                 ByRef iDbl As Integer,
                                 ByRef iNum As Integer,
                                 ByRef iBln As Integer,
                                 ByRef iStr As Integer)
        plateParam.sideDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.radius = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.gap = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.length = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.width = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.thickness = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.angle = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebHeight = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebThickness = Template.Double(iDbl) : iDbl = iDbl + 1
        plateParam.innerWebCount = Template.Number(iNum) : iNum = iNum + 1
        plateParam.innerWebDist = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub
    Public Sub ReadFromConnection(eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromConnection
        readConnectPlate(Me, eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub ReadFromTemplate(Template As PsTemplateManager, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.ReadFromTemplate
        readConnectPlate(Me, Template, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub WriteToConnection(ByRef eConnection As PsConnection, ByRef iDbl As Integer, ByRef iNum As Integer, ByRef iBln As Integer, ByRef iStr As Integer) Implements IParameters.WriteToConnection
        writeConnectionPlate(Me, eConnection, iDbl, iNum, iBln, iStr)
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager) Implements IParameters.WriteToTemplate
        writeConnectPlate(Me, Template)
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        Throw New NotImplementedException()
    End Sub

    Public Sub SetToMetricDefaults() Implements ISetToDefauts.SetToMetricDefaults
        sideDistance = 30
        radius = 1000
        gap = 20
        length = 1400
        width = 2000
        thickness = 36
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

    Public mConnectPlate1 As ConnectPlateParameter
    Public mConnectPlate2 As ConnectPlateParameter

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

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

        mConnectPlate1.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)

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
    End Sub

    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
        mConnectPlate1.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)

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
        Template.AppendDouble(mBottomAngle3)

        Template.AppendDouble(mBottomFillet1)
        Template.AppendDouble(mBottomFillet2)

        Template.AppendDouble(mMainChordPlateThickness)

        mConnectPlate1.WriteToTemplate(Template)

    End Sub


    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0
        ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
        mConnectPlate1.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)

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
    End Sub


    Public Sub New()
        MyBase.New()

        mConnectPlate1 = New ConnectPlateParameter()

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
        mSupport1CutBack = 1800
        mSupport2CutBack = 1600

        mConnect1CutBack = 2400
        mConnect2CutBack = 2400

        mPlateThickness = 104

        mBottomAngle1 = 5
        mBottomAngle2 = 5
        mBottomAngle3 = 5
        mBottomAngle4 = 5

        mBottomFillet1 = 50
        mBottomFillet2 = 50

        mMainChordPlateThickness = 52

        mConnectPlate1.SetToMetricDefaults()
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        mSupport1CutBack = 20
        mSupport2CutBack = 30

        mConnect1CutBack = 10
        mConnect2CutBack = 10

        mPlateThickness = 20

        mBottomAngle1 = 5
        mBottomAngle2 = 5
        mBottomAngle3 = 5
        mBottomAngle4 = 5

        mBottomFillet1 = 5
        mBottomFillet2 = 5

        mMainChordPlateThickness = 2

        mConnectPlate1.SetToImperialDefaults()
    End Sub
End Class