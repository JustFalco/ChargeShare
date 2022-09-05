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

		UserService userService;

		public LoginViewModel()
		{
			LoginCommand = new Command(OnLoginClicked);
			this.userService = new UserService();
		}

		private async void OnLoginClicked(object obj)
		{
			if(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				return;
			}

			Console.WriteLine("Going to log in user");
			LoggedinUser = new User();
			LoggedinUser = await userService.UserLogin(Email);
			Console.WriteLine("LoggedinUserSet");
			Console.WriteLine("Email: " + LoggedinUser.Email);

			//TODO encrypt wachtwoord
			if (Password == LoggedinUser.Password)
			{
				await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
			}
			else
			{
				await App.Current.MainPage.DisplayAlert("Whoop er ging iets fout", "helemaal kut", "ok");
			}
		}
	}
}
