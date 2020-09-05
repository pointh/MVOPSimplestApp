using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVOPSimplestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    // Forms previewer je dost k ničemu
    // Ale XAML Reload je výborné
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Ukončování aplikace není něco, co se od mobilního prg očekává
            // Pokud chce uživatel odejít, má nato v GUI jiné prostředky (kolečko, šipka vlevo)
            // Application.Current.Quit();
            // this.Navigation.PopAsync();
        }

        private void Button_Clicked_DalsiStrana(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new DalsiStranka());
        }
    }
}
