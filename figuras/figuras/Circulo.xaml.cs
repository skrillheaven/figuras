using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFigGeom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Circulo : ContentPage
    {

        int radio;
        double area;
        public Circulo()
        {
            InitializeComponent();
        }

        

        private void BtnCirculo_Clicked(object sender, EventArgs e)
        {
            radio = int.Parse(input1.Text);

            area = Math.PI * Math.Pow(radio, 2);

            lblResultado.Text = "El area del circulo es: " + area;
        }
    }
}