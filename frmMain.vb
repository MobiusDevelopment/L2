Imports System.IO

Public Class frmMain
    Dim SERVER_IP As String = "127.0.0.1"
    Dim IP_FILE As String = "connect.ini"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make form invisible
        Me.Visible = False

        'get ip from file, if it exists
        If File.Exists(IP_FILE) Then
            Using fileReader As StreamReader = New StreamReader(IP_FILE)
                SERVER_IP = Integer.Parse(fileReader.ReadLine)
            End Using
        End If

        'execute l2.bin
        Try
            Shell("l2.bin IP=" + SERVER_IP, vbNormalFocus)
        Catch ex As Exception
            MsgBox("L2.bin not found! Try checking your files.", MsgBoxStyle.Critical, "L2")
        End Try

        'close L2
        End
    End Sub
End Class
