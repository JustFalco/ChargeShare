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
	public partial class RegistrationPage : ContentPage
	{
		public RegistrationPage()
		{
			InitializeComponent();
			PersonalBoxes.IsVisible = true;
			PasswordBoxes.IsVisible = false;
			AdresBoxes.IsVisible = false;
		}

		private void DisplayAdressBoxes(object sender, EventArgs args)
		{
			PersonalBoxes.IsVisible = false;
			PasswordBoxes.IsVisible = false;
			AdresBoxes.IsVisible = true;
		}

		private void DisplayPasswordBoxes(object sender, EventArgs args)
		{
			PersonalBoxes.IsVisible = false;
			PasswordBoxes.IsVisible = true;
			AdresBoxes.IsVisible = false;
		}
	}

}