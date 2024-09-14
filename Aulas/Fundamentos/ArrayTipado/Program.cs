Console.WriteLine("Estrutura de dados - Array Tipado (Collections)");

var arrayTipadoNumero = new int[3] { 1, 2, 3 };
// int[] arrayTipadoNumero = new int[3] { 1, 2, 3 };

arrayTipadoNumero[2] = 10;

foreach (int item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

var arrayTipadoNomes = new String[3];

arrayTipadoNomes[0] = "A";
arrayTipadoNomes[1] = "B";
arrayTipadoNomes[2] = "C";

Array.Resize(ref arrayTipadoNomes, 4);

arrayTipadoNomes[3] = "D";

foreach (String item in arrayTipadoNomes)
{
    Console.WriteLine(item);
}