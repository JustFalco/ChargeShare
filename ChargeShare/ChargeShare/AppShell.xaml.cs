using ChargeShare.ViewModels;
using ChargeShare.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChargeShare
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
			Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
			Routing.RegisterRoute(nameof(RegisterPolePage), typeof(RegisterPolePage));
			Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
			Routing.RegisterRoute(nameof(LocalChargingStationsView), typeof(LocalChargingStationsView));
			Routing.RegisterRoute(nameof(AccountPage), typeof(AccountPage));
			Routing.RegisterRoute(nameof(ReservationsPage), typeof(ReservationsPage));
			Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
