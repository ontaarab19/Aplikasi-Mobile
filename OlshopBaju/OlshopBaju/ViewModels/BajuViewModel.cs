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
                    NamaOutfit = "Vintage Outfit",
                    Harga = "$18.11",
                    backColor = Color.Lavender
                },
                new Uniform
                {
                    FotoOutfit = "outfit5.png",
                    NamaOutfit = "Layering Outfit",
                    Harga = "$14.99",
                    backColor = Color.LightGreen
                },
                new Uniform
                {
                    FotoOutfit = "outfit2.png",
                    NamaOutfit = "Monochrome Outfit",
                    Harga = "$14.99",
                    backColor = Color.LightSkyBlue
                },
                new Uniform
                {
                    FotoOutfit = "outfit6.png", 
                    NamaOutfit = "Retro Outfit", 
                    Harga = "$29.99",
                    backColor = Color.WhiteSmoke
                },
                new Uniform
                {
                    FotoOutfit = "outfit4.png",
                    NamaOutfit = "Classy Outfit",
                    Harga = "$20.55",
                    backColor = Color.LightGray
                }
            };

            Bar = new ObservableCollection<UniformBar>
            {
                new UniformBar
                {
                     barPic  = "ikonbaju.png",
                     Quantity = "+15"
                },
                new UniformBar
                {
                     barPic  = "ikoncelana.png",
                     Quantity = "+10"
                },
                new UniformBar
                {
                     barPic  = "ikonkemeja.png",
                     Quantity = "+8"
                },
                new UniformBar
                {
                     barPic  = "ikonrok.png",
                     Quantity = "+7"
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
                    Title       = "Aesthetic Unishop",
                    Schedule    = "08:00 - 21:00",
                    Description = "⭐ 4.9 | 📍 2.5 km"
                },
                new Market
                {
                    Picture     = "market3.png",
                    Title       = "Tokyo Outfit",
                    Schedule    = "00:00 - 24:00",
                    Description = "⭐ 4.5 | 📍 4 km"
                },
            };

        }
    }
}
