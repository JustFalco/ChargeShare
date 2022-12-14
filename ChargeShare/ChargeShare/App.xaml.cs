using ChargeShare.Models;
using ChargeShare.Views;
using System;
using System.IO;
using WeekMCCapp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChargeShare
{
	public partial class App : Application
	{
		private static User loggedinUser;

		public static User LoggedinUser
		{
			get
			{
				if (loggedinUser == null)
				{
					Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
					return null;
				}
				else
				{
					return loggedinUser;
				}

			}
			set
			{
				loggedinUser = value;
			}
		}

		private static Database database;

		public static Database Database
		{
			get
			{
				if (database == null)
				{
					database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "appdatabase.db3"));
				}

				return database;
			}
		}

		public App()
		{
			InitializeComponent();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
