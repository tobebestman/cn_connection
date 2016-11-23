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


Public Class Parameters

    'version 1
    Public mVersionNumber As Integer
    Public mFirstLeftCutIndex As Integer
    Public mFirstRightCutIndex As Integer
    Public mSecondLeftCutIndex As Integer
    Public mSecondRightcutIndex As Integer

    Public mCreateGroup As Boolean
    Public mHasTopColumn As Boolean

    Public mSupport1CutBack As Double
    Public mSupport2CutBack As Double

    Public mConnect1CutBack As Double
    Public mConnect2CutBack As Double

    Public mPlateThickness As Double

    Public mBottomAngle1 As Double
    Public mBottomAngle2 As Double
    Public mBottomAngle3 As Double
    Public mBottomAngle4 As Double

    Public mTopAngle1 As Double
    Public mTopAngle2 As Double

    Public mTopColumnWidth As Double
    Public mTopColumnDist As Double

    Public mBottomFillet1 As Double
    Public mBottomFillet2 As Double

    Public mTopFillet1 As Double
    Public mTopFillet2 As Double


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

    Public Sub WriteToConnection(ByRef eConnection As PsConnection)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        eConnection.Number(iNum) = mVersionNumber : iNum = iNum + 1
        eConnection.Number(iNum) = mFirstLeftCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mFirstRightCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mSecondLeftCutIndex : iNum = iNum + 1
        eConnection.Number(iNum) = mSecondRightcutIndex : iNum = iNum + 1

        eConnection.Boolean(iBln) = mHasTopColumn : iBln = iBln + 1

        eConnection.Double(iDbl) = mSupport1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSupport2CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect2CutBack : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mPlateThickness : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mBottomAngle1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle3 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomAngle4 : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mTopAngle1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopAngle2 : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mTopColumnWidth : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopColumnDist : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mBottomFillet1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBottomFillet2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopFillet1 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mTopFillet2 : iDbl = iDbl + 1

    End Sub

    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1
        mFirstLeftCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mFirstRightCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mSecondLeftCutIndex = eConnection.Number(iNum) : iNum = iNum + 1
        mSecondRightcutIndex = eConnection.Number(iNum) : iNum = iNum + 1

        mHasTopColumn = eConnection.Boolean(iBln) : iBln = iBln + 1

        mSupport1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mBottomAngle1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle3 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle4 = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mTopAngle1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopAngle2 = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mTopColumnWidth = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopColumnDist = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mBottomFillet1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBottomFillet2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet1 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet2 = eConnection.Double(iDbl) : iDbl = iDbl + 1

    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager)

        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        Template.AppendNumber(mVersionNumber)
        'Template.AppendNumber(mFirstLeftCutIndex)
        'Template.AppendNumber(mFirstRightCutIndex)
        'Template.AppendNumber(mSecondLeftCutIndex)
        'Template.AppendNumber(mSecondRightcutIndex)

        Template.AppendBoolean(mHasTopColumn)

        Template.AppendDouble(mSupport1CutBack)
        Template.AppendDouble(mSupport2CutBack)
        Template.AppendDouble(mConnect1CutBack)
        Template.AppendDouble(mConnect2CutBack)

        Template.AppendDouble(mPlateThickness)

        Template.AppendDouble(mBottomAngle1)
        Template.AppendDouble(mBottomAngle2)
        Template.AppendDouble(mBottomAngle3)
        Template.AppendDouble(mBottomAngle3)

        Template.AppendDouble(mTopAngle1)
        Template.AppendDouble(mTopAngle2)

        Template.AppendDouble(mTopColumnWidth)
        Template.AppendDouble(mTopColumnDist)

        Template.AppendDouble(mBottomFillet1)
        Template.AppendDouble(mBottomFillet2)
        Template.AppendDouble(mTopFillet1)
        Template.AppendDouble(mTopFillet2)

    End Sub


    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1
        'mFirstLeftCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mFirstRightCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mSecondLeftCutIndex = Template.Number(iNum) : iNum = iNum + 1
        'mSecondRightcutIndex = Template.Number(iNum) : iNum = iNum + 1

        mHasTopColumn = Template.Boolean(iBln) : iBln = iBln + 1

        mSupport1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect2CutBack = Template.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1

        mBottomAngle1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle3 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomAngle4 = Template.Double(iDbl) : iDbl = iDbl + 1

        mTopAngle1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopAngle2 = Template.Double(iDbl) : iDbl = iDbl + 1

        mTopColumnWidth = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopColumnDist = Template.Double(iDbl) : iDbl = iDbl + 1

        mBottomFillet1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBottomFillet2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet1 = Template.Double(iDbl) : iDbl = iDbl + 1
        mTopFillet2 = Template.Double(iDbl) : iDbl = iDbl + 1

    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub SetToDefaults()
        Dim Measurement As Integer
        Measurement = GetCurMeasurement()

        mVersionNumber = PLUGIN_VERSION

        mHasTopColumn = False

        If Measurement = 0 Then
            mSupport1CutBack = 20
            mSupport2CutBack = 30

            mConnect1CutBack = 10
            mConnect2CutBack = 10

            mPlateThickness = 2

            mBottomAngle1 = 5
            mBottomAngle2 = 5
            mBottomAngle3 = 5
            mBottomAngle4 = 5

            mTopAngle1 = 5
            mTopAngle2 = 5

            mTopColumnWidth = 30
            mTopColumnDist = 30

            mBottomFillet1 = 5
            mBottomFillet2 = 5
            mTopFillet1 = 5
            mTopFillet2 = 5

        Else
            mSupport1CutBack = 1800
            mSupport2CutBack = 1600

            mConnect1CutBack = 2400
            mConnect2CutBack = 2400

            mPlateThickness = 52

            mBottomAngle1 = 5
            mBottomAngle2 = 5
            mBottomAngle3 = 5
            mBottomAngle4 = 5

            mTopAngle1 = 5
            mTopAngle2 = 5

            mTopColumnWidth = 2400
            mTopColumnDist = 1800

            mBottomFillet1 = 50
            mBottomFillet2 = 50
            mTopFillet1 = 50
            mTopFillet2 = 50

        End If

    End Sub
End Class