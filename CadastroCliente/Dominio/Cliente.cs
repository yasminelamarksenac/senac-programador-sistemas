using CadastroDeCliente;
using System;

namespace CadastroCliente
{
    internal class Cliente
    {
        // Atributos/Propriedades
        public TipoCliente Tipo { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NomeSocial { get; set; }
        public GeneroCliente Genero { get; set; }
        public bool Estrangeiro { get; set; }  
        public EnderecoCliente EnderecoCliente { get; set; }
        public EtniaCliente Etnia { get; set; }
    }
}








    


