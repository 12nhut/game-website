<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="PS3.aspx.vb" Inherits="_Default" Theme="Systems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            height: 170px;
            width: 345px;
        }
        .style9
        {
            height: 172px;
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2">
    <tr>
        <td class="SystemStyle">
            <img alt="PS3 Logo" class="style8" src="Images/PS3%20Logo.jpg" /></td>
        <td class="SystemStyle">
            <img alt="PS3" 
                class="style9" src="Images/PS3.jpg" /></td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Label ID="Label1" runat="server" Text="Playstation 3 Games:" 
                SkinID="SystemName"></asp:Label>
&nbsp;&nbsp;
            </td>
        <td class="SystemStyle">
            <asp:DropDownList ID="PS3GamesDropDownList" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Label ID="Label2" runat="server" Text="Date released:" SkinID="SystemName"></asp:Label>
&nbsp;&nbsp;&nbsp;
            </td>
        <td class="SystemStyle">
            <asp:Label ID="DateReleasedLabel" runat="server" SkinID="GameInfo"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Label ID="Label3" runat="server" Text="Price:" SkinID="SystemName"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td class="SystemStyle">
            <asp:Label ID="PriceLabel" runat="server" SkinID="GameInfo"></asp:Label>
        </td>
        <td>
            <asp:Image ID="PS3GamesImage" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Label ID="Label4" runat="server" Text="Summary: " SkinID="SystemName"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td class="SystemStyle">
            <asp:Label ID="SummaryLabel" runat="server" SkinID="GameInfo"></asp:Label>
            </td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Button ID="AddToCartButton" runat="server" Text="Add to Cart" />
        </td>
        <td class="SystemStyle">
            <asp:Button ID="GoToCartButton" runat="server" Text="Go to Cart" 
                PostBackUrl="~/Cart.aspx" />
        </td>
    </tr>
</table>
</asp:Content>

