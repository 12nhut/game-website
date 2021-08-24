<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Cart.aspx.vb" Inherits="_Default" Theme="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 285px;
        }
        .style4
        {
            width: 86px;
            height: 71px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2">
        <tr>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="My Cart" SkinID="OrderTitle"></asp:Label>
            </td>
            <td>
                <img alt="Cart" class="style4" src="Images/Cart.jpg" /></td>
        </tr>
        <tr>
            <td class="style3">
                <asp:ListBox ID="OrdersListBox" runat="server" Height="139px" Width="334px" 
                    ViewStateMode="Enabled" SelectionMode="Multiple">
                </asp:ListBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ListBoxRequiredFieldValidator" runat="server" 
                    ControlToValidate="OrdersListBox" Display="Dynamic" 
                    ErrorMessage="No game has been add to cart" ForeColor="Red">*</asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="RemoveButton" runat="server" Text="Remove Game" Width="113px" />
                <br />
                <br />
                <asp:Button ID="EmptyAllButton" runat="server" style="margin-left: 0px" 
                    Text="Empty All" Width="113px" CausesValidation="False" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;<asp:Button ID="ContinueShoppingButton" runat="server" Text="Continue Shopping" 
                    Width="142px" CausesValidation="False" />
                &nbsp;&nbsp;<asp:Button ID="CheckOutButton" runat="server" Text="Check Out" />
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" 
                    HeaderText="Please correct the following error" Height="109px" Width="336px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

