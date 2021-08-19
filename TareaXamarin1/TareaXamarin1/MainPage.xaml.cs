using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaXamarin1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entry.Text))
            {
                await DisplayAlert("Error", "Por favor introduzca su nombre de usuario ", "Ok");
            }
            else if(string.IsNullOrEmpty(entryContrasena.Text))
            {
                await DisplayAlert("Error", "Por favor introduzca su contrasena ", "Ok");
            }
            else if (string.IsNullOrEmpty(entryContrasena.Text) && string.IsNullOrEmpty(entry.Text))
            {
                await DisplayAlert("Error", "Por favor introduzca sus credenciales ", "Ok");
            }
            else {
                await DisplayAlert("Bienvenido", "Hola, " + entry.Text, "Ok");
            }
        }
    }
}
