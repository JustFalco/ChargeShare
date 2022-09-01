using ChargeShare.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChargeShare.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocalChargingStationsView : ContentPage
	{
		public LocalChargingStationsView()
		{
			InitializeComponent();
			this.BindingContext = new LocalChargingViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await (BindingContext as LocalChargingViewModel).getChargingStationsAsync();
		}
	}
}