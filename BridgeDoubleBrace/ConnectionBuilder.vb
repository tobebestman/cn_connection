Imports PlugInBase.PlugInCommon
''' <summary>
''' this is the class used to build the user connection and 
''' parse the data stored in the PsConnection
''' </summary>
Public Class ConnectionBuilder

    Public Function getOriginSupportingShapeIdFromAdapter(ByRef adpt As ConnectionAdapter,
                                                          index As Integer) As Long
        'the first additional object is the selected support shape.
        If (adpt.AdditionalObjectsCount <> 4 And
            (index < 0 Or index > 1)) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(index)
    End Function

    ''' <summary>
    ''' index can only be 1, 2
    ''' </summary>
    ''' <param name="adpt"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Public Function getConnectingShapeIdFromAdapter(ByRef adpt As ConnectionAdapter, index As Integer) As Long
        'the second and third addtional shape is the two connecting shape selected by the user.
        If (adpt.AdditionalObjectsCount <> 4) Then
            Debug.Assert(False)
            Return 0
        End If

        If (index < 2 Or index > 3) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(index)
    End Function

End Class


