using ChargeShare.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChargeShare.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		Task<Location> location;
		public HomePage()
		{
			InitializeComponent();
			this.BindingContext = new HomeViewModel();

			Task.Run(async () => {
				Device.BeginInvokeOnMainThread(() =>
				{
					getLocationUserAsync();
				});
					});

			
		}

		public async void getLocationUserAsync()
		{
			location = Geolocation.GetLocationAsync();
			Xamarin.Forms.Maps.Position position = new Xamarin.Forms.Maps.Position(location.Result.Latitude, location.Result.Longitude);
			Xamarin.Forms.Maps.MapSpan mapSpan = Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(position, Xamarin.Forms.Maps.Distance.FromKilometers(0.444));
			GoogleMaps.MoveToRegion(mapSpan);
		}

		public void onSwipe(object sender, EventArgs args){
			Console.WriteLine("Swiper no swiping");
		}

	}
}