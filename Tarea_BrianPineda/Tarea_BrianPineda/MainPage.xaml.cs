using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea_BrianPineda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {

            double resultado, a,b;

            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);
            resultado = a + b;

            var operaciones = new Models.Operacionesbasicas
            {
                resultado = resultado,
               
                
        };
            
            var page = new Views.Page2();
            page.BindingContext= operaciones;
            await Navigation.PushAsync(page);

        }
    
        private async void btnrestar_Clicked(object sender, EventArgs e)
            {
            double resultado, a, b;

            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);
            resultado = a - b;

            var operaciones = new Models.Operacionesbasicas
            {
                resultado = resultado,


            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);
     
    }

            private async void btnmultiplicar_Clicked(object sender, EventArgs e)
            {
            double resultado, a, b;

            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);
            resultado = a * b;

            var operaciones = new Models.Operacionesbasicas
            {
                resultado = resultado,


            };

            var page = new Views.Page2();
            page.BindingContext = operaciones;
            await Navigation.PushAsync(page);

        }

        private async void btndividir_Clicked(object sender, EventArgs e)
            { double resultado, a, b;

            a = Convert.ToDouble(txtnumero1.Text);
                b = Convert.ToDouble(txtnumero2.Text);
                resultado = a / b;

                var operaciones = new Models.Operacionesbasicas
                {
                    resultado = resultado,


                };

            var page = new Views.Page2();
            page.BindingContext= operaciones;
                await Navigation.PushAsync(page);

        }
    }
}
