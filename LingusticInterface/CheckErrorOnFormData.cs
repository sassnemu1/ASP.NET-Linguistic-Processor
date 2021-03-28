using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LingusticInterface
{
	public class CheckErrorOnFormData
	{
		RegistrationToken registr = new RegistrationToken();

		public bool isTrueRegister = false;
		public bool isTrueSignIn = false;
		public bool isAuth = false;
		public void ToCheckFormRegistrationOnError
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
				messageErrorRegister.Visible = false;
				messageSuccessRegister.Visible = true;
				messageSuccessRegister.Text = "Все данные введены корректно.";

				isTrueRegister = true;
				registr.TokenReg = isTrueRegister;
			}
		}

		public void ToCheckFormSignInOnError
		(
			string login, 
			string password, 
			TextBox messageErrorSignIn, 
			TextBox messageSuccessSignIn
		) 
		{
			if (login == "")
			{
				messageSuccessSignIn.Visible = false;
				messageErrorSignIn.Visible = true;
				messageErrorSignIn.Text = "Не введен Логин";
			}
			else if (password == "")
			{
				messageSuccessSignIn.Visible = false;
				messageErrorSignIn.Visible = true;
				messageErrorSignIn.Text = "Не введен Пароль";
			}
			else 
			{
				isTrueSignIn = true;
				messageErrorSignIn.Visible = false;
				messageSuccessSignIn.Visible = true;
				messageSuccessSignIn.Text = "Все данные введены корректно.";
			}
		}

		public bool ToCheckDataSignInOnDataBases
		(
			string login, 
			string password, 
			string loginDataBases, 
			string passwordDataBases,
			TextBox messageErrorSignIn,
			TextBox messageSuccessSignIn
		) 
		{
			if (login == loginDataBases && password == passwordDataBases)
			{
				isAuth = true;
				messageErrorSignIn.Visible = false;
				messageSuccessSignIn.Visible = true;
				messageSuccessSignIn.Text = "Вход совершен";
			}
			else 
			{
				isAuth = false;
				messageSuccessSignIn.Visible = false;
				messageErrorSignIn.Visible = true;
				messageErrorSignIn.Text = "Логин или пароль введены не корректно, попробуйте снова !";
			}

			return isAuth;
		}
	}
}
