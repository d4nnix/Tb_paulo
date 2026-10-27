using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tb_paulo.Dominio
{
    internal class Recepção
    {
        public int Id { get; set; }
        public string Paciente { get; set; }

        public string Consulta { get; set; }

        public string Especialidade { get; set; }

        public double Preco { get; set; }
    }
}
