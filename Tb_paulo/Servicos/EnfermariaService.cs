using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    class EnfermariaService
    {
        public static List<Enfermaria> enfermarias { get; set; } = new List<Enfermaria>() { 
           
                new Enfermaria(){ id=1,pacientes="Joaquim pereira",leitos= 22, prontuários = "acompanhado"},
                 new Enfermaria(){ id=2,pacientes="ana luiza",leitos= 23, prontuários = "nao registrado"},
                  new Enfermaria(){ id=3,pacientes="Gustavo eduardo",leitos= 24, prontuários = " em observacao medica"},
                   new Enfermaria(){ id=4,pacientes="Maria da conceicao evaristo",leitos= 25, prontuários = "em andamentos "},
                    new Enfermaria(){ id=5,pacientes="Eloiza figueiro",leitos= 26, prontuários = "aferido sinais vitais ,coleta de exames"},
            };
        public static void Adicionar(string pacientes
            , int leitos  , string prontuarios)
            
        {
            Enfermaria nome = new Enfermaria();
            nome.id = enfermarias.Count > 0 ?
                 enfermarias.Count + 1 : 1;

            nome.pacientes = pacientes;
            nome.leitos = leitos;
            nome.prontuários = prontuarios;
            enfermarias.Add(nome);
            Listar();
        }
        public static void Listar()
        {
            foreach (Enfermaria item in enfermarias)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.pacientes);
                Console.WriteLine(item.leitos);
                Console.WriteLine(item.prontuários);
                Console.WriteLine("---------------------");
            }
        }
        public static void Remover(int id)
        {
            Enfermaria p = enfermarias.Find(pacientes => pacientes.id == id);
            if (p != null)
            {
                enfermarias.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
    }  public static void Editar(int id, string novoNome, string novoleito, string novoprontuário)
        {
            Enfermaria p = enfermarias.Find(pacientes => pacientes.id == id);
            if (p != null)
            {
               p.nome pacientes = novoNome;
                p.id = id;
               

                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
    }

