using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public class CheckFormRegistration
	{
		public bool isTrueRegister = false;
		public void toCheckFormRegistrationOnError
		(
			string email,
			string login,
			string name,
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
				messageErrorRegister.Text = "Не введен Пароль";
			}
			else if (email == "")
			{
				messageErrorRegister.Visible = true;
				messageErrorRegister.Text = "Не введен Email";
			}
			else if (login == "")
			{
				messageErrorRegister.Visible = true;
				messageErrorRegister.Text = "Не введен Логин";
			}
			else if (name == "") 
			{
				messageErrorRegister.Visible = true;
				messageErrorRegister.Text = "Не введено Имя";
			}
			else
			{
				isTrueRegister = true;
				messageErrorRegister.Visible = false;
				messageSuccessRegister.Visible = true;
				messageSuccessRegister.Text = "Все данные введены корректно.";
			}
		}
	}
}