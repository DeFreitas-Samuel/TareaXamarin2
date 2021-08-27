using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TareaXamarin1.Views;
using Xamarin.Forms;

namespace TareaXamarin1.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string _user;
        private string _password;

        public string User 
        {
            get { return _user; }
            set {

                _user = value;
                OnPropertyChanged(nameof(User));
            
            } 
        }
        public string Password
        {
            get { return _password; }
            set
            {

                _password = value;
                OnPropertyChanged(nameof(Password));

            }
        }

        async private void Login()
        {
            if (string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(User))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your credentials ", "Ok");

            }
            else if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your password ", "Ok");
            }
            else if (string.IsNullOrEmpty(User))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your username", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Welcome", $"Hello, {User}", "Ok");
                await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage());
            }
        }
        async private void OnRegister() 
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }

        public ICommand LoginCommand{ get; }
        public ICommand RegisterCommand { get; }

        public MainViewModel()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(OnRegister);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
