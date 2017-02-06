Public Class Form1

    'If enter key is pressed then it go to the site in the url
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser.Navigate(TextBox1.Text)
        End If


    End Sub

    'Refresh buttom refreshes the site
    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        WebBrowser.Refresh()
    End Sub

    'Go forward 1 page with button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser.GoForward()
    End Sub

    'go backwards 1 page with eraser key and buttin
    Private Sub Go_Back_Click(sender As Object, e As EventArgs) Handles Go_Back.Click
        WebBrowser.GoBack()
        If Keys.OemBackslash Then
            WebBrowser.GoBack()

        End If
    End Sub

    Private Sub progress_Click(sender As Object, e As EventArgs) Handles progress.Click

    End Sub

    'progress bar down in left corner tells what its doing
    Private Sub WebBrowser_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser.ProgressChanged
        progress.Text = WebBrowser.StatusText
    End Sub

    'make web browser get same name as site you are on and put url in url text box
    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        Me.Text = WebBrowser.DocumentTitle
        TextBox1.Text = WebBrowser.Url.ToString
    End Sub

    'close down web browser in file bar
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    'about popout with name of creator
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class
