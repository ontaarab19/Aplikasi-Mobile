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
        public ObservableCollection<UniformBar> Bar { get; set; }

        public BajuViewModel()
        {
            Outfit = new ObservableCollection<Uniform>
            {
                new Uniform
                {
                    FotoOutfit = "outfit1.png",
                    NamaOutfit = "Purple Dress",
                    Harga = "$19.99",
                    backColor = Color.Lavender
                },
                new Uniform
                {
                    FotoOutfit = "outfit2.png",
                    NamaOutfit = "Stylish Skirt",
                    Harga = "$20.55",
                    backColor = Color.LightSkyBlue
                },
                new Uniform
                {
                    FotoOutfit = "outfit3.png",
                    NamaOutfit = "Casual Outfit",
                    Harga = "$19.99",
                    backColor = Color.LightPink
                },
                new Uniform
                {
                    FotoOutfit = "outfit4.png", 
                    NamaOutfit = "Nice Casual Outfit", 
                    Harga = "$19.99",
                    backColor = Color.LightGray
                }
            };

            Bar = new ObservableCollection<UniformBar>
            {
                new UniformBar
                {
                     barPic  = "baju.png",
                     Quantity = "+15"
                },
                new UniformBar
                {
                     barPic  = "celana.png",
                     Quantity = "+10"
                },
                new UniformBar
                {
                     barPic  = "topi.png",
                     Quantity = "+1"
                }
            };

            market = new ObservableCollection<Market>
            {
                new Market
                {
                    Picture     = "market2.png",
                    Title       = "Cyberpunk 2077",
                    Schedule    = "20:00 - 24:00",
                    Description = "⭐ 4.0 | 📍 2 km"
                },
                new Market
                {
                    Picture     = "market1.png",
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
