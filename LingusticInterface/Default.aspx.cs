using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Auth auth = new Auth();

			if (auth.AuthToken)
			{
				UserNameHomePage.InnerText += "HOMIE";
				NotAuthTitleText.Visible = false;
				ButtonRegistrAndSignIn.Visible = false;
			}
			else 
			{
				UserNameHomePage.Visible = false;
			}
		}
	}
}