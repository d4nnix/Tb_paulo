using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tb_paulo.Dominio 
{
    public  class Necroterio
    {
        public int Id { get; set; }
        public string nome_cadaver { get; set; }
        public string Capacidadetotal { get; set; }
        public DateTime Data_Falecimento { get; set; }
        public string Email { get; set; }
    }
}
