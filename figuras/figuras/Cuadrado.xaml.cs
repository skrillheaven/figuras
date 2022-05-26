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
    public partial class Cuadrado : ContentPage
    {

        int l;
        double resultado;
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void BtnCuadrado_Clicked(object sender, EventArgs e)
        {
            l = int.Parse(input1.Text);
            resultado = Math.Pow(l, 2);

            lblResultado.Text = "El area es: "+resultado + "";



        }
    }
}