<%@ Page Title="Регистрация" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LingusticInterface.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2><%: Title %></h2>
	<br />

	<!-- Форма регистрации -->
	<div class="form-group">
		<label for="inputEmailRegister">Email</label>
		<input 
			runat="server" 
			type="email" 
			class="form-control" 
			id="inputEmailRegister" 
			placeholder="name@example.com"
		>
	</div>

	<div class="form-group">
		<label for="inputLoginRegistr">Введите логин аккаунта</label>
		<input 
			runat="server" 
			type="text" 
			class="form-control" 
			id="inputLoginRegistr" 
			placeholder="Login"
		>
	</div>
	<br />
	<div class="form-group">
		<label for="inputPasswordRegistr">Введите пароль</label>
		<input 
			runat="server" 
			type="password" 
			class="form-control" 
			id="inputPasswordRegistr" 
			placeholder="Password"
		>
	</div>

	<div class="form-group">
		<label for="inputRepeatPasswordRegistr">Поторите пароль</label>
		<input 
			runat="server" 
			type="password" 
			class="form-control" 
			id="inputRepeatPasswordRegistr"
			placeholder="Repeat password"
		>
	</div>

	<!-- Кнопка регистрации -->
	<button 
		runat="server" 
		id="buttonRegistr" 
		type="submit" 
		class="btn btn-danger btn-lg"
	>
		Регистрация
	</button>

</asp:Content>
