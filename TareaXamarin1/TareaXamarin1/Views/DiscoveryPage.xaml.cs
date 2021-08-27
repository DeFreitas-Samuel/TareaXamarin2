using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaXamarin1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaXamarin1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeliveryPage : ContentPage
    {
        public DeliveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryViewModel();
        }
    }
}