Imports System.IO
Imports System.Collections.Generic

Imports Bentley.ProStructures.CadSystem
Imports Bentley.ProStructures.Configuration

Imports PlugInBase.PlugInCommon.CommonFunctions

Public Class WeldStyleManager
    Private ksGlobalSetting As PsGlobalSettings
    Private m_sFileName As String
    Private _WeldStyle As List(Of String)

    Public Property WeldStyle() As List(Of String)
        Get
            Return _WeldStyle
        End Get
        Set(ByVal value As List(Of String))
            _WeldStyle = value
        End Set
    End Property

    Public Sub New()
        ksGlobalSetting = New PsGlobalSettings()
        GetWeldStyle()
    End Sub


    Private Sub GetWeldStyle()
        Dim LineString As String
        Dim mSys As Integer
        _WeldStyle = New List(Of String)
        mSys = GetCurMeasurement()

        If WeldStylePath() <> "" Then
            If mSys = 0 Then
                m_sFileName = WeldStylePath() & "\Imperial\PsWeldList.bls"
            Else
                m_sFileName = WeldStylePath() & "\Metric\PsWeldList.bls"
            End If

            If Dir(m_sFileName) = "" Then
                _WeldStyle.Add("Standard")
                Exit Sub
            End If
        Else
            _WeldStyle.Add("Standard")
            Exit Sub
        End If
        Dim sw As New StreamReader(m_sFileName)

        Dim split1 As Object
        Do Until sw.EndOfStream
            LineString = sw.ReadLine
            If InStr(LineString, "[LIST]") > 0 Then
                LineString = sw.ReadLine
                Do Until InStr(LineString, "=") <= 0

                    split1 = Split(LineString, "=")

                    _WeldStyle.Add(LTrim(RTrim(split1(1))))
                    If Not sw.EndOfStream Then
                        LineString = sw.ReadLine
                    Else
                        LineString = ""
                    End If
                Loop
            End If
        Loop
    End Sub

    Private Function WeldStylePath() As String

        Dim oRessouce As New PsResource

        If oRessouce.LoadFile(ksGlobalSetting.ResourcePath + IIf(CShort(My.Application.Info.Version.Major) > 18, "\ProStructure.rss", "\pro_st3d.rss")) Then
            WeldStylePath = ksGlobalSetting.StylePath & "\" & oRessouce.GetString("C022")
        Else
            WeldStylePath = ""
        End If
    End Function
End Class
