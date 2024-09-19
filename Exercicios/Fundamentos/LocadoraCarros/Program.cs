using System;

namespace LocadoraCarros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Locadora locadora = new Locadora();

            Console.Write("Deseja adicionar quantos carro? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Informe o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Informe o Modelo: ");
                String modelo = Console.ReadLine();
                Console.Write("Informe o Ano de Fabricação: ");
                int anoFabricacao = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");

                Carro carro = new Carro(id, nome, modelo, anoFabricacao);

                locadora.AdicionarCarro(carro);
            }

            locadora.ExibirCarros();

            Console.Write("Qual deseja atualizar? ");
            int resp = int.Parse(Console.ReadLine());

            Console.Write("Informe o Id: ");
            int idNovo = int.Parse(Console.ReadLine());
            Console.Write("Informe o Nome: ");
            String nomeNovo = Console.ReadLine();
            Console.Write("Informe o Modelo: ");
            String modeloNovo = Console.ReadLine();
            Console.Write("Informe o Ano de Fabricação: ");
            int anoFabricacaoNova = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            Carro carroNovo = new Carro(idNovo, nomeNovo, modeloNovo, anoFabricacaoNova);

            locadora.AtualizarCarro(resp, carroNovo);

            locadora.ExibirCarros();

            Console.Write("Qual deseja remover? ");
            resp = int.Parse(Console.ReadLine());

            locadora.DeletarCarro(resp);

            locadora.ExibirCarros();
        }
    }
}