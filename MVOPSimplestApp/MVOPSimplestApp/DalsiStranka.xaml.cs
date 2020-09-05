using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVOPSimplestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DalsiStranka : ContentPage
    {
        public DalsiStranka()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}