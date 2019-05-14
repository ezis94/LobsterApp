using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using WorkshopApp.Model;

namespace WorkshopApp.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        { }
        private string _username;


        public string username
        {
            get => _username;
            set
            {
                _username = value;
                Changed();
            }
        }

        
        private string _password;


        public string password
        {
            get => _password;
            set
            {
                _password = value;
                Changed();
            }
        }
        private string _result;
        public string result
        {
            get => _result;
            set
            {
                _result = value;
                Changed();
            }
        }
        private ICommand _submitCommand;
        public ICommand SubmitCommand => _submitCommand ?? (_submitCommand = new Command(SubmitLogin)); private async void SubmitLogin(object obj)
        {
            isBusy = true;
            try
            {
               await DependencyService.Get<ILoginService>().SubmitAsync(username, password);
                result = "Success";
            }
            catch(UnauthorizedAccessException e) {
                result = "fail";
            }

            isBusy = false;
        }

       
    }

        
}

