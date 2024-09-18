using System;

namespace Biblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro()
            {
                Titulo = "1984",
                Autor = "George Orwell",
                AnoPublicacao = 1949,
                Genero = "Distopia"
            };

            Livro livro2 = new Livro()
            {
                Titulo = "O Senhor dos Anéis",
                Autor = "J.R.R. Tolkein",
                AnoPublicacao = 1954,
                Genero = "Fantasia"
            };

            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);

            biblioteca.ExibirLivros();
        }
    }
}