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
	public partial class Register : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void buttonRegistr_Click(object sender, EventArgs e)
		{
			CheckErrorOnFormData cheackFormOnError = new CheckErrorOnFormData();
			GetConnectBase connect = new GetConnectBase();

			bool isRegisteration = cheackFormOnError.isTrueRegister;
			string password = inputPasswordRegistr.Value;
			string password_repeat = inputRepeatPasswordRegistr.Value;
			string name = inputNameRegistr.Value;
			string connectURL = connect.ConnectURL;

			SqlConnection myConnection = new SqlConnection(connectURL);
			myConnection.Open();

			cheackFormOnError.ToCheckFormRegistrationOnError
			(
				inputEmailRegister.Value, 
				inputLoginRegister.Value, 
				name,
				password, 
				password_repeat, 
				messageErrorRegister,
				messageSuccessRegister
			);

			if (isRegisteration == true) 
			{
				string registrQuery = connect.GetRegistrQuery();

				using (SqlCommand comand = new SqlCommand(registrQuery, myConnection))
				{
					comand.Parameters.AddWithValue("@email", inputEmailRegister.Value);
					comand.Parameters.AddWithValue("@login", inputLoginRegister.Value);
					comand.Parameters.AddWithValue("@password", password);
					comand.Parameters.AddWithValue("@name", name);

					comand.CommandType = CommandType.Text;
					comand.ExecuteNonQuery();
				}
			}

		}

	}
}
 