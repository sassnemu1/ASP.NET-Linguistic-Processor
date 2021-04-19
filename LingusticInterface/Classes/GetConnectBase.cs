using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class GetConnectBase
	{
		//Data Base URL address 
		public string ConnectURL = "Data Source=tcp:lingusticbase.database.windows.net,1433;Initial Catalog=LingusticBase;Persist Security Info=False;User ID=adminbd@qwertsahapmgmail.onmicrosoft.com;Password=1379248650Qaz;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication='Active Directory Password'";

		//Registr Query
		public string GetRegistrQuery() 
		{
			return "INSERT INTO [User] (Login, Email, Password, Name) VALUES (@login, @email, @password, @name)";
		}

		//SignIn Query
		public string GetSignInQuery()
		{
			return "SELECT * FROM [User] ORDER BY Id";
		}
		//public string GetSignInQuery2()
		//{
		//	return "SELECT * FROM [User] WHERE Login = @login AND Password = @password";
		//}
		public string GetTextListQuery() 
		{
			return "SELECT * FROM [Text] ORDER BY UserId";
		}
		public string GetSaveResultTextQuery()
		{
			return "INSERT INTO [Text] (Title, Text, UserId) VALUES (@title, @text, @userid)";
		}
	}
}