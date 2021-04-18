<%@ Page Title="Вход в систему." Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="LingusticInterface.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2><%: Title %></h2>
    <br />

	<div class="form-group">
        <label for="inputLoginSignIn">Логин аккаунта</label>
        <input 
            runat="server" 
            type="text" 
            class="form-control" 
            id="inputLoginSignIn" 
            placeholder="Введите ваш логин"
        />
    </div>
    <div class="form-group">
        <label for="inputPasswordSignIn">Пароль</label>
        <input 
            runat="server" 
            type="password" 
            class="form-control" 
            id="inputPasswordSignIn" 
            placeholder="Введите пароль"
        />
    </div>

    <asp:Button 
        runat="server" 
        ID="buttonSignIn" 
		CssClass="btn btn-info btn-lg" 
		Text="Вход"
        OnClick="buttonSignIn_Click"
    />

    <asp:TextBox runat="server" ID="messageErrorSignIn" Visible="false" CssClass="alert alert-danger" />
	<asp:TextBox runat="server" ID="messageSuccessSignIn" Visible="false" CssClass="alert alert-success" />

</asp:Content>
