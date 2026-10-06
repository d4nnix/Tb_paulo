//// See https://aka.ms/new-console-template for more information
//Console.Write("Hello peoplle ");
//Console.WriteLine("im Verity! Your personal helper friend!");


using Tb_paulo.Servicos;


Console.WriteLine("Paciente: ");
string pacientes = Console.ReadLine();
Console.WriteLine("Sala de cirurgia: ");
int salascirurgia = int.Parse(Console.ReadLine());
Console.WriteLine("A ferramenta a ser utilizada: ");
string ferramentas = Console.ReadLine();

Sala_emergenciaServic.Listar();