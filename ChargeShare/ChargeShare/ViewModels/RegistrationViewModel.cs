using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChargeShare.ViewModels
{
	public class RegistrationViewModel
	{
		public Command goBackToHomeCommand { get; }

		public RegistrationViewModel()
		{
			this.goBackToHomeCommand = new Command(GoBackToHome);
		}

		public async void GoBackToHome()
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}

	}
}
