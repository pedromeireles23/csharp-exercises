//TODO Faça soma, subtração, multiplicação e divisão.

bool continuar = true;

do
{
    Console.Clear();  
    Console.WriteLine("Entre com o número da operação que deseja fazer:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    int escolhaUsuario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Entre com o primeiro número:");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entre com o segundo número:");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int soma = numero1 + numero2;
    int subtracao = numero1 - numero2;
    int multiplicacao = numero1 * numero2;
    float divisao = (float) numero1 / numero2;


    switch (escolhaUsuario)
    {
        case 1:
            Console.WriteLine($"O resultado da soma dos números é {soma}");
            break;
        case 2:
            Console.WriteLine($"O resultado da subtração dos números é {subtracao}");
            break;
        case 3:
            Console.WriteLine($"O resultado da Multiplicação dos números é {multiplicacao}");
            break;
        case 4:
            if (numero2 == 0 )
            {
                Console.WriteLine("Não é possível dividir por 0");
            }
            else
            {

            Console.WriteLine($"O resultado da divisão dos números é {divisao}");
            }
            break;
        default:
            Console.WriteLine("Entre com o valor de 1 a 4");
            break;
    }
        Console.WriteLine("Deseja fazer outra operação? (s/n)");
        string resposta = Console.ReadLine().ToLower();
        if (resposta == "n")
        {
            continuar = false;
        }

} while (continuar);

Console.WriteLine("Programa encerrado");
Console.ReadLine();