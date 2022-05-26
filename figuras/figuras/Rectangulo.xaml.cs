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
    public partial class Rectangulo : ContentPage
    {

        int base1;
        int altura;
        double area;
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void BtnRectangulo_Clicked(object sender, EventArgs e)
        {

            base1 = int.Parse(input1.Text);
            altura = int.Parse(input2.Text);

            area = (base1 * altura);

            lblResultado.Text = "El area del rectangulo es: " + area;

        }
    }
}