Console.WriteLine("Estrutura de controle - While");

String controle = "Sim";

while (controle != "Nao")
{
    Console.Write("Deseja continuar (Sim/Nao)? ");
    controle = Console.ReadLine();
}

Console.WriteLine("Programa finalizado!");