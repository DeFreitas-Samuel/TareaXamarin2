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
        private string _input_user;
        private string _input_email;
        private string _input_password;
        private string _input_repeated_password;

        public string InputUser
        {
            get { return _input_user; }
            set
            {

                _input_user = value;
                OnPropertyChanged(nameof(InputUser));

            }
        }
        public string InputEmail
        {
            get { return _input_email; }
            set
            {

                _input_email = value;
                OnPropertyChanged(nameof(InputEmail));

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
        public string InputRepeatedPassword
        {
            get { return _input_repeated_password; }
            set
            {

                _input_repeated_password = value;
                OnPropertyChanged(nameof(InputRepeatedPassword));

            }
        }


        async private void Register()
        {
            if (string.IsNullOrEmpty(InputPassword) || string.IsNullOrEmpty(InputUser) || string.IsNullOrEmpty(InputEmail) || string.IsNullOrEmpty(InputRepeatedPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor llene todos los campos", "Ok");
            }
            else if (!string.Equals(InputPassword, InputRepeatedPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden ", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido", $"Hola, {InputUser}", "Ok");
                Application.Current.MainPage = new HomePage();
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
