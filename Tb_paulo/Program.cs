// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Triagem
{
    // Dados do paciente
    public string Nome;
    public int Idade;
    public double Temperatura;
    public int Dor; // de 0 a 10

    // Método para fazer a triagem
    public string Classificar()
    {
        if (Temperatura >= 39 || Dor >= 8)
        {
            return "URGENTE";
        }
        else if (Temperatura >= 37.8 || Dor >= 5)
        {
            return "PRIORIDADE";
        }
        else
        {
            return "NORMAL";
        }
    }

    // Método para mostrar os dados
    public void Mostrar()
    {
        Console.WriteLine("----- TRIAGEM DO HOSPITAL -----");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Temperatura: " + Temperatura + " °C");
        Console.WriteLine("Dor: " + Dor + "/10");
        Console.WriteLine("Classificação: " + Classificar());
    }
}

class Program
{
    static void Main()
    {
        Triagem paciente = new Triagem();

        Console.Write("Digite o nome do paciente: ");
        paciente.Nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        paciente.Idade = int.Parse(Console.ReadLine());

        Console.Write("Digite a temperatura: ");
        paciente.Temperatura = double.Parse(Console.ReadLine());

        Console.Write("Digite o nível de dor (0 a 10): ");
        paciente.Dor = int.Parse(Console.ReadLine());

        Console.WriteLine();

        paciente.Mostrar();

        Console.ReadKey();
    }
}
