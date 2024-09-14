Console.WriteLine("Estrutura de dados - Dicionário (Collections)");

var dicionario = new Dictionary<int, String>(); // int: chave, string: valor (key, value)

dicionario.Add(1, "Arthur");
dicionario.Add(5, "Gustavo");
dicionario.Add(100, "Kalina");

dicionario[50] = "Josevaldo";

var nome = dicionario[50];

dicionario.Remove(50);

foreach (var item in dicionario)
{
    Console.WriteLine(item);
}

dicionario.Clear();

foreach (var item in dicionario)
{
    Console.WriteLine(item);
    // Console.WriteLine(item.Key);
    // Console.WriteLine(item.Value);
}

Console.WriteLine(nome);