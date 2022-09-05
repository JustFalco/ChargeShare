using ChargeShare.Models;
using ChargeShare.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChargeShare.Services
{
	internal class UserService
	{
		User User { get; set; }
		public async Task<User> UserLogin(string Email)
		{
			Console.WriteLine("In userlogin service");
			User = await App.Database.GetUserByEmail(Email);
			if(User == null)
			{
				await App.Current.MainPage.DisplayAlert("Gebruiker niet gevonden", "Gebruiker met email " + Email + " bestaat niet", "Oke");
				return null;
			}

			return User;
		}
	}
}
