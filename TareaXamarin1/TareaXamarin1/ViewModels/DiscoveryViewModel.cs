using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TareaXamarin1.Models;

namespace TareaXamarin1.ViewModels
{
    class DiscoveryViewModel
    {


        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodMenuOption { get; set; } = new MenuOption();
        
        public DiscoveryViewModel()
        {
            BarAndHotelsMenuOption.Title = "Bars & Hotels";
            BarAndHotelsMenuOption.Image = "bars";
            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "fine_dining";
            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "cafes";
            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "nearby";
            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "fast_food";
            FeaturedFoodMenuOption.Title = "Featured Food";
            FeaturedFoodMenuOption.Image = "featured_food";
        }

        

    }
}
