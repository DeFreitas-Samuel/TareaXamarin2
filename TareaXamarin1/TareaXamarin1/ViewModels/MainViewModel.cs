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
        private string _input_user;
        private string _input_password;

        public string InputUser 
        {
            get { return _input_user; }
            set {

                _input_user = value;
                OnPropertyChanged(nameof(InputUser));
            
            } 
        }
        public string InputPassword
        {
            get { return _input_password; }
            set
            {

                _input_password = value;
                OnPropertyChanged(nameof(InputPassword));

            }
        }

        async private void Login()
        {
            if (string.IsNullOrEmpty(InputPassword) && string.IsNullOrEmpty(InputUser))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your credentials ", "Ok");

            }
            else if (string.IsNullOrEmpty(InputPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your password ", "Ok");
            }
            else if (string.IsNullOrEmpty(InputUser))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your username", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Welcome", $"Hello, {InputUser}", "Ok");
                Application.Current.MainPage = new HomePage();
            }
        }
        private void RegisterPage() 
        {
            Application.Current.MainPage = new SignUpPage();
        }

        public ICommand LoginComand{ get; }
        public ICommand RegisterPageCommand { get; }

        public MainViewModel()
        {
            LoginComand = new Command(Login);
            RegisterPageCommand = new Command(RegisterPage);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
