using AppFigGeom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace figuras
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Cuadrado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cuadrado());

        }

        private async void Triangulo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Triangulo());
        }

        private async void Rectangulo_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new Rectangulo());
        }

        private async void Circulo_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Circulo());
        }
    }
}
