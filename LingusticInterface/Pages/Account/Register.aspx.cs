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
			RegistrationToken registrToken = new RegistrationToken();
			CheckErrorOnFormData cheackFormOnError = new CheckErrorOnFormData();
			GetConnectBase connect = new GetConnectBase();

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

			if (registrToken.TokenReg) 
			{
				string registrQuery = connect.GetRegistrQuery();

				using (SqlCommand command = new SqlCommand(registrQuery, myConnection))
				{
					command.Parameters.AddWithValue("@login", inputLoginRegister.Value);
					command.Parameters.AddWithValue("@email", inputEmailRegister.Value);
					command.Parameters.AddWithValue("@password", password);
					command.Parameters.AddWithValue("@name", name);

					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}

				Response.Redirect("/Pages/Account/SignIn.aspx");
			}

		}

	}
}
 