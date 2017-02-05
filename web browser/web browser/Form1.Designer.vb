<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Go_Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.progress = New System.Windows.Forms.Label()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Go_Back
        '
        Me.Go_Back.Location = New System.Drawing.Point(12, 12)
        Me.Go_Back.Name = "Go_Back"
        Me.Go_Back.Size = New System.Drawing.Size(30, 30)
        Me.Go_Back.TabIndex = 0
        Me.Go_Back.Text = "<"
        Me.Go_Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.Refresh.Location = New System.Drawing.Point(84, 12)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(30, 30)
        Me.Refresh.TabIndex = 2
        Me.Refresh.Text = "↺"
        Me.Refresh.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(952, 20)
        Me.TextBox1.TabIndex = 3
        '
        'progress
        '
        Me.progress.AutoSize = True
        Me.progress.Location = New System.Drawing.Point(4, 544)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(10, 13)
        Me.progress.TabIndex = 4
        Me.progress.Text = "-"
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(7, 48)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(1065, 493)
        Me.WebBrowser.TabIndex = 5
        Me.WebBrowser.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Go_Back)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Go_Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents progress As Label
    Friend WithEvents WebBrowser As WebBrowser
End Class
