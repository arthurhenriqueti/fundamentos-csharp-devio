using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class DispositivosRepositorio
    {
        List<Notebook> notebooks = new List<Notebook>();
        List<Monitor> monitores = new List<Monitor>();

        // Notebook

        public void AddNotebook(Notebook notebook)
        {
            notebooks.Add(notebook);
        }

        public void ExibirNotebooks()
        {
            foreach (Notebook item in notebooks)
            {
                item.ExibirInfoNotebook();
            }
        }

        public void AtualizarNotebook(int indice, Notebook notebook)
        {
            notebooks[indice] = notebook;
        }

        public void DelNotebook(int indice)
        {
            notebooks.RemoveAt(indice);
        }

        // Monitor

        public void AddMonitor(Monitor monitor)
        {
            monitores.Add(monitor);
        }

        public void ExibirMonitores()
        {
            foreach (Monitor item in monitores)
            {
                item.ExibirInfoMonitor();
            }
        }

        public void AtualizarMonitor(int indice, Monitor monitor)
        {
            monitores[indice] = monitor;
        }

        public void DelMonitor(int indice)
        {
            monitores.RemoveAt(indice);
        }
    }
}