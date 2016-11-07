Option Strict Off
Option Explicit On

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows .Forms 
Imports System.Diagnostics 
Imports System.Collections
Imports System.Text
Imports System.Reflection
Imports System.Text.RegularExpressions

Public Class ErrorLog

    Public Shared Sub LogCallStack(ByVal onlyLogTop As Boolean)
        Dim sTrace As New StackTrace
        Dim frame As StackFrame = Nothing
        Dim i As Integer
        For i = 1 To sTrace.FrameCount - 1
            frame = sTrace.GetFrame(i)
            Dim fullName As String = String.Empty
            If (Not Nothing Is frame.GetMethod.DeclaringType) Then
                fullName = frame.GetMethod.DeclaringType.FullName
            End If
            ErrorLog.Out("CallStack " & i, String.Format("class: {0}, method: {1}", fullName, frame.GetMethod.ToString))
            If onlyLogTop Then
                Exit For
            End If
        Next i
    End Sub

    Public Shared Sub Out(ByVal name As String, ByVal val As String)
        ErrorLog.Out("log.txt", name, val, True)
    End Sub

    Public Shared Sub Out(ByVal name As String, ByVal val As String, ByVal bAppend As Boolean)
        ErrorLog.Out("log.txt", name, val, bAppend)
    End Sub

    Public Shared Sub Out(ByVal filename As String, ByVal name As String, ByVal val As String, ByVal bAppend As Boolean)
        Try
            Dim sw As New StreamWriter(IIf(filename.IndexOf(":") > 0, filename, "c:\" & filename), bAppend)
            sw.WriteLine((name & ": " & val))
            sw.Close()
        Catch
        End Try
    End Sub

    Public Shared Sub ShowError(ByVal e As Exception)
        ErrorLog.ShowError(e, String.Empty)
    End Sub

    Private Shared Sub ShowError(ByVal e As Exception, ByVal sb As StringBuilder)
        If (Not e Is Nothing) Then
            Dim stack As String() = e.StackTrace.Split(New Char() {ChrW(10)})
            sb.Append(ChrW(10) & ChrW(10) & "-------------------------------------Inner Error Message-----------------------------------" & ChrW(10) & ChrW(10))
            sb.Append(String.Concat(New String() {e.Message, ChrW(10) & ChrW(10) & "Source:" & ChrW(9) & ChrW(9), e.Source, ChrW(10) & "TargetSite:" & ChrW(9), e.TargetSite.ToString, ChrW(10) & ChrW(10) & "StackTrace:" & ChrW(9)}))
            Dim i As Integer = (stack.Length - 1)
            Do While (i >= 0)
                If (stack(i).IndexOf(".vb:line") >= 0) Then
                    sb.Append((ChrW(10) & ChrW(10) & "Step " & (stack.Length - i).ToString & ":" & ChrW(9) & stack(i)))
                    ErrorLog.Out("LastError.txt", i.ToString, stack(i).Trim(New Char() {" "c, ChrW(10), ChrW(13)}), True)
                End If
                i -= 1
            Loop
            ErrorLog.ShowError(e.InnerException, sb)
        End If
    End Sub

    Public Shared Sub ShowError(ByVal e As Exception, ByVal userinfo As String)
        ErrorLog.LogCallStack(False)
        Dim mb As MethodBase = e.TargetSite
        Dim sb As New StringBuilder
        Dim stack As String() = e.StackTrace.Split(New Char() {ChrW(10)})
        Dim msg As String = e.Message
        sb.Append("Error Message:" & ChrW(9)).Append(msg).Append(ChrW(10) & ChrW(10) & "TargetSite:" & ChrW(9)).Append(mb.ToString).Append(ChrW(10))
        sb.Append(ChrW(9) & ChrW(9) & "DeclaringType: ")
        If (Not mb.DeclaringType Is Nothing) Then
            sb.Append(mb.DeclaringType.ToString)
        End If
        sb.Append(ChrW(10))
        sb.Append(ChrW(9) & ChrW(9) & "Attributes:")
        If mb.IsPublic Then
            sb.Append(" public")
        End If
        If mb.IsPrivate Then
            sb.Append(" private")
        End If
        If mb.IsAssembly Then
            sb.Append(" internal")
        End If
        If mb.IsFamily Then
            sb.Append(" protected")
        End If
        If mb.IsStatic Then
            sb.Append(" static")
        End If
        If mb.IsVirtual Then
            sb.Append(" virtual")
        End If
        If mb.IsAbstract Then
            sb.Append(" abstract")
        End If
        sb.Append(ChrW(10))
        sb.Append(ChrW(9) & ChrW(9) & "MemberType: ")
        sb.Append(mb.MemberType.ToString)
        sb.Append(ChrW(10))
        sb.Append("StackTrace:" & ChrW(9))
        ErrorLog.Out("LastError.txt", mb.ToString, msg, False)
        Dim i As Integer = (stack.Length - 1)
        Do While (i >= 0)
            If (stack(i).IndexOf(".vb:line") >= 0) Then
                sb.Append((ChrW(10) & ChrW(10) & "Step " & (stack.Length - i).ToString & ":" & ChrW(9) & stack(i)))
                ErrorLog.Out("LastError.txt", i.ToString, stack(i).Trim(New Char() {" "c, ChrW(10), ChrW(13)}), True)
            End If
            i -= 1
        Loop
        ErrorLog.ShowError(e.InnerException, sb)
        If (Not userinfo Is Nothing) Then
            sb.Insert(0, userinfo & ChrW(10) & ChrW(10))
        End If
        MessageBox.Show(sb.ToString, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class