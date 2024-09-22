using System;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DispositivosRepositorio dispositivosRepositorio = new DispositivosRepositorio();
            Notebook notebook = null;
            Monitor monitor = null;

            int respMenu = 0;
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - Notebook");
                Console.WriteLine("2 - Monitor");
                Console.WriteLine("3 - Impressora");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("---------------------------");

                respMenu = int.Parse(Console.ReadLine());

                switch (respMenu)
                {
                    case 1:
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("1 - Adicionar");
                        Console.WriteLine("2 - Exibir");
                        Console.WriteLine("3 - Atualizar");
                        Console.WriteLine("4 - Remover");
                        Console.WriteLine("---------------------------");

                        int respNotebook = int.Parse(Console.ReadLine());

                        switch (respNotebook)
                        {
                            case 1:
                                notebook = new Notebook(0, "Dell 15 3000", "Inspiron", 2021, "Notebook", "Intel Core i5", "8 GB", "SSD 256 GB", "Windows 10 Home");
                                dispositivosRepositorio.AddNotebook(notebook);
                                break;
                            case 2:
                                dispositivosRepositorio.ExibirNotebooks();
                                break;
                            case 3:
                                notebook = new Notebook(1, "MacBook Pro 13", "A2338", 2020, "Notebook", "Apple M1", "8 GB", "SSD 256 GB", "macOS Big Sur");
                                dispositivosRepositorio.AtualizarNotebook(0, notebook);
                                break;
                            case 4:
                                dispositivosRepositorio.DelNotebook(0);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("1 - Adicionar");
                        Console.WriteLine("2 - Exibir");
                        Console.WriteLine("3 - Atualizar");
                        Console.WriteLine("4 - Remover");
                        Console.WriteLine("---------------------------");

                        int respMonitor = int.Parse(Console.ReadLine());

                        switch (respMonitor)
                        {
                            case 1:
                                monitor = new Monitor(0, "LG UltraWide", "29WN600", 2020, "Monitor", "29P", "2560x1080", "75Hz", "HDMI, DP");
                                dispositivosRepositorio.AddMonitor(monitor);
                                break;
                            case 2:
                                dispositivosRepositorio.ExibirMonitores();
                                break;
                            case 3:
                                monitor = new Monitor(1, "Samsung Odyssey G7", "LC32G7", 2021, "Monitor", "32P", "2560x1440", "240Hz", "HDMI, DP, USB");
                                dispositivosRepositorio.AtualizarMonitor(0, monitor);
                                break;
                            case 4:
                                dispositivosRepositorio.DelMonitor(0);
                                break;
                            default:
                                Console.WriteLine("Valor inválido!");
                                break;
                        }
                        break;
                }
            } while (respMenu != 4);
        }
    }
}