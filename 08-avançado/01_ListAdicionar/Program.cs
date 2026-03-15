//TODO 📝 Crie uma List<int> e adicione 5 números.

var numeros = new List<int> { 20,30,40,50,60};
Console.WriteLine("Lista Original:");
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

//TODO 📝 Remova um número da lista.

Console.WriteLine("Removendo 20");
numeros.Remove(20);
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

//TODO 📝 Mostre quantos itens tem na lista.

Console.WriteLine($"Quantidade de itens: {numeros.Count}");

Console.ReadLine();