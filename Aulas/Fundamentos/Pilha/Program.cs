Console.WriteLine("Estrutura de dados - Pilha (Collections)");
// LIFO (Last In, First Out)

var pilha = new Stack<String>();

pilha.Push("Arthur"); // Add
pilha.Push("Gustavo");
pilha.Push("Kalina");
pilha.Push("Josevaldo");

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop(); // Remove

foreach (var item in pilha)
{
    Console.WriteLine(item);
}