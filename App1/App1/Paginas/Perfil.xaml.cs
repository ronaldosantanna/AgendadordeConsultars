using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Banco;
using App1.Modelos;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfil : ContentPage
	{
        string cpf1;
		public Perfil (string cpf)
		{
			InitializeComponent ();
            cpf1 = cpf;
            AcessoBanco banco = new AcessoBanco();
            ListaVagas.ItemsSource = banco.Pesquisar(cpf);
        }


        private void Mconsultas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MarcarConsultaLogado(cpf1));
        }
        private void Mexames(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MarcarExames());
        }
        private void Vconsultas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasConsultas(cpf1));
        }
    }
}