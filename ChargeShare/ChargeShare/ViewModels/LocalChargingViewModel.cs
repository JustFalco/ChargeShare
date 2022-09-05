using ChargeShare.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ChargeShare.ViewModels
{
	public class LocalChargingViewModel : BaseViewModel
	{
		public ObservableCollection<ChargeStation> LocalChargeStations { get; set; }

		public LocalChargingViewModel()
		{
			LocalChargeStations = new ObservableCollection<ChargeStation>();
			
		}

		public async Task getChargingStationsAsync()
		{
			if (IsBusy)
			{
				return;
			}
			IsBusy = true;

			try
			{
				var chargers = await App.Database.GetAllChargeStations();

				foreach (var charger in chargers)
				{
					LocalChargeStations.Add(charger);
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}



			IsBusy = false;
		}
	}
}
