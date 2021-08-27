using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TareaXamarin1.Models;

namespace TareaXamarin1.ViewModels
{
    class DiscoveryViewModel : INotifyPropertyChanged
    {


        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public DiscoveryViewModel()
        {
            BarAndHotelsMenuOption.Title = "Bars &amp; Hotels";
            BarAndHotelsMenuOption.Image = "bars";
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
