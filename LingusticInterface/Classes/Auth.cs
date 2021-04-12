using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class Auth
	{
		static bool auth;
		public bool AuthToken
		{
			get
			{
				if (auth)
				{
					return auth;
				}
				else
				{
					return false;
				}
			}
			set
			{
				auth = value;
			}
		}
	}
}