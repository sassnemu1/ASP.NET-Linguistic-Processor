<%@ Page Title="Регистрация" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LingusticInterface.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2><%: Title %></h2>
	<br />

	<!-- Форма регистрации -->
	<div class="form-group">
		<label for="inputNameRegistr">Имя</label>
		<input 
			runat="server" 
			id="inputNameRegistr" 
			type="text" 
			class="form-control" 
			placeholder="Имя"
		>
	</div>

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
			placeholder="Логин"
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
			placeholder="Пароль"
		>
	</div>

	<div class="form-group">
		<input 
			runat="server" 
			id="inputRepeatPasswordRegistr"
			type="password" 
			class="form-control" 
			placeholder="Повторите пароль"
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

	<!-- Сообщения --> 
	<asp:TextBox runat="server" ID="messageErrorRegister" Visible="false" CssClass="alert alert-danger" />
	<asp:TextBox runat="server" ID="messageSuccessRegister" Visible="false" CssClass="alert alert-success" Width="250" />

</asp:Content>
