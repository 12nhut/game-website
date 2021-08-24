<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Checkout.aspx.vb" Inherits="_Default" Theme="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 50px;
        }
        .style5
        {
            width: 125px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2" style="width: 490px">
        <tr>
            <td class="style5">
                <asp:Label ID="Label4" runat="server" Text="Check Out" SkinID="OrderTitle"></asp:Label>
            </td>
            <td>
                <img alt="Check Out Cart" class="style4" src="Images/Check%20Out%20Cart.gif" /></td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label1" runat="server" Text="First name:" 
                    SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="FirstNameTextBox" runat="server" Width="343px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" 
                    ControlToValidate="FirstNameTextBox" Display="Dynamic" 
                    ErrorMessage="First name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label2" runat="server" Text="Last name:" 
                    SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="LastNameTextBox" runat="server" Width="343px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" 
                    ControlToValidate="LastNameTextBox" Display="Dynamic" 
                    ErrorMessage="Last name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label3" runat="server" Text="Email:" SkinID="CustomerInfoTitle"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" Width="343px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" 
                    ControlToValidate="EmailTextBox" Display="Dynamic" 
                    ErrorMessage="Email is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" 
                    runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" 
                    ErrorMessage="Please enter a valid email address" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="ConfirmButton" runat="server" Text="Confirm" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ClearButton" runat="server" Text="Clear" 
        CausesValidation="False" />
    &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="CancelButton" runat="server" 
        Text="Cancel Order" CausesValidation="False" />
    &nbsp;<asp:ValidationSummary ID="ValidationSummary" runat="server" 
        ForeColor="Red" HeaderText="Please correct the following error" />
    &nbsp; 
</asp:Content>

