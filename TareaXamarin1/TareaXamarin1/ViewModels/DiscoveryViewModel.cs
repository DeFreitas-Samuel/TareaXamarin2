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
            BarAndHotelsMenuOption.Places = "42 places";
            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "fine_dining";
            FineDiningMenuOption.Places = "15 places";
            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "cafes";
            CafesMenuOption.Places = "28 places";
            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "nearby";
            NearbyMenuOption.Places = "34 places";
            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "fast_food";
            FastFoodsMenuOption.Places = "29 places";
            FeaturedFoodMenuOption.Title = "Featured Food";
            FeaturedFoodMenuOption.Image = "featured_food";
            FeaturedFoodMenuOption.Places = "21 places";
        }

        

    }
}
