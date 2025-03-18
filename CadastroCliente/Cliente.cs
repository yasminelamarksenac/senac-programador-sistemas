using CadastroDeCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {
        public TipoCliente Tipo { get; set; }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        bool Estrangeiro { get; set; }
        public EnderecoCliente Endereco { get; set; }



        public Cliente(int id, string nome, string dataNascimento, string telefone, string email, bool estrangeiro)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Estrangeiro = estrangeiro;


        }
    }
}

