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
			Auth auth = new Auth();
			UserInformation user = new UserInformation();

			if (auth.AuthToken)
			{
				navUserLogin.InnerText = user.Login; 
				AuthCloseButtonNavigation.Visible = true;
				MainContent.Visible = false;
				ProfileContent.Visible = true;
			}
			else
			{
				AuthCloseButtonNavigation.Visible = false;

				MainContent.Visible = true;
				ProfileContent.Visible = false;
			}
		}

		protected void CloseButton_Click(object sender, EventArgs e)
		{
			Auth auth = new Auth();
			auth.AuthToken = false;
			CloseButton.PostBackUrl = "~/";
		}

		protected void LinguisticProcessButtonStart_Click(object sender, EventArgs e)
		{
			string text = LinguisticText.Value;

			LinguisticProcess process = new LinguisticProcess();
			process.LinguisticProcessTextRender(text);

			foreach (string s in process.wordListParseOfPredlog)
			{
				LinguisticTextResult.Value = s;
			}
					

		}
	}
}