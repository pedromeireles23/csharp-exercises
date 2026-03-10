//TODO 📝 Verifique se uma pessoa é maior de idade.

Console.WriteLine("Entre com sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade < 18 && idade >= 0) {
    Console.WriteLine("Menor de idade");

}
else if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Idade inválida");
}

Console.ReadLine();