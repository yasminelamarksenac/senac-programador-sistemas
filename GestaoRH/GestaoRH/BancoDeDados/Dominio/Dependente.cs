using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDeDados.Dominio
{

        namespace GestaoRH.dominio
    {
        public class Dependente
        {
            public int Id { get; set; }
            public int FuncionarioId { get; set; }
            public string NomeCompleto { get; set; }
            public string CPF { get; set; }
            public string RG { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Genero { get; set; }
            public string Parentesco { get; set; }
        }
    }

}

