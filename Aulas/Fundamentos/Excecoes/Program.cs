Console.WriteLine("Exceptions (Exceções)");

while (true)
{
    try
    {
        Console.Write("Digite um número: ");
        var numero = int.Parse(Console.ReadLine());

        var resultado = 500 / numero;

        Console.WriteLine($"Resultado: {resultado}");
    } catch(Exception e)
    {
        Console.WriteLine($"Ocorreu um erro: {e.Message}");
        Console.WriteLine($"Stack: {e.StackTrace}");
    }
}