'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:  This Confirmation page contain a summary of the customers' information and Continue Shopping button to direct back
'               to the System page, Cancel Order button to cancel the order, Modify Cart to button to direct back to the Cart page
'               and a Confirm Order button the confirm the transaction.
Partial Class _Default
    Inherits System.Web.UI.Page
    'Create a Customer object
    Private Customer As Customer
    'List to store Order
    Private NewOrderList As New List(Of Product)
    'Variable to store Name query string
    Private LastNameString As String
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If the page is not being post back
        If Not IsPostBack Then
            'If the Customer session is empty
            If Session("Customer") Is Nothing Then
                'Create a new Customer object
                Customer = New Customer
                'If the OrderList session is empty
                If Session("OrderList") Is Nothing Then
                    'Create a New OrderList list
                    NewOrderList = New List(Of Product)
                End If
            Else
                'else, retrieve the Customer object from the sesssion
                Customer = CType(Session("Customer"), Customer)
                'Show the Customer information to the labels
                FirstNameLabel.Text = Customer.FirstName
                LastNameLabel.Text = Customer.LastName
                EmailLabel.Text = Customer.Email
                'Retrieve the OrderList from the session
                NewOrderList = CType(Session("OrderList"), List(Of Product))
                For Each Product As Product In NewOrderList
                    'Add the product name to listbox
                    OrdersListBox.Items.Add(Product.Name)
                Next
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

    Protected Sub CancelOrderButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelOrderButton.Click
        'Remove the Customer and OrderList session
        Session.Remove("Customer")
        Session.Remove("OrderList")
        'Redirect back to the System page
        Response.Redirect("System.aspx")
    End Sub

    Protected Sub ConfirmOrderButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConfirmOrderButton.Click
        'Implement the RetrieveNameQueryString procedure
        RetrieveNameQueryString()
        'Show the ThankYou label with the Name query string
        ThankYouLabel.Text = "Thank you " & LastNameString & " for your visiting.<br />" &
                          "An order confirmation has been send to your email"
    End Sub

    Protected Sub ModifyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifyButton.Click
        'Implement the RetrieveNameQueryString procedure
        RetrieveNameQueryString()
        'Redirect to the Cart page with the Name query string
        Response.Redirect("Cart.aspx?Name=" & LastNameString)
    End Sub

    Protected Sub ContinueShoppingButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContinueShoppingButton.Click
        'Implement the RetrieveNameQueryString procedure
        RetrieveNameQueryString()
        'Redirect to the System page with the Name query string
        Response.Redirect("System.aspx?Name=" & LastNameString)
    End Sub

    'Sub procedure to retrieve the Name query string
    Private Sub RetrieveNameQueryString()
        'If the Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Retrieve the Name query string
            LastNameString = Request.QueryString("Name")
        End If
    End Sub
End Class
