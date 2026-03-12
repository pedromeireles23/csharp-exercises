//TODO 📝 Clássico exercício FizzBuzz.
//Escreva um código onde você vai receber um número n, e deve imprimir todos os números até n, com a seguinte condição:
//Se um número for divisível por 3, ao invés de imprimir o número, você deve imprimir Fizz.
//Se um número for divisível por 5, ao invés de imprimir o número, você deve imprmimir Buzz.
//Se um número for divisível por 3 e 5 ao mesmo tempo, você deve imprimir Fizz Buzz.
//Se nenhum dos casos acima for atendido, você deve simplesmente imprimir o número.


Console.WriteLine("FizzBuzz!! Entre com um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz.");
    }else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz.");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz.");
    }
    else
    {
        Console.WriteLine(i);
    }
}



Console.ReadLine();