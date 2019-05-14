using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WorkshopApp.ViewModel;
using System.ComponentModel;

namespace WorkshopApp.View
{
	public partial class LoginPage: BasePage<LoginViewModel>
    {
		public LoginPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lobster.RotateTo(360, 3000, Easing.BounceOut);
            Lobster.FadeTo(1, 3000,Easing.Linear);
            Lobster.ScaleTo(1.5, 3000, Easing.Linear);
        }
        protected override void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.ViewModel_PropertyChanged(sender, e);
            if (e.PropertyName == nameof(ViewModel.result) && ViewModel.result == "Success")
                Application.Current.MainPage = new RootPage
                {
                    Detail = new NavigationPage(new ProductPage()),
                    Master = new MenuPage()
                };
                
        }

    }
}