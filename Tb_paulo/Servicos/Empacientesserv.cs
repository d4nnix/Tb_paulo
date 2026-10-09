using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    internal class Empacientesserv
    {
        public static List<EPacientes> grupos { get; set; }
         = new List<EPacientes>()
         {
               new EPacientes(){ Id=1,pacientes="Paulo",Email ="sshfb@gmail.com",salascirurgia=1},
               new EPacientes(){ Id=2,pacientes="Apolo",Email ="Hunter@gmail.com",salascirurgia=2},
               new EPacientes(){ Id=3,pacientes="Roberto",Email ="Robet45@gmail.com",salascirurgia=3},
               new EPacientes(){ Id=4,pacientes="Pedro",Email ="Pedr32@gmail.com",salascirurgia=4},
         };

        public static void Adicionar(string nome
            , string email
            , int nsala
            , DateTime data_nascimento)
        {
            EPacientes pessoa = new EPacientes();
            pessoa.Id = grupos.Count > 0 ?
           grupos.Count + 1 : 1;
            pessoa.pacientes = nome;
            pessoa.Email = email;
            pessoa.salascirurgia = nsala;
            grupos.Add(pessoa);
            Listar();
        }
        public static void Listar()
        {

            foreach (EPacientes item in grupos)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.pacientes);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.salascirurgia);
                Console.WriteLine("---------------------");
            }
        }



        public static void Remover(int id)
        {
            EPacientes p = grupos.Find(pessoas => pessoas.Id == id);
            if (p != null)
            {
                grupos.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, string nvpacientes, string novoEmail, int numSala)
        {
            EPacientes p = grupos.Find(pessoas => pessoas.Id == id);
            if (p != null)
            {
                p.pacientes = nvpacientes;
                p.Email = novoEmail;
                p.salascirurgia = numSala;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void BuscarPorId(int id)
        {
            EPacientes p = grupos.Find(pesssoa => pesssoa.Id == id);
            if (p != null)
            {
                grupos.Add(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Id não encontrado.");
            }
        }
    
    }
}
