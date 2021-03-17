using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LingusticInterface
{
	public partial class Register : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void buttonRegistr_Click(object sender, EventArgs e)
		{
			string password = inputPasswordRegistr.Value;
			string password_repeat = inputRepeatPasswordRegistr.Value;

			CheckFormRegistration cheackFormOnError = new CheckFormRegistration();

			cheackFormOnError.toCheckFormRegistrationOnError
			(
				inputEmailRegister.Value, 
				inputLoginRegister.Value, 
				password, 
				password_repeat, 
				messageErrorRegister,
				messageSuccessRegister
			);

			
		}
	}
}
 
public class CheckFormRegistration
{
	public void toCheckFormRegistrationOnError
	(
		string email, 
		string login, 
		string password, 
		string password_repeat, 
		TextBox messageErrorRegister, 
		TextBox messageSuccessRegister
	) 
	{
		if (password != password_repeat)
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Пароль не совпал";
		}
		else if (password == "" || password_repeat == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен пароль";
		}
		else if (email == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен email";
		}
		else if (login == "")
		{
			messageErrorRegister.Visible = true;
			messageErrorRegister.Text = "Не введен логин";
		}
		else 
		{
			messageErrorRegister.Visible = false;
			messageSuccessRegister.Visible = true;
			messageSuccessRegister.Text = "Все данные введены корректно.";
		}	
	}
}