using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;
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
            Console.WriteLine("2- Adicionar");

            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                RecepcaoService.Listar();
            }
            else if (opcao == 2)
            {
               void Adicionar(int Id, string Paciente
             , string Consulta
             , string Especialidade, double Preco)
                {
                    Recepção recepção = new Recepção();
                    recepção.Id = Id;
                    recepção.Paciente = Paciente;
                    recepção.Consulta = Consulta;
                    recepção.Especialidade = Especialidade;
                    recepção.Preco = Preco;
                }
            }
          }
       }
   }
