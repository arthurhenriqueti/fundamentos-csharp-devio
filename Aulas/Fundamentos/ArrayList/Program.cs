using System.Collections;

Console.WriteLine("Estrutura de dados - ArrayList (Collections)");

ArrayList arrayList = new ArrayList(); // Criando um objeto do tipo ArrayList
// var arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add("Arthur");
arrayList.Add(true);

/*
Console.WriteLine(arrayList[0]);
Console.WriteLine(arrayList[1]);
Console.WriteLine(arrayList[2]);
*/

arrayList.RemoveAt(0);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

arrayList.Clear(); // Limpando todo o ArrayList