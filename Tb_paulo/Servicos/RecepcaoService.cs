using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    internal class RecepcaoService
    {
        public static List<Recepção> Recepção { get; set; }
            = new List<Recepção>()
            {
                new Recepção(){ Paciente="Adam", Consulta=" ", Especialidade="emfermeiro", Preco=50 },
             };
        public static void Adicionar(string Paciente
            , string Consulta
            , string Especialidade, double preco)
        {
            Recepção recepção = new Recepção();
            recepção.Paciente = Paciente;
            recepção.Consulta = Consulta;
            recepção.Especialidade = Especialidade;
            recepção.Preco = preco;
            Recepção.Add(recepção);
        }
        public static void Listar()
        {
            foreach (Recepção item in Recepção)
            {
                Console.WriteLine(item.Paciente);
            }
        }
    }
}