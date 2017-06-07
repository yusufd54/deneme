Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sorgula()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            sorgula()
        End If
    End Sub
    Private Sub sorgula()
        Dim browser As New WebBrowser
        browser.Navigate("https://www.google.com.tr/#q=" & TextBox1.Text.Replace(" ", "+"))
        While Not browser.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        End While
        Label4.Text = (browser.Document.GetElementsByTagName("span").Item(browser.Document.GetElementsByTagName("span").Count - 3).InnerText)
        Label5.Text = (browser.Document.GetElementsByTagName("span").Item(browser.Document.GetElementsByTagName("span").Count - 1).InnerText)
    End Sub
End Class
