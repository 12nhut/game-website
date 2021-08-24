'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This N3DS page contain a dropdownlist of the names of the games, information of the games wil display after a game is
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
        'If page is not being post back
        If Not IsPostBack Then
            'Create three new games, add to the list and add the name to the dropdownlist
            Dim MarioKart7 As Product = New Product("Mario Kart 7 ", "12/4/2011", 39.99, "The newest installment of the fan-favorite Mario Kart franchise brings Mushroom Kingdom racing fun into glorious 3D.", "Images/3DS Games/Mario Kart 7.jpg")
            ProductList.Add(MarioKart7)
            N3DSGamesDropDownList.Items.Add(MarioKart7.Name)

            Dim TheLegendofZeldaOcarinaofTime As Product = New Product("The Legend of Zelda: Ocarina of Time", "6/19/2011", 39.99, "The Legend of Zelda: Ocarina of Time 3D brings a completely re-mastered version of this epic entry in the beloved The Legend of Zelda series to the Nintendo 3DS system.", "Images/3DS Games/The Legend of Zelda Ocarina of Time.jpg")
            ProductList.Add(TheLegendofZeldaOcarinaofTime)
            N3DSGamesDropDownList.Items.Add(TheLegendofZeldaOcarinaofTime.Name)

            Dim SteelDiver As Product = New Product("Steel Diver", "3/27/2011", 39.99, "Steel Diver is a new action-packed submarine combat game from Nintendo that immerses players in the 3D action with unique game controls and lush 3D environments.", "Images/3DS Games/Steel Diver.jpg")
            ProductList.Add(SteelDiver)
            N3DSGamesDropDownList.Items.Add(SteelDiver.Name)

            'Add the list to the session
            Session("ProductList") = ProductList
            'Hide the games image
            N3DSGamesImage.Visible = False
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

    Protected Sub N3DSGamesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles N3DSGamesDropDownList.SelectedIndexChanged
        'Show the games images
        N3DSGamesImage.Visible = True
        'Retrieve the selected games from the list
        Dim SelectedPS3GamesProduct As Product = ProductList(N3DSGamesDropDownList.SelectedIndex)
        'Show the game's information to the labels
        DateReleasedLabel.Text = SelectedPS3GamesProduct.DateReleased
        PriceLabel.Text = SelectedPS3GamesProduct.Price.ToString("C")
        SummaryLabel.Text = SelectedPS3GamesProduct.Summary
        N3DSGamesImage.ImageUrl = SelectedPS3GamesProduct.ImageFile
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
        Product.Name = N3DSGamesDropDownList.SelectedValue
        'Add the product to the list
        OrderList.Add(Product)
        'Add the list to the session
        Session("OrderList") = OrderList
        'Redirect to the Cart page
        Response.Redirect("Cart.aspx")
    End Sub
End Class
