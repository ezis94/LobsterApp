using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkshopApp.View
{
	public  class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
	{
        protected TViewModel ViewModel
        {
            get;
        }
		public BasePage ()
		{
            Visual = VisualMarker.Material;
            ViewModel = new TViewModel();
            BindingContext = ViewModel;
        }
        protected virtual void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e) { }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.PropertyChanged -= ViewModel_PropertyChanged;
        }
    }
}