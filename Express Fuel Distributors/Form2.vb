Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String = username.Text
        Dim pass As String = password.Text
        login(user, pass)
    End Sub

    Public Function login(ByVal user As String, ByVal pass As String)
        Dim cmd As New MySqlCommand(String.Format("SELECT * FROM login WHERE user = '{0}' AND password = '{1}'", user.Trim(), pass.Trim()), conn)
        Dim response As Integer
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            reader = cmd.ExecuteReader
            response = 0
            While reader.Read
                response = response + 1
            End While
            If response = 1 Then
                Return True
            Else
                Return MessageBox.Show("LOGIN FAILED")
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
        conn.Close()
    End Function
    Public Sub fade_in()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    'Fade out:
    Public Sub fade_out()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fade_in()
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        fade_out()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    Private Sub cancel_btn__Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class