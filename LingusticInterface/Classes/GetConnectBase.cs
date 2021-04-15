using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class GetConnectBase
	{
		//Data Base URL address 
		public string ConnectURL = "Data Source=АДМИН\\SQLEXPRESS;Initial Catalog=LingusticBase;" +
								   "Integrated Security=true";

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