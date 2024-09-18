using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public String Titulo;
        public String Autor;
        public int AnoPublicacao;
        public String Genero;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {this.Titulo}");
            Console.WriteLine($"Autor: {this.Autor}");
            Console.WriteLine($"Ano de Publicação: {this.AnoPublicacao}");
            Console.WriteLine($"Gênero: {this.Genero}");
        }
    }
}