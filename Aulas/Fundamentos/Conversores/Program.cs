Console.WriteLine("Conversores");

// Casting
byte v1 = 10; // Conversão implícita
short v2 = v1;

int v3 = 10;
double v4 = v3;

short v5 = 10; // Conversão explícita
byte v6 = (byte) v5;

double v7 = 10.0;
int v8 = (int) v7;

// Convert/Parse

int v9 = int.Parse("1"); // String -> Números
Console.WriteLine(v9 + v9);

int v10 = Convert.ToInt32("123");

bool v11 = true;
String v12 = Convert.ToString(v11);

Console.WriteLine($"O valor é {v12}");

// TryParse

String n1 = "123";

if (int.TryParse(n1, out int n2))
{
    Console.WriteLine("Convertido!");
} else
{
    Console.WriteLine("Não Convertido!");
}

Console.WriteLine($"Novo valor: {n2}");