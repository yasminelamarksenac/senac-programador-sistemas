using System;

namespace GestaoRH.Dominio
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
    }
}
