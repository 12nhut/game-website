'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This Wii page contain a dropdownlist of the names of the games, information of the games wil display after a game is
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
            Dim SuperMarioGalaxy2 As Product = New Product("Super Mario Galaxy 2", "5/23/2010", 49.99, "Mario Blasts Off for another Out-of-This-World Adventure In 2007, Super Mario Galaxy took the world of video games by storm.", "Images/Wii Games/Super Mario Galaxy 2.jpg")
            ProductList.Add(SuperMarioGalaxy2)
            WiiGamesDropDownList.Items.Add(SuperMarioGalaxy2.Name)

            Dim KirbyEpicYarn As Product = New Product("Kirby's Epic Yarn", "10/17/2010", 29.99, "Kirby's first console platform game since the Nintendo 64 days introduces an amazing new look based on animated yarn and a world of cloth and textiles.", "Images/Wii Games/Kirby's Epic Yarn.jpg")
            ProductList.Add(KirbyEpicYarn)
            WiiGamesDropDownList.Items.Add(KirbyEpicYarn.Name)

            Dim WiiSportsResort As Product = New Product("Wii Sports Resort", "7/26/2009", 39.99, "Wii Sports Resort is an immersive, expansive active-play game that includes a dozen fun resort-themed activities.", "Images/Wii Games/Wii Sports Resort.jpg")
            ProductList.Add(WiiSportsResort)
            WiiGamesDropDownList.Items.Add(WiiSportsResort.Name)

            'Add the list to the session
            Session("ProductList") = ProductList
            'Hide the games images
            WiiGamesImage.Visible = False
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

    Protected Sub WiiGamesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WiiGamesDropDownList.SelectedIndexChanged
        'Show the games images
        WiiGamesImage.Visible = True
        'Retrieve the selected games from the list
        Dim SelectedPS3GamesProduct As Product = ProductList(WiiGamesDropDownList.SelectedIndex)
        'Show the game's information to the labels
        DateReleasedLabel.Text = SelectedPS3GamesProduct.DateReleased
        PriceLabel.Text = SelectedPS3GamesProduct.Price.ToString("C")
        SummaryLabel.Text = SelectedPS3GamesProduct.Summary
        WiiGamesImage.ImageUrl = SelectedPS3GamesProduct.ImageFile
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
        Product.Name = WiiGamesDropDownList.SelectedValue
        'Add the product to the list
        OrderList.Add(Product)
        'Add the list to the session
        Session("OrderList") = OrderList
        'Redirect to the Cart page
        Response.Redirect("Cart.aspx")
    End Sub
End Class
