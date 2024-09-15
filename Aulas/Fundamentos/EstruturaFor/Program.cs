Console.WriteLine("Estrutura de controle - For");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

List<String> list = new List<String>();

list.Add("Arthur");
list.Add("Gustavo");
list.Add("Kalina");
list.Add("Josevaldo");

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

foreach (String item in list)
{
    Console.WriteLine(item);
}