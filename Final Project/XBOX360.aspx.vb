'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This XBOX360 page contain a dropdownlist of the names of the games, information of the games wil display after a game is
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
            Dim AssassinCreedRevelations As Product = New Product("Assassin's Creed Revelations", "11/15/2011", 59.99, "When a man's battles have been won and his enemies destroyed what then? Where does he find purpose and meaning? To find answers to these questions, Ezio Auditore will travel east in search of the lost library of the Assassins.", "Images/XBOX360 Games/Assassin's Creed Revelations.jpg")
            ProductList.Add(AssassinCreedRevelations)
            XBOX360GamesDropDownList.Items.Add(AssassinCreedRevelations.Name)

            Dim HaloCombatEvolvedAnniversary As Product = New Product("Halo: Combat Evolved Anniversary", "11/15/2011", 39.99, "Halo: Combat Evolved Anniversary is a spectacularly remastered version of the original Halo campaign, created in celebration of the 10th anniversary of one of the most beloved franchises in gaming history.", "Images/XBOX360 Games/Halo Combat Evolved Anniversary.jpg")
            ProductList.Add(HaloCombatEvolvedAnniversary)
            XBOX360GamesDropDownList.Items.Add(HaloCombatEvolvedAnniversary.Name)

            Dim SaintsRowTheThird As Product = New Product("Saints Row The Third", "11/15/2011", 59.99, "Years after taking Stilwater for their own, the Third Street Saints have evolved from street gang to household brand name, with Saints sneakers, Saints energy drinks and Johnny Gat bobble head dolls all available at a store near you.", "Images/XBOX360 Games/Saints Row The Third.jpg")
            ProductList.Add(SaintsRowTheThird)
            XBOX360GamesDropDownList.Items.Add(SaintsRowTheThird.Name)

            'Add the list to the session
            Session("ProductList") = ProductList
            'Hide the games images
            XBOX360GamesImage.Visible = False
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

    Protected Sub XBOX360GamesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XBOX360GamesDropDownList.SelectedIndexChanged
        'Show the games images
        XBOX360GamesImage.Visible = True
        'Retrieve the selected games from the list
        Dim SelectedPS3GamesProduct As Product = ProductList(XBOX360GamesDropDownList.SelectedIndex)
        'Show the game's information to the labels
        DateReleasedLabel.Text = SelectedPS3GamesProduct.DateReleased
        PriceLabel.Text = SelectedPS3GamesProduct.Price.ToString("C")
        SummaryLabel.Text = SelectedPS3GamesProduct.Summary
        XBOX360GamesImage.ImageUrl = SelectedPS3GamesProduct.ImageFile
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
        Product.Name = XBOX360GamesDropDownList.SelectedValue
        'Add the product to the list
        OrderList.Add(Product)
        'Add the list to the session
        Session("OrderList") = OrderList
        'Redirect to the Cart page
        Response.Redirect("Cart.aspx")
    End Sub
End Class
