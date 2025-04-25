using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDeDados.Dominio
{

        namespace GestaoRH.dominio
    {
        public class Endereco
        {
            public int Id { get; set; }
            public int FuncionarioId { get; set; } // FK para o funcionário
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
        }
    }

}

