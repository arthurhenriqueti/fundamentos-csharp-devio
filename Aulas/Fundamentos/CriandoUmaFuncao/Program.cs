Console.WriteLine("Criando uma função");

void BoasVindas()
{
    Console.WriteLine("Seja Bem-Vindo!");
}

BoasVindas();

String NomeCompleto()
{
    String primeiroNome = "Arthur";
    String segundoNome = "Henrique";
    return primeiroNome + " " + segundoNome;
}

String nomeCompleto = NomeCompleto();
Console.WriteLine(NomeCompleto());

Console.WriteLine(nomeCompleto);

void Escrever()
{
    BoasVindas();
    String nomeCompleto = NomeCompleto();
    Console.WriteLine(nomeCompleto);
}

Escrever();

int valor1 = 10;
int valor2 = 20;

int SomaValores(int valor1, int valor2)
{
    return valor1 + valor2;
}

int resultado = SomaValores(valor1, valor2);

Console.WriteLine($"A soma dos valores é de {resultado}");

String nome = "Arthur Henrique";

void MeuNome(String nome)
{
    Console.WriteLine($"Meu nome é {nome}");
}

MeuNome(nome);

String novoNome = "Arthur Henrique";
int idade = 26;
double salario = 1800.00;
char sexo = 'M';
bool status = true;

String MeusDados(String nome, int idade, double salario, char sexo, bool status)
{
    return "Nome: " + nome + " | Idade: " + idade + " | Salário: " + salario + " | Sexo: " + sexo + " | Status: " + status;
}

String info = MeusDados(novoNome, idade, salario, sexo, status);

Console.WriteLine(info);