Imports MySql.Data.MySqlClient

Public Class express_main
    Public conn As New MySqlConnection
    Dim status As String
    Dim login As Form2 = New Form2
    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim ppt As PPT_Calc = New PPT_Calc
        ppt.Show()
        ppt.TopMost = True
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Form2.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abtbx As AboutBox = New AboutBox
        abtbx.ShowDialog(Me)
    End Sub
    Private Sub expres_main_resize(sender As Object, e As EventArgs) Handles Me.Resize

        login.Top = (Me.Height - Me.Height) / 2
        login.Left = (Me.Width - Me.Width) / 2
    End Sub
    Public Sub express_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=localhost;" _
            & "uid=root;" _
            & "pwd=Cae12sar#$;" _
            & "database=express_fuel;"
        Try
            conn.Open()
            status = "Connected"
        Catch ex As Exception
            status = "Not Connected"
            MsgBox(ex.Message)
        End Try
        login.MdiParent = Me
        login.Show()
        Me.status_strip.Text = status

    End Sub
End Class