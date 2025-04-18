using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.BancoDeDados.Dominio
{
    internal class Estoque
    {
        public int Id { get; set; }
        public int quantidade { get; set; }
        public DateTime DataRegistro { get; set; }
        public int id_Produto { get; set; }
    }
}

