using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
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
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor introduzca sus credenciales ", "Ok");

            }
            else if (string.IsNullOrEmpty(InputPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor introduzca su contrasena ", "Ok");
            }
            else if (string.IsNullOrEmpty(InputUser))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor introduzca su nombre de usuario ", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido", $"Hola, {InputUser}", "Ok");
            }
        }

        public ICommand LoginComand{ get; }

        public MainViewModel()
        {
            LoginComand = new Command(Login);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
