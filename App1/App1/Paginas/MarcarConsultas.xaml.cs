using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelos;
using App1.Banco;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MarcarConsultas : ContentPage
	{
		public MarcarConsultas ()
		{
			InitializeComponent ();
		}
        public void Cadastro(object sender, EventArgs args)
        {
            
        }
        public void Entrar(object sender, EventArgs args)
        {
            if (ValidaCPF.IsCpf(Cpf.Text))
            {
                string cpf;
                cpf = Regex.Replace(Cpf.Text, @"[^\d]", "");
                AcessoBanco acessoBanco = new AcessoBanco();
                List<Consultas> consultas = acessoBanco.Pesquisar(cpf);

                if (consultas.Any())
                {
                    Navigation.PushAsync(new Perfil(cpf));
                }
                else
                {
                    Navigation.PushAsync(new Cadastro(cpf));
                }

            }
            else
            {
                DisplayAlert("ERRO", "CPF Inválido!", "OK");
            }
        }
    }
}