Option Strict Off
Option Explicit On
Module TheConstants
    Public Const PLUGIN_VERSION As Integer = 1
    Public Const PLUGIN_IDENTIFIER As String = "BridgeHor"
    Public Const PLUGIN_DESCRIPTION As String = "Bridge Hor Brace Designer Module"
    Public Const MAX_ASSIGN As Integer = 2
    Public Const PRECISION As Double = 0.00000001 '1e-8

    Public Enum IntersectType
        itUnbounded = 0
        itFirstBounded
        itSecondBounded
        itBothBounded
    End Enum
End Module