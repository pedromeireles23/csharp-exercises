Console.WriteLine("Comparação de números -----");
Console.WriteLine("Entre com o primeiro número: ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entre com o segundo número");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

if (primeiroNumero > segundoNumero)
{
    Console.WriteLine($"O número maior é {primeiroNumero}");

}
else if (primeiroNumero < segundoNumero)
{
    Console.WriteLine($"O número maior é {segundoNumero}");
}
else
{
    Console.WriteLine("Os números são iguais");
}

    Console.ReadLine();