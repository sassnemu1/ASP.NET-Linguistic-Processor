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
	}
}