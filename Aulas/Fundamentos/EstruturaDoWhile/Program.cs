Console.WriteLine("Estrutura de controle - Do While");

String controle = "Nao";

do
{
    Console.Write("Deseja continuar (Sim/Nao)? ");
    controle = Console.ReadLine();
} while (controle != "Nao");

Console.WriteLine("Programa finalizado!");