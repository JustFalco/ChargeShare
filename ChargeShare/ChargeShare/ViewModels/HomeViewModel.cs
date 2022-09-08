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
		public string Name { get; set; }
		public bool ButtonEnabled { get; set; }
		public Command RegisterPoleCommand { get; }
		public Command ViewChargersCommand { get; }
		public Command ViewReservationsCommand { get; }
		public HomeViewModel()
		{
			RegisterPoleCommand = new Command(RegisterPole);
			ViewChargersCommand = new Command(ViewChargersPage);
			ViewReservationsCommand = new Command(ViewReservationsPage);
			this.ButtonEnabled = true;
			Console.WriteLine("User: " + App.LoggedinUser.FirstName);
			this.Name=App.LoggedinUser.FirstName;
		}

		private async void RegisterPole()
		{
			this.ButtonEnabled = false;
			if (IsBusy)
			{
				return;
			}
			IsBusy = true;
			
			await Shell.Current.GoToAsync($"{nameof(RegisterPolePage)}");
			this.ButtonEnabled = true;
			IsBusy = false;
		}

		private async void ViewReservationsPage()
		{
			this.ButtonEnabled = false;
			if (IsBusy)
			{
				return;
			}
			IsBusy = true;

			await Shell.Current.GoToAsync($"{nameof(ReservationsPage)}");
			this.ButtonEnabled = true;
			IsBusy = false;
		}

		private async void ViewChargersPage()
		{
			this.ButtonEnabled = false;
			if (IsBusy)
			{
				return;
			}
			IsBusy = true;
			await Shell.Current.GoToAsync($"{nameof(LocalChargingStationsView)}");
			this.ButtonEnabled = true;
			IsBusy = false;
		}

	}
}
