using System;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DispositivosRepositorio dispositivosRepositorio = new DispositivosRepositorio();

            Notebook notebook = new Notebook(0, "Dell", "Inspiron", 2021, "Notebook", "Intel Core i5", "8 GB", "SSD 256 GB", "Windows 10 Home");
            Notebook notebook1 = new Notebook(1, "MacBook", "A2338", 2020, "Notebook", "Apple M1", "8 GB", "SSD 256 GB", "macOS Big Sur");

            dispositivosRepositorio.AddNotebook(notebook);
            dispositivosRepositorio.AddNotebook(notebook1);
            dispositivosRepositorio.ExibirNotebooks();
            
        }
    }
}