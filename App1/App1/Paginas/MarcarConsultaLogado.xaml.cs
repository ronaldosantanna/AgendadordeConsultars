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
	public partial class MarcarConsultaLogado : ContentPage
	{
        string cpf1;
		public MarcarConsultaLogado (string cpf)
		{
			InitializeComponent ();
            cpf1 = cpf;
        }
        public void BSALVAR(object sender, EventArgs args)
        {
            AcessoBanco acessoBanco = new AcessoBanco();
            List<Consultas> consultas = acessoBanco.Pesquisar(cpf1);
            Consultas consulta = new Consultas();
            consulta.especialidade = Pick.ToString();
            Navigation.PushAsync(new Perfil(cpf1));
        }
	}
}