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
	public partial class Login : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void buttonSignIn_Click(object sender, EventArgs e)
		{
			CheckErrorOnFormData cheackFormOnError = new CheckErrorOnFormData();
			GetConnectBase connect = new GetConnectBase();

			bool isSignIn = cheackFormOnError.isTrueSignIn;
			string login = inputLoginSignIn.Value;
			string password = inputPasswordSignIn.Value;
			string connectURL = connect.ConnectURL;

			SqlConnection myConnection = new SqlConnection(connectURL);
			myConnection.Open();

			cheackFormOnError.ToCheckFormSignInOnError(login, password, messageErrorSignIn, messageSuccessSignIn);

			if (isSignIn != true) 
			{
				string signInQuery = connect.GetSignInQuery();

				SqlCommand command = new SqlCommand(signInQuery, myConnection);
				SqlDataReader reader = command.ExecuteReader();

				List<string[]> data = new List<string[]>();

				while (reader.Read())
				{
					data.Add(new string[5]);
					data[data.Count - 1][0] = reader[0].ToString();
					data[data.Count - 1][1] = reader[1].ToString();
					data[data.Count - 1][2] = reader[2].ToString();
					data[data.Count - 1][3] = reader[3].ToString();
					data[data.Count - 1][4] = reader[4].ToString();
				}

				foreach (string[] s in data)
				{
					cheackFormOnError.ToCheckDataSignInOnDataBases(login, password, s[1], s[3], messageErrorSignIn, messageSuccessSignIn);
				}
			}
		}
	}
}