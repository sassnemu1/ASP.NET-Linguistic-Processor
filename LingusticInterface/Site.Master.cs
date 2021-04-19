using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace LingusticInterface
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Auth auth = new Auth();
			UserInformation user = new UserInformation();

			//textSuccess.Visible = false;
			//textDanger.Visible = false;

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
			CloseButton.PostBackUrl = "~/";
			Auth auth = new Auth();
			auth.AuthToken = false;

			AuthCloseButtonNavigation.Visible = false;
			MainContent.Visible = true;
			ProfileContent.Visible = false;
		}

		protected void LinguisticProcessButtonStart_Click(object sender, EventArgs e)
		{
			string text = LinguisticText.Value;

			LinguisticProcess process = new LinguisticProcess();

			if (text == "")
			{
				textSuccess.Visible = false;
				textDanger.Visible = true;
				textDanger.InnerText = "Не введен текст !";
			}
			else 
			{
				textDanger.Visible = false;
				textSuccess.Visible = true;
				textSuccess.InnerText = "Текст обработан";

				process.LinguisticProcessTextRender(text);
				foreach (string s in process.wordListParseOfPredlog)
					LinguisticTextResult.Value = s;
			}
		}

		protected void SaveTextResult_Click(object sender, EventArgs e)
		{
			GetConnectBase connect = new GetConnectBase();
			UserInformation user = new UserInformation();

			string title = TitleTextInput.Value;
			string result = LinguisticTextResult.Value;

			if (result != "")
			{
				textDanger.Visible = false;
				textSuccess.Visible = true;
				textSuccess.InnerText = "Текст сохранен !";

				string connectURL = connect.ConnectURL;
				string registrQuery = connect.GetSaveResultTextQuery();

				SqlConnection myConnection = new SqlConnection(connectURL);
				myConnection.Open();

				using (SqlCommand command = new SqlCommand(registrQuery, myConnection))
				{
					command.Parameters.AddWithValue("@title", title);
					command.Parameters.AddWithValue("@text", result);
					command.Parameters.AddWithValue("@userid", user.Id);

					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
			}
			else 
			{
				textSuccess.Visible = false;
				textDanger.Visible = true;
				textDanger.InnerText = "Не введен текст !";
			}
		}
	}
}