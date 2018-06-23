using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelos;
using App1.Banco;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        string cpf1;
		public Cadastro (string cpf)
		{
			InitializeComponent ();
            cpf1 = cpf;
		}

        public void cSalvar(object sender, EventArgs args)
        {

            if (ValidaCPF.IsCpf(cpf1))
            {
                Consultas consulta = new Consultas();
                consulta.Telefone = tel.Text;
                consulta.Cpf = cpf1;
                consulta.NomePaciente = NomePac.Text;
                consulta.Cidade = cit.Text;
                consulta.situacao = "Em espera";

                if (consulta.NomePaciente != null)
                {
                    if (consulta.Telefone != null)
                    {
                        if (consulta.Cidade != null)
                        {
                            DisplayAlert("Sucesso!", "Cadastrado!", "OK");
                            AcessoBanco acessobanco = new AcessoBanco();
                            acessobanco.Cadastro(consulta);
                
                            Navigation.PushAsync(new Perfil(cpf1));
                        }
                        else
                        {
                            DisplayAlert("ERRO", "A Cidade está em branco!", "Tentar Novamente");
                        }
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O Telefone está em branco!", "Tentar Novamente");
                    }
                }
                else
                {
                    DisplayAlert("ERRO", "O Nome está em branco!", "Tentar Novamente");
                }
            }
            else
            {
                DisplayAlert("ERRO", "CPF Inválido!", "OK");
            }
        }
    }
}
