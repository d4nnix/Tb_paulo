using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;
using Tb_paulo.Servicos;

namespace Tb_paulo.Views
{
    class Views_necro
    {
        public static void Adicionar()
        {
            Console.WriteLine("----- Bem vindo ao cadastro de Pessoas -----");
            Console.WriteLine("Precisamos de algumas informações para realizar o cadastro, segue abaixo.");
            Console.WriteLine("Digite seu nome?");
            string nome = Console.ReadLine();
        }
        public static void Listar()
        {
            int count = 1;
            foreach (Necroterio item in NecroService.Necroterios)
            {
                bool primeiraLinha = count == 1;
                ImprimirPessoa(item.Id, item.nome_cadaver, item.Data_Falecimento, item.Email, primeiraLinha);
                count++;
            }

        }
        public static void ImprimirPessoa(int id, string nome, bool ehPrimeiraLinha)
        {
            int largura = 30;

            Console.WriteLine(new string('-', largura + 2));
            if (ehPrimeiraLinha)
            {
                Console.WriteLine("|" +
                    "Listagem de Pessoas".PadLeft(26).PadRight(largura) + "|");

                Console.WriteLine(new string('-', largura + 2));
            }

            Console.WriteLine("|" + $" ID   : {id}".PadRight(largura) + "|");

            Console.WriteLine("|" + $" Nome : {nome}".PadRight(largura) + "|");

            Console.WriteLine(new string('-', largura + 2));
        }
            //char opacao;
            //int Id;
            //string novoNome = "novo", novoEmail = "novo";
            //DateTime novaDatafalecimento = DateTime.Now;
            //RecepcaoService.Listar();
            //NecroService.Listar();
            //Console.WriteLine("Deseja remover alqun falecido?");
            //Console.WriteLine("Caso sim digite (S) caso não digite (N)");
            //opacao = char.Parse(Console.ReadLine());
            //if (opacao == 'S' || opacao == 's')
            //{
            //    Console.WriteLine("Escreva o ID de quem deseja remover");
            //    Id = int.Parse(Console.ReadLine());
            //    NecroService.Remover(Id);
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum ID sera removido");
            //}
            //Console.Clear();
            //Console.WriteLine("Deseja editar alqun informação dos falecidos?");
            //Console.WriteLine("Caso sim digite (S) caso não digite (N)");
            //opacao = char.Parse(Console.ReadLine());
            //if (opacao == 'S' || opacao == 's')
            //{
            //    Console.WriteLine("Escreva o ID de quem deseja Editar em segida digite as novas informaçoes");
            //    Id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Agora digite o nome");
            //    novoNome = Console.ReadLine();
            //    Console.WriteLine("Agora digite o Email");
            //    novoEmail = Console.ReadLine();
            //    NecroService.Editar(Id, novoNome, novoEmail, novaDatafalecimento);
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum ID sera editado");
            //}
            //Console.Clear();
            //Console.WriteLine("Deseja adicionar alqun falecidos?");
            //Console.WriteLine("Caso sim digite (S) caso não digite (N)");
            //opacao = char.Parse(Console.ReadLine());
            //if (opacao == 'S' || opacao == 's')
            //{
            //    Console.WriteLine("Escreva a nova ID em segida digite as novas informaçoes");
            //    Console.WriteLine("Agora digite o nome");
            //    novoNome = Console.ReadLine();
            //    Console.WriteLine("Agora digite o Email");
            //    novoEmail = Console.ReadLine();
            //    NecroService.Adicionar(novoNome, novoEmail, novaDatafalecimento);
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum falecido sera adicionado");
            //}
        }
}
