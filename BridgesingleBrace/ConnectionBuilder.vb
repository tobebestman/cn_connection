Imports PlugInBase.PlugInCommon
''' <summary>
''' this is the class used to build the user connection and 
''' parse the data stored in the PsConnection
''' </summary>
Public Class ConnectionBuilder

    Public Function getOriginSupportingShapeIdFromAdapter(ByRef adpt As ConnectionAdapter) As Long
        'the first additional object is the selected support shape.
        If (adpt.AdditionalObjectsCount <> 3) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(0)
    End Function

    Public Function getCreatedSupporingShapeFromAdapter(ByRef adpt As ConnectionAdapter) As Long
        'the first shanpe in the first created object array is the "new" suppor shape
        'get from the split operation
        If (adpt.CreatedObjectArrayCount < 1) Then
            Debug.Assert(False)
            Return 0
        End If

        If (adpt.CreatedObjectArrayEntityCount(0) <> 1) Then
            Debug.Assert(False)
            Return 0
        End If

        Return adpt.CreatedObjectArrayEntity(0, 0)
    End Function

    ''' <summary>
    ''' index can only be 1, 2
    ''' </summary>
    ''' <param name="adpt"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Public Function getConnectingShapeIdFromAdapter(ByRef adpt As ConnectionAdapter, index As Integer) As Long
        'the second and third addtional shape is the two connecting shape selected by the user.
        If (adpt.AdditionalObjectsCount <> 3) Then
            Debug.Assert(False)
            Return 0
        End If

        If (index < 1 Or index > 2) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(index)
    End Function

End Class
