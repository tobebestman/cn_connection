Imports PlugInBase.PlugInCommon
''' <summary>
''' this is the class used to build the user connection and 
''' parse the data stored in the PsConnection
''' </summary>
Public Class ConnectionBuilder

    Public Function getOriginHorShapeIdFromAdapter(ByRef adpt As ConnectionAdapter) As Long
        'the first additional object is the selected support shape.
        If (adpt.AdditionalObjectsCount <> 3) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(0)
    End Function

    Public Function getOriginDiagnalShapeIdFromAdapter(ByRef adpt As ConnectionAdapter) As Long
        'the first additional object is the selected support shape.
        If (adpt.AdditionalObjectsCount <> 3) Then
            Debug.Assert(False)
            Return 0
        End If
        Return adpt.AdditionalObject(1)
    End Function

    ''' <summary>
    ''' index can only be 1, 2
    ''' </summary>
    ''' <param name="adpt"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Public Function getOriginSidePlateIdFromAdapter(ByRef adpt As ConnectionAdapter) As Long
        'the second and third addtional shape is the two connecting shape selected by the user.
        If (adpt.AdditionalObjectsCount <> 3) Then
            Debug.Assert(False)
            Return 0
        End If

        Return adpt.AdditionalObject(2)
    End Function

End Class


