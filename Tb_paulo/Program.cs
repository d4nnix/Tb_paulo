using Tb_paulo.Servicos;

Console.WriteLine("Paciente: ");
string Paciente = Console.ReadLine();

Console.WriteLine("Consulta: ");
string Consulta = Console.ReadLine();

Console.WriteLine("Especialidade: ");
string Especialidade = Console.ReadLine();

Console.WriteLine("Preçp: ");
string preco = Console.ReadLine();

RecepcaoService.Listar();