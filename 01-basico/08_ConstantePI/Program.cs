// TODO 📝 Crie uma constante PI e calcule a área de um círculo.
const double PI = 3.14;
Console.WriteLine("Digite o raio do círculo:");
double raio = double.Parse(Console.ReadLine());
//double area = PI * (raio * raio);
double area = Math.Round(Math.PI * Math.Pow(raio, 2),2);
Console.WriteLine($"A área do círculo é: {area}");
Console.ReadLine();