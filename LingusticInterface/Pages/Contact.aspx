<%@ Page Title="Контакты" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="LingusticInterface.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>

    <address>
        Николай Бойко ( ИСП-18-3 )
        <br />
        <abbr title="Phone">P:</abbr>
        +7 (980) 374 31 71
    </address>

    <address>
        <strong>Email:</strong>   
            <a href="https://mail.google.com">qwert.saha.pm@gmail.com</a>
        <br />
        <strong>GitHub</strong> 
            <a href="https://github.com/sassnemu1">sassnemu1</a>
    </address>

</asp:Content>
