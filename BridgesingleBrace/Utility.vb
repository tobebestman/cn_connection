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
Imports PlugInBase.PlugInCommon.CommonFunctions
Imports PlugInBase.PlugInCommon
Imports System.Collections.Generic

Module Utility
    'ShapeClass
    Public Const kShapeClassI As Short = 0 ' SHAPECLASS_I             
    Public Const kShapeClassHE As Short = 2 ' SHAPECLASS_HE          
    Public Const kShapeClassU As Short = 6 ' SHAPECLASS_U             
    Public Const kShapeClassZ As Short = 7 ' SHAPECLASS_Z            
    Public Const kShapeClassLE As Short = 8 ' SHAPECLASS_LE          
    Public Const kShapeClassLNE As Short = 9 ' SHAPECLASS_LNE         
    Public Const kShapeClassT As Short = 10 ' SHAPECLASS_T             
    Public Const kShapeClassTB As Short = 11 ' SHAPECLASS_TB           
    Public Const kShapeClassROUNDSTEEL As Short = 12 ' SHAPECLASS_ROUNDSTEEL    
    Public Const kShapeClassROUNDPIPE As Short = 13 ' SHAPECLASS_ROUNDPIPE     
    Public Const kShapeClassEDGEPIPE As Short = 14 ' SHAPECLASS_EDGEPIPE      
    Public Const kShapeClassEDGESTEEL As Short = 16 ' SHAPECLASS_EDGESTEEL     
    Public Const kShapeClassFLAT As Short = 17 ' SHAPECLASS_FLAT         
    Public Const kShapeClassCOLD_U As Short = 18 ' SHAPECLASS_COLD_U        
    Public Const kShapeClass_HALF_I As Short = 19 ' SHAPECLASS_HALF_I        
    Public Const kShapeClass_HALF_HE As Short = 20 ' SHAPECLASS_HALF_HE        
    Public Const kShapeClassCOLD_C As Short = 21 ' SHAPECLASS_COLD_C 

    Public Function IsPipe(ByVal objId As Integer) As Boolean
        Dim shapeInfo As New PsShapeInfo
        shapeInfo.SetObjectId(objId)
        shapeInfo.GetInfo()
        Dim shapeClass As Integer = shapeInfo.SectionClass
        IsPipe = (shapeClass = kShapeClassROUNDPIPE OrElse shapeClass = kShapeClassEDGEPIPE)
        shapeInfo = Nothing
    End Function

    Public Function IsAngle(ByVal objId As Integer) As Boolean
        Dim shapeInfo As New PsShapeInfo
        shapeInfo.SetObjectId(objId)
        shapeInfo.GetInfo()
        Dim shapeClass As Integer = shapeInfo.SectionClass
        IsAngle = (shapeClass = kShapeClassLE OrElse shapeClass = kShapeClassLNE)
        shapeInfo = Nothing
    End Function

    'Public Function BoltObjects(ByVal objectIds As List(Of Long), ByVal BoltType As String, ByVal BoltWorkLoose As Double, ByVal BoltAdditionalLen As Double, ByVal BoltGap As Double, ByVal BoltTurn As Boolean, ByVal ConnectionID As Long) As List(Of Long)

    '    Dim BoltId As Long = 0
    '    Dim BoltCreate As New PsCreateBolt
    '    Dim Bolt As New PsBolt
    '    Dim i As Integer
    '    Dim oTrans As New PsTransaction

    '    Dim BoltIds As New List(Of Long)

    '    Dim KsConnection As New ConnectionAdapter(ConnectionID)
    '    KsConnection.ReadData()


    '    BoltCreate.SetToDefaults()
    '    BoltCreate.BoltStyle = BoltType

    '    BoltCreate.MaxObjectDistance = BoltGap + IIf(GetCurMeasurement(), 1, 0.03125)
    '    BoltCreate.MaxDeclination = dtr(15)
    '    BoltCreate.MaxCenterDistance = BoltWorkLoose
    '    BoltCreate.AdditionalLength = BoltAdditionalLen

    '    For Each objectId As Long In objectIds
    '        If objectId <> 0 Then
    '            BoltCreate.AddObject(objectId)
    '        End If
    '    Next

    '    BoltCreate.Create()

    '    oTrans = New PsTransaction

    '    For i = 0 To (BoltCreate.BoltCount - 1)
    '        BoltId = BoltCreate.ObjectId(i)
    '        If BoltTurn Then
    '            Try
    '                oTrans.GetObject(BoltId, PsOpenMode.kForWrite, Bolt)
    '                Bolt.Turn()
    '            Catch ex As System.Exception
    '            Finally
    '                oTrans.Close()
    '            End Try
    '        End If

    '        BoltIds.Add(BoltId)
    '        KsConnection.AppendBoltObjectId(BoltId)

    '    Next i

    '    KsConnection.CommitAppendObjects()
    '    KsConnection.WriteData()
    '    Return BoltIds
    'End Function

    Public Function DefaultBoltStyle() As String
        Dim bolts As New PsCreateBolt
        If bolts.BoltTypeCount > 0 Then DefaultBoltStyle = bolts.BoltTypeName(0)
        bolts = Nothing
    End Function

    Public Sub DisplayBoltTypeList(ByRef cboControl As System.Windows.Forms.ComboBox, ByRef DefaultName As String)
        Dim i As Integer
        Dim nIndex As Integer

        Dim boltName As String
        Dim bolts As New PsCreateBolt

        cboControl.Items.Clear()
        nIndex = -1
        For i = 0 To bolts.BoltTypeCount - 1
            boltName = bolts.BoltTypeName(i)
            If boltName = DefaultName Then nIndex = i
            cboControl.Items.Insert(i, boltName)
        Next i
        If nIndex <> -1 Then cboControl.SelectedIndex = nIndex

        bolts = Nothing
    End Sub

    Public Function Dtr(ByRef Angle As Object) As Object

        Dtr = UserConnection.MathTool.Degrees2Radians(Angle)

    End Function

    Public Function Rtd(ByRef Angle As Object) As Object

        Rtd = UserConnection.MathTool.Radians2Degrees(Angle)

    End Function

    Public Function MyRND(ByRef Value As PsPoint) As PsPoint

        Dim Point As PsPoint = New PsPoint
        Point.x = System.Math.Round(Value.x, 8)
        Point.y = System.Math.Round(Value.y, 8)
        Point.z = System.Math.Round(Value.z, 8)
        Return Point

    End Function
End Module

