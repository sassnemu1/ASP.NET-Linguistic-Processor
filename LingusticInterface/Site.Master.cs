using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			CheckErrorOnFormData cheack = new CheckErrorOnFormData();
			if (cheack.isTrueSignIn == false) 
			{
				ProfileContent.Visible = false;
			}
		}
	}
}