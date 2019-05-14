using System;
using System.Collections.Generic;
using System.Text;
using WorkshopApp.Model;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using WorkshopApp.Model.Contract;

namespace WorkshopApp.ViewModel
{
    public class ProductViewModel: BaseViewModel
    {
        private ICommand _getJokeCommand;
        public ICommand getJokeCommand => _getJokeCommand ?? (_getJokeCommand = new Command(GetJokeAsync));
        private Joke _joke;
        public Joke Joke
        {
            get => _joke;
            set
            {
                _joke = value;
                Changed();
            }
        }
        private async void GetJokeAsync()
        {
            try
            {
                isBusy = true;
                var chuckService = DependencyService.Get<IChuckService>();
                Joke = await chuckService.GetRandomJokeAsync();
                isBusy = false;
            }
            catch (Exception e)
            {

            }
        }
        public ProductViewModel()
        {
            
        }
        
    }
    
}
