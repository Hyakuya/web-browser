Public Class Form1
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        WebBrowser.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser.GoForward()
        If Keys.XButton1 Then
            WebBrowser.GoForward()
        End If
    End Sub

    Private Sub Go_Back_Click(sender As Object, e As EventArgs) Handles Go_Back.Click
        WebBrowser.GoBack()
    End Sub

    Private Sub progress_Click(sender As Object, e As EventArgs) Handles progress.Click

    End Sub

    Private Sub WebBrowser_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser.ProgressChanged
        progress.Text = WebBrowser.StatusText
    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        Me.Text = WebBrowser.DocumentTitle
        TextBox1.Text = WebBrowser.Url.ToString
    End Sub




End Class
