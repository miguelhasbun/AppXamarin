using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPokemon : ContentPage
	{
		public MasterPokemon ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            btnend.Clicked += btnSalir_Clicked;
        }
        async void btnSalir_Clicked(object sender, EventArgs e)
        {

            bool answer = await DisplayAlert("ASH", "¿Quiere cerrar su sesión activa?", "Si", "No");
            if (answer)
            {
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }
    }
}