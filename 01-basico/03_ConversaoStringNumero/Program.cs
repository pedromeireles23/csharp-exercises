//TODO Leia um número como string e converta para inteiro.
Console.WriteLine("Digite um número:");
string str = Console.ReadLine();
Console.WriteLine($"O número é string? {str is string}");
int num = Convert.ToInt32(str);
Console.WriteLine("Então converteremos..");
Console.WriteLine($"O número é string? {num is string}");






Console.ReadLine();


