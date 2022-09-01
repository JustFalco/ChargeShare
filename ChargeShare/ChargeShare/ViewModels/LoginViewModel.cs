using ChargeShare.Models;
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

		public LoginViewModel()
		{
			LoginCommand = new Command(OnLoginClicked);
		}

		private async void OnLoginClicked(object obj)
		{
			if(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				return;
			}
			if(Email == "falco@wolkorte.nl" && Password == "falco")
			{
				await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
			}
		}
	}
}
