// TODO 📝 Crie uma classe Pessoa com: Nome Idade

// O código principal continua limpo
var pessoa1 = new Pessoa("Pedro", 23);

Console.WriteLine(pessoa1.Nome);  // Note o 'N' maiúsculo
Console.WriteLine(pessoa1.Idade);
Console.ReadLine();

class Pessoa
{
    // Usando Propriedades (Padrão C#)
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}