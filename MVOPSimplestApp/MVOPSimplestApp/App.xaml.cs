using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVOPSimplestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Když se má stát kořenem navigace, musí být NavigationPage
            MainPage = new NavigationPage(new MainPage());
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
