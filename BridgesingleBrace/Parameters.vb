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
    Public mCreateGroup As Boolean

    Public mSupport1CutBack As Double
    Public mSupport2CutBack As Double

    Public mConnect1CutBack As Double
    Public mConnect2CutBack As Double

    Public mPlateThickness As Double


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

        eConnection.Double(iDbl) = mSupport1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSupport2CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect1CutBack : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mConnect2CutBack : iDbl = iDbl + 1

        eConnection.Double(iDbl) = mPlateThickness : iDbl = iDbl + 1

    End Sub

    Public Sub ReadFromConnection(ByRef eConnection As PsConnection, Optional ByVal forClone As Boolean = False)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1

        mSupport1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mConnect2CutBack = eConnection.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = eConnection.Double(iDbl) : iDbl = iDbl + 1

    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager)

        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        Template.AppendNumber(mVersionNumber)

        Template.AppendDouble(mSupport1CutBack)
        Template.AppendDouble(mSupport2CutBack)
        Template.AppendDouble(mConnect1CutBack)
        Template.AppendDouble(mConnect2cutBack)

        Template.AppendDouble(mPlateThickness)
    End Sub


    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1

        mSupport1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mSupport2CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect1CutBack = Template.Double(iDbl) : iDbl = iDbl + 1
        mConnect2cutBack = Template.Double(iDbl) : iDbl = iDbl + 1

        mPlateThickness = Template.Double(iDbl) : iDbl = iDbl + 1
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

        If Measurement = 0 Then
            mSupport1CutBack = 20
            mSupport2CutBack = 30

            mConnect1CutBack = 10
            mConnect2CutBack = 10

            mPlateThickness = 2
        Else
            mSupport1CutBack = 1400
            mSupport2CutBack = 1200

            mConnect1CutBack = 2000
            mConnect2CutBack = 1600

            mPlateThickness = 40
        End If

    End Sub
End Class