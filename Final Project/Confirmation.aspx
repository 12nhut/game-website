<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Confirmation.aspx.vb" Inherits="_Default" Theme="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 137px;
        }
        .style4
        {
            width: 36px;
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2">
        <tr>
            <td class="style3">
                <asp:Label ID="Label8" runat="server" Text="Confirmation" SkinID="OrderTitle"></asp:Label>
            </td>
            <td>
                <img alt="Confirmation" class="style4" src="Images/Confirmation.gif" /></td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="Orders:" SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:ListBox ID="OrdersListBox" runat="server" Height="98px" Width="204px">
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label2" runat="server" Text="First name:" 
                    SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:Label ID="FirstNameLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label3" runat="server" Text="Last name:" 
                    SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LastNameLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label7" runat="server" Text="Email:" SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:Label ID="EmailLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
                <asp:Label ID="ThankYouLabel" runat="server" SkinID="Message"></asp:Label>
            <br />
    <br />
                <asp:Button ID="ConfirmOrderButton" runat="server" Text="Confirm Order" />
&nbsp;&nbsp;<asp:Button ID="CancelOrderButton" runat="server" Text="Cancel Order" />
&nbsp;&nbsp;
    <asp:Button ID="ModifyButton" runat="server" Text="Modify Cart" />
&nbsp;&nbsp;<asp:Button ID="ContinueShoppingButton" runat="server" 
                    Text="Continue Shopping" />
            </asp:Content>

