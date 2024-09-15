Console.WriteLine("Estrutura de controle - If");

int hora = 4;

if (hora >= 5 && hora <= 12)
{
    Console.WriteLine("Bom dia!");
} else if (hora >= 13 && hora <= 18)
{
    Console.WriteLine("Boa tarde!");
} else if (hora >= 19 && hora <= 23)
{
    Console.WriteLine("Boa noite!");
} else if (hora >= 0 && hora <= 4)
{
    Console.WriteLine("Boa madrugada!");
} else
{
    Console.WriteLine("Valor inválido!");
}

bool estaChovendo = false;

if (estaChovendo)
{
    Console.WriteLine("Cuidado... está chovendo!");
} else
{
    Console.WriteLine("Não está chovendo!");
}

bool status = true;

if (!status)
{
    Console.WriteLine("Ativo");
} else
{
    Console.WriteLine("Inativo");
}