Console.WriteLine("Trabalhando com variáveis");

String nome = "Arthur";
int idade = 26;
double salario = 1800.00;
char sexo = 'M';
bool ativo = true;
const double valorPI = 3.14; // Definindo uma constante

// Concatenação
Console.WriteLine("Nome: " + nome + " | Idade: " + idade + " | Salário: " + salario + " | Sexo: " + sexo + " | Ativo: " + ativo);

// Interpolação
Console.WriteLine($"Nome: {nome} | Idade: {idade} | Salário: {salario} | Sexo: {sexo} | Ativo: {ativo}");

// Formatação
Console.WriteLine("Nome: {0} | Idade: {1} | Salário: {2} | Sexo: {3} | Ativo: {4}", nome, idade, salario, sexo, ativo);

Console.WriteLine($"Valor de PI = {valorPI}");