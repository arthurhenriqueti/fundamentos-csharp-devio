Console.WriteLine("Estrutura de dados - Fila (Collections)");
// FIFO (First In, First Out)

var fila = new Queue<String>();

fila.Enqueue("Arthur"); // Add
fila.Enqueue("Gustavo");

foreach (var item in fila)
{
    Console.WriteLine(item);
}

var nome = fila.Peek();

Console.WriteLine(nome);

var nome1 = fila.Dequeue(); // Remove

foreach (var item in fila)
{
    Console.WriteLine(item);
}