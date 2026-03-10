// TODO 📝 Peça nome e idade ao usuário.

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Nome: {nome} ");
Console.WriteLine($"Idade: {idade} ");
Console.ReadLine();