'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This Cart contain the games that has been to added to cart in a listbox, users can remove one item using the Remove
'               Item button or Empty All button to remove all item in the listbox. Users also can use Continue Shopping button
'               to direct back to System page or check out using Check Out button.
Partial Class _Default
    Inherits System.Web.UI.Page
    'List to store Order
    Private NewOrderList As New List(Of Product)
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If page is not being post back
        If Not IsPostBack Then
            'If OrderList session is empty
            If Session("OrderList") Is Nothing Then
                'Create a new empty list
                NewOrderList = New List(Of Product)
            Else
                'Retrieve the OrderList from the session
                NewOrderList = CType(Session("OrderList"), List(Of Product))
                For Each Product As Product In NewOrderList
                    'Show the Products' name to the listbox
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

    Protected Sub RemoveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        'If OrderList is empty
        If Session("OrderList") Is Nothing Then
            'Create a new empty list
            NewOrderList = New List(Of Product)
        Else
            'Retrieve the OrderList from session
            NewOrderList = CType(Session("OrderList"), List(Of Product))
            'Remove the selected item from the listbox in the list
            NewOrderList.RemoveAt(OrdersListBox.SelectedIndex)
            'Put the list back to the session
            Session("OrderList") = NewOrderList
        End If
        'Remove the selected item in the listbox
        OrdersListBox.Items.RemoveAt(OrdersListBox.SelectedIndex)
    End Sub

    Protected Sub EmptyAllButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmptyAllButton.Click
        'Remove the OrderList session
        Session.Remove("OrderList")
        'Clear the listbox
        OrdersListBox.Items.Clear()
    End Sub

    Protected Sub ContinueShoppingButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContinueShoppingButton.Click
        'If Name query string is not empty
        If Request.QueryString("Name") IsNot Nothing Then
            'Retrieve the Name query string
            Dim LastNameString As String = Request.QueryString("Name")
            'Redirect to the System page with the Name query string
            Response.Redirect("System.aspx?Name=" & LastNameString)
        Else
            'else, 'Redirect to the System page without the Name query string
            Response.Redirect("System.aspx")
        End If
    End Sub

    Protected Sub CheckOutButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckOutButton.Click
        'If Name query string is not empty 
        If Request.QueryString("Name") IsNot Nothing Then
            'Retrieve the Name query string
            Dim LastNameString As String = Request.QueryString("Name")
            'Redirect to the CheckOut page with the Name query string
            Response.Redirect("CheckOut.aspx?Name=" & LastNameString)
        Else
            'Redirect to the CheckOut page without the Name query string
            Response.Redirect("CheckOut.aspx")
        End If
    End Sub
End Class
