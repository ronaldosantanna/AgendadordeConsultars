using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Modelos;
using App1.Banco;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarcarExames : ContentPage
    {
        public MarcarExames()
        {
            InitializeComponent();
        }

        private void Bmarcar(object sender, EventArgs args)
        {
            if (ValidaCPF.IsCpf(Cpf.Text))
            {
                DisplayAlert("Cadastrado!", "Cadastrado!", "OK");

                Consultas consulta = new Consultas();
                consulta.Telefone = Telefone.Text;
                consulta.Cpf = Cpf.Text;
                consulta.NomePaciente = Name.Text;
                consulta.situacao = "Em espera";
                consulta.exame = Pick.ToString();

                AcessoBanco acessobanco = new AcessoBanco();
                acessobanco.Cadastro(consulta);

                Navigation.PushAsync(new MinhasConsultas(null));
            }
            else
            {
                DisplayAlert("ERRO", "CPF Inválido!", "OK");
            }
        }

    }
}