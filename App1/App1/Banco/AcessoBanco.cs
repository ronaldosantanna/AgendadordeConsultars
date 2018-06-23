using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using App1.Modelos;
using System.Linq;

namespace App1.Banco
{
    class AcessoBanco
    {
        private SQLiteConnection _conexao;

        public AcessoBanco()
        {
            var dep = DependencyService.Get<Icaminho>();
            string caminho = dep.GetCaminho("AcessoBanco.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Consultas>();
        }

        public List<Consultas> Consultar()
        {
            
            return _conexao.Table<Consultas>().ToList();
        }

        public List<Consultas> Pesquisar(string palavra)
        {

            return _conexao.Table<Consultas>().Where(a=>a.Cpf.Contains(palavra)).ToList();
        }
        
        public Consultas ObterVagaPorID(int id)
        {
            return _conexao.Table<Consultas>().Where(a=>a.Id == id).FirstOrDefault();
        }
        
        public void Atualizacao(Consultas consulta)
        {
            _conexao.Update(consulta);
        }

        public void Cadastro(Consultas consulta)
        {
            _conexao.Insert(consulta);
        }

        public void Exclusao(Consultas consulta)
        {
            _conexao.Delete(consulta);
        }
    }
}
