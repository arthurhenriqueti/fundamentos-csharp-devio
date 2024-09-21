Console.WriteLine("Trabalhando com LINQ");

String nomeCompleto = "ARTHUR HENRIQUE DE LUCENA PAIVA";

var resultado = nomeCompleto.Where(p => p == 'A');

foreach (var item in resultado)
{
    Console.WriteLine(item);
}

var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

var novoResultado = numeros.Where(elemento => elemento >= 10);

foreach (var item in novoResultado)
{
    Console.WriteLine(item);
}

var arrayOrganizado = numeros.OrderBy(p => p); // Ordem crescente
// var arrayOrganizado = numeros.OrderByDescending(p => p); // Ordem decrescente

foreach (var item in arrayOrganizado)
{
    Console.WriteLine(item);
}

var arrayCortado = numeros.Take(3);

foreach (var item in arrayCortado)
{
    Console.WriteLine(item);
}

var arrayCount = numeros.Count(p => p > 10);

Console.WriteLine(arrayCount);

var arrayFirst = numeros.First(p => p > 15);
var arrayFirstOrDefault = numeros.FirstOrDefault(p => p > 15, 0);

Console.WriteLine(arrayFirst);
Console.WriteLine(arrayFirstOrDefault);