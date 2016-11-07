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

Imports System.Windows.Forms

Imports PlugInBase
Imports PlugInBase.PlugInCommon.CommonFunctions
Imports PlugInBase.PlugInCommon
Imports System.Collections.Generic

Public Class clsCreate1LegBrace
    Private Connection As PsConnection

    Friend mCreatedObjects As Collection

    Private mUcsMatrix As PsMatrix
    Private mInsertPoint As PsPoint
    Private mMathTool As PsGeometryFunctions

    Private mXaxis As Object
    Private mYaxis As Object
    Private mdAngleToMBrace As Double
    Private mPtBpEdgeOuter As PsPoint
    Private mPtBpEdgeInter As PsPoint
    Private mVectOuter As PsVector
    Private mVectInter As PsVector

    Private mUcsXAxis As PsVector
    Private mUcsYAxis As PsVector

    Public Sub New()
        mInsertPoint = New PsPoint
        mCreatedObjects = New Collection
        mUcsMatrix = New PsMatrix
        mMathTool = New PsGeometryFunctions
        mUcsXAxis = New PsVector
        mUcsYAxis = New PsVector
        mPtBpEdgeOuter = New PsPoint
        mPtBpEdgeInter = New PsPoint
        mVectOuter = New PsVector
        mVectInter = New PsVector
    End Sub

    Private Sub CreatePlate(ByRef plate As PsCreatePlate, ByVal id As Integer)
        Dim ObjId As Long
        With UserConnection.Data
            plate.SetMaterial(.mAssign(id).Material)
            plate.SetLayer(.mAssign(id).Level)
            plate.SetDisplayClass(.mAssign(id).DisplayClass)
            plate.SetAreaClass(.mAssign(id).AreaClass)
            plate.SetDescription(.mAssign(id).Description)
            plate.SetFamilyClass(.mAssign(id).PartFamily)
            plate.SetArticle(.mAssign(id).ItemNumber)
            plate.SetDetailStyle(.mAssign(id).DetailStyle)
        End With
        'ObjId = UserConnection.TheExchange.SetObjectCreated(id)
        'plate.SetObjectId(ObjId)
        plate.SetNormalPosition(VerticalPosition.kMiddle)
        plate.SetInsertMatrix(Me.mUcsMatrix)

        If plate.Create() = True Then
            ObjId = plate.ObjectId
            mCreatedObjects.Add(ObjId)
        Else
            PsMiscTools.Prompt("This plate did not work")
        End If
    End Sub

    Private Sub CutPlateById(ByVal plateId As Integer, ByVal cutId As Integer, ByVal tolerance As Double)
        Dim cut As New PsCutObjects
        cut.SetObjectId(plateId)
        cut.SetOffset(tolerance)
        cut.SetAsBooleanCut(cutId)
        cut.CreateLogicalLink = False
        cut.Apply()
        cut = Nothing
    End Sub

    Private Sub DrillHolesInBPlateAndAngle(ByVal plateId As Integer)
        Dim Driller As New PsDrillObject
        Dim originPt As New PsPoint
        Dim insertPt As New PsPoint
        Dim rotateM As New PsMatrix
        Dim i As Integer, j As Integer
        With UserConnection.Data
            .mPickedAngleHoleLastHandle = 0
            .mPickedAngleHoleCount = 0

            Driller.SetToDefaults()
            Driller.SetAxisDistance(.mSlotLen)
            Driller.SetSingleHoleField(.mHoleDia)
            Driller.SetHoleWorkloose(.mWorkLoose)
            Driller.SetHoleType(HoleType.kHoleNormal)
            Driller.SetNormal(mUcsMatrix.TransformVector(PsVector.ZAxis))
            'for angle
            mUcsMatrix.SetCoordinateSystem(.mAnglePt, .mAngleX, .mAngleZ, .mAngleY)
            For i = 1 To .mBpHorHoleNum
                originPt.x = .mBpA + (i - 1) * .mBpB
                For j = 1 To .mBpVerHoleNum
                    originPt.y = .mBpA2 + (j - 1) * .mBpB2
                    Driller.SetInsertPoint(mUcsMatrix.TransformPoint(originPt))

                    'set slot rotation
                    If Math.Abs(.mSlotRotation) <= PRECISION Then
                        Driller.SetXYPlane(.mAngleX, .mAngleZ)
                    Else
                        rotateM.SetFromPointAndNormal(insertPt, .mAngleY)
                        rotateM.SetToRotation(UserConnection.MathTool.Degrees2Radians(.mSlotRotation), .mAngleY, insertPt)
                        Driller.SetXYPlane(rotateM.TransformVector(.mAngleX), rotateM.TransformVector(.mAngleZ))
                    End If

                    'create hole in picked angle
                    Driller.SetObjectId(.mPickedAngleId)
                    Driller.SetHoleDepth(.mAngleSize.y)
                    If Driller.Apply() = 1 Then
                        .mPickedAngleHoleLastHandle = Driller.GetModifyIndex()
                        .mPickedAngleHoleCount = .mPickedAngleHoleCount + 1
                        'create hole in created bottom plate
                        Driller.SetObjectId(plateId)
                        Driller.SetHoleDepth(.mBpThick)
                        If Driller.Apply() <> 1 Then
                            Debug.WriteLine("Fail to drill hole in selected plate!")
                        End If
                    Else
                        Debug.WriteLine("Fail to drill hole in created plate!")
                    End If
                Next j
            Next i
        End With
        rotateM = Nothing
        insertPt = Nothing
        originPt = Nothing
        Driller = Nothing

        'set hole display mode as real hole
        Dim editPlate As New PsEditPlateModification
        editPlate.SetObjectId(plateId)
        editPlate.HoleDisplayMode = HoleDisplayFlags.kHoleAsReal
        editPlate.SetObjectId(UserConnection.Data.mPickedAngleId)
        editPlate.HoleDisplayMode = HoleDisplayFlags.kHoleAsReal
        editPlate = Nothing
    End Sub

    Private Sub BoltObjects(ByRef mFirstId As Long, ByRef mSecondId As Long, ByVal mAdditionalLength As Double)
        Dim i As Integer
        Dim oTrans As New PsTransaction
        Dim BoltCreate As New Steel.Bolt.PsCreateBolt
        Dim Bolt As New PsBolt
        Dim BoltId As Long

        BoltCreate.SetToDefaults()

        With UserConnection.Data
            BoltCreate.BoltStyle = .mBoltStyle
            BoltCreate.MaxObjectDistance = IIf(GetCurMeasurement(), 1, 0.03125)
            BoltCreate.MaxDeclination = Dtr(15)
            BoltCreate.MaxCenterDistance = .mWorkLoose
            BoltCreate.AdditionalLength = mAdditionalLength

            BoltCreate.AddObject(mFirstId)
            BoltCreate.AddObject(mSecondId)
            BoltCreate.Create()

            For i = 0 To (BoltCreate.BoltCount - 1)
                BoltId = BoltCreate.ObjectId(i)
                If .mTurnBolt Then
                    Try
                        oTrans.GetObject(BoltId, PsOpenMode.kForWrite, Bolt)
                        Bolt.Turn()
                    Catch ex As System.Exception
                    Finally
                        oTrans.Close()
                    End Try
                End If
                mCreatedObjects.Add(BoltId)
            Next i
        End With
    End Sub

    Public Sub CreateBottomPlate()
        Dim vec As New PsVector
        Dim pt As New PsPoint
        Dim ptTemp As New PsPoint
        Dim ptOuter As New PsPoint
        Dim ptInter As New PsPoint
        Dim poly As New PsPolygon
        Dim plate As New PsCreatePlate

        With UserConnection.Data
            'add 2 pt on the bottom side
            poly.appendVertex(pt)
            ptOuter = UserConnection.MathTool.PolarPoint(pt, Math.PI - Dtr(.mBpAngleA), .mMPipeDia / 2 + .mBpTolerance)
            poly.appendVertex(ptOuter)
            ptTemp = UserConnection.MathTool.PolarPoint(pt, mdAngleToMBrace, .mMPipeDia / 2 + .mBpTolerance _
            + .mBpGapEnd + .mBpA2 + (.mBpVerHoleNum - 1) * .mBpB2 + .mBpEdgeDistance)
            mPtBpEdgeOuter = UserConnection.MathTool.PolarPoint(ptTemp, Math.PI / 2 + mdAngleToMBrace, .mBpEdgeOuter + .mAngleSize.x / 2)
            poly.appendVertex(mPtBpEdgeOuter)
            mPtBpEdgeInter = UserConnection.MathTool.PolarPoint(ptTemp, -Math.PI / 2 + mdAngleToMBrace, .mBpEdgeInter + .mAngleSize.x / 2)
            poly.appendVertex(mPtBpEdgeInter)
            ptInter.CopyFrom(mPtBpEdgeInter)
            ptInter.y = 0
            poly.appendVertex(ptInter)

            mVectOuter = mPtBpEdgeOuter - ptOuter
            mVectInter = mPtBpEdgeInter - ptinter
            mUcsMatrix.TransformPoint2(mPtBpEdgeOuter)
            mUcsMatrix.TransformPoint2(mPtBpEdgeInter)
            mUcsMatrix.TransformVector2(mVectOuter)
            mUcsMatrix.TransformVector2(mVectInter)

            plate.SetFromPolygon(poly)
            plate.SetThickness(.mBpThick)
            CreatePlate(plate, 0)
            CutPlateById(plate.ObjectId, .mPickedMPipeId, .mBpTolerance)
            CutPlateById(plate.ObjectId, .mPickedBPipeId, .mBpTolerance)
            'Utility.SeePlate(plate.ObjectId)
            If .mBoltWeldStatus < 2 Then
                DrillHolesInBPlateAndAngle(plate.ObjectId)
                If .mBoltWeldStatus = 0 Then
                    Call BoltObjects(plate.ObjectId, .mPickedAngleId, 0)
                End If
            End If
        End With


        vec = Nothing
        pt = Nothing
        poly = Nothing
        plate = Nothing
    End Sub

    'James note: D-135185 (Comb.Hori.Leg.Brace Connection: the external gusset doesn't fit with the supporting pipe.)
    Public Function GetIntersectPoint(ByVal pt1 As PsPoint, ByVal pt2 As PsPoint, ByRef IntersectPt As PsPoint, ByRef NearestPt As PsPoint, Optional ByVal isMPipe As Boolean = True) As Boolean
        Dim ptTemp As New PsPoint
        pt1 = Me.mUcsMatrix.TransformPoint(pt1)
        pt2 = Me.mUcsMatrix.TransformPoint(pt2)

        Dim r As Double
        Dim pipePt1 As PsPoint, pipePt2 As PsPoint
        If isMPipe Then
            r = UserConnection.Data.mMPipeDia / 2
            pipePt1 = UserConnection.Data.mMPipePt1
            pipePt2 = UserConnection.Data.mMPipePt2
        Else
            r = UserConnection.Data.mBPipeDia / 2
            pipePt1 = UserConnection.Data.mBPipePt1
            pipePt2 = UserConnection.Data.mBPipePt2
        End If

        UserConnection.MathTool.GetNearestPointsBetweenTwoLines(pipePt1, pipePt2, _
                pt1, pt2, ptTemp, NearestPt)

        Dim dist As Double = ptTemp.get_DistanceTo(NearestPt)
        If dist < r Then
            dist = Math.Sqrt(r * r - dist * dist)
            GetIntersectPoint = True
        Else
            dist = 0
            GetIntersectPoint = False
        End If

        Dim vec As PsVector = pt1 - pt2
        vec.Normalize()
        Dim angle As Double = vec.GetAngleTo(pipePt1 - pipePt2) Mod System.Math.PI
        If angle > Math.PI / 2 Then angle = Math.PI - angle
        dist /= Math.Sin(angle)

        ptTemp = NearestPt + vec * dist
        'Debug.Assert(dist = ptTemp.get_DistanceTo(ptTemp2))

        Me.mUcsMatrix.Invert()
        IntersectPt = Me.mUcsMatrix.TransformPoint(ptTemp)
        IntersectPt.z = 0
        NearestPt = Me.mUcsMatrix.TransformPoint(NearestPt)
        NearestPt.z = 0
        Me.mUcsMatrix.Invert()

        ptTemp = Nothing
        vec = Nothing
    End Function

    Public Sub CreateSidePlate()
        Dim pt As New PsPoint
        Dim ptTemp, IntersectPt, NearestPt As New PsPoint
        Dim poly As New PsPolygon
        Dim plate As New PsCreatePlate

        With UserConnection.Data
            pt.Set(0, 0, 0)
            ptTemp.Set(10, 0, 0)
            GetIntersectPoint(ptTemp, pt, IntersectPt, NearestPt) : ptTemp.CopyFrom(IntersectPt)
            poly.appendVertex(ptTemp)
            poly.appendVertex(pt)
            pt.y = -.mSpChamferDistance
            poly.appendVertex(pt)

            pt.y = -.mSpHeight
            ptTemp.CopyFrom(pt)
            ptTemp.x += 10
            GetIntersectPoint(ptTemp, pt, IntersectPt, NearestPt) : pt.CopyFrom(IntersectPt)
            ptTemp.CopyFrom(pt)
            ptTemp.x = ptTemp.x + .mSpChamferDistance
            poly.appendVertex(ptTemp)
            poly.appendVertex(pt)

            plate.SetFromPolygon(poly)
            plate.SetThickness(.mSpThick)
            CreatePlate(plate, 1)

            'CutPlateById(plate.ObjectId, .mPickedMPipeId, .mBpTolerance)
            'CutPlateById(plate.ObjectId, .mPickedBPipeId, .mBpTolerance)
        End With

        pt = Nothing
        ptTemp = Nothing
        poly = Nothing
        plate = Nothing
    End Sub

    Public Sub CreateSide2Plate()
        Dim pt As New PsPoint
        Dim ptTemp, IntersectPt, NearestPt As New PsPoint
        Dim poly As New PsPolygon
        Dim plate As New PsCreatePlate

        With UserConnection.Data
            pt.Set(0, 0, 0)
            ptTemp.Set(10, 0, 0)
            GetIntersectPoint(ptTemp, pt, IntersectPt, NearestPt, False) : ptTemp.CopyFrom(NearestPt)
            poly.appendVertex(ptTemp)
            poly.appendVertex(pt)
            pt.y = -.mSp2ChamferDistance
            poly.appendVertex(pt)

            pt.y = -.mSp2Height
            ptTemp.CopyFrom(pt)
            ptTemp.x += 10
            GetIntersectPoint(ptTemp, pt, IntersectPt, NearestPt, False) : pt.CopyFrom(IntersectPt)
            ptTemp.CopyFrom(pt)
            ptTemp.x = ptTemp.x + .mSp2ChamferDistance
            poly.appendVertex(ptTemp)
            poly.appendVertex(pt)

            plate.SetFromPolygon(poly)
            plate.SetThickness(.mSp2Thick)
            CreatePlate(plate, 1)
            CutPlateById(plate.ObjectId, .mPickedMPipeId, 0) 'NOTE: need first cut by MPipe then by BPipe, so that the plate can be cut in all case
            CutPlateById(plate.ObjectId, .mPickedBPipeId, 0)
            'SeePlate(plate.ObjectId)
        End With

        pt = Nothing
        poly = Nothing
        plate = Nothing
    End Sub

    Private Sub ErasePrimitive(ByVal objId As Integer)
        Dim ent As PsPrimitive = Nothing
        Dim trans As New PsTransaction
        Try
            If trans.GetObject(objId, PsOpenMode.kForWrite, ent) Then
                ent.Erase()
            End If
        Catch ex As Exception
        Finally
            trans.Close()
        End Try

        ent = Nothing
        trans = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub SetAnglePt(ByRef angle As PsShape, ByRef angleOldPt As PsPoint, ByRef anglePt As PsPoint, _
        ByRef angleFarPt As PsPoint, ByRef angleVec As PsVector, ByRef isStartPt As Boolean)
        Dim anglePt2 As PsPoint = anglePt + angleVec * angle.Length
        Dim ptTemp As New PsPoint
        Dim ptTemp2 As New PsPoint

        isStartPt = True
        With UserConnection.Data
            'let angle pt be near to the pipe
            UserConnection.MathTool.GetNearestPointsBetweenTwoLines(.mMPipePt1, .mMPipePt2, _
                anglePt, anglePt2, ptTemp, ptTemp2)
            If anglePt.get_DistanceTo(ptTemp2) > anglePt2.get_DistanceTo(ptTemp2) Then
                ptTemp.set_Point(anglePt)
                anglePt.set_Point(anglePt2)
                anglePt2.set_Point(ptTemp)
                angleVec = -angleVec
                isStartPt = False
            End If

            'set angle pt by gapEnd
            angleOldPt.set_Point(anglePt)
            anglePt = ptTemp2 + angleVec * (.mMPipeDia / 2 + .mBpGapEnd)
            angleFarPt.set_Point(anglePt2)
            If isStartPt Then angle.SetShapeStart(anglePt) Else angle.SetShapeEnd(anglePt)
        End With

        ptTemp = Nothing
        ptTemp2 = Nothing
        anglePt2 = Nothing
    End Sub

    Private Function IsNeedSwapXY(ByVal x As PsVector, ByVal y As PsVector, ByVal pipe As PsVector) As Boolean
        Dim ax As Double, ay As Double
        ax = x.GetAngleTo(pipe) Mod System.Math.PI
        If ax > Math.PI / 2 Then ax = Math.PI - ax
        ay = y.GetAngleTo(pipe) Mod System.Math.PI
        If ay > Math.PI / 2 Then ay = Math.PI - ay
        If ax < ay Then IsNeedSwapXY = True
    End Function

    Public Function GetBaseMatrix() As Boolean
        GetBaseMatrix = False
        Dim pipe As PsShape = Nothing
        Dim angle As PsShape = Nothing
        Dim ptTemp As New PsPoint
        Dim ptTemp2 As New PsPoint
        Dim vec As New PsVector(0, 0, 0)
        Dim oTrans As New PsTransaction
        Try
            With UserConnection.Data
                If Not oTrans.GetObject(Convert.ToInt64(.mPickedMPipeId), PsOpenMode.kForRead, pipe) Then
                    'MessageBox.Show(UserConnection.RSS.RSS("D0000"))
                    Exit Function
                End If
                pipe.GetMidLine(.mMPipePt1, .mMPipePt2)
                .mMPipeDia = pipe.Height

                If Not oTrans.GetObject(Convert.ToInt64(.mPickedBPipeId), PsOpenMode.kForRead, pipe) Then
                    'MessageBox.Show(UserConnection.RSS.RSS("D0000"))
                    Exit Function
                End If
                pipe.GetMidLine(.mBPipePt1, .mBPipePt2)
                .mBPipeDia = pipe.Height

                'let branch pipe pt1 be near to the main pipe
                If .mBPipePt1.get_DistanceTo(.mMPipePt1) > .mBPipePt2.get_DistanceTo(.mMPipePt1) Then
                    ptTemp.set_Point(.mBPipePt1)
                    .mBPipePt1.set_Point(.mBPipePt2)
                    .mBPipePt2.set_Point(ptTemp)
                End If

                'angle
                If Not oTrans.GetObject(Convert.ToInt64(.mPickedAngleId), PsOpenMode.kForRead, angle) Then
                    MessageBox.Show(UserConnection.RSS.RSS("D0000"))
                    Exit Function
                End If
                angle.GetInsertUcs(.mBaseMatrix)
                .mBaseMatrix.GetCoordinateSystem(.mAnglePt, .mAngleX, .mAngleY, .mAngleZ)
                .mAngleSize.x = angle.Width : .mAngleSize.y = angle.Height : .mAngleSize.z = angle.Length

                'adjust angle pt by angel offset
                vec = .mAngleX * angle.InsertOffsetX
                .mAnglePt.Add(vec)
                vec = .mAngleY * angle.InsertOffsetY
                .mAnglePt.Add(vec)

                'let angle pt be near to the pipe and set angle pt by gapEnd
                SetAnglePt(angle, .mAngleOldPt, .mAnglePt, .mAngleFarPt, .mAngleZ, .mAngleIsStartPt)

                'let angle pt at angel corner
                vec = .mAngleX * (-.mAngleSize.x / 2)
                .mAnglePt.Add(vec)
                .mAngleFarPt.Add(vec)
                vec = .mAngleY * (-.mAngleSize.y / 2)
                .mAnglePt.Add(vec)
                .mAngleFarPt.Add(vec)

                'let angle x and size x be perpendicular with pipe, y be parallel with pipe
                vec = .mMPipePt1 - .mMPipePt2
                If IsNeedSwapXY(.mAngleX, .mAngleY, vec) Then
                    vec = .mAngleX
                    .mAngleX = .mAngleY
                    .mAngleY = vec
                    .mAngleSize.x = angle.Height : .mAngleSize.y = angle.Width
                End If

                'set base matrix by angle and 2 pipe, its xy plane will be parallel with angle xz plane
                'and z axis will be angle y, x axis will be branch pipe center line, origin will be cross pt of main pipe with xy plane
                .mX = (.mBPipePt2 - .mBPipePt1) : .mX.Normalize()
                mdAngleToMBrace = .mX.GetAngleTo(.mAngleZ)
                .mZ = .mAngleY : .mZ.Normalize()
                .mY = UserConnection.MathTool.GetCrossProductFrom(.mX, .mZ) : .mY.Normalize()
                If .mY.GetAngleTo(.mAngleZ) > Math.PI / 2 Then .mY = -.mY
                UserConnection.MathTool.IntersectLineWithPlane(.mMPipePt1, .mMPipePt2, .mAnglePt, .mZ, .mOriginPt)
                .mBaseMatrix.SetCoordinateSystem(.mOriginPt, .mX, .mY, .mZ)
            End With
        Catch ex As System.Exception
            ErrorLog.ShowError(ex)
        Finally
            oTrans.Close()
            oTrans = Nothing
            pipe = Nothing
            angle = Nothing
            ptTemp = Nothing
            ptTemp2 = Nothing
            vec = Nothing
        End Try
        GetBaseMatrix = True
    End Function

    Public Sub SetMatrix(ByVal type As Short)
        Dim vecMove As New PsVector(0, 0, 0)
        Dim matMove As New PsMatrix

        With UserConnection.Data
            If type = 0 Then 'bottom
                mUcsMatrix.CopyFrom(.mBaseMatrix)
                vecMove.z = -.mBpThick / 2
            Else
                Dim ZAxisOuter As New PsVector
                ZAxisOuter.SetFromCrossProduct(mVectOuter, .mAngleY)
                Dim dmoveZ As Double = .mBpOffsetGusset + .mSpThick / 2
                If ZAxisOuter.GetAngleTo(mVectInter) < Math.PI / 2 Then
                    dmoveZ = -dmoveZ
                End If
                If type = 1 Then 'side 1
                    mUcsMatrix.SetCoordinateSystem(mPtBpEdgeOuter, mVectOuter, .mAngleY) 'swap x and z
                    vecMove.z = dmoveZ
                Else 'side 2
                    mUcsMatrix.SetCoordinateSystem(mPtBpEdgeInter, mVectInter, .mAngleY) 'swap x and z
                    vecMove.z = -dmoveZ
                End If
                vecMove.y = -.mBpThick / 2
            End If

            matMove.SetToTranslation(vecMove)
            mUcsMatrix.PostMultiplyWith(matMove)

            If type = 1 And .mSpParallelToLeg Then
                Dim XAxis As New PsVector
                Dim PtOrigin As New PsPoint
                Dim NewYAxis As New PsVector
                Dim OldYAxis As New PsVector
                NewYAxis.SetFromPoints(.mMPipePt1, .mMPipePt2)
                mUcsMatrix.getYAxis(OldYAxis)
                mUcsMatrix.getXAxis(XAxis)
                mUcsMatrix.getOrigin(PtOrigin)
                If OldYAxis.GetAngleTo(NewYAxis) > Math.PI / 2.0 Then
                    NewYAxis = -NewYAxis
                End If
                mUcsMatrix.SetCoordinateSystem(PtOrigin, XAxis, NewYAxis)
            End If
            'mUcsMatrix.Draw()
        End With

        vecMove = Nothing
        matMove = Nothing
    End Sub

    Private Function IsAngleOnLeft(ByRef angleNearPoint As PsPoint, ByRef angleFarPoint As PsPoint, _
        ByRef branchNearPoint As PsPoint, ByRef branchFarPoint As PsPoint, ByRef xAxis As PsVector, _
        ByRef yAxis As PsVector, ByRef zAxis As PsVector) As Boolean
        IsAngleOnLeft = False
        Dim angleDire As New PsVector
        Dim branchDire As New PsVector
        Dim includeAngle As Double = 0
        Dim oRotateMat As New PsMatrix
        Dim newAngleDire As New PsVector
        Dim interPoint As New PsPoint
        Dim projBNearPoint As New PsPoint
        Dim projBFarPoint As New PsPoint

        projBNearPoint = mMathTool.OrthoProjectPointToPlane(branchNearPoint, angleNearPoint, zAxis)
        projBFarPoint = mMathTool.OrthoProjectPointToPlane(branchFarPoint, angleNearPoint, zAxis)
        If mMathTool.IntersectLineWithLine(angleNearPoint, angleFarPoint, projBNearPoint, projBFarPoint, _
            IntersectType.itUnbounded, interPoint) <> 1 Then
            Return False
        End If

        'Calculate angle direction, far away from main pipe
        angleDire.SetFromPoints(angleNearPoint, angleFarPoint)

        'Calculate branch pipe direction, far away from main pipe
        branchDire.SetFromPoints(projBNearPoint, projBFarPoint)

        'Rotate angle, then identify whether is aligned to branch pipe
        includeAngle = angleDire.GetAngleTo(branchDire)
        oRotateMat.SetToRotation(includeAngle, zAxis, interPoint)
        newAngleDire = mMathTool.TransformVectorBy(angleDire, oRotateMat)
        IsAngleOnLeft = Not (mMathTool.IsVectorAlignedTo(newAngleDire, branchDire) = 1)
    End Function
End Class

