using System;
using Cadastro;
using Matematica;
using Heranca;
using Selada;
using Abstracao;
using Record;
using Interface;

namespace Classe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var produto = new Produto();
            produto.Descricao = "Teclado";
            Console.WriteLine(produto.Descricao);

            produto.ImprimirDescricao();
            produto.SetId(123);

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());

            Calculos.Somar(2, 2);
            Console.WriteLine(produto.Estoque);

            var pessoaFisica = new PessoaFisica();

            pessoaFisica.Id = 123;
            pessoaFisica.Endereco = "Rua dos Bobos";
            pessoaFisica.Cidade = "SP";
            pessoaFisica.Cep = "00000-000";

            pessoaFisica.ImprimirDados();
            pessoaFisica.Cpf = "123456789-10";
            pessoaFisica.ImprimirCpf();

            var configuracao = new Configuracao()
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);

            var cachorro = new Cachorro();

            cachorro.Nome = "Freddy";
            cachorro.ImprimirDados();

            var gato = new Gato();

            gato.Nome = "Damião";
            gato.ImprimirDados();

            var pessoa1 = new Record.Pessoa("Arthur", 26);
            var pessoa2 = new Record.Pessoa("Arthur", 26);

            /*pessoa1.Nome = "Arthur";
            pessoa1.Idade = 26;

            pessoa2.Nome = "Arthur";
            pessoa2.Idade = 26;*/

            Console.WriteLine(pessoa1 == pessoa2);

            pessoa1.Apresentar();
            pessoa2.Apresentar();

            var notificacaoCliente = new NotificacaoCliente();

            notificacaoCliente.Descricao = "Facebook";
            notificacaoCliente.Notificar();
        }
    }
}