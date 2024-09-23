using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public static class MenuController
    {
        public static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Notebook");
            Console.WriteLine("2 - Monitor");
            Console.WriteLine("3 - Impressora");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("---------------------------");
        }

        public static void MenuDispositivos()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Exibir");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("---------------------------");
        }

        public static Notebook AddNotebook()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Processador: ");
            String processador = Console.ReadLine();
            Console.Write("Memória RAM: ");
            String memoria = Console.ReadLine();
            Console.Write("Armazenamento: ");
            String armazenamento = Console.ReadLine();
            Console.Write("Sistema Operacional: ");
            String sistemaOperacional = Console.ReadLine();

            Notebook notebook = new Notebook(id, nome, modelo, anoFabricacao, tipo, processador, memoria, armazenamento, sistemaOperacional);

            return notebook;
        }

        public static Notebook AlterarNotebook()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Processador: ");
            String processador = Console.ReadLine();
            Console.Write("Memória RAM: ");
            String memoria = Console.ReadLine();
            Console.Write("Armazenamento: ");
            String armazenamento = Console.ReadLine();
            Console.Write("Sistema Operacional: ");
            String sistemaOperacional = Console.ReadLine();

            Notebook notebook = new Notebook(id, nome, modelo, anoFabricacao, tipo, processador, memoria, armazenamento, sistemaOperacional);

            return notebook;
        }

        public static Monitor AddMonitor()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Tamanho: ");
            String tamanho = Console.ReadLine();
            Console.Write("Resolução: ");
            String resolucao = Console.ReadLine();
            Console.Write("Taxa de Atualização: ");
            String taxaAtualizacao = Console.ReadLine();
            Console.Write("Conexões: ");
            String conexoes = Console.ReadLine();

            Monitor monitor = new Monitor(id, nome, modelo, anoFabricacao, tipo, tamanho, resolucao, taxaAtualizacao, conexoes);

            return monitor;
        }

        public static Monitor AlterarMonitor()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Tamanho: ");
            String tamanho = Console.ReadLine();
            Console.Write("Resolução: ");
            String resolucao = Console.ReadLine();
            Console.Write("Taxa de Atualização: ");
            String taxaAtualizacao = Console.ReadLine();
            Console.Write("Conexões: ");
            String conexoes = Console.ReadLine();

            Monitor monitor = new Monitor(id, nome, modelo, anoFabricacao, tipo, tamanho, resolucao, taxaAtualizacao, conexoes);

            return monitor;
        }

        public static Impressora AddImpressora()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Funções: ");
            String funcoes = Console.ReadLine();
            Console.Write("Conexões: ");
            String conexoes = Console.ReadLine();

            Impressora impressora = new Impressora(id, nome, modelo, anoFabricacao, tipo, funcoes, conexoes);

            return impressora;
        }

        public static Impressora AlterarImpressora()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano de Fabricação: ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            String tipo = Console.ReadLine();
            Console.Write("Funções: ");
            String funcoes = Console.ReadLine();
            Console.Write("Conexões: ");
            String conexoes = Console.ReadLine();

            Impressora impressora = new Impressora(id, nome, modelo, anoFabricacao, tipo, funcoes, conexoes);

            return impressora;
        }
    }
}