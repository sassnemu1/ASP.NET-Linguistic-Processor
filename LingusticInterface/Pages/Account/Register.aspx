<%@ Page Title="Регистрация" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LingusticInterface.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2><%: Title %></h2>
	<br />

	<!-- Форма регистрации -->
	<div class="form-group">
		<label for="inputEmailRegister">Email</label>
		<input 
			runat="server" 
			id="inputEmailRegister" 
			type="email" 
			class="form-control" 
			placeholder="name@example.com"
		>
	</div>

	<div class="form-group">
		<label for="inputLoginRegister">Введите логин аккаунта</label>
		<input 
			runat="server" 
			id="inputLoginRegister"
			type="text" 
			class="form-control"  
			placeholder="Login"
		>
	</div>
	<br />
	<div class="form-group">
		<label for="inputPasswordRegistr">Введите пароль</label>
		<input 
			runat="server" 
			id="inputPasswordRegistr"
			type="password" 
			class="form-control" 
			placeholder="Password"
		>
	</div>

	<div class="form-group">
		<label for="inputRepeatPasswordRegistr">Поторите пароль</label>
		<input 
			runat="server" 
			id="inputRepeatPasswordRegistr"
			type="password" 
			class="form-control" 
			placeholder="Repeat password"
		>
	</div>

	<!-- Кнопка регистрации -->
	<asp:Button 
		runat="server" 
		ID="buttonRegistr" 
		CssClass="btn btn-danger btn-lg" 
		Text="Регистрация" 
		OnClick="buttonRegistr_Click"
	/>

	<asp:TextBox runat="server" ID="messageErrorRegister" Visible="false" CssClass="alert alert-danger" />

</asp:Content>
