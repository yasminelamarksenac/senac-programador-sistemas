using GestaoRH.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDeDados.Dominio
{
   
    
        namespace GestaoRH.dominio
    {
        public class Funcionario
        {
            public int Id { get; set; }
            public string NomeCompleto { get; set; }
            public string CPF { get; set; }
            public string RG { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Genero { get; set; }
            public string EstadoCivil { get; set; }

            public Endereco Endereco { get; set; }
            public Funcao Funcao { get; set; }
            public List<Dependente> Dependentes { get; set; }
        }
    }

}

