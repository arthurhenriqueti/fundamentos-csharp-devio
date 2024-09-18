using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        public List<Livro> Livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ExibirLivros()
        {
            foreach (var livro in Livros)
            {
                livro.ExibirDetalhes();
            }
        }
    }
}