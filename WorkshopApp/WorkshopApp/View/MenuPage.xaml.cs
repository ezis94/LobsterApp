using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkshopApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : BasePage<MenuViewModel>
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}