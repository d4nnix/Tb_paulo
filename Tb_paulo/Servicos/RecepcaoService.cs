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
                new Recepção(){ Id = 1, Paciente="Adam", Consulta="Teste", Especialidade="...", Preco=20 },
                new Recepção(){ Id = 2, Paciente="Miguel", Consulta="Teste", Especialidade="...", Preco=30 },
                new Recepção(){ Id = 3, Paciente="Araujo", Consulta="Teste", Especialidade="...", Preco=40 },
                new Recepção(){ Id = 4, Paciente="Rodrigues", Consulta="Teste", Especialidade="...", Preco=50 },
             };

        public static void Remover(int id)
        {
            Recepção p = Recepção.Find(recepção => recepção.Id == id);
            if (p != null)
            {
                Recepção.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, string novoPaciente, string novaConsulta, string novaEspecialidade, double novoPreco)
        {
            Recepção p = Recepção.Find(recepção => recepção.Id == id);
            if (p != null)
            {
                p.Paciente = novoPaciente;
                p.Consulta = novaConsulta;
                p.Especialidade = novaEspecialidade;
                p.Preco = novoPreco;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }

        public static void Adicionar(int Id, string Paciente
            , string Consulta
            , string Especialidade, double preco)
        {
            Recepção recepção = new Recepção();
            recepção.Id = Id;
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
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Paciente);
                Console.WriteLine("---------------------");
            }
        }
        public static void BuscarPorId(int id)
        {
            // Passo um Id por parametro e o metodo
            // lista as informações detalhadas da pessoa

            Recepção p = Recepção.Find(recepção => recepção.Id == id);
            if (p != null)
            {
                
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
            Listar();
        }
    }
}