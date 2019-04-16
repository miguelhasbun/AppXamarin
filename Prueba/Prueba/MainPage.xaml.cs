using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btnInicioSesion.Clicked += btnInicioSesion_Clicked;
            btnSalir.Clicked += btnSalir_Clicked;
        }
        private void btnInicioSesion_Clicked(object sender, EventArgs e)
        {

            if (txtuser.Text=="ASH" && txtcontra.Text == "PIKACHU")
            {
                ((NavigationPage)this.Parent).PushAsync(new MasterPokemon());
            }
            else
            {
                DisplayAlert("Error", "Usuario y/o contraseña incorrecta", "OK");
            }
        }

        async void btnSalir_Clicked(object sender, EventArgs e)
        {

            bool answer = await DisplayAlert("Advertencia", "¿Quiere salir de la app?", "Si", "No");
            if(answer)
            {
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }
    }
}
