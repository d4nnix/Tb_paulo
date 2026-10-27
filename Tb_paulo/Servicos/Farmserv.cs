using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    internal class Farmserv
    {
        public static List<Farmacia> Espaco { get; set; }
              = new List<Farmacia>()
              {
               new Farmacia(){ Id=1,farmaceutica="Paulo",receita=1,remedios="Bisturi" },
               new Farmacia(){ Id=2,farmaceutica="Apolo",receita=2,remedios= "Pinça" },
               new Farmacia(){ Id=3,farmaceutica="Roberto",receita=3, remedioss= "Afastador de Farabeuf"},
               new Farmacia(){ Id=4,farmaceutica="Pedro",receita=4, remedios= "Porta-agulhas"},
               new Farmacia(){ Id=5,farmaceutica="Julio",receita=5, remedios= "Agulhas cirúrgicas" },
               };
        public static void Listar(string nome
            , int num
            , string ferramenta)
        {
            Sala_emergencia Sala = new Sala_emergencia();
            Sala.Id = Salas.Count > 0 ?
            Salas.Count + 1 : 1;
            Sala.pacientes = nome;
            Sala.salascirurgia = num;
            Sala.ferramentas = ferramenta;
            Salas.Add(Sala);
        }
    }
}
