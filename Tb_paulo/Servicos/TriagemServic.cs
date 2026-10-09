using System;
using System.Collections.Generic;
using Tb_paulo.Dominio;

namespace Tb_paulo.Servicos
{
    public static class TriagemService
    {
        public static List<Triagem> Triagens { get; set; }
            = new List<Triagem>()
            {
                new Triagem(){ Id=1, NomePaciente="Carlos Silva", Temperatura=36, Sintomas="Febre leve" },
                new Triagem(){ Id=2, NomePaciente="Maria Oliveira", Temperatura=38, Sintomas="Dor de cabeça" },
                new Triagem(){ Id=3, NomePaciente="João Souza", Temperatura=37, Sintomas="Enjoo" },
                new Triagem(){ Id=4, NomePaciente="Ana Costa", Temperatura=36, Sintomas="Dor na perna" },
                new Triagem(){ Id=5, NomePaciente="Pedro Santos", Temperatura=39, Sintomas="Falta de ar" }
            };

        public static void Adicionar(string nome
            , int temperatura
            , string sintomas)
        {
            Triagem triagem = new Triagem();
            triagem.Id = Triagens.Count > 0 ?
                Triagens.Count + 1 : 1;
            triagem.NomePaciente = nome;
            triagem.Temperatura = temperatura;
            triagem.Sintomas = sintomas;

            Triagens.Add(triagem);
        }

        public static void Listar()
        {
            foreach (Triagem item in Triagens)
            {
                Console.WriteLine(item.NomePaciente);
            }
        }
    }
}