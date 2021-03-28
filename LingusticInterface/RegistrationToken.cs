using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LingusticInterface
{
	public class RegistrationToken
	{
		static bool registr;
		public bool TokenReg
		{
			get
			{
				if (registr)
				{
					return registr;
				}
				else
				{
					return false;
				}
			}
			set
			{
				registr = value;
			}
		}
	}
}