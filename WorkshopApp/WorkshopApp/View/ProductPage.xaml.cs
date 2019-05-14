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
	public partial class ProductPage : BasePage<ProductViewModel>
    {
		public ProductPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            Stack.FadeTo(1, 5000, Easing.Linear);
        }
    }
}