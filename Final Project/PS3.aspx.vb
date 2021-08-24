'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This PS3 page contain a dropdownlist of the names of the games, information of the games wil display after a game is
'               selected, Add to Cart to add to the game to cart and direct to the Cart page, Go To Cart button only direct to the
'               Cart page without doing anything.
Partial Class _Default
    Inherits System.Web.UI.Page
    'List to store to Product
    Private ProductList As New List(Of Product)
    'List to store the Order
    Private OrderList As New List(Of Product)
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Is page not being post back
        If Not IsPostBack Then
            'Create three new games, add to the list and add the name to the dropdownlist
            Dim CallOfDutyModernWarfare3 As Product = New Product("Call of Duty: Modern Warfare 3", "11/8/2011", 59.99, "Modern Warfare is back. On November 8th, the best-selling first person action series of all-time returns with the epic sequel to the multiple Game of the Year award winner Call of Duty: Modern Warfare 2.", "Images/PS3 Games/Call of Duty Modern Warfare 3.jpg")
            ProductList.Add(CallOfDutyModernWarfare3)
            PS3GamesDropDownList.Items.Add(CallOfDutyModernWarfare3.Name)

            Dim ElderScrollsVSkyrim As Product = New Product("The Elder Scrolls V: Skyrim", "11/11/2011", 59.99, "The next chapter in the highly anticipated Elder Scrolls saga arrives from the makers of the 2006 and 2008 Games of the Year, Bethesda Game Studios. Skyrim reimagines and revolutionizes the open-world fantasy epic, bringing to life a complete virtual world open for you to explore any way you choose.", "Images/PS3 Games/Skyrim.jpg")
            ProductList.Add(ElderScrollsVSkyrim)
            PS3GamesDropDownList.Items.Add(ElderScrollsVSkyrim.Name)

            Dim Battlefield3 As Product = New Product("Battlefield 3", "10/25/2011", 59.99, "Battlefield 3 leaps ahead of the competition with the power of Frostbite 2, the next installment of DICE's cutting-edge game engine.", "Images/PS3 Games/Battlefield 3.jpg")
            ProductList.Add(Battlefield3)
            PS3GamesDropDownList.Items.Add(Battlefield3.Name)

            'Add the list to the session
            Session("ProductList") = ProductList
            'Hide the games images
            PS3GamesImage.Visible = False
        Else
            'Else, retrieve the product from session
            ProductList = CType(Session("ProductList"), List(Of Product))
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

    Protected Sub PS3GamesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PS3GamesDropDownList.SelectedIndexChanged
        'Show the games images
        PS3GamesImage.Visible = True
        'Retrieve the selected games from the list
        Dim SelectedPS3GamesProduct As Product = ProductList(PS3GamesDropDownList.SelectedIndex)
        'Show the game's information to the labels
        DateReleasedLabel.Text = SelectedPS3GamesProduct.DateReleased
        PriceLabel.Text = SelectedPS3GamesProduct.Price.ToString("C")
        SummaryLabel.Text = SelectedPS3GamesProduct.Summary
        PS3GamesImage.ImageUrl = SelectedPS3GamesProduct.ImageFile
    End Sub

    Protected Sub AddToCartButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddToCartButton.Click
        'If the OrderList session is empty
        If Session("OrderList") Is Nothing Then
            'Create a new empty list
            OrderList = New List(Of Product)
        Else
            'Else, retrieve the OrderList from session
            OrderList = CType(Session("OrderList"), List(Of Product))
        End If
        'Create a new Product
        Dim Product As New Product
        'Retrieve the Product name from selected game in dropdownlist
        Product.Name = PS3GamesDropDownList.SelectedValue
        'Add the product to the list
        OrderList.Add(Product)
        'Add the list to the session
        Session("OrderList") = OrderList
        'Redirect to the Cart page
        Response.Redirect("Cart.aspx")
    End Sub
End Class
