using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OlshopBaju.Models;

namespace OlshopBaju.ViewModels
{
    class BajuViewModel
    {
        public ObservableCollection<Uniform> uniform { get; set; }
        public ObservableCollection<Market> market { get; set; }
        public ObservableCollection<UniformBar> uniformBar { get; set; }

        public BajuViewModel()
        {
            uniform = new ObservableCollection<Uniform>
            {
                new Uniform
                {
                    Picture = "",
                    Title = "Durian Mon Tong",
                    Price = "$19.99",
                    backColor = "#f5dfba"
                },
                new Uniform
                {
                    Picture = "",
                    Title = "Hawaiian Papaya",
                    Price = "$4.55",
                    backColor = "#ffc599"
                },
                new Uniform
                {
                    Picture = "",
                    Title = "Durian Mon Tong",
                    Price = "$19.99",
                    backColor = "#f5dfba"
                }
            };

            uniformBar = new ObservableCollection<UniformBar>
            {
                new UniformBar
                {
                     Picture  = "Watermelon",
                     Quantity = "+2"
                },
                new UniformBar
                {
                     Picture  = "Strawberry",
                     Quantity = "+10"
                },
                new UniformBar
                {
                     Picture  = "Mango",
                     Quantity = "+4"
                }
            };

            market = new ObservableCollection<Market>
            {
                new Market
                {
                    Picture     = "",
                    Title       = "24/7 Fruit Market",
                    Schedule    = "00:00 - 24:00",
                    Description = "⭐ 4.9 | 📍 3 km"
                },
                new Market
                {
                    Picture     = "",
                    Title       = "Fruit Valley",
                    Schedule    = "04:00 - 21:00",
                    Description = "⭐ 4.9 | 📍 3 km"
                },
                new Market
                {
                    Picture     = "",
                    Title       = "Brooklyn Fruit Valleyg",
                    Schedule    = "09:00 - 21:00",
                    Description = "⭐ 4.9 | 📍 3 km"
                },
            };

        }
    }
}
