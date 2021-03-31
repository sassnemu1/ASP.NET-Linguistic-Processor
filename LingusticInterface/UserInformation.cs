using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class UserInformation
	{
		static string name;
		static string login;
		static string password;
		static string email;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Login
		{
			get { return login; }
			set { login = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public string Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}