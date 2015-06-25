Imports System
Imports System.IO
Imports System.Net
Imports System.Text
'Imports System.Drawing.Imaging


Public Class Form1

    Private Sub LoadIPAddress()

        tbxGETURL.Text = "http://" + tbxIPAddr.Text + ":8060/query/apps"
        tbxPOSTURL.Text = "http://" + tbxIPAddr.Text + ":8060/keypress/home"
        tbxCommand.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPOST.Click
        ' WebRequestPOST.Main("http://www.contoso.com/PostAccepter.aspx", "This is a test that posts this string to a Web server.")
        WebRequestPOST.Main(tbxPOSTURL.Text, tbxCommand.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxIPAddr.Text = "192.168.1.10"
        Me.LoadIPAddress()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnGET_Click(sender As Object, e As EventArgs) Handles btnGET.Click
        WebRequestGET.Main(tbxGETURL.Text)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnUpdateIP.Click
        Me.LoadIPAddress()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/home", tbxCommand.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/back", tbxCommand.Text)
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/up", tbxCommand.Text)
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/left", tbxCommand.Text)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Select", tbxCommand.Text)
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/right", tbxCommand.Text)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/down", tbxCommand.Text)
    End Sub

    Private Sub btnAmazon_Click(sender As Object, e As EventArgs) Handles btnAmazon.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/launch/13", tbxCommand.Text)
    End Sub

    Private Sub btnPBSKids_Click(sender As Object, e As EventArgs) Handles btnPBSKids.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/launch/23333", tbxCommand.Text)
    End Sub

    Private Sub btnNetflix_Click(sender As Object, e As EventArgs) Handles btnNetflix.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/launch/12", tbxCommand.Text)
    End Sub

    Private Sub btnWeather_Click(sender As Object, e As EventArgs) Handles btnWeather.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/launch/8617", tbxCommand.Text)
    End Sub

    Private Sub btnRev_Click(sender As Object, e As EventArgs) Handles btnRev.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Rev", tbxCommand.Text)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Play", tbxCommand.Text)
    End Sub

    Private Sub btnFwd_Click(sender As Object, e As EventArgs) Handles btnFwd.Click
        WebRequestPOST.Main("http://" + tbxIPAddr.Text + ":8060/keypress/Fwd", tbxCommand.Text)
    End Sub
End Class

Public Class WebRequestPOST

    Public Shared Sub Main(URL As String, Optional strCmdData As String = "")
        ' Create a request using a URL that can receive a post. 
        Dim request As WebRequest = WebRequest.Create(URL)
        ' Set the Method property of the request to POST.
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.
        Dim postData As String = strCmdData
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.
        request.ContentType = "application/x-www-form-urlencoded"
        ' Set the ContentLength property of the WebRequest.
        request.ContentLength = byteArray.Length
        ' Get the request stream.
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.
        dataStream.Close()
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        Console.WriteLine(responseFromServer)
        Form1.tbxResponse.Text = responseFromServer

        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub
End Class

Public Class WebRequestGET

    Public Shared Sub Main(URL As String)
        ' Create a request for the URL. 
        Dim request As WebRequest = _
          WebRequest.Create(URL)
        ' If required by the server, set the credentials.
        ' request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        'Dim iconResponseFromServer As Image = reader.ReadToEnd()


        ' Display the content.
        Console.WriteLine(responseFromServer)
        Form1.tbxResponse.Text = responseFromServer
        'Form1.WebBrowser1.Document = responseFromServer
        'Form1.pbxIcon.Image = responseFromServer
        ' Clean up the streams and the response.
        reader.Close()
        response.Close()
    End Sub

    
End Class
