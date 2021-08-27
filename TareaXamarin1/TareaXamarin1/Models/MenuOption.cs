using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TareaXamarin1.Models
{
    public class MenuOption : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
