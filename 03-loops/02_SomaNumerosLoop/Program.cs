// TODO 📝 Some números de 1 a 5.

int[] numeros = {1, 2, 3, 4, 5 };
int somaNumeros = 0;

for (int i = 0; i < numeros.Length; i++)
{
    somaNumeros += numeros[i];   
}

Console.WriteLine(somaNumeros);

Console.ReadLine();