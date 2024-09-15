int controle = 1;

while (controle != 0)
{
    Console.WriteLine("1 - Para converter de Celsius para Fahrenheit");
    Console.WriteLine("2 - Para converter de Fahrenheit para Celsius");
    Console.WriteLine("0 - Sair");
    int resp = int.Parse(Console.ReadLine());

    if (resp == 1)
    {
        CelsiusFahrenheit();
    } else if (resp == 2)
    {
        FahrenheitCelsius();
    } else if (resp == 0)
    {
        Console.WriteLine("Programa encerrado!");
        controle = 0;
    } else
    {
        Console.WriteLine("Opção inválida!");
    }
}

void CelsiusFahrenheit()
{
    Console.Write("Digite a temperatura em Celsius: ");
    int celsius = int.Parse(Console.ReadLine());
    Console.WriteLine($"Temperatura em Fahrenheit: {(celsius * 9 / 5 + 32)}");
}

void FahrenheitCelsius()
{
    Console.Write("Digite a temperatura em Fahrenheit: ");
    int fahrenheit = int.Parse(Console.ReadLine());
    Console.WriteLine($"Temperatura em Celsius: {((fahrenheit - 32) / 1.8)}");
}