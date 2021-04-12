using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public partial class UserProfile : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			UserInformation user = new UserInformation();

			userName.InnerText = user.Name;
			userLogin.InnerText = user.Login;
			userEmail.InnerText = user.Email;
		}
	}
}