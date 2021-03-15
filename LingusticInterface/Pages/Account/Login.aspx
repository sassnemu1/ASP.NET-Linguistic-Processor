<%@ Page Title="Вход в систему." Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LingusticInterface.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2><%: Title %></h2>
    <br />

	<div class="form-group">
        <label for="inputLogin1">Логин аккаунта</label>
        <input 
            runat="server" 
            type="text" 
            class="form-control" 
            id="inputLogin1" 
            placeholder="Login"
        >
        <small id="emailHelp" class="form-text text-muted">Введите ваш логин</small>
    </div>
    <div class="form-group">
        <label for="inputPassword1">Пароль</label>
        <input 
            runat="server" 
            type="password" 
            class="form-control" 
            id="inputPassword1" 
            placeholder="Password"
        >
        <small id="passwordHelp" class="form-text text-muted">Введите пароль</small>
    </div>
      
    <button 
        runat="server" 
        id="buttonLogin" 
        type="submit" 
        class="btn btn-info btn-lg"
    >
        Войти
    </button>

</asp:Content>
