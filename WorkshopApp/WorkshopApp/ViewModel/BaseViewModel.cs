using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System;
using System.Runtime.CompilerServices;

namespace WorkshopApp.ViewModel
{
   public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel(){}
        protected void Changed([CallerMemberName]string propertyName = "")
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private bool _isBusy;
        public bool isBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                Changed();
            }
        }
    }
}
