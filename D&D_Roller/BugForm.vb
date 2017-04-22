Imports System.Web
Imports System.IO
Imports System.Net.Mail
Public Class BugForm
    Private Sub BugForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mail As New MailMessage
            mail.From = New MailAddress("bono.chaz123@gmail.com")
            mail.To.Add("bono.chaz123@gmail.com")
            mail.Subject = "Bug Report"
            mail.Body = TextBox1.Text
            Dim test As New SmtpClient("smtp.gmail.com")
            test.Port = 587
            test.EnableSsl = True
            test.Credentials = New System.Net.NetworkCredential("bono.chaz123@gmail.com", "Chazomail191$")
            test.Send(mail)
            MsgBox("SENT!")
            Me.Close()
        Catch ex As Exception
            MsgBox("UNKNOWN ERROR!")
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class