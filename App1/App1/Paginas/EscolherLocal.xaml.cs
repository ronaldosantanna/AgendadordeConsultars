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
	public partial class EscolherLocal : ContentPage
	{
		public EscolherLocal ()
		{
			InitializeComponent ();
		}
        public void MaisDetalhe(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer TapGes = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Consultas consulta = TapGes.CommandParameter as Consultas;

            Navigation.PushAsync(new Detalhes(consulta));
        }
    }
}