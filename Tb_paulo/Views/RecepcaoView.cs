using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Servicos;

namespace Tb_paulo.Views
{
    internal class RecepcaoView
    {
        public static void IniciarSistema()
        {
            Console.WriteLine("====RECEPÇÃO====");
            Console.WriteLine("Bem-Vindo ao ");
            Console.WriteLine("Você deseja mexer em qual função?");
            Console.WriteLine("1- Listar");
            Console.WriteLine("2- Editar");
            Console.WriteLine("3- Remover");
            Console.WriteLine("4- Buscar por Id");

            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                RecepcaoService.Listar();
            }
            else if (opcao == 2)
            {
                RecepcaoService.Editar();
            }
            else if (opcao == 3)
            {
                RecepcaoService.Remover();
            }
            else if (opcao == 3)
            {
                RecepcaoService.BuscarPorId();
            }
          }
        }
    }
