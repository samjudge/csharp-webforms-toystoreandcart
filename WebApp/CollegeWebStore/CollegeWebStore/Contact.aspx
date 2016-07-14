<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CollegeWebStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact us on:</h3>
    <address>
        21 Fantasy Boulvard<br />
        Some Kind Of Reference Way<br />
        Gatehead<br />
        NE2 6DB<br />
        <abbr title="Phone">P:</abbr>
        0800-001066
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@VIKSolutions.co.uk</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@VIKSolutions.co.uk</a>
    </address>
</asp:Content>
