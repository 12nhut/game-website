<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="System.aspx.vb" Inherits="_Default" Theme="Systems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 501px;
        }
        .style5
        {
            width: 285px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table ID="table">
        <tr>
            <td class="SystemStyle">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="PlayStation 3" SkinID="SystemName"></asp:Label>
&nbsp;<br />
                <asp:ImageButton ID="PS3ImageButton" runat="server" Height="277px" 
                    ImageUrl="~/Images/PS3.jpg" Width="325px" />
            </td>
            <td class="ViewGameStyle">
                <asp:LinkButton ID="PS3LinkButton" runat="server">View Games</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="SystemStyle">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Wii" SkinID="SystemName"></asp:Label>
                <br />
                <asp:ImageButton ID="WiiImageButton" runat="server" Height="277px" 
                    ImageUrl="~/Images/Wii.jpg" Width="326px" />
            </td>
            <td class="ViewGameStyle">
                <asp:LinkButton ID="WiiLinkButton" runat="server">View Games</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="SystemStyle">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="XBOX 360" SkinID="SystemName"></asp:Label>
                <br />
                <asp:ImageButton ID="XBOX360ImageButton" runat="server" Height="277px" 
                    ImageUrl="~/Images/XBOX360.gif" Width="322px" />
            </td>
            <td class="ViewGameStyle">
                <asp:LinkButton ID="XBOX360LinkButton" runat="server" 
                    PostBackUrl="~/XBOX360.aspx">View Games</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="SystemStyle">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="PlayStation Portable" 
                    SkinID="SystemName"></asp:Label>
                <br />
                <asp:ImageButton ID="PSPImageButton" runat="server" Height="168px" 
                    ImageUrl="~/Images/PSP.png" Width="252px" />
            </td>
            <td class="ViewGameStyle">
                <asp:LinkButton ID="PSPLinkButton" runat="server">View Games</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="SystemStyle">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Nintendo 3DS" SkinID="SystemName"></asp:Label>
                <br />
                <asp:ImageButton ID="N3DSImageButton" runat="server" Height="221px" 
                    ImageUrl="~/Images/3DS.jpg" Width="287px" />
                <br />
                </td>
            <td class="ViewGameStyle">
                <asp:LinkButton ID="N3DSLinkButton" runat="server">View Games</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>

