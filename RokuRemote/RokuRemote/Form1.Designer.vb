<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPOST = New System.Windows.Forms.Button()
        Me.tbxPOSTURL = New System.Windows.Forms.TextBox()
        Me.tbxCommand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxResponse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGET = New System.Windows.Forms.Button()
        Me.tbxGETURL = New System.Windows.Forms.TextBox()
        Me.tbxIPAddr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateIP = New System.Windows.Forms.Button()
        Me.pbxIcon = New System.Windows.Forms.PictureBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNetflix = New System.Windows.Forms.Button()
        Me.btnAmazon = New System.Windows.Forms.Button()
        Me.btnPBSKids = New System.Windows.Forms.Button()
        Me.btnWeather = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnRev = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPOST
        '
        Me.btnPOST.Location = New System.Drawing.Point(29, 20)
        Me.btnPOST.Name = "btnPOST"
        Me.btnPOST.Size = New System.Drawing.Size(75, 23)
        Me.btnPOST.TabIndex = 0
        Me.btnPOST.Text = "POST"
        Me.btnPOST.UseVisualStyleBackColor = True
        '
        'tbxPOSTURL
        '
        Me.tbxPOSTURL.Location = New System.Drawing.Point(29, 110)
        Me.tbxPOSTURL.Name = "tbxPOSTURL"
        Me.tbxPOSTURL.Size = New System.Drawing.Size(411, 20)
        Me.tbxPOSTURL.TabIndex = 1
        '
        'tbxCommand
        '
        Me.tbxCommand.Location = New System.Drawing.Point(29, 136)
        Me.tbxCommand.Name = "tbxCommand"
        Me.tbxCommand.Size = New System.Drawing.Size(411, 20)
        Me.tbxCommand.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL to POST to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Command to POST"
        '
        'tbxResponse
        '
        Me.tbxResponse.Location = New System.Drawing.Point(29, 166)
        Me.tbxResponse.Multiline = True
        Me.tbxResponse.Name = "tbxResponse"
        Me.tbxResponse.Size = New System.Drawing.Size(410, 106)
        Me.tbxResponse.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Response"
        '
        'btnGET
        '
        Me.btnGET.Location = New System.Drawing.Point(124, 20)
        Me.btnGET.Name = "btnGET"
        Me.btnGET.Size = New System.Drawing.Size(75, 23)
        Me.btnGET.TabIndex = 7
        Me.btnGET.Text = "GET"
        Me.btnGET.UseVisualStyleBackColor = True
        '
        'tbxGETURL
        '
        Me.tbxGETURL.Location = New System.Drawing.Point(29, 84)
        Me.tbxGETURL.Name = "tbxGETURL"
        Me.tbxGETURL.Size = New System.Drawing.Size(411, 20)
        Me.tbxGETURL.TabIndex = 8
        '
        'tbxIPAddr
        '
        Me.tbxIPAddr.Location = New System.Drawing.Point(29, 58)
        Me.tbxIPAddr.Name = "tbxIPAddr"
        Me.tbxIPAddr.Size = New System.Drawing.Size(411, 20)
        Me.tbxIPAddr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "IP Address of Roku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "URL to GET from"
        '
        'btnUpdateIP
        '
        Me.btnUpdateIP.Location = New System.Drawing.Point(218, 20)
        Me.btnUpdateIP.Name = "btnUpdateIP"
        Me.btnUpdateIP.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateIP.TabIndex = 12
        Me.btnUpdateIP.Text = "Update IP"
        Me.btnUpdateIP.UseVisualStyleBackColor = True
        '
        'pbxIcon
        '
        Me.pbxIcon.Location = New System.Drawing.Point(585, 20)
        Me.pbxIcon.Name = "pbxIcon"
        Me.pbxIcon.Size = New System.Drawing.Size(81, 78)
        Me.pbxIcon.TabIndex = 13
        Me.pbxIcon.TabStop = False
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(546, 248)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(51, 24)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(546, 302)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(51, 24)
        Me.btnDown.TabIndex = 15
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(605, 275)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(51, 24)
        Me.btnRight.TabIndex = 16
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(486, 275)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(51, 24)
        Me.btnLeft.TabIndex = 17
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(546, 275)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(51, 24)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(605, 227)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(51, 24)
        Me.btnHome.TabIndex = 19
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(486, 227)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 24)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNetflix
        '
        Me.btnNetflix.Location = New System.Drawing.Point(75, 305)
        Me.btnNetflix.Name = "btnNetflix"
        Me.btnNetflix.Size = New System.Drawing.Size(62, 24)
        Me.btnNetflix.TabIndex = 21
        Me.btnNetflix.Text = "Netflix"
        Me.btnNetflix.UseVisualStyleBackColor = True
        '
        'btnAmazon
        '
        Me.btnAmazon.Location = New System.Drawing.Point(75, 278)
        Me.btnAmazon.Name = "btnAmazon"
        Me.btnAmazon.Size = New System.Drawing.Size(62, 24)
        Me.btnAmazon.TabIndex = 22
        Me.btnAmazon.Text = "Amazon"
        Me.btnAmazon.UseVisualStyleBackColor = True
        '
        'btnPBSKids
        '
        Me.btnPBSKids.Location = New System.Drawing.Point(143, 278)
        Me.btnPBSKids.Name = "btnPBSKids"
        Me.btnPBSKids.Size = New System.Drawing.Size(62, 24)
        Me.btnPBSKids.TabIndex = 23
        Me.btnPBSKids.Text = "PBS Kids"
        Me.btnPBSKids.UseVisualStyleBackColor = True
        '
        'btnWeather
        '
        Me.btnWeather.Location = New System.Drawing.Point(143, 305)
        Me.btnWeather.Name = "btnWeather"
        Me.btnWeather.Size = New System.Drawing.Size(62, 24)
        Me.btnWeather.TabIndex = 24
        Me.btnWeather.Text = "Weather"
        Me.btnWeather.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(546, 337)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(51, 24)
        Me.btnPlay.TabIndex = 27
        Me.btnPlay.Text = "| | >"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnRev
        '
        Me.btnRev.Location = New System.Drawing.Point(486, 337)
        Me.btnRev.Name = "btnRev"
        Me.btnRev.Size = New System.Drawing.Size(51, 24)
        Me.btnRev.TabIndex = 26
        Me.btnRev.Text = "<<"
        Me.btnRev.UseVisualStyleBackColor = True
        '
        'btnFwd
        '
        Me.btnFwd.Location = New System.Drawing.Point(605, 337)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(51, 24)
        Me.btnFwd.TabIndex = 25
        Me.btnFwd.Text = ">>"
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 385)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnRev)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.btnWeather)
        Me.Controls.Add(Me.btnPBSKids)
        Me.Controls.Add(Me.btnAmazon)
        Me.Controls.Add(Me.btnNetflix)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.pbxIcon)
        Me.Controls.Add(Me.btnUpdateIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxIPAddr)
        Me.Controls.Add(Me.tbxGETURL)
        Me.Controls.Add(Me.btnGET)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxResponse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxCommand)
        Me.Controls.Add(Me.tbxPOSTURL)
        Me.Controls.Add(Me.btnPOST)
        Me.Name = "Form1"
        Me.Text = "RokuRemote"
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPOST As System.Windows.Forms.Button
    Friend WithEvents tbxPOSTURL As System.Windows.Forms.TextBox
    Friend WithEvents tbxCommand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxResponse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGET As System.Windows.Forms.Button
    Friend WithEvents tbxGETURL As System.Windows.Forms.TextBox
    Friend WithEvents tbxIPAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateIP As System.Windows.Forms.Button
    Friend WithEvents pbxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNetflix As System.Windows.Forms.Button
    Friend WithEvents btnAmazon As System.Windows.Forms.Button
    Friend WithEvents btnPBSKids As System.Windows.Forms.Button
    Friend WithEvents btnWeather As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnRev As System.Windows.Forms.Button
    Friend WithEvents btnFwd As System.Windows.Forms.Button

End Class
