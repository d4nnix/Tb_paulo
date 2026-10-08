using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    public static class NecroService
    {
        public static List<Necroterio> Necroterios { get; set; }
            = new List<Necroterio>()
            {
                new Necroterio(){ Id=1,nome_cadaver="Jonat",Email="Josaf@gmail.com", Data_Falecimento=DateTime.Now },
                new Necroterio(){ Id=2,nome_cadaver="Ana",Email="jode@gmail.com", Data_Falecimento=DateTime.Now },
                new Necroterio(){ Id=3,nome_cadaver="Raimundo",Email="paula@gmail.com", Data_Falecimento=DateTime.Now },
                new Necroterio(){ Id=4,nome_cadaver="Fulano2",Email="paulo@gmail.com", Data_Falecimento=DateTime.Now },
                new Necroterio(){ Id=5,nome_cadaver="Fulano3",Email="paulo@gmail.com", Data_Falecimento=DateTime.Now },
             };
        public static void Adicionar(string nome
            , string email
            , DateTime data_falecimento)
        {
            Necroterio pessoa = new Necroterio();
            pessoa.Id = Necroterios.Count > 0 ?
                Necroterios.Count + 1 : 1;
            pessoa.nome_cadaver = nome;
            pessoa.Email = email;
            pessoa.Data_Falecimento = data_falecimento;
            Necroterios.Add(pessoa);
        }
        public static void Listar()
        {
            foreach (Necroterio item in Necroterios)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.nome_cadaver);
                Console.WriteLine("---------------------");
            }
        }
        public static void Remover(int id)
        {
            Necroterio p = Necroterios.Find(pessoa => pessoa.Id == id);
            if (p != null)
            {
                Necroterios.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, string novoNome, string novoEmail, DateTime novaDatafalecimento)
        {
            Necroterio p = Necroterios.Find(pessoa => pessoa.Id == id);
            if (p != null)
            {
                p.nome_cadaver = novoNome;
                p.Email = novoEmail;
                p.Data_Falecimento = novaDatafalecimento;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void BuscarPorId(int id, string nome_cadaver, string Email, DateTime Data_Falecimento)
        {
            Necroterio p = Necroterios.Find(pessoa => pessoa.Id == id);
            Necroterio NC = Necroterios.Find(pessoa => pessoa.nome_cadaver == nome_cadaver);
            Necroterio email = Necroterios.Find(pessoa => pessoa.Email == Email);
            Necroterio DF = Necroterios.Find(pessoa => pessoa.Data_Falecimento == Data_Falecimento);
            if (p != null && NC != null && email != null && DF != null)
            {
                Necroterios.Add(p);
                Necroterios.Add(NC);
                Necroterios.Add(email);
                Necroterios.Add(DF);
                Listar();
            }
            else
            {
                Console.WriteLine("alguma informaçao nao foi registrada");
            }
        }
    }
}
