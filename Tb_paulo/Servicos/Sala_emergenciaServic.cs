using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    //int n1 = 10;
    //int n2 = 20;
    //int n3 = 30;
    //string nome = "nome";
    //List<int> var = new List<int>();
    //var.Add(n1);
    //var.Add(n2);
    //var.Add(40);

    //foreach (int i in var)
    //{
    //    Console.WriteLine(i);
    //}
   
    internal class Sala_emergenciaServic
    {

        public static List<Sala_emergencia> Salas { get; set; }
              = new List<Sala_emergencia>()
              {
               new Sala_emergencia(){ Id=1,pacientes="Paulo",salascirurgia=1, ferramentas="Bisturi" },
               new Sala_emergencia(){ Id=2,pacientes="Apolo",salascirurgia=2, ferramentas= "Pinça" },
               new Sala_emergencia(){ Id=3,pacientes="Roberto",salascirurgia=3, ferramentas= "Afastador de Farabeuf"},
               new Sala_emergencia(){ Id=4,pacientes="Pedro",salascirurgia=4, ferramentas= "Porta-agulhas"},
               new Sala_emergencia(){ Id=5,pacientes="Julio",salascirurgia=5, ferramentas= "Agulhas cirúrgicas" },
               };
        public static void Adicionar(string nome
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
        public static void Listar()
        {
           
            foreach (Sala_emergencia item in Salas)
            {
                Console.WriteLine(item.pacientes);
            }
        }
    }
}