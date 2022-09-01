using ChargeShare.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChargeShare.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		public Command RegisterPoleCommand { get; }
		public Command ViewChargersCommand { get; }
		public HomeViewModel()
		{
			RegisterPoleCommand = new Command(RegisterPole);
			ViewChargersCommand = new Command(ViewChargersPage);
		}

		private async void RegisterPole()
		{
			await Shell.Current.GoToAsync($"{nameof(RegisterPolePage)}");
		}
		private async void ViewChargersPage()
		{
			await Shell.Current.GoToAsync($"{nameof(LocalChargingStationsView)}");
		}

	}
}
