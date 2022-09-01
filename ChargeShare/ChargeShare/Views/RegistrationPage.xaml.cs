using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

		private void CheckPasswords(object sender, TextChangedEventArgs args)
		{
			if(PasswordEntry.Text != PasswordRepeatEntry.Text)
			{
				PasswordWarning.IsVisible = true;
			}
			else
			{
				PasswordWarning.IsVisible = false;
				RegisterButton.IsVisible = true;
			}
		}

		private void CheckPersonalEntryBoxes(object sender, EventArgs args)
		{
			bool FirstName = string.IsNullOrWhiteSpace(FirstNameEntry.Text);
			bool LastName = string.IsNullOrWhiteSpace(LastNameEntry.Text);
			bool Email = string.IsNullOrWhiteSpace(EmailEntry.Text);
			bool Phone = string.IsNullOrWhiteSpace(PhoneEntry.Text);

			if (FirstName)
			{
				FirstNameLabel.TextColor = Color.Red;
			}
			if (LastName)
			{
				LastNameLabel.TextColor = Color.Red;
			}
			if (Email)
			{
				EmailLabel.TextColor = Color.Red;
			}
			if (Phone)
			{
				PhoneLabel.TextColor = Color.Red;
			}
			if(!FirstName && !LastName && !Email && !Phone)
			{
				DisplayAdressBoxes(sender, args);
			}
		}

		private void CheckAdressBoxes(object sender, EventArgs args)
		{
			bool Street = string.IsNullOrWhiteSpace(StreetEntry.Text);
			bool City = string.IsNullOrWhiteSpace(CityEntry.Text);
			bool Postal = string.IsNullOrWhiteSpace(PostalEntry.Text);
			bool HouseNumber = string.IsNullOrWhiteSpace(HouseNumberEntry.Text);
			bool HouseAddition = string.IsNullOrWhiteSpace(HouseAdditionEntry.Text);

			if (Street)
			{
				StreetLabel.TextColor = Color.Red;
			}
			if (City)
			{
				CityLabel.TextColor = Color.Red;
			}
			if (Postal)
			{
				PostalLabel.TextColor = Color.Red;
			}
			if (HouseNumber)
			{
				HouseNumberLabel.TextColor = Color.Red;
			}
			if (HouseAddition)
			{
				HouseAdditionLabel.TextColor = Color.Red;
			}

			if(!Street && !City && !Postal && !HouseNumber && !HouseAddition)
			{
				DisplayPasswordBoxes(sender,args);
			}
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

		private void DisplayPersonalBoxes(object sender, EventArgs args)
		{
			PersonalBoxes.IsVisible = true;
			PasswordBoxes.IsVisible = false;
			AdresBoxes.IsVisible = false;
		}

		private async void BackToHome(object sender, EventArgs args)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}

		
		
	}

}