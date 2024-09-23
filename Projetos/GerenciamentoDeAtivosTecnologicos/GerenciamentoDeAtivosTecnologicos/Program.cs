using System;
using System.Reflection;
using System.Threading;

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
                MenuController.MenuInicial();
                respMenu = int.Parse(Console.ReadLine());

                switch (respMenu)
                {
                    case 1:
                        MenuController.MenuDispositivos();
                        int respNotebook = int.Parse(Console.ReadLine());

                        switch (respNotebook)
                        {
                            case 1:
                                notebook = MenuController.AddNotebook();
                                dispositivosRepositorio.AddNotebook(notebook);
                                break;
                            case 2:
                                Console.Clear();
                                if (notebook == null)
                                {
                                    Console.WriteLine("Nenhum Notebook cadastrado!");
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                } else
                                {
                                    dispositivosRepositorio.ExibirNotebooks();
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                notebook = MenuController.AlterarNotebook();
                                dispositivosRepositorio.AtualizarNotebook(idAlterar, notebook);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                int idRemover = int.Parse(Console.ReadLine());
                                dispositivosRepositorio.DelNotebook(idRemover);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 2:
                        MenuController.MenuDispositivos();
                        int respMonitor = int.Parse(Console.ReadLine());

                        switch (respMonitor)
                        {
                            case 1:
                                monitor = MenuController.AddMonitor();
                                dispositivosRepositorio.AddMonitor(monitor);
                                break;
                            case 2:
                                Console.Clear();
                                if (monitor == null)
                                {
                                    Console.WriteLine("Nenhum Monitor cadastrado!");
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                } else
                                {
                                    dispositivosRepositorio.ExibirMonitores();
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                monitor = MenuController.AlterarMonitor();
                                dispositivosRepositorio.AtualizarMonitor(idAlterar, monitor);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                int idRemover = int.Parse(Console.ReadLine());
                                dispositivosRepositorio.DelMonitor(idRemover);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 3:
                        MenuController.MenuDispositivos();
                        int respImpressora = int.Parse(Console.ReadLine());

                        switch (respImpressora)
                        {
                            case 1:
                                impressora = MenuController.AddImpressora();
                                dispositivosRepositorio.AddImpressora(impressora);
                                break;
                            case 2:
                                Console.Clear();
                                if (impressora == null)
                                {
                                    Console.WriteLine("Nenhuma Impressora cadastrada!");
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                } else
                                {
                                    dispositivosRepositorio.ExibirImpressoras();
                                    Console.WriteLine();
                                    Console.WriteLine("Voltando para o Menu em 5 segundos...");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Id (Alterar): ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                impressora = MenuController.AlterarImpressora();
                                dispositivosRepositorio.AtualizarImpressora(idAlterar, impressora);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Id (Remover): ");
                                int idRemover = int.Parse(Console.ReadLine());
                                dispositivosRepositorio.DelImpressora(idRemover);
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
    }
}