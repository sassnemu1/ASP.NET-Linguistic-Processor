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
	public partial class UserProfile : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			UserInformation user = new UserInformation();
			GetConnectBase connect = new GetConnectBase();

			userName.InnerText = user.Name;
			userLogin.InnerText = user.Login;
			userEmail.InnerText = user.Email;

			string user_id = user.Id;

			string connectURL = connect.ConnectURL;
			string textListQuery = connect.GetTextListQuery();

			SqlConnection myConnection = new SqlConnection(connectURL);
			myConnection.Open();

			SqlCommand command = new SqlCommand(textListQuery, myConnection);
			SqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[4]);
				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
			}

			foreach (string[] s in data)
			{
				string id = s[0];
				string title = s[1];
				string text = s[2];
				string id_user_text = s[3];

				string li =
					"<li>" +
						"<button id='buttonTitleTextUserProfile' class='btn btn-primary' type='button' data-toggle='collapse' data-target='#collapse" + id + "' aria-expanded='false aria-controls='collapseExample'>" +
							title +
						"</button>" +
						"<div class='collapse' id='collapse" + id + "'>" +
							"<div class='card card-body'>" +
								text +
							"</div>" +
						"</div>" +
					"</li>";

				if (user_id == id_user_text)
					ListAllTextsOfUser.InnerHtml += li;
			}
		}
	}
}