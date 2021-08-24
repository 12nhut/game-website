'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This System contain each gaming systems' image button and hyperlinks that direct to each individual system's page
Partial Class _Default
    Inherits System.Web.UI.Page
    'Variable for the last name
    Private LastNameString As String
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub PS3ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PS3ImageButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the PS3 page with Name query string
            Response.Redirect("PS3.aspx?Name=" & LastNameString)
        Else
            'Else direct to PS3 page without the query string
            Response.Redirect("PS3.aspx")
        End If
    End Sub

    Protected Sub PS3LinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PS3LinkButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the PS3 page with Name query string
            Response.Redirect("PS3.aspx?Name=" & LastNameString)
        Else
            'Else direct to PS3 page without the query string
            Response.Redirect("PS3.aspx")
        End If
    End Sub

    Protected Sub WiiImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles WiiImageButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the Wii page with Name query string
            Response.Redirect("Wii.aspx?Name=" & LastNameString)
        Else
            'Else direct to Wii page without the query string
            Response.Redirect("Wii.aspx")
        End If
    End Sub

    Protected Sub WiiLinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WiiLinkButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the Wii page with Name query string
            Response.Redirect("wii.aspx?Name=" & LastNameString)
        Else
            'Else direct to Wii page without the query string
            Response.Redirect("Wii.aspx")
        End If
    End Sub

    Protected Sub XBOX360ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles XBOX360ImageButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the XBOX360 page with Name query string
            Response.Redirect("XBOX360.aspx?Name=" & LastNameString)
        Else
            'Else direct to XBOX360 page without the query string
            Response.Redirect("XBOX360.aspx")
        End If
    End Sub

    Protected Sub XBOX360LinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles XBOX360LinkButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the XBOX360 page with Name query string
            Response.Redirect("XBOX360.aspx?Name=" & LastNameString)
        Else
            'Else direct to XBOX360 page without the query string
            Response.Redirect("XBOX360.aspx")
        End If
    End Sub

    Protected Sub PSPImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles PSPImageButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the PSP page with Name query string
            Response.Redirect("PSP.aspx?Name=" & LastNameString)
        Else
            'Else direct to PSP page without the query string
            Response.Redirect("PSP.aspx")
        End If
    End Sub

    Protected Sub PSPLinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PSPLinkButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the PSP page with Name query string
            Response.Redirect("PSP.aspx?Name=" & LastNameString)
        Else
            'Else direct to PSP page without the query string
            Response.Redirect("PSP.aspx")
        End If
    End Sub

    Protected Sub N3DSImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles N3DSImageButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the N3DS page with Name query string
            Response.Redirect("N3DS.aspx?Name=" & LastNameString)
        Else
            'Else direct to N3DS page without the query string
            Response.Redirect("N3DS.aspx")
        End If
    End Sub

    Protected Sub N3DSLinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles N3DSLinkButton.Click
        'Inplement the NameQueryString sub procedure
        NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Redirect to the N3DS page with Name query string
            Response.Redirect("N3DS.aspx?Name=" & LastNameString)
        Else
            'Else direct to N3DS page without the query string
            Response.Redirect("N3DS.aspx")
        End If
    End Sub

    'Sub procedure to retrieve the Name from query string
    Private Sub NameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Retrieve the Name value
            LastNameString = Request.QueryString("Name")
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Lock the application so this page can use it only
        Application.Lock()
        'If the VisitCounter application is not empty
        If Application("VisitCounter") IsNot Nothing Then
            'Retrieve the value from the application
            VisitCounterInteger = CInt(Application("VisitCounter"))
            'Increment the value by 1
            VisitCounterInteger += 1
            'Add the value back to the application
            Application("VisitCounter") = VisitCounterInteger.ToString
        End If
        'Unlock the application for other pages
        Application.UnLock()
    End Sub
End Class
