//TODO 📝 Junte nome e sobrenome.

Console.WriteLine("Nome Completo: " + "João" + " Silva");


//TODO 📝 Use string interpolation.

string name = "Pedro";
string surname = "Meireles";
Console.WriteLine($"Nome Completo: {name} {surname}");

//TODO 📝 Use string.Format.

double price = 19.99323;
string formattedPrice = string.Format("Preço: {0:C2}", price);
//Formata o preço para a moeda local com 2 casas decimais.
Console.WriteLine(formattedPrice);
string formattedPrice2 = string.Format("Preço: {0:F2}", price);
Console.WriteLine(formattedPrice2);
//Formata para duas casas decimais


//TODO 📝 Mostre uma string ao contrário.

char[] arrNome = name.ToCharArray();
Array.Reverse(arrNome);
Console.WriteLine(arrNome.GetType());
string inverter = new string(arrNome);
Console.WriteLine(inverter.GetType());

//TODO 📝 Use String.IsNullOrEmpty.
string? numeroNulo = null;
Console.WriteLine($"String é vazia ou nula: {string.IsNullOrEmpty(name)}");
Console.WriteLine($"String é vazia ou nula: {string.IsNullOrEmpty("")}");
Console.WriteLine($"String é vazia ou nula: {string.IsNullOrEmpty(numeroNulo)}");
//TODO 📝 Use String.Concat.

string[] palavaras = { "Olá", " ", "Mundo", "!" };
string frase = string.Concat(palavaras);
Console.WriteLine(frase);
Console.WriteLine(frase.GetType());
Console.ReadLine();