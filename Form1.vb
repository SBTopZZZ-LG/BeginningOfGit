Imports System.IO
Imports System.Net
Imports lib32.Class1
Public Class Form1
    Dim ab As New lib32.Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Paste()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ab.Link = TextBox1.Text
        ab.SaveTo = TextBox2.Text
        ab.DownloadAll()
        Label7.Text = ab.TotalBytesRecieved
        Label8.Text = ab.BytesRemaining
        ProgressBar1.Value = Val(ab.Percentagedownload)
    End Sub
End Class
