using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelos;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaInicial : ContentPage
	{
		public PaginaInicial ()
		{
			InitializeComponent ();
		}

        public void GoConsultas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MarcarConsultas());
        }
        public void GoVConsultas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasConsultas(null));
        }
        public void GoExames(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MarcarExames());
        }
        public void GoSobre(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Sobre());
        }
    }
}