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
	public partial class MinhasConsultas : ContentPage
	{
        string CPF1;
        public MinhasConsultas (string cpf)
		{
            CPF1 = cpf;
			InitializeComponent ();  
        }
        public void MaisDetalhe(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;

            Consultas consulta = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Consultas;

            Navigation.PushAsync(new Detalhes(consulta));
        }
        public void Cancelar(object sender, EventArgs args)
        {
            Label Cancelar = (Label)sender;
          
            Consultas consulta = ((TapGestureRecognizer)Cancelar.GestureRecognizers[0]).CommandParameter as Consultas;
           
            AcessoBanco banco = new AcessoBanco();
            banco.Exclusao(consulta);
            Navigation.PushAsync(new MinhasConsultas(CPF1));
        }
        public void Cbusca(object sender, EventArgs args)
        {
            if (CPF1 != null)
            {
                AcessoBanco acessoBanco = new AcessoBanco();
                List<Consultas> consultas = acessoBanco.Pesquisar(CPF1);

                if (consultas.Any())
                {
                    AcessoBanco banco = new AcessoBanco();
                    ListaVagas.ItemsSource = banco.Pesquisar(CPF1);
                }
                else
                {
                    DisplayAlert("Não Cadastrado!", "Sem consultas.", "Tentar novamente");
                }
            }
            else if (ValidaCPF.IsCpf(CPF.Text))
            {
                string cpf;
                cpf = Regex.Replace(CPF.Text, @"[^\d]", "");
                
                AcessoBanco acessoBanco = new AcessoBanco();
                List<Consultas> consultas = acessoBanco.Pesquisar(cpf);

                if (consultas.Any())
                {
                    AcessoBanco banco = new AcessoBanco();
                    ListaVagas.ItemsSource = banco.Pesquisar(cpf);
                }
                else
                {
                    DisplayAlert("Não Cadastrado!", "Entrada mal sucedida!", "Tentar novamente");
                }
            }
            else
            {
                DisplayAlert("ERRO", "CPF Inválido!", "OK");
                
            }
        }
        
        public void GoConsultas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasConsultas(null));
        }
    }
    
}