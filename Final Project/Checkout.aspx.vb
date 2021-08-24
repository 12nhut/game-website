'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This CheckOut page contain three textboxes that required users to input their first name, last name, and email.
Partial Class _Default
    Inherits System.Web.UI.Page
    'Create a Customer object
    Private Customer As Customer
    'Variable to store Name query string
    Private LastNameString As String
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If page is not being post back
        If Not IsPostBack Then
            'If Customer session is empty
            If Session("Customer") Is Nothing Then
                'Create a new Customer object
                Customer = New Customer
            Else
                'Retrieve the Customer object from the session
                Customer = CType(Session("Customer"), Customer)
                'Show the Customer information to the textboxes
                FirstNameTextBox.Text = Customer.FirstName
                LastNameTextBox.Text = Customer.LastName
                EmailTextBox.Text = Customer.Email
            End If
        End If
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

    Protected Sub ConfirmButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConfirmButton.Click
        'Retrieve the Email value from the textbox
        Dim EmailString As String = EmailTextBox.Text
        'If CustomerEmail cookies is empty
        If Request.Cookies("CustomerEmail") Is Nothing Then
            'Create a new Cookie
            Dim CustomerEmailCookies As New HttpCookie("CustomerEmail", EmailString)
            'Make the expiration of the cookie to 6 months
            CustomerEmailCookies.Expires.AddMonths(6)
            'Add the cookie to the HttpResponse
            Response.Cookies.Add(CustomerEmailCookies)
        Else
            'else, Add the Email value to the CustomerEmail cookie
            Response.Cookies("CustomerEmail").Value = EmailString
        End If

        'Create a new customer
        Customer = New Customer
        'Retrieve the value from the textboxes
        Customer.FirstName = FirstNameTextBox.Text
        Customer.LastName = LastNameTextBox.Text
        Customer.Email = EmailTextBox.Text
        'Add the new Customer to the session
        Session("Customer") = Customer
        'Retrieve the last name value
        LastNameString = LastNameTextBox.Text
        'Redirect to the Confirmation page with the Last name value
        Response.Redirect("Confirmation.aspx?Name=" & LastNameString)
    End Sub

    Protected Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        'Remove the Customer and OrderList session
        Session.Remove("Customer")
        Session.Remove("OrderList")
        'Redirect back to the System page
        Response.Redirect("System.aspx")
    End Sub

    Protected Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clear all textboxes
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        EmailTextBox.Text = ""
    End Sub
End Class
