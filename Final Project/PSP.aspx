<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="PSP.aspx.vb" Inherits="_Default" Theme="Systems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style17
        {
            height: 106px;
            width: 290px;
        }
        .style16
        {
            width: 238px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2">
    <tr>
        <td class="SystemStyle">
            <img alt="PSP Logo" class="style17" src="Images/PSP%20Logo.png" /></td>
        <td class="SystemStyle">
            <img alt="PSP" class="style16" src="Images/PSP.png" /></td>
    </tr>
    <tr>
        <td class="SystemStyle">
            <asp:Label ID="Label1" runat="server" Text="Playstation Portable Games:" 
                SkinID="SystemName"></asp:Label>
&nbsp;&nbsp;
            </td>
        <td class="SystemStyle">
            <asp:DropDownList ID="PSPGamesDropDownList" runat="server" AutoPostBack="True">
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
            <asp:Image ID="PSPGamesImage" runat="server" />
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

