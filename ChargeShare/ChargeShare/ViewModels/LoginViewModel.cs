using ChargeShare.Models;
using ChargeShare.Services;
using ChargeShare.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChargeShare.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		public Command LoginCommand { get; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool Spinner { get; set; }
		public bool LoginVisible { get; set; }
		UserService userService;

		public LoginViewModel()
		{
			Spinner = false;
			LoginVisible = true;
			LoginCommand = new Command(OnLoginClicked);
			this.userService = new UserService();
		}

		private async void OnLoginClicked(object obj)
		{
			LoginVisible = false;
			Spinner = true;
			if(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				await App.Current.MainPage.DisplayAlert("Lege velden", "Voer eerst alle velden in voordat u inlogd", "Oke");
				Spinner = false;
				LoginVisible = true;
				return;
			}
			await Shell.Current.GoToAsync($"{nameof(LoadingPage)}", false);
			Console.WriteLine("Going to log in user");
			App.LoggedinUser = new User();
			User loginUser = await userService.UserLogin(Email);
			if(loginUser == null)
			{
				await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
				LoginVisible = true;
				Spinner = false;
				return;
			}
			App.LoggedinUser = loginUser;
			Console.WriteLine("LoggedinUserSet");
			Console.WriteLine("Email: " + App.LoggedinUser.Email);

			//TODO encrypt wachtwoord
			if (Password == App.LoggedinUser.Password)
			{
				await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
				LoginVisible = true;
				Spinner = false;
			}
			else
			{
				LoginVisible = true;
				Spinner = false;
				await App.Current.MainPage.DisplayAlert("Onjuist wachtwoord", "Het wachtwoord dat u heeft ingevoerd is onjuist", "Oke");
			}
		}
	}
}
 