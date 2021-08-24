<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Help.aspx.vb" Inherits="_Default" Theme="Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p><img alt="Help" class="style2" src="Images/Help.jpg" /></p>
    <p>If you need help on using our web site such as purchasing our products or have any questions 
        or comments regarding our company. This is the place that provide services that 
        answer your questions and solve your problems.</p>
    <p>Please be sure to check out the frequently asked questions web page on the link 
        below and find the right resources that might answers your questions. If our 
        frequently asked questions section still can&#39;t asnwers your questions, you can 
        contact our company via the contact us page on the link below, we will try our 
        best to provide asnwers and feedback to you as soon as possible.</p>
    <p><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FAQs.aspx" SkinID="HelpLink"> FAQs</asp:HyperLink>
        : The list of questions that commonly asked by customers on using our web site 
        and provided answers.</p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Contact.aspx" 
            SkinID="HelpLink">Contact Us.</asp:HyperLink>
        : Contact information of our company to provide additional resources and help to 
        customers.</p>

</asp:Content>

