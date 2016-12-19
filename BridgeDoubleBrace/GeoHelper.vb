Imports Bentley.ProStructures.Geometry.Data
Imports Bentley.ProStructures.Geometry.Utilities

Public Module GeoHelper
    Dim MathTool As New PsGeometryFunctions

    Public Function IsInSameDirection(vect1 As PsVector, vect2 As PsVector) As Boolean
        vect1.Normalize()
        vect2.Normalize()
        Dim result As Double = 0

        If MathTool.GetDistanceBetween(New PsPoint(vect1.x, vect1.y, vect1.z),
                                       New PsPoint(vect2.x, vect2.y, vect2.z)) < PRECISION Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' rotate a vector in the x-y plane around the z axis by
    ''' angle degrees.
    ''' </summary>
    ''' <param name="vect"></param>
    ''' <param name="angle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RotateVector(vect As PsVector, angle As Double) As PsVector
        Dim oMat As New PsMatrix
        oMat.SetToRotation(MathTool.Degrees2Radians(angle), New PsVector(0, 0, 1))
        Return oMat.TransformVector(vect)
    End Function

    ''' <summary>
    ''' check if the spt, ept are on the same side of the point pt.
    ''' like:
    ''' spt---ept---pt or
    ''' pt---spt---ept etc...
    ''' </summary>
    ''' <param name="spt"></param>
    ''' <param name="ept"></param>
    ''' <param name="pt"></param>
    ''' <returns></returns>
    Function IsOnTheSameSide(spt As PsPoint, ept As PsPoint, pt As PsPoint) As Boolean
        Dim ptToSpt As New PsVector
        ptToSpt.SetFromPoints(pt, spt)
        Dim ptToEpt As New PsVector
        ptToEpt.SetFromPoints(pt, ept)

        ptToSpt.Normalize()
        ptToEpt.Normalize()

        Dim dot As Double = MathTool.GetDotProductFrom(ptToSpt, ptToSpt)
        If dot < 0 Then Return False

        If (Math.Abs(dot - 1) < PRECISION) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' function used to calculate the "insert matrix" determined by
    ''' two connecting member.
    ''' the two connecting member is defined by two pair of points. 
    ''' </summary>
    ''' <param name="pts1"></param>
    ''' <param name="pte1"></param>
    ''' <param name="pts2"></param>
    ''' <param name="pte2"></param>
    ''' <param name="returnFirst"></param>
    ''' <returns></returns>
    Public Function CalculateConnectingMemberUcs(pts1 As PsPoint, pte1 As PsPoint,
                                                 pts2 As PsPoint, pte2 As PsPoint,
                                                 returnFirst As Boolean) As PsMatrix
        Dim intersect As New PsPoint
        If MathTool.IntersectLineWithLine(pts1, pte1, pts2, pte2, 0, intersect) = False Then
            Debug.Assert(False)
            Return Nothing
        End If

        Debug.Assert(IsOnTheSameSide(pts1, pte1, intersect) = True)
        Debug.Assert(IsOnTheSameSide(pts2, pte2, intersect) = True)

        Dim pt As New PsPoint
        pt.CopyFrom(intersect)

        Dim vec1 As New PsVector
        vec1.SetFromPoints(intersect, pts1)
        vec1.Normalize()

        Dim vec2 As New PsVector
        vec2.SetFromPoints(intersect, pts2)
        vec2.Normalize()

        Dim vecZ As New PsVector
        vecZ.SetFromCrossProduct(vec1, vec2)
        vecZ.Normalize()

        Dim dirBetween As New PsVector
        Dim oMat As New PsMatrix

        If (returnFirst) Then
            dirBetween.SetFromCrossProduct(vecZ, vec1)
            dirBetween.Normalize()
            oMat.SetCoordinateSystem(intersect, vec1, dirBetween)
        Else
            dirBetween.SetFromCrossProduct(vecZ, vec2)
            dirBetween.Normalize()
            oMat.SetCoordinateSystem(intersect, vec2, dirBetween)
        End If

        Return oMat

    End Function

    ''' <summary>
    ''' get a new line by rotating the input line by its start
    ''' point with an angle in degree.
    ''' </summary>
    ''' <param name="spt"></param>
    ''' <param name="ept"></param>
    ''' <param name="angle"></param>
    ''' <param name="newEndPt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RotateLineByStart(spt As PsPoint, ept As PsPoint,
                               angle As Double, axis As PsVector,
                               ByRef newEndPt As PsPoint) As Boolean
        Dim vec As PsVector = ept - spt
        vec.Normalize()

        If MathTool.GetDotProductFrom(vec, axis) > PRECISION Then
            Debug.Assert(False)
            Return False
        End If

        Dim yAxis As New PsVector
        yAxis.SetFromCrossProduct(axis, vec)
        yAxis.Normalize()

        Dim oMat As New PsMatrix
        oMat.SetCoordinateSystem(spt, vec, yAxis)
        oMat.Invert()

        'the newVec should be the x axis.
        Dim newVec As PsVector = oMat.TransformVector(vec)
        Debug.Assert(Math.Abs(newVec.x) - 1 < PRECISION)
        Debug.Assert(Math.Abs(newVec.y) < PRECISION)
        Debug.Assert(Math.Abs(newVec.z) < PRECISION)

        newVec = RotateVector(newVec, angle)
        oMat.Invert()
        newVec = oMat.TransformVector(newVec)
        newVec.Normalize()

        newEndPt = MathTool.GetPointInDirection(spt, newVec, MathTool.GetDistanceBetween(spt, ept))
        Dim resultAng As Double = MathTool.Radians2Degrees(MathTool.GetAngleBetweenVectors(ept - spt, newEndPt - spt))
        Debug.Assert(Math.Abs(resultAng) - Math.Abs(angle) < PRECISION)

        Return True
    End Function

    ''' <summary>
    ''' function to calculate the two tangent point of the fillet
    ''' between two lines.
    ''' </summary>
    ''' <param name="spt1"></param>
    ''' <param name="ept1"></param>
    ''' <param name="spt2"></param>
    ''' <param name="ept2"></param>
    ''' <param name="r"></param>
    ''' <returns></returns>
    ''' <remarks>return nothing if there is no fillet between them</remarks>
    Public Function FilletTwoLine(spt1 As PsPoint, ept1 As PsPoint, spt2 As PsPoint, ept2 As PsPoint, r As Double) As List(Of PsPoint)
        Dim result As New List(Of PsPoint)

        If (r < PRECISION) Then
            Debug.Assert(False)
            Return Nothing
        End If

        Dim inter As New PsPoint
        If (MathTool.IntersectLineWithLine(spt1, ept1, spt2, ept2, 0, inter) = False) Then
            Debug.Assert(False)
            Return Nothing
        End If

        Dim vec1 As PsVector = ept1 - spt1
        vec1.Normalize()

        If (vec1.Length < PRECISION) Then
            Debug.Assert(False)
            Return Nothing
        End If

        Dim vec2 As PsVector = ept2 - spt2
        vec2.Normalize()
        If vec2.Length < PRECISION Then
            Debug.Assert(False)
            Return Nothing
        End If

        Dim angle As Double = MathTool.GetAngleBetweenVectors(vec1, vec2)
        If (Math.Abs((Math.Abs(angle) - Math.PI)) < PRECISION) Then
            Debug.Assert(False)
            Return Nothing
        End If

        Dim dist As Double = r / Math.Tan(angle / 2)

        result.Add(MathTool.GetPointInDirection(inter, -vec1, dist))
        result.Add(MathTool.GetPointInDirection(inter, -vec2, dist))

        'result .Add (inter)

        Return result
    End Function

End Module
