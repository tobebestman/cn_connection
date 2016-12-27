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
Imports System.Windows.Forms

Public Class Parameters
    Implements IParameters
    Implements ISetToDefauts

    'version 1
    Public mVersionNumber As Integer
    Public mFirstLeftCutIndex As Integer
    Public mFirstRightCutIndex As Integer
    Public mSecondLeftCutIndex As Integer
    Public mSecondRightcutIndex As Integer

    Public mFirstCutBackCutIndex As Integer
    Public mSecondCutBackCutIndex As Integer

    Public mColumnCutIndex As Integer

    Public mColumnBoolCutIndex1 As Integer
    Public mColumnBoolCutIndex2 As Integer
    Public mColumnBoolCutIndex3 As Integer
    Public mColumnBoolCutIndex4 As Integer

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

    Public mColumnCutBack As Double

    Public mTopAngle1 As Double
    Public mTopAngle2 As Double
    Public mTopFillet1 As Double
    Public mTopFillet2 As Double

    Public mColumnGap As Double

    Public mConnectPlate1 As ArcPlateParameter
    Public mConnectPlate2 As ArcPlateParameter

    Public mSideConnectPlate1 As SideConnectPlateParameter
    Public mSideConnectPlate2 As SideConnectPlateParameter

    Public mWebConnectPlate1 As WebConnectPlateParameter
    Public mWebConnectPlate2 As WebConnectPlateParameter

    Public mColumnWebConnectPlate As ColumnWebConnectPlateParameter

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

        mColumnWebConnectPlate.WriteToConnection(eConnection, iDbl, iNum, iBln, iStr)
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

        eConnection.Number(iNum) = mFirstCutBackCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mSecondCutBackCutIndex : iNum = iNum + 1

        eConnection.Number(iNum) = mColumnCutIndex : iNum = iNum + 1

        eConnection.Number(iNum) = mColumnBoolCutIndex1 : iNum = iNum + 1
        eConnection.Number(iNum) = mColumnBoolCutIndex2 : iNum = iNum + 1
        eConnection.Number(iNum) = mColumnBoolCutIndex3 : iNum = iNum + 1
        eConnection.Number(iNum) = mColumnBoolCutIndex4 : iNum = iNum + 1

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

        eConnection.Double(iDbl) = mColumnCutBack : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mTopAngle1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopAngle2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopFillet1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopFillet2 : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mColumnGap : iDbl = iDbl + 1
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

        mColumnWebConnectPlate.ReadFromConnection(eConnection, iDbl, iNum, iBln, iStr)
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

        mFirstCutBackCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mSecondCutBackCutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mColumnCutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mColumnBoolCutIndex1 = eConnection.Number(iNum) : iNum = iNum + 1
        mColumnBoolCutIndex2 = eConnection.Number(iNum) : iNum = iNum + 1
        mColumnBoolCutIndex3 = eConnection.Number(iNum) : iNum = iNum + 1
        mColumnBoolCutIndex4 = eConnection.Number(iNum) : iNum = iNum + 1

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

        mColumnCutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mTopAngle1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopAngle2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet2 = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mColumnGap = eConnection.Double(iDbl) : iDbl = iDbl + 1
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

        Template.AppendDouble(mColumnCutBack)

        Template.AppendDouble(mTopAngle1)
        Template.AppendDouble(mTopAngle2)
        Template.AppendDouble(mTopFillet1)
        Template.AppendDouble(mTopFillet2)

        Template.AppendDouble(mColumnGap)

        mConnectPlate1.WriteToTemplate(Template)
        mConnectPlate2.WriteToTemplate(Template)

        mSideConnectPlate1.WriteToTemplate(Template)
        mSideConnectPlate2.WriteToTemplate(Template)

        mWebConnectPlate1.WriteToTemplate(Template)
        mWebConnectPlate2.WriteToTemplate(Template)

        mColumnWebConnectPlate.WriteToTemplate(Template)
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

        mColumnWebConnectPlate.ReadFromTemplate(Template, iDbl, iNum, iBln, iStr)
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

        mColumnCutBack = Template.Double(iDbl) : iDbl = iDbl + 1

        mTopAngle1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopAngle2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet2 = Template.Double(iDbl) : iDbl = iDbl + 1

        mColumnGap = Template.Double(iDbl) : iDbl = iDbl + 1
    End Sub


    Public Sub New()
        MyBase.New()

        mConnectPlate1 = New ArcPlateParameter(Me)
        mConnectPlate2 = New ArcPlateParameter(Me)

        mSideConnectPlate1 = New SideConnectPlateParameter(Me)
        mSideConnectPlate2 = New SideConnectPlateParameter(Me)

        mWebConnectPlate1 = New WebConnectPlateParameter(Me)
        mWebConnectPlate2 = New WebConnectPlateParameter(Me)

        mColumnWebConnectPlate = New ColumnWebConnectPlateParameter(Me)
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
        mSupport1CutBack = 3800
        mSupport2CutBack = 3800

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

        mColumnCutBack = 2600

        mTopAngle1 = 45
        mTopAngle2 = 45
        mTopFillet1 = 200
        mTopFillet2 = 200

        mColumnGap = 40

        mConnectPlate1.SetToMetricDefaults()
        mConnectPlate2.SetToMetricDefaults()

        mSideConnectPlate1.SetToMetricDefaults()
        mSideConnectPlate2.SetToMetricDefaults()

        mWebConnectPlate1.SetToMetricDefaults()
        mWebConnectPlate2.SetToMetricDefaults()

        mColumnWebConnectPlate.SetToMetricDefaults()
    End Sub

    Public Sub SetToImperialDefaults() Implements ISetToDefauts.SetToImperialDefaults
        MessageBox.Show("Can not support the imperial units.")
        Throw New NotImplementedException()
    End Sub
End Class