Console.WriteLine("Trabalhando com Strings");

String s1 = "arthur";
Console.WriteLine(s1.ToUpper());

String s2 = "ARTHUR";
Console.WriteLine(s2.ToLower());

String s3 = "Arthur";
Console.WriteLine(s3.Substring(0, 2)); // Inicial, Final

String s4 = "Arthur";
Console.WriteLine(s4.Substring(2)); // Inicial

String s5 = "Hello World";
Console.WriteLine(s5[..5]); // Pegando os 5 primeiros caracteres
Console.WriteLine(s5[^5..]); // Pegando os 5 últimos caracteres

Console.WriteLine(s5.Contains("Hello"));
Console.WriteLine(s5.Contains("Arthur"));

Console.WriteLine(" HELLOWORLD ".Trim());

Console.WriteLine("Hello World".StartsWith("Hello"));
Console.WriteLine("Hello World".EndsWith("World"));

Console.WriteLine("Arthur".Replace("Arthur", "Gustavo"));
Console.WriteLine("Arthur".Replace("A", "X"));

Console.WriteLine("Arthur".Length);