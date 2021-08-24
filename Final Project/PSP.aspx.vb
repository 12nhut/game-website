'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This PSP page contain a dropdownlist of the names of the games, information of the games wil display after a game is
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
            Dim MonsterHunterFreedomUnite As Product = New Product("Monster Hunter Freedom Unite", "6/23/2009", 8.99, "Japan's most successful PSP title, Monster Hunter Portable 2nd G, is heading to the west. Renamed Monster Hunter Freedom Unite.", "Images/PSP Games/Monster Hunter Freedom Unite.jpg")
            ProductList.Add(MonsterHunterFreedomUnite)
            PSPGamesDropDownList.Items.Add(MonsterHunterFreedomUnite.Name)

            Dim NeedForSpeed As Product = New Product("Need For Speed: Most Wanted 5-1-0", "11/15/2005", 9.99, "Wake up to the smell of burnt asphalt as the thrill of illicit street racing permeates the air.", "Images/PSP Games/Need For Speed Most Wanted.jpg")
            ProductList.Add(NeedForSpeed)
            PSPGamesDropDownList.Items.Add(NeedForSpeed.Name)

            Dim NBA2K12 As Product = New Product("NBA 2K12", "10/4/2011", 19.99, "With over 5 million copies sold worldwide and over 20 Sports Game of Year awards, last year NBA 2K11 allowed you to BECOME THE GREATEST with MJ & the Jordan Challenge mode.", "Images/PSP Games/NBA 2K12.jpg")
            ProductList.Add(NBA2K12)
            PSPGamesDropDownList.Items.Add(NBA2K12.Name)

            'Add the list to the session
            Session("ProductList") = ProductList
            'Hide the games images
            PSPGamesImage.Visible = False
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

    Protected Sub PSPGamesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PSPGamesDropDownList.SelectedIndexChanged
        'Show the games images
        PSPGamesImage.Visible = True
        'Retrieve the selected games from the list
        Dim SelectedPS3GamesProduct As Product = ProductList(PSPGamesDropDownList.SelectedIndex)
        'Show the game's information to the labels
        DateReleasedLabel.Text = SelectedPS3GamesProduct.DateReleased
        PriceLabel.Text = SelectedPS3GamesProduct.Price.ToString("C")
        SummaryLabel.Text = SelectedPS3GamesProduct.Summary
        PSPGamesImage.ImageUrl = SelectedPS3GamesProduct.ImageFile
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
        Product.Name = PSPGamesDropDownList.SelectedValue
        'Add the product to the list
        OrderList.Add(Product)
        'Add the list to the session
        Session("OrderList") = OrderList
        'Redirect to the Cart page
        Response.Redirect("Cart.aspx")
    End Sub
End Class
