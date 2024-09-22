using System;
using System.Reflection;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DispositivosRepositorio dispositivosRepositorio = new DispositivosRepositorio();
            Notebook notebook = null;
            Monitor monitor = null;
            Impressora impressora = null;

            int respMenu = 0;
            do
            {
                Console.Clear();
                MenuInicial();

                respMenu = int.Parse(Console.ReadLine());

                switch (respMenu)
                {
                    case 1:
                        Console.Clear();
                        MenuDispositivos();

                        int respNotebook = int.Parse(Console.ReadLine());

                        switch (respNotebook)
                        {
                            case 1:
                                Console.Clear();
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

                                notebook = new Notebook(id, nome, modelo, anoFabricacao, tipo, processador, memoria, armazenamento, sistemaOperacional);
                                dispositivosRepositorio.AddNotebook(notebook);
                                break;
                            case 2:
                                dispositivosRepositorio.ExibirNotebooks();
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                Console.Write("Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Nome: ");
                                nome = Console.ReadLine();
                                Console.Write("Modelo: ");
                                modelo = Console.ReadLine();
                                Console.Write("Ano de Fabricação: ");
                                anoFabricacao = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                tipo = Console.ReadLine();
                                Console.Write("Processador: ");
                                processador = Console.ReadLine();
                                Console.Write("Memória RAM: ");
                                memoria = Console.ReadLine();
                                Console.Write("Armazenamento: ");
                                armazenamento = Console.ReadLine();
                                Console.Write("Sistema Operacional: ");
                                sistemaOperacional = Console.ReadLine();

                                notebook = new Notebook(id, nome, modelo, anoFabricacao, tipo, processador, memoria, armazenamento, sistemaOperacional);
                                dispositivosRepositorio.AtualizarNotebook(idAlterar, notebook);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                id = int.Parse(Console.ReadLine());

                                dispositivosRepositorio.DelNotebook(id);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        MenuDispositivos();

                        int respMonitor = int.Parse(Console.ReadLine());

                        switch (respMonitor)
                        {
                            case 1:
                                Console.Clear();
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

                                monitor = new Monitor(id, nome, modelo, anoFabricacao, tipo, tamanho, resolucao, taxaAtualizacao, conexoes);
                                dispositivosRepositorio.AddMonitor(monitor);
                                break;
                            case 2:
                                dispositivosRepositorio.ExibirMonitores();
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                Console.Write("Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Nome: ");
                                nome = Console.ReadLine();
                                Console.Write("Modelo: ");
                                modelo = Console.ReadLine();
                                Console.Write("Ano de Fabricação: ");
                                anoFabricacao = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                tipo = Console.ReadLine();
                                Console.Write("Tamanho: ");
                                tamanho = Console.ReadLine();
                                Console.Write("Resolução: ");
                                resolucao = Console.ReadLine();
                                Console.Write("Taxa de Atualização: ");
                                taxaAtualizacao = Console.ReadLine();
                                Console.Write("Conexões: ");
                                conexoes = Console.ReadLine();

                                monitor = new Monitor(id, nome, modelo, anoFabricacao, tipo, tamanho, resolucao, taxaAtualizacao, conexoes);
                                dispositivosRepositorio.AtualizarMonitor(idAlterar, monitor);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                id = int.Parse(Console.ReadLine());

                                dispositivosRepositorio.DelMonitor(id);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        MenuDispositivos();

                        int respImpressora = int.Parse(Console.ReadLine());

                        switch (respImpressora)
                        {
                            case 1:
                                Console.Clear();
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

                                impressora = new Impressora(id, nome, modelo, anoFabricacao, tipo, funcoes, conexoes);
                                dispositivosRepositorio.AddImpressora(impressora);
                                break;
                            case 2:
                                dispositivosRepositorio.ExibirImpressoras();
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                Console.Write("Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Nome: ");
                                nome = Console.ReadLine();
                                Console.Write("Modelo: ");
                                modelo = Console.ReadLine();
                                Console.Write("Ano de Fabricação: ");
                                anoFabricacao = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                tipo = Console.ReadLine();
                                Console.Write("Funções: ");
                                funcoes = Console.ReadLine();
                                Console.Write("Conexões: ");
                                conexoes = Console.ReadLine();

                                dispositivosRepositorio.AtualizarImpressora(idAlterar, impressora);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                id = int.Parse(Console.ReadLine());

                                dispositivosRepositorio.DelImpressora(id);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Programa encerrado!");
                        respMenu = 4;
                        break;
                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }
            } while (respMenu != 4);
        }

        public static void MenuInicial()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Notebook");
            Console.WriteLine("2 - Monitor");
            Console.WriteLine("3 - Impressora");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("---------------------------");
        }

        public static void MenuDispositivos()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Exibir");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("---------------------------");
        }
    }
}