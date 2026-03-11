// TODO 📝 Verifique se um número é positivo ou negativo.
Console.WriteLine("Digite um número:");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0)
{
    Console.WriteLine("O número é negativo");
}
else if(num == 0)
{
    Console.WriteLine("O número é zero");
}
else
{
    Console.WriteLine("O número é positivo");
}

Console.ReadLine();
