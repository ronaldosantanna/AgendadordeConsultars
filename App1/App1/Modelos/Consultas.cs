using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Modelos
{
    [Table("Consultas")]
    public class Consultas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public string Cidade { get; set; }
        public string Horario { get; set; }
        public string Exames { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Data { get; set; }
        public string especialidade{ get; set; }
        public string situacao { get; set; }
        public string exame { get; set; }
    }
}
