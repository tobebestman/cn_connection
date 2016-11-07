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

    'bottom plate
    Public mBpAngleA As Double
    Public mBpEdgeOuter As Double
    Public mBpEdgeInter As Double
    Public mBpEdgeDistance As Double
    Public mBpOffsetGusset As Double
    Public mBpThick As Double
    Public mBpGapEnd As Double
    Public mBpTolerance As Double
    'hole
    Public mBpHorHoleNum As Integer
    Public mBpA As Double
    Public mBpB As Double

    Public mBpVerHoleNum As Integer
    Public mBpA2 As Double
    Public mBpB2 As Double

    Public mHoleDia As Double
    Public mSlotLen As Double
    Public mWorkLoose As Double
    Public mSlotRotation As Double

    Public mBoltStyle As String
    Public mWeldStyle As String
    Public mBoltWeldStatus As Integer
    Public mTurnBolt As Boolean

    'side plate 1
    Public mSpHeight As Double
    Public mSpThick As Double
    Public mSpChamferDistance As Double
    Public mSpParallelToLeg As Boolean

    'side plate 2
    Public mSp2Height As Double
    Public mSp2Thick As Double
    Public mSp2ChamferDistance As Double
    '
    Public mPickedMPipeId As Integer
    Public mPickedBPipeId As Integer
    Public mPickedAngleId As Integer

    Public mPickedAngleHoleLastHandle As Integer
    Public mPickedAngleHoleCount As Integer

    '
    Public mCreateGroup As Boolean

    '
    Public mElement As Integer
    Public mAssign(MAX_ASSIGN) As Assignments

    'no UI for follow, will get by automatically compute
    Public mMPipeDia As Double
    Public mMPipePt1 As PsPoint
    Public mMPipePt2 As PsPoint
    Public mBPipeDia As Double
    Public mBPipePt1 As PsPoint
    Public mBPipePt2 As PsPoint
    Public mAngleSize As PsPoint
    Public mAngleOldPt As PsPoint
    Public mAngleIsStartPt As Boolean
    Public mAnglePt As PsPoint
    Public mAngleFarPt As PsPoint
    Public mAngleX As PsVector
    Public mAngleY As PsVector
    Public mAngleZ As PsVector
    Public mOriginPt As PsPoint
    Public mX As PsVector
    Public mY As PsVector
    Public mZ As PsVector

    Public mGusset1Pt As PsPoint
    Public mGusset1Y As PsVector
    Public mGusset1Z As PsVector
    Public mGusset1Width As Double

    Public mGusset2Pt As PsPoint
    Public mGusset2Y As PsVector
    Public mGusset2Z As PsVector
    Public mGusset2Width As Double
    Public mBaseMatrix As PsMatrix

    'version 2 New 0 Rewrite
    '...

    '-----------------------------------------

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

    Public Sub WriteToConnection(ByRef eConnection As PsConnection)
        If eConnection Is Nothing Then Return

        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        eConnection.Number(iNum) = mVersionNumber : iNum = iNum + 1
        'bottom plate
        eConnection.Double(iDbl) = mBpAngleA : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpEdgeOuter : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpEdgeInter : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpEdgeDistance : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpOffsetGusset : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpThick : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpGapEnd : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpTolerance : iDbl = iDbl + 1
        eConnection.Number(iNum) = mBpHorHoleNum : iNum = iNum + 1
        eConnection.Double(iDbl) = mBpA : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpB : iDbl = iDbl + 1
        eConnection.Number(iNum) = mBpVerHoleNum : iNum = iNum + 1
        eConnection.Double(iDbl) = mBpA2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mBpB2 : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mHoleDia : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSlotLen : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mWorkLoose : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSlotRotation : iDbl = iDbl + 1
        eConnection.String(iStr) = mBoltStyle : iStr = iStr + 1
        eConnection.String(iStr) = mWeldStyle : iStr = iStr + 1
        eConnection.Number(iNum) = mBoltWeldStatus : iNum = iNum + 1
        eConnection.Boolean(iBln) = mTurnBolt : iBln = iBln + 1

        'side plate 1
        eConnection.Double(iDbl) = mSpHeight : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSpThick : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSpChamferDistance : iDbl = iDbl + 1
        eConnection.Boolean(iBln) = mSpParallelToLeg : iBln = iBln + 1

        'side plate 1
        eConnection.Double(iDbl) = mSp2Height : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSp2Thick : iDbl = iDbl + 1
        eConnection.Double(iDbl) = mSp2ChamferDistance : iDbl = iDbl + 1

        'Group
        eConnection.Boolean(iBln) = mCreateGroup : iBln = iBln + 1

        'Assignment
        eConnection.Number(iNum) = mElement : iNum = iNum + 1
        For i As Integer = 0 To MAX_ASSIGN - 1
            eConnection.Number(iNum) = mAssign(i).Material : iNum = iNum + 1
            eConnection.String(iStr) = mAssign(i).DetailStyle : iStr = iStr + 1
            eConnection.Number(iNum) = mAssign(i).DisplayClass : iNum = iNum + 1
            eConnection.Number(iNum) = mAssign(i).AreaClass : iNum = iNum + 1
            eConnection.Number(iNum) = mAssign(i).PartFamily : iNum = iNum + 1
            eConnection.Number(iNum) = mAssign(i).Description : iNum = iNum + 1
            eConnection.String(iStr) = mAssign(i).Level : iStr = iStr + 1
            eConnection.String(iStr) = mAssign(i).ItemNumber : iStr = iStr + 1
        Next

        'no UI
        eConnection.RemoveAllAdditionalEntity(False)
        eConnection.AppendAdditionalObjectId(mPickedMPipeId)
        eConnection.AppendAdditionalObjectId(mPickedBPipeId)
        eConnection.AppendAdditionalObjectId(mPickedAngleId)

        '
        eConnection.Number(iNum) = mPickedAngleHoleLastHandle : iNum = iNum + 1
        eConnection.Number(iNum) = mPickedAngleHoleCount : iNum = iNum + 1
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

        mVersionNumber = eConnection.Number(iNum) : iNum = iNum + 1

        'bottom plate
        mBpAngleA = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeOuter = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeInter = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpOffsetGusset = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpThick = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpGapEnd = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpTolerance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpHorHoleNum = eConnection.Number(iNum) : iNum = iNum + 1
        mBpA = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpB = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpVerHoleNum = eConnection.Number(iNum) : iNum = iNum + 1
        mBpA2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBpB2 = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSlotLen = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mWorkLoose = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSlotRotation = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mBoltStyle = eConnection.String(iStr) : iStr = iStr + 1
        mWeldStyle = eConnection.String(iStr) : iStr = iStr + 1
        mBoltWeldStatus = eConnection.Number(iNum) : iNum = iNum + 1
        mTurnBolt = eConnection.Boolean(iBln) : iBln = iBln + 1

        'side plate 1
        mSpHeight = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSpThick = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSpChamferDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSpParallelToLeg = eConnection.Boolean(iBln) : iBln = iBln + 1

        'side plate 2
        mSp2Height = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSp2Thick = eConnection.Double(iDbl) : iDbl = iDbl + 1
        mSp2ChamferDistance = eConnection.Double(iDbl) : iDbl = iDbl + 1

        'Group
        mCreateGroup = eConnection.Boolean(iBln) : iBln = iBln + 1

        'Assignment
        mElement = eConnection.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To MAX_ASSIGN - 1
            mAssign(i).Material = eConnection.Number(iNum) : iNum = iNum + 1
            mAssign(i).DetailStyle = eConnection.String(iStr) : iStr = iStr + 1
            mAssign(i).DisplayClass = eConnection.Number(iNum) : iNum = iNum + 1
            mAssign(i).AreaClass = eConnection.Number(iNum) : iNum = iNum + 1
            mAssign(i).PartFamily = eConnection.Number(iNum) : iNum = iNum + 1
            mAssign(i).Description = eConnection.Number(iNum) : iNum = iNum + 1
            mAssign(i).Level = eConnection.String(iStr) : iStr = iStr + 1
            mAssign(i).ItemNumber = eConnection.String(iStr) : iStr = iStr + 1
        Next

        'no UI
        If Not forClone Then
            mPickedMPipeId = eConnection.AdditionalObjectId(0)
            mPickedBPipeId = eConnection.AdditionalObjectId(1)
            mPickedAngleId = eConnection.AdditionalObjectId(2)
            Debug.Assert(mPickedBPipeId <> 0 And mPickedAngleId <> 0, "lost pick object id")

            '
            mPickedAngleHoleLastHandle = eConnection.Number(iNum) : iNum = iNum + 1
            mPickedAngleHoleCount = eConnection.Number(iNum) : iNum = iNum + 1
        End If
    End Sub

    Public Sub WriteToTemplate(ByRef Template As PsTemplateManager)
        Template.DeleteAllBooleans()
        Template.DeleteAllDoubles()
        Template.DeleteAllNumbers()
        Template.DeleteAllStrings()

        '
        Template.AppendNumber(mVersionNumber)

        'bottom plate
        Template.AppendDouble(mBpAngleA)
        Template.AppendDouble(mBpEdgeOuter)
        Template.AppendDouble(mBpEdgeInter)
        Template.AppendDouble(mBpEdgeDistance)
        Template.AppendDouble(mBpOffsetGusset)
        Template.AppendDouble(mBpThick)
        Template.AppendDouble(mBpGapEnd)
        Template.AppendDouble(mBpTolerance)
        Template.AppendNumber(mBpHorHoleNum)
        Template.AppendDouble(mBpA)
        Template.AppendDouble(mBpB)
        Template.AppendNumber(mBpVerHoleNum)
        Template.AppendDouble(mBpA2)
        Template.AppendDouble(mBpB2)
        Template.AppendDouble(mHoleDia)
        Template.AppendDouble(mSlotLen)
        Template.AppendDouble(mWorkLoose)
        Template.AppendDouble(mSlotRotation)
        Template.AppendString(mBoltStyle)
        Template.AppendString(mWeldStyle)
        Template.AppendNumber(mBoltWeldStatus)
        Template.AppendBoolean(mTurnBolt)

        'side plate 1
        Template.AppendDouble(mSpHeight)
        Template.AppendDouble(mSpThick)
        Template.AppendDouble(mSpChamferDistance)
        Template.AppendBoolean(mSpParallelToLeg)

        'side plate 2
        Template.AppendDouble(mSp2Height)
        Template.AppendDouble(mSp2Thick)
        Template.AppendDouble(mSp2ChamferDistance)

        'Group
        Template.AppendBoolean(mCreateGroup)

        'Assignment
        Template.AppendNumber(mElement)
        For i As Integer = 0 To MAX_ASSIGN - 1
            Template.AppendNumber(mAssign(i).Material)
            Template.AppendString(mAssign(i).DetailStyle)
            Template.AppendNumber(mAssign(i).DisplayClass)
            Template.AppendNumber(mAssign(i).AreaClass)
            Template.AppendNumber(mAssign(i).PartFamily)
            Template.AppendNumber(mAssign(i).Description)
            Template.AppendString(mAssign(i).Level)
            Template.AppendString(mAssign(i).ItemNumber)
        Next
    End Sub


    Public Sub ReadFromTemplate(ByRef Template As PsTemplateManager)
        Dim iDbl, iNum, iBln, iStr As Integer
        iDbl = 0 : iNum = 0 : iBln = 0 : iStr = 0

        mVersionNumber = Template.Number(iNum) : iNum = iNum + 1

        'bottom plate
        mBpAngleA = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeOuter = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeInter = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpEdgeDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpOffsetGusset = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpThick = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpGapEnd = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpTolerance = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpHorHoleNum = Template.Number(iNum) : iNum = iNum + 1
        mBpA = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpB = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpVerHoleNum = Template.Number(iNum) : iNum = iNum + 1
        mBpA2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mBpB2 = Template.Double(iDbl) : iDbl = iDbl + 1
        mHoleDia = Template.Double(iDbl) : iDbl = iDbl + 1
        mSlotLen = Template.Double(iDbl) : iDbl = iDbl + 1
        mWorkLoose = Template.Double(iDbl) : iDbl = iDbl + 1
        mSlotRotation = Template.Double(iDbl) : iDbl = iDbl + 1
        mBoltStyle = Template.String(iStr) : iStr = iStr + 1
        mWeldStyle = Template.String(iStr) : iStr = iStr + 1
        mBoltWeldStatus = Template.Number(iNum) : iNum = iNum + 1
        mTurnBolt = Template.Boolean(iBln) : iBln = iBln + 1

        'side plate 1
        mSpHeight = Template.Double(iDbl) : iDbl = iDbl + 1
        mSpThick = Template.Double(iDbl) : iDbl = iDbl + 1
        mSpChamferDistance = Template.Double(iDbl) : iDbl = iDbl + 1
        mSpParallelToLeg = Template.Boolean(iBln) : iBln = iBln + 1

        'side plate 2
        mSp2Height = Template.Double(iDbl) : iDbl = iDbl + 1
        mSp2Thick = Template.Double(iDbl) : iDbl = iDbl + 1
        mSp2ChamferDistance = Template.Double(iDbl) : iDbl = iDbl + 1

        'Group
        mCreateGroup = Template.Boolean(iBln) : iBln = iBln + 1

        'Assignment
        mElement = Template.Number(iNum) : iNum = iNum + 1
        For i As Integer = 0 To MAX_ASSIGN - 1
            mAssign(i).Material = Template.Number(iNum) : iNum = iNum + 1
            mAssign(i).DetailStyle = Template.String(iStr) : iStr = iStr + 1
            mAssign(i).DisplayClass = Template.Number(iNum) : iNum = iNum + 1
            mAssign(i).AreaClass = Template.Number(iNum) : iNum = iNum + 1
            mAssign(i).PartFamily = Template.Number(iNum) : iNum = iNum + 1
            mAssign(i).Description = Template.Number(iNum) : iNum = iNum + 1
            mAssign(i).Level = Template.String(iStr) : iStr = iStr + 1
            mAssign(i).ItemNumber = Template.String(iStr) : iStr = iStr + 1
        Next
    End Sub

    Public Sub New()
        MyBase.New()
        mAngleSize = New PsPoint
        mMPipePt1 = New PsPoint
        mMPipePt2 = New PsPoint
        mBPipePt1 = New PsPoint
        mBPipePt2 = New PsPoint
        mAngleOldPt = New PsPoint
        mAnglePt = New PsPoint
        mAngleFarPt = New PsPoint
        mAngleX = New PsVector
        mAngleY = New PsVector
        mAngleZ = New PsVector
        mOriginPt = New PsPoint
        mX = New PsVector
        mY = New PsVector
        mZ = New PsVector
        mBaseMatrix = New PsMatrix
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub SetToDefaults()
        Dim Measurement As Integer
        Measurement = GetCurMeasurement()

        mVersionNumber = PLUGIN_VERSION

        ''bottom plate
        'mBpAngleA = IIf(Measurement > 0, 6.0#, 6.0)
        'mBpEdgeOuter = IIf(Measurement > 0, 12.0#, 0.5)
        'mBpEdgeInter = IIf(Measurement > 0, 24.0#, 1.0)
        'mBpEdgeDistance = IIf(Measurement > 0, 12.0#, 0.5)
        'mBpOffsetGusset = IIf(Measurement > 0, 4.8#, 0.2)
        'mBpThick = IIf(Measurement > 0, 4.8#, 0.2)
        'mBpGapEnd = IIf(Measurement > 0, 12.0#, 0.5)
        'mBpTolerance = IIf(Measurement > 0, 0.6#, 0.025)
        'mBpHorHoleNum = 1
        'mBpA = IIf(Measurement > 0, 12.0#, 0.5)
        'mBpB = IIf(Measurement > 0, 8.4#, 0.35)
        'mBpVerHoleNum = 2
        'mBpA2 = IIf(Measurement > 0, 12.0#, 0.5)
        'mBpB2 = IIf(Measurement > 0, 24.0#, 1.0)
        'mHoleDia = IIf(Measurement > 0, 6.0#, 0.25)
        'mSlotLen = IIf(Measurement > 0, 6.0#, 0.25)
        'mWorkLoose = IIf(Measurement > 0, 0.6, 0.025)
        'mSlotRotation = 0
        'mBoltStyle = DefaultBoltStyle()
        'mBoltWeldStatus = 0
        'mTurnBolt = False

        ''side plate 1
        'mSpHeight = IIf(Measurement > 0, 72.0#, 3.0)
        'mSpThick = IIf(Measurement > 0, 4.8#, 0.2)
        'mSpChamferDistance = IIf(Measurement > 0, 12.0#, 0.5)

        ''side plate 2
        'mSp2Height = IIf(Measurement > 0, 48.0#, 2.0)
        'mSp2Thick = IIf(Measurement > 0, 4.8#, 0.2)
        'mSp2ChamferDistance = IIf(Measurement > 0, 12.0#, 0.5)

        ''Assignment
        'For i As Integer = 0 To MAX_ASSIGN - 1
        '    mAssign(i).Material = 1
        '    mAssign(i).Description = 19 '20_plate
        '    mAssign(i).Level = "PS_PLATE" 'PS_PLATE
        'Next i

        'bottom plate
        mBpAngleA = 6
        mBpEdgeOuter = DimensionTol(12)
        mBpEdgeInter = DimensionTol(24)
        mBpEdgeDistance = DimensionTol(50)
        mBpOffsetGusset = DimensionTol(4.8)
        mBpThick = DimensionTol(10)
        mBpGapEnd = DimensionTol(80)
        mBpTolerance = DimensionTol(0.6)
        mBpHorHoleNum = 1
        mBpA = DimensionTol(43)
        mBpB = DimensionTol(40)
        mBpVerHoleNum = 2
        mBpA2 = DimensionTol(25)
        mBpB2 = DimensionTol(60)
        mHoleDia = DimensionTol(20)
        mSlotLen = DimensionTol(0)
        mWorkLoose = DimensionTol(2)
        mSlotRotation = 0
        mBoltStyle = DefaultBoltStyle()
        mBoltWeldStatus = 0
        mTurnBolt = False

        'side plate 1
        mSpHeight = DimensionTol(150)
        mSpThick = DimensionTol(10)
        mSpChamferDistance = DimensionTol(30)
        mSpParallelToLeg = False

        'side plate 2
        mSp2Height = DimensionTol(150)
        mSp2Thick = DimensionTol(10)
        mSp2ChamferDistance = DimensionTol(50)

        'Assignment
        For i As Integer = 0 To MAX_ASSIGN - 1
            mAssign(i).Material = 1
            mAssign(i).Description = 19 '20_plate
            mAssign(i).Level = "PS_PLATE" 'PS_PLATE
        Next i
    End Sub
End Class