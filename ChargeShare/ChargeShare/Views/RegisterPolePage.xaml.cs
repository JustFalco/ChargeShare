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
	public partial class RegisterPolePage : ContentPage
	{
		public RegisterPolePage()
		{
			InitializeComponent();
			this.BindingContext = new RegisterPoleViewModel();
		}
	}
}