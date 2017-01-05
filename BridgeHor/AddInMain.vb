Option Strict Off
Option Explicit On

Imports Bentley.MicroStation.WinForms
Imports Bentley.Windowing.WindowManager
Imports Bentley.Interop.MicroStationDGN
Imports Bentley.MicroStation.InteropServices

'How to add me into connection center:
'Append line 'BridgeHor, Macros, PSN_BridgeHor,' in follow file:
'C:\Program Files (x86)\Bentley\ProStructures\V8i_S6\MicroStation 081109\Localised\English\Resource\PlugIns\ConnectionCenter.txt

<Bentley.MicroStation.AddIn(MdlTaskID:="BridgeHor", KeyinTree:="BridgeHor.keyins")>
Friend NotInheritable Class AddInMain
    Inherits Bentley.MicroStation.AddIn
    ' Methods
    Private Sub New(ByVal mdlDesc As IntPtr)
        MyBase.New(mdlDesc)
        AddInMain.s_addin = Me
    End Sub

    Private Sub AddInMain_ReloadEvent(ByVal sender As Bentley.MicroStation.AddIn, ByVal eventArgs As ReloadEventArgs)
    End Sub

    Private Sub AddInMain_UnloadedEvent(ByVal sender As Bentley.MicroStation.AddIn, ByVal eventArgs As UnloadedEventArgs)
    End Sub

    Protected Overrides Sub OnUnloading(ByVal eventArgs As UnloadingEventArgs)
        MyBase.OnUnloading(eventArgs)
    End Sub

    ' Properties
    Friend Shared ReadOnly Property ComApp() As Application
        Get
            Return AddInMain.s_comApp
        End Get
    End Property

    Friend Shared ReadOnly Property MyAddin() As Bentley.MicroStation.AddIn
        Get
            Return AddInMain.s_addin
        End Get
    End Property
    Protected Overrides Function Run(ByVal commandLine As String()) As Integer
        AddInMain.s_comApp = Utilities.ComApp
        Return 0
    End Function


    ' Fields
    Private Shared s_addin As AddInMain = Nothing
    Private Shared s_comApp As Application = Nothing
End Class

