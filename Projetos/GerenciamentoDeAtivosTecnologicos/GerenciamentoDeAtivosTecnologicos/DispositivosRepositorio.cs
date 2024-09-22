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
    }
}