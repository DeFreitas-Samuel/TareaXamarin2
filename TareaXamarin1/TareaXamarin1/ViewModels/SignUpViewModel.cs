using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TareaXamarin1.Views;
using Xamarin.Forms;

namespace TareaXamarin1.ViewModels
{
    class SignUpViewModel : INotifyPropertyChanged
    {
        private string _user;
        private string _email;
        private string _password;
        private string _repeatedPassword;

        public string User
        {
            get { return _user; }
            set
            {

                _user = value;
                OnPropertyChanged(nameof(User));

            }
        }
        public string Email
        {
            get { return _email; }
            set
            {

                _email = value;
                OnPropertyChanged(nameof(Email));

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
        public string RepeatedPassword
        {
            get { return _repeatedPassword; }
            set
            {

                _repeatedPassword = value;
                OnPropertyChanged(nameof(RepeatedPassword));

            }
        }


        async private void Register()
        {
            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(RepeatedPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill all the fields", "Ok");
            }
            else if (!string.Equals(Password, RepeatedPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "The passwords don't match ", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Welcome", $"Hello, {User}", "Ok");
                await Application.Current.MainPage.Navigation.PushModalAsync(new HomePage());
            }
        }

        public ICommand RegisterCommand { get; }

        public SignUpViewModel()
        {
            RegisterCommand = new Command(Register);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
