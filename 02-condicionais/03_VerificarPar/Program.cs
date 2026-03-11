// TODO 📝 Verifique se um número é par ou ímpar.
Console.WriteLine("Entre com um número");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}

Console.ReadLine();