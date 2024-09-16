using System;

namespace Cadastro
{
    public class Produto
    {
        private int Id;
        public String Descricao { get; set; }
        public int Estoque { get; } // public readonly int Estoque

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(this.GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public int GetId()
        {
            return this.Id;
        }
    }
}

namespace Matematica
{
    public static class Calculos
    {
        public static void Somar(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }
}

namespace Heranca
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Cep {  get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Endereco);
            Console.WriteLine(this.Cidade);
            Console.WriteLine(this.Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public String Cpf { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine(Cpf);
        }
    }
}

namespace Selada
{
    public sealed class Configuracao
    {
        public String Host { get; set; }
    }
}

namespace Abstracao
{
    public abstract class Animal
    {
        public String Nome { get; set; }

        public abstract String GetInfo();

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome animal: {this.Nome}");
            Console.WriteLine($"Informações: {this.GetInfo()}");
        }
    }

    public class Cachorro : Animal
    {
        public override String GetInfo()
        {
            return "Cachorro é um bom amigo!";
        }
    }

    public class Gato : Animal
    {
        public override String GetInfo()
        {
            return "Gato é um animal estranho!";
        }
    }
}

namespace Record
{
    public record Pessoa(String Nome, int Idade)
    {
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {this.Nome} | Idade: {this.Idade}");
        }
    }
}

namespace Interface
{
    public interface INotificacao
    {
        public String Descricao { get; set; }

        public void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine(this.Descricao);
        }
    }
}