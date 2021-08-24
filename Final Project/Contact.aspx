<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Contact.aspx.vb" Inherits="_Default" Theme="Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3><img alt="Contact Us" class="style4" src="Images/Contact%20Us.jpg" /></h3>
    <h3>If you have any other questions or comments regarding our company, <br />
    please feel free to contact us via:</h3>
    <table ID="ContactTable">
        <tr>
            <td class="Contact">
                <asp:Label ID="Label1" runat="server" Text="Phone:" SkinID="ContactChoice"></asp:Label>
            </td>
            <td class="ContactInfo">
                1-800-123-4567<br />
                Weeksday 8am-5pm Pacific Time</td>
        </tr>
        <tr>
            <td class="Contact">
                <asp:Label ID="Label2" runat="server" Text="Email:" SkinID="ContactChoice"></asp:Label>
            </td>
            <td class="ContactInfo">
                <a href="mailto:nhuan@hawaii.edu">nhuan@hawaii.edu</a></td>
        </tr>
        <tr>
            <td class="Contact">
                <asp:Label ID="Label3" runat="server" Text="Headquarters Address:" 
                    SkinID="ContactChoice"></asp:Label>
            </td>
            <td class="ContactInfo">
                Kapiolani Community College<br />
                4303 Diamond Head Road<br />
                Honolulu, HI 96816-4421</td>
        </tr>
        </table>
</asp:Content>


