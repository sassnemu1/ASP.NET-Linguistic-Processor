<%@ Page Title="Профиль" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="LingusticInterface.UserProfile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ProfileContent" runat="server">

    <div class="row">
		<div class="col-md-4 card" style="width: 25rem;">
	      <div class="card-header">
            <h2><%: Title %></h2>
	      </div>
          <ul class="list-group list-group-flush">
            <li class="list-group-item">
                <h3 runat="server" id="userName"></h3>
            </li>
            <li class="list-group-item" >
                <small>Login:</small>
                <span runat="server" id="userLogin"></span>
            </li>
            <li class="list-group-item" >
                <small>Email:</small>
                <span runat="server" id="userEmail"></span>
            </li>
          </ul>
        </div>
        <div class="col-md-8">
            <h2>Hello !</h2>
        </div>
    </div>
	
	
</asp:Content>
