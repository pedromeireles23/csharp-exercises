//TODO Classifique uma nota:
//= 7 aprovado
//= 5 recuperação
//< 5 reprovado

Console.WriteLine("Digite a nota: ");
double nota = Convert.ToDouble(Console.ReadLine());

if(nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

Console.ReadLine();