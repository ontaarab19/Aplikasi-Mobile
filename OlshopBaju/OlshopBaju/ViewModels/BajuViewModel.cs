using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OlshopBaju.Models;

namespace OlshopBaju.ViewModels
{
    public class BajuViewModel
    {
        public ObservableCollection<Uniform> Outfit { get; set; }
        public ObservableCollection<Market> market { get; set; }
        public ObservableCollection<UniformBar> uniformBar { get; set; }

        public BajuViewModel()
        {
            Outfit = new ObservableCollection<Uniform>
            {
                new Uniform
                {
                    FotoOutfit = "Uniform01.png",
                    NamaOutfit = "Deep Sea Blue",
                    Harga = "$19.99",
                    backColor = Color.Blue
                },
                new Uniform
                {
                    FotoOutfit = "baju2.jpeg",
                    NamaOutfit = "Hawaiian Papaya",
                    Harga = "$4.55",
                    backColor = Color.Pink
                },
                new Uniform
                {
                    FotoOutfit = "baju3.jpeg",
                    NamaOutfit = "Baju apa ini?",
                    Harga = "$19.99",
                    backColor = Color.Aqua
                },
                new Uniform
                {
                    FotoOutfit = "Uniform01.png", 
                    NamaOutfit = "Baju apa ini?", 
                    Harga = "$19.99",
                    backColor = Color.Beige
                }
            };

            uniformBar = new ObservableCollection<UniformBar>
            {
                new UniformBar
                {
                     Picture  = "",
                     Quantity = "+2"
                },
                new UniformBar
                {
                     Picture  = "",
                     Quantity = "+10"
                },
                new UniformBar
                {
                     Picture  = "",
                     Quantity = "+4"
                }
            };

            market = new ObservableCollection<Market>
            {
                new Market
                {
                    Picture     = "tokyo.jpg",
                    Title       = "Cyberpunk 2077",
                    Schedule    = "20:00 - 24:00",
                    Description = "⭐ 4.0 | 📍 2 km"
                },
                new Market
                {
                    Picture     = "aesthetic.jpg",
                    Title       = "Aesthetic Spirit",
                    Schedule    = "08:00 - 21:00",
                    Description = "⭐ 4.9 | 📍 2.5 km"
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
