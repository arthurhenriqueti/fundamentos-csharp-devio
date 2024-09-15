int controle = 1;
List<String> alunos = new List<String>();

while (controle != 0)
{
    Console.WriteLine("------------------");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Exibir");
    Console.WriteLine("3 - Atualizar");
    Console.WriteLine("4 - Deletar");
    Console.WriteLine("5 - Limpar");
    Console.WriteLine("6 - Sair");
    Console.WriteLine("------------------");

    int resp = int.Parse(Console.ReadLine());

    if (resp == 1)
    {
        AddAluno(alunos);
    } else if (resp == 2)
    {
        ExibirAlunos(alunos);
    } else if (resp == 3)
    {
        AtualizarAluno(alunos);
    } else if (resp == 4)
    {
        DelAluno(alunos);
    } else if (resp == 5)
    {
        alunos.Clear();
    }
    else if (resp == 6)
    {
        Console.WriteLine("Programa encerrado!");
        controle = 0;
    }
}

void AddAluno(List<String> alunos)
{
    Console.Write("Digite o nome do aluno: ");
    String resp = Console.ReadLine();
    alunos.Add(resp);
}

void ExibirAlunos(List<String> alunos)
{
    int i = 0;
    foreach (String aluno in alunos)
    {
        Console.WriteLine($"{i} - {aluno}");
        i++;
    }
}

void AtualizarAluno(List<String> alunos)
{
    Console.Write("Digite o número referente ao aluno que deseja alterar: ");
    int resp = int.Parse(Console.ReadLine());
    Console.Write("Digite o novo nome: ");
    alunos[resp] = Console.ReadLine();
}

void DelAluno(List<String> alunos)
{
    Console.Write("Digite o número referente ao aluno que deseja deletar: ");
    int resp = int.Parse(Console.ReadLine());
    alunos.RemoveAt(resp);
}