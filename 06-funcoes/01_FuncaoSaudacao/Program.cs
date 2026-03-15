// TODO 📝 Crie uma função void que imprime uma saudação.

void Saudacao(string mensagem)
{
    Console.WriteLine(mensagem);
}

Saudacao("Olá, bem-vindo ao sistema!");


// TODO 📝 Crie uma função que recebe dois números e retorna a soma.

int Soma(int a, int b)
{
    return a + b;
}

Console.WriteLine(Soma(5,2));

//TODO 📝 Crie uma função que calcule a área de um triângulo.

double AreaTriangulo(double baseTriangulo, double altura)
{
    return (baseTriangulo * altura) / 2;
}
Console.WriteLine(AreaTriangulo(5,10));

//TODO 📝 Some os números de um array usando função.

int[] arr = {1, 2, 3, 4, 5 };

int SomaArray(int[] numbers)
{
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum;
}
Console.WriteLine(SomaArray(arr));
Console.ReadLine();