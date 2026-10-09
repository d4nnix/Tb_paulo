using System;

namespace Tb_paulo.Dominio
{
    public class Triagem
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public int Temperatura { get; set; }
        public string Sintomas { get; set; }
    }
}