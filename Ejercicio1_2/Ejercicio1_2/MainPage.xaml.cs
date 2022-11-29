using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.informacion
            {
                nombre = txtnombre.Text,
                apellidos = txtapellidos.Text,
                edad = Convert.ToInt32(txttedad.Text),
                correo = txtcorreo.Text
            };
            var page = new Views.Page2();
            page.BindingContext = emple;
            await Navigation.PushAsync(page);
        }
    }
}
