Console.WriteLine("Estrutura de dados - Lista Genérica (Collections)");

List<String> lista = new List<String>();
// var lista = new List<String>();

lista.Add("Arthur");
lista.Add("Gustavo");
lista.Add("Gabriel");

foreach (String item in lista)
{
    Console.WriteLine(item);
}

// Console.WriteLine(lista[0]);

lista.RemoveAt(0);

foreach (String item in lista)
{
    Console.WriteLine(item);
}