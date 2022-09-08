using ChargeShare.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChargeShare.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		Location location;
		public HomePage()
		{
			InitializeComponent();
			this.BindingContext = new HomeViewModel();

			Task.Run(async () => {
				await getLocationUserAsync();
			}).Wait();
			
		}

		public async Task getLocationUserAsync()
		{
			var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(2));
			var cts = new CancellationTokenSource();
			location = Geolocation.GetLocationAsync(request, cts.Token).Result;
			if(location == null)
			{
				location = Geolocation.GetLastKnownLocationAsync().Result;
			}
			Xamarin.Forms.Maps.Position position = new Xamarin.Forms.Maps.Position(location.Latitude, location.Longitude);
			Xamarin.Forms.Maps.MapSpan mapSpan = Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(position, Xamarin.Forms.Maps.Distance.FromKilometers(0.444));
			GoogleMaps.MoveToRegion(mapSpan);
			return;
		}

		public void onSwipe(object sender, EventArgs args){
			Console.WriteLine("Swiper no swiping");
		}

	}
}