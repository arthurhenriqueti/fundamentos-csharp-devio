Console.WriteLine("Trabalhando com Arquivos");

var escrever = new StreamWriter("D:\\Cadastro.txt", true);

Console.Write("Informe o nome: ");
var nome = Console.ReadLine();

escrever.WriteLine($"Nome: {nome}");
escrever.WriteLine("---------------------------------------");
escrever.Close();

var conteudo = File.ReadAllText("D:\\Cadastro.txt");

Console.WriteLine(conteudo);

if (File.Exists("D:\\Cadastro.txt"))
{
    File.Delete("D:\\Cadastro.txt");
} else
{
    Console.WriteLine("Arquivo não encontrado!");
}