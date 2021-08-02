using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OlshopBaju
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.UnishopPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
