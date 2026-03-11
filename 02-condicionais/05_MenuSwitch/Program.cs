//TODO 📝 Crie um menu usando switch.

Console.WriteLine("1 - Cadastrar");
Console.WriteLine("2 - Listar");
Console.WriteLine("3 - Sair");
int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case 1:
        Console.WriteLine("Cadastrar selecionado");
        break;
    case 2:
        Console.WriteLine("Listando dados...");
        break;
    case 3:
        Console.WriteLine("Saindo...");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

Console.ReadLine();