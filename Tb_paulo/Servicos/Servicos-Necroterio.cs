using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    public static class PessoaService
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
            , DateTime data_nascimento)
        {
            Necroterio pessoa = new Necroterio();
            pessoa.Id = Necroterios.Count > 0 ?
                Necroterios.Count + 1 : 1;
            pessoa.nome_cadaver = nome;
            pessoa.Email = email;
            pessoa.Data_Falecimento = data_nascimento;
            Necroterios.Add(pessoa);
        }
        public static void Listar()
        {
            foreach (Necroterio item in Necroterios)
            {
                Console.WriteLine(item.nome_cadaver);
            }
        }
    }
}
