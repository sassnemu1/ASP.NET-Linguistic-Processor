<%@ Page Title="Лингвистический процессор" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LingusticInterface._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><%: Title %></h1>
        <p class="lead">
            Войдите или зарегистрируйтесь в системе для того что бы начать работу с "Лингвистическим процессором"
        </p>

        <div class="btn-toolbar" role="toolbar">
            <div class="btn-group mr-2" role="group">
                <a runat="server" href="~/Pages/Account/Register" class="btn btn-danger btn-lg">Регистрация &raquo;</a>
            </div>
            <div class="btn-group mr-2" role="group">
                <a runat="server" href="~/Pages/Account/SignIn" class="btn btn-info btn-lg">Вход &raquo;</a>
            </div>
        </div>
    </div>

    <div class="row">
        <!--
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p></p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p></p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p></p>
        </div>
        -->
    </div>

</asp:Content>
