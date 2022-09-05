using ChargeShare.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChargeShare.ViewModels
{
	public class RegistrationViewModel : BaseViewModel
	{
		public User registeringUser { get; set; }
		public string PasswordRepeat { get; set; }


		public RegistrationViewModel()
		{
			registeringUser = new User();
		}

		public ICommand RegisterUserCommand => new Command(RegisterUser);

		public async void RegisterUser()
		{
			if (registeringUser == null)
			{
				return;
			}
			//Check of alles is ingevuld
			//Check of wachtwoorden gelijk zijn -> vervolgens encrypten
			//Check of email al bestaat
			//Check adress met api call
			//Check leeftijd
			//Store registeringUser in database
			try 
			{
				await App.Database.SaveUserToDatabase(registeringUser);
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			//Redirect naar homepage
			await Shell.Current.GoToAsync("//HomePage");
		}

	}
}
