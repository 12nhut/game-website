<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="_Default" Theme="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table">
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/System.aspx" 
                    SkinID="TableHyperLink">Game Systems</asp:HyperLink><br />
                <asp:ImageButton ID="ImageButton" runat="server" 
                    ImageUrl="~/Images/Game System.jpg" PostBackUrl="~/System.aspx" />
            </td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Cart.aspx" 
                    SkinID="TableHyperLink">My Cart</asp:HyperLink>
                <br />
                <asp:ImageButton ID="ImageButton7" runat="server" Height="50px" 
                    ImageUrl="~/Images/Cart.jpg" PostBackUrl="~/Cart.aspx" Width="59px" />
            </td>
        </tr>
    </table>
        <asp:Label ID="VisitCounterLabel" runat="server" SkinID="VisitCounter"></asp:Label>
</asp:Content>

