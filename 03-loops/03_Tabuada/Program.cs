// TODO 📝 Mostre a tabuada de um número.

Console.WriteLine("Tabuada do 05");

int numero = 5;

for (int i = 1; i <= 10; i++)
{
    int tabuada = numero * i;
    Console.WriteLine($"{numero} x {i} = {tabuada}");
}

Console.ReadLine();