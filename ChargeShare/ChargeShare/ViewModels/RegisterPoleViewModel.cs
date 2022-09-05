using ChargeShare.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChargeShare.ViewModels
{
	public class RegisterPoleViewModel : BaseViewModel
	{
		public ChargeStation ChargeStation { get; set; }

		public Command SubmitChargeStation { get; }

		public RegisterPoleViewModel()
		{
			ChargeStation = new ChargeStation();
			SubmitChargeStation = new Command(RegisterChargeStation);
		}

		public async void RegisterChargeStation()
		{
			Console.WriteLine("Submitting!");
			await App.Database.SaveChargeStationToDatabase(this.ChargeStation);
			Console.WriteLine("Submitted?");
			ChargeStation = new ChargeStation();
		}
	}
}
