using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque
{
    public class Produto
    {
        public String Nome { get; set; }
        public String Categoria { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto(String nome, string categoria, int quantidade, double preco)
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Categoria: {this.Categoria}");
            Console.WriteLine($"Quantidade: {this.Quantidade}");
            Console.WriteLine($"Preço: {this.Preco}");
        }
    }
}