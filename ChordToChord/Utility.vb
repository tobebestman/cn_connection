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

    Public MathTool As New PsGeometryFunctions
    Public Function IsPlate(ByVal objId As Integer) As Boolean
        Dim oTrans As New PsTransaction
        Dim oPlate As PsPlate = Nothing
        Try
            If oTrans.GetObject(objId, PsOpenMode.kForRead, oPlate) = False Then
                Return False
            End If
            Dim mode As Boolean = oPlate.RectangleMode
            Return True
        Catch ex As Exception
            Return False
        Finally
            oTrans.Close()
        End Try
    End Function
    Public Function IsWeldShape(ByVal objId As Integer) As Boolean
        Dim oTrans As New PsTransaction
        Dim oShape As PsShape = Nothing
        Try
            If oTrans.GetObject(objId, PsOpenMode.kForRead, oShape) = False Then
                Return False
            End If
            'Return oShape.CrossSectionType = ShapeType.kWeldType
            'just for test on the std-shape purposes
            Return True
        Catch ex As Exception
            Return False
        Finally
            oTrans.Close()
        End Try
    End Function

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
        Return ""
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
    Public Function GetNearestDistanceOfTwoMembers(supportId As Long, connectId As Long) As Double
        Dim MathTool As New PsGeometryFunctions
        Dim supportAdpt As New ShapeAdapter(supportId)
        Dim connectAdpt As New ShapeAdapter(connectId)
        Dim PointTemp1 As New PsPoint
        Dim PointTemp2 As New PsPoint
        Dim Dis1 As Double
        Dim Dis2 As Double

        Dis1 = MathTool.GetDistanceBetween(supportAdpt.MidLineStart, connectAdpt.MidLineStart)
        Dis2 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineStart)
        If Dis1 > Dis2 Then
            PointTemp1 = supportAdpt.MidLineEnd
        Else
            PointTemp1 = supportAdpt.MidLineStart
        End If

        Dis1 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineStart)
        Dis2 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineEnd)
        If Dis1 > Dis2 Then
            PointTemp2 = connectAdpt.MidLineEnd
        Else
            PointTemp2 = connectAdpt.MidLineStart
        End If

        Return MathTool.GetDistanceBetween(PointTemp1, PointTemp2)
    End Function
    Public Function GetIntersectPtAndUcsByTwoParallelMembers(supportId As Long, connectId As Long,
                                          ByRef instPt As PsPoint, ByRef connUcs As PsMatrix, exchangeYZ As Long) As Boolean
        Dim MathTool As New PsGeometryFunctions
        Dim supportAdpt As New ShapeAdapter(supportId)
        Dim connectAdpt As New ShapeAdapter(connectId)
        Dim PointTemp1 As New PsPoint
        Dim PointTemp2 As New PsPoint
        Dim Dis1 As Double
        Dim Dis2 As Double

        Dim xAxis As New PsVector

        Dis1 = MathTool.GetDistanceBetween(supportAdpt.MidLineStart, connectAdpt.MidLineStart)
        Dis2 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineStart)
        If Dis1 > Dis2 Then
            PointTemp1 = supportAdpt.MidLineEnd
        Else
            PointTemp1 = supportAdpt.MidLineStart
        End If

        Dis1 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineStart)
        Dis2 = MathTool.GetDistanceBetween(supportAdpt.MidLineEnd, connectAdpt.MidLineEnd)
        If Dis1 > Dis2 Then
            PointTemp2 = connectAdpt.MidLineEnd
        Else
            PointTemp2 = connectAdpt.MidLineStart
        End If

        instPt = MathTool.GetPointBetween(PointTemp1, PointTemp2)

        xAxis.SetFromCrossProduct(supportAdpt.XAxis, supportAdpt.YAxis)
        If exchangeYZ = 1 Then
            connUcs.SetCoordinateSystem(instPt, supportAdpt.XAxis, supportAdpt.YAxis, xAxis)
        ElseIf exchangeYZ = 2 Then
            connUcs.SetCoordinateSystem(instPt, supportAdpt.XAxis, xAxis, supportAdpt.YAxis)
        ElseIf exchangeYZ = 3 Then
            connUcs.SetCoordinateSystem(instPt, supportAdpt.YAxis, xAxis, supportAdpt.XAxis)
        Else
            connUcs.SetCoordinateSystem(instPt, supportAdpt.XAxis, xAxis, supportAdpt.YAxis)
        End If
        Return True
    End Function
    ''' <summary>
    ''' get the intersect point and usc defined by the input supportId and
    ''' connectId. 
    ''' origin: the intersect of the support and connect member.
    ''' 
    '''   ====================   (support Member)
    '''                   /  
    '''                  /     ^ YAxis 
    '''                 /      |      
    '''                /       |
    '''               /        -----> ZAxis
    '''              /
    '''             (connect memer)   
    ''' </summary>
    ''' <param name="supportId"></param>
    ''' <param name="connectId"></param>
    ''' <param name="instPt"></param>
    ''' <param name="connUcs"></param>
    ''' <returns></returns>
    Public Function GetIntersectPtAndUcsBySupportAndConnectMembers(supportId As Long, connectId As Long,
                                          ByRef instPt As PsPoint, ByRef connUcs As PsMatrix) As Boolean
        Dim MathTool As New PsGeometryFunctions
        Dim supportAdpt As New ShapeAdapter(supportId)
        Dim connectAdpt As New ShapeAdapter(connectId)

        If MathTool.IntersectLineWithLine(supportAdpt.MidLineStart, supportAdpt.MidLineEnd,
                                                   connectAdpt.MidLineStart, connectAdpt.MidLineEnd, 0, instPt) = False Then
            Return False
        End If
        Dim pt1 As PsPoint = MathTool.OrthoProjectPointToLine(connectAdpt.MidLineMid,
                                                             supportAdpt.MidLineStart,
                                                              supportAdpt.MidLineEnd)
        Dim yAxis As New PsVector
        yAxis.SetFromPoints(connectAdpt.MidLineMid, pt1)

        Dim zAxis As New PsVector
        If supportAdpt.GetEndSideTo(instPt) = 1 Then
            zAxis.SetFromPoints(supportAdpt.MidLineEnd, supportAdpt.MidLineStart)
        Else
            zAxis.SetFromPoints(supportAdpt.MidLineStart, supportAdpt.MidLineMid)
        End If

        zAxis.Normalize() : yAxis.Normalize()
        Dim xAxis As New PsVector
        xAxis.SetFromCrossProduct(yAxis, zAxis)
        xAxis.Normalize()

        connUcs.SetCoordinateSystem(instPt, xAxis, yAxis)
        Return True
    End Function
    ''' <summary>
    ''' Translation the UCS
    ''' </summary>
    ''' <param name="connUcs"></param>
    ''' <param name="x">move distance</param>
    ''' <param name="y">move distance</param>
    ''' <param name="z">move distance</param>
    ''' <param name="Dx">change direction use 1 ot -1</param>
    ''' <param name="Dy"></param>
    ''' <param name="Dz"></param>
    Public Sub OriPtTranslation(ByRef connUcs As PsMatrix, x As Double, y As Double, z As Double, Dx As Long, Dy As Long, Dz As Long)
        Dim xDir As New PsVector
        connUcs.getXAxis(xDir)
        Dim yDir As New PsVector
        connUcs.getYAxis(yDir)
        Dim zDir As New PsVector
        connUcs.getZAxis(zDir)
        Dim org As New PsPoint
        connUcs.getOrigin(org)

        org = MathTool.GetPointInDirection(org, xDir, x)
        org = MathTool.GetPointInDirection(org, yDir, y)
        org = MathTool.GetPointInDirection(org, zDir, z)
        connUcs.SetCoordinateSystem(org, Dx * xDir, Dy * yDir)
    End Sub
    Public Sub EraseObjectId(pId1 As Long)
        Dim trans As New PsTransaction
        trans.EraseLongId(pId1)
    End Sub
    Public Function Dtr(ByRef Angle As Object) As Object

        Dtr = UserConnection.MathTool.Degrees2Radians(Angle)

    End Function

    Public Function Rtd(ByRef Angle As Object) As Object

        Rtd = UserConnection.MathTool.Radians2Degrees(Angle)

    End Function
    Public Function CreatePlate(plateWidth As Double, plateLength As Double,
                                 plateThickness As Double,
                                 xOffset As Double, yOffset As Double,
                                 vertPos As VerticalPosition, oMat As PsMatrix) As Long
        Dim oCreatePlate As New PsCreatePlate
        oCreatePlate.SetToDefaults()
        oCreatePlate.SetAsRectangularPlate(plateWidth, plateLength)
        oCreatePlate.SetNormalPosition(vertPos)
        oCreatePlate.SetThickness(plateThickness)

        oCreatePlate.SetXOffset(xOffset)
        oCreatePlate.SetYOffset(yOffset)

        Dim org As New PsPoint
        oMat.getOrigin(org)

        'Utility.CreateBall(org)

        oCreatePlate.SetInsertMatrix(oMat)
        If oCreatePlate.Create() = False Then
            Debug.Assert(False)
        End If
        Dim plateId As Long = oCreatePlate.ObjectId
        Return plateId
    End Function
    Public Function DoPolyCut(supportId As Long, cutHeight As Double,
                                      oStart As PsPoint,
                                      xAxis As PsVector,
                                      yAxis As PsVector, oPoly As PsPolygon) As Integer
        Dim oCut As New PsCutObjects
        oCut.SetAsPolyCut(oPoly, oStart, xAxis, yAxis, cutHeight)
        oCut.SetObjectId(supportId)

        Dim result As Long = -1
        If oCut.Apply() > 0 Then
            result = oCut.GetModifyIndex()
        End If
        Return result
    End Function

    Public Class BoltDescParser
        Public count As Integer
        Public distance As Double

        Public Function Parse(value As String) As Boolean
            Dim parts As String() = value.Split("x")
            If (parts.Length <> 2) Then
                Return False
            End If

            Try
                count = Integer.Parse(parts(0))
                distance = Double.Parse(parts(1))
                Return True
            Catch e As Exception
                Return False
            End Try
            Return False
        End Function
    End Class

End Module




